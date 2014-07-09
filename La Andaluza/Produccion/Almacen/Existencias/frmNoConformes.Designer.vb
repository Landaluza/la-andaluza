<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNoConformes
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
        Me.tabDatos = New System.Windows.Forms.TabControl()
        Me.tpTotales = New System.Windows.Forms.TabPage()
        Me.pnlTotales = New System.Windows.Forms.Panel()
        Me.dgvTotales = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtSumTotales = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtSumPalets = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtSumLotes = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.tabPagPalets = New System.Windows.Forms.TabPage()
        Me.dgvPalet = New System.Windows.Forms.DataGridView()
        Me.tabPagAcumulados = New System.Windows.Forms.TabPage()
        Me.dgvLotes = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tstotales = New System.Windows.Forms.ToolStripButton()
        Me.tsPalets = New System.Windows.Forms.ToolStripButton()
        Me.tsLotes = New System.Windows.Forms.ToolStripButton()
        Me.butExcel = New System.Windows.Forms.ToolStripButton()
        Me.tsConforme = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.tabDatos.SuspendLayout()
        Me.tpTotales.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.tabPagPalets.SuspendLayout()
        CType(Me.dgvPalet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPagAcumulados.SuspendLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.tpTotales)
        Me.tabDatos.Controls.Add(Me.tabPagPalets)
        Me.tabDatos.Controls.Add(Me.tabPagAcumulados)
        Me.tabDatos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabDatos.Location = New System.Drawing.Point(0, 25)
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectedIndex = 0
        Me.tabDatos.Size = New System.Drawing.Size(889, 623)
        Me.tabDatos.TabIndex = 1000000047
        '
        'tpTotales
        '
        Me.tpTotales.Controls.Add(Me.pnlTotales)
        Me.tpTotales.Location = New System.Drawing.Point(4, 22)
        Me.tpTotales.Name = "tpTotales"
        Me.tpTotales.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpTotales.Size = New System.Drawing.Size(881, 597)
        Me.tpTotales.TabIndex = 3
        Me.tpTotales.Text = "Totales"
        Me.tpTotales.UseVisualStyleBackColor = True
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.dgvTotales)
        Me.pnlTotales.Controls.Add(Me.Panel1)
        Me.pnlTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlTotales.Location = New System.Drawing.Point(3, 3)
        Me.pnlTotales.Name = "pnlTotales"
        Me.pnlTotales.Size = New System.Drawing.Size(875, 591)
        Me.pnlTotales.TabIndex = 1000000065
        '
        'dgvTotales
        '
        Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTotales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTotales.GridColor = System.Drawing.Color.Black
        Me.dgvTotales.Location = New System.Drawing.Point(0, 0)
        Me.dgvTotales.Name = "dgvTotales"
        Me.dgvTotales.RowTemplate.Height = 14
        Me.dgvTotales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvTotales.Size = New System.Drawing.Size(616, 591)
        Me.dgvTotales.TabIndex = 1000000047
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSumTotales)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSumPalets)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSumLotes)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel1.Location = New System.Drawing.Point(616, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(259, 591)
        Me.Panel1.TabIndex = 1000000064
        '
        'txtSumTotales
        '
        Me.txtSumTotales.EsUnicoCampo = ""
        Me.txtSumTotales.EsUnicoCampoID = ""
        Me.txtSumTotales.EsUnicoID = 0
        Me.txtSumTotales.EsUnicoTabla = ""
        Me.txtSumTotales.Location = New System.Drawing.Point(102, 87)
        Me.txtSumTotales.Minimo = 0
        Me.txtSumTotales.Modificado = False
        Me.txtSumTotales.Name = "txtSumTotales"
        Me.txtSumTotales.Numerico_EsNumerico = True
        Me.txtSumTotales.Numerico_NumeroDoublees = 0
        Me.txtSumTotales.Numerico_SeparadorMiles = True
        Me.txtSumTotales.Obligatorio = False
        Me.txtSumTotales.ParametroID = 0
        Me.txtSumTotales.Size = New System.Drawing.Size(114, 20)
        Me.txtSumTotales.TabIndex = 1000000056
        Me.txtSumTotales.Text = Nothing
        Me.txtSumTotales.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSumTotales.ValorMaximo = 0.0!
        Me.txtSumTotales.ValorMinimo = 0.0!
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label1.Location = New System.Drawing.Point(43, 59)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 20)
        Me.Label1.TabIndex = 1000000061
        Me.Label1.Text = "Palets"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label2.Location = New System.Drawing.Point(43, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 20)
        Me.Label2.TabIndex = 1000000062
        Me.Label2.Text = "Lotes"
        '
        'txtSumPalets
        '
        Me.txtSumPalets.EsUnicoCampo = ""
        Me.txtSumPalets.EsUnicoCampoID = ""
        Me.txtSumPalets.EsUnicoID = 0
        Me.txtSumPalets.EsUnicoTabla = ""
        Me.txtSumPalets.Location = New System.Drawing.Point(102, 61)
        Me.txtSumPalets.Minimo = 0
        Me.txtSumPalets.Modificado = False
        Me.txtSumPalets.Name = "txtSumPalets"
        Me.txtSumPalets.Numerico_EsNumerico = True
        Me.txtSumPalets.Numerico_NumeroDoublees = 0
        Me.txtSumPalets.Numerico_SeparadorMiles = True
        Me.txtSumPalets.Obligatorio = False
        Me.txtSumPalets.ParametroID = 0
        Me.txtSumPalets.Size = New System.Drawing.Size(114, 20)
        Me.txtSumPalets.TabIndex = 1000000060
        Me.txtSumPalets.Text = Nothing
        Me.txtSumPalets.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSumPalets.ValorMaximo = 0.0!
        Me.txtSumPalets.ValorMinimo = 0.0!
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.Label3.Location = New System.Drawing.Point(35, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 20)
        Me.Label3.TabIndex = 1000000063
        Me.Label3.Text = "Totales"
        '
        'txtSumLotes
        '
        Me.txtSumLotes.EsUnicoCampo = ""
        Me.txtSumLotes.EsUnicoCampoID = ""
        Me.txtSumLotes.EsUnicoID = 0
        Me.txtSumLotes.EsUnicoTabla = ""
        Me.txtSumLotes.Location = New System.Drawing.Point(102, 35)
        Me.txtSumLotes.Minimo = 0
        Me.txtSumLotes.Modificado = False
        Me.txtSumLotes.Name = "txtSumLotes"
        Me.txtSumLotes.Numerico_EsNumerico = True
        Me.txtSumLotes.Numerico_NumeroDoublees = 0
        Me.txtSumLotes.Numerico_SeparadorMiles = True
        Me.txtSumLotes.Obligatorio = False
        Me.txtSumLotes.ParametroID = 0
        Me.txtSumLotes.Size = New System.Drawing.Size(114, 20)
        Me.txtSumLotes.TabIndex = 1000000059
        Me.txtSumLotes.Text = Nothing
        Me.txtSumLotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSumLotes.ValorMaximo = 0.0!
        Me.txtSumLotes.ValorMinimo = 0.0!
        '
        'tabPagPalets
        '
        Me.tabPagPalets.Controls.Add(Me.dgvPalet)
        Me.tabPagPalets.Location = New System.Drawing.Point(4, 22)
        Me.tabPagPalets.Name = "tabPagPalets"
        Me.tabPagPalets.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPagPalets.Size = New System.Drawing.Size(881, 600)
        Me.tabPagPalets.TabIndex = 1
        Me.tabPagPalets.Text = "Palets"
        Me.tabPagPalets.UseVisualStyleBackColor = True
        '
        'dgvPalet
        '
        Me.dgvPalet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPalet.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPalet.Location = New System.Drawing.Point(3, 3)
        Me.dgvPalet.MultiSelect = False
        Me.dgvPalet.Name = "dgvPalet"
        Me.dgvPalet.RowTemplate.Height = 14
        Me.dgvPalet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvPalet.Size = New System.Drawing.Size(877, 596)
        Me.dgvPalet.TabIndex = 1000000043
        '
        'tabPagAcumulados
        '
        Me.tabPagAcumulados.Controls.Add(Me.dgvLotes)
        Me.tabPagAcumulados.Location = New System.Drawing.Point(4, 22)
        Me.tabPagAcumulados.Name = "tabPagAcumulados"
        Me.tabPagAcumulados.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tabPagAcumulados.Size = New System.Drawing.Size(881, 600)
        Me.tabPagAcumulados.TabIndex = 2
        Me.tabPagAcumulados.Text = "Lotes"
        Me.tabPagAcumulados.UseVisualStyleBackColor = True
        '
        'dgvLotes
        '
        Me.dgvLotes.AllowUserToAddRows = False
        Me.dgvLotes.AllowUserToDeleteRows = False
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Location = New System.Drawing.Point(3, 3)
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLotes.Size = New System.Drawing.Size(1014, 696)
        Me.dgvLotes.TabIndex = 1000000044
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tstotales, Me.tsPalets, Me.tsLotes, Me.butExcel, Me.tsConforme})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(889, 25)
        Me.ToolStrip1.TabIndex = 1000000048
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tstotales
        '
        Me.tstotales.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.tstotales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tstotales.Name = "tstotales"
        Me.tstotales.Size = New System.Drawing.Size(107, 22)
        Me.tstotales.Text = "Recargar totales"
        '
        'tsPalets
        '
        Me.tsPalets.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.tsPalets.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPalets.Name = "tsPalets"
        Me.tsPalets.Size = New System.Drawing.Size(103, 22)
        Me.tsPalets.Text = "Recargar palets"
        '
        'tsLotes
        '
        Me.tsLotes.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.tsLotes.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLotes.Name = "tsLotes"
        Me.tsLotes.Size = New System.Drawing.Size(97, 22)
        Me.tsLotes.Text = "Recargar lotes"
        '
        'butExcel
        '
        Me.butExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butExcel.Image = Global.La_Andaluza.My.Resources.Resources.page_excel_16
        Me.butExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.butExcel.Name = "butExcel"
        Me.butExcel.Size = New System.Drawing.Size(23, 22)
        Me.butExcel.Text = "Excel"
        Me.butExcel.ToolTipText = "Grabar hoja Excel"
        '
        'tsConforme
        '
        Me.tsConforme.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.tsConforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsConforme.Name = "tsConforme"
        Me.tsConforme.Size = New System.Drawing.Size(136, 22)
        Me.tsConforme.Text = "Marcar como conforme"
        Me.tsConforme.Visible = False
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 626)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.StatusStrip1.Size = New System.Drawing.Size(889, 22)
        Me.StatusStrip1.TabIndex = 1000000049
        Me.StatusStrip1.Text = "StatusStrip1"
        Me.StatusStrip1.Visible = False
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.AutoToolTip = True
        Me.ToolStripProgressBar1.MarqueeAnimationSpeed = 30
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(100, 16)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ToolStripProgressBar1.ToolTipText = "cargando información de pestañas"
        '
        'frmNoConformes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(889, 648)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.tabDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmNoConformes"
        Me.Text = "frmNoConformes"
        Me.tabDatos.ResumeLayout(False)
        Me.tpTotales.ResumeLayout(False)
        Me.pnlTotales.ResumeLayout(False)
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.tabPagPalets.ResumeLayout(False)
        CType(Me.dgvPalet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPagAcumulados.ResumeLayout(False)
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tabDatos As System.Windows.Forms.TabControl
    Private WithEvents tpTotales As System.Windows.Forms.TabPage
    Private WithEvents pnlTotales As System.Windows.Forms.Panel
    Private WithEvents dgvTotales As System.Windows.Forms.DataGridView
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents txtSumTotales As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtSumPalets As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtSumLotes As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents tabPagPalets As System.Windows.Forms.TabPage
    Private WithEvents dgvPalet As System.Windows.Forms.DataGridView
    Private WithEvents tabPagAcumulados As System.Windows.Forms.TabPage
    Private WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tstotales As System.Windows.Forms.ToolStripButton
    Private WithEvents tsPalets As System.Windows.Forms.ToolStripButton
    Private WithEvents tsLotes As System.Windows.Forms.ToolStripButton
    Private WithEvents butExcel As System.Windows.Forms.ToolStripButton
    Private WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents tsConforme As System.Windows.Forms.ToolStripButton
End Class
