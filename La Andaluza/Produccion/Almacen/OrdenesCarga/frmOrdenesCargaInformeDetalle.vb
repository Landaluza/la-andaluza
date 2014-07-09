

Public Class frmOrdenesCargaInformeDetalle
    Private dtAlbaranes As DataTable
    Private dtLineas As DataTable
    Public FechaSeleccionada As String

    Public Sub New(ByVal dgv As DataGridView, ByVal dt As DataTable)
        InitializeComponent()
        Me.dtLineas = dt
        ''importarDatos(dgv)
        Me.dgvDetalle.DataSource = dt
    End Sub

    Private Sub CambiarColorToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CambiarColorToolStripMenuItem.Click
        If Me.ColorDialog1.ShowDialog() = DialogResult.OK Then
            Dim style As New DataGridViewCellStyle(Me.dgvDetalle.CurrentRow.DefaultCellStyle)
            style.BackColor = Me.ColorDialog1.Color
            Me.dgvDetalle.CurrentRow.DefaultCellStyle = style
        End If
    End Sub

    Private Sub frmOrdenesCargaInformeDetalle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.dgvDetalle.RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb(Color.Transparent.ToArgb + 5)
    End Sub

    Private Sub ResetToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetToolStripMenuItem.Click
        Dim style As New DataGridViewCellStyle(Me.dgvDetalle.CurrentRow.DefaultCellStyle)
        style.BackColor = New DataGridViewRow().DefaultCellStyle.BackColor
        Me.dgvDetalle.CurrentRow.DefaultCellStyle = style
    End Sub

    Private Sub importarDatos(ByVal dgv As DataGridView)
        Dim row As DataGridViewRow
        ''Dim column As DataGridViewColumn
        Dim cb As DataGridViewCheckBoxCell

        'For Each column In dgv.Columns
        '        Me.dgvDetalle.Columns.Add(column.Name, column.Name)
        'Next

        Me.dgvDetalle.DataSource = dgv.DataSource

        For Each row In dgv.Rows
            If TypeOf row.Cells("Exportar") Is DataGridViewCheckBoxCell Then
                cb = row.Cells("Exportar")
                If Not cb.Value Then
                    Me.dgvDetalle.Rows.RemoveAt(row.Index)
                End If
            End If
        Next

        'Me.dgvDetalle.Columns("Exportar").Visible = False
    End Sub


    Private Sub exportar()
        Dim oExcel As Microsoft.Office.Interop.Excel.Application
        Dim oBook As Microsoft.Office.Interop.Excel.Workbook
        Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet

        'preparativos para guardar el archivo
        Dim RutaCompleta As String
        Dim Unidad As String
        Dim NombreHoja As String
        Dim Ruta As String = "Almacen\Ordenes de carga\"
        'Dim m_detalles As DBO_OrdenesCargaDetalles

        FechaSeleccionada = Now.Year & "." & _
                            Convert.ToString(Now.Month) & "." & _
                            Convert.ToString(Now.Day) & " " & _
                            Convert.ToString(Now.Hour) & "-" & _
                            Convert.ToString(Now.Minute)

        If BasesParaCompatibilidad.Config.Server = 0 Then ' "GERENTE1\SQLEXPRESS") Or (GUImain.ServidorUsado = "W7U\SQLEXPRESS2005") Then
            Unidad = "C:\"
        Else
            Unidad = "Z:\"
        End If

        RutaCompleta = Unidad & Ruta
        NombreHoja = RutaCompleta & FechaSeleccionada & " Orden de carga.xlsx"

        'creacion de excel
        oExcel = CreateObject("Excel.Application")
        oExcel.Visible = True
        oBook = oExcel.Workbooks.Add
        oSheet = oBook.Worksheets(1)


        oSheet.Range("B2").Value = "Orden de carga "
        oSheet.Range("D2").Value = "FECHA " & String.Format("dd/MM/yyyy", Today)
        oSheet.Range("B2:D2").Font.Bold = True
        oSheet.Range("B2:D2").Font.Size = 22
        oSheet.Range("B2:D2").Font.Color = Color.Black
        oSheet.Range("B2:D2").Cells.HorizontalAlignment = HorizontalAlignment.Center

        oSheet.Range("B4").Value = "Siempre completar hasta maximo de kilos del camión"
        oSheet.Range("B4").Font.Bold = True
        oSheet.Range("B4").Font.Size = 14
        oSheet.Range("B4").Font.Color = Color.Black
        oSheet.Range("B5").Value = "No cargar palets de salsas en paralelo"
        oSheet.Range("B5").Font.Bold = True
        oSheet.Range("B5").Font.Size = 14
        oSheet.Range("B5").Font.Color = Color.Red
        oSheet.Range("B6").Value = "La referencia subrayada en verde es con la que se debe completar hasta maximo de kilos."
        oSheet.Range("B6").Font.Bold = True
        oSheet.Range("B6").Font.Size = 14
        oSheet.Range("B6").Font.Color = Color.Green

        Dim spOrdenesCarga As New spOrdenesCarga
        If dtLineas.Columns.Count > 0 Then
            'guardamos el registro maestro
            BasesParaCompatibilidad.BD.EmpezarTransaccion()


            Try
                If Not spOrdenesCarga.AddOrdenCarga(NombreHoja, BasesParaCompatibilidad.BD.transaction) Then Throw New Exception("No se pudo guardar la orden de carga")
                'Header
                Dim DataArrayHead(0, 0 To dtLineas.Columns.Count - 2) As Object
                For s As Integer = 0 To dtLineas.Columns.Count - 2
                    DataArrayHead(0, s) = dtLineas.Columns(s + 1).Caption
                Next

                oSheet.Range("B8").Resize(1, dtLineas.Columns.Count - 1).Value = DataArrayHead
                oSheet.Range("B8").Resize(1, dtLineas.Columns.Count - 1).Font.Bold = True
                oSheet.Range("B8").Resize(1, dtLineas.Columns.Count - 1).HorizontalAlignment = HorizontalAlignment.Center

                'Detail
                Dim DataArray(0 To dtLineas.Rows.Count - 1, 0 To dtLineas.Columns.Count - 2) As Object
                For mRow As Integer = 0 To dtLineas.Rows.Count - 1
                    For mColumn As Integer = 0 To dtLineas.Columns.Count - 2
                        DataArray(mRow, mColumn) = dtLineas.Rows.Item(mRow).Item(mColumn + 1)
                        'If Not spOrdenesCarga.OrdenesCargaInsertDetail(m_detalles, BasesParaCompatibilidad.BD.transaction) Then Throw New Exception("Error guardando los detalles")
                    Next
                Next

                oSheet.Range("B9").Resize(dtLineas.Rows.Count, dtLineas.Columns.Count - 1).Value = DataArray

                'Resize Columns
                'oSheet.Columns("B:B").ColumnWidth = 0
                'oSheet.Columns("B:B").EntireColumn.Delete()
                'oSheet.Columns("E:I").EntireColumn.Delete()

                oSheet.Columns("B:B").ColumnWidth = 50
                oSheet.Columns("C:G").ColumnWidth = 8.5
                'oSheet.Columns("L:L").ColumnWidth = 50

                'oExcel.Visible = True

                oSheet.SaveAs(NombreHoja) ', Excel.XlFileFormat.xlExcel8)
                BasesParaCompatibilidad.BD.CancelarTransaccion()
                'BasesParaCompatibilidad.BD.TerminarTransaccion()
            Catch ex As Exception
                messagebox.show(ex.Message, "", MessageBoxButtons.OK , MessageBoxIcon.Error )
                BasesParaCompatibilidad.BD.CancelarTransaccion()
            Finally
                oExcel.Quit()
                oExcel = Nothing
                oSheet = Nothing
            End Try
        End If
    End Sub
End Class