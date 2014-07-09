Public Class frmEntTiposControlesLotes
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_TiposControlesLotes As DBO_TiposControlesLotes

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposControlesLotes = Nothing, Optional ByRef v_dbo As DBO_TiposControlesLotes = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposControlesLotes,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposControlesLotes = if(v_dbo Is Nothing, New DBO_TiposControlesLotes, v_dbo)
       dbo = m_DBO_TiposControlesLotes
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spTiposControlesLotes,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_TiposControlesLotes,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntTiposControlesLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spProcedimientos
       s0.cargar_Procedimientos(Me.cboprocedimiento)
       If Me.mododeapertura = VISION Then
           Me.cboprocedimiento.enabled = False
           Me.lblId_procedimiento.enabled = False
       End If
       If Config.UserType <> 4 and Config.UserType <> 9 Then
   butAddId_procedimiento.enabled = false
   butVerId_procedimiento.enabled = false
       End If

       butVer.Visible = True
   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
        If Me.modoDeApertura = INSERCION Then
       Me.m_DBO_TiposControlesLotes = new dbo_TiposControlesLotes
       Else
       Me.m_DBO_TiposControlesLotes = ctype(dbo, DBO_TiposControlesLotes)
       End If

           txtDescripcion.Text = m_DBO_TiposControlesLotes.Descripcion
           txtObservaciones.Text = m_DBO_TiposControlesLotes.Observaciones
           txtRutaControles.Text = m_DBO_TiposControlesLotes.RutaControles
           cboprocedimiento.SelectedValue = m_DBO_TiposControlesLotes.Id_procedimiento
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       If txtDescripcion.Text= "" then
           If errores = "" Then txtDescripcion.Focus()
           errores = errores & "El campo Descripcion no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_TiposControlesLotes.Descripcion = txtDescripcion.Text
       End If


        m_DBO_TiposControlesLotes.Id_procedimiento = cboprocedimiento.SelectedValue
       m_DBO_TiposControlesLotes.Observaciones = txtObservaciones.Text


       m_DBO_TiposControlesLotes.RutaControles = txtRutaControles.Text


       If errores = String.empty Then
         Dbo = ctype(m_DBO_TiposControlesLotes, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements  BasesParaCompatibilidad.savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butRutaControles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRutaControles.Click
       Dim arch As String
       'Cambiar "C:\" por la ruta adecuada
        arch = BasesParaCompatibilidad.File.Elegir_archivo("C:\")

       If Me.Text.Substring(0, 3) <> "Ver" Then
           txtRutaControles.Text = arch
       End If 
   End Sub

   Public Overrides Sub Ver()
       Try
           Dim psi As New ProcessStartInfo()
           psi.UseShellExecute = True
           psi.FileName = txtRutaControles.Text
           Process.Start(psi)
       Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
       End Try
   End Sub

   Private Sub butVerId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_procedimiento.Click
       Dim frmEnt As New frmProcedimientos()
       frmEnt.ShowDialog()
   End Sub

   Private Sub butAddId_procedimiento_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_procedimiento.Click
       Dim DBO_Procedimientos As New DBO_Procedimientos
       Dim frmEnt As New frmEntProcedimientos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spProcedimientos,DBO_Procedimientos)
       frmEnt.ShowDialog()
       dim s as new spProcedimientos
       s.cargar_Procedimientos(Me.cboprocedimiento)
   End Sub

   Private Sub frmEntTiposControlesLotes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(Me.tlpMiddle, Me)
   End Sub
End Class
