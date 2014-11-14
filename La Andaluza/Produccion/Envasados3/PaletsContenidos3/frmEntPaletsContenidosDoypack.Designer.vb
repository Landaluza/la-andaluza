<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPaletsContenidosDoypack
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsContenidosDoypack))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidadCajas = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblCantidadCajas = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.SplitDoypack = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lCajasSuperiores = New System.Windows.Forms.Label()
        Me.PanDoypack = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SplitMermas = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dgvMermas = New System.Windows.Forms.DataGridView()
        Me.SCC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Existencias = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vaciar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Mover = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Combo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Indice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.chbVaciar = New System.Windows.Forms.CheckBox()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitDoypack, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitDoypack.Panel1.SuspendLayout()
        Me.SplitDoypack.Panel2.SuspendLayout()
        Me.SplitDoypack.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitMermas.Panel1.SuspendLayout()
        Me.SplitMermas.Panel2.SuspendLayout()
        Me.SplitMermas.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(76, 15)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraInicio.TabIndex = 0
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(76, 44)
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
        Me.txtCantidadCajas.Location = New System.Drawing.Point(298, 17)
        Me.txtCantidadCajas.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadCajas.MaxLength = 9
        Me.txtCantidadCajas.Name = "txtCantidadCajas"
        Me.txtCantidadCajas.Size = New System.Drawing.Size(121, 21)
        Me.txtCantidadCajas.TabIndex = 2
        Me.txtCantidadCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(32, 102)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(387, 50)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(29, 14)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraInicio.TabIndex = 0
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(29, 42)
        Me.lblHoraFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraFin.TabIndex = 1
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadCajas
        '
        Me.lblCantidadCajas.Location = New System.Drawing.Point(260, 14)
        Me.lblCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadCajas.Name = "lblCantidadCajas"
        Me.lblCantidadCajas.Size = New System.Drawing.Size(39, 28)
        Me.lblCantidadCajas.TabIndex = 2
        Me.lblCantidadCajas.Text = "Cajas"
        Me.lblCantidadCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(29, 76)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(83, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitDoypack
        '
        Me.SplitDoypack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitDoypack.Location = New System.Drawing.Point(0, 0)
        Me.SplitDoypack.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitDoypack.Name = "SplitDoypack"
        '
        'SplitDoypack.Panel1
        '
        Me.SplitDoypack.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitDoypack.Panel2
        '
        Me.SplitDoypack.Panel2.Controls.Add(Me.PanDoypack)
        Me.SplitDoypack.Panel2.Controls.Add(Me.Label2)
        Me.SplitDoypack.Size = New System.Drawing.Size(787, 279)
        Me.SplitDoypack.SplitterDistance = 471
        Me.SplitDoypack.SplitterWidth = 3
        Me.SplitDoypack.TabIndex = 1000000004
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lCajasSuperiores)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Controls.Add(Me.txtCantidadCajas)
        Me.Panel1.Controls.Add(Me.lblCantidadCajas)
        Me.Panel1.Controls.Add(Me.dtpHoraFin)
        Me.Panel1.Controls.Add(Me.lblHoraInicio)
        Me.Panel1.Controls.Add(Me.lblHoraFin)
        Me.Panel1.Controls.Add(Me.dtpHoraInicio)
        Me.Panel1.Location = New System.Drawing.Point(16, 49)
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
        Me.lCajasSuperiores.Location = New System.Drawing.Point(296, 39)
        Me.lCajasSuperiores.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lCajasSuperiores.Name = "lCajasSuperiores"
        Me.lCajasSuperiores.Size = New System.Drawing.Size(100, 9)
        Me.lCajasSuperiores.TabIndex = 8
        Me.lCajasSuperiores.Text = "Las cajas superan lo normal"
        Me.lCajasSuperiores.Visible = False
        '
        'PanDoypack
        '
        Me.PanDoypack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDoypack.Location = New System.Drawing.Point(0, 13)
        Me.PanDoypack.Margin = New System.Windows.Forms.Padding(2)
        Me.PanDoypack.Name = "PanDoypack"
        Me.PanDoypack.Size = New System.Drawing.Size(313, 266)
        Me.PanDoypack.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Doypack"
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
        Me.SplitMermas.Panel1.Controls.Add(Me.SplitDoypack)
        '
        'SplitMermas.Panel2
        '
        Me.SplitMermas.Panel2.Controls.Add(Me.Panel2)
        Me.SplitMermas.Panel2.Controls.Add(Me.Label3)
        Me.SplitMermas.Size = New System.Drawing.Size(787, 590)
        Me.SplitMermas.SplitterDistance = 279
        Me.SplitMermas.SplitterWidth = 3
        Me.SplitMermas.TabIndex = 1000000006
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvMermas)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 13)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(787, 295)
        Me.Panel2.TabIndex = 1
        '
        'dgvMermas
        '
        Me.dgvMermas.AllowUserToAddRows = False
        Me.dgvMermas.AllowUserToDeleteRows = False
        Me.dgvMermas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMermas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SCC, Me.Existencias, Me.Vaciar, Me.Mover, Me.Combo, Me.Indice})
        Me.dgvMermas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMermas.Location = New System.Drawing.Point(0, 24)
        Me.dgvMermas.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvMermas.Name = "dgvMermas"
        Me.dgvMermas.RowHeadersVisible = False
        Me.dgvMermas.RowTemplate.Height = 24
        Me.dgvMermas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMermas.Size = New System.Drawing.Size(787, 271)
        Me.dgvMermas.TabIndex = 1
        '
        'SCC
        '
        Me.SCC.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.SCC.HeaderText = "SCC"
        Me.SCC.Name = "SCC"
        '
        'Existencias
        '
        Me.Existencias.HeaderText = "Existencias"
        Me.Existencias.Name = "Existencias"
        '
        'Vaciar
        '
        Me.Vaciar.HeaderText = "Vaciar"
        Me.Vaciar.Name = "Vaciar"
        '
        'Mover
        '
        Me.Mover.HeaderText = "Mover a no conforme"
        Me.Mover.Name = "Mover"
        Me.Mover.Visible = False
        '
        'Combo
        '
        Me.Combo.HeaderText = "Combo"
        Me.Combo.Name = "Combo"
        Me.Combo.Visible = False
        '
        'Indice
        '
        Me.Indice.HeaderText = "Indice"
        Me.Indice.Name = "Indice"
        Me.Indice.Visible = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.chbVaciar)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(787, 24)
        Me.Panel3.TabIndex = 2
        '
        'chbVaciar
        '
        Me.chbVaciar.Dock = System.Windows.Forms.DockStyle.Right
        Me.chbVaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVaciar.Location = New System.Drawing.Point(671, 0)
        Me.chbVaciar.Name = "chbVaciar"
        Me.chbVaciar.Size = New System.Drawing.Size(116, 24)
        Me.chbVaciar.TabIndex = 0
        Me.chbVaciar.Text = "Vaciar"
        Me.chbVaciar.UseVisualStyleBackColor = True
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
        'frmEntPaletsContenidosDoypack
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(787, 615)
        Me.Controls.Add(Me.SplitMermas)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(431, 236)
        Me.Name = "frmEntPaletsContenidosDoypack"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.SplitMermas, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitDoypack.Panel1.ResumeLayout(False)
        Me.SplitDoypack.Panel2.ResumeLayout(False)
        Me.SplitDoypack.Panel2.PerformLayout()
        CType(Me.SplitDoypack, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitDoypack.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitMermas.Panel1.ResumeLayout(False)
        Me.SplitMermas.Panel2.ResumeLayout(False)
        Me.SplitMermas.Panel2.PerformLayout()
        CType(Me.SplitMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitMermas.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.dgvMermas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
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

    Private WithEvents SplitDoypack As System.Windows.Forms.SplitContainer
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents PanDoypack As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents SplitMermas As System.Windows.Forms.SplitContainer
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents dgvMermas As System.Windows.Forms.DataGridView
    Private WithEvents lCajasSuperiores As System.Windows.Forms.Label
    Friend WithEvents SCC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Existencias As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Vaciar As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Mover As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Combo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Indice As System.Windows.Forms.DataGridViewTextBoxColumn
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents chbVaciar As System.Windows.Forms.CheckBox
End Class
