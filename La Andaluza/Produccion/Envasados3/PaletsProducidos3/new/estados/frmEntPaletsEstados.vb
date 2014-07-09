Public Class frmEntPaletsEstados
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As System.Object, e As System.EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_PaletsEstados As DBO_PaletsEstados

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPaletsEstados = Nothing, Optional ByRef v_dbo As DBO_PaletsEstados = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spPaletsEstados,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_PaletsEstados = IIf(v_dbo Is Nothing, New DBO_PaletsEstados, v_dbo)
       dbo = m_DBO_PaletsEstados
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spPaletsEstados,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_PaletsEstados,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntPaletsEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.UserType <> 4 and Config.UserType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_PaletsEstados = new dbo_PaletsEstados
       Else
       Me.m_DBO_PaletsEstados = ctype(dbo, DBO_PaletsEstados)
       End If

           txtnombre.Text = m_DBO_PaletsEstados.nombre
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtnombre.Text= "" then
           If errores = "" Then txtnombre.Focus()
           errores = errores & "El campo nombre no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_PaletsEstados.nombre = txtnombre.Text
       End If



       If (errores = String.empty) then
         Dbo = ctype(m_DBO_PaletsEstados, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntPaletsEstados_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
