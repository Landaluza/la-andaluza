Public Class frmEntTiposDepositos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_TiposDepositos As DBO_TiposDepositos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposDepositos = Nothing, Optional ByRef v_dbo As DBO_TiposDepositos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposDepositos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposDepositos = If(v_dbo Is Nothing, New DBO_TiposDepositos, v_dbo)
       dbo = m_DBO_TiposDepositos
   End Sub

   Private Sub frmEntTiposDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_TiposDepositos = ctype(dbo, DBO_TiposDepositos)

           txtNombre.Text = m_DBO_TiposDepositos.Nombre
           txtObservaciones.Text = m_DBO_TiposDepositos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_TiposDepositos.Nombre = txtNombre.Text
       End If



       m_DBO_TiposDepositos.Observaciones = txtObservaciones.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposDepositos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntTiposDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
