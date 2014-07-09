Public Class frmEntProveedoresTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ProveedoresTipo As DBO_ProveedoresTipos
    Private m_VerID As Boolean = False
    Private spProveedoresTipos As spProveedoresTipos

   Public Sub New(ByRef ProveedoresTipo As DBO_ProveedoresTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spProveedoresTipos = New spProveedoresTipos
       m_DBO_ProveedoresTipo = ProveedoresTipo
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntProveedoresTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_ProveedoresTipo.ProveedorTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       
       If m_SelectRecord Then m_DBO_ProveedoresTipo = spProveedoresTipos.Select_Record(m_ID)
       If m_ID > 0 Then
           txtProveedorTipoID.Text = m_DBO_ProveedoresTipo.ProveedorTipoID
           txtDescripcion.Text = m_DBO_ProveedoresTipo.Descripcion
           txtObservaciones.Text = m_DBO_ProveedoresTipo.Observaciones
       End If
   End Sub

   Private Sub GetValores()
       m_DBO_ProveedoresTipo.Descripcion = txtDescripcion.Text
       m_DBO_ProveedoresTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
       m_DBO_ProveedoresTipo.FechaModificacion = System.DateTime.Now.date
        m_DBO_ProveedoresTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spProveedoresTipos.GrabarProveedoresTipos(m_DBO_ProveedoresTipo)
       Me.Close()
   End Sub


End Class
