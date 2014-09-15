<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposControlesLotesPlantilla
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposControlesLotesPlantilla))
        Me.cboTipoControl = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoControl = New System.Windows.Forms.Button()
        Me.butAddId_TipoControl = New System.Windows.Forms.Button()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoLote = New System.Windows.Forms.Button()
        Me.butAddId_TipoLote = New System.Windows.Forms.Button()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoProducto = New System.Windows.Forms.Button()
        Me.butAddId_TipoProducto = New System.Windows.Forms.Button()
        Me.cbofrecuencia = New System.Windows.Forms.ComboBox()
        Me.butVerId_frecuencia = New System.Windows.Forms.Button()
        Me.butAddId_frecuencia = New System.Windows.Forms.Button()
        Me.chbCritico = New System.Windows.Forms.CheckBox()
        Me.cboprocedimiento = New System.Windows.Forms.ComboBox()
        Me.butVerId_procedimiento = New System.Windows.Forms.Button()
        Me.butAddId_procedimiento = New System.Windows.Forms.Button()
        Me.lblId_TipoControl = New System.Windows.Forms.Label()
        Me.lblId_TipoLote = New System.Windows.Forms.Label()
        Me.lblId_TipoProducto = New System.Windows.Forms.Label()
        Me.lblId_frecuencia = New System.Windows.Forms.Label()
        Me.lblCritico = New System.Windows.Forms.Label()
        Me.lblId_procedimiento = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.btnBorrarPRocedimiento = New System.Windows.Forms.Button()
        Me.btnBorrarProducto = New System.Windows.Forms.Button()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoControl
        '
        Me.cboTipoControl.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoControl.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoControl.Location = New System.Drawing.Point(112, 14)
        Me.cboTipoControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoControl.Name = "cboTipoControl"
        Me.cboTipoControl.Size = New System.Drawing.Size(181, 23)
        Me.cboTipoControl.TabIndex = 0
        '
        'butVerId_TipoControl
        '
        Me.butVerId_TipoControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_TipoControl.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoControl.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_TipoControl.Location = New System.Drawing.Point(297, 14)
        Me.butVerId_TipoControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_TipoControl.Name = "butVerId_TipoControl"
        Me.butVerId_TipoControl.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_TipoControl.TabIndex = 1
        Me.butVerId_TipoControl.TabStop = False
        '
        'butAddId_TipoControl
        '
        Me.butAddId_TipoControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoControl.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoControl.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoControl.Location = New System.Drawing.Point(319, 14)
        Me.butAddId_TipoControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_TipoControl.Name = "butAddId_TipoControl"
        Me.butAddId_TipoControl.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_TipoControl.TabIndex = 2
        Me.butAddId_TipoControl.TabStop = False
        '
        'cboTipoLote
        '
        Me.cboTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoLote.Location = New System.Drawing.Point(112, 44)
        Me.cboTipoLote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(181, 23)
        Me.cboTipoLote.TabIndex = 1
        '
        'butVerId_TipoLote
        '
        Me.butVerId_TipoLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_TipoLote.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoLote.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_TipoLote.Location = New System.Drawing.Point(297, 44)
        Me.butVerId_TipoLote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_TipoLote.Name = "butVerId_TipoLote"
        Me.butVerId_TipoLote.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_TipoLote.TabIndex = 4
        Me.butVerId_TipoLote.TabStop = False
        '
        'butAddId_TipoLote
        '
        Me.butAddId_TipoLote.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoLote.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoLote.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoLote.Location = New System.Drawing.Point(319, 44)
        Me.butAddId_TipoLote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_TipoLote.Name = "butAddId_TipoLote"
        Me.butAddId_TipoLote.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_TipoLote.TabIndex = 5
        Me.butAddId_TipoLote.TabStop = False
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.Location = New System.Drawing.Point(112, 74)
        Me.cboTipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(181, 23)
        Me.cboTipoProducto.TabIndex = 2
        '
        'butVerId_TipoProducto
        '
        Me.butVerId_TipoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_TipoProducto.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoProducto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_TipoProducto.Location = New System.Drawing.Point(297, 74)
        Me.butVerId_TipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_TipoProducto.Name = "butVerId_TipoProducto"
        Me.butVerId_TipoProducto.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_TipoProducto.TabIndex = 7
        Me.butVerId_TipoProducto.TabStop = False
        '
        'butAddId_TipoProducto
        '
        Me.butAddId_TipoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoProducto.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoProducto.Location = New System.Drawing.Point(319, 74)
        Me.butAddId_TipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_TipoProducto.Name = "butAddId_TipoProducto"
        Me.butAddId_TipoProducto.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_TipoProducto.TabIndex = 8
        Me.butAddId_TipoProducto.TabStop = False
        '
        'cbofrecuencia
        '
        Me.cbofrecuencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbofrecuencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbofrecuencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbofrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbofrecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofrecuencia.Location = New System.Drawing.Point(112, 104)
        Me.cbofrecuencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbofrecuencia.Name = "cbofrecuencia"
        Me.cbofrecuencia.Size = New System.Drawing.Size(181, 23)
        Me.cbofrecuencia.TabIndex = 3
        '
        'butVerId_frecuencia
        '
        Me.butVerId_frecuencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_frecuencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_frecuencia.FlatAppearance.BorderSize = 0
        Me.butVerId_frecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_frecuencia.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_frecuencia.Location = New System.Drawing.Point(297, 104)
        Me.butVerId_frecuencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_frecuencia.Name = "butVerId_frecuencia"
        Me.butVerId_frecuencia.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_frecuencia.TabIndex = 10
        Me.butVerId_frecuencia.TabStop = False
        '
        'butAddId_frecuencia
        '
        Me.butAddId_frecuencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_frecuencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_frecuencia.FlatAppearance.BorderSize = 0
        Me.butAddId_frecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_frecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_frecuencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_frecuencia.Location = New System.Drawing.Point(319, 104)
        Me.butAddId_frecuencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_frecuencia.Name = "butAddId_frecuencia"
        Me.butAddId_frecuencia.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_frecuencia.TabIndex = 11
        Me.butAddId_frecuencia.TabStop = False
        '
        'chbCritico
        '
        Me.chbCritico.BackColor = System.Drawing.SystemColors.Control
        Me.chbCritico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbCritico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCritico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCritico.Location = New System.Drawing.Point(112, 134)
        Me.chbCritico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbCritico.Name = "chbCritico"
        Me.chbCritico.Size = New System.Drawing.Size(181, 21)
        Me.chbCritico.TabIndex = 4
        Me.chbCritico.UseVisualStyleBackColor = False
        '
        'cboprocedimiento
        '
        Me.cboprocedimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboprocedimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboprocedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboprocedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboprocedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprocedimiento.Location = New System.Drawing.Point(112, 159)
        Me.cboprocedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboprocedimiento.Name = "cboprocedimiento"
        Me.cboprocedimiento.Size = New System.Drawing.Size(181, 23)
        Me.cboprocedimiento.TabIndex = 5
        '
        'butVerId_procedimiento
        '
        Me.butVerId_procedimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_procedimiento.FlatAppearance.BorderSize = 0
        Me.butVerId_procedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_procedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_procedimiento.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_procedimiento.Location = New System.Drawing.Point(297, 159)
        Me.butVerId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_procedimiento.Name = "butVerId_procedimiento"
        Me.butVerId_procedimiento.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_procedimiento.TabIndex = 14
        Me.butVerId_procedimiento.TabStop = False
        '
        'butAddId_procedimiento
        '
        Me.butAddId_procedimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_procedimiento.FlatAppearance.BorderSize = 0
        Me.butAddId_procedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_procedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_procedimiento.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_procedimiento.Location = New System.Drawing.Point(319, 159)
        Me.butAddId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_procedimiento.Name = "butAddId_procedimiento"
        Me.butAddId_procedimiento.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_procedimiento.TabIndex = 15
        Me.butAddId_procedimiento.TabStop = False
        '
        'lblId_TipoControl
        '
        Me.lblId_TipoControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoControl.Location = New System.Drawing.Point(20, 12)
        Me.lblId_TipoControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_TipoControl.Name = "lblId_TipoControl"
        Me.lblId_TipoControl.Size = New System.Drawing.Size(88, 30)
        Me.lblId_TipoControl.TabIndex = 0
        Me.lblId_TipoControl.Text = "Tipo control"
        Me.lblId_TipoControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_TipoLote
        '
        Me.lblId_TipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoLote.Location = New System.Drawing.Point(20, 42)
        Me.lblId_TipoLote.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_TipoLote.Name = "lblId_TipoLote"
        Me.lblId_TipoLote.Size = New System.Drawing.Size(88, 30)
        Me.lblId_TipoLote.TabIndex = 3
        Me.lblId_TipoLote.Text = "Lote"
        Me.lblId_TipoLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_TipoProducto
        '
        Me.lblId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoProducto.Location = New System.Drawing.Point(20, 72)
        Me.lblId_TipoProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_TipoProducto.Name = "lblId_TipoProducto"
        Me.lblId_TipoProducto.Size = New System.Drawing.Size(88, 30)
        Me.lblId_TipoProducto.TabIndex = 6
        Me.lblId_TipoProducto.Text = "Producto"
        Me.lblId_TipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_frecuencia
        '
        Me.lblId_frecuencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_frecuencia.Location = New System.Drawing.Point(20, 102)
        Me.lblId_frecuencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_frecuencia.Name = "lblId_frecuencia"
        Me.lblId_frecuencia.Size = New System.Drawing.Size(88, 30)
        Me.lblId_frecuencia.TabIndex = 9
        Me.lblId_frecuencia.Text = "Frecuencia"
        Me.lblId_frecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCritico
        '
        Me.lblCritico.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCritico.Location = New System.Drawing.Point(20, 132)
        Me.lblCritico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCritico.Name = "lblCritico"
        Me.lblCritico.Size = New System.Drawing.Size(88, 25)
        Me.lblCritico.TabIndex = 12
        Me.lblCritico.Text = "Critico"
        Me.lblCritico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_procedimiento
        '
        Me.lblId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_procedimiento.Location = New System.Drawing.Point(20, 157)
        Me.lblId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_procedimiento.Name = "lblId_procedimiento"
        Me.lblId_procedimiento.Size = New System.Drawing.Size(88, 30)
        Me.lblId_procedimiento.TabIndex = 13
        Me.lblId_procedimiento.Text = "Procedimiento"
        Me.lblId_procedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 9
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoControl, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboTipoControl, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerId_TipoControl, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoControl, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoLote, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboTipoLote, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_TipoLote, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoLote, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoProducto, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboTipoProducto, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerId_TipoProducto, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoProducto, 4, 2)
        Me.tlpMiddle.Controls.Add(Me.lblId_frecuencia, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cbofrecuencia, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerId_frecuencia, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddId_frecuencia, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblCritico, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbCritico, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblId_procedimiento, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.cboprocedimiento, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.butVerId_procedimiento, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.butAddId_procedimiento, 4, 5)
        Me.tlpMiddle.Controls.Add(Me.btnBorrarPRocedimiento, 7, 5)
        Me.tlpMiddle.Controls.Add(Me.btnBorrarProducto, 7, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(40, 37)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(386, 220)
        Me.tlpMiddle.TabIndex = 8
        '
        'btnBorrarPRocedimiento
        '
        Me.btnBorrarPRocedimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarPRocedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrarPRocedimiento.FlatAppearance.BorderSize = 0
        Me.btnBorrarPRocedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarPRocedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarPRocedimiento.Image = CType(resources.GetObject("btnBorrarPRocedimiento.Image"), System.Drawing.Image)
        Me.btnBorrarPRocedimiento.Location = New System.Drawing.Point(341, 159)
        Me.btnBorrarPRocedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBorrarPRocedimiento.Name = "btnBorrarPRocedimiento"
        Me.btnBorrarPRocedimiento.Size = New System.Drawing.Size(18, 26)
        Me.btnBorrarPRocedimiento.TabIndex = 16
        Me.btnBorrarPRocedimiento.TabStop = False
        Me.MyToolTip.SetToolTip(Me.btnBorrarPRocedimiento, "no usar procedimiento")
        '
        'btnBorrarProducto
        '
        Me.btnBorrarProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBorrarProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnBorrarProducto.FlatAppearance.BorderSize = 0
        Me.btnBorrarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBorrarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBorrarProducto.Image = CType(resources.GetObject("btnBorrarProducto.Image"), System.Drawing.Image)
        Me.btnBorrarProducto.Location = New System.Drawing.Point(341, 74)
        Me.btnBorrarProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnBorrarProducto.Name = "btnBorrarProducto"
        Me.btnBorrarProducto.Size = New System.Drawing.Size(18, 26)
        Me.btnBorrarProducto.TabIndex = 17
        Me.btnBorrarProducto.TabStop = False
        Me.MyToolTip.SetToolTip(Me.btnBorrarProducto, "No usar producto")
        '
        'tlpTop
        '




        '
        'frmEntTiposControlesLotesPlantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(488, 301)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTiposControlesLotesPlantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposControlesLotesPlantilla"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboTipoControl As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoControl As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoControl As System.Windows.Forms.Button
    Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoLote As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoLote As System.Windows.Forms.Button
    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoProducto As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoProducto As System.Windows.Forms.Button
    Private WithEvents cbofrecuencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_frecuencia As System.Windows.Forms.Button
    Private WithEvents butAddId_frecuencia As System.Windows.Forms.Button
    Private WithEvents chbCritico As System.Windows.Forms.CheckBox
    Private WithEvents cboprocedimiento As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_procedimiento As System.Windows.Forms.Button
    Private WithEvents butAddId_procedimiento As System.Windows.Forms.Button
    Private WithEvents lblId_TipoControl As System.Windows.Forms.Label
    Private WithEvents lblId_TipoLote As System.Windows.Forms.Label
    Private WithEvents lblId_TipoProducto As System.Windows.Forms.Label
    Private WithEvents lblId_frecuencia As System.Windows.Forms.Label
    Private WithEvents lblCritico As System.Windows.Forms.Label
    Private WithEvents lblId_procedimiento As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

    Private WithEvents btnBorrarPRocedimiento As System.Windows.Forms.Button
    Private WithEvents btnBorrarProducto As System.Windows.Forms.Button
End Class
