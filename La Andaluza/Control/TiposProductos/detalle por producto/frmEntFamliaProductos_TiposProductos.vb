Public Class frmEntFamliaProductos_TiposProductos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_FamliaProductos_TiposProductos As DBO_FamliaProductos_TiposProductos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spFamliaProductos_TiposProductos = Nothing, Optional ByRef v_dbo As DBO_FamliaProductos_TiposProductos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spFamliaProductos_TiposProductos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_FamliaProductos_TiposProductos = If(v_dbo Is Nothing, New DBO_FamliaProductos_TiposProductos, v_dbo)
       dbo = m_DBO_FamliaProductos_TiposProductos
   End Sub

   Private Sub frmEntFamliaProductos_TiposProductos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spFamiliaProducto
       s0.cargar_FamiliaProducto(Me.cboFamiliaProducto)
       If (me.mododeapertura = VISION) Then
           Me.cboFamiliaProducto.enabled = False
           Me.lblId_FamiliaProducto.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_FamiliaProducto.enabled = false
   butVerId_FamiliaProducto.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_FamliaProductos_TiposProductos = ctype(dbo, DBO_FamliaProductos_TiposProductos)

           cboFamiliaProducto.SelectedValue = m_DBO_FamliaProductos_TiposProductos.Id_FamiliaProducto
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If cboFamiliaProducto.selectedvalue = nothing then
           If errores = "" Then cboFamiliaProducto.Focus()
           errores = errores & "No seleccionó un valor para Id_FamiliaProducto." & Environment.NewLine()
       Else
       m_DBO_FamliaProductos_TiposProductos.Id_FamiliaProducto = System.Convert.ToInt32(cboFamiliaProducto.SelectedValue)
       End If
       If (errores = String.empty) then
         Dbo = ctype(m_DBO_FamliaProductos_TiposProductos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

   Private Sub butVerId_FamiliaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_FamiliaProducto.Click
       Dim frmEnt As New frmFamiliaProducto()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_FamiliaProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_FamiliaProducto.Click
       Dim DBO_FamiliaProducto As New DBO_FamiliaProducto
       Dim frmEnt As New frmEntFamiliaProducto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spFamiliaProducto,DBO_FamiliaProducto)
       frmEnt.ShowDialog()
       dim s as new spFamiliaProducto
       s.cargar_FamiliaProducto(Me.cboFamiliaProducto)
   End Sub

   Private Sub frmEntFamliaProductos_TiposProductos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
