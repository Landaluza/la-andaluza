Public Class frmTiposProductosCompuestoPor
    Private sp As spTiposProductosCompuestoPor
    Private Id As Integer

    Public Sub New(ByVal Id_tipoProducto As Integer)

        InitializeComponent()

        sp = New spTiposProductosCompuestoPor
        Me.Id = Id_tipoProducto

        dgvFill()
    End Sub

    Private Sub tsdel_Click(sender As System.Object, e As System.EventArgs) Handles tsdel.Click
        eliminar()
    End Sub

    Private Sub tsmod_Click(sender As System.Object, e As System.EventArgs) Handles tsmod.Click
        modificar(Me.DataGridView1.CurrentRow.Cells("tipoproductoid").Value)
    End Sub

    Private Sub tsadd_Click(sender As System.Object, e As System.EventArgs) Handles tsadd.Click
        insertar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        modificar(Me.DataGridView1.CurrentRow.Cells("tipoproductoid").Value)
    End Sub

    Private Sub dgvFill()
        Dim dt As DataTable = Me.sp.selectDgv(Me.Id)

        If Not dt Is Nothing Then
            Me.DataGridView1.DataSource = dt

            Me.DataGridView1.Columns("tipoproductoid").Visible = False
        End If
    End Sub

    Private Sub modificar(ByVal id As Integer)

    End Sub

    Private Sub insertar()

    End Sub

    Private Sub eliminar()

    End Sub
End Class