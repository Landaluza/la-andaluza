Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntAguaPotableAnaliticasOrganolepticas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_AguaPotableAnaliticasOrganolepticas As DBO_AguaPotableAnaliticasOrganolepticas

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotableAnaliticasOrganolepticas = Nothing, Optional ByRef v_dbo As DBO_AguaPotableAnaliticasOrganolepticas = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spAguaPotableAnaliticasOrganolepticas, v_sp)
        m_DBO_AguaPotableAnaliticasOrganolepticas = If(v_dbo Is Nothing, New DBO_AguaPotableAnaliticasOrganolepticas, v_dbo)
        dbo = m_DBO_AguaPotableAnaliticasOrganolepticas
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntAguaPotableAnaliticasOrganolepticas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboAnalista)

        s.cargar_Empleados(Me.cboVerificador)
        If Me.ModoDeApertura = VISION Then
            Me.cboVerificador.Enabled = False
            Me.lblVerificadorID.Enabled = False
            Me.cboAnalista.Enabled = False
            Me.lblAnalistaID.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_AguaPotableAnaliticasOrganolepticas = New DBO_AguaPotableAnaliticasOrganolepticas
        Else
            Me.m_DBO_AguaPotableAnaliticasOrganolepticas = dbo
        End If

        cboAnalista.SelectedValue = m_DBO_AguaPotableAnaliticasOrganolepticas.AnalistaID
        cboVerificador.SelectedValue = m_DBO_AguaPotableAnaliticasOrganolepticas.VerificadorID
        chbIncoloro.Checked = m_DBO_AguaPotableAnaliticasOrganolepticas.Incoloro
        chbInodoro.Checked = m_DBO_AguaPotableAnaliticasOrganolepticas.Inodoro
        chbInsipido.Checked = m_DBO_AguaPotableAnaliticasOrganolepticas.Insipido
        dtpFecha.Text = m_DBO_AguaPotableAnaliticasOrganolepticas.Fecha.ToString
        chbVerificado.Checked = m_DBO_AguaPotableAnaliticasOrganolepticas.Verificado
        chbCorrecto.Checked = m_DBO_AguaPotableAnaliticasOrganolepticas.Correcto
        txtRuta.Text = m_DBO_AguaPotableAnaliticasOrganolepticas.Ruta
        txtObservaciones.Text = m_DBO_AguaPotableAnaliticasOrganolepticas.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If Me.cboAnalista.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para analista"
        Else
            Me.m_DBO_AguaPotableAnaliticasOrganolepticas.AnalistaID = Me.cboAnalista.SelectedValue
        End If

        If Me.cboVerificador.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para verificador"
        Else
            Me.m_DBO_AguaPotableAnaliticasOrganolepticas.VerificadorID = Me.cboVerificador.SelectedValue
        End If

        m_DBO_AguaPotableAnaliticasOrganolepticas.Incoloro = chbIncoloro.Checked

        m_DBO_AguaPotableAnaliticasOrganolepticas.Inodoro = chbInodoro.Checked

        m_DBO_AguaPotableAnaliticasOrganolepticas.Insipido = chbInsipido.Checked

        m_DBO_AguaPotableAnaliticasOrganolepticas.Fecha = dtpFecha.Value.Date


        m_DBO_AguaPotableAnaliticasOrganolepticas.Verificado = chbVerificado.Checked

        m_DBO_AguaPotableAnaliticasOrganolepticas.Correcto = chbCorrecto.Checked

        m_DBO_AguaPotableAnaliticasOrganolepticas.Ruta = txtRuta.Text


        m_DBO_AguaPotableAnaliticasOrganolepticas.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_AguaPotableAnaliticasOrganolepticas
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
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

    Private Sub butVerAnalistaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerAnalistaID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddAnalistaID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddAnalistaID.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, New spEmpleados, New DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboAnalista)
    End Sub

    Private Sub butVerVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVerificadorID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddVerificadorID.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, New spEmpleados, New DBO_Empleados)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboVerificador)
    End Sub

End Class
