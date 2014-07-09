Public Class frmExistenciasTodas
    Private frm As frmAlmacenExistencias
    Private frm2 As frmNoConformes

    Public Sub New()
        InitializeComponent()

        frm = New frmAlmacenExistencias
        frm2 = New frmNoConformes
    End Sub

    Private Sub frmExistenciasTodas_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Engine_LA.FormEnPestaña(frm, tbconforme)
        Engine_LA.FormEnPestaña(frm2, tbnoconforme)
    End Sub
End Class