Public Class frmEntVisitasMotivos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_VisitasMotivo As DBO_VisitasMotivos
    Private m_VerID As Boolean = False
    Private spVisitasMotivos As spVisitasMotivos

   Public Sub New(ByRef VisitasMotivo As DBO_VisitasMotivos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        spVisitasMotivos = New spVisitasMotivos
       m_DBO_VisitasMotivo = VisitasMotivo
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntVisitasMotivos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores(m_DBO_VisitasMotivo.VisitaMotivoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_VisitasMotivo = spVisitasMotivos.Select_Record(m_ID)
        
        txtVisitaMotivoID.Text = m_DBO_VisitasMotivo.VisitaMotivoID
        txtDescripcion.Text = m_DBO_VisitasMotivo.Descripcion
        txtObservaciones.Text = m_DBO_VisitasMotivo.Observaciones
        
    End Sub

   Private Sub GetValores()

       m_DBO_VisitasMotivo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
       m_DBO_VisitasMotivo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)

   End Sub

   Overrides Sub Guardar()
       GetValores()
        spVisitasMotivos.GrabarVisitasMotivos(m_DBO_VisitasMotivo)
       Me.Close()
   End Sub

End Class
