Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosProveedoresMaestros
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer

    Private DBO_PedidoProveedor As DBO_PedidosProveedoresMaestros
    Private DBO_PedidoProveedorDetalle As DBO_PedidosProveedoresDetalles
    Private spPedidosProveedoresMaestros As spPedidosProveedoresMaestros
    Private spPedidosProveedoresDetalles As spPedidosProveedoresDetalles
    Private spPedidosProveedoresEntregas As spPedidosProveedoresEntregas
    Private frmEnt As frmEntPedidosProveedoresDetalles
    Private frmEntPedidosProveedoresEntregas As frmEntPedidosProveedoresEntregas
    Private frmPedidosProveedoresDocumentos1 As frmPedidosProveedoresDocumentos1
    Public Sub New(ByRef PedidoProveedor As DBO_PedidosProveedoresMaestros, ByVal Pos As Integer)
        InitializeComponent()
        DBO_PedidoProveedorDetalle = New DBO_PedidosProveedoresDetalles
        spPedidosProveedoresMaestros = New spPedidosProveedoresMaestros
        spPedidosProveedoresEntregas = New spPedidosProveedoresEntregas
        spPedidosProveedoresDetalles = New spPedidosProveedoresDetalles
        dtb = New BasesParaCompatibilidad.DataBase()
        DBO_PedidoProveedor = PedidoProveedor
        m_Pos = Pos
        Me.txtFechaEmision.activarFoco()
        Me.txtFechaEmision.activarFoco()

        frmPedidosProveedoresDocumentos1 = New frmPedidosProveedoresDocumentos1(DBO_PedidoProveedor.PedidoProveedorMaestroID)
        Engine_LA.FormEnPestaña(frmPedidosProveedoresDocumentos1, tpDocumentos)
    End Sub

    Private Sub frmEntPedidosProveedoresMaestros_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboProveedores.mam_DataSource("ProveedoresSelectCbo", False, dtb)
        cboEstados.mam_DataSource("PedidosProveedoresEstadosSelectCbo", False, dtb)
        cboEmpleados.mam_DataSource("EmpleadosSelectCbo", False, dtb)


        'DBO_PedidoProveedor.EstadoID = 1 'Para que no se quede el combo vacio
        AddHandler cboProveedores.SelectedValueChanged, AddressOf cboProveedores_SelectedValueChanged
        SetValores()
        If DBO_PedidoProveedor.PedidoProveedorMaestroID <> 0 Then
            RellenarDgvNivel1()
        End If
    End Sub

