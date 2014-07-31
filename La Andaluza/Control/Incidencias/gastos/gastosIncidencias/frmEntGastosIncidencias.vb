Public Class frmEntGastosIncidencias
   Inherits BasesParaCompatibilidad.DetailedSimpleForm
   Implements BasesParaCompatibilidad.Savable
   Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
   Private m_DBO_GastosIncidencias As DBO_GastosIncidencias

   Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spGastosIncidencias = Nothing, Optional ByRef v_dbo As DBO_GastosIncidencias = Nothing)
       MyBase.new(modoDeApertura, v_sp, ctype(v_dbo, BasesParaCompatibilidad.databussines))
       InitializeComponent()
       If v_sp Is Nothing then
       sp = ctype( New spGastosIncidencias,BasesParaCompatibilidad.StoredProcedure)
       else
       sp = v_sp
       End if
       m_DBO_GastosIncidencias = If(v_dbo Is Nothing, New DBO_GastosIncidencias, v_dbo)
       dbo = m_DBO_GastosIncidencias
   End Sub

   Private Sub frmEntGastosIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
       
       dim s1 as new spConceptosGastosIncidencias
       s1.cargar_ConceptosGastosIncidencias(Me.cboconcepto)
       
       dim s3 as new spProveedores
       s3.cargar_Proveedores(Me.cboproveedor)
       dim s4 as new spEmpleados
       s4.cargar_empleados(Me.cboempleado)
       dim s5 as new spClientes
       s5.cargar_Clientes(Me.cbocliente)
       If (me.mododeapertura = VISION) Then
           Me.cboconcepto.enabled = False
           Me.lblId_concepto.enabled = False
           
           Me.cbocosteConcepto.enabled = False
           Me.lblId_costeConcepto.enabled = False
           
           Me.cboproveedor.enabled = False
           Me.lblId_proveedor.enabled = False
           
           Me.cboempleado.enabled = False
           Me.lblId_empleado.enabled = False
           
           Me.cbocliente.enabled = False
           Me.lblId_cliente.enabled = False
           
       End If
       If Config.userType <> 4 and Config.userType <> 9 Then
   butAddId_concepto.enabled = false
   butVerId_concepto.enabled = false
   butAddId_costeConcepto.enabled = false
   butVerId_costeConcepto.enabled = false
   butAddId_proveedor.enabled = false
   butVerId_proveedor.enabled = false
   butAddId_empleado.enabled = false
   butVerId_empleado.enabled = false
   butAddId_cliente.enabled = false
   butVerId_cliente.enabled = false
       End If

   End Sub

   Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
       Me.m_DBO_GastosIncidencias = ctype(dbo, DBO_GastosIncidencias)

           txtCantidad.Text = m_DBO_GastosIncidencias.Cantidad
           cboconcepto.SelectedValue = m_DBO_GastosIncidencias.Id_concepto
           cbocosteConcepto.SelectedValue = m_DBO_GastosIncidencias.Id_costeConcepto
           cboproveedor.SelectedValue = m_DBO_GastosIncidencias.Id_proveedor
           cboempleado.SelectedValue = m_DBO_GastosIncidencias.Id_empleado
           cbocliente.SelectedValue = m_DBO_GastosIncidencias.Id_cliente
   End Sub

   Protected Overrides Function GetValores() as boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores as String = string.empty


       If txtCantidad.Text= "" then
           If errores = "" Then txtCantidad.Focus()
           errores = errores & "El campo Cantidad no puede estar vacío." & Environment.NewLine()
       Else
       m_DBO_GastosIncidencias.Cantidad = System.Convert.ToString(txtCantidad.Text)
       End If


       If cboconcepto.selectedvalue = nothing then
           If errores = "" Then cboconcepto.Focus()
           errores = errores & "No seleccionó un valor para Id_concepto." & Environment.NewLine()
       Else
       m_DBO_GastosIncidencias.Id_concepto = System.Convert.ToInt32(cboconcepto.SelectedValue)
       End If
       If cbocosteConcepto.selectedvalue = nothing then
           If errores = "" Then cbocosteConcepto.Focus()
           errores = errores & "No seleccionó un valor para Id_costeConcepto." & Environment.NewLine()
       Else
       m_DBO_GastosIncidencias.Id_costeConcepto = System.Convert.ToInt32(cbocosteConcepto.SelectedValue)
       End If
       If (errores = String.empty) then
         Dbo = ctype(m_DBO_GastosIncidencias, BasesParaCompatibilidad.databussines)
         return true
       Else
         MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores,"Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
         return false
        End IF
   End Function

   Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = nothing) Implements BasesParaCompatibilidad.Savable.Guardar
       MyBase.Guardar(trans)
   End Sub

    Private Sub butVerId_controlIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmControlIncidencias()
        GUImain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_controlIncidencia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim DBO_ControlIncidencias As New DBO_ControlIncidencias
        Dim frmEnt As New frmEntControlIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spControlIncidencias, DBO_ControlIncidencias)
        frmEnt.ShowDialog()

    End Sub

   Private Sub butVerId_concepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_concepto.Click
       Dim frmEnt As New frmConceptosGastosIncidencias()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_concepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_concepto.Click
       Dim DBO_ConceptosGastosIncidencias As New DBO_ConceptosGastosIncidencias
       Dim frmEnt As New frmEntConceptosGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spConceptosGastosIncidencias,DBO_ConceptosGastosIncidencias)
       frmEnt.ShowDialog()
       dim s as new spConceptosGastosIncidencias
       s.cargar_ConceptosGastosIncidencias(Me.cboconcepto)
   End Sub

   Private Sub butVerId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_costeConcepto.Click
       Dim frmEnt As New frmCostesPorConcepto()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_costeConcepto.Click
       Dim DBO_CostesPorConcepto As New DBO_CostesPorConcepto
       Dim frmEnt As New frmEntCostesPorConcepto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spCostesPorConcepto,DBO_CostesPorConcepto)
       frmEnt.ShowDialog()
       dim s as new spCostesPorConcepto
        s.cargar_CostesPorConcepto(Me.cbocosteConcepto, Convert.ToInt32(Me.cboconcepto.SelectedValue))
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

   Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
       Dim frmEnt As New frmEmpleados()
       guiMain.añadirPestaña(frmEnt)
   End Sub

   Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
       Dim DBO_Empleados As New DBO_Empleados
       Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, new spEmpleados,DBO_Empleados)
       frmEnt.ShowDialog()
       dim s as new spEmpleados
       s.cargar_empleados(Me.cboempleado)
   End Sub

   Private Sub frmEntGastosIncidencias_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
       BasesParaCompatibilidad.DetailedSimpleForm.centerIn(ctype(Me.tlpMiddle, Control), Me)
    End Sub

    

    Private Sub cboconcepto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboconcepto.SelectedValueChanged
        Try
            If Not Me.cboconcepto.SelectedValue Is Nothing Then
                Dim s2 As New spCostesPorConcepto
                s2.cargar_CostesPorConcepto(Me.cbocosteConcepto, Convert.ToInt32(Me.cboconcepto.SelectedValue))
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class
