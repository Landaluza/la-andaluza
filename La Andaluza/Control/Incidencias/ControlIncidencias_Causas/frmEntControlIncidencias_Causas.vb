Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlIncidencias_Causas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ControlIncidencias_Causas As DBO_ControlIncidencias_Causas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_Causas = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_Causas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spControlIncidencias_Causas, v_sp)
        m_DBO_ControlIncidencias_Causas = If(v_dbo Is Nothing, New DBO_ControlIncidencias_Causas, v_dbo)
        dbo = m_DBO_ControlIncidencias_Causas
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntControlIncidencias_Causas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spCausas
        s.cargar_Causas(Me.cbocausa, dtb)

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboempleado, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboempleado.Enabled = False
            Me.lblId_empleado.Enabled = False
            Me.cbocausa.Enabled = False
            Me.lblId_causa.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_ControlIncidencias_Causas = dbo

        cbocausa.SelectedValue = m_DBO_ControlIncidencias_Causas.Id_causa
        cboempleado.SelectedValue = m_DBO_ControlIncidencias_Causas.Id_empleado
        txtObservaciones.Text = m_DBO_ControlIncidencias_Causas.Observaciones
        dtpFecha.Text = m_DBO_ControlIncidencias_Causas.Fecha.ToString
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If cbocausa.SelectedValue Is Nothing Then
            If errores = "" Then cbocausa.Focus()
            errores = errores & "No seleccionó un valor para Id_causa." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_Causas.Id_causa = System.Convert.ToInt32(cbocausa.SelectedValue)
        End If

        If cboempleado.SelectedValue Is Nothing Then
            If errores = "" Then cboempleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_Causas.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
        End If
        m_DBO_ControlIncidencias_Causas.Observaciones = txtObservaciones.Text


        m_DBO_ControlIncidencias_Causas.Fecha = dtpFecha.Value.Date


        If errores = String.Empty Then
            dbo = m_DBO_ControlIncidencias_Causas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_causa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_causa.Click
        Dim frmEnt As New frmCausas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_causa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_causa.Click
        Dim DBO_Causas As New DBO_Causas
        Dim frmEnt As New frmEntCausas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spCausas, DBO_Causas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spCausas
        s.cargar_Causas(Me.cbocausa, dtb)
    End Sub

    Private Sub butVerId_control_incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_control_incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
    End Sub

End Class
