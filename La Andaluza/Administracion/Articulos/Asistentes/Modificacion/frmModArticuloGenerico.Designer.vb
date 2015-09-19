<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModArticuloGenerico
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmModArticuloGenerico))
        Me.slGeneral_Extras = New System.Windows.Forms.SplitContainer()
        Me.slGeneral_detalles = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsDescripcion = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSplitButton1 = New System.Windows.Forms.ToolStripSplitButton()
        Me.OcultarPanelIzquierdoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarPanelDerechoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MostrarLosDosPanelesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OcultarmostrarPanelInferiorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.slGeneral_Extras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slGeneral_Extras.Panel1.SuspendLayout()
        Me.slGeneral_Extras.SuspendLayout()
        CType(Me.slGeneral_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.slGeneral_detalles.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'slGeneral_Extras
        '
        Me.slGeneral_Extras.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.slGeneral_Extras.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slGeneral_Extras.Location = New System.Drawing.Point(0, 50)
        Me.slGeneral_Extras.Name = "slGeneral_Extras"
        Me.slGeneral_Extras.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'slGeneral_Extras.Panel1
        '
        Me.slGeneral_Extras.Panel1.Controls.Add(Me.slGeneral_detalles)
        Me.slGeneral_Extras.Size = New System.Drawing.Size(1284, 609)
        Me.slGeneral_Extras.SplitterDistance = 396
        Me.slGeneral_Extras.TabIndex = 0
        '
        'slGeneral_detalles
        '
        Me.slGeneral_detalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.slGeneral_detalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.slGeneral_detalles.Location = New System.Drawing.Point(0, 0)
        Me.slGeneral_detalles.Name = "slGeneral_detalles"
        '
        'slGeneral_detalles.Panel2
        '
        Me.slGeneral_detalles.Panel2.AutoScroll = True
        Me.slGeneral_detalles.Size = New System.Drawing.Size(1284, 396)
        Me.slGeneral_detalles.SplitterDistance = 609
        Me.slGeneral_detalles.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsDescripcion, Me.ToolStripSplitButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1284, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsDescripcion
        '
        Me.tsDescripcion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDescripcion.Enabled = False
        Me.tsDescripcion.Image = Global.La_Andaluza.My.Resources.Resources.edit_table_cell
        Me.tsDescripcion.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDescripcion.Name = "tsDescripcion"
        Me.tsDescripcion.Size = New System.Drawing.Size(23, 22)
        Me.tsDescripcion.Text = "Editar descripción"
        Me.tsDescripcion.Visible = False
        '
        'ToolStripSplitButton1
        '
        Me.ToolStripSplitButton1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OcultarPanelIzquierdoToolStripMenuItem, Me.OcultarPanelDerechoToolStripMenuItem, Me.MostrarLosDosPanelesToolStripMenuItem, Me.OcultarmostrarPanelInferiorToolStripMenuItem})
        Me.ToolStripSplitButton1.Image = Global.La_Andaluza.My.Resources.Resources.distribute_vertical_equal
        Me.ToolStripSplitButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripSplitButton1.Name = "ToolStripSplitButton1"
        Me.ToolStripSplitButton1.Size = New System.Drawing.Size(132, 22)
        Me.ToolStripSplitButton1.Text = "&Modo de pantalla"
        '
        'OcultarPanelIzquierdoToolStripMenuItem
        '
        Me.OcultarPanelIzquierdoToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.go_previous_5
        Me.OcultarPanelIzquierdoToolStripMenuItem.Name = "OcultarPanelIzquierdoToolStripMenuItem"
        Me.OcultarPanelIzquierdoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Right), System.Windows.Forms.Keys)
        Me.OcultarPanelIzquierdoToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.OcultarPanelIzquierdoToolStripMenuItem.Text = "Ocultar panel &izquierdo"
        '
        'OcultarPanelDerechoToolStripMenuItem
        '
        Me.OcultarPanelDerechoToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.go_next_5
        Me.OcultarPanelDerechoToolStripMenuItem.Name = "OcultarPanelDerechoToolStripMenuItem"
        Me.OcultarPanelDerechoToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Left), System.Windows.Forms.Keys)
        Me.OcultarPanelDerechoToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.OcultarPanelDerechoToolStripMenuItem.Text = "Ocultar panel &derecho"
        '
        'MostrarLosDosPanelesToolStripMenuItem
        '
        Me.MostrarLosDosPanelesToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.package_installed_updated
        Me.MostrarLosDosPanelesToolStripMenuItem.Name = "MostrarLosDosPanelesToolStripMenuItem"
        Me.MostrarLosDosPanelesToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Up), System.Windows.Forms.Keys)
        Me.MostrarLosDosPanelesToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.MostrarLosDosPanelesToolStripMenuItem.Text = "Mostrar los dos &paneles"
        '
        'OcultarmostrarPanelInferiorToolStripMenuItem
        '
        Me.OcultarmostrarPanelInferiorToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.package_broken2
        Me.OcultarmostrarPanelInferiorToolStripMenuItem.Name = "OcultarmostrarPanelInferiorToolStripMenuItem"
        Me.OcultarmostrarPanelInferiorToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Down), System.Windows.Forms.Keys)
        Me.OcultarmostrarPanelInferiorToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.OcultarmostrarPanelInferiorToolStripMenuItem.Text = "Ocultar/mostrar panel inferior"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Tahoma", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.Image = Global.La_Andaluza.My.Resources.Resources.emblem_notice
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(460, 22)
        Me.ToolStripLabel1.Text = "Atencion: al guardar los cambios asegurarse de que la marca y tipo de producto so" &
    "n los correctos"
        '
        'frmModArticuloGenerico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(1284, 659)
        Me.Controls.Add(Me.slGeneral_Extras)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmModArticuloGenerico"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulo"
        Me.Controls.SetChildIndex(Me.ToolStrip1, 0)
        Me.Controls.SetChildIndex(Me.slGeneral_Extras, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slGeneral_Extras.Panel1.ResumeLayout(False)
        CType(Me.slGeneral_Extras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slGeneral_Extras.ResumeLayout(False)
        CType(Me.slGeneral_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.slGeneral_detalles.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents slGeneral_Extras As System.Windows.Forms.SplitContainer
   Private WithEvents slGeneral_detalles As System.Windows.Forms.SplitContainer
   Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Private WithEvents tsDescripcion As System.Windows.Forms.ToolStripButton
   Private WithEvents ToolStripSplitButton1 As System.Windows.Forms.ToolStripSplitButton
   Private WithEvents OcultarPanelIzquierdoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents OcultarPanelDerechoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents MostrarLosDosPanelesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
   Private WithEvents OcultarmostrarPanelInferiorToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel

End Class
