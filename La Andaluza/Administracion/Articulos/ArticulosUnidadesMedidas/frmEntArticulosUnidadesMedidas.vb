Public Class frmEntArticulosUnidadesMedidas
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosUnidadesMedida As DBO_ArticulosUnidadesMedidas
    Private m_VerID As Boolean = False
    Private spArticulosUnidadesMedidas As spArticulosUnidadesMedidas

   Public Sub New(ByRef ArticulosUnidadesMedida As DBO_ArticulosUnidadesMedidas, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spArticulosUnidadesMedidas = New spArticulosUnidadesMedidas
       m_DBO_ArticulosUnidadesMedida = ArticulosUnidadesMedida
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulosUnidadesMedidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_ArticulosUnidadesMedida.ArticuloUnidadMedidaID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       
        If m_SelectRecord Then m_DBO_ArticulosUnidadesMedida = spArticulosUnidadesMedidas.Select_Record(m_ID, dtb)
       If m_ID > 0 Then
           txtArticuloUnidadMedidaID.Text = m_DBO_ArticulosUnidadesMedida.ArticuloUnidadMedidaID
           txtDescripcion.Text = m_DBO_ArticulosUnidadesMedida.Descripcion
           txtAbreviatura.Text = m_DBO_ArticulosUnidadesMedida.Abreviatura
           txtObservaciones.Text = m_DBO_ArticulosUnidadesMedida.Observaciones
       End If
   End Sub

   Private Sub GetValores()
       m_DBO_ArticulosUnidadesMedida.Descripcion = txtDescripcion.Text
       m_DBO_ArticulosUnidadesMedida.Abreviatura = if(txtAbreviatura.Text = "", String.Empty, txtAbreviatura.Text)
       m_DBO_ArticulosUnidadesMedida.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosUnidadesMedida.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosUnidadesMedida.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spArticulosUnidadesMedidas.GrabarArticulosUnidadesMedidas(m_DBO_ArticulosUnidadesMedida, dtb)
       Me.Close()
   End Sub

End Class
