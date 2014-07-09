Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlbaranesCargaProviDetalles

    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlAlb As ctlAlbaranesCargaProviDetalles
    Private dtsAlb As dtsAlbaranesCargaProviDetalles.AlbaranesCargaProviDetallesDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlAlb = New ctlAlbaranesCargaProviDetalles
        dtsAlb = New dtsAlbaranesCargaProviDetalles.AlbaranesCargaProviDetallesDataTable
    End Sub
    Protected Overrides Sub cargar_datos()
        ctlAlb.mostrarTodosAlbaranesCargaProviDetalles(dtsAlb)
    End Sub
    Protected Overrides Sub BindDataSource()

        GeneralBindingSource.DataMember = "AlbaranesCargaProviDetalles"
        GeneralBindingSource.DataSource = dtsAlb
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.ReadOnly = True
        '

        With dgvGeneral
            .Columns("AlbaranCargaProviDetalleID").Visible = False
            .FormatoColumna("AlbaranCargaProviMaestroID", "Num", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 0)
            .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.QS, , 1)
            .FormatoColumna("CodigoQS", "CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, , 2)
            .FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Referencia, , 3)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 4)
            .FormatoColumna("UnidadMedidaID", "UM", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 5)
            .FormatoColumna("Lote", "Lote", BasesParaCompatibilidad.TiposColumna.Juliano, , 6)
            .FormatoColumna("TipoPaletID", "Palet", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 7)
            .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 300, 8)
            dgvGeneral.Columns("Reserva1").Visible = False
            dgvGeneral.Columns("Reserva2").Visible = False
            dgvGeneral.Columns("Reserva3").Visible = False
        End With
    End Sub

#Region "Sobrecargas BindingNavigator"

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntAlbaranesCargaProviDetalles
        FrmEnt.Text = ACCION_INSERTAR & " AlbaranesCargaProviDetalles"
        FrmEnt.CargarDatos(0, 0, 0, 0, 0, "", 0, 0, "", 0, "", "", "", "")
        FrmEnt.ShowDialog()
        ctlAlb.mostrarTodosAlbaranesCargaProviDetalles(dtsAlb)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaProviDetalles
            FrmEnt.Text = ACCION_MODIFICAR & " AlbaranesCargaProviDetalles"
            FrmEnt.CargarDatos(Posicion, _
                               dgvGeneral.Rows(Posicion).Cells(0).Value, _
                               dgvGeneral.Rows(Posicion).Cells(1).Value, _
                               dgvGeneral.Rows(Posicion).Cells(2).Value, _
                               dgvGeneral.Rows(Posicion).Cells(3).Value, _
                               dgvGeneral.Rows(Posicion).Cells(4).Value, _
                               dgvGeneral.Rows(Posicion).Cells(5).Value, _
                               dgvGeneral.Rows(Posicion).Cells(6).Value, _
                               dgvGeneral.Rows(Posicion).Cells(7).Value, _
                               dgvGeneral.Rows(Posicion).Cells(8).Value, _
                               dgvGeneral.Rows(Posicion).Cells(9).Value, _
                               dgvGeneral.Rows(Posicion).Cells(10).Value, _
                               dgvGeneral.Rows(Posicion).Cells(11).Value, _
                               dgvGeneral.Rows(Posicion).Cells(12).Value)
            FrmEnt.ShowDialog()
            ctlAlb.mostrarTodosAlbaranesCargaProviDetalles(dtsAlb)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaProviDetalles
            FrmEnt.Text = ACCION_VER & " AlbaranesCargaProviDetalles"
            FrmEnt.CargarDatos(Posicion, _
                       dgvGeneral.Rows(Posicion).Cells(0).Value, _
                       dgvGeneral.Rows(Posicion).Cells(1).Value, _
                       dgvGeneral.Rows(Posicion).Cells(2).Value, _
                       dgvGeneral.Rows(Posicion).Cells(3).Value, _
                       dgvGeneral.Rows(Posicion).Cells(4).Value, _
                       dgvGeneral.Rows(Posicion).Cells(5).Value, _
                       dgvGeneral.Rows(Posicion).Cells(6).Value, _
                       dgvGeneral.Rows(Posicion).Cells(7).Value, _
                       dgvGeneral.Rows(Posicion).Cells(8).Value, _
                       dgvGeneral.Rows(Posicion).Cells(9).Value, _
                       dgvGeneral.Rows(Posicion).Cells(10).Value, _
                       dgvGeneral.Rows(Posicion).Cells(11).Value, _
                       dgvGeneral.Rows(Posicion).Cells(12).Value)
            FrmEnt.ShowDialog()
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Eliminar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim response As DialogResult
            response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlAlb.SetAlbaranCargaProviDetalleID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                ctlAlb.EliminarAlbaranCargaProviDetalle()
                ctlAlb.mostrarTodosAlbaranesCargaProviDetalles(dtsAlb)
                If Posicion > 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub
#End Region


End Class
