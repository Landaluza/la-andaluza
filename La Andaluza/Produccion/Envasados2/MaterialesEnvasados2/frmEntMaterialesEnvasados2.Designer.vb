<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntMaterialesEnvasados2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntMaterialesEnvasados2))

        Me.lblMaterialEnvasadoID = New System.Windows.Forms.Label()
        Me.txtMaterialEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.txtLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblTipoMaterialID = New System.Windows.Forms.Label()
        Me.cboTipoMaterialID = New System.Windows.Forms.ComboBox()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.cboProveedorID = New System.Windows.Forms.ComboBox()
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.cboFormatoEnvasadoID = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'tlpTop
        '




        '
        'lblMaterialEnvasadoID
        '
        Me.lblMaterialEnvasadoID.Location = New System.Drawing.Point(55, 380)
        Me.lblMaterialEnvasadoID.Name = "lblMaterialEnvasadoID"
        Me.lblMaterialEnvasadoID.Size = New System.Drawing.Size(110, 21)
        Me.lblMaterialEnvasadoID.TabIndex = 1000000003
        Me.lblMaterialEnvasadoID.Text = "MaterialEnvasadoID"
        Me.lblMaterialEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMaterialEnvasadoID.Visible = False
        '
        'txtMaterialEnvasadoID
        '
        Me.txtMaterialEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaterialEnvasadoID.Enabled = False
        Me.txtMaterialEnvasadoID.EsUnicoCampo = ""
        Me.txtMaterialEnvasadoID.EsUnicoCampoID = ""
        Me.txtMaterialEnvasadoID.EsUnicoID = 0
        Me.txtMaterialEnvasadoID.EsUnicoTabla = ""
        Me.txtMaterialEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterialEnvasadoID.Location = New System.Drawing.Point(186, 383)
        Me.txtMaterialEnvasadoID.MaxLength = 9
        Me.txtMaterialEnvasadoID.Minimo = 0
        Me.txtMaterialEnvasadoID.Modificado = False
        Me.txtMaterialEnvasadoID.Name = "txtMaterialEnvasadoID"
        Me.txtMaterialEnvasadoID.Numerico_EsNumerico = False
        Me.txtMaterialEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtMaterialEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtMaterialEnvasadoID.Obligatorio = True
        Me.txtMaterialEnvasadoID.ParametroID = 0
        Me.txtMaterialEnvasadoID.Size = New System.Drawing.Size(56, 21)
        Me.txtMaterialEnvasadoID.TabIndex = 1000000002
        Me.txtMaterialEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMaterialEnvasadoID.ValorMaximo = 0.0R
        Me.txtMaterialEnvasadoID.ValorMinimo = 0.0R
        Me.txtMaterialEnvasadoID.Visible = False
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(7, 41)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(110, 21)
        Me.lblHoraInicio.TabIndex = 1
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(135, 43)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraInicio.TabIndex = 2
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(236, 41)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(66, 21)
        Me.lblHoraFin.TabIndex = 3
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(320, 41)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraFin.TabIndex = 4
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(7, 181)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(110, 21)
        Me.lblObservaciones.TabIndex = 13
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtObservaciones.Location = New System.Drawing.Point(135, 181)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 88)
        Me.txtObservaciones.TabIndex = 14
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblLote
        '
        Me.lblLote.Location = New System.Drawing.Point(7, 97)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(110, 21)
        Me.lblLote.TabIndex = 7
        Me.lblLote.Text = "Lote"
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.EsUnicoCampo = ""
        Me.txtLote.EsUnicoCampoID = ""
        Me.txtLote.EsUnicoID = 0
        Me.txtLote.EsUnicoTabla = ""
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(135, 97)
        Me.txtLote.MaxLength = 100
        Me.txtLote.Minimo = 0
        Me.txtLote.Modificado = False
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Numerico_EsNumerico = False
        Me.txtLote.Numerico_NumeroDoublees = 0
        Me.txtLote.Numerico_SeparadorMiles = False
        Me.txtLote.Obligatorio = False
        Me.txtLote.ParametroID = 0
        Me.txtLote.Size = New System.Drawing.Size(280, 21)
        Me.txtLote.TabIndex = 8
        Me.txtLote.ValorMaximo = 0.0R
        Me.txtLote.ValorMinimo = 0.0R
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(7, 125)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(110, 21)
        Me.lblCantidad.TabIndex = 9
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(135, 125)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = True
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = True
        Me.txtCantidad.Obligatorio = False
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(56, 21)
        Me.txtCantidad.TabIndex = 10
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'lblTipoMaterialID
        '
        Me.lblTipoMaterialID.Location = New System.Drawing.Point(7, 68)
        Me.lblTipoMaterialID.Name = "lblTipoMaterialID"
        Me.lblTipoMaterialID.Size = New System.Drawing.Size(110, 21)
        Me.lblTipoMaterialID.TabIndex = 5
        Me.lblTipoMaterialID.Text = "Tipo Material"
        Me.lblTipoMaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTipoMaterialID
        '
        Me.cboTipoMaterialID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoMaterialID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoMaterialID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMaterialID.Location = New System.Drawing.Point(135, 68)
        Me.cboTipoMaterialID.Name = "cboTipoMaterialID"
        Me.cboTipoMaterialID.Size = New System.Drawing.Size(280, 23)
        Me.cboTipoMaterialID.TabIndex = 6
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Location = New System.Drawing.Point(7, 153)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(110, 21)
        Me.lblProveedorID.TabIndex = 11
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboProveedorID
        '
        Me.cboProveedorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorID.Location = New System.Drawing.Point(135, 152)
        Me.cboProveedorID.Name = "cboProveedorID"
        Me.cboProveedorID.Size = New System.Drawing.Size(280, 23)
        Me.cboProveedorID.TabIndex = 12
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(58, 356)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(110, 21)
        Me.lblFormatoEnvasadoID.TabIndex = 1000000019
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Visible = False
        '
        'cboFormatoEnvasadoID
        '
        Me.cboFormatoEnvasadoID.Enabled = False
        Me.cboFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormatoEnvasadoID.Location = New System.Drawing.Point(186, 354)
        Me.cboFormatoEnvasadoID.Name = "cboFormatoEnvasadoID"
        Me.cboFormatoEnvasadoID.Size = New System.Drawing.Size(150, 23)
        Me.cboFormatoEnvasadoID.TabIndex = 1000000018
        Me.cboFormatoEnvasadoID.Visible = False
        '
        'frmEntMaterialesEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(459, 304)
        Me.Controls.Add(Me.lblHoraInicio)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.lblHoraFin)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblLote)
        Me.Controls.Add(Me.txtLote)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblTipoMaterialID)
        Me.Controls.Add(Me.cboTipoMaterialID)
        Me.Controls.Add(Me.lblProveedorID)
        Me.Controls.Add(Me.cboProveedorID)
        Me.Controls.Add(Me.lblFormatoEnvasadoID)
        Me.Controls.Add(Me.cboFormatoEnvasadoID)
        Me.Controls.Add(Me.lblMaterialEnvasadoID)
        Me.Controls.Add(Me.txtMaterialEnvasadoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntMaterialesEnvasados2"
        Me.Text = "MaterialesEnvasados2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.txtMaterialEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.lblMaterialEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.cboFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.lblFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.cboProveedorID, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorID, 0)
        Me.Controls.SetChildIndex(Me.cboTipoMaterialID, 0)
        Me.Controls.SetChildIndex(Me.lblTipoMaterialID, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.lblCantidad, 0)
        Me.Controls.SetChildIndex(Me.txtLote, 0)
        Me.Controls.SetChildIndex(Me.lblLote, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraFin, 0)
        Me.Controls.SetChildIndex(Me.lblHoraFin, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraInicio, 0)
        Me.Controls.SetChildIndex(Me.lblHoraInicio, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents lblMaterialEnvasadoID As System.Windows.Forms.Label
    Private WithEvents txtMaterialEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents cboFormatoEnvasadoID As System.Windows.Forms.ComboBox
    Public WithEvents lblHoraInicio As System.Windows.Forms.Label
    Public WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Public WithEvents lblHoraFin As System.Windows.Forms.Label
    Public WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Public WithEvents lblObservaciones As System.Windows.Forms.Label
    Public WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Public WithEvents lblLote As System.Windows.Forms.Label
    Public WithEvents txtLote As BasesParaCompatibilidad.CuadroDeTexto
    Public WithEvents lblCantidad As System.Windows.Forms.Label
    Public WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Public WithEvents lblTipoMaterialID As System.Windows.Forms.Label
    Public WithEvents cboTipoMaterialID As System.Windows.Forms.ComboBox
    Public WithEvents lblProveedorID As System.Windows.Forms.Label
    Public WithEvents cboProveedorID As System.Windows.Forms.ComboBox
End Class
