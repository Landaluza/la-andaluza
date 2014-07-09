Public Class frmEntArticulosGranelesTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosGranelesTipo As DBO_ArticulosGranelesTipos
    Private m_VerID As Boolean = False
    Private spArticulosGranelesTipos As New spArticulosGranelesTipos

   Public Sub New(ByRef ArticulosGranelesTipo As DBO_ArticulosGranelesTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
       InitializeComponent()
       m_DBO_ArticulosGranelesTipo = ArticulosGranelesTipo
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulosGranelesTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_ArticulosGranelesTipo.GranelTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       If m_SelectRecord Then m_DBO_ArticulosGranelesTipo = spArticulosGranelesTipos.Select_Record(m_ID)
        txtGranelTipoID.Text = m_DBO_ArticulosGranelesTipo.GranelTipoID
        txtDescripcion.Text = m_DBO_ArticulosGranelesTipo.Descripcion
        txtObservaciones.Text = m_DBO_ArticulosGranelesTipo.Observaciones
   End Sub

   Private Sub GetValores()
       m_DBO_ArticulosGranelesTipo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
       m_DBO_ArticulosGranelesTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosGranelesTipo.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosGranelesTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spArticulosGranelesTipos.GrabarArticulosGranelesTipos(m_DBO_ArticulosGranelesTipo)
       Me.Close()
   End Sub

End Class
