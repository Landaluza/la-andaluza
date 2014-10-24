Imports BasesParaCompatibilidad.dtpExtension

Public Class frmStock

    Private clsStock As New spStock
    Private dt As DataTable
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        dtStart.activarFoco()
        dtEnd.activarFoco()
    End Sub
    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        ''create TempStocks table
        clsStock.SelectStock0(dtb)
        ''calculate stock from previous period
        clsStock.SelectStock1(DateAdd(DateInterval.Year, -100, dtStart.Value), DateAdd(DateInterval.Day, -1, dtStart.Value), dtb)
        clsStock.SelectStock2(DateAdd(DateInterval.Year, -100, dtStart.Value), DateAdd(DateInterval.Day, -1, dtStart.Value), dtb)
        clsStock.SelectStock3(dtb)
        ''Copy previous stock as current opening
        clsStock.SelectStock4(dtb)
        ''calculate stock of current period
        clsStock.SelectStock1(dtStart.Value, dtEnd.Value, dtb)
        clsStock.SelectStock2(dtStart.Value, dtEnd.Value, dtb)
        dt = clsStock.SelectStock3(dtb)

        If dtStart.Value > dtEnd.Value Then
            messagebox.show("Start-Date should not be greater than End-Date.", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            With dgvStock
                .DataSource = dt
                If .Rows.Count = 0 Then
                    messagebox.show("No Record")
                    butReport.Enabled = False
                Else
                    butReport.Enabled = True
                End If
            End With
        End If
        Me.Cursor = System.Windows.Forms.Cursors.Default
    End Sub

    Private Sub butReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butReport.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Dim frm As New BasesParaCompatibilidad.frmEspera
        frm.Show()
        Try
            If dt.Rows.Count = 0 Then
                messagebox.show("No Record")
            Else
                Dim oExcel As Microsoft.Office.Interop.Excel.Application
                Dim oBook As Microsoft.Office.Interop.Excel.Workbook
                Dim oSheet As Microsoft.Office.Interop.Excel.Worksheet
                oExcel = CreateObject("Excel.Application")
                oExcel.Visible = False
                oBook = oExcel.Workbooks.Add
                oSheet = oBook.Worksheets(1)

                oSheet.Range("B2").Value = "EXISTENCIAS EN CAJAS"
                oSheet.Range("B2").Font.Bold = True
                oSheet.Range("B3").Value = "Start Date: " & dtStart.Text
                oSheet.Range("B3").Font.Bold = True
                oSheet.Range("B4").Value = "End Date: " & dtEnd.Text()
                oSheet.Range("B4").Font.Bold = True

                'Header
                Dim DataArrayHead(0, 0 To dt.Columns.Count - 2) As Object
                For s As Integer = 0 To dt.Columns.Count - 2
                    DataArrayHead(0, s) = dt.Columns(s).Caption
                Next

                oSheet.Range("B6").Resize(1, dt.Columns.Count - 1).Value = DataArrayHead
                oSheet.Range("B6").Resize(1, dt.Columns.Count - 1).Font.Bold = True

                'Detail
                Dim DataArray(0 To dt.Rows.Count - 1, 0 To dt.Columns.Count - 2) As Object
                For r As Integer = 0 To dt.Rows.Count - 1
                    For s As Integer = 0 To dt.Columns.Count - 2
                        If s = 0 Then 'CodigoQS
                            DataArray(r, s) = "'" & dt.Rows.Item(r).Item(s)
                        Else
                            DataArray(r, s) = dt.Rows.Item(r).Item(s)
                        End If
                    Next
                Next

                oSheet.Range("B7").Resize(dt.Rows.Count, dt.Columns.Count - 1).Value = DataArray
                oSheet.Range("B" & 6 + dt.Rows.Count).Resize(dt.Rows.Count, dt.Columns.Count - 1).Font.Bold = True

                'Resize Columns
                oSheet.Columns("B:B").ColumnWidth = 13
                oSheet.Columns("C:C").ColumnWidth = 50

                'All done. Close this form.
                oExcel.Visible = True
                oExcel = Nothing
                oSheet = Nothing
            End If
        Catch ex As Exception
            MessageBox.Show("Erroe." & Environment.NewLine, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            frm.Close()
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
        

    End Sub

End Class