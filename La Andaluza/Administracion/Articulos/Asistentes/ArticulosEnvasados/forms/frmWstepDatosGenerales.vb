Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmWstepDatosGenerales
    Implements wizardable
    Public Const TIPO_PALET As String = "tipoPalet"
    Public Const FORMATO As String = "tipoFormato"
    Public Const MARCA As String = "marca"
    Public Const MARCA_ID As String = "marcaId"
    Public Const LINEA As String = "linea"
    Public Const PRODUCTO As String = "producto"
    Public Const DESCRIPCION As String = "descripcion"
    Public Const CREAR_SECUNDARIO As String = "secundario"
    Public Const CREAR_FORMATO As String = "formato"
    Public Const CAJA As String = "caja"

    Public Sub New()

        InitializeComponent()
    End Sub

    Private Sub frmWstepDatosGenerales_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(Me.panContenido, Me)
    End Sub


    Private Sub rbExisteFormato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbExisteFormato.CheckedChanged
        Me.cboFormatos.Enabled = rbExisteFormato.Checked
        Me.panLinea.Enabled = rbNoExisteFormato.Checked
    End Sub

    Private Sub rbNoExisteFormato_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbNoExisteFormato.CheckedChanged
        Me.cboFormatos.Enabled = rbExisteFormato.Checked
        Me.panLinea.Enabled = rbNoExisteFormato.Checked
    End Sub

    Private Sub cboProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboProducto.SelectedValueChanged
        componernombre()
    End Sub

    Private Sub cboPaletTipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboPaletTipo.SelectedValueChanged
        componernombre()
    End Sub

    Private Sub cboMarca_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMarca.SelectedValueChanged
        componernombre()
    End Sub


    Public Sub establecerValores() Implements wizardable.EstablecerValores
        Me.cboLinea.mam_DataSource("LineasEnvasadoSelectCbo", False)
        'Me.cboMarca.mam_DataSource("MarcasCbo", False)
        Dim s As New spmarcas
        s.cargar_marcas(cboMarca)
        Dim spt As New spArticulosEnvasadosHistoricos
        spt.cargar_TiposFormatos_Libres(cboFormatos)
        Me.cboPaletTipo.mam_DataSource("PaletsTiposCbo", False)
        Me.cboProducto.mam_DataSource("TiposProductosSelectCbo", False)
        Me.cboCaja.mam_DataSource("TiposcajasCbo", False)
    End Sub

    Public Function recuperarValor(ByVal nombre As String) As Object Implements wizardable.recuperarValor
        Select Case (nombre)
            Case MARCA
                Return Me.cboMarca.SelectedValue
            Case MARCA_ID
                Return Me.cboMarca.SelectedValue
            Case FORMATO
                Return If(Me.rbExisteFormato.Checked, Me.cboFormatos.SelectedValue, Nothing)
            Case LINEA
                Return Me.cboLinea.SelectedValue
            Case TIPO_PALET
                Return Me.cboPaletTipo.SelectedValue
            Case PRODUCTO
                Return Me.cboProducto.SelectedValue
            Case DESCRIPCION
                Return Me.lNombre.Text
            Case CREAR_SECUNDARIO
                Return Not Me.cbCrearSecundario.Checked
            Case CREAR_FORMATO
                Return Me.rbNoExisteFormato.Checked
            Case CAJA
                Return Me.cboCaja.SelectedValue
            Case Else
                Return Nothing
        End Select
    End Function

    Public Function grabarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean Implements wizardable.grabarDatos
        Dim retorno As Boolean = True

        If Me.rbNoExisteFormato.Checked Then
            ' se crea el formato con datos de relleno para modificarlo con los datos introducidos en la pestaña de secundario
            Dim m_DBO_TiposFormatos1 As New DBO_ArticulosEnvasadosHistorico
            m_DBO_TiposFormatos1.TipoFormatoID = 0
            m_DBO_TiposFormatos1.CodigoQS = 0
            m_DBO_TiposFormatos1.Descripcion = Me.lNombre.Text
            m_DBO_TiposFormatos1.Separadores = 0
            m_DBO_TiposFormatos1.CajasPalet = 0
            m_DBO_TiposFormatos1.Genericas = 0
            m_DBO_TiposFormatos1.Particulares = 0
            m_DBO_TiposFormatos1.TipoProductoID = 1
            m_DBO_TiposFormatos1.TipoCajaID = cboCaja.SelectedValue
            Dim spTiposFormatos1 As New spArticulosEnvasadosHistorico1
            If Not spTiposFormatos1.GrabarTiposFormatos1Sintransaccion(m_DBO_TiposFormatos1, BasesParaCompatibilidad.BD.transaction) Then Return False
            Dim spt As New spArticulosEnvasadosHistoricos
            Dim m_formato As Integer = spt.seleccionar_ultimo_registro(dtb)

            'Dim ctlTipForLin_TipFor As New ctlTiposFormatosLineas_TiposFormatos
            'If Not ctlTipForLin_TipFor.GuardarTipoFormatoLinea(cboLinea.SelectedValue, m_formato, txtVelocidad.Text) Then Return False


            If Not Me.chbFormatoLinea.Checked Then
                'Dim dbo As New DBO_TiposFormatosLineas
                'dbo.LineaEnvasadoID = cboLinea.SelectedValue
                'dbo.Descripcion = Me.cboCaja.SelectedText
                'Dim sp As New spTiposFormatosLineas
                'If Not sp.Grabar(dbo, BasesParaCompatibilidad.BD.transaction) Then Return False
                ''falta grabar tiposforamtos_tiposformatoslineas
                'm_formatoLinea = RealizarConsulta("select max(tipoformatoLineaID) from tiposformatosLineas").Rows(0).Item(0)
            Else
                Dim dbo2 As New DBO_TiposFormatosLineas_TiposFormatos
                Dim sp2 As New spTiposFormatosLineas_TiposFormatos
                Dim m_formatoLinea As Integer

                m_formatoLinea = Me.cboFormatoLinea.SelectedValue

                dbo2.TipoFormatoID = m_formato
                dbo2.TipoFormatoLineaID = m_formatoLinea
                dbo2.Velocidad = Me.txtVelocidad.Text
                If Not sp2.Grabar(dbo2, BasesParaCompatibilidad.BD.transaction) Then Return False
            End If



            Return True
        Else
            Return True
        End If
    End Function

    Public Function comprobarCampos() As Boolean Implements wizardable.comprobarCampos
        If Me.rbNoExisteFormato.Checked Then
            If Me.txtVelocidad.Text = String.Empty Then
                txtVelocidad.Focus()
                MessageBox.Show("Se han encontrado los siguientes errores: " & Environment.NewLine & "El campo velocidad debe ser numérico.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
        End If

        Return True
    End Function

    Private Sub componernombre()
        Try
            'Dim cadPalet As String
            'cadPalet = convert.tostring(cboPaletTipo.SelectedItem(2)) & " x " & cboPaletTipo.SelectedItem(3)

            'Me.lNombre.Text = cboProducto.Text & " " & cboMarca.Text & " " & cadPalet
            'BasesParaCompatibilidad.DetailedSimpleForm.centerHorizontalyIn(lNombre, panContenido)

            Dim cadPalet As String
            cadPalet = Convert.ToString(cboCaja.SelectedItem(2)) & " x " & cboCaja.SelectedItem(3).ToString
            Me.lNombre.Text = cboProducto.Text & " " & cadPalet & " " & cboMarca.Text & " (" & cboPaletTipo.Text & ")"
            BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(lNombre, panContenido)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cboCaja_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboCaja.SelectedValueChanged
        componernombre()
    End Sub

    Private Sub btnMarca_Click(sender As System.Object, e As System.EventArgs) Handles btnMarca.Click
        Dim frm As New frmmarcas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Dim s As New spmarcas
        s.cargar_marcas(cboMarca)
    End Sub

    Private Sub cboLinea_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboLinea.SelectedValueChanged
        Try
            Dim sp As New spTiposFormatosLineas_TiposFormatos
            sp.cargarCombo_por_linea(Me.cboFormatoLinea, Me.cboLinea.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub chbFormatoLinea_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chbFormatoLinea.CheckedChanged
        Me.cboFormatoLinea.Enabled = chbFormatoLinea.Checked
    End Sub

    Private Sub btnAddProducto_Click(sender As System.Object, e As System.EventArgs) Handles btnAddProducto.Click
        Dim frm As New frmEntTiposProductos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Me.cboProducto.mam_DataSource("TiposProductosSelectCbo", False)
    End Sub

    Private Sub btnAddPalet_Click(sender As System.Object, e As System.EventArgs) Handles btnAddPalet.Click
        Dim frm As New frmPaletsTipos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Me.cboPaletTipo.mam_DataSource("PaletsTiposCbo", False)
    End Sub

    Private Sub btnAddCaja_Click(sender As System.Object, e As System.EventArgs) Handles btnAddCaja.Click
        Dim frm As New frmTiposCajas
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Me.cboCaja.mam_DataSource("TiposcajasCbo", False)
    End Sub
End Class