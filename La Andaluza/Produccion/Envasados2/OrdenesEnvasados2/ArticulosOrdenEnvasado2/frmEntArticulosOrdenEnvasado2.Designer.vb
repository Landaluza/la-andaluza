<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntArticulosOrdenEnvasado2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosOrdenEnvasado2))
        Me.txtArticuloOrdenEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboLineaID = New System.Windows.Forms.ComboBox()
        Me.cboArticuloEnvasadoID = New System.Windows.Forms.ComboBox()
        Me.txtCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloOrdenEnvasadoID = New System.Windows.Forms.Label()
        Me.lblLineaID = New System.Windows.Forms.Label()
        Me.lblArticuloEnvasadoID = New System.Windows.Forms.Label()
        Me.lblCajas = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPalets = New System.Windows.Forms.Label()
        Me.LabelPalets = New System.Windows.Forms.Label()

        Me.dgvPicos = New System.Windows.Forms.DataGridView()
        Me.grbPicos = New System.Windows.Forms.GroupBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        CType(Me.dgvPicos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbPicos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2)
        '
        'txtArticuloOrdenEnvasadoID
        '
        Me.txtArticuloOrdenEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloOrdenEnvasadoID.EsUnicoCampo = ""
        Me.txtArticuloOrdenEnvasadoID.EsUnicoCampoID = ""
        Me.txtArticuloOrdenEnvasadoID.EsUnicoID = 0
        Me.txtArticuloOrdenEnvasadoID.EsUnicoTabla = ""
        Me.txtArticuloOrdenEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloOrdenEnvasadoID.Location = New System.Drawing.Point(108, 3)
        Me.txtArticuloOrdenEnvasadoID.MaxLength = 9
        Me.txtArticuloOrdenEnvasadoID.Minimo = 0
        Me.txtArticuloOrdenEnvasadoID.Modificado = False
        Me.txtArticuloOrdenEnvasadoID.Name = "txtArticuloOrdenEnvasadoID"
        Me.txtArticuloOrdenEnvasadoID.Numerico_EsNumerico = False
        Me.txtArticuloOrdenEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtArticuloOrdenEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtArticuloOrdenEnvasadoID.Obligatorio = False
        Me.txtArticuloOrdenEnvasadoID.ParametroID = 0
        Me.txtArticuloOrdenEnvasadoID.Size = New System.Drawing.Size(56, 21)
        Me.txtArticuloOrdenEnvasadoID.TabIndex = 0
        Me.txtArticuloOrdenEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloOrdenEnvasadoID.ValorMaximo = 0.0R
        Me.txtArticuloOrdenEnvasadoID.ValorMinimo = 0.0R
        Me.txtArticuloOrdenEnvasadoID.Visible = False
        '
        'cboLineaID
        '
        Me.cboLineaID.Enabled = False
        Me.cboLineaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLineaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineaID.Location = New System.Drawing.Point(108, 30)
        Me.cboLineaID.Name = "cboLineaID"
        Me.cboLineaID.Size = New System.Drawing.Size(315, 23)
        Me.cboLineaID.TabIndex = 1
        Me.cboLineaID.Visible = False
        '
        'cboArticuloEnvasadoID
        '
        Me.cboArticuloEnvasadoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArticuloEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloEnvasadoID.Location = New System.Drawing.Point(108, 59)
        Me.cboArticuloEnvasadoID.Name = "cboArticuloEnvasadoID"
        Me.cboArticuloEnvasadoID.Size = New System.Drawing.Size(639, 23)
        Me.cboArticuloEnvasadoID.TabIndex = 2
        '
        'txtCajas
        '
        Me.txtCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajas.EsUnicoCampo = ""
        Me.txtCajas.EsUnicoCampoID = ""
        Me.txtCajas.EsUnicoID = 0
        Me.txtCajas.EsUnicoTabla = ""
        Me.txtCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Location = New System.Drawing.Point(108, 88)
        Me.txtCajas.MaxLength = 9
        Me.txtCajas.Minimo = 0
        Me.txtCajas.Modificado = False
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Numerico_EsNumerico = False
        Me.txtCajas.Numerico_NumeroDoublees = 0
        Me.txtCajas.Numerico_SeparadorMiles = False
        Me.txtCajas.Obligatorio = False
        Me.txtCajas.ParametroID = 0
        Me.txtCajas.Size = New System.Drawing.Size(56, 21)
        Me.txtCajas.TabIndex = 3
        Me.txtCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajas.ValorMaximo = 0.0R
        Me.txtCajas.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 140)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(639, 21)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblArticuloOrdenEnvasadoID
        '
        Me.lblArticuloOrdenEnvasadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloOrdenEnvasadoID.Location = New System.Drawing.Point(17, 0)
        Me.lblArticuloOrdenEnvasadoID.Name = "lblArticuloOrdenEnvasadoID"
        Me.lblArticuloOrdenEnvasadoID.Size = New System.Drawing.Size(85, 21)
        Me.lblArticuloOrdenEnvasadoID.TabIndex = 0
        Me.lblArticuloOrdenEnvasadoID.Text = "ID"
        Me.lblArticuloOrdenEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloOrdenEnvasadoID.Visible = False
        '
        'lblLineaID
        '
        Me.lblLineaID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLineaID.Location = New System.Drawing.Point(17, 27)
        Me.lblLineaID.Name = "lblLineaID"
        Me.lblLineaID.Size = New System.Drawing.Size(85, 21)
        Me.lblLineaID.TabIndex = 1
        Me.lblLineaID.Text = "Linea"
        Me.lblLineaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLineaID.Visible = False
        '
        'lblArticuloEnvasadoID
        '
        Me.lblArticuloEnvasadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloEnvasadoID.Location = New System.Drawing.Point(17, 56)
        Me.lblArticuloEnvasadoID.Name = "lblArticuloEnvasadoID"
        Me.lblArticuloEnvasadoID.Size = New System.Drawing.Size(85, 21)
        Me.lblArticuloEnvasadoID.TabIndex = 2
        Me.lblArticuloEnvasadoID.Text = "Articulo"
        Me.lblArticuloEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCajas
        '
        Me.lblCajas.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCajas.Location = New System.Drawing.Point(17, 85)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(85, 21)
        Me.lblCajas.TabIndex = 3
        Me.lblCajas.Text = "Cajas"
        Me.lblCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 137)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(85, 21)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 14.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 645.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tlpMiddle.Controls.Add(Me.lblArticuloOrdenEnvasadoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloOrdenEnvasadoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblLineaID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboLineaID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloEnvasadoID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloEnvasadoID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCajas, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCajas, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblPalets, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.LabelPalets, 1, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(763, 181)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'lblPalets
        '
        Me.lblPalets.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblPalets.Location = New System.Drawing.Point(108, 112)
        Me.lblPalets.Name = "lblPalets"
        Me.lblPalets.Size = New System.Drawing.Size(56, 25)
        Me.lblPalets.TabIndex = 5
        Me.lblPalets.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'LabelPalets
        '
        Me.LabelPalets.Dock = System.Windows.Forms.DockStyle.Top
        Me.LabelPalets.Location = New System.Drawing.Point(17, 112)
        Me.LabelPalets.Name = "LabelPalets"
        Me.LabelPalets.Size = New System.Drawing.Size(85, 21)
        Me.LabelPalets.TabIndex = 1000000003
        Me.LabelPalets.Text = "Palets"
        Me.LabelPalets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'dgvPicos
        '
        Me.dgvPicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPicos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPicos.Location = New System.Drawing.Point(6, 14)
        Me.dgvPicos.Name = "dgvPicos"
        Me.dgvPicos.RowTemplate.Height = 24
        Me.dgvPicos.Size = New System.Drawing.Size(727, 146)
        Me.dgvPicos.TabIndex = 1000000002
        '
        'grbPicos
        '
        Me.grbPicos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbPicos.Controls.Add(Me.dgvPicos)
        Me.grbPicos.Location = New System.Drawing.Point(12, 227)
        Me.grbPicos.Name = "grbPicos"
        Me.grbPicos.Size = New System.Drawing.Size(739, 166)
        Me.grbPicos.TabIndex = 1000000003
        Me.grbPicos.TabStop = False
        Me.grbPicos.Text = "Picos del Artículo."
        '
        'frmEntArticulosOrdenEnvasado2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(763, 405)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.grbPicos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(389, 250)
        Me.Name = "frmEntArticulosOrdenEnvasado2"
        Me.Text = "ArticulosOrdenEnvasado"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.grbPicos, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        CType(Me.dgvPicos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbPicos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtArticuloOrdenEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboLineaID As System.Windows.Forms.ComboBox
    Private WithEvents cboArticuloEnvasadoID As System.Windows.Forms.ComboBox
    Private WithEvents txtCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloOrdenEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblLineaID As System.Windows.Forms.Label
    Private WithEvents lblArticuloEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblCajas As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblPalets As System.Windows.Forms.Label
    Private WithEvents LabelPalets As System.Windows.Forms.Label
    Private WithEvents dgvPicos As System.Windows.Forms.DataGridView
    Private WithEvents grbPicos As System.Windows.Forms.GroupBox
End Class
