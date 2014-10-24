Public Class frmEntIdiomas
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_Idiomas As DBO_Idiomas

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spIdiomas = Nothing, Optional ByRef v_dbo As DBO_Idiomas = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spIdiomas,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Idiomas = IIf(v_dbo Is Nothing, New DBO_Idiomas, v_dbo)
       dbo = m_DBO_Idiomas
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spIdiomas,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_Idiomas,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntIdiomas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.UserType <> 4 and Config.UserType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_Idiomas = new dbo_Idiomas
       Else
       Me.m_DBO_Idiomas = ctype(dbo, DBO_Idiomas)
       End If

           txtDescripcion.Text = m_DBO_Idiomas.Descripcion
           chbTraduccion.Checked = m_DBO_Idiomas.Traduccion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Idiomas.Descripcion = txtDescripcion.Text
       End If



       m_DBO_Idiomas.Traduccion = chbTraduccion.Checked

       If (errores = String.empty) then
         Dbo = ctype(m_DBO_Idiomas, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub frmEntIdiomas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
