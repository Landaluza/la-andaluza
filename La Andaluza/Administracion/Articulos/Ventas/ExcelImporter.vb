

Public Class ExcelImporter
    Private clsExcelToSQLData As New ExcelToSQLDataClass

 

    Public Function import(ByVal month As Integer, ByVal path As String, ByVal resultados As Integer) As Boolean
        clsExcelToSQLData.beginTransaction()
        'arreglar el rango de los meses
        '* toma como rango del mes la columna i hay que mandar la correspondiente al mes i=julio, j=agosto, etc
        Dim columna As Char = Chr(66 + month)

        If Not ConvertExcelToSQL(path, 1, "B8:B" & resultados, "C4", columna & "8:" & columna & resultados, month, "A8:A" & resultados) Then
            clsExcelToSQLData.cancelTransaction()
            Return False
        Else
            clsExcelToSQLData.endTransaction()
            Return True
        End If
    End Function

    Public Function ExportToExcel(ByVal Head As String, ByVal Grid As DataGridView, ByVal cabecera As String) As Boolean
        '''''
        Dim oApp As New Microsoft.Office.Interop.Excel.Application
        'Dim oWBa As Excel.Workbook = oApp.Workbooks.Open(Application.StartupPath & "\ExcelFile\Book1.xlsx")
        Dim oWBa As Microsoft.Office.Interop.Excel.Workbook = oApp.Workbooks.Open("Z:\La Andaluza app\ExcelFile\Book1.xlsx")
        'Dim oWBa As Excel.Workbook = oApp.Workbooks.Open("Z:\ExcelFile\Book1.xlsx")
        'Dim oWS As Excel.Worksheet = DirectCast(oWBa.Worksheets(2), Excel.Worksheet)
        Dim oWS1 As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(oWBa.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        '''''
        oApp.Visible = False
        Try
            Dim fc As New SaveFileDialog
            fc.InitialDirectory = "Z:\comercial\ventas por articulo"
            fc.FileName = cabecera
            If Grid.ColumnCount > 0 Then
                If fc.ShowDialog = DialogResult.OK Then
                    Dim DataArray(0 To Grid.RowCount - 1, 0 To Grid.ColumnCount - 1) As Object
                    For i As Integer = 0 To Grid.RowCount - 1
                        For j As Integer = 0 To Grid.ColumnCount - 1
                            DataArray(i, j) = Grid.Rows.Item(i).Cells.Item(j).Value
                        Next
                    Next

                    oWS1.Range("C7").Resize(Grid.RowCount, Grid.ColumnCount).Value = DataArray
                    oWS1.Range("C4").Value = cabecera
                    oWS1.Columns.AutoFit()

                    oWBa.SaveAs(fc.FileName)
                    oWBa.Close()
                    oApp.Quit()
                    oApp = New Microsoft.Office.Interop.Excel.Application
                    oApp.Visible = True
                    oWBa = oApp.Workbooks.Open(If(fc.FileName.ToString.EndsWith(".xlsx"), fc.FileName.ToString, fc.FileName & ".xlsx"))
                    Return True
                End If
            End If
            Return False
        Catch
            Return False
        End Try
    End Function
    Public Function ExportToExcelNew(ByVal Head As String, ByVal cabecera As String) As Boolean
        '''''
        Dim oApp As New Microsoft.Office.Interop.Excel.Application
        'Dim oWBa As Excel.Workbook = oApp.Workbooks.Open(Application.StartupPath & "\ExcelFile\Book1.xlsx")
        'Dim oWBa As Excel.Workbook = oApp.Workbooks.Open("Z:\La Andaluza app\ExcelFile\Book1.xlsx")
        Dim oWBa As Microsoft.Office.Interop.Excel.Workbook = oApp.Workbooks.Open(Config.RutaVentasLocal)
        'Dim oWBa As Excel.Workbook = oApp.Workbooks.Open("Z:\ExcelFile\Book1.xlsx")
        'Dim oWS As Excel.Worksheet = DirectCast(oWBa.Worksheets(2), Excel.Worksheet)
        Dim oWS1 As Microsoft.Office.Interop.Excel.Worksheet = DirectCast(oWBa.Worksheets(1), Microsoft.Office.Interop.Excel.Worksheet)
        '''''
        oApp.Visible = False
        Try
            Dim fc As New SaveFileDialog
            fc.InitialDirectory = "Z:\comercial\ventas por articulo"
            fc.FileName = cabecera
            Dim ex As New ExcelToSQLDataClass

            If fc.ShowDialog = DialogResult.OK Then
                Dim year As Integer = Date.Now.Year
                year = year.ToString.Substring(2, 2)
                Dim mesactual As Integer = Date.Now.Month
                Dim nombreMesActual As String = ex.VentasMesMaximo().Rows(0).Item(0)
                Dim grid As DataTable
                Dim grpCol As New Collection
                Dim grpMes As Integer = 0
                Dim tope As Integer
                Dim DataArray(0 To 15, 0 To year - 1) As Object
                Dim contY As Integer = 2006
                For j As Integer = 1 To year - 5

                    If j = year - 5 Then
                        tope = ex.VentasMesMaximo.Rows(0).Item(1)
                    Else
                        tope = 12
                    End If
                    DataArray(0, j) = contY
                    For i As Integer = 1 To tope
                        grid = ex.VentasByCodigoQSAñoMes(Head, contY, i)

                        Try
                            If Not IsDBNull(grid.Rows(0).Item(0)) Then
                                DataArray(i, j) = grid.Rows(0).Item(0)
                                grpCol.Add(grid.Rows(0).Item(0))
                            Else
                                DataArray(i, j) = 0
                                grpCol.Add(0)
                            End If
                        Catch ex1 As Exception
                            DataArray(i, j) = 0
                            grpCol.Add(0)
                        End Try

                        grpMes += 1
                    Next

                    Try
                        DataArray(13, j) = ex.VentasAcumuladasByCodigoQSAño(contY, Head).Rows(0).Item(0)
                    Catch ex2 As Exception
                        DataArray(13, j) = 0
                    End Try

                    Try
                        DataArray(14, j) = ex.VentasAcumuladasMesByCodigoQSAño(contY, Head).Rows(0).Item(0)
                    Catch ex3 As Exception
                        DataArray(14, j) = 0
                    End Try

                    contY += 1
                Next

                DataArray(1, 0) = "Enero"
                DataArray(2, 0) = "Febrero"
                DataArray(3, 0) = "Marzo"
                DataArray(4, 0) = "Abril"
                DataArray(5, 0) = "Mayo"
                DataArray(6, 0) = "Junio"
                DataArray(7, 0) = "Julio"
                DataArray(8, 0) = "Agosto"
                DataArray(9, 0) = "Septiembre"
                DataArray(10, 0) = "Octubre"
                DataArray(11, 0) = "Noviembre"
                DataArray(12, 0) = "Diciembre"
                DataArray(13, 0) = "TOTAL ACUMULADO"
                DataArray(14, 0) = "Total acumulado a " & nombreMesActual

                oWS1.Range("C7").Resize(15, year).Value = DataArray
                oWS1.Range("C4").Value = cabecera

                Dim grafica As New Grafica
                grafica.GraficaBarras(oWS1, "D20", Chr(68 + year - 6) & "20", "Total anual", 80, 460, 550, 320)
                grafica.GraficaBarras(oWS1, "D21", Chr(68 + year - 6) & "21", "Acumulado a " & nombreMesActual, 660, 460, 550, 320)
                grafica.graficaLineas(oWS1, "C7", Chr(68 + year - 6) & "19", 80, 830, 1150, 320, 2006, 2013)

                Dim chartPage As Microsoft.Office.Interop.Excel.Chart
                Dim xlCharts As Microsoft.Office.Interop.Excel.ChartObjects
                Dim myChart As Microsoft.Office.Interop.Excel.ChartObject
                Dim chartRange As Microsoft.Office.Interop.Excel.Range
                Dim s As Microsoft.Office.Interop.Excel.Series
                Dim grp As Microsoft.Office.Interop.Excel.ChartGroup



                Dim DataArray2(0 To grpMes - 1) As Object
                Dim cont As Integer = 0

                For Each aux As Integer In grpCol
                    DataArray2(cont) = aux

                    oWS1.Cells(50 + cont, 1).Value = aux
                    'oWS1.Cells(100, cont)
                    cont += 1

                Next

                'oWS1.Range("A50", "A" & (50 + grpMes)).Cells.Hidden = True
                'oWS1.Columns(1).Hidden = True

                xlCharts = oWS1.ChartObjects
                myChart = xlCharts.Add(80, 1200, 1150, 320)
                chartPage = myChart.Chart

                chartRange = oWS1.Range("A50", "A" & (50 + grpMes)) 'letra & "25")
                chartPage.SetSourceData(Source:=chartRange)
                chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlLine
                chartPage.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlBox



                grp = chartPage.ChartGroups(1)
                grp.GapWidth = 20
                grp.VaryByCategories = True


                s = grp.SeriesCollection(1)
                s.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlCylinder
                s.Trendlines.Add(Type:=-4132, Forward:=0, Backward:=0, DisplayEquation:=False, DisplayRSquared:=False)

                s.HasDataLabels = True
                s.ApplyDataLabels(Microsoft.Office.Interop.Excel.XlDataLabelsType.xlDataLabelsShowLabel)



                Dim ax As Microsoft.Office.Interop.Excel.Axis = chartPage.Axes(Microsoft.Office.Interop.Excel.XlAxisType.xlValue)
                Dim longitud As Integer = 12 * (year - 5)
                Dim DataArrayLabel(0 To longitud) As Object


                Dim contMeses As Integer = 1
                Dim contAgno As Integer = 2006
                Dim contpuntos As Integer = 0
                Dim valormaximo As Object
                'Dim swMax As Boolean
                ' Dim rangoMaximos As Microsoft.Office.Interop.Excel.Range = oWS1.Range("D22", Chr(68 + year - 6) & "22")
                valormaximo = oWS1.Range("D22").Value

                For Each o As Object In s.Points()
                    'no usar el valor, iterar por los meses y años para añadirlo al label
                    Dim p As Microsoft.Office.Interop.Excel.Point = o
                    o.datalabel.text = oWS1.Cells(50 + contpuntos, 1).Value


                    If contMeses = 12 Then
                        DataArrayLabel(contpuntos) = "Diciembre " & contAgno                        

                        contMeses = 0
                        contAgno += 1
                    Else
                        If contMeses = 1 Then
                            valormaximo = oWS1.Range(Chr(68 + (contAgno - 2000) - 6) & "22").Value
                        End If
                        DataArrayLabel(contpuntos) = ""
                    End If

                    
                    If valormaximo = oWS1.Cells(50 + contpuntos, 1).Value Then
                        o.datalabel.text = oWS1.Cells(50 + contpuntos, 1).Value                        
                    Else
                        o.datalabel.text = ""
                    End If

                 
                    'Select Case contMeses
                    '    Case 1
                    '        o.datalabel.text = "Enero " & contAgno
                    '    Case 2
                    '        o.datalabel.text = "Febrero " & contAgno
                    '    Case 3
                    '        o.datalabel.text = "Marzo " & contAgno
                    '    Case 4
                    '        o.datalabel.text = "Abril " & contAgno
                    '    Case 5
                    '        o.datalabel.text = "Mayo " & contAgno
                    '    Case 6
                    '        o.datalabel.text = "Junio " & contAgno
                    '    Case 7
                    '        o.datalabel.text = "Julio " & contAgno
                    '    Case 8
                    '        o.datalabel.text = "Agosto " & contAgno
                    '    Case 9
                    '        o.datalabel.text = "Septiembre " & contAgno
                    '    Case 10
                    '        o.datalabel.text = "Octubre " & contAgno
                    '    Case 11
                    '        o.datalabel.text = "Noviembre " & contAgno
                    '    Case 12
                    '        o.datalabel.text = "Diciembre " & contAgno
                    '        contMeses = 0
                    '        contAgno += 1
                    'End Select

                    contpuntos += 1
                    contMeses += 1
                Next

                ax.CategoryNames = DataArrayLabel




                'muestra etiquetas DENTRO del grafico
                's.ApplyDataLabels(Microsoft.Office.Interop.Excel.XlDataLabelsType.xlDataLabelsShowLabel, True, nombreDeSerieAMostrar)
                'PRUEBAS
                's.ApplyDataLabels()
                's.AxisGroup 
                '=SERIES(Hoja1!$B$1;{"ene"\"feb"\"mar"\"abr"\"may"\"jun"};Hoja1!$B$2:$B$7;1)
                '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                oWS1.Columns.AutoFit()

                oWBa.SaveAs(fc.FileName)
                oWBa.Close()
                oApp.Quit()
                oApp = New Microsoft.Office.Interop.Excel.Application
                oApp.Visible = True
                oWBa = oApp.Workbooks.Open(If(fc.FileName.ToString.EndsWith(".xlsx"), fc.FileName.ToString, fc.FileName & ".xlsx"))
                Return True
            End If

            Return False
        Catch ex As Exception
            Throw
        End Try
    End Function

    Private Function ConvertExcelToSQL(ByVal ExcelFilePath As String, ByVal WorkSheetIndex As Int32, ByVal CodigoQSRange As String, ByVal AñoRange As String, ByVal MesRange As String, Optional ByVal mes As Integer = Nothing, Optional ByVal CantidadCajasRange As String = "") As Boolean
        Dim oApp As New Microsoft.Office.Interop.Excel.Application
        Dim oWBa As Microsoft.Office.Interop.Excel.Workbook
        Dim oWS As Microsoft.Office.Interop.Excel.Worksheet

        Try
            '''''
            oWBa = oApp.Workbooks.Open(ExcelFilePath)
            oWS = DirectCast(oWBa.Worksheets(WorkSheetIndex), Microsoft.Office.Interop.Excel.Worksheet)
            '''''
            oApp.Visible = False
            '''''

            Dim oRngCodigoQS As Microsoft.Office.Interop.Excel.Range
            Dim oRngCantidadCajas As Microsoft.Office.Interop.Excel.Range

            Dim myArrayCajas As Object(,) = Nothing
            Dim myArrayCodigoQS As Object(,)


            oRngCodigoQS = oWS.Range(CodigoQSRange)
            myArrayCodigoQS = oRngCodigoQS.Value


            If CantidadCajasRange <> "" Then
                oRngCantidadCajas = oWS.Range(CantidadCajasRange)
                myArrayCajas = oRngCantidadCajas.Value
            End If
            '''''
            '''''Año - 2006
            '''''
            Dim oRngAño1 As Microsoft.Office.Interop.Excel.Range
            oRngAño1 = oWS.Range(AñoRange)
            '''''
            Dim oRngMes1 As Microsoft.Office.Interop.Excel.Range
            oRngMes1 = oWS.Range(MesRange)
            Dim myArrayMes1 As Object(,)
            myArrayMes1 = oRngMes1.Value
            '''''
            Dim mCodigoQS As Object = ""
            Dim mDescripcion As Object = ""
            Dim mCantidadCajas As Object = Nothing
            Dim mAño As Object
            Dim mMes As Object
            Dim mCajas As Object
            Dim separador, separador2 As Integer
            '''''
            For r2 As Integer = 1 To myArrayMes1.GetUpperBound(0)
                For c2 As Integer = 1 To myArrayMes1.GetUpperBound(1)
                    '''''
                    For c1 As Integer = 1 To myArrayCodigoQS.GetUpperBound(1)
                        If Not myArrayCodigoQS(r2, c1) Is Nothing Then
                            If Not myArrayCodigoQS(r2, c1).ToString.Contains("Total") Then
                                mCodigoQS = Mid(myArrayCodigoQS(r2, c1), 1, 9)

                                mDescripcion = Mid(myArrayCodigoQS(r2, c1), 10)
                                mMes = if(mes = Nothing, c2, mes) 'si no se le pasa el mes usa el contador como mes (solo valido para importar desde enero)
                                mAño = oRngAño1.Value
                                mCajas = if(myArrayMes1(r2, c2) = Nothing, 0, myArrayMes1(r2, c2))
                                '''''
                                If mCodigoQS.ToString.Trim.Length > 0 Then
                                    If mCodigoQS.ToString.Trim <> "Total" Then
                                        If CantidadCajasRange = "" Then
                                            InsertRecord(mCodigoQS, mAño, mMes, mCajas, "", mDescripcion)
                                        Else
                                            If myArrayCajas(r2, c1) Is Nothing Then
                                                If mCantidadCajas Is Nothing Then mCantidadCajas = 1
                                            Else
                                                separador = myArrayCajas(r2, c1).ToString.IndexOf("-")
                                                separador2 = myArrayCajas(r2, c1).ToString.IndexOf("/")
                                                If separador = -1 And separador2 = -1 Then
                                                    mCantidadCajas = 1
                                                Else
                                                    If separador < separador2 And separador > 0 Then
                                                        mCantidadCajas = Mid(myArrayCajas(r2, c1), 1, separador)
                                                    Else
                                                        mCantidadCajas = Mid(myArrayCajas(r2, c1), 1, separador2)
                                                    End If
                                                End If
                                            End If

                                            If Not InsertRecord(mCodigoQS, mAño, mMes, mCajas / mCantidadCajas, "", mDescripcion) Then
                                                Return False
                                                Exit Function
                                            End If
                                        End If

                                    End If
                                End If
                                '''''                        
                            End If
                        End If
                    Next c1
                    '''''
                Next c2
            Next r2

            Return True
        Catch ex As System.Exception
            messagebox.show(ex.Message)
            Return False
        Finally
            oApp.Quit()
            oWBa = Nothing
            oApp = Nothing
        End Try
    End Function

    Private Function InsertRecord(ByVal mCodigoQS As String, ByVal mAño As Int32, ByVal mMes As Int32, ByVal mCajas As Int32, ByVal mObservaciones As String, ByVal mDescripcion As String) As Boolean
        Try
            Dim clsExcelToSQL As New ExcelToSQLClass
            With clsExcelToSQL
                .CodigoQS = mCodigoQS
                .CodigoQS_IsDBNull = if(mCodigoQS = "", True, False)
                .Descripcion = mDescripcion
                .Año = mAño
                .Año_IsDBNull = if(mAño = 0, True, False)
                .Mes = mMes
                .Mes_IsDBNull = if(mMes = 0, True, False)
                .Cajas = mCajas
                .Cajas_IsDBNull = if(mCajas = 0, True, False)
                .Observaciones = mObservaciones
                .Observaciones_IsDBNull = if(mObservaciones = "", True, False)
            End With

            Return clsExcelToSQLData.Add(clsExcelToSQL)
        Catch ex As System.Exception
            messagebox.show(ex.Message)
            Return False
        End Try
    End Function

    Private Function DeleteRecords() As Boolean
        Try
            Dim clsExcelToSQLClass As New ExcelToSQLClass
            Return clsExcelToSQLData.Delete()
        Catch ex As System.Exception
            messagebox.show(ex.Message)
            Return False
        End Try
    End Function

    Public Function delete(ByVal month As Integer, ByVal year As Integer) As Boolean
        Try
            Dim clsExcelToSQLClass As New ExcelToSQLClass
            Return clsExcelToSQLData.Delete(month, year)
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class


