Imports C1.C1Preview

Public Class LisDepPorTipos
    Private doc As C1PrintDocument
    Private ExisteProducto As Boolean
    Private ContadorProductos As Integer
    Private spProd As spTiposProductos
    Private TabTipPro As DataTable
    Private ctlDep As ctlDepositos
    Private Tab As DataTable
    Private title As RenderParagraph
    Private frmEspera As BasesParaCompatibilidad.frmEspera
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        doc = New C1PrintDocument

        ContadorProductos = 0
        spProd = New spTiposProductos
        TabTipPro = New DataTable
        ctlDep = New ctlDepositos
        Tab = New DataTable
    End Sub

    Private Sub LisDepPorTipos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        frmEspera = New BasesParaCompatibilidad.frmEspera("Generando informe, espere unos segundos")
        frmEspera.Show()
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        TabTipPro = spProd.devolver_TiposProductos(dtb) 'ctlTipPro.DevolverTiposProductos
        Tab = ctlDep.devolverDepositosLotes(dtb)

        doc.DefaultUnit = C1.C1Preview.UnitTypeEnum.Mm

        ' define PageLayout for the first page
        Dim pl As New PageLayout()
        With pl
            .PageSettings = New C1PageSettings()
            .PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
            .PageSettings.LeftMargin = 10
            .PageSettings.RightMargin = 10
        End With
        'doc.PageLayouts.FirstPage = pl
        doc.PageLayouts.Default = pl


        ' create the title of the document
        title = New RenderParagraph()
        title.Content.AddText("Existencias de productos a granell al día " & DateTime.Now)
        'title.Content.AddText("PageLayouts", Color.Blue)
        title.Style.Font = New Font("Tahoma", 18, FontStyle.Bold)
        title.Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
        title.Style.Borders.Bottom = New LineDef("1mm", Color.Black)
        title.Content.AddText("                ")
        doc.Body.Children.Add(title)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        While ContadorProductos < TabTipPro.Rows.Count
            Dim rt As New RenderTable()
            rt.Style.GridLines.All = LineDef.Default
            rt.CellStyle.Padding.Right = "1mm"
            rt.CellStyle.Padding.Left = "1mm"

            'rt.Rows(0).Style.Font = New Font("Arial", 12, FontStyle.Bold)
            rt.Cols(0).Width = 14
            rt.Cols(1).Width = 26
            rt.Cols(2).Width = 40
            rt.Cols(3).Width = 70
            rt.Cols(4).Width = 30
            rt.Cols(5).Width = 20
            rt.Cols(6).Width = 20
            rt.Cols(7).Width = 32
            rt.Cols(8).Width = 28

            Dim valor As Object
            Dim Fila As Integer = 0

            valor = rt.Rows.Item(Fila)
            rt.Cells(Fila, 0).Text = TabTipPro.Rows(ContadorProductos).Item("Descripcion")
            rt.Cells(Fila, 0).SpanCols = 9
            rt.Rows(Fila).Style.Font = New Font("Tahoma", 14, FontStyle.Bold)
            rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            'rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            rt.Rows(Fila).Style.BackColor = Color.Aqua
            Fila += 1

            valor = rt.Rows.Item(Fila)
            rt.Cells(Fila, 0).Text = "Num"
            rt.Cells(Fila, 1).Text = "Capacidad"
            rt.Cells(Fila, 2).Text = "Contenido"
            rt.Cells(Fila, 3).Text = "Descripcion"
            rt.Cells(Fila, 4).Text = "Cantidad"
            rt.Cells(Fila, 5).Text = "Acidez"
            rt.Cells(Fila, 6).Text = "Alcohol"
            rt.Cells(Fila, 7).Text = "º acidez"
            rt.Cells(Fila, 8).Text = "º alcohol"
            rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Bold)
            'rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            rt.Rows(Fila).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Center
            rt.Rows(Fila).Style.BackColor = Color.LightGray
            Fila += 1

            Dim i As Integer = 0
            Dim TotalCantidad As Double = 0
            Dim GradosAcidez As Double = 0
            Dim GradosAlcohol As Double = 0
            Dim BanderaBotas As Boolean = True
            Dim acidez As Double = 0
            Dim alcohol As Double = 0
            Dim contRegistros As Integer

            If Tab.Rows.Count > 0 Then
                contRegistros = 0

                While i < Tab.Rows.Count 'Id
                    If Not Convert.IsDBNull(Tab.Rows(i).Item("TipoProductoID")) And Not Convert.ToBoolean(TabTipPro.Rows(ContadorProductos).Item("Enologico")) Then
                        If Convert.ToInt32(Tab.Rows(i).Item("TipoProductoID")) = Convert.ToInt32(TabTipPro.Rows(ContadorProductos).Item("Id")) Then
                            If Convert.ToInt32(Tab.Rows(i).Item("TipoLoteID")) = 10 And BanderaBotas Then 'TipoLote = botas
                                BanderaBotas = False

                                'Define footer
                                Fila += 1
                                valor = rt.Rows.Item(Fila)
                                rt.Cells(Fila, 4).Text = Format(TotalCantidad, "#,##")
                                rt.Cells(Fila, 5).Text = Format(GradosAcidez / TotalCantidad, "0.##")
                                rt.Cells(Fila, 6).Text = Format(GradosAlcohol / TotalCantidad, "0.##")
                                rt.Cells(Fila, 7).Text = Format(GradosAcidez, "#,##")
                                rt.Cells(Fila, 8).Text = Format(GradosAlcohol, "#,##")

                                rt.Cells(Fila, 4).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 5).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 6).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 7).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 8).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Rows(Fila).Style.Font = New Font("Arial", 8, FontStyle.Bold)
                                rt.Rows(Fila).Style.BackColor = Color.LightGray

                                Fila += 1
                                TotalCantidad = 0
                                GradosAcidez = 0
                                GradosAlcohol = 0
                                acidez = 0
                                alcohol = 0

                                valor = rt.Rows.Item(Fila)
                                'rt.Rows.Insert(Fila)
                                rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Regular)
                                rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 1).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 2).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                                rt.Cells(Fila, 3).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                                rt.Cells(Fila, 4).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 5).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 6).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 7).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 8).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                ExisteProducto = True
                                rt.Cells(Fila, 0).Text = Tab.Rows(i).Item("Codigo")
                                rt.Cells(Fila, 1).Text = Format(Tab.Rows(i).Item("Capacidad"), "0,00")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("CodigoLote")) Then rt.Cells(Fila, 2).Text = Tab.Rows(i).Item("CodigoLote")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Descripcion")) Then rt.Cells(Fila, 3).Text = Tab.Rows(i).Item("Descripcion")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then rt.Cells(Fila, 4).Text = Format(Tab.Rows(i).Item("CantidadRestante"), "#,##")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Acidez")) Then rt.Cells(Fila, 5).Text = Format(Tab.Rows(i).Item("Acidez"), "0.#0")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Alcohol")) Then rt.Cells(Fila, 6).Text = Format(Tab.Rows(i).Item("Alcohol"), "0.#0")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("TipoProductoID")) Then
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then
                                        TotalCantidad += Convert.ToDouble(Tab.Rows(i).Item("CantidadRestante"))
                                    End If
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("Acidez")) Then
                                        GradosAcidez += Convert.ToDouble(Tab.Rows(i).Item("CantidadRestante")) * Convert.ToDouble(Tab.Rows(i).Item("Acidez"))
                                        rt.Cells(Fila, 7).Text = Format(Convert.ToDouble(Tab.Rows(i).Item("CantidadRestante")) * _
                                                                                         Convert.ToDouble(Tab.Rows(i).Item("Acidez")), "#,##")
                                    End If
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("Alcohol")) Then
                                        GradosAlcohol += Convert.ToDouble(Tab.Rows(i).Item("CantidadRestante")) * Convert.ToDouble(Tab.Rows(i).Item("Alcohol"))
                                        rt.Cells(Fila, 8).Text = Format(Convert.ToDouble(Tab.Rows(i).Item("CantidadRestante")) * _
                                                                                         Convert.ToDouble(Tab.Rows(i).Item("Alcohol")), "#,##")
                                    End If
                                End If
                                Fila += 1
                            Else ' If Tab.Rows(i).Item("TipoLoteID") = 10 And BanderaBotas  Then 'TipoLote = botas
                                valor = rt.Rows.Item(Fila)
                                'rt.Rows.Insert(Fila)
                                rt.Rows(Fila).Style.Font = New Font("Arial", 6, FontStyle.Regular)
                                rt.Cells(Fila, 0).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 1).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 2).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                                rt.Cells(Fila, 3).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Left
                                rt.Cells(Fila, 4).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 5).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 6).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 7).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                rt.Cells(Fila, 8).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                                ExisteProducto = True
                                rt.Cells(Fila, 0).Text = Tab.Rows(i).Item("Codigo")
                                rt.Cells(Fila, 1).Text = Format(Tab.Rows(i).Item("Capacidad"), "0,00")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("CodigoLote")) Then rt.Cells(Fila, 2).Text = Tab.Rows(i).Item("CodigoLote")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Descripcion")) Then rt.Cells(Fila, 3).Text = Tab.Rows(i).Item("Descripcion")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then rt.Cells(Fila, 4).Text = Format(Tab.Rows(i).Item("CantidadRestante"), "#,##")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Acidez")) Then rt.Cells(Fila, 5).Text = Format(Tab.Rows(i).Item("Acidez"), "0.#0")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("Alcohol")) Then rt.Cells(Fila, 6).Text = Format(Tab.Rows(i).Item("Alcohol"), "0.#0")
                                If Not Convert.IsDBNull(Tab.Rows(i).Item("TipoProductoID")) Then
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("CantidadRestante")) Then
                                        TotalCantidad += Tab.Rows(i).Item("CantidadRestante")
                                    End If
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("Acidez")) Then
                                        acidez += Tab.Rows(i).Item("Acidez")
                                        GradosAcidez += Tab.Rows(i).Item("CantidadRestante") * Tab.Rows(i).Item("Acidez")
                                        rt.Cells(Fila, 7).Text = Format(Tab.Rows(i).Item("CantidadRestante") * Tab.Rows(i).Item("Acidez"), "#,##")
                                    End If
                                    If Not Convert.IsDBNull(Tab.Rows(i).Item("Alcohol")) Then
                                        alcohol += Tab.Rows(i).Item("Alcohol")
                                        GradosAlcohol += Tab.Rows(i).Item("CantidadRestante") * Tab.Rows(i).Item("Alcohol")
                                        rt.Cells(Fila, 8).Text = Format(Tab.Rows(i).Item("CantidadRestante") * Tab.Rows(i).Item("Alcohol"), "#,##")
                                    End If
                                End If
                                Fila += 1
                            End If
                        End If ' If Tab.Rows(i).Item("TipoLoteID") = 10 Then 'TipoLote = botas
                    End If
                    i += 1
                    contRegistros += 1
                End While

                'Define footer
                valor = rt.Rows.Item(Fila)
                rt.Cells(Fila, 4).Text = Format(TotalCantidad, "#,##")
                rt.Cells(Fila, 5).Text = Format(GradosAcidez / TotalCantidad, "0.#0") ' Format(acidez / contRegistros, "0.#0") ' Format(GradosAcidez / TotalCantidad, "0,##")
                rt.Cells(Fila, 6).Text = Format(GradosAlcohol / TotalCantidad, "0.#0") 'Format(alcohol / contRegistros, "0.#0") 'Format(GradosAlcohol / TotalCantidad, "0,##")
                rt.Cells(Fila, 7).Text = Format(GradosAcidez, "#,##")
                rt.Cells(Fila, 8).Text = Format(GradosAlcohol, "#,##")
                rt.Cells(Fila, 4).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 5).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 6).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 7).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Cells(Fila, 8).Style.TextAlignHorz = C1.C1Preview.AlignHorzEnum.Right
                rt.Rows(Fila).Style.Font = New Font("Arial", 8, FontStyle.Bold)
                rt.Rows(Fila).Style.BackColor = Color.LightGray

                If ExisteProducto Then
                    doc.Body.Children.Add(New RenderEmpty("2mm"))
                    doc.Body.Children.Add(rt)
                End If

            End If
            ExisteProducto = False
            ContadorProductos += 1
        End While

        ' add the table to the document
        C1PrintPreviewControl1.Document = doc

        frmEspera.Close()
    End Sub
End Class

