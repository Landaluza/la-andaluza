<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntAlbaranesCargaMaestro
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Dise�ador de Windows Forms.  
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AlbaranCargaMaestroIDLabel As System.Windows.Forms.Label
        Dim AlbaranCargaProMaestroIDLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ClienteIDLabel As System.Windows.Forms.Label
        Dim SerieQSIDLabel As System.Windows.Forms.Label
        Dim NumeroQSLabel As System.Windows.Forms.Label
        Dim AlmacenSalidaQSIDLabel As System.Windows.Forms.Label
        Dim PorteFormaPagoIDLabel As System.Windows.Forms.Label
        Dim PorteImporteLabel As System.Windows.Forms.Label
        Dim ConductorLabel As System.Windows.Forms.Label
        Dim HoraLlegadaLabel As System.Windows.Forms.Label
        Dim HoraSalidaLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim Label16 As System.Windows.Forms.Label
        Dim Label17 As System.Windows.Forms.Label
        Dim Label19 As System.Windows.Forms.Label
        Dim Label18 As System.Windows.Forms.Label
        Dim Label20 As System.Windows.Forms.Label
        Dim Label21 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAlbaranesCargaMaestro))
        Me.DtsAlbaranesCargaMaestro = New La_Andaluza.dtsAlbaranesCargaMaestro()
        Me.txtAlbaranCargaMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.SerieQSIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.NumeroQSCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.AlmacenSalidaQSIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.PorteImporteCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.ConductorDNICuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.HoraLlegadaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraSalidaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dgvPalet = New System.Windows.Forms.DataGridView()
        Me.cmPalets = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MarcarComoMultiloteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarcarComoNoMultiloteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.CambiarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarLoteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tabDatos = New System.Windows.Forms.TabControl()
        Me.tabPagDatos = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.grbDatosTransporte = New System.Windows.Forms.GroupBox()
        Me.cboAgencia = New System.Windows.Forms.ComboBox()
        Me.txtDetalleRemolque = New System.Windows.Forms.TextBox()
        Me.btnNuevoCamion = New System.Windows.Forms.Button()
        Me.cboCabeza = New System.Windows.Forms.ComboBox()
        Me.cboFormaPAgo = New System.Windows.Forms.ComboBox()
        Me.cboREsponsableAdminsitracion = New System.Windows.Forms.ComboBox()
        Me.cboREsponsableCarga = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cboConductores = New System.Windows.Forms.ComboBox()
        Me.grbDatosCabecera = New System.Windows.Forms.GroupBox()
        Me.cboPedido = New System.Windows.Forms.ComboBox()
        Me.cboLugaresEntrega = New System.Windows.Forms.ComboBox()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.grbAlbaranesPendientes = New System.Windows.Forms.GroupBox()
        Me.dgvAlbaranesProvi = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.tabPagPalets = New System.Windows.Forms.TabPage()
        Me.tabPagAcumulados = New System.Windows.Forms.TabPage()
        Me.dgvAcumulados = New System.Windows.Forms.DataGridView()
        Me.cmAcumulados = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CambiarLoteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReiniciarLoteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvTotalPalets = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnCartaJr = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.butRegistrarPortesSalidaQS = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ButEmbotelladoPedido = New System.Windows.Forms.Button()
        Me.txtPesoBruto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butAlbaranProvisional = New System.Windows.Forms.Button()
        Me.txtPesoNeto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.butAlbaranQS = New System.Windows.Forms.Button()
        Me.butMercadonaCanarias = New System.Windows.Forms.Button()
        Me.butCartaPortes = New System.Windows.Forms.Button()
        Me.butEntradaJR = New System.Windows.Forms.Button()
        Me.butJRaMercadona = New System.Windows.Forms.Button()
        Me.butLAaJR = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtRemolque1 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCabeza = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto2 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtConductor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto4 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDNI = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto6 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.txtTotalBultos = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TabPagTotales = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvTotales = New System.Windows.Forms.DataGridView()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvTotalesPorPalet = New System.Windows.Forms.DataGridView()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.PrintForm1 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.PrintForm2 = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        AlbaranCargaMaestroIDLabel = New System.Windows.Forms.Label()
        AlbaranCargaProMaestroIDLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ClienteIDLabel = New System.Windows.Forms.Label()
        SerieQSIDLabel = New System.Windows.Forms.Label()
        NumeroQSLabel = New System.Windows.Forms.Label()
        AlmacenSalidaQSIDLabel = New System.Windows.Forms.Label()
        PorteFormaPagoIDLabel = New System.Windows.Forms.Label()
        PorteImporteLabel = New System.Windows.Forms.Label()
        ConductorLabel = New System.Windows.Forms.Label()
        HoraLlegadaLabel = New System.Windows.Forms.Label()
        HoraSalidaLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        Label16 = New System.Windows.Forms.Label()
        Label17 = New System.Windows.Forms.Label()
        Label19 = New System.Windows.Forms.Label()
        Label18 = New System.Windows.Forms.Label()
        Label20 = New System.Windows.Forms.Label()
        Label21 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsAlbaranesCargaMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPalet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmPalets.SuspendLayout()
        Me.tabDatos.SuspendLayout()
        Me.tabPagDatos.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.grbDatosTransporte.SuspendLayout()
        Me.grbDatosCabecera.SuspendLayout()
        Me.grbAlbaranesPendientes.SuspendLayout()
        CType(Me.dgvAlbaranesProvi, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        Me.tabPagPalets.SuspendLayout()
        Me.tabPagAcumulados.SuspendLayout()
        CType(Me.dgvAcumulados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmAcumulados.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvTotalPalets, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabPagTotales.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTotalesPorPalet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "AlbaranesCargaMaestro"
        Me.GeneralBindingSource.DataSource = Me.DtsAlbaranesCargaMaestro
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4)
        '
        'AlbaranCargaMaestroIDLabel
        '
        AlbaranCargaMaestroIDLabel.AutoSize = True
        AlbaranCargaMaestroIDLabel.Location = New System.Drawing.Point(26, 6)
        AlbaranCargaMaestroIDLabel.Name = "AlbaranCargaMaestroIDLabel"
        AlbaranCargaMaestroIDLabel.Size = New System.Drawing.Size(123, 13)
        AlbaranCargaMaestroIDLabel.TabIndex = 0
        AlbaranCargaMaestroIDLabel.Text = "AlbaranCargaMaestroID:"
        AlbaranCargaMaestroIDLabel.Visible = False
        '
        'AlbaranCargaProMaestroIDLabel
        '
        AlbaranCargaProMaestroIDLabel.AutoSize = True
        AlbaranCargaProMaestroIDLabel.Location = New System.Drawing.Point(256, 6)
        AlbaranCargaProMaestroIDLabel.Name = "AlbaranCargaProMaestroIDLabel"
        AlbaranCargaProMaestroIDLabel.Size = New System.Drawing.Size(139, 13)
        AlbaranCargaProMaestroIDLabel.TabIndex = 2
        AlbaranCargaProMaestroIDLabel.Text = "AlbaranCargaProMaestroID:"
        AlbaranCargaProMaestroIDLabel.Visible = False
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(15, 28)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 0
        FechaLabel.Text = "Fecha:"
        '
        'ClienteIDLabel
        '
        ClienteIDLabel.AutoSize = True
        ClienteIDLabel.Location = New System.Drawing.Point(15, 58)
        ClienteIDLabel.Name = "ClienteIDLabel"
        ClienteIDLabel.Size = New System.Drawing.Size(42, 13)
        ClienteIDLabel.TabIndex = 2
        ClienteIDLabel.Text = "Cliente:"
        '
        'SerieQSIDLabel
        '
        SerieQSIDLabel.AutoSize = True
        SerieQSIDLabel.Location = New System.Drawing.Point(17, 224)
        SerieQSIDLabel.Name = "SerieQSIDLabel"
        SerieQSIDLabel.Size = New System.Drawing.Size(63, 13)
        SerieQSIDLabel.TabIndex = 14
        SerieQSIDLabel.Text = "Serie QSID:"
        '
        'NumeroQSLabel
        '
        NumeroQSLabel.AutoSize = True
        NumeroQSLabel.Location = New System.Drawing.Point(15, 159)
        NumeroQSLabel.Name = "NumeroQSLabel"
        NumeroQSLabel.Size = New System.Drawing.Size(65, 13)
        NumeroQSLabel.TabIndex = 8
        NumeroQSLabel.Text = "Numero QS:"
        '
        'AlmacenSalidaQSIDLabel
        '
        AlmacenSalidaQSIDLabel.AutoSize = True
        AlmacenSalidaQSIDLabel.Location = New System.Drawing.Point(17, 257)
        AlmacenSalidaQSIDLabel.Name = "AlmacenSalidaQSIDLabel"
        AlmacenSalidaQSIDLabel.Size = New System.Drawing.Size(112, 13)
        AlmacenSalidaQSIDLabel.TabIndex = 16
        AlmacenSalidaQSIDLabel.Text = "Almacen Salida QSID:"
        '
        'PorteFormaPagoIDLabel
        '
        PorteFormaPagoIDLabel.AutoSize = True
        PorteFormaPagoIDLabel.Location = New System.Drawing.Point(204, 184)
        PorteFormaPagoIDLabel.Name = "PorteFormaPagoIDLabel"
        PorteFormaPagoIDLabel.Size = New System.Drawing.Size(67, 13)
        PorteFormaPagoIDLabel.TabIndex = 17
        PorteFormaPagoIDLabel.Text = "Forma Pago:"
        '
        'PorteImporteLabel
        '
        PorteImporteLabel.AutoSize = True
        PorteImporteLabel.Location = New System.Drawing.Point(204, 155)
        PorteImporteLabel.Name = "PorteImporteLabel"
        PorteImporteLabel.Size = New System.Drawing.Size(73, 13)
        PorteImporteLabel.TabIndex = 15
        PorteImporteLabel.Text = "Porte Importe:"
        '
        'ConductorLabel
        '
        ConductorLabel.AutoSize = True
        ConductorLabel.Location = New System.Drawing.Point(18, 48)
        ConductorLabel.Name = "ConductorLabel"
        ConductorLabel.Size = New System.Drawing.Size(59, 13)
        ConductorLabel.TabIndex = 0
        ConductorLabel.Text = "Conductor:"
        '
        'HoraLlegadaLabel
        '
        HoraLlegadaLabel.AutoSize = True
        HoraLlegadaLabel.Location = New System.Drawing.Point(18, 128)
        HoraLlegadaLabel.Name = "HoraLlegadaLabel"
        HoraLlegadaLabel.Size = New System.Drawing.Size(74, 13)
        HoraLlegadaLabel.TabIndex = 11
        HoraLlegadaLabel.Text = "Hora Llegada:"
        '
        'HoraSalidaLabel
        '
        HoraSalidaLabel.AutoSize = True
        HoraSalidaLabel.Location = New System.Drawing.Point(19, 155)
        HoraSalidaLabel.Name = "HoraSalidaLabel"
        HoraSalidaLabel.Size = New System.Drawing.Size(65, 13)
        HoraSalidaLabel.TabIndex = 13
        HoraSalidaLabel.Text = "Hora Salida:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(15, 192)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 10
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(15, 93)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(43, 13)
        Label2.TabIndex = 4
        Label2.Text = "Pedido:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(15, 126)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(76, 13)
        Label8.TabIndex = 6
        Label8.Text = "Lugar entrega:"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(23, 29)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(46, 13)
        Label9.TabIndex = 0
        Label9.Text = "Cabeza:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(23, 55)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(59, 13)
        Label10.TabIndex = 4
        Label10.Text = "Conductor:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(209, 143)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(73, 13)
        Label11.TabIndex = 14
        Label11.Text = "Porte Importe:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(23, 81)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(81, 13)
        Label12.TabIndex = 6
        Label12.Text = "Conductor DNI:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(209, 169)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(67, 13)
        Label13.TabIndex = 16
        Label13.Text = "Forma Pago:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(209, 114)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(49, 13)
        Label14.TabIndex = 10
        Label14.Text = "Agencia:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(23, 118)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(74, 13)
        Label15.TabIndex = 8
        Label15.Text = "Hora Llegada:"
        '
        'Label16
        '
        Label16.AutoSize = True
        Label16.Location = New System.Drawing.Point(24, 145)
        Label16.Name = "Label16"
        Label16.Size = New System.Drawing.Size(65, 13)
        Label16.TabIndex = 12
        Label16.Text = "Hora Salida:"
        '
        'Label17
        '
        Label17.AutoSize = True
        Label17.Location = New System.Drawing.Point(18, 95)
        Label17.Name = "Label17"
        Label17.Size = New System.Drawing.Size(42, 13)
        Label17.TabIndex = 6
        Label17.Text = "Camion"
        '
        'Label19
        '
        Label19.AutoSize = True
        Label19.Location = New System.Drawing.Point(236, 29)
        Label19.Name = "Label19"
        Label19.Size = New System.Drawing.Size(58, 13)
        Label19.TabIndex = 2
        Label19.Text = "Remolque:"
        '
        'Label18
        '
        Label18.AutoSize = True
        Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label18.Location = New System.Drawing.Point(406, 79)
        Label18.Name = "Label18"
        Label18.Size = New System.Drawing.Size(34, 9)
        Label18.TabIndex = 5
        Label18.Text = "Agencia:"
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.Location = New System.Drawing.Point(205, 79)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(42, 9)
        Label20.TabIndex = 4
        Label20.Text = "Remolque:"
        '
        'Label21
        '
        Label21.AutoSize = True
        Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label21.Location = New System.Drawing.Point(106, 79)
        Label21.Name = "Label21"
        Label21.Size = New System.Drawing.Size(33, 9)
        Label21.TabIndex = 3
        Label21.Text = "Cabeza:"
        '
        'DtsAlbaranesCargaMaestro
        '
        Me.DtsAlbaranesCargaMaestro.DataSetName = "dtsAlbaranesCargaMaestro"
        Me.DtsAlbaranesCargaMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'txtAlbaranCargaMaestroID
        '
        Me.txtAlbaranCargaMaestroID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaMaestroID", True))
        Me.txtAlbaranCargaMaestroID.EsUnicoCampo = ""
        Me.txtAlbaranCargaMaestroID.EsUnicoCampoID = ""
        Me.txtAlbaranCargaMaestroID.EsUnicoID = 0
        Me.txtAlbaranCargaMaestroID.EsUnicoTabla = ""
        Me.txtAlbaranCargaMaestroID.Location = New System.Drawing.Point(189, 3)
        Me.txtAlbaranCargaMaestroID.Minimo = 0
        Me.txtAlbaranCargaMaestroID.Modificado = False
        Me.txtAlbaranCargaMaestroID.Name = "txtAlbaranCargaMaestroID"
        Me.txtAlbaranCargaMaestroID.Numerico_EsNumerico = False
        Me.txtAlbaranCargaMaestroID.Numerico_NumeroDoublees = 0
        Me.txtAlbaranCargaMaestroID.Numerico_SeparadorMiles = False
        Me.txtAlbaranCargaMaestroID.Obligatorio = False
        Me.txtAlbaranCargaMaestroID.ParametroID = 0
        Me.txtAlbaranCargaMaestroID.Size = New System.Drawing.Size(57, 20)
        Me.txtAlbaranCargaMaestroID.TabIndex = 1
        Me.txtAlbaranCargaMaestroID.ValorMaximo = 0R
        Me.txtAlbaranCargaMaestroID.ValorMinimo = 0R
        Me.txtAlbaranCargaMaestroID.Visible = False
        '
        'txtMaestroID
        '
        Me.txtMaestroID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaProMaestroID", True))
        Me.txtMaestroID.EsUnicoCampo = ""
        Me.txtMaestroID.EsUnicoCampoID = ""
        Me.txtMaestroID.EsUnicoID = 0
        Me.txtMaestroID.EsUnicoTabla = ""
        Me.txtMaestroID.Location = New System.Drawing.Point(419, 6)
        Me.txtMaestroID.Minimo = 0
        Me.txtMaestroID.Modificado = False
        Me.txtMaestroID.Name = "txtMaestroID"
        Me.txtMaestroID.Numerico_EsNumerico = False
        Me.txtMaestroID.Numerico_NumeroDoublees = 0
        Me.txtMaestroID.Numerico_SeparadorMiles = False
        Me.txtMaestroID.Obligatorio = False
        Me.txtMaestroID.ParametroID = 0
        Me.txtMaestroID.Size = New System.Drawing.Size(57, 20)
        Me.txtMaestroID.TabIndex = 1000000003
        Me.txtMaestroID.ValorMaximo = 0R
        Me.txtMaestroID.ValorMinimo = 0R
        Me.txtMaestroID.Visible = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(99, 22)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.FechaDateTimePicker.TabIndex = 1
        '
        'SerieQSIDCuadroDeTexto
        '
        Me.SerieQSIDCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SerieQSIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "SerieQSID", True))
        Me.SerieQSIDCuadroDeTexto.EsUnicoCampo = ""
        Me.SerieQSIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.SerieQSIDCuadroDeTexto.EsUnicoID = 0
        Me.SerieQSIDCuadroDeTexto.EsUnicoTabla = ""
        Me.SerieQSIDCuadroDeTexto.Location = New System.Drawing.Point(180, 222)
        Me.SerieQSIDCuadroDeTexto.Minimo = 0
        Me.SerieQSIDCuadroDeTexto.Modificado = False
        Me.SerieQSIDCuadroDeTexto.Name = "SerieQSIDCuadroDeTexto"
        Me.SerieQSIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.SerieQSIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.SerieQSIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.SerieQSIDCuadroDeTexto.Obligatorio = False
        Me.SerieQSIDCuadroDeTexto.ParametroID = 0
        Me.SerieQSIDCuadroDeTexto.Size = New System.Drawing.Size(87, 20)
        Me.SerieQSIDCuadroDeTexto.TabIndex = 15
        Me.SerieQSIDCuadroDeTexto.ValorMaximo = 0R
        Me.SerieQSIDCuadroDeTexto.ValorMinimo = 0R
        '
        'NumeroQSCuadroDeTexto
        '
        Me.NumeroQSCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.NumeroQSCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "NumeroQS", True))
        Me.NumeroQSCuadroDeTexto.EsUnicoCampo = ""
        Me.NumeroQSCuadroDeTexto.EsUnicoCampoID = ""
        Me.NumeroQSCuadroDeTexto.EsUnicoID = 0
        Me.NumeroQSCuadroDeTexto.EsUnicoTabla = ""
        Me.NumeroQSCuadroDeTexto.Location = New System.Drawing.Point(97, 157)
        Me.NumeroQSCuadroDeTexto.Minimo = 0
        Me.NumeroQSCuadroDeTexto.Modificado = False
        Me.NumeroQSCuadroDeTexto.Name = "NumeroQSCuadroDeTexto"
        Me.NumeroQSCuadroDeTexto.Numerico_EsNumerico = False
        Me.NumeroQSCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.NumeroQSCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.NumeroQSCuadroDeTexto.Obligatorio = False
        Me.NumeroQSCuadroDeTexto.ParametroID = 0
        Me.NumeroQSCuadroDeTexto.Size = New System.Drawing.Size(87, 20)
        Me.NumeroQSCuadroDeTexto.TabIndex = 9
        Me.NumeroQSCuadroDeTexto.ValorMaximo = 0R
        Me.NumeroQSCuadroDeTexto.ValorMinimo = 0R
        '
        'AlmacenSalidaQSIDCuadroDeTexto
        '
        Me.AlmacenSalidaQSIDCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AlmacenSalidaQSIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlmacenSalidaQSID", True))
        Me.AlmacenSalidaQSIDCuadroDeTexto.EsUnicoCampo = ""
        Me.AlmacenSalidaQSIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.AlmacenSalidaQSIDCuadroDeTexto.EsUnicoID = 0
        Me.AlmacenSalidaQSIDCuadroDeTexto.EsUnicoTabla = ""
        Me.AlmacenSalidaQSIDCuadroDeTexto.Location = New System.Drawing.Point(180, 255)
        Me.AlmacenSalidaQSIDCuadroDeTexto.Minimo = 0
        Me.AlmacenSalidaQSIDCuadroDeTexto.Modificado = False
        Me.AlmacenSalidaQSIDCuadroDeTexto.Name = "AlmacenSalidaQSIDCuadroDeTexto"
        Me.AlmacenSalidaQSIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.AlmacenSalidaQSIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AlmacenSalidaQSIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AlmacenSalidaQSIDCuadroDeTexto.Obligatorio = False
        Me.AlmacenSalidaQSIDCuadroDeTexto.ParametroID = 0
        Me.AlmacenSalidaQSIDCuadroDeTexto.Size = New System.Drawing.Size(87, 20)
        Me.AlmacenSalidaQSIDCuadroDeTexto.TabIndex = 17
        Me.AlmacenSalidaQSIDCuadroDeTexto.ValorMaximo = 0R
        Me.AlmacenSalidaQSIDCuadroDeTexto.ValorMinimo = 0R
        '
        'PorteImporteCuadroDeTexto
        '
        Me.PorteImporteCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PorteImporteCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "PorteImporte", True))
        Me.PorteImporteCuadroDeTexto.EsUnicoCampo = ""
        Me.PorteImporteCuadroDeTexto.EsUnicoCampoID = ""
        Me.PorteImporteCuadroDeTexto.EsUnicoID = 0
        Me.PorteImporteCuadroDeTexto.EsUnicoTabla = ""
        Me.PorteImporteCuadroDeTexto.Location = New System.Drawing.Point(312, 152)
        Me.PorteImporteCuadroDeTexto.Minimo = 0
        Me.PorteImporteCuadroDeTexto.Modificado = False
        Me.PorteImporteCuadroDeTexto.Name = "PorteImporteCuadroDeTexto"
        Me.PorteImporteCuadroDeTexto.Numerico_EsNumerico = False
        Me.PorteImporteCuadroDeTexto.Numerico_NumeroDoublees = 2
        Me.PorteImporteCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.PorteImporteCuadroDeTexto.Obligatorio = False
        Me.PorteImporteCuadroDeTexto.ParametroID = 0
        Me.PorteImporteCuadroDeTexto.Size = New System.Drawing.Size(85, 20)
        Me.PorteImporteCuadroDeTexto.TabIndex = 16
        Me.PorteImporteCuadroDeTexto.ValorMaximo = 0R
        Me.PorteImporteCuadroDeTexto.ValorMinimo = 0R
        '
        'ConductorDNICuadroDeTexto
        '
        Me.ConductorDNICuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ConductorDNICuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "ConductorDNI", True))
        Me.ConductorDNICuadroDeTexto.EsUnicoCampo = ""
        Me.ConductorDNICuadroDeTexto.EsUnicoCampoID = ""
        Me.ConductorDNICuadroDeTexto.EsUnicoID = 0
        Me.ConductorDNICuadroDeTexto.EsUnicoTabla = ""
        Me.ConductorDNICuadroDeTexto.Location = New System.Drawing.Point(405, 44)
        Me.ConductorDNICuadroDeTexto.Minimo = 0
        Me.ConductorDNICuadroDeTexto.Modificado = False
        Me.ConductorDNICuadroDeTexto.Name = "ConductorDNICuadroDeTexto"
        Me.ConductorDNICuadroDeTexto.Numerico_EsNumerico = False
        Me.ConductorDNICuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ConductorDNICuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ConductorDNICuadroDeTexto.Obligatorio = False
        Me.ConductorDNICuadroDeTexto.ParametroID = 0
        Me.ConductorDNICuadroDeTexto.Size = New System.Drawing.Size(184, 20)
        Me.ConductorDNICuadroDeTexto.TabIndex = 2
        Me.ConductorDNICuadroDeTexto.ValorMaximo = 0R
        Me.ConductorDNICuadroDeTexto.ValorMinimo = 0R
        '
        'HoraLlegadaDateTimePicker
        '
        Me.HoraLlegadaDateTimePicker.CustomFormat = "HH:mm"
        Me.HoraLlegadaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "HoraLlegada", True))
        Me.HoraLlegadaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraLlegadaDateTimePicker.Location = New System.Drawing.Point(106, 124)
        Me.HoraLlegadaDateTimePicker.Name = "HoraLlegadaDateTimePicker"
        Me.HoraLlegadaDateTimePicker.ShowUpDown = True
        Me.HoraLlegadaDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.HoraLlegadaDateTimePicker.TabIndex = 12
        '
        'HoraSalidaDateTimePicker
        '
        Me.HoraSalidaDateTimePicker.CustomFormat = "HH:mm"
        Me.HoraSalidaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "HoraSalida", True))
        Me.HoraSalidaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.HoraSalidaDateTimePicker.Location = New System.Drawing.Point(106, 155)
        Me.HoraSalidaDateTimePicker.Name = "HoraSalidaDateTimePicker"
        Me.HoraSalidaDateTimePicker.ShowUpDown = True
        Me.HoraSalidaDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.HoraSalidaDateTimePicker.TabIndex = 14
        '
        'ObservacionesCuadroDeTexto
        '
        Me.ObservacionesCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ObservacionesCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.ObservacionesCuadroDeTexto.EsUnicoCampo = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoCampoID = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoID = 0
        Me.ObservacionesCuadroDeTexto.EsUnicoTabla = ""
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(97, 190)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(379, 20)
        Me.ObservacionesCuadroDeTexto.TabIndex = 11
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0R
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0R
        '
        'dgvPalet
        '
        Me.dgvPalet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPalet.ContextMenuStrip = Me.cmPalets
        Me.dgvPalet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPalet.Location = New System.Drawing.Point(3, 3)
        Me.dgvPalet.Name = "dgvPalet"
        Me.dgvPalet.RowTemplate.Height = 24
        Me.dgvPalet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPalet.Size = New System.Drawing.Size(1197, 625)
        Me.dgvPalet.TabIndex = 1000000043
        '
        'cmPalets
        '
        Me.cmPalets.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MarcarComoMultiloteToolStripMenuItem, Me.ToolStripSeparator4, Me.MarcarComoNoMultiloteToolStripMenuItem, Me.ToolStripSeparator2, Me.CambiarLoteToolStripMenuItem, Me.ReiniciarLoteToolStripMenuItem, Me.EliminarToolStripMenuItem})
        Me.cmPalets.Name = "cmPalets"
        Me.cmPalets.Size = New System.Drawing.Size(214, 126)
        '
        'MarcarComoMultiloteToolStripMenuItem
        '
        Me.MarcarComoMultiloteToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.brick_add
        Me.MarcarComoMultiloteToolStripMenuItem.Name = "MarcarComoMultiloteToolStripMenuItem"
        Me.MarcarComoMultiloteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MarcarComoMultiloteToolStripMenuItem.Text = "Marcar como multilote"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(210, 6)
        '
        'MarcarComoNoMultiloteToolStripMenuItem
        '
        Me.MarcarComoNoMultiloteToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.brick_delete
        Me.MarcarComoNoMultiloteToolStripMenuItem.Name = "MarcarComoNoMultiloteToolStripMenuItem"
        Me.MarcarComoNoMultiloteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.MarcarComoNoMultiloteToolStripMenuItem.Text = "Marcar como no multilote"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(210, 6)
        '
        'CambiarLoteToolStripMenuItem
        '
        Me.CambiarLoteToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.calendar_edit
        Me.CambiarLoteToolStripMenuItem.Name = "CambiarLoteToolStripMenuItem"
        Me.CambiarLoteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.CambiarLoteToolStripMenuItem.Text = "Cambiar lote"
        '
        'ReiniciarLoteToolStripMenuItem
        '
        Me.ReiniciarLoteToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.calendar_delete
        Me.ReiniciarLoteToolStripMenuItem.Name = "ReiniciarLoteToolStripMenuItem"
        Me.ReiniciarLoteToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.ReiniciarLoteToolStripMenuItem.Text = "Reiniciar lote"
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(213, 22)
        Me.EliminarToolStripMenuItem.Text = "Eliminar"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(238, 6)
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.tabPagDatos)
        Me.tabDatos.Controls.Add(Me.tabPagPalets)
        Me.tabDatos.Controls.Add(Me.tabPagAcumulados)
        Me.tabDatos.Controls.Add(Me.TabPagTotales)
        Me.tabDatos.Location = New System.Drawing.Point(0, 28)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectedIndex = 0
        Me.tabDatos.Size = New System.Drawing.Size(1211, 657)
        Me.tabDatos.TabIndex = 0
        '
        'tabPagDatos
        '
        Me.tabPagDatos.Controls.Add(Me.Panel4)
        Me.tabPagDatos.Controls.Add(Me.Panel5)
        Me.tabPagDatos.Location = New System.Drawing.Point(4, 22)
        Me.tabPagDatos.Name = "tabPagDatos"
        Me.tabPagDatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagDatos.Size = New System.Drawing.Size(1203, 631)
        Me.tabPagDatos.TabIndex = 0
        Me.tabPagDatos.Text = "Datos"
        Me.tabPagDatos.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.grbDatosTransporte)
        Me.Panel4.Controls.Add(Me.grbDatosCabecera)
        Me.Panel4.Controls.Add(Me.grbAlbaranesPendientes)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 32)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1197, 596)
        Me.Panel4.TabIndex = 1000000058
        '
        'grbDatosTransporte
        '
        Me.grbDatosTransporte.BackColor = System.Drawing.Color.Transparent
        Me.grbDatosTransporte.Controls.Add(Me.cboAgencia)
        Me.grbDatosTransporte.Controls.Add(Label21)
        Me.grbDatosTransporte.Controls.Add(Label20)
        Me.grbDatosTransporte.Controls.Add(Label18)
        Me.grbDatosTransporte.Controls.Add(Me.txtDetalleRemolque)
        Me.grbDatosTransporte.Controls.Add(Me.btnNuevoCamion)
        Me.grbDatosTransporte.Controls.Add(Me.cboCabeza)
        Me.grbDatosTransporte.Controls.Add(Me.cboFormaPAgo)
        Me.grbDatosTransporte.Controls.Add(Me.cboREsponsableAdminsitracion)
        Me.grbDatosTransporte.Controls.Add(Label17)
        Me.grbDatosTransporte.Controls.Add(Me.cboREsponsableCarga)
        Me.grbDatosTransporte.Controls.Add(Me.PorteImporteCuadroDeTexto)
        Me.grbDatosTransporte.Controls.Add(ConductorLabel)
        Me.grbDatosTransporte.Controls.Add(Me.Label24)
        Me.grbDatosTransporte.Controls.Add(PorteImporteLabel)
        Me.grbDatosTransporte.Controls.Add(Me.Label23)
        Me.grbDatosTransporte.Controls.Add(Me.cboConductores)
        Me.grbDatosTransporte.Controls.Add(PorteFormaPagoIDLabel)
        Me.grbDatosTransporte.Controls.Add(Me.ConductorDNICuadroDeTexto)
        Me.grbDatosTransporte.Controls.Add(HoraLlegadaLabel)
        Me.grbDatosTransporte.Controls.Add(Me.HoraLlegadaDateTimePicker)
        Me.grbDatosTransporte.Controls.Add(HoraSalidaLabel)
        Me.grbDatosTransporte.Controls.Add(Me.HoraSalidaDateTimePicker)
        Me.grbDatosTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbDatosTransporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbDatosTransporte.Location = New System.Drawing.Point(520, 0)
        Me.grbDatosTransporte.Name = "grbDatosTransporte"
        Me.grbDatosTransporte.Size = New System.Drawing.Size(677, 332)
        Me.grbDatosTransporte.TabIndex = 1
        Me.grbDatosTransporte.TabStop = False
        Me.grbDatosTransporte.Text = "Datos transporte"
        '
        'cboAgencia
        '
        Me.cboAgencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAgencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAgencia.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboAgencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAgencia.FormattingEnabled = True
        Me.cboAgencia.Location = New System.Drawing.Point(405, 90)
        Me.cboAgencia.Name = "cboAgencia"
        Me.cboAgencia.Size = New System.Drawing.Size(184, 21)
        Me.cboAgencia.TabIndex = 9
        '
        'txtDetalleRemolque
        '
        Me.txtDetalleRemolque.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalleRemolque.Location = New System.Drawing.Point(207, 90)
        Me.txtDetalleRemolque.Name = "txtDetalleRemolque"
        Me.txtDetalleRemolque.Size = New System.Drawing.Size(190, 20)
        Me.txtDetalleRemolque.TabIndex = 8
        '
        'btnNuevoCamion
        '
        Me.btnNuevoCamion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNuevoCamion.Image = Global.La_Andaluza.My.Resources.Resources.car
        Me.btnNuevoCamion.Location = New System.Drawing.Point(595, 90)
        Me.btnNuevoCamion.Name = "btnNuevoCamion"
        Me.btnNuevoCamion.Size = New System.Drawing.Size(29, 20)
        Me.btnNuevoCamion.TabIndex = 10
        Me.btnNuevoCamion.UseVisualStyleBackColor = True
        '
        'cboCabeza
        '
        Me.cboCabeza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCabeza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCabeza.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboCabeza.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCabeza.FormattingEnabled = True
        Me.cboCabeza.Location = New System.Drawing.Point(108, 90)
        Me.cboCabeza.Name = "cboCabeza"
        Me.cboCabeza.Size = New System.Drawing.Size(85, 21)
        Me.cboCabeza.TabIndex = 7
        '
        'cboFormaPAgo
        '
        Me.cboFormaPAgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFormaPAgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFormaPAgo.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboFormaPAgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFormaPAgo.FormattingEnabled = True
        Me.cboFormaPAgo.Location = New System.Drawing.Point(312, 181)
        Me.cboFormaPAgo.Name = "cboFormaPAgo"
        Me.cboFormaPAgo.Size = New System.Drawing.Size(277, 21)
        Me.cboFormaPAgo.TabIndex = 18
        '
        'cboREsponsableAdminsitracion
        '
        Me.cboREsponsableAdminsitracion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboREsponsableAdminsitracion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboREsponsableAdminsitracion.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboREsponsableAdminsitracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboREsponsableAdminsitracion.FormattingEnabled = True
        Me.cboREsponsableAdminsitracion.Location = New System.Drawing.Point(165, 257)
        Me.cboREsponsableAdminsitracion.Name = "cboREsponsableAdminsitracion"
        Me.cboREsponsableAdminsitracion.Size = New System.Drawing.Size(424, 21)
        Me.cboREsponsableAdminsitracion.TabIndex = 22
        '
        'cboREsponsableCarga
        '
        Me.cboREsponsableCarga.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboREsponsableCarga.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboREsponsableCarga.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboREsponsableCarga.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboREsponsableCarga.FormattingEnabled = True
        Me.cboREsponsableCarga.Location = New System.Drawing.Point(165, 211)
        Me.cboREsponsableCarga.Name = "cboREsponsableCarga"
        Me.cboREsponsableCarga.Size = New System.Drawing.Size(424, 21)
        Me.cboREsponsableCarga.TabIndex = 20
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(18, 260)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(139, 13)
        Me.Label24.TabIndex = 21
        Me.Label24.Text = "Responsable administracion"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(18, 221)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(99, 13)
        Me.Label23.TabIndex = 19
        Me.Label23.Text = "Responsable carga"
        '
        'cboConductores
        '
        Me.cboConductores.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboConductores.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConductores.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboConductores.FormattingEnabled = True
        Me.cboConductores.Location = New System.Drawing.Point(106, 45)
        Me.cboConductores.Name = "cboConductores"
        Me.cboConductores.Size = New System.Drawing.Size(291, 21)
        Me.cboConductores.TabIndex = 1
        '
        'grbDatosCabecera
        '
        Me.grbDatosCabecera.Controls.Add(Me.cboPedido)
        Me.grbDatosCabecera.Controls.Add(Me.cboLugaresEntrega)
        Me.grbDatosCabecera.Controls.Add(Me.cboClientes)
        Me.grbDatosCabecera.Controls.Add(Me.FechaDateTimePicker)
        Me.grbDatosCabecera.Controls.Add(Label8)
        Me.grbDatosCabecera.Controls.Add(ClienteIDLabel)
        Me.grbDatosCabecera.Controls.Add(Label2)
        Me.grbDatosCabecera.Controls.Add(FechaLabel)
        Me.grbDatosCabecera.Controls.Add(Me.AlmacenSalidaQSIDCuadroDeTexto)
        Me.grbDatosCabecera.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.grbDatosCabecera.Controls.Add(AlmacenSalidaQSIDLabel)
        Me.grbDatosCabecera.Controls.Add(ObservacionesLabel)
        Me.grbDatosCabecera.Controls.Add(Me.SerieQSIDCuadroDeTexto)
        Me.grbDatosCabecera.Controls.Add(NumeroQSLabel)
        Me.grbDatosCabecera.Controls.Add(Me.NumeroQSCuadroDeTexto)
        Me.grbDatosCabecera.Controls.Add(SerieQSIDLabel)
        Me.grbDatosCabecera.Dock = System.Windows.Forms.DockStyle.Left
        Me.grbDatosCabecera.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbDatosCabecera.Location = New System.Drawing.Point(0, 0)
        Me.grbDatosCabecera.Name = "grbDatosCabecera"
        Me.grbDatosCabecera.Size = New System.Drawing.Size(520, 332)
        Me.grbDatosCabecera.TabIndex = 0
        Me.grbDatosCabecera.TabStop = False
        Me.grbDatosCabecera.Text = "Datos cabecera"
        '
        'cboPedido
        '
        Me.cboPedido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPedido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPedido.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPedido.FormattingEnabled = True
        Me.cboPedido.Location = New System.Drawing.Point(97, 89)
        Me.cboPedido.Name = "cboPedido"
        Me.cboPedido.Size = New System.Drawing.Size(379, 21)
        Me.cboPedido.TabIndex = 5
        '
        'cboLugaresEntrega
        '
        Me.cboLugaresEntrega.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLugaresEntrega.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLugaresEntrega.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboLugaresEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLugaresEntrega.FormattingEnabled = True
        Me.cboLugaresEntrega.Location = New System.Drawing.Point(97, 123)
        Me.cboLugaresEntrega.Name = "cboLugaresEntrega"
        Me.cboLugaresEntrega.Size = New System.Drawing.Size(379, 21)
        Me.cboLugaresEntrega.TabIndex = 7
        '
        'cboClientes
        '
        Me.cboClientes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboClientes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClientes.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(97, 55)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(379, 21)
        Me.cboClientes.TabIndex = 3
        '
        'grbAlbaranesPendientes
        '
        Me.grbAlbaranesPendientes.Controls.Add(Me.dgvAlbaranesProvi)
        Me.grbAlbaranesPendientes.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbAlbaranesPendientes.Location = New System.Drawing.Point(0, 332)
        Me.grbAlbaranesPendientes.Name = "grbAlbaranesPendientes"
        Me.grbAlbaranesPendientes.Size = New System.Drawing.Size(1197, 264)
        Me.grbAlbaranesPendientes.TabIndex = 2
        Me.grbAlbaranesPendientes.TabStop = False
        Me.grbAlbaranesPendientes.Text = "Albaranes provisionales sin asignar."
        '
        'dgvAlbaranesProvi
        '
        Me.dgvAlbaranesProvi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvAlbaranesProvi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlbaranesProvi.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAlbaranesProvi.Location = New System.Drawing.Point(3, 16)
        Me.dgvAlbaranesProvi.Name = "dgvAlbaranesProvi"
        Me.dgvAlbaranesProvi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvAlbaranesProvi.Size = New System.Drawing.Size(1191, 245)
        Me.dgvAlbaranesProvi.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtAlbaranCargaMaestroID)
        Me.Panel5.Controls.Add(Me.txtMaestroID)
        Me.Panel5.Controls.Add(AlbaranCargaMaestroIDLabel)
        Me.Panel5.Controls.Add(AlbaranCargaProMaestroIDLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1197, 29)
        Me.Panel5.TabIndex = 0
        '
        'tabPagPalets
        '
        Me.tabPagPalets.Controls.Add(Me.dgvPalet)
        Me.tabPagPalets.Location = New System.Drawing.Point(4, 22)
        Me.tabPagPalets.Name = "tabPagPalets"
        Me.tabPagPalets.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagPalets.Size = New System.Drawing.Size(1203, 631)
        Me.tabPagPalets.TabIndex = 1
        Me.tabPagPalets.Text = "Palets"
        Me.tabPagPalets.UseVisualStyleBackColor = True
        '
        'tabPagAcumulados
        '
        Me.tabPagAcumulados.Controls.Add(Me.dgvAcumulados)
        Me.tabPagAcumulados.Controls.Add(Me.Label1)
        Me.tabPagAcumulados.Controls.Add(Me.Panel1)
        Me.tabPagAcumulados.Controls.Add(Me.txtTotalBultos)
        Me.tabPagAcumulados.Controls.Add(Me.Label6)
        Me.tabPagAcumulados.Location = New System.Drawing.Point(4, 22)
        Me.tabPagAcumulados.Name = "tabPagAcumulados"
        Me.tabPagAcumulados.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPagAcumulados.Size = New System.Drawing.Size(1203, 631)
        Me.tabPagAcumulados.TabIndex = 2
        Me.tabPagAcumulados.Text = "Acumulados"
        Me.tabPagAcumulados.UseVisualStyleBackColor = True
        '
        'dgvAcumulados
        '
        Me.dgvAcumulados.AllowUserToAddRows = False
        Me.dgvAcumulados.AllowUserToDeleteRows = False
        Me.dgvAcumulados.BackgroundColor = System.Drawing.Color.White
        Me.dgvAcumulados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAcumulados.ContextMenuStrip = Me.cmAcumulados
        Me.dgvAcumulados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAcumulados.Location = New System.Drawing.Point(3, 27)
        Me.dgvAcumulados.Name = "dgvAcumulados"
        Me.dgvAcumulados.RowTemplate.Height = 24
        Me.dgvAcumulados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAcumulados.Size = New System.Drawing.Size(731, 601)
        Me.dgvAcumulados.TabIndex = 1
        '
        'cmAcumulados
        '
        Me.cmAcumulados.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CambiarLoteToolStripMenuItem1, Me.ReiniciarLoteToolStripMenuItem1})
        Me.cmAcumulados.Name = "cmAcumulados"
        Me.cmAcumulados.Size = New System.Drawing.Size(143, 48)
        '
        'CambiarLoteToolStripMenuItem1
        '
        Me.CambiarLoteToolStripMenuItem1.Image = Global.La_Andaluza.My.Resources.Resources.calendar_edit
        Me.CambiarLoteToolStripMenuItem1.Name = "CambiarLoteToolStripMenuItem1"
        Me.CambiarLoteToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.CambiarLoteToolStripMenuItem1.Text = "Cambiar lote"
        '
        'ReiniciarLoteToolStripMenuItem1
        '
        Me.ReiniciarLoteToolStripMenuItem1.Image = Global.La_Andaluza.My.Resources.Resources.calendar_delete
        Me.ReiniciarLoteToolStripMenuItem1.Name = "ReiniciarLoteToolStripMenuItem1"
        Me.ReiniciarLoteToolStripMenuItem1.Size = New System.Drawing.Size(142, 22)
        Me.ReiniciarLoteToolStripMenuItem1.Text = "Reiniciar lote"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(367, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Total referencias acumuladas por lote."
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(734, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Padding = New System.Windows.Forms.Padding(15, 0, 0, 0)
        Me.Panel1.Size = New System.Drawing.Size(466, 625)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvTotalPalets)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(15, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Padding = New System.Windows.Forms.Padding(0, 0, 15, 0)
        Me.Panel2.Size = New System.Drawing.Size(451, 211)
        Me.Panel2.TabIndex = 1000000056
        '
        'dgvTotalPalets
        '
        Me.dgvTotalPalets.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotalPalets.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTotalPalets.Location = New System.Drawing.Point(0, 24)
        Me.dgvTotalPalets.Name = "dgvTotalPalets"
        Me.dgvTotalPalets.RowTemplate.Height = 24
        Me.dgvTotalPalets.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotalPalets.Size = New System.Drawing.Size(436, 187)
        Me.dgvTotalPalets.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 24)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Total palets."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btnCartaJr)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.butRegistrarPortesSalidaQS)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.ButEmbotelladoPedido)
        Me.Panel3.Controls.Add(Me.txtPesoBruto)
        Me.Panel3.Controls.Add(Me.butAlbaranProvisional)
        Me.Panel3.Controls.Add(Me.txtPesoNeto)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Controls.Add(Me.butLAaJR)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(15, 211)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(451, 220)
        Me.Panel3.TabIndex = 0
        '
        'btnCartaJr
        '
        Me.btnCartaJr.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCartaJr.Image = Global.La_Andaluza.My.Resources.Resources.page_white_word_16
        Me.btnCartaJr.Location = New System.Drawing.Point(288, 59)
        Me.btnCartaJr.Name = "btnCartaJr"
        Me.btnCartaJr.Size = New System.Drawing.Size(22, 29)
        Me.btnCartaJr.TabIndex = 6
        Me.btnCartaJr.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Peso bruto:"
        '
        'butRegistrarPortesSalidaQS
        '
        Me.butRegistrarPortesSalidaQS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRegistrarPortesSalidaQS.Location = New System.Drawing.Point(181, 94)
        Me.butRegistrarPortesSalidaQS.Name = "butRegistrarPortesSalidaQS"
        Me.butRegistrarPortesSalidaQS.Size = New System.Drawing.Size(129, 29)
        Me.butRegistrarPortesSalidaQS.TabIndex = 7
        Me.butRegistrarPortesSalidaQS.Text = "Registrar porte en QS"
        Me.butRegistrarPortesSalidaQS.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(3, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Peso neto:"
        '
        'ButEmbotelladoPedido
        '
        Me.ButEmbotelladoPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ButEmbotelladoPedido.Location = New System.Drawing.Point(181, 128)
        Me.ButEmbotelladoPedido.Name = "ButEmbotelladoPedido"
        Me.ButEmbotelladoPedido.Size = New System.Drawing.Size(129, 44)
        Me.ButEmbotelladoPedido.TabIndex = 8
        Me.ButEmbotelladoPedido.Text = "Embotellado con pedido"
        Me.ButEmbotelladoPedido.UseVisualStyleBackColor = True
        '
        'txtPesoBruto
        '
        Me.txtPesoBruto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesoBruto.EsUnicoCampo = ""
        Me.txtPesoBruto.EsUnicoCampoID = ""
        Me.txtPesoBruto.EsUnicoID = 0
        Me.txtPesoBruto.EsUnicoTabla = ""
        Me.txtPesoBruto.Location = New System.Drawing.Point(99, 26)
        Me.txtPesoBruto.Minimo = 0
        Me.txtPesoBruto.Modificado = False
        Me.txtPesoBruto.Name = "txtPesoBruto"
        Me.txtPesoBruto.Numerico_EsNumerico = False
        Me.txtPesoBruto.Numerico_NumeroDoublees = 0
        Me.txtPesoBruto.Numerico_SeparadorMiles = False
        Me.txtPesoBruto.Obligatorio = False
        Me.txtPesoBruto.ParametroID = 0
        Me.txtPesoBruto.Size = New System.Drawing.Size(71, 20)
        Me.txtPesoBruto.TabIndex = 1
        Me.txtPesoBruto.ValorMaximo = 0R
        Me.txtPesoBruto.ValorMinimo = 0R
        '
        'butAlbaranProvisional
        '
        Me.butAlbaranProvisional.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAlbaranProvisional.Location = New System.Drawing.Point(181, 24)
        Me.butAlbaranProvisional.Name = "butAlbaranProvisional"
        Me.butAlbaranProvisional.Size = New System.Drawing.Size(129, 29)
        Me.butAlbaranProvisional.TabIndex = 4
        Me.butAlbaranProvisional.Text = "Albaran Provisional"
        Me.butAlbaranProvisional.UseVisualStyleBackColor = True
        '
        'txtPesoNeto
        '
        Me.txtPesoNeto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPesoNeto.EsUnicoCampo = ""
        Me.txtPesoNeto.EsUnicoCampoID = ""
        Me.txtPesoNeto.EsUnicoID = 0
        Me.txtPesoNeto.EsUnicoTabla = ""
        Me.txtPesoNeto.Location = New System.Drawing.Point(99, 61)
        Me.txtPesoNeto.Minimo = 0
        Me.txtPesoNeto.Modificado = False
        Me.txtPesoNeto.Name = "txtPesoNeto"
        Me.txtPesoNeto.Numerico_EsNumerico = False
        Me.txtPesoNeto.Numerico_NumeroDoublees = 0
        Me.txtPesoNeto.Numerico_SeparadorMiles = False
        Me.txtPesoNeto.Obligatorio = False
        Me.txtPesoNeto.ParametroID = 0
        Me.txtPesoNeto.Size = New System.Drawing.Size(71, 20)
        Me.txtPesoNeto.TabIndex = 3
        Me.txtPesoNeto.ValorMaximo = 0R
        Me.txtPesoNeto.ValorMinimo = 0R
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.butAlbaranQS)
        Me.GroupBox2.Controls.Add(Me.butMercadonaCanarias)
        Me.GroupBox2.Controls.Add(Me.butCartaPortes)
        Me.GroupBox2.Controls.Add(Me.butEntradaJR)
        Me.GroupBox2.Controls.Add(Me.butJRaMercadona)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(118, 213)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Mercadona"
        '
        'butAlbaranQS
        '
        Me.butAlbaranQS.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAlbaranQS.Location = New System.Drawing.Point(6, 19)
        Me.butAlbaranQS.Name = "butAlbaranQS"
        Me.butAlbaranQS.Size = New System.Drawing.Size(109, 29)
        Me.butAlbaranQS.TabIndex = 0
        Me.butAlbaranQS.Text = "Salida de LA a JR"
        Me.butAlbaranQS.UseVisualStyleBackColor = True
        '
        'butMercadonaCanarias
        '
        Me.butMercadonaCanarias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butMercadonaCanarias.Location = New System.Drawing.Point(6, 157)
        Me.butMercadonaCanarias.Name = "butMercadonaCanarias"
        Me.butMercadonaCanarias.Size = New System.Drawing.Size(109, 48)
        Me.butMercadonaCanarias.TabIndex = 4
        Me.butMercadonaCanarias.Text = "Salida Mercadona Canarias"
        Me.butMercadonaCanarias.UseVisualStyleBackColor = True
        '
        'butCartaPortes
        '
        Me.butCartaPortes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butCartaPortes.Location = New System.Drawing.Point(6, 122)
        Me.butCartaPortes.Name = "butCartaPortes"
        Me.butCartaPortes.Size = New System.Drawing.Size(109, 29)
        Me.butCartaPortes.TabIndex = 3
        Me.butCartaPortes.Text = "Carta portes"
        Me.butCartaPortes.UseVisualStyleBackColor = True
        '
        'butEntradaJR
        '
        Me.butEntradaJR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEntradaJR.Location = New System.Drawing.Point(6, 54)
        Me.butEntradaJR.Name = "butEntradaJR"
        Me.butEntradaJR.Size = New System.Drawing.Size(109, 29)
        Me.butEntradaJR.TabIndex = 1
        Me.butEntradaJR.Text = "Entrada en JR"
        Me.butEntradaJR.UseVisualStyleBackColor = True
        '
        'butJRaMercadona
        '
        Me.butJRaMercadona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butJRaMercadona.Location = New System.Drawing.Point(6, 89)
        Me.butJRaMercadona.Name = "butJRaMercadona"
        Me.butJRaMercadona.Size = New System.Drawing.Size(109, 29)
        Me.butJRaMercadona.TabIndex = 2
        Me.butJRaMercadona.Text = "JR a Mercadona"
        Me.butJRaMercadona.UseVisualStyleBackColor = True
        '
        'butLAaJR
        '
        Me.butLAaJR.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butLAaJR.Location = New System.Drawing.Point(181, 59)
        Me.butLAaJR.Name = "butLAaJR"
        Me.butLAaJR.Size = New System.Drawing.Size(101, 29)
        Me.butLAaJR.TabIndex = 5
        Me.butLAaJR.Text = "Albaran LA a JR"
        Me.butLAaJR.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Label19)
        Me.GroupBox1.Controls.Add(Me.txtRemolque1)
        Me.GroupBox1.Controls.Add(Label9)
        Me.GroupBox1.Controls.Add(Me.txtCabeza)
        Me.GroupBox1.Controls.Add(Me.CuadroDeTexto2)
        Me.GroupBox1.Controls.Add(Label10)
        Me.GroupBox1.Controls.Add(Label11)
        Me.GroupBox1.Controls.Add(Me.txtConductor)
        Me.GroupBox1.Controls.Add(Me.CuadroDeTexto4)
        Me.GroupBox1.Controls.Add(Label12)
        Me.GroupBox1.Controls.Add(Label13)
        Me.GroupBox1.Controls.Add(Me.txtDNI)
        Me.GroupBox1.Controls.Add(Me.CuadroDeTexto6)
        Me.GroupBox1.Controls.Add(Label14)
        Me.GroupBox1.Controls.Add(Label15)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Label16)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox1.Location = New System.Drawing.Point(15, 431)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(451, 194)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Datos transporte"
        '
        'txtRemolque1
        '
        Me.txtRemolque1.Enabled = False
        Me.txtRemolque1.EsUnicoCampo = ""
        Me.txtRemolque1.EsUnicoCampoID = ""
        Me.txtRemolque1.EsUnicoID = 0
        Me.txtRemolque1.EsUnicoTabla = ""
        Me.txtRemolque1.Location = New System.Drawing.Point(295, 26)
        Me.txtRemolque1.Minimo = 0
        Me.txtRemolque1.Modificado = False
        Me.txtRemolque1.Name = "txtRemolque1"
        Me.txtRemolque1.Numerico_EsNumerico = False
        Me.txtRemolque1.Numerico_NumeroDoublees = 0
        Me.txtRemolque1.Numerico_SeparadorMiles = False
        Me.txtRemolque1.Obligatorio = False
        Me.txtRemolque1.ParametroID = 0
        Me.txtRemolque1.Size = New System.Drawing.Size(109, 20)
        Me.txtRemolque1.TabIndex = 3
        Me.txtRemolque1.ValorMaximo = 0R
        Me.txtRemolque1.ValorMinimo = 0R
        '
        'txtCabeza
        '
        Me.txtCabeza.Enabled = False
        Me.txtCabeza.EsUnicoCampo = ""
        Me.txtCabeza.EsUnicoCampoID = ""
        Me.txtCabeza.EsUnicoID = 0
        Me.txtCabeza.EsUnicoTabla = ""
        Me.txtCabeza.Location = New System.Drawing.Point(113, 26)
        Me.txtCabeza.Minimo = 0
        Me.txtCabeza.Modificado = False
        Me.txtCabeza.Name = "txtCabeza"
        Me.txtCabeza.Numerico_EsNumerico = False
        Me.txtCabeza.Numerico_NumeroDoublees = 0
        Me.txtCabeza.Numerico_SeparadorMiles = False
        Me.txtCabeza.Obligatorio = False
        Me.txtCabeza.ParametroID = 0
        Me.txtCabeza.Size = New System.Drawing.Size(109, 20)
        Me.txtCabeza.TabIndex = 1
        Me.txtCabeza.ValorMaximo = 0R
        Me.txtCabeza.ValorMinimo = 0R
        '
        'CuadroDeTexto2
        '
        Me.CuadroDeTexto2.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "PorteImporte", True))
        Me.CuadroDeTexto2.Enabled = False
        Me.CuadroDeTexto2.EsUnicoCampo = ""
        Me.CuadroDeTexto2.EsUnicoCampoID = ""
        Me.CuadroDeTexto2.EsUnicoID = 0
        Me.CuadroDeTexto2.EsUnicoTabla = ""
        Me.CuadroDeTexto2.Location = New System.Drawing.Point(317, 140)
        Me.CuadroDeTexto2.Minimo = 0
        Me.CuadroDeTexto2.Modificado = False
        Me.CuadroDeTexto2.Name = "CuadroDeTexto2"
        Me.CuadroDeTexto2.Numerico_EsNumerico = False
        Me.CuadroDeTexto2.Numerico_NumeroDoublees = 2
        Me.CuadroDeTexto2.Numerico_SeparadorMiles = False
        Me.CuadroDeTexto2.Obligatorio = False
        Me.CuadroDeTexto2.ParametroID = 0
        Me.CuadroDeTexto2.Size = New System.Drawing.Size(87, 20)
        Me.CuadroDeTexto2.TabIndex = 15
        Me.CuadroDeTexto2.ValorMaximo = 0R
        Me.CuadroDeTexto2.ValorMinimo = 0R
        '
        'txtConductor
        '
        Me.txtConductor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Conductor", True))
        Me.txtConductor.Enabled = False
        Me.txtConductor.EsUnicoCampo = ""
        Me.txtConductor.EsUnicoCampoID = ""
        Me.txtConductor.EsUnicoID = 0
        Me.txtConductor.EsUnicoTabla = ""
        Me.txtConductor.Location = New System.Drawing.Point(113, 52)
        Me.txtConductor.Minimo = 0
        Me.txtConductor.Modificado = False
        Me.txtConductor.Name = "txtConductor"
        Me.txtConductor.Numerico_EsNumerico = False
        Me.txtConductor.Numerico_NumeroDoublees = 0
        Me.txtConductor.Numerico_SeparadorMiles = False
        Me.txtConductor.Obligatorio = False
        Me.txtConductor.ParametroID = 0
        Me.txtConductor.Size = New System.Drawing.Size(291, 20)
        Me.txtConductor.TabIndex = 5
        Me.txtConductor.ValorMaximo = 0R
        Me.txtConductor.ValorMinimo = 0R
        '
        'CuadroDeTexto4
        '
        Me.CuadroDeTexto4.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "PorteFormaPagoID", True))
        Me.CuadroDeTexto4.Enabled = False
        Me.CuadroDeTexto4.EsUnicoCampo = ""
        Me.CuadroDeTexto4.EsUnicoCampoID = ""
        Me.CuadroDeTexto4.EsUnicoID = 0
        Me.CuadroDeTexto4.EsUnicoTabla = ""
        Me.CuadroDeTexto4.Location = New System.Drawing.Point(317, 166)
        Me.CuadroDeTexto4.Minimo = 0
        Me.CuadroDeTexto4.Modificado = False
        Me.CuadroDeTexto4.Name = "CuadroDeTexto4"
        Me.CuadroDeTexto4.Numerico_EsNumerico = False
        Me.CuadroDeTexto4.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto4.Numerico_SeparadorMiles = False
        Me.CuadroDeTexto4.Obligatorio = False
        Me.CuadroDeTexto4.ParametroID = 0
        Me.CuadroDeTexto4.Size = New System.Drawing.Size(87, 20)
        Me.CuadroDeTexto4.TabIndex = 17
        Me.CuadroDeTexto4.ValorMaximo = 0R
        Me.CuadroDeTexto4.ValorMinimo = 0R
        '
        'txtDNI
        '
        Me.txtDNI.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "ConductorDNI", True))
        Me.txtDNI.Enabled = False
        Me.txtDNI.EsUnicoCampo = ""
        Me.txtDNI.EsUnicoCampoID = ""
        Me.txtDNI.EsUnicoID = 0
        Me.txtDNI.EsUnicoTabla = ""
        Me.txtDNI.Location = New System.Drawing.Point(113, 78)
        Me.txtDNI.Minimo = 0
        Me.txtDNI.Modificado = False
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Numerico_EsNumerico = False
        Me.txtDNI.Numerico_NumeroDoublees = 0
        Me.txtDNI.Numerico_SeparadorMiles = False
        Me.txtDNI.Obligatorio = False
        Me.txtDNI.ParametroID = 0
        Me.txtDNI.Size = New System.Drawing.Size(109, 20)
        Me.txtDNI.TabIndex = 7
        Me.txtDNI.ValorMaximo = 0R
        Me.txtDNI.ValorMinimo = 0R
        '
        'CuadroDeTexto6
        '
        Me.CuadroDeTexto6.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AgenciaID", True))
        Me.CuadroDeTexto6.Enabled = False
        Me.CuadroDeTexto6.EsUnicoCampo = ""
        Me.CuadroDeTexto6.EsUnicoCampoID = ""
        Me.CuadroDeTexto6.EsUnicoID = 0
        Me.CuadroDeTexto6.EsUnicoTabla = ""
        Me.CuadroDeTexto6.Location = New System.Drawing.Point(317, 111)
        Me.CuadroDeTexto6.Minimo = 0
        Me.CuadroDeTexto6.Modificado = False
        Me.CuadroDeTexto6.Name = "CuadroDeTexto6"
        Me.CuadroDeTexto6.Numerico_EsNumerico = False
        Me.CuadroDeTexto6.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto6.Numerico_SeparadorMiles = False
        Me.CuadroDeTexto6.Obligatorio = False
        Me.CuadroDeTexto6.ParametroID = 0
        Me.CuadroDeTexto6.Size = New System.Drawing.Size(87, 20)
        Me.CuadroDeTexto6.TabIndex = 11
        Me.CuadroDeTexto6.ValorMaximo = 0R
        Me.CuadroDeTexto6.ValorMinimo = 0R
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "HoraLlegada", True))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(111, 111)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker1.TabIndex = 9
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "HoraSalida", True))
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(111, 137)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePicker2.TabIndex = 13
        '
        'txtTotalBultos
        '
        Me.txtTotalBultos.EsUnicoCampo = ""
        Me.txtTotalBultos.EsUnicoCampoID = ""
        Me.txtTotalBultos.EsUnicoID = 0
        Me.txtTotalBultos.EsUnicoTabla = ""
        Me.txtTotalBultos.Location = New System.Drawing.Point(194, 641)
        Me.txtTotalBultos.Minimo = 0
        Me.txtTotalBultos.Modificado = False
        Me.txtTotalBultos.Name = "txtTotalBultos"
        Me.txtTotalBultos.Numerico_EsNumerico = True
        Me.txtTotalBultos.Numerico_NumeroDoublees = 0
        Me.txtTotalBultos.Numerico_SeparadorMiles = True
        Me.txtTotalBultos.Obligatorio = False
        Me.txtTotalBultos.ParametroID = 0
        Me.txtTotalBultos.Size = New System.Drawing.Size(68, 20)
        Me.txtTotalBultos.TabIndex = 1000000054
        Me.txtTotalBultos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBultos.ValorMaximo = 0R
        Me.txtTotalBultos.ValorMinimo = 0R
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(97, 639)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(95, 20)
        Me.Label6.TabIndex = 1000000051
        Me.Label6.Text = "Total bultos:"
        '
        'TabPagTotales
        '
        Me.TabPagTotales.Controls.Add(Me.SplitContainer1)
        Me.TabPagTotales.Location = New System.Drawing.Point(4, 22)
        Me.TabPagTotales.Name = "TabPagTotales"
        Me.TabPagTotales.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPagTotales.Size = New System.Drawing.Size(1203, 631)
        Me.TabPagTotales.TabIndex = 3
        Me.TabPagTotales.Text = "Totales"
        Me.TabPagTotales.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvTotales)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvTotalesPorPalet)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label22)
        Me.SplitContainer1.Size = New System.Drawing.Size(1197, 625)
        Me.SplitContainer1.SplitterDistance = 663
        Me.SplitContainer1.SplitterWidth = 11
        Me.SplitContainer1.TabIndex = 1000000050
        '
        'dgvTotales
        '
        Me.dgvTotales.AllowUserToAddRows = False
        Me.dgvTotales.AllowUserToDeleteRows = False
        Me.dgvTotales.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTotales.Location = New System.Drawing.Point(0, 24)
        Me.dgvTotales.Name = "dgvTotales"
        Me.dgvTotales.RowTemplate.Height = 24
        Me.dgvTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotales.Size = New System.Drawing.Size(663, 601)
        Me.dgvTotales.TabIndex = 1000000048
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(231, 24)
        Me.Label7.TabIndex = 1000000049
        Me.Label7.Text = "Totales por referencias."
        '
        'dgvTotalesPorPalet
        '
        Me.dgvTotalesPorPalet.AllowUserToAddRows = False
        Me.dgvTotalesPorPalet.AllowUserToDeleteRows = False
        Me.dgvTotalesPorPalet.BackgroundColor = System.Drawing.Color.White
        Me.dgvTotalesPorPalet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotalesPorPalet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTotalesPorPalet.Location = New System.Drawing.Point(0, 24)
        Me.dgvTotalesPorPalet.Name = "dgvTotalesPorPalet"
        Me.dgvTotalesPorPalet.RowTemplate.Height = 24
        Me.dgvTotalesPorPalet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotalesPorPalet.Size = New System.Drawing.Size(523, 601)
        Me.dgvTotalesPorPalet.TabIndex = 1000000050
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(0, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(166, 24)
        Me.Label22.TabIndex = 1000000051
        Me.Label22.Text = "Totales por palet"
        '
        'PrintForm1
        '
        Me.PrintForm1.DocumentName = "document"
        Me.PrintForm1.Form = Me
        Me.PrintForm1.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.PrintForm1.PrinterSettings = CType(resources.GetObject("PrintForm1.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm1.PrintFileName = Nothing
        '
        'PrintForm2
        '
        Me.PrintForm2.DocumentName = "document"
        Me.PrintForm2.Form = Me
        Me.PrintForm2.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.PrintForm2.PrinterSettings = CType(resources.GetObject("PrintForm2.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.PrintForm2.PrintFileName = Nothing
        '
        'frmEntAlbaranesCargaMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1211, 686)
        Me.Controls.Add(Me.tabDatos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEntAlbaranesCargaMaestro"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.tabDatos, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsAlbaranesCargaMaestro,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvPalet,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmPalets.ResumeLayout(false)
        Me.tabDatos.ResumeLayout(false)
        Me.tabPagDatos.ResumeLayout(false)
        Me.Panel4.ResumeLayout(false)
        Me.grbDatosTransporte.ResumeLayout(false)
        Me.grbDatosTransporte.PerformLayout
        Me.grbDatosCabecera.ResumeLayout(false)
        Me.grbDatosCabecera.PerformLayout
        Me.grbAlbaranesPendientes.ResumeLayout(false)
        CType(Me.dgvAlbaranesProvi,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel5.ResumeLayout(false)
        Me.Panel5.PerformLayout
        Me.tabPagPalets.ResumeLayout(false)
        Me.tabPagAcumulados.ResumeLayout(false)
        Me.tabPagAcumulados.PerformLayout
        CType(Me.dgvAcumulados,System.ComponentModel.ISupportInitialize).EndInit
        Me.cmAcumulados.ResumeLayout(false)
        Me.Panel1.ResumeLayout(false)
        Me.Panel2.ResumeLayout(false)
        Me.Panel2.PerformLayout
        CType(Me.dgvTotalPalets,System.ComponentModel.ISupportInitialize).EndInit
        Me.Panel3.ResumeLayout(false)
        Me.Panel3.PerformLayout
        Me.GroupBox2.ResumeLayout(false)
        Me.GroupBox1.ResumeLayout(false)
        Me.GroupBox1.PerformLayout
        Me.TabPagTotales.ResumeLayout(false)
        Me.SplitContainer1.Panel1.ResumeLayout(false)
        Me.SplitContainer1.Panel1.PerformLayout
        Me.SplitContainer1.Panel2.ResumeLayout(false)
        Me.SplitContainer1.Panel2.PerformLayout
        CType(Me.SplitContainer1,System.ComponentModel.ISupportInitialize).EndInit
        Me.SplitContainer1.ResumeLayout(false)
        CType(Me.dgvTotales,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.dgvTotalesPorPalet,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Private WithEvents DtsAlbaranesCargaMaestro As La_Andaluza.dtsAlbaranesCargaMaestro
    Private WithEvents tabPagDatos As System.Windows.Forms.TabPage
    Private WithEvents tabPagPalets As System.Windows.Forms.TabPage
    Private WithEvents dgvAlbaranesProvi As System.Windows.Forms.DataGridView
    Private WithEvents TabPagTotales As System.Windows.Forms.TabPage
    Private WithEvents butAlbaranQS As System.Windows.Forms.Button
    Private WithEvents butEntradaJR As System.Windows.Forms.Button
    Private WithEvents butJRaMercadona As System.Windows.Forms.Button
    Private WithEvents butCartaPortes As System.Windows.Forms.Button
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents butMercadonaCanarias As System.Windows.Forms.Button
    Private WithEvents tabDatos As System.Windows.Forms.TabControl
    Private WithEvents tabPagAcumulados As System.Windows.Forms.TabPage
    Private WithEvents dgvAcumulados As System.Windows.Forms.DataGridView
    Private WithEvents dgvTotalPalets As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtTotalBultos As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPesoNeto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPesoBruto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents txtCabeza As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto2 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtConductor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto4 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDNI As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto6 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Private WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRemolque1 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butLAaJR As System.Windows.Forms.Button
    Private WithEvents butAlbaranProvisional As System.Windows.Forms.Button
    Private WithEvents ButEmbotelladoPedido As System.Windows.Forms.Button
    Private WithEvents butRegistrarPortesSalidaQS As System.Windows.Forms.Button
    Private WithEvents txtAlbaranCargaMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents SerieQSIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents NumeroQSCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents AlmacenSalidaQSIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents PorteImporteCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents ConductorDNICuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents HoraLlegadaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents HoraSalidaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dgvPalet As System.Windows.Forms.DataGridView
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents dgvTotales As System.Windows.Forms.DataGridView
    Private WithEvents grbDatosTransporte As System.Windows.Forms.GroupBox
    Private WithEvents grbAlbaranesPendientes As System.Windows.Forms.GroupBox
    Private WithEvents grbDatosCabecera As System.Windows.Forms.GroupBox
    Private WithEvents cboConductores As System.Windows.Forms.ComboBox
    Private WithEvents cboClientes As System.Windows.Forms.ComboBox
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents dgvTotalesPorPalet As System.Windows.Forms.DataGridView
    Private WithEvents Label22 As System.Windows.Forms.Label
    Private WithEvents PrintForm1 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Private WithEvents PrintForm2 As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm
    Private WithEvents cmPalets As System.Windows.Forms.ContextMenuStrip
    Private WithEvents MarcarComoMultiloteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents MarcarComoNoMultiloteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents CambiarLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents cmAcumulados As System.Windows.Forms.ContextMenuStrip
    Private WithEvents CambiarLoteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ReiniciarLoteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ReiniciarLoteToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    ' Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents EliminarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    'Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents btnCartaJr As System.Windows.Forms.Button
    Private WithEvents cboREsponsableAdminsitracion As System.Windows.Forms.ComboBox
    Private WithEvents cboREsponsableCarga As System.Windows.Forms.ComboBox
    Private WithEvents Label24 As System.Windows.Forms.Label
    Private WithEvents Label23 As System.Windows.Forms.Label
    Private WithEvents cboLugaresEntrega As System.Windows.Forms.ComboBox
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents cboFormaPAgo As System.Windows.Forms.ComboBox
    Private WithEvents cboCabeza As System.Windows.Forms.ComboBox
    Private WithEvents txtDetalleRemolque As System.Windows.Forms.TextBox
    Private WithEvents btnNuevoCamion As System.Windows.Forms.Button
    Private WithEvents cboAgencia As System.Windows.Forms.ComboBox
    Private WithEvents cboPedido As System.Windows.Forms.ComboBox
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    ' Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    'Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    ' Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator

End Class
