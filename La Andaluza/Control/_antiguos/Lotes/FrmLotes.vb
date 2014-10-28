Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class FrmLotesEnologicos
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlMue As New ctlLotes
    Private spTiposLotes As New spTiposLotes
    Private spTiposProductos As spTiposProductos
    Private label2 As ToolStripItem
    Private refresh100 As ToolStripItem
    Private tsdepositos As ToolStripItem
    Private top100 As Boolean
    Private tipolote As Integer
    Private tipoproduto As Integer
    Private conenologico As Boolean

    Public Sub New()

        MyBase.New()
        InitializeComponent()

        LastEntry = False
        top100 = True
        spTiposLotes = New spTiposLotes
        spTiposProductos = New spTiposProductos

        label2 = Me.bdnGeneral.Items.Add("Tipo Lote:")
        label2.Text = "Tipo Lote:"
        label2.DisplayStyle = ToolStripItemDisplayStyle.Text
        label2.Enabled = False
        Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.cboTipoLoteID))

        label2 = Me.bdnGeneral.Items.Add("Tipo Producto:")
        label2.Text = "Tipo Producto:"
        label2.DisplayStyle = ToolStripItemDisplayStyle.Text
        label2.Enabled = False
        Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.cboTipoProducto))

        Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.chbConEnologicos))

        refresh100 = Me.bdnGeneral.Items.Add("Mostrar los ultimos 100 registros")
        refresh100.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        refresh100.Text = "Mostrar los ultimos 100 registros"
        refresh100.TextDirection = ToolStripTextDirection.Horizontal
        refresh100.TextAlign = ContentAlignment.MiddleRight
        refresh100.Image = My.Resources.view_refresh_4
        AddHandler refresh100.Click, AddressOf toolStripRefresh100_Click
        toolStripRefresh100_Click(Nothing, Nothing)

        If Config.UserType = 9 Or Config.UserType = 4 Then
            tsdepositos = Me.bdnGeneral.Items.Add("Cambiar deposito")
            tsdepositos.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            tsdepositos.Text = "Cambiar deposito"
            tsdepositos.TextDirection = ToolStripTextDirection.Horizontal
            tsdepositos.TextAlign = ContentAlignment.MiddleRight
            tsdepositos.Image = My.Resources.edit_table_cell
            AddHandler tsdepositos.Click, AddressOf AsignarDesposito
        End If
    End Sub

    Private Sub FrmLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        spTiposLotes.cargar_TiposLotes(CType(cboTipoLoteID, ComboBox), dtb, "Todos")
        cboTipoLoteID.MaxDropDownItems = cboTipoLoteID.Items.Count

        spTiposProductos.cargar_ComboBox_No_enologicos(CType(cboTipoProducto, ComboBox), dtb, "Todos")
        GeneralBindingSource.Position = GeneralBindingSource.Count
    End Sub

    Protected Overrides Sub cargar_datos()
        dataSource = ctlMue.mostrarTodosLotesPorTipoLoteoProducto(dtb, Me.tipolote, Me.tipoproduto, Me.conenologico, top100)
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral

                .DataSource = GeneralBindingSource
                .Columns("LoteID").Visible = False
                .Columns("CantidadID").Visible = False

                .FormatoColumna("referencia", "Ref.", BasesParaCompatibilidad.TiposColumna.Miles, 62, 1)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90, 2)
                .FormatoColumna("CodigoLote", BasesParaCompatibilidad.TiposColumna.Izquierda, 130, 3)
                .FormatoColumna("DepositoID", "Depo.", BasesParaCompatibilidad.TiposColumna.Derecha, 46, 4)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 5, 300)
                .FormatoColumna("CantidadRestante", "Restante", BasesParaCompatibilidad.TiposColumna.Miles, 65, 7)
                .FormatoColumna("Observacion", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 8, 320)
            End With
        End If

        'dgvGeneral.MoveLast()
        'dgvGeneral.FormatoGeneral()
        'BindingNavigatorActualizar(dgvGeneral.RowCount)

        'Try
        '    Me.dgvGeneral.Rows(1).Selected = True
        'Catch ex As Exception
        'End Try
    End Sub


