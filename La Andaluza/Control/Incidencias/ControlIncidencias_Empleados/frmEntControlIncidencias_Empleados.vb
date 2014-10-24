Public Class frmEntControlIncidencias_Empleados
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ControlIncidencias_Empleados As DBO_ControlIncidencias_Empleados

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_Empleados = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_Empleados = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spControlIncidencias_Empleados, v_sp)
       m_DBO_ControlIncidencias_Empleados = if(v_dbo Is Nothing, New DBO_ControlIncidencias_Empleados, v_dbo)
       dbo = m_DBO_ControlIncidencias_Empleados
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntControlIncidencias_Empleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboempleado, dtb)
       If me.mododeapertura = VISION Then
           Me.cboempleado.enabled = False
           Me.lblId_empleado.enabled = False
       End If
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ControlIncidencias_Empleados = new dbo_ControlIncidencias_Empleados
       Else
       Me.m_DBO_ControlIncidencias_Empleados = dbo
       End If

           cboempleado.SelectedValue = m_DBO_ControlIncidencias_Empleados.Id_empleado
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

       If cboempleado.SelectedValue is Nothing then
           If errores = "" Then cboempleado.Focus()
           errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
       Else
       m_DBO_ControlIncidencias_Empleados.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
       End If
       If errores = String.empty then
         Dbo = m_DBO_ControlIncidencias_Empleados
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_control_incidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
    End Sub

    Private Sub frmEntControlIncidencias_Empleados_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Panel1, Me)
    End Sub
End Class
