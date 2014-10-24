Public Class frmCabiarCantidad
    Private loteId As Integer
    Private spLotes1 As spLotes1
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal m_loteId As Integer)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        spLotes1 = New spLotes1
        Me.loteId = m_loteId
    End Sub

    Private Sub btnCantidad_Click(sender As System.Object, e As System.EventArgs) Handles btnCantidad.Click
        If Me.txtCantidad.Text <> "" And IsNumeric(txtCantidad.Text) Then
            Try
                If spLotes1.ActualizarCantidad(loteId, Me.txtCantidad.Text, dtb) Then
                    Me.DialogResult = Windows.Forms.DialogResult.OK
                    Me.Close()
                Else
                    MessageBox.Show("No se pudo realizar la operación. Vuelva a intentarlo en unos segundos.", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            Catch ex As Exception
                messagebox.show("No se pudo realizar la operación. Detalles:" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        Else
            messagebox.show("Introduzca una cantidad correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
End Class