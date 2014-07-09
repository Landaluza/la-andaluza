<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrdenesEnvasado2Detalle
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grbAlbaranes = New System.Windows.Forms.GroupBox()
        Me.dgvAlbaranes = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsLimpiarSelecciones = New System.Windows.Forms.ToolStripButton()
        Me.tsVerPedidos = New System.Windows.Forms.ToolStripButton()
        Me.miniToolStrip = New System.Windows.Forms.ToolStrip()
        Me.grbPedidos = New System.Windows.Forms.GroupBox()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsInsertar1 = New System.Windows.Forms.ToolStripButton()
        Me.grbContenido = New System.Windows.Forms.GroupBox()
        Me.dgvArtOrdEnv = New System.Windows.Forms.DataGridView()
        Me.tsFormatos = New System.Windows.Forms.ToolStrip()
        Me.tsInsertar = New System.Windows.Forms.ToolStripButton()
        Me.tsModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tsDetalles = New System.Windows.Forms.ToolStripButton()
        Me.tsWord = New System.Windows.Forms.ToolStripButton()
        Me.grbAlbaranes.SuspendLayout()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.grbPedidos.SuspendLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.grbContenido.SuspendLayout()
        CType(Me.dgvArtOrdEnv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFormatos.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbAlbaranes
        '
        Me.grbAlbaranes.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbAlbaranes.Controls.Add(Me.dgvAlbaranes)
        Me.grbAlbaranes.Controls.Add(Me.ToolStrip2)
        Me.grbAlbaranes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbAlbaranes.Location = New System.Drawing.Point(18, 451)
        Me.grbAlbaranes.Name = "grbAlbaranes"
        Me.grbAlbaranes.Size = New System.Drawing.Size(347, 370)
        Me.grbAlbaranes.TabIndex = 1000000076
        Me.grbAlbaranes.TabStop = False
        Me.grbAlbaranes.Text = "Albaranes en Transito"
        '
        'dgvAlbaranes
        '
        Me.dgvAlbaranes.AllowUserToAddRows = False
        Me.dgvAlbaranes.AllowUserToDeleteRows = False
        Me.dgvAlbaranes.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvAlbaranes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlbaranes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlbaranes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAlbaranes.Location = New System.Drawing.Point(9, 23)
        Me.dgvAlbaranes.Name = "dgvAlbaranes"
        Me.dgvAlbaranes.ReadOnly = True
        Me.dgvAlbaranes.RowTemplate.Height = 24
        Me.dgvAlbaranes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlbaranes.Size = New System.Drawing.Size(309, 341)
        Me.dgvAlbaranes.TabIndex = 13
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsLimpiarSelecciones, Me.tsVerPedidos})
        Me.ToolStrip2.Location = New System.Drawing.Point(321, 23)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(49, 25)
        Me.ToolStrip2.TabIndex = 12
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsLimpiarSelecciones
        '
        Me.tsLimpiarSelecciones.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsLimpiarSelecciones.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_21
        Me.tsLimpiarSelecciones.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsLimpiarSelecciones.Name = "tsLimpiarSelecciones"
        Me.tsLimpiarSelecciones.Size = New System.Drawing.Size(23, 22)
        Me.tsLimpiarSelecciones.Text = "ToolStripButton1"
        Me.tsLimpiarSelecciones.ToolTipText = "Limpiar Selecciones"
        '
        'tsVerPedidos
        '
        Me.tsVerPedidos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsVerPedidos.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.tsVerPedidos.Name = "tsVerPedidos"
        Me.tsVerPedidos.RightToLeftAutoMirrorImage = True
        Me.tsVerPedidos.Size = New System.Drawing.Size(23, 22)
        Me.tsVerPedidos.Text = "Añadir"
        Me.tsVerPedidos.ToolTipText = "Ver Pedidos"
        '
        'miniToolStrip
        '
        Me.miniToolStrip.AutoSize = False
        Me.miniToolStrip.CanOverflow = False
        Me.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None
        Me.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.miniToolStrip.Location = New System.Drawing.Point(-1, 46)
        Me.miniToolStrip.Name = "miniToolStrip"
        Me.miniToolStrip.Size = New System.Drawing.Size(24, 350)
        Me.miniToolStrip.TabIndex = 12
        '
        'grbPedidos
        '
        Me.grbPedidos.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbPedidos.Controls.Add(Me.dgvPedidos)
        Me.grbPedidos.Controls.Add(Me.ToolStrip1)
        Me.grbPedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbPedidos.Location = New System.Drawing.Point(371, 454)
        Me.grbPedidos.Name = "grbPedidos"
        Me.grbPedidos.Size = New System.Drawing.Size(1127, 367)
        Me.grbPedidos.TabIndex = 1000000075
        Me.grbPedidos.TabStop = False
        Me.grbPedidos.Text = "Necesidades envasado."
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Location = New System.Drawing.Point(12, 20)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.ReadOnly = True
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.Size = New System.Drawing.Size(1076, 342)
        Me.dgvPedidos.TabIndex = 13
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsertar1})
        Me.ToolStrip1.Location = New System.Drawing.Point(1091, 20)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(26, 25)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'tsInsertar1
        '
        Me.tsInsertar1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsInsertar1.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsInsertar1.Name = "tsInsertar1"
        Me.tsInsertar1.RightToLeftAutoMirrorImage = True
        Me.tsInsertar1.Size = New System.Drawing.Size(23, 22)
        Me.tsInsertar1.Text = "Añadir"
        Me.tsInsertar1.ToolTipText = "New"
        '
        'grbContenido
        '
        Me.grbContenido.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.grbContenido.Controls.Add(Me.dgvArtOrdEnv)
        Me.grbContenido.Controls.Add(Me.tsFormatos)
        Me.grbContenido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbContenido.Location = New System.Drawing.Point(371, 65)
        Me.grbContenido.Name = "grbContenido"
        Me.grbContenido.Size = New System.Drawing.Size(909, 388)
        Me.grbContenido.TabIndex = 1000000074
        Me.grbContenido.TabStop = False
        Me.grbContenido.Text = "Articulos a envasar."
        '
        'dgvArtOrdEnv
        '
        Me.dgvArtOrdEnv.AllowUserToAddRows = False
        Me.dgvArtOrdEnv.AllowUserToDeleteRows = False
        Me.dgvArtOrdEnv.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.dgvArtOrdEnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvArtOrdEnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvArtOrdEnv.Location = New System.Drawing.Point(9, 17)
        Me.dgvArtOrdEnv.Name = "dgvArtOrdEnv"
        Me.dgvArtOrdEnv.ReadOnly = True
        Me.dgvArtOrdEnv.RowTemplate.Height = 24
        Me.dgvArtOrdEnv.Size = New System.Drawing.Size(856, 365)
        Me.dgvArtOrdEnv.TabIndex = 13
        '
        'tsFormatos
        '
        Me.tsFormatos.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsFormatos.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFormatos.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsertar, Me.tsModificar, Me.tsEliminar, Me.tsDetalles, Me.tsWord})
        Me.tsFormatos.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.tsFormatos.Location = New System.Drawing.Point(882, 17)
        Me.tsFormatos.Name = "tsFormatos"
        Me.tsFormatos.Size = New System.Drawing.Size(24, 368)
        Me.tsFormatos.TabIndex = 12
        Me.tsFormatos.Text = "ToolStrip2"
        '
        'tsInsertar
        '
        Me.tsInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsInsertar.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsInsertar.Name = "tsInsertar"
        Me.tsInsertar.RightToLeftAutoMirrorImage = True
        Me.tsInsertar.Size = New System.Drawing.Size(21, 20)
        Me.tsInsertar.Text = "Añadir"
        Me.tsInsertar.ToolTipText = "New"
        '
        'tsModificar
        '
        Me.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsModificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(21, 20)
        Me.tsModificar.Text = "Modificar"
        Me.tsModificar.ToolTipText = "Modify"
        '
        'tsEliminar
        '
        Me.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.RightToLeftAutoMirrorImage = True
        Me.tsEliminar.Size = New System.Drawing.Size(21, 20)
        Me.tsEliminar.Text = "Eliminar"
        Me.tsEliminar.ToolTipText = "Delete"
        '
        'tsDetalles
        '
        Me.tsDetalles.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsDetalles.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.tsDetalles.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsDetalles.Name = "tsDetalles"
        Me.tsDetalles.Size = New System.Drawing.Size(21, 20)
        Me.tsDetalles.Text = "Detalles"
        '
        'tsWord
        '
        Me.tsWord.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsWord.Image = Global.La_Andaluza.My.Resources.Resources.page_white_word_16
        Me.tsWord.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsWord.Name = "tsWord"
        Me.tsWord.Size = New System.Drawing.Size(21, 20)
        Me.tsWord.Text = "ToolStripButton1"
        Me.tsWord.ToolTipText = "Exportar a Word"
        '
        'frmOrdenesEnvasado2Detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1518, 855)
        Me.Controls.Add(Me.grbPedidos)
        Me.Controls.Add(Me.grbContenido)
        Me.Controls.Add(Me.grbAlbaranes)
        Me.Name = "frmOrdenesEnvasado2Detalle"
        Me.Text = "Form1"
        Me.grbAlbaranes.ResumeLayout(False)
        Me.grbAlbaranes.PerformLayout()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.grbPedidos.ResumeLayout(False)
        Me.grbPedidos.PerformLayout()
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.grbContenido.ResumeLayout(False)
        Me.grbContenido.PerformLayout()
        CType(Me.dgvArtOrdEnv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFormatos.ResumeLayout(False)
        Me.tsFormatos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents grbAlbaranes As System.Windows.Forms.GroupBox
    Private WithEvents dgvAlbaranes As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip2 As System.Windows.Forms.ToolStrip
    Private WithEvents tsLimpiarSelecciones As System.Windows.Forms.ToolStripButton
    Private WithEvents tsVerPedidos As System.Windows.Forms.ToolStripButton
   Private WithEvents miniToolStrip As System.Windows.Forms.ToolStrip
    Private WithEvents grbPedidos As System.Windows.Forms.GroupBox
    Private WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsInsertar1 As System.Windows.Forms.ToolStripButton
    Private WithEvents grbContenido As System.Windows.Forms.GroupBox
    Private WithEvents dgvArtOrdEnv As System.Windows.Forms.DataGridView
    Private WithEvents tsFormatos As System.Windows.Forms.ToolStrip
    Private WithEvents tsInsertar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsModificar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsEliminar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsDetalles As System.Windows.Forms.ToolStripButton
    Private WithEvents tsWord As System.Windows.Forms.ToolStripButton
End Class
