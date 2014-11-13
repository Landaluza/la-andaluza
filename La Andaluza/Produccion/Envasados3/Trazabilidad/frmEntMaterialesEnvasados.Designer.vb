<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntMaterialesEnvasados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntMaterialesEnvasados))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoMaterial = New System.Windows.Forms.ComboBox()
        Me.butVerTipoMaterialID = New System.Windows.Forms.Button()
        Me.butAddTipoMaterialID = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedorID = New System.Windows.Forms.Button()
        Me.butAddProveedorID = New System.Windows.Forms.Button()
        Me.cboFormatoEnvasado = New System.Windows.Forms.ComboBox()
        Me.butVerFormatoEnvasadoID = New System.Windows.Forms.Button()
        Me.butAddFormatoEnvasadoID = New System.Windows.Forms.Button()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblTipoMaterialID = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(139, 18)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraInicio.TabIndex = 0
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(139, 45)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraFin.TabIndex = 1
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(139, 72)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 21)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLote.EsUnicoCampo = ""
        Me.txtLote.EsUnicoCampoID = ""
        Me.txtLote.EsUnicoID = 0
        Me.txtLote.EsUnicoTabla = ""
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(139, 99)
        Me.txtLote.MaxLength = 100
        Me.txtLote.Minimo = 0
        Me.txtLote.Modificado = False
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Numerico_EsNumerico = False
        Me.txtLote.Numerico_NumeroDoublees = 0
        Me.txtLote.Numerico_SeparadorMiles = False
        Me.txtLote.Obligatorio = False
        Me.txtLote.ParametroID = 0
        Me.txtLote.Size = New System.Drawing.Size(200, 21)
        Me.txtLote.TabIndex = 3
        Me.txtLote.ValorMaximo = 0.0R
        Me.txtLote.ValorMinimo = 0.0R
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(139, 126)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = False
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = False
        Me.txtCantidad.Obligatorio = False
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(200, 21)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'cboTipoMaterial
        '
        Me.cboTipoMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMaterial.Location = New System.Drawing.Point(139, 153)
        Me.cboTipoMaterial.Name = "cboTipoMaterial"
        Me.cboTipoMaterial.Size = New System.Drawing.Size(200, 23)
        Me.cboTipoMaterial.TabIndex = 5
        '
        'butVerTipoMaterialID
        '
        Me.butVerTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTipoMaterialID.Location = New System.Drawing.Point(345, 153)
        Me.butVerTipoMaterialID.Name = "butVerTipoMaterialID"
        Me.butVerTipoMaterialID.Size = New System.Drawing.Size(20, 20)
        Me.butVerTipoMaterialID.TabIndex = 6
        Me.butVerTipoMaterialID.TabStop = False
        '
        'butAddTipoMaterialID
        '
        Me.butAddTipoMaterialID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoMaterialID.Location = New System.Drawing.Point(371, 153)
        Me.butAddTipoMaterialID.Name = "butAddTipoMaterialID"
        Me.butAddTipoMaterialID.Size = New System.Drawing.Size(20, 23)
        Me.butAddTipoMaterialID.TabIndex = 7
        Me.butAddTipoMaterialID.TabStop = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(139, 182)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(200, 23)
        Me.cboProveedor.TabIndex = 6
        '
        'butVerProveedorID
        '
        Me.butVerProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedorID.Location = New System.Drawing.Point(345, 182)
        Me.butVerProveedorID.Name = "butVerProveedorID"
        Me.butVerProveedorID.Size = New System.Drawing.Size(20, 20)
        Me.butVerProveedorID.TabIndex = 9
        Me.butVerProveedorID.TabStop = False
        '
        'butAddProveedorID
        '
        Me.butAddProveedorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedorID.Location = New System.Drawing.Point(371, 182)
        Me.butAddProveedorID.Name = "butAddProveedorID"
        Me.butAddProveedorID.Size = New System.Drawing.Size(20, 23)
        Me.butAddProveedorID.TabIndex = 10
        Me.butAddProveedorID.TabStop = False
        '
        'cboFormatoEnvasado
        '
        Me.cboFormatoEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFormatoEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFormatoEnvasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboFormatoEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormatoEnvasado.Location = New System.Drawing.Point(139, 211)
        Me.cboFormatoEnvasado.Name = "cboFormatoEnvasado"
        Me.cboFormatoEnvasado.Size = New System.Drawing.Size(200, 23)
        Me.cboFormatoEnvasado.TabIndex = 7
        '
        'butVerFormatoEnvasadoID
        '
        Me.butVerFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerFormatoEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerFormatoEnvasadoID.Location = New System.Drawing.Point(345, 211)
        Me.butVerFormatoEnvasadoID.Name = "butVerFormatoEnvasadoID"
        Me.butVerFormatoEnvasadoID.Size = New System.Drawing.Size(20, 20)
        Me.butVerFormatoEnvasadoID.TabIndex = 12
        Me.butVerFormatoEnvasadoID.TabStop = False
        '
        'butAddFormatoEnvasadoID
        '
        Me.butAddFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddFormatoEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddFormatoEnvasadoID.Location = New System.Drawing.Point(371, 211)
        Me.butAddFormatoEnvasadoID.Name = "butAddFormatoEnvasadoID"
        Me.butAddFormatoEnvasadoID.Size = New System.Drawing.Size(20, 23)
        Me.butAddFormatoEnvasadoID.TabIndex = 13
        Me.butAddFormatoEnvasadoID.TabStop = False
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraInicio.Location = New System.Drawing.Point(23, 15)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(110, 27)
        Me.lblHoraInicio.TabIndex = 0
        Me.lblHoraInicio.Text = "HoraInicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHoraFin.Location = New System.Drawing.Point(23, 42)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(110, 27)
        Me.lblHoraFin.TabIndex = 1
        Me.lblHoraFin.Text = "HoraFin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 69)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(110, 27)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLote
        '
        Me.lblLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLote.Location = New System.Drawing.Point(23, 96)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(110, 27)
        Me.lblLote.TabIndex = 3
        Me.lblLote.Text = "Lote"
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCantidad.Location = New System.Drawing.Point(23, 123)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(110, 27)
        Me.lblCantidad.TabIndex = 4
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoMaterialID
        '
        Me.lblTipoMaterialID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoMaterialID.Location = New System.Drawing.Point(23, 150)
        Me.lblTipoMaterialID.Name = "lblTipoMaterialID"
        Me.lblTipoMaterialID.Size = New System.Drawing.Size(110, 29)
        Me.lblTipoMaterialID.TabIndex = 5
        Me.lblTipoMaterialID.Text = "TipoMaterial"
        Me.lblTipoMaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblProveedorID.Location = New System.Drawing.Point(23, 179)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(110, 29)
        Me.lblProveedorID.TabIndex = 8
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(23, 208)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(110, 29)
        Me.lblFormatoEnvasadoID.TabIndex = 11
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasado"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMiddle.Controls.Add(Me.lblHoraInicio, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraInicio, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblHoraFin, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraFin, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblLote, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtLote, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblTipoMaterialID, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.cboTipoMaterial, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoMaterialID, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoMaterialID, 4, 5)
        Me.tlpMiddle.Controls.Add(Me.lblProveedorID, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.cboProveedor, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.butVerProveedorID, 3, 6)
        Me.tlpMiddle.Controls.Add(Me.butAddProveedorID, 4, 6)
        Me.tlpMiddle.Controls.Add(Me.lblFormatoEnvasadoID, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.cboFormatoEnvasado, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.butVerFormatoEnvasadoID, 3, 7)
        Me.tlpMiddle.Controls.Add(Me.butAddFormatoEnvasadoID, 4, 7)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(469, 277)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntMaterialesEnvasados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(469, 302)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntMaterialesEnvasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "MaterialesEnvasados"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtLote As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboTipoMaterial As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents butAddTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerProveedorID As System.Windows.Forms.Button
    Private WithEvents butAddProveedorID As System.Windows.Forms.Button
    Private WithEvents cboFormatoEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents butVerFormatoEnvasadoID As System.Windows.Forms.Button
    Private WithEvents butAddFormatoEnvasadoID As System.Windows.Forms.Button
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblLote As System.Windows.Forms.Label
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblTipoMaterialID As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
