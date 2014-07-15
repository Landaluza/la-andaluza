Public Class frmElegirOrdenListadoPedidos

    Public ReadOnly Property Seleccion As Integer
        Get
            Return Me.ComboBox1.SelectedIndex
        End Get
    End Property

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub
End Class