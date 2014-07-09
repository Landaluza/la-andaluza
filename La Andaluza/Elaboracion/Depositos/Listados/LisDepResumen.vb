Imports C1.C1Preview


Public Class LisDepResumen
    Private doc As C1PrintDocument
    Private ctlDep As ctlDepositos
    Private Tab As DataTable
    Private valor As Object
    Private Fila As Integer
    Private pl As PageLayout
    Private rt As RenderTable
    Private title As RenderParagraph
    Private frmEspera As BasesParaCompatibilidad.frmEspera

    Public Sub New()
        InitializeComponent()

        doc = New C1PrintDocument
        ctlDep = New ctlDepositos
        Tab = New DataTable
        Fila = 0
        pl = New PageLayout
        rt = New RenderTable
        title = New RenderParagraph

    End Sub
    Private Sub LisDepResumen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos")
        frmEspera.Show()
        BackgroundWorker1.RunWorkerAsync()

        

    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork

        Tab = ctlDep.devolverDepositosLotes()

        With pl
            .PageSettings = New C1PageSettings()
            .PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            .PageSettings.TopMargin = 10
            .PageSettings.BottomMargin = 10
            .PageSettings.LeftMargin = 10
            .PageSettings.RightMargin = 10
        End With

        doc.DefaultUnit = C1.C1Preview.UnitTypeEnum.Mm
        doc.PageLayouts.Default = pl

        ' create the title of the document
        title.Content.AddText("Existencias en depósitos al día " & DateTime.Now)
        'title.Content.AddText("PageLayouts", Color.Blue)
        title.Style.Font = New Font("Tahoma", 18, FontStyle.Bold)
        title.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
        title.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
        doc.Body.Children.Add(title)

        rt.Style.GridLines.All = LineDef.Default
        rt.CellStyle.Padding.Right = "1mm"
        rt.CellStyle.Padding.Left = "1mm"

        rt.Cols(0).Width = 10
        rt.Cols(1).Width = 16
        rt.Cols(2).Width = 25
        rt.Cols(3).Width = 70
        rt.Cols(4).Width = 16
        rt.Cols(5).Width = 14
        rt.Cols(6).Width = 14
        rt.Cols(7).Width = 16
        rt.Cols(8).Width = 16

        valor = rt.Rows.Item(Fila)
        rt.Cells(Fila, 0).Text = "Num"
        rt.Cells(Fila, 1).Text = "Capacidad"
        rt.Cells(Fila, 2).Text = "Contenido"
        rt.Cells(Fila, 3).Text = "Descripcion"
        rt.Cells(Fila, 4).Text = "Cantidad"
        rt.Cells(Fila, 5).Text = "Acidez"
        rt.Cells(Fila, 6).Text = "Alcohol"
        rt.Cells(Fila, 7).Text = "Densidad"
        rt.Cells(Fila, 8).Text = "Sulfuroso"
        rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Bold)
        rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
        rt.Rows(Fila).Style.BackColor = Color.LightGray
        Fila += 1
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Dim i As Integer = 0
        While i < Tab.Rows.Count
            If Tab.Rows(i).Item("Listado") Then
                valor = rt.Rows.Item(Fila)
                rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Regular)
                rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 1).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 2).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 3).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                rt.Cells(Fila, 4).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 5).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 6).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 7).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 8).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 0).Text = Convert.ToString(Tab.Rows(i).Item("Codigo"))
                rt.Cells(Fila, 1).Text = Format(Tab.Rows(i).Item("Capacidad"), "0,00")
                If Not Convert.IsDBNull(Tab.Rows(i).Item("CodigoLote")) Then rt.Cells(Fila, 2).Text = Convert.ToString(Tab.Rows(i).Item("CodigoLote"))
                If Not Convert.IsDBNull(Tab.Rows(i).Item("Descripcion")) Then rt.Cells(Fila, 3).Text = Convert.ToString(Tab.Rows(i).Item("Descripcion"))
                If Not Convert.IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then rt.Cells(Fila, 4).Text = Format(Tab.Rows(i).Item("CantidadRestante"), "#,##")
                If Not Convert.IsDBNull(Tab.Rows(i).Item("Acidez")) Then rt.Cells(Fila, 5).Text = Format(Tab.Rows(i).Item("Acidez"), "0.#0")
                If Not Convert.IsDBNull(Tab.Rows(i).Item("Alcohol")) Then rt.Cells(Fila, 6).Text = Format(Tab.Rows(i).Item("Alcohol"), "0.#0")
                If Not Convert.IsDBNull(Tab.Rows(i).Item("Densidad")) Then rt.Cells(Fila, 7).Text = Format(Tab.Rows(i).Item("Densidad"), "#.##0")
                If Not Convert.IsDBNull(Tab.Rows(i).Item("Sulfuroso")) Then rt.Cells(Fila, 8).Text = Format(Tab.Rows(i).Item("Sulfuroso"), "#,##0")
                Fila += 1
            End If
            i += 1

        End While

        doc.Body.Children.Add(New RenderEmpty("2mm"))
        doc.Body.Children.Add(rt)

        C1PrintPreviewControl1.Document = doc

        frmEspera.Close()
    End Sub
End Class

