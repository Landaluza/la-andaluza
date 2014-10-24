Public Class frmEntDDDAcciones
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_DDDAcciones As DBO_DDDAcciones

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDDDAcciones = Nothing, Optional ByRef v_dbo As DBO_DDDAcciones = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spDDDAcciones, v_sp)
       m_DBO_DDDAcciones = if(v_dbo Is Nothing, New DBO_DDDAcciones, v_dbo)
       dbo = m_DBO_DDDAcciones
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntDDDAcciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_DDDAcciones = new dbo_DDDAcciones
       Else
       Me.m_DBO_DDDAcciones = dbo
       End If

           txtDescripcion.Text = m_DBO_DDDAcciones.Descripcion
           txtObservaciones.Text = m_DBO_DDDAcciones.Observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_DDDAcciones.Descripcion = txtDescripcion.Text


       m_DBO_DDDAcciones.Observaciones = txtObservaciones.Text


       If errores = String.empty then
         Dbo = m_DBO_DDDAcciones
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
