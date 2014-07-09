Public Class frmEntConductores
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_Conductores As DBO_Conductores

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spConductores = Nothing, Optional ByRef v_dbo As DBO_Conductores = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spConductores,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Conductores = if(v_dbo Is Nothing, New DBO_Conductores, v_dbo)
       dbo = m_DBO_Conductores
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spConductores,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_Conductores,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Conductores = New dbo_Conductores
        Else
            Me.m_DBO_Conductores = CType(dbo, DBO_Conductores)
        End If

        txtNombre.Text = m_DBO_Conductores.Nombre
        txtApellido1.Text = m_DBO_Conductores.Apellido1
        txtApellido2.Text = m_DBO_Conductores.Apellido2
        txtApodo.Text = m_DBO_Conductores.Apodo
        txtDNI.Text = m_DBO_Conductores.DNI
        txtMovil.Text = m_DBO_Conductores.Movil
        txtObservaciones.Text = m_DBO_Conductores.Observaciones
    End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_Conductores.Nombre = txtNombre.Text


       m_DBO_Conductores.Apellido1 = txtApellido1.Text


       m_DBO_Conductores.Apellido2 = txtApellido2.Text


       m_DBO_Conductores.Apodo = txtApodo.Text


       m_DBO_Conductores.DNI = txtDNI.Text


       m_DBO_Conductores.Movil = txtMovil.Text


       m_DBO_Conductores.Observaciones = txtObservaciones.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_Conductores, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntConductores_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
