Public Class frmModificarHora

    Public ReadOnly Property Hora As TimeSpan
        Get
            Return New TimeSpan(Me.dtpHora.Value.Hour, Me.dtpHora.Value.Minute, Me.dtpHora.Value.Second)
        End Get
    End Property

    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub
End Class