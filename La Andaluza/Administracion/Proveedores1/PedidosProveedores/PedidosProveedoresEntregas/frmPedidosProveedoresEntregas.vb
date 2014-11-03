Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPedidosProveedoresEntregas
    Inherits BasesParaCompatibilidad.FrmAheredarOld


    Public Sub New()

        MyBase.New(New spPedidosProveedoresEntregas, 0)
        InitializeComponent()

        spSelectDgv = "PedidosProveedoresEntregasSelectDgv"
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
                .FormatoColumna("PedidoProveedorEntregaID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 0)
                .FormatoColumna("PedidoProveedorDetalleID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 1)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.Derecha, 50, 2)
                .FormatoColumna("Cantidad", BasesParaCompatibilidad.TiposColumna.Double2, 50, 3)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, 200, 4)
                .FormatoColumna("PedidosProveedoresDetalle_PedidoProveedorDetalleID", BasesParaCompatibilidad.TiposColumna.Miles, 50, 5)
                '   .FormatoGeneral()
            End With
        End If
    End Sub


    'Overrides Sub Insertar()
    '    Action(ACCION_INSERTAR)
    'End Sub

    'Overrides Sub Modificar()
    '    Action(ACCION_MODIFICAR)
    '    GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
    'End Sub

    'Overrides Sub Ver()
    '    Action(ACCION_VER)
    'End Sub

    Overrides Sub Eliminar()
        Dim response As DialogResult
        response = MessageBox.Show(" ¿Realmente quieres eliminar este registro ? ", _
                          "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If response = DialogResult.Yes Then
            Dim dtb As New BasesParaCompatibilidad.DataBase
            If CType(sp, spPedidosProveedoresEntregas).DeletePedidosProveedoresEntregas(dgvGeneral.CurrentRow.Cells("PedidoProveedorEntregaID").Value, dtb) Then
                dgvFill()
            End If
            'GeneralBindingSource. dataSource = dtb.Consultar(spSelectDgv)
        End If
    End Sub

    Public Overrides Sub Action(ByVal TipoAction As String)
        'Dim m_Pos As Integer = GeneralBindingSource.Position
        'Dim m_PedidoProveedorEntregaID As Int32
        'If TipoAction <> ACCION_INSERTAR Then
        '    m_PedidoProveedorEntregaID = dgvGeneral.CurrentRow.Cells("PedidoProveedorEntregaID").Value
        'End If
        'Dim frmEnt As New frmEntPedidosProveedoresEntregas(m_PedidoProveedorEntregaID, m_Pos)
        'If TipoAction = ACCION_MODIFICAR Then
        '    frmEnt.Text = String.Format("Modificar {0}", Titulo)
        'ElseIf TipoAction = ACCION_VER Then
        '    frmEnt.Text = String.Format("Ver {0}", Titulo)
        'Else
        '    frmEnt.Text = String.Format("Insertar {0}", Titulo)
        'End If
        'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
    End Sub


End Class
