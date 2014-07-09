Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmResumenDepositos
    Private spDepositos As spREsumenDepositos
    Private tempDataTable As DataTable

    Public Sub New()

        InitializeComponent()

        Me.spDepositos = New spREsumenDepositos
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Me.tempDataTable = Me.spDepositos.listar_depositos
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        dgvFill()
    End Sub

    Public Sub dgvFill()
        If Not Me.tempDataTable Is Nothing Then
            With Me.DataGridView1
                .DataSource = Me.tempDataTable
                .Columns("Capacidad").Visible = False
                .Columns("Descripcion").Visible = False
                .Columns("Acidez").Visible = False
                .Columns("Alcohol").Visible = False
                .Columns("Densidad").Visible = False
                .Columns("Sulfuroso").Visible = False
                .Columns("depositoID").Visible = False
                .Columns("Listado").Visible = False
                .Columns("TipoLoteID").Visible = False
                .Columns("TipoProductoID").Visible = False
                .FormatoColumna("Codigo", BasesParaCompatibilidad.TiposColumna.Miles, False, 1, 20)
                .FormatoColumna("CodigoLote", "Lote", BasesParaCompatibilidad.TiposColumna.Izquierda, False, 2, 130)
                .FormatoColumna("CantidadRestante", "Restante", BasesParaCompatibilidad.TiposColumna.Miles, False, 3, 70)

            End With

            For Each row As DataGridViewRow In Me.DataGridView1.Rows
                For Each cell As DataGridViewCell In row.Cells
                    cell.ToolTipText = If(Convert.IsDBNull(row.Cells("Descripcion").Value), "", row.Cells("Descripcion").Value)
                Next
            Next
        End If

        Me.tsActualizacion.Text = "Ultima actualizacion: " & DateTime.Now.Hour & ":" & DateTime.Now.Minute
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        If Not BackgroundWorker1.IsBusy Then BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub frmResumenDepositos_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        BackgroundWorker1.RunWorkerAsync()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        BackgroundWorker1.RunWorkerAsync()
    End Sub
End Class