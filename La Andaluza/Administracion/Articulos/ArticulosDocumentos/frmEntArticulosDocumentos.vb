Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntArticulosDocumentos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosDocumento As DBO_ArticulosDocumentos
    Private m_VerID As Boolean = False
    Private spArticulosDocumentos As spArticulosDocumentos

    Public Sub New(ByRef ArticulosDocumento As DBO_ArticulosDocumentos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_ArticulosDocumento = ArticulosDocumento
        m_Pos = Pos
        m_VerID = VerID
        spArticulosDocumentos = New spArticulosDocumentos
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntArticulosDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spArt As New spArticulos1
        spArt.cargar_Articulos(cboArticuloID, dtb)
        If Not m_VerID Then
            Me.cboArticuloID.Visible = False
            Me.lblArticuloID.Visible = False
        End If
        SetValores(m_DBO_ArticulosDocumento.ArticuloDocumentoID, False)
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_ArticulosDocumento = spArticulosDocumentos.Select_Record(dtb, m_ID)
        txtArticuloDocumentoID.Text = m_DBO_ArticulosDocumento.ArticuloDocumentoID.ToString
        cboArticuloID.SelectedValue = If(m_DBO_ArticulosDocumento.ArticuloID = Nothing, -1, m_DBO_ArticulosDocumento.ArticuloID)
        txtDescripcion.Text = m_DBO_ArticulosDocumento.Descripcion
        dtpFecha.Text = m_DBO_ArticulosDocumento.Fecha
        txtFuente.Text = m_DBO_ArticulosDocumento.Fuente
        txtRuta.Text = m_DBO_ArticulosDocumento.Ruta
        txtObservaciones.Text = m_DBO_ArticulosDocumento.Observaciones
    End Sub

    Private Function GetValores() As Boolean
        Dim errores As String = ""

        If txtDescripcion.Text = "" Then
            txtDescripcion.Focus()
            errores = errores & "El campo 'descripción' no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ArticulosDocumento.Descripcion = txtDescripcion.Text
            m_DBO_ArticulosDocumento.Fecha = dtpFecha.Value.Date
            m_DBO_ArticulosDocumento.Fuente = If(txtFuente.Text = "", String.Empty, txtFuente.Text)
            m_DBO_ArticulosDocumento.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
            m_DBO_ArticulosDocumento.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
            m_DBO_ArticulosDocumento.FechaModificacion = System.DateTime.Now.Date
            m_DBO_ArticulosDocumento.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spArticulosDocumentos.GrabarArticulosDocumentos(dtb, m_DBO_ArticulosDocumento) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Compras\Artículos")

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
