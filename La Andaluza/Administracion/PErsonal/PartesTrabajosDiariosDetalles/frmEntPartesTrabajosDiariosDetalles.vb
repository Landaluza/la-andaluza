Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPartesTrabajosDiariosDetalles
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_PartesTrabajosDiariosDetalle As DBO_PartesTrabajosDiariosDetalles
    Private m_VerID As Boolean = False
    Private frmEnt As frmEntTareas
    Private spPartesTrabajosDiariosDetalles As spPartesTrabajosDiariosDetalles


    Public Sub New(ByRef PartesTrabajosDiariosDetalle As DBO_PartesTrabajosDiariosDetalles, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spPartesTrabajosDiariosDetalles = New spPartesTrabajosDiariosDetalles
        m_DBO_PartesTrabajosDiariosDetalle = PartesTrabajosDiariosDetalle
        m_Pos = Pos
        m_VerID = VerID
        dtpHoraInicio.activarFoco()
        dtpHoraFinal.activarFoco()
    End Sub

    Private Sub frmEntPartesTrabajosDiariosDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboTareasID.mam_DataSource("PartesTrabajosDiariosDetalles_TareasCbo", False)


        SetValores()
    End Sub
    Overrides Sub SetValores()
        cboTareasID.SelectedValue = If(m_DBO_PartesTrabajosDiariosDetalle.TareasID.HasValue, m_DBO_PartesTrabajosDiariosDetalle.TareasID, -1)
        dtpHoraInicio.Text = DateTime.Now.Date.Add(m_DBO_PartesTrabajosDiariosDetalle.HoraInicio)
        dtpHoraFinal.Text = DateTime.Now.Date.Add(m_DBO_PartesTrabajosDiariosDetalle.HoraFinal)
        txtObservaciones.Text = m_DBO_PartesTrabajosDiariosDetalle.Observaciones
    End Sub

    Private Sub GetValores()

        m_DBO_PartesTrabajosDiariosDetalle.TareasID = System.Convert.ToInt32(cboTareasID.SelectedValue)
        m_DBO_PartesTrabajosDiariosDetalle.HoraInicio = New TimeSpan(dtpHoraInicio.Value.Hour, dtpHoraInicio.Value.Minute, 0)
        m_DBO_PartesTrabajosDiariosDetalle.HoraFinal = New TimeSpan(dtpHoraFinal.Value.Hour, dtpHoraFinal.Value.Minute, 0)
        m_DBO_PartesTrabajosDiariosDetalle.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)

    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPartesTrabajosDiariosDetalles.GrabarPartesTrabajosDiariosDetalles(m_DBO_PartesTrabajosDiariosDetalle)
        Me.Close()
    End Sub

    Private Sub butVerTareasID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerTareasID.Click
        Using frmEnt As New frmTareas()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using
    End Sub

    Private Sub butAddTareasID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddTareasID.Click
        Dim DBO_Tareas As New DBO_Tareas
        frmEnt = New frmEntTareas(DBO_Tareas, 1, False)
        frmEnt.Text = "Insertar"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Me.cboTareasID.mam_DataSource("PartesTrabajosDiariosDetalles_TareasCbo", False)
    End Sub




End Class
