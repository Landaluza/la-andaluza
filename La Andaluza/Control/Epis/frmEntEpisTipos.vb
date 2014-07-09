Public Class frmEntEpisTipos
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_EpisTipo As DBO_EpisTipos
    Private spEpisTipos As spEpisTipos

   Public Sub New(ByRef EpisTipo As DBO_EpisTipos, ByVal Pos As Integer)
       InitializeComponent()
       m_EpisTipo = EpisTipo
        m_Pos = Pos
        spEpisTipos = New spEpisTipos
   End Sub

   Private Sub frmEntEpisTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       ModificarBindingNavigator()

       If Me.Text.Substring(0, 3) = "Ver" Then
            'GeneralBindingSource. dataSource = dtb.Consultar("EpisTiposSelectAll")
           GeneralBindingSource.Position = m_Pos
       End If

       SetValores()
   End Sub

    Public Overrides Sub SetValores()
        txtEpiTipoID.Text = m_EpisTipo.EpiTipoID
        txtDescripcion.Text = m_EpisTipo.Descripcion
        txtObservaciones.Text = if(m_EpisTipo.Observaciones_IsDBNull = True, Nothing, m_EpisTipo.Observaciones)
    End Sub

   Private Sub GetValores(ByVal m_EpisTipo As DBO_EpisTipos)
       m_EpisTipo.Descripcion = System.Convert.ToString(txtDescripcion.Text)
       m_EpisTipo.Observaciones = System.Convert.ToString(if(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
       m_EpisTipo.Observaciones_IsDBNull = if(txtObservaciones.Text = "", True, False)
       m_EpisTipo.FechaModificacion = System.DateTime.Now.date
       m_EpisTipo.FechaModificacion_IsDBNull = False
        m_EpisTipo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
       m_EpisTipo.UsuarioModificacion_IsDBNull = False
   End Sub

   Overrides Sub Guardar()
       Dim m_NewEpisTipo As New DBO_EpisTipos
       GetValores(m_NewEpisTipo)
       If Me.Text.Substring(0, 3) = "Ins" Then
            spEpisTipos.InsertEpisTipos(m_NewEpisTipo)
       Else
            spEpisTipos.UpdateEpisTipos(m_EpisTipo, m_NewEpisTipo)
       End If
       Me.Close()
   End Sub

   Overrides Sub MoveRecord(ByVal Move As String)
       Select Case Move
           Case Is = "First"
               m_Pos = 0
           Case Is = "Previous"
               m_Pos = m_Pos - 1
           Case Is = "Next"
               m_Pos = m_Pos + 1
           Case Is = "Last"
               m_Pos = GeneralBindingSource.Count - 1
       End Select
       GeneralBindingSource.Position = m_Pos
       m_EpisTipo = spEpisTipos.Select_Record(GeneralBindingSource(m_Pos).Item("EpiTipoID"))
       SetValores()
   End Sub

End Class
