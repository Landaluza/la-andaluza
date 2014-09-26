Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntProtocolosMedicos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_ProtocolosMedicos As DBO_ProtocolosMedicos

    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spProtocolosMedicos = Nothing, Optional ByRef v_dbo As DBO_ProtocolosMedicos = Nothing)
        MyBase.New(modoDeApertura, v_sp, v_dbo)
        InitializeComponent()
        sp = If(v_sp Is Nothing, New spProtocolosMedicos, v_sp)
        m_DBO_ProtocolosMedicos = If(v_dbo Is Nothing, New DBO_ProtocolosMedicos, v_dbo)
        dbo = m_DBO_ProtocolosMedicos
        dtpFechaInicio.activarFoco()
        dtpFechaFinal.activarFoco()
    End Sub

    Public Sub New()
        InitializeComponent()
        dtpFechaInicio.activarFoco()
        dtpFechaFinal.activarFoco()
    End Sub

    Private Sub frmEntProtocolosMedicos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spMedicos
        s.cargar_Medicos(Me.cboMedico)
        If Me.ModoDeApertura = VISION Then
            Me.cboMedico.Enabled = False
            Me.lblMedico.Enabled = False

        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        If Me.ModoDeApertura = INSERCION Then
            Me.m_DBO_ProtocolosMedicos = New DBO_ProtocolosMedicos
        Else
            Me.m_DBO_ProtocolosMedicos = dbo
        End If

        txtReferencia.Text = m_DBO_ProtocolosMedicos.Referencia
        txtDescripcion.Text = m_DBO_ProtocolosMedicos.Descripcion
        dtpFechaInicio.Text = m_DBO_ProtocolosMedicos.FechaInicio.ToString
        dtpFechaFinal.Text = m_DBO_ProtocolosMedicos.FechaFinal.ToString
        cboMedico.SelectedValue = m_DBO_ProtocolosMedicos.Medico
        txtObservaciones.Text = m_DBO_ProtocolosMedicos.Observaciones
        chbVigente.Checked = m_DBO_ProtocolosMedicos.Vigente
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty


        If txtReferencia.Text = "" Then
            If errores = "" Then txtReferencia.Focus()
            errores = errores & "El campo Referencia no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ProtocolosMedicos.Referencia = txtReferencia.Text
        End If



        If txtDescripcion.Text = "" Then
            If errores = "" Then txtDescripcion.Focus()
            errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine
        Else
            m_DBO_ProtocolosMedicos.Descripcion = txtDescripcion.Text
        End If

        m_DBO_ProtocolosMedicos.Observaciones = Me.txtObservaciones.Text
        m_DBO_ProtocolosMedicos.Medico = Me.cboMedico.SelectedValue
        m_DBO_ProtocolosMedicos.FechaFinal = Me.dtpFechaFinal.Value
        m_DBO_ProtocolosMedicos.FechaInicio = Me.dtpFechaInicio.Value

        m_DBO_ProtocolosMedicos.Vigente = chbVigente.Checked

        If errores = String.Empty Then
            dbo = m_DBO_ProtocolosMedicos
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine & Environment.NewLine & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(trans)
    End Sub

    Private Sub butVerMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerMedico.Click
        Dim frmEnt As New frmMedicos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub

    Private Sub butAddMedico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddMedico.Click
        Dim DBO_Medicos As New DBO_Medicos
        Dim frmEnt As New frmEntMedicos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spMedicos, DBO_Medicos)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim s As New spMedicos
        s.cargar_Medicos(Me.cboMedico)
    End Sub

End Class
