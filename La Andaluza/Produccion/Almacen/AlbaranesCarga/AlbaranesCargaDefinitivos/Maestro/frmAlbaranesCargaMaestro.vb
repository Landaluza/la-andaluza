Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlbaranesCargaMaestro
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    Private ctlAlb As ctlAlbaranesCargaMaestro
    Private dtsAlb As dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable
    Private cboYear As ComboBox
    Private agno As Integer
    Public Sub New()
        MyBase.New()
        InitializeComponent()

        Me.agno = Now.Date.Year
        ctlAlb = New ctlAlbaranesCargaMaestro
        dtsAlb = New dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable

        Dim label2 As ToolStripItem
        label2 = Me.bdnGeneral.Items.Add("Año:")
        label2.Text = "Año:"
        label2.DisplayStyle = ToolStripItemDisplayStyle.Text
        label2.Enabled = False

        cboYear = New ComboBox
        cboYear.DropDownStyle = ComboBoxStyle.DropDownList
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta("select distinct year(fecha), year(fecha) from AlbaranesCargaMaestro order by year(fecha) desc")

        Me.bdnGeneral.Items.Add(New ToolStripControlHost(cboYear))
        cboYear.mam_DataSource(dtb.Consultar(), False)
        AddHandler cboYear.SelectedValueChanged, AddressOf asignarAgno        
    End Sub

    Private Sub asignarAgno()
        Try
            Me.agno = cboYear.SelectedValue
            If Not Me.agno = Nothing Then
                dgvFill()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Protected Overrides Sub cargar_datos()
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dtb.PrepararConsulta("select AlbaranesCargaMaestro.AlbaranCargaMaestroID,AlbaranesCargaMaestro.AlbaranCargaProMaestroID,AlbaranesCargaMaestro.Fecha,AlbaranesCargaMaestro.ClienteID,AlbaranesCargaMaestro.SerieQSID,AlbaranesCargaMaestro.NumeroQS,AlbaranesCargaMaestro.AlmacenSalidaQSID,AlbaranesCargaMaestro.AgenciaID,AlbaranesCargaMaestro.PorteFormaPagoID,AlbaranesCargaMaestro.PorteImporte,AlbaranesCargaMaestro.Matricula,AlbaranesCargaMaestro.Conductor,AlbaranesCargaMaestro.ConductorDNI,AlbaranesCargaMaestro.ResponsableCargaID,AlbaranesCargaMaestro.ResponsableAdministracionID,AlbaranesCargaMaestro.HoraLlegada,AlbaranesCargaMaestro.HoraSalida,AlbaranesCargaMaestro.Observaciones,AlbaranesCargaMaestro.Reserva1,AlbaranesCargaMaestro.Reserva2,AlbaranesCargaMaestro.Reserva3 from AlbaranesCargaMaestro where year(fecha)= @ano order by fecha asc, NumeroQS asc")
        dtb.AñadirParametroConsulta("@ano", agno)
        dataSource = dtb.Consultar()
    End Sub

    Private Sub _dgv_dataerror() Handles dgvGeneral.DataError

    End Sub
    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
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

            butEliminar.Visible = False
        End If
    End Sub

    Overrides Sub Insertar()
        Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
        FrmEnt.Text = ACCION_INSERTAR & " AlbaranesCargaMaestro"
        FrmEnt.CargarDatos(0, 0, 0, Today, 0, 0, 0, 0, 0, 0, 0, "", "", "", 0, 0, DateTime.Now.TimeOfDay, DateTime.Now.TimeOfDay, "", "", "", "")
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        dgvFill()
    End Sub

    Overrides Sub Modificar()
        Dim Posicion As Integer = GeneralBindingSource.Position
        ' If Posicion >= 0 Then
        If Not dgvGeneral.CurrentRow Is Nothing Then
            'comprobar si el numero es 0 aun y solicitar un cambio
            'If dgvGeneral.CurrentRow.Cells("AlbaranCargaProMaestroID").Value = 0 Then

            'End If


            Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
            FrmEnt.Text = ACCION_MODIFICAR & " AlbaranesCargaMaestro"

            FrmEnt.Cargar(Posicion, dgvGeneral.CurrentRow.Cells(0).Value)

            'FrmEnt.CargarDatos(Posicion, _
            '           dgvGeneral.CurrentRow.Cells(0).Value, _
            '           dgvGeneral.CurrentRow.Cells(1).Value, _
            '           dgvGeneral.CurrentRow.Cells(2).Value, _
            '           dgvGeneral.CurrentRow.Cells(3).Value, _
            '           dgvGeneral.CurrentRow.Cells(4).Value, _
            '           dgvGeneral.CurrentRow.Cells(5).Value, _
            '           dgvGeneral.CurrentRow.Cells(6).Value, _
            '           dgvGeneral.CurrentRow.Cells(7).Value, _
            '           dgvGeneral.CurrentRow.Cells(8).Value, _
            '           dgvGeneral.CurrentRow.Cells(9).Value, _
            '           dgvGeneral.CurrentRow.Cells(10).Value, _
            '           dgvGeneral.CurrentRow.Cells(11).Value, _
            '           dgvGeneral.CurrentRow.Cells(12).Value, _
            '           dgvGeneral.CurrentRow.Cells(13).Value, _
            '           dgvGeneral.CurrentRow.Cells(14).Value, _
            '           dgvGeneral.CurrentRow.Cells(15).Value, _
            '           dgvGeneral.CurrentRow.Cells(16).Value, _
            '           dgvGeneral.CurrentRow.Cells(17).Value, _
            '           dgvGeneral.CurrentRow.Cells(18).Value, _
            '           dgvGeneral.CurrentRow.Cells(19).Value, _
            '           dgvGeneral.CurrentRow.Cells(20).Value)

            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
            dgvFill()
        Else
            MessageBox.Show("no hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Overrides Sub Ver()
        Dim Posicion As Integer = GeneralBindingSource.Position
        If Posicion >= 0 Then
            Dim FrmEnt As New frmEntAlbaranesCargaMaestro()
            FrmEnt.Text = ACCION_VER & " AlbaranesCargaMaestro"
            FrmEnt.Cargar(Posicion, dgvGeneral.CurrentRow.Cells(0).Value)

            'FrmEnt.CargarDatos(Posicion, _
            '           dgvGeneral.Rows(Posicion).Cells(0).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(1).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(2).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(3).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(4).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(5).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(6).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(7).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(8).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(9).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(10).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(11).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(12).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(13).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(14).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(15).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(16).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(17).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(18).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(19).Value, _
            '           dgvGeneral.Rows(Posicion).Cells(20).Value)
            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frment)
        Else
            MessageBox.Show("No hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Overrides Sub Eliminar()
        If Not dgvGeneral.CurrentRow Is Nothing Then
            Dim response As DialogResult
            response = MessageBox.Show(" Realmente desea eliminar este registro ? ", " Eliminar ", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If response = DialogResult.Yes Then
                ctlAlb.SetAlbaranCargaMaestroID(dgvGeneral.CurrentRow.Cells(0).Value)
                Dim dtb As New BasesParaCompatibilidad.DataBase
                ctlAlb.EliminarAlbaranCargaMaestro(dtb)
                dgvFill()
            End If
        Else
            MessageBox.Show("No hay celda seleccionada", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class
