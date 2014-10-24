Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmIncidenciasRecuento
    Private sp As spIncidenciasRecuento
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()

        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.sp = New spIncidenciasRecuento
    End Sub
    Private Sub frmIncidenciasRecuento_Resize(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        BasesParaCompatibilidad.Pantalla.centerHorizontalyIn(Me.Panel3, Me.Panel1)
    End Sub


    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        dgvFill()
    End Sub

    Private Sub dgvFill()

        Dim dt As DataTable = sp.SelectByFecha(Me.dtpInicio.Value, Me.dtpFin.Value, dtb)
        If Not dt Is Nothing Then
            Me.dgvIncidencias.DataSource = dt

            With dgvIncidencias
                .FormatoColumna("scc", "SSCC", BasesParaCompatibilidad.TiposColumna.Izquierda)
                .FormatoColumna("Descripcion", "Producto", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
                .FormatoColumna("CajasIniciales", "Cajas originales", BasesParaCompatibilidad.TiposColumna.Izquierda)
                .FormatoColumna("CajasFinales", "Cajas modificadas", BasesParaCompatibilidad.TiposColumna.Izquierda)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Descripcion, True)
            End With
        End If
    End Sub

    Private Sub frmIncidenciasRecuento_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.dtpInicio.Value = New Date(dtpFin.Value.Year, dtpFin.Value.Month, dtpFin.Value.Day, 7, 0, 0)
        Dim filterManager As New DgvFilterPopup.DgvFilterManager(dgvIncidencias)
    End Sub
End Class