Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosGranelescompuestoPor
    Private spArticulosGranelesCompuestoPor As spArticulosGranelesCompuestoPor
    Private articuloId As Integer
    Public Event actualizarDatos()
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New(ByVal articuloid As Integer)

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase()
        spArticulosGranelesCompuestoPor = New spArticulosGranelesCompuestoPor
        Me.articuloId = articuloid
    End Sub

    Private Sub frmArticulos1CompuestoPor_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        DgvFill()
    End Sub

    Private Sub DgvFill()
        Me.DataGridView1.DataSource = Me.spArticulosGranelesCompuestoPor.DataTableFill(Me.articuloId, dtb)

        If Not Me.DataGridView1.DataSource Is Nothing Then
            DataGridView1.Columns("articuloid").Visible = False
            DataGridView1.Columns("id_fase").Visible = False
            DataGridView1.Columns("costeUnitario").Visible = False
            DataGridView1.Columns("subtotal").Visible = False
            DataGridView1.FormatoColumna("descripcionLa", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            DataGridView1.FormatoColumna("cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
        End If
    End Sub

    Private Sub butNuevo_Click(sender As System.Object, e As System.EventArgs) Handles butNuevo.Click
        nuevo()
    End Sub

    Private Sub butModificar_Click(sender As System.Object, e As System.EventArgs) Handles butModificar.Click
        modificar()
    End Sub

    Private Sub butEliminar_Click(sender As System.Object, e As System.EventArgs) Handles butEliminar.Click
        eliminar()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        modificar()
    End Sub

    Private Sub nuevo()
        Dim frm As New frmModGranelesCompuestoPor(Me.articuloId)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        DgvFill()
        RaiseEvent actualizarDatos()
    End Sub

    Private Sub eliminar()
        Try
            If Not Me.DataGridView1.CurrentRow Is Nothing Then
                Dim mdbo As New DBO_articulosGranelesCompuestoPor
                mdbo.Set_ArticuloPrincipal(Me.articuloId, dtb)
                mdbo.Set_ArticuloComponente(DataGridView1.CurrentRow.Cells("articuloid").Value, dtb)
                mdbo.Fase = DataGridView1.CurrentRow.Cells("id_fase").Value
                spArticulosGranelesCompuestoPor.select_record(mdbo, dtb)

                If Me.spArticulosGranelesCompuestoPor.Eliminar(mdbo, dtb) Then
                    RaiseEvent actualizarDatos()
                    DgvFill()
                Else
                    MessageBox.Show("Ocurrio un error al eliminar", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub modificar()
        If Not Me.DataGridView1.CurrentRow Is Nothing Then
            Dim frm As New frmModGranelesCompuestoPor(Me.articuloId, DataGridView1.CurrentRow.Cells("articuloid").Value, DataGridView1.CurrentRow.Cells("id_fase").Value)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
            DgvFill()
        End If
    End Sub
End Class