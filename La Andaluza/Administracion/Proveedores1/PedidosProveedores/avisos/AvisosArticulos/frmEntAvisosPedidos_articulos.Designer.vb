<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAvisosPedidos_articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAvisosPedidos_articulos))
        Me.cboproveedor = New System.Windows.Forms.ComboBox()
        Me.txtCabecera = New System.Windows.Forms.TextBox()
        Me.txtDetalle = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblId_proveedor = New System.Windows.Forms.Label()
        Me.lblCabecera = New System.Windows.Forms.Label()
        Me.lblDetalle = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.chbProveedor = New System.Windows.Forms.CheckBox()
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
        Me.cboproveedor.Size = New System.Drawing.Size(514, 23)
        Me.cboproveedor.TabIndex = 0
        '
        'txtCabecera
        '
        Me.txtCabecera.BackColor = System.Drawing.SystemColors.Window
        Me.txtCabecera.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabecera.Location = New System.Drawing.Point(105, 47)
        Me.txtCabecera.MaxLength = 500
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.Size = New System.Drawing.Size(514, 21)
        Me.txtCabecera.TabIndex = 1
        '
        'txtDetalle
        '
        Me.txtDetalle.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetalle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalle.Location = New System.Drawing.Point(105, 74)
        Me.txtDetalle.MaxLength = 3000
        Me.txtDetalle.Name = "txtDetalle"
        Me.txtDetalle.Size = New System.Drawing.Size(514, 21)
        Me.txtDetalle.TabIndex = 2
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(105, 101)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 3
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
        'lblCabecera
        '
        Me.lblCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCabecera.Location = New System.Drawing.Point(23, 44)
        Me.lblCabecera.Name = "lblCabecera"
        Me.lblCabecera.Size = New System.Drawing.Size(76, 27)
        Me.lblCabecera.TabIndex = 3
        Me.lblCabecera.Text = "Cabecera"
        Me.lblCabecera.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDetalle
        '
        Me.lblDetalle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDetalle.Location = New System.Drawing.Point(23, 71)
        Me.lblDetalle.Name = "lblDetalle"
        Me.lblDetalle.Size = New System.Drawing.Size(76, 27)
        Me.lblDetalle.TabIndex = 4
        Me.lblDetalle.Text = "Detalle"
        Me.lblDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Location = New System.Drawing.Point(23, 98)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(76, 27)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 520.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_proveedor, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboproveedor, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblCabecera, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtCabecera, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblDetalle, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtDetalle, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.chbProveedor, 7, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(55, 41)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(668, 145)
        Me.tlpMiddle.TabIndex = 8
        '
        'chbProveedor
        '
        Me.chbProveedor.AutoSize = True
        Me.chbProveedor.Checked = True
        Me.chbProveedor.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbProveedor.Location = New System.Drawing.Point(625, 18)
        Me.chbProveedor.Name = "chbProveedor"
        Me.chbProveedor.Size = New System.Drawing.Size(40, 23)
        Me.chbProveedor.TabIndex = 6
        Me.chbProveedor.UseVisualStyleBackColor = True
        '
        'frmEntAvisosPedidos_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(787, 215)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(406, 190)
        Me.Name = "frmEntAvisosPedidos_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AvisosPedidos_articulos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboproveedor As System.Windows.Forms.ComboBox
    Private WithEvents txtCabecera As System.Windows.Forms.TextBox
    Private WithEvents txtDetalle As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents lblId_proveedor As System.Windows.Forms.Label
    Private WithEvents lblCabecera As System.Windows.Forms.Label
    Private WithEvents lblDetalle As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents chbProveedor As System.Windows.Forms.CheckBox
End Class
