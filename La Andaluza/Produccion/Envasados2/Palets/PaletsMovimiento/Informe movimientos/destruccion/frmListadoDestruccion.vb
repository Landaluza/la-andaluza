Imports BasesParaCompatibilidad.dtpExtension
Public Class frmListadoDestruccion
    Private sp As spListadoDestruccion
    Public Sub New()

        InitializeComponent()

        sp = New spListadoDestruccion
        tpfFinal.activarFoco()
        tpfFinal.activarFoco()
    End Sub



    Private Sub cboArticulo_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboArticulo.SelectedValueChanged
        Try
            Me.sp.articulo = Me.cboArticulo.SelectedValue
            Me.cbArticulo.Checked = True
            sp.dgvFill(Me.dgvListado)
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cboMovimiento_SelectedValueChanged(sender As System.Object, e As System.EventArgs) Handles cboMovimiento.SelectedValueChanged
        Try
            Me.sp.tipo_movimiento = Me.cboMovimiento.SelectedValue
            Me.cbMovimiento.Checked = True
            sp.dgvFill(Me.dgvListado)
        Catch ex As Exception

        End Try
    End Sub



    Private Sub frmListadoDestruccion_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Me.sp.cargar_cbo_articulos(Me.cboArticulo)
        Me.sp.cargar_cbo_tiposMovimientos(Me.cboMovimiento)
    End Sub


    Private Sub tpfInicial_ValueChanged(sender As System.Object, e As System.EventArgs) Handles tpfInicial.ValueChanged
        Me.sp.fecha_inicial = Me.tpfInicial.Value
        Me.cbfInicial.Checked = True
    End Sub

    Private Sub tpfFinal_ValueChanged(sender As System.Object, e As System.EventArgs) Handles tpfFinal.ValueChanged
        Me.sp.fecha_final = Me.tpfFinal.Value
        Me.cbfFinal.Checked = True
    End Sub


    Private Sub cbfInicial_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbfInicial.CheckedChanged
        If Me.cbfInicial.Checked Then
            Me.sp.fecha_inicial = String.Empty
        Else
            Me.sp.fecha_inicial = Me.tpfInicial.Value
        End If

        sp.dgvFill(Me.dgvListado)
    End Sub

    Private Sub cbfFinal_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbfFinal.CheckedChanged
        If Me.cbfFinal.Checked Then
            Me.sp.fecha_final = String.Empty
        Else
            Me.sp.fecha_final = Me.tpfFinal.Value
        End If

        sp.dgvFill(Me.dgvListado)
    End Sub

    Private Sub cbArticulo_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbArticulo.CheckedChanged
        If Me.cbArticulo.Checked Then
            Me.sp.tipo_movimiento = Me.cboMovimiento.SelectedValue
        Else
            Me.sp.articulo = String.Empty
        End If

        Try
            sp.dgvFill(Me.dgvListado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cbMovimiento_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles cbMovimiento.CheckedChanged
        If Me.cbMovimiento.Checked Then
            Me.sp.articulo = Me.cboArticulo.SelectedValue
        Else
            Me.sp.tipo_movimiento = String.Empty
        End If

        Try
            sp.dgvFill(Me.dgvListado)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ImprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ImprimirToolStripMenuItem.Click
        Try
            Dim head(6) As String
            'Fecha,SCC,Cajas, Comentarios,PaletsMovimientoSubTipo.descripcion as Subtipo, tiposformatos.descripcion as Articulo
            head(1) = "Fecha"
            head(2) = "SSCC"
            head(3) = "Cajas"
            head(4) = "Comentarios"
            head(5) = "SubTipo"
            head(6) = "Articulo"
            Dim p As New BasesParaCompatibilidad.Printer
            p.imprimirGrilla(Me.dgvListado, head)
        Catch ex As Exception

        End Try
    End Sub
End Class