Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntSegumientosIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave

    Private m_DBO_SegumientosIncidencias As DBO_SegumientosIncidencias

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spSegumientosIncidencias = Nothing, Optional ByRef v_dbo As DBO_SegumientosIncidencias = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spSegumientosIncidencias, v_sp)
        m_DBO_SegumientosIncidencias = If(v_dbo Is Nothing, New DBO_SegumientosIncidencias, v_dbo)
        dbo = m_DBO_SegumientosIncidencias
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spSegumientosIncidencias, New DBO_SegumientosIncidencias)
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntSegumientosIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s2 As New spTiposSeguimientos
        s2.cargar_TiposSeguimientos(Me.cbotipoSeguimiento)

        Dim s3 As New spEmpleados
        s3.cargar_Empleados(Me.cboResponsable)
        If Me.ModoDeApertura = VISION Then
            Me.cboResponsable.Enabled = False
            Me.lblResponsable.Enabled = False
            Me.cbotipoSeguimiento.Enabled = False
            Me.lblId_tipoSeguimiento.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores

        Me.m_DBO_SegumientosIncidencias = dbo

        cbotipoSeguimiento.SelectedValue = m_DBO_SegumientosIncidencias.Id_tipoSeguimiento
        cboResponsable.SelectedValue = m_DBO_SegumientosIncidencias.Responsable
        dtpFecha.Text = m_DBO_SegumientosIncidencias.Fecha.ToString
        txtObservaciones.Text = m_DBO_SegumientosIncidencias.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty



        If cbotipoSeguimiento.SelectedValue Is Nothing Then
            If errores = "" Then cbotipoSeguimiento.Focus()
            errores = errores & "No seleccionó un valor para Id_tipoSeguimiento." & Environment.NewLine
        Else
            m_DBO_SegumientosIncidencias.Id_tipoSeguimiento = System.Convert.ToInt32(cbotipoSeguimiento.SelectedValue)
        End If

        If cboResponsable.SelectedValue Is Nothing Then
            If errores = "" Then cboResponsable.Focus()
            errores = errores & "No seleccionó un valor para Responsable." & Environment.NewLine
        Else
            m_DBO_SegumientosIncidencias.Responsable = System.Convert.ToInt32(cboResponsable.SelectedValue)
        End If

        m_DBO_SegumientosIncidencias.Fecha = dtpFecha.Value.Date
        m_DBO_SegumientosIncidencias.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_SegumientosIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerId_tipoSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_tipoSeguimiento.Click
        Dim frmEnt As New frmTiposSeguimientos()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_tipoSeguimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_tipoSeguimiento.Click
        Dim DBO_TiposSeguimientos As New DBO_TiposSeguimientos
        Dim frmEnt As New frmEntTiposSeguimientos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposSeguimientos, DBO_TiposSeguimientos)
        frmEnt.ShowDialog()
        Dim s As New spTiposSeguimientos
        s.cargar_TiposSeguimientos(Me.cbotipoSeguimiento)
    End Sub

    Private Sub butVerResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerResponsable.Click
        Dim frmEnt As New frmEmpleados()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddResponsable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddResponsable.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        frmEnt.ShowDialog()
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboResponsable)
    End Sub

End Class
