Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntempleados_contratos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_empleados_contratos As DBO_empleados_contratos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spempleados_contratos = Nothing, Optional ByRef v_dbo As DBO_empleados_contratos = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spempleados_contratos, v_sp)
        m_DBO_empleados_contratos = If(v_dbo Is Nothing, New DBO_empleados_contratos, v_dbo)
        dbo = m_DBO_empleados_contratos
        Me.dtpfecha_baja.activarFoco()
        Me.dtpfecha_final.activarFoco()
        Me.dtpfecha_inicio.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        Me.dtpfecha_baja.activarFoco()
        Me.dtpfecha_final.activarFoco()
        Me.dtpfecha_inicio.activarFoco()
    End Sub

    Private Sub frmEntempleados_contratos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboid_empleado)

        Dim s2 As New spTipos_contratos
        s2.cargar_Tipos_contratos(Me.cboid_tipoContrato)

        Dim s3 As New spPuestosTrabajos
        s3.cargar_PuestosTrabajos(Me.cboid_puestoTrabajo)
        If Me.ModoDeApertura = VISION Then
            Me.cboid_puestoTrabajo.Enabled = False
            Me.lblid_puestoTrabajo.Enabled = False
            Me.cboid_empleado.Enabled = False
            Me.lblid_empleado.Enabled = False
            Me.cboid_tipoContrato.Enabled = False
            Me.lblid_tipoContrato.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_empleados_contratos = dbo

        dtpfecha_inicio.Text = m_DBO_empleados_contratos.fecha_inicio.ToString
        dtpfecha_final.Text = m_DBO_empleados_contratos.fecha_final.ToString
        dtpfecha_baja.Text = m_DBO_empleados_contratos.fecha_baja.ToString
        txtreferencia.Text = m_DBO_empleados_contratos.referencia
        txtobservaciones.Text = m_DBO_empleados_contratos.observaciones
        txtruta_documentacion.Text = m_DBO_empleados_contratos.ruta_documentacion
        cboid_empleado.SelectedValue = m_DBO_empleados_contratos.id_empleado
        cboid_tipoContrato.SelectedValue = m_DBO_empleados_contratos.id_tipoContrato
        cboid_puestoTrabajo.SelectedValue = m_DBO_empleados_contratos.id_puestoTrabajo
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If cbFin.Checked And (dtpfecha_inicio.Value > dtpfecha_final.Value Or (cbBaja.Checked And dtpfecha_inicio.Value > dtpfecha_baja.Value)) Then
            errores = errores & "La fecha de inicio no puede ser mayor que la de finalización." & Environment.NewLine
        Else
            m_DBO_empleados_contratos.fecha_inicio = dtpfecha_inicio.Value.Date
            If cbFin.Checked Then
                m_DBO_empleados_contratos.fecha_final = dtpfecha_final.Value.Date
            Else
                m_DBO_empleados_contratos.fecha_final = Nothing
            End If
        End If

        If Me.cbBaja.Checked Then
            m_DBO_empleados_contratos.fecha_baja = dtpfecha_baja.Value.Date
        Else
            m_DBO_empleados_contratos.fecha_baja = Nothing
        End If


        If txtreferencia.Text = "" Then
            If errores = "" Then txtreferencia.Focus()
            errores = errores & "El campo referencia no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_empleados_contratos.referencia = txtreferencia.Text
        End If

        If cboid_puestoTrabajo.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó un puesto." & Environment.NewLine
        Else
            m_DBO_empleados_contratos.id_puestoTrabajo = cboid_puestoTrabajo.SelectedValue
        End If


        If cboid_tipoContrato.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó un tipo de contrato." & Environment.NewLine
        Else
            m_DBO_empleados_contratos.id_tipoContrato = cboid_tipoContrato.SelectedValue
        End If

        m_DBO_empleados_contratos.observaciones = txtobservaciones.Text


        If txtruta_documentacion.Text = "" Then
            If errores = "" Then txtruta_documentacion.Focus()
            errores = errores & "El campo ruta_documentacion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_empleados_contratos.ruta_documentacion = txtruta_documentacion.Text
        End If



        If errores = String.Empty Then
            dbo = m_DBO_empleados_contratos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerid_tipoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_tipoContrato.Click
        Dim frmEnt As New frmTipos_contratos()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddid_tipoContrato_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_tipoContrato.Click
        Dim DBO_Tipos_contratos As New DBO_Tipos_contratos
        Dim frmEnt As New frmEntTipos_contratos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTipos_contratos, DBO_Tipos_contratos)
        frmEnt.ShowDialog()
        Dim s As New spTipos_contratos
        s.cargar_Tipos_contratos(Me.cboid_tipoContrato)
    End Sub

    Private Sub butVerid_puestoTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerid_puestoTrabajo.Click
        Dim frmEnt As New frmPuestosTrabajos()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddid_puestoTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddid_puestoTrabajo.Click
        Dim DBO_PuestosTrabajos As New DBO_PuestosTrabajos
        Dim frmEnt As New frmEntPuestosTrabajos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spPuestosTrabajos, DBO_PuestosTrabajos)
        frmEnt.ShowDialog()
        Dim s As New spPuestosTrabajos
        s.cargar_PuestosTrabajos(Me.cboid_puestoTrabajo)
    End Sub


    Private Sub cbBaja_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbBaja.CheckedChanged
        Me.dtpfecha_baja.Enabled = Me.cbBaja.Checked
    End Sub

    Private Sub btnruta_Click(sender As System.Object, e As System.EventArgs) Handles btnruta.Click
        Try
            Dim MyFolderBrowser As New System.Windows.Forms.OpenFileDialog
            MyFolderBrowser.InitialDirectory = "Z:\Recursos Humanos\Empleados\"

            Dim dlgResult As DialogResult = MyFolderBrowser.ShowDialog()

            If dlgResult = Windows.Forms.DialogResult.OK Then
                Me.txtruta_documentacion.Text = MyFolderBrowser.FileName
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cbFin_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbFin.CheckedChanged
        Me.dtpfecha_final.Enabled = cbFin.Checked
    End Sub
End Class
