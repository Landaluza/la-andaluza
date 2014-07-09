<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalEnvasadoSinFin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPersonalEnvasadoSinFin))
        Me.dgvOcupados = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsFinalizar = New System.Windows.Forms.ToolStripButton()
        Me.tsSalir = New System.Windows.Forms.ToolStripButton()
        Me.tsRefreescar = New System.Windows.Forms.ToolStripButton()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvOcupados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvOcupados
        '
        Me.dgvOcupados.AllowUserToAddRows = False
        Me.dgvOcupados.AllowUserToDeleteRows = False
        Me.dgvOcupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvOcupados.ColumnHeadersVisible = False
        Me.dgvOcupados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Nombre, Me.Articulo, Me.Fecha})
        Me.dgvOcupados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvOcupados.Location = New System.Drawing.Point(0, 25)
        Me.dgvOcupados.MultiSelect = False
        Me.dgvOcupados.Name = "dgvOcupados"
        Me.dgvOcupados.ReadOnly = True
        Me.dgvOcupados.RowHeadersVisible = False
        Me.dgvOcupados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvOcupados.RowTemplate.Height = 24
        Me.dgvOcupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvOcupados.Size = New System.Drawing.Size(855, 516)
        Me.dgvOcupados.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsFinalizar, Me.tsSalir, Me.tsRefreescar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(855, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsFinalizar
        '
        Me.tsFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsFinalizar.Image = CType(resources.GetObject("tsFinalizar.Image"), System.Drawing.Image)
        Me.tsFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsFinalizar.Name = "tsFinalizar"
        Me.tsFinalizar.Size = New System.Drawing.Size(101, 22)
        Me.tsFinalizar.Text = "Finalizar turno"
        '
        'tsSalir
        '
        Me.tsSalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsSalir.Image = Global.La_Andaluza.My.Resources.Resources.application_xit_3
        Me.tsSalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsSalir.Name = "tsSalir"
        Me.tsSalir.Size = New System.Drawing.Size(23, 22)
        Me.tsSalir.Text = "Salir"
        '
        'tsRefreescar
        '
        Me.tsRefreescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsRefreescar.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.tsRefreescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsRefreescar.Name = "tsRefreescar"
        Me.tsRefreescar.Size = New System.Drawing.Size(23, 22)
        Me.tsRefreescar.Text = "Recargar"
        '
        'Id
        '
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        Me.Id.Visible = False
        '
        'Nombre
        '
        Me.Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Articulo
        '
        Me.Articulo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Articulo.HeaderText = "Articulo"
        Me.Articulo.Name = "Articulo"
        Me.Articulo.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'frmPersonalEnvasadoSinFin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 541)
        Me.Controls.Add(Me.dgvOcupados)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmPersonalEnvasadoSinFin"
        Me.Text = "frmPersonalEnvasadoSinFin"
        CType(Me.dgvOcupados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvOcupados As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsFinalizar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsSalir As System.Windows.Forms.ToolStripButton
    Private WithEvents tsRefreescar As System.Windows.Forms.ToolStripButton
    Private WithEvents Id As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
