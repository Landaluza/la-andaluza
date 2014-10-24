Public Class frmEntParametrosTipos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ParametrosTipos As DBO_ParametrosTipos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spParametrosTipos = Nothing, Optional ByRef v_dbo As DBO_ParametrosTipos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spParametrosTipos, v_sp)
       m_DBO_ParametrosTipos = if(v_dbo Is Nothing, New DBO_ParametrosTipos, v_dbo)
       dbo = m_DBO_ParametrosTipos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntParametrosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ParametrosTipos = new dbo_ParametrosTipos
       Else
       Me.m_DBO_ParametrosTipos = dbo
       End If

           txtnombre.Text = m_DBO_ParametrosTipos.nombre
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_ParametrosTipos.nombre = txtnombre.Text


       If errores = String.empty then
         Dbo = m_DBO_ParametrosTipos
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
