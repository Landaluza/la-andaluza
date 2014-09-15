<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntIncidenciasCalidadGeneral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntIncidenciasCalidadGeneral))
        Me.dtpFechaApertura = New System.Windows.Forms.DateTimePicker()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloTipo = New System.Windows.Forms.ComboBox()
        Me.butVerId_ArticuloTipo = New System.Windows.Forms.Button()
        Me.butAddId_ArticuloTipo = New System.Windows.Forms.Button()
        Me.cboprocesoCalidad = New System.Windows.Forms.ComboBox()
        Me.butVerId_procesoCalidad = New System.Windows.Forms.Button()
        Me.butAddId_procesoCalidad = New System.Windows.Forms.Button()
        Me.txtCriterioFrecuenciaBaja = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioFrecuenciaMedia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioFrecuenciaAlta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioGravedadLeve = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioGravedadModerada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioGravedadGrave = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbCalidad = New System.Windows.Forms.CheckBox()
        Me.chbMedioAmbiente = New System.Windows.Forms.CheckBox()
        Me.chbPRL = New System.Windows.Forms.CheckBox()
        Me.chbInocuidadAlimentos = New System.Windows.Forms.CheckBox()
        Me.chbFormacion = New System.Windows.Forms.CheckBox()
        Me.chbEstrategicos = New System.Windows.Forms.CheckBox()
        Me.txtDetalles = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbVisible = New System.Windows.Forms.CheckBox()
        Me.lblFechaApertura = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblId_ArticuloTipo = New System.Windows.Forms.Label()
        Me.lblId_procesoCalidad = New System.Windows.Forms.Label()
        Me.lblCriterioFrecuenciaBaja = New System.Windows.Forms.Label()
        Me.lblCriterioFrecuenciaMedia = New System.Windows.Forms.Label()
        Me.lblCriterioFrecuenciaAlta = New System.Windows.Forms.Label()
        Me.lblCriterioGravedadLeve = New System.Windows.Forms.Label()
        Me.lblCriterioGravedadModerada = New System.Windows.Forms.Label()
        Me.lblCriterioGravedadGrave = New System.Windows.Forms.Label()
        Me.lblCalidad = New System.Windows.Forms.Label()
        Me.lblMedioAmbiente = New System.Windows.Forms.Label()
        Me.lblPRL = New System.Windows.Forms.Label()
        Me.lblInocuidadAlimentos = New System.Windows.Forms.Label()
        Me.lblFormacion = New System.Windows.Forms.Label()
        Me.lblEstrategicos = New System.Windows.Forms.Label()
        Me.lblDetalles = New System.Windows.Forms.Label()
        Me.lblVisible = New System.Windows.Forms.Label()

        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpTipo = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFechaApertura
        '
        Me.dtpFechaApertura.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaApertura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaApertura.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaApertura.Location = New System.Drawing.Point(152, 17)
        Me.dtpFechaApertura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaApertura.Name = "dtpFechaApertura"
        Me.dtpFechaApertura.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaApertura.TabIndex = 1
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(152, 46)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(524, 23)
        Me.cboempleado.TabIndex = 3
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(690, 46)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_empleado.TabIndex = 4
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(712, 46)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_empleado.TabIndex = 5
        Me.butAddId_empleado.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(152, 132)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 500
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(578, 57)
        Me.txtDescripcion.TabIndex = 15
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboArticuloTipo
        '
        Me.cboArticuloTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboArticuloTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboArticuloTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArticuloTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloTipo.Location = New System.Drawing.Point(152, 72)
        Me.cboArticuloTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboArticuloTipo.Name = "cboArticuloTipo"
        Me.cboArticuloTipo.Size = New System.Drawing.Size(524, 23)
        Me.cboArticuloTipo.TabIndex = 7
        '
        'butVerId_ArticuloTipo
        '
        Me.butVerId_ArticuloTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_ArticuloTipo.FlatAppearance.BorderSize = 0
        Me.butVerId_ArticuloTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_ArticuloTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_ArticuloTipo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_ArticuloTipo.Location = New System.Drawing.Point(690, 72)
        Me.butVerId_ArticuloTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_ArticuloTipo.Name = "butVerId_ArticuloTipo"
        Me.butVerId_ArticuloTipo.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_ArticuloTipo.TabIndex = 8
        Me.butVerId_ArticuloTipo.TabStop = False
        '
        'butAddId_ArticuloTipo
        '
        Me.butAddId_ArticuloTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_ArticuloTipo.FlatAppearance.BorderSize = 0
        Me.butAddId_ArticuloTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_ArticuloTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_ArticuloTipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_ArticuloTipo.Location = New System.Drawing.Point(712, 72)
        Me.butAddId_ArticuloTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_ArticuloTipo.Name = "butAddId_ArticuloTipo"
        Me.butAddId_ArticuloTipo.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_ArticuloTipo.TabIndex = 9
        Me.butAddId_ArticuloTipo.TabStop = False
        '
        'cboprocesoCalidad
        '
        Me.cboprocesoCalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboprocesoCalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboprocesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboprocesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprocesoCalidad.Location = New System.Drawing.Point(152, 102)
        Me.cboprocesoCalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboprocesoCalidad.Name = "cboprocesoCalidad"
        Me.cboprocesoCalidad.Size = New System.Drawing.Size(524, 23)
        Me.cboprocesoCalidad.TabIndex = 11
        '
        'butVerId_procesoCalidad
        '
        Me.butVerId_procesoCalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_procesoCalidad.FlatAppearance.BorderSize = 0
        Me.butVerId_procesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_procesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_procesoCalidad.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_procesoCalidad.Location = New System.Drawing.Point(690, 102)
        Me.butVerId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_procesoCalidad.Name = "butVerId_procesoCalidad"
        Me.butVerId_procesoCalidad.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_procesoCalidad.TabIndex = 12
        Me.butVerId_procesoCalidad.TabStop = False
        '
        'butAddId_procesoCalidad
        '
        Me.butAddId_procesoCalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_procesoCalidad.FlatAppearance.BorderSize = 0
        Me.butAddId_procesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_procesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_procesoCalidad.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_procesoCalidad.Location = New System.Drawing.Point(712, 102)
        Me.butAddId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_procesoCalidad.Name = "butAddId_procesoCalidad"
        Me.butAddId_procesoCalidad.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_procesoCalidad.TabIndex = 13
        Me.butAddId_procesoCalidad.TabStop = False
        '
        'txtCriterioFrecuenciaBaja
        '
        Me.txtCriterioFrecuenciaBaja.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaBaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaBaja.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaBaja.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaBaja.EsUnicoID = 0
        Me.txtCriterioFrecuenciaBaja.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaBaja.Location = New System.Drawing.Point(127, 17)
        Me.txtCriterioFrecuenciaBaja.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioFrecuenciaBaja.MaxLength = 3000
        Me.txtCriterioFrecuenciaBaja.Minimo = 0
        Me.txtCriterioFrecuenciaBaja.Modificado = False
        Me.txtCriterioFrecuenciaBaja.Name = "txtCriterioFrecuenciaBaja"
        Me.txtCriterioFrecuenciaBaja.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaBaja.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaBaja.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaBaja.Obligatorio = False
        Me.txtCriterioFrecuenciaBaja.ParametroID = 0
        Me.txtCriterioFrecuenciaBaja.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioFrecuenciaBaja.TabIndex = 1
        Me.txtCriterioFrecuenciaBaja.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaBaja.ValorMinimo = 0.0R
        '
        'txtCriterioFrecuenciaMedia
        '
        Me.txtCriterioFrecuenciaMedia.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaMedia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaMedia.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaMedia.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaMedia.EsUnicoID = 0
        Me.txtCriterioFrecuenciaMedia.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaMedia.Location = New System.Drawing.Point(127, 46)
        Me.txtCriterioFrecuenciaMedia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioFrecuenciaMedia.MaxLength = 3000
        Me.txtCriterioFrecuenciaMedia.Minimo = 0
        Me.txtCriterioFrecuenciaMedia.Modificado = False
        Me.txtCriterioFrecuenciaMedia.Name = "txtCriterioFrecuenciaMedia"
        Me.txtCriterioFrecuenciaMedia.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaMedia.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaMedia.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaMedia.Obligatorio = False
        Me.txtCriterioFrecuenciaMedia.ParametroID = 0
        Me.txtCriterioFrecuenciaMedia.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioFrecuenciaMedia.TabIndex = 3
        Me.txtCriterioFrecuenciaMedia.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaMedia.ValorMinimo = 0.0R
        '
        'txtCriterioFrecuenciaAlta
        '
        Me.txtCriterioFrecuenciaAlta.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaAlta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaAlta.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaAlta.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaAlta.EsUnicoID = 0
        Me.txtCriterioFrecuenciaAlta.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaAlta.Location = New System.Drawing.Point(127, 74)
        Me.txtCriterioFrecuenciaAlta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioFrecuenciaAlta.MaxLength = 3000
        Me.txtCriterioFrecuenciaAlta.Minimo = 0
        Me.txtCriterioFrecuenciaAlta.Modificado = False
        Me.txtCriterioFrecuenciaAlta.Name = "txtCriterioFrecuenciaAlta"
        Me.txtCriterioFrecuenciaAlta.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaAlta.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaAlta.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaAlta.Obligatorio = False
        Me.txtCriterioFrecuenciaAlta.ParametroID = 0
        Me.txtCriterioFrecuenciaAlta.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioFrecuenciaAlta.TabIndex = 5
        Me.txtCriterioFrecuenciaAlta.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaAlta.ValorMinimo = 0.0R
        '
        'txtCriterioGravedadLeve
        '
        Me.txtCriterioGravedadLeve.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadLeve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadLeve.EsUnicoCampo = ""
        Me.txtCriterioGravedadLeve.EsUnicoCampoID = ""
        Me.txtCriterioGravedadLeve.EsUnicoID = 0
        Me.txtCriterioGravedadLeve.EsUnicoTabla = ""
        Me.txtCriterioGravedadLeve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadLeve.Location = New System.Drawing.Point(127, 19)
        Me.txtCriterioGravedadLeve.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioGravedadLeve.MaxLength = 3000
        Me.txtCriterioGravedadLeve.Minimo = 0
        Me.txtCriterioGravedadLeve.Modificado = False
        Me.txtCriterioGravedadLeve.Name = "txtCriterioGravedadLeve"
        Me.txtCriterioGravedadLeve.Numerico_EsNumerico = False
        Me.txtCriterioGravedadLeve.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadLeve.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadLeve.Obligatorio = False
        Me.txtCriterioGravedadLeve.ParametroID = 0
        Me.txtCriterioGravedadLeve.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioGravedadLeve.TabIndex = 7
        Me.txtCriterioGravedadLeve.ValorMaximo = 0.0R
        Me.txtCriterioGravedadLeve.ValorMinimo = 0.0R
        '
        'txtCriterioGravedadModerada
        '
        Me.txtCriterioGravedadModerada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadModerada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadModerada.EsUnicoCampo = ""
        Me.txtCriterioGravedadModerada.EsUnicoCampoID = ""
        Me.txtCriterioGravedadModerada.EsUnicoID = 0
        Me.txtCriterioGravedadModerada.EsUnicoTabla = ""
        Me.txtCriterioGravedadModerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadModerada.Location = New System.Drawing.Point(127, 47)
        Me.txtCriterioGravedadModerada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioGravedadModerada.MaxLength = 3000
        Me.txtCriterioGravedadModerada.Minimo = 0
        Me.txtCriterioGravedadModerada.Modificado = False
        Me.txtCriterioGravedadModerada.Name = "txtCriterioGravedadModerada"
        Me.txtCriterioGravedadModerada.Numerico_EsNumerico = False
        Me.txtCriterioGravedadModerada.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadModerada.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadModerada.Obligatorio = False
        Me.txtCriterioGravedadModerada.ParametroID = 0
        Me.txtCriterioGravedadModerada.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioGravedadModerada.TabIndex = 9
        Me.txtCriterioGravedadModerada.ValorMaximo = 0.0R
        Me.txtCriterioGravedadModerada.ValorMinimo = 0.0R
        '
        'txtCriterioGravedadGrave
        '
        Me.txtCriterioGravedadGrave.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadGrave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadGrave.EsUnicoCampo = ""
        Me.txtCriterioGravedadGrave.EsUnicoCampoID = ""
        Me.txtCriterioGravedadGrave.EsUnicoID = 0
        Me.txtCriterioGravedadGrave.EsUnicoTabla = ""
        Me.txtCriterioGravedadGrave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadGrave.Location = New System.Drawing.Point(127, 75)
        Me.txtCriterioGravedadGrave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCriterioGravedadGrave.MaxLength = 3000
        Me.txtCriterioGravedadGrave.Minimo = 0
        Me.txtCriterioGravedadGrave.Modificado = False
        Me.txtCriterioGravedadGrave.Name = "txtCriterioGravedadGrave"
        Me.txtCriterioGravedadGrave.Numerico_EsNumerico = False
        Me.txtCriterioGravedadGrave.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadGrave.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadGrave.Obligatorio = False
        Me.txtCriterioGravedadGrave.ParametroID = 0
        Me.txtCriterioGravedadGrave.Size = New System.Drawing.Size(392, 14)
        Me.txtCriterioGravedadGrave.TabIndex = 11
        Me.txtCriterioGravedadGrave.ValorMaximo = 0.0R
        Me.txtCriterioGravedadGrave.ValorMinimo = 0.0R
        '
        'chbCalidad
        '
        Me.chbCalidad.BackColor = System.Drawing.SystemColors.Control
        Me.chbCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCalidad.Location = New System.Drawing.Point(152, 283)
        Me.chbCalidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbCalidad.Name = "chbCalidad"
        Me.chbCalidad.Size = New System.Drawing.Size(21, 20)
        Me.chbCalidad.TabIndex = 19
        Me.chbCalidad.UseVisualStyleBackColor = False
        '
        'chbMedioAmbiente
        '
        Me.chbMedioAmbiente.BackColor = System.Drawing.SystemColors.Control
        Me.chbMedioAmbiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbMedioAmbiente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMedioAmbiente.Location = New System.Drawing.Point(152, 308)
        Me.chbMedioAmbiente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbMedioAmbiente.Name = "chbMedioAmbiente"
        Me.chbMedioAmbiente.Size = New System.Drawing.Size(21, 20)
        Me.chbMedioAmbiente.TabIndex = 21
        Me.chbMedioAmbiente.UseVisualStyleBackColor = False
        '
        'chbPRL
        '
        Me.chbPRL.BackColor = System.Drawing.SystemColors.Control
        Me.chbPRL.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbPRL.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPRL.Location = New System.Drawing.Point(152, 333)
        Me.chbPRL.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbPRL.Name = "chbPRL"
        Me.chbPRL.Size = New System.Drawing.Size(21, 20)
        Me.chbPRL.TabIndex = 23
        Me.chbPRL.UseVisualStyleBackColor = False
        '
        'chbInocuidadAlimentos
        '
        Me.chbInocuidadAlimentos.BackColor = System.Drawing.SystemColors.Control
        Me.chbInocuidadAlimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbInocuidadAlimentos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbInocuidadAlimentos.Location = New System.Drawing.Point(152, 358)
        Me.chbInocuidadAlimentos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbInocuidadAlimentos.Name = "chbInocuidadAlimentos"
        Me.chbInocuidadAlimentos.Size = New System.Drawing.Size(21, 20)
        Me.chbInocuidadAlimentos.TabIndex = 25
        Me.chbInocuidadAlimentos.UseVisualStyleBackColor = False
        '
        'chbFormacion
        '
        Me.chbFormacion.BackColor = System.Drawing.SystemColors.Control
        Me.chbFormacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbFormacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFormacion.Location = New System.Drawing.Point(152, 384)
        Me.chbFormacion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbFormacion.Name = "chbFormacion"
        Me.chbFormacion.Size = New System.Drawing.Size(21, 20)
        Me.chbFormacion.TabIndex = 27
        Me.chbFormacion.UseVisualStyleBackColor = False
        '
        'chbEstrategicos
        '
        Me.chbEstrategicos.BackColor = System.Drawing.SystemColors.Control
        Me.chbEstrategicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEstrategicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEstrategicos.Location = New System.Drawing.Point(152, 410)
        Me.chbEstrategicos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbEstrategicos.Name = "chbEstrategicos"
        Me.chbEstrategicos.Size = New System.Drawing.Size(21, 20)
        Me.chbEstrategicos.TabIndex = 29
        Me.chbEstrategicos.UseVisualStyleBackColor = False
        '
        'txtDetalles
        '
        Me.txtDetalles.BackColor = System.Drawing.SystemColors.Window
        Me.txtDetalles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDetalles.EsUnicoCampo = ""
        Me.txtDetalles.EsUnicoCampoID = ""
        Me.txtDetalles.EsUnicoID = 0
        Me.txtDetalles.EsUnicoTabla = ""
        Me.txtDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDetalles.Location = New System.Drawing.Point(152, 201)
        Me.txtDetalles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDetalles.MaxLength = 3000
        Me.txtDetalles.Minimo = 0
        Me.txtDetalles.Modificado = False
        Me.txtDetalles.Multiline = True
        Me.txtDetalles.Name = "txtDetalles"
        Me.txtDetalles.Numerico_EsNumerico = False
        Me.txtDetalles.Numerico_NumeroDoublees = 0
        Me.txtDetalles.Numerico_SeparadorMiles = False
        Me.txtDetalles.Obligatorio = False
        Me.txtDetalles.ParametroID = 0
        Me.txtDetalles.Size = New System.Drawing.Size(578, 60)
        Me.txtDetalles.TabIndex = 17
        Me.txtDetalles.ValorMaximo = 0.0R
        Me.txtDetalles.ValorMinimo = 0.0R
        '
        'chbVisible
        '
        Me.chbVisible.BackColor = System.Drawing.SystemColors.Control
        Me.chbVisible.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVisible.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVisible.Location = New System.Drawing.Point(152, 435)
        Me.chbVisible.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbVisible.Name = "chbVisible"
        Me.chbVisible.Size = New System.Drawing.Size(21, 20)
        Me.chbVisible.TabIndex = 31
        Me.chbVisible.UseVisualStyleBackColor = False
        '
        'lblFechaApertura
        '
        Me.lblFechaApertura.Location = New System.Drawing.Point(15, 15)
        Me.lblFechaApertura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaApertura.Name = "lblFechaApertura"
        Me.lblFechaApertura.Size = New System.Drawing.Size(133, 28)
        Me.lblFechaApertura.TabIndex = 0
        Me.lblFechaApertura.Text = "FechaApertura"
        Me.lblFechaApertura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Location = New System.Drawing.Point(15, 43)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(133, 30)
        Me.lblId_empleado.TabIndex = 2
        Me.lblId_empleado.Text = "Responsable"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 129)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(133, 28)
        Me.lblDescripcion.TabIndex = 14
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_ArticuloTipo
        '
        Me.lblId_ArticuloTipo.Location = New System.Drawing.Point(15, 69)
        Me.lblId_ArticuloTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_ArticuloTipo.Name = "lblId_ArticuloTipo"
        Me.lblId_ArticuloTipo.Size = New System.Drawing.Size(133, 30)
        Me.lblId_ArticuloTipo.TabIndex = 6
        Me.lblId_ArticuloTipo.Text = "Articulo"
        Me.lblId_ArticuloTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_procesoCalidad
        '
        Me.lblId_procesoCalidad.Location = New System.Drawing.Point(15, 99)
        Me.lblId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_procesoCalidad.Name = "lblId_procesoCalidad"
        Me.lblId_procesoCalidad.Size = New System.Drawing.Size(133, 30)
        Me.lblId_procesoCalidad.TabIndex = 10
        Me.lblId_procesoCalidad.Text = "Proceso"
        Me.lblId_procesoCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioFrecuenciaBaja
        '
        Me.lblCriterioFrecuenciaBaja.Location = New System.Drawing.Point(13, 15)
        Me.lblCriterioFrecuenciaBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaBaja.Name = "lblCriterioFrecuenciaBaja"
        Me.lblCriterioFrecuenciaBaja.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioFrecuenciaBaja.TabIndex = 0
        Me.lblCriterioFrecuenciaBaja.Text = "Frecuencia baja"
        Me.lblCriterioFrecuenciaBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioFrecuenciaMedia
        '
        Me.lblCriterioFrecuenciaMedia.Location = New System.Drawing.Point(13, 43)
        Me.lblCriterioFrecuenciaMedia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaMedia.Name = "lblCriterioFrecuenciaMedia"
        Me.lblCriterioFrecuenciaMedia.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioFrecuenciaMedia.TabIndex = 2
        Me.lblCriterioFrecuenciaMedia.Text = "Frecuencia media"
        Me.lblCriterioFrecuenciaMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioFrecuenciaAlta
        '
        Me.lblCriterioFrecuenciaAlta.Location = New System.Drawing.Point(13, 72)
        Me.lblCriterioFrecuenciaAlta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaAlta.Name = "lblCriterioFrecuenciaAlta"
        Me.lblCriterioFrecuenciaAlta.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioFrecuenciaAlta.TabIndex = 4
        Me.lblCriterioFrecuenciaAlta.Text = "Frecuencia alta"
        Me.lblCriterioFrecuenciaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioGravedadLeve
        '
        Me.lblCriterioGravedadLeve.Location = New System.Drawing.Point(13, 16)
        Me.lblCriterioGravedadLeve.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadLeve.Name = "lblCriterioGravedadLeve"
        Me.lblCriterioGravedadLeve.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioGravedadLeve.TabIndex = 6
        Me.lblCriterioGravedadLeve.Text = "Gravedad leve"
        Me.lblCriterioGravedadLeve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioGravedadModerada
        '
        Me.lblCriterioGravedadModerada.Location = New System.Drawing.Point(13, 45)
        Me.lblCriterioGravedadModerada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadModerada.Name = "lblCriterioGravedadModerada"
        Me.lblCriterioGravedadModerada.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioGravedadModerada.TabIndex = 8
        Me.lblCriterioGravedadModerada.Text = "Gravedad moderada"
        Me.lblCriterioGravedadModerada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioGravedadGrave
        '
        Me.lblCriterioGravedadGrave.Location = New System.Drawing.Point(13, 72)
        Me.lblCriterioGravedadGrave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadGrave.Name = "lblCriterioGravedadGrave"
        Me.lblCriterioGravedadGrave.Size = New System.Drawing.Size(110, 28)
        Me.lblCriterioGravedadGrave.TabIndex = 10
        Me.lblCriterioGravedadGrave.Text = "Gravedad grave"
        Me.lblCriterioGravedadGrave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCalidad
        '
        Me.lblCalidad.Location = New System.Drawing.Point(15, 280)
        Me.lblCalidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCalidad.Name = "lblCalidad"
        Me.lblCalidad.Size = New System.Drawing.Size(133, 25)
        Me.lblCalidad.TabIndex = 18
        Me.lblCalidad.Text = "Calidad"
        Me.lblCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedioAmbiente
        '
        Me.lblMedioAmbiente.Location = New System.Drawing.Point(15, 306)
        Me.lblMedioAmbiente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMedioAmbiente.Name = "lblMedioAmbiente"
        Me.lblMedioAmbiente.Size = New System.Drawing.Size(133, 25)
        Me.lblMedioAmbiente.TabIndex = 20
        Me.lblMedioAmbiente.Text = "MedioAmbiente"
        Me.lblMedioAmbiente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPRL
        '
        Me.lblPRL.Location = New System.Drawing.Point(15, 331)
        Me.lblPRL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPRL.Name = "lblPRL"
        Me.lblPRL.Size = New System.Drawing.Size(133, 25)
        Me.lblPRL.TabIndex = 22
        Me.lblPRL.Text = "PRL"
        Me.lblPRL.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInocuidadAlimentos
        '
        Me.lblInocuidadAlimentos.Location = New System.Drawing.Point(15, 356)
        Me.lblInocuidadAlimentos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInocuidadAlimentos.Name = "lblInocuidadAlimentos"
        Me.lblInocuidadAlimentos.Size = New System.Drawing.Size(133, 26)
        Me.lblInocuidadAlimentos.TabIndex = 24
        Me.lblInocuidadAlimentos.Text = "InocuidadAlimentos"
        Me.lblInocuidadAlimentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormacion
        '
        Me.lblFormacion.Location = New System.Drawing.Point(15, 382)
        Me.lblFormacion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFormacion.Name = "lblFormacion"
        Me.lblFormacion.Size = New System.Drawing.Size(133, 25)
        Me.lblFormacion.TabIndex = 26
        Me.lblFormacion.Text = "Formacion"
        Me.lblFormacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstrategicos
        '
        Me.lblEstrategicos.Location = New System.Drawing.Point(15, 407)
        Me.lblEstrategicos.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEstrategicos.Name = "lblEstrategicos"
        Me.lblEstrategicos.Size = New System.Drawing.Size(133, 25)
        Me.lblEstrategicos.TabIndex = 28
        Me.lblEstrategicos.Text = "Estrategicos"
        Me.lblEstrategicos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDetalles
        '
        Me.lblDetalles.Location = New System.Drawing.Point(15, 198)
        Me.lblDetalles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDetalles.Name = "lblDetalles"
        Me.lblDetalles.Size = New System.Drawing.Size(133, 28)
        Me.lblDetalles.TabIndex = 16
        Me.lblDetalles.Text = "Detalles"
        Me.lblDetalles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVisible
        '
        Me.lblVisible.Location = New System.Drawing.Point(15, 432)
        Me.lblVisible.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVisible.Name = "lblVisible"
        Me.lblVisible.Size = New System.Drawing.Size(133, 25)
        Me.lblVisible.TabIndex = 30
        Me.lblVisible.Text = "Visible"
        Me.lblVisible.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblCriterioFrecuenciaBaja)
        Me.GroupBox1.Controls.Add(Me.txtCriterioFrecuenciaAlta)
        Me.GroupBox1.Controls.Add(Me.lblCriterioFrecuenciaAlta)
        Me.GroupBox1.Controls.Add(Me.txtCriterioFrecuenciaMedia)
        Me.GroupBox1.Controls.Add(Me.lblCriterioFrecuenciaMedia)
        Me.GroupBox1.Controls.Add(Me.txtCriterioFrecuenciaBaja)
        Me.GroupBox1.Location = New System.Drawing.Point(190, 265)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(540, 102)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Criterios frecuencias"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.lblFechaApertura)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lblCalidad)
        Me.Panel1.Controls.Add(Me.chbCalidad)
        Me.Panel1.Controls.Add(Me.dtpFechaApertura)
        Me.Panel1.Controls.Add(Me.lblMedioAmbiente)
        Me.Panel1.Controls.Add(Me.chbMedioAmbiente)
        Me.Panel1.Controls.Add(Me.lblId_empleado)
        Me.Panel1.Controls.Add(Me.lblPRL)
        Me.Panel1.Controls.Add(Me.butAddId_procesoCalidad)
        Me.Panel1.Controls.Add(Me.cboempleado)
        Me.Panel1.Controls.Add(Me.chbPRL)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.butVerId_procesoCalidad)
        Me.Panel1.Controls.Add(Me.butVerId_empleado)
        Me.Panel1.Controls.Add(Me.lblInocuidadAlimentos)
        Me.Panel1.Controls.Add(Me.chbVisible)
        Me.Panel1.Controls.Add(Me.cboprocesoCalidad)
        Me.Panel1.Controls.Add(Me.butAddId_empleado)
        Me.Panel1.Controls.Add(Me.chbInocuidadAlimentos)
        Me.Panel1.Controls.Add(Me.lblVisible)
        Me.Panel1.Controls.Add(Me.lblId_procesoCalidad)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblFormacion)
        Me.Panel1.Controls.Add(Me.txtDetalles)
        Me.Panel1.Controls.Add(Me.butAddId_ArticuloTipo)
        Me.Panel1.Controls.Add(Me.lblDetalles)
        Me.Panel1.Controls.Add(Me.chbFormacion)
        Me.Panel1.Controls.Add(Me.lblId_ArticuloTipo)
        Me.Panel1.Controls.Add(Me.butVerId_ArticuloTipo)
        Me.Panel1.Controls.Add(Me.chbEstrategicos)
        Me.Panel1.Controls.Add(Me.lblEstrategicos)
        Me.Panel1.Controls.Add(Me.cboArticuloTipo)
        Me.Panel1.Location = New System.Drawing.Point(16, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(748, 478)
        Me.Panel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCriterioGravedadModerada)
        Me.GroupBox2.Controls.Add(Me.lblCriterioGravedadModerada)
        Me.GroupBox2.Controls.Add(Me.txtCriterioGravedadGrave)
        Me.GroupBox2.Controls.Add(Me.txtCriterioGravedadLeve)
        Me.GroupBox2.Controls.Add(Me.lblCriterioGravedadGrave)
        Me.GroupBox2.Controls.Add(Me.lblCriterioGravedadLeve)
        Me.GroupBox2.Location = New System.Drawing.Point(190, 371)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(540, 104)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Criterios gravedades"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(774, 669)
        Me.SplitContainer1.SplitterDistance = 479
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpTipo)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(774, 187)
        Me.TabControl1.TabIndex = 0
        '
        'tpTipo
        '
        Me.tpTipo.Location = New System.Drawing.Point(4, 22)
        Me.tpTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTipo.Name = "tpTipo"
        Me.tpTipo.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTipo.Size = New System.Drawing.Size(766, 161)
        Me.tpTipo.TabIndex = 1
        Me.tpTipo.Text = "Tipo incidencia envasado"
        Me.tpTipo.UseVisualStyleBackColor = True
        '
        'frmEntIncidenciasCalidadGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(774, 694)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntIncidenciasCalidadGeneral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IncidenciasCalidadGeneral"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCriterioFrecuenciaBaja As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioFrecuenciaMedia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioFrecuenciaAlta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioGravedadLeve As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioGravedadModerada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioGravedadGrave As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCriterioFrecuenciaBaja As System.Windows.Forms.Label
    Private WithEvents lblCriterioFrecuenciaMedia As System.Windows.Forms.Label
    Private WithEvents lblCriterioFrecuenciaAlta As System.Windows.Forms.Label
    Private WithEvents lblCriterioGravedadLeve As System.Windows.Forms.Label
    Private WithEvents lblCriterioGravedadModerada As System.Windows.Forms.Label
    Private WithEvents lblCriterioGravedadGrave As System.Windows.Forms.Label

    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents dtpFechaApertura As System.Windows.Forms.DateTimePicker
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloTipo As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_ArticuloTipo As System.Windows.Forms.Button
    Private WithEvents butAddId_ArticuloTipo As System.Windows.Forms.Button
    Private WithEvents cboprocesoCalidad As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_procesoCalidad As System.Windows.Forms.Button
    Private WithEvents butAddId_procesoCalidad As System.Windows.Forms.Button
    Private WithEvents chbCalidad As System.Windows.Forms.CheckBox
    Private WithEvents chbMedioAmbiente As System.Windows.Forms.CheckBox
    Private WithEvents chbPRL As System.Windows.Forms.CheckBox
    Private WithEvents chbInocuidadAlimentos As System.Windows.Forms.CheckBox
    Private WithEvents chbFormacion As System.Windows.Forms.CheckBox
    Private WithEvents chbEstrategicos As System.Windows.Forms.CheckBox
    Private WithEvents txtDetalles As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbVisible As System.Windows.Forms.CheckBox
    Private WithEvents lblFechaApertura As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblId_ArticuloTipo As System.Windows.Forms.Label
    Private WithEvents lblId_procesoCalidad As System.Windows.Forms.Label
    Private WithEvents lblCalidad As System.Windows.Forms.Label
    Private WithEvents lblMedioAmbiente As System.Windows.Forms.Label
    Private WithEvents lblPRL As System.Windows.Forms.Label
    Private WithEvents lblInocuidadAlimentos As System.Windows.Forms.Label
    Private WithEvents lblFormacion As System.Windows.Forms.Label
    Private WithEvents lblEstrategicos As System.Windows.Forms.Label
    Private WithEvents lblDetalles As System.Windows.Forms.Label
    Private WithEvents lblVisible As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpTipo As System.Windows.Forms.TabPage
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
