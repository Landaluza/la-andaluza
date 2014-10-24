Imports BasesParaCompatibilidad.dtpExtension

Public Class frmStock2

    Private clsStock As New spStock2
    Private dt As DataTable
    Private mdtStart As DateTime
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()

        dtEnd.activarFoco()
    End Sub

    Private Sub frmStock2_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim dt As DataTable
        dt = clsStock.SelectStock2_1(dtb)
        If dt.Rows.Count > 0 Then
            For i As Integer = 0 To dt.Rows.Count - 1
                dtStart.Items.Add(Convert.ToString(dt.Rows.Item(i).Item("Fecha")))
            Next i
        End If
    End Sub

    Private Sub butOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butOK.Click
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        clsStock.SelectStock2_2(dtb)
        clsStock.SelectStock2_3(mdtStart, dtEnd.Value, dtb)
        clsStock.SelectStock2_4(mdtStart, dtEnd.Value, dtb)
        dt = clsStock.SelectStock2_5(dtb)

        If mdtStart > dtEnd.Value Then
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
        Dim frm As New BasesParaCompatibilidad.frmEspera("")
        frm.Show()
        Me.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Try
            If dt.Rows.Count = 0 Then
                messagebox.show("No Record", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                oSheet.Range("B3").Value = "Fecha Inicio: " & dtStart.Text
                oSheet.Range("B3").Font.Bold = True
                oSheet.Range("B4").Value = "Fecha Final: " & dtEnd.Text()
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
            Me.Cursor = System.Windows.Forms.Cursors.Default
        End Try
       
    End Sub

    Private Sub dtStart_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtStart.SelectedIndexChanged
        mdtStart = Convert.ToDateTime(dtStart.Text)
    End Sub

    Private Sub frmStock2_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Try
            Me.dtStart.SelectedIndex = 0
        Catch ex As Exception
        End Try
    End Sub
End Class