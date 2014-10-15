Public Class frmPanMonodosis
    Implements BasesParaCompatibilidad.wizardable

    Private dbo As DBO_Monodosis
    Private mododeapertura As Byte
    Private asistente As Boolean
    Private spMonodosis As spMonodosis
    Private dtb As BasesParaCompatibilidad.Database
    Public Sub New(ByVal id As Integer, Optional asistente As Boolean = False)
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        spMonodosis = New spMonodosis
        dbo = New DBO_Monodosis
        dbo.ArticuloId = id
        Me.asistente = asistente
        Dim s As New spArticulosEnvasadosHistoricos
        s.cargar_TiposFormatos_SinLinea(Me.cboformato)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca)
        Dim s2 As New spTiposCajas
        s2.cargar_TiposCajas(Me.cboCaja)
        Dim s3 As New spTiposProductos
        s3.cargar_ComboBox(Me.cboProducto)

        If id = 0 Then
            Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION
        Else
            Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION
            Me.dbo = spMonodosis.selectRecord(Me.dbo.ArticuloId)
            If dbo Is Nothing Then
                dbo = New DBO_Monodosis
                dbo.ArticuloId = id
            End If
            EstablecerValores()
        End If
    End Sub

    Public Function comprobarCampos() As Boolean Implements BasesParaCompatibilidad.wizardable.comprobarCampos

        Me.dbo.MarcaId = Me.cboMarca.SelectedValue
        Me.dbo.Palet_NO_Conforme_ID = Me.cboSccNC.SelectedValue
        Me.dbo.ProductoId = Me.cboProducto.SelectedValue
        Me.dbo.CajaId = Me.cboCaja.SelectedValue
        Me.dbo.Ean13 = Me.txtEan.Text
        Me.dbo.CantidadPorMatricula = txtCantidad.Text

        If cbEnvasado.Checked Then
            Me.dbo.TipoFormatoId = Me.cboformato.SelectedValue
        Else
            Me.dbo.TipoFormatoId = 0
        End If

        Return True
    End Function

    Public Sub EstablecerValores() Implements BasesParaCompatibilidad.wizardable.EstablecerValores

        Try
            If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION Then
                Me.cboformato.SelectedValue = Me.dbo.TipoFormatoId
                Me.cboMarca.SelectedValue = Me.dbo.MarcaId
                Me.cboSccNC.SelectedValue = Me.dbo.Palet_NO_Conforme_ID
                Me.cboProducto.SelectedValue = Me.dbo.ProductoId
                Me.cboCaja.SelectedValue = Me.dbo.CajaId
                Me.txtEan.Text = Me.dbo.Ean13
                Me.txtCantidad.Text = Me.dbo.CantidadPorMatricula
            End If
        Catch ex As Exception
        End Try


    End Sub

    Public Function grabarDatos() As Boolean Implements BasesParaCompatibilidad.wizardable.grabarDatos
        If Me.mododeapertura = BasesParaCompatibilidad.DetailedSimpleForm.INSERCION Then
            If Me.asistente Then
                Me.dbo.ArticuloId = dtb.Consultar("select max(articuloid) from articulos1", True).Rows(0).Item(0)
            End If

            'guardar tipoformato
            If dbo.TipoFormatoId = 0 Then
                Dim m_DBO_TiposFormatos1 As New DBO_ArticulosEnvasadosHistorico
                m_DBO_TiposFormatos1.TipoFormatoID = 0
                m_DBO_TiposFormatos1.CodigoQS = 0
                m_DBO_TiposFormatos1.Descripcion = ""
                m_DBO_TiposFormatos1.Separadores = 0
                m_DBO_TiposFormatos1.CajasPalet = 0
                m_DBO_TiposFormatos1.Genericas = 0
                m_DBO_TiposFormatos1.Particulares = 0
                m_DBO_TiposFormatos1.TipoProductoID = 1
                m_DBO_TiposFormatos1.TipoCajaID = cboCaja.SelectedValue
                Dim spTiposFormatos1 As New spArticulosEnvasadosHistorico1
                If Not spTiposFormatos1.GrabarTiposFormatos1Sintransaccion(m_DBO_TiposFormatos1, BasesParaCompatibilidad.BD.transaction) Then Return False
                Dim spt As New spArticulosEnvasadosHistoricos
                Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
                Dim m_formato As Integer = spt.seleccionar_ultimo_registro(dtb)
                dbo.TipoFormatoId = m_formato
            End If

            Return spMonodosis.guardarMonodosis(Me.dbo)
        Else
            Return spMonodosis.updateMonodosis(Me.dbo)
        End If
    End Function

    Public Function recuperarValor(nombre As String) As Object Implements BasesParaCompatibilidad.wizardable.recuperarValor
        Return Nothing
    End Function

    Private Sub frmPanMonodosis_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.Pancontenidos, Me)
    End Sub

    Private Sub cboformato_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboformato.SelectedValueChanged
        Try
            Dim spPalets As New spPaletsProducidos
            spPalets.cargar_PaletsProducidosNC_byArticulo(Me.cboSccNC, Me.cboformato.SelectedValue)
        Catch ex As Exception
        End Try

        Try
            Dim sp As New spArticulosEnvasadosHistoricos
            Dim dbo As DBO_ArticulosEnvasadoHistorico = sp.Select_Record(Me.cboformato.SelectedValue)
            Me.cboProducto.SelectedValue = dbo.TipoProductoID
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbEnvasado_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbEnvasado.CheckedChanged
        Me.cboformato.Enabled = Me.cbEnvasado.Checked
    End Sub

    Private Sub btnverMarcas_Click(sender As System.Object, e As System.EventArgs) Handles btnverMarcas.Click
        Dim frm As New frmmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca)
    End Sub

    Private Sub btnaddMarcas_Click(sender As System.Object, e As System.EventArgs) Handles btnaddMarcas.Click
        Dim frm As New frmEntmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim sp As New spmarcas
        sp.cargar_marcas(Me.cboMarca)
    End Sub
End Class