Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmControlIncidencias_Origen
    Inherits Windows.Forms.Form
    Implements BasesParaCompatibilidad.Queriable
    Private spControlIncidencias_Origen As spControlIncidencias_Origen
    Private m_maestroid As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal MaestroID As Integer)
        MyBase.New()
        InitializeComponent()
        spControlIncidencias_Origen = New spControlIncidencias_Origen(MaestroID)
        m_maestroid = MaestroID
        dtb = New BasesParaCompatibilidad.DataBase()
    End Sub

    Private Sub frmControlIncidencias_Clientes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim filterManager As New DgvFilterPopup.DgvFilterManager(dgvGrilla)
    End Sub





    Protected Sub dgvFill() Implements BasesParaCompatibilidad.Queriable.dataGridViewFill
        dtb.PrepararConsulta(Me.spControlIncidencias_Origen.DataGridViewStoredProcedure)
        Dim dt As DataTable = dtb.Consultar()

        If Not dt Is Nothing Then
            If dt.Rows.Count > 0 Then
                Me.dgvGrilla.DataSource = dt
                With dgvGrilla
                    .Columns("Id").Visible = False
                    .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                    .FormatoColumna("Tipo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                End With
            End If
        End If

    End Sub

    Private Sub btnAñadir_Click(sender As System.Object, e As System.EventArgs) Handles btnAñadir.Click
        Dim frm As New frmEntControlIncidencias_origen(Me.m_maestroid)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        dgvFill()
    End Sub

    Private Sub btnEliminar_Click(sender As System.Object, e As System.EventArgs) Handles btnEliminar.Click
        If dgvGrilla.SelectedRows.Item(0).Cells("Tipo").Value = "Cliente" Then
            Dim sp As New spControlIncidencias_Clientes()
            sp.Delete(dgvGrilla.SelectedRows.Item(0).Cells("Id").Value, dtb)
        Else
            If dgvGrilla.SelectedRows.Item(0).Cells("Tipo").Value = "Empleado" Then
                Dim sp As New spControlIncidencias_Empleados()
                sp.Delete(dgvGrilla.SelectedRows.Item(0).Cells("Id").Value, dtb)
            Else
                If dgvGrilla.SelectedRows.Item(0).Cells("Tipo").Value = "Proveedor" Then
                    Dim sp As New spControlIncidencias_Proveedores()
                    sp.Delete(dgvGrilla.SelectedRows.Item(0).Cells("Id").Value, dtb)
                End If
            End If
        End If

        dgvFill()
    End Sub

    Private Sub frmControlIncidencias_Origen_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        Me.dgvFill()
    End Sub
End Class
