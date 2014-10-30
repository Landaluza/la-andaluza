<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPaletsContenidosMonodosis
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsContenidosMonodosis))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidadCajas = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblCantidadCajas = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lCajasSuperiores = New System.Windows.Forms.Label()
        Me.lnoconforme = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnMonodosis = New System.Windows.Forms.Button()
        Me.cboMonodosis = New System.Windows.Forms.ComboBox()
        Me.SplitMermas = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvMermas = New System.Windows.Forms.DataGridView()
        Me.SCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vaciar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Mover = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitMermas.Panel1.SuspendLayout()
        Me.SplitMermas.Panel2.SuspendLayout()
        Me.SplitMermas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraInicio.Location = New System.Drawing.Point(71, 8)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraInicio.TabIndex = 0
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.dtpHoraFin.Location = New System.Drawing.Point(71, 44)
        Me.dtpHoraFin.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraFin.TabIndex = 1
        '
        'txtCantidadCajas
        '
        Me.txtCantidadCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCajas.Location = New System.Drawing.Point(293, 10)
        Me.txtCantidadCajas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadCajas.MaxLength = 9
        Me.txtCantidadCajas.Name = "txtCantidadCajas"
        Me.txtCantidadCajas.Size = New System.Drawing.Size(131, 21)
        Me.txtCantidadCajas.TabIndex = 2
        Me.txtCantidadCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(27, 102)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(397, 50)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(24, 6)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraInicio.TabIndex = 0
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(24, 42)
        Me.lblHoraFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraFin.TabIndex = 1
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadCajas
        '
        Me.lblCantidadCajas.Location = New System.Drawing.Point(255, 6)
        Me.lblCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadCajas.Name = "lblCantidadCajas"
        Me.lblCantidadCajas.Size = New System.Drawing.Size(39, 28)
        Me.lblCantidadCajas.TabIndex = 2
        Me.lblCantidadCajas.Text = "Cajas"
        Me.lblCantidadCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(24, 76)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(83, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lCajasSuperiores)
        Me.Panel1.Controls.Add(Me.lnoconforme)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.btnMonodosis)
        Me.Panel1.Controls.Add(Me.cboMonodosis)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Controls.Add(Me.txtCantidadCajas)
        Me.Panel1.Controls.Add(Me.lblCantidadCajas)
        Me.Panel1.Controls.Add(Me.dtpHoraFin)
        Me.Panel1.Controls.Add(Me.lblHoraInicio)
        Me.Panel1.Controls.Add(Me.lblHoraFin)
        Me.Panel1.Controls.Add(Me.dtpHoraInicio)
        Me.Panel1.Location = New System.Drawing.Point(32, 31)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(446, 165)
        Me.Panel1.TabIndex = 1000000005
        '
        'lCajasSuperiores
        '
        Me.lCajasSuperiores.AutoSize = True
        Me.lCajasSuperiores.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCajasSuperiores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lCajasSuperiores.Location = New System.Drawing.Point(291, 31)
        Me.lCajasSuperiores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lCajasSuperiores.Name = "lCajasSuperiores"
        Me.lCajasSuperiores.Size = New System.Drawing.Size(100, 9)
        Me.lCajasSuperiores.TabIndex = 1000000014
        Me.lCajasSuperiores.Text = "Las cajas superan lo normal"
        Me.lCajasSuperiores.Visible = False
        '
        'lnoconforme
        '
        Me.lnoconforme.AutoSize = True
        Me.lnoconforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnoconforme.ForeColor = System.Drawing.Color.Red
        Me.lnoconforme.Location = New System.Drawing.Point(291, 66)
        Me.lnoconforme.Name = "lnoconforme"
        Me.lnoconforme.Size = New System.Drawing.Size(93, 13)
        Me.lnoconforme.TabIndex = 1000000013
        Me.lnoconforme.Text = "Palet no conforme"
        Me.lnoconforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnoconforme.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(255, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SCC"
        '
        'btnMonodosis
        '
        Me.btnMonodosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonodosis.FlatAppearance.BorderSize = 0
        Me.btnMonodosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonodosis.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.btnMonodosis.Location = New System.Drawing.Point(393, 42)
        Me.btnMonodosis.Margin = New System.Windows.Forms.Padding(2)
        Me.btnMonodosis.Name = "btnMonodosis"
        Me.btnMonodosis.Size = New System.Drawing.Size(31, 26)
        Me.btnMonodosis.TabIndex = 8
        Me.btnMonodosis.UseVisualStyleBackColor = True
        '
        'cboMonodosis
        '
        Me.cboMonodosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMonodosis.FormattingEnabled = True
        Me.cboMonodosis.Location = New System.Drawing.Point(293, 44)
        Me.cboMonodosis.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMonodosis.Name = "cboMonodosis"
        Me.cboMonodosis.Size = New System.Drawing.Size(101, 21)
        Me.cboMonodosis.TabIndex = 7
        '
        'SplitMermas
        '
        Me.SplitMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitMermas.Location = New System.Drawing.Point(0, 25)
        Me.SplitMermas.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitMermas.Name = "SplitMermas"
        Me.SplitMermas.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitMermas.Panel1
        '
        Me.SplitMermas.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitMermas.Panel2
        '
        Me.SplitMermas.Panel2.Controls.Add(Me.Panel2)
        Me.SplitMermas.Panel2.Controls.Add(Me.Label3)
        Me.SplitMermas.Size = New System.Drawing.Size(517, 448)
        Me.SplitMermas.SplitterDistance = 212
        Me.SplitMermas.SplitterWidth = 3
        Me.SplitMermas.TabIndex = 1000000006
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvMermas)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(517, 220)
        Me.Panel2.TabIndex = 1
        '
        'dgvMermas
        '
        Me.dgvMermas.AllowUserToAddRows = False
        Me.dgvMermas.AllowUserToDeleteRows = False
        Me.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMermas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCC, Me.Existencias, Me.Vaciar, Me.Mover})
        Me.dgvMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMermas.Location = New System.Drawing.Point(0, 0)
        Me.dgvMermas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMermas.Name = "dgvMermas"
        Me.dgvMermas.RowHeadersVisible = False
        Me.dgvMermas.RowTemplate.Height = 24
        Me.dgvMermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMermas.Size = New System.Drawing.Size(517, 220)
        Me.dgvMermas.TabIndex = 0
        '
        'SCC
        '
        Me.SCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCC.HeaderText = "SCC"
        Me.SCC.Name = "SCC"
        Me.SCC.ReadOnly = True
        '
        'Existencias
        '
        Me.Existencias.HeaderText = "Existencias"
        Me.Existencias.Name = "Existencias"
        Me.Existencias.ReadOnly = True
        '
        'Vaciar
        '
        Me.Vaciar.HeaderText = "Vaciar"
        Me.Vaciar.Name = "Vaciar"
        '
        'Mover
        '
        Me.Mover.HeaderText = "Mover a NC"
        Me.Mover.Name = "Mover"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label3.Location = New System.Drawing.Point(0, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mermas"
        '
        'frmEntPaletsContenidosMonodosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(517, 473)
        Me.Controls.Add(Me.SplitMermas)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(428, 235)
        Me.Name = "frmEntPaletsContenidosMonodosis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.SplitMermas, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitMermas.Panel1.ResumeLayout(False)
        Me.SplitMermas.Panel2.ResumeLayout(False)
        Me.SplitMermas.Panel2.PerformLayout()
        CType(Me.SplitMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitMermas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents txtCantidadCajas As System.windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.windows.Forms.TextBox
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblCantidadCajas As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label

    Private WithEvents SplitMermas As System.Windows.Forms.SplitContainer
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents dgvMermas As System.Windows.Forms.DataGridView
    Private WithEvents lnoconforme As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnMonodosis As System.Windows.Forms.Button
    Private WithEvents cboMonodosis As System.Windows.Forms.ComboBox
    Private WithEvents lCajasSuperiores As System.Windows.Forms.Label
    Friend WithEvents SCC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vaciar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Mover As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
