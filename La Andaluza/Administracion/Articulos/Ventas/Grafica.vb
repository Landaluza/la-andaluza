

Public Class Grafica

    Public Sub graficaLineas(ByRef ows1 As Microsoft.Office.Interop.Excel.Worksheet, inicioRango As String, finRango As String, margenIzquierdo As Integer, margenArriba As Integer, ancho As Integer, alto As Integer, legendstart As Integer, legendend As Integer)
        Dim chartPage As Microsoft.Office.Interop.Excel.Chart
        Dim xlCharts As Microsoft.Office.Interop.Excel.ChartObjects
        Dim myChart As Microsoft.Office.Interop.Excel.ChartObject
        Dim chartRange As Microsoft.Office.Interop.Excel.Range

        xlCharts = ows1.ChartObjects
        myChart = xlCharts.Add(80, 830, 1150, 320)
        chartPage = myChart.Chart
        chartRange = ows1.Range(inicioRango, finRango)
        chartPage.SetSourceData(Source:=chartRange)
        chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlLine
        chartPage.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlBox


        Dim grp As Microsoft.Office.Interop.Excel.ChartGroup = chartPage.ChartGroups(1)
        grp.GapWidth = 20
        grp.VaryByCategories = True

        Dim s As Microsoft.Office.Interop.Excel.Series = grp.SeriesCollection(1)
        s.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlCylinder
        s.HasDataLabels = False

        chartPage.HasLegend = True
        chartPage.Legend.Position = Microsoft.Office.Interop.Excel.XlLegendPosition.xlLegendPositionRight

        'Dim xlAxisCategory As Excel.Axes
        'Dim xlAxisValue As Excel.Axes
        'xlAxisCategory = CType(chartPage.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
        'xlAxisCategory.Item(Excel.XlAxisType.xlCategory).HasTitle = True
        'xlAxisCategory.Item(Excel.XlAxisType.xlCategory).AxisTitle.Characters.Text = "Week Number"
        'xlAxisValue = CType(chartPage.Axes(, Excel.XlAxisGroup.xlPrimary), Excel.Axes)
        'xlAxisValue.Item(Excel.XlAxisType.xlValue).HasTitle = True
        'xlAxisValue.Item(Excel.XlAxisType.xlValue).AxisTitle.Characters.Text = "Percent"
        'xlAxisValue.Item(Excel.XlAxisType.xlValue).MaximumScale = 100
    End Sub

    Public Sub GraficaBarras(ByRef ows1 As Microsoft.Office.Interop.Excel.Worksheet, inicioRango As String, finRango As String, titulo As String, margenIzquierdo As Integer, margenArriba As Integer, ancho As Integer, alto As Integer)
        Dim chartPage As Microsoft.Office.Interop.Excel.Chart
        Dim xlCharts As Microsoft.Office.Interop.Excel.ChartObjects
        Dim myChart As Microsoft.Office.Interop.Excel.ChartObject
        Dim chartRange As Microsoft.Office.Interop.Excel.Range

        xlCharts = ows1.ChartObjects
        myChart = xlCharts.Add(margenIzquierdo, margenArriba, ancho, alto)

        chartPage = myChart.Chart
        chartRange = ows1.Range(inicioRango, finRango)
        chartPage.SetSourceData(source:=chartRange)

        chartPage.ChartType = Microsoft.Office.Interop.Excel.XlChartType.xlCylinderColClustered
        chartPage.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlCylinder
        chartPage.Rotation = 0
        chartPage.Elevation = 0
        chartPage.Perspective = 45
        chartPage.ChartArea.RoundedCorners = True
        chartPage.RightAngleAxes = False

        chartPage.HasLegend = False
        chartPage.HasTitle = True
        chartPage.ChartTitle.Text = titulo
        chartPage.ChartTitle.Position = Microsoft.Office.Interop.Excel.XlLegendPosition.xlLegendPositionBottom

        Dim grp As Microsoft.Office.Interop.Excel.ChartGroup = chartPage.ChartGroups(1)
        grp.GapWidth = 20
        grp.VaryByCategories = True


        Dim s As Microsoft.Office.Interop.Excel.Series = grp.SeriesCollection(1)
        s.BarShape = Microsoft.Office.Interop.Excel.XlBarShape.xlCylinder
        s.HasDataLabels = False

    End Sub
End Class
