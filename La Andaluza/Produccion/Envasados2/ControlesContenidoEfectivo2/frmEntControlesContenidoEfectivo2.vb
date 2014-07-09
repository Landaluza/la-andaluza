Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlesContenidoEfectivo2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ControlesContenidoEfectivo As DBO_ControlesContenidoEfectivo2
    Private m_VerID As Boolean = False
    Private spControlesContenidoEfectivo2 As spControlesContenidoEfectivo2

    Public Sub New(modo As String, ByRef ControlesContenidoEfectivo As DBO_ControlesContenidoEfectivo2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        InitializeComponent()
        spControlesContenidoEfectivo2 = New spControlesContenidoEfectivo2
        m_DBO_ControlesContenidoEfectivo = ControlesContenidoEfectivo
        m_Pos = Pos
        m_VerID = VerID
        dtpHoraInicio.activarFoco()
        dtpHoraFinal.activarFoco()
    End Sub

    Private Sub frmEntControlesContenidoEfectivo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spEmpelados As New spEmpleados
        spEmpelados.cargar_empleados_envasados(cboVerificadorID)

        'Me.cboVerificadorID.mam_DataSource("EmpleadosSelectCbo"), False)
        SetValores(m_DBO_ControlesContenidoEfectivo.ControlContenidoEfectivoID, False)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If Me.ModoDeApertura = INSERCION Then
            dtpHoraInicio.Value = DateTime.Now
            dtpHoraFinal.Value = Me.dtpHoraInicio.Value.AddMinutes(15)
            'cboVerificadorID.SelectedIndex = 0
            cboVerificadorID.Text = ""
        Else
            dtpHoraInicio.Value = DateTime.Now.Date.Add(m_DBO_ControlesContenidoEfectivo.HoraInicio)
            dtpHoraFinal.Value = DateTime.Now.Date.Add(m_DBO_ControlesContenidoEfectivo.HoraFinal)
            cboVerificadorID.SelectedValue = If(m_DBO_ControlesContenidoEfectivo.VerificadorID.HasValue, m_DBO_ControlesContenidoEfectivo.VerificadorID, -1)
        End If
        txtControlContenidoEfectivoID.Text = m_DBO_ControlesContenidoEfectivo.ControlContenidoEfectivoID
        txtEnvasadoID.Text = If(m_DBO_ControlesContenidoEfectivo.EnvasadoID.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.EnvasadoID), "")

        txtContenidoNominal.Text = If(m_DBO_ControlesContenidoEfectivo.ContenidoNominal.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.ContenidoNominal), "")
        txtMaximo.Text = If(m_DBO_ControlesContenidoEfectivo.Maximo.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.Maximo), "")
        txtMinimo.Text = If(m_DBO_ControlesContenidoEfectivo.Minimo.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.Minimo), "")
        txtT1.Text = If(m_DBO_ControlesContenidoEfectivo.T1.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.T1), "")
        txtT2.Text = If(m_DBO_ControlesContenidoEfectivo.T2.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.T2), "")
        txtMedia.Text = If(m_DBO_ControlesContenidoEfectivo.Media.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.Media), "")
        txtDesviacion.Text = If(m_DBO_ControlesContenidoEfectivo.Desviacion.HasValue, Convert.ToString(m_DBO_ControlesContenidoEfectivo.Desviacion), "")
        chbCorrecto.Checked = m_DBO_ControlesContenidoEfectivo.Correcto
        txtObservaciones.Text = m_DBO_ControlesContenidoEfectivo.Observaciones
        txtLote.Text = m_DBO_ControlesContenidoEfectivo.Lote
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservaciones.Focus()
        Dim errores As String = ""

        m_DBO_ControlesContenidoEfectivo.EnvasadoID = System.Convert.ToInt32(If(txtEnvasadoID.Text = "", Nothing, txtEnvasadoID.Text))
        m_DBO_ControlesContenidoEfectivo.Correcto = System.Convert.ToBoolean(chbCorrecto.Checked)
        m_DBO_ControlesContenidoEfectivo.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ControlesContenidoEfectivo.Lote = If(txtLote.Text = "", String.Empty, txtLote.Text)

        If dtpHoraInicio.Value >= dtpHoraFinal.Value Then
            dtpHoraFinal.Focus()
            errores = errores & "La hora de fin no puede ser menor o igual a la de inicio." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
            m_DBO_ControlesContenidoEfectivo.HoraFinal = New TimeSpan(dtpHoraFinal.Value.Hour, dtpHoraFinal.Value.Minute, 0)
        End If

        If cboVerificadorID.SelectedValue Is Nothing Then
            If errores = "" Then cboVerificadorID.Focus()
            errores = errores & "no eligio un valor en Verificador." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.VerificadorID = System.Convert.ToInt32(cboVerificadorID.SelectedValue)
        End If

        If txtContenidoNominal.Text = "" Then
            If errores = "" Then txtContenidoNominal.Focus()
            errores = errores & "no eligio un valor en Contenido Nominal." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.ContenidoNominal = System.Convert.ToInt32(If(txtContenidoNominal.Text = "", Nothing, txtContenidoNominal.Text))
        End If

        If txtMaximo.Text = "" Then
            If errores = "" Then txtMaximo.Focus()
            errores = errores & "no eligio un valor en Maximo." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.Maximo = System.Convert.ToDouble(If(txtMaximo.Text = "", String.Empty, txtMaximo.Text))
        End If

        If txtMinimo.Text = "" Then
            If errores = "" Then txtMinimo.Focus()
            errores = errores & "no eligio un valor en Minimo." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.Minimo = System.Convert.ToDouble(If(txtMinimo.Text = "", String.Empty, txtMinimo.Text))
        End If

        If txtT1.Text = "" Then
            If errores = "" Then txtT1.Focus()
            errores = errores & "no eligio un valor en T1." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.T1 = System.Convert.ToDouble(If(txtT1.Text = "", String.Empty, txtT1.Text))
        End If

        If txtT2.Text = "" Then
            If errores = "" Then txtT2.Focus()
            errores = errores & "no eligio un valor en T2." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.T2 = System.Convert.ToDouble(If(txtT2.Text = "", String.Empty, txtT2.Text))
        End If

        If txtMedia.Text = "" Then
            If errores = "" Then txtMedia.Focus()
            errores = errores & "no eligio un valor en Media." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.Media = System.Convert.ToDouble(If(txtMedia.Text = "", String.Empty, txtMedia.Text))
        End If

        If txtDesviacion.Text = "" Then
            If errores = "" Then txtDesviacion.Focus()
            errores = errores & "no eligio un valor en Desviacion." & Environment.NewLine
        Else
            m_DBO_ControlesContenidoEfectivo.Desviacion = System.Convert.ToDouble(If(txtDesviacion.Text = "", String.Empty, txtDesviacion.Text))
        End If


        If errores <> "" Then
            MessageBox.Show("Complete correctamente el formulario. Se han encontrado los siguientes errores: " & Environment.NewLine & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        Else
            Return True
        End If
    End Function

    Overrides Sub Guardar()
        If GetValores() Then
            If spControlesContenidoEfectivo2.GrabarControlesContenidoEfectivo(m_DBO_ControlesContenidoEfectivo) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub butVerVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVerificadorID.Click
        Using frmEnt As New frmEmpleados()
            frmEnt.ShowDialog()
        End Using
    End Sub

    'Private Sub dtpHoraInicio_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraInicio.ValueChanged
    '    If dtpHoraInicio.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

    'Private Sub dtpHoraFinal_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHoraFinal.ValueChanged
    '    If dtpHoraFinal.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

End Class
