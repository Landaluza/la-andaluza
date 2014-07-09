Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntReconocimientosMedicos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ReconocimientosMedicos As DBO_ReconocimientosMedicos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spReconocimientosMedicos = Nothing, Optional ByRef v_dbo As DBO_ReconocimientosMedicos = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spReconocimientosMedicos, v_sp)
        m_DBO_ReconocimientosMedicos = If(v_dbo Is Nothing, New DBO_ReconocimientosMedicos, v_dbo)
        dbo = m_DBO_ReconocimientosMedicos
        dtpFechaRealizado.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaRealizado.activarFoco()
    End Sub

    Private Sub frmEntReconocimientosMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spReconocimientosMedicosSolicitudesEmpleados
        s.cargar_combobox(Me.cboReconocimientoMedicoSolicitudEmpleado)

        Dim s2 As New spGrupos_riesgo
        s2.cargar_Grupos_riesgo(Me.cboid_grupo_riesgo)

        Dim s3 As New spMedicos
        s3.cargar_Medicos(Me.cboid_medico)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_medico.Enabled = False
            Me.lblid_medico.Enabled = False
            Me.cboid_grupo_riesgo.Enabled = False
            Me.lblid_grupo_riesgo.Enabled = False
            Me.cboReconocimientoMedicoSolicitudEmpleado.Enabled = False
            Me.lblReconocimientoMedicoSolicitudEmpleadoID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ReconocimientosMedicos = New DBO_ReconocimientosMedicos
        Else
            Me.m_DBO_ReconocimientosMedicos = dbo
        End If

        cboReconocimientoMedicoSolicitudEmpleado.SelectedValue = m_DBO_ReconocimientosMedicos.ReconocimientoMedicoSolicitudEmpleadoID
        dtpFechaRealizado.Text = m_DBO_ReconocimientosMedicos.FechaRealizado.ToString
        chbApto.Checked = m_DBO_ReconocimientosMedicos.Apto
        cboid_grupo_riesgo.SelectedValue = m_DBO_ReconocimientosMedicos.id_grupo_riesgo
        cboid_medico.SelectedValue = m_DBO_ReconocimientosMedicos.id_medico
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If cboReconocimientoMedicoSolicitudEmpleado.SelectedValue Is Nothing Then
            If errores = "" Then cboReconocimientoMedicoSolicitudEmpleado.Focus()
            errores = errores & "No seleccionó un valor para ReconocimientoMedicoSolicitudEmpleadoID." & Environment.NewLine
        Else
            m_DBO_ReconocimientosMedicos.ReconocimientoMedicoSolicitudEmpleadoID = System.Convert.ToInt32(cboReconocimientoMedicoSolicitudEmpleado.SelectedValue)
        End If

        m_DBO_ReconocimientosMedicos.id_grupo_riesgo = cboid_grupo_riesgo.SelectedValue
        m_DBO_ReconocimientosMedicos.id_medico = cboid_medico.SelectedValue
        m_DBO_ReconocimientosMedicos.FechaRealizado = dtpFechaRealizado.Value.Date


        m_DBO_ReconocimientosMedicos.Apto = chbApto.Checked

        If errores = String.Empty Then
            dbo = m_DBO_ReconocimientosMedicos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerReconocimientoMedicoSolicitudEmpleadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerReconocimientoMedicoSolicitudEmpleadoID.Click
        Dim frmEnt As New frmReconocimientosMedicosSolicitudesEmpleados()
        frmEnt.ShowDialog()
        Dim s As New spReconocimientosMedicosSolicitudesEmpleados
        s.cargar_combobox(Me.cboReconocimientoMedicoSolicitudEmpleado)
    End Sub

    Private Sub butAddReconocimientoMedicoSolicitudEmpleadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddReconocimientoMedicoSolicitudEmpleadoID.Click
        Dim DBO_ReconocimientosMedicosSolicitudesEmpleados As New DBO_ReconocimientosMedicosSolicitudesEmpleados
        Dim frmEnt As New frmEntReconocimientosMedicosSolicitudesEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spReconocimientosMedicosSolicitudesEmpleados, DBO_ReconocimientosMedicosSolicitudesEmpleados)
        frmEnt.ShowDialog()
        Dim s As New spReconocimientosMedicosSolicitudesEmpleados
        s.cargar_combobox(Me.cboReconocimientoMedicoSolicitudEmpleado)
    End Sub

    Private Sub butVerid_grupo_riesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_grupo_riesgo.Click
        Dim frmEnt As New frmGrupos_riesgo()
        frmEnt.ShowDialog()
        Dim s As New spGrupos_riesgo
        s.cargar_Grupos_riesgo(Me.cboid_grupo_riesgo)
    End Sub

    Private Sub butAddid_grupo_riesgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_grupo_riesgo.Click
        Dim DBO_Grupos_riesgo As New DBO_Grupos_riesgo
        Dim frmEnt As New frmEntGrupos_riesgo(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spGrupos_riesgo, DBO_Grupos_riesgo)
        frmEnt.ShowDialog()
        Dim s As New spGrupos_riesgo
        s.cargar_Grupos_riesgo(Me.cboid_grupo_riesgo)
    End Sub

    Private Sub butVerid_medico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_medico.Click
        Dim frmEnt As New frmMedicos()
        frmEnt.ShowDialog()
        Dim s As New spMedicos
        s.cargar_Medicos(Me.cboid_medico)
    End Sub

    Private Sub butAddid_medico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_medico.Click
        Dim DBO_Medicos As New DBO_Medicos
        Dim frmEnt As New frmEntMedicos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spMedicos, DBO_Medicos)
        frmEnt.ShowDialog()
        Dim s As New spMedicos
        s.cargar_Medicos(Me.cboid_medico)
    End Sub


End Class
