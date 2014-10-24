Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ControlIncidencias As DBO_ControlIncidencias

    Private frmAccionesInmediatas_ControlIncidencias As frmAccionesInmediatas_ControlIncidencias
    Private frmControlIncidencias_AccionesCorrectivas As frmControlIncidencias_AccionesCorrectivas
    Private frmControlIncidencias_AccionesPreventivas As frmControlIncidencias_AccionesPreventivas
    Private frmControlIncidencias_Causas As frmControlIncidencias_Causas
    Private frmControlIncidencias_Origen As frmControlIncidencias_Origen
    Private frmIncidenciasEnvasadosAsignables As frmIncidenciasEnvasadosAsignables
    Private frmSegumientosIncidencias As frmSegumientosIncidencias
    Private frmGastos As frmGastosIncidencias
    Private frmANC As frmANC

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spControlIncidencias = Nothing, Optional ByRef v_dbo As DBO_ControlIncidencias = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spControlIncidencias, v_sp)
        m_DBO_ControlIncidencias = If(v_dbo Is Nothing, New DBO_ControlIncidencias, v_dbo)
        dbo = m_DBO_ControlIncidencias
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub frmEntControlIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProcesosCalidad
        s.cargar_ProcesosCalidad(Me.cboprocesoCalidad, dtb)

        Dim s2 As New spArticulosTipos
        s2.cargar_ArticulosTipos(Me.cboTipoArticulo, dtb)

        Dim s3 As New spIncidenciasCalidadGeneral
        s3.cargar_IncidenciasCalidadGeneral(Me.cboincidenciaCalidadGeneral, dtb)

        Dim s4 As New spEmpleados
        s4.cargar_Empleados(Me.cboid_empleado, dtb)

        Dim s5 As New spTiposGravedadesIncidencias
        s5.cargar_TiposGravedadesIncidencias(Me.cboPuntosGravedad, dtb)

        Dim s6 As New spTiposFrecuenciasIncidencias
        s6.cargar_TiposFrecuenciasIncidencias(Me.cboPuntosFrecuencia, dtb)

        Dim s7 As New spEstadosControlesIncidencias
        s7.cargar_estados(Me.cboEstado, dtb)

        If Me.ModoDeApertura = VISION Then
            Me.cboPuntosFrecuencia.Enabled = False
            Me.lblId_PuntosFrecuencia.Enabled = False

            Me.cboPuntosGravedad.Enabled = False
            Me.lblId_PuntosGravedad.Enabled = False

            Me.cboid_empleado.Enabled = False
            Me.lblid_empleado.Enabled = False

            Me.cboincidenciaCalidadGeneral.Enabled = False
            Me.lblId_incidenciaCalidadGeneral.Enabled = False

            Me.cboTipoArticulo.Enabled = False

            Me.cboprocesoCalidad.Enabled = False
            Me.lblId_procesoCalidad.Enabled = False

            Me.cboarticulo.Enabled = False
            Me.lblId_articulo.Enabled = False

            Me.cboEstado.Enabled = False
            Me.lEstado.Enabled = False
        End If


    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ControlIncidencias = New DBO_ControlIncidencias
        Else
            Me.m_DBO_ControlIncidencias = dbo
        End If

        Me.txtId.Text = m_DBO_ControlIncidencias.ID
        dtpFecha.Text = m_DBO_ControlIncidencias.Fecha.ToString
        cboprocesoCalidad.SelectedValue = m_DBO_ControlIncidencias.Id_procesoCalidad

        If Me.ModoDeApertura = MODIFICACION Then
            If m_DBO_ControlIncidencias.Id_articulo <> Nothing Then
                Dim spArt As New spArticulos1
                Dim dboArt As DBO_Articulos1 = spArt.Select_Record(m_DBO_ControlIncidencias.Id_articulo, dtb)
                Me.cboTipoArticulo.SelectedValue = dboArt.ArticuloTpoID
            End If
        End If

        cboarticulo.SelectedValue = m_DBO_ControlIncidencias.Id_articulo
        cboincidenciaCalidadGeneral.SelectedValue = m_DBO_ControlIncidencias.Id_incidenciaCalidadGeneral
        cboid_empleado.SelectedValue = m_DBO_ControlIncidencias.id_empleado
        cboPuntosGravedad.SelectedValue = m_DBO_ControlIncidencias.Id_PuntosGravedad
        cboPuntosFrecuencia.SelectedValue = m_DBO_ControlIncidencias.Id_PuntosFrecuencia
        txtObservaciones.Text = m_DBO_ControlIncidencias.Observaciones
        chbNecesitaSeguimiento.Checked = m_DBO_ControlIncidencias.NecesitaSeguimiento
        cboEstado.SelectedValue = m_DBO_ControlIncidencias.EstadosControlesIncidencias

        If Me.ModoDeApertura <> INSERCION Then
            Me.Height = 816
            Me.SplitContainer1.Panel2Collapsed = False

            Me.frmAccionesInmediatas_ControlIncidencias = New frmAccionesInmediatas_ControlIncidencias(Me.m_DBO_ControlIncidencias.ID)
            Me.frmControlIncidencias_AccionesCorrectivas = New frmControlIncidencias_AccionesCorrectivas(Me.m_DBO_ControlIncidencias.ID)
            Me.frmControlIncidencias_AccionesPreventivas = New frmControlIncidencias_AccionesPreventivas(Me.m_DBO_ControlIncidencias.ID)
            Me.frmGastos = New frmGastosIncidencias(Me.m_DBO_ControlIncidencias.ID)
            Me.frmControlIncidencias_Causas = New frmControlIncidencias_Causas(Me.m_DBO_ControlIncidencias.ID)
            frmControlIncidencias_Origen = New frmControlIncidencias_Origen(Me.m_DBO_ControlIncidencias.ID)
            frmIncidenciasEnvasadosAsignables = New frmIncidenciasEnvasadosAsignables(Me.m_DBO_ControlIncidencias.ID, Me.cboincidenciaCalidadGeneral.SelectedValue)
            frmSegumientosIncidencias = New frmSegumientosIncidencias(Me.m_DBO_ControlIncidencias.ID)
            frmANC = New frmANC(Me.m_DBO_ControlIncidencias.ID)

            Engine_LA.FormEnPestaña(Me.frmAccionesInmediatas_ControlIncidencias, tpAccionesInmediatas)
            Engine_LA.FormEnPestaña(Me.frmControlIncidencias_AccionesCorrectivas, tpAccionesCorrectivas)
            Engine_LA.FormEnPestaña(Me.frmControlIncidencias_AccionesPreventivas, tpAccionesPreventivas)
            Engine_LA.FormEnPestaña(Me.frmControlIncidencias_Causas, tpCausas)
            Engine_LA.FormEnPestaña(Me.frmControlIncidencias_Origen, tpOrigen)
            Engine_LA.FormEnPestaña(frmIncidenciasEnvasadosAsignables, tpIncidenciasenvasados)
            Engine_LA.FormEnPestaña(frmSegumientosIncidencias, tpSeguimiento)
            Engine_LA.FormEnPestaña(frmANC, tpAlmacenNC)
            Engine_LA.FormEnPestaña(Me.frmGastos, tpGastos)
        Else
            Me.Height = Me.SplitContainer1.Panel1.Height
            Me.SplitContainer1.Panel2Collapsed = True
        End If

        BasesParaCompatibilidad.pantalla.centerIn(Me.PanGeneral, Me.SplitContainer1.Panel1)
        Me.CenterToParent()
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_ControlIncidencias.Fecha = dtpFecha.Value.Date


        If cboprocesoCalidad.SelectedValue Is Nothing Then
            If errores = "" Then cboprocesoCalidad.Focus()
            errores = errores & "No seleccionó un valor para Id_procesoCalidad." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.Id_procesoCalidad = System.Convert.ToInt32(cboprocesoCalidad.SelectedValue)
        End If

        If Me.cboarticulo.Text = "" Then
            m_DBO_ControlIncidencias.Id_articulo = Nothing
        Else
            m_DBO_ControlIncidencias.Id_articulo = System.Convert.ToInt32(cboarticulo.SelectedValue)
        End If


        If cboincidenciaCalidadGeneral.SelectedValue Is Nothing Then
            If errores = "" Then cboincidenciaCalidadGeneral.Focus()
            errores = errores & "No seleccionó un valor para Id_incidenciaCalidadGeneral." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.Id_incidenciaCalidadGeneral = System.Convert.ToInt32(cboincidenciaCalidadGeneral.SelectedValue)
        End If

        If cboid_empleado.SelectedValue Is Nothing Then
            If errores = "" Then cboid_empleado.Focus()
            errores = errores & "No seleccionó un valor para id_empleado." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.id_empleado = System.Convert.ToInt32(cboid_empleado.SelectedValue)
        End If

        If cboPuntosGravedad.SelectedValue Is Nothing Then
            If errores = "" Then cboPuntosGravedad.Focus()
            errores = errores & "No seleccionó un valor para Id_PuntosGravedad." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.Id_PuntosGravedad = System.Convert.ToInt32(cboPuntosGravedad.SelectedValue)
        End If

        If cboPuntosFrecuencia.SelectedValue Is Nothing Then
            If errores = "" Then cboPuntosFrecuencia.Focus()
            errores = errores & "No seleccionó un valor para Id_PuntosFrecuencia." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.Id_PuntosFrecuencia = System.Convert.ToInt32(cboPuntosFrecuencia.SelectedValue)
        End If

        If cboEstado.SelectedValue Is Nothing Then
            If errores = "" Then cboPuntosFrecuencia.Focus()
            errores = errores & "No seleccionó un valor para Estado." & Environment.NewLine
        Else
            m_DBO_ControlIncidencias.EstadosControlesIncidencias = System.Convert.ToInt32(cboEstado.SelectedValue)
        End If

        m_DBO_ControlIncidencias.Observaciones = txtObservaciones.Text


        m_DBO_ControlIncidencias.NecesitaSeguimiento = chbNecesitaSeguimiento.Checked

        If errores = String.Empty Then
            dbo = m_DBO_ControlIncidencias
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
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
        s.cargar_ProcesosCalidad(Me.cboprocesoCalidad, dtb)
    End Sub

    Private Sub butVerId_incidenciaCalidadGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_incidenciaCalidadGeneral.Click
        Dim frmEnt As New frmIncidenciasCalidadGeneral()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_incidenciaCalidadGeneral_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_incidenciaCalidadGeneral.Click
        Dim DBO_IncidenciasCalidadGeneral As New DBO_IncidenciasCalidadGeneral
        Dim frmEnt As New frmEntIncidenciasCalidadGeneral(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spIncidenciasCalidadGeneral, DBO_IncidenciasCalidadGeneral)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spIncidenciasCalidadGeneral
        s.cargar_IncidenciasCalidadGeneral(Me.cboincidenciaCalidadGeneral, dtb)
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
        s.cargar_Empleados(Me.cboid_empleado, dtb)
    End Sub

    Private Sub butVerId_PuntosGravedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_PuntosGravedad.Click
        Dim frmEnt As New frmTiposGravedadesIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_PuntosGravedad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_PuntosGravedad.Click
        Dim DBO_TiposGravedadesIncidencias As New DBO_TiposGravedadesIncidencias
        Dim frmEnt As New frmEntTiposGravedadesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposGravedadesIncidencias, DBO_TiposGravedadesIncidencias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposGravedadesIncidencias
        s.cargar_TiposGravedadesIncidencias(Me.cboPuntosGravedad, dtb)
    End Sub

    Private Sub butVerId_PuntosFrecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_PuntosFrecuencia.Click
        Dim frmEnt As New frmTiposFrecuenciasIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddId_PuntosFrecuencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_PuntosFrecuencia.Click
        Dim DBO_TiposFrecuenciasIncidencias As New DBO_TiposFrecuenciasIncidencias
        Dim frmEnt As New frmEntTiposFrecuenciasIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spTiposFrecuenciasIncidencias, DBO_TiposFrecuenciasIncidencias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spTiposFrecuenciasIncidencias
        s.cargar_TiposFrecuenciasIncidencias(Me.cboPuntosFrecuencia, dtb)
    End Sub

    Private Sub frmEntControlIncidencias_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.pantalla.centerIn(Me.PanGeneral, Me.SplitContainer1.Panel1)
    End Sub

    Private Sub dtpFecha_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Not Me.frmIncidenciasEnvasadosAsignables Is Nothing Then
            frmIncidenciasEnvasadosAsignables.recargar(Me.dtpFecha.Value, Me.m_DBO_ControlIncidencias.ID, Me.cboincidenciaCalidadGeneral.SelectedValue)
        End If
    End Sub

    Private Sub cboTipoArticulo_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoArticulo.SelectedIndexChanged
        Try
            If Me.cboTipoArticulo.SelectedValue <> Nothing Then
                Dim s2 As New spArticulos1
                s2.cargar_Articulos_Por_Tipo(Me.cboarticulo, Me.cboTipoArticulo.SelectedValue, dtb)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboincidenciaCalidadGeneral_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboincidenciaCalidadGeneral.SelectedIndexChanged
        cargar_criterios()
    End Sub

    Private Sub butHelpCriterios_Click(sender As System.Object, e As System.EventArgs) Handles butHelpCriterios.Click
        If Me.PanCriterios.Visible Then
            Me.PanCriterios.Visible = False
            TimerCriterios.Stop()
            TimerCriterios.Enabled = False
        Else
            Me.PanCriterios.Visible = True
            cargar_criterios()
            TimerCriterios.Enabled = True
            TimerCriterios.Start()
        End If
    End Sub

    Private Sub cargar_criterios()
        Try
            If Me.cboincidenciaCalidadGeneral.SelectedValue <> Nothing Then
                Dim spIncidencia As New spIncidenciasCalidadGeneral
                Dim dboIncidencia As DBO_IncidenciasCalidadGeneral = spIncidencia.Select_Record(Me.cboincidenciaCalidadGeneral.SelectedValue, dtb)

                Me.txtCriterioFrecuenciaAlta.Text = dboIncidencia.CriterioFrecuenciaAlta
                Me.txtCriterioFrecuenciaBaja.Text = dboIncidencia.CriterioFrecuenciaBaja
                Me.txtCriterioFrecuenciaMedia.Text = dboIncidencia.CriterioFrecuenciaMedia

                Me.txtCriterioGravedadGrave.Text = dboIncidencia.CriterioGravedadGrave
                Me.txtCriterioGravedadLeve.Text = dboIncidencia.CriterioGravedadLeve
                Me.txtCriterioGravedadModerada.Text = dboIncidencia.CriterioGravedadModerada
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub TimerCriterios_Tick(sender As System.Object, e As System.EventArgs) Handles TimerCriterios.Tick
        Me.PanCriterios.Visible = False
        TimerCriterios.Stop()
        TimerCriterios.Enabled = False
    End Sub

    Private Sub frmEntControlIncidencias_FormClosing(sender As System.Object, e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        TimerCriterios.Stop()
        TimerCriterios.Enabled = False
    End Sub

    Private Sub btnVerEstados_Click(sender As System.Object, e As System.EventArgs) Handles btnVerEstados.Click
        Dim frmEnt As New frmEstadosControlesIncidencias()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEstadosControlesIncidencias
        s.cargar_estados(Me.cboEstado, dtb)
    End Sub

    Private Sub btnAddEstados_Click(sender As System.Object, e As System.EventArgs) Handles btnAddEstados.Click
        Dim DBO_EstadosControlesIncidencias As New DBO_EstadosControlesIncidencias
        Dim frmEnt As New frmEntEstadosControlesIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEstadosControlesIncidencias, DBO_EstadosControlesIncidencias)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEstadosControlesIncidencias
        s.cargar_estados(Me.cboEstado, dtb)
    End Sub

    Private Sub btnCleanArticulo_Click(sender As System.Object, e As System.EventArgs) Handles btnCleanArticulo.Click
        Me.cboarticulo.Text = ""
    End Sub
End Class
