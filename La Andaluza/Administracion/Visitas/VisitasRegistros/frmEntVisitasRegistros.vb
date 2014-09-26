Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntVisitasRegistros
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_VisitasRegistro As DBO_VisitasRegistros
    Private m_VerID As Boolean = False
    Private spVisitasRegistros As spVisitasRegistros
    Private frmEntArticulosDocumentosVisitasNombres1 As frmEntVisitasNombres1
    Private frmEntArticulosDocumentosVisitasMotivos As frmEntVisitasMotivos
    Private frmVisitasMotivos As frmVisitasMotivos
    Public Sub New(ByRef VisitasRegistro As DBO_VisitasRegistros, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_VisitasRegistro = VisitasRegistro
        m_Pos = Pos
        m_VerID = VerID
        spVisitasRegistros = New spVisitasRegistros
        dtpHoraEntrada.activarFoco()
        dtpHoraSalida.activarFoco()
    End Sub

    Private Sub frmEntVisitasRegistros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboVisitaTipoID.mam_DataSource("VisitasRegistros_VisitasTiposCbo", False)
        Me.cboVisitaNombreID.mam_DataSource("VisitasRegistros_VisitasNombresCbo", False)
        Me.cboVisitaMotivoID.mam_DataSource("VisitasRegistros_VisitasMotivosCbo", False)
        Me.cboEmpresaID.mam_DataSource("VisitasRegistros_ClientesCbo", False)
        Me.cboPersonaResponsableVisitaID.mam_DataSource("EmpleadosSelectCbo", False)

        If Not m_VerID Then
            Me.cboPersonaResponsableVisitaID.Visible = False
            Me.lblPersonaResponsableVisitaID.Visible = False
            Me.cboEmpresaID.Visible = False
            Me.lblEmpresaID.Visible = False
            Me.cboVisitaMotivoID.Visible = False
            Me.lblVisitaMotivoID.Visible = False
            Me.cboVisitaNombreID.Visible = False
            Me.lblVisitaNombreID.Visible = False
        End If
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_VisitasRegistro = spVisitasRegistros.Select_Record(m_ID)
        If m_ID > 0 Then

            txtVisitaRegistroID.Text = m_DBO_VisitasRegistro.VisitaRegistroID
            cboVisitaTipoID.SelectedValue = If(m_DBO_VisitasRegistro.VisitaTipoID.HasValue, m_DBO_VisitasRegistro.VisitaTipoID, -1)
            cboVisitaNombreID.SelectedValue = If(m_DBO_VisitasRegistro.VisitaNombreID.HasValue, m_DBO_VisitasRegistro.VisitaNombreID, -1)
            cboVisitaMotivoID.SelectedValue = If(m_DBO_VisitasRegistro.VisitaMotivoID.HasValue, m_DBO_VisitasRegistro.VisitaMotivoID, -1)
            cboEmpresaID.SelectedValue = If(m_DBO_VisitasRegistro.EmpresaID.HasValue, m_DBO_VisitasRegistro.EmpresaID, -1)
            cboPersonaResponsableVisitaID.SelectedValue = If(m_DBO_VisitasRegistro.PersonaResponsableVisitaID.HasValue, m_DBO_VisitasRegistro.PersonaResponsableVisitaID, -1)
            dtpFecha.Text = m_DBO_VisitasRegistro.Fecha
            dtpHoraEntrada.Value = DateTime.Now.Date.Add(m_DBO_VisitasRegistro.HoraEntrada)
            dtpHoraSalida.Value = DateTime.Now.Date.Add(m_DBO_VisitasRegistro.HoraSalida)
            txtEmpresaNombre.Text = m_DBO_VisitasRegistro.EmpresaNombre
            txtObservaciones.Text = m_DBO_VisitasRegistro.Observaciones

        End If

        Select Case cboVisitaTipoID.SelectedValue
            Case Is = 1
                cboEmpresaID.Visible = True
                lblEmpresaID.Visible = True
            Case Is = 2
                cboEmpresaID.Visible = True
                lblEmpresaID.Visible = True
            Case Is = 3 'Otras
                cboEmpresaID.Visible = False
                lblEmpresaID.Visible = False
        End Select
    End Sub

    Private Sub GetValores()

        m_DBO_VisitasRegistro.VisitaTipoID = System.Convert.ToInt32(cboVisitaTipoID.SelectedValue)
        m_DBO_VisitasRegistro.VisitaNombreID = System.Convert.ToInt32(cboVisitaNombreID.SelectedValue)
        m_DBO_VisitasRegistro.VisitaMotivoID = System.Convert.ToInt32(cboVisitaMotivoID.SelectedValue)
        m_DBO_VisitasRegistro.EmpresaID = System.Convert.ToInt32(cboEmpresaID.SelectedValue)
        m_DBO_VisitasRegistro.PersonaResponsableVisitaID = System.Convert.ToInt32(cboPersonaResponsableVisitaID.SelectedValue)
        m_DBO_VisitasRegistro.Fecha = dtpFecha.Value.Date
        m_DBO_VisitasRegistro.HoraEntrada = New TimeSpan(dtpHoraEntrada.Value.Hour, dtpHoraEntrada.Value.Minute, 0)
        m_DBO_VisitasRegistro.HoraSalida = New TimeSpan(dtpHoraSalida.Value.Hour, dtpHoraSalida.Value.Minute, 0)
        m_DBO_VisitasRegistro.EmpresaNombre = txtEmpresaNombre.Text
        m_DBO_VisitasRegistro.Observaciones = txtObservaciones.Text

    End Sub

    Overrides Sub Guardar()
        If dtpHoraSalida.Value < dtpHoraEntrada.Value Then
            MessageBox.Show("La hora de salida debe ser mayor que la hora de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            dtpHoraSalida.Focus()
        Else
            GetValores()
            If spVisitasRegistros.GrabarVisitasRegistros(m_DBO_VisitasRegistro) Then
                Me.Close()
            Else
                MessageBox.Show("No se pudo guardar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub butVerVisitaNombreID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVisitaNombreID.Click
        Using frmEnt As New frmVisitasNombres1()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using
        Me.cboVisitaNombreID.mam_DataSource("VisitasRegistros_VisitasNombresCbo", False)
    End Sub

    Private Sub butAddVisitaNombreID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddVisitaNombreID.Click
        Dim DBO_VisitasNombres1 As New DBO_VisitasNombres1
        frmEntArticulosDocumentosVisitasNombres1 = New frmEntVisitasNombres1(DBO_VisitasNombres1, 1)
        frmEntArticulosDocumentosVisitasNombres1.Text = "Insertar"
        'frmEntArticulosDocumentosVisitasNombres1.ShowDialog()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEntArticulosDocumentosVisitasNombres1)
        Me.cboVisitaNombreID.mam_DataSource("VisitasRegistros_VisitasNombresCbo", False)
    End Sub

    Private Sub butVerVisitaMotivoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVisitaMotivoID.Click
        frmVisitasMotivos = New frmVisitasMotivos()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmVisitasMotivos)
        Me.cboVisitaMotivoID.mam_DataSource("VisitasRegistros_VisitasMotivosCbo", False)
    End Sub

    Private Sub butAddVisitaMotivoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddVisitaMotivoID.Click
        Dim DBO_VisitasMotivos As New DBO_VisitasMotivos
        frmEntArticulosDocumentosVisitasMotivos = New frmEntVisitasMotivos(DBO_VisitasMotivos, 1, False)
        frmEntArticulosDocumentosVisitasMotivos.Text = "Insertar"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEntArticulosDocumentosVisitasMotivos)
        Me.cboVisitaMotivoID.mam_DataSource("VisitasRegistros_VisitasMotivosCbo", False)
    End Sub

    'Private Sub dtpHoraEntrada_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraEntrada.ValueChanged
    '    If dtpHoraEntrada.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraSalida_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraSalida.Validated
    '    If dtpHoraSalida.Value < dtpHoraEntrada.Value Then
    '        messagebox.show("La hora de salida debe ser mayor que la hora de entrada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '        dtpHoraSalida.Focus()
    '    End If
    'End Sub

    Private Sub dtpHoraSalida_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraSalida.ValueChanged
        If dtpHoraSalida.Value.ToString("hh").Length = 2 Then
            SendKeys.SendWait("{Right}")
        End If
    End Sub

    Private Sub cboVisitaTipoID_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboVisitaTipoID.SelectionChangeCommitted
        Select Case cboVisitaTipoID.SelectedValue
            Case Is = 1
                cboEmpresaID.Visible = True
                lblEmpresaID.Visible = True
                Me.cboEmpresaID.mam_DataSource("VisitasRegistros_ProveedoresCbo", False)
            Case Is = 2
                cboEmpresaID.Visible = True
                lblEmpresaID.Visible = True
                Me.cboEmpresaID.mam_DataSource("VisitasRegistros_ClientesCbo", False)
            Case Is = 3 'Otras
                cboEmpresaID.Visible = False
                lblEmpresaID.Visible = False
                txtEmpresaNombre.Text = "Visita particular"
        End Select

    End Sub


    Private Sub cboEmpresaID_SelectionChangeCommitted(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboEmpresaID.SelectionChangeCommitted
        txtEmpresaNombre.Text = cboEmpresaID.Text
    End Sub

    Private Sub frmEntVisitasRegistros_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        SetValores(m_DBO_VisitasRegistro.VisitaRegistroID, False)
    End Sub
End Class
