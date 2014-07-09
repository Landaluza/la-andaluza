Public Class frmEntCargaNecesidadesJR2Detalles
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_CargaNecesidadesJRDetalle As DBO_CargaNecesidadesJR2Detalles
    Private m_VerID As Boolean = False
    Private spCargaNecesidadesJR2Detalles As spCargaNecesidadesJR2Detalles

    Public Sub New(ByRef CargaNecesidadesJRDetalle As DBO_CargaNecesidadesJR2Detalles, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spCargaNecesidadesJR2Detalles = New spCargaNecesidadesJR2Detalles
        m_DBO_CargaNecesidadesJRDetalle = CargaNecesidadesJRDetalle
        m_Pos = Pos
        m_VerID = VerID
    End Sub

    Private Sub frmEntCargaNecesidadesJRDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim spArticulosEnvasadosHistoricos As New spArticulosEnvasadosHistoricos
        spArticulosEnvasadosHistoricos.cargar_TiposFormatos_Todos(cboArticuloID)
        'cboArticuloID.mam_DataSource(DataTable("CargaNecesidadesJRDetallesSelectTiposFormatos"), False)
        SetValores(m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRDetalleID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        
        If m_SelectRecord Then m_DBO_CargaNecesidadesJRDetalle = spCargaNecesidadesJR2Detalles.Select_Record(m_ID)
        txtCargaNecesidadesJRDetalleID.Text = m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRDetalleID.ToString
        txtCargaNecesidadesJRMaestroID.Text = m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRMaestroID.ToString
        txtArticuloID.Text = m_DBO_CargaNecesidadesJRDetalle.ArticuloID.ToString
        cboArticuloID.SelectedValue = txtArticuloID.Text
        txtCarga.Text = m_DBO_CargaNecesidadesJRDetalle.Carga.ToString
        txtStock.Text = m_DBO_CargaNecesidadesJRDetalle.Stock.ToString
        txtObservaciones.Text = m_DBO_CargaNecesidadesJRDetalle.Observaciones
        txtReserva1.Text = m_DBO_CargaNecesidadesJRDetalle.Reserva1
        txtReserva2.Text = m_DBO_CargaNecesidadesJRDetalle.Reserva2
        txtReserva3.Text = m_DBO_CargaNecesidadesJRDetalle.Reserva3
    End Sub

    Private Sub GetValores()
        m_DBO_CargaNecesidadesJRDetalle.CargaNecesidadesJRMaestroID = System.Convert.ToInt32(if(txtCargaNecesidadesJRMaestroID.Text = "", Nothing, txtCargaNecesidadesJRMaestroID.Text))
        m_DBO_CargaNecesidadesJRDetalle.ArticuloID = System.Convert.ToInt32(if(txtArticuloID.Text = "", Nothing, txtArticuloID.Text))
        m_DBO_CargaNecesidadesJRDetalle.Carga = System.Convert.ToInt32(if(txtCarga.Text = "", Nothing, txtCarga.Text))
        m_DBO_CargaNecesidadesJRDetalle.Stock = System.Convert.ToInt32(if(txtStock.Text = "", Nothing, txtStock.Text))
        m_DBO_CargaNecesidadesJRDetalle.Observaciones = txtObservaciones.Text
        m_DBO_CargaNecesidadesJRDetalle.Reserva1 = txtReserva1.Text
        m_DBO_CargaNecesidadesJRDetalle.Reserva2 = txtReserva2.Text
        m_DBO_CargaNecesidadesJRDetalle.Reserva3 = txtReserva3.Text
        m_DBO_CargaNecesidadesJRDetalle.FechaModificacion = System.DateTime.Now.Date
        m_DBO_CargaNecesidadesJRDetalle.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spCargaNecesidadesJR2Detalles.GrabarCargaNecesidadesJRDetalles(m_DBO_CargaNecesidadesJRDetalle)
        Me.Close()
    End Sub

    Private Sub cboArticuloID_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboArticuloID.SelectedIndexChanged
        If Convert.ToString(cboArticuloID.SelectedValue) <> "System.Data.DataRowView" Then
            txtArticuloID.Text = cboArticuloID.SelectedValue
        End If
    End Sub
End Class
