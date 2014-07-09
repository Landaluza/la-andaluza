Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlbaranesCargaMaestro
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlAlb As ctlAlbaranesCargaMaestro
    Private dtsAlb As dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable


    Public Sub New()
        MyBase.New()
        InitializeComponent()

        ctlAlb = New ctlAlbaranesCargaMaestro
        dtsAlb = New dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable
    End Sub
    Protected Overrides Sub cargar_datos()
        'ctlAlb.mostrarTodosAlbaranesCargaMaestro(dtsAlb)
        dataSource = dtb.Consultar("select AlbaranesCargaMaestro.AlbaranCargaMaestroID,AlbaranesCargaMaestro.AlbaranCargaProMaestroID,AlbaranesCargaMaestro.Fecha,AlbaranesCargaMaestro.ClienteID,AlbaranesCargaMaestro.SerieQSID,AlbaranesCargaMaestro.NumeroQS,AlbaranesCargaMaestro.AlmacenSalidaQSID,AlbaranesCargaMaestro.AgenciaID,AlbaranesCargaMaestro.PorteFormaPagoID,AlbaranesCargaMaestro.PorteImporte,AlbaranesCargaMaestro.Matricula,AlbaranesCargaMaestro.Conductor,AlbaranesCargaMaestro.ConductorDNI,AlbaranesCargaMaestro.ResponsableCargaID,AlbaranesCargaMaestro.ResponsableAdministracionID,AlbaranesCargaMaestro.HoraLlegada,AlbaranesCargaMaestro.HoraSalida,AlbaranesCargaMaestro.Observaciones,AlbaranesCargaMaestro.Reserva1,AlbaranesCargaMaestro.Reserva2,AlbaranesCargaMaestro.Reserva3 from AlbaranesCargaMaestro order by fecha asc, NumeroQS asc", False)
    End Sub

    Private Sub _dgv_dataerror() Handles dgvGeneral.DataError

    End Sub
    Protected Overrides Sub BindDataSource()

        If Not dtsAlb Is Nothing Then
            'GeneralBindingSource.DataMember = "AlbaranesCargaMaestro"
            ' GeneralBindingSource.DataSource = dtsAlb
            'GeneralBindingSource. dataSource = dtb.Consultar("AlbaranesCargaMaestro1SelectDgv1")

            dgvGeneral.DataSource = dataSource 'GeneralBindingSource
            dgvGeneral.ReadOnly = True

            With dgvGeneral
                .Columns("AlbaranCargaMaestroID").Visible = False
                .Columns("AlbaranCargaProMaestroID").Visible = False
                .Columns("AlmacenSalidaQSID").Visible = False
                .Columns("AgenciaID").Visible = False
                .Columns("PorteFormaPagoID").Visible = False
                .Columns("PorteImporte").Visible = False
                .Columns("Matricula").Visible = False
                .Columns("Conductor").Visible = False
                .Columns("ConductorDNI").Visible = False
                .Columns("ResponsableCargaID").Visible = False
                .Columns("ResponsableAdministracionID").Visible = False
                .Columns("HoraLlegada").Visible = False
                .Columns("HoraSalida").Visible = False
                .Columns("Reserva1").Visible = False
                .Columns("Reserva2").Visible = False
                .Columns("Reserva3").Visible = False
                .Columns("SerieQSID").Visible = False

                .FormatoColumna("NumeroQS", "NumeroQS", BasesParaCompatibilidad.TiposColumna.Derecha, 70, 0)
                .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 1)
                .FormatoColumna("ClienteID", "Cliente", BasesParaCompatibilidad.TiposColumna.Centro, 60, 3)
                .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 400, 4)
                .FormatoGeneral()
                .MoveLast()
            End With

            'With dgvGeneral
            '    .Columns("AlbaranCargaMaestroID").Visible = False

            '    .FormatoColumna("NumeroQS", "NumeroQS", BasesParaCompatibilidad.TiposColumna.Derecha, 70, 0)
            '    .FormatoColumna("Fecha", "Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, , 1)
            '    .FormatoColumna("Cliente", BasesParaCompatibilidad.TiposColumna.Izquierda, 60, 3)
            '    .FormatoColumna("Observaciones", "Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 400, 4)
            '    .FormatoGeneral()
            '    .MoveLast()
            'End With

            'Oculto Eliminar y Modificar, porque necesito controlar que los palets que se han dado de baja en almacen, se vuelvan a dar de alta
            ' para recoger los cambios 
            butEliminar.Visible = False
            'butModificar.Visible = False
            'GeneralBindingSource.MoveLast()
        End If
    End Sub

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
        FrmEnt.Text = ACCION_INSERTAR & " AlbaranesCargaMaestro"
        FrmEnt.CargarDatos(0, 0, 0, Today, 0, 0, 0, 0, 0, 0, 0, "", "", "", 0, 0, DateTime.Now.TimeOfDay, DateTime.Now.TimeOfDay, "", "", "", "")
        FrmEnt.ShowDialog()
        dgvFill()
        'ctlAlb.mostrarTodosAlbaranesCargaMaestro(dtsAlb)
        'GeneralBindingSource.Position = 1
        'GeneralBindingSource.Position = 0
        'dgvGeneral.MoveLast()
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        ' If Posicion >= 0 Then
        If Not dgvGeneral.CurrentRow Is Nothing Then
            Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
            FrmEnt.Text = ACCION_MODIFICAR & " AlbaranesCargaMaestro"
            FrmEnt.CargarDatos(Posicion, _
                       dgvGeneral.CurrentRow.Cells(0).Value, _
                       dgvGeneral.CurrentRow.Cells(1).Value, _
                       dgvGeneral.CurrentRow.Cells(2).Value, _
                       dgvGeneral.CurrentRow.Cells(3).Value, _
                       dgvGeneral.CurrentRow.Cells(4).Value, _
                       dgvGeneral.CurrentRow.Cells(5).Value, _
                       dgvGeneral.CurrentRow.Cells(6).Value, _
                       dgvGeneral.CurrentRow.Cells(7).Value, _
                       dgvGeneral.CurrentRow.Cells(8).Value, _
                       dgvGeneral.CurrentRow.Cells(9).Value, _
                       dgvGeneral.CurrentRow.Cells(10).Value, _
                       dgvGeneral.CurrentRow.Cells(11).Value, _
                       dgvGeneral.CurrentRow.Cells(12).Value, _
                       dgvGeneral.CurrentRow.Cells(13).Value, _
                       dgvGeneral.CurrentRow.Cells(14).Value, _
                       dgvGeneral.CurrentRow.Cells(15).Value, _
                       dgvGeneral.CurrentRow.Cells(16).Value, _
                       dgvGeneral.CurrentRow.Cells(17).Value, _
                       dgvGeneral.CurrentRow.Cells(18).Value, _
                       dgvGeneral.CurrentRow.Cells(19).Value, _
                       dgvGeneral.CurrentRow.Cells(20).Value)
            FrmEnt.ShowDialog()
            dgvFill()
            'ctlAlb.mostrarTodosAlbaranesCargaMaestro(dtsAlb)
            'GeneralBindingSource.Position = 1
            'GeneralBindingSource.Position = Posicion
        Else
            MessageBox.Show("no hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
            FrmEnt.Text = ACCION_VER & " AlbaranesCargaMaestro"
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
                       dgvGeneral.Rows(Posicion).Cells(12).Value, _
                       dgvGeneral.Rows(Posicion).Cells(13).Value, _
                       dgvGeneral.Rows(Posicion).Cells(14).Value, _
                       dgvGeneral.Rows(Posicion).Cells(15).Value, _
                       dgvGeneral.Rows(Posicion).Cells(16).Value, _
                       dgvGeneral.Rows(Posicion).Cells(17).Value, _
                       dgvGeneral.Rows(Posicion).Cells(18).Value, _
                       dgvGeneral.Rows(Posicion).Cells(19).Value, _
                       dgvGeneral.Rows(Posicion).Cells(20).Value)
            FrmEnt.ShowDialog()
        Else
            MessageBox.Show("No hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Overrides Sub Eliminar()
        'Dim Posicion As Integer = GeneralBindingSource.Position
        'If Posicion >= 0 Then
        '    Dim response As DialogResult
        '    response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        '    If response = DialogResult.Yes Then
        '        ctlAlb.SetAlbaranCargaMaestroID(dgvGeneral.Rows(Posicion).Cells(0).Value)
        '        ctlAlb.EliminarAlbaranCargaMaestro()
        '        ctlAlb.mostrarTodosAlbaranesCargaMaestro(dtsAlb)
        '        If Posicion > 0 Then
        '            GeneralBindingSource.Position = Posicion - 1
        '        Else
        '            GeneralBindingSource.Position = 0
        '        End If
        '    End If
        'Else
        '    messagebox.show("No hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        'End If

        If Not dgvGeneral.CurrentRow Is Nothing Then
            Dim response As DialogResult
            response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlAlb.SetAlbaranCargaMaestroID(dgvGeneral.CurrentRow.Cells(0).Value)
                ctlAlb.EliminarAlbaranCargaMaestro()
                dgvFill()
            End If
        Else
            MessageBox.Show("No hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
