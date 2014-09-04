Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmContenidosDetallesMonodosis2
    Inherits Form

    Public id As Integer
    Private tipoFormato As Integer

    Public Sub New(ByVal tipoformato As Integer)

        InitializeComponent()

        Me.tipoFormato = tipoformato
    End Sub

    Private Sub dgvGrilla_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellDoubleClick
        Me.id = Me.dgvGrilla.CurrentRow.Cells("paletproducidoID").Value
        Me.Close()
    End Sub

    Private Sub frmContenidosDetallesMonodosis_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("PaletsContenidosSelectMonodosis @tipo")
        dtb.AñadirParametroConsulta("@tipo", tipoFormato)
        Dim dt As DataTable = dtb.Consultar()

        Me.dgvGrilla.DataSource = dt

        Me.dgvGrilla.Columns("paletproducidoID").Visible = False
        Me.dgvGrilla.FormatoColumna("descripcion", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        Me.dgvGrilla.FormatoColumna("fecha", "Fecha envasado", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
    End Sub
End Class
