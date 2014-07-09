<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmArticulos1CompuestoPorMAM
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.butNuevo = New System.Windows.Forms.ToolStripButton()
        Me.butModificar = New System.Windows.Forms.ToolStripButton()
        Me.butEliminar = New System.Windows.Forms.ToolStripButton()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.butNuevo, Me.butModificar, Me.butEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1164, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'butNuevo
        '
        Me.butNuevo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butNuevo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butNuevo.Name = "butNuevo"
        Me.butNuevo.Size = New System.Drawing.Size(23, 22)
        Me.butNuevo.Text = "Añadir"
        '
        'butModificar
        '
        Me.butModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butModificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.butModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butModificar.Name = "butModificar"
        Me.butModificar.Size = New System.Drawing.Size(23, 22)
        Me.butModificar.Text = "Modificar"
        '
        'butEliminar
        '
        Me.butEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.butEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butEliminar.Name = "butEliminar"
        Me.butEliminar.Size = New System.Drawing.Size(23, 22)
        Me.butEliminar.Text = "Eliminar"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 25)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(4)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(1164, 563)
        Me.DataGridView1.StandardTab = True
        Me.DataGridView1.TabIndex = 1
        '
        'frmArticulos1CompuestoPorMAM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 588)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmArticulos1CompuestoPorMAM"
        Me.Text = "frmArticulos1CompuestoPor"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents butNuevo As System.Windows.Forms.ToolStripButton
    Private WithEvents butModificar As System.Windows.Forms.ToolStripButton
    Private WithEvents butEliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
End Class
