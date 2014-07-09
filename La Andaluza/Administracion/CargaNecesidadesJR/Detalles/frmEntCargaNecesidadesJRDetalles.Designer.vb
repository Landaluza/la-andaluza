<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntCargaNecesidadesJRDetalles
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
        Dim CargaNecesidadesJRDetalleIDLabel As System.Windows.Forms.Label
        Dim CargaNecesidadesJRMaestroIDLabel As System.Windows.Forms.Label
        Dim ArticuloIDLabel As System.Windows.Forms.Label
        Dim CargaLabel As System.Windows.Forms.Label
        Dim StockLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Reserva1Label As System.Windows.Forms.Label
        Dim Reserva2Label As System.Windows.Forms.Label
        Dim Reserva3Label As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCargaNecesidadesJRDetalles))
        Me.DtsCargaNecesidadesJRDetalles = New La_Andaluza.dtsCargaNecesidadesJRDetalles()
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.ArticuloIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CargaCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.StockCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva1CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva2CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva3CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticulos = New System.Windows.Forms.ComboBox()
        Me.lblAñadirArticulo = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        CargaNecesidadesJRDetalleIDLabel = New System.Windows.Forms.Label()
        CargaNecesidadesJRMaestroIDLabel = New System.Windows.Forms.Label()
        ArticuloIDLabel = New System.Windows.Forms.Label()
        CargaLabel = New System.Windows.Forms.Label()
        StockLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Reserva1Label = New System.Windows.Forms.Label()
        Reserva2Label = New System.Windows.Forms.Label()
        Reserva3Label = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsCargaNecesidadesJRDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "CargaNecesidadesJRDetalles"
        Me.GeneralBindingSource.DataSource = Me.DtsCargaNecesidadesJRDetalles
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'CargaNecesidadesJRDetalleIDLabel
        '
        CargaNecesidadesJRDetalleIDLabel.AutoSize = True
        CargaNecesidadesJRDetalleIDLabel.Location = New System.Drawing.Point(39, 52)
        CargaNecesidadesJRDetalleIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargaNecesidadesJRDetalleIDLabel.Name = "CargaNecesidadesJRDetalleIDLabel"
        CargaNecesidadesJRDetalleIDLabel.Size = New System.Drawing.Size(65, 17)
        CargaNecesidadesJRDetalleIDLabel.TabIndex = 1000000000
        CargaNecesidadesJRDetalleIDLabel.Text = "DetallaID"
        CargaNecesidadesJRDetalleIDLabel.Visible = False
        '
        'CargaNecesidadesJRMaestroIDLabel
        '
        CargaNecesidadesJRMaestroIDLabel.AutoSize = True
        CargaNecesidadesJRMaestroIDLabel.Location = New System.Drawing.Point(39, 84)
        CargaNecesidadesJRMaestroIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargaNecesidadesJRMaestroIDLabel.Name = "CargaNecesidadesJRMaestroIDLabel"
        CargaNecesidadesJRMaestroIDLabel.Size = New System.Drawing.Size(72, 17)
        CargaNecesidadesJRMaestroIDLabel.TabIndex = 1000000002
        CargaNecesidadesJRMaestroIDLabel.Text = "MaestroID"
        CargaNecesidadesJRMaestroIDLabel.Visible = False
        '
        'ArticuloIDLabel
        '
        ArticuloIDLabel.AutoSize = True
        ArticuloIDLabel.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArticuloIDLabel.Location = New System.Drawing.Point(24, 139)
        ArticuloIDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ArticuloIDLabel.Name = "ArticuloIDLabel"
        ArticuloIDLabel.Size = New System.Drawing.Size(115, 29)
        ArticuloIDLabel.TabIndex = 1000000004
        ArticuloIDLabel.Text = "Articulo:"
        '
        'CargaLabel
        '
        CargaLabel.AutoSize = True
        CargaLabel.Location = New System.Drawing.Point(39, 225)
        CargaLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        CargaLabel.Name = "CargaLabel"
        CargaLabel.Size = New System.Drawing.Size(50, 17)
        CargaLabel.TabIndex = 1000000006
        CargaLabel.Text = "Carga:"
        '
        'StockLabel
        '
        StockLabel.AutoSize = True
        StockLabel.Location = New System.Drawing.Point(39, 270)
        StockLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        StockLabel.Name = "StockLabel"
        StockLabel.Size = New System.Drawing.Size(47, 17)
        StockLabel.TabIndex = 1000000008
        StockLabel.Text = "Stock:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(39, 305)
        ObservacionesLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(107, 17)
        ObservacionesLabel.TabIndex = 1000000010
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Reserva1Label
        '
        Reserva1Label.AutoSize = True
        Reserva1Label.Location = New System.Drawing.Point(39, 402)
        Reserva1Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Reserva1Label.Name = "Reserva1Label"
        Reserva1Label.Size = New System.Drawing.Size(73, 17)
        Reserva1Label.TabIndex = 1000000012
        Reserva1Label.Text = "Reserva1:"
        Reserva1Label.Visible = False
        '
        'Reserva2Label
        '
        Reserva2Label.AutoSize = True
        Reserva2Label.Location = New System.Drawing.Point(39, 434)
        Reserva2Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Reserva2Label.Name = "Reserva2Label"
        Reserva2Label.Size = New System.Drawing.Size(73, 17)
        Reserva2Label.TabIndex = 1000000014
        Reserva2Label.Text = "Reserva2:"
        Reserva2Label.Visible = False
        '
        'Reserva3Label
        '
        Reserva3Label.AutoSize = True
        Reserva3Label.Location = New System.Drawing.Point(39, 466)
        Reserva3Label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Reserva3Label.Name = "Reserva3Label"
        Reserva3Label.Size = New System.Drawing.Size(73, 17)
        Reserva3Label.TabIndex = 1000000016
        Reserva3Label.Text = "Reserva3:"
        Reserva3Label.Visible = False
        '
        'DtsCargaNecesidadesJRDetalles
        '
        Me.DtsCargaNecesidadesJRDetalles.DataSetName = "dtsCargaNecesidadesJRDetalles"
        Me.DtsCargaNecesidadesJRDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CargaNecesidadesJRDetalleIDCuadroDeTexto
        '
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CargaNecesidadesJRDetalleID", True))
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.EsUnicoCampo = ""
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.EsUnicoID = 0
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.EsUnicoTabla = ""
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Location = New System.Drawing.Point(151, 52)
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Minimo = 0
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Modificado = False
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Name = "CargaNecesidadesJRDetalleIDCuadroDeTexto"
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Obligatorio = False
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.ParametroID = 0
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Size = New System.Drawing.Size(52, 22)
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.TabIndex = 1000000001
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.TabStop = False
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.ValorMinimo = 0.0!
        Me.CargaNecesidadesJRDetalleIDCuadroDeTexto.Visible = False
        '
        'CargaNecesidadesJRMaestroIDCuadroDeTexto
        '
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CargaNecesidadesJRMaestroID", True))
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoCampo = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoID = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.EsUnicoTabla = ""
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Location = New System.Drawing.Point(151, 84)
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Minimo = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Modificado = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Name = "CargaNecesidadesJRMaestroIDCuadroDeTexto"
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Obligatorio = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ParametroID = 0
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Size = New System.Drawing.Size(52, 22)
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.TabIndex = 1000000003
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.TabStop = False
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.ValorMinimo = 0.0!
        Me.CargaNecesidadesJRMaestroIDCuadroDeTexto.Visible = False
        '
        'ArticuloIDCuadroDeTexto
        '
        Me.ArticuloIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "ArticuloID", True))
        Me.ArticuloIDCuadroDeTexto.EsUnicoCampo = ""
        Me.ArticuloIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.ArticuloIDCuadroDeTexto.EsUnicoID = 0
        Me.ArticuloIDCuadroDeTexto.EsUnicoTabla = ""
        Me.ArticuloIDCuadroDeTexto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArticuloIDCuadroDeTexto.Location = New System.Drawing.Point(151, 139)
        Me.ArticuloIDCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ArticuloIDCuadroDeTexto.Minimo = 0
        Me.ArticuloIDCuadroDeTexto.Modificado = False
        Me.ArticuloIDCuadroDeTexto.Name = "ArticuloIDCuadroDeTexto"
        Me.ArticuloIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.ArticuloIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ArticuloIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ArticuloIDCuadroDeTexto.Obligatorio = False
        Me.ArticuloIDCuadroDeTexto.ParametroID = 0
        Me.ArticuloIDCuadroDeTexto.Size = New System.Drawing.Size(676, 36)
        Me.ArticuloIDCuadroDeTexto.TabIndex = 1000000005
        Me.ArticuloIDCuadroDeTexto.TabStop = False
        Me.ArticuloIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.ArticuloIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'CargaCuadroDeTexto
        '
        Me.CargaCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Carga", True))
        Me.CargaCuadroDeTexto.EsUnicoCampo = ""
        Me.CargaCuadroDeTexto.EsUnicoCampoID = ""
        Me.CargaCuadroDeTexto.EsUnicoID = 0
        Me.CargaCuadroDeTexto.EsUnicoTabla = ""
        Me.CargaCuadroDeTexto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CargaCuadroDeTexto.Location = New System.Drawing.Point(151, 212)
        Me.CargaCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CargaCuadroDeTexto.Minimo = 0
        Me.CargaCuadroDeTexto.Modificado = False
        Me.CargaCuadroDeTexto.Name = "CargaCuadroDeTexto"
        Me.CargaCuadroDeTexto.Numerico_EsNumerico = True
        Me.CargaCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CargaCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CargaCuadroDeTexto.Obligatorio = False
        Me.CargaCuadroDeTexto.ParametroID = 0
        Me.CargaCuadroDeTexto.Size = New System.Drawing.Size(71, 36)
        Me.CargaCuadroDeTexto.TabIndex = 1
        Me.CargaCuadroDeTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CargaCuadroDeTexto.ValorMaximo = 0.0!
        Me.CargaCuadroDeTexto.ValorMinimo = 0.0!
        '
        'StockCuadroDeTexto
        '
        Me.StockCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Stock", True))
        Me.StockCuadroDeTexto.EsUnicoCampo = ""
        Me.StockCuadroDeTexto.EsUnicoCampoID = ""
        Me.StockCuadroDeTexto.EsUnicoID = 0
        Me.StockCuadroDeTexto.EsUnicoTabla = ""
        Me.StockCuadroDeTexto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StockCuadroDeTexto.Location = New System.Drawing.Point(151, 256)
        Me.StockCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.StockCuadroDeTexto.Minimo = 0
        Me.StockCuadroDeTexto.Modificado = False
        Me.StockCuadroDeTexto.Name = "StockCuadroDeTexto"
        Me.StockCuadroDeTexto.Numerico_EsNumerico = True
        Me.StockCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.StockCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.StockCuadroDeTexto.Obligatorio = True
        Me.StockCuadroDeTexto.ParametroID = 0
        Me.StockCuadroDeTexto.Size = New System.Drawing.Size(71, 36)
        Me.StockCuadroDeTexto.TabIndex = 2
        Me.StockCuadroDeTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.StockCuadroDeTexto.ValorMaximo = 0.0!
        Me.StockCuadroDeTexto.ValorMinimo = 0.0!
        '
        'ObservacionesCuadroDeTexto
        '
        Me.ObservacionesCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.ObservacionesCuadroDeTexto.EsUnicoCampo = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoCampoID = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoID = 0
        Me.ObservacionesCuadroDeTexto.EsUnicoTabla = ""
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(151, 308)
        Me.ObservacionesCuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(477, 22)
        Me.ObservacionesCuadroDeTexto.TabIndex = 3
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0.0!
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva1CuadroDeTexto
        '
        Me.Reserva1CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva1", True))
        Me.Reserva1CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva1CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva1CuadroDeTexto.EsUnicoID = 0
        Me.Reserva1CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva1CuadroDeTexto.Location = New System.Drawing.Point(151, 402)
        Me.Reserva1CuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reserva1CuadroDeTexto.Minimo = 0
        Me.Reserva1CuadroDeTexto.Modificado = False
        Me.Reserva1CuadroDeTexto.Name = "Reserva1CuadroDeTexto"
        Me.Reserva1CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva1CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva1CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva1CuadroDeTexto.Obligatorio = False
        Me.Reserva1CuadroDeTexto.ParametroID = 0
        Me.Reserva1CuadroDeTexto.Size = New System.Drawing.Size(132, 22)
        Me.Reserva1CuadroDeTexto.TabIndex = 1000000013
        Me.Reserva1CuadroDeTexto.TabStop = False
        Me.Reserva1CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva1CuadroDeTexto.ValorMinimo = 0.0!
        Me.Reserva1CuadroDeTexto.Visible = False
        '
        'Reserva2CuadroDeTexto
        '
        Me.Reserva2CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva2", True))
        Me.Reserva2CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva2CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva2CuadroDeTexto.EsUnicoID = 0
        Me.Reserva2CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva2CuadroDeTexto.Location = New System.Drawing.Point(151, 434)
        Me.Reserva2CuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reserva2CuadroDeTexto.Minimo = 0
        Me.Reserva2CuadroDeTexto.Modificado = False
        Me.Reserva2CuadroDeTexto.Name = "Reserva2CuadroDeTexto"
        Me.Reserva2CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva2CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva2CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva2CuadroDeTexto.Obligatorio = False
        Me.Reserva2CuadroDeTexto.ParametroID = 0
        Me.Reserva2CuadroDeTexto.Size = New System.Drawing.Size(132, 22)
        Me.Reserva2CuadroDeTexto.TabIndex = 1000000015
        Me.Reserva2CuadroDeTexto.TabStop = False
        Me.Reserva2CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva2CuadroDeTexto.ValorMinimo = 0.0!
        Me.Reserva2CuadroDeTexto.Visible = False
        '
        'Reserva3CuadroDeTexto
        '
        Me.Reserva3CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva3", True))
        Me.Reserva3CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva3CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva3CuadroDeTexto.EsUnicoID = 0
        Me.Reserva3CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva3CuadroDeTexto.Location = New System.Drawing.Point(151, 466)
        Me.Reserva3CuadroDeTexto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Reserva3CuadroDeTexto.Minimo = 0
        Me.Reserva3CuadroDeTexto.Modificado = False
        Me.Reserva3CuadroDeTexto.Name = "Reserva3CuadroDeTexto"
        Me.Reserva3CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva3CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva3CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva3CuadroDeTexto.Obligatorio = False
        Me.Reserva3CuadroDeTexto.ParametroID = 0
        Me.Reserva3CuadroDeTexto.Size = New System.Drawing.Size(132, 22)
        Me.Reserva3CuadroDeTexto.TabIndex = 1000000017
        Me.Reserva3CuadroDeTexto.TabStop = False
        Me.Reserva3CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva3CuadroDeTexto.ValorMinimo = 0.0!
        Me.Reserva3CuadroDeTexto.Visible = False
        '
        'cboArticulos
        '
        Me.cboArticulos.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticulos.FormattingEnabled = True
        Me.cboArticulos.Location = New System.Drawing.Point(151, 143)
        Me.cboArticulos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboArticulos.Name = "cboArticulos"
        Me.cboArticulos.Size = New System.Drawing.Size(663, 27)
        Me.cboArticulos.TabIndex = 0
        '
        'lblAñadirArticulo
        '
        Me.lblAñadirArticulo.AutoSize = True
        Me.lblAñadirArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAñadirArticulo.ForeColor = System.Drawing.Color.Red
        Me.lblAñadirArticulo.Location = New System.Drawing.Point(369, 64)
        Me.lblAñadirArticulo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAñadirArticulo.Name = "lblAñadirArticulo"
        Me.lblAñadirArticulo.Size = New System.Drawing.Size(154, 25)
        Me.lblAñadirArticulo.TabIndex = 1000000019
        Me.lblAñadirArticulo.Text = "Añadir Articulo"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(292, 351)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(212, 22)
        Me.TextBox1.TabIndex = 4
        Me.TextBox1.Text = "Pulsa enter para nuevo registro"
        '
        'frmEntCargaNecesidadesJRDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(919, 533)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblAñadirArticulo)
        Me.Controls.Add(Me.cboArticulos)
        Me.Controls.Add(CargaNecesidadesJRDetalleIDLabel)
        Me.Controls.Add(Me.CargaNecesidadesJRDetalleIDCuadroDeTexto)
        Me.Controls.Add(CargaNecesidadesJRMaestroIDLabel)
        Me.Controls.Add(Me.CargaNecesidadesJRMaestroIDCuadroDeTexto)
        Me.Controls.Add(ArticuloIDLabel)
        Me.Controls.Add(Me.ArticuloIDCuadroDeTexto)
        Me.Controls.Add(CargaLabel)
        Me.Controls.Add(Me.CargaCuadroDeTexto)
        Me.Controls.Add(StockLabel)
        Me.Controls.Add(Me.StockCuadroDeTexto)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.Controls.Add(Reserva1Label)
        Me.Controls.Add(Me.Reserva1CuadroDeTexto)
        Me.Controls.Add(Reserva2Label)
        Me.Controls.Add(Me.Reserva2CuadroDeTexto)
        Me.Controls.Add(Reserva3Label)
        Me.Controls.Add(Me.Reserva3CuadroDeTexto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.Name = "frmEntCargaNecesidadesJRDetalles"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Reserva3CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva3Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva2CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva2Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva1CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva1Label, 0)
        Me.Controls.SetChildIndex(Me.ObservacionesCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ObservacionesLabel, 0)
        Me.Controls.SetChildIndex(Me.StockCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(StockLabel, 0)
        Me.Controls.SetChildIndex(Me.CargaCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CargaLabel, 0)
        Me.Controls.SetChildIndex(Me.ArticuloIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ArticuloIDLabel, 0)
        Me.Controls.SetChildIndex(Me.CargaNecesidadesJRMaestroIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CargaNecesidadesJRMaestroIDLabel, 0)
        Me.Controls.SetChildIndex(Me.CargaNecesidadesJRDetalleIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CargaNecesidadesJRDetalleIDLabel, 0)
        Me.Controls.SetChildIndex(Me.cboArticulos, 0)
        Me.Controls.SetChildIndex(Me.lblAñadirArticulo, 0)
        Me.Controls.SetChildIndex(Me.TextBox1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsCargaNecesidadesJRDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsCargaNecesidadesJRDetalles As La_Andaluza.dtsCargaNecesidadesJRDetalles
    Private WithEvents CargaNecesidadesJRDetalleIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CargaNecesidadesJRMaestroIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblAñadirArticulo As System.Windows.Forms.Label
    Private WithEvents ArticuloIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CargaCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents StockCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva1CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva2CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva3CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticulos As System.Windows.Forms.ComboBox
    Private WithEvents TextBox1 As System.Windows.Forms.TextBox

End Class
