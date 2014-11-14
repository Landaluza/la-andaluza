Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmContenidosDetallesMonodosis
    Inherits Form

    Public id As Integer
    Private tipoFormato As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Private datasource As DataTable
    Public Sub New(ByVal tipoformato As Integer)

        InitializeComponent()

        Me.tipoFormato = tipoformato
        dtb = New BasesParaCompatibilidad.DataBase()
    End Sub

    Private Sub dgvGeneral_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGeneral.CellDoubleClick
        Me.id = Me.dgvGeneral.CurrentRow.Cells("paletproducidoID").Value
        Me.Close()
    End Sub

    Private Sub frmContenidosDetallesMonodosis_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        dgvFill()
    End Sub

    Public Sub dgvFill()
        Me.dgvGeneral.Cursor = Cursors.WaitCursor
        Me.BackgroundWorker1.RunWorkerAsync()
        Me.dgvGeneral.Cursor = Cursors.Default
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As System.Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        dtb.PrepararConsulta("PaletsContenidosSelectMonodosis2 @tf")
        dtb.AñadirParametroConsulta("@tf", tipoFormato)
        datasource = dtb.Consultar()
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As System.Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        If Not datasource Is Nothing Then
            Me.dgvGeneral.DataSource = datasource

            Me.dgvGeneral.Columns("paletproducidoID").Visible = False
            Me.dgvGeneral.FormatoColumna("descripcion", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            Me.dgvGeneral.FormatoColumna("fecha", "Fecha envasado", BasesParaCompatibilidad.TiposColumna.FechaCorta, 80)
        End If
    End Sub
End Class
