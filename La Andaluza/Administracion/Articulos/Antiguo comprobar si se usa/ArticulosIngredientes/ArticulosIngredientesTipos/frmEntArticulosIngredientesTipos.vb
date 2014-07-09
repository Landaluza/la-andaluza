Public Class frmEntArticulosIngredientesTipos
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosIngredientesTipo As DBO_ArticulosIngredientesTipos
    Private m_VerID As Boolean = False
    Private m_IDI As Boolean
    Private spArticulosIngredientesTipos As spArticulosIngredientesTipos

    Public Sub New(ByRef ArticulosIngredientesTipo As DBO_ArticulosIngredientesTipos, ByVal Pos As Integer, ByVal VerID As Boolean, Optional ByVal idi As Boolean = False)
        InitializeComponent()
        m_DBO_ArticulosIngredientesTipo = ArticulosIngredientesTipo
        m_Pos = Pos
        m_VerID = VerID
        m_IDI = idi
        spArticulosIngredientesTipos = New spArticulosIngredientesTipos
    End Sub

   Private Sub frmEntArticulosIngredientesTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores(m_DBO_ArticulosIngredientesTipo.IngredienteTipoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        txtIngredienteTipoID.Text = m_DBO_ArticulosIngredientesTipo.IngredienteTipoID
        txtDescripcion.Text = m_DBO_ArticulosIngredientesTipo.Descripcion
        txtObservaciones.Text = m_DBO_ArticulosIngredientesTipo.Observaciones
   End Sub

   Private Sub GetValores()
       m_DBO_ArticulosIngredientesTipo.Descripcion = if(txtDescripcion.Text = "", String.Empty, txtDescripcion.Text)
       m_DBO_ArticulosIngredientesTipo.Observaciones = if(txtObservaciones.Text = "", String.Empty, txtObservaciones.Text)
        m_DBO_ArticulosIngredientesTipo.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosIngredientesTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
        GetValores()
        If Me.m_IDI Then
            spArticulosIngredientesTipos.GrabarArticulosIngredientesIDITipos(m_DBO_ArticulosIngredientesTipo, new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server))
        Else
            spArticulosIngredientesTipos.GrabarArticulosIngredientesTipos(m_DBO_ArticulosIngredientesTipo, new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server))
        End If
       Me.Close()
   End Sub

    Private Sub frmEntArticulosIngredientesTipos_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(panContenidos, Me)
    End Sub
End Class
