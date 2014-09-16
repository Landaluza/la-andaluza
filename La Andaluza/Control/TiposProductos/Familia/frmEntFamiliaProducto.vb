Public Class frmEntFamiliaProducto
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_FamiliaProducto As DBO_FamiliaProducto

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFamiliaProducto = Nothing, Optional ByRef v_dbo As DBO_FamiliaProducto = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spFamiliaProducto,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_FamiliaProducto = If(v_dbo Is Nothing, New DBO_FamiliaProducto, v_dbo)
       dbo = m_DBO_FamiliaProducto
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spFamiliaProducto,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_FamiliaProducto, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntFamiliaProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_FamiliaProducto = new dbo_FamiliaProducto
       Else
       Me.m_DBO_FamiliaProducto = ctype(dbo, DBO_FamiliaProducto)
       End If

           txtNombre.Text = m_DBO_FamiliaProducto.Nombre
           txtObservaciones.Text = m_DBO_FamiliaProducto.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_FamiliaProducto.Nombre = txtNombre.Text
       End If



       m_DBO_FamiliaProducto.Observaciones = txtObservaciones.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_FamiliaProducto, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntFamiliaProducto_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
