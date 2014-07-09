Public Class frmEntAgenciasTransportes
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_AgenciasTransportes As DBO_AgenciasTransportes

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAgenciasTransportes = Nothing, Optional ByRef v_dbo As DBO_AgenciasTransportes = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spAgenciasTransportes,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_AgenciasTransportes = if(v_dbo Is Nothing, New DBO_AgenciasTransportes, v_dbo)
       dbo = m_DBO_AgenciasTransportes
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spAgenciasTransportes,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_AgenciasTransportes,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_AgenciasTransportes = new dbo_AgenciasTransportes
       Else
       Me.m_DBO_AgenciasTransportes = ctype(dbo, DBO_AgenciasTransportes)
       End If

           txtNombre.Text = m_DBO_AgenciasTransportes.Nombre
           txtObservaciones.Text = m_DBO_AgenciasTransportes.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_AgenciasTransportes.Nombre = txtNombre.Text
       End If



       m_DBO_AgenciasTransportes.Observaciones = txtObservaciones.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_AgenciasTransportes, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntAgenciasTransportes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
