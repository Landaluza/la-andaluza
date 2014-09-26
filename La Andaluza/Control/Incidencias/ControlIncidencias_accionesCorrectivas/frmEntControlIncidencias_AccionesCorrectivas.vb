Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlIncidencias_AccionesCorrectivas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ControlIncidencias_AccionesCorrectivas As DBO_ControlIncidencias_AccionesCorrectivas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_AccionesCorrectivas = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_AccionesCorrectivas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spControlIncidencias_AccionesCorrectivas, v_sp)
        m_DBO_ControlIncidencias_AccionesCorrectivas = If(v_dbo Is Nothing, New DBO_ControlIncidencias_AccionesCorrectivas, v_dbo)
        dbo = m_DBO_ControlIncidencias_AccionesCorrectivas
        dtpFechaPrevista.activarFoco()

    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaPrevista.activarFoco()

    End Sub

    Private Sub frmEntControlIncidencias_AccionesCorrectivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s2 As New spAccionesCorrectivas
        s2.cargar_AccionesCorrectivas(Me.cboAccionCorrectiva)

        Dim s3 As New spEmpleados
        s3.cargar_Empleados(Me.cboid_empleado)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_empleado.Enabled = False
            Me.lblid_empleado.Enabled = False
            Me.cboAccionCorrectiva.Enabled = False
            Me.lblId_AccionCorrectiva.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        Me.m_DBO_ControlIncidencias_AccionesCorrectivas = dbo

        cboAccionCorrectiva.SelectedValue = m_DBO_ControlIncidencias_AccionesCorrectivas.Id_AccionCorrectiva
        txtObservaciones.Text = m_DBO_ControlIncidencias_AccionesCorrectivas.Observaciones
        cboid_empleado.SelectedValue = m_DBO_ControlIncidencias_AccionesCorrectivas.id_empleado
        dtpFechaPrevista.Text = m_DBO_ControlIncidencias_AccionesCorrectivas.FechaPrevista.ToString
        txtResultados.Text = m_DBO_ControlIncidencias_AccionesCorrectivas.Resultados
        chbRealizado.Checked = m_DBO_ControlIncidencias_AccionesCorrectivas.Realizado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If cboAccionCorrectiva.SelectedValue Is Nothing Then
            If errores = "" Then cboAccionCorrectiva.Focus()
            errores = errores & "No seleccionó un valor para Id_AccionCorrectiva." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_AccionesCorrectivas.Id_AccionCorrectiva = System.Convert.ToInt32(cboAccionCorrectiva.SelectedValue)
        End If
        If txtObservaciones.Text = "" Then
            If errores = "" Then txtObservaciones.Focus()
            errores = errores & "El campo Observaciones no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_AccionesCorrectivas.Observaciones = txtObservaciones.Text
        End If



        If cboid_empleado.SelectedValue Is Nothing Then
            If errores = "" Then cboid_empleado.Focus()
            errores = errores & "No seleccionó un valor para id_empleado." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_AccionesCorrectivas.id_empleado = System.Convert.ToInt32(cboid_empleado.SelectedValue)
        End If
        m_DBO_ControlIncidencias_AccionesCorrectivas.FechaPrevista = dtpFechaPrevista.Value.Date


        m_DBO_ControlIncidencias_AccionesCorrectivas.Resultados = txtResultados.Text

        m_DBO_ControlIncidencias_AccionesCorrectivas.Realizado = chbRealizado.Checked

        If errores = String.Empty Then
            dbo = m_DBO_ControlIncidencias_AccionesCorrectivas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_control_incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_control_incidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butVerId_AccionCorrectiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_AccionCorrectiva.Click
        Dim frmEnt As New frmAccionesCorrectivas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_AccionCorrectiva_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_AccionCorrectiva.Click
        Dim DBO_AccionesCorrectivas As New DBO_AccionesCorrectivas
        Dim frmEnt As New frmEntAccionesCorrectivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spAccionesCorrectivas, DBO_AccionesCorrectivas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAccionesCorrectivas
        s.cargar_AccionesCorrectivas(Me.cboAccionCorrectiva)
    End Sub

    Private Sub butVerid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboid_empleado)
    End Sub

End Class
