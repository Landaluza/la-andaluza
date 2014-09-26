Public Class frmEntTiposPendientes
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_TiposPendientes As DBO_TiposPendientes

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposPendientes = Nothing, Optional ByRef v_dbo As DBO_TiposPendientes = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposPendientes,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposPendientes = if(v_dbo Is Nothing, New DBO_TiposPendientes, v_dbo)
       dbo = m_DBO_TiposPendientes
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spTiposPendientes,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_TiposPendientes,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_TiposPendientes = new dbo_TiposPendientes
       Else
       Me.m_DBO_TiposPendientes = ctype(dbo, DBO_TiposPendientes)
       End If

           txtDescripcion.Text = m_DBO_TiposPendientes.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_TiposPendientes.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty Then
         Dbo = ctype(m_DBO_TiposPendientes, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntTiposPendientes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(Me.tlpMiddle, Me)
   End Sub
End Class
