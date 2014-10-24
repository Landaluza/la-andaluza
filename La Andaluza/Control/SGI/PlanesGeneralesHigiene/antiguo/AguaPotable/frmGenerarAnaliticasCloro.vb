Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmGenerarAnaliticasCloro
    Private ValorMinimo As Double 'Valor minimo del valor de cloro analizado
    Private ValorMaximo As Double 'Valor maximo del valor de cloro analizado
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()

        ' Llamada necesaria para el diseñador.
        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase()
    End Sub
    Private Sub frmGenerarAnaliticasCloro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cboAnalista.mam_DataSource("EmpleadosSelectCbo", False, dtb)
        cboVerificador.mam_DataSource("EmpleadosSelectCbo", False, dtb)

        With dgv
            .DataSource = dtb.Consultar("AguaPotablePuntosMuestreosSelectDgv", True)
            .Columns("Id").Visible = False
            .FormatoColumna("Referencia", BasesParaCompatibilidad.TiposColumna.Izquierda, 80)
            .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            .FormatoColumna("Responsable", BasesParaCompatibilidad.TiposColumna.Izquierda, 180)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
            .FormatoGeneral()
        End With

        dtpFecha.activarFoco()
    End Sub

    Private Sub butGenerar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butGenerar.Click
        MessageBox.Show("No implementado", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'Generar registros con los datos del form, uno por cada row seleecionado del dgv. 
        'El valor de cloro debe generarse aleatoriamente tomando valores entre ValorMinimo y ValorMaximo.
    End Sub

    Private Sub butCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCancelar.Click
        Me.Close()
    End Sub
End Class