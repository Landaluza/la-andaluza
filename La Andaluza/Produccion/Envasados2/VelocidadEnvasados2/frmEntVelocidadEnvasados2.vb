Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntVelocidadEnvasados2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_VelocidadEnvasados2 As DBO_VelocidadEnvasados2
    Private spVelocidadEnvasados2 As spVelocidadEnvasados2
    Private formatoId As Integer

    Public Sub New(formatoId As Integer, modo As String, ByRef VelocidadEnvasados2 As DBO_VelocidadEnvasados2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_VelocidadEnvasados2 = VelocidadEnvasados2
        m_Pos = Pos
        Me.formatoId = formatoId
        dtpHoraInicio.activarFoco()
    End Sub

    Private Sub frmEntVelocidadEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.cboPersonalID.mam_DataSource("VelocidadEnvasados2_PersonalCbo"), False)        
        Dim spEmpleados As New spEmpleados
        spEmpleados.cargar_empleados_envasados(cboPersonalID, dtb)

        spVelocidadEnvasados2 = New spVelocidadEnvasados2
        SetValores()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Private Shadows Sub SetValores()
        If Me.ModoDeApertura = INSERCION Then
            dtpHoraInicio.Value = DateTime.Now
            cboPersonalID.SelectedValue = 0
            'Dim m_aux As DBO_FormatosEnvasados2 = DBO_FormatosEnvasados2.Instance
        Else
            m_DBO_VelocidadEnvasados2 = spVelocidadEnvasados2.Select_Record(m_DBO_VelocidadEnvasados2.VelocidadEnvasadoID, dtb)
            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_VelocidadEnvasados2.HoraInicio)
            cboPersonalID.SelectedValue = If(m_DBO_VelocidadEnvasados2.PersonalID.HasValue, m_DBO_VelocidadEnvasados2.PersonalID, -1)
        End If

        txtVelocidad.Text = If(m_DBO_VelocidadEnvasados2.Velocidad.HasValue, Convert.ToString(m_DBO_VelocidadEnvasados2.Velocidad), "")
        txtObservacion.Text = m_DBO_VelocidadEnvasados2.Observacion
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservacion.Focus()
        Dim errores As String = ""
        m_DBO_VelocidadEnvasados2.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_VelocidadEnvasados2.Observacion = If(txtObservacion.Text = "", String.Empty, txtObservacion.Text)
        m_DBO_VelocidadEnvasados2.PersonalID = System.Convert.ToInt32(cboPersonalID.SelectedValue)
        m_DBO_VelocidadEnvasados2.FormatoEnvasadoID = Me.formatoId
        m_DBO_VelocidadEnvasados2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_VelocidadEnvasados2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If Not IsNumeric(txtVelocidad.Text) Then
            txtVelocidad.Focus()
            errores = errores & "La velocidad debe ser numerica." & Environment.NewLine
        Else
            m_DBO_VelocidadEnvasados2.Velocidad = System.Convert.ToInt32(If(txtVelocidad.Text = "", String.Empty, txtVelocidad.Text.Replace(".", "")))
        End If
        If cboPersonalID.SelectedValue Is Nothing Then
            If errores = "" Then cboPersonalID.Focus()
            errores = errores & "No selecciono un valor en el campo Personal." & Environment.NewLine
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spVelocidadEnvasados2.GrabarVelocidadEnvasados2(m_DBO_VelocidadEnvasados2, dtb) Then
                Me.Close()
            End If
        End If
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub
End Class
