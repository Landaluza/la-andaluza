Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntAguaPotableAnaliticasCloro
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_AguaPotableAnaliticasCloro As DBO_AguaPotableAnaliticasCloro

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAguaPotableAnaliticasCloro = Nothing, Optional ByRef v_dbo As DBO_AguaPotableAnaliticasCloro = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spAguaPotableAnaliticasCloro, v_sp)
        m_DBO_AguaPotableAnaliticasCloro = If(v_dbo Is Nothing, New DBO_AguaPotableAnaliticasCloro, v_dbo)
        dbo = m_DBO_AguaPotableAnaliticasCloro
        dtpFecha.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntAguaPotableAnaliticasCloro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spAguaPotablePuntosMuestreos
        s.cargar_ComboBox(Me.cboPuntoMuestreo)

        Dim s2 As New spEmpleados
        s2.cargar_Empleados(Me.cboAnalista)

        s2.cargar_Empleados(Me.cboVerificador)
        If Me.ModoDeApertura = VISION Then
            Me.cboVerificador.Enabled = False
            Me.lblVerificadorID.Enabled = False
            Me.cboAnalista.Enabled = False
            Me.lblAnalistaID.Enabled = False
            Me.cboPuntoMuestreo.Enabled = False
            Me.lblPuntoMuestreoID.Enabled = False
        End If

        butVer.Visible = True
    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_AguaPotableAnaliticasCloro = New DBO_AguaPotableAnaliticasCloro
        Else
            Me.m_DBO_AguaPotableAnaliticasCloro = dbo
        End If

        cboPuntoMuestreo.SelectedValue = m_DBO_AguaPotableAnaliticasCloro.PuntoMuestreoID
        cboAnalista.SelectedValue = m_DBO_AguaPotableAnaliticasCloro.AnalistaID
        cboVerificador.SelectedValue = m_DBO_AguaPotableAnaliticasCloro.VerificadorID
        chbVerificado.Checked = m_DBO_AguaPotableAnaliticasCloro.Verificado
        dtpFecha.Text = m_DBO_AguaPotableAnaliticasCloro.Fecha.ToString
        txtValor.Text = m_DBO_AguaPotableAnaliticasCloro.Valor
        chbCorrecto.Checked = m_DBO_AguaPotableAnaliticasCloro.Correcto
        txtRuta.Text = m_DBO_AguaPotableAnaliticasCloro.Ruta
        txtObservaciones.Text = m_DBO_AguaPotableAnaliticasCloro.Observaciones
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If Me.cboAnalista.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para analista"
        Else
            Me.m_DBO_AguaPotableAnaliticasCloro.AnalistaID = Me.cboAnalista.SelectedValue
        End If

        If Me.cboVerificador.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para verificador"
        Else
            Me.m_DBO_AguaPotableAnaliticasCloro.VerificadorID = Me.cboVerificador.SelectedValue
        End If

        If Me.cboPuntoMuestreo.SelectedValue Is Nothing Then
            errores &= Environment.NewLine & "No seleccionó un valor para punto de muestreo"
        Else
            Me.m_DBO_AguaPotableAnaliticasCloro.PuntoMuestreoID = Me.cboPuntoMuestreo.SelectedValue
        End If

        m_DBO_AguaPotableAnaliticasCloro.Verificado = chbVerificado.Checked

        m_DBO_AguaPotableAnaliticasCloro.Fecha = dtpFecha.Value.Date


        If Not IsNumeric(txtValor.Text) Then
            errores &= Environment.NewLine & "El valor de  'valor' debe ser numérico"
        Else
            m_DBO_AguaPotableAnaliticasCloro.Valor = System.Convert.ToDouble(txtValor.Text)
        End If




        m_DBO_AguaPotableAnaliticasCloro.Correcto = chbCorrecto.Checked

        m_DBO_AguaPotableAnaliticasCloro.Ruta = txtRuta.Text


        m_DBO_AguaPotableAnaliticasCloro.Observaciones = txtObservaciones.Text


        If errores = String.Empty Then
            dbo = m_DBO_AguaPotableAnaliticasCloro
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

    Private Sub butVerPuntoMuestreoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerPuntoMuestreoID.Click
        Dim frmEnt As New frmAguaPotablePuntosMuestreos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddPuntoMuestreoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddPuntoMuestreoID.Click
        Dim DBO_AguaPotablePuntosMuestreos As New DBO_AguaPotablePuntosMuestreos
        Dim frmEnt As New frmEntAguaPotablePuntosMuestreos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spAguaPotablePuntosMuestreos, DBO_AguaPotablePuntosMuestreos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spAguaPotablePuntosMuestreos
        s.cargar_ComboBox(Me.cboPuntoMuestreo)
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
