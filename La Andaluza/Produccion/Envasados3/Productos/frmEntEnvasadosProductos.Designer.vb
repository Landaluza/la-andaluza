<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEnvasadosProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEnvasadosProductos))
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.butVerProductoID = New System.Windows.Forms.Button()
        Me.butAddProductoID = New System.Windows.Forms.Button()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblProductoID = New System.Windows.Forms.Label()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFinal = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboProducto
        '
        Me.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.Location = New System.Drawing.Point(231, 14)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(181, 23)
        Me.cboProducto.TabIndex = 1
        '
        'butVerProductoID
        '
        Me.butVerProductoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProductoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerProductoID.FlatAppearance.BorderSize = 0
        Me.butVerProductoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProductoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProductoID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerProductoID.Location = New System.Drawing.Point(416, 14)
        Me.butVerProductoID.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerProductoID.Name = "butVerProductoID"
        Me.butVerProductoID.Size = New System.Drawing.Size(18, 26)
        Me.butVerProductoID.TabIndex = 4
        Me.butVerProductoID.TabStop = False
        '
        'butAddProductoID
        '
        Me.butAddProductoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProductoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddProductoID.FlatAppearance.BorderSize = 0
        Me.butAddProductoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProductoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProductoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProductoID.Location = New System.Drawing.Point(438, 14)
        Me.butAddProductoID.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddProductoID.Name = "butAddProductoID"
        Me.butAddProductoID.Size = New System.Drawing.Size(18, 26)
        Me.butAddProductoID.TabIndex = 5
        Me.butAddProductoID.TabStop = False
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(231, 44)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraInicio.TabIndex = 2
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFinal.CustomFormat = "HH:mm"
        Me.dtpHoraFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinal.Location = New System.Drawing.Point(231, 72)
        Me.dtpHoraFinal.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraFinal.TabIndex = 3
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(231, 100)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(253, 21)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblProductoID
        '
        Me.lblProductoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProductoID.Location = New System.Drawing.Point(126, 12)
        Me.lblProductoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductoID.Name = "lblProductoID"
        Me.lblProductoID.Size = New System.Drawing.Size(101, 30)
        Me.lblProductoID.TabIndex = 3
        Me.lblProductoID.Text = "Producto"
        Me.lblProductoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraInicio.Location = New System.Drawing.Point(126, 42)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(101, 28)
        Me.lblHoraInicio.TabIndex = 6
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFinal
        '
        Me.lblHoraFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraFinal.Location = New System.Drawing.Point(126, 70)
        Me.lblHoraFinal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraFinal.Name = "lblHoraFinal"
        Me.lblHoraFinal.Size = New System.Drawing.Size(101, 28)
        Me.lblHoraFinal.TabIndex = 7
        Me.lblHoraFinal.Text = "Final"
        Me.lblHoraFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(126, 98)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 28)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 124.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 169.0!))
        Me.tlpMiddle.Controls.Add(Me.lblProductoID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboProducto, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerProductoID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddProductoID, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblHoraInicio, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraInicio, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblHoraFinal, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraFinal, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(22, 11)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(655, 138)
        Me.tlpMiddle.TabIndex = 8
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tlpMiddle)
        Me.SplitContainer1.Size = New System.Drawing.Size(704, 359)
        Me.SplitContainer1.SplitterDistance = 158
        Me.SplitContainer1.SplitterWidth = 16
        Me.SplitContainer1.TabIndex = 9
        '
        'frmEntEnvasadosProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(704, 384)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(428, 212)
        Me.Name = "frmEntEnvasadosProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "EnvasadosProductos"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerProductoID As System.Windows.Forms.Button
    Private WithEvents butAddProductoID As System.Windows.Forms.Button
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblProductoID As System.Windows.Forms.Label
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFinal As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
