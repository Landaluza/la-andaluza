Public Class frmEntPagosFormas
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_PagosForma As DBO_PagosFormas
    Private m_VerID As Boolean = False
    Private spPagosFormas As spPagosFormas


   Public Sub New(ByRef PagosForma As DBO_PagosFormas, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spPagosFormas = New spPagosFormas
       m_DBO_PagosForma = PagosForma
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntPagosFormas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       SetValores(m_DBO_PagosForma.PagoFormaID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
       
       If m_SelectRecord Then m_DBO_PagosForma = spPagosFormas.Select_Record(m_ID)
       If m_ID > 0 Then
            txtPagoFormaID.Text = m_DBO_PagosForma.PagoFormaID.ToString
           txtDescripcion.Text = m_DBO_PagosForma.Descripcion
           txtObservaciones.Text = m_DBO_PagosForma.Observaciones
       End If
   End Sub

   Private Sub GetValores()
       m_DBO_PagosForma.Descripcion = txtDescripcion.Text
        m_DBO_PagosForma.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text).ToString
        m_DBO_PagosForma.FechaModificacion = System.DateTime.Now.Date
        m_DBO_PagosForma.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
       GetValores()
        spPagosFormas.GrabarPagosFormas(m_DBO_PagosForma)
       Me.Close()
   End Sub

End Class
