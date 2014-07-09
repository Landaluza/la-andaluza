Public Class frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad As DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = Nothing, Optional ByRef v_dbo As DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad, v_sp)
       m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = if(v_dbo Is Nothing, New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad, v_dbo)
        dbo = m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad, new DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad)
       InitializeComponent()
   End Sub

   Private Sub frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s as new spIncidencias
       s.cargar_Incidencias(Me.cboIncidencia)
       If me.mododeapertura = VISION Then
           Me.cboIncidencia.enabled = False
           Me.lblId_Incidencia.enabled = False
           
       End If
      
        If Config.UserType = 3 Then
            Me.butVerId_Incidencia.Enabled = False
            Me.butAddId_Incidencia.Enabled = False
        End If
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = new dbo_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
       Else
       Me.m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad = dbo
       End If

           cboIncidencia.SelectedValue = m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Id_Incidencia
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If cboIncidencia.SelectedValue is Nothing then
           If errores = "" Then cboIncidencia.Focus()
           errores = errores & "No seleccionó un valor para Id_Incidencia." & Environment.NewLine
       Else
       m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad.Id_Incidencia = System.Convert.ToInt32(cboIncidencia.SelectedValue)
       End If
       
       If errores = String.empty then
         Dbo = m_DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerId_Incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_Incidencia.Click
       Dim frmEnt As New frmIncidencias()
       frmEnt.ShowDialog()
   End Sub

   Private Sub butAddId_Incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_Incidencia.Click
       Dim DBO_Incidencias As New DBO_Incidencias
        Dim frmEnt As New frmEntIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spIncidencias, DBO_Incidencias)
       frmEnt.ShowDialog()
       dim s as new spIncidencias
       s.cargar_Incidencias(Me.cboIncidencia)
   End Sub

   

End Class
