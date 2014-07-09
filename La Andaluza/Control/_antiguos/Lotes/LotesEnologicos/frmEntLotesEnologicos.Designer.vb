<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntLotesEnologicos
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim CantidadRestanteLabel As System.Windows.Forms.Label
        Dim TipoLoteLabel As System.Windows.Forms.Label
        Dim TipoProductoLabel As System.Windows.Forms.Label
        Dim ProveedorLabel As System.Windows.Forms.Label
        Dim CodigoLoteLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntLotesEnologicos))
        Me.DtsLotes = New La_Andaluza.dtsLotes()
        Me.DescripcionCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.CantidadRestanteCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.TipoLoteIDComboMAM = New System.Windows.Forms.ComboBox()
        Me.TipoProductoIDComboMAM = New System.Windows.Forms.ComboBox()
        Me.ProveedorIDCombo = New System.Windows.Forms.ComboBox()
        Me.CodigoLoteCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtLoteProveedor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cbMedidas = New System.Windows.Forms.ComboBox()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblValorTransformar = New System.Windows.Forms.Label()
        DescripcionLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        CantidadRestanteLabel = New System.Windows.Forms.Label()
        TipoLoteLabel = New System.Windows.Forms.Label()
        TipoProductoLabel = New System.Windows.Forms.Label()
        ProveedorLabel = New System.Windows.Forms.Label()
        CodigoLoteLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "Lotes"
        Me.GeneralBindingSource.DataSource = Me.DtsLotes
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(36, 70)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 1000000002
        DescripcionLabel.Text = "Descripcion:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(36, 97)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 1000000004
        FechaLabel.Text = "Fecha:"
        '
        'CantidadRestanteLabel
        '
        CantidadRestanteLabel.AutoSize = True
        CantidadRestanteLabel.Location = New System.Drawing.Point(36, 128)
        CantidadRestanteLabel.Name = "CantidadRestanteLabel"
        CantidadRestanteLabel.Size = New System.Drawing.Size(98, 13)
        CantidadRestanteLabel.TabIndex = 1000000006
        CantidadRestanteLabel.Text = "Cantidad Restante:"
        '
        'TipoLoteLabel
        '
        TipoLoteLabel.AutoSize = True
        TipoLoteLabel.Location = New System.Drawing.Point(36, 160)
        TipoLoteLabel.Name = "TipoLoteLabel"
        TipoLoteLabel.Size = New System.Drawing.Size(55, 13)
        TipoLoteLabel.TabIndex = 1000000018
        TipoLoteLabel.Text = "Tipo Lote:"
        '
        'TipoProductoLabel
        '
        TipoProductoLabel.AutoSize = True
        TipoProductoLabel.Location = New System.Drawing.Point(36, 187)
        TipoProductoLabel.Name = "TipoProductoLabel"
        TipoProductoLabel.Size = New System.Drawing.Size(77, 13)
        TipoProductoLabel.TabIndex = 1000000020
        TipoProductoLabel.Text = "Tipo Producto:"
        '
        'ProveedorLabel
        '
        ProveedorLabel.AutoSize = True
        ProveedorLabel.Location = New System.Drawing.Point(36, 218)
        ProveedorLabel.Name = "ProveedorLabel"
        ProveedorLabel.Size = New System.Drawing.Size(59, 13)
        ProveedorLabel.TabIndex = 1000000024
        ProveedorLabel.Text = "Proveedor:"
        '
        'CodigoLoteLabel
        '
        CodigoLoteLabel.AutoSize = True
        CodigoLoteLabel.Location = New System.Drawing.Point(36, 275)
        CodigoLoteLabel.Name = "CodigoLoteLabel"
        CodigoLoteLabel.Size = New System.Drawing.Size(67, 13)
        CodigoLoteLabel.TabIndex = 1000000028
        CodigoLoteLabel.Text = "Codigo Lote:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(36, 249)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(83, 13)
        Label1.TabIndex = 1000000030
        Label1.Text = "Lote Proveedor:"
        '
        'DtsLotes
        '
        Me.DtsLotes.DataSetName = "dtsLotes"
        Me.DtsLotes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionCuadroDeTexto
        '
        Me.DescripcionCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Descripcion", True))
        Me.DescripcionCuadroDeTexto.EsUnicoCampo = ""
        Me.DescripcionCuadroDeTexto.EsUnicoCampoID = ""
        Me.DescripcionCuadroDeTexto.EsUnicoID = 0
        Me.DescripcionCuadroDeTexto.EsUnicoTabla = ""
        Me.DescripcionCuadroDeTexto.Location = New System.Drawing.Point(157, 67)
        Me.DescripcionCuadroDeTexto.MaxLength = 50
        Me.DescripcionCuadroDeTexto.Minimo = 0
        Me.DescripcionCuadroDeTexto.Modificado = False
        Me.DescripcionCuadroDeTexto.Name = "DescripcionCuadroDeTexto"
        Me.DescripcionCuadroDeTexto.Numerico_EsNumerico = False
        Me.DescripcionCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.DescripcionCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.DescripcionCuadroDeTexto.Obligatorio = False
        Me.DescripcionCuadroDeTexto.ParametroID = 0
        Me.DescripcionCuadroDeTexto.Size = New System.Drawing.Size(219, 20)
        Me.DescripcionCuadroDeTexto.TabIndex = 1
        Me.DescripcionCuadroDeTexto.ValorMaximo = 0.0R
        Me.DescripcionCuadroDeTexto.ValorMinimo = 0.0R
        '
        'dtpFecha
        '
        Me.dtpFecha.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Fecha", True))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(157, 93)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(121, 20)
        Me.dtpFecha.TabIndex = 2
        '
        'CantidadRestanteCuadroDeTexto
        '
        Me.CantidadRestanteCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CantidadRestanteCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CantidadRestante", True))
        Me.CantidadRestanteCuadroDeTexto.EsUnicoCampo = ""
        Me.CantidadRestanteCuadroDeTexto.EsUnicoCampoID = ""
        Me.CantidadRestanteCuadroDeTexto.EsUnicoID = 0
        Me.CantidadRestanteCuadroDeTexto.EsUnicoTabla = ""
        Me.CantidadRestanteCuadroDeTexto.Location = New System.Drawing.Point(157, 125)
        Me.CantidadRestanteCuadroDeTexto.Minimo = 0
        Me.CantidadRestanteCuadroDeTexto.Modificado = False
        Me.CantidadRestanteCuadroDeTexto.Name = "CantidadRestanteCuadroDeTexto"
        Me.CantidadRestanteCuadroDeTexto.Numerico_EsNumerico = True
        Me.CantidadRestanteCuadroDeTexto.Numerico_NumeroDoublees = 2
        Me.CantidadRestanteCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.CantidadRestanteCuadroDeTexto.Obligatorio = False
        Me.CantidadRestanteCuadroDeTexto.ParametroID = 0
        Me.CantidadRestanteCuadroDeTexto.Size = New System.Drawing.Size(121, 20)
        Me.CantidadRestanteCuadroDeTexto.TabIndex = 3
        Me.CantidadRestanteCuadroDeTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CantidadRestanteCuadroDeTexto.ValorMaximo = 0.0R
        Me.CantidadRestanteCuadroDeTexto.ValorMinimo = 0.0R
        '
        'TipoLoteIDComboMAM
        '
        Me.TipoLoteIDComboMAM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoLote", True))
        Me.TipoLoteIDComboMAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoLoteIDComboMAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoLoteIDComboMAM.FormattingEnabled = True
        Me.TipoLoteIDComboMAM.Location = New System.Drawing.Point(157, 157)
        Me.TipoLoteIDComboMAM.Name = "TipoLoteIDComboMAM"
        Me.TipoLoteIDComboMAM.Size = New System.Drawing.Size(219, 21)
        Me.TipoLoteIDComboMAM.TabIndex = 4
        '
        'TipoProductoIDComboMAM
        '
        Me.TipoProductoIDComboMAM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoProducto", True))
        Me.TipoProductoIDComboMAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TipoProductoIDComboMAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.TipoProductoIDComboMAM.FormattingEnabled = True
        Me.TipoProductoIDComboMAM.Location = New System.Drawing.Point(157, 184)
        Me.TipoProductoIDComboMAM.Name = "TipoProductoIDComboMAM"
        Me.TipoProductoIDComboMAM.Size = New System.Drawing.Size(219, 21)
        Me.TipoProductoIDComboMAM.TabIndex = 5
        '
        'ProveedorIDCombo
        '
        Me.ProveedorIDCombo.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Proveedor", True))
        Me.ProveedorIDCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ProveedorIDCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ProveedorIDCombo.FormattingEnabled = True
        Me.ProveedorIDCombo.Location = New System.Drawing.Point(157, 215)
        Me.ProveedorIDCombo.Name = "ProveedorIDCombo"
        Me.ProveedorIDCombo.Size = New System.Drawing.Size(219, 21)
        Me.ProveedorIDCombo.TabIndex = 6
        '
        'CodigoLoteCuadroDeTexto
        '
        Me.CodigoLoteCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CodigoLoteCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CodigoLote", True))
        Me.CodigoLoteCuadroDeTexto.EsUnicoCampo = "CodigoLote"
        Me.CodigoLoteCuadroDeTexto.EsUnicoCampoID = "LoteID"
        Me.CodigoLoteCuadroDeTexto.EsUnicoID = 0
        Me.CodigoLoteCuadroDeTexto.EsUnicoTabla = "Lotes"
        Me.CodigoLoteCuadroDeTexto.Location = New System.Drawing.Point(157, 272)
        Me.CodigoLoteCuadroDeTexto.MaxLength = 15
        Me.CodigoLoteCuadroDeTexto.Minimo = 0
        Me.CodigoLoteCuadroDeTexto.Modificado = False
        Me.CodigoLoteCuadroDeTexto.Name = "CodigoLoteCuadroDeTexto"
        Me.CodigoLoteCuadroDeTexto.Numerico_EsNumerico = False
        Me.CodigoLoteCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CodigoLoteCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CodigoLoteCuadroDeTexto.Obligatorio = False
        Me.CodigoLoteCuadroDeTexto.ParametroID = 0
        Me.CodigoLoteCuadroDeTexto.ReadOnly = True
        Me.CodigoLoteCuadroDeTexto.Size = New System.Drawing.Size(219, 20)
        Me.CodigoLoteCuadroDeTexto.TabIndex = 7
        Me.CodigoLoteCuadroDeTexto.ValorMaximo = 0.0R
        Me.CodigoLoteCuadroDeTexto.ValorMinimo = 0.0R
        '
        'txtLoteProveedor
        '
        Me.txtLoteProveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoteProveedor.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "LoteProveedor", True))
        Me.txtLoteProveedor.EsUnicoCampo = ""
        Me.txtLoteProveedor.EsUnicoCampoID = ""
        Me.txtLoteProveedor.EsUnicoID = 0
        Me.txtLoteProveedor.EsUnicoTabla = ""
        Me.txtLoteProveedor.Location = New System.Drawing.Point(157, 246)
        Me.txtLoteProveedor.MaxLength = 50
        Me.txtLoteProveedor.Minimo = 0
        Me.txtLoteProveedor.Modificado = False
        Me.txtLoteProveedor.Name = "txtLoteProveedor"
        Me.txtLoteProveedor.Numerico_EsNumerico = False
        Me.txtLoteProveedor.Numerico_NumeroDoublees = 0
        Me.txtLoteProveedor.Numerico_SeparadorMiles = False
        Me.txtLoteProveedor.Obligatorio = False
        Me.txtLoteProveedor.ParametroID = 0
        Me.txtLoteProveedor.Size = New System.Drawing.Size(219, 20)
        Me.txtLoteProveedor.TabIndex = 1000000029
        Me.txtLoteProveedor.ValorMaximo = 0.0R
        Me.txtLoteProveedor.ValorMinimo = 0.0R
        '
        'cbMedidas
        '
        Me.cbMedidas.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Proveedor", True))
        Me.cbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbMedidas.FormattingEnabled = True
        Me.cbMedidas.Location = New System.Drawing.Point(284, 124)
        Me.cbMedidas.Name = "cbMedidas"
        Me.cbMedidas.Size = New System.Drawing.Size(92, 21)
        Me.cbMedidas.TabIndex = 1000000031
        '
        'txtDensidad
        '
        Me.txtDensidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDensidad.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CantidadRestante", True))
        Me.txtDensidad.EsUnicoCampo = ""
        Me.txtDensidad.EsUnicoCampoID = ""
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = ""
        Me.txtDensidad.Location = New System.Drawing.Point(396, 124)
        Me.txtDensidad.Minimo = 0
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 2
        Me.txtDensidad.Numerico_SeparadorMiles = True
        Me.txtDensidad.Obligatorio = False
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(55, 20)
        Me.txtDensidad.TabIndex = 1000000032
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0.0R
        Me.txtDensidad.ValorMinimo = 0.0R
        '
        'lblValorTransformar
        '
        Me.lblValorTransformar.AutoSize = True
        Me.lblValorTransformar.Location = New System.Drawing.Point(396, 108)
        Me.lblValorTransformar.Name = "lblValorTransformar"
        Me.lblValorTransformar.Size = New System.Drawing.Size(55, 13)
        Me.lblValorTransformar.TabIndex = 1000000033
        Me.lblValorTransformar.Text = "Densidad:"
        '
        'frmEntLotesEnologicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(477, 337)
        Me.Controls.Add(Me.lblValorTransformar)
        Me.Controls.Add(Me.txtDensidad)
        Me.Controls.Add(Me.cbMedidas)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtLoteProveedor)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionCuadroDeTexto)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(CantidadRestanteLabel)
        Me.Controls.Add(Me.CantidadRestanteCuadroDeTexto)
        Me.Controls.Add(TipoLoteLabel)
        Me.Controls.Add(Me.TipoLoteIDComboMAM)
        Me.Controls.Add(TipoProductoLabel)
        Me.Controls.Add(Me.TipoProductoIDComboMAM)
        Me.Controls.Add(ProveedorLabel)
        Me.Controls.Add(Me.ProveedorIDCombo)
        Me.Controls.Add(CodigoLoteLabel)
        Me.Controls.Add(Me.CodigoLoteCuadroDeTexto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEntLotesEnologicos"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.CodigoLoteCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CodigoLoteLabel, 0)
        Me.Controls.SetChildIndex(Me.ProveedorIDCombo, 0)
        Me.Controls.SetChildIndex(ProveedorLabel, 0)
        Me.Controls.SetChildIndex(Me.TipoProductoIDComboMAM, 0)
        Me.Controls.SetChildIndex(TipoProductoLabel, 0)
        Me.Controls.SetChildIndex(Me.TipoLoteIDComboMAM, 0)
        Me.Controls.SetChildIndex(TipoLoteLabel, 0)
        Me.Controls.SetChildIndex(Me.CantidadRestanteCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CantidadRestanteLabel, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(FechaLabel, 0)
        Me.Controls.SetChildIndex(Me.DescripcionCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(DescripcionLabel, 0)
        Me.Controls.SetChildIndex(Me.txtLoteProveedor, 0)
        Me.Controls.SetChildIndex(Label1, 0)
        Me.Controls.SetChildIndex(Me.cbMedidas, 0)
        Me.Controls.SetChildIndex(Me.txtDensidad, 0)
        Me.Controls.SetChildIndex(Me.lblValorTransformar, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsLotes As La_Andaluza.dtsLotes
    Private WithEvents DescripcionCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents CantidadRestanteCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents TipoLoteIDComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents TipoProductoIDComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents ProveedorIDCombo As System.Windows.Forms.ComboBox
    Private WithEvents CodigoLoteCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtLoteProveedor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cbMedidas As System.Windows.Forms.ComboBox
    Private WithEvents txtDensidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblValorTransformar As System.Windows.Forms.Label

End Class
