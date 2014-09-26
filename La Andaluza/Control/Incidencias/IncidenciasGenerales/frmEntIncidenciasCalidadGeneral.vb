Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntIncidenciasCalidadGeneral
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_IncidenciasCalidadGeneral As DBO_IncidenciasCalidadGeneral
    Private frmIncidenciasCalidadGeneral_tiposIncEnv As frmIncidenciasCalidadGeneral_tiposIncEnv

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spIncidenciasCalidadGeneral = Nothing, Optional ByRef v_dbo As DBO_IncidenciasCalidadGeneral = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spIncidenciasCalidadGeneral, v_sp)
        m_DBO_IncidenciasCalidadGeneral = If(v_dbo Is Nothing, New DBO_IncidenciasCalidadGeneral, v_dbo)
        dbo = m_DBO_IncidenciasCalidadGeneral
        dtpFechaApertura.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaApertura.activarFoco()
    End Sub

    Private Sub frmEntIncidenciasCalidadGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado)

        Dim s2 As New spArticulosTipos
        s2.cargar_ArticulosTipos(Me.cboArticuloTipo)

        Dim s3 As New spProcesosCalidad
        s3.cargar_ProcesosCalidad(Me.cboprocesoCalidad)
        If Me.ModoDeApertura = VISION Then
            Me.cboprocesoCalidad.Enabled = False
            Me.lblId_procesoCalidad.Enabled = False
            Me.cboArticuloTipo.Enabled = False
            Me.lblId_ArticuloTipo.Enabled = False
            Me.cboempleado.Enabled = False
            Me.lblId_empleado.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_IncidenciasCalidadGeneral = New DBO_IncidenciasCalidadGeneral
            Engine_LA.FormEnPestaña(New Form, tpTipo)
        Else
            Me.m_DBO_IncidenciasCalidadGeneral = dbo

            frmIncidenciasCalidadGeneral_tiposIncEnv = New frmIncidenciasCalidadGeneral_tiposIncEnv(Me.m_DBO_IncidenciasCalidadGeneral.ID)
            Engine_LA.FormEnPestaña(frmIncidenciasCalidadGeneral_tiposIncEnv, tpTipo)
        End If

        dtpFechaApertura.Text = m_DBO_IncidenciasCalidadGeneral.FechaApertura.ToString
        cboempleado.SelectedValue = m_DBO_IncidenciasCalidadGeneral.Id_empleado
        txtDescripcion.Text = m_DBO_IncidenciasCalidadGeneral.Descripcion
        cboArticuloTipo.SelectedValue = m_DBO_IncidenciasCalidadGeneral.Id_ArticuloTipo
        cboprocesoCalidad.SelectedValue = m_DBO_IncidenciasCalidadGeneral.Id_procesoCalidad
        txtCriterioFrecuenciaBaja.Text = m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaBaja
        txtCriterioFrecuenciaMedia.Text = m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaMedia
        txtCriterioFrecuenciaAlta.Text = m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaAlta
        txtCriterioGravedadLeve.Text = m_DBO_IncidenciasCalidadGeneral.CriterioGravedadLeve
        txtCriterioGravedadModerada.Text = m_DBO_IncidenciasCalidadGeneral.CriterioGravedadModerada
        txtCriterioGravedadGrave.Text = m_DBO_IncidenciasCalidadGeneral.CriterioGravedadGrave
        chbCalidad.Checked = m_DBO_IncidenciasCalidadGeneral.Calidad
        chbMedioAmbiente.Checked = m_DBO_IncidenciasCalidadGeneral.MedioAmbiente
        chbPRL.Checked = m_DBO_IncidenciasCalidadGeneral.PRL
        chbInocuidadAlimentos.Checked = m_DBO_IncidenciasCalidadGeneral.InocuidadAlimentos
        chbFormacion.Checked = m_DBO_IncidenciasCalidadGeneral.Formacion
        chbEstrategicos.Checked = m_DBO_IncidenciasCalidadGeneral.Estrategicos
        txtDetalles.Text = m_DBO_IncidenciasCalidadGeneral.Detalles
        chbVisible.Checked = m_DBO_IncidenciasCalidadGeneral.Visible
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_IncidenciasCalidadGeneral.FechaApertura = dtpFechaApertura.Value.Date


        If cboempleado.SelectedValue Is Nothing Then
            If errores = "" Then cboempleado.Focus()
            errores = errores & "No seleccionó un valor para Id_empleado." & Environment.NewLine
        Else
            m_DBO_IncidenciasCalidadGeneral.Id_empleado = System.Convert.ToInt32(cboempleado.SelectedValue)
        End If
        m_DBO_IncidenciasCalidadGeneral.Descripcion = txtDescripcion.Text


        If cboprocesoCalidad.SelectedValue Is Nothing Then
            If errores = "" Then cboprocesoCalidad.Focus()
            errores = errores & "No seleccionó un valor para Id_procesoCalidad." & Environment.NewLine
        Else
            m_DBO_IncidenciasCalidadGeneral.Id_procesoCalidad = System.Convert.ToInt32(cboprocesoCalidad.SelectedValue)
        End If

        m_DBO_IncidenciasCalidadGeneral.Id_ArticuloTipo = Me.cboArticuloTipo.SelectedValue

        m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaBaja = txtCriterioFrecuenciaBaja.Text


        m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaMedia = txtCriterioFrecuenciaMedia.Text


        m_DBO_IncidenciasCalidadGeneral.CriterioFrecuenciaAlta = txtCriterioFrecuenciaAlta.Text


        m_DBO_IncidenciasCalidadGeneral.CriterioGravedadLeve = txtCriterioGravedadLeve.Text


        m_DBO_IncidenciasCalidadGeneral.CriterioGravedadModerada = txtCriterioGravedadModerada.Text


        m_DBO_IncidenciasCalidadGeneral.CriterioGravedadGrave = txtCriterioGravedadGrave.Text


        m_DBO_IncidenciasCalidadGeneral.Calidad = chbCalidad.Checked

        m_DBO_IncidenciasCalidadGeneral.MedioAmbiente = chbMedioAmbiente.Checked

        m_DBO_IncidenciasCalidadGeneral.PRL = chbPRL.Checked

        m_DBO_IncidenciasCalidadGeneral.InocuidadAlimentos = chbInocuidadAlimentos.Checked

        m_DBO_IncidenciasCalidadGeneral.Formacion = chbFormacion.Checked

        m_DBO_IncidenciasCalidadGeneral.Estrategicos = chbEstrategicos.Checked

        m_DBO_IncidenciasCalidadGeneral.Detalles = txtDetalles.Text


        m_DBO_IncidenciasCalidadGeneral.Visible = chbVisible.Checked

        If errores = String.Empty Then
            dbo = m_DBO_IncidenciasCalidadGeneral
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
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
        s.cargar_Empleados(Me.cboempleado)
    End Sub

    Private Sub butVerId_ArticuloTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_ArticuloTipo.Click
        Dim frmEnt As New frmArticulosTipos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_ArticuloTipo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_ArticuloTipo.Click
        Dim DBO_ArticulosTipos As New DBO_ArticulosTipos
        Dim frmEnt As New frmEntArticulosTipos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spArticulosTipos, DBO_ArticulosTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spArticulosTipos
        s.cargar_ArticulosTipos(Me.cboArticuloTipo)
    End Sub

    Private Sub butVerId_procesoCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_procesoCalidad.Click
        Dim frmEnt As New frmProcesosCalidad()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_procesoCalidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_procesoCalidad.Click
        Dim DBO_ProcesosCalidad As New DBO_ProcesosCalidad
        Dim frmEnt As New frmEntProcesosCalidad(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProcesosCalidad, DBO_ProcesosCalidad)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProcesosCalidad
        s.cargar_ProcesosCalidad(Me.cboprocesoCalidad)
    End Sub

    Private Sub frmEntIncidenciasCalidadGeneral_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.Panel1, Me.SplitContainer1.Panel1)
    End Sub
End Class
