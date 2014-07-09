<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPartesEnvasadosCausasIns
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
        Me.cboCausaParteEnvasado = New System.Windows.Forms.ComboBox()
        Me.lblId_CausaParteEnvasado = New System.Windows.Forms.Label()
        Me.butAddId_CausaParteEnvasado = New System.Windows.Forms.Button()
        Me.butVerId_CausaParteEnvasado = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tsSalir = New System.Windows.Forms.ToolStripButton()
        Me.PanContenido = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ToolStrip1.SuspendLayout()
        Me.PanContenido.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCausaParteEnvasado
        '
        Me.cboCausaParteEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCausaParteEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaParteEnvasado.Location = New System.Drawing.Point(46, 10)
        Me.cboCausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCausaParteEnvasado.Name = "cboCausaParteEnvasado"
        Me.cboCausaParteEnvasado.Size = New System.Drawing.Size(390, 23)
        Me.cboCausaParteEnvasado.TabIndex = 6
        '
        'lblId_CausaParteEnvasado
        '
        Me.lblId_CausaParteEnvasado.Location = New System.Drawing.Point(-4, 7)
        Me.lblId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_CausaParteEnvasado.Name = "lblId_CausaParteEnvasado"
        Me.lblId_CausaParteEnvasado.Size = New System.Drawing.Size(45, 30)
        Me.lblId_CausaParteEnvasado.TabIndex = 7
        Me.lblId_CausaParteEnvasado.Text = "Causa"
        Me.lblId_CausaParteEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'butAddId_CausaParteEnvasado
        '
        Me.butAddId_CausaParteEnvasado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_CausaParteEnvasado.FlatAppearance.BorderSize = 0
        Me.butAddId_CausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_CausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_CausaParteEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_CausaParteEnvasado.Location = New System.Drawing.Point(462, 11)
        Me.butAddId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_CausaParteEnvasado.Name = "butAddId_CausaParteEnvasado"
        Me.butAddId_CausaParteEnvasado.Size = New System.Drawing.Size(18, 19)
        Me.butAddId_CausaParteEnvasado.TabIndex = 9
        Me.butAddId_CausaParteEnvasado.TabStop = False
        '
        'butVerId_CausaParteEnvasado
        '
        Me.butVerId_CausaParteEnvasado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_CausaParteEnvasado.FlatAppearance.BorderSize = 0
        Me.butVerId_CausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_CausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_CausaParteEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_CausaParteEnvasado.Location = New System.Drawing.Point(439, 11)
        Me.butVerId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_CausaParteEnvasado.Name = "butVerId_CausaParteEnvasado"
        Me.butVerId_CausaParteEnvasado.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_CausaParteEnvasado.TabIndex = 8
        Me.butVerId_CausaParteEnvasado.TabStop = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsGuardar, Me.tsSalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(534, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsGuardar
        '
        Me.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsGuardar.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_16
        Me.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsGuardar.Name = "tsGuardar"
        Me.tsGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsGuardar.Text = "ToolStripButton1"
        '
        'tsSalir
        '
        Me.tsSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSalir.Image = Global.La_Andaluza.My.Resources.Resources.application_xit_3
        Me.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsSalir.Text = "ToolStripButton2"
        '
        'PanContenido
        '
        Me.PanContenido.Controls.Add(Me.cboCausaParteEnvasado)
        Me.PanContenido.Controls.Add(Me.butVerId_CausaParteEnvasado)
        Me.PanContenido.Controls.Add(Me.butAddId_CausaParteEnvasado)
        Me.PanContenido.Controls.Add(Me.lblId_CausaParteEnvasado)
        Me.PanContenido.Location = New System.Drawing.Point(34, 7)
        Me.PanContenido.Name = "PanContenido"
        Me.PanContenido.Size = New System.Drawing.Size(481, 40)
        Me.PanContenido.TabIndex = 11
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanContenido)
        Me.SplitContainer1.Size = New System.Drawing.Size(534, 339)
        Me.SplitContainer1.SplitterDistance = 52
        Me.SplitContainer1.TabIndex = 12
        '
        'frmEntPartesEnvasadosCausasIns
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 364)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEntPartesEnvasadosCausasIns"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntPartesEnvasadosCausasIns"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.PanContenido.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cboCausaParteEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents lblId_CausaParteEnvasado As System.Windows.Forms.Label
    Private WithEvents butAddId_CausaParteEnvasado As System.Windows.Forms.Button
    Private WithEvents butVerId_CausaParteEnvasado As System.Windows.Forms.Button
   Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Private WithEvents tsGuardar As System.Windows.Forms.ToolStripButton
   Private WithEvents tsSalir As System.Windows.Forms.ToolStripButton
    Private WithEvents PanContenido As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
