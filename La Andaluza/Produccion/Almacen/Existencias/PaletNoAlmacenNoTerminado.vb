Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class PaletNoAlmacenNoTerminado
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Public Sub New()
        MyBase.New()
        InitializeComponent()
    End Sub

    Private Sub PaletNoAlmacenNoTerminado_Load(sender As Object, e As System.EventArgs) Handles Me.Load

        butExcel.Visible = True
        butWord.Visible = False
        butGuardar.Visible = False
        butEliminar.Visible = False
        butNuevo.Visible = False

        ''BindingNavigatorActualizar(dgvGeneral.RowCount)
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dataSource = dtb.Consultar("PaletsContenidosNoAlmacenNoTerminado ", True)
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            With dgvGeneral
                .DataSource = dataSource
                .FormatoColumna("SCC", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Cajas", BasesParaCompatibilidad.TiposColumna.Miles)
                .FormatoColumna("Descripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoGeneral(True)
            End With
        End If

        Me.butEliminar.Enabled = False
        Me.butModificar.Enabled = False
        Me.butNuevo.Enabled = False
    End Sub
End Class
