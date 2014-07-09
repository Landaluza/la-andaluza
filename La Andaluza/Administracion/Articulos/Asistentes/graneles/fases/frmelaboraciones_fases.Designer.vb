<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmelaboraciones_fases
    Inherits System.Windows.Forms.Form

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
        Me.dgvGrilla = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsInsertar = New System.Windows.Forms.ToolStripButton()
        Me.tsModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGrilla
        '
        Me.dgvGrilla.AllowUserToAddRows = False
        Me.dgvGrilla.AllowUserToDeleteRows = False
        Me.dgvGrilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGrilla.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGrilla.Location = New System.Drawing.Point(0, 25)
        Me.dgvGrilla.Name = "dgvGrilla"
        Me.dgvGrilla.ReadOnly = True
        Me.dgvGrilla.RowTemplate.Height = 24
        Me.dgvGrilla.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGrilla.Size = New System.Drawing.Size(835, 436)
        Me.dgvGrilla.TabIndex = 12
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsertar, Me.tsModificar, Me.tsEliminar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(835, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsInsertar
        '
        Me.tsInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsInsertar.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsInsertar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsInsertar.Name = "tsInsertar"
        Me.tsInsertar.Size = New System.Drawing.Size(23, 22)
        Me.tsInsertar.Text = "insertar"
        '
        'tsModificar
        '
        Me.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsModificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(23, 22)
        Me.tsModificar.Text = "modificar"
        '
        'tsEliminar
        '
        Me.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.Size = New System.Drawing.Size(23, 22)
        Me.tsEliminar.Text = "eliminar"
        '
        'frmelaboraciones_fases
        '
        Me.ClientSize = New System.Drawing.Size(835, 461)
        Me.Controls.Add(Me.dgvGrilla)
        Me.Controls.Add(Me.ToolStrip1)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(400, 400)
        Me.Name = "frmelaboraciones_fases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "elaboraciones_fases"
        CType(Me.dgvGrilla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents dgvGrilla As System.Windows.Forms.DataGridView
   Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Private WithEvents tsInsertar As System.Windows.Forms.ToolStripButton
   Private WithEvents tsModificar As System.Windows.Forms.ToolStripButton
   Private WithEvents tsEliminar As System.Windows.Forms.ToolStripButton

End Class
