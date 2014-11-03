Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPaletsAlmacenEntradas
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private entradas As Boolean
    Public Sub New(ByVal Entradas As Boolean)
        MyBase.New(New spPaletsAlmacenEntradas, If(Entradas, 0, 1))
        InitializeComponent()

        Me.entradas = Entradas
        If Entradas Then
            spSelectDgv = "PaletsAlmacenEntradasSelectByCajas 0"
        Else
            spSelectDgv = "PaletsAlmacenEntradasSelectByCajas 1"
        End If

    End Sub

    Private Sub frmPaletsAlmacenEntradas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        butExcel.Visible = True
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar(spSelectDgv, True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource

            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("PaletAlmacenEntradaID").Visible = False
                .Columns("Vigente").Visible = False

                .FormatoColumna("SSCC", BasesParaCompatibilidad.TiposColumna.Izquierda, 50)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 72)
                .FormatoColumna("Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, 300)
                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("ComentariosCarga", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            End With

            dgvGeneral.FormatoGeneral()
            BindingNavigatorActualizar(dgvGeneral.RowCount)
            butNuevo.Visible = False
            butModificar.Visible = False
            butVer.Visible = False
            If Not entradas Then butEliminar.Visible = False
            butSalir.Visible = False
        End If
    End Sub


    Public Overrides Sub Eliminar()
        If Not Me.dgvGeneral.CurrentRow Is Nothing Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPaletsAlmacenEntradas).PaletsAlmacenEntradasDelete(dgvGeneral.CurrentRow.Cells("PaletAlmacenEntradaID").Value, dtb) Then
                dgvFill()
            Else
                MessageBox.Show("No se pudo eliminar el registro", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

End Class
