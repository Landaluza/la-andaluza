<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesCargaInforme
    Inherits Windows.Forms.Form

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
        Me.components = New System.ComponentModel.Container()

        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.dgvAlbaranes = New System.Windows.Forms.DataGridView()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butExcel = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnclean = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.VerdeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RojoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtroToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BorrarCargaDePicosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.txtComentarios = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cbPicos = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtTotalPalets = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTop
        '




        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.dgv)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(10, 170)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1245, 383)
        Me.Panel1.TabIndex = 1000000002
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2
        Me.dgv.Location = New System.Drawing.Point(0, 0)
        Me.dgv.MultiSelect = False
        Me.dgv.Name = "dgv"
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgv.Size = New System.Drawing.Size(1245, 383)
        Me.dgv.TabIndex = 0
        '
        'dgvAlbaranes
        '
        Me.dgvAlbaranes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlbaranes.Location = New System.Drawing.Point(0, 19)
        Me.dgvAlbaranes.Name = "dgvAlbaranes"
        Me.dgvAlbaranes.RowTemplate.Height = 24
        Me.dgvAlbaranes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlbaranes.Size = New System.Drawing.Size(550, 131)
        Me.dgvAlbaranes.TabIndex = 1000000003
        '
        'butOK
        '
        Me.butOK.Image = Global.La_Andaluza.My.Resources.Resources.checkbox_2
        Me.butOK.Location = New System.Drawing.Point(577, 30)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(64, 45)
        Me.butOK.TabIndex = 1000000004
        Me.ToolTip1.SetToolTip(Me.butOK, "muestra el detalle de la fila seleccionada")
        Me.butOK.UseVisualStyleBackColor = True
        '
        'butExcel
        '
        Me.butExcel.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butExcel.Location = New System.Drawing.Point(577, 90)
        Me.butExcel.Name = "butExcel"
        Me.butExcel.Size = New System.Drawing.Size(64, 45)
        Me.butExcel.TabIndex = 1000000005
        Me.ToolTip1.SetToolTip(Me.butExcel, "Abre una ventana para la edicion del formato de excel")
        Me.butExcel.UseVisualStyleBackColor = True
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.IsBalloon = True
        Me.ToolTip1.ReshowDelay = 100
        '
        'btnclean
        '
        Me.btnclean.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnclean.Location = New System.Drawing.Point(660, 90)
        Me.btnclean.Name = "btnclean"
        Me.btnclean.Size = New System.Drawing.Size(61, 45)
        Me.btnclean.TabIndex = 1000000006
        Me.ToolTip1.SetToolTip(Me.btnclean, "muestra/oculta las filas seleccionadas")
        Me.btnclean.UseVisualStyleBackColor = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.VerdeToolStripMenuItem, Me.RojoToolStripMenuItem, Me.ResetToolStripMenuItem, Me.OtroToolStripMenuItem, Me.ToolStripSeparator1, Me.BorrarCargaDePicosToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(317, 120)
        '
        'VerdeToolStripMenuItem
        '
        Me.VerdeToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.package_installed_updated
        Me.VerdeToolStripMenuItem.Name = "VerdeToolStripMenuItem"
        Me.VerdeToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.VerdeToolStripMenuItem.Text = "Completar hasta maximo de kilos"
        '
        'RojoToolStripMenuItem
        '
        Me.RojoToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.package_broken
        Me.RojoToolStripMenuItem.Name = "RojoToolStripMenuItem"
        Me.RojoToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.RojoToolStripMenuItem.Text = "No cargar palets de salsa en paralelo"
        '
        'ResetToolStripMenuItem
        '
        Me.ResetToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.contrast_low
        Me.ResetToolStripMenuItem.Name = "ResetToolStripMenuItem"
        Me.ResetToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.ResetToolStripMenuItem.Text = "Reiniciar color"
        '
        'OtroToolStripMenuItem
        '
        Me.OtroToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.color_swatch
        Me.OtroToolStripMenuItem.Name = "OtroToolStripMenuItem"
        Me.OtroToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.OtroToolStripMenuItem.Text = "Otro"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(313, 6)
        '
        'BorrarCargaDePicosToolStripMenuItem
        '
        Me.BorrarCargaDePicosToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.textfield_delete
        Me.BorrarCargaDePicosToolStripMenuItem.Name = "BorrarCargaDePicosToolStripMenuItem"
        Me.BorrarCargaDePicosToolStripMenuItem.Size = New System.Drawing.Size(316, 22)
        Me.BorrarCargaDePicosToolStripMenuItem.Text = "Borrar carga de picos"
        '
        'txtComentarios
        '
        Me.txtComentarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtComentarios.Location = New System.Drawing.Point(743, 62)
        Me.txtComentarios.Multiline = True
        Me.txtComentarios.Name = "txtComentarios"
        Me.txtComentarios.Size = New System.Drawing.Size(502, 88)
        Me.txtComentarios.TabIndex = 1000000007
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cbPicos)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.txtTotalPalets)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dgvAlbaranes)
        Me.Panel2.Controls.Add(Me.txtComentarios)
        Me.Panel2.Controls.Add(Me.butOK)
        Me.Panel2.Controls.Add(Me.butExcel)
        Me.Panel2.Controls.Add(Me.btnclean)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(10, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1245, 170)
        Me.Panel2.TabIndex = 1000000008
        '
        'cbPicos
        '
        Me.cbPicos.AutoSize = True
        Me.cbPicos.Checked = True
        Me.cbPicos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbPicos.Location = New System.Drawing.Point(743, 19)
        Me.cbPicos.Name = "cbPicos"
        Me.cbPicos.Size = New System.Drawing.Size(139, 21)
        Me.cbPicos.TabIndex = 1000000011
        Me.cbPicos.Text = "Ver/Ocultar picos"
        Me.cbPicos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(978, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 17)
        Me.Label2.TabIndex = 1000000010
        Me.Label2.Text = "Total carga de palets"
        '
        'txtTotalPalets
        '
        Me.txtTotalPalets.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTotalPalets.Enabled = False
        Me.txtTotalPalets.Location = New System.Drawing.Point(1126, 19)
        Me.txtTotalPalets.Name = "txtTotalPalets"
        Me.txtTotalPalets.Size = New System.Drawing.Size(117, 22)
        Me.txtTotalPalets.TabIndex = 1000000009
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(740, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 17)
        Me.Label1.TabIndex = 1000000008
        Me.Label1.Text = "Comentarios"
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.MaximumSize = New System.Drawing.Size(10, 553)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(10, 553)
        Me.Panel3.TabIndex = 1000000009
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(1255, 0)
        Me.Panel4.MaximumSize = New System.Drawing.Size(10, 553)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(10, 553)
        Me.Panel4.TabIndex = 1000000010
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(0, 553)
        Me.Panel5.MaximumSize = New System.Drawing.Size(1265, 20)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1265, 20)
        Me.Panel5.TabIndex = 1000000011
        '
        'frmOrdenesCargaInforme
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit
        Me.ClientSize = New System.Drawing.Size(1265, 573)
        Me.ContextMenuStrip = Me.ContextMenuStrip1
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.MinimizeBox = False
        Me.Name = "frmOrdenesCargaInforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Preparación de ordenes de carga."
        Me.Panel1.ResumeLayout(False)
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub


   Private WithEvents Panel1 As System.Windows.Forms.Panel
   Private WithEvents dgv As System.Windows.Forms.DataGridView
   Private WithEvents dgvAlbaranes As System.Windows.Forms.DataGridView
   Private WithEvents butOK As System.Windows.Forms.Button
    Friend Shadows WithEvents butExcel As System.Windows.Forms.Button
   Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Private WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
   Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
   Private WithEvents VerdeToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents RojoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents ResetToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents OtroToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents btnclean As System.Windows.Forms.Button
   Private WithEvents txtComentarios As System.Windows.Forms.TextBox
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents Panel3 As System.Windows.Forms.Panel
   Private WithEvents Panel4 As System.Windows.Forms.Panel
   Private WithEvents Panel5 As System.Windows.Forms.Panel
   Private WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents txtTotalPalets As System.Windows.Forms.TextBox
    Private WithEvents BorrarCargaDePicosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
   Private WithEvents cbPicos As System.Windows.Forms.CheckBox
End Class
