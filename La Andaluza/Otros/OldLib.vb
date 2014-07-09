Public Class OldLib
    ' Las funciones de estsa clase se usan en modulos que van a ser reemplazados

    'Public Sub RellenarComboBox(ByVal Combo As ComboBox, ByVal tb As DataTable, ByVal PrimeraVacia As Boolean, Optional ByVal Texto As String = "")
    '    ' Crear nueva Tabla, Column y Row
    '    Dim table As DataTable = New DataTable
    '    Dim column As DataColumn
    '    Dim row As DataRow
    '    'ComprobarCambiosCombo = False

    '    ' crear nueva columna, poner el tipo de dato, poner nombre y añadir a la tabla
    '    column = New DataColumn()
    '    column.DataType = System.Type.GetType("System.Int32")
    '    column.ColumnName = "ID"
    '    table.Columns.Add(column)

    '    ' crear la 2da columna
    '    column = New DataColumn()
    '    column.DataType = System.Type.GetType("System.String")
    '    column.ColumnName = "Display"
    '    table.Columns.Add(column)

    '    If PrimeraVacia Then
    '        row = table.NewRow()
    '        row.Item(0) = 0
    '        If Texto = "" Then
    '            row.Item(1) = ""
    '        Else
    '            row.Item(1) = Texto
    '        End If
    '        table.Rows.Add(row)
    '        row = Nothing
    '    End If

    '    'recorrer la tabla que me vino de la bd y cargarla en la nueva
    '    Dim i As Integer = 0
    '    Try
    '        While i < tb.Rows.Count
    '            row = table.NewRow()
    '            row.Item(0) = tb.Rows(i).Item(0)
    '            row.Item(1) = tb.Rows(i).Item(1).ToString
    '            table.Rows.Add(row)
    '            row = Nothing
    '            i = i + 1
    '        End While

    '        Combo.DataSource = table
    '        Combo.ValueMember = "ID"
    '        Combo.DisplayMember = "Display"
    '        'ComprobarCambiosCombo = True
    '    Catch ex As Exception
    '        messagebox.show("Fallo al rellenar el ComboBox" & Environment.NewLine & Environment.NewLine & ex.Message)
    '    End Try
    'End Sub
    Public Function HacerTablasTodos(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "ID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Display"
        table.Columns.Add(column)

        row = table.NewRow()
        row.Item(0) = 0
        row.Item(1) = "Todos"
        table.Rows.Add(row)
        row = Nothing

        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        Dim i As Integer = 0
        Try
            While i < tb.Rows.Count
                row = table.NewRow()
                row.Item(0) = tb.Rows(i).Item(0)
                row.Item(1) = tb.Rows(i).Item(1)
                table.Rows.Add(row)
                row = Nothing
                i = i + 1
            End While
        Catch ex As Exception

        End Try

        'reemplazar la vieja con la nueva
        Return table
    End Function

    Public Function HacerTablasNoObligatorias(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "ID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Display"
        table.Columns.Add(column)

        row = table.NewRow()
        row.Item(0) = 0
        row.Item(1) = ""
        table.Rows.Add(row)
        row = Nothing

        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        Dim i As Integer = 0
        Try
            While i < tb.Rows.Count
                row = table.NewRow()
                row.Item(0) = tb.Rows(i).Item(0)
                row.Item(1) = tb.Rows(i).Item(1)
                table.Rows.Add(row)
                row = Nothing
                i = i + 1
            End While
        Catch ex As Exception

        End Try

        'reemplazar la vieja con la nueva
        Return table
    End Function

    Public Function HacerTablasObligatorias(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "ID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Display"
        table.Columns.Add(column)

        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        Dim i As Integer = 0
        Try
            While i < tb.Rows.Count
                row = table.NewRow()
                row.Item(0) = tb.Rows(i).Item(0)
                row.Item(1) = tb.Rows(i).Item(1).ToString
                table.Rows.Add(row)
                row = Nothing
                i = i + 1
            End While
        Catch ex As Exception

        End Try

        'reemplazar la vieja con la nueva
        Return table
    End Function

End Class

