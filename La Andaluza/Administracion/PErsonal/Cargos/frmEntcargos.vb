Public Class frmEntcargos
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_cargos As DBO_cargos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spcargos = Nothing, Optional ByRef v_dbo As DBO_cargos = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spcargos, v_sp)
       m_DBO_cargos = if(v_dbo Is Nothing, New DBO_cargos, v_dbo)
       dbo = m_DBO_cargos
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntcargos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_cargos = new dbo_cargos
       Else
       Me.m_DBO_cargos = dbo
       End If

           txtnombre.Text = m_DBO_cargos.nombre
           txtobservaciones.Text = m_DBO_cargos.observaciones
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtnombre.Text= "" then
           If errores = "" Then txtnombre.Focus()
           errores = errores & "El campo nombre no puede estar vacío." & Environment.NewLine
       Else
            m_DBO_cargos.nombre = txtnombre.Text
       End If



       m_DBO_cargos.observaciones = txtobservaciones.Text


       If errores = String.empty then
         Dbo = m_DBO_cargos
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

End Class
