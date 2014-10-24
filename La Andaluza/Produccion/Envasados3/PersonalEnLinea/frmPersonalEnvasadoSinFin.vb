Public Class frmPersonalEnvasadoSinFin
    Private dtb As BasesParaCompatibilidad.DataBase
    Private Sub cargar()
        dtb = New BasesParaCompatibilidad.DataBase
        Dim dtOcupados As DataTable
        Dim spEmlpeados As New spEmpleados
        dgvOcupados.Rows.Clear()

        dtOcupados = spEmlpeados.devolver_empleados_con_turnos_sin_fin(dtb)

        For Each row As DataRow In dtOcupados.Rows
            dgvOcupados.Rows.Add(New String() {row(1), row(0), row(2), row(3)})
        Next
    End Sub

    Private Sub frmPersonalEnvasadoOcupado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles tsRefreescar.Click
        cargar()
    End Sub

    Private Sub tsSalir_Click(sender As System.Object, e As System.EventArgs) Handles tsSalir.Click
        Me.Close()
    End Sub

    Private Sub dgvOcupados_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvOcupados.CellDoubleClick, tsFinalizar.Click
        Try
            Dim sp As New spempleados_formatosEnvasados
            Dim dbo As DBO_empleados_formatosEnvasados = sp.Select_Record(Convert.ToInt32(Me.dgvOcupados.CurrentRow.Cells("Id").Value), dtb)
            Dim frm As New frmEntempleados_formatosEnvasados(BasesParaCompatibilidad.GridSimpleForm.ACCION_MODIFICAR, New spempleados_formatosEnvasados, dbo)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
            cargar()
        Catch ex As Exception

        End Try
    End Sub

    


  
End Class