<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPersonalEnvasadoOcupado
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DgvOcupados = New System.Windows.Forms.DataGridView()
        Me.Id_ocupado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreOcupado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lineaTrabajo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DgvOcupados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Personal ocupado:"
        '
        'DgvOcupados
        '
        Me.DgvOcupados.AllowUserToAddRows = False
        Me.DgvOcupados.AllowUserToDeleteRows = False
        Me.DgvOcupados.AllowUserToResizeColumns = False
        Me.DgvOcupados.AllowUserToResizeRows = False
        Me.DgvOcupados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvOcupados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvOcupados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvOcupados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id_ocupado, Me.NombreOcupado, Me.lineaTrabajo, Me.Articulo, Me.Fecha})
        Me.DgvOcupados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DgvOcupados.Location = New System.Drawing.Point(0, 18)
        Me.DgvOcupados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvOcupados.MultiSelect = False
        Me.DgvOcupados.Name = "DgvOcupados"
        Me.DgvOcupados.ReadOnly = True
        Me.DgvOcupados.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvOcupados.RowHeadersVisible = False
        Me.DgvOcupados.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvOcupados.RowTemplate.Height = 24
        Me.DgvOcupados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvOcupados.Size = New System.Drawing.Size(736, 413)
        Me.DgvOcupados.TabIndex = 11
        '
        'Id_ocupado
        '
        Me.Id_ocupado.HeaderText = "Id"
        Me.Id_ocupado.Name = "Id_ocupado"
        Me.Id_ocupado.ReadOnly = True
        Me.Id_ocupado.Visible = False
        '
        'NombreOcupado
        '
        Me.NombreOcupado.HeaderText = "Nombre"
        Me.NombreOcupado.Name = "NombreOcupado"
        Me.NombreOcupado.ReadOnly = True
        '
        'lineaTrabajo
        '
        Me.lineaTrabajo.HeaderText = "Linea"
        Me.lineaTrabajo.Name = "lineaTrabajo"
        Me.lineaTrabajo.ReadOnly = True
        '
        'Articulo
        '
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
        'btnRefresh
        '
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.Dock = System.Windows.Forms.DockStyle.Left
        Me.btnRefresh.FlatAppearance.BorderSize = 0
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRefresh.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.btnRefresh.Location = New System.Drawing.Point(96, 0)
        Me.btnRefresh.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(20, 18)
        Me.btnRefresh.TabIndex = 13
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnRefresh)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(736, 18)
        Me.Panel1.TabIndex = 14
        '
        'frmPersonalEnvasadoOcupado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 431)
        Me.Controls.Add(Me.DgvOcupados)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmPersonalEnvasadoOcupado"
        Me.Text = "frmPersonalOcupado"
        CType(Me.DgvOcupados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents DgvOcupados As System.Windows.Forms.DataGridView
   Private WithEvents Id_ocupado As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents NombreOcupado As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents lineaTrabajo As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents Articulo As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents btnRefresh As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
