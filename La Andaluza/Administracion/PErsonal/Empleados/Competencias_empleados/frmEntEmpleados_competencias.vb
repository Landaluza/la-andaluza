Public Class frmEntEmpleados_competencias
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Empleados_competencias As DBO_Empleados_competencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spEmpleados_competencias = Nothing, Optional ByRef v_dbo As DBO_Empleados_competencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spEmpleados_competencias, v_sp)
        m_DBO_Empleados_competencias = if(v_dbo Is Nothing, New DBO_Empleados_competencias, v_dbo)
        dbo = m_DBO_Empleados_competencias
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntEmpleados_competencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboid_empleado, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboid_empleado.enabled = False
            Me.lblid_empleado.enabled = False

        End If
        Dim s2 As New spPersonalCompetencias
        s2.cargar_PersonalCompetencias(Me.cboid_personalCompetencia, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboid_personalCompetencia.enabled = False
            Me.lblid_personalCompetencia.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_Empleados_competencias = dbo

        cboid_empleado.SelectedValue = m_DBO_Empleados_competencias.id_empleado
        cboid_personalCompetencia.SelectedValue = m_DBO_Empleados_competencias.id_personalCompetencia
        chbactivo.Checked = m_DBO_Empleados_competencias.activo
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        'If cboid_empleado.SelectedValue is Nothing Then
        '    If errores = "" Then cboid_empleado.Focus()
        '    errores = errores & "No seleccionó un valor para id_empleado." & Environment.NewLine
        'Else
        '    m_DBO_Empleados_competencias.id_empleado = System.Convert.ToInt32(cboid_empleado.SelectedValue)
        'End If

        If cboid_personalCompetencia.SelectedValue Is Nothing Then
            If errores = "" Then cboid_personalCompetencia.Focus()
            errores = errores & "No seleccionó un valor para competencia." & Environment.NewLine
        Else
            m_DBO_Empleados_competencias.id_personalCompetencia = System.Convert.ToInt32(cboid_personalCompetencia.SelectedValue)
        End If
        m_DBO_Empleados_competencias.activo = chbactivo.Checked

        If errores = String.empty Then
            Dbo = m_DBO_Empleados_competencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboid_empleado, dtb)
    End Sub

    Private Sub butVerid_personalCompetencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_personalCompetencia.Click
        Dim frmEnt As New frmPersonalCompetencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_personalCompetencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_personalCompetencia.Click
        Dim DBO_PersonalCompetencias As New DBO_PersonalCompetencias
        Dim frmEnt As New frmEntPersonalCompetencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spPersonalCompetencias, DBO_PersonalCompetencias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spPersonalCompetencias
        s.cargar_PersonalCompetencias(Me.cboid_personalCompetencia, dtb)
    End Sub


End Class
