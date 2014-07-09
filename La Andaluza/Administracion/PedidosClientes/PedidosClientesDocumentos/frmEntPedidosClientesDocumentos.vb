Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosClientesDocumentos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_PedidosClientesDocumento As DBO_PedidosClientesDocumentos
    Private m_VerID As Boolean = False
    Private spPedidosClientesDocumentos As spPedidosClientesDocumentos


    Public Sub New(ByRef PedidosClientesDocumento As DBO_PedidosClientesDocumentos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spPedidosClientesDocumentos = New spPedidosClientesDocumentos
        m_DBO_PedidosClientesDocumento = PedidosClientesDocumento
        m_Pos = Pos
        m_VerID = VerID
        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntPedidosClientesDocumentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_PedidosClientesDocumento.PedidoClienteDocumentoID, False)
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)

        'If m_SelectRecord Then m_DBO_PedidosClientesDocumento = spPedidosClientesDocumentos.Select_Record(m_ID)
        'If m_ID > 0 Then
        txtPedidoClienteDocumentoID.Text = m_DBO_PedidosClientesDocumento.PedidoClienteDocumentoID
        txtPedidoClienteMaestroID.Text = If(m_DBO_PedidosClientesDocumento.PedidoClienteMaestroID.HasValue, Convert.ToString(m_DBO_PedidosClientesDocumento.PedidoClienteMaestroID), "")
        txtDescripcion.Text = m_DBO_PedidosClientesDocumento.Descripcion
        txtRuta.Text = m_DBO_PedidosClientesDocumento.Ruta
        dtpFecha.Text = m_DBO_PedidosClientesDocumento.Fecha
        txtObservaciones.Text = m_DBO_PedidosClientesDocumento.Observaciones
        'End If
    End Sub

    Private Sub GetValores()
        m_DBO_PedidosClientesDocumento.PedidoClienteMaestroID = System.Convert.ToInt32(If(txtPedidoClienteMaestroID.Text = "", String.Empty, txtPedidoClienteMaestroID.Text))
        m_DBO_PedidosClientesDocumento.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_PedidosClientesDocumento.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_PedidosClientesDocumento.Fecha = dtpFecha.Value.Date
        m_DBO_PedidosClientesDocumento.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PedidosClientesDocumento.FechaModificacion = System.DateTime.Now.Date
        m_DBO_PedidosClientesDocumento.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPedidosClientesDocumentos.GrabarPedidosClientesDocumentos(m_DBO_PedidosClientesDocumento)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Comercial\Pedidos\Cajas")
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
