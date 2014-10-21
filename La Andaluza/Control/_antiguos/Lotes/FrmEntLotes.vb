Imports BasesParaCompatibilidad.dtpExtension

Public Class FrmEntLotes
    Private dtsMue As dtsLotes.LotesDataTable
    Private dtsCompuestoPor As dtsLotesComponentes.LotesComponentesDataTable
    Private dtsComponenteDe As dtsLotesComponentes.LotesComponentesDataTable
    Private dtsTrazabilidad As dtsLotesTrazabilidad.LotesTrazabilidadDataTable

    Private Especificacion As String

    Private ctlDep As ctlDepositos
    Private ctlLot As ctlLotes
    Private ctlTipLot As spTiposLotes
    Private spTiposProductos As spTiposProductos
    Private ctlCor As spCorredores
    Private ctlProv As spProveedores
    Private ctlEsp As ctlEspecificaciones
    Private ctlMed As spMuestrasMedidas
    Private ctlCant As spMuestrasCantidades
    'Private ctlLabExt As spProveedores
    Private ctlRecSal As spRecipientesSalidas 'ctlRecipientesSalidas

    Private LoteID As Integer
    Private AnaliticaID As Integer
    Private AnaliticaExternaID As Integer
    Private tTipLot As DataTable
    Private Bandera_EntroCon As Integer
    Private Bandera_SinEspecificacion As Boolean

    Private ConEnologicos As Boolean
    Private TipoLoteID, TipoProductoID As Integer

    Private tsTrazabilidad As ToolStripButton
    Private tsBoletin As ToolStripButton
    Private tsCantidad As ToolStripButton
    Private tsaprobar As ToolStripButton
    Private tsdeprobar As ToolStripButton
    Private tsrepetir As ToolStripButton
    Private OldLib As OldLib
    Private spTiposLotes As spTiposLotes
    Private spEmpleados As spEmpleados
    Private frmControlesPorLote As frmControlesPorLote
    Private spElaboraciones As spElaboraciones
    Private frmTRazabilidad As frmTrazabilidad
    Private dtb As BasesParaCompatibilidad.DataBase

    Private dbo As DBO_Lotes1
    Private sp As spLotes1


    Public Sub New()

        InitializeComponent()

        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        sp = New spLotes1
        Me.dtsMue = New dtsLotes.LotesDataTable
        Me.dtsCompuestoPor = New dtsLotesComponentes.LotesComponentesDataTable
        Me.dtsComponenteDe = New dtsLotesComponentes.LotesComponentesDataTable
        Me.dtsTrazabilidad = New dtsLotesTrazabilidad.LotesTrazabilidadDataTable
        Me.ctlDep = New ctlDepositos
        Me.ctlLot = New ctlLotes
        Me.ctlTipLot = New spTiposLotes
        Me.spTiposProductos = New spTiposProductos
        Me.ctlCor = New spCorredores 'ctlCorredores
        Me.ctlProv = New spProveedores
        Me.ctlEsp = New ctlEspecificaciones
        Me.ctlMed = New spMuestrasMedidas
        Me.ctlCant = New spMuestrasCantidades
        ' Me.ctlLabExt = New ctlProveedores
        'Dim ctlPer As New ctlPersonal
        Me.ctlRecSal = New spRecipientesSalidas
        Me.tTipLot = New DataTable
        Me.OldLib = New OldLib
        Me.spTiposLotes = New spTiposLotes
        Me.spEmpleados = New spEmpleados
        Me.spElaboraciones = New spElaboraciones

        tsBoletin = Me.bdnGeneral.Items.Add("Imprimir Boletin")
        tsBoletin.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsBoletin.Image = My.Resources.imprimir_16
        tsBoletin.TextDirection = ToolStripTextDirection.Horizontal
        tsBoletin.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsBoletin.Click, AddressOf btnImprimirBoletin_Click
        Me.btnImprimirBoletin.Visible = False


        tsTrazabilidad = Me.bdnGeneral.Items.Add("Informe Trazabilidad")
        tsTrazabilidad.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
        tsTrazabilidad.Image = My.Resources.emblem_documents
        tsTrazabilidad.TextDirection = ToolStripTextDirection.Horizontal
        tsTrazabilidad.TextAlign = ContentAlignment.MiddleRight
        AddHandler tsTrazabilidad.Click, AddressOf butInfoTrazabilidad_Click
        Me.butInfoTrazabilidad.Visible = False

        If Config.UserType = 9 Or Config.UserType = 4 Then
            tsCantidad = Me.bdnGeneral.Items.Add("Cambiar cantidad")
            tsCantidad.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
            tsCantidad.Image = My.Resources.view_process_own
            tsCantidad.TextDirection = ToolStripTextDirection.Horizontal
            tsCantidad.TextAlign = ContentAlignment.MiddleRight
            AddHandler tsCantidad.Click, AddressOf cambiar_cantidad
        End If
    End Sub
    Public Sub CargarDatos(ByVal pos As Integer, ByVal ID As Integer, ByVal TipLot As Integer, ByVal TipPro As Integer, ByVal ConEnologic As Boolean)
        Posicion = pos
        LoteID = ID
        TipoLoteID = TipLot
        TipoProductoID = TipPro
        'poner id a todos los unicos EsUnicoID
        txtDescripcion.EsUnicoID = LoteID
        txtCodigoLote.EsUnicoID = LoteID
        ConEnologicos = ConEnologic


        spTiposLotes.cargar_TiposLotes(cboTipoLote)

        'cboTipoLote.DataSource = OldLib.HacerTablasObligatorias(ctlTipLot.devolverLotes())
        'cboTipoLote.ValueMember = "ID"
        'cboTipoLote.DisplayMember = "Display"

        spTiposProductos.cargar_ComboBox(cboTipoProducto)
        'cboTipoProducto.DataSource = OldLib.HacerTablasObligatorias(ctlTipPro.DevolverTiposProductos())
        'cboTipoProducto.ValueMember = "ID"
        'cboTipoProducto.DisplayMember = "Display"


        ctlCor.cargar_Corredores(cboCorredor)
        'cboCorredor.DataSource = OldLib.HacerTablasNoObligatorias(ctlCor.devolverCorredores())
        'cboCorredor.ValueMember = "ID"
        'cboCorredor.DisplayMember = "Display"

        cboProveedor.DataSource = OldLib.HacerTablasNoObligatorias(ctlProv.devolverProveedores())
        cboProveedor.ValueMember = "ID"
        cboProveedor.DisplayMember = "Display"

        'cboProveedoresLabExternos.DataSource = OldLib.HacerTablasObligatorias(ctlLabExt.devolverProveedoresAnaliticas())
        cboProveedoresLabExternos.DataSource = OldLib.HacerTablasObligatorias(ctlProv.devolverProveedoresAnaliticas(dtb))
        cboProveedoresLabExternos.ValueMember = "ID"
        cboProveedoresLabExternos.DisplayMember = "Display"

        ctlMed.cargar_MuestrasMedidas(cboMedidas)
        'cboMedidas.DataSource = OldLib.HacerTablasObligatorias(ctlMed.devolverMuestrasMedidas())
        'cboMedidas.ValueMember = "ID"
        'cboMedidas.DisplayMember = "Display"

        ctlCant.cargar_MuestrasCantidades(cboCantidad)
        'cboCantidad.DataSource = OldLib.HacerTablasObligatorias(ctlCant.devolverMuestrasCantidades())
        'cboCantidad.ValueMember = "ID"
        'cboCantidad.DisplayMember = "Display"


        cboCatador.DataSource = OldLib.HacerTablasNoObligatorias(spEmpleados.devolver_Empleados_Catadores)
        cboCatador.ValueMember = "ID"
        cboCatador.DisplayMember = "Display"

        cboAnalista.DataSource = OldLib.HacerTablasNoObligatorias(spEmpleados.devolver_Empleados_Analistas)
        cboAnalista.ValueMember = "ID"
        cboAnalista.DisplayMember = "Display"

        Dim tabdep As DataTable = ctlDep.devolverDepositosporCodigo()
        cboDeposito.DataSource = OldLib.HacerTablasNoObligatorias(tabdep)
        cboDeposito.ValueMember = "ID"
        cboDeposito.DisplayMember = "Display"

        cboDepositoPrevio.DataSource = OldLib.HacerTablasNoObligatorias(tabdep)
        cboDepositoPrevio.ValueMember = "ID"
        cboDepositoPrevio.DisplayMember = "Display"

        'cboRecipientes.DataSource = OldLib.HacerTablasNoObligatorias(ctlRecSal.devolverRecipientesSalidas)
        'cboRecipientes.ValueMember = "ID"
        'cboRecipientes.DisplayMember = "Display"
        ctlRecSal.cargar_RecipientesSalidas(cboRecipientes)

        cboMuestras.DataSource = OldLib.HacerTablasNoObligatorias(ctlLot.DevolverMuestrasAnaliticas)
        cboMuestras.ValueMember = "ID"
        cboMuestras.DisplayMember = "Display"

        Me.dtpFecha.activarFoco()
        dtpFechaAnaliticaExterna.activarFoco()

        If LoteID <> 0 Then
            frmControlesPorLote = New frmControlesPorLote(LoteID)
            Engine_LA.FormEnPestaña(frmControlesPorLote, Me.tpControles)
        End If
    End Sub

    Private Sub FrmEntLotes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'cboAnaliticas se completa en este Sub
        'Private Sub txtLoteID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoteID.TextChanged
        '    Dim tabla As DataTable = ctlLot.mostrarTodasAnaliticasPorMuestra(txtLoteID.Text)
        '    cboAnaliticas.DataSource = HacerTablasObligatorias(tabla)

        'Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.btnImprimirBoletin))
        'Me.bdnGeneral.Items.Add(New ToolStripControlHost(Me.butInfoTrazabilidad))        


        ctlLot.cargarParametrosMuestra(dtb, 1, txtAcidez, chbAcidez, txtAlcohol1, chbAlcohol, txtExtracto, chbExtracto, txtExtractoNro, txtCenizas, chbCenizas, txtMetanol, _
                                                                chbMetanol, txtHg, chbHg, txtAs, chbAs, txtPb, chbPb, txtSulfatos, chbSulfatos, txtCloruros, chbCloruros, txtSulfuroso, chbSulfuroso, txtC14, chbC14, _
                                                                txtAcetato, chbAcetato, txtDensidad, chbDensidad, txtTurbidez, chbTurbidez, txtIC, chbIC, txtPh, chbPh, txtColor, chbColor, txtFe, chbFe, _
                                                                txtCu, chbCu, txtZn, chbZn, txtAcetoina, chbAcetoina, txtPardeamiento, chbPardeamiento, txtNitrogeno, chbNitrogeno, txtPolifenoles, chbPolifenoles, txtAcidezFija, chbAcidezFija, _
                                                                txtAcidezVolatil, chbAcidezVolatil, txtAzucarTotal, chbAzucarTotal, txtBaume, chbBaume, txtBrix, chbBrix, txtSorbitol, chbSorbitol, _
                                                                txtRecuentoTotal, chbRecuentoTotal, txtBacterias, chbBacterias, txtLevaduras, chbLevaduras, txtHongos, chbHongos, txtXilenium, chbXilenium, txtAnguilulas, chbAnguilulas, _
                                                                txtOlfato, chbOlfato, txtSabor, chbSabor, txtVista, chbVista, txtEstableFrio, chbEstableFrio, txtEstableCalor, chbEstableCalor, txtEstableProteinas, chbEstableProteinas)


        ModificarBindingNavigator()
        CargarObservacionesID(dtb)
        dtpFecha.Value = Today
        dtpFechaAnaliticaExterna.Value = Today

        '  If Me.Text.Substring(0, 3) = "Ver" Then
        'cboEspecificacion.DataSource = HacerTablaEspecificacion(ctlEsp.devolverEspecificacionesTodas())
        'cboEspecificacion.ValueMember = "ID"
        'cboEspecificacion.DisplayMember = "Display"
        '  End If

        If (Me.Text.Substring(0, 8) <> "Insertar") Then
            ctlLot.mostrarTodosLotesPorTipoLoteoProducto(dtb, TipoLoteID, TipoProductoID, dtsMue, ConEnologicos, False, LoteID)
            GeneralBindingSource.DataSource = dtsMue

            GeneralBindingSource.Position = Posicion
            tsTrazabilidad.Visible = True

            If cboAnaliticas.Items.Count = 0 Then
                cboAnaliticas.Text = "La Andaluza"
            End If
        End If

        If Me.Text.Substring(0, 8) = "Insertar" Then
            butAnaliticaExterna.Enabled = False
            cboAnaliticas.Text = "La Andaluza"
            tsTrazabilidad.Visible = False

        Else
            ctlLot.cargarParametrosMuestra(dtb, If(chbSinEspecificacion.Checked, Nothing, cboEspecificacion.SelectedValue), txtAcidez, chbAcidez, txtAlcohol1, chbAlcohol, txtExtracto, chbExtracto, txtExtractoNro, txtCenizas, chbCenizas, txtMetanol, _
                                                                                                            chbMetanol, txtHg, chbHg, txtAs, chbAs, txtPb, chbPb, txtSulfatos, chbSulfatos, txtCloruros, chbCloruros, txtSulfuroso, chbSulfuroso, txtC14, chbC14, _
                                                                                                            txtAcetato, chbAcetato, txtDensidad, chbDensidad, txtTurbidez, chbTurbidez, txtIC, chbIC, txtPh, chbPh, txtColor, chbColor, txtFe, chbFe, _
                                                                                                            txtCu, chbCu, txtZn, chbZn, txtAcetoina, chbAcetoina, txtPardeamiento, chbPardeamiento, txtNitrogeno, chbNitrogeno, txtPolifenoles, chbPolifenoles, txtAcidezFija, chbAcidezFija, _
                                                                                                            txtAcidezVolatil, chbAcidezVolatil, txtAzucarTotal, chbAzucarTotal, txtBaume, chbBaume, txtBrix, chbBrix, txtSorbitol, chbSorbitol, _
                                                                                                            txtRecuentoTotal, chbRecuentoTotal, txtBacterias, chbBacterias, txtLevaduras, chbLevaduras, txtHongos, chbHongos, txtXilenium, chbXilenium, txtAnguilulas, chbAnguilulas, _
                                                                                                            txtOlfato, chbOlfato, txtSabor, chbSabor, txtVista, chbVista, txtEstableFrio, chbEstableFrio, txtEstableCalor, chbEstableCalor, txtEstableProteinas, chbEstableProteinas)

            ctlLot.MostrarParametrosAnalitica(dtb, cboAnaliticas.SelectedValue, txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                    chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                    txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                    txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                    txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                    txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                    txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                   txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista, False)
            ValidarEspecificaciones()
        End If

        If Me.Text.Substring(0, 3) = "Ver" Then
            If cboAnaliticas.Items.Count = 1 Then
                cboAnaliticas.Enabled = False
            Else
                cboAnaliticas.Enabled = True
            End If
            cboAnaliticas.Focus()
        End If

        butRuta.Enabled = True
        cboEspecificacion.Text = txtEspecificacion.Text

        frmTRazabilidad = New frmTrazabilidad(LoteID, ConEnologicos)
        Engine_LA.FormEnPestaña(frmTRazabilidad, TabPage1)

        txtMaceraciones.Text = ctlLot.CantidadDeMaceraciones()

        calcularExtractoGrados()
        calcularExtractoNeto()

        If LoteID <> Nothing Then
            If spElaboraciones.procede_de_elaboracion(LoteID) Then
                tsaprobar = Me.bdnGeneral.Items.Add("Aprobar mezcla")
                tsaprobar.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                tsaprobar.Image = My.Resources.dialog_apply
                tsaprobar.TextDirection = ToolStripTextDirection.Horizontal
                tsaprobar.TextAlign = ContentAlignment.MiddleRight
                AddHandler tsaprobar.Click, AddressOf tsAprobar_click

                tsdeprobar = Me.bdnGeneral.Items.Add("Denegar mezcla")
                tsdeprobar.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                tsdeprobar.Image = My.Resources.dialog_cancel_3
                tsdeprobar.TextDirection = ToolStripTextDirection.Horizontal
                tsdeprobar.TextAlign = ContentAlignment.MiddleRight
                AddHandler tsdeprobar.Click, AddressOf tsDeprobar_click

                tsrepetir = Me.bdnGeneral.Items.Add("Repetir muestra")
                tsrepetir.DisplayStyle = ToolStripItemDisplayStyle.ImageAndText
                tsrepetir.Image = My.Resources.dialog_cancel_3
                tsrepetir.TextDirection = ToolStripTextDirection.Horizontal
                tsrepetir.TextAlign = ContentAlignment.MiddleRight
                AddHandler tsrepetir.Click, AddressOf tsrepetir_click
            End If


            dbo = Me.sp.Select_Record(LoteID)
        End If
    End Sub

    Private Sub cambiar_cantidad()
        Dim frm As New frmCabiarCantidad(Me.LoteID)
        frm.txtCantidad.Text = Me.txtCantidadRestante.Text
        If BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm) = Windows.Forms.DialogResult.OK Then
            Me.txtCantidadRestante.Text = frm.txtCantidad.Text
        End If
    End Sub

    Overrides Sub Guardar()
        If Not Me.comprobarDatos(dtb) Then
            MessageBox.Show("Alguien, que no eres tu, ha modificado los datos de este lote. Para evitar que se corrompan los datos el formulario se cerrara. Vuelva a intentar sus modificaciones de nuevo", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        dtb.EmpezarTransaccion()

        Try


            If Me.Text.Substring(0, 8) = "Insertar" Then
                LoteID = 0
                If Not ctlLot.GuardarLote(dtb, LoteID, If(txtReferencia.Text = "" Or IsDBNull(txtReferencia.Text), 0, Convert.ToInt32(txtReferencia.Text)), cboAnalista.SelectedValue, If(txtCantidadRestante.Text = "" Or IsDBNull(txtCantidadRestante.Text), 0, Convert.ToInt32(txtCantidadRestante.Text)), cboCatador.SelectedValue, txtCodigoLote.Text, cboTipoLote.SelectedValue, cboTipoProducto.SelectedValue, chbSinEspecificacion.Checked, txtDescripcion.Text, dtpFecha.Value, _
                 If(chbSinEspecificacion.Checked, Nothing, cboEspecificacion.SelectedValue), txtObservacion.Text, txtBotellas.Text, cboCantidad.SelectedValue, cboMedidas.SelectedValue, cboCorredor.SelectedValue, _
                 cboProveedor.SelectedValue, cboAnaliticas.SelectedValue, _
                 txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                 chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                 txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                 txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                 txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                 txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                 txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                 txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista) Then

                    Throw New Exception("No se pudo guardar el lote")
                End If

                dtb.TerminarTransaccion()
                Me.Close()


            ElseIf Me.Text.Substring(0, 9) = "Modificar" Then
                If Not ctlLot.GuardarLote(dtb, LoteID, If(txtReferencia.Text = "" Or IsDBNull(txtReferencia.Text), 0, Convert.ToInt32(txtReferencia.Text)), cboAnalista.SelectedValue, txtCantidadRestante.Text, cboCatador.SelectedValue, txtCodigoLote.Text, cboTipoLote.SelectedValue, cboTipoProducto.SelectedValue, chbSinEspecificacion.Checked, txtDescripcion.Text, dtpFecha.Value, _
                If(chbSinEspecificacion.Checked, Nothing, cboEspecificacion.SelectedValue), txtObservacion.Text, txtBotellas.Text, cboCantidad.SelectedValue, cboMedidas.SelectedValue, cboCorredor.SelectedValue, _
                cboProveedor.SelectedValue, cboAnaliticas.SelectedValue, _
                txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista) Then

                    Throw New Exception("No se pudo guardar el lote")
                End If

                If cboAnaliticas.Items.Count = 0 Then
                    dtb.TerminarTransaccion()
                    cboAnaliticas.DataSource = OldLib.HacerTablasObligatorias(ctlLot.mostrarTodasAnaliticasPorMuestra(dtb, LoteID))
                Else
                    If cboAnaliticas.Text <> "La Andaluza" Then
                        If Not ctlLot.GuardarAnaliticaExterna(dtb, cboAnaliticas.SelectedValue, AnaliticaExternaID, txtRutaAnalisis.Text, dtpFechaAnaliticaExterna.Value, cboProveedoresLabExternos.SelectedValue) Then
                            Throw New Exception("Error al guardar la analitica externa")
                        End If

                        cboAnaliticas.Enabled = True
                    End If

                    dtb.TerminarTransaccion()
                End If

                dbo = sp.Select_Record(LoteID)
                'Me.Close()
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            MessageBox.Show("Error al guardar. Detalles: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function comprobarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        If Me.Text.Substring(0, 8) <> "Insertar" Then
            Return sp.comprobar(dtb, dbo)
        End If

        Return True
    End Function

    Private Function HacerTablaEspecificacion(ByVal tb As DataTable) As DataTable
        ' crear nueva tabla
        Dim table As DataTable = New DataTable

        ' declarar variables para la Columna de datos y las filas
        Dim column As DataColumn, row As DataRow

        ' crear nueva columna, poner el tipo de dato
        ' poner nombre y añadir a la tabla
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.Int32")
        column.ColumnName = "ID"
        table.Columns.Add(column)

        ' crear la 2da columna
        column = New DataColumn()
        column.DataType = System.Type.GetType("System.String")
        column.ColumnName = "Display"
        table.Columns.Add(column)

        row = table.NewRow()
        row.Item(0) = -1
        row.Item(1) = ""
        table.Rows.Add(row)
        row = Nothing

        'recorrer la tabla que me vino de la bd y cargarla en la nueva
        Dim i As Integer = 0
        Try
            While i < tb.Rows.Count
                row = table.NewRow()
                row.Item(0) = tb.Rows(i).Item(0)
                row.Item(1) = tb.Rows(i).Item(1)
                table.Rows.Add(row)
                row = Nothing
                i = i + 1
            End While
        Catch ex As Exception

        End Try
        'reemplazar la vieja con la nueva
        Return table
    End Function

    Sub GenerarCodigoLote()
        Try
            Dim dia, mes As String
            If dtpFecha.Value.Day < 10 Then
                dia = "0" & dtpFecha.Value.Day
            Else
                dia = dtpFecha.Value.Day
            End If
            If dtpFecha.Value.Month < 10 Then
                mes = "0" & dtpFecha.Value.Month
            Else
                mes = dtpFecha.Value.Month
            End If
            txtCodigoLote.Text = dtpFecha.Value.Year & mes & dia
            'txtCodigoLote.Text &= ctlTipPro.DevolverAbreviatura(cboTipoProducto.SelectedValue)
            txtCodigoLote.Text &= spTiposProductos.Select_Record(cboTipoProducto.SelectedValue, BasesParaCompatibilidad.BD.transaction).Abreviatura
            If cboTipoLote.SelectedValue <> Nothing Then
                txtCodigoLote.Text &= ctlTipLot.Select_Record(cboTipoLote.SelectedValue, BasesParaCompatibilidad.BD.transaction).Abreviatura & "1"
            End If
        Catch ex As Exception
            txtCodigoLote.Text = ""
        End Try
    End Sub

    Private Sub cboTipoLote_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoLote.SelectedValueChanged
        If Me.Text.Substring(0, 3) <> "Ver" Then
            Try
                Dim aux1 As Integer = cboTipoLote.SelectedValue
                Dim aux2 As Integer = cboTipoProducto.SelectedValue
                If aux1 <> 0 And aux2 <> 0 Then
                    cboEspecificacion.DataSource = HacerTablaEspecificacion(ctlEsp.devolverEspecificacionesPorLote(cboTipoLote.SelectedValue, cboTipoProducto.SelectedValue))
                    cboEspecificacion.ValueMember = "ID"
                    cboEspecificacion.DisplayMember = "Display"
                    cboEspecificacion.SelectedValue = 0
                    GenerarCodigoLote()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Sub ValidarEspecificaciones()
        'dependiendo de cual selecciona cargamos la muestra
        Try
            Dim aux As Integer = If(chbSinEspecificacion.Checked, 0, cboEspecificacion.SelectedValue)
            If aux > 0 Then
                If Bandera_EntroCon <> aux Or Bandera_SinEspecificacion <> chbSinEspecificacion.Checked Then
                    If Not chbSinEspecificacion.Checked Then
                        If aux = -1 Then
                            aux = 0
                        End If
                        ctlLot.cargarParametrosMuestra(dtb, aux, txtAcidez, chbAcidez, txtAlcohol1, chbAlcohol, txtExtracto, chbExtracto, txtExtractoNro, txtCenizas, chbCenizas, txtMetanol, _
                                                                 chbMetanol, txtHg, chbHg, txtAs, chbAs, txtPb, chbPb, txtSulfatos, chbSulfatos, txtCloruros, chbCloruros, txtSulfuroso, chbSulfuroso, txtC14, chbC14, _
                                                                 txtAcetato, chbAcetato, txtDensidad, chbDensidad, txtTurbidez, chbTurbidez, txtIC, chbIC, txtPh, chbPh, txtColor, chbColor, txtFe, chbFe, _
                                                                 txtCu, chbCu, txtZn, chbZn, txtAcetoina, chbAcetoina, txtPardeamiento, chbPardeamiento, txtNitrogeno, chbNitrogeno, txtPolifenoles, chbPolifenoles, txtAcidezFija, chbAcidezFija, _
                                                                 txtAcidezVolatil, chbAcidezVolatil, txtAzucarTotal, chbAzucarTotal, txtBaume, chbBaume, txtBrix, chbBrix, txtSorbitol, chbSorbitol, _
                                                                 txtRecuentoTotal, chbRecuentoTotal, txtBacterias, chbBacterias, txtLevaduras, chbLevaduras, txtHongos, chbHongos, txtXilenium, chbXilenium, txtAnguilulas, chbAnguilulas, _
                                                                 txtOlfato, chbOlfato, txtSabor, chbSabor, txtVista, chbVista, txtEstableFrio, chbEstableFrio, txtEstableCalor, chbEstableCalor, txtEstableProteinas, chbEstableProteinas)

                    Else
                        ctlLot.cargarParametrosMuestra(dtb, 0, txtAcidez, chbAcidez, txtAlcohol1, chbAlcohol, txtExtracto, chbExtracto, txtExtractoNro, txtCenizas, chbCenizas, txtMetanol, _
                                                                                        chbMetanol, txtHg, chbHg, txtAs, chbAs, txtPb, chbPb, txtSulfatos, chbSulfatos, txtCloruros, chbCloruros, txtSulfuroso, chbSulfuroso, txtC14, chbC14, _
                                                                                        txtAcetato, chbAcetato, txtDensidad, chbDensidad, txtTurbidez, chbTurbidez, txtIC, chbIC, txtPh, chbPh, txtColor, chbColor, txtFe, chbFe, _
                                                                                        txtCu, chbCu, txtZn, chbZn, txtAcetoina, chbAcetoina, txtPardeamiento, chbPardeamiento, txtNitrogeno, chbNitrogeno, txtPolifenoles, chbPolifenoles, txtAcidezFija, chbAcidezFija, _
                                                                                        txtAcidezVolatil, chbAcidezVolatil, txtAzucarTotal, chbAzucarTotal, txtBaume, chbBaume, txtBrix, chbBrix, txtSorbitol, chbSorbitol, _
                                                                                        txtRecuentoTotal, chbRecuentoTotal, txtBacterias, chbBacterias, txtLevaduras, chbLevaduras, txtHongos, chbHongos, txtXilenium, chbXilenium, txtAnguilulas, chbAnguilulas, _
                                                                                        txtOlfato, chbOlfato, txtSabor, chbSabor, txtVista, chbVista, txtEstableFrio, chbEstableFrio, txtEstableCalor, chbEstableCalor, txtEstableProteinas, chbEstableProteinas)
                    End If
                    Bandera_EntroCon = aux
                    Bandera_SinEspecificacion = chbSinEspecificacion.Checked
                    If Me.Text.Substring(0, 3) = "Ver" Then
                        ModificarBindingNavigator()
                        Dim tabla As DataTable = ctlLot.mostrarTodasAnaliticasPorMuestra(dtb, txtLoteID.Text)
                        If tabla.Rows.Count > 1 Then
                            cboAnaliticas.Enabled = True
                        Else
                            cboAnaliticas.Enabled = False
                        End If
                        'butRuta.Enabled = True
                    End If
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub


    Private Sub cboEspecificacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboEspecificacion.SelectedValueChanged
        Try
            'If cboEspecificacion.Items.Count > 1 Then
            '    cboEspecificacion.Visible = True
            '    lblEspecificacion.Visible = True
            'Else
            '    cboEspecificacion.Visible = False
            '    lblEspecificacion.Visible = False
            'End If
            ValidarEspecificaciones()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub chbSinEspecificacion_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbSinEspecificacion.CheckedChanged
        cboEspecificacion.Enabled = Not chbSinEspecificacion.Checked
        establecerLimitesCampos()
        ValidarEspecificaciones()
    End Sub

    Private Sub establecerLimitesCampos()
        Dim aux As New BasesParaCompatibilidad.CuadroDeTextoMuestra
        Dim ob As Object
        For Each ob In grbCata.Controls
            If ob.GetType = aux.GetType Then
                aux = ob
                aux.LimitarValor = Not chbSinEspecificacion.Checked
            End If
        Next
        For Each ob In grbAnalitico.Controls
            If ob.GetType = aux.GetType Then
                aux = ob
                aux.LimitarValor = Not chbSinEspecificacion.Checked
            End If
        Next
        For Each ob In grbEsta.Controls
            If ob.GetType = aux.GetType Then
                aux = ob
                aux.LimitarValor = Not chbSinEspecificacion.Checked
            End If
        Next
        For Each ob In grbMicro.Controls
            If ob.GetType = aux.GetType Then
                aux = ob
                aux.LimitarValor = Not chbSinEspecificacion.Checked
            End If
        Next
        For Each ob In grbParametrosLegales.Controls
            If ob.GetType = aux.GetType Then
                aux = ob
                aux.LimitarValor = Not chbSinEspecificacion.Checked
            End If
        Next
    End Sub

    Sub VerParametrosAnaliticaExterna(ByVal Visible As Boolean)
        lblRutaAnalisis.Visible = Visible
        txtRutaAnalisis.Visible = Visible
        butRuta.Visible = Visible
        lblFechaanaliticaExterna.Visible = Visible
        dtpFechaAnaliticaExterna.Visible = Visible
        lblLaboratorioExterno.Visible = Visible
        cboProveedoresLabExternos.Visible = Visible
    End Sub

    Private Sub butanaliticaExterna_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butAnaliticaExterna.Click
        Dim sRespuesta As String

        sRespuesta = InputBox("Nombre de la nueva Analitica Externa : ", "Nueva Analitica Externa", , 500, 500)
        If sRespuesta <> vbNullString Then
            If sRespuesta.ToUpper <> "LA ANDALUZA" Then

                dtb.EmpezarTransaccion()

                Try
                    'nueva analitica
                    AnaliticaID = ctlLot.NuevaAnalitica(dtb, sRespuesta, LoteID, cboAnalista.SelectedValue, cboCatador.SelectedValue)
                    If AnaliticaID <> 0 Then
                        'llevar al combobox
                        cboAnaliticas.DataSource = OldLib.HacerTablasObligatorias(ctlLot.mostrarTodasAnaliticasPorMuestra(dtb, LoteID))
                        cboAnaliticas.Text = sRespuesta
                        'cboAnaliticas.
                        VerParametrosAnaliticaExterna(True)
                    Else
                        Throw New Exception("Error al guardar la analitica")
                    End If

                    dtb.TerminarTransaccion()
                Catch ex As Exception
                    dtb.CancelarTransaccion()
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Else
                MessageBox.Show("Es necesario dar un nombre para la nueva Analitica diferente a ´La Andaluza´", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
        Else
            messagebox.show("Es necesario dar un nombre para la nueva Analitica Externa", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Sub CargarObservacionesID(ByRef dtb As BasesParaCompatibilidad.DataBase)
        ctlLot.CargarObservacionesID(dtb, txtMedidaColor, txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista)
    End Sub

    Private Sub butRuta_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butRuta.Click
        Dim arch As String
        Dim f As New BasesParaCompatibilidad.File
        arch = f.SeleccionarArchivo(Me.Text, txtRutaAnalisis.Text, "")
        If Me.Text.Substring(0, 3) <> "Ver" Then
            txtRutaAnalisis.Text = arch
        End If
    End Sub

    Private Sub cboAnaliticas_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAnaliticas.SelectedValueChanged
        Try
            AnaliticaID = cboAnaliticas.SelectedValue
            If cboAnaliticas.Text <> "" And AnaliticaID <> 0 Then
                ctlLot.CargarAnalitica(dtb, AnaliticaID, cboAnalista.SelectedValue, cboCatador.SelectedValue)
            End If
            If cboAnaliticas.Text <> "La Andaluza" And cboAnaliticas.Text <> "" Then
                Try
                    Dim aaa As Integer = cboAnaliticas.SelectedValue
                    aaa = cboProveedoresLabExternos.SelectedValue
                    AnaliticaExternaID = ctlLot.CargarAnaliticaExterna(dtb, cboAnaliticas.SelectedValue, txtRutaAnalisis.Text, dtpFechaAnaliticaExterna.Value, cboProveedoresLabExternos.SelectedValue)
                    VerParametrosAnaliticaExterna(True)
                    Bandera_EntroCon = 0
                    If cboAnaliticas.SelectedValue > 0 And cboAnaliticas.Text <> "" Then
                        ctlLot.MostrarParametrosAnalitica(dtb, cboAnaliticas.SelectedValue, txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                         chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                         txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                         txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                         txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                         txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                         txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                         txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista, False)
                    End If
                    ctlLot.cargarParametrosMuestra(dtb, 0, txtAcidez, chbAcidez, txtAlcohol1, chbAlcohol, txtExtracto, chbExtracto, txtExtractoNro, txtCenizas, chbCenizas, txtMetanol, _
                                                                                           chbMetanol, txtHg, chbHg, txtAs, chbAs, txtPb, chbPb, txtSulfatos, chbSulfatos, txtCloruros, chbCloruros, txtSulfuroso, chbSulfuroso, txtC14, chbC14, _
                                                                                           txtAcetato, chbAcetato, txtDensidad, chbDensidad, txtTurbidez, chbTurbidez, txtIC, chbIC, txtPh, chbPh, txtColor, chbColor, txtFe, chbFe, _
                                                                                           txtCu, chbCu, txtZn, chbZn, txtAcetoina, chbAcetoina, txtPardeamiento, chbPardeamiento, txtNitrogeno, chbNitrogeno, txtPolifenoles, chbPolifenoles, txtAcidezFija, chbAcidezFija, _
                                                                                           txtAcidezVolatil, chbAcidezVolatil, txtAzucarTotal, chbAzucarTotal, txtBaume, chbBaume, txtBrix, chbBrix, txtSorbitol, chbSorbitol, _
                                                                                           txtRecuentoTotal, chbRecuentoTotal, txtBacterias, chbBacterias, txtLevaduras, chbLevaduras, txtHongos, chbHongos, txtXilenium, chbXilenium, txtAnguilulas, chbAnguilulas, _
                                                                                           txtOlfato, chbOlfato, txtSabor, chbSabor, txtVista, chbVista, txtEstableFrio, chbEstableFrio, txtEstableCalor, chbEstableCalor, txtEstableProteinas, chbEstableProteinas)
                Catch ex As Exception

                End Try
            Else
                VerParametrosAnaliticaExterna(False)
                If cboAnaliticas.SelectedValue > 0 And cboAnaliticas.Text <> "" Then

                    ctlLot.MostrarParametrosAnalitica(dtb, cboAnaliticas.SelectedValue, txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                     chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                     txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                     txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                     txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                     txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                     txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                     txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista, False)
                    ValidarEspecificaciones()
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtCodigoLote_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCodigoLote.TextChanged
        If Me.Text.Substring(0, 3) <> "Ver" Then
            Dim CodigoLote As New CodigoLote
            CodigoLote.validarCodigoLote(txtCodigoLote.EsUnicoCampo, txtCodigoLote.EsUnicoCampoID, _
                                         txtCodigoLote.EsUnicoTabla, txtCodigoLote.EsUnicoID, txtCodigoLote.Text)
            'txtCodigoLote.validarCodigoLote()
        End If
        Try
            If ctlTipLot.Select_Record(cboTipoLote.SelectedValue).Abreviatura = "Env" Then
                If frmTRazabilidad.count > 0 Then
                    Me.AutoScroll = True
                    gbAnalitica.Visible = True
                    Me.Height = 965
                    Me.Location = New Point(100, 100)
                    cboAnaliticas.DataSource = OldLib.HacerTablasObligatorias(ctlLot.mostrarTodasAnaliticasPorMuestra(Me.dtb, LoteID))
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboTipoProducto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboTipoProducto.SelectedValueChanged
        If Me.Text.Substring(0, 3) <> "Ver" Then
            Try
                Dim aux1 As Integer = cboTipoLote.SelectedValue
                Dim aux2 As Integer = cboTipoProducto.SelectedValue
                If aux1 <> 0 And aux2 <> 0 Then
                    cboEspecificacion.DataSource = HacerTablaEspecificacion(ctlEsp.devolverEspecificacionesPorLote(cboTipoLote.SelectedValue, cboTipoProducto.SelectedValue))
                    cboEspecificacion.ValueMember = "ID"
                    cboEspecificacion.DisplayMember = "Display"
                    GenerarCodigoLote()
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub

    Private Sub dtpFecha_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtpFecha.ValueChanged
        If Me.Text.Substring(0, 3) <> "Ver" Then
            GenerarCodigoLote()
        End If
    End Sub

    Private Sub txtOlfato_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtOlfato.Validating
        Try
            If Convert.ToInt16(txtOlfato.Text) < 0 Or Convert.ToInt16(txtOlfato.Text) > 10 Then
                messagebox.show("Solo valores entre 0 y 10", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtSabor_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtSabor.Validating
        Try
            If Convert.ToInt16(txtSabor.Text) < 0 Or Convert.ToInt16(txtSabor.Text) > 10 Then
                messagebox.show("Solo valores entre 0 y 10", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtVista_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtVista.Validating
        Try
            If Convert.ToInt16(txtVista.Text) < 0 Or Convert.ToInt16(txtVista.Text) > 10 Then
                messagebox.show("Solo valores entre 0 y 10", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                e.Cancel = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Dim band As Boolean = True
    Sub HabilitarReadOnly(ByVal txt As BasesParaCompatibilidad.CuadroDeTextoMuestra)
        Try
            If band Then
                band = False
                If Not txt.Enabled Then
                    txt.Enabled = True
                    txt.ReadOnly = True
                Else
                    txt.ReadOnly = False
                End If
                band = True
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub txtObservacionesOlfato_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacionesOlfato.EnabledChanged
        HabilitarReadOnly(txtObservacionesOlfato)
    End Sub

    Private Sub txtObservacionesSabor_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacionesSabor.EnabledChanged
        HabilitarReadOnly(txtObservacionesSabor)
    End Sub

    Private Sub txtObservacionesVista_EnabledChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtObservacionesVista.EnabledChanged
        HabilitarReadOnly(txtObservacionesVista)
    End Sub

    Private Sub butCorredor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butCorredor.Click
        Dim frm As New frmEntCorredores
        frm.Text = "Insertar Corredor"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        'Dim sp As New spCorredores
        ctlCor.cargar_Corredores(cboCorredor)
        'cboCorredor.DataSource = OldLib.HacerTablasNoObligatorias(ctlCor.devolverCorredores())
        'cboCorredor.ValueMember = "ID"
        'cboCorredor.DisplayMember = "Display"
        'cboCorredor.SelectedIndex = cboCorredor.Items.Count - 1
    End Sub

    Private Sub butProveedor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butProveedor.Click
        'Dim frm As New FrmEntProveedores
        Dim m_Proveedor As New DBO_Proveedores
        Dim DBO_Proveedor As New DBO_Proveedores
        Dim sp As New spProveedores

        Dim frm As New frmEntProveedores(INSERCION, sp, DBO_Proveedor)
        'frm.Text = "Insertar Proveedor"
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        cboProveedor.DataSource = OldLib.HacerTablasNoObligatorias(ctlProv.devolverProveedores())
        cboProveedor.ValueMember = "ID"
        cboProveedor.DisplayMember = "Display"
        cboProveedor.SelectedIndex = cboProveedor.Items.Count - 1
    End Sub

    Private Sub txtEstableFrio_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstableFrio.TextChanged
        Try
            If If(txtEstableFrio.Text = "" Or IsDBNull(txtEstableFrio.Text), 0, Convert.ToInt32(txtEstableFrio.Text)) > 0 Then
                chbValorEstableFrio.Checked = True
            Else
                chbValorEstableFrio.Checked = False
            End If
            If txtEstableFrio.Text = "" Then
                chbValorEstableFrio.CheckState = CheckState.Indeterminate
            End If
        Catch ex As Exception
            If txtEstableFrio.Text = "" Then
                chbValorEstableFrio.CheckState = CheckState.Indeterminate
            End If
        End Try
    End Sub

    Private Sub txtEstableCalor_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstableCalor.TextChanged
        Try
            If If(txtEstableCalor.Text = "" Or IsDBNull(txtEstableCalor.Text), 0, Convert.ToInt32(txtEstableCalor.Text)) > 0 Then
                chbValorEstableCalor.Checked = True
            Else
                chbValorEstableCalor.Checked = False
            End If
            If txtEstableCalor.Text = "" Then
                chbValorEstableCalor.CheckState = CheckState.Indeterminate
            End If
        Catch ex As Exception
            If txtEstableCalor.Text = "" Then
                chbValorEstableCalor.CheckState = CheckState.Indeterminate
            End If
        End Try
    End Sub

    Private Sub txtEstableProteinas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEstableProteinas.TextChanged
        Try
            If If(txtEstableProteinas.Text = "" Or IsDBNull(txtEstableProteinas.Text), 0, Convert.ToInt32(txtEstableProteinas.Text)) > 0 Then
                chbValorEstableProteina.Checked = True
            Else
                chbValorEstableProteina.Checked = False
            End If
            If txtEstableProteinas.Text = "" Then
                chbValorEstableProteina.CheckState = CheckState.Indeterminate
            End If
        Catch ex As Exception
            If txtEstableProteinas.Text = "" Then
                chbValorEstableProteina.CheckState = CheckState.Indeterminate
            End If
        End Try
    End Sub

    Private Sub chbValorEstableFrio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbValorEstableFrio.CheckedChanged
        txtEstableFrio.Modificado = True
        If chbValorEstableFrio.Checked Then
            txtEstableFrio.Text = 1
        Else
            txtEstableFrio.Text = 0
        End If
    End Sub

    Private Sub chbValorEstableCalor_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbValorEstableCalor.CheckedChanged
        txtEstableCalor.Modificado = True
        If chbValorEstableCalor.Checked Then
            txtEstableCalor.Text = 1
        Else
            txtEstableCalor.Text = 0
        End If
    End Sub

    Private Sub chbValorEstableProteina_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chbValorEstableProteina.CheckedChanged
        txtEstableProteinas.Modificado = True
        If chbValorEstableProteina.Checked Then
            txtEstableProteinas.Text = 1
        Else
            txtEstableProteinas.Text = 0
        End If
    End Sub

    Private Sub butInfoTrazabilidad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles butInfoTrazabilidad.Click
        'Dim MSWord As New Microsoft.Office.Interop.Word.Application
        'Dim Documento As Microsoft.Office.Interop.Word.Document
        'Dim Parrafo As Microsoft.Office.Interop.Word.Paragraph

        'Documento = MSWord.Documents.Add
        'Parrafo = Documento.Paragraphs.Add

        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "España, " & Now.Day & " de " & Now.Month.ToString & "  del " & Now.Year
        'Parrafo.Range.Font.Bold = False
        'Parrafo.Format.SpaceAfter = 50
        'Parrafo.Range.InsertParagraphAfter()

        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "Ref:    Informe de Trazabilidad del Lote " & txtCodigoLote.Text
        'Parrafo.Range.Font.Bold = True
        'Parrafo.Format.SpaceAfter = 25
        'Parrafo.Range.InsertParagraphAfter()

        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "La siguiente es la trazabilidad del lote de codigo '" & txtCodigoLote.Text & "'"
        'Parrafo.Range.Font.Bold = False
        'Parrafo.Format.SpaceAfter = 25
        'Parrafo.Range.InsertParagraphAfter()

        'dtsTrazabilidad.Clear()
        'ctlLot.mostrarTrazabilidadLote(dtsTrazabilidad, LoteID)

        'Parrafo.Range.InsertParagraphAfter()
        'Documento.Tables.Add(Parrafo.Range, NumRows:=dtsTrazabilidad.Rows.Count + 1, NumColumns:=6)

        'Dim i As Integer = 0
        'While i < dtsTrazabilidad.Rows.Count
        '    Documento.Tables.Item(1).Cell(i + 1, 1).Range().Text = dtsTrazabilidad.Rows(i).Item(0)
        '    Documento.Tables.Item(1).Cell(i + 1, 2).Range().Text = dtsTrazabilidad.Rows(i).Item(2)
        '    Documento.Tables.Item(1).Cell(i + 1, 3).Range().Text = dtsTrazabilidad.Rows(i).Item(3)
        '    Documento.Tables.Item(1).Cell(i + 1, 4).Range().Text = dtsTrazabilidad.Rows(i).Item(4)
        '    Documento.Tables.Item(1).Cell(i + 1, 5).Range().Text = dtsTrazabilidad.Rows(i).Item(5)
        '    Documento.Tables.Item(1).Cell(i + 1, 6).Range().Text = dtsTrazabilidad.Rows(i).Item(6)
        '    i = i + 1
        'End While

        ''Documento.Tables.Item(1).Cell(0, 1).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        ''Documento.Tables.Item(1).Cell(0, 2).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        ''Documento.Tables.Item(1).Cell(0, 3).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        ''Documento.Tables.Item(1).Cell(0, 4).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        ''Documento.Tables.Item(1).Cell(0, 5).Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter
        'Documento.Tables.Item(1).Cell(0, 1).Range.Font.Bold = True
        'Documento.Tables.Item(1).Cell(0, 2).Range.Font.Bold = True
        'Documento.Tables.Item(1).Cell(0, 3).Range.Font.Bold = True
        'Documento.Tables.Item(1).Cell(0, 4).Range.Font.Bold = True
        'Documento.Tables.Item(1).Cell(0, 5).Range.Font.Bold = True
        'Documento.Tables.Item(1).Cell(0, 6).Range.Font.Bold = True

        'Documento.Tables.Item(1).Cell(0, 1).Range().Text = "Compone A"
        'Documento.Tables.Item(1).Cell(0, 2).Range().Text = "CodigoLote"
        'Documento.Tables.Item(1).Cell(0, 3).Range().Text = "Fecha"
        'Documento.Tables.Item(1).Cell(0, 4).Range().Text = "Proceso"
        'Documento.Tables.Item(1).Cell(0, 5).Range().Text = "Cantidad"
        'Documento.Tables.Item(1).Cell(0, 6).Range().Text = "Proveedor"
        'Documento.Tables.Item(1).AllowAutoFit = True

        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = " Es cuanto informo a usted, para los fines consiguiente "
        'Parrafo.Range.Font.Bold = False
        'Parrafo.Format.SpaceBefore = 40
        'Parrafo.Format.SpaceAfter = 50
        'Parrafo.Range.InsertParagraphAfter()

        'Parrafo.Format.SpaceBefore = 0
        'Parrafo.Format.SpaceAfter = 0
        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "                                   ---------------------------"
        'Parrafo.Range.InsertParagraphAfter()
        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "                                            Alejandro"
        'Parrafo.Range.InsertParagraphAfter()
        'Parrafo = Documento.Content.Paragraphs.Add(Documento.Bookmarks("\endofdoc").Range)
        'Parrafo.Range.Text = "                                       Desarrollador de SW"
        'Parrafo.Range.InsertParagraphAfter()

        'MSWord.PrintPreview() = True
        'MSWord.Visible = True
    End Sub

    Private Sub txtLoteID_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtLoteID.TextChanged
        Dim tabla As DataTable = ctlLot.mostrarTodasAnaliticasPorMuestra(dtb, txtLoteID.Text)
        cboAnaliticas.DataSource = OldLib.HacerTablasObligatorias(tabla)
        cboAnaliticas.ValueMember = "ID"
        cboAnaliticas.DisplayMember = "Display"
        If tabla.Rows.Count > 1 Then
            cboAnaliticas.Enabled = True
        Else
            cboAnaliticas.Enabled = False
        End If
        ctlLot.setLoteID((txtLoteID.Text))
        ctlLot.mostrarLotesComponentes(dtsCompuestoPor)

        ctlLot.mostrarLotesQueCompone(dtsComponenteDe)

        txtMaceraciones.Text = ctlLot.CantidadDeMaceraciones()
    End Sub

    Private Sub dudBotellas_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBotellas.TextChanged
        Try
            If txtBotellas.Text.Trim = "" Or txtBotellas.Text = "0" Then
                gbAnalitica.Visible = False
                Me.Height = 537
                Me.AutoScroll = False
                Me.Location = New Point(100, 100)
            Else
                Me.AutoScroll = True
                gbAnalitica.Visible = True
                Me.Height = 965
                Me.Location = New Point(100, 100)
                If (Me.Text.Substring(0, 9) = "Modificar") And (txtReferencia.Text = "0" Or txtReferencia.Text.Trim = "") Then
                    txtReferencia.Text = ctlLot.devolverReferencia(dtb)
                End If
                If (Me.Text.Substring(0, 8) = "Insertar") Then
                    txtReferencia.Text = ctlLot.devolverReferencia(dtb)
                End If
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub cboDeposito_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboDeposito.SelectedValueChanged
        Try
            If cboDeposito.SelectedValue = 0 Then
                lblDepositoPRevio.Visible = True
                cboDepositoPrevio.Visible = True
            Else
                lblDepositoPRevio.Visible = False
                cboDepositoPrevio.Visible = False
            End If
        Catch ex As Exception
        End Try
    End Sub

    'Private Sub cboMuestras_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboMuestras.SelectedValueChanged

    'End Sub



    Private Sub tsAprobar_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sp As New spElaboraciones
        If Not sp.aprobar_lote_mezcla(LoteID) Then
            messagebox.show("No se pudo realizar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            messagebox.show("Completado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsDeprobar_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sp As New spElaboraciones
        If Not sp.deprobar_lote_mezcla(LoteID) Then
            messagebox.show("No se pudo realizar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            messagebox.show("Completado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub tsrepetir_click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim sp As New spElaboraciones
        If Not sp.repetir_muestra_mezcla(LoteID) Then
            messagebox.show("No se pudo realizar la operacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            messagebox.show("Completado con exito", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnImprimirBoletin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImprimirBoletin.Click
        Dim clsLotesAnaliticas As New clsLotesAnaliticas
        If clsLotesAnaliticas.comprobar_disponibilidad_boletin_envasado(txtCodigoLote.Text) Then
            'Dim Frm As New LisBoletinesParametros(txtCodigoLote.Text, _
            '                                      cboTipoLote.SelectedValue, _
            '                                      cboTipoProducto.Text, _
            '                                      txtAcidez.Text, _
            '                                      txtAlcohol1.Text, _
            '                                      txtExtracto.Text, _
            '                                      txtExtractoNro.Text, _
            '                                      txtAzucarTotal.Text, _
            '                                      txtSulfuroso.Text, _
            '                                      txtDensidad.Text)

            'BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
            'Frm.Dispose()
            Dim Frm As New frmEntplantillasBoletines(txtCodigoLote.Text, True)

            BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
            Frm.Dispose()
        Else
            messagebox.show("Boletin no disponible", "", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub


    Private Sub txtObservacionesOlfato_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtObservacionesOlfato.KeyUp
        Me.txtObservacionesOlfato.Text = Me.txtObservacionesOlfato.Text.Replace(".", ",")
        Me.txtObservacionesOlfato.SelectionStart = Me.txtObservacionesOlfato.Text.Length
    End Sub

    Private Sub txtObservacionesSabor_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtObservacionesSabor.KeyUp
        Me.txtObservacionesSabor.Text = Me.txtObservacionesSabor.Text.Replace(".", ",")
        Me.txtObservacionesSabor.SelectionStart = Me.txtObservacionesSabor.Text.Length
    End Sub

    Private Sub txtObservacionesVista_KeyUp(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txtObservacionesVista.KeyUp
        Me.txtObservacionesVista.Text = Me.txtObservacionesVista.Text.Replace(".", ",")
        Me.txtObservacionesVista.SelectionStart = Me.txtObservacionesVista.Text.Length
    End Sub

    Private Sub calcularExtractoGrados()
        Try
            If (Me.cboTipoProducto.Text.Contains("Vino") Or Me.cboTipoProducto.Text.Contains("vino")) And Not Me.cboTipoProducto.Text.Contains("ateria") And Not Me.cboTipoProducto.Text.Contains("inagr") Then
                If Me.txtExtracto.Text <> "" And Me.txtAlcohol1.Text <> "" Then
                    If IsNumeric(Me.txtExtracto.Text) And IsNumeric(Me.txtAlcohol1.Text) And txtAlcohol1.Text <> 0 Then
                        Me.txtExtractoNro.Text = Me.txtExtracto.Text / Me.txtAlcohol1.Text
                    Else
                        Me.txtExtractoNro.Text = 0
                    End If
                Else
                    Me.txtExtractoNro.Text = 0
                End If
            Else
                If Me.txtExtracto.Text <> "" And Me.txtAcidez.Text <> "" Then
                    If IsNumeric(Me.txtExtracto.Text) And IsNumeric(Me.txtAcidez.Text) And txtAcidez.Text <> 0 Then
                        Me.txtExtractoNro.Text = Me.txtExtracto.Text / Me.txtAcidez.Text
                    Else
                        Me.txtExtractoNro.Text = 0
                    End If
                Else
                    Me.txtExtractoNro.Text = 0
                End If
            End If
            'If Me.txtExtracto.Text <> "" And Me.txtAcidez.Text <> "" Then
            '    If IsNumeric(Me.txtExtracto.Text) And IsNumeric(Me.txtAcidez.Text) And txtAcidez.Text <> 0 Then
            '        Me.txtExtractoNro.Text = Me.txtExtracto.Text / Me.txtAcidez.Text
            '    Else
            '        Me.txtExtractoNro.Text = 0
            '    End If
            'Else
            '    Me.txtExtractoNro.Text = 0
            'End If
        Catch ex As Exception
            Me.txtExtractoNro.Text = 0
        End Try
    End Sub

    Private Sub calcularExtractoNeto()
        Try
            If Me.txtExtracto.Text <> "" And Me.txtAzucarTotal.Text <> "" Then
                If IsNumeric(Me.txtExtracto.Text) And IsNumeric(Me.txtAzucarTotal.Text) Then
                    Me.txtHg.Text = Me.txtExtracto.Text - Me.txtAzucarTotal.Text
                Else
                    Me.txtHg.Text = 0
                End If
            Else
                Me.txtHg.Text = 0
            End If
        Catch ex As Exception
            Me.txtHg.Text = 0
        End Try
    End Sub


    Private Sub FrmEntLotes_Shown(sender As System.Object, e As System.EventArgs) Handles MyBase.Shown
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        If Me.Text.Substring(0, 8) = "Insertar" Then Me.txtCantidadRestante.Enabled = True
    End Sub

    Private Sub txtExtracto_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtExtracto.TextChanged
        calcularExtractoGrados()
        calcularExtractoNeto()
    End Sub

    Private Sub txtAcidez_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAcidez.TextChanged
        calcularExtractoGrados()
    End Sub

    Private Sub txtAzucarTotal_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAzucarTotal.TextChanged
        calcularExtractoNeto()
    End Sub

    Private Sub txtAlcohol1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAlcohol1.TextChanged
        calcularExtractoGrados()
    End Sub

    Private Sub btnmuestra_Click(sender As System.Object, e As System.EventArgs) Handles btnmuestra.Click
        Try
            Dim aux As Integer
            aux = cboMuestras.SelectedValue
            If aux > 0 Then
                ctlLot.MostrarParametrosAnalitica(dtb, aux, txtAcidez, chbAcidez.Checked, txtAlcohol1, chbAlcohol.Checked, txtExtracto, chbExtracto.Checked, txtExtractoNro, txtCenizas, chbCenizas.Checked, txtMetanol, _
                         chbMetanol.Checked, txtHg, chbHg.Checked, txtAs, chbAs.Checked, txtPb, chbPb.Checked, txtSulfatos, chbSulfatos.Checked, txtCloruros, chbCloruros.Checked, txtSulfuroso, chbSulfuroso.Checked, txtC14, chbC14.Checked, _
                         txtAcetato, chbAcetato.Checked, txtDensidad, chbDensidad.Checked, txtTurbidez, chbTurbidez.Checked, txtIC, chbIC.Checked, txtPh, chbPh.Checked, txtColor, chbColor.Checked, txtMedidaColor, txtFe, chbFe.Checked, _
                         txtCu, chbCu.Checked, txtZn, chbZn.Checked, txtAcetoina, chbAcetoina.Checked, txtPardeamiento, chbPardeamiento.Checked, txtNitrogeno, chbNitrogeno.Checked, txtPolifenoles, chbPolifenoles.Checked, txtAcidezFija, chbAcidezFija.Checked, _
                         txtAcidezVolatil, chbAcidezVolatil.Checked, txtAzucarTotal, chbAzucarTotal.Checked, txtBaume, chbBaume.Checked, txtBrix, chbBrix.Checked, txtSorbitol, chbSorbitol.Checked, _
                         txtRecuentoTotal, chbRecuentoTotal.Checked, txtBacterias, chbBacterias.Checked, txtLevaduras, chbLevaduras.Checked, txtHongos, chbHongos.Checked, txtXilenium, chbXilenium.Checked, txtAnguilulas, chbAnguilulas.Checked, _
                         txtOlfato, chbOlfato.Checked, txtSabor, chbSabor.Checked, txtVista, chbVista.Checked, txtEstableFrio, chbEstableFrio.Checked, txtEstableCalor, chbEstableCalor.Checked, txtEstableProteinas, chbEstableProteinas.Checked, _
                         txtObservacionesOlfato, txtObservacionesSabor, txtObservacionesVista, True)
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnVerTrazabilidad_Click(sender As System.Object, e As System.EventArgs) Handles btnVerTrazabilidad.Click
        Me.tcTrazabilidad.Visible = Not Me.tcTrazabilidad.Visible

        If Not Me.SplitContainer2.Panel2Collapsed Then
            If Not tcTrazabilidad.Visible Then
                Me.SplitContainer2.SplitterDistance = Me.PanelGeneral.Height
            Else
                Me.SplitContainer2.SplitterDistance = Me.PanelGeneral.Height * 2
            End If
        End If
    End Sub

    Private Sub btnVerAnalitica_Click(sender As System.Object, e As System.EventArgs) Handles btnVerAnalitica.Click
        Me.SplitContainer2.Panel2Collapsed = Not Me.SplitContainer2.Panel2Collapsed

        If Not Me.SplitContainer2.Panel2Collapsed Then
            If Not tcTrazabilidad.Visible Then
                Me.SplitContainer2.SplitterDistance = Me.PanelGeneral.Height
            Else
                Me.SplitContainer2.SplitterDistance = Me.PanelGeneral.Height * 2
            End If
        End If
    End Sub


   

  
    Private Sub vtnCodigoLoteClipboard_Click(sender As Object, e As EventArgs) Handles vtnCodigoLoteClipboard.Click
        My.Computer.Clipboard.SetText(Me.txtCodigoLote.Text)
    End Sub
End Class
