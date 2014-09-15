<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias))
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboprocesoCalidad = New System.Windows.Forms.ComboBox()
        Me.butVerId_procesoCalidad = New System.Windows.Forms.Button()
        Me.butAddId_procesoCalidad = New System.Windows.Forms.Button()
        Me.cboarticulo = New System.Windows.Forms.ComboBox()
        Me.cboincidenciaCalidadGeneral = New System.Windows.Forms.ComboBox()
        Me.butVerId_incidenciaCalidadGeneral = New System.Windows.Forms.Button()
        Me.butAddId_incidenciaCalidadGeneral = New System.Windows.Forms.Button()
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.butVerid_empleado = New System.Windows.Forms.Button()
        Me.butAddid_empleado = New System.Windows.Forms.Button()
        Me.cboPuntosGravedad = New System.Windows.Forms.ComboBox()
        Me.butVerId_PuntosGravedad = New System.Windows.Forms.Button()
        Me.butAddId_PuntosGravedad = New System.Windows.Forms.Button()
        Me.cboPuntosFrecuencia = New System.Windows.Forms.ComboBox()
        Me.butVerId_PuntosFrecuencia = New System.Windows.Forms.Button()
        Me.butAddId_PuntosFrecuencia = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbNecesitaSeguimiento = New System.Windows.Forms.CheckBox()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblId_procesoCalidad = New System.Windows.Forms.Label()
        Me.lblId_articulo = New System.Windows.Forms.Label()
        Me.lblId_incidenciaCalidadGeneral = New System.Windows.Forms.Label()
        Me.lblid_empleado = New System.Windows.Forms.Label()
        Me.lblId_PuntosGravedad = New System.Windows.Forms.Label()
        Me.lblId_PuntosFrecuencia = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblNecesitaSeguimiento = New System.Windows.Forms.Label()
        Me.PanGeneral = New System.Windows.Forms.Panel()
        Me.btnCleanArticulo = New System.Windows.Forms.Button()
        Me.btnVerEstados = New System.Windows.Forms.Button()
        Me.btnAddEstados = New System.Windows.Forms.Button()
        Me.lEstado = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lCodigo = New System.Windows.Forms.Label()
        Me.butHelpCriterios = New System.Windows.Forms.Button()
        Me.PanCriterios = New System.Windows.Forms.Panel()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.lblCriterioFrecuenciaBaja = New System.Windows.Forms.Label()
        Me.txtCriterioFrecuenciaAlta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCriterioFrecuenciaBaja = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCriterioFrecuenciaAlta = New System.Windows.Forms.Label()
        Me.lblCriterioFrecuenciaMedia = New System.Windows.Forms.Label()
        Me.txtCriterioFrecuenciaMedia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.txtCriterioGravedadModerada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCriterioGravedadModerada = New System.Windows.Forms.Label()
        Me.lblCriterioGravedadLeve = New System.Windows.Forms.Label()
        Me.txtCriterioGravedadGrave = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCriterioGravedadGrave = New System.Windows.Forms.Label()
        Me.txtCriterioGravedadLeve = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoArticulo = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpOrigen = New System.Windows.Forms.TabPage()
        Me.tpCausas = New System.Windows.Forms.TabPage()
        Me.tpAccionesInmediatas = New System.Windows.Forms.TabPage()
        Me.tpAccionesCorrectivas = New System.Windows.Forms.TabPage()
        Me.tpAccionesPreventivas = New System.Windows.Forms.TabPage()
        Me.tpIncidenciasenvasados = New System.Windows.Forms.TabPage()
        Me.tpSeguimiento = New System.Windows.Forms.TabPage()
        Me.tpAlmacenNC = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TimerCriterios = New System.Windows.Forms.Timer(Me.components)
        Me.tpGastos = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanGeneral.SuspendLayout()
        Me.PanCriterios.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(136, 10)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'cboprocesoCalidad
        '
        Me.cboprocesoCalidad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboprocesoCalidad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboprocesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboprocesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprocesoCalidad.Location = New System.Drawing.Point(136, 38)
        Me.cboprocesoCalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.cboprocesoCalidad.Name = "cboprocesoCalidad"
        Me.cboprocesoCalidad.Size = New System.Drawing.Size(618, 23)
        Me.cboprocesoCalidad.TabIndex = 3
        '
        'butVerId_procesoCalidad
        '
        Me.butVerId_procesoCalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_procesoCalidad.FlatAppearance.BorderSize = 0
        Me.butVerId_procesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_procesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_procesoCalidad.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_procesoCalidad.Location = New System.Drawing.Point(755, 38)
        Me.butVerId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerId_procesoCalidad.Name = "butVerId_procesoCalidad"
        Me.butVerId_procesoCalidad.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_procesoCalidad.TabIndex = 4
        Me.butVerId_procesoCalidad.TabStop = False
        '
        'butAddId_procesoCalidad
        '
        Me.butAddId_procesoCalidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_procesoCalidad.FlatAppearance.BorderSize = 0
        Me.butAddId_procesoCalidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_procesoCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_procesoCalidad.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_procesoCalidad.Location = New System.Drawing.Point(776, 38)
        Me.butAddId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddId_procesoCalidad.Name = "butAddId_procesoCalidad"
        Me.butAddId_procesoCalidad.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_procesoCalidad.TabIndex = 5
        Me.butAddId_procesoCalidad.TabStop = False
        '
        'cboarticulo
        '
        Me.cboarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboarticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboarticulo.Location = New System.Drawing.Point(321, 68)
        Me.cboarticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboarticulo.Name = "cboarticulo"
        Me.cboarticulo.Size = New System.Drawing.Size(434, 23)
        Me.cboarticulo.TabIndex = 8
        '
        'cboincidenciaCalidadGeneral
        '
        Me.cboincidenciaCalidadGeneral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboincidenciaCalidadGeneral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboincidenciaCalidadGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboincidenciaCalidadGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboincidenciaCalidadGeneral.Location = New System.Drawing.Point(136, 98)
        Me.cboincidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.cboincidenciaCalidadGeneral.Name = "cboincidenciaCalidadGeneral"
        Me.cboincidenciaCalidadGeneral.Size = New System.Drawing.Size(618, 23)
        Me.cboincidenciaCalidadGeneral.TabIndex = 10
        '
        'butVerId_incidenciaCalidadGeneral
        '
        Me.butVerId_incidenciaCalidadGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_incidenciaCalidadGeneral.FlatAppearance.BorderSize = 0
        Me.butVerId_incidenciaCalidadGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_incidenciaCalidadGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_incidenciaCalidadGeneral.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_incidenciaCalidadGeneral.Location = New System.Drawing.Point(755, 98)
        Me.butVerId_incidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerId_incidenciaCalidadGeneral.Name = "butVerId_incidenciaCalidadGeneral"
        Me.butVerId_incidenciaCalidadGeneral.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_incidenciaCalidadGeneral.TabIndex = 11
        Me.butVerId_incidenciaCalidadGeneral.TabStop = False
        '
        'butAddId_incidenciaCalidadGeneral
        '
        Me.butAddId_incidenciaCalidadGeneral.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_incidenciaCalidadGeneral.FlatAppearance.BorderSize = 0
        Me.butAddId_incidenciaCalidadGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_incidenciaCalidadGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_incidenciaCalidadGeneral.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_incidenciaCalidadGeneral.Location = New System.Drawing.Point(776, 98)
        Me.butAddId_incidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddId_incidenciaCalidadGeneral.Name = "butAddId_incidenciaCalidadGeneral"
        Me.butAddId_incidenciaCalidadGeneral.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_incidenciaCalidadGeneral.TabIndex = 12
        Me.butAddId_incidenciaCalidadGeneral.TabStop = False
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(136, 128)
        Me.cboid_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(618, 23)
        Me.cboid_empleado.TabIndex = 15
        '
        'butVerid_empleado
        '
        Me.butVerid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_empleado.FlatAppearance.BorderSize = 0
        Me.butVerid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_empleado.Location = New System.Drawing.Point(755, 128)
        Me.butVerid_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerid_empleado.Name = "butVerid_empleado"
        Me.butVerid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_empleado.TabIndex = 16
        Me.butVerid_empleado.TabStop = False
        '
        'butAddid_empleado
        '
        Me.butAddid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_empleado.FlatAppearance.BorderSize = 0
        Me.butAddid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_empleado.Location = New System.Drawing.Point(776, 128)
        Me.butAddid_empleado.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddid_empleado.Name = "butAddid_empleado"
        Me.butAddid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_empleado.TabIndex = 17
        Me.butAddid_empleado.TabStop = False
        '
        'cboPuntosGravedad
        '
        Me.cboPuntosGravedad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPuntosGravedad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuntosGravedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPuntosGravedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntosGravedad.Location = New System.Drawing.Point(136, 159)
        Me.cboPuntosGravedad.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPuntosGravedad.Name = "cboPuntosGravedad"
        Me.cboPuntosGravedad.Size = New System.Drawing.Size(181, 23)
        Me.cboPuntosGravedad.TabIndex = 19
        '
        'butVerId_PuntosGravedad
        '
        Me.butVerId_PuntosGravedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_PuntosGravedad.FlatAppearance.BorderSize = 0
        Me.butVerId_PuntosGravedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_PuntosGravedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_PuntosGravedad.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_PuntosGravedad.Location = New System.Drawing.Point(321, 159)
        Me.butVerId_PuntosGravedad.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerId_PuntosGravedad.Name = "butVerId_PuntosGravedad"
        Me.butVerId_PuntosGravedad.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_PuntosGravedad.TabIndex = 20
        Me.butVerId_PuntosGravedad.TabStop = False
        '
        'butAddId_PuntosGravedad
        '
        Me.butAddId_PuntosGravedad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_PuntosGravedad.FlatAppearance.BorderSize = 0
        Me.butAddId_PuntosGravedad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_PuntosGravedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_PuntosGravedad.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_PuntosGravedad.Location = New System.Drawing.Point(344, 159)
        Me.butAddId_PuntosGravedad.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddId_PuntosGravedad.Name = "butAddId_PuntosGravedad"
        Me.butAddId_PuntosGravedad.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_PuntosGravedad.TabIndex = 21
        Me.butAddId_PuntosGravedad.TabStop = False
        '
        'cboPuntosFrecuencia
        '
        Me.cboPuntosFrecuencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPuntosFrecuencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuntosFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPuntosFrecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntosFrecuencia.Location = New System.Drawing.Point(573, 159)
        Me.cboPuntosFrecuencia.Margin = New System.Windows.Forms.Padding(2)
        Me.cboPuntosFrecuencia.Name = "cboPuntosFrecuencia"
        Me.cboPuntosFrecuencia.Size = New System.Drawing.Size(181, 23)
        Me.cboPuntosFrecuencia.TabIndex = 23
        '
        'butVerId_PuntosFrecuencia
        '
        Me.butVerId_PuntosFrecuencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_PuntosFrecuencia.FlatAppearance.BorderSize = 0
        Me.butVerId_PuntosFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_PuntosFrecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_PuntosFrecuencia.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_PuntosFrecuencia.Location = New System.Drawing.Point(755, 158)
        Me.butVerId_PuntosFrecuencia.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerId_PuntosFrecuencia.Name = "butVerId_PuntosFrecuencia"
        Me.butVerId_PuntosFrecuencia.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_PuntosFrecuencia.TabIndex = 24
        Me.butVerId_PuntosFrecuencia.TabStop = False
        '
        'butAddId_PuntosFrecuencia
        '
        Me.butAddId_PuntosFrecuencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_PuntosFrecuencia.FlatAppearance.BorderSize = 0
        Me.butAddId_PuntosFrecuencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_PuntosFrecuencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_PuntosFrecuencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_PuntosFrecuencia.Location = New System.Drawing.Point(776, 158)
        Me.butAddId_PuntosFrecuencia.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddId_PuntosFrecuencia.Name = "butAddId_PuntosFrecuencia"
        Me.butAddId_PuntosFrecuencia.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_PuntosFrecuencia.TabIndex = 25
        Me.butAddId_PuntosFrecuencia.TabStop = False
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
        Me.txtObservaciones.Location = New System.Drawing.Point(136, 191)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(658, 51)
        Me.txtObservaciones.TabIndex = 27
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'chbNecesitaSeguimiento
        '
        Me.chbNecesitaSeguimiento.BackColor = System.Drawing.SystemColors.Control
        Me.chbNecesitaSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNecesitaSeguimiento.Location = New System.Drawing.Point(136, 246)
        Me.chbNecesitaSeguimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.chbNecesitaSeguimiento.Name = "chbNecesitaSeguimiento"
        Me.chbNecesitaSeguimiento.Size = New System.Drawing.Size(180, 20)
        Me.chbNecesitaSeguimiento.TabIndex = 29
        Me.chbNecesitaSeguimiento.UseVisualStyleBackColor = False
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(20, 6)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(116, 28)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_procesoCalidad
        '
        Me.lblId_procesoCalidad.Location = New System.Drawing.Point(20, 36)
        Me.lblId_procesoCalidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_procesoCalidad.Name = "lblId_procesoCalidad"
        Me.lblId_procesoCalidad.Size = New System.Drawing.Size(116, 30)
        Me.lblId_procesoCalidad.TabIndex = 2
        Me.lblId_procesoCalidad.Text = "Proceso"
        Me.lblId_procesoCalidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_articulo
        '
        Me.lblId_articulo.Location = New System.Drawing.Point(20, 66)
        Me.lblId_articulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_articulo.Name = "lblId_articulo"
        Me.lblId_articulo.Size = New System.Drawing.Size(116, 30)
        Me.lblId_articulo.TabIndex = 6
        Me.lblId_articulo.Text = "Artículo"
        Me.lblId_articulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_incidenciaCalidadGeneral
        '
        Me.lblId_incidenciaCalidadGeneral.Location = New System.Drawing.Point(20, 96)
        Me.lblId_incidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_incidenciaCalidadGeneral.Name = "lblId_incidenciaCalidadGeneral"
        Me.lblId_incidenciaCalidadGeneral.Size = New System.Drawing.Size(116, 30)
        Me.lblId_incidenciaCalidadGeneral.TabIndex = 9
        Me.lblId_incidenciaCalidadGeneral.Text = "Incidencia"
        Me.lblId_incidenciaCalidadGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empleado
        '
        Me.lblid_empleado.Location = New System.Drawing.Point(20, 126)
        Me.lblid_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(116, 30)
        Me.lblid_empleado.TabIndex = 14
        Me.lblid_empleado.Text = "Responsable"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_PuntosGravedad
        '
        Me.lblId_PuntosGravedad.Location = New System.Drawing.Point(20, 156)
        Me.lblId_PuntosGravedad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_PuntosGravedad.Name = "lblId_PuntosGravedad"
        Me.lblId_PuntosGravedad.Size = New System.Drawing.Size(116, 30)
        Me.lblId_PuntosGravedad.TabIndex = 18
        Me.lblId_PuntosGravedad.Text = "Puntos gravedad"
        Me.lblId_PuntosGravedad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_PuntosFrecuencia
        '
        Me.lblId_PuntosFrecuencia.Location = New System.Drawing.Point(428, 156)
        Me.lblId_PuntosFrecuencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_PuntosFrecuencia.Name = "lblId_PuntosFrecuencia"
        Me.lblId_PuntosFrecuencia.Size = New System.Drawing.Size(142, 29)
        Me.lblId_PuntosFrecuencia.TabIndex = 22
        Me.lblId_PuntosFrecuencia.Text = "Puntos frecuencia"
        Me.lblId_PuntosFrecuencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 188)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(116, 28)
        Me.lblObservaciones.TabIndex = 26
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNecesitaSeguimiento
        '
        Me.lblNecesitaSeguimiento.Location = New System.Drawing.Point(20, 244)
        Me.lblNecesitaSeguimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNecesitaSeguimiento.Name = "lblNecesitaSeguimiento"
        Me.lblNecesitaSeguimiento.Size = New System.Drawing.Size(116, 25)
        Me.lblNecesitaSeguimiento.TabIndex = 28
        Me.lblNecesitaSeguimiento.Text = "Necesita seguimiento"
        Me.lblNecesitaSeguimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'PanGeneral
        '
        Me.PanGeneral.Controls.Add(Me.btnCleanArticulo)
        Me.PanGeneral.Controls.Add(Me.btnVerEstados)
        Me.PanGeneral.Controls.Add(Me.btnAddEstados)
        Me.PanGeneral.Controls.Add(Me.lEstado)
        Me.PanGeneral.Controls.Add(Me.cboEstado)
        Me.PanGeneral.Controls.Add(Me.txtId)
        Me.PanGeneral.Controls.Add(Me.lCodigo)
        Me.PanGeneral.Controls.Add(Me.butHelpCriterios)
        Me.PanGeneral.Controls.Add(Me.PanCriterios)
        Me.PanGeneral.Controls.Add(Me.cboTipoArticulo)
        Me.PanGeneral.Controls.Add(Me.dtpFecha)
        Me.PanGeneral.Controls.Add(Me.butVerid_empleado)
        Me.PanGeneral.Controls.Add(Me.cboid_empleado)
        Me.PanGeneral.Controls.Add(Me.lblFecha)
        Me.PanGeneral.Controls.Add(Me.butAddid_empleado)
        Me.PanGeneral.Controls.Add(Me.lblid_empleado)
        Me.PanGeneral.Controls.Add(Me.cboincidenciaCalidadGeneral)
        Me.PanGeneral.Controls.Add(Me.lblId_PuntosGravedad)
        Me.PanGeneral.Controls.Add(Me.lblId_procesoCalidad)
        Me.PanGeneral.Controls.Add(Me.butAddId_incidenciaCalidadGeneral)
        Me.PanGeneral.Controls.Add(Me.chbNecesitaSeguimiento)
        Me.PanGeneral.Controls.Add(Me.cboPuntosGravedad)
        Me.PanGeneral.Controls.Add(Me.cboprocesoCalidad)
        Me.PanGeneral.Controls.Add(Me.butVerId_incidenciaCalidadGeneral)
        Me.PanGeneral.Controls.Add(Me.lblNecesitaSeguimiento)
        Me.PanGeneral.Controls.Add(Me.butVerId_PuntosGravedad)
        Me.PanGeneral.Controls.Add(Me.butVerId_procesoCalidad)
        Me.PanGeneral.Controls.Add(Me.butAddId_PuntosGravedad)
        Me.PanGeneral.Controls.Add(Me.txtObservaciones)
        Me.PanGeneral.Controls.Add(Me.lblId_incidenciaCalidadGeneral)
        Me.PanGeneral.Controls.Add(Me.butAddId_procesoCalidad)
        Me.PanGeneral.Controls.Add(Me.lblId_PuntosFrecuencia)
        Me.PanGeneral.Controls.Add(Me.lblObservaciones)
        Me.PanGeneral.Controls.Add(Me.lblId_articulo)
        Me.PanGeneral.Controls.Add(Me.cboPuntosFrecuencia)
        Me.PanGeneral.Controls.Add(Me.butAddId_PuntosFrecuencia)
        Me.PanGeneral.Controls.Add(Me.cboarticulo)
        Me.PanGeneral.Controls.Add(Me.butVerId_PuntosFrecuencia)
        Me.PanGeneral.Location = New System.Drawing.Point(9, 4)
        Me.PanGeneral.Margin = New System.Windows.Forms.Padding(2)
        Me.PanGeneral.Name = "PanGeneral"
        Me.PanGeneral.Size = New System.Drawing.Size(819, 395)
        Me.PanGeneral.TabIndex = 0
        '
        'btnCleanArticulo
        '
        Me.btnCleanArticulo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCleanArticulo.FlatAppearance.BorderSize = 0
        Me.btnCleanArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCleanArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCleanArticulo.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnCleanArticulo.Location = New System.Drawing.Point(755, 69)
        Me.btnCleanArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCleanArticulo.Name = "btnCleanArticulo"
        Me.btnCleanArticulo.Size = New System.Drawing.Size(18, 21)
        Me.btnCleanArticulo.TabIndex = 36
        Me.btnCleanArticulo.TabStop = False
        '
        'btnVerEstados
        '
        Me.btnVerEstados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnVerEstados.FlatAppearance.BorderSize = 0
        Me.btnVerEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerEstados.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.btnVerEstados.Location = New System.Drawing.Point(562, 11)
        Me.btnVerEstados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnVerEstados.Name = "btnVerEstados"
        Me.btnVerEstados.Size = New System.Drawing.Size(18, 21)
        Me.btnVerEstados.TabIndex = 34
        Me.btnVerEstados.TabStop = False
        '
        'btnAddEstados
        '
        Me.btnAddEstados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddEstados.FlatAppearance.BorderSize = 0
        Me.btnAddEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddEstados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddEstados.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnAddEstados.Location = New System.Drawing.Point(584, 11)
        Me.btnAddEstados.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAddEstados.Name = "btnAddEstados"
        Me.btnAddEstados.Size = New System.Drawing.Size(18, 21)
        Me.btnAddEstados.TabIndex = 35
        Me.btnAddEstados.TabStop = False
        '
        'lEstado
        '
        Me.lEstado.AutoSize = True
        Me.lEstado.Location = New System.Drawing.Point(258, 15)
        Me.lEstado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lEstado.Name = "lEstado"
        Me.lEstado.Size = New System.Drawing.Size(40, 13)
        Me.lEstado.TabIndex = 33
        Me.lEstado.Text = "Estado"
        '
        'cboEstado
        '
        Me.cboEstado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEstado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.Location = New System.Drawing.Point(304, 10)
        Me.cboEstado.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(261, 23)
        Me.cboEstado.TabIndex = 32
        '
        'txtId
        '
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtId.Enabled = False
        Me.txtId.Location = New System.Drawing.Point(667, 13)
        Me.txtId.Margin = New System.Windows.Forms.Padding(2)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(126, 20)
        Me.txtId.TabIndex = 31
        '
        'lCodigo
        '
        Me.lCodigo.AutoSize = True
        Me.lCodigo.Location = New System.Drawing.Point(623, 15)
        Me.lCodigo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lCodigo.Name = "lCodigo"
        Me.lCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lCodigo.TabIndex = 30
        Me.lCodigo.Text = "Código"
        '
        'butHelpCriterios
        '
        Me.butHelpCriterios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butHelpCriterios.FlatAppearance.BorderSize = 0
        Me.butHelpCriterios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butHelpCriterios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butHelpCriterios.Image = Global.La_Andaluza.My.Resources.Resources.emblem_notice
        Me.butHelpCriterios.Location = New System.Drawing.Point(799, 99)
        Me.butHelpCriterios.Margin = New System.Windows.Forms.Padding(2)
        Me.butHelpCriterios.Name = "butHelpCriterios"
        Me.butHelpCriterios.Size = New System.Drawing.Size(18, 21)
        Me.butHelpCriterios.TabIndex = 13
        Me.butHelpCriterios.TabStop = False
        '
        'PanCriterios
        '
        Me.PanCriterios.BackColor = System.Drawing.SystemColors.Control
        Me.PanCriterios.Controls.Add(Me.TabControl2)
        Me.PanCriterios.Location = New System.Drawing.Point(22, 279)
        Me.PanCriterios.Margin = New System.Windows.Forms.Padding(2)
        Me.PanCriterios.Name = "PanCriterios"
        Me.PanCriterios.Size = New System.Drawing.Size(772, 114)
        Me.PanCriterios.TabIndex = 22
        Me.PanCriterios.Visible = False
        '
        'TabControl2
        '
        Me.TabControl2.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl2.Controls.Add(Me.TabPage1)
        Me.TabControl2.Controls.Add(Me.TabPage2)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(772, 114)
        Me.TabControl2.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.lblCriterioFrecuenciaBaja)
        Me.TabPage1.Controls.Add(Me.txtCriterioFrecuenciaAlta)
        Me.TabPage1.Controls.Add(Me.txtCriterioFrecuenciaBaja)
        Me.TabPage1.Controls.Add(Me.lblCriterioFrecuenciaAlta)
        Me.TabPage1.Controls.Add(Me.lblCriterioFrecuenciaMedia)
        Me.TabPage1.Controls.Add(Me.txtCriterioFrecuenciaMedia)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(764, 85)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Criterios de frecuencia"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'lblCriterioFrecuenciaBaja
        '
        Me.lblCriterioFrecuenciaBaja.Enabled = False
        Me.lblCriterioFrecuenciaBaja.Location = New System.Drawing.Point(4, 0)
        Me.lblCriterioFrecuenciaBaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaBaja.Name = "lblCriterioFrecuenciaBaja"
        Me.lblCriterioFrecuenciaBaja.Size = New System.Drawing.Size(40, 28)
        Me.lblCriterioFrecuenciaBaja.TabIndex = 0
        Me.lblCriterioFrecuenciaBaja.Text = "Baja"
        Me.lblCriterioFrecuenciaBaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCriterioFrecuenciaAlta
        '
        Me.txtCriterioFrecuenciaAlta.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaAlta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaAlta.Enabled = False
        Me.txtCriterioFrecuenciaAlta.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaAlta.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaAlta.EsUnicoID = 0
        Me.txtCriterioFrecuenciaAlta.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaAlta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaAlta.Location = New System.Drawing.Point(111, 59)
        Me.txtCriterioFrecuenciaAlta.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioFrecuenciaAlta.MaxLength = 3000
        Me.txtCriterioFrecuenciaAlta.Minimo = 0
        Me.txtCriterioFrecuenciaAlta.Modificado = False
        Me.txtCriterioFrecuenciaAlta.Multiline = True
        Me.txtCriterioFrecuenciaAlta.Name = "txtCriterioFrecuenciaAlta"
        Me.txtCriterioFrecuenciaAlta.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaAlta.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaAlta.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaAlta.Obligatorio = False
        Me.txtCriterioFrecuenciaAlta.ParametroID = 0
        Me.txtCriterioFrecuenciaAlta.Size = New System.Drawing.Size(651, 19)
        Me.txtCriterioFrecuenciaAlta.TabIndex = 5
        Me.txtCriterioFrecuenciaAlta.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaAlta.ValorMinimo = 0.0R
        '
        'txtCriterioFrecuenciaBaja
        '
        Me.txtCriterioFrecuenciaBaja.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaBaja.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaBaja.Enabled = False
        Me.txtCriterioFrecuenciaBaja.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaBaja.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaBaja.EsUnicoID = 0
        Me.txtCriterioFrecuenciaBaja.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaBaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaBaja.Location = New System.Drawing.Point(111, 2)
        Me.txtCriterioFrecuenciaBaja.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioFrecuenciaBaja.MaxLength = 3000
        Me.txtCriterioFrecuenciaBaja.Minimo = 0
        Me.txtCriterioFrecuenciaBaja.Modificado = False
        Me.txtCriterioFrecuenciaBaja.Multiline = True
        Me.txtCriterioFrecuenciaBaja.Name = "txtCriterioFrecuenciaBaja"
        Me.txtCriterioFrecuenciaBaja.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaBaja.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaBaja.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaBaja.Obligatorio = False
        Me.txtCriterioFrecuenciaBaja.ParametroID = 0
        Me.txtCriterioFrecuenciaBaja.Size = New System.Drawing.Size(651, 19)
        Me.txtCriterioFrecuenciaBaja.TabIndex = 1
        Me.txtCriterioFrecuenciaBaja.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaBaja.ValorMinimo = 0.0R
        '
        'lblCriterioFrecuenciaAlta
        '
        Me.lblCriterioFrecuenciaAlta.Enabled = False
        Me.lblCriterioFrecuenciaAlta.Location = New System.Drawing.Point(4, 57)
        Me.lblCriterioFrecuenciaAlta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaAlta.Name = "lblCriterioFrecuenciaAlta"
        Me.lblCriterioFrecuenciaAlta.Size = New System.Drawing.Size(40, 28)
        Me.lblCriterioFrecuenciaAlta.TabIndex = 4
        Me.lblCriterioFrecuenciaAlta.Text = "Alta"
        Me.lblCriterioFrecuenciaAlta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioFrecuenciaMedia
        '
        Me.lblCriterioFrecuenciaMedia.Enabled = False
        Me.lblCriterioFrecuenciaMedia.Location = New System.Drawing.Point(4, 28)
        Me.lblCriterioFrecuenciaMedia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioFrecuenciaMedia.Name = "lblCriterioFrecuenciaMedia"
        Me.lblCriterioFrecuenciaMedia.Size = New System.Drawing.Size(40, 28)
        Me.lblCriterioFrecuenciaMedia.TabIndex = 2
        Me.lblCriterioFrecuenciaMedia.Text = "Media"
        Me.lblCriterioFrecuenciaMedia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCriterioFrecuenciaMedia
        '
        Me.txtCriterioFrecuenciaMedia.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioFrecuenciaMedia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioFrecuenciaMedia.Enabled = False
        Me.txtCriterioFrecuenciaMedia.EsUnicoCampo = ""
        Me.txtCriterioFrecuenciaMedia.EsUnicoCampoID = ""
        Me.txtCriterioFrecuenciaMedia.EsUnicoID = 0
        Me.txtCriterioFrecuenciaMedia.EsUnicoTabla = ""
        Me.txtCriterioFrecuenciaMedia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioFrecuenciaMedia.Location = New System.Drawing.Point(111, 32)
        Me.txtCriterioFrecuenciaMedia.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioFrecuenciaMedia.MaxLength = 3000
        Me.txtCriterioFrecuenciaMedia.Minimo = 0
        Me.txtCriterioFrecuenciaMedia.Modificado = False
        Me.txtCriterioFrecuenciaMedia.Multiline = True
        Me.txtCriterioFrecuenciaMedia.Name = "txtCriterioFrecuenciaMedia"
        Me.txtCriterioFrecuenciaMedia.Numerico_EsNumerico = False
        Me.txtCriterioFrecuenciaMedia.Numerico_NumeroDoublees = 0
        Me.txtCriterioFrecuenciaMedia.Numerico_SeparadorMiles = False
        Me.txtCriterioFrecuenciaMedia.Obligatorio = False
        Me.txtCriterioFrecuenciaMedia.ParametroID = 0
        Me.txtCriterioFrecuenciaMedia.Size = New System.Drawing.Size(651, 19)
        Me.txtCriterioFrecuenciaMedia.TabIndex = 3
        Me.txtCriterioFrecuenciaMedia.ValorMaximo = 0.0R
        Me.txtCriterioFrecuenciaMedia.ValorMinimo = 0.0R
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.txtCriterioGravedadModerada)
        Me.TabPage2.Controls.Add(Me.lblCriterioGravedadModerada)
        Me.TabPage2.Controls.Add(Me.lblCriterioGravedadLeve)
        Me.TabPage2.Controls.Add(Me.txtCriterioGravedadGrave)
        Me.TabPage2.Controls.Add(Me.lblCriterioGravedadGrave)
        Me.TabPage2.Controls.Add(Me.txtCriterioGravedadLeve)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(764, 85)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Criterios de gravedad"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'txtCriterioGravedadModerada
        '
        Me.txtCriterioGravedadModerada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadModerada.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadModerada.Enabled = False
        Me.txtCriterioGravedadModerada.EsUnicoCampo = ""
        Me.txtCriterioGravedadModerada.EsUnicoCampoID = ""
        Me.txtCriterioGravedadModerada.EsUnicoID = 0
        Me.txtCriterioGravedadModerada.EsUnicoTabla = ""
        Me.txtCriterioGravedadModerada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadModerada.Location = New System.Drawing.Point(111, 30)
        Me.txtCriterioGravedadModerada.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioGravedadModerada.MaxLength = 3000
        Me.txtCriterioGravedadModerada.Minimo = 0
        Me.txtCriterioGravedadModerada.Modificado = False
        Me.txtCriterioGravedadModerada.Multiline = True
        Me.txtCriterioGravedadModerada.Name = "txtCriterioGravedadModerada"
        Me.txtCriterioGravedadModerada.Numerico_EsNumerico = False
        Me.txtCriterioGravedadModerada.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadModerada.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadModerada.Obligatorio = False
        Me.txtCriterioGravedadModerada.ParametroID = 0
        Me.txtCriterioGravedadModerada.Size = New System.Drawing.Size(654, 19)
        Me.txtCriterioGravedadModerada.TabIndex = 9
        Me.txtCriterioGravedadModerada.ValorMaximo = 0.0R
        Me.txtCriterioGravedadModerada.ValorMinimo = 0.0R
        '
        'lblCriterioGravedadModerada
        '
        Me.lblCriterioGravedadModerada.Enabled = False
        Me.lblCriterioGravedadModerada.Location = New System.Drawing.Point(-1, 28)
        Me.lblCriterioGravedadModerada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadModerada.Name = "lblCriterioGravedadModerada"
        Me.lblCriterioGravedadModerada.Size = New System.Drawing.Size(62, 28)
        Me.lblCriterioGravedadModerada.TabIndex = 8
        Me.lblCriterioGravedadModerada.Text = "Moderada"
        Me.lblCriterioGravedadModerada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCriterioGravedadLeve
        '
        Me.lblCriterioGravedadLeve.Enabled = False
        Me.lblCriterioGravedadLeve.Location = New System.Drawing.Point(-1, -1)
        Me.lblCriterioGravedadLeve.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadLeve.Name = "lblCriterioGravedadLeve"
        Me.lblCriterioGravedadLeve.Size = New System.Drawing.Size(62, 28)
        Me.lblCriterioGravedadLeve.TabIndex = 6
        Me.lblCriterioGravedadLeve.Text = "Leve"
        Me.lblCriterioGravedadLeve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCriterioGravedadGrave
        '
        Me.txtCriterioGravedadGrave.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadGrave.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadGrave.Enabled = False
        Me.txtCriterioGravedadGrave.EsUnicoCampo = ""
        Me.txtCriterioGravedadGrave.EsUnicoCampoID = ""
        Me.txtCriterioGravedadGrave.EsUnicoID = 0
        Me.txtCriterioGravedadGrave.EsUnicoTabla = ""
        Me.txtCriterioGravedadGrave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadGrave.Location = New System.Drawing.Point(111, 58)
        Me.txtCriterioGravedadGrave.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioGravedadGrave.MaxLength = 3000
        Me.txtCriterioGravedadGrave.Minimo = 0
        Me.txtCriterioGravedadGrave.Modificado = False
        Me.txtCriterioGravedadGrave.Multiline = True
        Me.txtCriterioGravedadGrave.Name = "txtCriterioGravedadGrave"
        Me.txtCriterioGravedadGrave.Numerico_EsNumerico = False
        Me.txtCriterioGravedadGrave.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadGrave.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadGrave.Obligatorio = False
        Me.txtCriterioGravedadGrave.ParametroID = 0
        Me.txtCriterioGravedadGrave.Size = New System.Drawing.Size(656, 19)
        Me.txtCriterioGravedadGrave.TabIndex = 11
        Me.txtCriterioGravedadGrave.ValorMaximo = 0.0R
        Me.txtCriterioGravedadGrave.ValorMinimo = 0.0R
        '
        'lblCriterioGravedadGrave
        '
        Me.lblCriterioGravedadGrave.Enabled = False
        Me.lblCriterioGravedadGrave.Location = New System.Drawing.Point(-1, 55)
        Me.lblCriterioGravedadGrave.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCriterioGravedadGrave.Name = "lblCriterioGravedadGrave"
        Me.lblCriterioGravedadGrave.Size = New System.Drawing.Size(62, 28)
        Me.lblCriterioGravedadGrave.TabIndex = 10
        Me.lblCriterioGravedadGrave.Text = "Grave"
        Me.lblCriterioGravedadGrave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCriterioGravedadLeve
        '
        Me.txtCriterioGravedadLeve.BackColor = System.Drawing.SystemColors.Window
        Me.txtCriterioGravedadLeve.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCriterioGravedadLeve.Enabled = False
        Me.txtCriterioGravedadLeve.EsUnicoCampo = ""
        Me.txtCriterioGravedadLeve.EsUnicoCampoID = ""
        Me.txtCriterioGravedadLeve.EsUnicoID = 0
        Me.txtCriterioGravedadLeve.EsUnicoTabla = ""
        Me.txtCriterioGravedadLeve.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCriterioGravedadLeve.Location = New System.Drawing.Point(111, 2)
        Me.txtCriterioGravedadLeve.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCriterioGravedadLeve.MaxLength = 3000
        Me.txtCriterioGravedadLeve.Minimo = 0
        Me.txtCriterioGravedadLeve.Modificado = False
        Me.txtCriterioGravedadLeve.Multiline = True
        Me.txtCriterioGravedadLeve.Name = "txtCriterioGravedadLeve"
        Me.txtCriterioGravedadLeve.Numerico_EsNumerico = False
        Me.txtCriterioGravedadLeve.Numerico_NumeroDoublees = 0
        Me.txtCriterioGravedadLeve.Numerico_SeparadorMiles = False
        Me.txtCriterioGravedadLeve.Obligatorio = False
        Me.txtCriterioGravedadLeve.ParametroID = 0
        Me.txtCriterioGravedadLeve.Size = New System.Drawing.Size(654, 19)
        Me.txtCriterioGravedadLeve.TabIndex = 7
        Me.txtCriterioGravedadLeve.ValorMaximo = 0.0R
        Me.txtCriterioGravedadLeve.ValorMinimo = 0.0R
        '
        'cboTipoArticulo
        '
        Me.cboTipoArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoArticulo.FormattingEnabled = True
        Me.cboTipoArticulo.Location = New System.Drawing.Point(136, 68)
        Me.cboTipoArticulo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTipoArticulo.Name = "cboTipoArticulo"
        Me.cboTipoArticulo.Size = New System.Drawing.Size(181, 21)
        Me.cboTipoArticulo.TabIndex = 7
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpOrigen)
        Me.TabControl1.Controls.Add(Me.tpCausas)
        Me.TabControl1.Controls.Add(Me.tpAccionesInmediatas)
        Me.TabControl1.Controls.Add(Me.tpAccionesCorrectivas)
        Me.TabControl1.Controls.Add(Me.tpAccionesPreventivas)
        Me.TabControl1.Controls.Add(Me.tpIncidenciasenvasados)
        Me.TabControl1.Controls.Add(Me.tpSeguimiento)
        Me.TabControl1.Controls.Add(Me.tpAlmacenNC)
        Me.TabControl1.Controls.Add(Me.tpGastos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(838, 267)
        Me.TabControl1.TabIndex = 0
        '
        'tpOrigen
        '
        Me.tpOrigen.Location = New System.Drawing.Point(4, 22)
        Me.tpOrigen.Margin = New System.Windows.Forms.Padding(2)
        Me.tpOrigen.Name = "tpOrigen"
        Me.tpOrigen.Size = New System.Drawing.Size(830, 241)
        Me.tpOrigen.TabIndex = 4
        Me.tpOrigen.Text = "Origenes"
        Me.tpOrigen.UseVisualStyleBackColor = True
        '
        'tpCausas
        '
        Me.tpCausas.Location = New System.Drawing.Point(4, 22)
        Me.tpCausas.Margin = New System.Windows.Forms.Padding(2)
        Me.tpCausas.Name = "tpCausas"
        Me.tpCausas.Size = New System.Drawing.Size(830, 241)
        Me.tpCausas.TabIndex = 3
        Me.tpCausas.Text = "Causas"
        Me.tpCausas.UseVisualStyleBackColor = True
        '
        'tpAccionesInmediatas
        '
        Me.tpAccionesInmediatas.Location = New System.Drawing.Point(4, 22)
        Me.tpAccionesInmediatas.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAccionesInmediatas.Name = "tpAccionesInmediatas"
        Me.tpAccionesInmediatas.Padding = New System.Windows.Forms.Padding(2)
        Me.tpAccionesInmediatas.Size = New System.Drawing.Size(830, 241)
        Me.tpAccionesInmediatas.TabIndex = 0
        Me.tpAccionesInmediatas.Text = "Acciones inmediatas"
        Me.tpAccionesInmediatas.UseVisualStyleBackColor = True
        '
        'tpAccionesCorrectivas
        '
        Me.tpAccionesCorrectivas.Location = New System.Drawing.Point(4, 22)
        Me.tpAccionesCorrectivas.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAccionesCorrectivas.Name = "tpAccionesCorrectivas"
        Me.tpAccionesCorrectivas.Size = New System.Drawing.Size(830, 241)
        Me.tpAccionesCorrectivas.TabIndex = 2
        Me.tpAccionesCorrectivas.Text = "Acciones correctivas"
        Me.tpAccionesCorrectivas.UseVisualStyleBackColor = True
        '
        'tpAccionesPreventivas
        '
        Me.tpAccionesPreventivas.Location = New System.Drawing.Point(4, 22)
        Me.tpAccionesPreventivas.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAccionesPreventivas.Name = "tpAccionesPreventivas"
        Me.tpAccionesPreventivas.Padding = New System.Windows.Forms.Padding(2)
        Me.tpAccionesPreventivas.Size = New System.Drawing.Size(830, 241)
        Me.tpAccionesPreventivas.TabIndex = 1
        Me.tpAccionesPreventivas.Text = "Acciones preventivas"
        Me.tpAccionesPreventivas.UseVisualStyleBackColor = True
        '
        'tpIncidenciasenvasados
        '
        Me.tpIncidenciasenvasados.Location = New System.Drawing.Point(4, 22)
        Me.tpIncidenciasenvasados.Name = "tpIncidenciasenvasados"
        Me.tpIncidenciasenvasados.Size = New System.Drawing.Size(830, 241)
        Me.tpIncidenciasenvasados.TabIndex = 5
        Me.tpIncidenciasenvasados.Text = "Envasados"
        Me.tpIncidenciasenvasados.UseVisualStyleBackColor = True
        '
        'tpSeguimiento
        '
        Me.tpSeguimiento.Location = New System.Drawing.Point(4, 22)
        Me.tpSeguimiento.Margin = New System.Windows.Forms.Padding(2)
        Me.tpSeguimiento.Name = "tpSeguimiento"
        Me.tpSeguimiento.Size = New System.Drawing.Size(830, 241)
        Me.tpSeguimiento.TabIndex = 6
        Me.tpSeguimiento.Text = "Seguimiento"
        Me.tpSeguimiento.UseVisualStyleBackColor = True
        '
        'tpAlmacenNC
        '
        Me.tpAlmacenNC.Location = New System.Drawing.Point(4, 22)
        Me.tpAlmacenNC.Margin = New System.Windows.Forms.Padding(2)
        Me.tpAlmacenNC.Name = "tpAlmacenNC"
        Me.tpAlmacenNC.Size = New System.Drawing.Size(830, 241)
        Me.tpAlmacenNC.TabIndex = 7
        Me.tpAlmacenNC.Text = "Almacen no conforme"
        Me.tpAlmacenNC.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.PanGeneral)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(838, 667)
        Me.SplitContainer1.SplitterDistance = 397
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1
        '
        'TimerCriterios
        '
        Me.TimerCriterios.Interval = 20000
        '
        'tpGastos
        '
        Me.tpGastos.Location = New System.Drawing.Point(4, 22)
        Me.tpGastos.Name = "tpGastos"
        Me.tpGastos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpGastos.Size = New System.Drawing.Size(830, 241)
        Me.tpGastos.TabIndex = 8
        Me.tpGastos.Text = "Gastos"
        Me.tpGastos.UseVisualStyleBackColor = True
        '
        'frmEntControlIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(838, 692)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanGeneral.ResumeLayout(False)
        Me.PanGeneral.PerformLayout()
        Me.PanCriterios.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents PanGeneral As System.Windows.Forms.Panel
   Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents tpSeguimiento As System.Windows.Forms.TabPage
    Private WithEvents tpAccionesInmediatas As System.Windows.Forms.TabPage
    Private WithEvents tpAccionesPreventivas As System.Windows.Forms.TabPage
    Private WithEvents tpAccionesCorrectivas As System.Windows.Forms.TabPage
    Private WithEvents tpCausas As System.Windows.Forms.TabPage
    Private WithEvents tpOrigen As System.Windows.Forms.TabPage
    Private WithEvents tpIncidenciasenvasados As System.Windows.Forms.TabPage
    Private WithEvents tpAlmacenNC As System.Windows.Forms.TabPage
    Private WithEvents TabControl2 As System.Windows.Forms.TabControl
    Private WithEvents lblCriterioFrecuenciaBaja As System.Windows.Forms.Label
    Private WithEvents txtCriterioFrecuenciaAlta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioFrecuenciaBaja As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCriterioFrecuenciaAlta As System.Windows.Forms.Label
    Private WithEvents lblCriterioFrecuenciaMedia As System.Windows.Forms.Label
    Private WithEvents txtCriterioFrecuenciaMedia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCriterioGravedadModerada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCriterioGravedadModerada As System.Windows.Forms.Label
    Private WithEvents lblCriterioGravedadLeve As System.Windows.Forms.Label
    Private WithEvents txtCriterioGravedadGrave As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCriterioGravedadGrave As System.Windows.Forms.Label
    Private WithEvents txtCriterioGravedadLeve As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents TimerCriterios As System.Windows.Forms.Timer
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents txtId As System.Windows.Forms.TextBox
    Private WithEvents lCodigo As System.Windows.Forms.Label
    Private WithEvents PanCriterios As System.Windows.Forms.Panel
    Private WithEvents lEstado As System.Windows.Forms.Label
    Private WithEvents cboEstado As System.Windows.Forms.ComboBox
    Private WithEvents btnVerEstados As System.Windows.Forms.Button
    Private WithEvents btnAddEstados As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents cboprocesoCalidad As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_procesoCalidad As System.Windows.Forms.Button
    Private WithEvents butAddId_procesoCalidad As System.Windows.Forms.Button
    Private WithEvents cboarticulo As System.Windows.Forms.ComboBox
    Private WithEvents cboincidenciaCalidadGeneral As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_incidenciaCalidadGeneral As System.Windows.Forms.Button
    Private WithEvents butAddId_incidenciaCalidadGeneral As System.Windows.Forms.Button
    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_empleado As System.Windows.Forms.Button
    Private WithEvents butAddid_empleado As System.Windows.Forms.Button
    Private WithEvents cboPuntosGravedad As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_PuntosGravedad As System.Windows.Forms.Button
    Private WithEvents butAddId_PuntosGravedad As System.Windows.Forms.Button
    Private WithEvents cboPuntosFrecuencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_PuntosFrecuencia As System.Windows.Forms.Button
    Private WithEvents butAddId_PuntosFrecuencia As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbNecesitaSeguimiento As System.Windows.Forms.CheckBox
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblId_procesoCalidad As System.Windows.Forms.Label
    Private WithEvents lblId_articulo As System.Windows.Forms.Label
    Private WithEvents lblId_incidenciaCalidadGeneral As System.Windows.Forms.Label
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
    Private WithEvents lblId_PuntosGravedad As System.Windows.Forms.Label
    Private WithEvents lblId_PuntosFrecuencia As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblNecesitaSeguimiento As System.Windows.Forms.Label
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents cboTipoArticulo As System.Windows.Forms.ComboBox
    Private WithEvents butHelpCriterios As System.Windows.Forms.Button
    Private WithEvents btnCleanArticulo As System.Windows.Forms.Button
    Private WithEvents tpGastos As System.Windows.Forms.TabPage
End Class
