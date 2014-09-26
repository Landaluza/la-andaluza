Public Class frmEntCamiones
    inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements  BasesParaCompatibilidad.savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
    Private m_DBO_Camiones As DBO_Camiones

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spCamiones = Nothing, Optional ByRef v_dbo As DBO_Camiones = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        If v_sp Is Nothing Then
            sp = CType(New spCamiones, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_Camiones = if(v_dbo Is Nothing, New DBO_Camiones, v_dbo)
        dbo = m_DBO_Camiones
    End Sub

    Public Sub New()
        MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, CType(New spCamiones, BasesParaCompatibilidad.StoredProcedure), CType(New DBO_Camiones, BasesParaCompatibilidad.databussines))
        InitializeComponent()
    End Sub

    Private Sub frmEntCamiones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s0 As New spAgenciasTransportes
        s0.cargar_AgenciasTransportes(Me.cboAgenciaTransporte)
        Dim s1 As New spConductores
        s1.cargar_Conductores(Me.cboConductorHabitual)
        Dim s2 As New spCamionesTipos
        s2.cargar_CamionesTipos(Me.cboCamionTipo)
        If Me.mododeapertura = VISION Then
            Me.cboAgenciaTransporte.enabled = False
            Me.lblAgenciaTransporteID.enabled = False

            Me.cboConductorHabitual.enabled = False
            Me.lblConductorHabitualID.enabled = False

            Me.cboCamionTipo.enabled = False
            Me.lblCamionTipoID.enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddAgenciaTransporteID.enabled = False
            butVerAgenciaTransporteID.enabled = False
            butAddConductorHabitualID.enabled = False
            butVerConductorHabitualID.enabled = False
            butAddCamionTipoID.enabled = False
            butVerCamionTipoID.enabled = False
        End If
    End Sub

    Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
         If Me.modoDeApertura = INSERCION Then
            Me.m_DBO_Camiones = New dbo_Camiones
        Else
            Me.m_DBO_Camiones = CType(dbo, DBO_Camiones)
        End If

        cboAgenciaTransporte.SelectedValue = m_DBO_Camiones.AgenciaTransporteID
        cboConductorHabitual.SelectedValue = m_DBO_Camiones.ConductorHabitualID
        cboCamionTipo.SelectedValue = m_DBO_Camiones.CamionTipoID
        txtMatriculaCabeza.Text = m_DBO_Camiones.MatriculaCabeza
        txtMatriculaRemolque.Text = m_DBO_Camiones.MatriculaRemolque
        txtTara.Text = m_DBO_Camiones.Tara
        txtPesoMaximo.Text = m_DBO_Camiones.PesoMaximo
        txtObservaciones.Text = m_DBO_Camiones.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores As String = String.empty


        If cboAgenciaTransporte.SelectedValue Is Nothing Then
            If errores = "" Then cboAgenciaTransporte.Focus()
            errores = errores & "No seleccionó un valor para AgenciaTransporteID." & Environment.NewLine()
        Else
            m_DBO_Camiones.AgenciaTransporteID = System.Convert.ToInt32(cboAgenciaTransporte.SelectedValue)
        End If
        If cboConductorHabitual.SelectedValue Is Nothing Then
            If errores = "" Then cboConductorHabitual.Focus()
            errores = errores & "No seleccionó un valor para ConductorHabitualID." & Environment.NewLine()
        Else
            m_DBO_Camiones.ConductorHabitualID = System.Convert.ToInt32(cboConductorHabitual.SelectedValue)
        End If
        If cboCamionTipo.SelectedValue Is Nothing Then
            If errores = "" Then cboCamionTipo.Focus()
            errores = errores & "No seleccionó un valor para CamionTipoID." & Environment.NewLine()
        Else
            m_DBO_Camiones.CamionTipoID = System.Convert.ToInt32(cboCamionTipo.SelectedValue)
        End If

        m_DBO_Camiones.MatriculaCabeza = txtMatriculaCabeza.Text
        m_DBO_Camiones.MatriculaRemolque = txtMatriculaRemolque.Text
        m_DBO_Camiones.Tara = System.Convert.ToInt32(txtTara.Text)


        m_DBO_Camiones.PesoMaximo = System.Convert.ToInt32(txtPesoMaximo.Text)


        m_DBO_Camiones.Observaciones = txtObservaciones.Text


        If errores = String.empty Then
            Dbo = CType(m_DBO_Camiones, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements  BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerAgenciaTransporteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerAgenciaTransporteID.Click
        Dim frmEnt As New frmAgenciasTransportes()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddAgenciaTransporteID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddAgenciaTransporteID.Click
        Dim DBO_AgenciasTransportes As New DBO_AgenciasTransportes
        Dim frmEnt As New frmEntAgenciasTransportes(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spAgenciasTransportes, DBO_AgenciasTransportes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAgenciasTransportes
        s.cargar_AgenciasTransportes(Me.cboAgenciaTransporte)
    End Sub

    Private Sub butVerConductorHabitualID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerConductorHabitualID.Click
        Dim frmEnt As New frmConductores()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddConductorHabitualID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddConductorHabitualID.Click
        Dim DBO_Conductores As New DBO_Conductores
        Dim frmEnt As New frmEntConductores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spConductores, DBO_Conductores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spConductores
        s.cargar_Conductores(Me.cboConductorHabitual)
    End Sub

    Private Sub butVerCamionTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerCamionTipoID.Click
        Dim frmEnt As New frmCamionesTipos()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddCamionTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCamionTipoID.Click
        Dim DBO_CamionesTipos As New DBO_CamionesTipos
        Dim frmEnt As New frmEntCamionesTipos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCamionesTipos, DBO_CamionesTipos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spCamionesTipos
        s.cargar_CamionesTipos(Me.cboCamionTipo)
    End Sub

    Private Sub frmEntCamiones_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.Pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub
End Class
