Public Class frmEntTiposProductos_ClasesProductos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_TiposProductos_ClasesProductos As DBO_TiposProductos_ClasesProductos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spTiposProductos_ClasesProductos = Nothing, Optional ByRef v_dbo As DBO_TiposProductos_ClasesProductos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spTiposProductos_ClasesProductos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_TiposProductos_ClasesProductos = If(v_dbo Is Nothing, New DBO_TiposProductos_ClasesProductos, v_dbo)
       dbo = m_DBO_TiposProductos_ClasesProductos
   End Sub

   Private Sub frmEntTiposProductos_ClasesProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spTiposProductos
       s0.cargar_TiposProductos(Me.cboTipoProducto)
       dim s1 as new spClasesProductos
       s1.cargar_ClasesProductos(Me.cboClaseProducto)
       If (me.mododeapertura = VISION) Then
           Me.cboTipoProducto.enabled = False
           Me.lblId_TipoProducto.enabled = False
           
           Me.cboClaseProducto.enabled = False
           Me.lblId_ClaseProducto.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_TipoProducto.enabled = false
   butVerId_TipoProducto.enabled = false
   butAddId_ClaseProducto.enabled = false
   butVerId_ClaseProducto.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_TiposProductos_ClasesProductos = ctype(dbo, DBO_TiposProductos_ClasesProductos)

           cboTipoProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto
           cboClaseProducto.SelectedValue = m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If cboTipoProducto.selectedvalue = nothing then
           If errores = "" Then cboTipoProducto.Focus()
           errores = errores & "No seleccionó un valor para Id_TipoProducto." & Environment.NewLine()
       Else
       m_DBO_TiposProductos_ClasesProductos.Id_TipoProducto = System.Convert.ToInt32(cboTipoProducto.SelectedValue)
       End If
       If cboClaseProducto.selectedvalue = nothing then
           If errores = "" Then cboClaseProducto.Focus()
           errores = errores & "No seleccionó un valor para Id_ClaseProducto." & Environment.NewLine()
       Else
       m_DBO_TiposProductos_ClasesProductos.Id_ClaseProducto = System.Convert.ToInt32(cboClaseProducto.SelectedValue)
       End If
       If (errores = String.empty) then
         Dbo = ctype(m_DBO_TiposProductos_ClasesProductos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_TipoProducto.Click
       Dim frmEnt As New frmTiposProductos()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_TipoProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_TipoProducto.Click
       Dim DBO_TiposProductos As New DBO_TiposProductos
       Dim frmEnt As New frmEntTiposProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spTiposProductos,DBO_TiposProductos)
       frmEnt.ShowDialog()
       dim s as new spTiposProductos
       s.cargar_TiposProductos(Me.cboTipoProducto)
   End Sub

   Private Sub butVerId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_ClaseProducto.Click
       Dim frmEnt As New frmClasesProductos()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_ClaseProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_ClaseProducto.Click
       Dim DBO_ClasesProductos As New DBO_ClasesProductos
       Dim frmEnt As New frmEntClasesProductos(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spClasesProductos,DBO_ClasesProductos)
       frmEnt.ShowDialog()
       dim s as new spClasesProductos
       s.cargar_ClasesProductos(Me.cboClaseProducto)
   End Sub

   Private Sub frmEntTiposProductos_ClasesProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
