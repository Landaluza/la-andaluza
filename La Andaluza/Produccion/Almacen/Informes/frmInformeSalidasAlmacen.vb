Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmInformeSalidasAlmacen
    Private sp As spInformeSalidasAlmacen

    Public Sub New()
        InitializeComponent()

        sp = New spInformeSalidasAlmacen

        Dim spTipoProducto As New spTiposProductos
        spTipoProducto.cargar_ComboBox(Me.cboProducto)

        dtpFin.activarFoco()
        dtpInicio.activarFoco()
        Me.dtpFin.Value = Now.Date
        Me.dtpInicio.Value = New Date(Now.Date.Year, Now.Date.Month, 1)
    End Sub

    Private Sub frmInformeSalidasAlmacen_Resize(sender As System.Object, e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.panFiltros, Me.Panel1)
    End Sub

    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvFill()
    End Sub

    Private Sub dgvFill()
        Dim dt As DataTable = sp.listar_palets_por_producto_entre_fechas(Me.cboProducto.SelectedValue, Me.dtpInicio.Value, Me.dtpFin.Value)
        If Not dt Is Nothing Then
            Me.DataGridView1.DataSource = dt

            Me.DataGridView1.FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
            Me.DataGridView1.FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, True)
        End If


    End Sub
End Class