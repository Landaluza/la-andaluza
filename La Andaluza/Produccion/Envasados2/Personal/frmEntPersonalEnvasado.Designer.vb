<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPersonalEnvasado
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panOcupados = New System.Windows.Forms.Panel()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.lRecomendado = New System.Windows.Forms.Label()
        Me.DgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.eId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnALinea = New System.Windows.Forms.Button()
        Me.dgvEnLinea = New System.Windows.Forms.DataGridView()
        Me.lId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apoyo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.btnfueraLinea = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(365, 210)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(85, 9)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Personal recomendado:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.panOcupados)
        Me.Panel1.Controls.Add(Me.dtpInicio)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lRecomendado)
        Me.Panel1.Controls.Add(Me.DgvDisponibles)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnALinea)
        Me.Panel1.Controls.Add(Me.dgvEnLinea)
        Me.Panel1.Controls.Add(Me.btnfueraLinea)
        Me.Panel1.Location = New System.Drawing.Point(7, 24)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(698, 436)
        Me.Panel1.TabIndex = 7
        '
        'panOcupados
        '
        Me.panOcupados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.panOcupados.Location = New System.Drawing.Point(0, 304)
        Me.panOcupados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panOcupados.Name = "panOcupados"
        Me.panOcupados.Size = New System.Drawing.Size(698, 132)
        Me.panOcupados.TabIndex = 9
        '
        'dtpInicio
        '
        Me.dtpInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpInicio.CustomFormat = "HH:mm"
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(608, 14)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.ShowUpDown = True
        Me.dtpInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpInicio.TabIndex = 8
        '
        'lRecomendado
        '
        Me.lRecomendado.AutoSize = True
        Me.lRecomendado.Location = New System.Drawing.Point(481, 208)
        Me.lRecomendado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lRecomendado.Name = "lRecomendado"
        Me.lRecomendado.Size = New System.Drawing.Size(13, 13)
        Me.lRecomendado.TabIndex = 6
        Me.lRecomendado.Text = "0"
        '
        'DgvDisponibles
        '
        Me.DgvDisponibles.AllowUserToAddRows = False
        Me.DgvDisponibles.AllowUserToDeleteRows = False
        Me.DgvDisponibles.AllowUserToResizeColumns = False
        Me.DgvDisponibles.AllowUserToResizeRows = False
        Me.DgvDisponibles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DgvDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDisponibles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.eId, Me.Nombre})
        Me.DgvDisponibles.Location = New System.Drawing.Point(6, 68)
        Me.DgvDisponibles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DgvDisponibles.MultiSelect = False
        Me.DgvDisponibles.Name = "DgvDisponibles"
        Me.DgvDisponibles.ReadOnly = True
        Me.DgvDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDisponibles.RowHeadersVisible = False
        Me.DgvDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDisponibles.RowTemplate.Height = 24
        Me.DgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDisponibles.Size = New System.Drawing.Size(330, 137)
        Me.DgvDisponibles.TabIndex = 1
        '
        'eId
        '
        Me.eId.HeaderText = "Id"
        Me.eId.Name = "eId"
        Me.eId.ReadOnly = True
        Me.eId.Visible = False
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 14)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el personal con el que arranca la linea"
        '
        'btnALinea
        '
        Me.btnALinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnALinea.FlatAppearance.BorderSize = 0
        Me.btnALinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnALinea.Image = Global.La_Andaluza.My.Resources.Resources.go_previous_5
        Me.btnALinea.Location = New System.Drawing.Point(340, 94)
        Me.btnALinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnALinea.Name = "btnALinea"
        Me.btnALinea.Size = New System.Drawing.Size(25, 31)
        Me.btnALinea.TabIndex = 4
        Me.btnALinea.UseVisualStyleBackColor = True
        '
        'dgvEnLinea
        '
        Me.dgvEnLinea.AllowUserToAddRows = False
        Me.dgvEnLinea.AllowUserToDeleteRows = False
        Me.dgvEnLinea.AllowUserToResizeColumns = False
        Me.dgvEnLinea.AllowUserToResizeRows = False
        Me.dgvEnLinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lId, Me.DataGridViewTextBoxColumn2, Me.Apoyo})
        Me.dgvEnLinea.Location = New System.Drawing.Point(368, 68)
        Me.dgvEnLinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvEnLinea.Name = "dgvEnLinea"
        Me.dgvEnLinea.ReadOnly = True
        Me.dgvEnLinea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEnLinea.RowHeadersVisible = False
        Me.dgvEnLinea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEnLinea.RowTemplate.Height = 24
        Me.dgvEnLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnLinea.Size = New System.Drawing.Size(325, 137)
        Me.dgvEnLinea.TabIndex = 2
        '
        'lId
        '
        Me.lId.HeaderText = "Id"
        Me.lId.Name = "lId"
        Me.lId.ReadOnly = True
        Me.lId.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'Apoyo
        '
        Me.Apoyo.FillWeight = 20.0!
        Me.Apoyo.HeaderText = "Apoyo"
        Me.Apoyo.Name = "Apoyo"
        Me.Apoyo.ReadOnly = True
        Me.Apoyo.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        '
        'btnfueraLinea
        '
        Me.btnfueraLinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfueraLinea.FlatAppearance.BorderSize = 0
        Me.btnfueraLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfueraLinea.Image = Global.La_Andaluza.My.Resources.Resources.go_next_5
        Me.btnfueraLinea.Location = New System.Drawing.Point(340, 130)
        Me.btnfueraLinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnfueraLinea.Name = "btnfueraLinea"
        Me.btnfueraLinea.Size = New System.Drawing.Size(25, 34)
        Me.btnfueraLinea.TabIndex = 3
        Me.btnfueraLinea.UseVisualStyleBackColor = True
        '
        'frmEntPersonalEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 484)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEntPersonalEnvasado"
        Me.Text = "frmEntPersonalEnvasado"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lRecomendado As System.Windows.Forms.Label
    Private WithEvents DgvDisponibles As System.Windows.Forms.DataGridView
   Private WithEvents eId As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnALinea As System.Windows.Forms.Button
    Private WithEvents dgvEnLinea As System.Windows.Forms.DataGridView
   Private WithEvents lId As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents Apoyo As System.Windows.Forms.DataGridViewCheckBoxColumn
    Private WithEvents btnfueraLinea As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents panOcupados As System.Windows.Forms.Panel
End Class
