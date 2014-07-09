Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntControlesEntregasEpis
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_ControlesEntregasEpi As DBO_ControlesEntregasEpis
    Private spControlesEntregasEpis As New spControlesEntregasEpis
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByRef ControlesEntregasEpi As DBO_ControlesEntregasEpis, ByVal Pos As Integer)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        m_ControlesEntregasEpi = ControlesEntregasEpi
        m_Pos = Pos
        txtFechaEntrega.activarFoco()
    End Sub

    Private Sub frmEntControlesEntregasEpis_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()
        CboEpis.mam_DataSource("EpisSelectCbo", False)
        CboEmpleados.mam_DataSource("EmpleadosSelectCbo", False)

        If Me.Text.Substring(0, 3) = "Ver" Then
            GeneralBindingSource.DataSource = dtb.Consultar("ControlesEntregasEpisSelectAll")
            GeneralBindingSource.Position = m_Pos
        End If

        SetValores()
    End Sub

    Public Overrides Sub SetValores()
        txtControlEntregaEpiID.Text = m_ControlesEntregasEpi.ControlEntregaEpiID
        txtFechaEntrega.Text = m_ControlesEntregasEpi.FechaEntrega
        'txtEpiID.Text = m_ControlesEntregasEpi.EpiID
        CboEpis.SelectedValue = m_ControlesEntregasEpi.EpiID
        'txtEmpleadoID.Text = m_ControlesEntregasEpi.EmpleadoID
        CboEmpleados.SelectedValue = m_ControlesEntregasEpi.EmpleadoID
        txtObservaciones.Text = If(m_ControlesEntregasEpi.Observaciones_IsDBNull = True, Nothing, m_ControlesEntregasEpi.Observaciones)
        txtEntregaAnteriores.Checked = m_ControlesEntregasEpi.EntregaAnteriores
    End Sub

    Private Sub GetValores(ByVal m_ControlesEntregasEpi As DBO_ControlesEntregasEpis)
        m_ControlesEntregasEpi.FechaEntrega = System.Convert.ToDateTime(txtFechaEntrega.Text)
        'm_ControlesEntregasEpi.EpiID = System.Convert.ToInt32(txtEpiID.Text)
        m_ControlesEntregasEpi.EpiID = CboEpis.SelectedValue
        'm_ControlesEntregasEpi.EmpleadoID = System.Convert.ToInt32(txtEmpleadoID.Text)
        m_ControlesEntregasEpi.EmpleadoID = CboEmpleados.SelectedValue
        m_ControlesEntregasEpi.Observaciones = System.Convert.ToString(If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        m_ControlesEntregasEpi.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        m_ControlesEntregasEpi.EntregaAnteriores = System.Convert.ToBoolean(txtEntregaAnteriores.Checked)
        m_ControlesEntregasEpi.FechaModificacion = System.DateTime.Now.Date
        m_ControlesEntregasEpi.FechaModificacion_IsDBNull = False
        m_ControlesEntregasEpi.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_ControlesEntregasEpi.UsuarioModificacion_IsDBNull = False
    End Sub

    Overrides Sub Guardar()
        Dim m_NewControlesEntregasEpi As New DBO_ControlesEntregasEpis
        GetValores(m_NewControlesEntregasEpi)
        If Me.Text.Substring(0, 3) = "Ins" Then
            spControlesEntregasEpis.InsertControlesEntregasEpis(m_NewControlesEntregasEpi)
        Else
            spControlesEntregasEpis.UpdateControlesEntregasEpis(m_ControlesEntregasEpi, m_NewControlesEntregasEpi)
        End If
        Me.Close()
    End Sub

    Overrides Sub MoveRecord(ByVal Move As String)
        Select Case Move
            Case Is = "First"
                m_Pos = 0
            Case Is = "Previous"
                m_Pos = m_Pos - 1
            Case Is = "Next"
                m_Pos = m_Pos + 1
            Case Is = "Last"
                m_Pos = GeneralBindingSource.Count - 1
        End Select
        GeneralBindingSource.Position = m_Pos
        m_ControlesEntregasEpi = spControlesEntregasEpis.Select_Record(GeneralBindingSource(m_Pos).Item("ControlEntregaEpiID"))
        SetValores()
    End Sub

End Class
