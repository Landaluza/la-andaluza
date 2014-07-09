Public Class frmEntReconocimientosMedicosTipos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable

    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ReconocimientosMedicosTipos As DBO_ReconocimientosMedicosTipos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReconocimientosMedicosTipos = Nothing, Optional ByRef v_dbo As DBO_ReconocimientosMedicosTipos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spReconocimientosMedicosTipos, v_sp)
       m_DBO_ReconocimientosMedicosTipos = if(v_dbo Is Nothing, New DBO_ReconocimientosMedicosTipos, v_dbo)
       dbo = m_DBO_ReconocimientosMedicosTipos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntReconocimientosMedicosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ReconocimientosMedicosTipos = new dbo_ReconocimientosMedicosTipos
       Else
       Me.m_DBO_ReconocimientosMedicosTipos = dbo
       End If

           txtDescripcion.Text = m_DBO_ReconocimientosMedicosTipos.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_ReconocimientosMedicosTipos.Descripcion = txtDescripcion.Text
       End If



       If errores = String.empty then
         Dbo = m_DBO_ReconocimientosMedicosTipos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
