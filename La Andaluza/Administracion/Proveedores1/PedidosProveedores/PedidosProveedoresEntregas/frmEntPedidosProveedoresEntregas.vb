Imports BasesParaCompatibilidad.dtpExtension

Public Class frmEntPedidosProveedoresEntregas
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    'Private m_Tabla As DataTable
    Private m_Pos As Integer
    'Private m_PedidoProveedorEntregaID As Int32
    Private DBO_PedidoProveedorEntrega As DBO_PedidosProveedoresEntregas
    Private spPedidosProveedoresEntregas As spPedidosProveedoresEntregas
    Private dtb as BasesParaCompatibilidad.Database

    Public Sub New(ByVal PedidoProveedorEntrega As DBO_PedidosProveedoresEntregas, ByVal Pos As Integer)
        InitializeComponent()
        DBO_PedidoProveedorEntrega = PedidoProveedorEntrega
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        m_Pos = Pos
        spPedidosProveedoresEntregas = New spPedidosProveedoresEntregas
        Me.txtFecha.activarFoco()
    End Sub

    Private Sub frmEntPedidosProveedoresEntregas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Me.Text.Substring(0, 3) = "Ver" Then
            GeneralBindingSource.DataSource = dtb.Consultar("PedidosProveedoresEntregasSelectAll", True)
            GeneralBindingSource.Position = m_Pos
        End If

        SetValores()

        'Aqui oculto el boton Grabar para que la opcion ver no lo permita
        ModificarBindingNavigator()
    End Sub

    Overrides Sub MoveRecord(ByVal Move As String)
        Select Case Move
            Case Is = "First"
                m_Pos = 0
            Case Is = "Previous"
                m_Pos = m_Pos - 1
            Case Is = "Next"
                m_Pos = m_Pos + 1
            Case Is = "Last"
                m_Pos = GeneralBindingSource.Count - 1
        End Select
        GeneralBindingSource.Position = m_Pos
        DBO_PedidoProveedorEntrega = spPedidosProveedoresEntregas.Select_Record(GeneralBindingSource(m_Pos).Item("PedidoProveedorEntregaID"))
        SetValores()
    End Sub

    Overrides Sub Guardar()
        GetValores()
        If Me.Text.Substring(0, 3) = "Ins" Then
            spPedidosProveedoresEntregas.InsertPedidosProveedoresEntregas(DBO_PedidoProveedorEntrega)
        Else
            spPedidosProveedoresEntregas.UpdatePedidosProveedoresEntregas(DBO_PedidoProveedorEntrega)
        End If
        Me.Close()
    End Sub

    Public Overrides Sub SetValores()
        txtPedidoProveedorEntregaID.Text = DBO_PedidoProveedorEntrega.PedidoProveedorEntregaID
        txtPedidoProveedorDetalleID.Text = DBO_PedidoProveedorEntrega.PedidoProveedorDetalleID
        txtFecha.Text = DBO_PedidoProveedorEntrega.Fecha
        txtCantidad.Text = DBO_PedidoProveedorEntrega.Cantidad
        txtObservaciones.Text = if(DBO_PedidoProveedorEntrega.Observaciones_IsDBNull = True, Nothing, DBO_PedidoProveedorEntrega.Observaciones)
        txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Text = DBO_PedidoProveedorEntrega.PedidosProveedoresDetalle_PedidoProveedorDetalleID
    End Sub

    Private Sub GetValores()
        DBO_PedidoProveedorEntrega.PedidoProveedorDetalleID = System.Convert.ToInt32(txtPedidoProveedorDetalleID.Text)
        DBO_PedidoProveedorEntrega.Fecha = System.Convert.ToDateTime(txtFecha.Text)
        DBO_PedidoProveedorEntrega.Cantidad = System.Convert.ToDouble(txtCantidad.Text)
        DBO_PedidoProveedorEntrega.Observaciones = System.Convert.ToString(if(txtObservaciones.Text = "", Nothing, txtObservaciones.Text))
        DBO_PedidoProveedorEntrega.Observaciones_IsDBNull = if(txtObservaciones.Text = "", True, False)
        'DBO_PedidoProveedorEntrega.PedidosProveedoresDetalle_PedidoProveedorDetalleID = System.Convert.ToInt32(txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Text)
        'El valor debe corresponder a un registro existente en la tabla relacionada, en este caso PedidosProveedoresDetalle
        DBO_PedidoProveedorEntrega.PedidosProveedoresDetalle_PedidoProveedorDetalleID = System.Convert.ToInt32(txtPedidoProveedorDetalleID.Text)
    End Sub

End Class
