Namespace Proveedores
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAvisosPedidos))
            Me.cboproveedor = New System.Windows.Forms.ComboBox()
            Me.cboarticulo = New System.Windows.Forms.ComboBox()
            Me.chbLeido = New System.Windows.Forms.CheckBox()
            Me.txtCabecera = New System.Windows.Forms.TextBox()
            Me.txtDetalle = New System.Windows.Forms.TextBox()
            Me.lblId_proveedor = New System.Windows.Forms.Label()
            Me.lblId_articulo = New System.Windows.Forms.Label()
            Me.lblLeido = New System.Windows.Forms.Label()
            Me.lblCabecera = New System.Windows.Forms.Label()
            Me.lblDetalle = New System.Windows.Forms.Label()
            Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
            Me.chbProveedor = New System.Windows.Forms.CheckBox()
            Me.chbArticulo = New System.Windows.Forms.CheckBox()
            Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
            Me.Label1 = New System.Windows.Forms.Label()
            CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.tlpMiddle.SuspendLayout()
            Me.SuspendLayout()
            '
            'cboproveedor
            '
            Me.cboproveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
            Me.cboproveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboproveedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cboproveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboproveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboproveedor.Location = New System.Drawing.Point(105, 18)
            Me.cboproveedor.Name = "cboproveedor"
            Me.cboproveedor.Size = New System.Drawing.Size(444, 23)
            Me.cboproveedor.TabIndex = 0
            '
            'cboarticulo
            '
            Me.cboarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
            Me.cboarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
            Me.cboarticulo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.cboarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.cboarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.cboarticulo.Location = New System.Drawing.Point(105, 47)
            Me.cboarticulo.Name = "cboarticulo"
            Me.cboarticulo.Size = New System.Drawing.Size(444, 23)
            Me.cboarticulo.TabIndex = 1
            '
            'chbLeido
            '
            Me.chbLeido.BackColor = System.Drawing.SystemColors.Control
            Me.chbLeido.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chbLeido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chbLeido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.chbLeido.Location = New System.Drawing.Point(105, 76)
            Me.chbLeido.Name = "chbLeido"
            Me.chbLeido.Size = New System.Drawing.Size(444, 21)
            Me.chbLeido.TabIndex = 2
            Me.chbLeido.UseVisualStyleBackColor = False
            '
            'txtCabecera
            '
            Me.txtCabecera.BackColor = System.Drawing.SystemColors.Window
            Me.txtCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtCabecera.Location = New System.Drawing.Point(105, 103)
            Me.txtCabecera.MaxLength = 500
            Me.txtCabecera.Name = "txtCabecera"
            Me.txtCabecera.Size = New System.Drawing.Size(444, 21)
            Me.txtCabecera.TabIndex = 3
            '
            'txtDetalle
            '
            Me.txtDetalle.BackColor = System.Drawing.SystemColors.Window
            Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
            Me.txtDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtDetalle.Location = New System.Drawing.Point(105, 130)
            Me.txtDetalle.MaxLength = 3000
            Me.txtDetalle.Multiline = True
            Me.txtDetalle.Name = "txtDetalle"
            Me.txtDetalle.Size = New System.Drawing.Size(444, 53)
            Me.txtDetalle.TabIndex = 4
            '
            'lblId_proveedor
            '
            Me.lblId_proveedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblId_proveedor.Location = New System.Drawing.Point(23, 15)
            Me.lblId_proveedor.Name = "lblId_proveedor"
            Me.lblId_proveedor.Size = New System.Drawing.Size(76, 29)
            Me.lblId_proveedor.TabIndex = 0
            Me.lblId_proveedor.Text = "Proveedor"
            Me.lblId_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblId_articulo
            '
            Me.lblId_articulo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblId_articulo.Location = New System.Drawing.Point(23, 44)
            Me.lblId_articulo.Name = "lblId_articulo"
            Me.lblId_articulo.Size = New System.Drawing.Size(76, 29)
            Me.lblId_articulo.TabIndex = 3
            Me.lblId_articulo.Text = "Articulo"
            Me.lblId_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblLeido
            '
            Me.lblLeido.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblLeido.Location = New System.Drawing.Point(23, 73)
            Me.lblLeido.Name = "lblLeido"
            Me.lblLeido.Size = New System.Drawing.Size(76, 27)
            Me.lblLeido.TabIndex = 6
            Me.lblLeido.Text = "Leido"
            Me.lblLeido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblCabecera
            '
            Me.lblCabecera.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblCabecera.Location = New System.Drawing.Point(23, 100)
            Me.lblCabecera.Name = "lblCabecera"
            Me.lblCabecera.Size = New System.Drawing.Size(76, 27)
            Me.lblCabecera.TabIndex = 7
            Me.lblCabecera.Text = "Cabecera"
            Me.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'lblDetalle
            '
            Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
            Me.lblDetalle.Location = New System.Drawing.Point(23, 127)
            Me.lblDetalle.Name = "lblDetalle"
            Me.lblDetalle.Size = New System.Drawing.Size(76, 59)
            Me.lblDetalle.TabIndex = 8
            Me.lblDetalle.Text = "Detalle"
            Me.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
            '
            'tlpMiddle
            '
            Me.tlpMiddle.AutoSize = True
            Me.tlpMiddle.ColumnCount = 8
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
            Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
            Me.tlpMiddle.Controls.Add(Me.lblId_proveedor, 1, 0)
            Me.tlpMiddle.Controls.Add(Me.cboproveedor, 2, 0)
            Me.tlpMiddle.Controls.Add(Me.lblId_articulo, 1, 1)
            Me.tlpMiddle.Controls.Add(Me.cboarticulo, 2, 1)
            Me.tlpMiddle.Controls.Add(Me.lblLeido, 1, 2)
            Me.tlpMiddle.Controls.Add(Me.chbLeido, 2, 2)
            Me.tlpMiddle.Controls.Add(Me.lblCabecera, 1, 3)
            Me.tlpMiddle.Controls.Add(Me.txtCabecera, 2, 3)
            Me.tlpMiddle.Controls.Add(Me.lblDetalle, 1, 4)
            Me.tlpMiddle.Controls.Add(Me.txtDetalle, 2, 4)
            Me.tlpMiddle.Controls.Add(Me.chbProveedor, 7, 0)
            Me.tlpMiddle.Controls.Add(Me.chbArticulo, 7, 1)
            Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 5)
            Me.tlpMiddle.Controls.Add(Me.Label1, 1, 5)
            Me.tlpMiddle.Location = New System.Drawing.Point(31, 40)
            Me.tlpMiddle.Name = "tlpMiddle"
            Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
            Me.tlpMiddle.RowCount = 6
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
            Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
            Me.tlpMiddle.Size = New System.Drawing.Size(598, 206)
            Me.tlpMiddle.TabIndex = 8
            '
            'chbProveedor
            '
            Me.chbProveedor.AutoSize = True
            Me.chbProveedor.Checked = True
            Me.chbProveedor.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chbProveedor.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chbProveedor.Location = New System.Drawing.Point(555, 18)
            Me.chbProveedor.Name = "chbProveedor"
            Me.chbProveedor.Size = New System.Drawing.Size(40, 23)
            Me.chbProveedor.TabIndex = 9
            Me.chbProveedor.UseVisualStyleBackColor = True
            '
            'chbArticulo
            '
            Me.chbArticulo.AutoSize = True
            Me.chbArticulo.Checked = True
            Me.chbArticulo.CheckState = System.Windows.Forms.CheckState.Checked
            Me.chbArticulo.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chbArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
            Me.chbArticulo.Location = New System.Drawing.Point(555, 47)
            Me.chbArticulo.Name = "chbArticulo"
            Me.chbArticulo.Size = New System.Drawing.Size(40, 23)
            Me.chbArticulo.TabIndex = 10
            Me.chbArticulo.UseVisualStyleBackColor = True
            '
            'dtpFecha
            '
            Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.Left
            Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
            Me.dtpFecha.Location = New System.Drawing.Point(105, 189)
            Me.dtpFecha.Name = "dtpFecha"
            Me.dtpFecha.Size = New System.Drawing.Size(106, 20)
            Me.dtpFecha.TabIndex = 11
            '
            'Label1
            '
            Me.Label1.AutoSize = True
            Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.Label1.Location = New System.Drawing.Point(23, 186)
            Me.Label1.Name = "Label1"
            Me.Label1.Size = New System.Drawing.Size(76, 20)
            Me.Label1.TabIndex = 12
            Me.Label1.Text = "Fecha"
            '
            'frmEntAvisosPedidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(683, 402)
            Me.Controls.Add(Me.tlpMiddle)
            Me.Cursor = System.Windows.Forms.Cursors.Default
            Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
            Me.MinimumSize = New System.Drawing.Size(406, 219)
            Me.Name = "frmEntAvisosPedidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Aviso para pedido"
            Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
            CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.tlpMiddle.ResumeLayout(False)
            Me.tlpMiddle.PerformLayout()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

        Private WithEvents cboproveedor As System.Windows.Forms.ComboBox
        Private WithEvents cboarticulo As System.Windows.Forms.ComboBox
        Private WithEvents chbLeido As System.Windows.Forms.CheckBox
        Private WithEvents txtCabecera As System.Windows.Forms.TextBox
        Private WithEvents txtDetalle As System.Windows.Forms.TextBox
        Private WithEvents lblId_proveedor As System.Windows.Forms.Label
        Private WithEvents lblId_articulo As System.Windows.Forms.Label
        Private WithEvents lblLeido As System.Windows.Forms.Label
        Private WithEvents lblCabecera As System.Windows.Forms.Label
        Private WithEvents lblDetalle As System.Windows.Forms.Label
        Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
        Private WithEvents chbProveedor As System.Windows.Forms.CheckBox
        Private WithEvents chbArticulo As System.Windows.Forms.CheckBox
        Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
        Private WithEvents Label1 As System.Windows.Forms.Label
    End Class
End Namespace
