Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosTiposDocumentos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosTiposDocumento As DBO_ArticulosTiposDocumentos
    Private m_VerID As Boolean = False
    Private spArticulosTiposDocumentos As spArticulosTiposDocumentos

    Public Sub New(ByRef ArticulosTiposDocumento As DBO_ArticulosTiposDocumentos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ArticulosTiposDocumento = ArticulosTiposDocumento
        spArticulosTiposDocumentos = New spArticulosTiposDocumentos
        m_Pos = Pos
        m_VerID = VerID
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntArticulosTiposDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboArticuloTipoID.mam_DataSource("ArticulosTiposDocumentos_ArticulosTiposCbo", False, dtb)
        If Not m_VerID Then
            Me.cboArticuloTipoID.Visible = False
            Me.lblArticuloTipoID.Visible = False
        End If
        butVer.Visible = True
        SetValores(m_DBO_ArticulosTiposDocumento.ArticuloTipoDocumentoID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_ArticulosTiposDocumento = spArticulosTiposDocumentos.Select_Record(m_ID, dtb)
        txtArticuloTipoDocumentoID.Text = m_DBO_ArticulosTiposDocumento.ArticuloTipoDocumentoID
        cboArticuloTipoID.SelectedValue = If(m_DBO_ArticulosTiposDocumento.ArticuloTipoID.HasValue, m_DBO_ArticulosTiposDocumento.ArticuloTipoID, -1)
        txtDescripcion.Text = m_DBO_ArticulosTiposDocumento.Descripcion
        dtpFecha.Text = m_DBO_ArticulosTiposDocumento.Fecha
        txtFuente.Text = m_DBO_ArticulosTiposDocumento.Fuente
        txtRuta.Text = m_DBO_ArticulosTiposDocumento.Ruta
        txtObservaciones.Text = m_DBO_ArticulosTiposDocumento.Observaciones
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosTiposDocumento.ArticuloTipoID = System.Convert.ToInt32(cboArticuloTipoID.SelectedValue)
        m_DBO_ArticulosTiposDocumento.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_ArticulosTiposDocumento.Fecha = dtpFecha.Value.Date
        m_DBO_ArticulosTiposDocumento.Fuente = If(txtFuente.Text = "", String.Empty, txtFuente.Text)
        m_DBO_ArticulosTiposDocumento.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_ArticulosTiposDocumento.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosTiposDocumento.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosTiposDocumento.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosTiposDocumentos.GrabarArticulosTiposDocumentos(m_DBO_ArticulosTiposDocumento, dtb)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Compras\ArticulosTipos")
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
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
