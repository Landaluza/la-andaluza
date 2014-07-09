Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntCambiosFormatosEnvasados2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Public m_Envasado As DBO_Envasados2
    Private formatoId As Integer
    Private m_DBO_CambiosFormatosEnvasados2 As DBO_CambiosFormatosEnvasados2
    Private m_VerID As Boolean = False
    Private spFormatosEnvasados As spFormatosEnvasados
    Private spCambiosFormatosEnvasados2 As spCambiosFormatosEnvasados2
    Private spArticulosEnvasadosHistoricos As spArticulosEnvasadosHistoricos

    Public Sub New(modo As String, ByRef CambiosFormatosEnvasados2 As DBO_CambiosFormatosEnvasados2, ByVal Pos As Integer, ByVal VerID As Boolean, FormatoId As Integer)
        MyBase.New(modo)
        InitializeComponent()
        spFormatosEnvasados = New spFormatosEnvasados
        spCambiosFormatosEnvasados2 = New spCambiosFormatosEnvasados2
        spArticulosEnvasadosHistoricos = New spArticulosEnvasadosHistoricos
        m_DBO_CambiosFormatosEnvasados2 = CambiosFormatosEnvasados2
        m_Pos = Pos
        m_VerID = VerID
        m_Envasado = DBO_Envasados2.Instance
        Me.formatoId = FormatoId
        dtpHoraInicio.activarFoco()
        dtpHoraFin.activarFoco()
    End Sub

    Private Sub frmEntCambiosFormatosEnvasados2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.cboPersonalID.mam_DataSource("CambiosFormatosEnvasados2_PersonalCbo"), False)

        Dim spEmpelados As New spEmpleados
        spEmpelados.cargar_empleados_envasados(cboPersonalID)

        spArticulosEnvasadosHistoricos.cargar_comboByLinea_activos(cboTipoformatoInicialID, m_Envasado.LineaID)

        Me.cboFormatoEnvasadoAID.mam_DataSource("CambiosFormatosEnvasados2_FormatosEnvasadosCbo", False)


        SetValores(m_DBO_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Me.cboFormatoEnvasadoAID.Enabled = False

        If Me.ModoDeApertura = MODIFICACION Then
            If Config.UserType = 3 Then
                Me.cboTipoformatoInicialID.Enabled = False
            End If
        End If
    End Sub

    Private Shadows Sub SetValores(ByVal m_ID As Integer)

        If m_ID > 0 Then m_DBO_CambiosFormatosEnvasados2 = spCambiosFormatosEnvasados2.Select_Record(m_ID)

        txtCambioFormatoEnvasadoId.Text = m_DBO_CambiosFormatosEnvasados2.CambioFormatoEnvasadoId
        dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraInicio)
        dtpHoraFin.Value = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraFin)
        txtObservacion.Text = If(m_DBO_CambiosFormatosEnvasados2.Observacion_IsDBNull = True, Nothing, m_DBO_CambiosFormatosEnvasados2.Observacion)



        If Me.ModoDeApertura = INSERCION Then

            Try
                Me.cboTipoformatoInicialID.SelectedValue = spCambiosFormatosEnvasados2.recuperar_ultimo_formato_por_linea_de_formatoEnvasado(Me.m_Envasado.LineaID, m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID)
            Catch ex As Exception
                Me.cboTipoformatoInicialID.SelectedIndex = 0
            End Try

            Me.dtpHoraInicio.Value = DateTime.Now

            Try
                Dim sp As New spFormatosEnvasados
                Dim f As DBO_FormatosEnvasados = sp.Select_Record(Me.formatoId)
                dtpHoraFin.Value = DateTime.Now.Date.Add(f.inicio)
            Catch ex As Exception
                dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
            End Try

            Try
                Dim spFormatosEnvasados2 As New spFormatosEnvasados2
                Dim d As DBO_PaletsProducidos2 = spFormatosEnvasados2.select_ultimo_palet_por_linea(Me.m_Envasado.LineaID)
                dtpHoraInicio.Value = DateTime.Now.Date.Add(d.HoraFin)
            Catch ex As Exception
                dtpHoraFin.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
            End Try

            cboFormatoEnvasadoAID.SelectedValue = If(m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID = Nothing, -1, m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID)
            Try
                Me.cboPersonalID.SelectedIndex = spCambiosFormatosEnvasados2.recuperar_personal_habitual_por_linea(Me.m_Envasado.LineaID)
            Catch ex As Exception
                Me.cboPersonalID.SelectedIndex = 0
            End Try

        Else
            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraInicio)
            dtpHoraFin.Value = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraFin)
            cboPersonalID.SelectedValue = If(m_DBO_CambiosFormatosEnvasados2.PersonalID = Nothing, -1, m_DBO_CambiosFormatosEnvasados2.PersonalID)
            cboTipoformatoInicialID.SelectedValue = If(m_DBO_CambiosFormatosEnvasados2.TipoformatoInicialID = Nothing, -1, m_DBO_CambiosFormatosEnvasados2.TipoformatoInicialID)
            cboFormatoEnvasadoAID.SelectedValue = Me.formatoId  'if(m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID = Nothing, -1, m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID)
        End If
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservacion.Focus()
        Dim errores As String = ""

        m_DBO_CambiosFormatosEnvasados2.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_CambiosFormatosEnvasados2.HoraInicio_IsDBNull = If(dtpHoraInicio.Text = "", True, False)
        m_DBO_CambiosFormatosEnvasados2.HoraFin = New TimeSpan(dtpHoraFin.Value.Hour, dtpHoraFin.Value.Minute, 0)
        m_DBO_CambiosFormatosEnvasados2.HoraFin_IsDBNull = If(dtpHoraFin.Text = "", True, False)
        m_DBO_CambiosFormatosEnvasados2.Observacion = If(txtObservacion.Text = "", String.Empty, txtObservacion.Text)
        m_DBO_CambiosFormatosEnvasados2.Observacion_IsDBNull = If(txtObservacion.Text = "", True, False)
        m_DBO_CambiosFormatosEnvasados2.PersonalID = System.Convert.ToInt32(cboPersonalID.SelectedValue)
        m_DBO_CambiosFormatosEnvasados2.TipoformatoInicialID = System.Convert.ToInt32(cboTipoformatoInicialID.SelectedValue)
        m_DBO_CambiosFormatosEnvasados2.FormatoEnvasadoAID = formatoId 'System.Convert.ToInt32(cboFormatoEnvasadoAID.SelectedValue)
        m_DBO_CambiosFormatosEnvasados2.FechaModificacion = System.DateTime.Now.Date
        m_DBO_CambiosFormatosEnvasados2.UsuarioModificacion = BasesParaCompatibilidad.Config.User

        If cboFormatoEnvasadoAID.SelectedValue Is Nothing Then
            errores = errores & "No selecciono un valor en el campo Envasado." & Environment.NewLine
        End If
        If cboTipoformatoInicialID.SelectedValue Is Nothing Then
            If errores = "" Then cboTipoformatoInicialID.Focus()
            errores = errores & "No selecciono un valor en el campo Formato inicial." & Environment.NewLine

        End If
        If cboPersonalID.SelectedValue Is Nothing Then
            If errores = "" Then cboPersonalID.Focus()
            errores = errores & "No selecciono un valor en el campo Personal." & Environment.NewLine
        End If

        Dim ini As DateTime = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraInicio)
        Dim fin As DateTime = DateTime.Now.Date.Add(m_DBO_CambiosFormatosEnvasados2.HoraFin)

        If ini >= fin Then
            If errores = "" Then dtpHoraFin.Focus()
            errores = errores & "La hora de fin no puede ser igual o menor que la de inicio." & Environment.NewLine
        End If

        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If

        Return True
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spCambiosFormatosEnvasados2.GrabarCambiosFormatosEnvasados2(m_DBO_CambiosFormatosEnvasados2) Then
                Me.Close()
            End If
        End If
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFin_ValueChanged(sender As System.Object, e As System.EventArgs) Handles dtpHoraFin.ValueChanged
    '    If dtpHoraFin.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub


    Private Sub cboTipoformatoInicialID_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoformatoInicialID.SelectedValueChanged
        Try
            Dim d As Date = spCambiosFormatosEnvasados2.selectUltimaHoraPorLineaYformato(Me.m_Envasado.LineaID, Me.cboTipoformatoInicialID.SelectedValue)
            Me.dtpHoraInicio.Value = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, d.Hour, d.Minute, 0)
            Me.dtpHoraFin.Value = New DateTime(Now.Year, Now.Month, Now.Day, Me.dtpHoraFin.Value.Hour, Me.dtpHoraFin.Value.Minute, 0)
        Catch ex As Exception
        End Try
    End Sub
End Class
