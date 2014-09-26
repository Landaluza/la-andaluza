Public Class frmEntPedidosClientesNecesidades
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PedidosClientesNecesidades As DBO_PedidosClientesNecesidades

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPedidosClientesNecesidades = Nothing, Optional ByRef v_dbo As DBO_PedidosClientesNecesidades = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spPedidosClientesNecesidades, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_PedidosClientesNecesidades = if(v_dbo Is Nothing, New DBO_PedidosClientesNecesidades, v_dbo)
        dbo = m_DBO_PedidosClientesNecesidades
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spPedidosClientesNecesidades, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_PedidosClientesNecesidades, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntPedidosClientesNecesidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spClientes As New spClientes
        spClientes.cargar_Clientes(Me.cboCliente)
        If Me.mododeapertura = VISION Then
            Me.cboCliente.enabled = False
            Me.lblClienteID.enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddClienteID.enabled = False
            butVerClienteID.enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_PedidosClientesNecesidades = New dbo_PedidosClientesNecesidades
        Else
            Me.m_DBO_PedidosClientesNecesidades = CType(dbo, DBO_PedidosClientesNecesidades)
        End If

        cboCliente.SelectedValue = m_DBO_PedidosClientesNecesidades.ClienteID
        txtRuta.Text = m_DBO_PedidosClientesNecesidades.Ruta
        txtObservaciones.Text = m_DBO_PedidosClientesNecesidades.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        m_DBO_PedidosClientesNecesidades.Ruta = txtRuta.Text


        m_DBO_PedidosClientesNecesidades.Observaciones = txtObservaciones.Text

        If Me.cboCliente.SelectedValue Is Nothing Then
            errores = "No selcciono un cliente"
        Else
            m_DBO_PedidosClientesNecesidades.ClienteID = Me.cboCliente.SelectedValue
        End If


        If errores = String.empty Then
            Dbo = CType(m_DBO_PedidosClientesNecesidades, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        'Cambiar "C:\" por la ruta adecuada
        arch = BasesParaCompatibilidad.File.Elegir_archivo("C:\")

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
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub butVerClienteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerClienteID.Click
        Dim frmEnt As New frmClientes()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddClienteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddClienteID.Click
        Dim DBO_Clientes As New DBO_Clientes
        Dim spClientes As New spClientes
        Dim frmEnt As New frmEntClientes(0, 0)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        spClientes.cargar_Clientes(Me.cboCliente)
    End Sub

    Private Sub frmEntPedidosClientesNecesidades_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
