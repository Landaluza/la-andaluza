Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosProveedoresDetalles
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Public Proveedor As Integer
    Private frmEnt As frmEntPedidosProveedoresDetalles
    Public Sub New()
        MyBase.New(New spPedidosProveedoresDetalles, 0)
        InitializeComponent()

        spSelectDgv = "PedidosProveedoresDetallesSelectDgv"
    End Sub
    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta(spSelectDgv)
        dataSource = dtb.Consultar()
    End Sub

    Protected Overrides Sub BindDataSource()
        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .FormatoColumna("PedidoProveedorDetalleID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 0)
                .FormatoColumna("PedidoProveedorMaestroID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoColumna("ArticuloID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 2)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 50, 3)
                .FormatoColumna("FechaServicio", BasesParaCompatibilidad.TiposColumna.Derecha, 50, 4)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 5)
                .FormatoColumna("EstadoID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 6)
                .FormatoColumna("PedidosProveedoresMaestro_PedidoProveedorMaestroID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 7)
                .FormatoColumna("MedidaProductoID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 8)
            End With
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPedidosProveedoresDetalles).DeletePedidosProveedoresDetalles(dgvGeneral.CurrentRow.Cells("PedidoProveedorDetalleID").Value, dtb) Then
                dgvFill()
            End If
            'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
        End If
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)

        Dim DBO_PedidoProveedorDetalle As New DBO_PedidosProveedoresDetalles
        Dim m_Pos As Integer = GeneralBindingSource.Position

        If TipoAction = ACCION_INSERTAR Then
            'Asignar las propiedades del objeto creado cuyos valores se obtengan en este Form.
        Else
            Dim dtb As New BasesParaCompatibilidad.DataBase
            DBO_PedidoProveedorDetalle = CType(sp, spPedidosProveedoresDetalles).Select_Record(GeneralBindingSource(m_Pos).Item("PedidoProveedorDetalleID"), dtb)
        End If

        frmEnt = New frmEntPedidosProveedoresDetalles(DBO_PedidoProveedorDetalle, m_Pos)
        frmEnt.Proveedor = Me.Proveedor
        frmEnt.Text = String.Format("{0} {1}", TipoAction, Me.Text)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)

        dgvFill()
    End Sub



End Class
