Public Class frmEntPersonalCompetencias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PersonalCompetencias As DBO_PersonalCompetencias

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPersonalCompetencias = Nothing, Optional ByRef v_dbo As DBO_PersonalCompetencias = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spPersonalCompetencias, v_sp)
       m_DBO_PersonalCompetencias = if(v_dbo Is Nothing, New DBO_PersonalCompetencias, v_dbo)
       dbo = m_DBO_PersonalCompetencias
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntPersonalCompetencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_PersonalCompetencias = new dbo_PersonalCompetencias
       Else
       Me.m_DBO_PersonalCompetencias = dbo
       End If

           txtDescripcion.Text = m_DBO_PersonalCompetencias.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_PersonalCompetencias.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty then
         Dbo = m_DBO_PersonalCompetencias
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
