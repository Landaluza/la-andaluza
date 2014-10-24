Public Class frmEntVisitasTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer
    Private m_DBO_VisitasTipo As DBO_VisitasTipos
    Private m_VerID As Boolean = False
    Private spVisitasTipos As spVisitasTipos

    Public Sub New(ByRef VisitasTipo As DBO_VisitasTipos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_VisitasTipo = VisitasTipo
        m_Pos = Pos
        m_VerID = VerID
        spVisitasTipos = New spVisitasTipos
    End Sub

    Private Sub frmEntVisitasTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores(m_DBO_VisitasTipo.VisitaTipoID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        If m_SelectRecord Then m_DBO_VisitasTipo = spVisitasTipos.Select_Record(m_ID, dtb)
        If m_ID > 0 Then
            
            txtVisitaTipoID.Text = m_DBO_VisitasTipo.VisitaTipoID
            txtDescripcion.Text = m_DBO_VisitasTipo.Descripcion
            txtObservaciones.Text = m_DBO_VisitasTipo.Observaciones
            
        End If
    End Sub

    Private Sub GetValores()
        
        m_DBO_VisitasTipo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_VisitasTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spVisitasTipos.GrabarVisitasTipos(m_DBO_VisitasTipo, dtb)
        Me.Close()
    End Sub

End Class
