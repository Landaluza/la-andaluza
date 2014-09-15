<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLisEnvPorReferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLisEnvPorReferencia))
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.dgvEnvasados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnPorDias = New System.Windows.Forms.Button()
        Me.btnPorSCC = New System.Windows.Forms.Button()
        Me.btnNoSCC = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtSCC = New System.Windows.Forms.TextBox()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.lblTotalCajas = New System.Windows.Forms.Label()
        Me.lblBotellas = New System.Windows.Forms.Label()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtTotalEnvasados = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtVelocidadMedia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalMinutos = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalBotellas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalLitros = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAgrupados = New System.Windows.Forms.Button()
        Me.cboReferencia = New System.Windows.Forms.ComboBox()
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(52, 36)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(87, 20)
        Me.dtpDesde.TabIndex = 1
        Me.dtpDesde.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(181, 36)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(93, 20)
        Me.dtpHasta.TabIndex = 2
        '
        'dgvEnvasados
        '
        Me.dgvEnvasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnvasados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnvasados.Location = New System.Drawing.Point(0, 89)
        Me.dgvEnvasados.Name = "dgvEnvasados"
        Me.dgvEnvasados.RowTemplate.Height = 24
        Me.dgvEnvasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnvasados.Size = New System.Drawing.Size(453, 564)
        Me.dgvEnvasados.TabIndex = 3
        Me.dgvEnvasados.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Desde:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Hasta:"
        '
        'btnPorDias
        '
        Me.btnPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorDias.Image = CType(resources.GetObject("btnPorDias.Image"), System.Drawing.Image)
        Me.btnPorDias.Location = New System.Drawing.Point(14, 62)
        Me.btnPorDias.Name = "btnPorDias"
        Me.btnPorDias.Size = New System.Drawing.Size(81, 24)
        Me.btnPorDias.TabIndex = 8
        Me.btnPorDias.Text = "Por &dias"
        Me.btnPorDias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPorDias.UseVisualStyleBackColor = True
        '
        'btnPorSCC
        '
        Me.btnPorSCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorSCC.Image = CType(resources.GetObject("btnPorSCC.Image"), System.Drawing.Image)
        Me.btnPorSCC.Location = New System.Drawing.Point(101, 62)
        Me.btnPorSCC.Name = "btnPorSCC"
        Me.btnPorSCC.Size = New System.Drawing.Size(81, 24)
        Me.btnPorSCC.TabIndex = 9
        Me.btnPorSCC.Text = "Por &SCC"
        Me.btnPorSCC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPorSCC.UseVisualStyleBackColor = True
        '
        'btnNoSCC
        '
        Me.btnNoSCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoSCC.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnNoSCC.Location = New System.Drawing.Point(64, 20)
        Me.btnNoSCC.Name = "btnNoSCC"
        Me.btnNoSCC.Size = New System.Drawing.Size(66, 23)
        Me.btnNoSCC.TabIndex = 11
        Me.btnNoSCC.Text = "&Buscar"
        Me.btnNoSCC.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnNoSCC.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtSCC)
        Me.GroupBox1.Controls.Add(Me.btnNoSCC)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(137, 54)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Buscar palet por SCC"
        '
        'txtSCC
        '
        Me.txtSCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCC.Location = New System.Drawing.Point(6, 22)
        Me.txtSCC.Name = "txtSCC"
        Me.txtSCC.Size = New System.Drawing.Size(52, 20)
        Me.txtSCC.TabIndex = 12
        '
        'btnExcel
        '
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = Global.La_Andaluza.My.Resources.Resources.page_excel_16
        Me.btnExcel.Location = New System.Drawing.Point(401, 10)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(19, 20)
        Me.btnExcel.TabIndex = 14
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'lblTotalCajas
        '
        Me.lblTotalCajas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalCajas.AutoSize = True
        Me.lblTotalCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCajas.Location = New System.Drawing.Point(157, 0)
        Me.lblTotalCajas.Name = "lblTotalCajas"
        Me.lblTotalCajas.Size = New System.Drawing.Size(38, 13)
        Me.lblTotalCajas.TabIndex = 18
        Me.lblTotalCajas.Text = "Cajas"
        '
        'lblBotellas
        '
        Me.lblBotellas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblBotellas.AutoSize = True
        Me.lblBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotellas.Location = New System.Drawing.Point(207, 0)
        Me.lblBotellas.Name = "lblBotellas"
        Me.lblBotellas.Size = New System.Drawing.Size(52, 13)
        Me.lblBotellas.TabIndex = 19
        Me.lblBotellas.Text = "Botellas"
        '
        'lblLitros
        '
        Me.lblLitros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(270, 0)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(38, 13)
        Me.lblLitros.TabIndex = 20
        Me.lblLitros.Text = "Litros"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(7, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(67, 15)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "TOTALES"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(323, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Velocidad"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(97, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Minutos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTotalEnvasados)
        Me.Panel1.Controls.Add(Me.txtVelocidadMedia)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.txtTotalCajas)
        Me.Panel1.Controls.Add(Me.txtTotalMinutos)
        Me.Panel1.Controls.Add(Me.txtTotalBotellas)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.txtTotalLitros)
        Me.Panel1.Controls.Add(Me.lblTotalCajas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.lblBotellas)
        Me.Panel1.Controls.Add(Me.lblLitros)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 653)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(453, 41)
        Me.Panel1.TabIndex = 26
        '
        'txtTotalEnvasados
        '
        Me.txtTotalEnvasados.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalEnvasados.EsUnicoCampo = ""
        Me.txtTotalEnvasados.EsUnicoCampoID = ""
        Me.txtTotalEnvasados.EsUnicoID = 0
        Me.txtTotalEnvasados.EsUnicoTabla = ""
        Me.txtTotalEnvasados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalEnvasados.Location = New System.Drawing.Point(14, 3)
        Me.txtTotalEnvasados.MaxLength = 30
        Me.txtTotalEnvasados.Minimo = 0
        Me.txtTotalEnvasados.Modificado = False
        Me.txtTotalEnvasados.Name = "txtTotalEnvasados"
        Me.txtTotalEnvasados.Numerico_EsNumerico = True
        Me.txtTotalEnvasados.Numerico_NumeroDoublees = 0
        Me.txtTotalEnvasados.Numerico_SeparadorMiles = True
        Me.txtTotalEnvasados.Obligatorio = False
        Me.txtTotalEnvasados.ParametroID = 0
        Me.txtTotalEnvasados.Size = New System.Drawing.Size(57, 22)
        Me.txtTotalEnvasados.TabIndex = 26
        Me.txtTotalEnvasados.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalEnvasados.ValorMaximo = 0.0R
        Me.txtTotalEnvasados.ValorMinimo = 0.0R
        '
        'txtVelocidadMedia
        '
        Me.txtVelocidadMedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtVelocidadMedia.EsUnicoCampo = ""
        Me.txtVelocidadMedia.EsUnicoCampoID = ""
        Me.txtVelocidadMedia.EsUnicoID = 0
        Me.txtVelocidadMedia.EsUnicoTabla = ""
        Me.txtVelocidadMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidadMedia.Location = New System.Drawing.Point(317, 16)
        Me.txtVelocidadMedia.MaxLength = 30
        Me.txtVelocidadMedia.Minimo = 0
        Me.txtVelocidadMedia.Modificado = False
        Me.txtVelocidadMedia.Name = "txtVelocidadMedia"
        Me.txtVelocidadMedia.Numerico_EsNumerico = True
        Me.txtVelocidadMedia.Numerico_NumeroDoublees = 0
        Me.txtVelocidadMedia.Numerico_SeparadorMiles = True
        Me.txtVelocidadMedia.Obligatorio = False
        Me.txtVelocidadMedia.ParametroID = 0
        Me.txtVelocidadMedia.Size = New System.Drawing.Size(69, 22)
        Me.txtVelocidadMedia.TabIndex = 22
        Me.txtVelocidadMedia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVelocidadMedia.ValorMaximo = 0.0R
        Me.txtVelocidadMedia.ValorMinimo = 0.0R
        '
        'txtTotalCajas
        '
        Me.txtTotalCajas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalCajas.EsUnicoCampo = ""
        Me.txtTotalCajas.EsUnicoCampoID = ""
        Me.txtTotalCajas.EsUnicoID = 0
        Me.txtTotalCajas.EsUnicoTabla = ""
        Me.txtTotalCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCajas.Location = New System.Drawing.Point(153, 16)
        Me.txtTotalCajas.MaxLength = 30
        Me.txtTotalCajas.Minimo = 0
        Me.txtTotalCajas.Modificado = False
        Me.txtTotalCajas.Name = "txtTotalCajas"
        Me.txtTotalCajas.Numerico_EsNumerico = True
        Me.txtTotalCajas.Numerico_NumeroDoublees = 0
        Me.txtTotalCajas.Numerico_SeparadorMiles = True
        Me.txtTotalCajas.Obligatorio = False
        Me.txtTotalCajas.ParametroID = 0
        Me.txtTotalCajas.Size = New System.Drawing.Size(46, 22)
        Me.txtTotalCajas.TabIndex = 15
        Me.txtTotalCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCajas.ValorMaximo = 0.0R
        Me.txtTotalCajas.ValorMinimo = 0.0R
        '
        'txtTotalMinutos
        '
        Me.txtTotalMinutos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalMinutos.EsUnicoCampo = ""
        Me.txtTotalMinutos.EsUnicoCampoID = ""
        Me.txtTotalMinutos.EsUnicoID = 0
        Me.txtTotalMinutos.EsUnicoTabla = ""
        Me.txtTotalMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalMinutos.Location = New System.Drawing.Point(93, 16)
        Me.txtTotalMinutos.MaxLength = 30
        Me.txtTotalMinutos.Minimo = 0
        Me.txtTotalMinutos.Modificado = False
        Me.txtTotalMinutos.Name = "txtTotalMinutos"
        Me.txtTotalMinutos.Numerico_EsNumerico = True
        Me.txtTotalMinutos.Numerico_NumeroDoublees = 0
        Me.txtTotalMinutos.Numerico_SeparadorMiles = True
        Me.txtTotalMinutos.Obligatorio = False
        Me.txtTotalMinutos.ParametroID = 0
        Me.txtTotalMinutos.Size = New System.Drawing.Size(57, 22)
        Me.txtTotalMinutos.TabIndex = 24
        Me.txtTotalMinutos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalMinutos.ValorMaximo = 0.0R
        Me.txtTotalMinutos.ValorMinimo = 0.0R
        '
        'txtTotalBotellas
        '
        Me.txtTotalBotellas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalBotellas.EsUnicoCampo = ""
        Me.txtTotalBotellas.EsUnicoCampoID = ""
        Me.txtTotalBotellas.EsUnicoID = 0
        Me.txtTotalBotellas.EsUnicoTabla = ""
        Me.txtTotalBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBotellas.Location = New System.Drawing.Point(200, 16)
        Me.txtTotalBotellas.MaxLength = 30
        Me.txtTotalBotellas.Minimo = 0
        Me.txtTotalBotellas.Modificado = False
        Me.txtTotalBotellas.Name = "txtTotalBotellas"
        Me.txtTotalBotellas.Numerico_EsNumerico = True
        Me.txtTotalBotellas.Numerico_NumeroDoublees = 0
        Me.txtTotalBotellas.Numerico_SeparadorMiles = True
        Me.txtTotalBotellas.Obligatorio = False
        Me.txtTotalBotellas.ParametroID = 0
        Me.txtTotalBotellas.Size = New System.Drawing.Size(57, 22)
        Me.txtTotalBotellas.TabIndex = 16
        Me.txtTotalBotellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBotellas.ValorMaximo = 0.0R
        Me.txtTotalBotellas.ValorMinimo = 0.0R
        '
        'txtTotalLitros
        '
        Me.txtTotalLitros.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtTotalLitros.EsUnicoCampo = ""
        Me.txtTotalLitros.EsUnicoCampoID = ""
        Me.txtTotalLitros.EsUnicoID = 0
        Me.txtTotalLitros.EsUnicoTabla = ""
        Me.txtTotalLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLitros.Location = New System.Drawing.Point(259, 16)
        Me.txtTotalLitros.MaxLength = 30
        Me.txtTotalLitros.Minimo = 0
        Me.txtTotalLitros.Modificado = False
        Me.txtTotalLitros.Name = "txtTotalLitros"
        Me.txtTotalLitros.Numerico_EsNumerico = True
        Me.txtTotalLitros.Numerico_NumeroDoublees = 0
        Me.txtTotalLitros.Numerico_SeparadorMiles = True
        Me.txtTotalLitros.Obligatorio = False
        Me.txtTotalLitros.ParametroID = 0
        Me.txtTotalLitros.Size = New System.Drawing.Size(57, 22)
        Me.txtTotalLitros.TabIndex = 17
        Me.txtTotalLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalLitros.ValorMaximo = 0.0R
        Me.txtTotalLitros.ValorMinimo = 0.0R
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnAgrupados)
        Me.Panel2.Controls.Add(Me.btnPorSCC)
        Me.Panel2.Controls.Add(Me.cboReferencia)
        Me.Panel2.Controls.Add(Me.btnExcel)
        Me.Panel2.Controls.Add(Me.dtpDesde)
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.dtpHasta)
        Me.Panel2.Controls.Add(Me.btnPorDias)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(453, 89)
        Me.Panel2.TabIndex = 27
        '
        'btnAgrupados
        '
        Me.btnAgrupados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgrupados.Image = CType(resources.GetObject("btnAgrupados.Image"), System.Drawing.Image)
        Me.btnAgrupados.Location = New System.Drawing.Point(188, 62)
        Me.btnAgrupados.Name = "btnAgrupados"
        Me.btnAgrupados.Size = New System.Drawing.Size(86, 24)
        Me.btnAgrupados.TabIndex = 15
        Me.btnAgrupados.Text = "Agrup&ados"
        Me.btnAgrupados.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnAgrupados.UseVisualStyleBackColor = True
        '
        'cboReferencia
        '
        Me.cboReferencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboReferencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReferencia.FormattingEnabled = True
        Me.cboReferencia.Location = New System.Drawing.Point(14, 10)
        Me.cboReferencia.Name = "cboReferencia"
        Me.cboReferencia.Size = New System.Drawing.Size(382, 21)
        Me.cboReferencia.TabIndex = 0
        '
        'frmLisEnvPorReferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 694)
        Me.Controls.Add(Me.dgvEnvasados)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmLisEnvPorReferencia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Envasados secundarios entre fechas"
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cboReferencia As System.Windows.Forms.ComboBox
    Private WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents dgvEnvasados As System.Windows.Forms.DataGridView
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnPorDias As System.Windows.Forms.Button
    Private WithEvents btnPorSCC As System.Windows.Forms.Button
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents btnExcel As System.Windows.Forms.Button
    Private WithEvents txtTotalCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTotalBotellas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTotalLitros As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblTotalCajas As System.Windows.Forms.Label
    Private WithEvents lblBotellas As System.Windows.Forms.Label
    Private WithEvents lblLitros As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtVelocidadMedia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtTotalMinutos As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents txtTotalEnvasados As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents btnAgrupados As System.Windows.Forms.Button
    Private WithEvents btnNoSCC As System.Windows.Forms.Button
    Private WithEvents txtSCC As System.Windows.Forms.TextBox
End Class
