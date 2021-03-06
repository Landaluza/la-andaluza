Public Class frmEntMuestrasCantidades
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_MuestrasCantidades As DBO_MuestrasCantidades

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMuestrasCantidades = Nothing, Optional ByRef v_dbo As DBO_MuestrasCantidades = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spMuestrasCantidades,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_MuestrasCantidades = if(v_dbo Is Nothing, New DBO_MuestrasCantidades, v_dbo)
       dbo = m_DBO_MuestrasCantidades
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spMuestrasCantidades,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_MuestrasCantidades,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_MuestrasCantidades = New DBO_MuestrasCantidades
        Else
            Me.m_DBO_MuestrasCantidades = CType(dbo, DBO_MuestrasCantidades)
        End If

        txtDescripcion.Text = m_DBO_MuestrasCantidades.Descripcion
    End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vac�o." & Environment.NewLine()
       Else
       m_DBO_MuestrasCantidades.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty Then
         Dbo = ctype(m_DBO_MuestrasCantidades, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub


End Class
