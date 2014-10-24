Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntParadaOrdenadas2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ParadaOrdenadas2 As DBO_ParadaOrdenadas2
    Private m_VerID As Boolean = False
    Private formatoID As Integer
    Private spParadaOrdenadas2 As spParadaOrdenadas2

    Public Sub New(formatoId As Integer, modo As String, ByRef ParadaOrdenadas2 As DBO_ParadaOrdenadas2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        InitializeComponent()
        spParadaOrdenadas2 = New spParadaOrdenadas2
        m_DBO_ParadaOrdenadas2 = ParadaOrdenadas2
        m_Pos = Pos
        m_VerID = VerID
        Me.formatoID = formatoId
        dtpHoraFinal.activarFoco()
        dtpHoraInicio.activarFoco()
    End Sub

    Private Sub frmEntParadaOrdenadas2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboParadaOrdenadaMotivoID.mam_DataSource("ParadaOrdenadas2_ParadaOrdenadasMotivosCbo", False, dtb)
        If Not m_VerID Then
            Me.cboParadaOrdenadaMotivoID.Visible = False
            Me.lblParadaOrdenadaMotivoID.Visible = False
            Me.cboPersonalID.Visible = False
            Me.lblPersonalID.Visible = False
        End If
        Me.cboPersonalID.mam_DataSource("ParadaOrdenadas2_PersonalCbo", False, dtb)



        SetValores()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Shadows Sub SetValores()
        If Me.ModoDeApertura = INSERCION Then
            cboParadaOrdenadaMotivoID.SelectedIndex = 0
            cboPersonalID.SelectedIndex = 0
            'Dim m_aux As DBO_FormatosEnvasados2 = DBO_FormatosEnvasados2.Instance

            dtpHoraInicio.Value = DateTime.Now
            Me.dtpHoraFinal.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
        Else
            m_DBO_ParadaOrdenadas2 = spParadaOrdenadas2.Select_Record(m_DBO_ParadaOrdenadas2.ParadaOrdenadaID, dtb)

            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_ParadaOrdenadas2.HoraInicio)
            dtpHoraFinal.Value = DateTime.Now.Date.Add(m_DBO_ParadaOrdenadas2.HoraFinal)
            cboParadaOrdenadaMotivoID.SelectedValue = If(m_DBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID = Nothing, -1, m_DBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID)
            cboPersonalID.SelectedValue = If(m_DBO_ParadaOrdenadas2.PersonalID = Nothing, -1, m_DBO_ParadaOrdenadas2.PersonalID)
        End If

        txtParadaOrdenadaID.Text = m_DBO_ParadaOrdenadas2.ParadaOrdenadaID
        txtObservacion.Text = If(m_DBO_ParadaOrdenadas2.Observacion_IsDBNull = True, Nothing, m_DBO_ParadaOrdenadas2.Observacion)
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservacion.Focus()
        Dim errores As String = ""
        m_DBO_ParadaOrdenadas2.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_ParadaOrdenadas2.HoraInicio_IsDBNull = If(dtpHoraInicio.Text = "", True, False)
        m_DBO_ParadaOrdenadas2.HoraFinal = New TimeSpan(dtpHoraFinal.Value.Hour, dtpHoraFinal.Value.Minute, 0)
        m_DBO_ParadaOrdenadas2.HoraFinal_IsDBNull = If(dtpHoraFinal.Text = "", True, False)
        m_DBO_ParadaOrdenadas2.Observacion = If(txtObservacion.Text = "", String.Empty, txtObservacion.Text)
        m_DBO_ParadaOrdenadas2.Observacion_IsDBNull = If(txtObservacion.Text = "", True, False)
        m_DBO_ParadaOrdenadas2.ParadaOrdenadaMotivoID = System.Convert.ToInt32(cboParadaOrdenadaMotivoID.SelectedValue)
        m_DBO_ParadaOrdenadas2.PersonalID = System.Convert.ToInt32(cboPersonalID.SelectedValue)
        m_DBO_ParadaOrdenadas2.FormatoEnvasadoID = Me.formatoID
        m_DBO_ParadaOrdenadas2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ParadaOrdenadas2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If dtpHoraInicio.Value >= dtpHoraFinal.Value Then
            dtpHoraFinal.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine
        End If
        If cboPersonalID.SelectedValue Is Nothing Then
            If errores = "" Then cboPersonalID.Focus()
            errores = errores & "No selecciono un valor en el campo Personal." & Environment.NewLine
        End If
        If cboParadaOrdenadaMotivoID.SelectedValue Is Nothing Then
            If errores = "" Then cboParadaOrdenadaMotivoID.Focus()
            errores = errores & "No selecciono un valor en el campo Parada Ordenada." & Environment.NewLine
        End If
        'If cboFormatoEnvasadoID.SelectedValue is Nothing Then
        '    If errores = "" Then cboFormatoEnvasadoID.Focus()
        '    errores = errores & "No selecciono un valor en el campo Formato Envasado." & Environment.NewLine
        'End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spParadaOrdenadas2.GrabarParadaOrdenadas2(m_DBO_ParadaOrdenadas2, dtb) Then
                Me.Close()
            End If
        End If
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFinal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraFinal.ValueChanged
    '    If dtpHoraFinal.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub
End Class
