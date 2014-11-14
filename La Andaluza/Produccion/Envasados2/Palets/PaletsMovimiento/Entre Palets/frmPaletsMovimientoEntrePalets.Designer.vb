<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaletsMovimientoEntrePalets
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gpbOrigen = New System.Windows.Forms.GroupBox()
        Me.panOrigen = New System.Windows.Forms.Panel()
        Me.gpbDestino = New System.Windows.Forms.GroupBox()
        Me.panDestino = New System.Windows.Forms.Panel()
        Me.gpbDatos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMovimientoSubTipo = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDocumento = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butAddMovimientoTipo = New System.Windows.Forms.Button()
        Me.cboMovimientoTipo = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblObsPaletDestino = New System.Windows.Forms.Label()
        Me.txtObsPaletDestino = New System.Windows.Forms.TextBox()
        Me.lblObsPaletOrigen = New System.Windows.Forms.Label()
        Me.txtObsPaletOrigen = New System.Windows.Forms.TextBox()
        Me.lblObsMovimiento = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtObsMovimiento = New System.Windows.Forms.TextBox()
        Me.lblAutorizadoPor = New System.Windows.Forms.Label()
        Me.lblReceptor = New System.Windows.Forms.Label()
        Me.lblMotivo = New System.Windows.Forms.Label()
        Me.lblSolicitante = New System.Windows.Forms.Label()
        Me.lblCliente = New System.Windows.Forms.Label()
        Me.lblInicial = New System.Windows.Forms.Label()
        Me.lblFinal = New System.Windows.Forms.Label()
        Me.gpbObservaciones = New System.Windows.Forms.GroupBox()
        Me.gpbDatosAdicionales = New System.Windows.Forms.GroupBox()
        Me.txtReceptor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtSolicitante = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtInicial = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFinal = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAutorizadoPor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCliente = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtMotivo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.gpbOrigen.SuspendLayout()
        Me.gpbDestino.SuspendLayout()
        Me.gpbDatos.SuspendLayout()
        Me.gpbObservaciones.SuspendLayout()
        Me.gpbDatosAdicionales.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gpbOrigen
        '
        Me.gpbOrigen.Controls.Add(Me.panOrigen)
        Me.gpbOrigen.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbOrigen.Location = New System.Drawing.Point(0, 0)
        Me.gpbOrigen.Name = "gpbOrigen"
        Me.gpbOrigen.Size = New System.Drawing.Size(1009, 269)
        Me.gpbOrigen.TabIndex = 0
        Me.gpbOrigen.TabStop = False
        Me.gpbOrigen.Text = "Palet origen"
        '
        'panOrigen
        '
        Me.panOrigen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panOrigen.Location = New System.Drawing.Point(3, 16)
        Me.panOrigen.Name = "panOrigen"
        Me.panOrigen.Size = New System.Drawing.Size(1003, 250)
        Me.panOrigen.TabIndex = 0
        '
        'gpbDestino
        '
        Me.gpbDestino.Controls.Add(Me.panDestino)
        Me.gpbDestino.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbDestino.Location = New System.Drawing.Point(0, 619)
        Me.gpbDestino.Name = "gpbDestino"
        Me.gpbDestino.Size = New System.Drawing.Size(1009, 303)
        Me.gpbDestino.TabIndex = 4
        Me.gpbDestino.TabStop = False
        Me.gpbDestino.Text = "Palet destino"
        Me.gpbDestino.Visible = False
        '
        'panDestino
        '
        Me.panDestino.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panDestino.Location = New System.Drawing.Point(3, 16)
        Me.panDestino.Name = "panDestino"
        Me.panDestino.Size = New System.Drawing.Size(1003, 284)
        Me.panDestino.TabIndex = 0
        '
        'gpbDatos
        '
        Me.gpbDatos.Controls.Add(Me.DateTimePicker1)
        Me.gpbDatos.Controls.Add(Me.Label5)
        Me.gpbDatos.Controls.Add(Me.cboMovimientoSubTipo)
        Me.gpbDatos.Controls.Add(Me.Label7)
        Me.gpbDatos.Controls.Add(Me.txtCajas)
        Me.gpbDatos.Controls.Add(Me.txtDocumento)
        Me.gpbDatos.Controls.Add(Me.butAddMovimientoTipo)
        Me.gpbDatos.Controls.Add(Me.cboMovimientoTipo)
        Me.gpbDatos.Controls.Add(Me.Label6)
        Me.gpbDatos.Controls.Add(Me.Label3)
        Me.gpbDatos.Controls.Add(Me.dtpFecha)
        Me.gpbDatos.Controls.Add(Me.Label2)
        Me.gpbDatos.Controls.Add(Me.Label1)
        Me.gpbDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbDatos.Location = New System.Drawing.Point(0, 0)
        Me.gpbDatos.Name = "gpbDatos"
        Me.gpbDatos.Size = New System.Drawing.Size(1009, 228)
        Me.gpbDatos.TabIndex = 1
        Me.gpbDatos.TabStop = False
        Me.gpbDatos.Text = "Datos del movimiento"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Subtipo"
        '
        'cboMovimientoSubTipo
        '
        Me.cboMovimientoSubTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMovimientoSubTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMovimientoSubTipo.BackColor = System.Drawing.SystemColors.Window
        Me.cboMovimientoSubTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMovimientoSubTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMovimientoSubTipo.Location = New System.Drawing.Point(70, 52)
        Me.cboMovimientoSubTipo.Name = "cboMovimientoSubTipo"
        Me.cboMovimientoSubTipo.Size = New System.Drawing.Size(277, 23)
        Me.cboMovimientoSubTipo.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(48, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(285, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "En diferencia recuento, cantidad en negativa sumara cajas"
        '
        'txtCajas
        '
        Me.txtCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajas.EsUnicoCampo = ""
        Me.txtCajas.EsUnicoCampoID = ""
        Me.txtCajas.EsUnicoID = 0
        Me.txtCajas.EsUnicoTabla = ""
        Me.txtCajas.Location = New System.Drawing.Point(70, 107)
        Me.txtCajas.Minimo = 0
        Me.txtCajas.Modificado = False
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Numerico_EsNumerico = True
        Me.txtCajas.Numerico_NumeroDoublees = 0
        Me.txtCajas.Numerico_SeparadorMiles = False
        Me.txtCajas.Obligatorio = False
        Me.txtCajas.ParametroID = 0
        Me.txtCajas.Size = New System.Drawing.Size(42, 20)
        Me.txtCajas.TabIndex = 8
        Me.txtCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajas.ValorMaximo = 0.0R
        Me.txtCajas.ValorMinimo = 0.0R
        '
        'txtDocumento
        '
        Me.txtDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDocumento.EsUnicoCampo = ""
        Me.txtDocumento.EsUnicoCampoID = ""
        Me.txtDocumento.EsUnicoID = 0
        Me.txtDocumento.EsUnicoTabla = ""
        Me.txtDocumento.Location = New System.Drawing.Point(70, 133)
        Me.txtDocumento.Minimo = 0
        Me.txtDocumento.Modificado = False
        Me.txtDocumento.Name = "txtDocumento"
        Me.txtDocumento.Numerico_EsNumerico = True
        Me.txtDocumento.Numerico_NumeroDoublees = 0
        Me.txtDocumento.Numerico_SeparadorMiles = False
        Me.txtDocumento.Obligatorio = False
        Me.txtDocumento.ParametroID = 0
        Me.txtDocumento.Size = New System.Drawing.Size(90, 20)
        Me.txtDocumento.TabIndex = 10
        Me.txtDocumento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDocumento.ValorMaximo = 0.0R
        Me.txtDocumento.ValorMinimo = 0.0R
        '
        'butAddMovimientoTipo
        '
        Me.butAddMovimientoTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddMovimientoTipo.FlatAppearance.BorderSize = 0
        Me.butAddMovimientoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMovimientoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMovimientoTipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMovimientoTipo.Location = New System.Drawing.Point(350, 29)
        Me.butAddMovimientoTipo.Name = "butAddMovimientoTipo"
        Me.butAddMovimientoTipo.Size = New System.Drawing.Size(20, 20)
        Me.butAddMovimientoTipo.TabIndex = 2
        Me.butAddMovimientoTipo.TabStop = False
        '
        'cboMovimientoTipo
        '
        Me.cboMovimientoTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMovimientoTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMovimientoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMovimientoTipo.FormattingEnabled = True
        Me.cboMovimientoTipo.Location = New System.Drawing.Point(70, 29)
        Me.cboMovimientoTipo.Name = "cboMovimientoTipo"
        Me.cboMovimientoTipo.Size = New System.Drawing.Size(277, 21)
        Me.cboMovimientoTipo.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Documento"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(70, 81)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(91, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Cajas"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo"
        '
        'lblObsPaletDestino
        '
        Me.lblObsPaletDestino.AutoSize = True
        Me.lblObsPaletDestino.Location = New System.Drawing.Point(19, 72)
        Me.lblObsPaletDestino.Name = "lblObsPaletDestino"
        Me.lblObsPaletDestino.Size = New System.Drawing.Size(68, 13)
        Me.lblObsPaletDestino.TabIndex = 4
        Me.lblObsPaletDestino.Text = "Palet destino"
        Me.lblObsPaletDestino.Visible = False
        '
        'txtObsPaletDestino
        '
        Me.txtObsPaletDestino.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObsPaletDestino.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsPaletDestino.Location = New System.Drawing.Point(103, 69)
        Me.txtObsPaletDestino.Name = "txtObsPaletDestino"
        Me.txtObsPaletDestino.Size = New System.Drawing.Size(886, 20)
        Me.txtObsPaletDestino.TabIndex = 5
        Me.txtObsPaletDestino.Visible = False
        '
        'lblObsPaletOrigen
        '
        Me.lblObsPaletOrigen.AutoSize = True
        Me.lblObsPaletOrigen.Location = New System.Drawing.Point(19, 48)
        Me.lblObsPaletOrigen.Name = "lblObsPaletOrigen"
        Me.lblObsPaletOrigen.Size = New System.Drawing.Size(63, 13)
        Me.lblObsPaletOrigen.TabIndex = 2
        Me.lblObsPaletOrigen.Text = "Palet origen"
        '
        'txtObsPaletOrigen
        '
        Me.txtObsPaletOrigen.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObsPaletOrigen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsPaletOrigen.Location = New System.Drawing.Point(103, 45)
        Me.txtObsPaletOrigen.Name = "txtObsPaletOrigen"
        Me.txtObsPaletOrigen.Size = New System.Drawing.Size(886, 20)
        Me.txtObsPaletOrigen.TabIndex = 3
        '
        'lblObsMovimiento
        '
        Me.lblObsMovimiento.AutoSize = True
        Me.lblObsMovimiento.Location = New System.Drawing.Point(19, 22)
        Me.lblObsMovimiento.Name = "lblObsMovimiento"
        Me.lblObsMovimiento.Size = New System.Drawing.Size(61, 13)
        Me.lblObsMovimiento.TabIndex = 0
        Me.lblObsMovimiento.Text = "Movimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(100, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(703, 16)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Si se quiere marcar el palets para que no se cargue, empezar las Observaciones co" & _
    "n ""NO CARGAR"""
        '
        'txtObsMovimiento
        '
        Me.txtObsMovimiento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObsMovimiento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObsMovimiento.Location = New System.Drawing.Point(103, 19)
        Me.txtObsMovimiento.Name = "txtObsMovimiento"
        Me.txtObsMovimiento.Size = New System.Drawing.Size(886, 20)
        Me.txtObsMovimiento.TabIndex = 1
        '
        'lblAutorizadoPor
        '
        Me.lblAutorizadoPor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAutorizadoPor.Location = New System.Drawing.Point(20, 125)
        Me.lblAutorizadoPor.Name = "lblAutorizadoPor"
        Me.lblAutorizadoPor.Size = New System.Drawing.Size(78, 21)
        Me.lblAutorizadoPor.TabIndex = 8
        Me.lblAutorizadoPor.Text = "Autorizado por"
        Me.lblAutorizadoPor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblAutorizadoPor.Visible = False
        '
        'lblReceptor
        '
        Me.lblReceptor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblReceptor.Location = New System.Drawing.Point(20, 46)
        Me.lblReceptor.Name = "lblReceptor"
        Me.lblReceptor.Size = New System.Drawing.Size(56, 21)
        Me.lblReceptor.TabIndex = 0
        Me.lblReceptor.Text = "Receptor"
        Me.lblReceptor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblReceptor.Visible = False
        '
        'lblMotivo
        '
        Me.lblMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblMotivo.Location = New System.Drawing.Point(20, 150)
        Me.lblMotivo.Name = "lblMotivo"
        Me.lblMotivo.Size = New System.Drawing.Size(50, 21)
        Me.lblMotivo.TabIndex = 10
        Me.lblMotivo.Text = "Motivo"
        Me.lblMotivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMotivo.Visible = False
        '
        'lblSolicitante
        '
        Me.lblSolicitante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSolicitante.Location = New System.Drawing.Point(20, 72)
        Me.lblSolicitante.Name = "lblSolicitante"
        Me.lblSolicitante.Size = New System.Drawing.Size(62, 21)
        Me.lblSolicitante.TabIndex = 2
        Me.lblSolicitante.Text = "Solicitante"
        Me.lblSolicitante.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblSolicitante.Visible = False
        '
        'lblCliente
        '
        Me.lblCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCliente.Location = New System.Drawing.Point(20, 171)
        Me.lblCliente.Name = "lblCliente"
        Me.lblCliente.Size = New System.Drawing.Size(50, 21)
        Me.lblCliente.TabIndex = 12
        Me.lblCliente.Text = "Cliente"
        Me.lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCliente.Visible = False
        '
        'lblInicial
        '
        Me.lblInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblInicial.Location = New System.Drawing.Point(20, 98)
        Me.lblInicial.Name = "lblInicial"
        Me.lblInicial.Size = New System.Drawing.Size(53, 21)
        Me.lblInicial.TabIndex = 4
        Me.lblInicial.Text = "Inicial"
        Me.lblInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblInicial.Visible = False
        '
        'lblFinal
        '
        Me.lblFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFinal.Location = New System.Drawing.Point(260, 97)
        Me.lblFinal.Name = "lblFinal"
        Me.lblFinal.Size = New System.Drawing.Size(37, 21)
        Me.lblFinal.TabIndex = 6
        Me.lblFinal.Text = "Final"
        Me.lblFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFinal.Visible = False
        '
        'gpbObservaciones
        '
        Me.gpbObservaciones.Controls.Add(Me.lblObsMovimiento)
        Me.gpbObservaciones.Controls.Add(Me.txtObsMovimiento)
        Me.gpbObservaciones.Controls.Add(Me.lblObsPaletDestino)
        Me.gpbObservaciones.Controls.Add(Me.Label4)
        Me.gpbObservaciones.Controls.Add(Me.txtObsPaletDestino)
        Me.gpbObservaciones.Controls.Add(Me.txtObsPaletOrigen)
        Me.gpbObservaciones.Controls.Add(Me.lblObsPaletOrigen)
        Me.gpbObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpbObservaciones.Location = New System.Drawing.Point(0, 497)
        Me.gpbObservaciones.Name = "gpbObservaciones"
        Me.gpbObservaciones.Size = New System.Drawing.Size(1009, 122)
        Me.gpbObservaciones.TabIndex = 3
        Me.gpbObservaciones.TabStop = False
        Me.gpbObservaciones.Text = "Observaciones"
        '
        'gpbDatosAdicionales
        '
        Me.gpbDatosAdicionales.Controls.Add(Me.lblReceptor)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtReceptor)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblSolicitante)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtSolicitante)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblInicial)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtInicial)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblFinal)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblCliente)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblMotivo)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtFinal)
        Me.gpbDatosAdicionales.Controls.Add(Me.lblAutorizadoPor)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtAutorizadoPor)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtCliente)
        Me.gpbDatosAdicionales.Controls.Add(Me.txtMotivo)
        Me.gpbDatosAdicionales.Dock = System.Windows.Forms.DockStyle.Right
        Me.gpbDatosAdicionales.Location = New System.Drawing.Point(551, 0)
        Me.gpbDatosAdicionales.Name = "gpbDatosAdicionales"
        Me.gpbDatosAdicionales.Size = New System.Drawing.Size(458, 228)
        Me.gpbDatosAdicionales.TabIndex = 2
        Me.gpbDatosAdicionales.TabStop = False
        Me.gpbDatosAdicionales.Text = "Datos adicionales"
        '
        'txtReceptor
        '
        Me.txtReceptor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceptor.EsUnicoCampo = ""
        Me.txtReceptor.EsUnicoCampoID = ""
        Me.txtReceptor.EsUnicoID = 0
        Me.txtReceptor.EsUnicoTabla = ""
        Me.txtReceptor.Location = New System.Drawing.Point(104, 47)
        Me.txtReceptor.Minimo = 0
        Me.txtReceptor.Modificado = False
        Me.txtReceptor.Name = "txtReceptor"
        Me.txtReceptor.Numerico_EsNumerico = False
        Me.txtReceptor.Numerico_NumeroDoublees = 0
        Me.txtReceptor.Numerico_SeparadorMiles = False
        Me.txtReceptor.Obligatorio = False
        Me.txtReceptor.ParametroID = 0
        Me.txtReceptor.Size = New System.Drawing.Size(334, 20)
        Me.txtReceptor.TabIndex = 1
        Me.txtReceptor.ValorMaximo = 0.0R
        Me.txtReceptor.ValorMinimo = 0.0R
        Me.txtReceptor.Visible = False
        '
        'txtSolicitante
        '
        Me.txtSolicitante.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtSolicitante.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSolicitante.EsUnicoCampo = ""
        Me.txtSolicitante.EsUnicoCampoID = ""
        Me.txtSolicitante.EsUnicoID = 0
        Me.txtSolicitante.EsUnicoTabla = ""
        Me.txtSolicitante.Location = New System.Drawing.Point(104, 73)
        Me.txtSolicitante.Minimo = 0
        Me.txtSolicitante.Modificado = False
        Me.txtSolicitante.Name = "txtSolicitante"
        Me.txtSolicitante.Numerico_EsNumerico = False
        Me.txtSolicitante.Numerico_NumeroDoublees = 0
        Me.txtSolicitante.Numerico_SeparadorMiles = False
        Me.txtSolicitante.Obligatorio = False
        Me.txtSolicitante.ParametroID = 0
        Me.txtSolicitante.Size = New System.Drawing.Size(334, 20)
        Me.txtSolicitante.TabIndex = 3
        Me.txtSolicitante.ValorMaximo = 0.0R
        Me.txtSolicitante.ValorMinimo = 0.0R
        Me.txtSolicitante.Visible = False
        '
        'txtInicial
        '
        Me.txtInicial.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtInicial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInicial.EsUnicoCampo = ""
        Me.txtInicial.EsUnicoCampoID = ""
        Me.txtInicial.EsUnicoID = 0
        Me.txtInicial.EsUnicoTabla = ""
        Me.txtInicial.Location = New System.Drawing.Point(104, 99)
        Me.txtInicial.Minimo = 0
        Me.txtInicial.Modificado = False
        Me.txtInicial.Name = "txtInicial"
        Me.txtInicial.Numerico_EsNumerico = False
        Me.txtInicial.Numerico_NumeroDoublees = 0
        Me.txtInicial.Numerico_SeparadorMiles = False
        Me.txtInicial.Obligatorio = False
        Me.txtInicial.ParametroID = 0
        Me.txtInicial.Size = New System.Drawing.Size(150, 20)
        Me.txtInicial.TabIndex = 5
        Me.txtInicial.ValorMaximo = 0.0R
        Me.txtInicial.ValorMinimo = 0.0R
        Me.txtInicial.Visible = False
        '
        'txtFinal
        '
        Me.txtFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFinal.EsUnicoCampo = ""
        Me.txtFinal.EsUnicoCampoID = ""
        Me.txtFinal.EsUnicoID = 0
        Me.txtFinal.EsUnicoTabla = ""
        Me.txtFinal.Location = New System.Drawing.Point(303, 98)
        Me.txtFinal.Minimo = 0
        Me.txtFinal.Modificado = False
        Me.txtFinal.Name = "txtFinal"
        Me.txtFinal.Numerico_EsNumerico = False
        Me.txtFinal.Numerico_NumeroDoublees = 0
        Me.txtFinal.Numerico_SeparadorMiles = False
        Me.txtFinal.Obligatorio = False
        Me.txtFinal.ParametroID = 0
        Me.txtFinal.Size = New System.Drawing.Size(136, 20)
        Me.txtFinal.TabIndex = 7
        Me.txtFinal.ValorMaximo = 0.0R
        Me.txtFinal.ValorMinimo = 0.0R
        Me.txtFinal.Visible = False
        '
        'txtAutorizadoPor
        '
        Me.txtAutorizadoPor.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtAutorizadoPor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutorizadoPor.EsUnicoCampo = ""
        Me.txtAutorizadoPor.EsUnicoCampoID = ""
        Me.txtAutorizadoPor.EsUnicoID = 0
        Me.txtAutorizadoPor.EsUnicoTabla = ""
        Me.txtAutorizadoPor.Location = New System.Drawing.Point(104, 126)
        Me.txtAutorizadoPor.Minimo = 0
        Me.txtAutorizadoPor.Modificado = False
        Me.txtAutorizadoPor.Name = "txtAutorizadoPor"
        Me.txtAutorizadoPor.Numerico_EsNumerico = False
        Me.txtAutorizadoPor.Numerico_NumeroDoublees = 0
        Me.txtAutorizadoPor.Numerico_SeparadorMiles = False
        Me.txtAutorizadoPor.Obligatorio = False
        Me.txtAutorizadoPor.ParametroID = 0
        Me.txtAutorizadoPor.Size = New System.Drawing.Size(334, 20)
        Me.txtAutorizadoPor.TabIndex = 9
        Me.txtAutorizadoPor.ValorMaximo = 0.0R
        Me.txtAutorizadoPor.ValorMinimo = 0.0R
        Me.txtAutorizadoPor.Visible = False
        '
        'txtCliente
        '
        Me.txtCliente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCliente.EsUnicoCampo = ""
        Me.txtCliente.EsUnicoCampoID = ""
        Me.txtCliente.EsUnicoID = 0
        Me.txtCliente.EsUnicoTabla = ""
        Me.txtCliente.Location = New System.Drawing.Point(104, 173)
        Me.txtCliente.Minimo = 0
        Me.txtCliente.Modificado = False
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Numerico_EsNumerico = False
        Me.txtCliente.Numerico_NumeroDoublees = 0
        Me.txtCliente.Numerico_SeparadorMiles = False
        Me.txtCliente.Obligatorio = False
        Me.txtCliente.ParametroID = 0
        Me.txtCliente.Size = New System.Drawing.Size(334, 20)
        Me.txtCliente.TabIndex = 13
        Me.txtCliente.ValorMaximo = 0.0R
        Me.txtCliente.ValorMinimo = 0.0R
        Me.txtCliente.Visible = False
        '
        'txtMotivo
        '
        Me.txtMotivo.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtMotivo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMotivo.EsUnicoCampo = ""
        Me.txtMotivo.EsUnicoCampoID = ""
        Me.txtMotivo.EsUnicoID = 0
        Me.txtMotivo.EsUnicoTabla = ""
        Me.txtMotivo.Location = New System.Drawing.Point(104, 152)
        Me.txtMotivo.Minimo = 0
        Me.txtMotivo.Modificado = False
        Me.txtMotivo.Name = "txtMotivo"
        Me.txtMotivo.Numerico_EsNumerico = False
        Me.txtMotivo.Numerico_NumeroDoublees = 0
        Me.txtMotivo.Numerico_SeparadorMiles = False
        Me.txtMotivo.Obligatorio = False
        Me.txtMotivo.ParametroID = 0
        Me.txtMotivo.Size = New System.Drawing.Size(334, 20)
        Me.txtMotivo.TabIndex = 11
        Me.txtMotivo.ValorMaximo = 0.0R
        Me.txtMotivo.ValorMinimo = 0.0R
        Me.txtMotivo.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gpbDatosAdicionales)
        Me.Panel1.Controls.Add(Me.gpbDatos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 269)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1009, 228)
        Me.Panel1.TabIndex = 5
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "HH:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(167, 81)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(67, 20)
        Me.DateTimePicker1.TabIndex = 11
        '
        'frmPaletsMovimientoEntrePalets
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1009, 813)
        Me.Controls.Add(Me.gpbDestino)
        Me.Controls.Add(Me.gpbObservaciones)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.gpbOrigen)
        Me.MinimizeBox = False
        Me.Name = "frmPaletsMovimientoEntrePalets"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmPaletsMovimientoEntrePalets"
        Me.gpbOrigen.ResumeLayout(False)
        Me.gpbDestino.ResumeLayout(False)
        Me.gpbDatos.ResumeLayout(False)
        Me.gpbDatos.PerformLayout()
        Me.gpbObservaciones.ResumeLayout(False)
        Me.gpbObservaciones.PerformLayout()
        Me.gpbDatosAdicionales.ResumeLayout(False)
        Me.gpbDatosAdicionales.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gpbOrigen As System.Windows.Forms.GroupBox
    Private WithEvents gpbDestino As System.Windows.Forms.GroupBox
    Private WithEvents gpbDatos As System.Windows.Forms.GroupBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents panOrigen As System.Windows.Forms.Panel
    Private WithEvents panDestino As System.Windows.Forms.Panel
    Private WithEvents txtObsMovimiento As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents cboMovimientoTipo As System.Windows.Forms.ComboBox
    Private WithEvents butAddMovimientoTipo As System.Windows.Forms.Button
    Private WithEvents txtDocumento As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents lblObsPaletDestino As System.Windows.Forms.Label
    Private WithEvents txtObsPaletDestino As System.Windows.Forms.TextBox
    Private WithEvents lblObsPaletOrigen As System.Windows.Forms.Label
    Private WithEvents txtObsPaletOrigen As System.Windows.Forms.TextBox
    Private WithEvents lblObsMovimiento As System.Windows.Forms.Label
    Private WithEvents cboMovimientoSubTipo As System.Windows.Forms.ComboBox
    Private WithEvents lblAutorizadoPor As System.Windows.Forms.Label
    Private WithEvents lblReceptor As System.Windows.Forms.Label
    Private WithEvents lblMotivo As System.Windows.Forms.Label
    Private WithEvents lblSolicitante As System.Windows.Forms.Label
    Private WithEvents lblCliente As System.Windows.Forms.Label
    Private WithEvents lblInicial As System.Windows.Forms.Label
    Private WithEvents lblFinal As System.Windows.Forms.Label
    Private WithEvents txtAutorizadoPor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtMotivo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCliente As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFinal As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtReceptor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSolicitante As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtInicial As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents gpbObservaciones As System.Windows.Forms.GroupBox
    Private WithEvents gpbDatosAdicionales As System.Windows.Forms.GroupBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
End Class
