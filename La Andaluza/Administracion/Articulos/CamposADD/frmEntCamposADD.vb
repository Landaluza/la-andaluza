Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmEntCamposADD
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_CamposADD As DBO_CamposADD
    Private m_VerID As Boolean = False
    Private spCamposADD As spCamposADD

    Public Sub New(ByRef CamposADD As DBO_CamposADD, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spCamposADD = New spCamposADD
        m_DBO_CamposADD = CamposADD
        m_Pos = Pos
        m_VerID = VerID
    End Sub

    Private Sub frmEntCamposADD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.cboArticuloTipoID.mam_DataSource("CamposADD_ArticulosTiposCbo"), False)
        'Me.cboSolicitanteID.mam_DataSource("EmpleadosSelectCbo"), False)
        Me.cboArticuloTipoID.mam_DataSource("CamposADD_ArticulosTiposCbo", False, dtb)
        Me.cboSolicitanteID.mam_DataSource("EmpleadosSelectCbo", False, dtb)

        SetValores(m_DBO_CamposADD.ID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        txtID.Text = m_DBO_CamposADD.ID
        cboArticuloTipoID.SelectedValue = If(m_DBO_CamposADD.ArticuloTipoID.HasValue, m_DBO_CamposADD.ArticuloTipoID, -1)
        cboSolicitanteID.SelectedValue = If(m_DBO_CamposADD.SolicitanteID.HasValue, m_DBO_CamposADD.SolicitanteID, -1)
        txtDescripcion.Text = m_DBO_CamposADD.Descripcion
        txtUtilizacion.Text = m_DBO_CamposADD.Utilizacion
        txtObservaciones.Text = m_DBO_CamposADD.Observaciones
    End Sub

    Private Sub GetValores()
        m_DBO_CamposADD.ArticuloTipoID = System.Convert.ToInt32(cboArticuloTipoID.SelectedValue)
        m_DBO_CamposADD.SolicitanteID = System.Convert.ToInt32(cboSolicitanteID.SelectedValue)
        m_DBO_CamposADD.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_CamposADD.Utilizacion = If(txtUtilizacion.Text = "", String.Empty, txtUtilizacion.Text)
        m_DBO_CamposADD.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spCamposADD.GrabarCamposADD(m_DBO_CamposADD, New BasesParaCompatibilidad.DataBase())
        Me.Close()
    End Sub

End Class
