Public Class frmEntempresas
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_empresas As DBO_empresas

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spempresas = Nothing, Optional ByRef v_dbo As DBO_empresas = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spempresas, v_sp)
       m_DBO_empresas = if(v_dbo Is Nothing, New DBO_empresas, v_dbo)
       dbo = m_DBO_empresas
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntempresas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_empresas = new dbo_empresas
       Else
       Me.m_DBO_empresas = dbo
       End If
           txtnombre.Text = m_DBO_empresas.nombre
           txtruta_logo.Text = m_DBO_empresas.ruta_logo
           txtfax.Text = m_DBO_empresas.fax
           txttlf.Text = m_DBO_empresas.tlf
           txtemail.Text = m_DBO_empresas.email
           txtweb.Text = m_DBO_empresas.web
           txtdireccion.Text = m_DBO_empresas.direccion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty
       m_DBO_empresas.nombre = txtnombre.Text
       m_DBO_empresas.ruta_logo = txtruta_logo.Text
       m_DBO_empresas.fax = txtfax.Text
       m_DBO_empresas.tlf = txttlf.Text
       m_DBO_empresas.email = txtemail.Text
       m_DBO_empresas.web = txtweb.Text
       m_DBO_empresas.direccion = txtdireccion.Text
       If errores = String.empty then
         Dbo = m_DBO_empresas
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtruta_logo.Text = BasesParaCompatibilidad.File.Elegir_archivo
    End Sub
End Class
