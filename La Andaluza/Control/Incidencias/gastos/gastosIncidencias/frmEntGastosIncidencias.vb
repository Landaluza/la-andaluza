Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntGastosIncidencias
    Inherits BasesParaCompatibilidad.DetailedSimpleForm
    Implements BasesParaCompatibilidad.Savable
    Public Shadows Event afterSave(sender As Object, args As EventArgs) Implements BasesParaCompatibilidad.Savable.afterSave
    Private m_DBO_GastosIncidencias As DBO_GastosIncidencias
    Private spCostesPorConcepto As New spCostesPorConcepto
    Public Sub New(ByVal modoDeApertura As String, Optional ByRef v_sp As spGastosIncidencias = Nothing, Optional ByRef v_dbo As DBO_GastosIncidencias = Nothing)
        MyBase.New(modoDeApertura, v_sp, CType(v_dbo, BasesParaCompatibilidad.DataBussines))
        InitializeComponent()
        spCostesPorConcepto = New spCostesPorConcepto
        If v_sp Is Nothing Then
            sp = CType(New spGastosIncidencias, BasesParaCompatibilidad.StoredProcedure)
        Else
            sp = v_sp
        End If
        m_DBO_GastosIncidencias = If(v_dbo Is Nothing, New DBO_GastosIncidencias, v_dbo)
        dbo = m_DBO_GastosIncidencias

        Me.dtpFecha.activarFoco()
    End Sub

    Private Sub frmEntGastosIncidencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s1 As New spConceptosGastosIncidencias
        s1.cargar_ConceptosGastosIncidencias(Me.cboconcepto)

        Dim s3 As New spProveedores
        s3.cargar_Proveedores(Me.cboproveedor)
        Dim s4 As New spEmpleados
        s4.cargar_Empleados(Me.cboempleado)
        Dim s5 As New spClientes
        s5.cargar_Clientes(Me.cbocliente)
        Dim s6 As New spMedidasProductos
        s6.cargar_MedidasProductos(cboMedidaProducto)

        If (Me.ModoDeApertura = VISION) Then
            Me.cboconcepto.Enabled = False

            Me.cbocosteConcepto.Enabled = False

            Me.cboproveedor.Enabled = False
            Me.rbProveedor.Enabled = False

            Me.cboempleado.Enabled = False
            Me.rbEmpleado.Enabled = False

            Me.cbocliente.Enabled = False
            Me.rbCliente.Enabled = False

            Me.cboMedidaProducto.Enabled = False
        End If
        If Config.UserType <> 4 And Config.UserType <> 9 Then
            butAddId_concepto.Enabled = False
            butVerId_concepto.Enabled = False
            butAddId_costeConcepto.Enabled = False
            butAddId_proveedor.Enabled = False
            butVerId_proveedor.Enabled = False
            butAddId_empleado.Enabled = False
            butVerId_empleado.Enabled = False
            butAddId_cliente.Enabled = False
            butVerId_cliente.Enabled = False
        End If

    End Sub

    Overrides Sub SetValores() Implements BasesParaCompatibilidad.Savable.setValores
        Me.m_DBO_GastosIncidencias = CType(dbo, DBO_GastosIncidencias)

        txtCantidad.Text = m_DBO_GastosIncidencias.Cantidad
        cboconcepto.SelectedValue = m_DBO_GastosIncidencias.Id_concepto
        cbocosteConcepto.SelectedValue = m_DBO_GastosIncidencias.Id_costeConcepto
        cboproveedor.SelectedValue = m_DBO_GastosIncidencias.Id_proveedor
        txtCantidadRef.Text = m_DBO_GastosIncidencias.CantidadReferencia
        txtObservaciones.Text = m_DBO_GastosIncidencias.Observaciones
        cboMedidaProducto.SelectedValue = m_DBO_GastosIncidencias.Id_MedidaReferencia
        dtpFecha.Value = m_DBO_GastosIncidencias.Fecha

        If Not cboproveedor.SelectedValue Is Nothing Then rbProveedor.Checked = True
        cboempleado.SelectedValue = m_DBO_GastosIncidencias.Id_empleado
        If Not cboempleado.SelectedValue Is Nothing Then rbEmpleado.Checked = True
        cbocliente.SelectedValue = m_DBO_GastosIncidencias.Id_cliente
        If Not cbocliente.SelectedValue Is Nothing Then rbCliente.Checked = True

    End Sub

    Protected Overrides Function GetValores() As Boolean Implements BasesParaCompatibilidad.Savable.getValores
        Dim errores As String = String.Empty

        If dtpFecha.Value.Date > DateTime.Now.Date Then
            dtpFecha.Focus()
            errores = errores & "La fecha no puede ser posterior a hoy." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Fecha = dtpFecha.Value.Date
        End If

        If txtCantidad.Text = "" Then
            If errores = "" Then txtCantidad.Focus()
            errores = errores & "El campo Cantidad no puede estar vacío." & Environment.NewLine()
        Else
            If Not IsNumeric(txtCantidad.Text) Then
                If errores = "" Then txtCantidad.Focus()
                errores = errores & "El campo Cantidad debe ser numérico." & Environment.NewLine()
            End If
            m_DBO_GastosIncidencias.Cantidad = System.Convert.ToDouble(txtCantidad.Text.Replace(".", ","))
        End If

        If txtCantidadRef.Text <> "" Then
            If Not IsNumeric(txtCantidadRef.Text) Then
                If errores = "" Then txtCantidad.Focus()
                errores = errores & "El campo Cantidad debe ser numérico." & Environment.NewLine()
            End If
            m_DBO_GastosIncidencias.CantidadReferencia = System.Convert.ToDouble(txtCantidadRef.Text.Replace(".", ","))

            If Not cboMedidaProducto.SelectedValue Is Nothing Then
                m_DBO_GastosIncidencias.Id_MedidaReferencia = cboMedidaProducto.SelectedValue
            Else
                m_DBO_GastosIncidencias.Id_MedidaReferencia = 0
            End If
        Else
            m_DBO_GastosIncidencias.Id_MedidaReferencia = 0
        End If

        m_DBO_GastosIncidencias.Observaciones = txtObservaciones.Text

        If cboconcepto.SelectedValue = Nothing Then
            If errores = "" Then cboconcepto.Focus()
            errores = errores & "No seleccionó un valor para Id_concepto." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Id_concepto = System.Convert.ToInt32(cboconcepto.SelectedValue)
        End If

        If cbocosteConcepto.SelectedValue = Nothing Then
            If errores = "" Then cbocosteConcepto.Focus()
            errores = errores & "No seleccionó un valor para Id_costeConcepto." & Environment.NewLine()
        Else
            m_DBO_GastosIncidencias.Id_costeConcepto = System.Convert.ToInt32(cbocosteConcepto.SelectedValue)
        End If

        Me.m_DBO_GastosIncidencias.Id_cliente = 0
        Me.m_DBO_GastosIncidencias.Id_empleado = 0
        Me.m_DBO_GastosIncidencias.Id_proveedor = 0


        If (cbocliente.SelectedValue Is Nothing And cboproveedor.SelectedValue Is Nothing And cboempleado.SelectedValue Is Nothing) _
            Or (Not rbCliente.Checked And Not rbEmpleado.Checked And Not rbProveedor.Checked) Then

            errores = errores & "No seleccionó un valor para el causante." & Environment.NewLine()
        Else
            If rbCliente.Checked Then
                If cbocliente Is Nothing Then
                    If errores = "" Then cbocliente.Focus()
                    errores = errores & "No seleccionó un valor para cliente." & Environment.NewLine()
                Else
                    Me.m_DBO_GastosIncidencias.Id_cliente = cbocliente.SelectedValue
                End If
            Else
                If rbEmpleado.Checked Then
                    If cboempleado Is Nothing Then
                        If errores = "" Then cboempleado.Focus()
                        errores = errores & "No seleccionó un valor para empleado." & Environment.NewLine()
                    Else
                        Me.m_DBO_GastosIncidencias.Id_empleado = cboempleado.SelectedValue
                    End If
                Else
                    If rbProveedor.Checked Then
                        If cboproveedor Is Nothing Then
                            If errores = "" Then cboproveedor.Focus()
                            errores = errores & "No seleccionó un valor para proveedor." & Environment.NewLine()
                        Else
                            Me.m_DBO_GastosIncidencias.Id_proveedor = cboproveedor.SelectedValue
                        End If
                    End If
                End If
            End If
        End If


        If (errores = String.Empty) Then
            dbo = CType(m_DBO_GastosIncidencias, BasesParaCompatibilidad.DataBussines)
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
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_concepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_concepto.Click
        Dim DBO_ConceptosGastosIncidencias As New DBO_ConceptosGastosIncidencias
        Dim frmEnt As New frmEntConceptosGastosIncidencias(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spConceptosGastosIncidencias, DBO_ConceptosGastosIncidencias)
        frmEnt.ShowDialog()
        Dim s As New spConceptosGastosIncidencias
        s.cargar_ConceptosGastosIncidencias(Me.cboconcepto)
    End Sub

    Private Sub butVerId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim frmEnt As New frmCostesPorConcepto()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_costeConcepto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_costeConcepto.Click
        Dim DBO_CostesPorConcepto As New DBO_CostesPorConcepto
        Dim frmEnt As New frmEntCostesPorConcepto(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spCostesPorConcepto, DBO_CostesPorConcepto)
        frmEnt.ShowDialog()
        Dim s As New spCostesPorConcepto
        s.cargar_CostesPorConcepto(Me.cbocosteConcepto, Convert.ToInt32(Me.cboconcepto.SelectedValue))
    End Sub

    Private Sub butVerId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_proveedor.Click
        Dim frmEnt As New frmProveedores()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_proveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_proveedor.Click
        Dim DBO_Proveedores As New DBO_Proveedores
        Dim frmEnt As New frmEntProveedores(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spProveedores, DBO_Proveedores)
        frmEnt.ShowDialog()
        Dim s As New spProveedores
        s.cargar_Proveedores(Me.cboproveedor)
    End Sub

    Private Sub butVerId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butVerId_empleado.Click
        Dim frmEnt As New frmEmpleados()
        frmEnt.ShowDialog()
    End Sub

    Private Sub butAddId_empleado_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAddId_empleado.Click
        Dim DBO_Empleados As New DBO_Empleados
        Dim frmEnt As New frmEntEmpleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spEmpleados, DBO_Empleados)
        frmEnt.ShowDialog()
        Dim s As New spEmpleados
        s.cargar_Empleados(Me.cboempleado)
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


    Private Sub btnVerCosteConvepto_Click(sender As Object, e As EventArgs) Handles btnVerCosteConvepto.Click
        Dim frm As New frmCostesPorConcepto
        frm.ShowDialog()
    End Sub
End Class