#Region "Acciones nivel 0  Maestro"

    Overrides Sub MoveRecord(ByVal Move As String)
        Select Case Move
            Case Is = "First"
                m_Pos = 0
            Case Is = "Previous"
                m_Pos = m_Pos - 1
            Case Is = "Next"
                m_Pos = m_Pos + 1
            Case Is = "Last"
                m_Pos = GeneralBindingSource.Count - 1
        End Select
        GeneralBindingSource.Position = m_Pos
        DBO_PedidoProveedor = spPedidosProveedoresMaestros.Select_Record(GeneralBindingSource(m_Pos).Item("ArticuloID"), dtb)
        SetValores()
    End Sub

    Overrides Sub Guardar()
        GetValores()
        If Me.Text.Substring(0, 3) = "Ins" Then
            spPedidosProveedoresMaestros.InsertPedidosProveedoresMaestros(DBO_PedidoProveedor, dtb)
        Else
            spPedidosProveedoresMaestros.UpdatePedidosProveedoresMaestros(DBO_PedidoProveedor, DBO_PedidoProveedor, dtb)
        End If
        Me.Close()
    End Sub

    Public Overrides Sub SetValores()
        txtPedidoProveedorMaestroID.Text = DBO_PedidoProveedor.PedidoProveedorMaestroID
        txtNumero.Text = DBO_PedidoProveedor.Numero
        txtFechaEmision.Text = DBO_PedidoProveedor.FechaEmision
        cboEstados.SelectedValue = DBO_PedidoProveedor.EstadoID
        txtFechaServicio.Text = DBO_PedidoProveedor.FechaServicio
        txtObservaciones.Text = If(DBO_PedidoProveedor.Observaciones_IsDBNull = True, Nothing, DBO_PedidoProveedor.Observaciones)
        cboProveedores.SelectedValue = DBO_PedidoProveedor.ProveedorID
        cboEmpleados.SelectedValue = DBO_PedidoProveedor.SolicitanteID
        txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Text = DBO_PedidoProveedor.PedidosProveedoresEstados_PedidoProveedorEstadoID

        If DBO_PedidoProveedor.PedidoProveedorMaestroID = 0 Then
            grbNivel1.Enabled = False
            grbNivel2.Enabled = False
            Me.frmPedidosProveedoresDocumentos1.Enabled = False
        Else
            grbNivel1.Enabled = True
            grbNivel2.Enabled = True
            Me.frmPedidosProveedoresDocumentos1.Enabled = True
        End If
    End Sub

    Private Sub GetValores()
        'm_RegistroActual.Numero = System.Convert.ToInt32(txtNumero.Text)
        DBO_PedidoProveedor.ProveedorID = cboProveedores.SelectedValue
        DBO_PedidoProveedor.FechaEmision = System.Convert.ToDateTime(txtFechaEmision.Text)
        DBO_PedidoProveedor.FechaServicio = System.Convert.ToDateTime(txtFechaServicio.Text)
        DBO_PedidoProveedor.EstadoID = cboEstados.SelectedValue
        DBO_PedidoProveedor.Observaciones = System.Convert.ToString(If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        DBO_PedidoProveedor.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        DBO_PedidoProveedor.SolicitanteID = cboEmpleados.SelectedValue
        'm_RegistroActual.PedidosProveedoresEstados_PedidoProveedorEstadoID = System.Convert.ToInt32(txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Text)
        DBO_PedidoProveedor.PedidosProveedoresEstados_PedidoProveedorEstadoID = cboEstados.SelectedValue
    End Sub
#End Region

#Region "Acciones nivel 1 = = detalles = lineas articulos pedidos"

    Private Sub bdnNivel1Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Add.Click
        ActionNivel1("Insertar")
        bdsNivel1.MoveLast()
    End Sub

    Private Sub bdnNivel1Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Edit.Click, dgvNivel1.CellDoubleClick
        ActionNivel1("Modificar")
    End Sub

    Private Sub bdnNivel1Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Delete.Click
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then _
                    spPedidosProveedoresDetalles.DeletePedidosProveedoresDetalles(dgvNivel1.CurrentRow.Cells("PedidoProveedorDetalleID").Value, dtb)
        RellenarDgvNivel1()
        If dgvNivel1.RowCount > 0 Then RellenarDgvNivel2()
    End Sub

    Private Sub dgvDetalles_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNivel1.CellClick
        RellenarDgvNivel2()
    End Sub

    Private Sub ActionNivel1(ByVal TipoAction As String)
        Dim m_Pos As Integer = bdsNivel1.Position

        If TipoAction = "Insertar" Then
            DBO_PedidoProveedorDetalle.PedidoProveedorMaestroID = DBO_PedidoProveedor.PedidoProveedorMaestroID
            DBO_PedidoProveedorDetalle.EstadoID = 1 'Para que en los pedidos nuevos los Articulos aparezacan como solicitado
        Else
            DBO_PedidoProveedorDetalle = spPedidosProveedoresDetalles.Select_Record(bdsNivel1(m_Pos).Item("PedidoProveedorDetalleID"), dtb)
        End If

        frmEnt = New frmEntPedidosProveedoresDetalles(DBO_PedidoProveedorDetalle, m_Pos)
        frmEnt.Proveedor = cboProveedores.SelectedValue
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        RellenarDgvNivel1()
    End Sub

    Sub HabilitarBotonesNivel1()

        If Me.Text.Substring(0, 3) = "Ver" Then
            bdnNivel1.DeleteItem.Enabled = False
            bdnNivel1Edit.Enabled = False
            bdnNivel1.AddNewItem.Enabled = True
        Else
            If dgvNivel1.RowCount > 0 Then
                bdnNivel1Delete.Enabled = True
                bdnNivel1Edit.Enabled = True
                bdnNivel1.AddNewItem.Enabled = True
            Else
                bdnNivel1Delete.Enabled = False
                bdnNivel1Edit.Enabled = False
                bdnNivel1.AddNewItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub RellenarDgvNivel1()
        dtb.PrepararConsulta("PedidosProveedoresDetallesSelectByMaestroIDDgv @id")
        dtb.AñadirParametroConsulta("@id", DBO_PedidoProveedor.PedidoProveedorMaestroID)
        ' Dim spSelectDgv As String = "PedidosProveedoresDetallesSelectByMaestroIDDgv '" & DBO_PedidoProveedor.PedidoProveedorMaestroID & "'"
        bdsNivel1.DataSource = dtb.Consultar()
        bdnNivel1.BindingSource = bdsNivel1
        With dgvNivel1
            .DataSource = bdsNivel1
            'Necesito tener los dos ID, el del Maestro y el del Detalle, para pasarlos como parametros en  Private Sub Action
            .Columns("PedidoProveedorDetalleID").Visible = False
            .Columns("PedidoProveedorMaestroID").Visible = False
            .Columns("FechaServicio").Visible = False
            .Columns("Estado").Visible = False

            .FormatoColumna("CodigoLA", BasesParaCompatibilidad.TiposColumna.QS, 100, 0)
            .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Referencia, , 1)
            .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 70, 2)
            .FormatoColumna("Medida", BasesParaCompatibilidad.TiposColumna.Izquierda, 50, 3)
            .FormatoColumna("Recibido", BasesParaCompatibilidad.TiposColumna.Double2, 70, 4)
            .FormatoColumna("Pendiente", BasesParaCompatibilidad.TiposColumna.Double2, 70, 5)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 350, 6)
            .FormatoGeneral()
        End With
        HabilitarBotonesNivel1()
        If dgvNivel1.RowCount > 0 Then RellenarDgvNivel2()
    End Sub
