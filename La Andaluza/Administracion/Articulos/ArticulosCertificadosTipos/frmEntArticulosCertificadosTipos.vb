Public Class frmEntArticulosCertificadosTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosCertificadosTipo As DBO_ArticulosCertificadosTipos
    Private m_VerID As Boolean = False
    Private spArticulosCertificadosTipos As spArticulosCertificadosTipos

   Public Sub New(ByRef ArticulosCertificadosTipo As DBO_ArticulosCertificadosTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spArticulosCertificadosTipos = New spArticulosCertificadosTipos
       m_DBO_ArticulosCertificadosTipo = ArticulosCertificadosTipo
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulosCertificadosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores(m_DBO_ArticulosCertificadosTipo.ArticuloCertificadoTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       
        txtArticuloCertificadoTipoID.Text = m_DBO_ArticulosCertificadosTipo.ArticuloCertificadoTipoID
        txtDescripcion.Text = m_DBO_ArticulosCertificadosTipo.Descripcion
        txtObservaciones.Text = m_DBO_ArticulosCertificadosTipo.Observaciones
   End Sub

   Private Sub GetValores()
       m_DBO_ArticulosCertificadosTipo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
       m_DBO_ArticulosCertificadosTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spArticulosCertificadosTipos.GrabarArticulosCertificadosTipos(m_DBO_ArticulosCertificadosTipo, dtb)
       Me.Close()
   End Sub


End Class
