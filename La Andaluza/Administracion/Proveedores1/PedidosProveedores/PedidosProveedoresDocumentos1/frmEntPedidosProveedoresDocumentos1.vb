Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosProveedoresDocumentos1
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1
    Private spPedidosProveedoresDocumentos1 As spPedidosProveedoresDocumentos1

    Public Sub New(ByRef PedidosProveedoresDocumentos1 As DBO_PedidosProveedoresDocumentos1, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spPedidosProveedoresDocumentos1 = New spPedidosProveedoresDocumentos1
        m_DBO_PedidosProveedoresDocumentos1 = PedidosProveedoresDocumentos1
        m_Pos = Pos
        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntPedidosProveedoresDocumentos1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores()
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores()
        txtPedidoProveedorDocumentoID.Text = m_DBO_PedidosProveedoresDocumentos1.PedidoProveedorDocumentoID
        txtDescripcion.Text = m_DBO_PedidosProveedoresDocumentos1.Descripcion
        txtRuta.Text = m_DBO_PedidosProveedoresDocumentos1.Ruta
        dtpFecha.Text = m_DBO_PedidosProveedoresDocumentos1.Fecha
        txtObservaciones.Text = m_DBO_PedidosProveedoresDocumentos1.Observaciones
        txtPedidoProveedorMaestroID.Text = m_DBO_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID
    End Sub

    Private Sub GetValores()
        m_DBO_PedidosProveedoresDocumentos1.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_PedidosProveedoresDocumentos1.Ruta = If(txtRuta.Text = "", String.Empty, txtRuta.Text)
        m_DBO_PedidosProveedoresDocumentos1.Fecha = dtpFecha.Value.Date
        m_DBO_PedidosProveedoresDocumentos1.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PedidosProveedoresDocumentos1.PedidoProveedorMaestroID = System.Convert.ToInt32(txtPedidoProveedorMaestroID.Text)
        m_DBO_PedidosProveedoresDocumentos1.FechaModificacion = System.DateTime.Now.Date
        m_DBO_PedidosProveedoresDocumentos1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPedidosProveedoresDocumentos1.GrabarPedidosProveedoresDocumentos1(m_DBO_PedidosProveedoresDocumentos1, dtb)
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        'Hay que añadir el parametro despues de txtRuta.Text, para que conserve la ruta
        'arch = SeleccionarArchivo(Me.Text, txtRuta.Text, "Z:\Compras\Pedidos\2011")
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\Compras\Pedidos\2011")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Overrides Sub Ver()
        Dim f As New BasesParaCompatibilidad.File
        f.open(txtRuta.Text)

        'Try
        '    Dim psi As New ProcessStartInfo()
        '    psi.UseShellExecute = True
        '    psi.FileName = txtRuta.Text
        '    Process.Start(psi)
        'Catch ex As Exception
        '    messagebox.show(ex.Message)
        'End Try
    End Sub

End Class
