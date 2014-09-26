Public Class frmEntControlIncidencias_Clientes
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ControlIncidencias_Clientes As DBO_ControlIncidencias_Clientes

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_Clientes = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_Clientes = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spControlIncidencias_Clientes, v_sp)
       m_DBO_ControlIncidencias_Clientes = if(v_dbo Is Nothing, New DBO_ControlIncidencias_Clientes, v_dbo)
       dbo = m_DBO_ControlIncidencias_Clientes
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntControlIncidencias_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spClientes2
       s.cargar_Clientes(Me.cbocliente)
       If me.mododeapertura = VISION Then
           Me.cbocliente.enabled = False
           Me.lblId_cliente.enabled = False
       End If
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ControlIncidencias_Clientes = new dbo_ControlIncidencias_Clientes
       Else
       Me.m_DBO_ControlIncidencias_Clientes = dbo
       End If

           cbocliente.SelectedValue = m_DBO_ControlIncidencias_Clientes.Id_cliente
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

       If cbocliente.SelectedValue is Nothing then
           If errores = "" Then cbocliente.Focus()
           errores = errores & "No seleccionó un valor para Id_cliente." & Environment.NewLine
       Else
       m_DBO_ControlIncidencias_Clientes.Id_cliente = System.Convert.ToInt32(cbocliente.SelectedValue)
       End If
       If errores = String.empty then
         Dbo = m_DBO_ControlIncidencias_Clientes
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_control_incidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butVerId_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_cliente.Click
        Dim frmEnt As New frmClientes()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_cliente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_cliente.Click
        Dim DBO_Clientes As New DBO_Clientes
        Dim frmEnt As New frmEntClientes(0, 0)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spClientes2
        s.cargar_Clientes(Me.cbocliente)
    End Sub

    Private Sub frmEntControlIncidencias_Clientes_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Panel1, Me)
    End Sub
End Class
