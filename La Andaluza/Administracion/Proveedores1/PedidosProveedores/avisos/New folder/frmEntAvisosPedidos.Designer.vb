<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAvisosPedidos
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
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.butVerId_proveedor = New System.Windows.Forms.Button()
        Me.butAddId_proveedor = New System.Windows.Forms.Button()
        Me.cboarticulo = New System.Windows.Forms.ComboBox()
        Me.butVerId_articulo = New System.Windows.Forms.Button()
        Me.butAddId_articulo = New System.Windows.Forms.Button()
        Me.chbLeido = New System.Windows.Forms.CheckBox()
        Me.txtCabecera = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblId_proveedor = New System.Windows.Forms.Label
        Me.lblId_articulo = New System.Windows.Forms.Label
        Me.lblLeido = New System.Windows.Forms.Label
        Me.lblCabecera = New System.Windows.Forms.Label
        Me.lblDetalle = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboproveedor
        '
        Me.cboproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboproveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboproveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboproveedor.Name = "cboproveedor
        Me.cboproveedor.TabIndex = 0
        Me.cboproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboproveedor.Size = New System.Drawing.Size(200,21)
        '
        'butVerId_proveedor
        '
        Me.butVerId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_proveedor.FlatAppearance.BorderSize = 0
        Me.butVerId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_proveedor.Name = "butVerId_proveedor
        Me.butVerId_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_proveedor.TabStop = False
        Me.butVerId_proveedor.Size = New System.Drawing.Size(20, 20)
        'butAddId_proveedor
        '
        Me.butAddId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_proveedor.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddId_proveedor.Name = "butAddId_proveedor
        Me.butAddId_proveedor.TabStop = False
        Me.butAddId_proveedor.Size = New System.Drawing.Size(20, 20)
        '
        '
        'cboarticulo
        '
        Me.cboarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboarticulo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboarticulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboarticulo.Name = "cboarticulo
        Me.cboarticulo.TabIndex = 1
        Me.cboarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboarticulo.Size = New System.Drawing.Size(200,21)
        '
        'butVerId_articulo
        '
        Me.butVerId_articulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_articulo.FlatAppearance.BorderSize = 0
        Me.butVerId_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_articulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_articulo.Name = "butVerId_articulo
        Me.butVerId_articulo.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_articulo.TabStop = False
        Me.butVerId_articulo.Size = New System.Drawing.Size(20, 20)
        'butAddId_articulo
        '
        Me.butAddId_articulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_articulo.FlatAppearance.BorderSize = 0
        Me.butAddId_articulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_articulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_articulo.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddId_articulo.Name = "butAddId_articulo
        Me.butAddId_articulo.TabStop = False
        Me.butAddId_articulo.Size = New System.Drawing.Size(20, 20)
        '
        '
        'chbLeido
        '
        Me.chbLeido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbLeido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLeido.Name = "chbLeido
        Me.chbLeido.TabIndex = 2
        Me.chbLeido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbLeido.BackColor = System.Drawing.SystemColors.Control
        Me.chbLeido.UseVisualStyleBackColor = False
        Me.chbLeido.Size = New System.Drawing.Size(16,21)
        '
        'txtCabecera
        '
        Me.txtCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabecera.Name = "txtCabecera
        Me.txtCabecera.TabIndex = 3
        Me.txtCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCabecera.BackColor = System.Drawing.SystemColors.Window
        Me.txtCabecera.MaxLength = 500
        Me.txtCabecera.Size = New System.Drawing.Size(200,42)
        '
        'txtDetalle
        '
        Me.txtDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Name = "txtDetalle
        Me.txtDetalle.TabIndex = 4
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetalle.MaxLength = 3000
        Me.txtDetalle.Size = New System.Drawing.Size(200,42)
        '
        'dtpFecha
        '
        Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Name = "dtpFecha
        Me.dtpFecha.TabIndex = 5
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Size = New System.Drawing.Size(95,21)
        '
        'lblId_proveedor
        '
        Me.lblId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_proveedor.Name = "lblId_proveedor
        Me.lblId_proveedor.Text = "Proveedor
        Me.lblId_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblId_proveedor.Size = New System.Drawing.Size(76,21)
        Me.lblId_proveedor.Location = New System.Drawing.Point(20,40)
        '
        'lblId_articulo
        '
        Me.lblId_articulo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_articulo.Name = "lblId_articulo
        Me.lblId_articulo.Text = "Articulo
        Me.lblId_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblId_articulo.Size = New System.Drawing.Size(76,21)
        Me.lblId_articulo.Location = New System.Drawing.Point(20,40)
        '
        'lblLeido
        '
        Me.lblLeido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLeido.Name = "lblLeido
        Me.lblLeido.Text = "Leo
        Me.lblLeido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLeido.Size = New System.Drawing.Size(76,21)
        Me.lblLeido.Location = New System.Drawing.Point(20,40)
        '
        'lblCabecera
        '
        Me.lblCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCabecera.Name = "lblCabecera
        Me.lblCabecera.Text = "Cabecera
        Me.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCabecera.Size = New System.Drawing.Size(76,21)
        Me.lblCabecera.Location = New System.Drawing.Point(20,40)
        '
        'lblDetalle
        '
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetalle.Name = "lblDetalle
        Me.lblDetalle.Text = "Detalle
        Me.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblDetalle.Size = New System.Drawing.Size(76,21)
        Me.lblDetalle.Location = New System.Drawing.Point(20,40)
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Name = "lblFecha
        Me.lblFecha.Text = "Fecha
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFecha.Size = New System.Drawing.Size(76,21)
        Me.lblFecha.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_proveedor, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboproveedor, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerId_proveedor, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddId_proveedor, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblId_articulo, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboarticulo, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_articulo, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_articulo, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblLeido, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.chbLeido, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCabecera, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCabecera, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblDetalle, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtDetalle, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 5)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(406, 166)
        '
        '
        'frmEntAvisosPedidos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(406, 246)
        Me.MinimumSize = New System.Drawing.Size(406, 246)
        Me.Name = "frmEntAvisosPedidos
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AvisosPedidos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(406,1660)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_proveedor As System.Windows.Forms.Button
    Private WithEvents butAddId_proveedor As System.Windows.Forms.Button
    Private WithEvents cboarticulo As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_articulo As System.Windows.Forms.Button
    Private WithEvents butAddId_articulo As System.Windows.Forms.Button
    Private WithEvents chbLeido As System.Windows.Forms.CheckBox
    Private WithEvents txtCabecera As System.Windows.Forms.TextBox
    Private WithEvents txtDetalle As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents lblId_proveedor As System.Windows.Forms.Label
    Private WithEvents lblId_articulo As System.Windows.Forms.Label
    Private WithEvents lblLeido As System.Windows.Forms.Label
    Private WithEvents lblCabecera As System.Windows.Forms.Label
    Private WithEvents lblDetalle As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
