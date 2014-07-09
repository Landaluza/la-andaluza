<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPendientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPendientes))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chbTerminada = New System.Windows.Forms.CheckBox()
        Me.cboTipoPendiente = New System.Windows.Forms.ComboBox()
        Me.butVerTipoPendiente = New System.Windows.Forms.Button()
        Me.butAddTipoPendiente = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedor = New System.Windows.Forms.Button()
        Me.butAddProveedor = New System.Windows.Forms.Button()
        Me.txtNumeroDocumento = New System.Windows.Forms.TextBox()
        Me.dtpFechaDocumento = New System.Windows.Forms.DateTimePicker()
        Me.txtRutaDocumento = New System.Windows.Forms.TextBox()
        Me.butRutaDocumento = New System.Windows.Forms.Button()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.butVerResponsableID = New System.Windows.Forms.Button()
        Me.butAddResponsableID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblTerminada = New System.Windows.Forms.Label()
        Me.lblTipoPendiente = New System.Windows.Forms.Label()
        Me.lblProveedor = New System.Windows.Forms.Label()
        Me.lblNumeroDocumento = New System.Windows.Forms.Label()
        Me.lblFechaDocumento = New System.Windows.Forms.Label()
        Me.lblRutaDocumento = New System.Windows.Forms.Label()
        Me.lblResponsableID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(116, 14)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(253, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(116, 42)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'chbTerminada
        '
        Me.chbTerminada.BackColor = System.Drawing.SystemColors.Control
        Me.chbTerminada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbTerminada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTerminada.Location = New System.Drawing.Point(116, 70)
        Me.chbTerminada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbTerminada.Name = "chbTerminada"
        Me.chbTerminada.Size = New System.Drawing.Size(253, 21)
        Me.chbTerminada.TabIndex = 2
        Me.chbTerminada.UseVisualStyleBackColor = False
        '
        'cboTipoPendiente
        '
        Me.cboTipoPendiente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoPendiente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoPendiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoPendiente.Location = New System.Drawing.Point(116, 95)
        Me.cboTipoPendiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoPendiente.Name = "cboTipoPendiente"
        Me.cboTipoPendiente.Size = New System.Drawing.Size(253, 23)
        Me.cboTipoPendiente.TabIndex = 3
        '
        'butVerTipoPendiente
        '
        Me.butVerTipoPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoPendiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerTipoPendiente.FlatAppearance.BorderSize = 0
        Me.butVerTipoPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoPendiente.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerTipoPendiente.Location = New System.Drawing.Point(373, 95)
        Me.butVerTipoPendiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerTipoPendiente.Name = "butVerTipoPendiente"
        Me.butVerTipoPendiente.Size = New System.Drawing.Size(18, 26)
        Me.butVerTipoPendiente.TabIndex = 4
        Me.butVerTipoPendiente.TabStop = False
        '
        'butAddTipoPendiente
        '
        Me.butAddTipoPendiente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoPendiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoPendiente.FlatAppearance.BorderSize = 0
        Me.butAddTipoPendiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoPendiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoPendiente.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoPendiente.Location = New System.Drawing.Point(395, 95)
        Me.butAddTipoPendiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddTipoPendiente.Name = "butAddTipoPendiente"
        Me.butAddTipoPendiente.Size = New System.Drawing.Size(18, 26)
        Me.butAddTipoPendiente.TabIndex = 5
        Me.butAddTipoPendiente.TabStop = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(116, 125)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(253, 23)
        Me.cboProveedor.TabIndex = 4
        '
        'butVerProveedor
        '
        Me.butVerProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerProveedor.FlatAppearance.BorderSize = 0
        Me.butVerProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedor.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerProveedor.Location = New System.Drawing.Point(373, 125)
        Me.butVerProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProveedor.Name = "butVerProveedor"
        Me.butVerProveedor.Size = New System.Drawing.Size(18, 26)
        Me.butVerProveedor.TabIndex = 7
        Me.butVerProveedor.TabStop = False
        '
        'butAddProveedor
        '
        Me.butAddProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddProveedor.FlatAppearance.BorderSize = 0
        Me.butAddProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedor.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedor.Location = New System.Drawing.Point(395, 125)
        Me.butAddProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProveedor.Name = "butAddProveedor"
        Me.butAddProveedor.Size = New System.Drawing.Size(18, 26)
        Me.butAddProveedor.TabIndex = 8
        Me.butAddProveedor.TabStop = False
        '
        'txtNumeroDocumento
        '
        Me.txtNumeroDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNumeroDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroDocumento.Location = New System.Drawing.Point(116, 155)
        Me.txtNumeroDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNumeroDocumento.MaxLength = 20
        Me.txtNumeroDocumento.Name = "txtNumeroDocumento"
        Me.txtNumeroDocumento.Size = New System.Drawing.Size(253, 21)
        Me.txtNumeroDocumento.TabIndex = 5
        '
        'dtpFechaDocumento
        '
        Me.dtpFechaDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDocumento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDocumento.Location = New System.Drawing.Point(116, 183)
        Me.dtpFechaDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaDocumento.Name = "dtpFechaDocumento"
        Me.dtpFechaDocumento.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaDocumento.TabIndex = 6
        '
        'txtRutaDocumento
        '
        Me.txtRutaDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtRutaDocumento, 4)
        Me.txtRutaDocumento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRutaDocumento.Enabled = False
        Me.txtRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaDocumento.Location = New System.Drawing.Point(116, 211)
        Me.txtRutaDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaDocumento.MaxLength = 250
        Me.txtRutaDocumento.Name = "txtRutaDocumento"
        Me.txtRutaDocumento.Size = New System.Drawing.Size(298, 21)
        Me.txtRutaDocumento.TabIndex = 7
        '
        'butRutaDocumento
        '
        Me.butRutaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butRutaDocumento.FlatAppearance.BorderSize = 0
        Me.butRutaDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaDocumento.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaDocumento.Location = New System.Drawing.Point(418, 211)
        Me.butRutaDocumento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaDocumento.Name = "butRutaDocumento"
        Me.butRutaDocumento.Size = New System.Drawing.Size(18, 24)
        Me.butRutaDocumento.TabIndex = 12
        Me.butRutaDocumento.TabStop = False
        '
        'cboResponsable
        '
        Me.cboResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboResponsable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.Location = New System.Drawing.Point(116, 239)
        Me.cboResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(253, 23)
        Me.cboResponsable.TabIndex = 8
        '
        'butVerResponsableID
        '
        Me.butVerResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerResponsableID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerResponsableID.FlatAppearance.BorderSize = 0
        Me.butVerResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerResponsableID.Location = New System.Drawing.Point(373, 239)
        Me.butVerResponsableID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerResponsableID.Name = "butVerResponsableID"
        Me.butVerResponsableID.Size = New System.Drawing.Size(18, 26)
        Me.butVerResponsableID.TabIndex = 14
        Me.butVerResponsableID.TabStop = False
        '
        'butAddResponsableID
        '
        Me.butAddResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddResponsableID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddResponsableID.FlatAppearance.BorderSize = 0
        Me.butAddResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddResponsableID.Location = New System.Drawing.Point(395, 239)
        Me.butAddResponsableID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddResponsableID.Name = "butAddResponsableID"
        Me.butAddResponsableID.Size = New System.Drawing.Size(18, 26)
        Me.butAddResponsableID.TabIndex = 15
        Me.butAddResponsableID.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(92, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Location = New System.Drawing.Point(20, 40)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(92, 28)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTerminada
        '
        Me.lblTerminada.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTerminada.Location = New System.Drawing.Point(20, 68)
        Me.lblTerminada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTerminada.Name = "lblTerminada"
        Me.lblTerminada.Size = New System.Drawing.Size(92, 25)
        Me.lblTerminada.TabIndex = 2
        Me.lblTerminada.Text = "Terminada"
        Me.lblTerminada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoPendiente
        '
        Me.lblTipoPendiente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoPendiente.Location = New System.Drawing.Point(20, 93)
        Me.lblTipoPendiente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoPendiente.Name = "lblTipoPendiente"
        Me.lblTipoPendiente.Size = New System.Drawing.Size(92, 30)
        Me.lblTipoPendiente.TabIndex = 3
        Me.lblTipoPendiente.Text = "Tipo"
        Me.lblTipoPendiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedor
        '
        Me.lblProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProveedor.Location = New System.Drawing.Point(20, 123)
        Me.lblProveedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedor.Name = "lblProveedor"
        Me.lblProveedor.Size = New System.Drawing.Size(92, 30)
        Me.lblProveedor.TabIndex = 6
        Me.lblProveedor.Text = "Proveedor"
        Me.lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumeroDocumento
        '
        Me.lblNumeroDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNumeroDocumento.Location = New System.Drawing.Point(20, 153)
        Me.lblNumeroDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNumeroDocumento.Name = "lblNumeroDocumento"
        Me.lblNumeroDocumento.Size = New System.Drawing.Size(92, 28)
        Me.lblNumeroDocumento.TabIndex = 9
        Me.lblNumeroDocumento.Text = "Nº Documento"
        Me.lblNumeroDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaDocumento
        '
        Me.lblFechaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaDocumento.Location = New System.Drawing.Point(20, 181)
        Me.lblFechaDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaDocumento.Name = "lblFechaDocumento"
        Me.lblFechaDocumento.Size = New System.Drawing.Size(92, 28)
        Me.lblFechaDocumento.TabIndex = 10
        Me.lblFechaDocumento.Text = "Fecha documento"
        Me.lblFechaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaDocumento
        '
        Me.lblRutaDocumento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRutaDocumento.Location = New System.Drawing.Point(20, 209)
        Me.lblRutaDocumento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaDocumento.Name = "lblRutaDocumento"
        Me.lblRutaDocumento.Size = New System.Drawing.Size(92, 28)
        Me.lblRutaDocumento.TabIndex = 11
        Me.lblRutaDocumento.Text = "Ruta documento"
        Me.lblRutaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResponsableID
        '
        Me.lblResponsableID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResponsableID.Location = New System.Drawing.Point(20, 237)
        Me.lblResponsableID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponsableID.Name = "lblResponsableID"
        Me.lblResponsableID.Size = New System.Drawing.Size(92, 30)
        Me.lblResponsableID.TabIndex = 13
        Me.lblResponsableID.Text = "Responsable"
        Me.lblResponsableID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblTerminada, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.chbTerminada, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblTipoPendiente, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboTipoPendiente, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoPendiente, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoPendiente, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblProveedor, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboProveedor, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerProveedor, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddProveedor, 4, 4)
        Me.tlpMiddle.Controls.Add(Me.lblNumeroDocumento, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtNumeroDocumento, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblFechaDocumento, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaDocumento, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblRutaDocumento, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtRutaDocumento, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.butRutaDocumento, 6, 7)
        Me.tlpMiddle.Controls.Add(Me.lblResponsableID, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.cboResponsable, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.butVerResponsableID, 3, 8)
        Me.tlpMiddle.Controls.Add(Me.butAddResponsableID, 4, 8)
        Me.tlpMiddle.Location = New System.Drawing.Point(157, 34)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 10
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(460, 282)
        Me.tlpMiddle.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControl1.Location = New System.Drawing.Point(0, 321)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(834, 243)
        Me.TabControl1.TabIndex = 9
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabPage2.Size = New System.Drawing.Size(826, 217)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Gestiones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'frmEntPendientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(834, 564)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(419, 315)
        Me.Name = "frmEntPendientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Pendientes"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents chbTerminada As System.Windows.Forms.CheckBox
    Private WithEvents cboTipoPendiente As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoPendiente As System.Windows.Forms.Button
    Private WithEvents butAddTipoPendiente As System.Windows.Forms.Button
    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerProveedor As System.Windows.Forms.Button
    Private WithEvents butAddProveedor As System.Windows.Forms.Button
    Private WithEvents txtNumeroDocumento As System.Windows.Forms.TextBox
    Private WithEvents dtpFechaDocumento As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRutaDocumento As System.Windows.Forms.TextBox
    Private WithEvents butRutaDocumento As System.Windows.Forms.Button
    Private WithEvents cboResponsable As System.Windows.Forms.ComboBox
    Private WithEvents butVerResponsableID As System.Windows.Forms.Button
    Private WithEvents butAddResponsableID As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblTerminada As System.Windows.Forms.Label
    Private WithEvents lblTipoPendiente As System.Windows.Forms.Label
    Private WithEvents lblProveedor As System.Windows.Forms.Label
    Private WithEvents lblNumeroDocumento As System.Windows.Forms.Label
    Private WithEvents lblFechaDocumento As System.Windows.Forms.Label
    Private WithEvents lblRutaDocumento As System.Windows.Forms.Label
    Private WithEvents lblResponsableID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents TabPage2 As System.Windows.Forms.TabPage
End Class
