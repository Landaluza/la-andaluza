Public Class frmAccesoRemoto
    Private Sub conectar()
        If rdp.Connected.ToString() = "0" Then
            Try
                'mm0121
                rdp.Server = "80.38.182.11"
                rdp.Domain = ""
                rdp.UserName = "vinagreria.andaluza"
                Dim secured As MSTSCLib.IMsTscNonScriptable = DirectCast(rdp.GetOcx(), MSTSCLib.IMsTscNonScriptable)
                secured.ClearTextPassword = ""
                rdp.Connect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub desconectar()
        If rdp.Connected.ToString() = "1" Then
            rdp.Disconnect()
        End If
    End Sub

    Private Sub frmAccesoRemoto_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        conectar()
    End Sub

    Private Sub frmAccesoRemoto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        desconectar()
    End Sub
End Class