#End Region

#Region "Acciones nivel 2 = entregas de cada articulo pedido"

    Private Sub bdnNivel2Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel2Add.Click
        ActionNivel2("Insertar")
        bdsNivel2.MoveLast()
    End Sub

    Private Sub bdnNivel2Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel2Edit.Click, dgvNivel2.CellDoubleClick
        ActionNivel2("Modificar")
    End Sub

    Private Sub bdnNivel2Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel2Delete.Click
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then _
                    spPedidosProveedoresEntregas.DeletePedidosProveedoresEntregas(dgvNivel2.CurrentRow.Cells("PedidoProveedorEntregaID").Value, dtb)
        RellenarDgvNivel1()
        RellenarDgvNivel2()
    End Sub

    Private Sub ActionNivel2(ByVal TipoAction As String)
        Dim DBO_PedidoProveedorEntrega As New DBO_PedidosProveedoresEntregas
        Dim spPedidosProveedoresEntregas As New spPedidosProveedoresEntregas
        Dim m_Pos As Integer = bdsNivel2.Position

        If TipoAction = "Insertar" Then
            DBO_PedidoProveedorEntrega.PedidoProveedorDetalleID = dgvNivel1.CurrentRow.Cells("PedidoProveedorDetalleID").Value
        Else
            DBO_PedidoProveedorEntrega = spPedidosProveedoresEntregas.Select_Record(bdsNivel2(m_Pos).Item("PedidoProveedorEntregaID"), dtb)
        End If

        frmEntPedidosProveedoresEntregas = New frmEntPedidosProveedoresEntregas(DBO_PedidoProveedorEntrega, m_Pos)
        frmEntPedidosProveedoresEntregas.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frmEntPedidosProveedoresEntregas)
        RellenarDgvNivel1()
    End Sub

    Private Sub RellenarDgvNivel2()
        Dim spSelectDgvEntregas As String = "PedidosProveedoresEntregasSelectByDetalleIDDgv '" & dgvNivel1.CurrentRow.Cells("PedidoProveedorDetalleID").Value & "'"
        dtb.PrepararConsulta(spSelectDgvEntregas)
        bdsNivel2.DataSource = dtb.Consultar()
        bdnNivel2.BindingSource = bdsNivel2
        With dgvNivel2
            .DataSource = bdsNivel2
            .Columns("PedidoProveedorEntregaID").Visible = False
            .Columns("PedidoProveedorDetalleID").Visible = False
            .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 50, 1)
            .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 150, 2)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400, 3)
        End With
        HabilitarBotonesNivel2()
    End Sub

    Sub HabilitarBotonesNivel2()
        If Me.Text.Substring(0, 3) = "Ver" Then
            bdnNivel2.DeleteItem.Enabled = False
            bdnNivel2Edit.Enabled = False
            bdnNivel2.AddNewItem.Enabled = False
        Else
            If dgvNivel2.RowCount > 0 Then
                bdnNivel2Delete.Enabled = True
                bdnNivel2Edit.Enabled = True
                bdnNivel2.AddNewItem.Enabled = True
            Else
                bdnNivel2Delete.Enabled = False
                bdnNivel2Edit.Enabled = False
                bdnNivel2.AddNewItem.Enabled = True
            End If
        End If
    End Sub
#End Region


    Private Sub cboProveedores_SelectedValueChanged(sender As Object, e As EventArgs)
        Try
            Dim aviso As New Proveedores.AvisoPedido(cboProveedores.SelectedValue)
        Catch ex As Exception
        End Try
    End Sub

End Class
