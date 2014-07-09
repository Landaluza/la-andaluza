<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

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
        Me.components = New System.ComponentModel.Container()
        Dim LoteIDLabel As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEnvasados2))
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.tpgProduccion = New System.Windows.Forms.TabControl()
        Me.tbpFormatos = New System.Windows.Forms.TabPage()
        Me.tbpSeguimiento = New System.Windows.Forms.TabPage()
        Me.dgvSeguimientoProduccion = New System.Windows.Forms.DataGridView()
        Me.tbpProductos = New System.Windows.Forms.TabPage()
        Me.tbpPresion1 = New System.Windows.Forms.TabPage()
        Me.tbpContenido = New System.Windows.Forms.TabPage()
        Me.cboLineas = New System.Windows.Forms.ComboBox()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.timerSeguimiento = New System.Windows.Forms.Timer(Me.components)
        Me.txtEnvasadoID = New System.Windows.Forms.TextBox()
        Me.tpResumenPersonal = New System.Windows.Forms.TabPage()
        LoteIDLabel = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgProduccion.SuspendLayout()
        Me.tbpSeguimiento.SuspendLayout()
        CType(Me.dgvSeguimientoProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2)
        '
        'LoteIDLabel
        '
        LoteIDLabel.AutoSize = True
        LoteIDLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        LoteIDLabel.Location = New System.Drawing.Point(10, 32)
        LoteIDLabel.Name = "LoteIDLabel"
        LoteIDLabel.Size = New System.Drawing.Size(34, 15)
        LoteIDLabel.TabIndex = 0
        LoteIDLabel.Text = "Lote:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label8.Location = New System.Drawing.Point(10, 61)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(41, 15)
        Label8.TabIndex = 2
        Label8.Text = "Linea:"
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(233, 29)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(92, 21)
        Me.dtpFecha.TabIndex = 0
        Me.dtpFecha.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(344, 32)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(628, 46)
        Me.txtObservaciones.TabIndex = 4
        '
        'lblObs
        '
        Me.lblObs.Location = New System.Drawing.Point(342, 15)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(80, 13)
        Me.lblObs.TabIndex = 3
        Me.lblObs.Text = "Obsevaciones:"
        Me.lblObs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpgProduccion
        '
        Me.tpgProduccion.Controls.Add(Me.tbpFormatos)
        Me.tpgProduccion.Controls.Add(Me.tbpSeguimiento)
        Me.tpgProduccion.Controls.Add(Me.tbpProductos)
        Me.tpgProduccion.Controls.Add(Me.tbpPresion1)
        Me.tpgProduccion.Controls.Add(Me.tbpContenido)
        Me.tpgProduccion.Controls.Add(Me.tpResumenPersonal)
        Me.tpgProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpgProduccion.Location = New System.Drawing.Point(0, 110)
        Me.tpgProduccion.Multiline = True
        Me.tpgProduccion.Name = "tpgProduccion"
        Me.tpgProduccion.SelectedIndex = 0
        Me.tpgProduccion.Size = New System.Drawing.Size(981, 477)
        Me.tpgProduccion.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tpgProduccion.TabIndex = 2
        '
        'tbpFormatos
        '
        Me.tbpFormatos.Location = New System.Drawing.Point(4, 22)
        Me.tbpFormatos.Name = "tbpFormatos"
        Me.tbpFormatos.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpFormatos.Size = New System.Drawing.Size(973, 451)
        Me.tbpFormatos.TabIndex = 0
        Me.tbpFormatos.Text = "Formatos"
        Me.tbpFormatos.UseVisualStyleBackColor = True
        '
        'tbpSeguimiento
        '
        Me.tbpSeguimiento.Controls.Add(Me.dgvSeguimientoProduccion)
        Me.tbpSeguimiento.Location = New System.Drawing.Point(4, 22)
        Me.tbpSeguimiento.Name = "tbpSeguimiento"
        Me.tbpSeguimiento.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpSeguimiento.Size = New System.Drawing.Size(973, 451)
        Me.tbpSeguimiento.TabIndex = 10
        Me.tbpSeguimiento.Text = "Seguimiento Producción"
        Me.tbpSeguimiento.UseVisualStyleBackColor = True
        '
        'dgvSeguimientoProduccion
        '
        Me.dgvSeguimientoProduccion.AllowUserToAddRows = False
        Me.dgvSeguimientoProduccion.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow
        Me.dgvSeguimientoProduccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSeguimientoProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeguimientoProduccion.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSeguimientoProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSeguimientoProduccion.Location = New System.Drawing.Point(3, 3)
        Me.dgvSeguimientoProduccion.Name = "dgvSeguimientoProduccion"
        Me.dgvSeguimientoProduccion.ReadOnly = True
        Me.dgvSeguimientoProduccion.RowHeadersVisible = False
        Me.dgvSeguimientoProduccion.RowTemplate.Height = 24
        Me.dgvSeguimientoProduccion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSeguimientoProduccion.Size = New System.Drawing.Size(967, 445)
        Me.dgvSeguimientoProduccion.TabIndex = 0
        '
        'tbpProductos
        '
        Me.tbpProductos.Location = New System.Drawing.Point(4, 22)
        Me.tbpProductos.Name = "tbpProductos"
        Me.tbpProductos.Size = New System.Drawing.Size(973, 451)
        Me.tbpProductos.TabIndex = 11
        Me.tbpProductos.Text = "Productos"
        Me.tbpProductos.UseVisualStyleBackColor = True
        '
        'tbpPresion1
        '
        Me.tbpPresion1.Location = New System.Drawing.Point(4, 22)
        Me.tbpPresion1.Name = "tbpPresion1"
        Me.tbpPresion1.Size = New System.Drawing.Size(973, 451)
        Me.tbpPresion1.TabIndex = 12
        Me.tbpPresion1.Text = "Presion llenadora 1"
        Me.tbpPresion1.UseVisualStyleBackColor = True
        '
        'tbpContenido
        '
        Me.tbpContenido.Location = New System.Drawing.Point(4, 22)
        Me.tbpContenido.Name = "tbpContenido"
        Me.tbpContenido.Size = New System.Drawing.Size(973, 451)
        Me.tbpContenido.TabIndex = 13
        Me.tbpContenido.Text = "Contenido efectivo"
        Me.tbpContenido.UseVisualStyleBackColor = True
        '
        'cboLineas
        '
        Me.cboLineas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLineas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLineas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineas.FormattingEnabled = True
        Me.cboLineas.Location = New System.Drawing.Point(57, 56)
        Me.cboLineas.Name = "cboLineas"
        Me.cboLineas.Size = New System.Drawing.Size(268, 23)
        Me.cboLineas.TabIndex = 3
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.Label2)
        Me.grbDatos.Controls.Add(Me.lblLote)
        Me.grbDatos.Controls.Add(Me.lblObs)
        Me.grbDatos.Controls.Add(Me.cboLineas)
        Me.grbDatos.Controls.Add(Me.txtObservaciones)
        Me.grbDatos.Controls.Add(LoteIDLabel)
        Me.grbDatos.Controls.Add(Me.dtpFecha)
        Me.grbDatos.Controls.Add(Label8)
        Me.grbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbDatos.Location = New System.Drawing.Point(0, 25)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(981, 85)
        Me.grbDatos.TabIndex = 1
        Me.grbDatos.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(186, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Fecha"
        Me.Label2.Visible = False
        '
        'lblLote
        '
        Me.lblLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(57, 14)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(116, 36)
        Me.lblLote.TabIndex = 1
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'timerSeguimiento
        '
        Me.timerSeguimiento.Enabled = True
        Me.timerSeguimiento.Interval = 60000
        '
        'txtEnvasadoID
        '
        Me.txtEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoID.Enabled = False
        Me.txtEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvasadoID.Location = New System.Drawing.Point(521, 2)
        Me.txtEnvasadoID.MaxLength = 9
        Me.txtEnvasadoID.Name = "txtEnvasadoID"
        Me.txtEnvasadoID.Size = New System.Drawing.Size(70, 21)
        Me.txtEnvasadoID.TabIndex = 9
        Me.txtEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEnvasadoID.Visible = False
        '
        'tpResumenPersonal
        '
        Me.tpResumenPersonal.Location = New System.Drawing.Point(4, 22)
        Me.tpResumenPersonal.Name = "tpResumenPersonal"
        Me.tpResumenPersonal.Padding = New System.Windows.Forms.Padding(3)
        Me.tpResumenPersonal.Size = New System.Drawing.Size(973, 451)
        Me.tpResumenPersonal.TabIndex = 14
        Me.tpResumenPersonal.Text = "Resumen personal"
        Me.tpResumenPersonal.UseVisualStyleBackColor = True
        '
        'frmEntEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(981, 587)
        Me.ControlBox = True
        Me.Controls.Add(Me.tpgProduccion)
        Me.Controls.Add(Me.txtEnvasadoID)
        Me.Controls.Add(Me.grbDatos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = True
        Me.Name = "frmEntEnvasados2"
        Me.Text = "Envasados2"
        Me.Controls.SetChildIndex(Me.grbDatos, 0)
        Me.Controls.SetChildIndex(Me.txtEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.tpgProduccion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgProduccion.ResumeLayout(False)
        Me.tbpSeguimiento.ResumeLayout(False)
        CType(Me.dgvSeguimientoProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents lblEnvasadoID As System.Windows.Forms.Label
    Private WithEvents tbpFormatos As System.Windows.Forms.TabPage
    Private WithEvents tbpSeguimiento As System.Windows.Forms.TabPage
    Private WithEvents tbpProductos As System.Windows.Forms.TabPage
    Private WithEvents tbpPresion1 As System.Windows.Forms.TabPage
    Private WithEvents tbpContenido As System.Windows.Forms.TabPage
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblObs As System.Windows.Forms.Label
    Private WithEvents grbDatos As System.Windows.Forms.GroupBox
    Private WithEvents timerSeguimiento As System.Windows.Forms.Timer
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents lblLote As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents dgvSeguimientoProduccion As System.Windows.Forms.DataGridView
    Public WithEvents cboLineas As System.Windows.Forms.ComboBox
    Private WithEvents txtEnvasadoID As System.Windows.Forms.TextBox
    Private WithEvents tpgProduccion As System.Windows.Forms.TabControl
    Private WithEvents tpResumenPersonal As System.Windows.Forms.TabPage
End Class
