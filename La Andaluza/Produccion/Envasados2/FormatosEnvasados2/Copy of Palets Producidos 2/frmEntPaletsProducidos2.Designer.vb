<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsProducidos2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsProducidos2))
        Me.lblSSCC = New System.Windows.Forms.Label()
        Me.lblSSCCtext = New System.Windows.Forms.Label()
        Me.lblPaletProducidoID = New System.Windows.Forms.Label()

        Me.grbContenido = New System.Windows.Forms.GroupBox()
        Me.panConPal = New System.Windows.Forms.Panel()
        Me.grbIncompletos = New System.Windows.Forms.GroupBox()
        Me.grbDgvImcompletos = New System.Windows.Forms.GroupBox()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.dgvIncompletos = New System.Windows.Forms.DataGridView()
        Me.lblCajasCompletar = New System.Windows.Forms.Label()
        Me.lblPartePaletContenido = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.grbDatos = New System.Windows.Forms.GroupBox()
        Me.chbMultilote = New System.Windows.Forms.CheckBox()
        Me.chbEnAlmacen = New System.Windows.Forms.CheckBox()
        Me.chbTerminado = New System.Windows.Forms.CheckBox()
        Me.lblObs = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Pactions = New System.Windows.Forms.Panel()
        Me.btnCompletar = New System.Windows.Forms.Button()
        Me.btnNoCoincide = New System.Windows.Forms.Button()
        Me.btnNoAlmacen = New System.Windows.Forms.Button()
        Me.TimerSSCC = New System.Windows.Forms.Timer(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContenido.SuspendLayout()
        Me.grbIncompletos.SuspendLayout()
        Me.grbDgvImcompletos.SuspendLayout()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvIncompletos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbDatos.SuspendLayout()
        Me.Pactions.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'lblSSCC
        '
        Me.lblSSCC.AutoSize = True
        Me.lblSSCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSCC.Location = New System.Drawing.Point(6, 11)
        Me.lblSSCC.Name = "lblSSCC"
        Me.lblSSCC.Size = New System.Drawing.Size(60, 24)
        Me.lblSSCC.TabIndex = 1
        Me.lblSSCC.Text = "SSCC"
        Me.lblSSCC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblSSCCtext
        '
        Me.lblSSCCtext.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblSSCCtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSCCtext.ForeColor = System.Drawing.Color.Blue
        Me.lblSSCCtext.Location = New System.Drawing.Point(6, 35)
        Me.lblSSCCtext.Name = "lblSSCCtext"
        Me.lblSSCCtext.Size = New System.Drawing.Size(232, 40)
        Me.lblSSCCtext.TabIndex = 12
        '
        'lblPaletProducidoID
        '
        Me.lblPaletProducidoID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPaletProducidoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPaletProducidoID.ForeColor = System.Drawing.Color.Blue
        Me.lblPaletProducidoID.Location = New System.Drawing.Point(420, 76)
        Me.lblPaletProducidoID.Name = "lblPaletProducidoID"
        Me.lblPaletProducidoID.Size = New System.Drawing.Size(30, 25)
        Me.lblPaletProducidoID.TabIndex = 13
        Me.lblPaletProducidoID.Visible = False
        '
        'tlpTop
        '




        '
        'grbContenido
        '
        Me.grbContenido.Controls.Add(Me.panConPal)
        Me.grbContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbContenido.Location = New System.Drawing.Point(0, 105)
        Me.grbContenido.Name = "grbContenido"
        Me.grbContenido.Size = New System.Drawing.Size(801, 197)
        Me.grbContenido.TabIndex = 1
        Me.grbContenido.TabStop = False
        Me.grbContenido.Text = "Contenido"
        '
        'panConPal
        '
        Me.panConPal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panConPal.Location = New System.Drawing.Point(3, 16)
        Me.panConPal.Name = "panConPal"
        Me.panConPal.Size = New System.Drawing.Size(795, 178)
        Me.panConPal.TabIndex = 0
        '
        'grbIncompletos
        '
        Me.grbIncompletos.Controls.Add(Me.grbDgvImcompletos)
        Me.grbIncompletos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbIncompletos.Location = New System.Drawing.Point(0, 302)
        Me.grbIncompletos.Name = "grbIncompletos"
        Me.grbIncompletos.Size = New System.Drawing.Size(801, 277)
        Me.grbIncompletos.TabIndex = 2
        Me.grbIncompletos.TabStop = False
        '
        'grbDgvImcompletos
        '
        Me.grbDgvImcompletos.Controls.Add(Me.dgvMovimientos)
        Me.grbDgvImcompletos.Controls.Add(Me.dgvIncompletos)
        Me.grbDgvImcompletos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbDgvImcompletos.Location = New System.Drawing.Point(3, 14)
        Me.grbDgvImcompletos.Name = "grbDgvImcompletos"
        Me.grbDgvImcompletos.Size = New System.Drawing.Size(795, 260)
        Me.grbDgvImcompletos.TabIndex = 0
        Me.grbDgvImcompletos.TabStop = False
        Me.grbDgvImcompletos.Text = "Palets incompletos."
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToResizeRows = False
        Me.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.dgvMovimientos.Location = New System.Drawing.Point(3, 150)
        Me.dgvMovimientos.MultiSelect = False
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.RowTemplate.Height = 24
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(789, 107)
        Me.dgvMovimientos.TabIndex = 1
        '
        'dgvIncompletos
        '
        Me.dgvIncompletos.AllowUserToResizeRows = False
        Me.dgvIncompletos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvIncompletos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvIncompletos.Dock = System.Windows.Forms.DockStyle.Top
        Me.dgvIncompletos.Location = New System.Drawing.Point(3, 16)
        Me.dgvIncompletos.MultiSelect = False
        Me.dgvIncompletos.Name = "dgvIncompletos"
        Me.dgvIncompletos.RowHeadersVisible = False
        Me.dgvIncompletos.RowTemplate.Height = 24
        Me.dgvIncompletos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvIncompletos.Size = New System.Drawing.Size(789, 134)
        Me.dgvIncompletos.TabIndex = 0
        '
        'lblCajasCompletar
        '
        Me.lblCajasCompletar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblCajasCompletar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCajasCompletar.ForeColor = System.Drawing.Color.Blue
        Me.lblCajasCompletar.Location = New System.Drawing.Point(749, 76)
        Me.lblCajasCompletar.Name = "lblCajasCompletar"
        Me.lblCajasCompletar.Size = New System.Drawing.Size(29, 25)
        Me.lblCajasCompletar.TabIndex = 5
        Me.lblCajasCompletar.Visible = False
        '
        'lblPartePaletContenido
        '
        Me.lblPartePaletContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblPartePaletContenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPartePaletContenido.ForeColor = System.Drawing.Color.Blue
        Me.lblPartePaletContenido.Location = New System.Drawing.Point(564, 76)
        Me.lblPartePaletContenido.Name = "lblPartePaletContenido"
        Me.lblPartePaletContenido.Size = New System.Drawing.Size(42, 25)
        Me.lblPartePaletContenido.TabIndex = 4
        Me.lblPartePaletContenido.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(376, 82)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Cajas"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label5.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(612, 84)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "PartePaletContenidoID"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label6.Visible = False
        '
        'grbDatos
        '
        Me.grbDatos.Controls.Add(Me.chbMultilote)
        Me.grbDatos.Controls.Add(Me.chbEnAlmacen)
        Me.grbDatos.Controls.Add(Me.chbTerminado)
        Me.grbDatos.Controls.Add(Me.lblObs)
        Me.grbDatos.Controls.Add(Me.Label1)
        Me.grbDatos.Controls.Add(Me.lblSSCCtext)
        Me.grbDatos.Controls.Add(Me.Label6)
        Me.grbDatos.Controls.Add(Me.lblPaletProducidoID)
        Me.grbDatos.Controls.Add(Me.lblPartePaletContenido)
        Me.grbDatos.Controls.Add(Me.Label5)
        Me.grbDatos.Controls.Add(Me.lblSSCC)
        Me.grbDatos.Controls.Add(Me.lblCajasCompletar)
        Me.grbDatos.Controls.Add(Me.txtObservaciones)
        Me.grbDatos.Dock = System.Windows.Forms.DockStyle.Top
        Me.grbDatos.Location = New System.Drawing.Point(0, 0)
        Me.grbDatos.Name = "grbDatos"
        Me.grbDatos.Size = New System.Drawing.Size(801, 105)
        Me.grbDatos.TabIndex = 0
        Me.grbDatos.TabStop = False
        Me.grbDatos.Text = "Datos"
        '
        'chbMultilote
        '
        Me.chbMultilote.AutoSize = True
        Me.chbMultilote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMultilote.Location = New System.Drawing.Point(176, 79)
        Me.chbMultilote.Name = "chbMultilote"
        Me.chbMultilote.Size = New System.Drawing.Size(66, 17)
        Me.chbMultilote.TabIndex = 17
        Me.chbMultilote.Text = "MultiLote"
        Me.chbMultilote.UseVisualStyleBackColor = True
        '
        'chbEnAlmacen
        '
        Me.chbEnAlmacen.AutoSize = True
        Me.chbEnAlmacen.Checked = True
        Me.chbEnAlmacen.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEnAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEnAlmacen.Location = New System.Drawing.Point(88, 79)
        Me.chbEnAlmacen.Name = "chbEnAlmacen"
        Me.chbEnAlmacen.Size = New System.Drawing.Size(79, 17)
        Me.chbEnAlmacen.TabIndex = 16
        Me.chbEnAlmacen.Text = "En almacen"
        Me.chbEnAlmacen.UseVisualStyleBackColor = True
        '
        'chbTerminado
        '
        Me.chbTerminado.AutoSize = True
        Me.chbTerminado.Checked = True
        Me.chbTerminado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbTerminado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTerminado.Location = New System.Drawing.Point(6, 79)
        Me.chbTerminado.Name = "chbTerminado"
        Me.chbTerminado.Size = New System.Drawing.Size(73, 17)
        Me.chbTerminado.TabIndex = 15
        Me.chbTerminado.Text = "Terminado"
        Me.chbTerminado.UseVisualStyleBackColor = True
        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(255, 17)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(141, 15)
        Me.lblObs.TabIndex = 8
        Me.lblObs.Text = "Observaciones del palet "
        Me.lblObs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(455, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PaletProducidoID"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Location = New System.Drawing.Point(258, 35)
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(537, 40)
        Me.txtObservaciones.TabIndex = 14
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'Pactions
        '
        Me.Pactions.Controls.Add(Me.btnCompletar)
        Me.Pactions.Controls.Add(Me.btnNoCoincide)
        Me.Pactions.Controls.Add(Me.btnNoAlmacen)
        Me.Pactions.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Pactions.Location = New System.Drawing.Point(0, 579)
        Me.Pactions.Name = "Pactions"
        Me.Pactions.Size = New System.Drawing.Size(801, 35)
        Me.Pactions.TabIndex = 8
        '
        'btnCompletar
        '
        Me.btnCompletar.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnCompletar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCompletar.FlatAppearance.BorderSize = 0
        Me.btnCompletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCompletar.Image = Global.La_Andaluza.My.Resources.Resources.package_add
        Me.btnCompletar.Location = New System.Drawing.Point(710, 3)
        Me.btnCompletar.Name = "btnCompletar"
        Me.btnCompletar.Size = New System.Drawing.Size(85, 30)
        Me.btnCompletar.TabIndex = 8
        Me.btnCompletar.Text = "Com&pletar"
        Me.btnCompletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCompletar.UseVisualStyleBackColor = True
        '
        'btnNoCoincide
        '
        Me.btnNoCoincide.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnNoCoincide.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoCoincide.FlatAppearance.BorderSize = 0
        Me.btnNoCoincide.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoCoincide.Image = Global.La_Andaluza.My.Resources.Resources.emblem_notice
        Me.btnNoCoincide.Location = New System.Drawing.Point(187, 3)
        Me.btnNoCoincide.Name = "btnNoCoincide"
        Me.btnNoCoincide.Size = New System.Drawing.Size(179, 30)
        Me.btnNoCoincide.TabIndex = 7
        Me.btnNoCoincide.Text = "Numero de &cajas no coincide"
        Me.btnNoCoincide.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNoCoincide.UseVisualStyleBackColor = True
        '
        'btnNoAlmacen
        '
        Me.btnNoAlmacen.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.btnNoAlmacen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNoAlmacen.FlatAppearance.BorderSize = 0
        Me.btnNoAlmacen.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNoAlmacen.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_3
        Me.btnNoAlmacen.Location = New System.Drawing.Point(3, 3)
        Me.btnNoAlmacen.Name = "btnNoAlmacen"
        Me.btnNoAlmacen.Size = New System.Drawing.Size(178, 30)
        Me.btnNoAlmacen.TabIndex = 6
        Me.btnNoAlmacen.Text = "No encontrado en &almacen"
        Me.btnNoAlmacen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnNoAlmacen.UseVisualStyleBackColor = True
        '
        'TimerSSCC
        '
        Me.TimerSSCC.Interval = 333
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.grbContenido)
        Me.Panel1.Controls.Add(Me.grbDatos)
        Me.Panel1.Controls.Add(Me.grbIncompletos)
        Me.Panel1.Controls.Add(Me.Pactions)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(801, 614)
        Me.Panel1.TabIndex = 9
        '
        'frmEntPaletsProducidos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(801, 639)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(552, 663)
        Me.Name = "frmEntPaletsProducidos2"
        Me.Text = "PaletsProducidos2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContenido.ResumeLayout(False)
        Me.grbIncompletos.ResumeLayout(False)
        Me.grbDgvImcompletos.ResumeLayout(False)
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvIncompletos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbDatos.ResumeLayout(False)
        Me.grbDatos.PerformLayout()
        Me.Pactions.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblSSCC As System.Windows.Forms.Label
    Private WithEvents grbContenido As System.Windows.Forms.GroupBox
    Private WithEvents lblSSCCtext As System.Windows.Forms.Label
    Private WithEvents lblPaletProducidoID As System.Windows.Forms.Label
    Private WithEvents grbIncompletos As System.Windows.Forms.GroupBox
    Private WithEvents grbDgvImcompletos As System.Windows.Forms.GroupBox
    Private WithEvents lblCajasCompletar As System.Windows.Forms.Label
    Private WithEvents lblPartePaletContenido As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents grbDatos As System.Windows.Forms.GroupBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblObs As System.Windows.Forms.Label
    Private WithEvents panConPal As System.Windows.Forms.Panel
    Private WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Private WithEvents Pactions As System.Windows.Forms.Panel
    Private WithEvents btnCompletar As System.Windows.Forms.Button
    Private WithEvents btnNoCoincide As System.Windows.Forms.Button
    Private WithEvents btnNoAlmacen As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbMultilote As System.Windows.Forms.CheckBox
    Public WithEvents dgvIncompletos As System.Windows.Forms.DataGridView
    Public WithEvents chbTerminado As System.Windows.Forms.CheckBox
    Public WithEvents chbEnAlmacen As System.Windows.Forms.CheckBox
    Public WithEvents TimerSSCC As System.Windows.Forms.Timer
End Class
