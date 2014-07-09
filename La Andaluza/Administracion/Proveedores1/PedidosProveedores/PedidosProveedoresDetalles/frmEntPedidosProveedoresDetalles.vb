Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntPedidosProveedoresDetalles
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private m_Pos As Integer

    Private DBO_PedidoProveedorDetalle As DBO_PedidosProveedoresDetalles
    Private DBO_PedidoProveedorEntrega As New DBO_PedidosProveedoresEntregas
    Private spPedidosProveedoresEntregas As spPedidosProveedoresEntregas
    Private spPedidosProveedoresDetalles As spPedidosProveedoresDetalles
    Private frmEnt As frmEntPedidosProveedoresEntregas
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal PedidoProveedorDetalle As DBO_PedidosProveedoresDetalles, ByVal Pos As Integer)
        InitializeComponent()
        DBO_PedidoProveedorDetalle = PedidoProveedorDetalle
        m_Pos = Pos
        spPedidosProveedoresEntregas = New spPedidosProveedoresEntregas
        spPedidosProveedoresDetalles = New spPedidosProveedoresDetalles
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Me.txtFechaServicio.activarFoco()
    End Sub

    Private Sub frmEntPedidosProveedoresDetalles_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(cboUnidades)

        cboArticulos.mam_DataSource("PedidosProveedoresArticulosSelectCbo", False)
        cboEstados.mam_DataSource("PedidosProveedoresEstadosSelectCbo", False)
        'cboUnidades.mam_DataSource("MedidasProductosSelectCbo", False)

        If Me.Text.Substring(0, 3) = "Ver" Then
            GeneralBindingSource.DataSource = dtb.Consultar("PedidosProveedoresDetallesSelectAll")
            GeneralBindingSource.Position = m_Pos
        End If

        SetValores()
        RellenarDgvNivel1()

        'Aqui oculto el boton Grabar para que la opcion ver no lo permita
        ModificarBindingNavigator()
    End Sub

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
        DBO_PedidoProveedorEntrega = spPedidosProveedoresEntregas.Select_Record(GeneralBindingSource(m_Pos).Item("PedidoProveedorDetalleID"))
        SetValores()
    End Sub

    Overrides Sub Guardar()
        If txtCantidadPedida.Text = "" Then
            MessageBox.Show("Introduce una cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtCantidadPedida.Focus()
        Else
            GetValores()
            If Me.Text.Substring(0, 3) = "Ins" Then
                spPedidosProveedoresDetalles.InsertPedidosProveedoresDetalles(DBO_PedidoProveedorDetalle)
            Else
                spPedidosProveedoresDetalles.UpdatePedidosProveedoresDetalles(DBO_PedidoProveedorDetalle)
            End If
            Me.Close()
        End If
    End Sub

    Public Overrides Sub SetValores()
        TotalEntregas()
        txtPedidoProveedorDetalleID.Text = DBO_PedidoProveedorDetalle.PedidoProveedorDetalleID
        txtPedidoProveedorMaestroID.Text = DBO_PedidoProveedorDetalle.PedidoProveedorMaestroID
        cboArticulos.SelectedValue = DBO_PedidoProveedorDetalle.ArticuloID
        txtCantidadPedida.Text = DBO_PedidoProveedorDetalle.Cantidad
        txtFechaServicio.Text = DBO_PedidoProveedorDetalle.FechaServicio
        txtObservaciones.Text = If(DBO_PedidoProveedorDetalle.Observaciones_IsDBNull = True, Nothing, DBO_PedidoProveedorDetalle.Observaciones)
        cboEstados.SelectedValue = DBO_PedidoProveedorDetalle.EstadoID
        cboUnidades.SelectedValue = DBO_PedidoProveedorDetalle.MedidaProductoID
        txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Text = DBO_PedidoProveedorDetalle.PedidosProveedoresMaestro_PedidoProveedorMaestroID
    End Sub

    Private Sub GetValores()
        DBO_PedidoProveedorDetalle.PedidoProveedorMaestroID = System.Convert.ToInt32(txtPedidoProveedorMaestroID.Text)
        DBO_PedidoProveedorDetalle.ArticuloID = cboArticulos.SelectedValue
        DBO_PedidoProveedorDetalle.Cantidad = System.Convert.ToDouble(txtCantidadPedida.Text)
        DBO_PedidoProveedorDetalle.FechaServicio = System.Convert.ToDateTime(txtFechaServicio.Text)
        DBO_PedidoProveedorDetalle.Observaciones = System.Convert.ToString(If(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        DBO_PedidoProveedorDetalle.Observaciones_IsDBNull = If(txtObservaciones.Text = "", True, False)
        DBO_PedidoProveedorDetalle.EstadoID = cboEstados.SelectedValue
        DBO_PedidoProveedorDetalle.MedidaProductoID = cboUnidades.SelectedValue
        'm_RegistroActual.PedidosProveedoresMaestro_PedidoProveedorMaestroID = System.Convert.ToInt32(txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Text)
        DBO_PedidoProveedorDetalle.PedidosProveedoresMaestro_PedidoProveedorMaestroID = 8
    End Sub

    Sub HabilitarBotonesNivel1()
        If Me.Text.Substring(0, 3) = "Ver" Then
            bdnNivel1.DeleteItem.Enabled = False
            bdnNivel1Modificar.Enabled = False
            bdnNivel1.AddNewItem.Enabled = True
        Else
            If dgvNivel1.RowCount > 0 Then
                bdnNivel1.DeleteItem.Enabled = True
                bdnNivel1Modificar.Enabled = True
                bdnNivel1.AddNewItem.Enabled = True
            Else
                bdnNivel1.DeleteItem.Enabled = False
                bdnNivel1Modificar.Enabled = False
                bdnNivel1.AddNewItem.Enabled = True
            End If
        End If
    End Sub

    Private Sub dgvDetalles_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvNivel1.CellDoubleClick
        ActionNivel1("Modificar")
    End Sub

    Private Sub bdnNivel1Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Add.Click
        ActionNivel1("Insertar")
        bdsNivel1.MoveLast()
    End Sub

    Private Sub bdnNivel1Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Modificar.Click
        ActionNivel1("Modificar")
    End Sub

    Private Sub bdnNivel1Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bdnNivel1Delete.Click
        If MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then spPedidosProveedoresEntregas.DeletePedidosProveedoresEntregas(dgvNivel1.CurrentRow.Cells("PedidoProveedorEntregaID").Value)
        RellenarDgvNivel1()

        'Dim spSelectDgvNivel1 As String = "PedidosProveedoresDetallesSelectByMaestroIDDgv '" & DBO_PedidoProveedorDetalle.PedidoProveedorMaestroID & "'"
        'bdsNivel1. dataSource = dtb.Consultar(spSelectDgvNivel1)
    End Sub

    Private Sub ActionNivel1(ByVal TipoAction As String)
        Dim m_Pos As Integer = bdsNivel1.Position
        If TipoAction = "Insertar" Then
            DBO_PedidoProveedorEntrega.PedidoProveedorDetalleID = DBO_PedidoProveedorDetalle.PedidoProveedorDetalleID
        Else
            DBO_PedidoProveedorEntrega = spPedidosProveedoresEntregas.Select_Record(bdsNivel1(m_Pos).Item("PedidoProveedorEntregaID"))
        End If

        frmEnt = New frmEntPedidosProveedoresEntregas(DBO_PedidoProveedorEntrega, m_Pos)
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        frmEnt.ShowDialog()
        RellenarDgvNivel1()
    End Sub

    Private Sub RellenarDgvNivel1()
        Dim spSelectDgv As String = "PedidosProveedoresEntregasSelectByDetalleIDDgv '" & DBO_PedidoProveedorDetalle.PedidoProveedorDetalleID & "'"
        bdsNivel1.DataSource = dtb.Consultar(spSelectDgv)
        bdnNivel1.BindingSource = bdsNivel1
        With dgvNivel1
            .DataSource = bdsNivel1
            .Columns("PedidoProveedorEntregaID").Visible = False
            .Columns("PedidoProveedorDetalleID").Visible = False
            .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 50, 1)
            .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 150, 2)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 400, 3)
        End With
        HabilitarBotonesNivel1()
        TotalEntregas()
    End Sub

    Private Sub TotalEntregas()
        'Recalcular la cantidad recibida
        Dim TotalEntregas As Double = 0
        For Each row As DataGridViewRow In dgvNivel1.Rows
            TotalEntregas += (row.Cells("Cantidad").Value)
        Next
        txtCantidadServida.Text = TotalEntregas
        Me.txtCAntidadRetante.Text = If(txtCantidadPedida.Text = "", 0, System.Convert.ToDouble(txtCantidadPedida.Text)) - If(txtCantidadServida.Text = "", 0, System.Convert.ToDouble(txtCantidadServida.Text))

        If txtCantidadPedida.Text <> "" Then
            If System.Convert.ToDouble(txtCantidadPedida.Text) > 0 Then
                If System.Convert.ToDouble(txtCantidadServida.Text) >= System.Convert.ToDouble(txtCantidadPedida.Text) Then
                    'messagebox.show("Servido")
                    cboEstados.SelectedValue = 5
                    'SetValores()
                End If
            End If
        End If
    End Sub

    Private Sub cboArticulos_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboArticulos.SelectedIndexChanged
        Try
            Me.lArticulosObservaciones.Text = Me.cboArticulos.SelectedItem(2)
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnAddUnidad_Click(sender As Object, e As EventArgs) Handles btnAddUnidad.Click
        Dim frmEnt As New frmEntMedidasProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, New spMedidasProductos, New DBO_MedidasProductos)
        frmEnt.ShowDialog()
        Dim s As New spMedidasProductos
        s.cargar_MedidasProductos(Me.cboUnidades)
    End Sub
End Class
