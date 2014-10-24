Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntEnvasadosControles
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_DBO_EnvasadosControles As DBO_EnvasadosControles
    Private m_DBO_EnvasadoControlLinea As Object
    Private m_FormLinea As Object
    Private spEnvasadosControles As spEnvasadosControles

    Public Sub New(modo As String, ByRef EnvasadosControles As DBO_EnvasadosControles, ByVal DBO_EnvasadoControlLinea As Object, ByVal FormLinea As Form)
        MyBase.New(modo)
        InitializeComponent()
        spEnvasadosControles = New spEnvasadosControles
        m_DBO_EnvasadosControles = EnvasadosControles
        m_DBO_EnvasadoControlLinea = DBO_EnvasadoControlLinea
        m_FormLinea = FormLinea
        If Me.ModoDeApertura = VISION Then
            Me.panDatos.Enabled = False
            Me.tlpMiddle.Enabled = False
        End If
        dtpHora.activarFoco()
    End Sub

    Public Sub New(ByRef EnvasadosControles As DBO_EnvasadosControles, ByVal DBO_EnvasadoControlLinea As Object, ByVal FormLinea As Form)
        InitializeComponent()
        m_DBO_EnvasadosControles = EnvasadosControles
        m_DBO_EnvasadoControlLinea = DBO_EnvasadoControlLinea
        m_FormLinea = FormLinea
    End Sub

    Private Sub frmEntEnvasadosControles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboResponsableID.mam_DataSource("EmpleadosSelectCbo"), False)
        Dim spEmple As New spEmpleados
        spEmple.cargar_empleados_envasados(cboResponsableID, dtb)
        SetValores()
        RellenarDatosAuxiliares()
        Me.ModificarBindingNavigator()
    End Sub

    Overrides Sub SetValores()

        txtEnvasadoControlID.Text = m_DBO_EnvasadosControles.EnvasadoControlID
        cboResponsableID.SelectedValue = If(m_DBO_EnvasadosControles.ResponsableID.HasValue, m_DBO_EnvasadosControles.ResponsableID, -1)
        txtFormatoEnvasadoID.Text = If(m_DBO_EnvasadosControles.FormatoEnvasadoID.HasValue, Convert.ToString(m_DBO_EnvasadosControles.FormatoEnvasadoID), "")
        txtObservaciones.Text = m_DBO_EnvasadosControles.Observaciones
        If Me.ModoDeApertura <> INSERCION Then
            dtpHora.Value = DateTime.Now.Date.Add(m_DBO_EnvasadosControles.Hora)
            chbLoteadoEnvase.Checked = m_DBO_EnvasadosControles.LoteadoEnvase
            chbLoteadoCaja.Checked = m_DBO_EnvasadosControles.LoteadoCaja
            chbEtiquetaPalet.Checked = m_DBO_EnvasadosControles.EtiquetaPalet
            chbMosaico.Checked = m_DBO_EnvasadosControles.Mosaico
            chbPaletizado.Checked = m_DBO_EnvasadosControles.Paletizado
            chbTodoCorrecto.Checked = m_DBO_EnvasadosControles.TodoCorrecto
        Else
            dtpHora.Value = DateTime.Now
        End If

    End Sub

    Private Sub GetValores()

        m_DBO_EnvasadosControles.ResponsableID = System.Convert.ToInt32(cboResponsableID.SelectedValue)
        m_DBO_EnvasadosControles.FormatoEnvasadoID = System.Convert.ToInt32(If(txtFormatoEnvasadoID.Text = "", Nothing, txtFormatoEnvasadoID.Text))
        m_DBO_EnvasadosControles.Hora = New TimeSpan(dtpHora.Value.Hour, dtpHora.Value.Minute, 0)
        m_DBO_EnvasadosControles.LoteadoEnvase = System.Convert.ToBoolean(chbLoteadoEnvase.Checked)
        m_DBO_EnvasadosControles.LoteadoCaja = System.Convert.ToBoolean(chbLoteadoCaja.Checked)
        m_DBO_EnvasadosControles.EtiquetaPalet = System.Convert.ToBoolean(chbEtiquetaPalet.Checked)
        m_DBO_EnvasadosControles.Mosaico = System.Convert.ToBoolean(chbMosaico.Checked)
        m_DBO_EnvasadosControles.Paletizado = System.Convert.ToBoolean(chbPaletizado.Checked)
        m_DBO_EnvasadosControles.TodoCorrecto = System.Convert.ToBoolean(chbTodoCorrecto.Checked)
        m_DBO_EnvasadosControles.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)

    End Sub

    Overrides Sub Guardar()
        If System.Convert.ToInt32(cboResponsableID.SelectedValue) = Nothing Then
            MessageBox.Show("Debes seleccionar un verificador", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            cboResponsableID.Focus()
        Else
            GetValores()
            spEnvasadosControles.GrabarEnvasadosControles(m_DBO_EnvasadosControles, dtb)

            'Tengo que obtener el ID del ultimo registro
            If Me.Text.Substring(0, 3) = "Ins" Then m_DBO_EnvasadoControlLinea.EnvasadoControlID = spEnvasadosControles.EnvasadosControlesSelecMax(dtb)

            'Grabo los valores de la tabla auxiliar
            m_FormLinea.guardar(m_DBO_EnvasadoControlLinea)

            Me.Close()
        End If
    End Sub

    Public Sub RellenarDatosAuxiliares()
        For Each Control As Control In panDatos.Controls
            Control.Hide()
        Next

        Engine_LA.FormEnPestaña(m_FormLinea, panDatos)

    End Sub


End Class
