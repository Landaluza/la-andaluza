<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvasadosProductosArticulos_NO_USAR
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidadRestante = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLitrosLote = New System.Windows.Forms.Label()
        Me.txtCantidadAsignada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLitrosEnvasados = New System.Windows.Forms.Label()
        Me.txtCantidadEnvasada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butGenerarTrasiegos = New System.Windows.Forms.Button()
        Me.gpbMonodosis = New System.Windows.Forms.GroupBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.CuadroDeTexto7 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto8 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto9 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.CuadroDeTexto1 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto2 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto3 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.CuadroDeTexto4 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto5 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CuadroDeTexto6 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.gpbCantidades = New System.Windows.Forms.GroupBox()
        Me.gpbMovimientos = New System.Windows.Forms.GroupBox()
        Me.gpbMermas = New System.Windows.Forms.GroupBox()
        Me.dgvMermas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.lTrasiegos = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel22 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.Panel19 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbMonodosis.SuspendLayout()
        Me.Panel12.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel16.SuspendLayout()
        Me.Panel8.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.Panel14.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.gpbCantidades.SuspendLayout()
        Me.gpbMovimientos.SuspendLayout()
        Me.gpbMermas.SuspendLayout()
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel22.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()

        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGrilla.Location = New System.Drawing.Point(3, 16)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(875, 279)
        Me.dgvGrilla.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.Location = New System.Drawing.Point(44, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(64, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Restante:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadRestante
        '
        Me.txtCantidadRestante.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadRestante.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadRestante.Enabled = False
        Me.txtCantidadRestante.EsUnicoCampo = ""
        Me.txtCantidadRestante.EsUnicoCampoID = ""
        Me.txtCantidadRestante.EsUnicoID = 0
        Me.txtCantidadRestante.EsUnicoTabla = ""
        Me.txtCantidadRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRestante.Location = New System.Drawing.Point(128, 69)
        Me.txtCantidadRestante.MaxLength = 500
        Me.txtCantidadRestante.Minimo = 0
        Me.txtCantidadRestante.Modificado = False
        Me.txtCantidadRestante.Name = "txtCantidadRestante"
        Me.txtCantidadRestante.Numerico_EsNumerico = True
        Me.txtCantidadRestante.Numerico_NumeroDoublees = 0
        Me.txtCantidadRestante.Numerico_SeparadorMiles = True
        Me.txtCantidadRestante.Obligatorio = False
        Me.txtCantidadRestante.ParametroID = 0
        Me.txtCantidadRestante.Size = New System.Drawing.Size(69, 21)
        Me.txtCantidadRestante.TabIndex = 5
        Me.txtCantidadRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadRestante.ValorMaximo = 0.0!
        Me.txtCantidadRestante.ValorMinimo = 0.0!
        '
        'lblLitrosLote
        '
        Me.lblLitrosLote.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblLitrosLote.Location = New System.Drawing.Point(44, 45)
        Me.lblLitrosLote.Name = "lblLitrosLote"
        Me.lblLitrosLote.Size = New System.Drawing.Size(64, 21)
        Me.lblLitrosLote.TabIndex = 2
        Me.lblLitrosLote.Text = "Asignada:"
        Me.lblLitrosLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadAsignada
        '
        Me.txtCantidadAsignada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadAsignada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadAsignada.Enabled = False
        Me.txtCantidadAsignada.EsUnicoCampo = ""
        Me.txtCantidadAsignada.EsUnicoCampoID = ""
        Me.txtCantidadAsignada.EsUnicoID = 0
        Me.txtCantidadAsignada.EsUnicoTabla = ""
        Me.txtCantidadAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAsignada.Location = New System.Drawing.Point(128, 42)
        Me.txtCantidadAsignada.MaxLength = 500
        Me.txtCantidadAsignada.Minimo = 0
        Me.txtCantidadAsignada.Modificado = False
        Me.txtCantidadAsignada.Name = "txtCantidadAsignada"
        Me.txtCantidadAsignada.Numerico_EsNumerico = True
        Me.txtCantidadAsignada.Numerico_NumeroDoublees = 0
        Me.txtCantidadAsignada.Numerico_SeparadorMiles = True
        Me.txtCantidadAsignada.Obligatorio = False
        Me.txtCantidadAsignada.ParametroID = 0
        Me.txtCantidadAsignada.Size = New System.Drawing.Size(69, 21)
        Me.txtCantidadAsignada.TabIndex = 3
        Me.txtCantidadAsignada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadAsignada.ValorMaximo = 0.0!
        Me.txtCantidadAsignada.ValorMinimo = 0.0!
        '
        'lblLitrosEnvasados
        '
        Me.lblLitrosEnvasados.Location = New System.Drawing.Point(44, 15)
        Me.lblLitrosEnvasados.Name = "lblLitrosEnvasados"
        Me.lblLitrosEnvasados.Size = New System.Drawing.Size(64, 21)
        Me.lblLitrosEnvasados.TabIndex = 0
        Me.lblLitrosEnvasados.Text = "Envasada:"
        Me.lblLitrosEnvasados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadEnvasada
        '
        Me.txtCantidadEnvasada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadEnvasada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadEnvasada.Enabled = False
        Me.txtCantidadEnvasada.EsUnicoCampo = ""
        Me.txtCantidadEnvasada.EsUnicoCampoID = ""
        Me.txtCantidadEnvasada.EsUnicoID = 0
        Me.txtCantidadEnvasada.EsUnicoTabla = ""
        Me.txtCantidadEnvasada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEnvasada.Location = New System.Drawing.Point(128, 15)
        Me.txtCantidadEnvasada.MaxLength = 500
        Me.txtCantidadEnvasada.Minimo = 0
        Me.txtCantidadEnvasada.Modificado = False
        Me.txtCantidadEnvasada.Name = "txtCantidadEnvasada"
        Me.txtCantidadEnvasada.Numerico_EsNumerico = True
        Me.txtCantidadEnvasada.Numerico_NumeroDoublees = 0
        Me.txtCantidadEnvasada.Numerico_SeparadorMiles = True
        Me.txtCantidadEnvasada.Obligatorio = False
        Me.txtCantidadEnvasada.ParametroID = 0
        Me.txtCantidadEnvasada.Size = New System.Drawing.Size(69, 21)
        Me.txtCantidadEnvasada.TabIndex = 1
        Me.txtCantidadEnvasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadEnvasada.ValorMaximo = 0.0!
        Me.txtCantidadEnvasada.ValorMinimo = 0.0!
        '
        'butGenerarTrasiegos
        '
        Me.butGenerarTrasiegos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.butGenerarTrasiegos.Location = New System.Drawing.Point(41, 34)
        Me.butGenerarTrasiegos.Name = "butGenerarTrasiegos"
        Me.butGenerarTrasiegos.Size = New System.Drawing.Size(117, 47)
        Me.butGenerarTrasiegos.TabIndex = 6
        Me.butGenerarTrasiegos.Text = "&Generar movimientos y lotes"
        Me.butGenerarTrasiegos.UseVisualStyleBackColor = True
        Me.butGenerarTrasiegos.Visible = False
        '
        'gpbMonodosis
        '
        Me.gpbMonodosis.Controls.Add(Me.Panel12)
        Me.gpbMonodosis.Controls.Add(Me.Panel11)
        Me.gpbMonodosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbMonodosis.Location = New System.Drawing.Point(409, 0)
        Me.gpbMonodosis.Name = "gpbMonodosis"
        Me.gpbMonodosis.Size = New System.Drawing.Size(472, 114)
        Me.gpbMonodosis.TabIndex = 1
        Me.gpbMonodosis.TabStop = False
        Me.gpbMonodosis.Text = "Monodosis"
        Me.gpbMonodosis.Visible = False
        '
        'Panel12
        '
        Me.Panel12.Controls.Add(Me.Panel10)
        Me.Panel12.Controls.Add(Me.Panel8)
        Me.Panel12.Controls.Add(Me.Panel9)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(135, 16)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(334, 95)
        Me.Panel12.TabIndex = 18
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.CuadroDeTexto7)
        Me.Panel10.Controls.Add(Me.CuadroDeTexto8)
        Me.Panel10.Controls.Add(Me.CuadroDeTexto9)
        Me.Panel10.Controls.Add(Me.Panel16)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(206, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Panel10.Size = New System.Drawing.Size(104, 95)
        Me.Panel10.TabIndex = 17
        '
        'CuadroDeTexto7
        '
        Me.CuadroDeTexto7.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto7.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto7.EsUnicoCampo = ""
        Me.CuadroDeTexto7.EsUnicoCampoID = ""
        Me.CuadroDeTexto7.EsUnicoID = 0
        Me.CuadroDeTexto7.EsUnicoTabla = ""
        Me.CuadroDeTexto7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto7.Location = New System.Drawing.Point(0, 68)
        Me.CuadroDeTexto7.MaxLength = 500
        Me.CuadroDeTexto7.Minimo = 0
        Me.CuadroDeTexto7.Modificado = False
        Me.CuadroDeTexto7.Name = "CuadroDeTexto7"
        Me.CuadroDeTexto7.Numerico_EsNumerico = True
        Me.CuadroDeTexto7.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto7.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto7.Obligatorio = False
        Me.CuadroDeTexto7.ParametroID = 0
        Me.CuadroDeTexto7.Size = New System.Drawing.Size(99, 21)
        Me.CuadroDeTexto7.TabIndex = 17
        Me.CuadroDeTexto7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto7.ValorMaximo = 0.0!
        Me.CuadroDeTexto7.ValorMinimo = 0.0!
        '
        'CuadroDeTexto8
        '
        Me.CuadroDeTexto8.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto8.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto8.EsUnicoCampo = ""
        Me.CuadroDeTexto8.EsUnicoCampoID = ""
        Me.CuadroDeTexto8.EsUnicoID = 0
        Me.CuadroDeTexto8.EsUnicoTabla = ""
        Me.CuadroDeTexto8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto8.Location = New System.Drawing.Point(0, 47)
        Me.CuadroDeTexto8.MaxLength = 500
        Me.CuadroDeTexto8.Minimo = 0
        Me.CuadroDeTexto8.Modificado = False
        Me.CuadroDeTexto8.Name = "CuadroDeTexto8"
        Me.CuadroDeTexto8.Numerico_EsNumerico = True
        Me.CuadroDeTexto8.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto8.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto8.Obligatorio = False
        Me.CuadroDeTexto8.ParametroID = 0
        Me.CuadroDeTexto8.Size = New System.Drawing.Size(99, 21)
        Me.CuadroDeTexto8.TabIndex = 13
        Me.CuadroDeTexto8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto8.ValorMaximo = 0.0!
        Me.CuadroDeTexto8.ValorMinimo = 0.0!
        '
        'CuadroDeTexto9
        '
        Me.CuadroDeTexto9.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto9.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto9.EsUnicoCampo = ""
        Me.CuadroDeTexto9.EsUnicoCampoID = ""
        Me.CuadroDeTexto9.EsUnicoID = 0
        Me.CuadroDeTexto9.EsUnicoTabla = ""
        Me.CuadroDeTexto9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto9.Location = New System.Drawing.Point(0, 26)
        Me.CuadroDeTexto9.MaxLength = 500
        Me.CuadroDeTexto9.Minimo = 0
        Me.CuadroDeTexto9.Modificado = False
        Me.CuadroDeTexto9.Name = "CuadroDeTexto9"
        Me.CuadroDeTexto9.Numerico_EsNumerico = True
        Me.CuadroDeTexto9.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto9.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto9.Obligatorio = False
        Me.CuadroDeTexto9.ParametroID = 0
        Me.CuadroDeTexto9.Size = New System.Drawing.Size(99, 21)
        Me.CuadroDeTexto9.TabIndex = 9
        Me.CuadroDeTexto9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto9.ValorMaximo = 0.0!
        Me.CuadroDeTexto9.ValorMinimo = 0.0!
        '
        'Panel16
        '
        Me.Panel16.Controls.Add(Me.Label7)
        Me.Panel16.Controls.Add(Me.Button3)
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel16.Location = New System.Drawing.Point(0, 0)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(99, 26)
        Me.Panel16.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label7.Location = New System.Drawing.Point(0, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 26)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Sal"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button3
        '
        Me.Button3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button3.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.Button3.Location = New System.Drawing.Point(71, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(28, 26)
        Me.Button3.TabIndex = 5
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Panel8
        '
        Me.Panel8.Controls.Add(Me.CuadroDeTexto1)
        Me.Panel8.Controls.Add(Me.CuadroDeTexto2)
        Me.Panel8.Controls.Add(Me.CuadroDeTexto3)
        Me.Panel8.Controls.Add(Me.Panel15)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel8.Location = New System.Drawing.Point(108, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Panel8.Size = New System.Drawing.Size(98, 95)
        Me.Panel8.TabIndex = 15
        '
        'CuadroDeTexto1
        '
        Me.CuadroDeTexto1.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto1.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto1.EsUnicoCampo = ""
        Me.CuadroDeTexto1.EsUnicoCampoID = ""
        Me.CuadroDeTexto1.EsUnicoID = 0
        Me.CuadroDeTexto1.EsUnicoTabla = ""
        Me.CuadroDeTexto1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto1.Location = New System.Drawing.Point(0, 68)
        Me.CuadroDeTexto1.MaxLength = 500
        Me.CuadroDeTexto1.Minimo = 0
        Me.CuadroDeTexto1.Modificado = False
        Me.CuadroDeTexto1.Name = "CuadroDeTexto1"
        Me.CuadroDeTexto1.Numerico_EsNumerico = True
        Me.CuadroDeTexto1.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto1.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto1.Obligatorio = False
        Me.CuadroDeTexto1.ParametroID = 0
        Me.CuadroDeTexto1.Size = New System.Drawing.Size(93, 21)
        Me.CuadroDeTexto1.TabIndex = 15
        Me.CuadroDeTexto1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto1.ValorMaximo = 0.0!
        Me.CuadroDeTexto1.ValorMinimo = 0.0!
        '
        'CuadroDeTexto2
        '
        Me.CuadroDeTexto2.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto2.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto2.EsUnicoCampo = ""
        Me.CuadroDeTexto2.EsUnicoCampoID = ""
        Me.CuadroDeTexto2.EsUnicoID = 0
        Me.CuadroDeTexto2.EsUnicoTabla = ""
        Me.CuadroDeTexto2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto2.Location = New System.Drawing.Point(0, 47)
        Me.CuadroDeTexto2.MaxLength = 500
        Me.CuadroDeTexto2.Minimo = 0
        Me.CuadroDeTexto2.Modificado = False
        Me.CuadroDeTexto2.Name = "CuadroDeTexto2"
        Me.CuadroDeTexto2.Numerico_EsNumerico = True
        Me.CuadroDeTexto2.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto2.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto2.Obligatorio = False
        Me.CuadroDeTexto2.ParametroID = 0
        Me.CuadroDeTexto2.Size = New System.Drawing.Size(93, 21)
        Me.CuadroDeTexto2.TabIndex = 11
        Me.CuadroDeTexto2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto2.ValorMaximo = 0.0!
        Me.CuadroDeTexto2.ValorMinimo = 0.0!
        '
        'CuadroDeTexto3
        '
        Me.CuadroDeTexto3.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto3.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto3.EsUnicoCampo = ""
        Me.CuadroDeTexto3.EsUnicoCampoID = ""
        Me.CuadroDeTexto3.EsUnicoID = 0
        Me.CuadroDeTexto3.EsUnicoTabla = ""
        Me.CuadroDeTexto3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto3.Location = New System.Drawing.Point(0, 26)
        Me.CuadroDeTexto3.MaxLength = 500
        Me.CuadroDeTexto3.Minimo = 0
        Me.CuadroDeTexto3.Modificado = False
        Me.CuadroDeTexto3.Name = "CuadroDeTexto3"
        Me.CuadroDeTexto3.Numerico_EsNumerico = True
        Me.CuadroDeTexto3.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto3.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto3.Obligatorio = False
        Me.CuadroDeTexto3.ParametroID = 0
        Me.CuadroDeTexto3.Size = New System.Drawing.Size(93, 21)
        Me.CuadroDeTexto3.TabIndex = 7
        Me.CuadroDeTexto3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto3.ValorMaximo = 0.0!
        Me.CuadroDeTexto3.ValorMinimo = 0.0!
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.Label5)
        Me.Panel15.Controls.Add(Me.Button1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 0)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(93, 26)
        Me.Panel15.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(65, 26)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Aceite"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.Button1.Location = New System.Drawing.Point(65, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(28, 26)
        Me.Button1.TabIndex = 1
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel9
        '
        Me.Panel9.Controls.Add(Me.CuadroDeTexto4)
        Me.Panel9.Controls.Add(Me.CuadroDeTexto5)
        Me.Panel9.Controls.Add(Me.CuadroDeTexto6)
        Me.Panel9.Controls.Add(Me.Panel14)
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel9.Location = New System.Drawing.Point(0, 0)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Padding = New System.Windows.Forms.Padding(0, 0, 5, 0)
        Me.Panel9.Size = New System.Drawing.Size(108, 95)
        Me.Panel9.TabIndex = 16
        '
        'CuadroDeTexto4
        '
        Me.CuadroDeTexto4.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto4.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto4.EsUnicoCampo = ""
        Me.CuadroDeTexto4.EsUnicoCampoID = ""
        Me.CuadroDeTexto4.EsUnicoID = 0
        Me.CuadroDeTexto4.EsUnicoTabla = ""
        Me.CuadroDeTexto4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto4.Location = New System.Drawing.Point(0, 68)
        Me.CuadroDeTexto4.MaxLength = 500
        Me.CuadroDeTexto4.Minimo = 0
        Me.CuadroDeTexto4.Modificado = False
        Me.CuadroDeTexto4.Name = "CuadroDeTexto4"
        Me.CuadroDeTexto4.Numerico_EsNumerico = True
        Me.CuadroDeTexto4.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto4.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto4.Obligatorio = False
        Me.CuadroDeTexto4.ParametroID = 0
        Me.CuadroDeTexto4.Size = New System.Drawing.Size(103, 21)
        Me.CuadroDeTexto4.TabIndex = 16
        Me.CuadroDeTexto4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto4.ValorMaximo = 0.0!
        Me.CuadroDeTexto4.ValorMinimo = 0.0!
        '
        'CuadroDeTexto5
        '
        Me.CuadroDeTexto5.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto5.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto5.EsUnicoCampo = ""
        Me.CuadroDeTexto5.EsUnicoCampoID = ""
        Me.CuadroDeTexto5.EsUnicoID = 0
        Me.CuadroDeTexto5.EsUnicoTabla = ""
        Me.CuadroDeTexto5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto5.Location = New System.Drawing.Point(0, 47)
        Me.CuadroDeTexto5.MaxLength = 500
        Me.CuadroDeTexto5.Minimo = 0
        Me.CuadroDeTexto5.Modificado = False
        Me.CuadroDeTexto5.Name = "CuadroDeTexto5"
        Me.CuadroDeTexto5.Numerico_EsNumerico = True
        Me.CuadroDeTexto5.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto5.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto5.Obligatorio = False
        Me.CuadroDeTexto5.ParametroID = 0
        Me.CuadroDeTexto5.Size = New System.Drawing.Size(103, 21)
        Me.CuadroDeTexto5.TabIndex = 12
        Me.CuadroDeTexto5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto5.ValorMaximo = 0.0!
        Me.CuadroDeTexto5.ValorMinimo = 0.0!
        '
        'CuadroDeTexto6
        '
        Me.CuadroDeTexto6.BackColor = System.Drawing.SystemColors.Window
        Me.CuadroDeTexto6.Dock = System.Windows.Forms.DockStyle.Top
        Me.CuadroDeTexto6.EsUnicoCampo = ""
        Me.CuadroDeTexto6.EsUnicoCampoID = ""
        Me.CuadroDeTexto6.EsUnicoID = 0
        Me.CuadroDeTexto6.EsUnicoTabla = ""
        Me.CuadroDeTexto6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CuadroDeTexto6.Location = New System.Drawing.Point(0, 26)
        Me.CuadroDeTexto6.MaxLength = 500
        Me.CuadroDeTexto6.Minimo = 0
        Me.CuadroDeTexto6.Modificado = False
        Me.CuadroDeTexto6.Name = "CuadroDeTexto6"
        Me.CuadroDeTexto6.Numerico_EsNumerico = True
        Me.CuadroDeTexto6.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto6.Numerico_SeparadorMiles = True
        Me.CuadroDeTexto6.Obligatorio = False
        Me.CuadroDeTexto6.ParametroID = 0
        Me.CuadroDeTexto6.Size = New System.Drawing.Size(103, 21)
        Me.CuadroDeTexto6.TabIndex = 8
        Me.CuadroDeTexto6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CuadroDeTexto6.ValorMaximo = 0.0!
        Me.CuadroDeTexto6.ValorMinimo = 0.0!
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.Label6)
        Me.Panel14.Controls.Add(Me.Button2)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel14.Location = New System.Drawing.Point(0, 0)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(103, 26)
        Me.Panel14.TabIndex = 16
        '
        'Label6
        '
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 26)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Vinagre"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button2
        '
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.Button2.Location = New System.Drawing.Point(75, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(28, 26)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.Label2)
        Me.Panel11.Controls.Add(Me.Label3)
        Me.Panel11.Controls.Add(Me.Label4)
        Me.Panel11.Controls.Add(Me.Panel13)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel11.Location = New System.Drawing.Point(3, 16)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(132, 95)
        Me.Panel11.TabIndex = 18
        '
        'Label2
        '
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 21)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Monodosis restantes:"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 21)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Monodosis asignadas:"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label4.Location = New System.Drawing.Point(0, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 21)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Monodosis envasadas:"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel13.Location = New System.Drawing.Point(0, 0)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(132, 26)
        Me.Panel13.TabIndex = 15
        '
        'gpbCantidades
        '
        Me.gpbCantidades.Controls.Add(Me.lblLitrosEnvasados)
        Me.gpbCantidades.Controls.Add(Me.txtCantidadEnvasada)
        Me.gpbCantidades.Controls.Add(Me.txtCantidadAsignada)
        Me.gpbCantidades.Controls.Add(Me.Label1)
        Me.gpbCantidades.Controls.Add(Me.lblLitrosLote)
        Me.gpbCantidades.Controls.Add(Me.txtCantidadRestante)
        Me.gpbCantidades.Dock = System.Windows.Forms.DockStyle.Left
        Me.gpbCantidades.Location = New System.Drawing.Point(0, 0)
        Me.gpbCantidades.Name = "gpbCantidades"
        Me.gpbCantidades.Size = New System.Drawing.Size(209, 114)
        Me.gpbCantidades.TabIndex = 0
        Me.gpbCantidades.TabStop = False
        Me.gpbCantidades.Text = "Cantidades"
        '
        'gpbMovimientos
        '
        Me.gpbMovimientos.Controls.Add(Me.dgvGrilla)
        Me.gpbMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.gpbMovimientos.Name = "gpbMovimientos"
        Me.gpbMovimientos.Size = New System.Drawing.Size(881, 298)
        Me.gpbMovimientos.TabIndex = 12
        Me.gpbMovimientos.TabStop = False
        Me.gpbMovimientos.Text = "Lotes a generar."
        '
        'gpbMermas
        '
        Me.gpbMermas.Controls.Add(Me.dgvMermas)
        Me.gpbMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpbMermas.Location = New System.Drawing.Point(0, 0)
        Me.gpbMermas.Name = "gpbMermas"
        Me.gpbMermas.Size = New System.Drawing.Size(881, 325)
        Me.gpbMermas.TabIndex = 13
        Me.gpbMermas.TabStop = False
        Me.gpbMermas.Text = "Mermas"
        '
        'dgvMermas
        '
        Me.dgvMermas.AllowUserToAddRows = False
        Me.dgvMermas.AllowUserToDeleteRows = False
        Me.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMermas.Location = New System.Drawing.Point(3, 16)
        Me.dgvMermas.MultiSelect = False
        Me.dgvMermas.Name = "dgvMermas"
        Me.dgvMermas.ReadOnly = True
        Me.dgvMermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMermas.Size = New System.Drawing.Size(875, 306)
        Me.dgvMermas.TabIndex = 3
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 150)
        Me.Panel1.TabIndex = 14
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.gpbMonodosis)
        Me.Panel4.Controls.Add(Me.Panel7)
        Me.Panel4.Controls.Add(Me.gpbCantidades)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(33, 26)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(881, 124)
        Me.Panel4.TabIndex = 15
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.butGenerarTrasiegos)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel7.Location = New System.Drawing.Point(209, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(200, 114)
        Me.Panel7.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(0, 114)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(881, 10)
        Me.Panel6.TabIndex = 7
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.lTrasiegos)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(33, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(881, 26)
        Me.Panel5.TabIndex = 9
        '
        'lTrasiegos
        '
        Me.lTrasiegos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lTrasiegos.AutoSize = True
        Me.lTrasiegos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lTrasiegos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lTrasiegos.Location = New System.Drawing.Point(325, 6)
        Me.lTrasiegos.Name = "lTrasiegos"
        Me.lTrasiegos.Size = New System.Drawing.Size(197, 13)
        Me.lTrasiegos.TabIndex = 0
        Me.lTrasiegos.Text = "Se han generado los movimientos"
        Me.lTrasiegos.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(33, 150)
        Me.Panel3.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(914, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(32, 150)
        Me.Panel2.TabIndex = 7
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Panel22)
        Me.Panel17.Controls.Add(Me.Panel21)
        Me.Panel17.Controls.Add(Me.Panel18)
        Me.Panel17.Controls.Add(Me.Panel19)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel17.Location = New System.Drawing.Point(0, 175)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(946, 646)
        Me.Panel17.TabIndex = 15
        '
        'Panel22
        '
        Me.Panel22.Controls.Add(Me.SplitContainer1)
        Me.Panel22.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel22.Location = New System.Drawing.Point(33, 0)
        Me.Panel22.Name = "Panel22"
        Me.Panel22.Size = New System.Drawing.Size(881, 627)
        Me.Panel22.TabIndex = 14
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gpbMovimientos)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gpbMermas)
        Me.SplitContainer1.Size = New System.Drawing.Size(881, 627)
        Me.SplitContainer1.SplitterDistance = 298
        Me.SplitContainer1.TabIndex = 14
        '
        'Panel21
        '
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel21.Location = New System.Drawing.Point(33, 627)
        Me.Panel21.Name = "Panel21"
        Me.Panel21.Size = New System.Drawing.Size(881, 19)
        Me.Panel21.TabIndex = 3
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel18.Location = New System.Drawing.Point(0, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(33, 646)
        Me.Panel18.TabIndex = 0
        '
        'Panel19
        '
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel19.Location = New System.Drawing.Point(914, 0)
        Me.Panel19.Name = "Panel19"
        Me.Panel19.Size = New System.Drawing.Size(32, 646)
        Me.Panel19.TabIndex = 1
        '
        'frmEnvasadosProductosArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(946, 821)
        Me.Controls.Add(Me.Panel17)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmEnvasadosProductosArticulos"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel17, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbMonodosis.ResumeLayout(False)
        Me.Panel12.ResumeLayout(False)
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.Panel16.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.gpbCantidades.ResumeLayout(False)
        Me.gpbCantidades.PerformLayout()
        Me.gpbMovimientos.ResumeLayout(False)
        Me.gpbMermas.ResumeLayout(False)
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel7.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel17.ResumeLayout(False)
        Me.Panel22.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents dgvGrilla As System.Windows.Forms.DataGridView
   Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtCantidadRestante As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLitrosLote As System.Windows.Forms.Label
    Private WithEvents txtCantidadAsignada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLitrosEnvasados As System.Windows.Forms.Label
    Private WithEvents txtCantidadEnvasada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butGenerarTrasiegos As System.Windows.Forms.Button
    Private WithEvents gpbMonodosis As System.Windows.Forms.GroupBox
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto7 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto8 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto9 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto4 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto5 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CuadroDeTexto6 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto1 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto2 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto3 As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents gpbCantidades As System.Windows.Forms.GroupBox
   Private WithEvents gpbMovimientos As System.Windows.Forms.GroupBox
   Private WithEvents gpbMermas As System.Windows.Forms.GroupBox
   Private WithEvents dgvMermas As System.Windows.Forms.DataGridView
   Private WithEvents Panel12 As System.Windows.Forms.Panel
   Private WithEvents Panel10 As System.Windows.Forms.Panel
   Private WithEvents Panel16 As System.Windows.Forms.Panel
   Private WithEvents Panel8 As System.Windows.Forms.Panel
   Private WithEvents Panel15 As System.Windows.Forms.Panel
   Private WithEvents Panel9 As System.Windows.Forms.Panel
   Private WithEvents Panel14 As System.Windows.Forms.Panel
   Private WithEvents Panel11 As System.Windows.Forms.Panel
   Private WithEvents Panel13 As System.Windows.Forms.Panel
   Private WithEvents Panel1 As System.Windows.Forms.Panel
   Private WithEvents Panel4 As System.Windows.Forms.Panel
   Private WithEvents Panel7 As System.Windows.Forms.Panel
   Private WithEvents Panel6 As System.Windows.Forms.Panel
   Private WithEvents Panel5 As System.Windows.Forms.Panel
   Private WithEvents Panel3 As System.Windows.Forms.Panel
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents Panel17 As System.Windows.Forms.Panel
   Private WithEvents Panel21 As System.Windows.Forms.Panel
   Private WithEvents Panel19 As System.Windows.Forms.Panel
   Private WithEvents Panel18 As System.Windows.Forms.Panel
   Private WithEvents Panel22 As System.Windows.Forms.Panel
   Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
   Private WithEvents lTrasiegos As System.Windows.Forms.Label

End Class
