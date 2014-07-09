<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAlmacenExistencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAlmacenExistencias))
        Me.tabPagAcumulados = New System.Windows.Forms.TabPage()
        Me.dgvLotes = New System.Windows.Forms.DataGridView()
        Me.tabPagPalets = New System.Windows.Forms.TabPage()
        Me.dgvPalet = New System.Windows.Forms.DataGridView()
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
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsTotales = New System.Windows.Forms.ToolStripButton()
        Me.tsPalets = New System.Windows.Forms.ToolStripButton()
        Me.tsLotes = New System.Windows.Forms.ToolStripButton()
        Me.butExcel = New System.Windows.Forms.ToolStripButton()
        Me.tsNoConforme = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.tabPagAcumulados.SuspendLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabPagPalets.SuspendLayout()
        CType(Me.dgvPalet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabDatos.SuspendLayout()
        Me.tpTotales.SuspendLayout()
        Me.pnlTotales.SuspendLayout()
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabPagAcumulados
        '
        Me.tabPagAcumulados.Controls.Add(Me.dgvLotes)
        resources.ApplyResources(Me.tabPagAcumulados, "tabPagAcumulados")
        Me.tabPagAcumulados.Name = "tabPagAcumulados"
        Me.tabPagAcumulados.UseVisualStyleBackColor = True
        '
        'dgvLotes
        '
        Me.dgvLotes.AllowUserToAddRows = False
        Me.dgvLotes.AllowUserToDeleteRows = False
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvLotes, "dgvLotes")
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'tabPagPalets
        '
        Me.tabPagPalets.Controls.Add(Me.dgvPalet)
        resources.ApplyResources(Me.tabPagPalets, "tabPagPalets")
        Me.tabPagPalets.Name = "tabPagPalets"
        Me.tabPagPalets.UseVisualStyleBackColor = True
        '
        'dgvPalet
        '
        Me.dgvPalet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvPalet, "dgvPalet")
        Me.dgvPalet.MultiSelect = False
        Me.dgvPalet.Name = "dgvPalet"
        Me.dgvPalet.RowTemplate.Height = 14
        Me.dgvPalet.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'tabDatos
        '
        Me.tabDatos.Controls.Add(Me.tpTotales)
        Me.tabDatos.Controls.Add(Me.tabPagPalets)
        Me.tabDatos.Controls.Add(Me.tabPagAcumulados)
        resources.ApplyResources(Me.tabDatos, "tabDatos")
        Me.tabDatos.Name = "tabDatos"
        Me.tabDatos.SelectedIndex = 0
        '
        'tpTotales
        '
        Me.tpTotales.Controls.Add(Me.pnlTotales)
        resources.ApplyResources(Me.tpTotales, "tpTotales")
        Me.tpTotales.Name = "tpTotales"
        Me.tpTotales.UseVisualStyleBackColor = True
        '
        'pnlTotales
        '
        Me.pnlTotales.Controls.Add(Me.dgvTotales)
        Me.pnlTotales.Controls.Add(Me.Panel1)
        resources.ApplyResources(Me.pnlTotales, "pnlTotales")
        Me.pnlTotales.Name = "pnlTotales"
        '
        'dgvTotales
        '
        Me.dgvTotales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        resources.ApplyResources(Me.dgvTotales, "dgvTotales")
        Me.dgvTotales.GridColor = System.Drawing.Color.Black
        Me.dgvTotales.Name = "dgvTotales"
        Me.dgvTotales.RowTemplate.Height = 14
        Me.dgvTotales.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvTotales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtSumTotales)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.txtSumPalets)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.txtSumLotes)
        resources.ApplyResources(Me.Panel1, "Panel1")
        Me.Panel1.Name = "Panel1"
        '
        'txtSumTotales
        '
        Me.txtSumTotales.EsUnicoCampo = ""
        Me.txtSumTotales.EsUnicoCampoID = ""
        Me.txtSumTotales.EsUnicoID = 0
        Me.txtSumTotales.EsUnicoTabla = ""
        resources.ApplyResources(Me.txtSumTotales, "txtSumTotales")
        Me.txtSumTotales.Minimo = 0
        Me.txtSumTotales.Modificado = False
        Me.txtSumTotales.Name = "txtSumTotales"
        Me.txtSumTotales.Numerico_EsNumerico = True
        Me.txtSumTotales.Numerico_NumeroDoublees = 0
        Me.txtSumTotales.Numerico_SeparadorMiles = True
        Me.txtSumTotales.Obligatorio = False
        Me.txtSumTotales.ParametroID = 0
        Me.txtSumTotales.ValorMaximo = 0.0!
        Me.txtSumTotales.ValorMinimo = 0.0!
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.Name = "Label1"
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.Name = "Label2"
        '
        'txtSumPalets
        '
        Me.txtSumPalets.EsUnicoCampo = ""
        Me.txtSumPalets.EsUnicoCampoID = ""
        Me.txtSumPalets.EsUnicoID = 0
        Me.txtSumPalets.EsUnicoTabla = ""
        resources.ApplyResources(Me.txtSumPalets, "txtSumPalets")
        Me.txtSumPalets.Minimo = 0
        Me.txtSumPalets.Modificado = False
        Me.txtSumPalets.Name = "txtSumPalets"
        Me.txtSumPalets.Numerico_EsNumerico = True
        Me.txtSumPalets.Numerico_NumeroDoublees = 0
        Me.txtSumPalets.Numerico_SeparadorMiles = True
        Me.txtSumPalets.Obligatorio = False
        Me.txtSumPalets.ParametroID = 0
        Me.txtSumPalets.ValorMaximo = 0.0!
        Me.txtSumPalets.ValorMinimo = 0.0!
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.Name = "Label3"
        '
        'txtSumLotes
        '
        Me.txtSumLotes.EsUnicoCampo = ""
        Me.txtSumLotes.EsUnicoCampoID = ""
        Me.txtSumLotes.EsUnicoID = 0
        Me.txtSumLotes.EsUnicoTabla = ""
        resources.ApplyResources(Me.txtSumLotes, "txtSumLotes")
        Me.txtSumLotes.Minimo = 0
        Me.txtSumLotes.Modificado = False
        Me.txtSumLotes.Name = "txtSumLotes"
        Me.txtSumLotes.Numerico_EsNumerico = True
        Me.txtSumLotes.Numerico_NumeroDoublees = 0
        Me.txtSumLotes.Numerico_SeparadorMiles = True
        Me.txtSumLotes.Obligatorio = False
        Me.txtSumLotes.ParametroID = 0
        Me.txtSumLotes.ValorMaximo = 0.0!
        Me.txtSumLotes.ValorMinimo = 0.0!
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsTotales, Me.tsPalets, Me.tsLotes, Me.butExcel, Me.tsNoConforme})
        resources.ApplyResources(Me.ToolStrip1, "ToolStrip1")
        Me.ToolStrip1.Name = "ToolStrip1"
        '
        'tsTotales
        '
        Me.tsTotales.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        resources.ApplyResources(Me.tsTotales, "tsTotales")
        Me.tsTotales.Name = "tsTotales"
        '
        'tsPalets
        '
        Me.tsPalets.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        resources.ApplyResources(Me.tsPalets, "tsPalets")
        Me.tsPalets.Name = "tsPalets"
        '
        'tsLotes
        '
        Me.tsLotes.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        resources.ApplyResources(Me.tsLotes, "tsLotes")
        Me.tsLotes.Name = "tsLotes"
        '
        'butExcel
        '
        Me.butExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.butExcel.Image = Global.La_Andaluza.My.Resources.Resources.page_excel_16
        resources.ApplyResources(Me.butExcel, "butExcel")
        Me.butExcel.Name = "butExcel"
        '
        'tsNoConforme
        '
        Me.tsNoConforme.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        resources.ApplyResources(Me.tsNoConforme, "tsNoConforme")
        Me.tsNoConforme.Name = "tsNoConforme"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        resources.ApplyResources(Me.StatusStrip1, "StatusStrip1")
        Me.StatusStrip1.Name = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripProgressBar1.AutoToolTip = True
        Me.ToolStripProgressBar1.MarqueeAnimationSpeed = 30
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        resources.ApplyResources(Me.ToolStripProgressBar1, "ToolStripProgressBar1")
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        '
        'frmAlmacenExistencias
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.tabDatos)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.DoubleBuffered = True
        Me.MinimizeBox = False
        Me.Name = "frmAlmacenExistencias"
        Me.tabPagAcumulados.ResumeLayout(False)
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabPagPalets.ResumeLayout(False)
        CType(Me.dgvPalet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabDatos.ResumeLayout(False)
        Me.tpTotales.ResumeLayout(False)
        Me.pnlTotales.ResumeLayout(False)
        CType(Me.dgvTotales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents tabPagAcumulados As System.Windows.Forms.TabPage
    Private WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Private WithEvents tabPagPalets As System.Windows.Forms.TabPage
    Private WithEvents dgvPalet As System.Windows.Forms.DataGridView
    Private WithEvents tabDatos As System.Windows.Forms.TabControl
    Private WithEvents tpTotales As System.Windows.Forms.TabPage
    Private WithEvents dgvTotales As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents butExcel As System.Windows.Forms.ToolStripButton
    Private WithEvents txtSumTotales As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtSumPalets As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSumLotes As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents pnlTotales As System.Windows.Forms.Panel
    Private WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Private WithEvents ToolStripProgressBar1 As System.Windows.Forms.ToolStripProgressBar
    Private WithEvents tsTotales As System.Windows.Forms.ToolStripButton
    Private WithEvents tsPalets As System.Windows.Forms.ToolStripButton
    Private WithEvents tsLotes As System.Windows.Forms.ToolStripButton
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents tsNoConforme As System.Windows.Forms.ToolStripButton
End Class
