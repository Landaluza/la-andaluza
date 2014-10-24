Public Class frmEntMotivosCeseServicio
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_MotivosCeseServicio As DBO_MotivosCeseServicio

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMotivosCeseServicio = Nothing, Optional ByRef v_dbo As DBO_MotivosCeseServicio = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spMotivosCeseServicio,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_MotivosCeseServicio = if(v_dbo Is Nothing, New DBO_MotivosCeseServicio, v_dbo)
       dbo = m_DBO_MotivosCeseServicio
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spMotivosCeseServicio,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_MotivosCeseServicio,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_MotivosCeseServicio = New dbo_MotivosCeseServicio
        Else
            Me.m_DBO_MotivosCeseServicio = CType(dbo, DBO_MotivosCeseServicio)
        End If

        txtDescripcion.Text = m_DBO_MotivosCeseServicio.Descripcion
        txtObservaciones.Text = m_DBO_MotivosCeseServicio.Observaciones
    End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_MotivosCeseServicio.Descripcion = txtDescripcion.Text


       m_DBO_MotivosCeseServicio.Observaciones = txtObservaciones.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_MotivosCeseServicio, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub frmEntMotivosCeseServicio_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
