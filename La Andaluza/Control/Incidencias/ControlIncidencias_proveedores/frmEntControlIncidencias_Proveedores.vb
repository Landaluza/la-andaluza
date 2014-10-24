Public Class frmEntControlIncidencias_Proveedores
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ControlIncidencias_Proveedores As DBO_ControlIncidencias_Proveedores

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_Proveedores = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_Proveedores = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spControlIncidencias_Proveedores, v_sp)
       m_DBO_ControlIncidencias_Proveedores = if(v_dbo Is Nothing, New DBO_ControlIncidencias_Proveedores, v_dbo)
       dbo = m_DBO_ControlIncidencias_Proveedores
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntControlIncidencias_Proveedores_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s2 As New spProveedores
        s2.cargar_Proveedores(Me.cboid_proveedor, dtb)
       If me.mododeapertura = VISION Then
           Me.cboid_proveedor.enabled = False
           Me.lblid_proveedor.enabled = False
       End If
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ControlIncidencias_Proveedores = new dbo_ControlIncidencias_Proveedores
       Else
       Me.m_DBO_ControlIncidencias_Proveedores = dbo
       End If

           cboid_proveedor.SelectedValue = m_DBO_ControlIncidencias_Proveedores.id_proveedor
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

       If cboid_proveedor.SelectedValue is Nothing then
           If errores = "" Then cboid_proveedor.Focus()
           errores = errores & "No seleccionó un valor para id_proveedor." & Environment.NewLine
       Else
       m_DBO_ControlIncidencias_Proveedores.id_proveedor = System.Convert.ToInt32(cboid_proveedor.SelectedValue)
       End If
       If errores = String.empty then
         Dbo = m_DBO_ControlIncidencias_Proveedores
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



    Private Sub butVerid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_proveedor.Click
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboid_proveedor, dtb)
    End Sub

    Private Sub frmEntControlIncidencias_Proveedores_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Panel1, Me)
    End Sub
End Class
