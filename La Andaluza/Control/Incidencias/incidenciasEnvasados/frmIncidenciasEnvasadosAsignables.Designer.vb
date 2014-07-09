<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncidenciasEnvasadosAsignables
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
        Me.dgvAsignables = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnEliminar = New System.Windows.Forms.ToolStripButton()
        Me.btnAnadir = New System.Windows.Forms.ToolStripButton()
        Me.dgvAsignadas = New System.Windows.Forms.DataGridView()
        Me.titulo1 = New System.Windows.Forms.Label()
        Me.titulo2 = New System.Windows.Forms.Label()
        Me.PanTitulo = New System.Windows.Forms.Panel()
        Me.panTitulo2 = New System.Windows.Forms.Panel()
        Me.PanBotonera = New System.Windows.Forms.Panel()
        CType(Me.dgvAsignables, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvAsignadas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanTitulo.SuspendLayout()
        Me.panTitulo2.SuspendLayout()
        Me.PanBotonera.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvAsignables
        '
        Me.dgvAsignables.AllowUserToAddRows = False
        Me.dgvAsignables.AllowUserToDeleteRows = False
        Me.dgvAsignables.AllowUserToResizeRows = False
        Me.dgvAsignables.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAsignables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignables.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvAsignables.Location = New System.Drawing.Point(0, 17)
        Me.dgvAsignables.Name = "dgvAsignables"
        Me.dgvAsignables.ReadOnly = True
        Me.dgvAsignables.RowHeadersVisible = False
        Me.dgvAsignables.RowTemplate.Height = 24
        Me.dgvAsignables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAsignables.Size = New System.Drawing.Size(683, 150)
        Me.dgvAsignables.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnEliminar, Me.btnAnadir})
        Me.ToolStrip1.Location = New System.Drawing.Point(288, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(49, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnEliminar
        '
        Me.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnEliminar.Image = Global.La_Andaluza.My.Resources.Resources.arrow_up_16
        Me.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(23, 22)
        Me.btnEliminar.Text = "Quitar de las asignadas"
        '
        'btnAnadir
        '
        Me.btnAnadir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnAnadir.Image = Global.La_Andaluza.My.Resources.Resources.arrow_down_16
        Me.btnAnadir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAnadir.Name = "btnAnadir"
        Me.btnAnadir.Size = New System.Drawing.Size(23, 22)
        Me.btnAnadir.Text = "Mover a asignadas"
        '
        'dgvAsignadas
        '
        Me.dgvAsignadas.AllowUserToAddRows = False
        Me.dgvAsignadas.AllowUserToDeleteRows = False
        Me.dgvAsignadas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvAsignadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAsignadas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvAsignadas.Location = New System.Drawing.Point(0, 203)
        Me.dgvAsignadas.MultiSelect = False
        Me.dgvAsignadas.Name = "dgvAsignadas"
        Me.dgvAsignadas.ReadOnly = True
        Me.dgvAsignadas.RowHeadersVisible = False
        Me.dgvAsignadas.RowTemplate.Height = 24
        Me.dgvAsignadas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAsignadas.Size = New System.Drawing.Size(683, 167)
        Me.dgvAsignadas.TabIndex = 2
        '
        'titulo1
        '
        Me.titulo1.AutoSize = True
        Me.titulo1.Location = New System.Drawing.Point(279, 0)
        Me.titulo1.Name = "titulo1"
        Me.titulo1.Size = New System.Drawing.Size(58, 13)
        Me.titulo1.TabIndex = 3
        Me.titulo1.Text = "Asignables"
        '
        'titulo2
        '
        Me.titulo2.AutoSize = True
        Me.titulo2.Location = New System.Drawing.Point(285, 0)
        Me.titulo2.Name = "titulo2"
        Me.titulo2.Size = New System.Drawing.Size(56, 13)
        Me.titulo2.TabIndex = 4
        Me.titulo2.Text = "Asignadas"
        '
        'PanTitulo
        '
        Me.PanTitulo.Controls.Add(Me.titulo1)
        Me.PanTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanTitulo.Name = "PanTitulo"
        Me.PanTitulo.Size = New System.Drawing.Size(683, 17)
        Me.PanTitulo.TabIndex = 5
        '
        'panTitulo2
        '
        Me.panTitulo2.Controls.Add(Me.titulo2)
        Me.panTitulo2.Dock = System.Windows.Forms.DockStyle.Top
        Me.panTitulo2.Location = New System.Drawing.Point(0, 189)
        Me.panTitulo2.Name = "panTitulo2"
        Me.panTitulo2.Size = New System.Drawing.Size(683, 14)
        Me.panTitulo2.TabIndex = 6
        '
        'PanBotonera
        '
        Me.PanBotonera.Controls.Add(Me.ToolStrip1)
        Me.PanBotonera.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanBotonera.Location = New System.Drawing.Point(0, 167)
        Me.PanBotonera.Name = "PanBotonera"
        Me.PanBotonera.Size = New System.Drawing.Size(683, 22)
        Me.PanBotonera.TabIndex = 7
        '
        'frmIncidenciasEnvasadosAsignables
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(683, 370)
        Me.Controls.Add(Me.dgvAsignadas)
        Me.Controls.Add(Me.panTitulo2)
        Me.Controls.Add(Me.PanBotonera)
        Me.Controls.Add(Me.dgvAsignables)
        Me.Controls.Add(Me.PanTitulo)
        Me.Name = "frmIncidenciasEnvasadosAsignables"
        Me.Text = "frmIncidenciasEnvasadosAsignables"
        CType(Me.dgvAsignables, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvAsignadas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanTitulo.ResumeLayout(False)
        Me.PanTitulo.PerformLayout()
        Me.panTitulo2.ResumeLayout(False)
        Me.panTitulo2.PerformLayout()
        Me.PanBotonera.ResumeLayout(False)
        Me.PanBotonera.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgvAsignables As System.Windows.Forms.DataGridView
    Private WithEvents dgvAsignadas As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnEliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents btnAnadir As System.Windows.Forms.ToolStripButton
    Private WithEvents titulo1 As System.Windows.Forms.Label
    Private WithEvents titulo2 As System.Windows.Forms.Label
    Private WithEvents PanTitulo As System.Windows.Forms.Panel
    Private WithEvents panTitulo2 As System.Windows.Forms.Panel
    Private WithEvents PanBotonera As System.Windows.Forms.Panel
End Class
