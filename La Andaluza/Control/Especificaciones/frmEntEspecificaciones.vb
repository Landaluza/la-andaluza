Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmEntEspecificaciones
    Inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private ctlEsp As New ctlEspecificaciones
    Private spTiposLotes As New spTiposLotes
    Private spTiposProductos As New spTiposProductos
    Private ctlMetAna As New spMetodosAnalisis
    Private dtsEsp As New dtsEspecificaciones.EspecificacionesDataTable
    Private dtsValEsp As New dtsEspecificaciones.ValoresEspecificacionesDataTable
    Private grilla As New DataGridView

    Public Sub New()

        InitializeComponent()

        dtpFechaRevisado.activarFoco()
    End Sub
    Overrides Sub guardar()
        If checkValues() Then
            Dim i As Integer
            'While i < dgvEspecificaciones.RowCount
            '    dgvEspecificaciones.CurrentCell = dgvEspecificaciones.Rows(i).Cells(1)
            '    i = i + 1
            'End While
            'If dgvEspecificaciones.RowCount > 0 Then
            '    dgvEspecificaciones.CurrentCell = dgvEspecificaciones.Rows(0).Cells(1)
            'End If

            Try
                ctlEsp.GuardarEspecificacion(txtDescripcion.Text, txtCodigoQS.Text, dtpFechaRevisado.Value, cboTipoLote.SelectedValue, cboTipoProducto.SelectedValue, cboLegislacion.SelectedValue)
                i = 0
                While i < dgvEspecificaciones.RowCount
                    'ctlEsp.guardarValoresEspecificaciones(dgvEspecificaciones.Rows(i).Cells(0).Value, dgvEspecificaciones.Rows(i).Cells(2).Value, dgvEspecificaciones.Rows(i).Cells(3).Value, dgvEspecificaciones.Rows(i).Cells(4).Value, dgvEspecificaciones.Rows(i).Cells(5).Value, dgvEspecificaciones.Rows(i).Cells(7).Value, dgvEspecificaciones.Rows(i).Cells(8).Value, dgvEspecificaciones.Rows(i).Cells(9).Value)
                    ctlEsp.guardarValoresEspecificaciones(dgvEspecificaciones.Rows(i).Cells("ParametroID").Value, _
                                                         dgvEspecificaciones.Rows(i).Cells("Obligatoriedad").Value, _
                                                         dgvEspecificaciones.Rows(i).Cells("Minimo").Value, _
                                                         dgvEspecificaciones.Rows(i).Cells("Maximo").Value, _
                                                         dgvEspecificaciones.Rows(i).Cells("Periodicidad").Value, _
                                                         dgvEspecificaciones.Rows(i).Cells(7).Value, _
                                                         If(Convert.IsDBNull(dgvEspecificaciones.Rows(i).Cells("DesviacionMaxima").Value), Nothing, dgvEspecificaciones.Rows(i).Cells("DesviacionMaxima").Value), _
                                                         If(Convert.IsDBNull(dgvEspecificaciones.Rows(i).Cells("DesviacionMinima").Value), Nothing, dgvEspecificaciones.Rows(i).Cells("DesviacionMinima").Value))
                    i = i + 1
                End While
                dtsValEsp.AcceptChanges()
                Me.Close()
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
    Private Function checkValues() As Boolean
        Dim errores As String = ""

        If Me.txtDescripcion.Text = "" Then
            errores &= "El campo descripcion no puede estar vacio."
            Me.txtDescripcion.Focus()
        End If

        'If Me.cbo Then

        If errores = "" Then
            Return True
        Else
            MessageBox.Show("Se han encontrado los siguientes errores: " & Environment.NewLine() & errores, "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation) 'Complete correctamente el formulario")
            Return False
        End If
    End Function

    Private Sub AddComboBoxColumnsTablas()
        Dim comboboxColumn As New DataGridViewComboBoxColumn
        comboboxColumn.Items.Clear()
        comboboxColumn.Items.Add("")
        Dim tablaMet As New DataTable
        Dim table As New DataTable
        tablaMet = ctlMetAna.devolverMetodosAnalisis

        If dgvEspecificaciones.Columns.Contains("MetodosAnalisis") Then dgvEspecificaciones.Columns.Remove("MetodosAnalisis")

        ' Declare variables for DataColumn and DataRow objects
        Dim column As DataColumn, row As DataRow

        ' Create new DataColumn, set DataType, 
        ' ColumnName and add to DataTable
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "MetodoAnalisisID"
        table.Columns.Add(column)

        ' Create second column
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        table.Columns.Add(column)

        row = table.NewRow()
        row.Item(0) = 0
        row.Item(1) = ""
        table.Rows.Add(row)
        row = Nothing

        Dim i As Integer = 0
        While i < tablaMet.Rows.Count
            row = table.NewRow()
            row.Item(0) = tablaMet.Rows(i).Item(0)
            row.Item(1) = tablaMet.Rows(i).Item(1)
            table.Rows.Add(row)
            row = Nothing
            i = i + 1
        End While


        With comboboxColumn
            .HeaderText = "Metodo Analisis"
            .DropDownWidth = 150
            .Width = 90
            .MaxDropDownItems = 5
            .FlatStyle = FlatStyle.Flat
            .DataSource = table
            .Name = "MetodosAnalisis"
            .ValueMember = "MetodoAnalisisID"
            .DisplayMember = "Descripcion"

        End With

        dgvEspecificaciones.Columns.Insert(7, comboboxColumn)
        i = 0
        Dim j As Integer
        Dim aux As String
        While i < dgvEspecificaciones.RowCount
            aux = dgvEspecificaciones.Rows(i).Cells(8).Value
            j = 0
            While j < tablaMet.Rows.Count
                If aux = tablaMet.Rows(j).Item(1).ToString Then
                    dgvEspecificaciones.Rows(i).Cells(7).Value = tablaMet.Rows(j).Item(0)
                    j = tablaMet.Rows.Count
                End If
                j = j + 1
            End While
            i = i + 1
        End While
        dgvEspecificaciones.Columns.Remove("MetodosAnalisisID")
    End Sub

    Private Function HacerTablaTiposLotes(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "TipoLoteID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        table.Columns.Add(column)

        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        Dim i As Integer = 0
        While i < tb.Rows.Count
            row = table.NewRow()
            row.Item(0) = tb.Rows(i).Item(0)
            row.Item(1) = tb.Rows(i).Item(1)
            table.Rows.Add(row)
            row = Nothing
            i = i + 1
        End While
        'reemplazar la vieja con la nueva
        Return table

    End Function

    Private Function HacerTablaTiposProductos(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "TipoProductoID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Descripcion"
        table.Columns.Add(column)

        Dim i As Integer = 0
        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        While i < tb.Rows.Count
            row = table.NewRow()
            row.Item(0) = tb.Rows(i).Item(0)
            row.Item(1) = tb.Rows(i).Item(1)
            table.Rows.Add(row)
            row = Nothing
            i = i + 1
        End While
        'reemplazar la vieja con la nueva
        Return table

    End Function

    Private Sub dgvFill()


        dgvEspecificaciones.DataSource = dtsValEsp
        ctlEsp.mostrarTodosValoresEspecificaciones(dtsValEsp)

        'messageBox.show(ctlEsp.getEspecificacionID)

        dgvEspecificaciones.Columns(0).Visible = False
        dgvEspecificaciones.Columns(1).ReadOnly = True
        dgvEspecificaciones.FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 1, 80)
        dgvEspecificaciones.FormatoColumna("Maximo", BasesParaCompatibilidad.TiposColumna.Double2, 60)
        dgvEspecificaciones.FormatoColumna("Minimo", BasesParaCompatibilidad.TiposColumna.Double2, 60)
        dgvEspecificaciones.FormatoColumna("MaximoLegislacion", BasesParaCompatibilidad.TiposColumna.Double2, 60)
        dgvEspecificaciones.FormatoColumna("MinimoLegislacion", BasesParaCompatibilidad.TiposColumna.Double2, 60)
        dgvEspecificaciones.FormatoColumna("DesviacionMaxima", BasesParaCompatibilidad.TiposColumna.Descripcion, 60)
        dgvEspecificaciones.FormatoColumna("DesviacionMinima", BasesParaCompatibilidad.TiposColumna.Descripcion, 60)
        dgvEspecificaciones.Columns(6).ReadOnly = True
        dgvEspecificaciones.Columns("MaximoLegislacion").ReadOnly = True
        dgvEspecificaciones.Columns("MinimoLegislacion").ReadOnly = True
        dgvEspecificaciones.Columns("DesviacionMaxima").ReadOnly = False
        dgvEspecificaciones.Columns("DesviacionMinima").ReadOnly = False

        ModificarBindingNavigator()

        If Me.Text.Substring(0, 3) = "Ver" Then
            dgvEspecificaciones.Columns(2).ReadOnly = True
            dgvEspecificaciones.Columns(3).ReadOnly = True
            dgvEspecificaciones.Columns(4).ReadOnly = True
            dgvEspecificaciones.Columns(5).ReadOnly = True
            ctlEsp.mostrarTodasEspecificaciones(dtsEsp)
            GeneralBindingSource.DataSource = dtsEsp
            GeneralBindingSource.Position = Posicion
        Else
            AddComboBoxColumnsTablas()
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Public Sub CargarDatos(ByVal pos As Integer, ByVal gril As DataGridView, ByVal espID As Integer, _
                           ByVal qs As String, ByVal esp As String, ByVal fecha As Date, ByVal tipoLote As String, _
                           ByVal TipoProducto As String, Optional ByVal LegislacionID As Integer = Nothing)
        Posicion = pos
        txtCodigoQS.Text = qs
        txtDescripcion.Text = esp
        txtDescripcion.EsUnicoID = espID
        txtCodigoQS.EsUnicoID = espID
        dtpFechaRevisado.Value = fecha
        grilla = gril
        Dim spLotes As New spTiposLotes
        spLotes.cargar_TiposLotes(cboTipoLote)
        'cboTipoLote.DataSource = HacerTablaTiposLotes(ctlTipLot.devolverLotes())
        cboTipoLote.ValueMember = "TipoLoteID"
        cboTipoLote.DisplayMember = "Descripcion"
        cboTipoLote.Text = tipoLote
        Me.spTiposProductos.cargar_ComboBox(cboTipoProducto)
        'cboTipoProducto.DataSource = HacerTablaTiposProductos(ctlTipPro.DevolverTiposProductos())
        'cboTipoProducto.ValueMember = "TipoProductoID"
        'cboTipoProducto.DisplayMember = "Descripcion"
        'cboTipoProducto.Text = TipoProducto
        ctlEsp.setEspecificacionID(espID)

        If LegislacionID <> Nothing Then Me.ctlEsp.setLegislacion(LegislacionID)
    End Sub

    Private Sub lblEspecificacionID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEspecificacionID.TextChanged
        ctlEsp.setEspecificacionID(lblEspecificacionID.Text)
        dgvEspecificaciones.DataSource = dtsValEsp
        ctlEsp.mostrarTodosValoresEspecificaciones(dtsValEsp)
    End Sub


    'Private Sub dgvEspecificaciones_CellValueChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEspecificaciones.CellValueChanged

    '    If dgvEspecificaciones.Columns("Minimo").Index = e.ColumnIndex Or dgvEspecificaciones.Columns("Maximo").Index = e.ColumnIndex Then
    '        ' Valor actual de la celda 
    '        Dim value As String = dgvEspecificaciones.CurrentCell.EditedFormattedValue.ToString
    '        ' Reemplazamos el punto por la coma Double. 
    '        value = value.Replace(".", ",")
    '        ' Escribimos el nuevo valor. 
    '        Dim cellValue As Double = CType(value, Double)
    '        If dgvEspecificaciones.CurrentCell.Value <> cellValue Then
    '            dgvEspecificaciones.CurrentCell.Value = cellValue
    '        End If
    '    End If

    'End Sub


    Private Sub dgvEspecificaciones_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs)
        'messageBox.show("Solo introducir solo reales")
        'messageBox.show(e.Exception.Message)
    End Sub


    Private Sub dgvEspecificaciones_CellEndEdit(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvEspecificaciones.CellEndEdit
        If dgvEspecificaciones.Columns("Minimo").Index = e.ColumnIndex Or dgvEspecificaciones.Columns("Maximo").Index = e.ColumnIndex Then
            lError.Text = ""

            Dim value As String = dgvEspecificaciones.CurrentCell.EditedFormattedValue.ToString
            ' Reemplazamos el punto por la coma Double. 
            'value = value.Replace(",", ".")

            ' Escribimos el nuevo valor. 
            'Dim cellValue As Double = CType(value / 100, Double)
            'If dgv.CurrentCell.Value <> value Then
            dgvEspecificaciones.CurrentCell.Value = value
            'End If

            If Not Convert.IsDBNull(dgvEspecificaciones.CurrentRow.Cells("MinimoLegislacion").Value) Then
                If CDbl(dgvEspecificaciones.CurrentRow.Cells("Minimo").Value) < CDbl(dgvEspecificaciones.CurrentRow.Cells("MinimoLegislacion").Value) Then
                    dgvEspecificaciones.CurrentRow.Cells("Minimo").Style.BackColor = Color.Red
                    lError.Text = "El valor no puede exceder los margenes de la legislacion aplicada"
                Else
                    dgvEspecificaciones.CurrentRow.Cells("Minimo").Style.BackColor = dgvEspecificaciones.DefaultCellStyle.BackColor
                End If
            End If
            If Not Convert.IsDBNull(dgvEspecificaciones.CurrentRow.Cells("MaximoLegislacion").Value) Then
                If CDbl(dgvEspecificaciones.CurrentRow.Cells("Maximo").Value) > CDbl(dgvEspecificaciones.CurrentRow.Cells("MaximoLegislacion").Value) Then
                    dgvEspecificaciones.CurrentRow.Cells("Maximo").Style.BackColor = Color.Red
                    lError.Text = "El valor no puede exceder los margenes de la legislacion aplicada"
                Else
                    dgvEspecificaciones.CurrentRow.Cells("Maximo").Style.BackColor = dgvEspecificaciones.DefaultCellStyle.BackColor
                End If
            End If

            If (lError.Text <> "") Then
                BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Panel3, Panel1)
                BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(lError, Panel3)
                Panel3.Visible = True
                lError.Visible = True
                Me.Timer1.Enabled = True
                Me.Timer1.Start()
            End If
        End If
    End Sub

    Private Sub frmEntEspecificaciones_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Panel2, Panel1)
    End Sub

    Private Sub cboLegislacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboLegislacion.SelectedValueChanged
        Try
            Me.ctlEsp.setLegislacion(Me.cboLegislacion.SelectedValue)
            dgvFill()
        Catch ex As Exception
        Finally
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub frmEntEspecificaciones_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim aux As New spEspecificacionLegal
        Dim legislacion As Integer = ctlEsp.getLegislacion
        aux.cargar_ComboBox(Me.cboLegislacion)
        If legislacion <> Nothing Then cboLegislacion.SelectedValue = legislacion
        'dgvFill()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Me.lError.Text <> "" Then
            Me.Timer1.Stop()
            Me.Timer1.Enabled = False
            Me.lError.Text = ""
            Me.lError.Visible = False
            Me.Panel3.Visible = False
        End If
    End Sub
End Class