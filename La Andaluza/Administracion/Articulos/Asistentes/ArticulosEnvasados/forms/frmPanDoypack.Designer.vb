<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanDoypack
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
        Me.Pancontenidos = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsadd = New System.Windows.Forms.ToolStripButton()
        Me.tsmod = New System.Windows.Forms.ToolStripButton()
        Me.tsdel = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboFormato = New System.Windows.Forms.ComboBox()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboSccNC = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbEnvasado = New System.Windows.Forms.CheckBox()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtEan = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnaddMarcas = New System.Windows.Forms.Button()
        Me.btnverMarcas = New System.Windows.Forms.Button()
        Me.Pancontenidos.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pancontenidos
        '
        Me.Pancontenidos.Controls.Add(Me.DataGridView1)
        Me.Pancontenidos.Controls.Add(Me.ToolStrip1)
        Me.Pancontenidos.Location = New System.Drawing.Point(12, 43)
        Me.Pancontenidos.Name = "Pancontenidos"
        Me.Pancontenidos.Size = New System.Drawing.Size(531, 246)
        Me.Pancontenidos.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(531, 221)
        Me.DataGridView1.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsadd, Me.tsmod, Me.tsdel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(531, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsadd
        '
        Me.tsadd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsadd.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsadd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsadd.Name = "tsadd"
        Me.tsadd.Size = New System.Drawing.Size(23, 22)
        Me.tsadd.Text = "Nuevo"
        '
        'tsmod
        '
        Me.tsmod.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsmod.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.tsmod.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsmod.Name = "tsmod"
        Me.tsmod.Size = New System.Drawing.Size(23, 22)
        Me.tsmod.Text = "Modificar"
        '
        'tsdel
        '
        Me.tsdel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsdel.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsdel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsdel.Name = "tsdel"
        Me.tsdel.Size = New System.Drawing.Size(23, 22)
        Me.tsdel.Text = "Eliminar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Envasado"
        '
        'cboFormato
        '
        Me.cboFormato.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboFormato.FormattingEnabled = True
        Me.cboFormato.Location = New System.Drawing.Point(73, 15)
        Me.cboFormato.Name = "cboFormato"
        Me.cboFormato.Size = New System.Drawing.Size(470, 21)
        Me.cboFormato.TabIndex = 2
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(61, 91)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(453, 21)
        Me.cboMarca.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Marca"
        '
        'cboSccNC
        '
        Me.cboSccNC.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboSccNC.FormattingEnabled = True
        Me.cboSccNC.Location = New System.Drawing.Point(427, 125)
        Me.cboSccNC.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSccNC.Name = "cboSccNC"
        Me.cboSccNC.Size = New System.Drawing.Size(126, 21)
        Me.cboSccNC.TabIndex = 12
        '
        'Label3
        '
        Me.Label3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(0, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 21)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "SSCC no coforme"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbEnvasado
        '
        Me.cbEnvasado.AutoSize = True
        Me.cbEnvasado.Checked = True
        Me.cbEnvasado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEnvasado.Location = New System.Drawing.Point(9, 18)
        Me.cbEnvasado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEnvasado.Name = "cbEnvasado"
        Me.cbEnvasado.Size = New System.Drawing.Size(15, 14)
        Me.cbEnvasado.TabIndex = 0
        Me.cbEnvasado.UseVisualStyleBackColor = True
        '
        'cboCaja
        '
        Me.cboCaja.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(61, 64)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(492, 21)
        Me.cboCaja.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 67)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(28, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Caja"
        '
        'cboProducto
        '
        Me.cboProducto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(61, 37)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(492, 21)
        Me.cboProducto.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 41)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Producto"
        '
        'txtEan
        '
        Me.txtEan.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtEan.Location = New System.Drawing.Point(61, 11)
        Me.txtEan.MaxLength = 13
        Me.txtEan.Name = "txtEan"
        Me.txtEan.Size = New System.Drawing.Size(492, 20)
        Me.txtEan.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(0, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 13)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "EAN13"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnaddMarcas)
        Me.Panel1.Controls.Add(Me.btnverMarcas)
        Me.Panel1.Controls.Add(Me.txtEan)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cboMarca)
        Me.Panel1.Controls.Add(Me.cboProducto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cboSccNC)
        Me.Panel1.Controls.Add(Me.cboCaja)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(555, 155)
        Me.Panel1.TabIndex = 13
        '
        'btnaddMarcas
        '
        Me.btnaddMarcas.FlatAppearance.BorderSize = 0
        Me.btnaddMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddMarcas.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnaddMarcas.Location = New System.Drawing.Point(536, 92)
        Me.btnaddMarcas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnaddMarcas.Name = "btnaddMarcas"
        Me.btnaddMarcas.Size = New System.Drawing.Size(18, 19)
        Me.btnaddMarcas.TabIndex = 66
        Me.btnaddMarcas.UseVisualStyleBackColor = True
        '
        'btnverMarcas
        '
        Me.btnverMarcas.FlatAppearance.BorderSize = 0
        Me.btnverMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverMarcas.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnverMarcas.Location = New System.Drawing.Point(514, 92)
        Me.btnverMarcas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnverMarcas.Name = "btnverMarcas"
        Me.btnverMarcas.Size = New System.Drawing.Size(20, 19)
        Me.btnverMarcas.TabIndex = 65
        Me.btnverMarcas.UseVisualStyleBackColor = True
        '
        'frmPanDoypack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(555, 448)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cbEnvasado)
        Me.Controls.Add(Me.cboFormato)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Pancontenidos)
        Me.Name = "frmPanDoypack"
        Me.Text = "frmPanDoypack"
        Me.Pancontenidos.ResumeLayout(False)
        Me.Pancontenidos.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboMarca As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Pancontenidos As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboFormato As System.Windows.Forms.ComboBox
    Private WithEvents cboSccNC As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cbEnvasado As System.Windows.Forms.CheckBox
    Private WithEvents cboCaja As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtEan As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnaddMarcas As System.Windows.Forms.Button
    Private WithEvents btnverMarcas As System.Windows.Forms.Button
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsadd As System.Windows.Forms.ToolStripButton
    Private WithEvents tsmod As System.Windows.Forms.ToolStripButton
    Private WithEvents tsdel As System.Windows.Forms.ToolStripButton
End Class
