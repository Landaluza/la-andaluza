<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PersonalEnLinea
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DgvDisponibles = New System.Windows.Forms.DataGridView()
        Me.eId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvEnLinea = New System.Windows.Forms.DataGridView()
        Me.btnfueraLinea = New System.Windows.Forms.Button()
        Me.btnALinea = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnConfirmar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lRecomendado = New System.Windows.Forms.Label()
        Me.lId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apoyo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        CType(Me.DgvDisponibles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(292, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seleccione el personal con el que arranca la linea"
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
        Me.DgvDisponibles.Location = New System.Drawing.Point(8, 124)
        Me.DgvDisponibles.MultiSelect = False
        Me.DgvDisponibles.Name = "DgvDisponibles"
        Me.DgvDisponibles.ReadOnly = True
        Me.DgvDisponibles.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.DgvDisponibles.RowHeadersVisible = False
        Me.DgvDisponibles.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.DgvDisponibles.RowTemplate.Height = 24
        Me.DgvDisponibles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDisponibles.Size = New System.Drawing.Size(442, 169)
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
        'dgvEnLinea
        '
        Me.dgvEnLinea.AllowUserToAddRows = False
        Me.dgvEnLinea.AllowUserToDeleteRows = False
        Me.dgvEnLinea.AllowUserToResizeColumns = False
        Me.dgvEnLinea.AllowUserToResizeRows = False
        Me.dgvEnLinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lId, Me.DataGridViewTextBoxColumn2, Me.Apoyo})
        Me.dgvEnLinea.Location = New System.Drawing.Point(490, 124)
        Me.dgvEnLinea.Name = "dgvEnLinea"
        Me.dgvEnLinea.ReadOnly = True
        Me.dgvEnLinea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEnLinea.RowHeadersVisible = False
        Me.dgvEnLinea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEnLinea.RowTemplate.Height = 24
        Me.dgvEnLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnLinea.Size = New System.Drawing.Size(433, 169)
        Me.dgvEnLinea.TabIndex = 2
        '
        'btnfueraLinea
        '
        Me.btnfueraLinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnfueraLinea.FlatAppearance.BorderSize = 0
        Me.btnfueraLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnfueraLinea.Image = Global.La_Andaluza.My.Resources.Resources.go_next_5
        Me.btnfueraLinea.Location = New System.Drawing.Point(453, 200)
        Me.btnfueraLinea.Name = "btnfueraLinea"
        Me.btnfueraLinea.Size = New System.Drawing.Size(33, 42)
        Me.btnfueraLinea.TabIndex = 3
        Me.btnfueraLinea.UseVisualStyleBackColor = True
        '
        'btnALinea
        '
        Me.btnALinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnALinea.FlatAppearance.BorderSize = 0
        Me.btnALinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnALinea.Image = Global.La_Andaluza.My.Resources.Resources.go_previous_5
        Me.btnALinea.Location = New System.Drawing.Point(453, 156)
        Me.btnALinea.Name = "btnALinea"
        Me.btnALinea.Size = New System.Drawing.Size(33, 38)
        Me.btnALinea.TabIndex = 4
        Me.btnALinea.UseVisualStyleBackColor = True
        '
        'btnConfirmar
        '
        Me.btnConfirmar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnConfirmar.Location = New System.Drawing.Point(724, 391)
        Me.btnConfirmar.Name = "btnConfirmar"
        Me.btnConfirmar.Size = New System.Drawing.Size(199, 78)
        Me.btnConfirmar.TabIndex = 5
        Me.btnConfirmar.Text = "Confirmar"
        Me.btnConfirmar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnConfirmar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lRecomendado)
        Me.Panel1.Controls.Add(Me.DgvDisponibles)
        Me.Panel1.Controls.Add(Me.btnConfirmar)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnALinea)
        Me.Panel1.Controls.Add(Me.dgvEnLinea)
        Me.Panel1.Controls.Add(Me.btnfueraLinea)
        Me.Panel1.Location = New System.Drawing.Point(6, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(930, 484)
        Me.Panel1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(487, 315)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(159, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Personal recomendado:"
        '
        'lRecomendado
        '
        Me.lRecomendado.AutoSize = True
        Me.lRecomendado.Location = New System.Drawing.Point(676, 315)
        Me.lRecomendado.Name = "lRecomendado"
        Me.lRecomendado.Size = New System.Drawing.Size(16, 17)
        Me.lRecomendado.TabIndex = 6
        Me.lRecomendado.Text = "0"
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
        'PersonalEnLinea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(939, 534)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PersonalEnLinea"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PersonalEnLinea"
        CType(Me.DgvDisponibles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents DgvDisponibles As System.Windows.Forms.DataGridView
    Private WithEvents dgvEnLinea As System.Windows.Forms.DataGridView
    Private WithEvents btnfueraLinea As System.Windows.Forms.Button
    Private WithEvents btnALinea As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents btnConfirmar As System.Windows.Forms.Button
    Private WithEvents eId As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lRecomendado As System.Windows.Forms.Label
    Private WithEvents lId As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Apoyo As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
