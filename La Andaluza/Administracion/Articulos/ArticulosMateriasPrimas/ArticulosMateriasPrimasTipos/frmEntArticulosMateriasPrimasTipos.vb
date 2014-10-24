Public Class frmEntArticulosMateriasPrimasTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosMateriasPrimasTipo As DBO_ArticulosMateriasPrimasTipos
    Private m_VerID As Boolean = False
    Private spArticulosMateriasPrimasTipos As spArticulosMateriasPrimasTipos

   Public Sub New(ByRef ArticulosMateriasPrimasTipo As DBO_ArticulosMateriasPrimasTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
       InitializeComponent()
        m_DBO_ArticulosMateriasPrimasTipo = ArticulosMateriasPrimasTipo
        spArticulosMateriasPrimasTipos = New spArticulosMateriasPrimasTipos
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulosMateriasPrimasTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_ArticulosMateriasPrimasTipo.MateriaPrimaTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_ArticulosMateriasPrimasTipo = spArticulosMateriasPrimasTipos.Select_Record(m_ID, dtb)
        txtMateriaPrimaTipoID.Text = m_DBO_ArticulosMateriasPrimasTipo.MateriaPrimaTipoID
        txtDescripcion.Text = m_DBO_ArticulosMateriasPrimasTipo.Descripcion
        chbLiquido.Checked = If(m_DBO_ArticulosMateriasPrimasTipo.Liquido = Nothing, False, Convert.ToBoolean(m_DBO_ArticulosMateriasPrimasTipo.Liquido))
        chbCertificadoOGM.Checked = If(m_DBO_ArticulosMateriasPrimasTipo.CertificadoOGM = Nothing, False, Convert.ToBoolean(m_DBO_ArticulosMateriasPrimasTipo.CertificadoOGM))
        txtObservaciones.Text = m_DBO_ArticulosMateriasPrimasTipo.Observaciones
    End Sub

    Private Sub GetValores()
        m_DBO_ArticulosMateriasPrimasTipo.Descripcion = If(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_ArticulosMateriasPrimasTipo.Liquido = System.Convert.ToBoolean(chbLiquido.Checked)
        m_DBO_ArticulosMateriasPrimasTipo.CertificadoOGM = System.Convert.ToBoolean(chbCertificadoOGM.Checked)
        m_DBO_ArticulosMateriasPrimasTipo.Observaciones = If(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosMateriasPrimasTipo.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosMateriasPrimasTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spArticulosMateriasPrimasTipos.GrabarArticulosMateriasPrimasTipos(m_DBO_ArticulosMateriasPrimasTipo, dtb)
        Me.Close()
    End Sub

    Private Sub frmEntArticulosMateriasPrimasTipos_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerIn(panContenido, Me)
    End Sub
End Class
