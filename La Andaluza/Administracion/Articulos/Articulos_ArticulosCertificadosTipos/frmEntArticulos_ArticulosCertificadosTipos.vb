Public Class frmEntArticulos_ArticulosCertificadosTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_Articulos_ArticulosCertificadosTipo As DBO_Articulos_ArticulosCertificadosTipos
    Private m_VerID As Boolean = False
    Private spArticulos_ArticulosCertificadosTipos As spArticulos_ArticulosCertificadosTipos

   Public Sub New(ByRef Articulos_ArticulosCertificadosTipo As DBO_Articulos_ArticulosCertificadosTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
       InitializeComponent()
        m_DBO_Articulos_ArticulosCertificadosTipo = Articulos_ArticulosCertificadosTipo
        spArticulos_ArticulosCertificadosTipos = New spArticulos_ArticulosCertificadosTipos
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulos_ArticulosCertificadosTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_Articulos_ArticulosCertificadosTipo.Articulo_ArticuloCertificadoTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       
        If m_SelectRecord Then m_DBO_Articulos_ArticulosCertificadosTipo = spArticulos_ArticulosCertificadosTipos.Select_Record(m_ID, dtb)
       If m_ID > 0 Then
           txtArticulo_ArticuloCertificadoTipoID.Text = m_DBO_Articulos_ArticulosCertificadosTipo.Articulo_ArticuloCertificadoTipoID
            txtArticuloID.Text = If(m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloID.HasValue, m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloID, Convert.DBNull)
            txtArticuloCertificadoTipoID.Text = If(m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloCertificadoTipoID.HasValue, m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloCertificadoTipoID, Convert.DBNull)
           txtObservaciones.Text = m_DBO_Articulos_ArticulosCertificadosTipo.Observaciones
       End If
   End Sub

   Private Sub GetValores()
       m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloID = System.Convert.ToInt32(if(txtArticuloID.Text = "", Nothing, txtArticuloID.Text))
       m_DBO_Articulos_ArticulosCertificadosTipo.ArticuloCertificadoTipoID = System.Convert.ToInt32(if(txtArticuloCertificadoTipoID.Text = "", Nothing, txtArticuloCertificadoTipoID.Text))
       m_DBO_Articulos_ArticulosCertificadosTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spArticulos_ArticulosCertificadosTipos.GrabarArticulos_ArticulosCertificadosTipos(m_DBO_Articulos_ArticulosCertificadosTipo, dtb)
       Me.Close()
   End Sub

End Class
