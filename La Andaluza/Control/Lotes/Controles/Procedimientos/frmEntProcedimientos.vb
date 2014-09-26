Public Class frmEntProcedimientos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_Procedimientos As DBO_Procedimientos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProcedimientos = Nothing, Optional ByRef v_dbo As DBO_Procedimientos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spProcedimientos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Procedimientos = if(v_dbo Is Nothing, New DBO_Procedimientos, v_dbo)
       dbo = m_DBO_Procedimientos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spProcedimientos,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_Procedimientos,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntProcedimientos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       butVer.Visible = True
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Procedimientos = new dbo_Procedimientos
       Else
       Me.m_DBO_Procedimientos = ctype(dbo, DBO_Procedimientos)
       End If

           txtDescripcion.Text = m_DBO_Procedimientos.Descripcion
           txtObservaciones.Text = m_DBO_Procedimientos.Observaciones
           txtRuta.Text = m_DBO_Procedimientos.Ruta
           txtN_version.Text = m_DBO_Procedimientos.N_version
           txtCodigo.Text = m_DBO_Procedimientos.Codigo
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Procedimientos.Descripcion = txtDescripcion.Text
       End If



       m_DBO_Procedimientos.Observaciones = txtObservaciones.Text


       If txtRuta.Text= "" then
           If errores = "" Then txtRuta.Focus()
           errores = errores & "El campo Ruta no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_Procedimientos.Ruta = txtRuta.Text
       End If



       If not isNumeric(txtN_version.Text) then
           If errores = "" Then txtN_version.Focus()
           errores = errores & "El campo N_version debe ser numérico." & Environment.NewLine()
       Else
       m_DBO_Procedimientos.N_version = System.Convert.ToInt32(txtN_version.Text)
       End If


       m_DBO_Procedimientos.Codigo = txtCodigo.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_Procedimientos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
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

   Private Sub frmEntProcedimientos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(Me.tlpMiddle, Me)
   End Sub
End Class
