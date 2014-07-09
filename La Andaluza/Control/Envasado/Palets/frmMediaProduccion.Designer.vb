<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMediaProduccion
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtFiltro = New System.Windows.Forms.TextBox()
        Me.btnBuscar = New System.Windows.Forms.Button()
        Me.lArticulo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbArticulo = New System.Windows.Forms.CheckBox()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.cboLinea = New System.Windows.Forms.ComboBox()
        Me.dtpEnvasado = New System.Windows.Forms.DateTimePicker()
        Me.dgvProduccion = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.txtMedia = New System.Windows.Forms.TextBox()
        Me.txtSuperior = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgvSuperior = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvSuperior, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.txtFiltro)
        Me.Panel1.Controls.Add(Me.btnBuscar)
        Me.Panel1.Controls.Add(Me.lArticulo)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chbArticulo)
        Me.Panel1.Controls.Add(Me.cboArticulo)
        Me.Panel1.Controls.Add(Me.cboLinea)
        Me.Panel1.Controls.Add(Me.dtpEnvasado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(758, 60)
        Me.Panel1.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Enabled = False
        Me.Label7.Location = New System.Drawing.Point(645, 12)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Media"
        '
        'txtFiltro
        '
        Me.txtFiltro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFiltro.Location = New System.Drawing.Point(647, 29)
        Me.txtFiltro.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFiltro.Name = "txtFiltro"
        Me.txtFiltro.Size = New System.Drawing.Size(76, 20)
        Me.txtFiltro.TabIndex = 4
        '
        'btnBuscar
        '
        Me.btnBuscar.FlatAppearance.BorderSize = 0
        Me.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBuscar.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnBuscar.Location = New System.Drawing.Point(726, 28)
        Me.btnBuscar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 19)
        Me.btnBuscar.TabIndex = 7
        Me.btnBuscar.UseVisualStyleBackColor = True
        '
        'lArticulo
        '
        Me.lArticulo.AutoSize = True
        Me.lArticulo.Enabled = False
        Me.lArticulo.Location = New System.Drawing.Point(304, 13)
        Me.lArticulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lArticulo.Name = "lArticulo"
        Me.lArticulo.Size = New System.Drawing.Size(44, 13)
        Me.lArticulo.TabIndex = 6
        Me.lArticulo.Text = "Artículo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(124, 12)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(33, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Linea"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Envasado"
        '
        'chbArticulo
        '
        Me.chbArticulo.AutoSize = True
        Me.chbArticulo.Location = New System.Drawing.Point(350, 13)
        Me.chbArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.chbArticulo.Name = "chbArticulo"
        Me.chbArticulo.Size = New System.Drawing.Size(15, 14)
        Me.chbArticulo.TabIndex = 3
        Me.chbArticulo.UseVisualStyleBackColor = True
        '
        'cboArticulo
        '
        Me.cboArticulo.Enabled = False
        Me.cboArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.Location = New System.Drawing.Point(307, 28)
        Me.cboArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(327, 21)
        Me.cboArticulo.TabIndex = 2
        '
        'cboLinea
        '
        Me.cboLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLinea.FormattingEnabled = True
        Me.cboLinea.Location = New System.Drawing.Point(127, 28)
        Me.cboLinea.Margin = New System.Windows.Forms.Padding(2)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Size = New System.Drawing.Size(169, 21)
        Me.cboLinea.TabIndex = 1
        '
        'dtpEnvasado
        '
        Me.dtpEnvasado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpEnvasado.Location = New System.Drawing.Point(28, 29)
        Me.dtpEnvasado.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpEnvasado.Name = "dtpEnvasado"
        Me.dtpEnvasado.Size = New System.Drawing.Size(89, 20)
        Me.dtpEnvasado.TabIndex = 0
        '
        'dgvProduccion
        '
        Me.dgvProduccion.AllowUserToAddRows = False
        Me.dgvProduccion.AllowUserToDeleteRows = False
        Me.dgvProduccion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvProduccion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvProduccion.Location = New System.Drawing.Point(0, 13)
        Me.dgvProduccion.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvProduccion.Name = "dgvProduccion"
        Me.dgvProduccion.ReadOnly = True
        Me.dgvProduccion.RowHeadersVisible = False
        Me.dgvProduccion.RowTemplate.Height = 24
        Me.dgvProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvProduccion.Size = New System.Drawing.Size(364, 372)
        Me.dgvProduccion.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtMedia)
        Me.Panel2.Controls.Add(Me.txtSuperior)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 445)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(758, 43)
        Me.Panel2.TabIndex = 2
        '
        'txtMedia
        '
        Me.txtMedia.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtMedia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMedia.Enabled = False
        Me.txtMedia.Location = New System.Drawing.Point(667, 15)
        Me.txtMedia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtMedia.Name = "txtMedia"
        Me.txtMedia.Size = New System.Drawing.Size(76, 20)
        Me.txtMedia.TabIndex = 3
        '
        'txtSuperior
        '
        Me.txtSuperior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtSuperior.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSuperior.Enabled = False
        Me.txtSuperior.Location = New System.Drawing.Point(532, 15)
        Me.txtSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.txtSuperior.Name = "txtSuperior"
        Me.txtSuperior.Size = New System.Drawing.Size(76, 20)
        Me.txtSuperior.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(452, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Media superior"
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(628, 17)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Media"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 60)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvProduccion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvSuperior)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Size = New System.Drawing.Size(758, 385)
        Me.SplitContainer1.SplitterDistance = 364
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label5.Location = New System.Drawing.Point(0, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Produccion del dia"
        '
        'dgvSuperior
        '
        Me.dgvSuperior.AllowUserToAddRows = False
        Me.dgvSuperior.AllowUserToDeleteRows = False
        Me.dgvSuperior.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvSuperior.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSuperior.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSuperior.Location = New System.Drawing.Point(0, 13)
        Me.dgvSuperior.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvSuperior.Name = "dgvSuperior"
        Me.dgvSuperior.ReadOnly = True
        Me.dgvSuperior.RowHeadersVisible = False
        Me.dgvSuperior.RowTemplate.Height = 24
        Me.dgvSuperior.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSuperior.Size = New System.Drawing.Size(391, 372)
        Me.dgvSuperior.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label6.Location = New System.Drawing.Point(0, 0)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(101, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Produccion superior"
        '
        'frmMediaProduccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(758, 488)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmMediaProduccion"
        Me.Text = "frmMediaProduccion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvSuperior, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgvProduccion As System.Windows.Forms.DataGridView
    Private WithEvents btnBuscar As System.Windows.Forms.Button
    Private WithEvents lArticulo As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents chbArticulo As System.Windows.Forms.CheckBox
    Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Private WithEvents cboLinea As System.Windows.Forms.ComboBox
    Private WithEvents dtpEnvasado As System.Windows.Forms.DateTimePicker
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dgvSuperior As System.Windows.Forms.DataGridView
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtMedia As System.Windows.Forms.TextBox
    Private WithEvents txtSuperior As System.Windows.Forms.TextBox
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtFiltro As System.Windows.Forms.TextBox
End Class
