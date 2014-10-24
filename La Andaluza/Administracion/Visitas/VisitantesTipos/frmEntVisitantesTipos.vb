Public Class frmEntVisitantesTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld
    Private m_DBO_VisitantesTipo As DBO_VisitantesTipos
    Private spVisitantesTipos As spVisitantesTipos

   Public Sub New(ByRef VisitantesTipo As DBO_VisitantesTipos)
        InitializeComponent()
        spVisitantesTipos = New spVisitantesTipos
        m_DBO_VisitantesTipo = VisitantesTipo
    End Sub

    Private Sub frmEntVisitantesTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        OcultarBotonGrabar(Me.Text.Substring(0, 3))

        
        txtVisitanteTipoID.Text = m_DBO_VisitantesTipo.VisitanteTipoID
        txtDescripcion.Text = m_DBO_VisitantesTipo.Descripcion
        txtObservaciones.Text = m_DBO_VisitantesTipo.Observaciones
        
    End Sub

    Overrides Sub Guardar()
        
        m_DBO_VisitantesTipo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
        m_DBO_VisitantesTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        
        spVisitantesTipos.GrabarVisitantesTipos(m_DBO_VisitantesTipo, dtb)
        Me.Close()
    End Sub

End Class
