<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntAlbaranesCargaProviDetalles
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
        Dim AlbaranCargaProviDetalleIDLabel As System.Windows.Forms.Label
        Dim AlbaranCargaProviMaestroIDLabel As System.Windows.Forms.Label
        Dim SCCLabel As System.Windows.Forms.Label
        Dim CodigoQSLabel As System.Windows.Forms.Label
        Dim AticuloDescripcionLabel As System.Windows.Forms.Label
        Dim CajasLabel As System.Windows.Forms.Label
        Dim UnidadMedidaIDLabel As System.Windows.Forms.Label
        Dim LoteLabel As System.Windows.Forms.Label
        Dim TipoPaletIDLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Reserva1Label As System.Windows.Forms.Label
        Dim Reserva2Label As System.Windows.Forms.Label
        Dim Reserva3Label As System.Windows.Forms.Label
        Me.DtsAlbaranesCargaProviDetalles = New La_Andaluza.dtsAlbaranesCargaProviDetalles
        Me.AlbaranCargaProviDetalleIDTextBox = New System.Windows.Forms.TextBox
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.SCCCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.CodigoQSCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.AticuloDescripcionCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.CajasCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.UnidadMedidaIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.LoteCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.TipoPaletIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva1CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva2CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        Me.Reserva3CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto
        AlbaranCargaProviDetalleIDLabel = New System.Windows.Forms.Label
        AlbaranCargaProviMaestroIDLabel = New System.Windows.Forms.Label
        SCCLabel = New System.Windows.Forms.Label
        CodigoQSLabel = New System.Windows.Forms.Label
        AticuloDescripcionLabel = New System.Windows.Forms.Label
        CajasLabel = New System.Windows.Forms.Label
        UnidadMedidaIDLabel = New System.Windows.Forms.Label
        LoteLabel = New System.Windows.Forms.Label
        TipoPaletIDLabel = New System.Windows.Forms.Label
        ObservacionesLabel = New System.Windows.Forms.Label
        Reserva1Label = New System.Windows.Forms.Label
        Reserva2Label = New System.Windows.Forms.Label
        Reserva3Label = New System.Windows.Forms.Label
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsAlbaranesCargaProviDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "AlbaranesCargaProviDetalles"
        Me.GeneralBindingSource.DataSource = Me.DtsAlbaranesCargaProviDetalles
        '
        'DtsAlbaranesCargaProviDetalles
        '
        Me.DtsAlbaranesCargaProviDetalles.DataSetName = "dtsAlbaranesCargaProviDetalles"
        Me.DtsAlbaranesCargaProviDetalles.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlbaranCargaProviDetalleIDLabel
        '
        AlbaranCargaProviDetalleIDLabel.AutoSize = True
        AlbaranCargaProviDetalleIDLabel.Location = New System.Drawing.Point(17, 46)
        AlbaranCargaProviDetalleIDLabel.Name = "AlbaranCargaProviDetalleIDLabel"
        AlbaranCargaProviDetalleIDLabel.Size = New System.Drawing.Size(154, 13)
        AlbaranCargaProviDetalleIDLabel.TabIndex = 1000000000
        AlbaranCargaProviDetalleIDLabel.Text = "Albaran Carga Provi Detalle ID:"
        '
        'AlbaranCargaProviDetalleIDTextBox
        '
        Me.AlbaranCargaProviDetalleIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaProviDetalleID", True))
        Me.AlbaranCargaProviDetalleIDTextBox.Location = New System.Drawing.Point(182, 43)
        Me.AlbaranCargaProviDetalleIDTextBox.Name = "AlbaranCargaProviDetalleIDTextBox"
        Me.AlbaranCargaProviDetalleIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AlbaranCargaProviDetalleIDTextBox.TabIndex = 1000000001
        '
        'AlbaranCargaProviMaestroIDLabel
        '
        AlbaranCargaProviMaestroIDLabel.AutoSize = True
        AlbaranCargaProviMaestroIDLabel.Location = New System.Drawing.Point(17, 72)
        AlbaranCargaProviMaestroIDLabel.Name = "AlbaranCargaProviMaestroIDLabel"
        AlbaranCargaProviMaestroIDLabel.Size = New System.Drawing.Size(159, 13)
        AlbaranCargaProviMaestroIDLabel.TabIndex = 1000000002
        AlbaranCargaProviMaestroIDLabel.Text = "Albaran Carga Provi Maestro ID:"
        '
        'AlbaranCargaProviMaestroIDCuadroDeTexto
        '
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaProviMaestroID", True))
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.EsUnicoCampo = ""
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.EsUnicoID = 0
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.EsUnicoTabla = ""
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Location = New System.Drawing.Point(182, 69)
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Minimo = 0
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Modificado = False
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Name = "AlbaranCargaProviMaestroIDCuadroDeTexto"
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Obligatorio = False
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.ParametroID = 0
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.TabIndex = 1000000003
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.AlbaranCargaProviMaestroIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'SCCLabel
        '
        SCCLabel.AutoSize = True
        SCCLabel.Location = New System.Drawing.Point(17, 98)
        SCCLabel.Name = "SCCLabel"
        SCCLabel.Size = New System.Drawing.Size(31, 13)
        SCCLabel.TabIndex = 1000000004
        SCCLabel.Text = "SCC:"
        '
        'SCCCuadroDeTexto
        '
        Me.SCCCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "SCC", True))
        Me.SCCCuadroDeTexto.EsUnicoCampo = ""
        Me.SCCCuadroDeTexto.EsUnicoCampoID = ""
        Me.SCCCuadroDeTexto.EsUnicoID = 0
        Me.SCCCuadroDeTexto.EsUnicoTabla = ""
        Me.SCCCuadroDeTexto.Location = New System.Drawing.Point(182, 95)
        Me.SCCCuadroDeTexto.Minimo = 0
        Me.SCCCuadroDeTexto.Modificado = False
        Me.SCCCuadroDeTexto.Name = "SCCCuadroDeTexto"
        Me.SCCCuadroDeTexto.Numerico_EsNumerico = False
        Me.SCCCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.SCCCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.SCCCuadroDeTexto.Obligatorio = False
        Me.SCCCuadroDeTexto.ParametroID = 0
        Me.SCCCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.SCCCuadroDeTexto.TabIndex = 1000000005
        Me.SCCCuadroDeTexto.ValorMaximo = 0.0!
        Me.SCCCuadroDeTexto.ValorMinimo = 0.0!
        '
        'CodigoQSLabel
        '
        CodigoQSLabel.AutoSize = True
        CodigoQSLabel.Location = New System.Drawing.Point(17, 124)
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
        Me.CodigoQSCuadroDeTexto.Location = New System.Drawing.Point(182, 121)
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
        AticuloDescripcionLabel.Location = New System.Drawing.Point(17, 150)
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
        Me.AticuloDescripcionCuadroDeTexto.Location = New System.Drawing.Point(182, 147)
        Me.AticuloDescripcionCuadroDeTexto.Minimo = 0
        Me.AticuloDescripcionCuadroDeTexto.Modificado = False
        Me.AticuloDescripcionCuadroDeTexto.Name = "AticuloDescripcionCuadroDeTexto"
        Me.AticuloDescripcionCuadroDeTexto.Numerico_EsNumerico = False
        Me.AticuloDescripcionCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.AticuloDescripcionCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.AticuloDescripcionCuadroDeTexto.Obligatorio = False
        Me.AticuloDescripcionCuadroDeTexto.ParametroID = 0
        Me.AticuloDescripcionCuadroDeTexto.Size = New System.Drawing.Size(293, 20)
        Me.AticuloDescripcionCuadroDeTexto.TabIndex = 1000000009
        Me.AticuloDescripcionCuadroDeTexto.ValorMaximo = 0.0!
        Me.AticuloDescripcionCuadroDeTexto.ValorMinimo = 0.0!
        '
        'CajasLabel
        '
        CajasLabel.AutoSize = True
        CajasLabel.Location = New System.Drawing.Point(17, 176)
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
        Me.CajasCuadroDeTexto.Location = New System.Drawing.Point(182, 173)
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
        'UnidadMedidaIDLabel
        '
        UnidadMedidaIDLabel.AutoSize = True
        UnidadMedidaIDLabel.Location = New System.Drawing.Point(17, 202)
        UnidadMedidaIDLabel.Name = "UnidadMedidaIDLabel"
        UnidadMedidaIDLabel.Size = New System.Drawing.Size(96, 13)
        UnidadMedidaIDLabel.TabIndex = 1000000012
        UnidadMedidaIDLabel.Text = "Unidad Medida ID:"
        '
        'UnidadMedidaIDCuadroDeTexto
        '
        Me.UnidadMedidaIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "UnidadMedidaID", True))
        Me.UnidadMedidaIDCuadroDeTexto.EsUnicoCampo = ""
        Me.UnidadMedidaIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.UnidadMedidaIDCuadroDeTexto.EsUnicoID = 0
        Me.UnidadMedidaIDCuadroDeTexto.EsUnicoTabla = ""
        Me.UnidadMedidaIDCuadroDeTexto.Location = New System.Drawing.Point(182, 199)
        Me.UnidadMedidaIDCuadroDeTexto.Minimo = 0
        Me.UnidadMedidaIDCuadroDeTexto.Modificado = False
        Me.UnidadMedidaIDCuadroDeTexto.Name = "UnidadMedidaIDCuadroDeTexto"
        Me.UnidadMedidaIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.UnidadMedidaIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.UnidadMedidaIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.UnidadMedidaIDCuadroDeTexto.Obligatorio = False
        Me.UnidadMedidaIDCuadroDeTexto.ParametroID = 0
        Me.UnidadMedidaIDCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.UnidadMedidaIDCuadroDeTexto.TabIndex = 1000000013
        Me.UnidadMedidaIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.UnidadMedidaIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'LoteLabel
        '
        LoteLabel.AutoSize = True
        LoteLabel.Location = New System.Drawing.Point(17, 228)
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
        Me.LoteCuadroDeTexto.Location = New System.Drawing.Point(182, 225)
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
        'TipoPaletIDLabel
        '
        TipoPaletIDLabel.AutoSize = True
        TipoPaletIDLabel.Location = New System.Drawing.Point(17, 254)
        TipoPaletIDLabel.Name = "TipoPaletIDLabel"
        TipoPaletIDLabel.Size = New System.Drawing.Size(72, 13)
        TipoPaletIDLabel.TabIndex = 1000000016
        TipoPaletIDLabel.Text = "Tipo Palet ID:"
        '
        'TipoPaletIDCuadroDeTexto
        '
        Me.TipoPaletIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "TipoPaletID", True))
        Me.TipoPaletIDCuadroDeTexto.EsUnicoCampo = ""
        Me.TipoPaletIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.TipoPaletIDCuadroDeTexto.EsUnicoID = 0
        Me.TipoPaletIDCuadroDeTexto.EsUnicoTabla = ""
        Me.TipoPaletIDCuadroDeTexto.Location = New System.Drawing.Point(182, 251)
        Me.TipoPaletIDCuadroDeTexto.Minimo = 0
        Me.TipoPaletIDCuadroDeTexto.Modificado = False
        Me.TipoPaletIDCuadroDeTexto.Name = "TipoPaletIDCuadroDeTexto"
        Me.TipoPaletIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.TipoPaletIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.TipoPaletIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.TipoPaletIDCuadroDeTexto.Obligatorio = False
        Me.TipoPaletIDCuadroDeTexto.ParametroID = 0
        Me.TipoPaletIDCuadroDeTexto.Size = New System.Drawing.Size(100, 20)
        Me.TipoPaletIDCuadroDeTexto.TabIndex = 1000000017
        Me.TipoPaletIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.TipoPaletIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(17, 280)
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
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(182, 277)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(293, 20)
        Me.ObservacionesCuadroDeTexto.TabIndex = 1000000019
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0.0!
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva1Label
        '
        Reserva1Label.AutoSize = True
        Reserva1Label.Location = New System.Drawing.Point(17, 306)
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
        Me.Reserva1CuadroDeTexto.Location = New System.Drawing.Point(182, 303)
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
        Reserva2Label.Location = New System.Drawing.Point(17, 332)
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
        Me.Reserva2CuadroDeTexto.Location = New System.Drawing.Point(182, 329)
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
        Reserva3Label.Location = New System.Drawing.Point(17, 358)
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
        Me.Reserva3CuadroDeTexto.Location = New System.Drawing.Point(182, 355)
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
        'frmEntAlbaranesCargaProviDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(550, 401)
        Me.Controls.Add(AlbaranCargaProviDetalleIDLabel)
        Me.Controls.Add(Me.AlbaranCargaProviDetalleIDTextBox)
        Me.Controls.Add(AlbaranCargaProviMaestroIDLabel)
        Me.Controls.Add(Me.AlbaranCargaProviMaestroIDCuadroDeTexto)
        Me.Controls.Add(SCCLabel)
        Me.Controls.Add(Me.SCCCuadroDeTexto)
        Me.Controls.Add(CodigoQSLabel)
        Me.Controls.Add(Me.CodigoQSCuadroDeTexto)
        Me.Controls.Add(AticuloDescripcionLabel)
        Me.Controls.Add(Me.AticuloDescripcionCuadroDeTexto)
        Me.Controls.Add(CajasLabel)
        Me.Controls.Add(Me.CajasCuadroDeTexto)
        Me.Controls.Add(UnidadMedidaIDLabel)
        Me.Controls.Add(Me.UnidadMedidaIDCuadroDeTexto)
        Me.Controls.Add(LoteLabel)
        Me.Controls.Add(Me.LoteCuadroDeTexto)
        Me.Controls.Add(TipoPaletIDLabel)
        Me.Controls.Add(Me.TipoPaletIDCuadroDeTexto)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.Controls.Add(Reserva1Label)
        Me.Controls.Add(Me.Reserva1CuadroDeTexto)
        Me.Controls.Add(Reserva2Label)
        Me.Controls.Add(Me.Reserva2CuadroDeTexto)
        Me.Controls.Add(Reserva3Label)
        Me.Controls.Add(Me.Reserva3CuadroDeTexto)
        Me.Name = "frmEntAlbaranesCargaProviDetalles"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Reserva3CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva3Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva2CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva2Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva1CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva1Label, 0)
        Me.Controls.SetChildIndex(Me.ObservacionesCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ObservacionesLabel, 0)
        Me.Controls.SetChildIndex(Me.TipoPaletIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(TipoPaletIDLabel, 0)
        Me.Controls.SetChildIndex(Me.LoteCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(LoteLabel, 0)
        Me.Controls.SetChildIndex(Me.UnidadMedidaIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(UnidadMedidaIDLabel, 0)
        Me.Controls.SetChildIndex(Me.CajasCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CajasLabel, 0)
        Me.Controls.SetChildIndex(Me.AticuloDescripcionCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(AticuloDescripcionLabel, 0)
        Me.Controls.SetChildIndex(Me.CodigoQSCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(CodigoQSLabel, 0)
        Me.Controls.SetChildIndex(Me.SCCCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(SCCLabel, 0)
        Me.Controls.SetChildIndex(Me.AlbaranCargaProviMaestroIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(AlbaranCargaProviMaestroIDLabel, 0)
        Me.Controls.SetChildIndex(Me.AlbaranCargaProviDetalleIDTextBox, 0)
        Me.Controls.SetChildIndex(AlbaranCargaProviDetalleIDLabel, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsAlbaranesCargaProviDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsAlbaranesCargaProviDetalles As La_Andaluza.dtsAlbaranesCargaProviDetalles
   Private WithEvents AlbaranCargaProviDetalleIDTextBox As System.Windows.Forms.TextBox
    Private WithEvents AlbaranCargaProviMaestroIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents SCCCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CodigoQSCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents AticuloDescripcionCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents CajasCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents UnidadMedidaIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents LoteCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents TipoPaletIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva1CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva2CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva3CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto

End Class
