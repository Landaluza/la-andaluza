Public Class frmEntAccionesInmediatas_ControlIncidencias
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_AccionesInmediatas_ControlIncidencias As DBO_AccionesInmediatas_ControlIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAccionesInmediatas_ControlIncidencias = Nothing, Optional ByRef v_dbo As DBO_AccionesInmediatas_ControlIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = if(v_sp Is Nothing, New spAccionesInmediatas_ControlIncidencias, v_sp)
        m_DBO_AccionesInmediatas_ControlIncidencias = if(v_dbo Is Nothing, New DBO_AccionesInmediatas_ControlIncidencias, v_dbo)
        dbo = m_DBO_AccionesInmediatas_ControlIncidencias
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntAccionesInmediatas_ControlIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s As New spAccionesInmediatas
        s.cargar_AccionesInmediatas(Me.cboAccionesInmediatas)
     
        Dim s2 As New spEmpleados
        s2.cargar_empleados(Me.cboid_empleado)
        If Me.mododeapertura = VISION Then
            Me.cboid_empleado.enabled = False
            Me.lblid_empleado.enabled = False
            Me.cboAccionesInmediatas.Enabled = False
            Me.lblId_AccionesInmediatas.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        Me.m_DBO_AccionesInmediatas_ControlIncidencias = dbo

        cboAccionesInmediatas.SelectedValue = m_DBO_AccionesInmediatas_ControlIncidencias.Id_AccionesInmediatas
        txtDescripcion.Text = m_DBO_AccionesInmediatas_ControlIncidencias.Descripcion
        cboid_empleado.SelectedValue = m_DBO_AccionesInmediatas_ControlIncidencias.id_empleado
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty

        If cboAccionesInmediatas.SelectedValue is Nothing Then
            If errores = "" Then cboAccionesInmediatas.Focus()
            errores = errores & "No seleccionó un valor para Id_AccionesInmediatas." & Environment.NewLine
        Else
            m_DBO_AccionesInmediatas_ControlIncidencias.Id_AccionesInmediatas = System.Convert.ToInt32(cboAccionesInmediatas.SelectedValue)
        End If

        If cboid_empleado.SelectedValue is Nothing Then
            If errores = "" Then cboid_empleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_AccionesInmediatas_ControlIncidencias.id_empleado = Me.cboid_empleado.SelectedValue
        End If

        m_DBO_AccionesInmediatas_ControlIncidencias.Descripcion = txtDescripcion.Text
        m_DBO_AccionesInmediatas_ControlIncidencias.id_empleado = Me.cboid_empleado.SelectedValue

        If errores = String.empty Then
            Dbo = m_DBO_AccionesInmediatas_ControlIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As sqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_ControlIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_ControlIncidencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub butVerId_AccionesInmediatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_AccionesInmediatas.Click
        Dim frmEnt As New frmAccionesInmediatas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_AccionesInmediatas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_AccionesInmediatas.Click
        Dim DBO_AccionesInmediatas As New DBO_AccionesInmediatas
        Dim frmEnt As New frmEntAccionesInmediatas(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spAccionesInmediatas, DBO_AccionesInmediatas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAccionesInmediatas
        s.cargar_AccionesInmediatas(Me.cboAccionesInmediatas)
    End Sub

    Private Sub butVerid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_empleado.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddid_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_empleados(Me.cboid_empleado)
    End Sub

End Class
