Public Class frmEntGastosIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_GastosIncidencias As DBO_GastosIncidencias
    Private spCostesPorConcepto As New spCostesPorConcepto
    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spGastosIncidencias = Nothing, Optional ByRef v_dbo As DBO_GastosIncidencias = Nothing)
        MyBase.new(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.databussines))
        InitializeComponent()
        spCostesPorConcepto = New spCostesPorConcepto
        If v_sp Is Nothing Then
            sp = CType(New spGastosIncidencias, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_GastosIncidencias = If(v_dbo Is Nothing, New DBO_GastosIncidencias, v_dbo)
        dbo = m_DBO_GastosIncidencias
    End Sub

    Private Sub frmEntGastosIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s1 As New spConceptosGastosIncidencias
        s1.cargar_ConceptosGastosIncidencias(Me.cboconcepto)

        Dim s3 As New spProveedores
        s3.cargar_Proveedores(Me.cboproveedor)
        Dim s4 As New spEmpleados
        s4.cargar_empleados(Me.cboempleado)
        Dim s5 As New spClientes
        s5.cargar_Clientes(Me.cbocliente)
        If (Me.mododeapertura = VISION) Then
            Me.cboconcepto.enabled = False
            Me.lblId_concepto.enabled = False

            Me.cbocosteConcepto.enabled = False
            Me.lblId_costeConcepto.enabled = False

            Me.cboproveedor.enabled = False
            Me.rbProveedor.Enabled = False

            Me.cboempleado.enabled = False
            Me.rbEmpleado.Enabled = False

            Me.cbocliente.enabled = False
            Me.rbCliente.Enabled = False

        End If
        If Config.userType <> 4 And Config.userType <> 9 Then
            butAddId_concepto.enabled = False
            butVerId_concepto.enabled = False
            butAddId_costeConcepto.enabled = False
            butVerId_costeConcepto.enabled = False
            butAddId_proveedor.enabled = False
            butVerId_proveedor.enabled = False
            butAddId_empleado.enabled = False
            butVerId_empleado.enabled = False
            butAddId_cliente.enabled = False
            butVerId_cliente.enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_GastosIncidencias = CType(dbo, DBO_GastosIncidencias)

        txtCantidad.Text = m_DBO_GastosIncidencias.Cantidad
        cboconcepto.SelectedValue = m_DBO_GastosIncidencias.Id_concepto
        cbocosteConcepto.SelectedValue = m_DBO_GastosIncidencias.Id_costeConcepto
        cboproveedor.SelectedValue = m_DBO_GastosIncidencias.Id_proveedor
        cboempleado.SelectedValue = m_DBO_GastosIncidencias.Id_empleado
        cbocliente.SelectedValue = m_DBO_GastosIncidencias.Id_cliente
    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.empty


        If txtCantidad.Text = "" Then
            If errores = "" Then txtCantidad.Focus()
            errores = errores & "El campo Cantidad no puede estar vacío." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Cantidad = System.Convert.ToString(txtCantidad.Text)
        End If


        If cboconcepto.selectedvalue = Nothing Then
            If errores = "" Then cboconcepto.Focus()
            errores = errores & "No seleccionó un valor para Id_concepto." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Id_concepto = System.Convert.ToInt32(cboconcepto.SelectedValue)
        End If
        If cbocosteConcepto.selectedvalue = Nothing Then
            If errores = "" Then cbocosteConcepto.Focus()
            errores = errores & "No seleccionó un valor para Id_costeConcepto." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Id_costeConcepto = System.Convert.ToInt32(cbocosteConcepto.SelectedValue)
        End If
        If (errores = String.empty) Then
            Dbo = CType(m_DBO_GastosIncidencias, BasesParaCompatibilidad.databussines)
            Return True
        Else
            MessageBox.Show("Rellene correctamente el formulario, se han encontrado os siguientes errores:" & Environment.NewLine() & Environment.NewLine() & errores, "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Return False
        End If
    End Function

    Public Overrides Sub Guardar(Optional ByRef trans As SqlClient.SqlTransaction = Nothing) Implements BasesParaCompatibilidad.Savable.Guardar
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
        Dim frmEnt As New frmEntConceptosGastosIncidencias(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spConceptosGastosIncidencias, DBO_ConceptosGastosIncidencias)
        frmEnt.ShowDialog()
        Dim s As New spConceptosGastosIncidencias
        s.cargar_ConceptosGastosIncidencias(Me.cboconcepto)
    End Sub

    Private Sub butVerId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_costeConcepto.Click
        Dim frmEnt As New frmCostesPorConcepto()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_costeConcepto.Click
        Dim DBO_CostesPorConcepto As New DBO_CostesPorConcepto
        Dim frmEnt As New frmEntCostesPorConcepto(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spCostesPorConcepto, DBO_CostesPorConcepto)
        frmEnt.ShowDialog()
        Dim s As New spCostesPorConcepto
        s.cargar_CostesPorConcepto(Me.cbocosteConcepto, Convert.ToInt32(Me.cboconcepto.SelectedValue))
    End Sub

    Private Sub butVerId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_proveedor.Click
        Dim frmEnt As New frmProveedores()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        frmEnt.ShowDialog()
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboproveedor)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        guiMain.añadirPestaña(frmEnt)
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.GridSimpleForm.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        frmEnt.ShowDialog()
        Dim s As New spEmpleados
        s.cargar_empleados(Me.cboempleado)
    End Sub

    Private Sub frmEntGastosIncidencias_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BasesParaCompatibilidad.DetailedSimpleForm.centerIn(CType(Me.tlpMiddle, Control), Me)
    End Sub



    Private Sub cboconcepto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cboconcepto.SelectedValueChanged
        Try
            If Not Me.cboconcepto.SelectedValue Is Nothing Then
                spCostesPorConcepto.cargar_CostesPorConcepto(Me.cbocosteConcepto, Convert.ToInt32(Me.cboconcepto.SelectedValue))
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnActualizarCoste_Click(sender As Object, e As EventArgs) Handles btnActualizarCoste.Click
        Try
            Dim dt As DataRow = spCostesPorConcepto.cargar_CostesPorConceptoActual(Convert.ToInt32(Me.cboconcepto.SelectedValue))
            Me.cbocosteConcepto.SelectedValue = dt.Item(0)
        Catch ex As Exception

        End Try
    End Sub


End Class
