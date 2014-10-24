Public Class frmEntRecipientesSalidas
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_RecipientesSalidas As DBO_RecipientesSalidas

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spRecipientesSalidas = Nothing, Optional ByRef v_dbo As DBO_RecipientesSalidas = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spRecipientesSalidas,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_RecipientesSalidas = If(v_dbo Is Nothing, New DBO_RecipientesSalidas, v_dbo)
       dbo = m_DBO_RecipientesSalidas
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spRecipientesSalidas,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_RecipientesSalidas, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntRecipientesSalidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_RecipientesSalidas = new dbo_RecipientesSalidas
       Else
       Me.m_DBO_RecipientesSalidas = ctype(dbo, DBO_RecipientesSalidas)
       End If

           txtDescripcion.Text = m_DBO_RecipientesSalidas.Descripcion
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       m_DBO_RecipientesSalidas.Descripcion = txtDescripcion.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_RecipientesSalidas, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub frmEntRecipientesSalidas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
