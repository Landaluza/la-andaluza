Public Class frmEntDDDProductos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_DDDProductos As DBO_DDDProductos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDDDProductos = Nothing, Optional ByRef v_dbo As DBO_DDDProductos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spDDDProductos, v_sp)
       m_DBO_DDDProductos = if(v_dbo Is Nothing, New DBO_DDDProductos, v_dbo)
       dbo = m_DBO_DDDProductos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntDDDProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       butVer.Visible = True
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_DDDProductos = new dbo_DDDProductos
       Else
       Me.m_DBO_DDDProductos = dbo
       End If

           txtDescripcion.Text = m_DBO_DDDProductos.Descripcion
           txtRutaFicha.Text = m_DBO_DDDProductos.RutaFicha
           txtObservaciones.Text = m_DBO_DDDProductos.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_DDDProductos.Descripcion = txtDescripcion.Text


       m_DBO_DDDProductos.RutaFicha = txtRutaFicha.Text


       m_DBO_DDDProductos.Observaciones = txtObservaciones.Text


       If errores = String.empty then
         Dbo = m_DBO_DDDProductos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub butRutaFicha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaFicha.Click
       Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaFicha.Text, "", "Z:\")
       If Me.Text.Substring(0, 3) <> "Ver" Then
           txtRutaFicha.Text = arch
       End If 
   End Sub

   Public Overrides Sub Ver()
       Try
           Dim psi As New ProcessStartInfo()
           psi.UseShellExecute = True
           psi.FileName = txtRutaFicha.Text
           Process.Start(psi)
       Catch ex As Exception
           messagebox.show(ex.Message)
       End Try
   End Sub

End Class
