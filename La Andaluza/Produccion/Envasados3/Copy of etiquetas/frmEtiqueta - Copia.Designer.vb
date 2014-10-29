<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEtiqueta0
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
        Me.components = New System.ComponentModel.Container()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lnCajas = New System.Windows.Forms.TextBox()
        Me.lPalet = New System.Windows.Forms.TextBox()
        Me.lnBotellas = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lCajasBotellas = New System.Windows.Forms.TextBox()
        Me.lProducto = New System.Windows.Forms.TextBox()
        Me.lMarca = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lCaducidad = New System.Windows.Forms.TextBox()
        Me.ltCaducidad = New System.Windows.Forms.Label()
        Me.lean13 = New System.Windows.Forms.TextBox()
        Me.lean14 = New System.Windows.Forms.TextBox()
        Me.llote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelean = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lscc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.panCabecera = New System.Windows.Forms.Panel()
        Me.txtCabecera = New System.Windows.Forms.TextBox()
        Me.panBotones = New System.Windows.Forms.Panel()
        Me.butCalculateCod = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Barcode2 = New System.Windows.Forms.PictureBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Barcode1 = New System.Windows.Forms.PictureBox()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.panCabecera.SuspendLayout()
        Me.panBotones.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.Barcode2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Barcode1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 23)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(342, 84)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lnCajas)
        Me.Panel4.Controls.Add(Me.lPalet)
        Me.Panel4.Controls.Add(Me.lnBotellas)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(214, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(128, 84)
        Me.Panel4.TabIndex = 1
        '
        'lnCajas
        '
        Me.lnCajas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lnCajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnCajas.Location = New System.Drawing.Point(4, 40)
        Me.lnCajas.Margin = New System.Windows.Forms.Padding(2)
        Me.lnCajas.MaxLength = 1000
        Me.lnCajas.Multiline = True
        Me.lnCajas.Name = "lnCajas"
        Me.lnCajas.Size = New System.Drawing.Size(122, 19)
        Me.lnCajas.TabIndex = 13
        Me.lnCajas.Text = "XXX CAJAS POR PALET"
        '
        'lPalet
        '
        Me.lPalet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lPalet.Dock = System.Windows.Forms.DockStyle.Top
        Me.lPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPalet.Location = New System.Drawing.Point(4, 0)
        Me.lPalet.Margin = New System.Windows.Forms.Padding(2)
        Me.lPalet.MaxLength = 1000
        Me.lPalet.Multiline = True
        Me.lPalet.Name = "lPalet"
        Me.lPalet.Size = New System.Drawing.Size(122, 40)
        Me.lPalet.TabIndex = 12
        Me.lPalet.Text = "PALET: CHEP XX x XXX bbb bb bb  cc"
        '
        'lnBotellas
        '
        Me.lnBotellas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lnBotellas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lnBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnBotellas.Location = New System.Drawing.Point(4, 59)
        Me.lnBotellas.Margin = New System.Windows.Forms.Padding(2)
        Me.lnBotellas.MaxLength = 1000
        Me.lnBotellas.Multiline = True
        Me.lnBotellas.Name = "lnBotellas"
        Me.lnBotellas.Size = New System.Drawing.Size(122, 23)
        Me.lnBotellas.TabIndex = 14
        Me.lnBotellas.Text = "xxxx BOTELLAS"
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(4, 82)
        Me.Panel10.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lCajasBotellas)
        Me.Panel3.Controls.Add(Me.lProducto)
        Me.Panel3.Controls.Add(Me.lMarca)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(214, 84)
        Me.Panel3.TabIndex = 0
        '
        'lCajasBotellas
        '
        Me.lCajasBotellas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lCajasBotellas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lCajasBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCajasBotellas.Location = New System.Drawing.Point(0, 59)
        Me.lCajasBotellas.Margin = New System.Windows.Forms.Padding(2)
        Me.lCajasBotellas.MaxLength = 1000
        Me.lCajasBotellas.Multiline = True
        Me.lCajasBotellas.Name = "lCajasBotellas"
        Me.lCajasBotellas.Size = New System.Drawing.Size(212, 23)
        Me.lCajasBotellas.TabIndex = 12
        Me.lCajasBotellas.Text = "xx BOTELLAS DE xxx ml"
        Me.lCajasBotellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lProducto
        '
        Me.lProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProducto.Location = New System.Drawing.Point(0, 24)
        Me.lProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.lProducto.MaxLength = 1000
        Me.lProducto.Multiline = True
        Me.lProducto.Name = "lProducto"
        Me.lProducto.Size = New System.Drawing.Size(212, 35)
        Me.lProducto.TabIndex = 14
        Me.lProducto.Text = "sustituir los datos de ejemplo por los reales"
        Me.lProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lMarca
        '
        Me.lMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.lMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMarca.Location = New System.Drawing.Point(0, 0)
        Me.lMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.lMarca.MaxLength = 1000
        Me.lMarca.Multiline = True
        Me.lMarca.Name = "lMarca"
        Me.lMarca.Size = New System.Drawing.Size(212, 24)
        Me.lMarca.TabIndex = 13
        Me.lMarca.Text = "Datos no recuperados"
        Me.lMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lCaducidad)
        Me.Panel5.Controls.Add(Me.ltCaducidad)
        Me.Panel5.Controls.Add(Me.lean13)
        Me.Panel5.Controls.Add(Me.lean14)
        Me.Panel5.Controls.Add(Me.llote)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.labelean)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 107)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(342, 78)
        Me.Panel5.TabIndex = 2
        '
        'lCaducidad
        '
        Me.lCaducidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCaducidad.Location = New System.Drawing.Point(278, 58)
        Me.lCaducidad.Margin = New System.Windows.Forms.Padding(2)
        Me.lCaducidad.MaxLength = 20
        Me.lCaducidad.Name = "lCaducidad"
        Me.lCaducidad.Size = New System.Drawing.Size(63, 16)
        Me.lCaducidad.TabIndex = 13
        Me.lCaducidad.Visible = False
        '
        'ltCaducidad
        '
        Me.ltCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltCaducidad.Location = New System.Drawing.Point(9, 58)
        Me.ltCaducidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ltCaducidad.Name = "ltCaducidad"
        Me.ltCaducidad.Size = New System.Drawing.Size(323, 15)
        Me.ltCaducidad.TabIndex = 12
        Me.ltCaducidad.Text = "Fecha de consumo preferente(aammdd):"
        '
        'lean13
        '
        Me.lean13.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lean13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lean13.Location = New System.Drawing.Point(91, 0)
        Me.lean13.Margin = New System.Windows.Forms.Padding(2)
        Me.lean13.MaxLength = 13
        Me.lean13.Name = "lean13"
        Me.lean13.Size = New System.Drawing.Size(162, 16)
        Me.lean13.TabIndex = 11
        Me.lean13.Text = "8481034912123"
        '
        'lean14
        '
        Me.lean14.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lean14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lean14.Location = New System.Drawing.Point(90, 21)
        Me.lean14.Margin = New System.Windows.Forms.Padding(2)
        Me.lean14.MaxLength = 14
        Me.lean14.Name = "lean14"
        Me.lean14.Size = New System.Drawing.Size(162, 16)
        Me.lean14.TabIndex = 10
        Me.lean14.Text = "1848103400785"
        '
        'llote
        '
        Me.llote.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.llote.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llote.Location = New System.Drawing.Point(91, 41)
        Me.llote.Margin = New System.Windows.Forms.Padding(2)
        Me.llote.MaxLength = 20
        Me.llote.Name = "llote"
        Me.llote.Size = New System.Drawing.Size(162, 16)
        Me.llote.TabIndex = 8
        Me.llote.Text = "xxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 40)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 20)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GTIN-14:"
        '
        'labelean
        '
        Me.labelean.AutoSize = True
        Me.labelean.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelean.Location = New System.Drawing.Point(9, 0)
        Me.labelean.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelean.Name = "labelean"
        Me.labelean.Size = New System.Drawing.Size(66, 17)
        Me.labelean.TabIndex = 0
        Me.labelean.Text = "GTIN-13:"
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lscc)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 185)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(342, 21)
        Me.Panel6.TabIndex = 3
        '
        'lscc
        '
        Me.lscc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lscc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lscc.Location = New System.Drawing.Point(91, 1)
        Me.lscc.Margin = New System.Windows.Forms.Padding(2)
        Me.lscc.MaxLength = 8
        Me.lscc.Name = "lscc"
        Me.lscc.Size = New System.Drawing.Size(161, 16)
        Me.lscc.TabIndex = 7
        Me.lscc.Text = "xxxxx"
        '
        'Label4
        '
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 2)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SSCC:"
        '
        'panCabecera
        '
        Me.panCabecera.Controls.Add(Me.txtCabecera)
        Me.panCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panCabecera.Margin = New System.Windows.Forms.Padding(2)
        Me.panCabecera.Name = "panCabecera"
        Me.panCabecera.Size = New System.Drawing.Size(342, 23)
        Me.panCabecera.TabIndex = 3
        '
        'txtCabecera
        '
        Me.txtCabecera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabecera.Location = New System.Drawing.Point(0, 0)
        Me.txtCabecera.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCabecera.MaxLength = 1000
        Me.txtCabecera.Multiline = True
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.Size = New System.Drawing.Size(342, 23)
        Me.txtCabecera.TabIndex = 14
        Me.txtCabecera.Text = "Datos no recuperados"
        Me.txtCabecera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'panBotones
        '
        Me.panBotones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panBotones.BackColor = System.Drawing.Color.LightGray
        Me.panBotones.Controls.Add(Me.butCalculateCod)
        Me.panBotones.Controls.Add(Me.btnImprimir)
        Me.panBotones.Location = New System.Drawing.Point(0, 337)
        Me.panBotones.Margin = New System.Windows.Forms.Padding(2)
        Me.panBotones.Name = "panBotones"
        Me.panBotones.Size = New System.Drawing.Size(342, 86)
        Me.panBotones.TabIndex = 6
        '
        'butCalculateCod
        '
        Me.butCalculateCod.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCalculateCod.FlatAppearance.BorderSize = 0
        Me.butCalculateCod.Image = Global.La_Andaluza.My.Resources.Resources.document_quick_restart
        Me.butCalculateCod.Location = New System.Drawing.Point(24, 11)
        Me.butCalculateCod.Margin = New System.Windows.Forms.Padding(2)
        Me.butCalculateCod.Name = "butCalculateCod"
        Me.butCalculateCod.Size = New System.Drawing.Size(135, 68)
        Me.butCalculateCod.TabIndex = 2
        Me.butCalculateCod.Text = "Recalcular codigo de barras"
        Me.butCalculateCod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.butCalculateCod.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.Image = Global.La_Andaluza.My.Resources.Resources.printer_laser_64
        Me.btnImprimir.Location = New System.Drawing.Point(191, 11)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(130, 68)
        Me.btnImprimir.TabIndex = 1
        Me.btnImprimir.Text = "Imprimir"
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.Controls.Add(Me.panBotones)
        Me.Panel1.Controls.Add(Me.Barcode2)
        Me.Panel1.Controls.Add(Me.Panel9)
        Me.Panel1.Controls.Add(Me.Barcode1)
        Me.Panel1.Controls.Add(Me.Panel8)
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.panCabecera)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(342, 469)
        Me.Panel1.TabIndex = 2
        '
        'Barcode2
        '
        Me.Barcode2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barcode2.Location = New System.Drawing.Point(6, 320)
        Me.Barcode2.Margin = New System.Windows.Forms.Padding(2)
        Me.Barcode2.Name = "Barcode2"
        Me.Barcode2.Size = New System.Drawing.Size(336, 98)
        Me.Barcode2.TabIndex = 8
        Me.Barcode2.TabStop = False
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel9.Location = New System.Drawing.Point(6, 312)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(336, 8)
        Me.Panel9.TabIndex = 11
        '
        'Barcode1
        '
        Me.Barcode1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Barcode1.Location = New System.Drawing.Point(6, 214)
        Me.Barcode1.Margin = New System.Windows.Forms.Padding(2)
        Me.Barcode1.Name = "Barcode1"
        Me.Barcode1.Size = New System.Drawing.Size(336, 98)
        Me.Barcode1.TabIndex = 7
        Me.Barcode1.TabStop = False
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(0, 214)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(6, 255)
        Me.Panel8.TabIndex = 10
        '
        'Panel7
        '
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 206)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(342, 8)
        Me.Panel7.TabIndex = 9
        '
        'frmEtiqueta0
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(342, 469)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEtiqueta0"
        Me.Text = "frmEtiqueta"
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panCabecera.ResumeLayout(False)
        Me.panCabecera.PerformLayout()
        Me.panBotones.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        CType(Me.Barcode2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Barcode1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Timer1 As System.Windows.Forms.Timer
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents lnBotellas As System.Windows.Forms.TextBox
    Private WithEvents lnCajas As System.Windows.Forms.TextBox
    Private WithEvents lPalet As System.Windows.Forms.TextBox
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents lCajasBotellas As System.Windows.Forms.TextBox
    Private WithEvents lProducto As System.Windows.Forms.TextBox
    Private WithEvents lMarca As System.Windows.Forms.TextBox
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents lCaducidad As System.Windows.Forms.TextBox
    Private WithEvents ltCaducidad As System.Windows.Forms.Label
    Private WithEvents lean13 As System.Windows.Forms.TextBox
    Private WithEvents lean14 As System.Windows.Forms.TextBox
    Private WithEvents llote As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents labelean As System.Windows.Forms.Label
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents lscc As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents panCabecera As System.Windows.Forms.Panel
    Private WithEvents txtCabecera As System.Windows.Forms.TextBox
    Private WithEvents panBotones As System.Windows.Forms.Panel
    Private WithEvents butCalculateCod As System.Windows.Forms.Button
    Private WithEvents btnImprimir As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Barcode2 As System.Windows.Forms.PictureBox
    Private WithEvents Barcode1 As System.Windows.Forms.PictureBox
    Private WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents Panel8 As System.Windows.Forms.Panel
    Private WithEvents Panel7 As System.Windows.Forms.Panel
End Class
