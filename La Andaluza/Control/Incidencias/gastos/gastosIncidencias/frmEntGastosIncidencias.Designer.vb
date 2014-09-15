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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCantidadRef = New System.Windows.Forms.TextBox()
        Me.cboMedidaProducto = New System.Windows.Forms.ComboBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
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
        Me.txtCantidad.Location = New System.Drawing.Point(97, 38)
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
        Me.cboconcepto.Location = New System.Drawing.Point(97, 65)
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
        Me.butVerId_concepto.Location = New System.Drawing.Point(498, 65)
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
        Me.butAddId_concepto.Location = New System.Drawing.Point(530, 65)
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
        Me.cbocosteConcepto.Location = New System.Drawing.Point(97, 94)
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
        Me.butAddId_costeConcepto.Location = New System.Drawing.Point(530, 94)
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
        Me.cboproveedor.Location = New System.Drawing.Point(91, 3)
        Me.cboproveedor.Name = "cboproveedor"
        Me.cboproveedor.Size = New System.Drawing.Size(392, 23)
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
        Me.butVerId_proveedor.Location = New System.Drawing.Point(489, 3)
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
        Me.butAddId_proveedor.Location = New System.Drawing.Point(520, 3)
        Me.butAddId_proveedor.Name = "butAddId_proveedor"
        Me.butAddId_proveedor.Size = New System.Drawing.Size(26, 28)
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
        Me.cboempleado.Location = New System.Drawing.Point(91, 37)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(392, 23)
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
        Me.butVerId_empleado.Location = New System.Drawing.Point(489, 37)
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
        Me.butAddId_empleado.Location = New System.Drawing.Point(520, 37)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(26, 28)
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
        Me.cbocliente.Location = New System.Drawing.Point(91, 71)
        Me.cbocliente.Name = "cbocliente"
        Me.cbocliente.Size = New System.Drawing.Size(392, 23)
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
        Me.butVerId_cliente.Location = New System.Drawing.Point(489, 71)
        Me.butVerId_cliente.Name = "butVerId_cliente"
        Me.butVerId_cliente.Size = New System.Drawing.Size(25, 30)
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
        Me.butAddId_cliente.Location = New System.Drawing.Point(520, 71)
        Me.butAddId_cliente.Name = "butAddId_cliente"
        Me.butAddId_cliente.Size = New System.Drawing.Size(26, 30)
        Me.butAddId_cliente.TabIndex = 18
        Me.butAddId_cliente.TabStop = False
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Location = New System.Drawing.Point(3, 35)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(88, 27)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_concepto
        '
        Me.lblId_concepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_concepto.Location = New System.Drawing.Point(3, 62)
        Me.lblId_concepto.Name = "lblId_concepto"
        Me.lblId_concepto.Size = New System.Drawing.Size(88, 29)
        Me.lblId_concepto.TabIndex = 4
        Me.lblId_concepto.Text = "Concepto"
        Me.lblId_concepto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_costeConcepto
        '
        Me.lblId_costeConcepto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_costeConcepto.Location = New System.Drawing.Point(3, 91)
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
        Me.tlpMiddle.Controls.Add(Me.btnActualizarCoste, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 0, 2)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.lblId_concepto, 0, 3)
        Me.tlpMiddle.Controls.Add(Me.cboconcepto, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerId_concepto, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddId_concepto, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.lblId_costeConcepto, 0, 4)
        Me.tlpMiddle.Controls.Add(Me.cbocosteConcepto, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddId_costeConcepto, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.gpCAusante, 0, 8)
        Me.tlpMiddle.Controls.Add(Me.btnVerCosteConvepto, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.Label1, 0, 10)
        Me.tlpMiddle.Controls.Add(Me.Label2, 0, 11)
        Me.tlpMiddle.Controls.Add(Me.Label3, 0, 12)
        Me.tlpMiddle.Controls.Add(Me.txtCantidadRef, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 1, 12)
        Me.tlpMiddle.Controls.Add(Me.cboMedidaProducto, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.Label4, 0, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(54, 28)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 13
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 129.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 109.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(561, 446)
        Me.tlpMiddle.TabIndex = 8
        '
        'btnActualizarCoste
        '
        Me.btnActualizarCoste.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnActualizarCoste.FlatAppearance.BorderSize = 0
        Me.btnActualizarCoste.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnActualizarCoste.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.btnActualizarCoste.Location = New System.Drawing.Point(97, 257)
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
        Me.gpCAusante.Location = New System.Drawing.Point(3, 128)
        Me.gpCAusante.Name = "gpCAusante"
        Me.gpCAusante.Size = New System.Drawing.Size(555, 123)
        Me.gpCAusante.TabIndex = 10
        Me.gpCAusante.TabStop = False
        Me.gpCAusante.Text = "Causante"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.27515!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 81.72485!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
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
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(549, 104)
        Me.TableLayoutPanel1.TabIndex = 19
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rbCliente.Location = New System.Drawing.Point(3, 71)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(82, 30)
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
        Me.rbEmpleado.Size = New System.Drawing.Size(82, 28)
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
        Me.rbProveedor.Size = New System.Drawing.Size(82, 28)
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
        Me.btnVerCosteConvepto.Location = New System.Drawing.Point(498, 94)
        Me.btnVerCosteConvepto.Name = "btnVerCosteConvepto"
        Me.btnVerCosteConvepto.Size = New System.Drawing.Size(26, 28)
        Me.btnVerCosteConvepto.TabIndex = 12
        Me.btnVerCosteConvepto.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(3, 286)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 24)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Cantidad rª"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label2.Location = New System.Drawing.Point(3, 310)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 27)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Medida"
        '
        'txtCantidadRef
        '
        Me.txtCantidadRef.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadRef.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidadRef.Location = New System.Drawing.Point(97, 289)
        Me.txtCantidadRef.Name = "txtCantidadRef"
        Me.txtCantidadRef.Size = New System.Drawing.Size(395, 20)
        Me.txtCantidadRef.TabIndex = 16
        '
        'cboMedidaProducto
        '
        Me.cboMedidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboMedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMedidaProducto.FormattingEnabled = True
        Me.cboMedidaProducto.Location = New System.Drawing.Point(97, 313)
        Me.cboMedidaProducto.Name = "cboMedidaProducto"
        Me.cboMedidaProducto.Size = New System.Drawing.Size(395, 21)
        Me.cboMedidaProducto.TabIndex = 18
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Location = New System.Drawing.Point(97, 340)
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(395, 103)
        Me.txtObservaciones.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label3.Location = New System.Drawing.Point(3, 337)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(88, 109)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Observaciones"
        '
        'dtpFecha
        '
        Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(97, 18)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(395, 20)
        Me.dtpFecha.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label4.Location = New System.Drawing.Point(3, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 20)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Fecha"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntGastosIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(669, 488)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(448, 254)
        Me.Name = "frmEntGastosIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "GastosIncidencias"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.gpCAusante.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtCantidadRef As System.Windows.Forms.TextBox
    Private WithEvents cboMedidaProducto As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
