Public Class frmNumeroAlbaran
    Private num As Integer

    Public ReadOnly Property Numero As Integer
        Get
            Return Me.num
        End Get
    End Property
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        If txtNumero.Text <> "" Then
            If IsNumeric(txtNumero) Then
                Me.num = txtNumero.Text
                Me.DialogResult = Windows.Forms.DialogResult.OK
                Me.Hide()
            End If
        End If
    End Sub
End Class