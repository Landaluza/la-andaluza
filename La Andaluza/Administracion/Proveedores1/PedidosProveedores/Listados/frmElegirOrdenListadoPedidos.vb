Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class frmElegirOrdenListadoPedidos
    Private Orden As Integer
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
    End Sub
    Private Sub frmElegirOrdenListadoPedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim dt As DataTable = dtb.Consultar("SELECT DISTINCT proveedores.proveedorid, Proveedores.Nombre  FROM  PedidosProveedoresMaestros INNER JOIN Proveedores  ON  PedidosProveedoresMaestros.ProveedorID = Proveedores.ProveedorID INNER JOIN PedidosProveedoresEstados  ON  PedidosProveedoresMaestros.EstadoID = PedidosProveedoresEstados.PedidoProveedorEstadoID  WHERE PedidosProveedoresMaestros.EstadoID <> 5 And PedidosProveedoresMaestros.EstadoID <> 6 ORDER BY  Proveedores.Nombre", False)
        cboProveedores.mam_DataSource(dt, False)
    End Sub

    Public ReadOnly Property Seleccion As Integer
        Get
            Return Orden
        End Get
    End Property

    Public ReadOnly Property Proveedor As Integer
        Get
            Return Me.cboProveedores.SelectedValue
        End Get
    End Property

    Public ReadOnly Property Fecha As String
        Get
            'Return dtpFecha.Value.Year & If(dtpFecha.Value.Month < 10, "0" & dtpFecha.Value.Month, Convert.ToString(dtpFecha.Value.Month)) & If(dtpFecha.Value.Day < 10, "0" & dtpFecha.Value.Day, Convert.ToString(dtpFecha.Value.Day))
            Return dtpFecha.Value.Date
        End Get
    End Property

    Private Sub butByNumero_Click(sender As Object, e As EventArgs) Handles butByNumero.Click
        Orden = 1
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butByProveedor_Click(sender As Object, e As EventArgs) Handles butByProveedor.Click
        Orden = 2
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butByFecha_Click(sender As Object, e As EventArgs) Handles butByFecha.Click
        Orden = 3
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butDia_Click(sender As Object, e As EventArgs) Handles butDia.Click
        Orden = 4
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butProveedor_Click(sender As Object, e As EventArgs) Handles butProveedor.Click
        Orden = 5
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub butEntregaIncumplida_Click(sender As Object, e As EventArgs) Handles butEntregaIncumplida.Click
        Orden = 6
        Me.DialogResult = Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    'Private Sub EnvironmentSettings1_DatabaseLogin(sender As Object, e As FastReport.DatabaseLoginEventArgs)
    '    ''e.ConnectionString = "Data Source=JAYMIN-PC\SQLEXPRESS;Initial Catalog=PMData;Integrated Security=SSPI;"
    '    e.ConnectionString = BD.Cnx.ConnectionString
    'End Sub

End Class