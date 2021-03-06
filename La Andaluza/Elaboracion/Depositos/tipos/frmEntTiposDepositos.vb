Public Class frmEntTiposDepositos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_TiposDepositos As DBO_TiposDepositos
    Private frmDepositos As frmDepositosPorTipo

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposDepositos = Nothing, Optional ByRef v_dbo As DBO_TiposDepositos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposDepositos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposDepositos = If(v_dbo Is Nothing, New DBO_TiposDepositos, v_dbo)
       dbo = m_DBO_TiposDepositos
   End Sub

   Private Sub frmEntTiposDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       If (me.mododeapertura = VISION) Then
       End If
        If Config.UserType <> 4 AndAlso Config.UserType <> 9 Then
        End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_TiposDepositos = ctype(dbo, DBO_TiposDepositos)

        txtNombre.Text = m_DBO_TiposDepositos.Nombre
        txtObservaciones.Text = m_DBO_TiposDepositos.Observaciones

        If Me.m_DBO_TiposDepositos.ID <> 0 Then
            Me.frmDepositos = New frmDepositosPorTipo(m_DBO_TiposDepositos.ID)
            Engine_LA.FormEnPesta�a(frmDepositos, tpDEpositos)
        Else
            Engine_LA.FormEnPesta�a(New Form, tpDEpositos)
        End If
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtNombre.Text= "" then
           If errores = "" Then txtNombre.Focus()
           errores = errores & "El campo Nombre no puede estar vac�o." & Environment.NewLine()
       Else
       m_DBO_TiposDepositos.Nombre = txtNombre.Text
       End If



       m_DBO_TiposDepositos.Observaciones = txtObservaciones.Text


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposDepositos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

    Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
        MyBase.Guardar(Me.dtb)
    End Sub

   Private Sub frmEntTiposDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.pantalla.centerIn(CType(Me.tlpMiddle, Control), Me)
   End Sub
End Class
