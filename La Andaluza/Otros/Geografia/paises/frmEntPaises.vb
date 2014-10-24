Public Class frmEntPaises
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Paises As DBO_Paises

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPaises = Nothing, Optional ByRef v_dbo As DBO_Paises = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spPaises, v_sp)
       m_DBO_Paises = if(v_dbo Is Nothing, New DBO_Paises, v_dbo)
       dbo = m_DBO_Paises
   End Sub

    Public Sub New()
        MyBase.new()
        InitializeComponent()
        sp = New spPaises
        m_DBO_Paises = New DBO_Paises
        dbo = m_DBO_Paises
    End Sub

   Private Sub frmEntPaises_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_Paises = new dbo_Paises
       Else
       Me.m_DBO_Paises = dbo
       End If

           txtPais.Text = m_DBO_Paises.Pais
           txtNombre.Text = m_DBO_Paises.Nombre

   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

       If txtPais.Text= "" then
           If errores = "" Then txtPais.Focus()
           errores = errores & "El campo Pais no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_Paises.Pais = txtPais.Text
       End If
       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_Paises.Nombre = txtNombre.Text
       End If

       If errores = String.empty then
         Dbo = m_DBO_Paises
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

End Class
