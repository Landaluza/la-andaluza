Public Class frmDevolucionCarga

    Private _SCC As String

    Sub New(ByVal scc As String)
        InitializeComponent()

        _SCC = scc
    End Sub

    Private Function guardar() As Boolean
        Dim sp As New spAlbaranesCarga
        Return sp.devolverPalet(Me._SCC)
        'If Me.rbSacar.Checked Then
        ''Return sp.spDeleteAlbaranCargaDetalle(Me._SCC)
        'Else
        'Return sp.devolverPalet(Me._SCC)
        'End If
    End Function

    Private Sub btnAceptar_Click(sender As System.Object, e As System.EventArgs) Handles btnAceptar.Click
        If Guardar() Then
            Me.DialogResult = Windows.Forms.DialogResult.OK
            Me.Close()
        Else
            messagebox.show("No se pudo completar la operacion", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As System.Object, e As System.EventArgs) Handles btnCancelar.Click
        Me.DialogResult = Windows.Forms.DialogResult.Abort
        Me.Close()
    End Sub
End Class