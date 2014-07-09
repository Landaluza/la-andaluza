Public Class frmEntCategoriaIncidencias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_CategoriaIncidencias As DBO_CategoriaIncidencias

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCategoriaIncidencias = Nothing, Optional ByRef v_dbo As DBO_CategoriaIncidencias = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spCategoriaIncidencias, v_sp)
       m_DBO_CategoriaIncidencias = if(v_dbo Is Nothing, New DBO_CategoriaIncidencias, v_dbo)
       dbo = m_DBO_CategoriaIncidencias
   End Sub

   Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCategoriaIncidencias, New DBO_CategoriaIncidencias)
       InitializeComponent()
   End Sub

   Private Sub frmEntCategoriaIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_CategoriaIncidencias = new dbo_CategoriaIncidencias
       Else
       Me.m_DBO_CategoriaIncidencias = dbo
       End If

           txtDescripcion.Text = m_DBO_CategoriaIncidencias.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_CategoriaIncidencias.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty then
         Dbo = m_DBO_CategoriaIncidencias
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
