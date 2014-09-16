Public Class frmEntDepositos_TiposDepositos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_Depositos_TiposDepositos As DBO_Depositos_TiposDepositos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spDepositos_TiposDepositos = Nothing, Optional ByRef v_dbo As DBO_Depositos_TiposDepositos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spDepositos_TiposDepositos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_Depositos_TiposDepositos = If(v_dbo Is Nothing, New DBO_Depositos_TiposDepositos, v_dbo)
       dbo = m_DBO_Depositos_TiposDepositos
   End Sub

   Private Sub frmEntDepositos_TiposDepositos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spDepositos
       s0.cargar_Depositos(Me.cboDeposito)
       dim s1 as new spTiposDepositos
       s1.cargar_TiposDepositos(Me.cboTipoDeposito)
       If (me.mododeapertura = VISION) Then
           Me.cboDeposito.enabled = False
           Me.lblId_Deposito.enabled = False
           
           Me.cboTipoDeposito.enabled = False
           Me.lblId_TipoDeposito.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_Deposito.enabled = false
   butVerId_Deposito.enabled = false
   butAddId_TipoDeposito.enabled = false
   butVerId_TipoDeposito.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_Depositos_TiposDepositos = ctype(dbo, DBO_Depositos_TiposDepositos)

           cboDeposito.SelectedValue = m_DBO_Depositos_TiposDepositos.Id_Deposito
           cboTipoDeposito.SelectedValue = m_DBO_Depositos_TiposDepositos.Id_TipoDeposito
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If cboDeposito.selectedvalue = nothing then
           If errores = "" Then cboDeposito.Focus()
           errores = errores & "No seleccionó un valor para Id_Deposito." & Environment.NewLine()
       Else
       m_DBO_Depositos_TiposDepositos.Id_Deposito = System.Convert.ToInt32(cboDeposito.SelectedValue)
       End If
       If cboTipoDeposito.selectedvalue = nothing then
           If errores = "" Then cboTipoDeposito.Focus()
           errores = errores & "No seleccionó un valor para Id_TipoDeposito." & Environment.NewLine()
       Else
       m_DBO_Depositos_TiposDepositos.Id_TipoDeposito = System.Convert.ToInt32(cboTipoDeposito.SelectedValue)
       End If
       If (errores = String.empty) then
         Dbo = ctype(m_DBO_Depositos_TiposDepositos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerId_Deposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_Deposito.Click
       Dim frmEnt As New frmDepositos()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_Deposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_Deposito.Click
       Dim DBO_Depositos As New DBO_Depositos
       Dim frmEnt As New frmEntDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spDepositos,DBO_Depositos)
       frmEnt.ShowDialog()
       dim s as new spDepositos
       s.cargar_Depositos(Me.cboDeposito)
   End Sub

   Private Sub butVerId_TipoDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoDeposito.Click
       Dim frmEnt As New frmTiposDepositos()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_TipoDeposito_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoDeposito.Click
       Dim DBO_TiposDepositos As New DBO_TiposDepositos
       Dim frmEnt As New frmEntTiposDepositos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spTiposDepositos,DBO_TiposDepositos)
       frmEnt.ShowDialog()
       dim s as new spTiposDepositos
       s.cargar_TiposDepositos(Me.cboTipoDeposito)
   End Sub

   Private Sub frmEntDepositos_TiposDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
