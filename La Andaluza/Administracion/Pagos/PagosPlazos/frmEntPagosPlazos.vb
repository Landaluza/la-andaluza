Public Class frmEntPagosPlazos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
    Private m_DBO_PagosPlazos As DBO_PagosPlazos
    Private m_VerID As Boolean = False
    Private spPagosPlazos As spPagosPlazos

    Public Sub New(ByRef PagosPlazo As DBO_PagosPlazos, ByVal Pos As Integer, ByVal VerID As Boolean)
        InitializeComponent()
        m_DBO_PagosPlazos = PagosPlazo
        m_Pos = Pos
        m_VerID = VerID
        spPagosPlazos = New spPagosPlazos
    End Sub

    Private Sub frmEntPagosPlazos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SetValores(m_DBO_PagosPlazos.PagoPlazoID, False)
    End Sub

    Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        
        If m_SelectRecord Then m_DBO_PagosPlazos = spPagosPlazos.Select_Record(m_ID)
        If m_ID > 0 Then
            txtPagoPlazoID.Text = m_DBO_PagosPlazos.PagoPlazoID
            txtDescripcion.Text = m_DBO_PagosPlazos.Descripcion
            txtObservaciones.Text = m_DBO_PagosPlazos.Observaciones
        End If
    End Sub

    Private Sub GetValores()
        m_DBO_PagosPlazos.Descripcion = txtDescripcion.Text
        m_DBO_PagosPlazos.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_PagosPlazos.FechaModificacion = System.DateTime.Now.date
        m_DBO_PagosPlazos.UsuarioModificacion = BasesParaCompatibilidad.Config.User
    End Sub

    Overrides Sub Guardar()
        GetValores()
        spPagosPlazos.GrabarPagosPlazos(m_DBO_PagosPlazos)
        Me.Close()
    End Sub

End Class
