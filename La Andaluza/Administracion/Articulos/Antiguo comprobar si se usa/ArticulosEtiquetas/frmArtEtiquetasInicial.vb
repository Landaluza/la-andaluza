Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class frmArtEtiquetasInicial

    Private Sub frmArtEtiquetasInicial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboEtiquetasTipos.mam_DataSource("ArticulosEtiquetasTiposCbo", False)
    End Sub
End Class