<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntCargaNecesidadesJRMaestro
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CargaNecesidadesJRMaestroIDLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCargaNecesidadesJRMaestro))
        Me.DtsCargaNecesidadesJRMaestro = New La_Andaluza.dtsCargaNecesidadesJRMaestro()
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.grbContenido = New System.Windows.Forms.GroupBox()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.tsFormatos1 = New System.Windows.Forms.ToolStrip()
        Me.tsInsertar = New System.Windows.Forms.ToolStripButton()
        Me.tsModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.ServidoCheckBox = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CargaNecesidadesJRMaestroIDLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsCargaNecesidadesJRMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbContenido.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFormatos1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "CargaNecesidadesJRMaestro"
        Me.GeneralBindingSource.DataSource = Me.DtsCargaNecesidadesJRMaestro
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'CargaNecesidadesJRMaestroIDLabel
        '
        CargaNecesidadesJRMaestroIDLabel.AutoSize = True
        CargaNecesidadesJRMaestroIDLabel.Location = New System.Drawing.Point(274, -6)
        CargaNecesidadesJRMaestroIDLabel.Name = "CargaNecesidadesJRMaestroIDLabel"
        CargaNecesidadesJRMaestroIDLabel.Size = New System.Drawing.Size(62, 13)
        CargaNecesidadesJRMaestroIDLabel.TabIndex = 1000000000
        CargaNecesidadesJRMaestroIDLabel.Text = "Maestro ID:"
        CargaNecesidadesJRMaestroIDLabel.Visible = False
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(50, 6)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 1000000002
        FechaLabel.Text = "Fecha:"
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(57, 32)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(33, 13)
        HoraLabel.TabIndex = 1000000004
        HoraLabel.Text = "Hora:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(9, 56)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 1000000006
        ObservacionesLabel.Text = "Observaciones:"
        '
        'DtsCargaNecesidadesJRMaestro
        '
        Me.DtsCargaNecesidadesJRMaestro.DataSetName = "dtsCargaNecesidadesJRMaestro"
        Me.DtsCargaNecesidadesJRMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargaNecesidadesJRMaestroIDCuadroDeTexto
        '
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "MaestroID", True))
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoCampo = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoID = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoTabla = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Location = New System.Drawing.Point(342, -9)
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Minimo = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Modificado = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Name = "CargaNecesidadesJRMaestroIDCuadroDeTexto"
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Obligatorio = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ParametroID = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Size = New System.Drawing.Size(54, 20)
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.TabIndex = 1000000001
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ValorMaximo = 0.0R
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ValorMinimo = 0.0R
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Visible = False
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(96, 3)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(84, 20)
        Me.FechaDateTimePicker.TabIndex = 1000000003
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Hora", True))
        Me.HoraDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(96, 29)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.ShowUpDown = True
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(62, 20)
        Me.HoraDateTimePicker.TabIndex = 1000000005
        '
        'ObservacionesCuadroDeTexto
        '
        Me.ObservacionesCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.ObservacionesCuadroDeTexto.EsUnicoCampo = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoCampoID = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoID = 0
        Me.ObservacionesCuadroDeTexto.EsUnicoTabla = ""
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(96, 55)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(594, 20)
        Me.ObservacionesCuadroDeTexto.TabIndex = 1000000007
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0.0R
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0.0R
        '
        'grbContenido
        '
        Me.grbContenido.Controls.Add(Me.dgv)
        Me.grbContenido.Controls.Add(Me.tsFormatos1)
        Me.grbContenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbContenido.Location = New System.Drawing.Point(0, 106)
        Me.grbContenido.Name = "grbContenido"
        Me.grbContenido.Size = New System.Drawing.Size(821, 519)
        Me.grbContenido.TabIndex = 1000000031
        Me.grbContenido.TabStop = False
        Me.grbContenido.Text = "Articulos"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AllowUserToDeleteRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 16)
        Me.dgv.Name = "dgv"
        Me.dgv.ReadOnly = True
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(783, 500)
        Me.dgv.TabIndex = 13
        '
        'tsFormatos1
        '
        Me.tsFormatos1.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsFormatos1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.tsFormatos1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsertar, Me.tsModificar, Me.tsEliminar})
        Me.tsFormatos1.Location = New System.Drawing.Point(786, 16)
        Me.tsFormatos1.Name = "tsFormatos1"
        Me.tsFormatos1.Size = New System.Drawing.Size(32, 500)
        Me.tsFormatos1.TabIndex = 12
        Me.tsFormatos1.Text = "ToolStrip2"
        '
        'tsInsertar
        '
        Me.tsInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsInsertar.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsInsertar.Name = "tsInsertar"
        Me.tsInsertar.RightToLeftAutoMirrorImage = True
        Me.tsInsertar.Size = New System.Drawing.Size(29, 20)
        Me.tsInsertar.Text = "Añadir"
        Me.tsInsertar.ToolTipText = "Añadir"
        '
        'tsModificar
        '
        Me.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsModificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(29, 20)
        Me.tsModificar.Text = "Modificar"
        Me.tsModificar.ToolTipText = "Modificar"
        '
        'tsEliminar
        '
        Me.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.RightToLeftAutoMirrorImage = True
        Me.tsEliminar.Size = New System.Drawing.Size(29, 20)
        Me.tsEliminar.Text = "Eliminar"
        Me.tsEliminar.ToolTipText = "Eliminar"
        '
        'ServidoCheckBox
        '
        Me.ServidoCheckBox.AutoSize = True
        Me.ServidoCheckBox.Location = New System.Drawing.Point(218, 32)
        Me.ServidoCheckBox.Name = "ServidoCheckBox"
        Me.ServidoCheckBox.Size = New System.Drawing.Size(62, 17)
        Me.ServidoCheckBox.TabIndex = 1000000032
        Me.ServidoCheckBox.Text = "Servido"
        Me.ServidoCheckBox.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ServidoCheckBox)
        Me.Panel1.Controls.Add(Me.FechaDateTimePicker)
        Me.Panel1.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.Panel1.Controls.Add(CargaNecesidadesJRMaestroIDLabel)
        Me.Panel1.Controls.Add(ObservacionesLabel)
        Me.Panel1.Controls.Add(Me.CargaNecesidadesJRMaestroIDCuadroDeTexto)
        Me.Panel1.Controls.Add(Me.HoraDateTimePicker)
        Me.Panel1.Controls.Add(FechaLabel)
        Me.Panel1.Controls.Add(HoraLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(821, 81)
        Me.Panel1.TabIndex = 14
        '
        'frmEntCargaNecesidadesJRMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(821, 625)
        Me.Controls.Add(Me.grbContenido)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEntCargaNecesidadesJRMaestro"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.grbContenido, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsCargaNecesidadesJRMaestro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbContenido.ResumeLayout(False)
        Me.grbContenido.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFormatos1.ResumeLayout(False)
        Me.tsFormatos1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsCargaNecesidadesJRMaestro As La_Andaluza.dtsCargaNecesidadesJRMaestro
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents CargaNecesidadesJRMaestroIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents ServidoCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents grbContenido As System.Windows.Forms.GroupBox
    Private WithEvents dgv As System.Windows.Forms.DataGridView
    Private WithEvents tsFormatos1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsInsertar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsModificar As System.Windows.Forms.ToolStripButton
    Private WithEvents tsEliminar As System.Windows.Forms.ToolStripButton

End Class
