Public Class frmDetallesArtOrdEnv

    Private Sub btnAmpliarEnvase_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAmpliarEnvase.Click
        Dim frm As New frmAmpliarEnvase
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
    End Sub
End Class