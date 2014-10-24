Imports BasesParaCompatibilidad.DataGridViewExtension

Public Class frmInformePedidos
    Private dt As DataTable
    Private spInformePedidos As spInformePedidos
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spInformePedidos = New spInformePedidos
    End Sub

    Private Sub frmInformePedidos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load       
        Dim dtCli As DataTable
        Dim filCli As DataRow
        Dim NomCol As String
        dt = spInformePedidos.SelectInformePedidos(False, dtb)
        dtCli = spInformePedidos.SelectInformePedidos_ClienteEnFecha(dtb)

        'Crea las columnas correspondientes a los clientes con pedidos
        For Each filCli In dtCli.Rows
            NomCol = Convert.ToString(filCli.Item("Nombre")) & " (" & Convert.ToString(filCli.Item("FechaServicio")) & ")"

            If Not ExisteColumnaEnDatatable(NomCol) Then
                dt.Columns.Add(NomCol, System.Type.GetType("System.Int32"))
            End If

            'Inserta el pedido
            InsertaPedido_ClienteFecha(NomCol, (filCli.Item("TipoFormatoID")), (filCli.Item("Cantidad")))
        Next

        'Rellena con 0 los espacios vacios
        RellenaVacios()

        With dgvPedidos
            If Not dt Is Nothing Then
                If dt.Rows.Count = 0 Then
                    dt = Nothing
                    .DataSource = Nothing
                    'messagebox.show("Sin Resultados", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    butReport.Enabled = False
                    Return
                Else
                    .DataSource = dt
                    .Columns("TipoFormatoID").Visible = False
                    .Columns("CodigoQS").Visible = False
                    .Columns("Transito").Visible = False
                    .Columns("StockJR").Visible = False
                    .Columns("PedidosJR").Visible = False
                    .Columns("TotalJR").Visible = False
                    .Columns("StockLA").Visible = False
                    .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, 460)
                    .FormatoColumna("Palets", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                    .FormatoColumna("Pico", BasesParaCompatibilidad.TiposColumna.Miles, 46)
                    .FormatoColumna("Existen", BasesParaCompatibilidad.TiposColumna.Miles)

                    For Each filCli In dtCli.Rows
                        NomCol = Convert.ToString(filCli.Item("Nombre")) & " (" & Convert.ToString(filCli.Item("FechaServicio")) & ")"
                        .FormatoColumna(NomCol, BasesParaCompatibilidad.TiposColumna.Miles, 70)
                    Next

                    .FormatoGeneral()
                    butReport.Enabled = True
                    chbMostrar0.Enabled = False
                End If
            End If
        End With
        'calcula el ancho del formulario a partir del ancho de las columnas añadidas, un fijo para la descripcion y el ancho de las columnas fijas
        Me.Width = (dtCli.Rows.Count * 30 + 494 + 8 * 40)
        'elimina las filas que no tienen pedidos
        Dim row As DataRow
        Dim cont As Integer
        Dim vacio As Boolean
        Dim columnas As Integer = Me.dt.Columns.Count

        For Each row In Me.dt.Rows
            cont = 11
            vacio = True

            While cont < columnas
                If Convert.ToString(row.Item(cont)) <> "0" Then
                    vacio = False
                    cont = columnas
                End If
                cont = cont + 1
            End While

            If vacio Then
                row.Delete()
            End If
        Next

        ColorearInforme()
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Function ExisteColumnaEnDatatable(ByVal NombreColumna As String) As Boolean
        Dim res As Boolean = False
        If Not dt Is Nothing Then
            Dim i As Integer = 0
            While i < dt.Columns.Count
                If dt.Columns(i).Caption = NombreColumna Then
                    res = True
                End If
                i = i + 1
            End While
        End If
        Return res
    End Function

    Private Sub InsertaPedido_ClienteFecha(ByVal NombreColumna As String, ByVal TipoFormatoID As Integer, ByVal Cantidad As Integer)
        Dim fildt As DataRow
        For Each fildt In dt.Rows
            If Convert.ToString(fildt.Item(0)) = TipoFormatoID Then
                If fildt.Item(NombreColumna) Is Convert.DBNull Then
                    fildt.Item(NombreColumna) = Cantidad
                Else
                    fildt.Item(NombreColumna) = (fildt.Item(NombreColumna)) + Cantidad
                End If
            End If
        Next
    End Sub

    Private Sub RellenaVacios()
        Dim i, j As Integer
        i = 0
        j = 0

        While i < dt.Rows.Count
            While j < dt.Columns.Count

                If dt.Rows(i).Item(j) Is Convert.DBNull Then
                    dt.Rows(i).Item(j) = 0
                End If

                j = j + 1
            End While
            j = 0
            i = i + 1
        End While
    End Sub

    Private Sub ColorearInforme()
        Dim i, j, tot As Integer
        i = j = tot = 0

        With dgvPedidos
            While i < .Rows.Count
                tot = .Rows(i).Cells("Existen").Value
                j = 0
                While j < .Columns.Count
                    Select Case .Columns(j).Name
                        Case "TipoFormatoID", "CodigoQS", "Descripcion", "Existen", "Transito", "PedidosJR", "StockJR", "TotalJR", "StockLA", "Palets", "Pico"
                        Case Else
                            If tot >= .Rows(i).Cells(j).Value Then
                                If .Rows(i).Cells(j).Value <> 0 Then
                                    .Rows(i).Cells(j).Style.BackColor = Color.GreenYellow
                                Else
                                    .Rows(i).Cells(j).Style.BackColor = Color.Gainsboro
                                End If
                            Else
                                If .Rows(i).Cells(j).Value <> 0 Then
                                    .Rows(i).Cells(j).Style.BackColor = Color.Red
                                    .Rows(i).Cells(j).Style.ForeColor = Color.White
                                Else
                                    .Rows(i).Cells(j).Style.BackColor = Color.Gainsboro
                                End If
                            End If
                            tot = tot - .Rows(i).Cells(j).Value
                    End Select
                    j = j + 1
                End While
                i = i + 1
            End While
        End With
    End Sub

    'Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    dt = Nothing

    '    Dim i As Integer = 0
    '    While i < dgvAlbaranes.SelectedRows.Count
    '        spInformePedidos.InsertInformePedidos_TablaTemporal(Convert.ToInt32(dgvAlbaranes.SelectedRows(i).Cells("AlbaranCargaMaestroID").Value))
    '        i += 1
    '    End While

    '    dt = spInformePedidos.SelectInformePedidos(chbMostrar0.Checked)

    '    Dim dtCli As DataTable
    '    Dim filCli As DataRow
    '    Dim NomCol As String

    '    dtCli = spInformePedidos.SelectInformePedidos_ClienteEnFecha()

    '    'Crea las columnas correspondientes a los clientes con pedidos
    '    For Each filCli In dtCli.Rows
    '        NomCol = convert.tostring(filCli.Item("Nombre")) & " (" & convert.tostring(filCli.Item("FechaServicio")) & ")"
    '        If Not ExisteColumnaEnDatatable(NomCol) Then
    '            dt.Columns.Add(NomCol, System.Type.GetType("System.Int32"))
    '        End If

    '        'Inserta el pedido
    '        InsertaPedido_ClienteFecha(NomCol, Convert.ToInt32(filCli.Item("TipoFormatoID")), Convert.ToInt32(filCli.Item("Cantidad")))
    '    Next

    '    'Rellena con 0 los espacios vacios
    '    RellenaVacios()

    '    With dgvPedidos
    '        .DataSource = dt
    '        If .Rows.Count = 0 Then
    '            dt = Nothing
    '            .DataSource = Nothing
    '            messagebox.show("Sin Resultados", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '            butReport.Enabled = False
    '        Else
    '            .Columns("TipoFormatoID").Visible = False
    '            .Columns("CodigoQS").Visible = False

    '            '.FormatoColumna("CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, 70)
    '            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, 300)
    '            .FormatoColumna("Palets", BasesParaCompatibilidad.TiposColumna.Miles, 50)
    '            .FormatoColumna("Pico", BasesParaCompatibilidad.TiposColumna.Miles, 46)
    '            .FormatoColumna("Transito", BasesParaCompatibilidad.TiposColumna.Miles)
    '            .FormatoColumna("Existen", BasesParaCompatibilidad.TiposColumna.Miles)
    '            .FormatoColumna("Transito", BasesParaCompatibilidad.TiposColumna.Miles)
    '            .FormatoColumna("StockJR", BasesParaCompatibilidad.TiposColumna.Miles)
    '            .FormatoColumna("PedidosJR", BasesParaCompatibilidad.TiposColumna.Miles, 70)
    '            .FormatoColumna("TotalJR", BasesParaCompatibilidad.TiposColumna.Miles)
    '            .FormatoColumna("StockLA", BasesParaCompatibilidad.TiposColumna.Miles)

    '            For Each filCli In dtCli.Rows
    '                NomCol = convert.tostring(filCli.Item("Nombre")) & " (" & convert.tostring(filCli.Item("FechaServicio")) & ")"
    '                .FormatoColumna(NomCol, BasesParaCompatibilidad.TiposColumna.Miles, 70)
    '            Next

    '            .FormatoGeneral()
    '            butReport.Enabled = True
    '            chbMostrar0.Enabled = False
    '        End If
    '    End With

    '    ColorearInforme()
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub

    'Private Sub butReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butReport.Click
    '    Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
    '    If dt.Rows.Count = 0 Then
    '        messagebox.show("Sin Resultados", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
    '    Else
    '        Dim oExcel As Excel.Application
    '        Dim oBook As Excel.Workbook
    '        Dim oSheet As Excel.Worksheet
    '        oExcel = CreateObject("Excel.Application")
    '        oExcel.Visible = True
    '        oBook = oExcel.Workbooks.Add
    '        oSheet = oBook.Worksheets(1)

    '        oSheet.Range("B4").Value = "FECHA"
    '        oSheet.Range("B4").Font.Bold = True
    '        oSheet.Range("B5").Value = "HORA"
    '        oSheet.Range("B5").Font.Bold = True
    '        oSheet.Range("C4").Value = Format(Today, "dd/MM/yyyy")
    '        oSheet.Range("C4").Font.Bold = True
    '        oSheet.Range("C5").Value = Format(Now, "HH:mm:ss")
    '        oSheet.Range("C5").Font.Bold = True

    '        'Header
    '        Dim DataArrayHead(0, 0 To dt.Columns.Count - 2) As Object
    '        For s As Integer = 0 To dt.Columns.Count - 2
    '            DataArrayHead(0, s) = dt.Columns(s + 1).Caption
    '        Next

    '        oSheet.Range("B7").Resize(1, dt.Columns.Count - 1).Value = DataArrayHead
    '        oSheet.Range("B7").Resize(1, dt.Columns.Count - 1).Font.Bold = True

    '        'Detail
    '        Dim DataArray(0 To dt.Rows.Count - 1, 0 To dt.Columns.Count - 2) As Object
    '        For r As Integer = 0 To dt.Rows.Count - 1
    '            For s As Integer = 0 To dt.Columns.Count - 2
    '                If s = 0 Then 'CodigoQS
    '                    DataArray(r, s) = "'" & dt.Rows.Item(r).Item(s + 1)
    '                Else
    '                    DataArray(r, s) = dt.Rows.Item(r).Item(s + 1)
    '                End If
    '            Next
    '        Next

    '        oSheet.Range("B8").Resize(dt.Rows.Count, dt.Columns.Count - 1).Value = DataArray
    '        'oSheet.Range("B" & 8 + dt.Rows.Count).Resize(dt.Rows.Count, dt.Columns.Count-1).Font.Bold = True

    '        'Resize Columns
    '        oSheet.Columns("B:B").ColumnWidth = 13
    '        oSheet.Columns("C:C").ColumnWidth = 50

    '        'All done. Close this form.
    '        oExcel.Visible = True

    '        FechaSeleccionada = Now.Year & ".0" & _
    '                            convert.tostring(Now.Month) & "." & _
    '                            convert.tostring(Now.Day) & " " & _
    '                            convert.tostring(Now.Hour) & "-" & _
    '                            convert.tostring(Now.Minute)

    '        'Guarda el archivo en el disco
    '        Dim RutaCompleta As String
    '        Dim Unidad As String
    '        Dim NombreHoja As String

    '        If ServidorUsado = "MAM1\SQLEXPRESS") Or (ServidorUsado = "W7U\SQLEXPRESS2005" Then
    '            Unidad = "C:\"
    '        Else
    '            Unidad = "Z:\"
    '        End If

    '        Dim Ruta As String = "Comercial\Informes pedidos\"
    '        RutaCompleta = Unidad & Ruta
    '        NombreHoja = RutaCompleta & FechaSeleccionada & " Informe pedidos.xls"

    '        oSheet.SaveAs(NombreHoja)

    '        oExcel = Nothing
    '        oSheet = Nothing

    '    End If
    '    Me.Cursor = System.Windows.Forms.Cursors.Default
    'End Sub

    'Private Sub butLimpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLimpiar.Click
    '    Me.dgvAlbaranes.ClearSelection()
    '    Me.dgvPedidos.DataSource = Nothing
    '    Me.butReport.Enabled = False
    '    Me.chbMostrar0.Enabled = True
    'End Sub

    'Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
    '    Me.Close()
    'End Sub
End Class