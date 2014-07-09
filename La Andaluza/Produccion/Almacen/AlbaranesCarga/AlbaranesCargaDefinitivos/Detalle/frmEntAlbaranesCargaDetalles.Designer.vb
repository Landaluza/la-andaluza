<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntAlbaranesCargaDetalles
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
        Dim AlbaranCargaDetalleIDLabel As System.Windows.Forms.Label
        Dim AlbaranCargaMaestroIDLabel As System.Windows.Forms.Label
        Dim SccLabel As System.Windows.Forms.Label
        Dim CodigoQSLabel As System.Windows.Forms.Label
        Dim AticuloDescripcionLabel As System.Windows.Forms.Label
        Dim CajasLabel As System.Windows.Forms.Label
        Dim UnidadMedidaLabel As System.Windows.Forms.Label
        Dim LoteLabel As System.Windows.Forms.Label
        Dim TipoPaletLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Reserva1Label As System.Windows.Forms.Label
        Dim Reserva2Label As System.Windows.Forms.Label
        Dim Reserva3Label As System.Windows.Forms.Label
        Me.DtsAlbaranesCargaDetalles = New La_Andaluza.dtsAlbaranesCargaDetalles
        Me.AlbaranCargaDetalleIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.AlbaranCargaMaestroIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.SccCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.CodigoQSCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.AticuloDescripcionCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.CajasCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.UnidadMedidaCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.LoteCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.TipoPaletCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva1CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva2CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva3CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        AlbaranCargaDetalleIDLabel = New System.Windows.Forms.Label
        AlbaranCargaMaestroIDLabel = New System.Windows.Forms.Label
        SccLabel = New System.Windows.Forms.Label
        CodigoQSLabel = New System.Windows.Forms.Label
        AticuloDescripcionLabel = New System.Windows.Forms.Label
        CajasLabel = New System.Windows.Forms.Label
        UnidadMedidaLabel = New System.Windows.Forms.Label
        LoteLabel = New System.Windows.Forms.Label
        TipoPaletLabel = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        Reserva1Label = New System.Windows.Forms.Label
        Reserva2Label = New System.Windows.Forms.Label
        Reserva3Label = New System.Windows.Forms.Label
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsAlbaranesCargaDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "AlbaranesCargaDetalles"
        Me.GeneralBindingSource.DataSource = Me.DtsAlbaranesCargaDetalles
        '
        'DtsAlbaranesCargaDetalles
        '
        Me.DtsAlbaranesCargaDetalles.DataSetName = "dtsAlbaranesCargaDetalles"
        Me.DtsAlbaranesCargaDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlbaranCargaDetalleIDLabel
        '
        AlbaranCargaDetalleIDLabel.AutoSize = True
        AlbaranCargaDetalleIDLabel.Location = New System.Drawing.Point(80, 65)
        AlbaranCargaDetalleIDLabel.Name = "AlbaranCargaDetalleIDLabel"
        AlbaranCargaDetalleIDLabel.Size = New System.Drawing.Size(127, 13)
        AlbaranCargaDetalleIDLabel.TabIndex = 1000000000
        AlbaranCargaDetalleIDLabel.Text = "Albaran Carga Detalle ID:"
        '
        'AlbaranCargaDetalleIDCuadroDeTexto
        '
        Me.AlbaranCargaDetalleIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaDetalleID", True))
        Me.AlbaranCargaDetalleIDCuadroDeTexto.EsUnicoCampo = ""
        Me.AlbaranCargaDetalleIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.AlbaranCargaDetalleIDCuadroDeTexto.EsUnicoID = 0
        Me.AlbaranCargaDetalleIDCuadroDeTexto.EsUnicoTabla = ""
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Location = New System.Drawing.Point(218, 62)
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Minimo = 0
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Modificado = False
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Name = "AlbaranCargaDetalleIDCuadroDeTexto"
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Obligatorio = False
        Me.AlbaranCargaDetalleIDCuadroDeTexto.ParametroID = 0
        Me.AlbaranCargaDetalleIDCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.AlbaranCargaDetalleIDCuadroDeTexto.TabIndex = 1000000001
        Me.AlbaranCargaDetalleIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.AlbaranCargaDetalleIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'AlbaranCargaMaestroIDLabel
        '
        AlbaranCargaMaestroIDLabel.AutoSize = True
        AlbaranCargaMaestroIDLabel.Location = New System.Drawing.Point(80, 91)
        AlbaranCargaMaestroIDLabel.Name = "AlbaranCargaMaestroIDLabel"
        AlbaranCargaMaestroIDLabel.Size = New System.Drawing.Size(132, 13)
        AlbaranCargaMaestroIDLabel.TabIndex = 1000000002
        AlbaranCargaMaestroIDLabel.Text = "Albaran Carga Maestro ID:"
        '
        'AlbaranCargaMaestroIDCuadroDeTexto
        '
        Me.AlbaranCargaMaestroIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaMaestroID", True))
        Me.AlbaranCargaMaestroIDCuadroDeTexto.EsUnicoCampo = ""
        Me.AlbaranCargaMaestroIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.AlbaranCargaMaestroIDCuadroDeTexto.EsUnicoID = 0
        Me.AlbaranCargaMaestroIDCuadroDeTexto.EsUnicoTabla = ""
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Location = New System.Drawing.Point(218, 88)
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Minimo = 0
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Modificado = False
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Name = "AlbaranCargaMaestroIDCuadroDeTexto"
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Obligatorio = False
        Me.AlbaranCargaMaestroIDCuadroDeTexto.ParametroID = 0
        Me.AlbaranCargaMaestroIDCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.AlbaranCargaMaestroIDCuadroDeTexto.TabIndex = 1000000003
        Me.AlbaranCargaMaestroIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.AlbaranCargaMaestroIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'SccLabel
        '
        SccLabel.AutoSize = True
        SccLabel.Location = New System.Drawing.Point(80, 117)
        SccLabel.Name = "SccLabel"
        SccLabel.Size = New System.Drawing.Size(29, 13)
        SccLabel.TabIndex = 1000000004
        SccLabel.Text = "Scc:"
        '
        'SccCuadroDeTexto
        '
        Me.SccCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Scc", True))
        Me.SccCuadroDeTexto.EsUnicoCampo = ""
        Me.SccCuadroDeTexto.EsUnicoCampoID = ""
        Me.SccCuadroDeTexto.EsUnicoID = 0
        Me.SccCuadroDeTexto.EsUnicoTabla = ""
        Me.SccCuadroDeTexto.Location = New System.Drawing.Point(218, 114)
        Me.SccCuadroDeTexto.Minimo = 0
        Me.SccCuadroDeTexto.Modificado = False
        Me.SccCuadroDeTexto.Name = "SccCuadroDeTexto"
        Me.SccCuadroDeTexto.Numerico_EsNumerico = False
        Me.SccCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.SccCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.SccCuadroDeTexto.Obligatorio = False
        Me.SccCuadroDeTexto.ParametroID = 0
        Me.SccCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.SccCuadroDeTexto.TabIndex = 1000000005
        Me.SccCuadroDeTexto.ValorMaximo = 0.0!
        Me.SccCuadroDeTexto.ValorMinimo = 0.0!
        '
        'CodigoQSLabel
        '
        CodigoQSLabel.AutoSize = True
        CodigoQSLabel.Location = New System.Drawing.Point(80, 143)
        CodigoQSLabel.Name = "CodigoQSLabel"
        CodigoQSLabel.Size = New System.Drawing.Size(61, 13)
        CodigoQSLabel.TabIndex = 1000000006
        CodigoQSLabel.Text = "Codigo QS:"
        '
        'CodigoQSCuadroDeTexto
        '
        Me.CodigoQSCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "CodigoQS", True))
        Me.CodigoQSCuadroDeTexto.EsUnicoCampo = ""
        Me.CodigoQSCuadroDeTexto.EsUnicoCampoID = ""
        Me.CodigoQSCuadroDeTexto.EsUnicoID = 0
        Me.CodigoQSCuadroDeTexto.EsUnicoTabla = ""
        Me.CodigoQSCuadroDeTexto.Location = New System.Drawing.Point(218, 140)
        Me.CodigoQSCuadroDeTexto.Minimo = 0
        Me.CodigoQSCuadroDeTexto.Modificado = False
        Me.CodigoQSCuadroDeTexto.Name = "CodigoQSCuadroDeTexto"
        Me.CodigoQSCuadroDeTexto.Numerico_EsNumerico = False
        Me.CodigoQSCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CodigoQSCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CodigoQSCuadroDeTexto.Obligatorio = False
        Me.CodigoQSCuadroDeTexto.ParametroID = 0
        Me.CodigoQSCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.CodigoQSCuadroDeTexto.TabIndex = 1000000007
        Me.CodigoQSCuadroDeTexto.ValorMaximo = 0.0!
        Me.CodigoQSCuadroDeTexto.ValorMinimo = 0.0!
        '
        'AticuloDescripcionLabel
        '
        AticuloDescripcionLabel.AutoSize = True
        AticuloDescripcionLabel.Location = New System.Drawing.Point(80, 169)
        AticuloDescripcionLabel.Name = "AticuloDescripcionLabel"
        AticuloDescripcionLabel.Size = New System.Drawing.Size(101, 13)
        AticuloDescripcionLabel.TabIndex = 1000000008
        AticuloDescripcionLabel.Text = "Aticulo Descripcion:"
        '
        'AticuloDescripcionCuadroDeTexto
        '
        Me.AticuloDescripcionCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AticuloDescripcion", True))
        Me.AticuloDescripcionCuadroDeTexto.EsUnicoCampo = ""
        Me.AticuloDescripcionCuadroDeTexto.EsUnicoCampoID = ""
        Me.AticuloDescripcionCuadroDeTexto.EsUnicoID = 0
        Me.AticuloDescripcionCuadroDeTexto.EsUnicoTabla = ""
        Me.AticuloDescripcionCuadroDeTexto.Location = New System.Drawing.Point(218, 166)
        Me.AticuloDescripcionCuadroDeTexto.Minimo = 0
        Me.AticuloDescripcionCuadroDeTexto.Modificado = False
        Me.AticuloDescripcionCuadroDeTexto.Name = "AticuloDescripcionCuadroDeTexto"
        Me.AticuloDescripcionCuadroDeTexto.Numerico_EsNumerico = False
        Me.AticuloDescripcionCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AticuloDescripcionCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AticuloDescripcionCuadroDeTexto.Obligatorio = False
        Me.AticuloDescripcionCuadroDeTexto.ParametroID = 0
        Me.AticuloDescripcionCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.AticuloDescripcionCuadroDeTexto.TabIndex = 1000000009
        Me.AticuloDescripcionCuadroDeTexto.ValorMaximo = 0.0!
        Me.AticuloDescripcionCuadroDeTexto.ValorMinimo = 0.0!
        '
        'CajasLabel
        '
        CajasLabel.AutoSize = True
        CajasLabel.Location = New System.Drawing.Point(80, 195)
        CajasLabel.Name = "CajasLabel"
        CajasLabel.Size = New System.Drawing.Size(36, 13)
        CajasLabel.TabIndex = 1000000010
        CajasLabel.Text = "Cajas:"
        '
        'CajasCuadroDeTexto
        '
        Me.CajasCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Cajas", True))
        Me.CajasCuadroDeTexto.EsUnicoCampo = ""
        Me.CajasCuadroDeTexto.EsUnicoCampoID = ""
        Me.CajasCuadroDeTexto.EsUnicoID = 0
        Me.CajasCuadroDeTexto.EsUnicoTabla = ""
        Me.CajasCuadroDeTexto.Location = New System.Drawing.Point(218, 192)
        Me.CajasCuadroDeTexto.Minimo = 0
        Me.CajasCuadroDeTexto.Modificado = False
        Me.CajasCuadroDeTexto.Name = "CajasCuadroDeTexto"
        Me.CajasCuadroDeTexto.Numerico_EsNumerico = False
        Me.CajasCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CajasCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.CajasCuadroDeTexto.Obligatorio = False
        Me.CajasCuadroDeTexto.ParametroID = 0
        Me.CajasCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.CajasCuadroDeTexto.TabIndex = 1000000011
        Me.CajasCuadroDeTexto.ValorMaximo = 0.0!
        Me.CajasCuadroDeTexto.ValorMinimo = 0.0!
        '
        'UnidadMedidaLabel
        '
        UnidadMedidaLabel.AutoSize = True
        UnidadMedidaLabel.Location = New System.Drawing.Point(80, 221)
        UnidadMedidaLabel.Name = "UnidadMedidaLabel"
        UnidadMedidaLabel.Size = New System.Drawing.Size(82, 13)
        UnidadMedidaLabel.TabIndex = 1000000012
        UnidadMedidaLabel.Text = "Unidad Medida:"
        '
        'UnidadMedidaCuadroDeTexto
        '
        Me.UnidadMedidaCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "UnidadMedida", True))
        Me.UnidadMedidaCuadroDeTexto.EsUnicoCampo = ""
        Me.UnidadMedidaCuadroDeTexto.EsUnicoCampoID = ""
        Me.UnidadMedidaCuadroDeTexto.EsUnicoID = 0
        Me.UnidadMedidaCuadroDeTexto.EsUnicoTabla = ""
        Me.UnidadMedidaCuadroDeTexto.Location = New System.Drawing.Point(218, 218)
        Me.UnidadMedidaCuadroDeTexto.Minimo = 0
        Me.UnidadMedidaCuadroDeTexto.Modificado = False
        Me.UnidadMedidaCuadroDeTexto.Name = "UnidadMedidaCuadroDeTexto"
        Me.UnidadMedidaCuadroDeTexto.Numerico_EsNumerico = False
        Me.UnidadMedidaCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.UnidadMedidaCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.UnidadMedidaCuadroDeTexto.Obligatorio = False
        Me.UnidadMedidaCuadroDeTexto.ParametroID = 0
        Me.UnidadMedidaCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.UnidadMedidaCuadroDeTexto.TabIndex = 1000000013
        Me.UnidadMedidaCuadroDeTexto.ValorMaximo = 0.0!
        Me.UnidadMedidaCuadroDeTexto.ValorMinimo = 0.0!
        '
        'LoteLabel
        '
        LoteLabel.AutoSize = True
        LoteLabel.Location = New System.Drawing.Point(80, 247)
        LoteLabel.Name = "LoteLabel"
        LoteLabel.Size = New System.Drawing.Size(31, 13)
        LoteLabel.TabIndex = 1000000014
        LoteLabel.Text = "Lote:"
        '
        'LoteCuadroDeTexto
        '
        Me.LoteCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Lote", True))
        Me.LoteCuadroDeTexto.EsUnicoCampo = ""
        Me.LoteCuadroDeTexto.EsUnicoCampoID = ""
        Me.LoteCuadroDeTexto.EsUnicoID = 0
        Me.LoteCuadroDeTexto.EsUnicoTabla = ""
        Me.LoteCuadroDeTexto.Location = New System.Drawing.Point(218, 244)
        Me.LoteCuadroDeTexto.Minimo = 0
        Me.LoteCuadroDeTexto.Modificado = False
        Me.LoteCuadroDeTexto.Name = "LoteCuadroDeTexto"
        Me.LoteCuadroDeTexto.Numerico_EsNumerico = False
        Me.LoteCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.LoteCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.LoteCuadroDeTexto.Obligatorio = False
        Me.LoteCuadroDeTexto.ParametroID = 0
        Me.LoteCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.LoteCuadroDeTexto.TabIndex = 1000000015
        Me.LoteCuadroDeTexto.ValorMaximo = 0.0!
        Me.LoteCuadroDeTexto.ValorMinimo = 0.0!
        '
        'TipoPaletLabel
        '
        TipoPaletLabel.AutoSize = True
        TipoPaletLabel.Location = New System.Drawing.Point(80, 273)
        TipoPaletLabel.Name = "TipoPaletLabel"
        TipoPaletLabel.Size = New System.Drawing.Size(58, 13)
        TipoPaletLabel.TabIndex = 1000000016
        TipoPaletLabel.Text = "Tipo Palet:"
        '
        'TipoPaletCuadroDeTexto
        '
        Me.TipoPaletCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoPalet", True))
        Me.TipoPaletCuadroDeTexto.EsUnicoCampo = ""
        Me.TipoPaletCuadroDeTexto.EsUnicoCampoID = ""
        Me.TipoPaletCuadroDeTexto.EsUnicoID = 0
        Me.TipoPaletCuadroDeTexto.EsUnicoTabla = ""
        Me.TipoPaletCuadroDeTexto.Location = New System.Drawing.Point(218, 270)
        Me.TipoPaletCuadroDeTexto.Minimo = 0
        Me.TipoPaletCuadroDeTexto.Modificado = False
        Me.TipoPaletCuadroDeTexto.Name = "TipoPaletCuadroDeTexto"
        Me.TipoPaletCuadroDeTexto.Numerico_EsNumerico = False
        Me.TipoPaletCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.TipoPaletCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.TipoPaletCuadroDeTexto.Obligatorio = False
        Me.TipoPaletCuadroDeTexto.ParametroID = 0
        Me.TipoPaletCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.TipoPaletCuadroDeTexto.TabIndex = 1000000017
        Me.TipoPaletCuadroDeTexto.ValorMaximo = 0.0!
        Me.TipoPaletCuadroDeTexto.ValorMinimo = 0.0!
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(80, 299)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 1000000018
        ObservacionesLabel.Text = "Observaciones:"
        '
        'ObservacionesCuadroDeTexto
        '
        Me.ObservacionesCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.ObservacionesCuadroDeTexto.EsUnicoCampo = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoCampoID = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoID = 0
        Me.ObservacionesCuadroDeTexto.EsUnicoTabla = ""
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(218, 296)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.ObservacionesCuadroDeTexto.TabIndex = 1000000019
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0.0!
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva1Label
        '
        Reserva1Label.AutoSize = True
        Reserva1Label.Location = New System.Drawing.Point(80, 325)
        Reserva1Label.Name = "Reserva1Label"
        Reserva1Label.Size = New System.Drawing.Size(56, 13)
        Reserva1Label.TabIndex = 1000000020
        Reserva1Label.Text = "Reserva1:"
        '
        'Reserva1CuadroDeTexto
        '
        Me.Reserva1CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva1", True))
        Me.Reserva1CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva1CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva1CuadroDeTexto.EsUnicoID = 0
        Me.Reserva1CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva1CuadroDeTexto.Location = New System.Drawing.Point(218, 322)
        Me.Reserva1CuadroDeTexto.Minimo = 0
        Me.Reserva1CuadroDeTexto.Modificado = False
        Me.Reserva1CuadroDeTexto.Name = "Reserva1CuadroDeTexto"
        Me.Reserva1CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva1CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva1CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva1CuadroDeTexto.Obligatorio = False
        Me.Reserva1CuadroDeTexto.ParametroID = 0
        Me.Reserva1CuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.Reserva1CuadroDeTexto.TabIndex = 1000000021
        Me.Reserva1CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva1CuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva2Label
        '
        Reserva2Label.AutoSize = True
        Reserva2Label.Location = New System.Drawing.Point(80, 351)
        Reserva2Label.Name = "Reserva2Label"
        Reserva2Label.Size = New System.Drawing.Size(56, 13)
        Reserva2Label.TabIndex = 1000000022
        Reserva2Label.Text = "Reserva2:"
        '
        'Reserva2CuadroDeTexto
        '
        Me.Reserva2CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva2", True))
        Me.Reserva2CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva2CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva2CuadroDeTexto.EsUnicoID = 0
        Me.Reserva2CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva2CuadroDeTexto.Location = New System.Drawing.Point(218, 348)
        Me.Reserva2CuadroDeTexto.Minimo = 0
        Me.Reserva2CuadroDeTexto.Modificado = False
        Me.Reserva2CuadroDeTexto.Name = "Reserva2CuadroDeTexto"
        Me.Reserva2CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva2CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva2CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva2CuadroDeTexto.Obligatorio = False
        Me.Reserva2CuadroDeTexto.ParametroID = 0
        Me.Reserva2CuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.Reserva2CuadroDeTexto.TabIndex = 1000000023
        Me.Reserva2CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva2CuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva3Label
        '
        Reserva3Label.AutoSize = True
        Reserva3Label.Location = New System.Drawing.Point(80, 377)
        Reserva3Label.Name = "Reserva3Label"
        Reserva3Label.Size = New System.Drawing.Size(56, 13)
        Reserva3Label.TabIndex = 1000000024
        Reserva3Label.Text = "Reserva3:"
        '
        'Reserva3CuadroDeTexto
        '
        Me.Reserva3CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva3", True))
        Me.Reserva3CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva3CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva3CuadroDeTexto.EsUnicoID = 0
        Me.Reserva3CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva3CuadroDeTexto.Location = New System.Drawing.Point(218, 374)
        Me.Reserva3CuadroDeTexto.Minimo = 0
        Me.Reserva3CuadroDeTexto.Modificado = False
        Me.Reserva3CuadroDeTexto.Name = "Reserva3CuadroDeTexto"
        Me.Reserva3CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva3CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva3CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva3CuadroDeTexto.Obligatorio = False
        Me.Reserva3CuadroDeTexto.ParametroID = 0
        Me.Reserva3CuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.Reserva3CuadroDeTexto.TabIndex = 1000000025
        Me.Reserva3CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva3CuadroDeTexto.ValorMinimo = 0.0!
        '
        'frmEntAlbaranesCargaDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(633, 467)
        Me.Controls.Add(AlbaranCargaDetalleIDLabel)
        Me.Controls.Add(Me.AlbaranCargaDetalleIDCuadroDeTexto)
        Me.Controls.Add(AlbaranCargaMaestroIDLabel)
        Me.Controls.Add(Me.AlbaranCargaMaestroIDCuadroDeTexto)
        Me.Controls.Add(SccLabel)
        Me.Controls.Add(Me.SccCuadroDeTexto)
        Me.Controls.Add(CodigoQSLabel)
        Me.Controls.Add(Me.CodigoQSCuadroDeTexto)
        Me.Controls.Add(AticuloDescripcionLabel)
        Me.Controls.Add(Me.AticuloDescripcionCuadroDeTexto)
        Me.Controls.Add(CajasLabel)
        Me.Controls.Add(Me.CajasCuadroDeTexto)
        Me.Controls.Add(UnidadMedidaLabel)
        Me.Controls.Add(Me.UnidadMedidaCuadroDeTexto)
        Me.Controls.Add(LoteLabel)
        Me.Controls.Add(Me.LoteCuadroDeTexto)
        Me.Controls.Add(TipoPaletLabel)
        Me.Controls.Add(Me.TipoPaletCuadroDeTexto)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.Controls.Add(Reserva1Label)
        Me.Controls.Add(Me.Reserva1CuadroDeTexto)
        Me.Controls.Add(Reserva2Label)
        Me.Controls.Add(Me.Reserva2CuadroDeTexto)
        Me.Controls.Add(Reserva3Label)
        Me.Controls.Add(Me.Reserva3CuadroDeTexto)
        Me.Name = "frmEntAlbaranesCargaDetalles"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Reserva3CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva3Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva2CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva2Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva1CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva1Label, 0)
        Me.Controls.SetChildIndex(Me.ObservacionesCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ObservacionesLabel, 0)
        Me.Controls.SetChildIndex(Me.TipoPaletCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(TipoPaletLabel, 0)
        Me.Controls.SetChildIndex(Me.LoteCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(LoteLabel, 0)
        Me.Controls.SetChildIndex(Me.UnidadMedidaCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(UnidadMedidaLabel, 0)
        Me.Controls.SetChildIndex(Me.CajasCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CajasLabel, 0)
        Me.Controls.SetChildIndex(Me.AticuloDescripcionCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(AticuloDescripcionLabel, 0)
        Me.Controls.SetChildIndex(Me.CodigoQSCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CodigoQSLabel, 0)
        Me.Controls.SetChildIndex(Me.SccCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(SccLabel, 0)
        Me.Controls.SetChildIndex(Me.AlbaranCargaMaestroIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(AlbaranCargaMaestroIDLabel, 0)
        Me.Controls.SetChildIndex(Me.AlbaranCargaDetalleIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(AlbaranCargaDetalleIDLabel, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsAlbaranesCargaDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsAlbaranesCargaDetalles As La_Andaluza.dtsAlbaranesCargaDetalles
    Private WithEvents AlbaranCargaDetalleIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents AlbaranCargaMaestroIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents SccCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CodigoQSCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents AticuloDescripcionCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CajasCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents UnidadMedidaCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents LoteCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents TipoPaletCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva1CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva2CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva3CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto

End Class
