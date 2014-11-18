<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaletSCC
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

    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPaletSCC))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.ImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.StatusBarfrmdbo_Movimiento = New System.Windows.Forms.StatusBar()
        Me.lblSCC = New System.Windows.Forms.Label()
        Me.dgvMovimientos = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EliminarMovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ModificarMovimientoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarHoraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CambiarFechaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.btnVer = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lblCajas = New System.Windows.Forms.Label()
        Me.LblCajasExisten = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsimprimir = New System.Windows.Forms.ToolStripButton()
        Me.tsPalet = New System.Windows.Forms.ToolStripButton()
        Me.tsNoConforme = New System.Windows.Forms.ToolStripButton()
        Me.txtSCC = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.tsCAmbiarFecha = New System.Windows.Forms.ToolStripButton()
        Me.tsCambiarHora = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar2 = New System.Windows.Forms.ToolStripButton()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        Me.ErrorProvider1.Icon = CType(resources.GetObject("ErrorProvider1.Icon"), System.Drawing.Icon)
        '
        'ImageList
        '
        Me.ImageList.ImageStream = CType(resources.GetObject("ImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList.Images.SetKeyName(0, "")
        Me.ImageList.Images.SetKeyName(1, "")
        Me.ImageList.Images.SetKeyName(2, "")
        Me.ImageList.Images.SetKeyName(3, "")
        Me.ImageList.Images.SetKeyName(4, "")
        Me.ImageList.Images.SetKeyName(5, "")
        Me.ImageList.Images.SetKeyName(6, "")
        Me.ImageList.Images.SetKeyName(7, "")
        Me.ImageList.Images.SetKeyName(8, "")
        '
        'StatusBarfrmdbo_Movimiento
        '
        Me.StatusBarfrmdbo_Movimiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.StatusBarfrmdbo_Movimiento.Dock = System.Windows.Forms.DockStyle.None
        Me.StatusBarfrmdbo_Movimiento.Location = New System.Drawing.Point(88, 379)
        Me.StatusBarfrmdbo_Movimiento.Name = "StatusBarfrmdbo_Movimiento"
        Me.StatusBarfrmdbo_Movimiento.Size = New System.Drawing.Size(836, 22)
        Me.StatusBarfrmdbo_Movimiento.TabIndex = 13
        '
        'lblSCC
        '
        Me.lblSCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSCC.AutoSize = True
        Me.lblSCC.Location = New System.Drawing.Point(34, 44)
        Me.lblSCC.Name = "lblSCC"
        Me.lblSCC.Size = New System.Drawing.Size(35, 13)
        Me.lblSCC.TabIndex = 16
        Me.lblSCC.Text = "SSCC"
        '
        'dgvMovimientos
        '
        Me.dgvMovimientos.AllowUserToAddRows = False
        Me.dgvMovimientos.AllowUserToDeleteRows = False
        Me.dgvMovimientos.AllowUserToResizeRows = False
        Me.dgvMovimientos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvMovimientos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.dgvMovimientos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMovimientos.ContextMenuStrip = Me.ContextMenuStrip1
        Me.dgvMovimientos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvMovimientos.Location = New System.Drawing.Point(0, 0)
        Me.dgvMovimientos.MultiSelect = False
        Me.dgvMovimientos.Name = "dgvMovimientos"
        Me.dgvMovimientos.ReadOnly = True
        Me.dgvMovimientos.RowHeadersVisible = False
        Me.dgvMovimientos.RowTemplate.Height = 16
        Me.dgvMovimientos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMovimientos.Size = New System.Drawing.Size(938, 323)
        Me.dgvMovimientos.TabIndex = 2
        Me.dgvMovimientos.Visible = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarMovimientoToolStripMenuItem, Me.ModificarMovimientoToolStripMenuItem, Me.CambiarHoraToolStripMenuItem, Me.CambiarFechaToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(194, 92)
        '
        'EliminarMovimientoToolStripMenuItem
        '
        Me.EliminarMovimientoToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.EliminarMovimientoToolStripMenuItem.Name = "EliminarMovimientoToolStripMenuItem"
        Me.EliminarMovimientoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.EliminarMovimientoToolStripMenuItem.Text = "Eliminar movimiento"
        '
        'ModificarMovimientoToolStripMenuItem
        '
        Me.ModificarMovimientoToolStripMenuItem.Enabled = False
        Me.ModificarMovimientoToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.ModificarMovimientoToolStripMenuItem.Name = "ModificarMovimientoToolStripMenuItem"
        Me.ModificarMovimientoToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.ModificarMovimientoToolStripMenuItem.Text = "Modificar movimiento"
        '
        'CambiarHoraToolStripMenuItem
        '
        Me.CambiarHoraToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.appointmentmissed16
        Me.CambiarHoraToolStripMenuItem.Name = "CambiarHoraToolStripMenuItem"
        Me.CambiarHoraToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CambiarHoraToolStripMenuItem.Text = "Cambiar hora"
        '
        'CambiarFechaToolStripMenuItem
        '
        Me.CambiarFechaToolStripMenuItem.Image = Global.La_Andaluza.My.Resources.Resources.note_go
        Me.CambiarFechaToolStripMenuItem.Name = "CambiarFechaToolStripMenuItem"
        Me.CambiarFechaToolStripMenuItem.Size = New System.Drawing.Size(193, 22)
        Me.CambiarFechaToolStripMenuItem.Text = "Cambiar fecha"
        '
        'lblArticulo
        '
        Me.lblArticulo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblArticulo.AutoSize = True
        Me.lblArticulo.Location = New System.Drawing.Point(34, 67)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(42, 13)
        Me.lblArticulo.TabIndex = 20
        Me.lblArticulo.Text = "Articulo"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescripcion.Location = New System.Drawing.Point(82, 67)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(91, 16)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        '
        'btnVer
        '
        Me.btnVer.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnVer.BackColor = System.Drawing.SystemColors.Control
        Me.btnVer.FlatAppearance.BorderSize = 0
        Me.btnVer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVer.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnVer.Location = New System.Drawing.Point(147, 39)
        Me.btnVer.Name = "btnVer"
        Me.btnVer.Size = New System.Drawing.Size(23, 25)
        Me.btnVer.TabIndex = 1
        Me.btnVer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnVer.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.dgvMovimientos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 90)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(938, 323)
        Me.Panel1.TabIndex = 21
        '
        'lblCajas
        '
        Me.lblCajas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCajas.AutoSize = True
        Me.lblCajas.Location = New System.Drawing.Point(737, 65)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(33, 13)
        Me.lblCajas.TabIndex = 22
        Me.lblCajas.Text = "Cajas"
        '
        'LblCajasExisten
        '
        Me.LblCajasExisten.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LblCajasExisten.AutoSize = True
        Me.LblCajasExisten.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblCajasExisten.Location = New System.Drawing.Point(785, 65)
        Me.LblCajasExisten.Name = "LblCajasExisten"
        Me.LblCajasExisten.Size = New System.Drawing.Size(98, 16)
        Me.LblCajasExisten.TabIndex = 23
        Me.LblCajasExisten.Text = "CajasExisten"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.LblCajasExisten)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.lblCajas)
        Me.Panel2.Controls.Add(Me.txtSCC)
        Me.Panel2.Controls.Add(Me.btnVer)
        Me.Panel2.Controls.Add(Me.lblSCC)
        Me.Panel2.Controls.Add(Me.lblArticulo)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(938, 90)
        Me.Panel2.TabIndex = 24
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsimprimir, Me.tsPalet, Me.tsNoConforme, Me.tsCAmbiarFecha, Me.tsCambiarHora, Me.tsEliminar2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(938, 25)
        Me.ToolStrip1.TabIndex = 25
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsimprimir
        '
        Me.tsimprimir.Image = Global.La_Andaluza.My.Resources.Resources.imprimir_16
        Me.tsimprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsimprimir.Name = "tsimprimir"
        Me.tsimprimir.Size = New System.Drawing.Size(73, 22)
        Me.tsimprimir.Text = "Imprimir"
        '
        'tsPalet
        '
        Me.tsPalet.Image = Global.La_Andaluza.My.Resources.Resources.package_add
        Me.tsPalet.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsPalet.Name = "tsPalet"
        Me.tsPalet.Size = New System.Drawing.Size(174, 22)
        Me.tsPalet.Text = "El palet no ha sido expedido"
        '
        'tsNoConforme
        '
        Me.tsNoConforme.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.tsNoConforme.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsNoConforme.Name = "tsNoConforme"
        Me.tsNoConforme.Size = New System.Drawing.Size(170, 22)
        Me.tsNoConforme.Text = "Marcar como no conforme"
        '
        'txtSCC
        '
        Me.txtSCC.AcceptsReturn = True
        Me.txtSCC.AcceptsTab = True
        Me.txtSCC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txtSCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSCC.EsUnicoCampo = ""
        Me.txtSCC.EsUnicoCampoID = ""
        Me.txtSCC.EsUnicoID = 0
        Me.txtSCC.EsUnicoTabla = ""
        Me.txtSCC.Location = New System.Drawing.Point(82, 42)
        Me.txtSCC.Minimo = 0
        Me.txtSCC.Modificado = False
        Me.txtSCC.Name = "txtSCC"
        Me.txtSCC.Numerico_EsNumerico = True
        Me.txtSCC.Numerico_NumeroDoublees = 0
        Me.txtSCC.Numerico_SeparadorMiles = False
        Me.txtSCC.Obligatorio = False
        Me.txtSCC.ParametroID = 0
        Me.txtSCC.Size = New System.Drawing.Size(65, 20)
        Me.txtSCC.TabIndex = 0
        Me.txtSCC.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSCC.ValorMaximo = 0.0R
        Me.txtSCC.ValorMinimo = 0.0R
        '
        'tsCAmbiarFecha
        '
        Me.tsCAmbiarFecha.Image = Global.La_Andaluza.My.Resources.Resources.note_go
        Me.tsCAmbiarFecha.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCAmbiarFecha.Name = "tsCAmbiarFecha"
        Me.tsCAmbiarFecha.Size = New System.Drawing.Size(104, 22)
        Me.tsCAmbiarFecha.Text = "Cambiar fecha"
        '
        'tsCambiarHora
        '
        Me.tsCambiarHora.Image = Global.La_Andaluza.My.Resources.Resources.appointmentmissed16
        Me.tsCambiarHora.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsCambiarHora.Name = "tsCambiarHora"
        Me.tsCambiarHora.Size = New System.Drawing.Size(99, 22)
        Me.tsCambiarHora.Text = "Cambiar hora"
        '
        'tsEliminar2
        '
        Me.tsEliminar2.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsEliminar2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEliminar2.Name = "tsEliminar2"
        Me.tsEliminar2.Size = New System.Drawing.Size(138, 22)
        Me.tsEliminar2.Text = "Eliminar movimiento"
        '
        'frmPaletSCC
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(938, 413)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.StatusBarfrmdbo_Movimiento)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frmPaletSCC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Palet SCC"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvMovimientos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents ImageList As System.Windows.Forms.ImageList
    Private WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider

    Private WithEvents StatusBarfrmdbo_Movimiento As System.Windows.Forms.StatusBar
    Private WithEvents lblSCC As System.Windows.Forms.Label
    Private WithEvents dgvMovimientos As System.Windows.Forms.DataGridView
    Private WithEvents lblArticulo As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lblCajas As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents tsimprimir As System.Windows.Forms.ToolStripButton
    Private WithEvents tsPalet As System.Windows.Forms.ToolStripButton
    Private WithEvents tsNoConforme As System.Windows.Forms.ToolStripButton
    Private WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Private WithEvents EliminarMovimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ModificarMovimientoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Public WithEvents txtSCC As BasesParaCompatibilidad.CuadroDeTexto
    Public WithEvents LblCajasExisten As System.Windows.Forms.Label
    Public WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Public WithEvents btnVer As System.Windows.Forms.Button
    Private WithEvents CambiarHoraToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents CambiarFechaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents tsCAmbiarFecha As System.Windows.Forms.ToolStripButton
    Private WithEvents tsCambiarHora As System.Windows.Forms.ToolStripButton
    Private WithEvents tsEliminar2 As System.Windows.Forms.ToolStripButton

End Class
