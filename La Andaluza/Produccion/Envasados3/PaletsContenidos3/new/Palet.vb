Public Class Palet
    Public Property Cajas_a_tener As Integer
    Public Property Cajas As Integer
    Private Property ID As Integer

    Public ReadOnly Property Cajas_restantes As Integer
        Get
            Dim total As Integer = Cajas_a_tener - Cajas
            If total < 0 Then Return 0
            Return total
        End Get
    End Property

    Public WriteOnly Property Identificador As Integer
        Set(value As Integer)
            Me.ID = value
        End Set
    End Property


    Public Sub New(ByVal id As Integer)
        Me.ID = id
    End Sub

    Public Sub recuperar_datos()
        Me.Cajas = calcular_cajas(ID)
        Me.Cajas_a_tener = calcular_cajas_tipo(ID)
    End Sub

    Public Function calcular_cajas(ByVal paletId As Integer) As String
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("SELECT isnull(sum(PaletsContenidos.CantidadCajas), 0) AS SumCajas FROM paletsProducidos INNER JOIN PaletsContenidos ON  PaletsProducidos.PaletProducidoID = PaletsContenidos.PaletProducidoID WHERE PaletsProducidos.paletproducidoid = @id")
        dtb.AñadirParametroConsulta("@id", ID)
        Dim cantidad As Integer = dtb.Consultar().Rows(0).Item(0)
        Return if(cantidad < 0, 0, cantidad)
    End Function

    Public Function calcular_cajas_tipo(ByVal paletId As Integer) As String
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("select isnull(CajasPorMatricula, 0) from paletsproducidos, formatosEnvasados, ArticulosEnvasadosHistoricoSinLinea where paletsproducidos.formatoid = formatosEnvasados.formatoEnvasadoid and tipoformatoEnvasadoid = tipoformato and paletproducidoid = @id")
        dtb.AñadirParametroConsulta("@id", Me.ID)
        Dim dt As DataTable = dtb.Consultar()

        If dt Is Nothing Then Return 0
        If dt.Rows.Count = 0 Then Return 0
        If dt.Rows(0) Is Nothing Then Return 0
        If dt.Rows(0).Item(0) Is Nothing Or dt.Rows(0).Item(0) Is Convert.DBNull Then Return 0

        Return dt.Rows(0).Item(0)
    End Function


End Class
