Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spListadoDestruccion
    Private filtroFechaInicial As String
    Private filtroFechafinal As String
    Private filtroTipoMovimiento As String
    Private filtroArticulo As String

#Region "constructor y propiedades"
    Public Sub New()

    End Sub

    Public Property fecha_inicial As String
        Get
            Return Me.filtroFechaInicial
        End Get
        Set(value As String)
            Me.filtroFechaInicial = value
        End Set
    End Property

    Public Property fecha_final As String
        Get
            Return Me.filtroFechafinal
        End Get
        Set(value As String)
            Me.filtroFechafinal = value
        End Set
    End Property

    Public Property articulo As String
        Get
            Return Me.filtroArticulo
        End Get
        Set(value As String)
            Me.filtroArticulo = value
        End Set
    End Property

    Public Property tipo_movimiento As String
        Get
            Return Me.filtroTipoMovimiento
        End Get
        Set(value As String)
            Me.filtroTipoMovimiento = value
        End Set
    End Property

#End Region

    Public Sub cargar_cbo_tiposMovimientos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PaletsMovimientosTipos1CboNoEntrePalets", False, dtb)
    End Sub

    Public Sub cargar_cbo_articulos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposFormatosSelectCbo", False, dtb)
    End Sub



    Public Sub dgvFill(ByRef dgv As DataGridView, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Dim query As String = Me.crearConsulta

        Dim dt As DataTable = dtb.Consultar(query, False)

        If Not dt Is Nothing Then
            With dgv
                .DataSource = dt
                .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            End With
        End If
    End Sub

    Private Function crearConsulta() As String


        crearConsulta = "select Fecha,SCC,Cajas, Comentarios,PaletsMovimientoSubTipo.descripcion as Subtipo, Articulo " & _
                       "from paletsmovimiento,paletsproducidos,formatosenvasados, articulosEnvasadosHistorico, PaletsMovimientosTipos left join PaletsMovimientoSubTipo on paletsMovimientosTipos.PaletMovimientoTipoID = PaletsMovimientoSubTipo.tipo " & _
                       "where paletsmovimiento.paletid = paletsproducidos.paletproducidoid " & _
                       "and paletsproducidos.formatoid = formatosenvasados.formatoenvasadoid " & _
                       "and formatosenvasados.tipoformatoenvasadoid = tipoformato " & _
                       "and paletsmovimiento.tipo = PaletsMovimientosTipos.paletMovimientotipoID "

        Dim c As New Collection
        If Me.filtroArticulo <> String.Empty Then c.Add(" paletid in (select paletproducidoid from paletsproducidos where formatoid in(select formatoEnvasadoId from formatosenvasados where tipoFormatoEnvasadoid = " & Me.filtroArticulo & "))")
        If Me.filtroTipoMovimiento <> String.Empty Then c.Add(" paletmovimientotipoID=" & Me.filtroTipoMovimiento)
        If Me.filtroFechaInicial <> String.Empty Then c.Add(" fecha>=convert(varchar,'" & Me.fecha_inicial & "', 111)")
        If Me.filtroFechafinal <> String.Empty Then c.Add(" fecha<=convert(varchar,'" & Me.fecha_final & "', 111)")

        Dim cont As Integer = 1
        While cont <= c.Count

            crearConsulta &= " and " & c.Item(cont)
            cont += 1
        End While

        'select * from paletsmovimiento where paletid in (select paletproducidoid from paletsproducidos where formatoid in(select formatoEnvasadoId from formatosenvasados where tipoFormatoEnvasadoid in (select sccetiquetaid from articulosenvasesterciarios)))
    End Function
End Class
