Public Class frmEntAvisosPedidos
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_AvisosPedidos As DBO_AvisosPedidos

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spAvisosPedidos = Nothing, Optional ByRef v_dbo As DBO_AvisosPedidos = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spAvisosPedidos,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_AvisosPedidos = If(v_dbo Is Nothing, New DBO_AvisosPedidos, v_dbo)
       dbo = m_DBO_AvisosPedidos
   End Sub

   Public Sub New()
       MyBase.new(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, ctype(new spAvisosPedidos,BasesParaCompatibilidad.storedprocedure), ctype(new DBO_AvisosPedidos, BasesParaCompatibilidad.databussines))
       InitializeComponent()
   End Sub

   Private Sub frmEntAvisosPedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       dim s0 as new spProveedores
       s0.cargar_Proveedores(Me.cboproveedor)
       dim s1 as new spArticulos1
       s1.cargar_Articulos1(Me.cboarticulo)
       If (me.mododeapertura = VISION) Then
           Me.cboproveedor.enabled = False
           Me.lblId_proveedor.enabled = False
           
           Me.cboarticulo.enabled = False
           Me.lblId_articulo.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_proveedor.enabled = false
   butVerId_proveedor.enabled = false
   butAddId_articulo.enabled = false
   butVerId_articulo.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       If (Me.modoDeApertura = INSERCION) Then
       Me.m_DBO_AvisosPedidos = new dbo_AvisosPedidos
       Else
       Me.m_DBO_AvisosPedidos = ctype(dbo, DBO_AvisosPedidos)
       End If

           cboproveedor.SelectedValue = m_DBO_AvisosPedidos.Id_proveedor
           cboarticulo.SelectedValue = m_DBO_AvisosPedidos.Id_articulo
           chbLeido.Checked = m_DBO_AvisosPedidos.Leido
           txtCabecera.Text = m_DBO_AvisosPedidos.Cabecera
           txtDetalle.Text = m_DBO_AvisosPedidos.Detalle
           dtpFecha.Value = m_DBO_AvisosPedidos.Fecha
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       m_DBO_AvisosPedidos.Leido = chbLeido.Checked

       If txtCabecera.Text= "" then
           If errores = "" Then txtCabecera.Focus()
           errores = errores & "El campo Cabecera no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_AvisosPedidos.Cabecera = txtCabecera.Text
       End If



       m_DBO_AvisosPedidos.Detalle = txtDetalle.Text


       m_DBO_AvisosPedidos.Fecha = dtpFecha.value


       If (errores = String.empty) then
         Dbo = ctype(m_DBO_AvisosPedidos, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef dtb As BasesParaCompatibilidad.DataBase = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(dtb)
   End Sub

   Private Sub butVerId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_proveedor.Click
       Dim frmEnt As New frmProveedores()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_proveedor.Click
       Dim DBO_Proveedores As New DBO_Proveedores
       Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spProveedores,DBO_Proveedores)
       frmEnt.ShowDialog()
       dim s as new spProveedores
       s.cargar_Proveedores(Me.cboproveedor)
   End Sub

   Private Sub butVerId_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_articulo.Click
       Dim frmEnt As New frmArticulos1()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_articulo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_articulo.Click
       Dim DBO_Articulos1 As New DBO_Articulos1
       Dim frmEnt As New frmEntArticulos1(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spArticulos1,DBO_Articulos1)
       frmEnt.ShowDialog()
       dim s as new spArticulos1
       s.cargar_Articulos1(Me.cboarticulo)
   End Sub

   Private Sub frmEntAvisosPedidos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
   End Sub
End Class
