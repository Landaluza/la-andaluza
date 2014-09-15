<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLisEnvPorArticuloPrimario
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
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.btnPorDias = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvEnvasados = New System.Windows.Forms.DataGridView()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnExcel
        '
        Me.btnExcel.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = Global.La_Andaluza.My.Resources.Resources.page_excel_16
        Me.btnExcel.Location = New System.Drawing.Point(835, 27)
        Me.btnExcel.Margin = New System.Windows.Forms.Padding(4)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(31, 22)
        Me.btnExcel.TabIndex = 5
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'dtpHasta
        '
        Me.dtpHasta.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(665, 27)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(123, 22)
        Me.dtpHasta.TabIndex = 3
        '
        'btnPorDias
        '
        Me.btnPorDias.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnPorDias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPorDias.FlatAppearance.BorderSize = 0
        Me.btnPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorDias.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.btnPorDias.Location = New System.Drawing.Point(796, 27)
        Me.btnPorDias.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPorDias.Name = "btnPorDias"
        Me.btnPorDias.Size = New System.Drawing.Size(31, 22)
        Me.btnPorDias.TabIndex = 4
        Me.btnPorDias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnPorDias.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(607, 30)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Hasta:"
        '
        'dgvEnvasados
        '
        Me.dgvEnvasados.AllowUserToAddRows = False
        Me.dgvEnvasados.AllowUserToDeleteRows = False
        Me.dgvEnvasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvEnvasados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnvasados.Location = New System.Drawing.Point(25, 76)
        Me.dgvEnvasados.Margin = New System.Windows.Forms.Padding(4)
        Me.dgvEnvasados.Name = "dgvEnvasados"
        Me.dgvEnvasados.ReadOnly = True
        Me.dgvEnvasados.RowTemplate.Height = 24
        Me.dgvEnvasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnvasados.Size = New System.Drawing.Size(1136, 824)
        Me.dgvEnvasados.TabIndex = 1
        '
        'dtpDesde
        '
        Me.dtpDesde.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(467, 27)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(115, 22)
        Me.dtpDesde.TabIndex = 1
        Me.dtpDesde.Value = New Date(2011, 1, 1, 0, 0, 0, 0)
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(391, 30)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Desde:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnPorDias)
        Me.Panel1.Controls.Add(Me.btnExcel)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.dtpHasta)
        Me.Panel1.Controls.Add(Me.dtpDesde)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1186, 76)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1161, 76)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(25, 847)
        Me.Panel2.TabIndex = 23
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 76)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(25, 847)
        Me.Panel3.TabIndex = 24
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(25, 900)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1136, 23)
        Me.Panel4.TabIndex = 25
        '
        'BackgroundWorker1
        '
        '
        'frmLisEnvPorArticuloPrimario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1186, 923)
        Me.Controls.Add(Me.dgvEnvasados)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmLisEnvPorArticuloPrimario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos primarios entre fechas"
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnExcel As System.Windows.Forms.Button
    Private WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents btnPorDias As System.Windows.Forms.Button
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dgvEnvasados As System.Windows.Forms.DataGridView
    Private WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
