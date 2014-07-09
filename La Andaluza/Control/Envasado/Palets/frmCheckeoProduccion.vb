Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.dtpExtension
Public Class frmCheckeoProduccion

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        dtpInicio.activarFoco()
        dtpFin.activarFoco()
    End Sub
    Private Sub btnBuscar_Click(sender As System.Object, e As System.EventArgs) Handles btnBuscar.Click
        dgvFill()
    End Sub

    Private Sub dgvFill()
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("exec comparacion_produccion_entradas '" & Me.dtpInicio.Value.ToShortDateString & "', '" & Me.dtpFin.Value.ToShortDateString & "'", False)

        If Not dt Is Nothing Then
            Me.DataGridView1.DataSource = dt
            DataGridView1.FormatoColumna("scc", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
        End If
    End Sub
End Class