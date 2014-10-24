Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmelaboraciones_fases
    Inherits Windows.Forms.Form


    Private idGranel As Integer
    Private spelaboraciones_fases As spelaboraciones_fases
    Private dboelaboraciones_fases As DBO_elaboraciones_fases
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New(ByVal MaestroID As Integer)
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()
        Me.idGranel = MaestroID
        Me.spelaboraciones_fases = New spelaboraciones_fases
        Me.dboelaboraciones_fases = New DBO_elaboraciones_fases
    End Sub

    Private Sub frmelaboraciones_fases_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filterManager As New DgvFilterPopup.DgvFilterManager(dgvGrilla)
        dgvFill()
    End Sub

    Private Sub Insertar()
        Dim frm As New frmEntelaboraciones_fases(BasesParaCompatibilidad.DetailedSimpleForm.INSERCION, Me.idGranel)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        dgvFill()
    End Sub

    Private Sub modificar()
        Dim frm As New frmEntelaboraciones_fases(BasesParaCompatibilidad.DetailedSimpleForm.MODIFICACION, Me.idGranel, Me.dgvGrilla.CurrentRow.Cells("id").Value)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        dgvFill()
    End Sub

    Private Sub eliminar()
        Me.spelaboraciones_fases.Delete(Me.dgvGrilla.CurrentRow.Cells("id").Value, dtb)
        dgvFill()
    End Sub

    Protected Sub dgvFill(Optional ByVal Repaint As Boolean = True)
        Dim dt As DataTable = Me.spelaboraciones_fases.select_DgvBy(Me.idGranel, dtb)

        If Not dt Is Nothing Then
            If Repaint Then
                With dgvGrilla
                    .DataSource = dt
                    .Columns("id").Visible = False
                    .Columns("GranelID").Visible = False
                    .FormatoColumna("descripcionla", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True, 0, 50)
                    .FormatoColumna("fase", "Fase", BasesParaCompatibilidad.TiposColumna.Izquierda, 50)
                    .FormatoGeneral()
                End With
            End If
        End If
    End Sub

    Private Sub tsInsertar_Click(sender As System.Object, e As System.EventArgs) Handles tsInsertar.Click
        Me.Insertar()
    End Sub

    Private Sub tsModificar_Click(sender As System.Object, e As System.EventArgs) Handles tsModificar.Click
        Me.modificar()
    End Sub

    Private Sub tsEliminar_Click(sender As System.Object, e As System.EventArgs) Handles tsEliminar.Click
        Me.eliminar()
    End Sub

    Private Sub dgvGrilla_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dgvGrilla.CellDoubleClick
        Me.modificar()
    End Sub
End Class
