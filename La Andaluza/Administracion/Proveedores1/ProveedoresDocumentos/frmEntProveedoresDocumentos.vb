Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntProveedoresDocumentos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ProveedoresDocumento As DBO_ProveedoresDocumentos
    Private m_VerID As Boolean = False
    Private m_ruta As String
    Private spProveedoresDocumentos As spProveedoresDocumentos

    Public Sub New(ByRef ProveedoresDocumento As DBO_ProveedoresDocumentos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ProveedoresDocumento = ProveedoresDocumento
        m_Pos = Pos
        m_VerID = VerID
        spProveedoresDocumentos = New spProveedoresDocumentos
        Me.dtpFecha.activarFoco()
    End Sub

    Public Sub New(ByRef ProveedoresDocumento As DBO_ProveedoresDocumentos, ByVal Pos As Integer, ByVal VerID As Boolean, ByVal rutaDefecto As String)
        Me.New(ProveedoresDocumento, Pos, VerID)
        Me.m_ruta = rutaDefecto
        spProveedoresDocumentos = New spProveedoresDocumentos
        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntProveedoresDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboProveedorID.mam_DataSource("ProveedoresDocumentos_ProveedoresCbo", False)
        If Not m_VerID Then
            Me.cboProveedorID.Visible = False
            Me.lblProveedorID.Visible = False
        End If
        butVer.Visible = True
        SetValores(m_DBO_ProveedoresDocumento.ProveedorDocumentoID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        If m_SelectRecord Then m_DBO_ProveedoresDocumento = spProveedoresDocumentos.Select_Record(m_ID)
        'If m_ID > 0 Then
        txtProveedorDocumentoID.Text = m_DBO_ProveedoresDocumento.ProveedorDocumentoID
        'cboProveedorID.SelectedValue = if(m_DBO_ProveedoresDocumento.ProveedorID.HasValue, m_DBO_ProveedoresDocumento.ProveedorID, -1)
        cboProveedorID.SelectedValue = If(m_DBO_ProveedoresDocumento.ProveedorID = Nothing, -1, m_DBO_ProveedoresDocumento.ProveedorID)
        txtDescripcion.Text = m_DBO_ProveedoresDocumento.Descripcion
        dtpFecha.Text = m_DBO_ProveedoresDocumento.Fecha
        txtFuente.Text = m_DBO_ProveedoresDocumento.Fuente
        txtRuta.Text = m_DBO_ProveedoresDocumento.Ruta
        txtObservaciones.Text = m_DBO_ProveedoresDocumento.Observaciones
        'End If
    End Sub

    Private Sub GetValores()
        m_DBO_ProveedoresDocumento.ProveedorID = System.Convert.ToInt32(cboProveedorID.SelectedValue)
        m_DBO_ProveedoresDocumento.Descripcion = txtDescripcion.Text
        m_DBO_ProveedoresDocumento.Fecha = dtpFecha.Value.Date
        m_DBO_ProveedoresDocumento.Fuente = If(txtFuente.Text = "", String.Empty, txtFuente.Text)
        m_DBO_ProveedoresDocumento.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_ProveedoresDocumento.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ProveedoresDocumento.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ProveedoresDocumento.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spProveedoresDocumentos.GrabarProveedoresDocumentos(m_DBO_ProveedoresDocumento)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", If(Me.m_ruta <> Nothing, m_ruta, "Z:\Compras\Proveedores"))
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRuta.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
