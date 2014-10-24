Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPartesTrabajosDiariosMaestros
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_PartesTrabajosDiariosMaestro As DBO_PartesTrabajosDiariosMaestros
    Private frHijo As BasesParaCompatibilidad.FrmAheredarOld
    Private spPartesTrabajosDiariosMaestros As spPartesTrabajosDiariosMaestros
    Private frmPartesTrabajosDiariosDetalles As frmPartesTrabajosDiariosDetalles
    Public Sub New(ByRef PartesTrabajosDiariosMaestro As DBO_PartesTrabajosDiariosMaestros)
        InitializeComponent()
        spPartesTrabajosDiariosMaestros = New spPartesTrabajosDiariosMaestros
        m_DBO_PartesTrabajosDiariosMaestro = PartesTrabajosDiariosMaestro
        Me.dtpFecha.activarFoco()
        frmPartesTrabajosDiariosDetalles = New frmPartesTrabajosDiariosDetalles(m_DBO_PartesTrabajosDiariosMaestro.ParteTrabajoDiarioMaestroID)

        Me.frHijo = frmPartesTrabajosDiariosDetalles
        Me.frHijo.Embebido = True
        frmPartesTrabajosDiariosDetalles.Embebido = True
        Engine_LA.FormEnPestaña(frmPartesTrabajosDiariosDetalles, panTareas)
    End Sub

    Private Sub frmEntPartesTrabajosDiariosMaestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.cboEmpleadoID.mam_DataSource("EmpleadosSelectCbo", False, dtb)

        If Me.Text.Substring(0, 3) = "Ver" Then
            OcultarBotonGrabar(True)
        Else
            OcultarBotonGrabar(False)
        End If

        SetValores()
    End Sub

    Overrides Sub SetValores()
        cboEmpleadoID.SelectedValue = If(m_DBO_PartesTrabajosDiariosMaestro.EmpleadoID.HasValue, m_DBO_PartesTrabajosDiariosMaestro.EmpleadoID, -1)
        dtpFecha.Text = m_DBO_PartesTrabajosDiariosMaestro.Fecha
        txtObservaciones.Text = m_DBO_PartesTrabajosDiariosMaestro.Observaciones
    End Sub

    Private Sub GetValores()

        m_DBO_PartesTrabajosDiariosMaestro.EmpleadoID = System.Convert.ToInt32(cboEmpleadoID.SelectedValue)
        m_DBO_PartesTrabajosDiariosMaestro.Fecha = dtpFecha.Value.Date
        m_DBO_PartesTrabajosDiariosMaestro.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)

    End Sub
    Overrides Sub Guardar()
        GetValores()
        spPartesTrabajosDiariosMaestros.GrabarPartesTrabajosDiariosMaestros(m_DBO_PartesTrabajosDiariosMaestro, dtb)
        Me.Close()
    End Sub
    Private Sub butVerEmpleadoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerEmpleadoID.Click
        Dim frmEnt As New frmEmpleados()
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub
    Private Sub frmEntPartesTrabajosDiariosMaestros_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Me.frHijo.gestionarEventosDeTeclado(e)
    End Sub
End Class
