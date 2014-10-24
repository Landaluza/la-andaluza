Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntVisitasNombres1
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_VisitasNombres1 As DBO_VisitasNombres1
    Private m_VisitaTipoID As Integer
    Private spVisitasNombres1 As spVisitasNombres1
    Private frmEnt As frmEntVisitasTipos
    Public Sub New(ByRef VisitasNombres1 As DBO_VisitasNombres1, VisitaTipoID As Integer)
        InitializeComponent()
        spVisitasNombres1 = New spVisitasNombres1
        m_DBO_VisitasNombres1 = VisitasNombres1
        m_VisitaTipoID = VisitaTipoID
    End Sub

    Private Sub frmEntVisitasNombres1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cboVisitaTipoID.mam_DataSource("VisitasNombres1_VisitasTiposCbo", False, dtb)

        Select Case m_VisitaTipoID
            Case Is = 1
                lblEmpresaID.Visible = True
                lblEmpresaID.Text = "Proveedor"
                cboEmpresaID.Visible = True
                cboEmpresaID.mam_DataSource("Proveedores1Cbo", False, dtb)

            Case Is = 2
                lblEmpresaID.Visible = True
                lblEmpresaID.Text = "Cliente"
                cboEmpresaID.Visible = True
                cboEmpresaID.mam_DataSource("ClientesSelectCbo", False, dtb)
            Case Is = 3
                lblEmpresaID.Visible = False
                cboEmpresaID.Visible = False
        End Select


        If Me.Text.Substring(0, 3) = "Ver" Then
            OcultarBotonGrabar(True)
        Else
            OcultarBotonGrabar(False)
        End If

        SetValores()
    End Sub

    Overrides Sub SetValores()

        txtVisitaNombreID.Text = m_DBO_VisitasNombres1.VisitaNombreID
        cboEmpresaID.SelectedValue = If(m_DBO_VisitasNombres1.EmpresaID.HasValue, m_DBO_VisitasNombres1.EmpresaID, -1)
        txtNombre.Text = m_DBO_VisitasNombres1.Nombre
        txtDNI.Text = m_DBO_VisitasNombres1.DNI
        txtObservaciones.Text = m_DBO_VisitasNombres1.Observaciones
        cboVisitaTipoID.SelectedValue = If(m_DBO_VisitasNombres1.VisitaTipoID.HasValue, m_DBO_VisitasNombres1.VisitaTipoID, -1)

    End Sub

    Private Sub GetValores()

        m_DBO_VisitasNombres1.EmpresaID = System.Convert.ToInt32(cboEmpresaID.SelectedValue)
        m_DBO_VisitasNombres1.Nombre = If(txtNombre.Text = "", String.Empty, txtNombre.Text)
        m_DBO_VisitasNombres1.DNI = If(txtDNI.Text = "", String.Empty, txtDNI.Text)
        m_DBO_VisitasNombres1.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_VisitasNombres1.VisitaTipoID = System.Convert.ToInt32(cboVisitaTipoID.SelectedValue)

    End Sub

    Overrides Sub Guardar()
        GetValores()
        spVisitasNombres1.GrabarVisitasNombres1(m_DBO_VisitasNombres1, dtb)
        Me.Close()
    End Sub

    Private Sub butVerVisitaTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerVisitaTipoID.Click
        Using frmEnt As New frmVisitasTipos()
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        End Using
    End Sub

    Private Sub butAddVisitaTipoID_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddVisitaTipoID.Click
        Dim DBO_VisitasTipos As New DBO_VisitasTipos
        frmEnt = New frmEntVisitasTipos(DBO_VisitasTipos, 1, False)
        frmEnt.Text = "Insertar"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Me.cboVisitaTipoID.mam_DataSource("VisitasNombres1_VisitasTiposCbo", False, dtb)
    End Sub

    Private Sub cboVisitaTipoID_SelectionChangeCommitted(sender As Object, e As System.EventArgs) Handles cboVisitaTipoID.SelectionChangeCommitted
        Select Case cboVisitaTipoID.SelectedValue
            Case Is = 1
                lblEmpresaID.Visible = True
                lblEmpresaID.Text = "Proveedor"
                cboEmpresaID.Visible = True
                cboEmpresaID.mam_DataSource("Proveedores1Cbo", False, dtb)

            Case Is = 2
                lblEmpresaID.Visible = True
                lblEmpresaID.Text = "Cliente"
                cboEmpresaID.Visible = True
                cboEmpresaID.mam_DataSource("ClientesSelectCbo", False, dtb)
            Case Is = 3
                lblEmpresaID.Visible = False
                cboEmpresaID.Visible = False
        End Select





    End Sub
End Class
