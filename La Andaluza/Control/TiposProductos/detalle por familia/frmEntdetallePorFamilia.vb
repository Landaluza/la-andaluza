Public Class frmEntdetallePorFamilia
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_detallePorFamilia As DBO_detallePorFamilia

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spdetallePorFamilia = Nothing, Optional ByRef v_dbo As DBO_detallePorFamilia = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spdetallePorFamilia,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_detallePorFamilia = If(v_dbo Is Nothing, New DBO_detallePorFamilia, v_dbo)
       dbo = m_DBO_detallePorFamilia
   End Sub

   Private Sub frmEntdetallePorFamilia_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_detallePorFamilia = ctype(dbo, DBO_detallePorFamilia)

   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_detallePorFamilia, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntdetallePorFamilia_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
