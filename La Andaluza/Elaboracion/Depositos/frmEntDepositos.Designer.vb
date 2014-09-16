<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntDepositos
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
        Dim FechaCreacionLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label5 As System.Windows.Forms.Label
        Dim Label6 As System.Windows.Forms.Label
        Dim Label8 As System.Windows.Forms.Label
        Dim Label10 As System.Windows.Forms.Label
        Dim Label11 As System.Windows.Forms.Label
        Dim Label12 As System.Windows.Forms.Label
        Dim Label13 As System.Windows.Forms.Label
        Dim Label14 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim MaterialConstruccionIDLabel As System.Windows.Forms.Label
        Dim ListadoLabel As System.Windows.Forms.Label
        Dim Label7 As System.Windows.Forms.Label
        Dim Label9 As System.Windows.Forms.Label
        Dim Label15 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDepositos))
        Me.DtsDepositos = New La_Andaluza.dtsDepositos()
        Me.FechaCreacionDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.gbBota = New System.Windows.Forms.GroupBox()
        Me.NaveComboMAM = New System.Windows.Forms.ComboBox()
        Me.PiernaComboMAM = New System.Windows.Forms.ComboBox()
        Me.AlturaComboMAM = New System.Windows.Forms.ComboBox()
        Me.PosicionComboMAM = New System.Windows.Forms.ComboBox()
        Me.BotaTaponIDComboMAM = New System.Windows.Forms.ComboBox()
        Me.gbTransicuba = New System.Windows.Forms.GroupBox()
        Me.cbEstadoTransicuba = New System.Windows.Forms.CheckBox()
        Me.cdDescripcionTransicuba = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.gbTonel = New System.Windows.Forms.GroupBox()
        Me.txtContenidoHabitual = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cdDescripcionTonel = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.rbBota = New System.Windows.Forms.RadioButton()
        Me.rbTransicuba = New System.Windows.Forms.RadioButton()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.rbTonel = New System.Windows.Forms.RadioButton()
        Me.DoctoUbicacionfisicaCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.CapacidadCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.DepositoIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.MaterialConstruccionIDComboMAM = New System.Windows.Forms.ComboBox()
        Me.ListadoCheckBox = New System.Windows.Forms.CheckBox()
        Me.rbPiernas = New System.Windows.Forms.RadioButton()
        Me.gbPiernas = New System.Windows.Forms.GroupBox()
        Me.txtPiernasContenido = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPiernasDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cdCodigo = New System.Windows.Forms.TextBox()
        FechaCreacionLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Label6 = New System.Windows.Forms.Label()
        Label8 = New System.Windows.Forms.Label()
        Label10 = New System.Windows.Forms.Label()
        Label11 = New System.Windows.Forms.Label()
        Label12 = New System.Windows.Forms.Label()
        Label13 = New System.Windows.Forms.Label()
        Label14 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        MaterialConstruccionIDLabel = New System.Windows.Forms.Label()
        ListadoLabel = New System.Windows.Forms.Label()
        Label7 = New System.Windows.Forms.Label()
        Label9 = New System.Windows.Forms.Label()
        Label15 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsDepositos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbBota.SuspendLayout()
        Me.gbTransicuba.SuspendLayout()
        Me.gbTonel.SuspendLayout()
        Me.gbPiernas.SuspendLayout()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "Depositos"
        Me.GeneralBindingSource.DataSource = Me.DtsDepositos
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4)
        '
        'FechaCreacionLabel
        '
        FechaCreacionLabel.AutoSize = True
        FechaCreacionLabel.Location = New System.Drawing.Point(239, 75)
        FechaCreacionLabel.Name = "FechaCreacionLabel"
        FechaCreacionLabel.Size = New System.Drawing.Size(85, 13)
        FechaCreacionLabel.TabIndex = 1000000002
        FechaCreacionLabel.Text = "Fecha Creacion:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(24, 71)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(61, 13)
        Label2.TabIndex = 1000000017
        Label2.Text = "Capacidad:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(25, 101)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(118, 13)
        Label3.TabIndex = 1000000019
        Label3.Text = "docto Ubicacion Fisica:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(22, 36)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(43, 13)
        Label4.TabIndex = 1000000024
        Label4.Text = "Codigo:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(18, 53)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(66, 13)
        Label5.TabIndex = 1000000025
        Label5.Text = "Descripcion:"
        '
        'Label6
        '
        Label6.AutoSize = True
        Label6.Location = New System.Drawing.Point(22, 38)
        Label6.Name = "Label6"
        Label6.Size = New System.Drawing.Size(66, 13)
        Label6.TabIndex = 1000000029
        Label6.Text = "Descripcion:"
        '
        'Label8
        '
        Label8.AutoSize = True
        Label8.Location = New System.Drawing.Point(23, 70)
        Label8.Name = "Label8"
        Label8.Size = New System.Drawing.Size(40, 13)
        Label8.TabIndex = 1000000031
        Label8.Text = "Activa:"
        '
        'Label10
        '
        Label10.AutoSize = True
        Label10.Location = New System.Drawing.Point(20, 42)
        Label10.Name = "Label10"
        Label10.Size = New System.Drawing.Size(41, 13)
        Label10.TabIndex = 1000000035
        Label10.Text = "Tapon:"
        '
        'Label11
        '
        Label11.AutoSize = True
        Label11.Location = New System.Drawing.Point(24, 76)
        Label11.Name = "Label11"
        Label11.Size = New System.Drawing.Size(36, 13)
        Label11.TabIndex = 1000000040
        Label11.Text = "Nave:"
        '
        'Label12
        '
        Label12.AutoSize = True
        Label12.Location = New System.Drawing.Point(24, 110)
        Label12.Name = "Label12"
        Label12.Size = New System.Drawing.Size(40, 13)
        Label12.TabIndex = 1000000041
        Label12.Text = "Pierna:"
        '
        'Label13
        '
        Label13.AutoSize = True
        Label13.Location = New System.Drawing.Point(24, 144)
        Label13.Name = "Label13"
        Label13.Size = New System.Drawing.Size(37, 13)
        Label13.TabIndex = 1000000042
        Label13.Text = "Altura:"
        '
        'Label14
        '
        Label14.AutoSize = True
        Label14.Location = New System.Drawing.Point(24, 178)
        Label14.Name = "Label14"
        Label14.Size = New System.Drawing.Size(50, 13)
        Label14.TabIndex = 1000000043
        Label14.Text = "Posicion:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(18, 83)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(100, 13)
        Label1.TabIndex = 1000000027
        Label1.Text = "Contenido Habitual:"
        '
        'MaterialConstruccionIDLabel
        '
        MaterialConstruccionIDLabel.AutoSize = True
        MaterialConstruccionIDLabel.Location = New System.Drawing.Point(28, 127)
        MaterialConstruccionIDLabel.Name = "MaterialConstruccionIDLabel"
        MaterialConstruccionIDLabel.Size = New System.Drawing.Size(127, 13)
        MaterialConstruccionIDLabel.TabIndex = 1000000024
        MaterialConstruccionIDLabel.Text = "Material de Construccion:"
        '
        'ListadoLabel
        '
        ListadoLabel.AutoSize = True
        ListadoLabel.Location = New System.Drawing.Point(237, 45)
        ListadoLabel.Name = "ListadoLabel"
        ListadoLabel.Size = New System.Drawing.Size(44, 13)
        ListadoLabel.TabIndex = 1000000025
        ListadoLabel.Text = "Listado:"
        '
        'Label7
        '
        Label7.AutoSize = True
        Label7.Location = New System.Drawing.Point(180, 71)
        Label7.Name = "Label7"
        Label7.Size = New System.Drawing.Size(32, 13)
        Label7.TabIndex = 1000000027
        Label7.Text = "Litros"
        '
        'Label9
        '
        Label9.AutoSize = True
        Label9.Location = New System.Drawing.Point(18, 83)
        Label9.Name = "Label9"
        Label9.Size = New System.Drawing.Size(100, 13)
        Label9.TabIndex = 1000000027
        Label9.Text = "Contenido Habitual:"
        '
        'Label15
        '
        Label15.AutoSize = True
        Label15.Location = New System.Drawing.Point(18, 53)
        Label15.Name = "Label15"
        Label15.Size = New System.Drawing.Size(66, 13)
        Label15.TabIndex = 1000000025
        Label15.Text = "Descripcion:"
        '
        'DtsDepositos
        '
        Me.DtsDepositos.DataSetName = "dtsDepositos"
        Me.DtsDepositos.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FechaCreacionDateTimePicker
        '
        Me.FechaCreacionDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "FechaCreacion", True))
        Me.FechaCreacionDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaCreacionDateTimePicker.Location = New System.Drawing.Point(333, 71)
        Me.FechaCreacionDateTimePicker.Name = "FechaCreacionDateTimePicker"
        Me.FechaCreacionDateTimePicker.Size = New System.Drawing.Size(82, 20)
        Me.FechaCreacionDateTimePicker.TabIndex = 1000000003
        '
        'gbBota
        '
        Me.gbBota.Controls.Add(Label14)
        Me.gbBota.Controls.Add(Label13)
        Me.gbBota.Controls.Add(Label12)
        Me.gbBota.Controls.Add(Label11)
        Me.gbBota.Controls.Add(Me.NaveComboMAM)
        Me.gbBota.Controls.Add(Me.PiernaComboMAM)
        Me.gbBota.Controls.Add(Me.AlturaComboMAM)
        Me.gbBota.Controls.Add(Me.PosicionComboMAM)
        Me.gbBota.Controls.Add(Label10)
        Me.gbBota.Controls.Add(Me.BotaTaponIDComboMAM)
        Me.gbBota.Location = New System.Drawing.Point(68, 206)
        Me.gbBota.Name = "gbBota"
        Me.gbBota.Size = New System.Drawing.Size(295, 216)
        Me.gbBota.TabIndex = 1000000017
        Me.gbBota.TabStop = False
        Me.gbBota.Text = "Bota"
        Me.gbBota.Visible = False
        '
        'NaveComboMAM
        '
        Me.NaveComboMAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.NaveComboMAM.FormattingEnabled = True
        Me.NaveComboMAM.Location = New System.Drawing.Point(89, 71)
        Me.NaveComboMAM.Name = "NaveComboMAM"
        Me.NaveComboMAM.Size = New System.Drawing.Size(82, 21)
        Me.NaveComboMAM.TabIndex = 1000000039
        '
        'PiernaComboMAM
        '
        Me.PiernaComboMAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PiernaComboMAM.FormattingEnabled = True
        Me.PiernaComboMAM.Location = New System.Drawing.Point(89, 105)
        Me.PiernaComboMAM.Name = "PiernaComboMAM"
        Me.PiernaComboMAM.Size = New System.Drawing.Size(82, 21)
        Me.PiernaComboMAM.TabIndex = 1000000038
        '
        'AlturaComboMAM
        '
        Me.AlturaComboMAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.AlturaComboMAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.AlturaComboMAM.FormattingEnabled = True
        Me.AlturaComboMAM.Location = New System.Drawing.Point(89, 139)
        Me.AlturaComboMAM.Name = "AlturaComboMAM"
        Me.AlturaComboMAM.Size = New System.Drawing.Size(82, 21)
        Me.AlturaComboMAM.TabIndex = 1000000037
        '
        'PosicionComboMAM
        '
        Me.PosicionComboMAM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.PosicionComboMAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.PosicionComboMAM.FormattingEnabled = True
        Me.PosicionComboMAM.Location = New System.Drawing.Point(89, 173)
        Me.PosicionComboMAM.Name = "PosicionComboMAM"
        Me.PosicionComboMAM.Size = New System.Drawing.Size(82, 21)
        Me.PosicionComboMAM.TabIndex = 1000000036
        '
        'BotaTaponIDComboMAM
        '
        Me.BotaTaponIDComboMAM.FormattingEnabled = True
        Me.BotaTaponIDComboMAM.Location = New System.Drawing.Point(89, 37)
        Me.BotaTaponIDComboMAM.Name = "BotaTaponIDComboMAM"
        Me.BotaTaponIDComboMAM.Size = New System.Drawing.Size(82, 21)
        Me.BotaTaponIDComboMAM.TabIndex = 1000000034
        '
        'gbTransicuba
        '
        Me.gbTransicuba.Controls.Add(Label8)
        Me.gbTransicuba.Controls.Add(Me.cbEstadoTransicuba)
        Me.gbTransicuba.Controls.Add(Label6)
        Me.gbTransicuba.Controls.Add(Me.cdDescripcionTransicuba)
        Me.gbTransicuba.Location = New System.Drawing.Point(66, 206)
        Me.gbTransicuba.Name = "gbTransicuba"
        Me.gbTransicuba.Size = New System.Drawing.Size(298, 132)
        Me.gbTransicuba.TabIndex = 1000000017
        Me.gbTransicuba.TabStop = False
        Me.gbTransicuba.Text = "Transicuba"
        Me.gbTransicuba.Visible = False
        '
        'cbEstadoTransicuba
        '
        Me.cbEstadoTransicuba.AutoSize = True
        Me.cbEstadoTransicuba.Location = New System.Drawing.Point(92, 69)
        Me.cbEstadoTransicuba.Name = "cbEstadoTransicuba"
        Me.cbEstadoTransicuba.Size = New System.Drawing.Size(15, 14)
        Me.cbEstadoTransicuba.TabIndex = 1000000030
        Me.cbEstadoTransicuba.UseVisualStyleBackColor = True
        '
        'cdDescripcionTransicuba
        '
        Me.cdDescripcionTransicuba.EsUnicoCampo = ""
        Me.cdDescripcionTransicuba.EsUnicoCampoID = ""
        Me.cdDescripcionTransicuba.EsUnicoID = 0
        Me.cdDescripcionTransicuba.EsUnicoTabla = ""
        Me.cdDescripcionTransicuba.Location = New System.Drawing.Point(92, 34)
        Me.cdDescripcionTransicuba.Minimo = 0
        Me.cdDescripcionTransicuba.Modificado = False
        Me.cdDescripcionTransicuba.Name = "cdDescripcionTransicuba"
        Me.cdDescripcionTransicuba.Numerico_EsNumerico = False
        Me.cdDescripcionTransicuba.Numerico_NumeroDoublees = 0
        Me.cdDescripcionTransicuba.Numerico_SeparadorMiles = False
        Me.cdDescripcionTransicuba.Obligatorio = False
        Me.cdDescripcionTransicuba.ParametroID = 0
        Me.cdDescripcionTransicuba.Size = New System.Drawing.Size(162, 20)
        Me.cdDescripcionTransicuba.TabIndex = 1000000026
        Me.cdDescripcionTransicuba.ValorMaximo = 0.0R
        Me.cdDescripcionTransicuba.ValorMinimo = 0.0R
        '
        'gbTonel
        '
        Me.gbTonel.Controls.Add(Label1)
        Me.gbTonel.Controls.Add(Me.txtContenidoHabitual)
        Me.gbTonel.Controls.Add(Label5)
        Me.gbTonel.Controls.Add(Me.cdDescripcionTonel)
        Me.gbTonel.Location = New System.Drawing.Point(66, 206)
        Me.gbTonel.Name = "gbTonel"
        Me.gbTonel.Size = New System.Drawing.Size(299, 132)
        Me.gbTonel.TabIndex = 1000000016
        Me.gbTonel.TabStop = False
        Me.gbTonel.Text = "Tonel"
        Me.gbTonel.Visible = False
        '
        'txtContenidoHabitual
        '
        Me.txtContenidoHabitual.EsUnicoCampo = ""
        Me.txtContenidoHabitual.EsUnicoCampoID = ""
        Me.txtContenidoHabitual.EsUnicoID = 0
        Me.txtContenidoHabitual.EsUnicoTabla = ""
        Me.txtContenidoHabitual.Location = New System.Drawing.Point(122, 80)
        Me.txtContenidoHabitual.Minimo = 0
        Me.txtContenidoHabitual.Modificado = False
        Me.txtContenidoHabitual.Name = "txtContenidoHabitual"
        Me.txtContenidoHabitual.Numerico_EsNumerico = False
        Me.txtContenidoHabitual.Numerico_NumeroDoublees = 0
        Me.txtContenidoHabitual.Numerico_SeparadorMiles = False
        Me.txtContenidoHabitual.Obligatorio = False
        Me.txtContenidoHabitual.ParametroID = 0
        Me.txtContenidoHabitual.Size = New System.Drawing.Size(162, 20)
        Me.txtContenidoHabitual.TabIndex = 1000000026
        Me.txtContenidoHabitual.ValorMaximo = 0.0R
        Me.txtContenidoHabitual.ValorMinimo = 0.0R
        '
        'cdDescripcionTonel
        '
        Me.cdDescripcionTonel.EsUnicoCampo = ""
        Me.cdDescripcionTonel.EsUnicoCampoID = ""
        Me.cdDescripcionTonel.EsUnicoID = 0
        Me.cdDescripcionTonel.EsUnicoTabla = ""
        Me.cdDescripcionTonel.Location = New System.Drawing.Point(122, 50)
        Me.cdDescripcionTonel.Minimo = 0
        Me.cdDescripcionTonel.Modificado = False
        Me.cdDescripcionTonel.Name = "cdDescripcionTonel"
        Me.cdDescripcionTonel.Numerico_EsNumerico = False
        Me.cdDescripcionTonel.Numerico_NumeroDoublees = 0
        Me.cdDescripcionTonel.Numerico_SeparadorMiles = False
        Me.cdDescripcionTonel.Obligatorio = False
        Me.cdDescripcionTonel.ParametroID = 0
        Me.cdDescripcionTonel.Size = New System.Drawing.Size(162, 20)
        Me.cdDescripcionTonel.TabIndex = 1000000024
        Me.cdDescripcionTonel.ValorMaximo = 0.0R
        Me.cdDescripcionTonel.ValorMinimo = 0.0R
        '
        'rbBota
        '
        Me.rbBota.AutoSize = True
        Me.rbBota.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbBota.Location = New System.Drawing.Point(359, 167)
        Me.rbBota.Name = "rbBota"
        Me.rbBota.Size = New System.Drawing.Size(46, 17)
        Me.rbBota.TabIndex = 1000000023
        Me.rbBota.Text = "Bota"
        Me.rbBota.UseVisualStyleBackColor = True
        '
        'rbTransicuba
        '
        Me.rbTransicuba.AutoSize = True
        Me.rbTransicuba.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTransicuba.Location = New System.Drawing.Point(167, 167)
        Me.rbTransicuba.Name = "rbTransicuba"
        Me.rbTransicuba.Size = New System.Drawing.Size(77, 17)
        Me.rbTransicuba.TabIndex = 1000000022
        Me.rbTransicuba.Text = "Transicuba"
        Me.rbTransicuba.UseVisualStyleBackColor = True
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(500, 92)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(33, 22)
        Me.butRuta.TabIndex = 1000000020
        Me.butRuta.UseVisualStyleBackColor = True
        '
        'rbTonel
        '
        Me.rbTonel.AutoSize = True
        Me.rbTonel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbTonel.Location = New System.Drawing.Point(78, 167)
        Me.rbTonel.Name = "rbTonel"
        Me.rbTonel.Size = New System.Drawing.Size(51, 17)
        Me.rbTonel.TabIndex = 1000000021
        Me.rbTonel.Text = "Tonel"
        Me.rbTonel.UseVisualStyleBackColor = True
        '
        'DoctoUbicacionfisicaCuadroDeTexto
        '
        Me.DoctoUbicacionfisicaCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DoctoUbicacionfisicaCuadroDeTexto.EsUnicoCampo = ""
        Me.DoctoUbicacionfisicaCuadroDeTexto.EsUnicoCampoID = ""
        Me.DoctoUbicacionfisicaCuadroDeTexto.EsUnicoID = 0
        Me.DoctoUbicacionfisicaCuadroDeTexto.EsUnicoTabla = ""
        Me.DoctoUbicacionfisicaCuadroDeTexto.Location = New System.Drawing.Point(152, 97)
        Me.DoctoUbicacionfisicaCuadroDeTexto.Minimo = 0
        Me.DoctoUbicacionfisicaCuadroDeTexto.Modificado = False
        Me.DoctoUbicacionfisicaCuadroDeTexto.Name = "DoctoUbicacionfisicaCuadroDeTexto"
        Me.DoctoUbicacionfisicaCuadroDeTexto.Numerico_EsNumerico = False
        Me.DoctoUbicacionfisicaCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.DoctoUbicacionfisicaCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.DoctoUbicacionfisicaCuadroDeTexto.Obligatorio = False
        Me.DoctoUbicacionfisicaCuadroDeTexto.ParametroID = 0
        Me.DoctoUbicacionfisicaCuadroDeTexto.Size = New System.Drawing.Size(342, 20)
        Me.DoctoUbicacionfisicaCuadroDeTexto.TabIndex = 1000000018
        Me.DoctoUbicacionfisicaCuadroDeTexto.ValorMaximo = 0.0R
        Me.DoctoUbicacionfisicaCuadroDeTexto.ValorMinimo = 0.0R
        '
        'CapacidadCuadroDeTexto
        '
        Me.CapacidadCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CapacidadCuadroDeTexto.EsUnicoCampo = ""
        Me.CapacidadCuadroDeTexto.EsUnicoCampoID = ""
        Me.CapacidadCuadroDeTexto.EsUnicoID = 0
        Me.CapacidadCuadroDeTexto.EsUnicoTabla = ""
        Me.CapacidadCuadroDeTexto.Location = New System.Drawing.Point(92, 67)
        Me.CapacidadCuadroDeTexto.Minimo = 0
        Me.CapacidadCuadroDeTexto.Modificado = False
        Me.CapacidadCuadroDeTexto.Name = "CapacidadCuadroDeTexto"
        Me.CapacidadCuadroDeTexto.Numerico_EsNumerico = True
        Me.CapacidadCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.CapacidadCuadroDeTexto.Numerico_SeparadorMiles = True
        Me.CapacidadCuadroDeTexto.Obligatorio = False
        Me.CapacidadCuadroDeTexto.ParametroID = 0
        Me.CapacidadCuadroDeTexto.Size = New System.Drawing.Size(82, 20)
        Me.CapacidadCuadroDeTexto.TabIndex = 1000000016
        Me.CapacidadCuadroDeTexto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.CapacidadCuadroDeTexto.ValorMaximo = 0.0R
        Me.CapacidadCuadroDeTexto.ValorMinimo = 0.0R
        '
        'DepositoIDCuadroDeTexto
        '
        Me.DepositoIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "DepositoID", True))
        Me.DepositoIDCuadroDeTexto.EsUnicoCampo = ""
        Me.DepositoIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.DepositoIDCuadroDeTexto.EsUnicoID = 0
        Me.DepositoIDCuadroDeTexto.EsUnicoTabla = ""
        Me.DepositoIDCuadroDeTexto.Font = New System.Drawing.Font("Microsoft Sans Serif", 5.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DepositoIDCuadroDeTexto.Location = New System.Drawing.Point(335, 74)
        Me.DepositoIDCuadroDeTexto.Minimo = 0
        Me.DepositoIDCuadroDeTexto.Modificado = False
        Me.DepositoIDCuadroDeTexto.Name = "DepositoIDCuadroDeTexto"
        Me.DepositoIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.DepositoIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.DepositoIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.DepositoIDCuadroDeTexto.Obligatorio = False
        Me.DepositoIDCuadroDeTexto.ParametroID = 0
        Me.DepositoIDCuadroDeTexto.Size = New System.Drawing.Size(16, 15)
        Me.DepositoIDCuadroDeTexto.TabIndex = 1000000015
        Me.DepositoIDCuadroDeTexto.ValorMaximo = 0.0R
        Me.DepositoIDCuadroDeTexto.ValorMinimo = 0.0R
        '
        'MaterialConstruccionIDComboMAM
        '
        Me.MaterialConstruccionIDComboMAM.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "MaterialConstruccionID", True))
        Me.MaterialConstruccionIDComboMAM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.MaterialConstruccionIDComboMAM.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.MaterialConstruccionIDComboMAM.FormattingEnabled = True
        Me.MaterialConstruccionIDComboMAM.Location = New System.Drawing.Point(164, 123)
        Me.MaterialConstruccionIDComboMAM.Name = "MaterialConstruccionIDComboMAM"
        Me.MaterialConstruccionIDComboMAM.Size = New System.Drawing.Size(200, 21)
        Me.MaterialConstruccionIDComboMAM.TabIndex = 1000000025
        '
        'ListadoCheckBox
        '
        Me.ListadoCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.GeneralBindingSource, "Listado", True))
        Me.ListadoCheckBox.Location = New System.Drawing.Point(290, 39)
        Me.ListadoCheckBox.Name = "ListadoCheckBox"
        Me.ListadoCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ListadoCheckBox.TabIndex = 1000000026
        '
        'rbPiernas
        '
        Me.rbPiernas.AutoSize = True
        Me.rbPiernas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbPiernas.Location = New System.Drawing.Point(277, 167)
        Me.rbPiernas.Name = "rbPiernas"
        Me.rbPiernas.Size = New System.Drawing.Size(59, 17)
        Me.rbPiernas.TabIndex = 1000000028
        Me.rbPiernas.Text = "Piernas"
        Me.rbPiernas.UseVisualStyleBackColor = True
        '
        'gbPiernas
        '
        Me.gbPiernas.Controls.Add(Label9)
        Me.gbPiernas.Controls.Add(Me.txtPiernasContenido)
        Me.gbPiernas.Controls.Add(Label15)
        Me.gbPiernas.Controls.Add(Me.txtPiernasDescripcion)
        Me.gbPiernas.Location = New System.Drawing.Point(70, 203)
        Me.gbPiernas.Name = "gbPiernas"
        Me.gbPiernas.Size = New System.Drawing.Size(299, 132)
        Me.gbPiernas.TabIndex = 1000000029
        Me.gbPiernas.TabStop = False
        Me.gbPiernas.Text = "Piernas"
        Me.gbPiernas.Visible = False
        '
        'txtPiernasContenido
        '
        Me.txtPiernasContenido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPiernasContenido.EsUnicoCampo = ""
        Me.txtPiernasContenido.EsUnicoCampoID = ""
        Me.txtPiernasContenido.EsUnicoID = 0
        Me.txtPiernasContenido.EsUnicoTabla = ""
        Me.txtPiernasContenido.Location = New System.Drawing.Point(122, 80)
        Me.txtPiernasContenido.Minimo = 0
        Me.txtPiernasContenido.Modificado = False
        Me.txtPiernasContenido.Name = "txtPiernasContenido"
        Me.txtPiernasContenido.Numerico_EsNumerico = False
        Me.txtPiernasContenido.Numerico_NumeroDoublees = 0
        Me.txtPiernasContenido.Numerico_SeparadorMiles = False
        Me.txtPiernasContenido.Obligatorio = False
        Me.txtPiernasContenido.ParametroID = 0
        Me.txtPiernasContenido.Size = New System.Drawing.Size(162, 20)
        Me.txtPiernasContenido.TabIndex = 1000000026
        Me.txtPiernasContenido.ValorMaximo = 0.0R
        Me.txtPiernasContenido.ValorMinimo = 0.0R
        '
        'txtPiernasDescripcion
        '
        Me.txtPiernasDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPiernasDescripcion.EsUnicoCampo = ""
        Me.txtPiernasDescripcion.EsUnicoCampoID = ""
        Me.txtPiernasDescripcion.EsUnicoID = 0
        Me.txtPiernasDescripcion.EsUnicoTabla = ""
        Me.txtPiernasDescripcion.Location = New System.Drawing.Point(122, 50)
        Me.txtPiernasDescripcion.Minimo = 0
        Me.txtPiernasDescripcion.Modificado = False
        Me.txtPiernasDescripcion.Name = "txtPiernasDescripcion"
        Me.txtPiernasDescripcion.Numerico_EsNumerico = False
        Me.txtPiernasDescripcion.Numerico_NumeroDoublees = 0
        Me.txtPiernasDescripcion.Numerico_SeparadorMiles = False
        Me.txtPiernasDescripcion.Obligatorio = False
        Me.txtPiernasDescripcion.ParametroID = 0
        Me.txtPiernasDescripcion.Size = New System.Drawing.Size(162, 20)
        Me.txtPiernasDescripcion.TabIndex = 1000000024
        Me.txtPiernasDescripcion.ValorMaximo = 0.0R
        Me.txtPiernasDescripcion.ValorMinimo = 0.0R
        '
        'cdCodigo
        '
        Me.cdCodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.cdCodigo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cdCodigo.Location = New System.Drawing.Point(92, 28)
        Me.cdCodigo.Name = "cdCodigo"
        Me.cdCodigo.Size = New System.Drawing.Size(139, 27)
        Me.cdCodigo.TabIndex = 1000000030
        Me.cdCodigo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'frmEntDepositos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(550, 451)
        Me.Controls.Add(Me.cdCodigo)
        Me.Controls.Add(Me.gbPiernas)
        Me.Controls.Add(Me.rbPiernas)
        Me.Controls.Add(Label7)
        Me.Controls.Add(ListadoLabel)
        Me.Controls.Add(Me.ListadoCheckBox)
        Me.Controls.Add(MaterialConstruccionIDLabel)
        Me.Controls.Add(Me.MaterialConstruccionIDComboMAM)
        Me.Controls.Add(Me.gbTonel)
        Me.Controls.Add(Me.gbBota)
        Me.Controls.Add(Label4)
        Me.Controls.Add(Me.rbBota)
        Me.Controls.Add(Me.rbTransicuba)
        Me.Controls.Add(FechaCreacionLabel)
        Me.Controls.Add(Me.butRuta)
        Me.Controls.Add(Me.FechaCreacionDateTimePicker)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Me.DepositoIDCuadroDeTexto)
        Me.Controls.Add(Me.rbTonel)
        Me.Controls.Add(Me.DoctoUbicacionfisicaCuadroDeTexto)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Me.CapacidadCuadroDeTexto)
        Me.Controls.Add(Me.gbTransicuba)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmEntDepositos"
        Me.Controls.SetChildIndex(Me.gbTransicuba, 0)
        Me.Controls.SetChildIndex(Me.CapacidadCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Label2, 0)
        Me.Controls.SetChildIndex(Me.DoctoUbicacionfisicaCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Me.rbTonel, 0)
        Me.Controls.SetChildIndex(Me.DepositoIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Label3, 0)
        Me.Controls.SetChildIndex(Me.FechaCreacionDateTimePicker, 0)
        Me.Controls.SetChildIndex(Me.butRuta, 0)
        Me.Controls.SetChildIndex(FechaCreacionLabel, 0)
        Me.Controls.SetChildIndex(Me.rbTransicuba, 0)
        Me.Controls.SetChildIndex(Me.rbBota, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Label4, 0)
        Me.Controls.SetChildIndex(Me.gbBota, 0)
        Me.Controls.SetChildIndex(Me.gbTonel, 0)
        Me.Controls.SetChildIndex(Me.MaterialConstruccionIDComboMAM, 0)
        Me.Controls.SetChildIndex(MaterialConstruccionIDLabel, 0)
        Me.Controls.SetChildIndex(Me.ListadoCheckBox, 0)
        Me.Controls.SetChildIndex(ListadoLabel, 0)
        Me.Controls.SetChildIndex(Label7, 0)
        Me.Controls.SetChildIndex(Me.rbPiernas, 0)
        Me.Controls.SetChildIndex(Me.gbPiernas, 0)
        Me.Controls.SetChildIndex(Me.cdCodigo, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsDepositos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbBota.ResumeLayout(False)
        Me.gbBota.PerformLayout()
        Me.gbTransicuba.ResumeLayout(False)
        Me.gbTransicuba.PerformLayout()
        Me.gbTonel.ResumeLayout(False)
        Me.gbTonel.PerformLayout()
        Me.gbPiernas.ResumeLayout(False)
        Me.gbPiernas.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents DtsDepositos As La_Andaluza.dtsDepositos
    Private WithEvents cdDescripcionTonel As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cdDescripcionTransicuba As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cbEstadoTransicuba As System.Windows.Forms.CheckBox
    Private WithEvents BotaTaponIDComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents NaveComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents PiernaComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents txtContenidoHabitual As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents FechaCreacionDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents CapacidadCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents DoctoUbicacionfisicaCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents rbBota As System.Windows.Forms.RadioButton
    Private WithEvents rbTransicuba As System.Windows.Forms.RadioButton
    Private WithEvents rbTonel As System.Windows.Forms.RadioButton
    Private WithEvents gbBota As System.Windows.Forms.GroupBox
    Private WithEvents gbTransicuba As System.Windows.Forms.GroupBox
    Private WithEvents gbTonel As System.Windows.Forms.GroupBox
    Private WithEvents PosicionComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents AlturaComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents DepositoIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents MaterialConstruccionIDComboMAM As System.Windows.Forms.ComboBox
    Private WithEvents ListadoCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents rbPiernas As System.Windows.Forms.RadioButton
    Private WithEvents gbPiernas As System.Windows.Forms.GroupBox
    Private WithEvents txtPiernasContenido As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPiernasDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cdCodigo As System.Windows.Forms.TextBox

End Class
