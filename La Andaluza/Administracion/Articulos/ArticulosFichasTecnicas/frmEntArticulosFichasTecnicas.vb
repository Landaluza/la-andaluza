Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosFichasTecnicas
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosFichasTecnica As DBO_ArticulosFichasTecnicas
    Private m_VerID As Boolean = False
    Private spArticulosFichasTecnicas As New spArticulosFichasTecnicas

    Public Sub New(ByRef ArticulosFichasTecnica As DBO_ArticulosFichasTecnicas, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ArticulosFichasTecnica = ArticulosFichasTecnica
        m_Pos = Pos
        m_VerID = VerID
        dtpFechaAprobacion.activarFoco()
        dtpFechaObsoleta.activarFoco()
    End Sub

    Private Sub frmEntArticulosFichasTecnicas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.cboArticuloID.mam_DataSource("ArticulosFichasTecnicas_ArticulosCbo"), False)
        Dim spArticulo As New spArticulos1
        Dim spEmp As New spEmpleados
        Dim spProv As New spProveedores
        Dim spart As New spArticulosFichasTecnicasEstados

        spArticulo.cargar_Articulos(cboArticuloID)
        spEmp.cargar_Empleados(cboAprobadorID)
        spProv.cargar_ComboBox(cboProveedorID)
        spart.cargar_combo(cboEstadoID)
        'Me.cboArticuloID.mam_DataSource(dtb.consultar("Articulos1Cbo"), False)


        'Me.cboProveedorID.mam_DataSource(dtb.consultar("ArticulosFichasTecnicas_ProveedoresCbo"), False)
        'Me.cboAprobadorID.mam_DataSource("ArticulosFichasTecnicas_EmpleadosCbo"), False)
        ' Me.cboAprobadorID.mam_DataSource(dtb.consultar("EmpleadosSelectCbo"), False)
        'Me.cboEstadoID.mam_DataSource(dtb.consultar("ArticulosFichasTecnicas_ArticulosFichasTecnicasEstadosCbo"), False)
        Me.butVer.Visible = True
        SetValores(m_DBO_ArticulosFichasTecnica.ArticuloFichaTecnicaID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        'cboArticuloID.SelectedValue = if(m_DBO_ArticulosFichasTecnica.ArticuloID = Nothing, -1, m_DBO_ArticulosFichasTecnica.ArticuloID)

        If m_SelectRecord Then m_DBO_ArticulosFichasTecnica = spArticulosFichasTecnicas.Select_Record(m_ID)
        txtArticuloFichaTecnicaID.Text = m_DBO_ArticulosFichasTecnica.ArticuloFichaTecnicaID
        cboArticuloID.SelectedValue = If(m_DBO_ArticulosFichasTecnica.ArticuloID = Nothing, -1, m_DBO_ArticulosFichasTecnica.ArticuloID)
        cboProveedorID.SelectedValue = If(m_DBO_ArticulosFichasTecnica.ProveedorID = Nothing, -1, m_DBO_ArticulosFichasTecnica.ProveedorID)
        cboAprobadorID.SelectedValue = If(m_DBO_ArticulosFichasTecnica.AprobadorID = Nothing, -1, m_DBO_ArticulosFichasTecnica.AprobadorID)
        cboEstadoID.SelectedValue = If(m_DBO_ArticulosFichasTecnica.EstadoID = Nothing, -1, m_DBO_ArticulosFichasTecnica.EstadoID)
        txtVersion.Text = m_DBO_ArticulosFichasTecnica.Version
        dtpFechaAprobacion.Text = m_DBO_ArticulosFichasTecnica.FechaAprobacion
        dtpFechaObsoleta.Text = If(m_DBO_ArticulosFichasTecnica.FechaObsoleta.HasValue, Convert.ToString(m_DBO_ArticulosFichasTecnica.FechaObsoleta), "")
        txtRuta.Text = m_DBO_ArticulosFichasTecnica.Ruta
        txtCambiosAnterior.Text = m_DBO_ArticulosFichasTecnica.CambiosAnterior
        txtPropuestasCambios.Text = m_DBO_ArticulosFichasTecnica.PropuestasCambios
        txtMotivoPasoObsoleta.Text = m_DBO_ArticulosFichasTecnica.MotivoPasoObsoleta
        txtObservaciones.Text = m_DBO_ArticulosFichasTecnica.Observaciones
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosFichasTecnica.ArticuloID = System.Convert.ToInt32(cboArticuloID.SelectedValue)
        m_DBO_ArticulosFichasTecnica.ProveedorID = System.Convert.ToInt32(cboProveedorID.SelectedValue)
        m_DBO_ArticulosFichasTecnica.AprobadorID = System.Convert.ToInt32(cboAprobadorID.SelectedValue)
        m_DBO_ArticulosFichasTecnica.EstadoID = System.Convert.ToInt32(cboEstadoID.SelectedValue)
        m_DBO_ArticulosFichasTecnica.Version = System.Convert.ToInt32(txtVersion.Text)
        m_DBO_ArticulosFichasTecnica.FechaAprobacion = dtpFechaAprobacion.Value.Date
        m_DBO_ArticulosFichasTecnica.FechaObsoleta = If(dtpFechaObsoleta.Text = "", System.DateTime.Now.Date, dtpFechaObsoleta.Value)
        m_DBO_ArticulosFichasTecnica.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_ArticulosFichasTecnica.CambiosAnterior = If(txtCambiosAnterior.Text = "", String.Empty, txtCambiosAnterior.Text)
        m_DBO_ArticulosFichasTecnica.PropuestasCambios = If(txtPropuestasCambios.Text = "", String.Empty, txtPropuestasCambios.Text)
        m_DBO_ArticulosFichasTecnica.MotivoPasoObsoleta = If(txtMotivoPasoObsoleta.Text = "", String.Empty, txtMotivoPasoObsoleta.Text)
        m_DBO_ArticulosFichasTecnica.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosFichasTecnica.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosFichasTecnica.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosFichasTecnicas.GrabarArticulosFichasTecnicas(m_DBO_ArticulosFichasTecnica)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Sistema de Gestión Integrada\0.2. Calidad\Fichas tecnicas materiales auxiliares")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRuta.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub cboEstadoID_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEstadoID.SelectionChangeCommitted
        If cboEstadoID.Text = "Vigente" And cboArticuloID.Text <> "" And cboProveedorID.Text <> "" Then
            spArticulosFichasTecnicas.Select_ArticulosFichasTecnicas_EstadoVigente(cboArticuloID.SelectedValue, cboProveedorID.SelectedValue)
        End If
    End Sub
End Class
