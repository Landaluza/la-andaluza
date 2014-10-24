Public Class frmEntControlIncidencias_AccionesPreventivas
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_ControlIncidencias_AccionesPreventivas As DBO_ControlIncidencias_AccionesPreventivas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias_AccionesPreventivas = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias_AccionesPreventivas = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spControlIncidencias_AccionesPreventivas, v_sp)
        m_DBO_ControlIncidencias_AccionesPreventivas = if(v_dbo Is Nothing, New DBO_ControlIncidencias_AccionesPreventivas, v_dbo)
        dbo = m_DBO_ControlIncidencias_AccionesPreventivas
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntControlIncidencias_AccionesPreventivas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s As New spAccionesPreventivas
        s.cargar_AccionesPreventivas(Me.cboAccionesPreventivas, dtb)

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboempleado, dtb)
        If Me.mododeapertura = VISION Then
            Me.cboempleado.enabled = False
            Me.lblId_empleado.enabled = False
            Me.cboAccionesPreventivas.Enabled = False
            Me.lblId_AccionesPreventivas.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_ControlIncidencias_AccionesPreventivas = dbo

        cboAccionesPreventivas.SelectedValue = m_DBO_ControlIncidencias_AccionesPreventivas.Id_AccionesPreventivas
        txtDescripcion.Text = m_DBO_ControlIncidencias_AccionesPreventivas.Descripcion
        cboempleado.SelectedValue = m_DBO_ControlIncidencias_AccionesPreventivas.Id_empleado
        dtpFechaPrevista.Text = m_DBO_ControlIncidencias_AccionesPreventivas.FechaPrevista.toString
        dtpFechaInicio.Text = m_DBO_ControlIncidencias_AccionesPreventivas.FechaInicio.toString
        txtResultados.Text = m_DBO_ControlIncidencias_AccionesPreventivas.Resultados
        chbRealizado.Checked = m_DBO_ControlIncidencias_AccionesPreventivas.Realizado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        If cboAccionesPreventivas.SelectedValue is Nothing Then
            If errores = "" Then cboAccionesPreventivas.Focus()
            errores = errores & "No seleccionó un valor para Id_AccionesPreventivas." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_AccionesPreventivas.Id_AccionesPreventivas = System.Convert.ToInt32(cboAccionesPreventivas.SelectedValue)
        End If
        m_DBO_ControlIncidencias_AccionesPreventivas.Descripcion = txtDescripcion.Text


        If cboempleado.SelectedValue is Nothing Then
            If errores = "" Then cboempleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias_AccionesPreventivas.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
        End If
        m_DBO_ControlIncidencias_AccionesPreventivas.FechaPrevista = dtpFechaPrevista.Value.Date


        m_DBO_ControlIncidencias_AccionesPreventivas.FechaInicio = dtpFechaInicio.Value.Date


        m_DBO_ControlIncidencias_AccionesPreventivas.Resultados = txtResultados.Text


        m_DBO_ControlIncidencias_AccionesPreventivas.Realizado = chbRealizado.Checked

        If errores = String.empty Then
            Dbo = m_DBO_ControlIncidencias_AccionesPreventivas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butVerId_ControlIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_ControlIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butVerId_AccionesPreventivas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_AccionesPreventivas.Click
        Dim frmEnt As New frmAccionesPreventivas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_AccionesPreventivas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_AccionesPreventivas.Click
        Dim DBO_AccionesPreventivas As New DBO_AccionesPreventivas
        Dim frmEnt As New frmEntAccionesPreventivas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spAccionesPreventivas, DBO_AccionesPreventivas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAccionesPreventivas
        s.cargar_AccionesPreventivas(Me.cboAccionesPreventivas, dtb)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado, dtb)
    End Sub

End Class
