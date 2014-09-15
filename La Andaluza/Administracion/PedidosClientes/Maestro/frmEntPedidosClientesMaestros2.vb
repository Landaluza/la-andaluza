Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosClientesMaestros2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2
    Private m_VerID As Boolean = False
    Private frmPedidosClientesDetalles2 As frmPedidosClientesDetalles2
    Private frmPedidosClientesDocumentos As frmPedidosClientesDocumentos
    Private spPedidosClientesMaestros2 As spPedidosClientesMaestros2

    Public Sub New(ByRef PedidosClientesMaestros2 As DBO_PedidosClientesMaestros2, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_PedidosClientesMaestros2 = PedidosClientesMaestros2
        spPedidosClientesMaestros2 = New spPedidosClientesMaestros2
        m_Pos = Pos
        m_VerID = VerID
        Me.dtpFechaEmision.activarFoco()
        Me.dtpFechaServicio.activarFoco()
    End Sub

    Private Sub frmEntPedidosClientesMaestros2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spClientes As New spClientes
        spClientes.cargar_Clientes(cboClienteID)
        'Me.cboClienteID.mam_DataSource("PedidosClientesMaestros2_ClientesCbo"), False)
        Dim spLugares As New spLugaresEntregas
        spLugares.cargar_LugaresEntregas(cboPedidoClienteLugarEntregaID)

        If Not m_VerID Then
            Me.cboClienteID.Visible = False
            Me.lblClienteID.Visible = False
            Me.cboPedidoClienteLugarEntregaID.Visible = False
            Me.lblPedidoClienteLugarEntregaID.Visible = False
        End If

        'Me.cboPedidoClienteLugarEntregaID.mam_DataSource("PedidosClientesMaestros2_LugaresEntregasCbo"), False)



        RellenaTabPrincipal()
        SetValores(m_DBO_PedidosClientesMaestros2.PedidoClienteMaestroID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_PedidosClientesMaestros2 = spPedidosClientesMaestros2.Select_Record(m_ID)

        If m_ID > 0 Then
            txtPedidoClienteMaestroID.Text = m_DBO_PedidosClientesMaestros2.PedidoClienteMaestroID
            cboClienteID.SelectedValue = If(m_DBO_PedidosClientesMaestros2.ClienteID = Nothing, -1, m_DBO_PedidosClientesMaestros2.ClienteID)
            txtNumero.Text = m_DBO_PedidosClientesMaestros2.Numero
            dtpFechaEmision.Text = m_DBO_PedidosClientesMaestros2.FechaEmision
            dtpFechaServicio.Text = If(m_DBO_PedidosClientesMaestros2.FechaServicio.HasValue, Convert.ToString(m_DBO_PedidosClientesMaestros2.FechaServicio), "")
            chbServido.Checked = m_DBO_PedidosClientesMaestros2.Servido
            txtObservaciones.Text = m_DBO_PedidosClientesMaestros2.Observaciones
            txtNumeroPedidoCliente.Text = If(m_DBO_PedidosClientesMaestros2.NumeroPedidoCliente.HasValue, Convert.ToString(m_DBO_PedidosClientesMaestros2.NumeroPedidoCliente), "")
            cboPedidoClienteLugarEntregaID.SelectedValue = If(m_DBO_PedidosClientesMaestros2.PedidoClienteLugarEntregaID = Nothing, -1, m_DBO_PedidosClientesMaestros2.PedidoClienteLugarEntregaID)
        Else
            Me.TabControl1.Visible = False
        End If
    End Sub

    Private Function GetValores() As Boolean
        Dim errores As String = ""

        If txtNumero.Text = "" Then
            errores &= "El campo numero no puede estar vacio" & Environment.NewLine
        Else
            m_DBO_PedidosClientesMaestros2.Numero = System.Convert.ToInt32(txtNumero.Text)
        End If

        m_DBO_PedidosClientesMaestros2.ClienteID = System.Convert.ToInt32(cboClienteID.SelectedValue)
        m_DBO_PedidosClientesMaestros2.FechaEmision = dtpFechaEmision.Value.Date
        m_DBO_PedidosClientesMaestros2.FechaServicio = If(dtpFechaServicio.Text = "", System.DateTime.Now.Date, dtpFechaServicio.Value.Date)
        m_DBO_PedidosClientesMaestros2.Servido = System.Convert.ToBoolean(chbServido.Checked)
        m_DBO_PedidosClientesMaestros2.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PedidosClientesMaestros2.NumeroPedidoCliente = System.Convert.ToInt32(If(txtNumeroPedidoCliente.Text = "", Nothing, txtNumeroPedidoCliente.Text))
        m_DBO_PedidosClientesMaestros2.PedidoClienteLugarEntregaID = System.Convert.ToInt32(cboPedidoClienteLugarEntregaID.SelectedValue)
        m_DBO_PedidosClientesMaestros2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_PedidosClientesMaestros2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If errores = "" Then
            Return True
        Else
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores:" & Environment.NewLine & Environment.NewLine & errores)
            Return False
        End If
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spPedidosClientesMaestros2.GrabarPedidosClientesMaestros2(m_DBO_PedidosClientesMaestros2) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Name Is "tbpFichasTecnicas" Then
            RellenaTabPrincipal()
        ElseIf TabControl1.SelectedTab.Name Is "tbpArticulos" Then
            frmPedidosClientesDetalles2 = New frmPedidosClientesDetalles2(m_DBO_PedidosClientesMaestros2.PedidoClienteMaestroID)
            ' Me.frHijo = f
            ' Me.frHijo.Embebido = True
            frmPedidosClientesDetalles2.Embebido = True
            frmPedidosClientesDetalles2.TopLevel = False
            frmPedidosClientesDetalles2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmPedidosClientesDetalles2.Dock = DockStyle.Fill
            frmPedidosClientesDetalles2.butSalir.Visible = False
            frmPedidosClientesDetalles2.butVer.Visible = False
            Me.tbpArticulos.Controls.Add(frmPedidosClientesDetalles2)
            frmPedidosClientesDetalles2.Show()
        ElseIf TabControl1.SelectedTab.Name Is "tpDocumentos" Then
            frmPedidosClientesDocumentos = New frmPedidosClientesDocumentos(m_DBO_PedidosClientesMaestros2.PedidoClienteMaestroID)
            ' frHijo = f
            '  Me.frHijo.Embebido = True
            frmPedidosClientesDocumentos.Embebido = True
            frmPedidosClientesDocumentos.TopLevel = False
            frmPedidosClientesDocumentos.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            frmPedidosClientesDocumentos.Dock = DockStyle.Fill
            frmPedidosClientesDocumentos.butSalir.Visible = False
            frmPedidosClientesDocumentos.butVer.Visible = True
            Me.tpDocumentos.Controls.Add((frmPedidosClientesDocumentos))
            frmPedidosClientesDocumentos.Show()
        End If
    End Sub

    Sub RellenaTabPrincipal()
        frmPedidosClientesDetalles2 = New frmPedidosClientesDetalles2(m_DBO_PedidosClientesMaestros2.PedidoClienteMaestroID)
        frmPedidosClientesDetalles2.Embebido = True
        frmPedidosClientesDetalles2.TopLevel = False
        frmPedidosClientesDetalles2.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        frmPedidosClientesDetalles2.Dock = DockStyle.Fill
        frmPedidosClientesDetalles2.butSalir.Visible = False
        frmPedidosClientesDetalles2.butVer.Visible = False
        Me.tbpArticulos.Controls.Add((frmPedidosClientesDetalles2))
        frmPedidosClientesDetalles2.Show()
    End Sub

    Private Sub cboClienteID_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboClienteID.SelectedValueChanged
        If Not frmPedidosClientesDetalles2 Is Nothing Then
            Me.frmPedidosClientesDetalles2.mercadona = If(Me.cboClienteID.SelectedValue = 2, True, False)
        End If
    End Sub
End Class
