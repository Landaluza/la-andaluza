Public Class frmEntMetodosAnalisis
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_MetodosAnalisis As DBO_MetodosAnalisis

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spMetodosAnalisis = Nothing, Optional ByRef v_dbo As DBO_MetodosAnalisis = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spMetodosAnalisis,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_MetodosAnalisis = if(v_dbo Is Nothing, New DBO_MetodosAnalisis, v_dbo)
       dbo = m_DBO_MetodosAnalisis
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spMetodosAnalisis,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_MetodosAnalisis,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntMetodosAnalisis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butVer.Visible = True
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_MetodosAnalisis = new dbo_MetodosAnalisis
       Else
       Me.m_DBO_MetodosAnalisis = ctype(dbo, DBO_MetodosAnalisis)
       End If

           txtDescripcion.Text = m_DBO_MetodosAnalisis.Descripcion
           txtRuta.Text = m_DBO_MetodosAnalisis.Ruta
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_MetodosAnalisis.Descripcion = txtDescripcion.Text


       m_DBO_MetodosAnalisis.Ruta = txtRuta.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_MetodosAnalisis, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
       Dim arch As String
       'Cambiar "C:\" por la ruta adecuada
        arch = BasesParaCompatibilidad.File.Elegir_archivo("C:\")

       If Me.Text.Substring(0, 3) <> "Ver" Then
           txtRuta.Text = arch
       End If 
   End Sub

   Public Overrides Sub Ver()
       Try
           Dim psi As New ProcessStartInfo()
           psi.UseShellExecute = True
           psi.FileName = txtRuta.Text
           Process.Start(psi)
       Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
       End Try
   End Sub

   Private Sub frmEntMetodosAnalisis_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(Me.tlpMiddle, Me)
   End Sub
End Class
