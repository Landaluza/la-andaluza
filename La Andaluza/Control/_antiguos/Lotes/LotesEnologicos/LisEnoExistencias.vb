Imports C1.C1Preview



Public Class LisEnoExistencias
    Private Sub LisEnoExistencias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim doc As New C1PrintDocument()
        Dim valor As Object
        Dim Fila As Integer = 0
        Dim pl As New PageLayout()
        Dim title As New RenderParagraph()
        Dim ExisteProducto As Boolean
        Dim ContadorProductos As Integer = 0

        'Dim ctlTipPro As New ctlTiposProductos
        Dim spProd As New spTiposProductos
        Dim TabTipPro As New DataTable
        TabTipPro = spProd.devolver_TiposProductos 'ctlTipPro.DevolverTiposProductos

        Dim ctlLot As New ctlLotes
        Dim Tab As New DataTable
        Tab = ctlLot.devolverLotesEnologicos

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
        title.Content.AddText("Existencias materiales enológicos al día " & Today.Date)
        title.Content.AddText("Pagina: [PageNo] de [PageCount]")

        'title.Content.AddText("PageLayouts", Color.Blue)
        title.Style.Font = New Font("Tahoma", 18, FontStyle.Bold)
        title.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
        title.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
        doc.Body.Children.Add(title)

        While ContadorProductos < TabTipPro.Rows.Count
            Dim rt As New RenderTable()
            Dim TotalCantidad As Double = 0

            rt.Style.GridLines.All = LineDef.Default
            rt.CellStyle.Padding.Right = "1mm"
            rt.CellStyle.Padding.Left = "1mm"

            rt.Cols(0).Width = 20
            rt.Cols(1).Width = 50
            rt.Cols(2).Width = 70
            rt.Cols(3).Width = 20

            valor = rt.Rows.Item(Fila)
            rt.Cells(Fila, 0).Text = "Lote"
            rt.Cells(Fila, 1).Text = "Producto"
            rt.Cells(Fila, 2).Text = "Proveedor"
            rt.Cells(Fila, 3).Text = "Cantidad"

            rt.Rows(Fila).Style.Font = New Font("Arial", 8, FontStyle.Bold)
            rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            rt.Rows(Fila).Style.BackColor = Color.LightGray
            Fila += 1

            Dim i As Integer = 0
            While i < Tab.Rows.Count
                If Not IsDBNull(Tab.Rows(i).Item("TipoProductoID")) And (TabTipPro.Rows(ContadorProductos).Item("Enologico")) Then
                    If Tab.Rows(i).Item("TipoProductoID") = TabTipPro.Rows(ContadorProductos).Item("TipoProductoID") Then
                        valor = rt.Rows.Item(Fila)
                        rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Regular)
                        rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                        rt.Cells(Fila, 1).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                        rt.Cells(Fila, 2).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                        rt.Cells(Fila, 3).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                        ExisteProducto = True
                        If Not IsDBNull(Tab.Rows(i).Item("CodigoLote")) Then rt.Cells(Fila, 0).Text = Tab.Rows(i).Item("CodigoLote")
                        If Not IsDBNull(Tab.Rows(i).Item("Nombre")) Then rt.Cells(Fila, 1).Text = Tab.Rows(i).Item("Descripcion")
                        If Not IsDBNull(Tab.Rows(i).Item("Descripcion")) Then rt.Cells(Fila, 2).Text = Tab.Rows(i).Item("Nombre")
                        If Not IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then
                            rt.Cells(Fila, 3).Text = Format(Tab.Rows(i).Item("CantidadRestante"), "#,##")
                            TotalCantidad += Tab.Rows(i).Item("CantidadRestante")
                        End If
                        Fila += 1
                    End If
                End If
                i += 1
            End While

            If ExisteProducto Then
                valor = rt.Rows.Item(Fila)
                rt.Cells(Fila, 0).SpanCols = 3
                rt.Cells(Fila, 0).Style.BackColor = Color.White
                rt.Cells(Fila, 0).Style.GridLines.Left = LineDef.Empty
                rt.Cells(Fila, 0).Style.GridLines.Bottom = LineDef.Empty
                rt.Cells(Fila, 3).Text = Format(TotalCantidad, "#,##")
                rt.Cells(Fila, 3).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Rows(Fila).Style.Font = New Font("Arial", 8, FontStyle.Bold)
                rt.Rows(Fila).Style.BackColor = Color.LightGray
                doc.Body.Children.Add(New RenderEmpty("2mm"))
                doc.Body.Children.Add(rt)
            End If

            ExisteProducto = False
            ContadorProductos += 1
        End While


        Dim rtf As New RenderTable()
        doc.PageLayout.PageFooter = rtf

        rtf.Cells(0, 0).Text = ""
        rtf.Cells(0, 0).SpanCols = 3
        rtf.Cells(0, 0).Style.FontSize = 6
        rtf.Cells(0, 0).Style.FontItalic = True
        rtf.Cells(0, 0).Style.TextAlignVert = C1.C1Preview.AlignVertEnum.Center
        rtf.Cells(0, 0).CellStyle.Padding.Bottom = "2mm"

        rtf.Cells(1, 0).Text = ""
        rtf.Cells(1, 0).Style.FontItalic = True
        rtf.Cells(1, 0).Style.FontSize = 12
        rtf.Cells(1, 0).Style.TextColor = Color.Red

        rtf.Cells(1, 1).Text = "Pagina: [PageNo] de [PageCount]"
        rtf.Cells(1, 1).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
        rtf.Cells(1, 1).Style.FontBold = True
        rtf.Cells(1, 1).Style.FontSize = 12

        rtf.Cells(1, 2).Text = Now
        rtf.Cells(1, 2).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
        rtf.Cells(1, 2).Style.FontBold = True
        rtf.Cells(1, 2).Style.FontSize = 12

        C1PrintPreviewControl1.Document = doc
    End Sub
End Class





