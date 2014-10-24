Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntTurnosTrabajo
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_TurnosTrabajo As DBO_TurnosTrabajo
    Private m_VerID As Boolean = False
    Private spTurnosTrabajo As spTurnosTrabajo

    Public Sub New(ByRef TurnosTrabajo As DBO_TurnosTrabajo, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spTurnosTrabajo = New spTurnosTrabajo
        m_DBO_TurnosTrabajo = TurnosTrabajo
        m_Pos = Pos
        m_VerID = VerID
        dtpAno.activarFoco()
    End Sub

    Private Sub frmEntTurnosTrabajo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_TurnosTrabajo.TurnoTrabajoID, False)
        butVer.Visible = True
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        '
        'If m_SelectRecord Then m_DBO_TurnosTrabajo = spTurnosTrabajo.Select_Record(m_ID)
        txtTurnoTrabajoID.Text = m_DBO_TurnosTrabajo.TurnoTrabajoID
        dtpAno.Text = m_DBO_TurnosTrabajo.Ano
        txtSemana.Text = m_DBO_TurnosTrabajo.Semana
        txtObservaciones.Text = m_DBO_TurnosTrabajo.Observaciones
        txtRutaFichero.Text = m_DBO_TurnosTrabajo.RutaFichero
    End Sub

    Private Sub GetValores()
        m_DBO_TurnosTrabajo.Ano = dtpAno.Value.Date
        m_DBO_TurnosTrabajo.Semana = System.Convert.ToInt32(txtSemana.Text)
        'm_DBO_TurnosTrabajo.Observaciones = if(txtObservaciones.Text = "", Nothing, txtObservaciones.Text)
        m_DBO_TurnosTrabajo.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_TurnosTrabajo.RutaFichero = txtRutaFichero.Text
        m_DBO_TurnosTrabajo.FechaModificacion = System.DateTime.Now.Date
        m_DBO_TurnosTrabajo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spTurnosTrabajo.GrabarTurnosTrabajo(m_DBO_TurnosTrabajo, New BasesParaCompatibilidad.DataBase())
        Me.Close()
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaFichero.Text, "", "Z:\Recursos Humanos\Turnos de trabajo")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaFichero.Text = arch
        End If
    End Sub

    Public Overrides Sub Ver()
        Dim psi As ProcessStartInfo

        Try
            psi = New ProcessStartInfo()
            psi.UseShellExecute = True
            psi.FileName = txtRutaFichero.Text
            Process.Start(psi)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

End Class