#Region "Sobrecargas BindingNavigator"
    Overrides Sub Insertar()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim FrmEnt As New FrmEntLotes
        FrmEnt.Text = "Insertar Lote"
        FrmEnt.CargarDatos(0, 0, 0, 0, False)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Dim TipLot As Integer = cboTipoLoteID.SelectedValue

        'If MessageBox.Show("¿Recargar la tabla?", "Refrescar", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
        ' If MessageBox.Show("¿Recargar la tabla?", "Refrescar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
        toolStripRefresh100_Click(Nothing, Nothing)
        ' End If

        'GeneralBindingSource.DataSource = dtsMue
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Dim Posicion As Integer = Me.dgvGeneral.CurrentRow.Index
        If Posicion >= 0 Then
            Dim Frm As New FrmEntLotes
            Frm.Text = "Modificar Lote"

            Frm.CargarDatos(Posicion, _
                           Convert.ToInt32(Me.dgvGeneral.CurrentRow.Cells(0).Value), _
                           Convert.ToInt32(cboTipoLoteID.SelectedValue), _
                           Convert.ToInt32(cboTipoProducto.SelectedValue), _
                           chbConEnologicos.Checked)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

            'If MessageBox.Show("¿Recargar la tabla?", "Refrescar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            toolStripRefresh100_Click(Nothing, Nothing)
            'End If

            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New FrmEntLotes
            FrmEnt.Text = "Ver Lote"
            FrmEnt.CargarDatos(Posicion, dgvGeneral.Rows(Posicion).Cells(0).Value, cboTipoLoteID.SelectedValue, cboTipoProducto.SelectedValue, chbConEnologicos.Checked)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" ¿Realmente desea eliminar este registro? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then

                'eliminar muestra
                ctlMue.EliminarLote(dgvGeneral.Rows(Posicion).Cells(0).Value, dtb)
                toolStripRefresh100_Click(Nothing, Nothing)
                'ctlMue.mostrarTodosLotesPorTipoLoteoProducto((cboTipoLoteID.SelectedValue), (cboTipoProducto.SelectedValue), dtsMue, chbConEnologicos.Checked, True)

                'GeneralBindingSource.DataSource = dtsMue
                If Posicion >= 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region

    Private Sub TipoLoteIDComboMAM_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoLoteID.SelectedValueChanged, cboTipoProducto.SelectedValueChanged
        Try

            'Dim TipLot As Integer = Convert.ToInt32(cboTipoLoteID.SelectedValue)
            'ctlMue.mostrarTodosLotesPorTipoLoteoProducto(Convert.ToInt32(cboTipoLoteID.SelectedValue), Convert.ToInt32(cboTipoProducto.SelectedValue), dtsMue, chbConEnologicos.Checked)
            toolStripRefresh100_Click(Nothing, Nothing)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbConEnologicos.CheckedChanged
        If chbConEnologicos.Checked Then
            spTiposProductos.cargar_ComboBox_Enologicos(CType(cboTipoProducto, ComboBox), dtb, "Todos")
            'Oldlib.RellenarComboBox(cboTipoProducto, ctlTipPro.devolverTiposProductosPorDescripcionEnologicos, True, "Todos")
        Else
            spTiposProductos.cargar_ComboBox_No_enologicos(CType(cboTipoProducto, ComboBox), dtb, "Todos")
            'Oldlib.RellenarComboBox(cboTipoProducto, ctlTipPro.devolverTiposProductosPorDescripcionNoEnologicos, True, "Todos")
        End If

    End Sub

    Private Sub toolStripRefresh100_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.conenologico = chbConEnologicos.Checked
            Me.tipolote = If(cboTipoLoteID.SelectedValue Is Nothing, 0, Convert.ToInt32(cboTipoLoteID.SelectedValue))
            Me.tipoproduto = If(cboTipoProducto.SelectedValue Is Nothing, 0, Convert.ToInt32(cboTipoProducto.SelectedValue))
        Catch ex As Exception
            Return
        End Try

        If Me.refresh100.Text = "Mostrar todos los registros" Then
            top100 = False
            dgvFill()
            Me.refresh100.Text = "Mostrar los ultimos 100 registros"
        Else
            top100 = True
            dgvFill()
            Me.refresh100.Text = "Mostrar todos los registros"
        End If
    End Sub

    Private Sub cboTipoProducto_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles cboTipoProducto.SelectedIndexChanged
        toolStripRefresh100_Click(Nothing, Nothing)
    End Sub

    Private Sub AsignarDesposito()

        If Not Me.dgvGeneral.CurrentRow.Cells("DepositoID").Value Is Nothing Then
            Dim frm As New frmCambiarDesposito(Me.dgvGeneral.CurrentRow.Cells("LoteID").Value, Me.dgvGeneral.CurrentRow.Cells("DepositoID").Value)
            If BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm) = Windows.Forms.DialogResult.OK Then
                toolStripRefresh100_Click(Nothing, Nothing)
            End If
        End If
    End Sub
End Class
