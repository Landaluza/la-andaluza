Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPeriodosServicio
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_PeriodosServicio As DBO_PeriodosServicio

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spPeriodosServicio = Nothing, Optional ByRef v_dbo As DBO_PeriodosServicio = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spPeriodosServicio, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_PeriodosServicio = If(v_dbo Is Nothing, New DBO_PeriodosServicio, v_dbo)
        dbo = m_DBO_PeriodosServicio
        Me.dtpDesde.activarFoco()
        Me.dtpHasta.activarFoco()
    End Sub

    Public Sub New()
        MyBase.New(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, CType(New spPeriodosServicio, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_PeriodosServicio, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        Me.dtpDesde.activarFoco()
        Me.dtpHasta.activarFoco()
    End Sub

    Private Sub frmEntPeriodosServicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spMotivosCeseServicio
        s0.cargar_MotivosCeseServicio(Me.cboMotivoCeseServicio)
        If Me.ModoDeApertura = VISION Then
            Me.cboMotivoCeseServicio.Enabled = False
            Me.lblMotivoCeseServicioID.Enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddMotivoCeseServicioID.Enabled = False
            butVerMotivoCeseServicioID.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_PeriodosServicio = New DBO_PeriodosServicio
        Else
            Me.m_DBO_PeriodosServicio = CType(dbo, DBO_PeriodosServicio)
        End If

        cboMotivoCeseServicio.SelectedValue = m_DBO_PeriodosServicio.MotivoCeseServicioID
        dtpDesde.Value = m_DBO_PeriodosServicio.Desde
        dtpHasta.Value = m_DBO_PeriodosServicio.Hasta
        txtObservaciones.Text = m_DBO_PeriodosServicio.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_PeriodosServicio.Desde = dtpDesde.Value
        m_DBO_PeriodosServicio.Hasta = dtpHasta.Value

        If dtpDesde.Value > dtpHasta.Value Then
            errores = errores & Environment.NewLine & "El inicio no puede ser mayor que el final"
        End If

        m_DBO_PeriodosServicio.Observaciones = txtObservaciones.Text
        If cboMotivoCeseServicio.SelectedValue Is Nothing Then
            errores = errores & Environment.NewLine & "No selecciono un motivo"
        End If
        m_DBO_PeriodosServicio.MotivoCeseServicioID = cboMotivoCeseServicio.SelectedValue

        If errores = String.Empty Then
            dbo = CType(m_DBO_PeriodosServicio, BasesParaCompatibilidad.DataBussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerMotivoCeseServicioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerMotivoCeseServicioID.Click
        Dim frmEnt As New frmMotivosCeseServicio()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddMotivoCeseServicioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddMotivoCeseServicioID.Click
        Dim DBO_MotivosCeseServicio As New DBO_MotivosCeseServicio
        Dim frmEnt As New frmEntMotivosCeseServicio(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spMotivosCeseServicio, DBO_MotivosCeseServicio)
        frmEnt.ShowDialog()
        Dim s As New spMotivosCeseServicio
        s.cargar_MotivosCeseServicio(Me.cboMotivoCeseServicio)
    End Sub

    Private Sub frmEntPeriodosServicio_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
