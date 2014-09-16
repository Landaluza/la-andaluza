Public Class frmEntClasesProductos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_ClasesProductos As DBO_ClasesProductos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spClasesProductos = Nothing, Optional ByRef v_dbo As DBO_ClasesProductos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spClasesProductos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_ClasesProductos = If(v_dbo Is Nothing, New DBO_ClasesProductos, v_dbo)
       dbo = m_DBO_ClasesProductos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spClasesProductos,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_ClasesProductos, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntClasesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_ClasesProductos = new dbo_ClasesProductos
       Else
       Me.m_DBO_ClasesProductos = ctype(dbo, DBO_ClasesProductos)
       End If

           txtNombre.Text = m_DBO_ClasesProductos.Nombre
           txtObservaciones.Text = m_DBO_ClasesProductos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_ClasesProductos.Nombre = txtNombre.Text
       End If



       m_DBO_ClasesProductos.Observaciones = txtObservaciones.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_ClasesProductos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
