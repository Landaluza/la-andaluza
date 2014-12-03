Public Class frmDatosExtraCamion
    Public TipoCamion As Integer
    Private spTipos As spCamionesTipos
    Public Sub New()
        InitializeComponent()
        TipoCamion = 0
        spTipos = New spCamionesTipos

        spTipos.cargar_CamionesTipos(Me.cboTipoCamion, New BasesParaCompatibilidad.DataBase)
    End Sub
    Private Sub btnAceptar_Click(sender As Object, e As EventArgs) Handles btnAceptar.Click
        TipoCamion = Me.cboTipoCamion.SelectedValue
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Hide()
    End Sub

    Private Sub btnAddTipoCamion_Click(sender As Object, e As EventArgs) Handles btnAddTipoCamion.Click
        Dim frm As New frmEntCamionesTipos()
        frm.ShowDialog()
        spTipos.cargar_CamionesTipos(Me.cboTipoCamion, New BasesParaCompatibilidad.DataBase)
    End Sub
End Class