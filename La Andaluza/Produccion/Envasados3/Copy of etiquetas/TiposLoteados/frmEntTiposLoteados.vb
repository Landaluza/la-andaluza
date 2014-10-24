Public Class frmEntTiposLoteados
   inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements  BasesParaCompatibilidad.savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements  BasesParaCompatibilidad.savable.afterSave
   Private m_DBO_TiposLoteados As DBO_TiposLoteados

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposLoteados = Nothing, Optional ByRef v_dbo As DBO_TiposLoteados = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo,BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposLoteados,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposLoteados = IIf(v_dbo Is Nothing, New DBO_TiposLoteados, v_dbo)
       dbo = m_DBO_TiposLoteados
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spTiposLoteados,BasesParaCompatibilidad.StoredProcedure), ctype(new DBO_TiposLoteados,BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntTiposLoteados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
       If Config.UserType <> 4 and Config.UserType <> 9 Then
       End If

   End Sub

   Overrides Sub SetValores() Implements  BasesParaCompatibilidad.savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_TiposLoteados = new dbo_TiposLoteados
       Else
       Me.m_DBO_TiposLoteados = ctype(dbo, DBO_TiposLoteados)
       End If

           txtNombre.Text = m_DBO_TiposLoteados.Nombre
   End Sub

   Protected Overrides Function GetValores() as boolean Implements  BasesParaCompatibilidad.savable.getValores
        Dim errores as String = string.empty


       m_DBO_TiposLoteados.Nombre = txtNombre.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposLoteados, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub frmEntTiposLoteados_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
