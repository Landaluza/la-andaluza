Public Class frmEntNaves
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_Naves As DBO_Naves

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spNaves = Nothing, Optional ByRef v_dbo As DBO_Naves = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spNaves,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Naves = if(v_dbo Is Nothing, New DBO_Naves, v_dbo)
       dbo = m_DBO_Naves
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spNaves,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_Naves,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Naves = New dbo_Naves
        Else
            Me.m_DBO_Naves = CType(dbo, DBO_Naves)
        End If

        txtDescripcion.Text = m_DBO_Naves.Descripcion
    End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Naves.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty Then
         Dbo = ctype(m_DBO_Naves, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub frmEntNaves_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
