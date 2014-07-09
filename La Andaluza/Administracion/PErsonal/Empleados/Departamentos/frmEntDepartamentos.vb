Public Class frmEntDepartamentos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Departamentos As DBO_Departamentos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDepartamentos = Nothing, Optional ByRef v_dbo As DBO_Departamentos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spDepartamentos, v_sp)
       m_DBO_Departamentos = if(v_dbo Is Nothing, New DBO_Departamentos, v_dbo)
       dbo = m_DBO_Departamentos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spDepartamentos, new DBO_Departamentos)
       InitializeComponent()
   End Sub

   Private Sub frmEntDepartamentos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Departamentos = new dbo_Departamentos
       Else
       Me.m_DBO_Departamentos = dbo
       End If

           txtNombre.Text = m_DBO_Departamentos.Nombre
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_Departamentos.Nombre = txtNombre.Text


       If errores = String.empty then
         Dbo = m_DBO_Departamentos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

End Class
