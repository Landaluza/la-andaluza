Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntDDDAccionesRealizadas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_DDDAccionesRealizadas As DBO_DDDAccionesRealizadas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDDDAccionesRealizadas = Nothing, Optional ByRef v_dbo As DBO_DDDAccionesRealizadas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spDDDAccionesRealizadas, v_sp)
        m_DBO_DDDAccionesRealizadas = If(v_dbo Is Nothing, New DBO_DDDAccionesRealizadas, v_dbo)
        dbo = m_DBO_DDDAccionesRealizadas
        dtpFechaEjecutada.activarFoco()
        dtpFechaPlanificada.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaEjecutada.activarFoco()
        dtpFechaPlanificada.activarFoco()
    End Sub

    Private Sub frmEntDDDAccionesRealizadas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spDDDPlanes
        s.cargar_DDDPlanes(Me.cboDDDPlan, dtb)

        Dim s2 As New spDDDAcciones
        s2.cargar_DDDAcciones(Me.cboDDDAccion, dtb)

        Dim s3 As New spDDDPersonasAutorizadas
        s3.cargar_DDDPersonasAutorizadas(Me.cboPersona, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboPersona.Enabled = False
            Me.lblPersonaID.Enabled = False
            Me.cboDDDPlan.Enabled = False
            Me.lblDDDPlanID.Enabled = False
            Me.cboDDDAccion.Enabled = False
            Me.lblDDDAccionID.Enabled = False
        End If
        Dim s4 As New spDDDProductos
        s4.cargar_DDDProductos(Me.cboProducto, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboProducto.Enabled = False
            Me.lblProductoID.Enabled = False

        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_DDDAccionesRealizadas = New DBO_DDDAccionesRealizadas
        Else
            Me.m_DBO_DDDAccionesRealizadas = dbo
        End If

        cboDDDPlan.SelectedValue = m_DBO_DDDAccionesRealizadas.DDDPlanID
        dtpFechaPlanificada.Text = m_DBO_DDDAccionesRealizadas.FechaPlanificada.ToString
        dtpFechaEjecutada.Text = m_DBO_DDDAccionesRealizadas.FechaEjecutada.ToString
        cboDDDAccion.SelectedValue = m_DBO_DDDAccionesRealizadas.DDDAccionID
        cboPersona.SelectedValue = m_DBO_DDDAccionesRealizadas.PersonaID
        cboProducto.SelectedValue = m_DBO_DDDAccionesRealizadas.ProductoID
        txtRutaParteTrabajo.Text = m_DBO_DDDAccionesRealizadas.RutaParteTrabajo
        txtObservaciones.Text = m_DBO_DDDAccionesRealizadas.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = ""


        m_DBO_DDDAccionesRealizadas.FechaPlanificada = dtpFechaPlanificada.Value.Date


        m_DBO_DDDAccionesRealizadas.FechaEjecutada = dtpFechaEjecutada.Value.Date


        m_DBO_DDDAccionesRealizadas.RutaParteTrabajo = txtRutaParteTrabajo.Text


        m_DBO_DDDAccionesRealizadas.Observaciones = txtObservaciones.Text

        If Me.cboDDDAccion.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó una acción" & Environment.NewLine
        Else
            m_DBO_DDDAccionesRealizadas.DDDAccionID = cboDDDAccion.SelectedValue
        End If

        If Me.cboDDDPlan.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó un plan" & Environment.NewLine
        Else
            m_DBO_DDDAccionesRealizadas.DDDPlanID = cboDDDPlan.SelectedValue
        End If

        If Me.cboPersona.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó una persona" & Environment.NewLine
        Else
            m_DBO_DDDAccionesRealizadas.PersonaID = cboPersona.SelectedValue
        End If

        If Me.cboProducto.SelectedValue Is Nothing Then
            errores = errores & "No seleccionó un producto" & Environment.NewLine
        Else
            m_DBO_DDDAccionesRealizadas.ProductoID = cboProducto.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = m_DBO_DDDAccionesRealizadas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butRutaParteTrabajo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaParteTrabajo.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaParteTrabajo.Text, "", "Z:\")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaParteTrabajo.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRutaParteTrabajo.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butVerDDDPlanID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerDDDPlanID.Click
        Dim frmEnt As New frmDDDPlanes()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddDDDPlanID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddDDDPlanID.Click
        Dim DBO_DDDPlanes As New DBO_DDDPlanes
        Dim frmEnt As New frmEntDDDPlanes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spDDDPlanes, DBO_DDDPlanes)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spDDDPlanes
        s.cargar_DDDPlanes(Me.cboDDDPlan, dtb)
    End Sub

    Private Sub butVerDDDAccionID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerDDDAccionID.Click
        Dim frmEnt As New frmDDDAcciones()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddDDDAccionID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddDDDAccionID.Click
        Dim DBO_DDDAcciones As New DBO_DDDAcciones
        Dim frmEnt As New frmEntDDDAcciones(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spDDDAcciones, DBO_DDDAcciones)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spDDDAcciones
        s.cargar_DDDAcciones(Me.cboDDDAccion, dtb)
    End Sub

    Private Sub butVerPersonaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPersonaID.Click
        Dim frmEnt As New frmDDDPersonasAutorizadas()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddPersonaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPersonaID.Click
        Dim DBO_DDDPersonasAutorizadas As New DBO_DDDPersonasAutorizadas
        Dim frmEnt As New frmEntDDDPersonasAutorizadas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spDDDPersonasAutorizadas, DBO_DDDPersonasAutorizadas)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spDDDPersonasAutorizadas
        s.cargar_DDDPersonasAutorizadas(Me.cboPersona, dtb)
    End Sub

    Private Sub butVerProductoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerProductoID.Click
        Dim frmEnt As New frmDDDProductos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddProductoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddProductoID.Click
        Dim DBO_DDDProductos As New DBO_DDDProductos
        Dim frmEnt As New frmEntDDDProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spDDDProductos, DBO_DDDProductos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spDDDProductos
        s.cargar_DDDProductos(Me.cboProducto, dtb)
    End Sub

End Class
