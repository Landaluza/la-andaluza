<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosFichasCondiciones3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosFichasCondiciones3))
        Me.txtArticuloFichaCondicionID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloID = New System.Windows.Forms.ComboBox()
        Me.cboProveedorID = New System.Windows.Forms.ComboBox()
        Me.cboFormaPagoID = New System.Windows.Forms.ComboBox()
        Me.cboPlazoPagoID = New System.Windows.Forms.ComboBox()
        Me.cboUnidadID = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEurosUnidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidadMinima = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPrecioAnterior = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtIncremento = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.txtCosteTransporte = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCosteEmbalaje = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCosteDevolucionEmbalaje = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbonoDevolucionEmbalaje = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCosteMolde = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCosteAmortizacionMoldeUnidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloFichaCondicionID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblFormaPagoID = New System.Windows.Forms.Label()
        Me.lblPlazoPagoID = New System.Windows.Forms.Label()
        Me.lblUnidadID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEurosUnidad = New System.Windows.Forms.Label()
        Me.lblCantidadMinima = New System.Windows.Forms.Label()
        Me.lblPrecioAnterior = New System.Windows.Forms.Label()
        Me.lblIncremento = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.lblCosteTransporte = New System.Windows.Forms.Label()
        Me.lblCosteEmbalaje = New System.Windows.Forms.Label()
        Me.lblCosteDevolucionEmbalaje = New System.Windows.Forms.Label()
        Me.lblAbonoDevolucionEmbalaje = New System.Windows.Forms.Label()
        Me.lblCosteMolde = New System.Windows.Forms.Label()
        Me.lblCosteAmortizacionMoldeUnidad = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.butAddUnidad = New System.Windows.Forms.Button()
        Me.butAddPagoPlazo = New System.Windows.Forms.Button()
        Me.butVerUnidad = New System.Windows.Forms.Button()
        Me.butVerPagoPlazo = New System.Windows.Forms.Button()
        Me.butVerPagoForma = New System.Windows.Forms.Button()
        Me.butAddPagoForma = New System.Windows.Forms.Button()
        Me.butVerProveedor = New System.Windows.Forms.Button()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.butAddProveedor = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtArticuloFichaCondicionID
        '
        Me.txtArticuloFichaCondicionID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloFichaCondicionID.EsUnicoCampo = ""
        Me.txtArticuloFichaCondicionID.EsUnicoCampoID = ""
        Me.txtArticuloFichaCondicionID.EsUnicoID = 0
        Me.txtArticuloFichaCondicionID.EsUnicoTabla = ""
        Me.txtArticuloFichaCondicionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloFichaCondicionID.Location = New System.Drawing.Point(244, 698)
        Me.txtArticuloFichaCondicionID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArticuloFichaCondicionID.MaxLength = 9
        Me.txtArticuloFichaCondicionID.Minimo = 0
        Me.txtArticuloFichaCondicionID.Modificado = False
        Me.txtArticuloFichaCondicionID.Name = "txtArticuloFichaCondicionID"
        Me.txtArticuloFichaCondicionID.Numerico_EsNumerico = False
        Me.txtArticuloFichaCondicionID.Numerico_NumeroDoublees = 0
        Me.txtArticuloFichaCondicionID.Numerico_SeparadorMiles = False
        Me.txtArticuloFichaCondicionID.Obligatorio = True
        Me.txtArticuloFichaCondicionID.ParametroID = 0
        Me.txtArticuloFichaCondicionID.Size = New System.Drawing.Size(73, 24)
        Me.txtArticuloFichaCondicionID.TabIndex = 0
        Me.txtArticuloFichaCondicionID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloFichaCondicionID.ValorMaximo = 0.0!
        Me.txtArticuloFichaCondicionID.ValorMinimo = 0.0!
        Me.txtArticuloFichaCondicionID.Visible = False
        '
        'cboArticuloID
        '
        Me.tlpMiddle.SetColumnSpan(Me.cboArticuloID, 4)
        Me.cboArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloID.Location = New System.Drawing.Point(244, 36)
        Me.cboArticuloID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloID.Name = "cboArticuloID"
        Me.cboArticuloID.Size = New System.Drawing.Size(633, 26)
        Me.cboArticuloID.TabIndex = 1
        '
        'cboProveedorID
        '
        Me.tlpMiddle.SetColumnSpan(Me.cboProveedorID, 4)
        Me.cboProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorID.Location = New System.Drawing.Point(244, 70)
        Me.cboProveedorID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProveedorID.Name = "cboProveedorID"
        Me.cboProveedorID.Size = New System.Drawing.Size(633, 26)
        Me.cboProveedorID.TabIndex = 2
        '
        'cboFormaPagoID
        '
        Me.cboFormaPagoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormaPagoID.Location = New System.Drawing.Point(244, 106)
        Me.cboFormaPagoID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFormaPagoID.Name = "cboFormaPagoID"
        Me.cboFormaPagoID.Size = New System.Drawing.Size(323, 26)
        Me.cboFormaPagoID.TabIndex = 3
        '
        'cboPlazoPagoID
        '
        Me.cboPlazoPagoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPlazoPagoID.Location = New System.Drawing.Point(244, 142)
        Me.cboPlazoPagoID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPlazoPagoID.Name = "cboPlazoPagoID"
        Me.cboPlazoPagoID.Size = New System.Drawing.Size(323, 26)
        Me.cboPlazoPagoID.TabIndex = 4
        '
        'cboUnidadID
        '
        Me.cboUnidadID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadID.Location = New System.Drawing.Point(244, 178)
        Me.cboUnidadID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboUnidadID.Name = "cboUnidadID"
        Me.cboUnidadID.Size = New System.Drawing.Size(323, 26)
        Me.cboUnidadID.TabIndex = 5
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtDescripcion, 7)
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(244, 4)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(951, 24)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtEurosUnidad
        '
        Me.txtEurosUnidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtEurosUnidad.EsUnicoCampo = ""
        Me.txtEurosUnidad.EsUnicoCampoID = ""
        Me.txtEurosUnidad.EsUnicoID = 0
        Me.txtEurosUnidad.EsUnicoTabla = ""
        Me.txtEurosUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEurosUnidad.Location = New System.Drawing.Point(244, 214)
        Me.txtEurosUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtEurosUnidad.Minimo = 0
        Me.txtEurosUnidad.Modificado = False
        Me.txtEurosUnidad.Name = "txtEurosUnidad"
        Me.txtEurosUnidad.Numerico_EsNumerico = False
        Me.txtEurosUnidad.Numerico_NumeroDoublees = 5
        Me.txtEurosUnidad.Numerico_SeparadorMiles = False
        Me.txtEurosUnidad.Obligatorio = True
        Me.txtEurosUnidad.ParametroID = 0
        Me.txtEurosUnidad.Size = New System.Drawing.Size(133, 24)
        Me.txtEurosUnidad.TabIndex = 7
        Me.txtEurosUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEurosUnidad.ValorMaximo = 0.0!
        Me.txtEurosUnidad.ValorMinimo = 0.0!
        '
        'txtCantidadMinima
        '
        Me.txtCantidadMinima.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadMinima.EsUnicoCampo = ""
        Me.txtCantidadMinima.EsUnicoCampoID = ""
        Me.txtCantidadMinima.EsUnicoID = 0
        Me.txtCantidadMinima.EsUnicoTabla = ""
        Me.txtCantidadMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadMinima.Location = New System.Drawing.Point(244, 246)
        Me.txtCantidadMinima.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidadMinima.Minimo = 0
        Me.txtCantidadMinima.Modificado = False
        Me.txtCantidadMinima.Name = "txtCantidadMinima"
        Me.txtCantidadMinima.Numerico_EsNumerico = False
        Me.txtCantidadMinima.Numerico_NumeroDoublees = 2
        Me.txtCantidadMinima.Numerico_SeparadorMiles = False
        Me.txtCantidadMinima.Obligatorio = False
        Me.txtCantidadMinima.ParametroID = 0
        Me.txtCantidadMinima.Size = New System.Drawing.Size(133, 24)
        Me.txtCantidadMinima.TabIndex = 8
        Me.txtCantidadMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadMinima.ValorMaximo = 0.0!
        Me.txtCantidadMinima.ValorMinimo = 0.0!
        '
        'txtPrecioAnterior
        '
        Me.txtPrecioAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrecioAnterior.EsUnicoCampo = ""
        Me.txtPrecioAnterior.EsUnicoCampoID = ""
        Me.txtPrecioAnterior.EsUnicoID = 0
        Me.txtPrecioAnterior.EsUnicoTabla = ""
        Me.txtPrecioAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrecioAnterior.Location = New System.Drawing.Point(244, 278)
        Me.txtPrecioAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPrecioAnterior.Minimo = 0
        Me.txtPrecioAnterior.Modificado = False
        Me.txtPrecioAnterior.Name = "txtPrecioAnterior"
        Me.txtPrecioAnterior.Numerico_EsNumerico = False
        Me.txtPrecioAnterior.Numerico_NumeroDoublees = 5
        Me.txtPrecioAnterior.Numerico_SeparadorMiles = False
        Me.txtPrecioAnterior.Obligatorio = False
        Me.txtPrecioAnterior.ParametroID = 0
        Me.txtPrecioAnterior.Size = New System.Drawing.Size(133, 24)
        Me.txtPrecioAnterior.TabIndex = 9
        Me.txtPrecioAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPrecioAnterior.ValorMaximo = 0.0!
        Me.txtPrecioAnterior.ValorMinimo = 0.0!
        '
        'txtIncremento
        '
        Me.txtIncremento.BackColor = System.Drawing.SystemColors.Window
        Me.txtIncremento.EsUnicoCampo = ""
        Me.txtIncremento.EsUnicoCampoID = ""
        Me.txtIncremento.EsUnicoID = 0
        Me.txtIncremento.EsUnicoTabla = ""
        Me.txtIncremento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIncremento.Location = New System.Drawing.Point(244, 310)
        Me.txtIncremento.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIncremento.Minimo = 0
        Me.txtIncremento.Modificado = False
        Me.txtIncremento.Name = "txtIncremento"
        Me.txtIncremento.Numerico_EsNumerico = False
        Me.txtIncremento.Numerico_NumeroDoublees = 2
        Me.txtIncremento.Numerico_SeparadorMiles = False
        Me.txtIncremento.Obligatorio = False
        Me.txtIncremento.ParametroID = 0
        Me.txtIncremento.Size = New System.Drawing.Size(133, 24)
        Me.txtIncremento.TabIndex = 10
        Me.txtIncremento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIncremento.ValorMaximo = 0.0!
        Me.txtIncremento.ValorMinimo = 0.0!
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtRuta, 7)
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(244, 342)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(951, 24)
        Me.txtRuta.TabIndex = 11
        Me.txtRuta.ValorMaximo = 0.0!
        Me.txtRuta.ValorMinimo = 0.0!
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(244, 376)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaInicio.TabIndex = 12
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(244, 408)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaFinal.TabIndex = 13
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(244, 440)
        Me.chbVigente.Margin = New System.Windows.Forms.Padding(4)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(21, 26)
        Me.chbVigente.TabIndex = 14
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'txtCosteTransporte
        '
        Me.txtCosteTransporte.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosteTransporte.EsUnicoCampo = ""
        Me.txtCosteTransporte.EsUnicoCampoID = ""
        Me.txtCosteTransporte.EsUnicoID = 0
        Me.txtCosteTransporte.EsUnicoTabla = ""
        Me.txtCosteTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosteTransporte.Location = New System.Drawing.Point(244, 474)
        Me.txtCosteTransporte.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosteTransporte.Minimo = 0
        Me.txtCosteTransporte.Modificado = False
        Me.txtCosteTransporte.Name = "txtCosteTransporte"
        Me.txtCosteTransporte.Numerico_EsNumerico = False
        Me.txtCosteTransporte.Numerico_NumeroDoublees = 5
        Me.txtCosteTransporte.Numerico_SeparadorMiles = False
        Me.txtCosteTransporte.Obligatorio = False
        Me.txtCosteTransporte.ParametroID = 0
        Me.txtCosteTransporte.Size = New System.Drawing.Size(87, 24)
        Me.txtCosteTransporte.TabIndex = 15
        Me.txtCosteTransporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosteTransporte.ValorMaximo = 0.0!
        Me.txtCosteTransporte.ValorMinimo = 0.0!
        '
        'txtCosteEmbalaje
        '
        Me.txtCosteEmbalaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosteEmbalaje.EsUnicoCampo = ""
        Me.txtCosteEmbalaje.EsUnicoCampoID = ""
        Me.txtCosteEmbalaje.EsUnicoID = 0
        Me.txtCosteEmbalaje.EsUnicoTabla = ""
        Me.txtCosteEmbalaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosteEmbalaje.Location = New System.Drawing.Point(244, 506)
        Me.txtCosteEmbalaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosteEmbalaje.Minimo = 0
        Me.txtCosteEmbalaje.Modificado = False
        Me.txtCosteEmbalaje.Name = "txtCosteEmbalaje"
        Me.txtCosteEmbalaje.Numerico_EsNumerico = False
        Me.txtCosteEmbalaje.Numerico_NumeroDoublees = 5
        Me.txtCosteEmbalaje.Numerico_SeparadorMiles = False
        Me.txtCosteEmbalaje.Obligatorio = False
        Me.txtCosteEmbalaje.ParametroID = 0
        Me.txtCosteEmbalaje.Size = New System.Drawing.Size(87, 24)
        Me.txtCosteEmbalaje.TabIndex = 16
        Me.txtCosteEmbalaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosteEmbalaje.ValorMaximo = 0.0!
        Me.txtCosteEmbalaje.ValorMinimo = 0.0!
        '
        'txtCosteDevolucionEmbalaje
        '
        Me.txtCosteDevolucionEmbalaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosteDevolucionEmbalaje.EsUnicoCampo = ""
        Me.txtCosteDevolucionEmbalaje.EsUnicoCampoID = ""
        Me.txtCosteDevolucionEmbalaje.EsUnicoID = 0
        Me.txtCosteDevolucionEmbalaje.EsUnicoTabla = ""
        Me.txtCosteDevolucionEmbalaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosteDevolucionEmbalaje.Location = New System.Drawing.Point(244, 538)
        Me.txtCosteDevolucionEmbalaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosteDevolucionEmbalaje.Minimo = 0
        Me.txtCosteDevolucionEmbalaje.Modificado = False
        Me.txtCosteDevolucionEmbalaje.Name = "txtCosteDevolucionEmbalaje"
        Me.txtCosteDevolucionEmbalaje.Numerico_EsNumerico = False
        Me.txtCosteDevolucionEmbalaje.Numerico_NumeroDoublees = 5
        Me.txtCosteDevolucionEmbalaje.Numerico_SeparadorMiles = False
        Me.txtCosteDevolucionEmbalaje.Obligatorio = False
        Me.txtCosteDevolucionEmbalaje.ParametroID = 0
        Me.txtCosteDevolucionEmbalaje.Size = New System.Drawing.Size(87, 24)
        Me.txtCosteDevolucionEmbalaje.TabIndex = 17
        Me.txtCosteDevolucionEmbalaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosteDevolucionEmbalaje.ValorMaximo = 0.0!
        Me.txtCosteDevolucionEmbalaje.ValorMinimo = 0.0!
        '
        'txtAbonoDevolucionEmbalaje
        '
        Me.txtAbonoDevolucionEmbalaje.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbonoDevolucionEmbalaje.EsUnicoCampo = ""
        Me.txtAbonoDevolucionEmbalaje.EsUnicoCampoID = ""
        Me.txtAbonoDevolucionEmbalaje.EsUnicoID = 0
        Me.txtAbonoDevolucionEmbalaje.EsUnicoTabla = ""
        Me.txtAbonoDevolucionEmbalaje.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbonoDevolucionEmbalaje.Location = New System.Drawing.Point(244, 570)
        Me.txtAbonoDevolucionEmbalaje.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbonoDevolucionEmbalaje.Minimo = 0
        Me.txtAbonoDevolucionEmbalaje.Modificado = False
        Me.txtAbonoDevolucionEmbalaje.Name = "txtAbonoDevolucionEmbalaje"
        Me.txtAbonoDevolucionEmbalaje.Numerico_EsNumerico = False
        Me.txtAbonoDevolucionEmbalaje.Numerico_NumeroDoublees = 5
        Me.txtAbonoDevolucionEmbalaje.Numerico_SeparadorMiles = False
        Me.txtAbonoDevolucionEmbalaje.Obligatorio = False
        Me.txtAbonoDevolucionEmbalaje.ParametroID = 0
        Me.txtAbonoDevolucionEmbalaje.Size = New System.Drawing.Size(87, 24)
        Me.txtAbonoDevolucionEmbalaje.TabIndex = 18
        Me.txtAbonoDevolucionEmbalaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAbonoDevolucionEmbalaje.ValorMaximo = 0.0!
        Me.txtAbonoDevolucionEmbalaje.ValorMinimo = 0.0!
        '
        'txtCosteMolde
        '
        Me.txtCosteMolde.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosteMolde.EsUnicoCampo = ""
        Me.txtCosteMolde.EsUnicoCampoID = ""
        Me.txtCosteMolde.EsUnicoID = 0
        Me.txtCosteMolde.EsUnicoTabla = ""
        Me.txtCosteMolde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosteMolde.Location = New System.Drawing.Point(244, 602)
        Me.txtCosteMolde.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosteMolde.Minimo = 0
        Me.txtCosteMolde.Modificado = False
        Me.txtCosteMolde.Name = "txtCosteMolde"
        Me.txtCosteMolde.Numerico_EsNumerico = False
        Me.txtCosteMolde.Numerico_NumeroDoublees = 5
        Me.txtCosteMolde.Numerico_SeparadorMiles = False
        Me.txtCosteMolde.Obligatorio = False
        Me.txtCosteMolde.ParametroID = 0
        Me.txtCosteMolde.Size = New System.Drawing.Size(87, 24)
        Me.txtCosteMolde.TabIndex = 19
        Me.txtCosteMolde.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosteMolde.ValorMaximo = 0.0!
        Me.txtCosteMolde.ValorMinimo = 0.0!
        '
        'txtCosteAmortizacionMoldeUnidad
        '
        Me.txtCosteAmortizacionMoldeUnidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCosteAmortizacionMoldeUnidad.EsUnicoCampo = ""
        Me.txtCosteAmortizacionMoldeUnidad.EsUnicoCampoID = ""
        Me.txtCosteAmortizacionMoldeUnidad.EsUnicoID = 0
        Me.txtCosteAmortizacionMoldeUnidad.EsUnicoTabla = ""
        Me.txtCosteAmortizacionMoldeUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCosteAmortizacionMoldeUnidad.Location = New System.Drawing.Point(244, 634)
        Me.txtCosteAmortizacionMoldeUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCosteAmortizacionMoldeUnidad.MaxLength = 9
        Me.txtCosteAmortizacionMoldeUnidad.Minimo = 0
        Me.txtCosteAmortizacionMoldeUnidad.Modificado = False
        Me.txtCosteAmortizacionMoldeUnidad.Name = "txtCosteAmortizacionMoldeUnidad"
        Me.txtCosteAmortizacionMoldeUnidad.Numerico_EsNumerico = False
        Me.txtCosteAmortizacionMoldeUnidad.Numerico_NumeroDoublees = 0
        Me.txtCosteAmortizacionMoldeUnidad.Numerico_SeparadorMiles = False
        Me.txtCosteAmortizacionMoldeUnidad.Obligatorio = False
        Me.txtCosteAmortizacionMoldeUnidad.ParametroID = 0
        Me.txtCosteAmortizacionMoldeUnidad.Size = New System.Drawing.Size(87, 24)
        Me.txtCosteAmortizacionMoldeUnidad.TabIndex = 20
        Me.txtCosteAmortizacionMoldeUnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCosteAmortizacionMoldeUnidad.ValorMaximo = 0.0!
        Me.txtCosteAmortizacionMoldeUnidad.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 7)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(244, 666)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(951, 24)
        Me.txtObservaciones.TabIndex = 21
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblArticuloFichaCondicionID
        '
        Me.lblArticuloFichaCondicionID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArticuloFichaCondicionID.Location = New System.Drawing.Point(4, 707)
        Me.lblArticuloFichaCondicionID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloFichaCondicionID.Name = "lblArticuloFichaCondicionID"
        Me.lblArticuloFichaCondicionID.Size = New System.Drawing.Size(232, 26)
        Me.lblArticuloFichaCondicionID.TabIndex = 0
        Me.lblArticuloFichaCondicionID.Text = "ArticuloFichaCondicionID"
        Me.lblArticuloFichaCondicionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloFichaCondicionID.Visible = False
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArticuloID.Location = New System.Drawing.Point(4, 36)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(232, 26)
        Me.lblArticuloID.TabIndex = 1
        Me.lblArticuloID.Text = "Articulo"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblProveedorID.Location = New System.Drawing.Point(4, 71)
        Me.lblProveedorID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(232, 26)
        Me.lblProveedorID.TabIndex = 2
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormaPagoID
        '
        Me.lblFormaPagoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFormaPagoID.Location = New System.Drawing.Point(4, 107)
        Me.lblFormaPagoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormaPagoID.Name = "lblFormaPagoID"
        Me.lblFormaPagoID.Size = New System.Drawing.Size(232, 26)
        Me.lblFormaPagoID.TabIndex = 3
        Me.lblFormaPagoID.Text = "Forma de pago"
        Me.lblFormaPagoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlazoPagoID
        '
        Me.lblPlazoPagoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPlazoPagoID.Location = New System.Drawing.Point(4, 143)
        Me.lblPlazoPagoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPlazoPagoID.Name = "lblPlazoPagoID"
        Me.lblPlazoPagoID.Size = New System.Drawing.Size(232, 26)
        Me.lblPlazoPagoID.TabIndex = 4
        Me.lblPlazoPagoID.Text = "Plazo de pago"
        Me.lblPlazoPagoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnidadID
        '
        Me.lblUnidadID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblUnidadID.Location = New System.Drawing.Point(4, 179)
        Me.lblUnidadID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblUnidadID.Name = "lblUnidadID"
        Me.lblUnidadID.Size = New System.Drawing.Size(232, 26)
        Me.lblUnidadID.TabIndex = 5
        Me.lblUnidadID.Text = "Unidad"
        Me.lblUnidadID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.Location = New System.Drawing.Point(4, 3)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(232, 26)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEurosUnidad
        '
        Me.lblEurosUnidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEurosUnidad.Location = New System.Drawing.Point(4, 213)
        Me.lblEurosUnidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEurosUnidad.Name = "lblEurosUnidad"
        Me.lblEurosUnidad.Size = New System.Drawing.Size(232, 26)
        Me.lblEurosUnidad.TabIndex = 7
        Me.lblEurosUnidad.Text = "Euros unidad"
        Me.lblEurosUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadMinima
        '
        Me.lblCantidadMinima.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCantidadMinima.Location = New System.Drawing.Point(4, 245)
        Me.lblCantidadMinima.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidadMinima.Name = "lblCantidadMinima"
        Me.lblCantidadMinima.Size = New System.Drawing.Size(232, 26)
        Me.lblCantidadMinima.TabIndex = 8
        Me.lblCantidadMinima.Text = "Cantidad minima"
        Me.lblCantidadMinima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrecioAnterior
        '
        Me.lblPrecioAnterior.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblPrecioAnterior.Location = New System.Drawing.Point(4, 277)
        Me.lblPrecioAnterior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPrecioAnterior.Name = "lblPrecioAnterior"
        Me.lblPrecioAnterior.Size = New System.Drawing.Size(232, 26)
        Me.lblPrecioAnterior.TabIndex = 9
        Me.lblPrecioAnterior.Text = "Precio anterior"
        Me.lblPrecioAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncremento
        '
        Me.lblIncremento.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblIncremento.Location = New System.Drawing.Point(4, 309)
        Me.lblIncremento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblIncremento.Name = "lblIncremento"
        Me.lblIncremento.Size = New System.Drawing.Size(232, 26)
        Me.lblIncremento.TabIndex = 10
        Me.lblIncremento.Text = "Incremento"
        Me.lblIncremento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRuta.Location = New System.Drawing.Point(4, 342)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(232, 26)
        Me.lblRuta.TabIndex = 11
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaInicio.Location = New System.Drawing.Point(4, 375)
        Me.lblFechaInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(232, 26)
        Me.lblFechaInicio.TabIndex = 14
        Me.lblFechaInicio.Text = "Inicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFechaFinal.Location = New System.Drawing.Point(4, 407)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(232, 26)
        Me.lblFechaFinal.TabIndex = 15
        Me.lblFechaFinal.Text = "Final"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblVigente.Location = New System.Drawing.Point(4, 440)
        Me.lblVigente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(232, 26)
        Me.lblVigente.TabIndex = 16
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosteTransporte
        '
        Me.lblCosteTransporte.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCosteTransporte.Location = New System.Drawing.Point(4, 473)
        Me.lblCosteTransporte.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosteTransporte.Name = "lblCosteTransporte"
        Me.lblCosteTransporte.Size = New System.Drawing.Size(232, 26)
        Me.lblCosteTransporte.TabIndex = 17
        Me.lblCosteTransporte.Text = "Coste de transporte"
        Me.lblCosteTransporte.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosteEmbalaje
        '
        Me.lblCosteEmbalaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCosteEmbalaje.Location = New System.Drawing.Point(4, 505)
        Me.lblCosteEmbalaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosteEmbalaje.Name = "lblCosteEmbalaje"
        Me.lblCosteEmbalaje.Size = New System.Drawing.Size(232, 26)
        Me.lblCosteEmbalaje.TabIndex = 18
        Me.lblCosteEmbalaje.Text = "Coste de embalaje"
        Me.lblCosteEmbalaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosteDevolucionEmbalaje
        '
        Me.lblCosteDevolucionEmbalaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCosteDevolucionEmbalaje.Location = New System.Drawing.Point(4, 537)
        Me.lblCosteDevolucionEmbalaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosteDevolucionEmbalaje.Name = "lblCosteDevolucionEmbalaje"
        Me.lblCosteDevolucionEmbalaje.Size = New System.Drawing.Size(232, 26)
        Me.lblCosteDevolucionEmbalaje.TabIndex = 19
        Me.lblCosteDevolucionEmbalaje.Text = "Coste de devolucion de embalaje"
        Me.lblCosteDevolucionEmbalaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAbonoDevolucionEmbalaje
        '
        Me.lblAbonoDevolucionEmbalaje.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblAbonoDevolucionEmbalaje.Location = New System.Drawing.Point(4, 569)
        Me.lblAbonoDevolucionEmbalaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbonoDevolucionEmbalaje.Name = "lblAbonoDevolucionEmbalaje"
        Me.lblAbonoDevolucionEmbalaje.Size = New System.Drawing.Size(232, 26)
        Me.lblAbonoDevolucionEmbalaje.TabIndex = 20
        Me.lblAbonoDevolucionEmbalaje.Text = "Abono devolucion embalaje"
        Me.lblAbonoDevolucionEmbalaje.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosteMolde
        '
        Me.lblCosteMolde.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCosteMolde.Location = New System.Drawing.Point(4, 601)
        Me.lblCosteMolde.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosteMolde.Name = "lblCosteMolde"
        Me.lblCosteMolde.Size = New System.Drawing.Size(232, 26)
        Me.lblCosteMolde.TabIndex = 21
        Me.lblCosteMolde.Text = "Coste molde"
        Me.lblCosteMolde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCosteAmortizacionMoldeUnidad
        '
        Me.lblCosteAmortizacionMoldeUnidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCosteAmortizacionMoldeUnidad.Location = New System.Drawing.Point(4, 633)
        Me.lblCosteAmortizacionMoldeUnidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCosteAmortizacionMoldeUnidad.Name = "lblCosteAmortizacionMoldeUnidad"
        Me.lblCosteAmortizacionMoldeUnidad.Size = New System.Drawing.Size(232, 26)
        Me.lblCosteAmortizacionMoldeUnidad.TabIndex = 22
        Me.lblCosteAmortizacionMoldeUnidad.Text = "Coste amortizacion molde unidad"
        Me.lblCosteAmortizacionMoldeUnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblObservaciones.Location = New System.Drawing.Point(4, 665)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(232, 26)
        Me.lblObservaciones.TabIndex = 23
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 17
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.butAddUnidad, 4, 5)
        Me.tlpMiddle.Controls.Add(Me.butAddPagoPlazo, 4, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerUnidad, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.butVerPagoPlazo, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblProveedorID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboProveedorID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFormaPagoID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboFormaPagoID, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblPlazoPagoID, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboPlazoPagoID, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblUnidadID, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.cboUnidadID, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblEurosUnidad, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtEurosUnidad, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblCantidadMinima, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtCantidadMinima, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lblPrecioAnterior, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.txtPrecioAnterior, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lblIncremento, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtIncremento, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.lblFechaInicio, 1, 12)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaInicio, 2, 12)
        Me.tlpMiddle.Controls.Add(Me.lblFechaFinal, 1, 13)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaFinal, 2, 13)
        Me.tlpMiddle.Controls.Add(Me.lblVigente, 1, 14)
        Me.tlpMiddle.Controls.Add(Me.chbVigente, 2, 14)
        Me.tlpMiddle.Controls.Add(Me.lblCosteTransporte, 1, 15)
        Me.tlpMiddle.Controls.Add(Me.txtCosteTransporte, 2, 15)
        Me.tlpMiddle.Controls.Add(Me.lblCosteEmbalaje, 1, 16)
        Me.tlpMiddle.Controls.Add(Me.txtCosteEmbalaje, 2, 16)
        Me.tlpMiddle.Controls.Add(Me.lblCosteDevolucionEmbalaje, 1, 17)
        Me.tlpMiddle.Controls.Add(Me.txtCosteDevolucionEmbalaje, 2, 17)
        Me.tlpMiddle.Controls.Add(Me.lblAbonoDevolucionEmbalaje, 1, 18)
        Me.tlpMiddle.Controls.Add(Me.txtAbonoDevolucionEmbalaje, 2, 18)
        Me.tlpMiddle.Controls.Add(Me.lblCosteMolde, 1, 19)
        Me.tlpMiddle.Controls.Add(Me.txtCosteMolde, 2, 19)
        Me.tlpMiddle.Controls.Add(Me.lblCosteAmortizacionMoldeUnidad, 1, 20)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 21)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 21)
        Me.tlpMiddle.Controls.Add(Me.txtCosteAmortizacionMoldeUnidad, 2, 20)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 11)
        Me.tlpMiddle.Controls.Add(Me.butVerPagoForma, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddPagoForma, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerProveedor, 6, 2)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 16, 11)
        Me.tlpMiddle.Controls.Add(Me.butAddProveedor, 7, 2)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloFichaCondicionID, 2, 22)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloFichaCondicionID, 1, 22)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 23
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1261, 747)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'butAddUnidad
        '
        Me.butAddUnidad.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butAddUnidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddUnidad.FlatAppearance.BorderSize = 0
        Me.butAddUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddUnidad.Location = New System.Drawing.Point(622, 178)
        Me.butAddUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddUnidad.Name = "butAddUnidad"
        Me.butAddUnidad.Size = New System.Drawing.Size(48, 28)
        Me.butAddUnidad.TabIndex = 1000000005
        Me.butAddUnidad.TabStop = False
        '
        'butAddPagoPlazo
        '
        Me.butAddPagoPlazo.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPagoPlazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butAddPagoPlazo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddPagoPlazo.FlatAppearance.BorderSize = 0
        Me.butAddPagoPlazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPagoPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPagoPlazo.Location = New System.Drawing.Point(622, 142)
        Me.butAddPagoPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddPagoPlazo.Name = "butAddPagoPlazo"
        Me.butAddPagoPlazo.Size = New System.Drawing.Size(48, 28)
        Me.butAddPagoPlazo.TabIndex = 1000000005
        Me.butAddPagoPlazo.TabStop = False
        '
        'butVerUnidad
        '
        Me.butVerUnidad.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerUnidad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butVerUnidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerUnidad.FlatAppearance.BorderSize = 0
        Me.butVerUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerUnidad.Location = New System.Drawing.Point(575, 178)
        Me.butVerUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.butVerUnidad.Name = "butVerUnidad"
        Me.butVerUnidad.Size = New System.Drawing.Size(39, 28)
        Me.butVerUnidad.TabIndex = 1000000004
        Me.butVerUnidad.TabStop = False
        '
        'butVerPagoPlazo
        '
        Me.butVerPagoPlazo.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerPagoPlazo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butVerPagoPlazo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerPagoPlazo.FlatAppearance.BorderSize = 0
        Me.butVerPagoPlazo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPagoPlazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPagoPlazo.Location = New System.Drawing.Point(575, 142)
        Me.butVerPagoPlazo.Margin = New System.Windows.Forms.Padding(4)
        Me.butVerPagoPlazo.Name = "butVerPagoPlazo"
        Me.butVerPagoPlazo.Size = New System.Drawing.Size(39, 28)
        Me.butVerPagoPlazo.TabIndex = 1000000004
        Me.butVerPagoPlazo.TabStop = False
        '
        'butVerPagoForma
        '
        Me.butVerPagoForma.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerPagoForma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butVerPagoForma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerPagoForma.FlatAppearance.BorderSize = 0
        Me.butVerPagoForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPagoForma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPagoForma.Location = New System.Drawing.Point(575, 106)
        Me.butVerPagoForma.Margin = New System.Windows.Forms.Padding(4)
        Me.butVerPagoForma.Name = "butVerPagoForma"
        Me.butVerPagoForma.Size = New System.Drawing.Size(39, 28)
        Me.butVerPagoForma.TabIndex = 1000000003
        Me.butVerPagoForma.TabStop = False
        '
        'butAddPagoForma
        '
        Me.butAddPagoForma.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPagoForma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butAddPagoForma.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddPagoForma.FlatAppearance.BorderSize = 0
        Me.butAddPagoForma.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPagoForma.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPagoForma.Location = New System.Drawing.Point(622, 106)
        Me.butAddPagoForma.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddPagoForma.Name = "butAddPagoForma"
        Me.butAddPagoForma.Size = New System.Drawing.Size(48, 28)
        Me.butAddPagoForma.TabIndex = 1000000004
        Me.butAddPagoForma.TabStop = False
        '
        'butVerProveedor
        '
        Me.butVerProveedor.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butVerProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProveedor.FlatAppearance.BorderSize = 0
        Me.butVerProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedor.Location = New System.Drawing.Point(885, 70)
        Me.butVerProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.butVerProveedor.Name = "butVerProveedor"
        Me.butVerProveedor.Size = New System.Drawing.Size(39, 28)
        Me.butVerProveedor.TabIndex = 1000000002
        Me.butVerProveedor.TabStop = False
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(1203, 342)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(39, 26)
        Me.butRuta.TabIndex = 12
        Me.butRuta.TabStop = False
        '
        'butAddProveedor
        '
        Me.butAddProveedor.BackgroundImage = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.butAddProveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProveedor.FlatAppearance.BorderSize = 0
        Me.butAddProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedor.Location = New System.Drawing.Point(932, 70)
        Me.butAddProveedor.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddProveedor.Name = "butAddProveedor"
        Me.butAddProveedor.Size = New System.Drawing.Size(48, 28)
        Me.butAddProveedor.TabIndex = 1000000003
        Me.butAddProveedor.TabStop = False
        '
        'frmEntArticulosFichasCondiciones3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1281, 807)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(563, 835)
        Me.Name = "frmEntArticulosFichasCondiciones3"
        Me.Text = "ArticulosFichasCondiciones3"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtArticuloFichaCondicionID As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboArticuloID As System.Windows.Forms.ComboBox
   Private WithEvents cboProveedorID As System.Windows.Forms.ComboBox
   Private WithEvents cboFormaPagoID As System.Windows.Forms.ComboBox
   Private WithEvents cboPlazoPagoID As System.Windows.Forms.ComboBox
   Private WithEvents cboUnidadID As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEurosUnidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCantidadMinima As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPrecioAnterior As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtIncremento As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
   Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
   Private WithEvents chbVigente As System.Windows.Forms.CheckBox
    Private WithEvents txtCosteTransporte As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCosteEmbalaje As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCosteDevolucionEmbalaje As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAbonoDevolucionEmbalaje As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCosteMolde As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCosteAmortizacionMoldeUnidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblArticuloFichaCondicionID As System.Windows.Forms.Label
   Private WithEvents lblArticuloID As System.Windows.Forms.Label
   Private WithEvents lblProveedorID As System.Windows.Forms.Label
   Private WithEvents lblFormaPagoID As System.Windows.Forms.Label
   Private WithEvents lblPlazoPagoID As System.Windows.Forms.Label
   Private WithEvents lblUnidadID As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblEurosUnidad As System.Windows.Forms.Label
   Private WithEvents lblCantidadMinima As System.Windows.Forms.Label
   Private WithEvents lblPrecioAnterior As System.Windows.Forms.Label
   Private WithEvents lblIncremento As System.Windows.Forms.Label
   Private WithEvents lblRuta As System.Windows.Forms.Label
   Private WithEvents lblFechaInicio As System.Windows.Forms.Label
   Private WithEvents lblFechaFinal As System.Windows.Forms.Label
   Private WithEvents lblVigente As System.Windows.Forms.Label
   Private WithEvents lblCosteTransporte As System.Windows.Forms.Label
   Private WithEvents lblCosteEmbalaje As System.Windows.Forms.Label
   Private WithEvents lblCosteDevolucionEmbalaje As System.Windows.Forms.Label
   Private WithEvents lblAbonoDevolucionEmbalaje As System.Windows.Forms.Label
   Private WithEvents lblCosteMolde As System.Windows.Forms.Label
   Private WithEvents lblCosteAmortizacionMoldeUnidad As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
   Private WithEvents butVerProveedor As System.Windows.Forms.Button
   Private WithEvents butAddProveedor As System.Windows.Forms.Button
   Private WithEvents butAddPagoForma As System.Windows.Forms.Button
   Private WithEvents butVerPagoForma As System.Windows.Forms.Button
   Private WithEvents butAddUnidad As System.Windows.Forms.Button
   Private WithEvents butAddPagoPlazo As System.Windows.Forms.Button
   Private WithEvents butVerUnidad As System.Windows.Forms.Button
   Private WithEvents butVerPagoPlazo As System.Windows.Forms.Button
   Private WithEvents butRuta As System.Windows.Forms.Button
End Class
