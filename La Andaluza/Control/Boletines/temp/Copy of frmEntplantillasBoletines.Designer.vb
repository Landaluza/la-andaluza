<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntplantillasBoletines
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntplantillasBoletines))

        Me.txtCabecera = New System.Windows.Forms.TextBox()
        Me.lCabecera = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.rdbSinLogo = New System.Windows.Forms.RadioButton()
        Me.rdbLA = New System.Windows.Forms.RadioButton()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.rdbJR = New System.Windows.Forms.RadioButton()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.cboAnalistas = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PanParametros = New System.Windows.Forms.Panel()
        Me.panel3 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.cboIdioma = New System.Windows.Forms.ComboBox()
        Me.txtComentario1 = New System.Windows.Forms.RichTextBox()
        Me.txtComentario2 = New System.Windows.Forms.RichTextBox()
        Me.cbComentario1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbComentario2 = New System.Windows.Forms.CheckBox()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.PanDescripciones = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panel3.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.PanDescripciones.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTop
        '




        '
        'txtCabecera
        '
        Me.txtCabecera.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCabecera.Location = New System.Drawing.Point(151, 199)
        Me.txtCabecera.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.Size = New System.Drawing.Size(1291, 22)
        Me.txtCabecera.TabIndex = 10
        '
        'lCabecera
        '
        Me.lCabecera.AutoSize = True
        Me.lCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCabecera.Location = New System.Drawing.Point(61, 203)
        Me.lCabecera.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lCabecera.Name = "lCabecera"
        Me.lCabecera.Size = New System.Drawing.Size(77, 17)
        Me.lCabecera.TabIndex = 9
        Me.lCabecera.Text = "Cabecera"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 20)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 17)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Idioma"
        Me.Label6.Visible = False
        '
        'lNombre
        '
        Me.lNombre.AutoSize = True
        Me.lNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lNombre.Location = New System.Drawing.Point(61, 169)
        Me.lNombre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lNombre.Name = "lNombre"
        Me.lNombre.Size = New System.Drawing.Size(64, 17)
        Me.lNombre.TabIndex = 7
        Me.lNombre.Text = "Nombre"
        '
        'txtNombre
        '
        Me.txtNombre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtNombre.Location = New System.Drawing.Point(151, 165)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(1291, 22)
        Me.txtNombre.TabIndex = 8
        Me.txtNombre.Visible = False
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(48, 416)
        Me.Panel9.TabIndex = 1
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.La_Andaluza.My.Resources.Resources.LogoJR
        Me.PictureBox3.InitialImage = Global.La_Andaluza.My.Resources.Resources.LogoJR
        Me.PictureBox3.Location = New System.Drawing.Point(261, 37)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 35
        Me.PictureBox3.TabStop = False
        '
        'Panel10
        '
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(1442, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(43, 416)
        Me.Panel10.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtCabecera)
        Me.Panel2.Controls.Add(Me.lCabecera)
        Me.Panel2.Controls.Add(Me.lNombre)
        Me.Panel2.Controls.Add(Me.txtNombre)
        Me.Panel2.Controls.Add(Me.PictureBox4)
        Me.Panel2.Controls.Add(Me.PictureBox3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.PictureBox1)
        Me.Panel2.Controls.Add(Me.butCancelar)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.rdbSinLogo)
        Me.Panel2.Controls.Add(Me.rdbLA)
        Me.Panel2.Controls.Add(Me.Label12)
        Me.Panel2.Controls.Add(Me.rdbJR)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1485, 252)
        Me.Panel2.TabIndex = 1
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.La_Andaluza.My.Resources.Resources.LogoLA
        Me.PictureBox4.Location = New System.Drawing.Point(151, 37)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(295, 122)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 18)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "JR Sabater"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label8.UseCompatibleTextRendering = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(195, 122)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 18)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Andaluza"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label7.UseCompatibleTextRendering = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.La_Andaluza.My.Resources.Resources.no_imagen_64
        Me.PictureBox1.InitialImage = Global.La_Andaluza.My.Resources.Resources.LogoJR
        Me.PictureBox1.Location = New System.Drawing.Point(372, 37)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 85)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 44
        Me.PictureBox1.TabStop = False
        '
        'butCancelar
        '
        Me.butCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butCancelar.FlatAppearance.BorderSize = 0
        Me.butCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butCancelar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_cancel_3
        Me.butCancelar.Location = New System.Drawing.Point(1155, 37)
        Me.butCancelar.Margin = New System.Windows.Forms.Padding(4)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(139, 73)
        Me.butCancelar.TabIndex = 12
        Me.butCancelar.Text = "&Cancelar"
        Me.butCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.butCancelar.UseVisualStyleBackColor = True
        Me.butCancelar.Visible = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_32
        Me.Button1.Location = New System.Drawing.Point(1305, 37)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(139, 73)
        Me.Button1.TabIndex = 13
        Me.Button1.Text = "&Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        Me.Button1.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(61, 238)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 17)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Parametros a incluir"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(61, 11)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 17)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Logo"
        '
        'rdbSinLogo
        '
        Me.rdbSinLogo.AutoSize = True
        Me.rdbSinLogo.Location = New System.Drawing.Point(372, 121)
        Me.rdbSinLogo.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbSinLogo.Name = "rdbSinLogo"
        Me.rdbSinLogo.Size = New System.Drawing.Size(17, 16)
        Me.rdbSinLogo.TabIndex = 5
        Me.rdbSinLogo.Tag = "0"
        Me.rdbSinLogo.UseVisualStyleBackColor = True
        '
        'rdbLA
        '
        Me.rdbLA.AutoSize = True
        Me.rdbLA.Checked = True
        Me.rdbLA.Location = New System.Drawing.Point(151, 121)
        Me.rdbLA.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbLA.Name = "rdbLA"
        Me.rdbLA.Size = New System.Drawing.Size(17, 16)
        Me.rdbLA.TabIndex = 1
        Me.rdbLA.TabStop = True
        Me.rdbLA.Tag = "1"
        Me.rdbLA.UseVisualStyleBackColor = True
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(424, 122)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(48, 18)
        Me.Label12.TabIndex = 6
        Me.Label12.Text = "Sin logo"
        Me.Label12.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label12.UseCompatibleTextRendering = True
        '
        'rdbJR
        '
        Me.rdbJR.AutoSize = True
        Me.rdbJR.Location = New System.Drawing.Point(261, 122)
        Me.rdbJR.Margin = New System.Windows.Forms.Padding(4)
        Me.rdbJR.Name = "rdbJR"
        Me.rdbJR.Size = New System.Drawing.Size(17, 16)
        Me.rdbJR.TabIndex = 3
        Me.rdbJR.Tag = "2"
        Me.rdbJR.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel5.Location = New System.Drawing.Point(1442, 0)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(43, 156)
        Me.Panel5.TabIndex = 1
        '
        'cboAnalistas
        '
        Me.cboAnalistas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboAnalistas.FormattingEnabled = True
        Me.cboAnalistas.Location = New System.Drawing.Point(1127, 48)
        Me.cboAnalistas.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAnalistas.Name = "cboAnalistas"
        Me.cboAnalistas.Size = New System.Drawing.Size(265, 24)
        Me.cboAnalistas.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(13, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 17)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Pie de Página"
        '
        'PanParametros
        '
        Me.PanParametros.AutoScroll = True
        Me.PanParametros.AutoScrollMargin = New System.Drawing.Size(0, 500)
        Me.PanParametros.AutoScrollMinSize = New System.Drawing.Size(745, 325)
        Me.PanParametros.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanParametros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanParametros.Location = New System.Drawing.Point(48, 0)
        Me.PanParametros.Margin = New System.Windows.Forms.Padding(4)
        Me.PanParametros.Name = "PanParametros"
        Me.PanParametros.Size = New System.Drawing.Size(1394, 156)
        Me.PanParametros.TabIndex = 0
        '
        'panel3
        '
        Me.panel3.Controls.Add(Me.PanParametros)
        Me.panel3.Controls.Add(Me.Panel5)
        Me.panel3.Controls.Add(Me.Panel6)
        Me.panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel3.Location = New System.Drawing.Point(0, 277)
        Me.panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.panel3.Name = "panel3"
        Me.panel3.Size = New System.Drawing.Size(1485, 156)
        Me.panel3.TabIndex = 1000000003
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(48, 156)
        Me.Panel6.TabIndex = 2
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.Label5)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(48, 0)
        Me.Panel8.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(1394, 32)
        Me.Panel8.TabIndex = 0
        '
        'cboIdioma
        '
        Me.cboIdioma.FormattingEnabled = True
        Me.cboIdioma.Location = New System.Drawing.Point(28, 48)
        Me.cboIdioma.Margin = New System.Windows.Forms.Padding(4)
        Me.cboIdioma.Name = "cboIdioma"
        Me.cboIdioma.Size = New System.Drawing.Size(185, 24)
        Me.cboIdioma.TabIndex = 1
        Me.cboIdioma.Visible = False
        '
        'txtComentario1
        '
        Me.txtComentario1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario1.Location = New System.Drawing.Point(28, 31)
        Me.txtComentario1.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario1.Name = "txtComentario1"
        Me.txtComentario1.Size = New System.Drawing.Size(1364, 69)
        Me.txtComentario1.TabIndex = 2
        Me.txtComentario1.Text = resources.GetString("txtComentario1.Text")
        '
        'txtComentario2
        '
        Me.txtComentario2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentario2.Location = New System.Drawing.Point(28, 121)
        Me.txtComentario2.Margin = New System.Windows.Forms.Padding(4)
        Me.txtComentario2.Name = "txtComentario2"
        Me.txtComentario2.Size = New System.Drawing.Size(1364, 69)
        Me.txtComentario2.TabIndex = 0
        Me.txtComentario2.Text = "Texto alternativo"
        '
        'cbComentario1
        '
        Me.cbComentario1.AutoSize = True
        Me.cbComentario1.Location = New System.Drawing.Point(0, 57)
        Me.cbComentario1.Margin = New System.Windows.Forms.Padding(4)
        Me.cbComentario1.Name = "cbComentario1"
        Me.cbComentario1.Size = New System.Drawing.Size(18, 17)
        Me.cbComentario1.TabIndex = 1
        Me.cbComentario1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(976, 58)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Analista"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(976, 17)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Fecha del informe"
        '
        'cbComentario2
        '
        Me.cbComentario2.AutoSize = True
        Me.cbComentario2.Location = New System.Drawing.Point(0, 145)
        Me.cbComentario2.Margin = New System.Windows.Forms.Padding(4)
        Me.cbComentario2.Name = "cbComentario2"
        Me.cbComentario2.Size = New System.Drawing.Size(18, 17)
        Me.cbComentario2.TabIndex = 3
        Me.cbComentario2.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnImprimir.Location = New System.Drawing.Point(1255, 87)
        Me.btnImprimir.Margin = New System.Windows.Forms.Padding(4)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(139, 58)
        Me.btnImprimir.TabIndex = 6
        Me.btnImprimir.Text = "&Exportar"
        Me.btnImprimir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnImprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'PanDescripciones
        '
        Me.PanDescripciones.Controls.Add(Me.txtComentario1)
        Me.PanDescripciones.Controls.Add(Me.txtComentario2)
        Me.PanDescripciones.Controls.Add(Me.cbComentario1)
        Me.PanDescripciones.Controls.Add(Me.cbComentario2)
        Me.PanDescripciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDescripciones.Location = New System.Drawing.Point(48, 32)
        Me.PanDescripciones.Margin = New System.Windows.Forms.Padding(4)
        Me.PanDescripciones.Name = "PanDescripciones"
        Me.PanDescripciones.Size = New System.Drawing.Size(1394, 224)
        Me.PanDescripciones.TabIndex = 1
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.PanDescripciones)
        Me.Panel7.Controls.Add(Me.Panel11)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel10)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1485, 416)
        Me.Panel7.TabIndex = 30
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label6)
        Me.Panel11.Controls.Add(Me.cboAnalistas)
        Me.Panel11.Controls.Add(Me.cboIdioma)
        Me.Panel11.Controls.Add(Me.btnImprimir)
        Me.Panel11.Controls.Add(Me.dtpFecha)
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(48, 256)
        Me.Panel11.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(1394, 160)
        Me.Panel11.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFecha.Location = New System.Drawing.Point(1127, 11)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(265, 22)
        Me.dtpFecha.TabIndex = 4
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel7)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 433)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1485, 416)
        Me.Panel1.TabIndex = 1000000001
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'frmEntplantillasBoletines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1485, 849)
        Me.Controls.Add(Me.panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntplantillasBoletines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "plantillasBoletines"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.panel3, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panel3.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.PanDescripciones.ResumeLayout(False)
        Me.PanDescripciones.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel7 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents btnImprimir As System.Windows.Forms.Button
    Private WithEvents txtCabecera As System.Windows.Forms.TextBox
    Private WithEvents lCabecera As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lNombre As System.Windows.Forms.Label
    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Private WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents butCancelar As System.Windows.Forms.Button
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents rdbSinLogo As System.Windows.Forms.RadioButton
    Private WithEvents rdbLA As System.Windows.Forms.RadioButton
    Private WithEvents Label12 As System.Windows.Forms.Label
    Private WithEvents rdbJR As System.Windows.Forms.RadioButton
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents cboAnalistas As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents PanParametros As System.Windows.Forms.Panel
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents Panel8 As System.Windows.Forms.Panel
    Private WithEvents cboIdioma As System.Windows.Forms.ComboBox
    Private WithEvents txtComentario1 As System.Windows.Forms.RichTextBox
    Private WithEvents txtComentario2 As System.Windows.Forms.RichTextBox
    Private WithEvents cbComentario1 As System.Windows.Forms.CheckBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cbComentario2 As System.Windows.Forms.CheckBox
    Private WithEvents PanDescripciones As System.Windows.Forms.Panel
    Private WithEvents Panel11 As System.Windows.Forms.Panel
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
End Class
