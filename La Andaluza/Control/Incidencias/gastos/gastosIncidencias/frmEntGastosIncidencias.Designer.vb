<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntGastosIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntGastosIncidencias))
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.cboconcepto = New System.Windows.Forms.ComboBox()
        Me.butVerId_concepto = New System.Windows.Forms.Button()
        Me.butAddId_concepto = New System.Windows.Forms.Button()
        Me.cbocosteConcepto = New System.Windows.Forms.ComboBox()
        Me.butAddId_costeConcepto = New System.Windows.Forms.Button()
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.butVerId_proveedor = New System.Windows.Forms.Button()
        Me.butAddId_proveedor = New System.Windows.Forms.Button()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.cbocliente = New System.Windows.Forms.ComboBox()
        Me.butVerId_cliente = New System.Windows.Forms.Button()
        Me.butAddId_cliente = New System.Windows.Forms.Button()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblId_concepto = New System.Windows.Forms.Label()
        Me.lblId_costeConcepto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.btnActualizarCoste = New System.Windows.Forms.Button()
        Me.gpCAusante = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.btnVerCosteConvepto = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.gpCAusante.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(97, 18)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(395, 21)
        Me.txtCantidad.TabIndex = 1
        '
        'cboconcepto
        '
        Me.cboconcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboconcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboconcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboconcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboconcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboconcepto.Location = New System.Drawing.Point(97, 45)
        Me.cboconcepto.Name = "cboconcepto"
        Me.cboconcepto.Size = New System.Drawing.Size(395, 23)
        Me.cboconcepto.TabIndex = 2
        '
        'butVerId_concepto
        '
        Me.butVerId_concepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_concepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_concepto.FlatAppearance.BorderSize = 0
        Me.butVerId_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_concepto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_concepto.Location = New System.Drawing.Point(498, 45)
        Me.butVerId_concepto.Name = "butVerId_concepto"
        Me.butVerId_concepto.Size = New System.Drawing.Size(26, 23)
        Me.butVerId_concepto.TabIndex = 5
        Me.butVerId_concepto.TabStop = False
        '
        'butAddId_concepto
        '
        Me.butAddId_concepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_concepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_concepto.FlatAppearance.BorderSize = 0
        Me.butAddId_concepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_concepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_concepto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_concepto.Location = New System.Drawing.Point(530, 45)
        Me.butAddId_concepto.Name = "butAddId_concepto"
        Me.butAddId_concepto.Size = New System.Drawing.Size(28, 23)
        Me.butAddId_concepto.TabIndex = 6
        Me.butAddId_concepto.TabStop = False
        '
        'cbocosteConcepto
        '
        Me.cbocosteConcepto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbocosteConcepto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbocosteConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbocosteConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocosteConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocosteConcepto.Location = New System.Drawing.Point(97, 74)
        Me.cbocosteConcepto.Name = "cbocosteConcepto"
        Me.cbocosteConcepto.Size = New System.Drawing.Size(395, 23)
        Me.cbocosteConcepto.TabIndex = 3
        '
        'butAddId_costeConcepto
        '
        Me.butAddId_costeConcepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_costeConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_costeConcepto.FlatAppearance.BorderSize = 0
        Me.butAddId_costeConcepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_costeConcepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_costeConcepto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_costeConcepto.Location = New System.Drawing.Point(530, 74)
        Me.butAddId_costeConcepto.Name = "butAddId_costeConcepto"
        Me.butAddId_costeConcepto.Size = New System.Drawing.Size(28, 28)
        Me.butAddId_costeConcepto.TabIndex = 9
        Me.butAddId_costeConcepto.TabStop = False
        '
        'cboproveedor
        '
        Me.cboproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboproveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproveedor.Location = New System.Drawing.Point(86, 3)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(399, 23)
        Me.cboproveedor.TabIndex = 4
        '
        'butVerId_proveedor
        '
        Me.butVerId_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_proveedor.FlatAppearance.BorderSize = 0
        Me.butVerId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_proveedor.Location = New System.Drawing.Point(491, 3)
        Me.butVerId_proveedor.Name = "butVerId_proveedor"
        Me.butVerId_proveedor.Size = New System.Drawing.Size(25, 28)
        Me.butVerId_proveedor.TabIndex = 11
        Me.butVerId_proveedor.TabStop = False
        '
        'butAddId_proveedor
        '
        Me.butAddId_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_proveedor.Location = New System.Drawing.Point(522, 3)
        Me.butAddId_proveedor.Name = "butAddId_proveedor"
        Me.butAddId_proveedor.Size = New System.Drawing.Size(24, 28)
        Me.butAddId_proveedor.TabIndex = 12
        Me.butAddId_proveedor.TabStop = False
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(86, 37)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(399, 23)
        Me.cboempleado.TabIndex = 5
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_empleado.Location = New System.Drawing.Point(491, 37)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(25, 28)
        Me.butVerId_empleado.TabIndex = 14
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(522, 37)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(24, 28)
        Me.butAddId_empleado.TabIndex = 15
        Me.butAddId_empleado.TabStop = False
        '
        'cbocliente
        '
        Me.cbocliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbocliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbocliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocliente.Location = New System.Drawing.Point(86, 71)
        Me.cbocliente.Name = "cbocliente"
        Me.cbocliente.Size = New System.Drawing.Size(399, 23)
        Me.cbocliente.TabIndex = 6
        '
        'butVerId_cliente
        '
        Me.butVerId_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_cliente.FlatAppearance.BorderSize = 0
        Me.butVerId_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_cliente.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_cliente.Location = New System.Drawing.Point(491, 71)
        Me.butVerId_cliente.Name = "butVerId_cliente"
        Me.butVerId_cliente.Size = New System.Drawing.Size(25, 38)
        Me.butVerId_cliente.TabIndex = 17
        Me.butVerId_cliente.TabStop = False
        '
        'butAddId_cliente
        '
        Me.butAddId_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_cliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_cliente.FlatAppearance.BorderSize = 0
        Me.butAddId_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_cliente.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_cliente.Location = New System.Drawing.Point(522, 71)
        Me.butAddId_cliente.Name = "butAddId_cliente"
        Me.butAddId_cliente.Size = New System.Drawing.Size(24, 38)
        Me.butAddId_cliente.TabIndex = 18
        Me.butAddId_cliente.TabStop = False
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Location = New System.Drawing.Point(3, 15)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(88, 27)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_concepto
        '
        Me.lblId_concepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_concepto.Location = New System.Drawing.Point(3, 42)
        Me.lblId_concepto.Name = "lblId_concepto"
        Me.lblId_concepto.Size = New System.Drawing.Size(88, 29)
        Me.lblId_concepto.TabIndex = 4
        Me.lblId_concepto.Text = "Concepto"
        Me.lblId_concepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_costeConcepto
        '
        Me.lblId_costeConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_costeConcepto.Location = New System.Drawing.Point(3, 71)
        Me.lblId_costeConcepto.Name = "lblId_costeConcepto"
        Me.lblId_costeConcepto.Size = New System.Drawing.Size(88, 34)
        Me.lblId_costeConcepto.TabIndex = 7
        Me.lblId_costeConcepto.Text = "Coste concepto"
        Me.lblId_costeConcepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 401.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.tlpMiddle.Controls.Add(Me.btnActualizarCoste, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 0, 1)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.lblId_concepto, 0, 2)
        Me.tlpMiddle.Controls.Add(Me.cboconcepto, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerId_concepto, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddId_concepto, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.lblId_costeConcepto, 0, 3)
        Me.tlpMiddle.Controls.Add(Me.cbocosteConcepto, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddId_costeConcepto, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.gpCAusante, 0, 7)
        Me.tlpMiddle.Controls.Add(Me.btnVerCosteConvepto, 2, 3)
        Me.tlpMiddle.Location = New System.Drawing.Point(54, 28)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 137.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(561, 366)
        Me.tlpMiddle.TabIndex = 8
        '
        'btnActualizarCoste
        '
        Me.btnActualizarCoste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarCoste.FlatAppearance.BorderSize = 0
        Me.btnActualizarCoste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarCoste.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.btnActualizarCoste.Location = New System.Drawing.Point(97, 245)
        Me.btnActualizarCoste.Name = "btnActualizarCoste"
        Me.btnActualizarCoste.Size = New System.Drawing.Size(252, 23)
        Me.btnActualizarCoste.TabIndex = 9
        Me.btnActualizarCoste.Text = "Actualizar el coste del concepto al actual"
        Me.btnActualizarCoste.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnActualizarCoste.UseVisualStyleBackColor = True
        '
        'gpCAusante
        '
        Me.tlpMiddle.SetColumnSpan(Me.gpCAusante, 4)
        Me.gpCAusante.Controls.Add(Me.TableLayoutPanel1)
        Me.gpCAusante.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gpCAusante.Location = New System.Drawing.Point(3, 108)
        Me.gpCAusante.Name = "gpCAusante"
        Me.gpCAusante.Size = New System.Drawing.Size(555, 131)
        Me.gpCAusante.TabIndex = 10
        Me.gpCAusante.TabStop = False
        Me.gpCAusante.Text = "Causante"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.12598!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 82.87402!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.rbCliente, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.rbEmpleado, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.rbProveedor, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.butAddId_proveedor, 3, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.cboproveedor, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.butAddId_empleado, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.butAddId_cliente, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.butVerId_proveedor, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.butVerId_empleado, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.butVerId_cliente, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cbocliente, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.cboempleado, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 112)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbCliente.Location = New System.Drawing.Point(3, 71)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(77, 38)
        Me.rbCliente.TabIndex = 21
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbEmpleado.Location = New System.Drawing.Point(3, 37)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(77, 28)
        Me.rbEmpleado.TabIndex = 19
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbProveedor.Location = New System.Drawing.Point(3, 3)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(77, 28)
        Me.rbProveedor.TabIndex = 20
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'btnVerCosteConvepto
        '
        Me.btnVerCosteConvepto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerCosteConvepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnVerCosteConvepto.FlatAppearance.BorderSize = 0
        Me.btnVerCosteConvepto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerCosteConvepto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerCosteConvepto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.btnVerCosteConvepto.Location = New System.Drawing.Point(498, 74)
        Me.btnVerCosteConvepto.Name = "btnVerCosteConvepto"
        Me.btnVerCosteConvepto.Size = New System.Drawing.Size(26, 28)
        Me.btnVerCosteConvepto.TabIndex = 12
        Me.btnVerCosteConvepto.TabStop = False
        '
        'frmEntGastosIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.ClientSize = New System.Drawing.Size(669, 398)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(448, 254)
        Me.Name = "frmEntGastosIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GastosIncidencias"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource,System.ComponentModel.ISupportInitialize).EndInit
        Me.tlpMiddle.ResumeLayout(false)
        Me.tlpMiddle.PerformLayout
        Me.gpCAusante.ResumeLayout(false)
        Me.TableLayoutPanel1.ResumeLayout(false)
        Me.TableLayoutPanel1.PerformLayout
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents cboconcepto As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_concepto As System.Windows.Forms.Button
    Private WithEvents butAddId_concepto As System.Windows.Forms.Button
    Private WithEvents cbocosteConcepto As System.Windows.Forms.ComboBox
    Private WithEvents butAddId_costeConcepto As System.Windows.Forms.Button
    Private WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_proveedor As System.Windows.Forms.Button
    Private WithEvents butAddId_proveedor As System.Windows.Forms.Button
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents cbocliente As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_cliente As System.Windows.Forms.Button
    Private WithEvents butAddId_cliente As System.Windows.Forms.Button
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblId_concepto As System.Windows.Forms.Label
    Private WithEvents lblId_costeConcepto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents btnActualizarCoste As System.Windows.Forms.Button
    Private WithEvents gpCAusante As System.Windows.Forms.GroupBox
    Private WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Private WithEvents rbEmpleado As System.Windows.Forms.RadioButton
    Private WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Private WithEvents rbCliente As System.Windows.Forms.RadioButton
    Private WithEvents btnVerCosteConvepto As System.Windows.Forms.Button
End Class
