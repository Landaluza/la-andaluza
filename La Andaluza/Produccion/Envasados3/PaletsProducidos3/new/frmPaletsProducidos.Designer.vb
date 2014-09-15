<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaletsProducidos
    Inherits BasesParaCompatibilidad.GridSimpleForm

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
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpPicos = New System.Windows.Forms.TabPage()
        Me.dgvPicos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripCompletar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripMostrar = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripOcultar = New System.Windows.Forms.ToolStripButton()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tpPicos.SuspendLayout()
        CType(Me.dgvPicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1113, 542)
        Me.SplitContainer1.SplitterDistance = 340
        Me.SplitContainer1.TabIndex = 13
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpPicos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1113, 198)
        Me.TabControl1.TabIndex = 0
        '
        'tpPicos
        '
        Me.tpPicos.Controls.Add(Me.dgvPicos)
        Me.tpPicos.Controls.Add(Me.ToolStrip1)
        Me.tpPicos.Location = New System.Drawing.Point(4, 25)
        Me.tpPicos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpPicos.Name = "tpPicos"
        Me.tpPicos.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpPicos.Size = New System.Drawing.Size(1105, 169)
        Me.tpPicos.TabIndex = 0
        Me.tpPicos.Text = "Picos"
        Me.tpPicos.UseVisualStyleBackColor = True
        '
        'dgvPicos
        '
        Me.dgvPicos.AllowUserToAddRows = False
        Me.dgvPicos.AllowUserToDeleteRows = False
        Me.dgvPicos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvPicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPicos.Location = New System.Drawing.Point(3, 27)
        Me.dgvPicos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvPicos.MultiSelect = False
        Me.dgvPicos.Name = "dgvPicos"
        Me.dgvPicos.ReadOnly = True
        Me.dgvPicos.RowHeadersVisible = False
        Me.dgvPicos.RowTemplate.Height = 24
        Me.dgvPicos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPicos.Size = New System.Drawing.Size(1099, 140)
        Me.dgvPicos.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripCompletar, Me.ToolStripMostrar, Me.ToolStripOcultar})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1099, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripCompletar
        '
        Me.ToolStripCompletar.Image = Global.La_Andaluza.My.Resources.Resources.package_add
        Me.ToolStripCompletar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripCompletar.Name = "ToolStripCompletar"
        Me.ToolStripCompletar.Size = New System.Drawing.Size(94, 22)
        Me.ToolStripCompletar.Text = "Completar"
        '
        'ToolStripMostrar
        '
        Me.ToolStripMostrar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripMostrar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripMostrar.Enabled = False
        Me.ToolStripMostrar.Image = Global.La_Andaluza.My.Resources.Resources.arrow_up_16
        Me.ToolStripMostrar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripMostrar.Name = "ToolStripMostrar"
        Me.ToolStripMostrar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripMostrar.Text = "mostrar panel de picos"
        '
        'ToolStripOcultar
        '
        Me.ToolStripOcultar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripOcultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripOcultar.Image = Global.La_Andaluza.My.Resources.Resources.arrow_down_16
        Me.ToolStripOcultar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripOcultar.Name = "ToolStripOcultar"
        Me.ToolStripOcultar.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripOcultar.Text = "ToolStripButton2"
        Me.ToolStripOcultar.ToolTipText = "Ocultar panel de picos"
        '
        'frmPaletsProducidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1113, 567)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmPaletsProducidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PaletsProducidos"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tpPicos.ResumeLayout(False)
        Me.tpPicos.PerformLayout()
        CType(Me.dgvPicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpPicos As System.Windows.Forms.TabPage
    Private WithEvents dgvPicos As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents ToolStripCompletar As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripMostrar As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripOcultar As System.Windows.Forms.ToolStripButton    


End Class
