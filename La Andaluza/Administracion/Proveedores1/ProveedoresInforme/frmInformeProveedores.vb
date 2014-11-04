Imports BasesParaCompatibilidad.DataGridViewExtension


Public Class frmInformeProveedores
    Private dtb as BasesParaCompatibilidad.Database
    Private filterManager As DgvFilterPopup.DgvFilterManager
    Public Sub New()

        InitializeComponent()
        filterManager = New DgvFilterPopup.DgvFilterManager(Me.dgvProveedores)
        dtb = New BasesParaCompatibilidad.Database()
    End Sub

    Private Sub dgvfill()
        dtb.PrepararConsulta("ProveedoresInformeSelectDgv")
        Dim dt As DataTable = dtb.Consultar()

        If Not dt Is Nothing Then
            With dgvProveedores

                .DataSource = dt

                .Columns("ProveedorID").Visible = False
                .Columns("ProveedorCeroID").Visible = False
                .Columns("Alias").Visible = False
                .Columns("NIF").Visible = False
                .Columns("RSI").Visible = False
                .Columns("Cp2").Visible = False
                .Columns("Direccion2").Visible = False
                .Columns("Provincia2").Visible = False
                .Columns("Poblacion2").Visible = False
                .Columns("Pais2").Visible = False
                .Columns("QS").Visible = False
                .Columns("Tipo").Visible = False
                .Columns("DireccionCompleta2").Visible = False
                .Columns("DireccionCompleta").Visible = False

                .FormatoColumna("Proveedor", "Proveedor", BasesParaCompatibilidad.TiposColumna.Izquierda, True, 1, 150)
                .FormatoColumna("Direccion", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 2, 100)
                .FormatoColumna("Cp", BasesParaCompatibilidad.TiposColumna.Descripcion, 40, 3)
                .FormatoColumna("Pais", BasesParaCompatibilidad.TiposColumna.Descripcion, 60, 4)
                .FormatoColumna("Provincia", BasesParaCompatibilidad.TiposColumna.Descripcion, 60, 5)
                .FormatoColumna("Poblacion", BasesParaCompatibilidad.TiposColumna.Descripcion, 60, 6)
                .FormatoColumna("FechaUltimaReunion", "Fecha ultima reunion", BasesParaCompatibilidad.TiposColumna.FechaCorta, 100, 7)
                .FormatoColumna("N_trabajadores", "Trabajadores", BasesParaCompatibilidad.TiposColumna.Derecha, 80, 8)
                .FormatoColumna("EmpleadosSectorPrimario", "Empleados sector primario", BasesParaCompatibilidad.TiposColumna.Derecha, 80, 9)
                .FormatoColumna("ConsumoParaMercadona", "Consumo para Mercadona", BasesParaCompatibilidad.TiposColumna.Derecha, 80, 10)
                .FormatoColumna("CapacidadProductivaTotal", "Capacidad productiva total", BasesParaCompatibilidad.TiposColumna.Derecha, 100, 11)
                .FormatoColumna("CompromisoCalidad", "Compromiso calidad", BasesParaCompatibilidad.TiposColumna.Derecha, 80, 12)
                .FormatoColumna("ResultadoFinanciero", "Resultado financiero ultimos 3 años", BasesParaCompatibilidad.TiposColumna.Derecha, 100, 13)
            End With
        End If


    End Sub

    Private Sub frmInformeProveedores_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        dgvfill()

    End Sub

    Private Sub ToolStripButton1_Click(sender As System.Object, e As System.EventArgs) Handles ToolStripButton1.Click
        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer
        Dim contFilas As Integer
        Dim contColumnas As Integer
        Dim saveFileDialog1 As New SaveFileDialog

        Try
            saveFileDialog1.Filter = "Archivo de Excel|*.xlsx"
            saveFileDialog1.Title = "Guardar listado de proveedores"
            saveFileDialog1.ShowDialog()

            If saveFileDialog1.FileName <> "" Then
                If Not saveFileDialog1.FileName.EndsWith(".xlsx") Then saveFileDialog1.FileName = saveFileDialog1.FileName & ".xlsx"

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets(1)

                contFilas = 1
                contColumnas = 1

                For j = 0 To dgvProveedores.ColumnCount - 1
                    If dgvProveedores.Columns(j).Visible Then
                        xlWorkSheet.Cells(1, contColumnas + 1) = dgvProveedores.Columns(j).HeaderText
                        xlApp.Range(xlApp.Cells(1, contColumnas + 1), xlApp.Cells(1, contColumnas + 1)).ColumnWidth = dgvProveedores.Columns(j).Width / 5
                        contColumnas += 1
                    End If
                Next
                xlApp.Range(xlApp.Cells(1, 1), xlApp.Cells(1, contColumnas)).Font.Bold = True
                contColumnas = 1

                For i = 0 To dgvProveedores.RowCount - 1
                    For j = 0 To dgvProveedores.ColumnCount - 1
                        If dgvProveedores.Columns(j).Visible Then
                            xlWorkSheet.Cells(contFilas + 1, contColumnas + 1) = _
                                Convert.ToString(dgvProveedores(j, i).Value)

                            contColumnas += 1
                        End If
                    Next
                    contColumnas = 1
                    contFilas += 1
                Next

                ' contColumnas = 1

                'For j = 0 To dgvProveedores.ColumnCount - 1
                '    If dgvProveedores.Columns(j).Visible Then
                '        xlApp.Columns(Chr(contColumnas + 65)) = dgvProveedores.Columns(j).Width

                '        contColumnas += 1
                '    End If
                'Next

                xlWorkSheet.SaveAs(saveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)
            End If

        Catch ex As Exception
            MessageBox.Show("Error. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub
End Class