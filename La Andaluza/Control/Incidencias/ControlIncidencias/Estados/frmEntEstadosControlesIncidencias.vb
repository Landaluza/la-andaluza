Public Class frmEntEstadosControlesIncidencias
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_EstadosControlesIncidencias As DBO_EstadosControlesIncidencias

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEstadosControlesIncidencias = Nothing, Optional ByRef v_dbo As DBO_EstadosControlesIncidencias = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spEstadosControlesIncidencias, v_sp)
       m_DBO_EstadosControlesIncidencias = if(v_dbo Is Nothing, New DBO_EstadosControlesIncidencias, v_dbo)
       dbo = m_DBO_EstadosControlesIncidencias
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spEstadosControlesIncidencias, new DBO_EstadosControlesIncidencias)
       InitializeComponent()
   End Sub

   Private Sub frmEntEstadosControlesIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_EstadosControlesIncidencias = new dbo_EstadosControlesIncidencias
       Else
       Me.m_DBO_EstadosControlesIncidencias = dbo
       End If

           txtNombre.Text = m_DBO_EstadosControlesIncidencias.Nombre
           txtObservaciones.Text = m_DBO_EstadosControlesIncidencias.Observaciones
           txtValor.Text = m_DBO_EstadosControlesIncidencias.Valor
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vacío." & Environment.NewLine
       Else
       m_DBO_EstadosControlesIncidencias.Nombre = txtNombre.Text
       End If



       m_DBO_EstadosControlesIncidencias.Observaciones = txtObservaciones.Text


       m_DBO_EstadosControlesIncidencias.Valor = System.Convert.ToInt32( txtValor.Text)


       If errores = String.empty then
         Dbo = m_DBO_EstadosControlesIncidencias
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

End Class
