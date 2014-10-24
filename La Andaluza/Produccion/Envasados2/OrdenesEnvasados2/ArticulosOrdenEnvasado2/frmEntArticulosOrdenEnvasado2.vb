Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntArticulosOrdenEnvasado2
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2
    'Dim m_VerID As Boolean = False
    Private spTiposFormatos As spArticulosEnvasadosHistoricos
    Private spArticulosOrdenEnvasado2 As spArticulosOrdenEnvasado2

    'Public Sub New(ByRef ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2, ByVal Pos As Integer, ByVal VerID As Boolean)
    Public Sub New(ByRef ArticulosOrdenEnvasado As DBO_ArticulosOrdenEnvasado2, ByVal Pos As Integer)
        InitializeComponent()
        m_DBO_ArticulosOrdenEnvasado = ArticulosOrdenEnvasado
        m_Pos = Pos
        'm_VerID = VerID
        dtb = New BasesParaCompatibilidad.DataBase()
        spTiposFormatos = New spArticulosEnvasadosHistoricos
        spArticulosOrdenEnvasado2 = New spArticulosOrdenEnvasado2
    End Sub

    Private Sub frmEntArticulosOrdenEnvasado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboLineaID.mam_DataSource("OrdenesEnvasados2SelectLineasEnvasados"), True)
        cboLineaID.mam_DataSource("OrdenesEnvasados2SelectLineasEnvasados", False, dtb)
        SetValores(m_DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_ArticulosOrdenEnvasado = spArticulosOrdenEnvasado2.Select_Record(m_ID, dtb)
        txtArticuloOrdenEnvasadoID.Text = m_DBO_ArticulosOrdenEnvasado.ArticuloOrdenEnvasadoID
        cboLineaID.SelectedValue = If(m_DBO_ArticulosOrdenEnvasado.LineaID = Nothing, -1, m_DBO_ArticulosOrdenEnvasado.LineaID)

        Try
            spTiposFormatos.cargar_comboByLinea_activos(cboArticuloEnvasadoID, cboLineaID.SelectedValue, dtb)
        Catch ex As Exception
        End Try

        cboArticuloEnvasadoID.SelectedValue = If(m_DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID = Nothing, -1, m_DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID)
        txtCajas.Text = If(m_DBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = True, Nothing, m_DBO_ArticulosOrdenEnvasado.Cajas)
        txtObservaciones.Text = If(m_DBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = True, Nothing, m_DBO_ArticulosOrdenEnvasado.Observaciones)
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosOrdenEnvasado.LineaID = System.Convert.ToInt32(cboLineaID.SelectedValue)
        m_DBO_ArticulosOrdenEnvasado.ArticuloEnvasadoID = System.Convert.ToInt32(cboArticuloEnvasadoID.SelectedValue)
        m_DBO_ArticulosOrdenEnvasado.Cajas = System.Convert.ToDouble(If(txtCajas.Text = "", Nothing, txtCajas.Text))
        m_DBO_ArticulosOrdenEnvasado.Cajas_IsDBNull = If(txtCajas.Text = "", True, False)
        m_DBO_ArticulosOrdenEnvasado.Observaciones = If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text)
        m_DBO_ArticulosOrdenEnvasado.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        m_DBO_ArticulosOrdenEnvasado.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosOrdenEnvasado.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosOrdenEnvasado2.GrabarArticulosOrdenEnvasado(m_DBO_ArticulosOrdenEnvasado, dtb)
        Me.Close()
    End Sub

    Private Sub cboLineaID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLineaID.SelectedIndexChanged
        If cboLineaID.SelectedValue.ToString <> "System.Data.DataRowView" Then

            spTiposFormatos.cargar_comboByLinea_activos(cboArticuloEnvasadoID, cboLineaID.SelectedValue, dtb)
        Else
            cboArticuloEnvasadoID.DataSource = Nothing
        End If
    End Sub

    Private Sub cboArticuloEnvasadoID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArticuloEnvasadoID.SelectedIndexChanged
        If Not cboArticuloEnvasadoID.SelectedValue Is Nothing Then
            If Convert.ToString(cboArticuloEnvasadoID.SelectedValue) <> "System.Data.DataRowView" Then
                dtb.PrepararConsulta("PaletsProducidosIncompletosByTipoFormato @art")
                dtb.AñadirParametroConsulta("@art", cboArticuloEnvasadoID.SelectedValue)
                dgvPicos.DataSource = dtb.Consultar()
                dgvPicos.Columns("TipoFormatoID").Visible = False
                dgvPicos.FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Izquierda, 40, 0)
                dgvPicos.FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 180, 1)
                dgvPicos.FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 40, 2)
                dgvPicos.FormatoColumna("CajasPalet", BasesParaCompatibilidad.TiposColumna.Miles, 40, 3)
                txtObservaciones.Text = ""
                txtCajas.Text = ""
            End If
        End If
    End Sub

    Private Sub dgvPicos_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvPicos.CellContentClick
        txtCajas.Text = dgvPicos.CurrentRow.Cells("CajasPalet").Value - dgvPicos.CurrentRow.Cells("Cajas").Value
        txtObservaciones.Text = "Completar SCC: " & dgvPicos.CurrentRow.Cells("SCC").Value
    End Sub

    Private Sub txtCajas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCajas.TextChanged
        If txtCajas.Text = "" Or dgvPicos.CurrentCell Is Nothing Then
            lblPalets.Text = ""
        Else
            lblPalets.Text = txtCajas.Text / dgvPicos.CurrentRow.Cells("CajasPalet").Value
        End If
    End Sub
End Class
