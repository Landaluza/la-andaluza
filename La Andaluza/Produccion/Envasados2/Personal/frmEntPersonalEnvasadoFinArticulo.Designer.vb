<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPersonalEnvasadoFinArticulo
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lEnvasado = New System.Windows.Forms.Label()
        Me.lArticulo = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEnLinea = New System.Windows.Forms.DataGridView()
        Me.lId = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apoyo = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.formato = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolTip2 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lEnvasado)
        Me.Panel1.Controls.Add(Me.lArticulo)
        Me.Panel1.Controls.Add(Me.btnGuardar)
        Me.Panel1.Controls.Add(Me.dtpFin)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.dgvEnLinea)
        Me.Panel1.Location = New System.Drawing.Point(11, 11)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 323)
        Me.Panel1.TabIndex = 9
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_cancel_3
        Me.btnCancelar.Location = New System.Drawing.Point(403, 258)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(105, 56)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "del envasado correspondiente al "
        '
        'lEnvasado
        '
        Me.lEnvasado.AutoSize = True
        Me.lEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lEnvasado.Location = New System.Drawing.Point(204, 55)
        Me.lEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lEnvasado.Name = "lEnvasado"
        Me.lEnvasado.Size = New System.Drawing.Size(45, 13)
        Me.lEnvasado.TabIndex = 8
        Me.lEnvasado.Text = "Label2"
        '
        'lArticulo
        '
        Me.lArticulo.AutoSize = True
        Me.lArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lArticulo.Location = New System.Drawing.Point(56, 36)
        Me.lArticulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lArticulo.Name = "lArticulo"
        Me.lArticulo.Size = New System.Drawing.Size(279, 13)
        Me.lArticulo.TabIndex = 7
        Me.lArticulo.Text = "Confirme la hora de fin de envasado del articulo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.FlatAppearance.BorderSize = 0
        Me.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuardar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnGuardar.Location = New System.Drawing.Point(527, 258)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(110, 56)
        Me.btnGuardar.TabIndex = 6
        Me.btnGuardar.Text = "Confirmar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'dtpFin
        '
        Me.dtpFin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFin.CustomFormat = "HH:mm"
        Me.dtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFin.Location = New System.Drawing.Point(560, 9)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.ShowUpDown = True
        Me.dtpFin.Size = New System.Drawing.Size(78, 29)
        Me.dtpFin.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 16)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(231, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Confirme la hora de fin de envasado del articulo"
        '
        'dgvEnLinea
        '
        Me.dgvEnLinea.AllowUserToAddRows = False
        Me.dgvEnLinea.AllowUserToDeleteRows = False
        Me.dgvEnLinea.AllowUserToResizeColumns = False
        Me.dgvEnLinea.AllowUserToResizeRows = False
        Me.dgvEnLinea.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEnLinea.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEnLinea.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnLinea.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.lId, Me.DataGridViewTextBoxColumn2, Me.Apoyo, Me.formato})
        Me.dgvEnLinea.Location = New System.Drawing.Point(30, 81)
        Me.dgvEnLinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvEnLinea.Name = "dgvEnLinea"
        Me.dgvEnLinea.ReadOnly = True
        Me.dgvEnLinea.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvEnLinea.RowHeadersVisible = False
        Me.dgvEnLinea.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dgvEnLinea.RowTemplate.Height = 24
        Me.dgvEnLinea.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnLinea.Size = New System.Drawing.Size(396, 137)
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
        'formato
        '
        Me.formato.HeaderText = "formato"
        Me.formato.Name = "formato"
        Me.formato.ReadOnly = True
        Me.formato.Visible = False
        '
        'frmEntPersonalEnvasadoFinArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 373)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntPersonalEnvasadoFinArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntPersonalEnvasadoFinArticulo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvEnLinea, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnGuardar As System.Windows.Forms.Button
    Private WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents dgvEnLinea As System.Windows.Forms.DataGridView
    Private WithEvents ToolTip2 As System.Windows.Forms.ToolTip
   Private WithEvents lId As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
   Private WithEvents Apoyo As System.Windows.Forms.DataGridViewCheckBoxColumn
   Private WithEvents formato As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents lArticulo As System.Windows.Forms.Label
    Private WithEvents lEnvasado As System.Windows.Forms.Label
   Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
End Class
