Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntAguaPotableInformesMensuales
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_AguaPotableInformesMensuales As DBO_AguaPotableInformesMensuales

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotableInformesMensuales = Nothing, Optional ByRef v_dbo As DBO_AguaPotableInformesMensuales = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spAguaPotableInformesMensuales, v_sp)
        m_DBO_AguaPotableInformesMensuales = If(v_dbo Is Nothing, New DBO_AguaPotableInformesMensuales, v_dbo)
        dbo = m_DBO_AguaPotableInformesMensuales
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntAguaPotableInformesMensuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboCreador, dtb)

        s.cargar_Empleados(Me.cboVerificador, dtb)
        If Me.ModoDeApertura = VISION Then
            Me.cboVerificador.Enabled = False
            Me.lblVerificadorID.Enabled = False
            Me.cboCreador.Enabled = False
            Me.lblCreadorID.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_AguaPotableInformesMensuales = New DBO_AguaPotableInformesMensuales
        Else
            Me.m_DBO_AguaPotableInformesMensuales = dbo
        End If

        dtpFecha.Text = m_DBO_AguaPotableInformesMensuales.Fecha.ToString
        cboCreador.SelectedValue = m_DBO_AguaPotableInformesMensuales.CreadorID
        cboVerificador.SelectedValue = m_DBO_AguaPotableInformesMensuales.VerificadorID
        txtPeriodo.Text = m_DBO_AguaPotableInformesMensuales.Periodo
        txtRuta.Text = m_DBO_AguaPotableInformesMensuales.Ruta
        txtObservaciones.Text = m_DBO_AguaPotableInformesMensuales.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        m_DBO_AguaPotableInformesMensuales.Fecha = dtpFecha.Value.Date

        If txtPeriodo.Text = "" Then
            errores &= Environment.NewLine & "El campo periodo no puede estar vacío"
        Else
            m_DBO_AguaPotableInformesMensuales.Periodo = txtPeriodo.Text
        End If

        If txtRuta.Text = "" Then
            errores &= Environment.NewLine & "El campo ruta no puede estar vacío"
        Else
            m_DBO_AguaPotableInformesMensuales.Ruta = txtRuta.Text
        End If

        m_DBO_AguaPotableInformesMensuales.Observaciones = txtObservaciones.Text

        If cboCreador.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para creador"
        Else
            Me.m_DBO_AguaPotableInformesMensuales.CreadorID = cboCreador.SelectedValue
        End If

        If cboVerificador.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para verificador"
        Else
            Me.m_DBO_AguaPotableInformesMensuales.VerificadorID = cboVerificador.SelectedValue
        End If

        If errores = String.Empty Then
            dbo = m_DBO_AguaPotableInformesMensuales
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRuta.Text, "", "Z:\")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRuta.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Try
            Dim psi As New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRuta.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub butVerCreadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerCreadorID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddCreadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddCreadorID.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, New spEmpleados, New DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboCreador, dtb)
    End Sub

    Private Sub butVerVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVerificadorID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddVerificadorID.Click

        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, New spEmpleados, New DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboVerificador, dtb)
    End Sub

End Class
