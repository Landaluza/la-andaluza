Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlmacenEntradasInforme
    Inherits Windows.Forms.Form
    Private spAlmacen As spAlmacenPalets
    Private datasource As DataTable
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New()
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase
        Me.spAlmacen = New spAlmacenPalets
        Me.MonthCalendar.MaxDate = DateTime.Now.Date
        Me.MonthCalendar.SelectionRange.Start = DateTime.Now.Date
    End Sub

    Private Sub MonthCalendar_DateChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DateRangeEventArgs) Handles MonthCalendar.DateChanged
        dgvFill()
    End Sub

    Private Sub dgvFill()
        If Not spAlmacen Is Nothing Then
            Me.Cursor = Cursors.WaitCursor
            datasource = Me.spAlmacen.selectEntradasPorFecha(Me.MonthCalendar.SelectionRange.Start, dtb)

            If Not datasource Is Nothing Then
                dgv.DataSource = datasource
                If (Me.dgv.Columns.Count > 0) Then
                    With dgv
                        .Columns("PaletAlmacenEntradaID").Visible = False
                        .Columns("Fecha").Visible = False
                        .FormatoColumna("SSCC", BasesParaCompatibilidad.TiposColumna.Izquierda, 60)
                        .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Descripcion, 250)
                        .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 60)
                        .FormatoColumna("ComentariosCarga", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 80)
                        .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True, 80)
                        .FormatoColumna("Vigente", BasesParaCompatibilidad.TiposColumna.Centro, 60)
                        .FormatoGeneral()
                    End With
                End If
            End If
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub butSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butSalir.Click
        Me.Close()
    End Sub
End Class