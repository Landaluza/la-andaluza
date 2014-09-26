Public Class frmEntReconocimientosMedicosSolicitudesEmpleados
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ReconocimientosMedicosSolicitudesEmpleados As DBO_ReconocimientosMedicosSolicitudesEmpleados

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReconocimientosMedicosSolicitudesEmpleados = Nothing, Optional ByRef v_dbo As DBO_ReconocimientosMedicosSolicitudesEmpleados = Nothing)
       MyBase.new(modoDeApertura, v_sp, v_dbo)
       InitializeComponent()
       sp = if(v_sp Is Nothing, New spReconocimientosMedicosSolicitudesEmpleados, v_sp)
       m_DBO_ReconocimientosMedicosSolicitudesEmpleados = if(v_dbo Is Nothing, New DBO_ReconocimientosMedicosSolicitudesEmpleados, v_dbo)
       dbo = m_DBO_ReconocimientosMedicosSolicitudesEmpleados
   End Sub

   Public Sub New()
       InitializeComponent()
   End Sub

   Private Sub frmEntReconocimientosMedicosSolicitudesEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s as new spReconocimientosMedicosSolicitudes
        s.cargar_ReconocimientosMedicosSolicitudes(Me.cboReconocimientoMedicoSolicitud)

        Dim s2 As New spEmpleados
        s2.cargar_empleados(Me.cboEmpleado)

       If me.mododeapertura = VISION Then
           Me.cboEmpleado.enabled = False
           Me.lblEmpleadoID.enabled = False
            Me.cboReconocimientoMedicoSolicitud.Enabled = False
            Me.lblReconocimientoMedicoSolicitudID.Enabled = False
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_ReconocimientosMedicosSolicitudesEmpleados = new dbo_ReconocimientosMedicosSolicitudesEmpleados
       Else
       Me.m_DBO_ReconocimientosMedicosSolicitudesEmpleados = dbo
       End If

           cboReconocimientoMedicoSolicitud.SelectedValue = m_DBO_ReconocimientosMedicosSolicitudesEmpleados.ReconocimientoMedicoSolicitudID
           cboEmpleado.SelectedValue = m_DBO_ReconocimientosMedicosSolicitudesEmpleados.EmpleadoID
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty

        If cboEmpleado.SelectedValue is Nothing Then
            If errores = "" Then cboEmpleado.Focus()
            errores = errores & "No seleccionó un valor para empleado." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicosSolicitudesEmpleados.EmpleadoID = System.Convert.ToInt32(cboEmpleado.SelectedValue)
        End If

       If cboReconocimientoMedicoSolicitud.SelectedValue is Nothing then
           If errores = "" Then cboReconocimientoMedicoSolicitud.Focus()
           errores = errores & "No seleccionó un valor para ReconocimientoMedicoSolicitudID." & Environment.NewLine
       Else
       m_DBO_ReconocimientosMedicosSolicitudesEmpleados.ReconocimientoMedicoSolicitudID = System.Convert.ToInt32(cboReconocimientoMedicoSolicitud.SelectedValue)
       End If
       If errores = String.empty then
         Dbo = m_DBO_ReconocimientosMedicosSolicitudesEmpleados
         return true
       Else
         messagebox.show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK , MessageBoxIcon.Error )
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

   Private Sub butVerReconocimientoMedicoSolicitudID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerReconocimientoMedicoSolicitudID.Click
       Dim frmEnt As New frmReconocimientosMedicosSolicitudes()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicosSolicitudes
        s.cargar_ReconocimientosMedicosSolicitudes(Me.cboReconocimientoMedicoSolicitud)
    End Sub

    Private Sub butAddReconocimientoMedicoSolicitudID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddReconocimientoMedicoSolicitudID.Click
        Dim DBO_ReconocimientosMedicosSolicitudes As New DBO_ReconocimientosMedicosSolicitudes
        Dim frmEnt As New frmEntReconocimientosMedicosSolicitudes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spReconocimientosMedicosSolicitudes, DBO_ReconocimientosMedicosSolicitudes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spReconocimientosMedicosSolicitudes
        s.cargar_ReconocimientosMedicosSolicitudes(Me.cboReconocimientoMedicoSolicitud)
    End Sub

    Private Sub butVerEmpleadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

  

End Class
