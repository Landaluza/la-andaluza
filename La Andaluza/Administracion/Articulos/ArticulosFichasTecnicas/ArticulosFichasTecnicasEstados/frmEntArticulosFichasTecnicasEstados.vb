Public Class frmEntArticulosFichasTecnicasEstados
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

   Private m_Pos As Integer
   Private m_DBO_ArticulosFichasTecnicasEstado As DBO_ArticulosFichasTecnicasEstados
   Dim m_VerID As Boolean = False

   Public Sub New(ByRef ArticulosFichasTecnicasEstado As DBO_ArticulosFichasTecnicasEstados, ByVal Pos As Integer, ByVal VerID As Boolean)
       InitializeComponent()
       m_DBO_ArticulosFichasTecnicasEstado = ArticulosFichasTecnicasEstado
       m_Pos = Pos
       m_VerID = VerID
   End Sub

   Private Sub frmEntArticulosFichasTecnicasEstados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SetValores(m_DBO_ArticulosFichasTecnicasEstado.ArticuloFichaTecnicaEstadoID, False)
   End Sub

   Overrides Sub SetValores(ByVal m_ID As Integer, ByVal m_SelectRecord As Boolean)
        

        If m_SelectRecord Then
            Dim spArticulosFichasTecnicasEstados As New spArticulosFichasTecnicasEstados
            m_DBO_ArticulosFichasTecnicasEstado = spArticulosFichasTecnicasEstados.Select_Record(m_ID, dtb)
        End If
       txtArticuloFichaTecnicaEstadoID.Text = m_DBO_ArticulosFichasTecnicasEstado.ArticuloFichaTecnicaEstadoID
       txtDescripcion.Text = m_DBO_ArticulosFichasTecnicasEstado.Descripcion
       txtObservaciones.Text = m_DBO_ArticulosFichasTecnicasEstado.Observaciones
   End Sub

   Private Sub GetValores()
       m_DBO_ArticulosFichasTecnicasEstado.Descripcion = txtDescripcion.Text
       m_DBO_ArticulosFichasTecnicasEstado.Observaciones = if(txtObservaciones.Text = "", Nothing, txtObservaciones.Text)
        m_DBO_ArticulosFichasTecnicasEstado.FechaModificacion = System.DateTime.Now.Date
        m_DBO_ArticulosFichasTecnicasEstado.UsuarioModificacion = BasesParaCompatibilidad.Config.User
   End Sub

   Overrides Sub Guardar()
        GetValores()
        Dim spArticulosFichasTecnicasEstados As New spArticulosFichasTecnicasEstados
        spArticulosFichasTecnicasEstados.GrabarArticulosFichasTecnicasEstados(m_DBO_ArticulosFichasTecnicasEstado, dtb)
       Me.Close()
   End Sub

End Class
