<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmControlIncidencias_Origen
    Inherits System.Windows.Forms.Form

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Dise�ador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Dise�ador de Windows Forms.  
    'No lo modifique con el editor de c�digo.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnA�adir = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.AllowUserToResizeRows = False
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGrilla.Location = New System.Drawing.Point(0, 25)
        Me.dgvGrilla.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvGrilla.MultiSelect = False
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowHeadersVisible = False
        Me.dgvGrilla.RowTemplate.Height = 24
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(1113, 542)
        Me.dgvGrilla.TabIndex = 12
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1113, 567)
        Me.DataGridView1.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnA�adir, Me.btnEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1113, 25)
        Me.ToolStrip1.TabIndex = 14
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnA�adir
        '
        Me.btnA�adir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnA�adir.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnA�adir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnA�adir.Name = "btnA�adir"
        Me.btnA�adir.Size = New System.Drawing.Size(23, 22)
        Me.btnA�adir.Text = "A�adir"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Text = "Eliminar"
        '
        'frmControlIncidencias_Origen
        '
        Me.ClientSize = New System.Drawing.Size(1113, 567)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.DataGridView1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmControlIncidencias_Origen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_Clientes"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents dgvGrilla As System.Windows.Forms.DataGridView
   Private WithEvents DataGridView1 As System.Windows.Forms.DataGridView
   Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Private WithEvents btnA�adir As System.Windows.Forms.ToolStripButton
   Private WithEvents btnEliminar As System.Windows.Forms.ToolStripButton

End Class
