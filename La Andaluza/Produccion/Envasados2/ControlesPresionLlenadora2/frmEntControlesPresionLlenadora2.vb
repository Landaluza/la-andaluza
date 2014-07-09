Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlesPresionLlenadora2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ControlesPresionLlenadora1 As DBO_ControlesPresionLlenadora2
    Private m_VerID As Boolean = False
    Private spControlesPresionLlenadora2 As spControlesPresionLlenadora2


    Public Sub New(modo As String, ByRef ControlesPresionLlenadora1 As DBO_ControlesPresionLlenadora2, ByVal Pos As Integer, ByVal VerID As Boolean)
        MyBase.New(modo)
        InitializeComponent()
        m_DBO_ControlesPresionLlenadora1 = ControlesPresionLlenadora1
        m_Pos = Pos
        m_VerID = VerID
        spControlesPresionLlenadora2 = New spControlesPresionLlenadora2
        dtpHora.activarFoco()
    End Sub

    Private Sub frmEntControlesPresionLlenadora1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spEmpelados As New spEmpleados
        spEmpelados.cargar_empleados_envasados(cboVerificadorID)

        'Me.cboVerificadorID.mam_DataSource("EmpleadosSelectCbo"), False)
        spControlesPresionLlenadora2 = New spControlesPresionLlenadora2
        SetValores(m_DBO_ControlesPresionLlenadora1.ControlPresionLlenadora1ID, False)
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If Me.ModoDeApertura = INSERCION Then
            cboVerificadorID.SelectedIndex = 0
            dtpHora.Text = DateTime.Now
        Else
            cboVerificadorID.SelectedValue = If(m_DBO_ControlesPresionLlenadora1.VerificadorID.HasValue, m_DBO_ControlesPresionLlenadora1.VerificadorID, -1)
            dtpHora.Value = DateTime.Now.Date.Add(m_DBO_ControlesPresionLlenadora1.Hora)
        End If

        txtEnvasadoID.Text = m_DBO_ControlesPresionLlenadora1.EnvasadoID
        txtPresion.Text = If(m_DBO_ControlesPresionLlenadora1.Presion.HasValue, Convert.ToString(m_DBO_ControlesPresionLlenadora1.Presion), "")
        chbCorrecto.Checked = m_DBO_ControlesPresionLlenadora1.Correcto
        txtObservaciones.Text = m_DBO_ControlesPresionLlenadora1.Observaciones
    End Sub

    Private Function GetValores() As Boolean
        Me.txtObservaciones.Focus()
        Dim errores As String = ""

        m_DBO_ControlesPresionLlenadora1.EnvasadoID = System.Convert.ToInt32(txtEnvasadoID.Text)

        m_DBO_ControlesPresionLlenadora1.Hora = New TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0)

        m_DBO_ControlesPresionLlenadora1.Correcto = System.Convert.ToBoolean(chbCorrecto.Checked)
        m_DBO_ControlesPresionLlenadora1.Observaciones = txtObservaciones.Text = ""

        If cboVerificadorID.SelectedValue Is Nothing Then
            cboVerificadorID.Focus()
            errores = errores & "No selecciono un valor en Verificador." & Environment.NewLine
        Else
            m_DBO_ControlesPresionLlenadora1.VerificadorID = System.Convert.ToInt32(cboVerificadorID.SelectedValue)
        End If

        If txtPresion.Text = "" Then
            If errores = "" Then txtPresion.Focus()
            errores = errores & "No selecciono un valor en Presion." & Environment.NewLine
        Else
            m_DBO_ControlesPresionLlenadora1.Presion = System.Convert.ToDouble(If(txtPresion.Text = "", String.Empty, txtPresion.Text))
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
            If spControlesPresionLlenadora2.GrabarControlesPresionLlenadora1(m_DBO_ControlesPresionLlenadora1) Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub butVerVerificadorID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVerificadorID.Click
        Using frmEnt As New frmEmpleados()
            frmEnt.ShowDialog()
        End Using
    End Sub

    'Private Sub dtpHora_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtpHora.ValueChanged
    '    If dtpHora.Value.ToString("hh").Length = 2 Then
    '        SendKeys.SendWait("{Right}")
    '    End If
    'End Sub

End Class
