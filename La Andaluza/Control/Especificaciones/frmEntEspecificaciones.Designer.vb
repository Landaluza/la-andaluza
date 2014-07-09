<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntEspecificaciones
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEspecificaciones))
        Me.txtCodigoQS = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblFechaRevisado = New System.Windows.Forms.Label()
        Me.lblTipoLote = New System.Windows.Forms.Label()
        Me.dtpFechaRevisado = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.DtsEspecificaciones = New La_Andaluza.dtsEspecificaciones()
        Me.lblEspecificacionID = New System.Windows.Forms.Label()
        Me.lblTipoProducto = New System.Windows.Forms.Label()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.dgvEspecificaciones = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboLegislacion = New System.Windows.Forms.ComboBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lError = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsEspecificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEspecificaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "Especificaciones"
        Me.GeneralBindingSource.DataSource = Me.DtsEspecificaciones
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoQS.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CodigoQS", True))
        Me.txtCodigoQS.EsUnicoCampo = ""
        Me.txtCodigoQS.EsUnicoCampoID = ""
        Me.txtCodigoQS.EsUnicoID = 0
        Me.txtCodigoQS.EsUnicoTabla = ""
        Me.txtCodigoQS.Location = New System.Drawing.Point(95, 5)
        Me.txtCodigoQS.MaxLength = 15
        Me.txtCodigoQS.Minimo = 0
        Me.txtCodigoQS.Modificado = False
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Numerico_EsNumerico = False
        Me.txtCodigoQS.Numerico_NumeroDoublees = 0
        Me.txtCodigoQS.Numerico_SeparadorMiles = False
        Me.txtCodigoQS.Obligatorio = False
        Me.txtCodigoQS.ParametroID = 0
        Me.txtCodigoQS.Size = New System.Drawing.Size(109, 20)
        Me.txtCodigoQS.TabIndex = 1
        Me.txtCodigoQS.ValorMaximo = 0.0R
        Me.txtCodigoQS.ValorMinimo = 0.0R
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.AutoSize = True
        Me.lblCodigoQS.Location = New System.Drawing.Point(26, 8)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(58, 13)
        Me.lblCodigoQS.TabIndex = 6
        Me.lblCodigoQS.Text = "Codigo QS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaRevisado
        '
        Me.lblFechaRevisado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaRevisado.AutoSize = True
        Me.lblFechaRevisado.Location = New System.Drawing.Point(490, 8)
        Me.lblFechaRevisado.Name = "lblFechaRevisado"
        Me.lblFechaRevisado.Size = New System.Drawing.Size(85, 13)
        Me.lblFechaRevisado.TabIndex = 12
        Me.lblFechaRevisado.Text = "Fecha Revisado"
        Me.lblFechaRevisado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoLote
        '
        Me.lblTipoLote.AutoSize = True
        Me.lblTipoLote.Location = New System.Drawing.Point(26, 38)
        Me.lblTipoLote.Name = "lblTipoLote"
        Me.lblTipoLote.Size = New System.Drawing.Size(52, 13)
        Me.lblTipoLote.TabIndex = 14
        Me.lblTipoLote.Text = "Tipo Lote"
        Me.lblTipoLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFechaRevisado
        '
        Me.dtpFechaRevisado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtpFechaRevisado.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "FechaRevisado", True))
        Me.dtpFechaRevisado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRevisado.Location = New System.Drawing.Point(592, 5)
        Me.dtpFechaRevisado.Name = "dtpFechaRevisado"
        Me.dtpFechaRevisado.Size = New System.Drawing.Size(188, 20)
        Me.dtpFechaRevisado.TabIndex = 2
        '
        'cboTipoLote
        '
        Me.cboTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLote.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoLote", True))
        Me.cboTipoLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.FormattingEnabled = True
        Me.cboTipoLote.Location = New System.Drawing.Point(95, 35)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(278, 21)
        Me.cboTipoLote.TabIndex = 3
        '
        'DtsEspecificaciones
        '
        Me.DtsEspecificaciones.DataSetName = "dtsEspecificaciones"
        Me.DtsEspecificaciones.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lblEspecificacionID
        '
        Me.lblEspecificacionID.AutoSize = True
        Me.lblEspecificacionID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "EspecificacionID", True))
        Me.lblEspecificacionID.Location = New System.Drawing.Point(219, 11)
        Me.lblEspecificacionID.Name = "lblEspecificacionID"
        Me.lblEspecificacionID.Size = New System.Drawing.Size(13, 13)
        Me.lblEspecificacionID.TabIndex = 17
        Me.lblEspecificacionID.Text = "0"
        Me.lblEspecificacionID.Visible = False
        '
        'lblTipoProducto
        '
        Me.lblTipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTipoProducto.AutoSize = True
        Me.lblTipoProducto.Location = New System.Drawing.Point(490, 38)
        Me.lblTipoProducto.Name = "lblTipoProducto"
        Me.lblTipoProducto.Size = New System.Drawing.Size(74, 13)
        Me.lblTipoProducto.TabIndex = 18
        Me.lblTipoProducto.Text = "Tipo Producto"
        Me.lblTipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoProducto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoProducto", True))
        Me.cboTipoProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(593, 35)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(321, 21)
        Me.cboTipoProducto.TabIndex = 4
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Descripcion", True))
        Me.txtDescripcion.EsUnicoCampo = "Descripcion"
        Me.txtDescripcion.EsUnicoCampoID = "EspecificacionID"
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = "Especificaciones"
        Me.txtDescripcion.Location = New System.Drawing.Point(593, 67)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(322, 54)
        Me.txtDescripcion.TabIndex = 5
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(490, 70)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 15
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dgvEspecificaciones
        '
        Me.dgvEspecificaciones.AllowUserToAddRows = False
        Me.dgvEspecificaciones.AllowUserToDeleteRows = False
        Me.dgvEspecificaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEspecificaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEspecificaciones.Location = New System.Drawing.Point(0, 172)
        Me.dgvEspecificaciones.MultiSelect = False
        Me.dgvEspecificaciones.Name = "dgvEspecificaciones"
        Me.dgvEspecificaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEspecificaciones.Size = New System.Drawing.Size(969, 450)
        Me.dgvEspecificaciones.TabIndex = 1000000001
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 1000000002
        Me.Label1.Text = "Legislación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(969, 147)
        Me.Panel1.TabIndex = 1000000004
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboLegislacion)
        Me.Panel2.Controls.Add(Me.lblEspecificacionID)
        Me.Panel2.Controls.Add(Me.dtpFechaRevisado)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.lblTipoProducto)
        Me.Panel2.Controls.Add(Me.txtCodigoQS)
        Me.Panel2.Controls.Add(Me.cboTipoLote)
        Me.Panel2.Controls.Add(Me.lblFechaRevisado)
        Me.Panel2.Controls.Add(Me.cboTipoProducto)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.lblTipoLote)
        Me.Panel2.Controls.Add(Me.lblCodigoQS)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Location = New System.Drawing.Point(12, 17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(945, 124)
        Me.Panel2.TabIndex = 1000000005
        '
        'cboLegislacion
        '
        Me.cboLegislacion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLegislacion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLegislacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboLegislacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLegislacion.FormattingEnabled = True
        Me.cboLegislacion.Location = New System.Drawing.Point(95, 67)
        Me.cboLegislacion.Name = "cboLegislacion"
        Me.cboLegislacion.Size = New System.Drawing.Size(278, 21)
        Me.cboLegislacion.TabIndex = 1000000003
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lError)
        Me.Panel3.Location = New System.Drawing.Point(201, 197)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(561, 70)
        Me.Panel3.TabIndex = 1000000007
        Me.Panel3.Visible = False
        '
        'lError
        '
        Me.lError.AutoSize = True
        Me.lError.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lError.ForeColor = System.Drawing.Color.DarkRed
        Me.lError.Location = New System.Drawing.Point(72, 32)
        Me.lError.Name = "lError"
        Me.lError.Size = New System.Drawing.Size(0, 13)
        Me.lError.TabIndex = 1000000006
        Me.lError.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1850
        '
        'frmEntEspecificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 622)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.dgvEspecificaciones)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEntEspecificaciones"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.dgvEspecificaciones, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsEspecificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEspecificaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents lblCodigoQS As System.Windows.Forms.Label
   Private WithEvents lblFechaRevisado As System.Windows.Forms.Label
   Private WithEvents lblTipoLote As System.Windows.Forms.Label
   Private WithEvents dtpFechaRevisado As System.Windows.Forms.DateTimePicker
   Private WithEvents DtsEspecificaciones As La_Andaluza.dtsEspecificaciones
   Private WithEvents lblEspecificacionID As System.Windows.Forms.Label
    Private WithEvents txtCodigoQS As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents lblTipoProducto As System.Windows.Forms.Label
    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents dgvEspecificaciones As System.Windows.Forms.DataGridView
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents Panel1 As System.Windows.Forms.Panel
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents cboLegislacion As System.Windows.Forms.ComboBox
   Private WithEvents lError As System.Windows.Forms.Label
   Private WithEvents Timer1 As System.Windows.Forms.Timer
   Private WithEvents Panel3 As System.Windows.Forms.Panel
End Class
