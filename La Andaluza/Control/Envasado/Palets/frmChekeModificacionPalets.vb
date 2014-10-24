Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmChekeModificacionPalets
    Private dtb As BasesParaCompatibilidad.DataBase
    Private datasource As DataTable
    Private datasourceDetalles As DataTable
    Private calendar As BasesParaCompatibilidad.Calendar
    Public Sub New()
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
        calendar = New BasesParaCompatibilidad.Calendar
    End Sub
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvFill()
    End Sub

    Private Sub dgvFill()
        dtb.PrepararConsulta("comparacion_produccion_paletsmodificados2 @inicio, @usuario")
        dtb.AñadirParametroConsulta("@inicio", Me.dtpInicio.Value)
        dtb.AñadirParametroConsulta("@usuario", Me.cboUsuario.SelectedValue)
        datasource = dtb.Consultar

        If Not datasource Is Nothing Then
            DataGridView1.SuspendLayout()
            Me.DataGridView1.DataSource = datasource
            DataGridView1.Columns("paletProducidoID").Visible = False
            DataGridView1.FormatoColumna("scc", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            DataGridView1.FormatoColumna("fechaModificacion2", "Fecha Modificacion", BasesParaCompatibilidad.TiposColumna.FechaCorta, True)
            DataGridView1.FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, True)
            DataGridView1.FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, True)
            DataGridView1.ResumeLayout()
        End If
    End Sub

    Private Sub dgvFillDetalles()

        dtb.PrepararConsulta("PaletsContenidos2ByPaletProducidoID @id")
        dtb.AñadirParametroConsulta("@id", Me.DataGridView1.CurrentRow.Cells("paletProducidoID").Value)
        datasourceDetalles = dtb.Consultar()

        datasourceDetalles.Columns.Add("Lote")
        For Each row As DataRow In datasourceDetalles.Rows

            row.Item("Lote") = calendar.DevuelveFechaJuliana(row.Item("gregoriano"))
        Next

        If Not datasourceDetalles Is Nothing Then
            dgvDetalles.SuspendLayout()
            With Me.dgvDetalles
                .DataSource = datasourceDetalles
                .Columns("PaletContenidoID").Visible = False
                .Columns("PaletProducidoID").Visible = False
                .Columns("EnAlmacen").Visible = False
                .Columns("Completo").Visible = False
                .Columns("gregoriano").Visible = False
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85)
                .FormatoColumna("Inicio", BasesParaCompatibilidad.TiposColumna.Hora, 65)
                .FormatoColumna("Fin", BasesParaCompatibilidad.TiposColumna.Hora, 65)
                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 45)
                .FormatoColumna("Lote", BasesParaCompatibilidad.TiposColumna.Descripcion, 85)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
            End With



            dgvDetalles.ResumeLayout()


        End If
    End Sub

    Private Sub frmChekeModificacionPalets_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Dim s As New spEmpleados
        s.cargar_Empleados_usuarios(Me.cboUsuario, dtb)
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As System.Object, e As System.EventArgs) Handles DataGridView1.SelectionChanged
        dgvFillDetalles()
    End Sub
End Class