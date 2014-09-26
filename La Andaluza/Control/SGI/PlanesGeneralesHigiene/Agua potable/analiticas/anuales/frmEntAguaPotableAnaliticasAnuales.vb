Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntAguaPotableAnaliticasAnuales
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_AguaPotableAnaliticasAnuales As DBO_AguaPotableAnaliticasAnuales

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotableAnaliticasAnuales = Nothing, Optional ByRef v_dbo As DBO_AguaPotableAnaliticasAnuales = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spAguaPotableAnaliticasAnuales, v_sp)
        m_DBO_AguaPotableAnaliticasAnuales = If(v_dbo Is Nothing, New DBO_AguaPotableAnaliticasAnuales, v_dbo)
        dbo = m_DBO_AguaPotableAnaliticasAnuales
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntAguaPotableAnaliticasAnuales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spProveedores
        s.cargar_ComboBox(Me.cboLaboratorio)

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboVerificador)
        If Me.ModoDeApertura = VISION Then
            Me.cboVerificador.Enabled = False
            Me.lblVerificadorID.Enabled = False
            Me.cboLaboratorio.Enabled = False
            Me.lblLaboratorioID.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_AguaPotableAnaliticasAnuales = New DBO_AguaPotableAnaliticasAnuales
        Else
            Me.m_DBO_AguaPotableAnaliticasAnuales = dbo
        End If

        cboLaboratorio.SelectedValue = m_DBO_AguaPotableAnaliticasAnuales.LaboratorioID
        cboVerificador.SelectedValue = m_DBO_AguaPotableAnaliticasAnuales.VerificadorID
        chbVerificado.Checked = m_DBO_AguaPotableAnaliticasAnuales.Verificado
        dtpFecha.Text = m_DBO_AguaPotableAnaliticasAnuales.Fecha.ToString
        txtRuta.Text = m_DBO_AguaPotableAnaliticasAnuales.Ruta
        txtObservaciones.Text = m_DBO_AguaPotableAnaliticasAnuales.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If Me.cboLaboratorio.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para laboratorio"
        Else
            Me.m_DBO_AguaPotableAnaliticasAnuales.LaboratorioID = Me.cboLaboratorio.SelectedValue
        End If

        If Me.cboVerificador.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para verificador"
        Else
            Me.m_DBO_AguaPotableAnaliticasAnuales.VerificadorID = Me.cboVerificador.SelectedValue
        End If

        m_DBO_AguaPotableAnaliticasAnuales.Verificado = chbVerificado.Checked

        m_DBO_AguaPotableAnaliticasAnuales.Fecha = dtpFecha.Value.Date


        m_DBO_AguaPotableAnaliticasAnuales.Ruta = txtRuta.Text


        m_DBO_AguaPotableAnaliticasAnuales.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_AguaPotableAnaliticasAnuales
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub butVerLaboratorioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerLaboratorioID.Click
        Dim frmEnt As New frmProveedores()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddLaboratorioID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddLaboratorioID.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spProveedores
        s.cargar_ComboBox(Me.cboLaboratorio)
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
