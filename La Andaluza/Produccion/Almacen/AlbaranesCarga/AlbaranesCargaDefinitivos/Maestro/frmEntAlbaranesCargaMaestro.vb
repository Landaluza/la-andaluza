Option Compare Text
Imports BasesParaCompatibilidad.ComboBoxExtension
Imports BasesParaCompatibilidad.dtpExtension
Imports BasesParaCompatibilidad.DataGridViewExtension
Imports BasesParaCompatibilidad.WordExtension
Public Class frmEntAlbaranesCargaMaestro
    inherits BasesParaCompatibilidad.FrmAHeredarEntOld

    Private ctlAlbDet As ctlAlbaranesCargaDetalles
    Private dtsAlb As dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable
    Private ctlAlb As ctlAlbaranesCargaMaestro
    Private ctlAlbProMae As ctlAlbaranCargaProMaestro
    Private ctlAlbProDet As ctlAlbaranesCargaProviDetalles

    Private totalCajas As Integer
    Private m_MaestroProID As String
    Private m_MaestroID As String

    Private v_cliente As String
    Private v_conductor As String
    Private tsExcel As ToolStripButton
    Private tsNuevoPalet As ToolStripButton
    Private dtb as BasesParaCompatibilidad.Database
    Private macrosender As MacroSender
    Private Respuesta As MsgBoxResult
    'Private oQS As Object
    'Private oMensajesQS As Object
    'Private TiempoEspera As Integer = 600
    Private Medida As Integer
    Private Albaran As String
    Public Sub New()
        InitializeComponent()

        macrosender = New MacroSender
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        ctlAlbDet = New ctlAlbaranesCargaDetalles
        dtsAlb = New dtsAlbaranesCargaMaestro.AlbaranesCargaMaestroDataTable
        ctlAlb = New ctlAlbaranesCargaMaestro
        ctlAlbProMae = New ctlAlbaranCargaProMaestro
        ctlAlbProDet = New ctlAlbaranesCargaProviDetalles
        FechaDateTimePicker.activarFoco()
        HoraLlegadaDateTimePicker.activarFoco()
        HoraSalidaDateTimePicker.activarFoco()

        cboConductores.mam_DataSource("ConductoresSelectCbo", False)
        cboClientes.mam_DataSource("ClientesSelectCbo", False)

        tsExcel = Me.bdnGeneral.Items.Add("Excel")
        tsExcel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsExcel.Text = "Excel"
        tsExcel.ToolTipText = "Generar archivo excel"
        tsExcel.TextDirection = ToolStripTextDirection.Horizontal
        tsExcel.TextAlign = ContentAlignment.MiddleRight
        tsExcel.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsExcel.Image = My.Resources.page_excel_16
        AddHandler tsExcel.Click, AddressOf btnToExcel_Click
    End Sub

    Private Sub frmEntAlbaranesCargaMaestro_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ModificarBindingNavigator()

        If Me.Text.Substring(0, 8) = "Insertar" Then
            grbDatosCabecera.Visible = False
            grbAlbaranesPendientes.Visible = True
            grbAlbaranesPendientes.Location = New System.Drawing.Point(8, 32)
            Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
            With dgvAlbaranesProvi
                .Width = 500
                .DataSource = dtb.Consultar("SelectAlbaranCargaProMaestroByReserva1")
                .Columns("AlbaranCargaProMaestroID").Visible = False
                .Columns("Cargador").Visible = False
                .FormatoColumna("Num", BasesParaCompatibilidad.TiposColumna.Derecha, 60, 0)
                .FormatoColumna("Fecha", BasesParaCompatibilidad.TiposColumna.FechaCorta, 85, 1)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 427, 3)
                .FormatoGeneral()
            End With
        Else
            If Me.Text.Substring(0, 3) = "Ver" Then
                ctlAlb.mostrarTodosAlbaranesCargaMaestro(dtsAlb)
                GeneralBindingSource.DataSource = dtsAlb
                GeneralBindingSource.Position = Posicion
            Else
                tsNuevoPalet = Me.bdnGeneral.Items.Add("Añadir palet a albaran de carga")
                tsNuevoPalet.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                tsNuevoPalet.Text = "Añadir palet a albaran de carga"
                tsNuevoPalet.ToolTipText = "Añadir palet a albaran de carga"
                tsNuevoPalet.TextDirection = ToolStripTextDirection.Horizontal
                tsNuevoPalet.TextAlign = ContentAlignment.MiddleRight
                tsNuevoPalet.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                tsNuevoPalet.Image = My.Resources.edit_add_2
                AddHandler tsNuevoPalet.Click, AddressOf NuevoPalet_Click
            End If

            grbAlbaranesPendientes.Visible = False
            RellenarDgv()
        End If



        Me.butImprimir.Visible = True
        Me.butExcel.Visible = True
        'TO DO añadir boton nuevo y cambiar este por uno de verdad
        ' Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.btnToExcel))
        btnToExcel.Visible = False
    End Sub



    Private Sub NuevoPalet_Click(ByVal sender As Object, ByVal e As System.EventArgs)
        Dim frm As New AgnadirAcarga(m_MaestroProID)
        AddHandler frm.AfterSave, AddressOf RellenarDgv
        frm.ShowDialog()
    End Sub

    Public Sub CargarDatos(ByVal Pos As Integer,
                           ByVal AlbaranCargaMaestroID As Integer, _
                           ByVal AlbaranCargaProMaestroID As Integer, _
                           ByVal Fecha As DateTime, _
                           ByVal ClienteID As Integer, _
                           ByVal SerieQSID As Integer, _
                           ByVal NumeroQS As Integer, _
                           ByVal AlmacenSalidaQSID As Integer, _
                           ByVal AgenciaID As Integer, _
                           ByVal PorteFormaPagoID As Integer, _
                           ByVal PorteImporte As Integer, _
                           ByVal Matricula As String, _
                           ByVal Conductor As String, _
                           ByVal ConductorDNI As String, _
                           ByVal ResponsableCargaID As Integer, _
                           ByVal ResponsableAdministracionID As Integer, _
                           ByVal HoraLlegada As TimeSpan, _
                           ByVal HoraSalida As timespan, _
                           ByVal Observaciones As String, _
                           ByVal Reserva1 As String, _
                           ByVal Reserva2 As String, _
                           ByVal Reserva3 As String)

        Posicion = Pos
        ctlAlb.SetAlbaranCargaMaestroID(AlbaranCargaMaestroID)
        txtAlbaranCargaMaestroID.Text = AlbaranCargaMaestroID.ToString
        txtMaestroID.Text = AlbaranCargaProMaestroID.ToString
        m_MaestroProID = AlbaranCargaProMaestroID.ToString
        FechaDateTimePicker.Value = Fecha
        ClienteIDCuadroDeTexto.Text = ClienteID.ToString
        SerieQSIDCuadroDeTexto.Text = SerieQSID.ToString
        NumeroQSCuadroDeTexto.Text = NumeroQS.ToString
        AlmacenSalidaQSIDCuadroDeTexto.Text = AlmacenSalidaQSID.ToString
        AgenciaIDCuadroDeTexto.Text = AgenciaID.ToString
        PorteFormaPagoIDCuadroDeTexto.Text = PorteFormaPagoID.ToString
        PorteImporteCuadroDeTexto.Text = PorteImporte.ToString
        MatriculaCuadroDeTexto.Text = Matricula
        ConductorCuadroDeTexto.Text = Conductor
        ConductorDNICuadroDeTexto.Text = ConductorDNI
        Reserva1CuadroDeTexto.Text = Reserva1

        'Los mismos datos en pestaña Acumulados
        txtCabeza.Text = Matricula
        txtConductor.Text = Conductor
        txtDNI.Text = ConductorDNI
        txtRemolque1.Text = Reserva1

        ResponsableCargaIDCuadroDeTexto.Text = ResponsableCargaID.ToString
        ResponsableAdministracionIDCuadroDeTexto.Text = ResponsableAdministracionID.ToString
        HoraLlegadaDateTimePicker.Value = Now.Date.Add(HoraLlegada)
        HoraSalidaDateTimePicker.Value = Now.Date.Add(HoraSalida)
        ObservacionesCuadroDeTexto.Text = Observaciones

        Reserva2CuadroDeTexto.Text = Reserva2
        Reserva3CuadroDeTexto.Text = Reserva3

        v_cliente = ClienteID.ToString
        v_conductor = Conductor
    End Sub

    Private Sub dgvAlbaranesProvi_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles dgvAlbaranesProvi.CellClick
        Try
            'Por error estoy guardando en AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID 
            'AlbaranesCargaProMaestro.Numero en lugar de AlbaranesCargaProMaestro.AlbaranCargaProMaestroID que seria lo correcto.
            'm_MaestroProID = dgvAlbaranesProvi.SelectedRows(0).Cells("Num").Value.ToString
            m_MaestroProID = dgvAlbaranesProvi.CurrentRow.Cells("Num").Value.ToString

            grbAlbaranesPendientes.Visible = False
            grbDatosCabecera.Visible = True
            RellenarDgv()
        Catch ex As Exception
            messagebox.show("Selecciona una fila entera pulsando a la izquierda de la misma. Detalles: " & Environment.NewLine & ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try

    End Sub

    Overrides Sub Guardar()
        Me.txtAlbaranCargaMaestroID.Focus()
        Dim dtb As New BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

        Try
            If Me.Text.Substring(0, 8) = "Insertar" Then
                ctlAlb.GuardarAlbaranCargaMaestro((m_MaestroProID), _
                                                  FechaDateTimePicker.Value, _
                                                  (ClienteIDCuadroDeTexto.Text), _
                                                  (SerieQSIDCuadroDeTexto.Text), _
                                                  (NumeroQSCuadroDeTexto.Text), _
                                                  (AlmacenSalidaQSIDCuadroDeTexto.Text), _
                                                  (AgenciaIDCuadroDeTexto.Text), _
                                                  (PorteFormaPagoIDCuadroDeTexto.Text), _
                                                  (PorteImporteCuadroDeTexto.Text), _
                                                  MatriculaCuadroDeTexto.Text, _
                                                  ConductorCuadroDeTexto.Text, _
                                                  ConductorDNICuadroDeTexto.Text, _
                                                  (ResponsableCargaIDCuadroDeTexto.Text), _
                                                  (ResponsableAdministracionIDCuadroDeTexto.Text), _
                                                  HoraLlegadaDateTimePicker.Value, _
                                                  HoraSalidaDateTimePicker.Value, _
                                                  ObservacionesCuadroDeTexto.Text, _
                                                  Reserva1CuadroDeTexto.Text, _
                                                  Reserva2CuadroDeTexto.Text, _
                                                  Reserva3CuadroDeTexto.Text)

                'Guardar el ID del albaran definitivo en el albaran provisional en el campo Reserva1
                m_MaestroID = ctlAlb.GetAlbaranCargaMaestroID().ToString
                'ProcedimientoAlmacenado("AlbaranCargaProMaestroUpdate ", "@ID", m_MaestroProID, "@AlbaranDefinitivo", m_MaestroID)

                'Por error estoy guardando en AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID 
                'AlbaranesCargaProMaestro.Numero en lugar de AlbaranesCargaProMaestro.AlbaranCargaProMaestroID que seria lo correcto.
                dtb.ConsultaAlteraciones("exec AlbaranCargaProMaestroUpdate " & m_MaestroProID & "," & m_MaestroProID)

                Dim Contador As Integer = 0
                Do While Contador < dgvPalet.Rows.Count
                    'Dar de baja a estos palets en almacen, en la tabla PaletsContenidos.
                    'Tambien pongo Terminado = True, porque de los contario seguia saliendo en Envasado como pico a completar.
                    Dim scc As Integer = Convert.ToInt32(dgvPalet.Rows(Contador).Cells(2).Value)
                    dtb.ConsultaAlteraciones("exec PaletsContenidosUpdateEnAlmacenBySCC '" & scc & "'")
                    Contador += 1
                Loop
                Me.Close()
            End If

            If Me.Text.Substring(0, 9) = "Modificar" Then
                ctlAlb.GuardarAlbaranCargaMaestro((m_MaestroProID), _
                                                  FechaDateTimePicker.Value, _
                                                  (ClienteIDCuadroDeTexto.Text), _
                                                  (SerieQSIDCuadroDeTexto.Text), _
                                                  (NumeroQSCuadroDeTexto.Text), _
                                                  (AlmacenSalidaQSIDCuadroDeTexto.Text), _
                                                  (AgenciaIDCuadroDeTexto.Text), _
                                                  (PorteFormaPagoIDCuadroDeTexto.Text), _
                                                  (PorteImporteCuadroDeTexto.Text), _
                                                  MatriculaCuadroDeTexto.Text, _
                                                  ConductorCuadroDeTexto.Text, _
                                                  ConductorDNICuadroDeTexto.Text, _
                                                  (ResponsableCargaIDCuadroDeTexto.Text), _
                                                  (ResponsableAdministracionIDCuadroDeTexto.Text), _
                                                  HoraLlegadaDateTimePicker.Value, _
                                                  HoraSalidaDateTimePicker.Value, _
                                                  ObservacionesCuadroDeTexto.Text, _
                                                  Reserva1CuadroDeTexto.Text, _
                                                  Reserva2CuadroDeTexto.Text, _
                                                  Reserva3CuadroDeTexto.Text)
                Me.Close()
            End If
        Catch ex As Exception
            messagebox.show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub RellenarDgv()
        Dim calendar As New BasesParaCompatibilidad.Calendar
        'Si pongo txtMaestroID.visible = false, falla
        'txtMaestroID.Visible = True
        'MaestroID = txtMaestroID.Text
        'txtMaestroID.Visible = False
        'Guardo el numero del albaran provisional
        'Me.txtMaestroID.Text = cadena

        Dim dtPalets As System.Data.DataTable = dtb.consultar("SelectPaletsByAlbaranPro4 " & m_MaestroProID)

        For Each row As DataRow In dtPalets.Rows
            'row.Item("Lote") = DevuelveFechaJuliana(Convert.ToDateTime(row.Item("lote"))).ToString
            If Not IsDBNull(row.Item("loteAlternativo")) Then
                If row.Item("loteAlternativo") <> "" Then
                    row.Item("Lote") = row.Item("loteAlternativo")
                Else
                    row.Item("Lote") = calendar.DevuelveFechaJuliana(Convert.ToDateTime(row.Item("Lote"))).ToString
                End If
            Else
                row.Item("Lote") = calendar.DevuelveFechaJuliana(Convert.ToDateTime(row.Item("Lote"))).ToString
            End If
        Next

        With dgvPalet
            .Height = 1190
            .DataSource = dtPalets
            .Columns("AlbaranCargaProviDetalleID").Visible = False
            .Columns("AlbaranCargaProviMaestroID").Visible = False
            .Columns("loteAlternativo").Visible = False
            .Columns("formatoenvasado").Visible = False
            .Columns("UnidadMedidaID").Visible = False
            .Columns("TipoPaletID").Visible = False

            .FormatoColumna("SCC", "SCC", BasesParaCompatibilidad.TiposColumna.QS, , 0)
            .FormatoColumna("CodigoQS", "CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, 120, 1)
            .FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, 480, 2)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 3)
            .FormatoColumna("Lote", "Lote", BasesParaCompatibilidad.TiposColumna.Juliano, , 4)
            .FormatoColumna("Multilote", BasesParaCompatibilidad.TiposColumna.Centro, 64, 5)
            .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Observaciones, 400, 6)
            .FormatoGeneral()
        End With

        Dim dtAcu As System.Data.DataTable = dtb.Consultar("sumCajasByCodigoLote4 " & m_MaestroProID)

        dtAcu.Columns.Add("Lote")
        For Each row As DataRow In dtAcu.Rows
            If Not IsDBNull(row.Item("loteAlternativo")) Then
                If row.Item("loteAlternativo") <> "" Then
                    Try
                        row.Item("Lote") = row.Item("loteAlternativo")
                    Catch ex As Exception
                    End Try
                Else
                    Try
                        row.Item("Lote") = row.Item("Lote2")
                    Catch ex As Exception
                    End Try
                End If
            Else
                Try
                    row.Item("Lote") = row.Item("Lote2") 'DevuelveFechaJuliana(Convert.ToDateTime(row.Item("Lote2"))).ToString
                Catch ex As Exception
                End Try
            End If
        Next

        With dgvAcumulados
            .Width = 700
            .DataSource = dtAcu
            .Columns("AlbaranCargaProviMaestroID").Visible = False
            .Columns("Lote2").Visible = False
            .Columns("loteAlternativo").Visible = False

            .FormatoColumna("CodigoQS", "CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, 120, 0)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
            .FormatoColumna("Lote", "Lote", BasesParaCompatibilidad.TiposColumna.Juliano, , 3)
            .FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Referencia, True)
            .FormatoGeneral()
        End With

        With dgvTotalPalets
            .Width = 300
            .dataSource = dtb.Consultar("sumPaletsByTipo " & m_MaestroProID)
            .FormatoColumna("TipoPaletID", "Tipo", BasesParaCompatibilidad.TiposColumna.Miles, 40, 0)
            .FormatoColumna("descripcion", "Descripcion", BasesParaCompatibilidad.TiposColumna.Descripcion, 180, 1)
            .FormatoColumna("Cantidad", "Cantidad", BasesParaCompatibilidad.TiposColumna.Miles, , 2)
            .FormatoGeneral()
        End With

        'Sumo todas los bultos, hay albaranes como los de transicubas que no tienen registros
        'If dtPalets.Rows.Count > 0 Then
        '    Dim TotalBultos As Object = dtPalets.Compute("Sum(Cajas)", "")
        '    txtTotalBultos.Text = CStr(TotalBultos)
        'End If

        With dgvTotales
            .dataSource = dtb.Consultar("AlbaranesCargaProviDetallesSumCajas " & m_MaestroProID)
            .FormatoColumna("CodigoQS", "CodigoQS", BasesParaCompatibilidad.TiposColumna.QS, 120, 0)
            .FormatoColumna("Cajas", "Cajas", BasesParaCompatibilidad.TiposColumna.Miles, , 1)
            .FormatoColumna("AticuloDescripcion", "Articulo", BasesParaCompatibilidad.TiposColumna.Izquierda, 480, 2)
            .FormatoGeneral()
        End With

        Dim dtTotalPalets As System.Data.DataTable = dtb.consultar("AlbaranesCargaProviDetallesTotalesPorTipoPalet " & m_MaestroProID)

        If Not dtTotalPalets Is Nothing Then
            With dgvTotalesPorPalet
                .DataSource = dtTotalPalets
                .FormatoGeneral()
            End With
        End If
    End Sub

    Overrides Sub Imprimir()
        Dim p As New BasesParaCompatibilidad.Printer
        p.ImprimirForm(Me)
    End Sub

    Private Sub ToExcel()
        'ExportarTablaExcel(DataTableFill("SelectPaletsByAlbaranPro " & m_MaestroProID))
    End Sub

    Private Sub cboConductores_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboConductores.SelectedValueChanged

        'Tengo que usar este Try vacio porque da error al cargar el formnulario
        Try
            Dim m_Conductor As New DBO_Conductores
            Dim spConductores As New spConductores
            m_Conductor = spConductores.Select_Record((cboConductores.SelectedValue))
            ConductorDNICuadroDeTexto.Text = m_Conductor.DNI
            Me.txtDNI.Text = m_Conductor.DNI

            Me.ConductorCuadroDeTexto.Text = cboConductores.Text
            Me.txtConductor.Text = cboConductores.Text
        Catch ex As Exception
        End Try

    End Sub

    Private Sub cboClientes_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cboClientes.SelectedValueChanged
        'Tengo que usar este Try vacio porque da error al cargar el formnulario
        Try
            ClienteIDCuadroDeTexto.Text = (CType(cboClientes.SelectedValue, Integer) - 1).ToString
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnToExcel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnToExcel.Click
        Dim dgv As New DataGridView
        dgv.dataSource = dtb.Consultar("SelectPaletsByAlbaranPro", m_MaestroProID)
        Dim mse As New BasesParaCompatibilidad.MicrosoftOfficeExporter
        mse.ExportToExcel("Many", Me.Text, dgv)
        dgv.Dispose()
    End Sub

    

   
    Private Sub butAlbaranQS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAlbaranQS.Click
        'QS.SalidaJR(dgvTotalPalets, dgvAcumulados)

        Try
            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()
            'Enviar las pulsaciones de teclas a la aplicación
            If macrosender.SiExisteTextoTeclea("Area Comercial", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Venta y Facturación", 10, 8, "14[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albaranes", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "1000002[tab][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Dirección Envío", 4, 22, "[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Almacén", 10, 1, "10[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Serie", 10, 54, "E") Then Return
            If macrosender.SiExisteTextoTeclea("Negociación", 15, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
            If macrosender.SiExisteTextoTeclea("Tarifa", 11, 2, "[enter]") Then Return

            For Each m_Row As DataGridViewRow In dgvAcumulados.Rows
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cajas").Value.ToString & "[tab][enter]") Then Return

                'Precio:
                If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return

                'Lote:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
            Next

            For Each m_Row As DataGridViewRow In dgvTotalPalets.Rows
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "462599120[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cantidad").Value.ToString & "[tab][enter]") Then Return

                'Precio:
                If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return
            Next

            Respuesta = MsgBox(" ¿Todo correcto?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab]N[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3][pf12][pf12]") Then Return


            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub butEntradaJR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butEntradaJR.Click
        'QS.EntradaJR(dgvTotalPalets, dgvAcumulados)
        'http://publib.boulder.ibm.com/infocenter/pcomhelp/v5r9/index.jsp?topic=/com.ibm.pcomm.doc/books/html/host_access08.htm

        Try
            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()
            Albaran = InputBox("Introduce numero de albaran", "Albaran")

            If macrosender.espera Then
                macrosender.Enviar("[pf3][enter]")
            Else
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
                macrosender.Enviar("[pf3][enter]")
            End If

            If macrosender.SiExisteTextoTeclea("Usuario", 6, 17, "JEREZ999[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Contraseña", 7, 17, "JEREZ[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Ventas", 6, 8, "[pf1]") Then Return
            If macrosender.SiExisteTextoTeclea("Conexión a Empresa", 19, 32, "999[enter][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("J.R. SABATER", 1, 31, "21[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Número Albarán", 3, 2, Albaran) Then Return
            If macrosender.SiExisteTextoTeclea("Número Albarán", 3, 2, "[tab]5000427[tab][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Pedido", 5, 10, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Almacén", 7, 1, "40[tab][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Tarifa", 8, 2, "[enter]") Then Return

            For Each m_Row As DataGridViewRow In dgvAcumulados.Rows
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab][tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("Cajas").Value.ToString & "[tab]") Then Return

                Select Case m_Row.Cells("CodigoQS").Value.ToString
                    Case Is = 116001302.ToString, 117001302.ToString, 116607375.ToString
                        Medida = 4
                    Case Is = 462599120.ToString
                        Medida = 8
                    Case Is = 198174302.ToString
                        Medida = 15
                    Case Is = 170267375.ToString, 170167375.ToString, 170367375.ToString, 150166302.ToString, 150218375.ToString, 150318375.ToString
                        Medida = 16
                    Case Else
                        Medida = (InputBox("Introduce Medida", "Medida"))
                End Select

                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, Medida & "[tab][enter]") Then Return

                'Precio:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter]") Then Return

                'Lote:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter][enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
            Next

            For Each m_Row As DataGridViewRow In dgvTotalPalets.Rows
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "462599120[tab][tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("Cantidad").Value.ToString & "[tab][enter]") Then Return

                'Precio:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter][enter]") Then Return
            Next

            Respuesta = MsgBox(" ¿Todo correcto?", _
                               MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                               " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]")
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 7, 2, "N[enter]") Then Return
                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return



            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return


            End If

        Catch ex As Exception
            If ex.Message = "ECLErr object is unable to load error message number 37130, reason code 0.(Session error)" Then
                MsgBox("Hay un problema al crear en enlace con QS", MsgBoxStyle.Exclamation)
            Else
                If macrosender.espera Then
                    MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
                Else
                    MsgBox(ex.ToString, MsgBoxStyle.Critical, "Error")
                End If
            End If
        End Try
    End Sub

    Private Sub butJRaMercadona_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butJRaMercadona.Click
        ' QS.JR_a_Mercadona(txtRemolque1.Text, txtConductor.Text, txtDNI.Text)
        Try
            Dim Pedido As String
            Dim Transportista As String
            Dim Matricula As String
            Dim Chofer As String
            Dim DNI As String
            Dim Fecha As String
            Pedido = InputBox("Introduce numero de pedido", "Pedido")


            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()

            If macrosender.espera Then
                macrosender.Enviar("[pf3][enter]")
            Else
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
                macrosender.Enviar("[pf3][enter]")
            End If

            If macrosender.SiExisteTextoTeclea("Usuario", 6, 17, "JEREZ999[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Contraseña", 7, 17, "JEREZ[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Ventas", 6, 8, "[pf1]") Then Return
            If macrosender.SiExisteTextoTeclea("Conexión a Empresa", 19, 32, "999[enter][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("J.R. SABATER", 1, 31, "11[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, Pedido + "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "[enter][enter]") Then Return


            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox(" ¿Hay que pulsar F23?", _
                               MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                               " ¿F23 ")
            If Respuesta = MsgBoxResult.Yes Then

                'Pulsar F23 para continuar
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

            Else
            End If

            Respuesta = MsgBox(" ¿Todo correcto?", _
                                 MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                 " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab][tab]") Then Return

                'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                Transportista = InputBox("Introduce Transportista", "Transportista")
                Transportista = Transportista + Space(20)
                Transportista = Transportista.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Envio", 8, 37, Transportista) Then Return

                'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                Matricula = txtRemolque1.Text
                Matricula = Matricula + Space(8)
                Matricula = Matricula.ToString.Substring(0, 8)
                If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                Chofer = txtConductor.Text
                Chofer = Chofer + Space(20)
                Chofer = Chofer.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)
                DNI = txtDNI.Text
                DNI = DNI + Space(15)
                DNI = DNI.ToString.Substring(0, 15)
                If macrosender.SiExisteTextoTeclea("DNI", 9, 55, DNI) Then Return

                'Descarga: Tiene que poner la fecha de hoy
                Fecha = System.DateTime.Today.ToString
                If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[enter]") Then Return

                Dim Respuesta1 As MsgBoxResult
                Respuesta1 = MsgBox(" ¿Hay que pulsar F23?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿F23 ")
                If Respuesta1 = MsgBoxResult.Yes Then

                    'Pulsar F23 para continuar
                    If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

                Else
                End If

                'If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then return
                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return

            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][pf12][pf12][pf3]") Then Return


            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub butCartaPortes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCartaPortes.Click
        'Dim EmpresaDestinataria As String
        'Dim LugarEntrega As String
        Dim DescripcionMercancia As String
        Dim NumeroDocumento As String
        'Dim OperadorTransporte As String
        'Dim Transportista As String
        Dim PesoBruto As String
        Dim Anchocolumna As Integer = 242
        Dim Anchocolumna1 As Integer = 294
        Dim Fecha As String = System.DateTime.Today.ToString.Substring(0, 10)
        Dim Fila As Integer = 1
        Dim DireccionJRSabater As String = "J.R.SABATER, S.A." + Environment.NewLine + _
                                           "C/Marquetería, 7" + Environment.NewLine + _
                                           "11408 - JEREZ DE LA FRONTERA" + Environment.NewLine + _
                                           "CADIZ - ESPAÑA" + Environment.NewLine

        Dim DireccionMercadonaHuevar As String = "MERCADONA - HUEVAR" + Environment.NewLine + _
                                                 "AV. SEVILLA-HUELVA A-49 KM.21" + Environment.NewLine + _
                                                 "41830 - HUEVAR" + Environment.NewLine + _
                                                 "SEVILLA (ESPAÑA)" + Environment.NewLine

        Dim DireccionMercadonaAntequera As String = "MERCADONA - ANTEQUERA" + Environment.NewLine + _
                                                    "PQ. EMPRESARIAL SECTOR SUP.I 5" + Environment.NewLine + _
                                                    "29200 - ANTEQUERA" + Environment.NewLine + _
                                                    "MALAGA (ESPAÑA)" + Environment.NewLine

        Dim DireccionAcotral As String = "TRANSPORTES ACOTRAL, S.L." + Environment.NewLine + _
                                         "C/ CUEVA DE VIERA, Nº2" + Environment.NewLine + _
                                         "24900 - ANTEQUERA" + Environment.NewLine + _
                                         "MALAGA (ESPAÑA)" + Environment.NewLine

        Dim DireccionTransreyes As String = "TRANSREYES LOGISTICA, S.L." + Environment.NewLine + _
                                            "C/ CEREZO, 8 - Apto. Correos nº1" + Environment.NewLine + _
                                            "18040 - LA ZUBIA" + Environment.NewLine + _
                                            "GRANADA (ESPAÑA)" + Environment.NewLine

        Dim oWord As New Microsoft.Office.Interop.Word.Application
        Dim oDoc As Microsoft.Office.Interop.Word.Document
        Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table
        'Dim oTabla As Table
        'Dim oPara1 As Paragraph

        oWord.Visible = False
        oDoc = oWord.Documents.Add
        oWord.ActiveWindow.Selection.Style = Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText

        With oDoc.PageSetup
            Try
                .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
            Catch ex As Exception
            End Try
            Try
                .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
            Catch ex As Exception
            End Try
            .LeftMargin = oWord.CentimetersToPoints(1)
            .BottomMargin = oWord.CentimetersToPoints(0.7)
            .TopMargin = oWord.CentimetersToPoints(1)
            .TextColumns.SetCount(2)
        End With
        Try
            oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 32, 1)
            With oTablaTitulo
                .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Cell(1, 1).Range.InsertAfter("")
                '.Cell(1, 1).Width = 63

                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .Cell(1, 1).Width = oWord.PixelsToPoints(300)
                .Cell(1, 1).Range.Font.Size = 18
                .Cell(1, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
                .mam_FormatoLinea(1, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "DOCUMENTO DE CONTROL DEL TRANSPORTE " + Environment.NewLine + _
                                                                                                     "DE MERCANCIAS POR CARRETERA" + Environment.NewLine + _
                                                                                                     "Orden FOM/238/203, de 28 de agosto de 2003")



                'Dim rngPara As Range
                ''Set rngPara = ActiveDocument.Paragraphs(1).Range
                'rngPara = .Cell(1, 1).Range
                'With rngPara
                '    .Sentences(1).Select()
                '    .Bold = True
                '    .Font.Name = "Arial"
                'End With
                '

                .mam_FormatoLineaTitulo(2, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA CARGADORA (Nombre y domicilio)")
                .mam_FormatoLinea(3, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionJRSabater)

                .mam_FormatoLineaTitulo(4, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA EXPEDIDORA (Nombre y domicilio)")
                .mam_FormatoLinea(5, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionJRSabater)


                .mam_FormatoLineaTitulo(6, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA DESTINATARIA (Nombre y domicilio)")
                .mam_FormatoLineaTitulo(10, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "LUGAR ENTREGA MERCANCIA DESTINO")

                Dim Respuesta As DialogResult
                Respuesta = messagebox.show(" ¿El lugar de entrega es Huevar?", _
                                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta = DialogResult.Yes Then
                    .mam_FormatoLinea(7, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaHuevar)
                    .mam_FormatoLinea(11, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaHuevar)

                Else
                    .mam_FormatoLinea(7, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaAntequera)
                    .mam_FormatoLinea(11, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionMercadonaAntequera)
                End If

                .mam_FormatoLineaTitulo(8, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "LUGAR Y FECHA CARGA MERCANCIA")
                .mam_FormatoLinea(9, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, _
                                                                                                    "JEREZ DE LA FRA - CADIZ - ESPAÑA" + Environment.NewLine + _
                                                                                                    (Fecha) + Environment.NewLine)




                .mam_FormatoLineaTitulo(12, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "INSTRUCCIONES DEL REMITENTE")
                .mam_FormatoLinea(13, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine)


                Dim NumeroPalets As String

                If dgvTotalPalets.Rows.Count = 0 Then
                    NumeroPalets = InputBox("Introduce numero palets", "DescripcionMercancia")
                Else
                    NumeroPalets = dgvTotalPalets.Rows(0).Cells("Cantidad").Value.ToString
                End If

                DescripcionMercancia = Environment.NewLine + _
                                        NumeroPalets + " PALETS DE VINAGRES Y SALSAS" + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine

                .mam_FormatoLineaTitulo(14, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "DESCRIPCION DE LA MERCANCIA")
                .mam_FormatoLinea(15, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DescripcionMercancia)

                .mam_FormatoLineaTitulo(16, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "FIRMA Y SELLO EMPRESA CARGADORA")
                .mam_FormatoLinea(17, 1, Anchocolumna, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine)

                NumeroDocumento = InputBox("Introduce numero documento", "Documento")
                .mam_FormatoLinea(18, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "DOCUMENTO Nº" + " " + NumeroDocumento.ToString + Environment.NewLine + "Formalizado en Jerez a " + (Fecha) + Environment.NewLine)

                Dim Respuesta1 As DialogResult
                Respuesta1 = messagebox.show(" ¿Es Acotral la empresa cargadora?", _
                                   "", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Respuesta1 = DialogResult.Yes Then
                    .mam_FormatoLineaTitulo(19, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "OPERADOR DE TRANSPORTE (AGENCIA)")
                    .mam_FormatoLinea(20, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionAcotral)

                    .mam_FormatoLineaTitulo(21, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "TRANSPORTISTA (Nombre y domicilio)")
                    .mam_FormatoLinea(22, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionAcotral)

                Else
                    .mam_FormatoLineaTitulo(19, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "OPERADOR DE TRANSPORTE (AGENCIA)")
                    .mam_FormatoLinea(20, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionTransreyes)

                    .mam_FormatoLineaTitulo(21, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "TRANSPORTISTA (Nombre y domicilio)")
                    .mam_FormatoLinea(22, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, DireccionTransreyes)

                End If



                Dim MatriculaTractora As String
                MatriculaTractora = txtCabeza.Text
                MatriculaTractora = MatriculaTractora


                Dim MatriculaSemirremolque As String
                MatriculaSemirremolque = txtRemolque1.Text
                MatriculaSemirremolque = MatriculaSemirremolque

                .mam_FormatoLineaTitulo(23, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "MATRICULA TRACTORA")
                .mam_FormatoLinea(24, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, MatriculaTractora + Environment.NewLine)


                .mam_FormatoLineaTitulo(25, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "MATRICULA SEMIRREMOLQUE")
                .mam_FormatoLinea(26, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, MatriculaSemirremolque + Environment.NewLine)


                .mam_FormatoLineaTitulo(27, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "RESERVA Y OBSERVACIONES DEL TRANSPORTISTA")
                .mam_FormatoLinea(28, 1, Anchocolumna1, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine + _
                                               Environment.NewLine)

                .Cell(29, 1).Split(1, 4)
                .Cell(30, 1).Split(1, 4)

                .mam_FormatoLineaTitulo(29, 1, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "Nº DE BULTOS")
                .mam_FormatoLinea(30, 1, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine)




                PesoBruto = InputBox("Introduce peso bruto", "PesoBruto")
                PesoBruto = Environment.NewLine + _
                                        PesoBruto + " Kg." + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine + _
                                        Environment.NewLine
                .mam_FormatoLineaTitulo(29, 2, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "PESO BRUTO")
                .mam_FormatoLinea(30, 2, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, PesoBruto)

                .mam_FormatoLineaTitulo(29, 3, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "PESO NETO")
                .mam_FormatoLinea(30, 3, 74, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine)

                .mam_FormatoLineaTitulo(29, 4, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "VOLUMEN M3")
                .mam_FormatoLinea(30, 4, 73, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine + _
                Environment.NewLine)


                .Cell(31, 1).Split(1, 2)
                .Cell(32, 1).Split(1, 2)

                .mam_FormatoLineaTitulo(31, 1, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA TRANSPORTISTA")
                .mam_FormatoLinea(32, 1, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine)

                .mam_FormatoLineaTitulo(31, 2, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, True, "EMPRESA DESTINATARIA")
                .mam_FormatoLinea(32, 2, 147, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine + _
                                              Environment.NewLine)

            End With

            'oDoc.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryFooter
            'oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
            'oWord.Selection.Font.Color = WdColor.wdColorBlue
            'oWord.Selection.Font.Size = 12
            'oWord.Selection.TypeText(Text:=Now)

            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
            'Me.Dispose()
        Catch ex As Exception
            messagebox.show("Ocurrio un error." & Environment.NewLine & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub




    Private Sub butLAaJR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butLAaJR.Click

        '''QS.AlbaranJR(txtRemolque1.Text, txtConductor.Text, txtDNI.Text, dgvAcumulados)

        Dim Matricula As String
        Dim Chofer As String
        Dim DNI As String
        Dim Fecha As String
        Dim PrecioPorte As Double = 400 '352.8
        Dim PesoBruto As Double
        Dim PrecioKilo As Double

        Try
            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()
            'Enviar las pulsaciones de teclas a la aplicación
            If macrosender.SiExisteTextoTeclea("Area Comercial", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Venta y Facturación", 10, 8, "14[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albaranes", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "1000002[tab][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Dirección Envío", 4, 22, "[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Almacén", 10, 1, "10[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Serie", 10, 54, "E") Then Return
            If macrosender.SiExisteTextoTeclea("Negociación", 15, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
            If macrosender.SiExisteTextoTeclea("Tarifa", 11, 2, "[enter]") Then Return

            For Each m_Row As DataGridViewRow In dgvAcumulados.Rows
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, m_Row.Cells("CodigoQS").Value.ToString & "[tab]") Then Return
                If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, m_Row.Cells("Cajas").Value.ToString & "[tab][enter]") Then Return

                Dim Respuesta As MsgBoxResult
                Respuesta = MsgBox(" ¿Hay existencias suficientes?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿Hay existencias ")
                If Respuesta = MsgBoxResult.Yes Then

                Else
                    'Pulsar F23 para continuar
                    If macrosender.SiExisteTextoTeclea("No hay existencias", 24, 2, "[pf23]") Then Return

                End If

                'Precio:
                If macrosender.SiExisteTextoTeclea("Precio", 21, 52, "[enter][enter]") Then Return

                'Lote:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Texto", 21, 15, "L-" & m_Row.Cells("Lote").Value.ToString & "[enter]") Then Return
            Next

            MsgBox("Introducir palets manualmente. Pulsa Aceptar para continuar", MsgBoxStyle.Information)

            Respuesta = MsgBox(" ¿Todo correcto?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If



            If Respuesta = MsgBoxResult.Yes Then

                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab]P[tab]") Then Return

                'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                If macrosender.SiExisteTextoTeclea("Envio", 8, 37, "FUENTES E HIJOS[tab]") Then Return

                'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                Matricula = txtRemolque1.Text
                Matricula = Matricula + Space(8)
                Matricula = Matricula.ToString.Substring(0, 8)
                If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                Chofer = txtConductor.Text
                Chofer = Chofer + Space(20)
                Chofer = Chofer.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)
                DNI = txtDNI.Text
                DNI = DNI + Space(15)
                DNI = DNI.ToString.Substring(0, 15)
                If macrosender.SiExisteTextoTeclea("DNI", 9, 55, DNI) Then Return

                'Descarga: Tiene que poner la fecha de hoy
                Fecha = System.DateTime.Today.ToString
                If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[tab][tab]") Then Return

                'Precio Kilo: OJO SOLO PUEDE CONTENER 5 DoubleES
                PesoBruto = InputBox("Introduce Peso bruto", "Peso bruto")
                PrecioKilo = Format(PrecioPorte / PesoBruto, "#0.#0000")
                If macrosender.SiExisteTextoTeclea("Precio", 11, 3, PrecioKilo.ToString + "[tab][enter]") Then Return
                'El precio Kilo es lo que da dividir el precio acordado (352,80) entre el peso neto en QS


                Dim Respuesta1 As MsgBoxResult
                Respuesta1 = MsgBox(" ¿Hay que pulsar F23?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿F23 ")
                If Respuesta1 = MsgBoxResult.Yes Then
                    'Pulsar F23 para continuar
                    If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

                Else
                End If
                'If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then return

                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3][pf12][pf12]") Then Return


            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf12][pf3][pf12][pf12]") Then Return

            End If


        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
            Return
        End Try

        Dim cabecera As String
        Dim texto As String
        Dim detalle As String
        Dim pie As String
        Dim pie2 As String
        Dim tlf As String
        Dim fecha_recogida As Date = Now.Date.AddDays(1)
        If fecha_recogida.DayOfWeek = DayOfWeek.Saturday Then fecha_recogida.AddDays(2)

        pie2 = txtDNI.Text
        pie = txtConductor.Text

        Try
            tlf = dtb.Consultar("select movil from conductores where dni='" & pie2 & "'", False).Rows(0).Item(0).ToString
        Catch ex As Exception
            tlf = InputBox("No se pudo recuperar el telefono de contacto del conductor. Introduzcalo manualmente")
        End Try


        detalle = "Mi teléfono de contacto es " & tlf & _
            Environment.NewLine & Environment.NewLine & _
            Environment.NewLine & Environment.NewLine & _
            Environment.NewLine & "Firmado:"

        texto = "Yo, D. " & pie & ", con DNI " & pie2 & " firmo que he sido informado de la obligación de entergar la mercancía hoy recogida en Vinagrería La Andaluza, a las " _
            & "07:00 del dia " & fecha_recogida.Day & " de " & _
            fecha_recogida.ToString("MMMM", Globalization.CultureInfo.CreateSpecificCulture("es-ES")) & ", en su lugar de entrega." & Environment.NewLine & _
            "En caso de no poder cumplir con los horarios previstos ponerse en contacto con Francisco Gallego Vidal o Cesar Monserrate (tl.968830979)"

        cabecera = "En Jerez de la Frontera a " & Now.Date.Day.ToString & " de " & Now.Date.ToString("MMMM", Globalization.CultureInfo.CreateSpecificCulture("es-ES")) & " de " & Now.Date.Year


        Dim a As New Carta_de_portes.frmCartaDePortes(cabecera, texto, detalle, pie, pie2)
        a.ShowDialog()
    End Sub

    Private Sub butMercadonaCanarias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butMercadonaCanarias.Click
        'QS.SalidaMecadonaCanarias(txtRemolque1.Text, txtConductor.Text, txtDNI.Text)
        Try
            Dim Pedido As Integer
            Dim Consignatario As String
            Dim NIF As String
            Dim Direccion As String
            Dim Municipio As String
            Dim CodigoPostal As String
            Dim Pais As String = "11"
            Dim Matricula As String
            Dim Chofer As String
            Dim DNI As String
            Dim Fecha As String
            Dim Contenedor As String
            Dim Precinto As String
            Pedido = CType(InputBox("Introduce numero de pedido", "Pedido"), Integer)


            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()

            If macrosender.espera Then
                macrosender.Enviar("[pf3][enter]")
            Else
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
                macrosender.Enviar("[pf3][enter]")
            End If

            If macrosender.SiExisteTextoTeclea("Usuario", 6, 17, "JEREZ999[tab]") Then Return
            If macrosender.SiExisteTextoTeclea("Contraseña", 7, 17, "JEREZ[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Ventas", 6, 8, "[pf1]") Then Return
            If macrosender.SiExisteTextoTeclea("Conexión a Empresa", 19, 32, "999[enter][enter]") Then Return
            If macrosender.SiExisteTextoTeclea("J.R. SABATER", 1, 31, "11[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, Pedido.ToString + "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "[enter][enter]") Then Return


            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox(" ¿Hay que pulsar F23?", _
                               MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                               " ¿F23 ")
            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F23 para continuar
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

            Else
            End If

            Respuesta = MsgBox(" ¿Todo correcto?", _
                                 MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                 " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab][tab]") Then Return

                'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                'Para rellenar los datos del packing list
                If macrosender.SiExisteTextoTeclea("Envio", 8, 37, "[pf2]") Then Return

                'Consignatario: 30 espacios
                Consignatario = InputBox("Introduce nombre empresa cargadora", "Consignatario")
                Consignatario = Consignatario + Space(30)
                Consignatario = Consignatario.ToString.Substring(0, 30)
                'MsgBox(Consignatario.Length.ToString)
                If macrosender.SiExisteTextoTeclea("Consignatario", 14, 6, Consignatario) Then Return

                'NIF: 15 espacios
                NIF = InputBox("Introduce NIF empresa cargadora", "NIF")
                NIF = NIF + Space(15)
                NIF = NIF.ToString.Substring(0, 15)
                If macrosender.SiExisteTextoTeclea("N.I.F.", 14, 56, NIF) Then Return

                'Direccion: 2 espacios + 25 espacios
                Direccion = InputBox("Introduce direccion empresa cargadora", "Direccion")
                Direccion = Direccion + Space(27)
                Direccion = Direccion.ToString.Substring(0, 27)
                If macrosender.SiExisteTextoTeclea("Dirección", 15, 10, Direccion + "[tab][tab]") Then Return

                'Municipio: 25 espacios
                Municipio = InputBox("Introduce municipio empresa cargadora", "Municipio")
                Municipio = Municipio + Space(25)
                Municipio = Municipio.ToString.Substring(0, 25)
                If macrosender.SiExisteTextoTeclea("Municipio", 16, 10, Municipio) Then Return

                'CodigoPostal: 5 espacios
                CodigoPostal = InputBox("Introduce codigo postal empresa cargadora", "CodigoPostal")
                CodigoPostal = CodigoPostal + Space(5)
                CodigoPostal = CodigoPostal.ToString.Substring(0, 5)
                If macrosender.SiExisteTextoTeclea("Cód.Postal", 16, 50, CodigoPostal + "[tab]") Then Return

                'Pais: 2 espacios - HAY QUE SELECCIONARLOS DE UNA LISTA
                If macrosender.SiExisteTextoTeclea("Pais", 17, 9, Pais + "[tab]") Then Return

                'Prov: 2 espacios - HAY QUE SELECCIONARLOS DE UNA LISTA
                MsgBox("Introduce provincia selecionando de la lista de la lista NO PULSAR ENTER", MsgBoxStyle.Information)
                If macrosender.SiExisteTextoTeclea("Prov", 17, 14, "[enter][enter]") Then Return

                'Para continuar rellenando datos
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab][tab][tab]") Then Return

                'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                Matricula = txtRemolque1.Text
                Matricula = Matricula + Space(8)
                Matricula = Matricula.ToString.Substring(0, 8)
                If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                Chofer = txtConductor.Text
                Chofer = Chofer + Space(20)
                Chofer = Chofer.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)
                DNI = txtDNI.Text
                DNI = DNI + Space(15)
                DNI = DNI.ToString.Substring(0, 15)
                If macrosender.SiExisteTextoTeclea("DNI", 9, 55, DNI) Then Return

                'Descarga: Tiene que poner la fecha de hoy
                Fecha = System.DateTime.Today.ToString
                If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[tab]") Then Return

                'Contenedor
                Contenedor = InputBox("Introduce numero contenedor", "Contenedor")
                If macrosender.SiExisteTextoTeclea("Contenedor", 10, 53, Contenedor + "[tab]") Then Return

                'Para ponernos en el campo observaciones
                If macrosender.SiExisteTextoTeclea("Precio", 11, 3, "[tab][tab][tab][tab][tab][tab][tab][tab]") Then Return

                'Observaciones:
                Precinto = InputBox("Introduce numero precinto", "Precinto")
                Precinto = "Nº precinto: " + Precinto
                If macrosender.SiExisteTextoTeclea("Observaciones", 21, 1, Precinto + "[enter]") Then Return

                Dim Respuesta1 As MsgBoxResult
                Respuesta1 = MsgBox(" ¿Hay que pulsar F23?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿F23 ")
                If Respuesta1 = MsgBoxResult.Yes Then
                    'Pulsar F23 para continuar
                    If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

                Else
                End If

                'If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then return
                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return

            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][pf12][pf12][pf3]") Then Return


            End If

        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub butAlbaranProvisional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAlbaranProvisional.Click
        'QS.AlbaranProvisional(txtRemolque1.Text, txtConductor.Text, txtDNI.Text, cboClientes.SelectedText)
        Try
            'Albaran Provisional

            Dim Albaran As String
            Dim Serie As String
            Dim CodigoQS As String
            Dim CIF As String

            'Dim LugarEntrega As String
            'Dim DescripcionMercancia As String
            'Dim NumeroDocumento As String
            Dim OperadorTransporte As String
            'Dim MatriculaRemolque As String
            Dim FechaEntrega As String
            Dim Portes As String
            'Dim Transportista As String
            'Dim DNITransportista As String
            'Dim PesoBruto As String
            Dim Anchocolumna As Integer = 300
            Dim Anchocolumna1 As Integer = 300
            Dim Fecha As String = System.DateTime.Today.ToString.Substring(0, 10)
            Dim Fila As Integer = 1
            Dim DireccionJRSabater As String = "    J.R.SABATER, S.A." + Environment.NewLine + _
                                               "    AV. MURCIA, 61 APARTADO 59" + Environment.NewLine + _
                                               "    30110 - CABEZO DE TORRES" + Environment.NewLine + _
                                               "    MURCIA         TELF: 968830979" + Environment.NewLine



            Dim oWord As New Microsoft.Office.Interop.Word.Application
            Dim oDoc As Microsoft.Office.Interop.Word.Document
            Dim oTablaTitulo As Microsoft.Office.Interop.Word.Table

            oWord.Visible = False
            oDoc = oWord.Documents.Add
            oWord.ActiveWindow.Selection.Style = Microsoft.Office.Interop.Word.WdBuiltinStyle.wdStylePlainText

            With oDoc.PageSetup
                Try
                    .PaperSize = Microsoft.Office.Interop.Word.WdPaperSize.wdPaperA4
                Catch ex As Exception
                End Try
                Try
                    .Orientation = Microsoft.Office.Interop.Word.WdOrientation.wdOrientPortrait
                Catch ex As Exception
                End Try
                .LeftMargin = oWord.CentimetersToPoints(1)
                .RightMargin = oWord.CentimetersToPoints(1)
                .BottomMargin = oWord.CentimetersToPoints(1)
                .TopMargin = oWord.CentimetersToPoints(1)
            End With

            oTablaTitulo = oDoc.Tables.Add(oDoc.Bookmarks.Item("\endofdoc").Range, 23, 1)
            With oTablaTitulo
                .Range.Cells.VerticalAlignment = Microsoft.Office.Interop.Word.WdCellVerticalAlignment.wdCellAlignVerticalCenter
                .Borders.InsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                .Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble
                '.Cell(1, 1).Range.InsertAfter("")

                '.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                '.Cell(1, 1).Width = oWord.PixelsToPoints(600)
                '.Cell(1, 1).Range.Font.Size = 18

                .Cell(1, 1).Split(1, 2)
                '.Cell(1, 1).Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter
                .Rows.Item(2).Range.Font.Size = 9
                .Cell(2, 1).Range.Font.Name = "Arial"
                '.mam_FormatoLinea(1, 2, 273, 36, WdParagraphAlignment.wdAlignParagraphCenter, "ALBARAN")

                '.Cell(2, 1).Split(1, 2)
                '.Cell(3, 1).Split(1, 2)
                '.Cell(3, 2).Split(1, 6)
                '.mam_FormatoLineaTitulo(3, 2, 40, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "NUMERO")
                '.mam_FormatoLineaTitulo(3, 3, 30, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "SERIE")
                '.mam_FormatoLineaTitulo(3, 4, 68, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "FECHA")
                '.mam_FormatoLineaTitulo(3, 5, 45, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "CODIGO")
                '.mam_FormatoLineaTitulo(3, 6, 30, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "TIPO")
                '.mam_FormatoLineaTitulo(3, 7, 60, 7, WdParagraphAlignment.wdAlignParagraphCenter, True, "DNI/CIF")

                .mam_FormatoLinea(1, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .mam_FormatoLinea(1, 2, 260, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "ALBARAN")

                .Cell(2, 1).Split(1, 2)
                .mam_FormatoLinea(2, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .Cell(3, 1).Split(1, 2)
                .Cell(3, 2).Split(1, 6)
                .mam_FormatoLinea(3, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .mam_FormatoLineaTitulo(3, 2, 27, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "NUMERO")
                .mam_FormatoLineaTitulo(3, 3, 30, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "SERIE")
                .mam_FormatoLineaTitulo(3, 4, 68, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FECHA")
                .mam_FormatoLineaTitulo(3, 5, 45, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CODIGO")
                .mam_FormatoLineaTitulo(3, 6, 30, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TIPO")
                .mam_FormatoLineaTitulo(3, 7, 60, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "DNI/CIF")

                .Cell(4, 1).Split(1, 2)
                .mam_FormatoLinea(4, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")

                Albaran = InputBox("Introduce numero de albaran sin serie", "Albaran")
                Serie = InputBox("Introduce letra de la serie", "Serie")
                CodigoQS = InputBox("Introduce codigo QS del cliente", "CodigoQS")
                CIF = InputBox("Introduce CIF del cliente", "CIF")

                .Cell(4, 2).Split(1, 6)
                .mam_FormatoLinea(4, 2, 27, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Albaran)
                .mam_FormatoLinea(4, 3, 30, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Serie)
                .mam_FormatoLinea(4, 4, 68, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Fecha)
                .mam_FormatoLinea(4, 5, 45, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, CodigoQS)
                .mam_FormatoLinea(4, 6, 30, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, " ")
                .mam_FormatoLinea(4, 7, 60, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, CIF)

                .Cell(5, 1).Split(1, 2)
                .mam_FormatoLinea(5, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .Cell(5, 2).Split(1, 2)
                .mam_FormatoLineaTitulo(5, 2, 140, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CENTRO")
                .mam_FormatoLineaTitulo(5, 3, 120, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FORMA PAGO")

                .Cell(6, 1).Split(1, 2)
                .mam_FormatoLinea(6, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .Cell(6, 2).Split(6, 2)
                .mam_FormatoLinea(6, 2, 140, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "JEREZ FRONT.ALMAC.EMBOT.VLAND")
                .mam_FormatoLinea(6, 3, 120, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "PAGARE 85 DIAS F.F.")

                .Cell(7, 1).Split(1, 2)
                .mam_FormatoLinea(7, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .Cell(8, 1).Split(1, 2)
                .mam_FormatoLinea(8, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .mam_FormatoLineaTitulo(8, 2, 140, 12, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "NOMBRE / DIRECCION ENTREGA")

                .Cell(9, 1).Split(1, 2)
                .mam_FormatoLinea(9, 1, 300, 36, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, "")
                .mam_FormatoLinea(9, 2, 140, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  DireccionJRSabater + _
                                  Environment.NewLine)

                .Cell(1, 1).Merge(.Cell(9, 1))


                .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderBottom).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(1, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .Cell(2, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(2, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .Cell(7, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(7, 2).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(10, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderTop).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(9, 2).Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleDouble

                'Albaran = InputBox("Introduce numero de albaran", "Albaran")
                'Serie = InputBox("Introduce letra de la serie", "Serie")
                'CodigoQS = InputBox("Introduce codigo QS del cliente", "CodigoQS")
                'CIF = InputBox("Introduce CIF del cliente", "CIF")

                .Cell(11, 1).Split(1, 9)
                .mam_FormatoLineaTitulo(11, 1, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "COD.ART")
                .mam_FormatoLineaTitulo(11, 2, 25, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "LOTE")
                .mam_FormatoLineaTitulo(11, 3, 60, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "CANTIDAD")
                .mam_FormatoLineaTitulo(11, 4, 20, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "UM")
                .mam_FormatoLineaTitulo(11, 5, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "EAN FORMATO ENVASE")
                .mam_FormatoLineaTitulo(11, 6, 170, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "PRODUCTOS")
                .mam_FormatoLineaTitulo(11, 7, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "PRECIO")
                .mam_FormatoLineaTitulo(11, 8, 20, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "UM")
                .mam_FormatoLineaTitulo(11, 9, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IMPORTE")

                .Cell(12, 1).Split(1, 9)
                .mam_FormatoLinea(12, 1, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 2, 25, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 3, 60, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphRight, Environment.NewLine + _
                                Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 4, 20, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, Environment.NewLine + _
                               Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 5, 100, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                              Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 6, 170, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                               Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 7, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                               Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 8, 20, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                               Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(12, 9, 50, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                 Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)


                .Cell(13, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(13, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .Cell(14, 1).Split(1, 7)
                .mam_FormatoLineaTitulo(14, 1, 75, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TOTAL")
                .mam_FormatoLineaTitulo(14, 2, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "BASE IMPONIBLE")
                .mam_FormatoLineaTitulo(14, 3, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IVA %")
                .mam_FormatoLineaTitulo(14, 4, 70, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "IVA IMPORTE")
                .mam_FormatoLineaTitulo(14, 5, 50, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "R.E. %")
                .mam_FormatoLineaTitulo(14, 6, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "R.E. IMPORTE")
                .mam_FormatoLineaTitulo(14, 7, 100, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "TOTAL ALBARAN")

                .Cell(15, 1).Split(1, 7)
                .mam_FormatoLinea(15, 1, 75, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(15, 2, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(15, 3, 50, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(15, 4, 70, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                  Environment.NewLine + _
                                  Environment.NewLine)

                .mam_FormatoLinea(15, 5, 50, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                .mam_FormatoLinea(15, 6, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                .mam_FormatoLinea(15, 7, 100, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)



                .Cell(16, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(16, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .mam_FormatoLineaTitulo(17, 1, 545, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "OBSERVACIONES")

                .mam_FormatoLinea(18, 1, 545, 10, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                .Cell(19, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(19, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone

                .Cell(20, 1).Split(1, 2)
                .mam_FormatoLineaTitulo(20, 1, 360, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "DATOS DEL TRANSPORTISTA")
                .mam_FormatoLineaTitulo(20, 2, 185, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter, True, "FIRMA Y SELLO DEL CLIENTE")

                .Cell(21, 1).Split(1, 3)
                OperadorTransporte = InputBox("Introduce Empresa cargadora", "OperadorTransporte")
                FechaEntrega = InputBox("Introduce Fecha de entrega", "FechaEntrega")
                Portes = InputBox("Introduce tipo de porte", "Portes")

                .mam_FormatoLinea(21, 1, 180, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      "TRANSPORTISTA: " + OperadorTransporte + _
                                      Environment.NewLine + _
                                      "MATRICULA: " + txtRemolque1.Text + _
                                      Environment.NewLine + _
                                      "FECHA DE ENTREGA: " + FechaEntrega + _
                                      Environment.NewLine + _
                                      "PORTES: " + Portes + _
                                      Environment.NewLine)

                'Transportista = InputBox("Introduce nombre del conductor", "Transportista")
                'DNITransportista = InputBox("Introduce DNI del conductor", "DNITransportista")

                .mam_FormatoLinea(21, 2, 180, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      "NOMBRE DEL CONDUCTOR: " + txtConductor.Text + _
                                      Environment.NewLine + _
                                      "DNI: " + txtDNI.Text + _
                                      Environment.NewLine + _
                                      "FIRMA:" + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine)

                .mam_FormatoLinea(21, 3, 185, 7, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, Environment.NewLine + _
                                      "NOMBRE DEL CLIENTE " + cboClientes.SelectedText.ToString + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      Environment.NewLine + _
                                      "FECHA DE CARGA " + Fecha + _
                                      Environment.NewLine)

                .Cell(22, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderLeft).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(22, 1).Borders(Microsoft.Office.Interop.Word.WdBorderType.wdBorderRight).LineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .Cell(23, 1).Borders.OutsideLineStyle = Microsoft.Office.Interop.Word.WdLineStyle.wdLineStyleNone
                .mam_FormatoLinea(23, 1, 545, 9, Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft, "UM: CJ=CAJAS:BT=BOTELLAS:CJ=CAJEXPOSIT:UN=UNIDADES")

                '.mam_FormatoLinea(26, 1, 545, 5, WdParagraphAlignment.wdAlignParagraphLeft, "Vinagrería La Andaluza, S.L. inscrita en el Registro Mercantil de Cadiz.Tomo 1682.Libro 0.Folio 31.Sección 8.Hoja CA27329-CIF ES-B11826617")
            End With

            oDoc.ActiveWindow.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekPrimaryFooter
            oWord.Selection.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
            oWord.Selection.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlue
            oWord.Selection.Font.Size = 9
            oWord.Selection.TypeText(Text:="Vinagrería La Andaluza, S.L. inscrita en el Registro Mercantil de Cadiz.Tomo 1682.Libro 0.Folio 31.Sección 8.Hoja CA27329-CIF ES-B11826617")

            'oWord.Selection.TypeText(Text:="V. La Andaluza, S.L." & Environment.NewLine & _
            '                               "C/ Marquetería, 7. 11408 Jerez de la Frontera. Cádiz. España." & Environment.NewLine & _
            '                               "Teléfono: +34 956144538; Fax: +34 956142230" & Environment.NewLine & _
            '                               "calidad@landaluza.es  www.landaluza.es")

            'oDoc.ActiveWindow.View.SeekView = WdSeekView.wdSeekPrimaryFooter
            'oWord.Selection.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphRight
            'oWord.Selection.Font.Color = WdColor.wdColorBlue
            'oWord.Selection.Font.Size = 12
            'oWord.Selection.TypeText(Text:=Now)

            oDoc.ActiveWindow.ActivePane.View.SeekView = Microsoft.Office.Interop.Word.WdSeekView.wdSeekMainDocument
            oWord.Visible = True
            oWord.NormalTemplate.Saved = True
            oWord = Nothing
            oDoc = Nothing
            'Me.Dispose()
        Catch ex As Exception
            MessageBox.Show("Ocurrio un error." & Environment.NewLine & " Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub butRegistrarPortesSalidaQS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRegistrarPortesSalidaQS.Click
        ' QS.RegistroPortes(dgvTotalPalets)
        Try
            Dim Albaran As String
            Dim Cantidad As String
            Dim Precio As String

            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()
            'Enviar las pulsaciones de teclas a la aplicación
            If macrosender.SiExisteTextoTeclea("Area de Gestión", 7, 8, "12[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Compra y Facturación", 15, 8, "23[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albaranes", 7, 8, "12[enter]") Then Return

            'Albarán:
            Albaran = InputBox("Introduce numero de albaran", "Albaran")
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 9, Albaran + "[tab]") Then Return

            'Proveedor:
            If macrosender.SiExisteTextoTeclea("Proveedor", 4, 7, "6000009[tab][enter]") Then Return

            'Pedido:
            If macrosender.SiExisteTextoTeclea("Pedido", 5, 10, "[enter]") Then Return

            'Almacen:
            If macrosender.SiExisteTextoTeclea("Almacén", 7, 1, "10[tab][enter]") Then Return

            'Tarifa:
            If macrosender.SiExisteTextoTeclea("Tarifa", 8, 2, "[enter]") Then Return

            'Cod.Articulo
            If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "900002001[tab][tab]") Then Return

            'Cantidad
            Cantidad = InputBox("Introduce cantidad", "Cantidad")
            If macrosender.SiExisteTextoTeclea("Cantidad", 20, 6, Cantidad.ToString + "[tab]") Then Return

            'Unidad medida
            If macrosender.SiExisteTextoTeclea("U.Medida", 20, 30, "2[tab][enter]") Then Return

            'Precio:
            Precio = InputBox("Introduce precio", "Precio")
            Precio = Precio + Space(14)
            Precio = Precio.ToString.Substring(0, 14)
            If macrosender.SiExisteTextoTeclea("Precio", 21, 2, Precio + "[tab][enter][enter]") Then Return


            Respuesta = MsgBox(" ¿Todo correcto?", _
                                   MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                   " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 7, 2, "N[enter][enter]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3][pf12][pf12]") Then Return


            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][enter][pf12][pf12][pf3][pf12][pf12]") Then Return

            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub ButEmbotelladoPedido_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButEmbotelladoPedido.Click
        ' QS.Embotellado_pedido(txtRemolque1.Text, txtConductor.Text, txtDNI.Text)
        Try
            Dim Pedido As String
            Dim Transportista As String
            Dim Matricula As String
            Dim Chofer As String
            Dim DNI As String
            Dim Fecha As String

            If Not Me.macrosender.conectar() Then
                MessageBox.Show("No se pudo conectar con QS", "Atencion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return
            End If

            My.Computer.Clipboard.Clear()
            'Enviar las pulsaciones de teclas a la aplicación
            If macrosender.SiExisteTextoTeclea("Area Comercial", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Venta y Facturación", 10, 8, "14[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albaranes", 8, 8, "13[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Albarán", 3, 2, "[enter]") Then Return
            Pedido = InputBox("Introduce numero de pedido", "Pedido")
            If macrosender.SiExisteTextoTeclea("Pedido", 4, 3, Pedido + "[enter]") Then Return
            If macrosender.SiExisteTextoTeclea("Cliente", 4, 2, "[enter][enter]") Then Return

            Dim Respuesta As MsgBoxResult
            Respuesta = MsgBox(" ¿Hay que pulsar F23?", _
                               MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                               " ¿F23 ")
            If Respuesta = MsgBoxResult.Yes Then

                'Pulsar F23 para continuar
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return

            Else
            End If

            Respuesta = MsgBox(" ¿Todo correcto?", _
                                 MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.YesNo, _
                                 " ¿Verificación ")

            If Not macrosender.espera Then
                MsgBox("Hay un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa la tecla [Control]", MsgBoxStyle.Information)
            End If

            If Not macrosender.espera Then
                MsgBox("Sigue existiendo un error esperando en QS." & Chr(13) & "Pulsa sobre la ventana de QS y usa compruebalo.", MsgBoxStyle.Information)
            End If

            If Respuesta = MsgBoxResult.Yes Then
                'Pulsar F20 para grabar:
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf20]") Then Return
                'Tipo de porte:
                If macrosender.SiExisteTextoTeclea("Tipo", 8, 3, "[tab][tab]") Then Return

                'Envio:Tiene que pedir la compañia que carga - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES) 
                Transportista = InputBox("Introduce Transportista", "Transportista")
                Transportista = Transportista + Space(20)
                Transportista = Transportista.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Envio", 8, 37, Transportista) Then Return

                'Matricula: Tiene que pedirla - OJO CON EL TAMAÑO DEL HUECO (8 POSICIONES)
                Matricula = txtRemolque1.Text
                Matricula = Matricula + Space(8)
                Matricula = Matricula.ToString.Substring(0, 8)
                If macrosender.SiExisteTextoTeclea("Matrícula", 9, 2, Matricula) Then Return

                'Chofer: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (20 POSICIONES)
                Chofer = txtConductor.Text
                Chofer = Chofer + Space(20)
                Chofer = Chofer.ToString.Substring(0, 20)
                If macrosender.SiExisteTextoTeclea("Chofer", 9, 24, Chofer) Then Return

                'DNI: Tiene que pedirlo - OJO CON EL TAMAÑO DEL HUECO (15 POSICIONES)
                DNI = txtDNI.Text
                DNI = DNI + Space(15)
                DNI = DNI.ToString.Substring(0, 15)
                If macrosender.SiExisteTextoTeclea("DNI", 9, 55, DNI) Then Return

                'Descarga: Tiene que poner la fecha de hoy
                Fecha = System.DateTime.Today.AddDays(1).ToString
                If macrosender.SiExisteTextoTeclea("Descarga", 10, 2, Fecha + "[enter]") Then Return
                If macrosender.SiExisteTextoTeclea("Riesgo Concedido", 24, 2, "[pf23]") Then Return
                'Pulsar F5 para imprimir
                If macrosender.SiExisteTextoTeclea("F5=Imprimir", 23, 2, "[pf5]") Then Return
                'Volver pantalla principal
                If macrosender.SiExisteTextoTeclea("El albarán", 24, 2, "[pf3]") Then Return

            Else
                'Volver a la pantalla principal
                If macrosender.SiExisteTextoTeclea("Cód.Articulo", 19, 2, "[pf12][pf12][pf12][pf3][pf12][pf12]") Then Return


            End If
        Catch ex As Exception
            MsgBox("Ocurrio un error." & vbLf & " Detalles: " & ex.Message, MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub MatriculaCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MatriculaCuadroDeTexto.TextChanged
        Me.txtCabeza.Text = Me.MatriculaCuadroDeTexto.Text
    End Sub

    Private Sub Reserva1CuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Reserva1CuadroDeTexto.TextChanged
        Me.txtRemolque1.Text = Reserva1CuadroDeTexto.Text
    End Sub

    Private Sub ConductorCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductorCuadroDeTexto.TextChanged
        txtConductor.Text = ConductorCuadroDeTexto.Text
    End Sub

    Private Sub ConductorDNICuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConductorDNICuadroDeTexto.TextChanged
        txtDNI.Text = ConductorDNICuadroDeTexto.Text
    End Sub

    Private Sub AgenciaIDCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgenciaIDCuadroDeTexto.TextChanged
        CuadroDeTexto6.Text = AgenciaIDCuadroDeTexto.Text
    End Sub

    Private Sub PorteFormaPagoIDCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorteFormaPagoIDCuadroDeTexto.TextChanged
        CuadroDeTexto4.Text = PorteFormaPagoIDCuadroDeTexto.Text
    End Sub

    Private Sub PorteImporteCuadroDeTexto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorteImporteCuadroDeTexto.TextChanged
        CuadroDeTexto2.Text = PorteImporteCuadroDeTexto.Text
    End Sub

    Private Sub frmEntAlbaranesCargaMaestro_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
        Me.cboClientes.SelectedValue = Me.v_cliente + 1
        Me.cboConductores.SelectedIndex = Me.cboConductores.FindString(Me.v_conductor)
    End Sub

    Private Sub MarcarComoMultiloteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MarcarComoMultiloteToolStripMenuItem.Click
        Try
            BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update paletsproducidos set multilote=1 where scc = " & Me.dgvPalet.CurrentRow.Cells("SCC").Value)
            RellenarDgv()
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub MarcarComoNoMultiloteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles MarcarComoNoMultiloteToolStripMenuItem.Click
        Try
            BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update paletsproducidos set multilote=1 where scc = " & Me.dgvPalet.CurrentRow.Cells("SCC").Value)
            RellenarDgv()
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CambiarLoteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles CambiarLoteToolStripMenuItem1.Click
        Try
            Dim lote As String = InputBox("Introduce el nuevo lote")
            If lote <> "" Then
                If IsNumeric(lote) Then
                    BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update AlbaranesCargaProviDetalles set loteAlternativo=" & lote & " where  CodigoQS=" & Me.dgvAcumulados.CurrentRow.Cells("CodigoQS").Value & " and AlbaranCargaProviMaestroID = " & Me.dgvAcumulados.CurrentRow.Cells("AlbaranCargaProviMaestroID").Value)
                    RellenarDgv()
                End If
            End If
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CambiarLoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles CambiarLoteToolStripMenuItem.Click
        Try
            Dim lote As String = InputBox("Introduce el nuevo lote")
            If lote <> "" Then
                If IsNumeric(lote) Then
                    BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update AlbaranesCargaProviDetalles set loteAlternativo=" & lote & " where  AlbaranCargaProviDetalleID = " & Me.dgvPalet.CurrentRow.Cells("AlbaranCargaProviDetalleID").Value)
                    RellenarDgv()
                End If
            End If
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReiniciarLoteToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ReiniciarLoteToolStripMenuItem1.Click
        Try
            BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update AlbaranesCargaProviDetalles set loteAlternativo=null where  AlbaranCargaProviDetalleID = " & Me.dgvPalet.CurrentRow.Cells("AlbaranCargaProviDetalleID").Value)
            RellenarDgv()
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub ReiniciarLoteToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ReiniciarLoteToolStripMenuItem.Click
        Try
            BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update AlbaranesCargaProviDetalles set loteAlternativo=null where  CodigoQS=" & Me.dgvAcumulados.CurrentRow.Cells("CodigoQS").Value & " and AlbaranCargaProviMaestroID = " & Me.dgvAcumulados.CurrentRow.Cells("AlbaranCargaProviMaestroID").Value)
            RellenarDgv()
        Catch ex As Exception
            messagebox.show("Error al realizar la operacion. Detalles: " & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles EliminarToolStripMenuItem.Click
        ''pendiente de revision con calidad y control
        Dim frmDevolucionCarga As New frmDevolucionCarga(dgvPalet.CurrentRow.Cells("SCC").Value)
        If frmDevolucionCarga.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            RellenarDgv()
        End If
    End Sub

 

End Class