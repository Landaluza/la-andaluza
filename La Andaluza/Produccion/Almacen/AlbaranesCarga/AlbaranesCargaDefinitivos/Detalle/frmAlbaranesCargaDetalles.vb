Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlbaranesCargaDetalles
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlAlb As ctlAlbaranesCargaDetalles
    Private dtsAlb As dtsAlbaranesCargaDetalles.AlbaranesCargaDetallesDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()
        ctlAlb = New ctlAlbaranesCargaDetalles
        dtsAlb = New dtsAlbaranesCargaDetalles.AlbaranesCargaDetallesDataTable
    End Sub
    Protected Overrides Sub cargar_datos()
        ctlAlb.mostrarTodosAlbaranesCargaDetalles(dtsAlb)
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataMember = "AlbaranesCargaDetalles"
        GeneralBindingSource.DataSource = dtsAlb
        dgvGeneral.DataSource = GeneralBindingSource
        dgvGeneral.ReadOnly = True

        With dgvGeneral
            .Height = 562
            .Columns("AlbaranCargaDetalleID").Visible = True
            .FormatoColumna("AlbaranCargaMaestroID", "Num", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 1)
            .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.QS, , 2)
            .FormatoColumna("CodigoQS", "CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, , 3)
            .FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Referencia, , 4)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 5)
            .FormatoColumna("UnidadMedida", "UM", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 6)
            .FormatoColumna("Lote", "Lote", BasesParaCompatibilidad.TiposColumna.Juliano, , 7)
            .FormatoColumna("TipoPalet", "Palet", BasesParaCompatibilidad.TiposColumna.Derecha, 40, 8)
            .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 290, 9)
            .Columns("Reserva1").Visible = False
            .Columns("Reserva2").Visible = False
            .Columns("Reserva3").Visible = False
            .FormatoGeneral()
        End With
    End Sub

#Region "Sobrecargas BindingNavigator"
    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntAlbaranesCargaDetalles
        FrmEnt.Text = ACCION_INSERTAR & " AlbaranesCargaDetalles"
        FrmEnt.CargarDatos(0, 0, 0, 0, 0, "", 0, "", "", "", "", "", "", "")
        FrmEnt.ShowDialog()
        ctlAlb.mostrarTodosAlbaranesCargaDetalles(dtsAlb)
        GeneralBindingSource.Position = 1
        GeneralBindingSource.Position = 0
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaDetalles
            FrmEnt.Text = ACCION_MODIFICAR & " AlbaranesCargaDetalles"
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
            ctlAlb.mostrarTodosAlbaranesCargaDetalles(dtsAlb)
            GeneralBindingSource.Position = 1
            GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("Seleccionar alguna celda", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaDetalles
            FrmEnt.Text = ACCION_VER & " AlbaranesCargaDetalles"
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
                ctlAlb.SetAlbaranCargaDetalleID(dgvGeneral.Rows(Posicion).Cells(0).Value)
                ctlAlb.EliminarAlbaranCargaDetalle()
                ctlAlb.mostrarTodosAlbaranesCargaDetalles(dtsAlb)
                If Posicion > 0 Then
                    GeneralBindingSource.Position = Posicion - 1
                Else
                    GeneralBindingSource.Position = 0
                End If
            End If
        Else
            MessageBox.Show("Seleccionar alguna celda")
        End If
    End Sub
#End Region

End Class
