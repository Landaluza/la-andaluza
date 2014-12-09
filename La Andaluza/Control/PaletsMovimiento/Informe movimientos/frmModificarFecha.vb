Public Class frmModificarFecha
    Public ReadOnly Property Fecha As Date
        Get
            Return Me.dtpHora.Value
        End Get
    End Property

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class