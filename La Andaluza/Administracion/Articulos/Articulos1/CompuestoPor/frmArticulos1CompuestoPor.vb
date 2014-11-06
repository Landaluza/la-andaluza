Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulos1CompuestoPor
    Private spArticulos1CompuestoPor As spArticulos1CompuestoPor
    Private articuloId As Integer
    Public Event actualizarDatos()
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spArticulos1CompuestoPor = New spArticulos1CompuestoPor
        Me.articuloId = articuloid
    End Sub

    Private Sub frmArticulos1CompuestoPor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DgvFill()
    End Sub

    Private Sub DgvFill()
        Me.DataGridView1.DataSource = Me.spArticulos1CompuestoPor.DataTableFill(Me.articuloId, dtb)

        If Not Me.DataGridView1.DataSource Is Nothing Then
            DataGridView1.Columns("articuloid").Visible = False
            DataGridView1.Columns("costeUnitario").Visible = False
            DataGridView1.Columns("subtotal").Visible = False
            DataGridView1.FormatoColumna("descripcionLa", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            DataGridView1.FormatoColumna("cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        End If
    End Sub

    Private Sub butNuevo_Click(sender As System.Object, e As System.EventArgs) Handles butNuevo.Click
        Dim frm As New frmModCompuestoPor(Me.articuloId)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        DgvFill()
        RaiseEvent actualizarDatos()
    End Sub

    Private Sub butModificar_Click(sender As System.Object, e As System.EventArgs) Handles butModificar.Click
        Dim frm As New frmModCompuestoPor(Me.articuloId, DataGridView1.CurrentRow.Cells("articuloid").Value)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        DgvFill()
    End Sub

    Private Sub butEliminar_Click(sender As System.Object, e As System.EventArgs) Handles butEliminar.Click
        Try
            If Me.spArticulos1CompuestoPor.Eliminar(Me.articuloId, DataGridView1.CurrentRow.Cells("articuloid").Value, dtb) Then
                RaiseEvent actualizarDatos()
                DgvFill()
            Else
                MessageBox.Show("Ocurrio un error al eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class