<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEmpleados))
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPrimerApellido = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtSegundoApellido = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.txtDireccionDomicilio = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodigoPostal = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNIF = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNSS = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTelefonoFijo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTelefonoMovil = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTelefonoUrgencia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPersonaContactoUrgencia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEmail = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbContratoVigente = New System.Windows.Forms.CheckBox()
        Me.cbo_poblacion_nacimiento = New System.Windows.Forms.ComboBox()
        Me.butAddid_poblacion_nacimiento = New System.Windows.Forms.Button()
        Me.cbo_poblacion_domicilio = New System.Windows.Forms.ComboBox()
        Me.butAddid_poblacion_domicilio = New System.Windows.Forms.Button()
        Me.cboid_usuario = New System.Windows.Forms.ComboBox()
        Me.butAddid_usuario = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblFechaNacimiento = New System.Windows.Forms.Label()
        Me.lblDireccionDomicilio = New System.Windows.Forms.Label()
        Me.lblCodigoPostal = New System.Windows.Forms.Label()
        Me.lblNIF = New System.Windows.Forms.Label()
        Me.lblNSS = New System.Windows.Forms.Label()
        Me.lblTelefonoFijo = New System.Windows.Forms.Label()
        Me.lblTelefonoMovil = New System.Windows.Forms.Label()
        Me.lblTelefonoUrgencia = New System.Windows.Forms.Label()
        Me.lblPersonaContactoUrgencia = New System.Windows.Forms.Label()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblContratoVigente = New System.Windows.Forms.Label()
        Me.lblid_poblacion_nacimiento = New System.Windows.Forms.Label()
        Me.lblid_poblacion_domicilio = New System.Windows.Forms.Label()
        Me.lblid_usuario = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbo_provincia_domicilio = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbo_pais_domicilio = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_pais_domicilio = New System.Windows.Forms.Button()
        Me.btn_provincia_domicilio = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtCorreoEmpresa = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtExtension = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtMvEmpresa = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbo_provincia_nacimiento = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_pais_nacimiento = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnAddPais_nacimineto = New System.Windows.Forms.Button()
        Me.btnAddProvincia_nacimietno = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.gpUsuario = New System.Windows.Forms.GroupBox()
        Me.lVigente = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pbFoto = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpContratos = New System.Windows.Forms.TabPage()
        Me.tpCompetencias = New System.Windows.Forms.TabPage()
        Me.tpCostes = New System.Windows.Forms.TabPage()
        Me.btnModUsuario = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.gpUsuario.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.EsUnicoCampo = ""
        Me.txtNombre.EsUnicoCampoID = ""
        Me.txtNombre.EsUnicoID = 0
        Me.txtNombre.EsUnicoTabla = ""
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(116, 18)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(181, 21)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrimerApellido.EsUnicoCampo = ""
        Me.txtPrimerApellido.EsUnicoCampoID = ""
        Me.txtPrimerApellido.EsUnicoID = 0
        Me.txtPrimerApellido.EsUnicoTabla = ""
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(418, 17)
        Me.txtPrimerApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPrimerApellido.MaxLength = 200
        Me.txtPrimerApellido.Minimo = 0
        Me.txtPrimerApellido.Modificado = False
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Numerico_EsNumerico = False
        Me.txtPrimerApellido.Numerico_NumeroDoublees = 0
        Me.txtPrimerApellido.Numerico_SeparadorMiles = False
        Me.txtPrimerApellido.Obligatorio = False
        Me.txtPrimerApellido.ParametroID = 0
        Me.txtPrimerApellido.Size = New System.Drawing.Size(181, 21)
        Me.txtPrimerApellido.TabIndex = 1
        Me.txtPrimerApellido.ValorMaximo = 0.0R
        Me.txtPrimerApellido.ValorMinimo = 0.0R
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtSegundoApellido.EsUnicoCampo = ""
        Me.txtSegundoApellido.EsUnicoCampoID = ""
        Me.txtSegundoApellido.EsUnicoID = 0
        Me.txtSegundoApellido.EsUnicoTabla = ""
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(752, 18)
        Me.txtSegundoApellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSegundoApellido.MaxLength = 200
        Me.txtSegundoApellido.Minimo = 0
        Me.txtSegundoApellido.Modificado = False
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Numerico_EsNumerico = False
        Me.txtSegundoApellido.Numerico_NumeroDoublees = 0
        Me.txtSegundoApellido.Numerico_SeparadorMiles = False
        Me.txtSegundoApellido.Obligatorio = False
        Me.txtSegundoApellido.ParametroID = 0
        Me.txtSegundoApellido.Size = New System.Drawing.Size(181, 21)
        Me.txtSegundoApellido.TabIndex = 2
        Me.txtSegundoApellido.ValorMaximo = 0.0R
        Me.txtSegundoApellido.ValorMinimo = 0.0R
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaNacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(116, 42)
        Me.dtpFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaNacimiento.TabIndex = 3
        '
        'txtDireccionDomicilio
        '
        Me.txtDireccionDomicilio.BackColor = System.Drawing.SystemColors.Window
        Me.txtDireccionDomicilio.EsUnicoCampo = ""
        Me.txtDireccionDomicilio.EsUnicoCampoID = ""
        Me.txtDireccionDomicilio.EsUnicoID = 0
        Me.txtDireccionDomicilio.EsUnicoTabla = ""
        Me.txtDireccionDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDireccionDomicilio.Location = New System.Drawing.Point(116, 17)
        Me.txtDireccionDomicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDireccionDomicilio.MaxLength = 300
        Me.txtDireccionDomicilio.Minimo = 0
        Me.txtDireccionDomicilio.Modificado = False
        Me.txtDireccionDomicilio.Name = "txtDireccionDomicilio"
        Me.txtDireccionDomicilio.Numerico_EsNumerico = False
        Me.txtDireccionDomicilio.Numerico_NumeroDoublees = 0
        Me.txtDireccionDomicilio.Numerico_SeparadorMiles = False
        Me.txtDireccionDomicilio.Obligatorio = False
        Me.txtDireccionDomicilio.ParametroID = 0
        Me.txtDireccionDomicilio.Size = New System.Drawing.Size(377, 21)
        Me.txtDireccionDomicilio.TabIndex = 4
        Me.txtDireccionDomicilio.ValorMaximo = 0.0R
        Me.txtDireccionDomicilio.ValorMinimo = 0.0R
        '
        'txtCodigoPostal
        '
        Me.txtCodigoPostal.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoPostal.EsUnicoCampo = ""
        Me.txtCodigoPostal.EsUnicoCampoID = ""
        Me.txtCodigoPostal.EsUnicoID = 0
        Me.txtCodigoPostal.EsUnicoTabla = ""
        Me.txtCodigoPostal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoPostal.Location = New System.Drawing.Point(532, 16)
        Me.txtCodigoPostal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigoPostal.MaxLength = 5
        Me.txtCodigoPostal.Minimo = 0
        Me.txtCodigoPostal.Modificado = False
        Me.txtCodigoPostal.Name = "txtCodigoPostal"
        Me.txtCodigoPostal.Numerico_EsNumerico = False
        Me.txtCodigoPostal.Numerico_NumeroDoublees = 0
        Me.txtCodigoPostal.Numerico_SeparadorMiles = False
        Me.txtCodigoPostal.Obligatorio = False
        Me.txtCodigoPostal.ParametroID = 0
        Me.txtCodigoPostal.Size = New System.Drawing.Size(66, 21)
        Me.txtCodigoPostal.TabIndex = 5
        Me.txtCodigoPostal.ValorMaximo = 0.0R
        Me.txtCodigoPostal.ValorMinimo = 0.0R
        '
        'txtNIF
        '
        Me.txtNIF.BackColor = System.Drawing.SystemColors.Window
        Me.txtNIF.EsUnicoCampo = ""
        Me.txtNIF.EsUnicoCampoID = ""
        Me.txtNIF.EsUnicoID = 0
        Me.txtNIF.EsUnicoTabla = ""
        Me.txtNIF.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNIF.Location = New System.Drawing.Point(116, 67)
        Me.txtNIF.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNIF.MaxLength = 9
        Me.txtNIF.Minimo = 0
        Me.txtNIF.Modificado = False
        Me.txtNIF.Name = "txtNIF"
        Me.txtNIF.Numerico_EsNumerico = False
        Me.txtNIF.Numerico_NumeroDoublees = 0
        Me.txtNIF.Numerico_SeparadorMiles = False
        Me.txtNIF.Obligatorio = False
        Me.txtNIF.ParametroID = 0
        Me.txtNIF.Size = New System.Drawing.Size(181, 21)
        Me.txtNIF.TabIndex = 6
        Me.txtNIF.ValorMaximo = 0.0R
        Me.txtNIF.ValorMinimo = 0.0R
        '
        'txtNSS
        '
        Me.txtNSS.BackColor = System.Drawing.SystemColors.Window
        Me.txtNSS.EsUnicoCampo = ""
        Me.txtNSS.EsUnicoCampoID = ""
        Me.txtNSS.EsUnicoID = 0
        Me.txtNSS.EsUnicoTabla = ""
        Me.txtNSS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNSS.Location = New System.Drawing.Point(418, 66)
        Me.txtNSS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNSS.MaxLength = 40
        Me.txtNSS.Minimo = 0
        Me.txtNSS.Modificado = False
        Me.txtNSS.Name = "txtNSS"
        Me.txtNSS.Numerico_EsNumerico = False
        Me.txtNSS.Numerico_NumeroDoublees = 0
        Me.txtNSS.Numerico_SeparadorMiles = False
        Me.txtNSS.Obligatorio = False
        Me.txtNSS.ParametroID = 0
        Me.txtNSS.Size = New System.Drawing.Size(181, 21)
        Me.txtNSS.TabIndex = 7
        Me.txtNSS.ValorMaximo = 0.0R
        Me.txtNSS.ValorMinimo = 0.0R
        '
        'txtTelefonoFijo
        '
        Me.txtTelefonoFijo.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefonoFijo.EsUnicoCampo = ""
        Me.txtTelefonoFijo.EsUnicoCampoID = ""
        Me.txtTelefonoFijo.EsUnicoID = 0
        Me.txtTelefonoFijo.EsUnicoTabla = ""
        Me.txtTelefonoFijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoFijo.Location = New System.Drawing.Point(116, 17)
        Me.txtTelefonoFijo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefonoFijo.MaxLength = 9
        Me.txtTelefonoFijo.Minimo = 0
        Me.txtTelefonoFijo.Modificado = False
        Me.txtTelefonoFijo.Name = "txtTelefonoFijo"
        Me.txtTelefonoFijo.Numerico_EsNumerico = False
        Me.txtTelefonoFijo.Numerico_NumeroDoublees = 0
        Me.txtTelefonoFijo.Numerico_SeparadorMiles = False
        Me.txtTelefonoFijo.Obligatorio = False
        Me.txtTelefonoFijo.ParametroID = 0
        Me.txtTelefonoFijo.Size = New System.Drawing.Size(181, 21)
        Me.txtTelefonoFijo.TabIndex = 8
        Me.txtTelefonoFijo.ValorMaximo = 0.0R
        Me.txtTelefonoFijo.ValorMinimo = 0.0R
        '
        'txtTelefonoMovil
        '
        Me.txtTelefonoMovil.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefonoMovil.EsUnicoCampo = ""
        Me.txtTelefonoMovil.EsUnicoCampoID = ""
        Me.txtTelefonoMovil.EsUnicoID = 0
        Me.txtTelefonoMovil.EsUnicoTabla = ""
        Me.txtTelefonoMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoMovil.Location = New System.Drawing.Point(116, 41)
        Me.txtTelefonoMovil.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefonoMovil.MaxLength = 9
        Me.txtTelefonoMovil.Minimo = 0
        Me.txtTelefonoMovil.Modificado = False
        Me.txtTelefonoMovil.Name = "txtTelefonoMovil"
        Me.txtTelefonoMovil.Numerico_EsNumerico = False
        Me.txtTelefonoMovil.Numerico_NumeroDoublees = 0
        Me.txtTelefonoMovil.Numerico_SeparadorMiles = False
        Me.txtTelefonoMovil.Obligatorio = False
        Me.txtTelefonoMovil.ParametroID = 0
        Me.txtTelefonoMovil.Size = New System.Drawing.Size(181, 21)
        Me.txtTelefonoMovil.TabIndex = 9
        Me.txtTelefonoMovil.ValorMaximo = 0.0R
        Me.txtTelefonoMovil.ValorMinimo = 0.0R
        '
        'txtTelefonoUrgencia
        '
        Me.txtTelefonoUrgencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtTelefonoUrgencia.EsUnicoCampo = ""
        Me.txtTelefonoUrgencia.EsUnicoCampoID = ""
        Me.txtTelefonoUrgencia.EsUnicoID = 0
        Me.txtTelefonoUrgencia.EsUnicoTabla = ""
        Me.txtTelefonoUrgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTelefonoUrgencia.Location = New System.Drawing.Point(418, 15)
        Me.txtTelefonoUrgencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTelefonoUrgencia.MaxLength = 9
        Me.txtTelefonoUrgencia.Minimo = 0
        Me.txtTelefonoUrgencia.Modificado = False
        Me.txtTelefonoUrgencia.Name = "txtTelefonoUrgencia"
        Me.txtTelefonoUrgencia.Numerico_EsNumerico = False
        Me.txtTelefonoUrgencia.Numerico_NumeroDoublees = 0
        Me.txtTelefonoUrgencia.Numerico_SeparadorMiles = False
        Me.txtTelefonoUrgencia.Obligatorio = False
        Me.txtTelefonoUrgencia.ParametroID = 0
        Me.txtTelefonoUrgencia.Size = New System.Drawing.Size(181, 21)
        Me.txtTelefonoUrgencia.TabIndex = 10
        Me.txtTelefonoUrgencia.ValorMaximo = 0.0R
        Me.txtTelefonoUrgencia.ValorMinimo = 0.0R
        '
        'txtPersonaContactoUrgencia
        '
        Me.txtPersonaContactoUrgencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtPersonaContactoUrgencia.EsUnicoCampo = ""
        Me.txtPersonaContactoUrgencia.EsUnicoCampoID = ""
        Me.txtPersonaContactoUrgencia.EsUnicoID = 0
        Me.txtPersonaContactoUrgencia.EsUnicoTabla = ""
        Me.txtPersonaContactoUrgencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonaContactoUrgencia.Location = New System.Drawing.Point(418, 40)
        Me.txtPersonaContactoUrgencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPersonaContactoUrgencia.MaxLength = 200
        Me.txtPersonaContactoUrgencia.Minimo = 0
        Me.txtPersonaContactoUrgencia.Modificado = False
        Me.txtPersonaContactoUrgencia.Name = "txtPersonaContactoUrgencia"
        Me.txtPersonaContactoUrgencia.Numerico_EsNumerico = False
        Me.txtPersonaContactoUrgencia.Numerico_NumeroDoublees = 0
        Me.txtPersonaContactoUrgencia.Numerico_SeparadorMiles = False
        Me.txtPersonaContactoUrgencia.Obligatorio = False
        Me.txtPersonaContactoUrgencia.ParametroID = 0
        Me.txtPersonaContactoUrgencia.Size = New System.Drawing.Size(181, 21)
        Me.txtPersonaContactoUrgencia.TabIndex = 11
        Me.txtPersonaContactoUrgencia.ValorMaximo = 0.0R
        Me.txtPersonaContactoUrgencia.ValorMinimo = 0.0R
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmail.EsUnicoCampo = ""
        Me.txtEmail.EsUnicoCampoID = ""
        Me.txtEmail.EsUnicoID = 0
        Me.txtEmail.EsUnicoTabla = ""
        Me.txtEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.Location = New System.Drawing.Point(116, 66)
        Me.txtEmail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtEmail.MaxLength = 200
        Me.txtEmail.Minimo = 0
        Me.txtEmail.Modificado = False
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Numerico_EsNumerico = False
        Me.txtEmail.Numerico_NumeroDoublees = 0
        Me.txtEmail.Numerico_SeparadorMiles = False
        Me.txtEmail.Obligatorio = False
        Me.txtEmail.ParametroID = 0
        Me.txtEmail.Size = New System.Drawing.Size(394, 21)
        Me.txtEmail.TabIndex = 12
        Me.txtEmail.ValorMaximo = 0.0R
        Me.txtEmail.ValorMinimo = 0.0R
        '
        'chbContratoVigente
        '
        Me.chbContratoVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbContratoVigente.Enabled = False
        Me.chbContratoVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbContratoVigente.Location = New System.Drawing.Point(127, 374)
        Me.chbContratoVigente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbContratoVigente.Name = "chbContratoVigente"
        Me.chbContratoVigente.Size = New System.Drawing.Size(18, 20)
        Me.chbContratoVigente.TabIndex = 13
        Me.chbContratoVigente.UseVisualStyleBackColor = False
        '
        'cbo_poblacion_nacimiento
        '
        Me.cbo_poblacion_nacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_poblacion_nacimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_poblacion_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_poblacion_nacimiento.Location = New System.Drawing.Point(752, 16)
        Me.cbo_poblacion_nacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_poblacion_nacimiento.Name = "cbo_poblacion_nacimiento"
        Me.cbo_poblacion_nacimiento.Size = New System.Drawing.Size(181, 23)
        Me.cbo_poblacion_nacimiento.TabIndex = 14
        '
        'butAddid_poblacion_nacimiento
        '
        Me.butAddid_poblacion_nacimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_poblacion_nacimiento.FlatAppearance.BorderSize = 0
        Me.butAddid_poblacion_nacimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_poblacion_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_poblacion_nacimiento.Image = CType(resources.GetObject("butAddid_poblacion_nacimiento.Image"), System.Drawing.Image)
        Me.butAddid_poblacion_nacimiento.Location = New System.Drawing.Point(729, 17)
        Me.butAddid_poblacion_nacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_poblacion_nacimiento.Name = "butAddid_poblacion_nacimiento"
        Me.butAddid_poblacion_nacimiento.Size = New System.Drawing.Size(18, 20)
        Me.butAddid_poblacion_nacimiento.TabIndex = 16
        Me.butAddid_poblacion_nacimiento.TabStop = False
        '
        'cbo_poblacion_domicilio
        '
        Me.cbo_poblacion_domicilio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_poblacion_domicilio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_poblacion_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_poblacion_domicilio.Location = New System.Drawing.Point(752, 46)
        Me.cbo_poblacion_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_poblacion_domicilio.Name = "cbo_poblacion_domicilio"
        Me.cbo_poblacion_domicilio.Size = New System.Drawing.Size(181, 23)
        Me.cbo_poblacion_domicilio.TabIndex = 15
        '
        'butAddid_poblacion_domicilio
        '
        Me.butAddid_poblacion_domicilio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_poblacion_domicilio.FlatAppearance.BorderSize = 0
        Me.butAddid_poblacion_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_poblacion_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_poblacion_domicilio.Image = CType(resources.GetObject("butAddid_poblacion_domicilio.Image"), System.Drawing.Image)
        Me.butAddid_poblacion_domicilio.Location = New System.Drawing.Point(729, 45)
        Me.butAddid_poblacion_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_poblacion_domicilio.Name = "butAddid_poblacion_domicilio"
        Me.butAddid_poblacion_domicilio.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_poblacion_domicilio.TabIndex = 19
        Me.butAddid_poblacion_domicilio.TabStop = False
        '
        'cboid_usuario
        '
        Me.cboid_usuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_usuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_usuario.Location = New System.Drawing.Point(116, 23)
        Me.cboid_usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_usuario.Name = "cboid_usuario"
        Me.cboid_usuario.Size = New System.Drawing.Size(181, 23)
        Me.cboid_usuario.TabIndex = 16
        '
        'butAddid_usuario
        '
        Me.butAddid_usuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_usuario.FlatAppearance.BorderSize = 0
        Me.butAddid_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_usuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_usuario.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_usuario.Location = New System.Drawing.Point(94, 23)
        Me.butAddid_usuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_usuario.Name = "butAddid_usuario"
        Me.butAddid_usuario.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_usuario.TabIndex = 22
        Me.butAddid_usuario.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(11, 18)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 20)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.Location = New System.Drawing.Point(313, 17)
        Me.lblPrimerApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(90, 20)
        Me.lblPrimerApellido.TabIndex = 1
        Me.lblPrimerApellido.Text = "Primer apellido"
        Me.lblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.Location = New System.Drawing.Point(620, 18)
        Me.lblSegundoApellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(128, 20)
        Me.lblSegundoApellido.TabIndex = 2
        Me.lblSegundoApellido.Text = "Segundo apellido"
        Me.lblSegundoApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaNacimiento
        '
        Me.lblFechaNacimiento.Location = New System.Drawing.Point(11, 42)
        Me.lblFechaNacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaNacimiento.Name = "lblFechaNacimiento"
        Me.lblFechaNacimiento.Size = New System.Drawing.Size(100, 20)
        Me.lblFechaNacimiento.TabIndex = 3
        Me.lblFechaNacimiento.Text = "Fecha nacimiento"
        Me.lblFechaNacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDireccionDomicilio
        '
        Me.lblDireccionDomicilio.Location = New System.Drawing.Point(10, 17)
        Me.lblDireccionDomicilio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDireccionDomicilio.Name = "lblDireccionDomicilio"
        Me.lblDireccionDomicilio.Size = New System.Drawing.Size(60, 20)
        Me.lblDireccionDomicilio.TabIndex = 4
        Me.lblDireccionDomicilio.Text = "Dirección"
        Me.lblDireccionDomicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoPostal
        '
        Me.lblCodigoPostal.Location = New System.Drawing.Point(506, 16)
        Me.lblCodigoPostal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoPostal.Name = "lblCodigoPostal"
        Me.lblCodigoPostal.Size = New System.Drawing.Size(21, 20)
        Me.lblCodigoPostal.TabIndex = 5
        Me.lblCodigoPostal.Text = "CP"
        Me.lblCodigoPostal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNIF
        '
        Me.lblNIF.Location = New System.Drawing.Point(11, 67)
        Me.lblNIF.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNIF.Name = "lblNIF"
        Me.lblNIF.Size = New System.Drawing.Size(90, 20)
        Me.lblNIF.TabIndex = 6
        Me.lblNIF.Text = "NIF"
        Me.lblNIF.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNSS
        '
        Me.lblNSS.Location = New System.Drawing.Point(313, 67)
        Me.lblNSS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNSS.Name = "lblNSS"
        Me.lblNSS.Size = New System.Drawing.Size(90, 20)
        Me.lblNSS.TabIndex = 7
        Me.lblNSS.Text = "NSS"
        Me.lblNSS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefonoFijo
        '
        Me.lblTelefonoFijo.Location = New System.Drawing.Point(10, 17)
        Me.lblTelefonoFijo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoFijo.Name = "lblTelefonoFijo"
        Me.lblTelefonoFijo.Size = New System.Drawing.Size(84, 20)
        Me.lblTelefonoFijo.TabIndex = 8
        Me.lblTelefonoFijo.Text = "Tlf fijo"
        Me.lblTelefonoFijo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefonoMovil
        '
        Me.lblTelefonoMovil.Location = New System.Drawing.Point(10, 42)
        Me.lblTelefonoMovil.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoMovil.Name = "lblTelefonoMovil"
        Me.lblTelefonoMovil.Size = New System.Drawing.Size(90, 19)
        Me.lblTelefonoMovil.TabIndex = 9
        Me.lblTelefonoMovil.Text = "Tlf Movil"
        Me.lblTelefonoMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTelefonoUrgencia
        '
        Me.lblTelefonoUrgencia.Location = New System.Drawing.Point(315, 16)
        Me.lblTelefonoUrgencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTelefonoUrgencia.Name = "lblTelefonoUrgencia"
        Me.lblTelefonoUrgencia.Size = New System.Drawing.Size(98, 19)
        Me.lblTelefonoUrgencia.TabIndex = 10
        Me.lblTelefonoUrgencia.Text = "Tlf urgencias"
        Me.lblTelefonoUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPersonaContactoUrgencia
        '
        Me.lblPersonaContactoUrgencia.Location = New System.Drawing.Point(315, 41)
        Me.lblPersonaContactoUrgencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPersonaContactoUrgencia.Name = "lblPersonaContactoUrgencia"
        Me.lblPersonaContactoUrgencia.Size = New System.Drawing.Size(98, 18)
        Me.lblPersonaContactoUrgencia.TabIndex = 11
        Me.lblPersonaContactoUrgencia.Text = "Contacto urgencias"
        Me.lblPersonaContactoUrgencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmail
        '
        Me.lblEmail.Location = New System.Drawing.Point(11, 66)
        Me.lblEmail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(83, 20)
        Me.lblEmail.TabIndex = 12
        Me.lblEmail.Text = "Email"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblContratoVigente
        '
        Me.lblContratoVigente.Location = New System.Drawing.Point(9, 371)
        Me.lblContratoVigente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblContratoVigente.Name = "lblContratoVigente"
        Me.lblContratoVigente.Size = New System.Drawing.Size(90, 25)
        Me.lblContratoVigente.TabIndex = 13
        Me.lblContratoVigente.Text = "ContratoVigente"
        Me.lblContratoVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_poblacion_nacimiento
        '
        Me.lblid_poblacion_nacimiento.Location = New System.Drawing.Point(620, 17)
        Me.lblid_poblacion_nacimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_poblacion_nacimiento.Name = "lblid_poblacion_nacimiento"
        Me.lblid_poblacion_nacimiento.Size = New System.Drawing.Size(58, 20)
        Me.lblid_poblacion_nacimiento.TabIndex = 14
        Me.lblid_poblacion_nacimiento.Text = "Población"
        Me.lblid_poblacion_nacimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_poblacion_domicilio
        '
        Me.lblid_poblacion_domicilio.Location = New System.Drawing.Point(622, 46)
        Me.lblid_poblacion_domicilio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_poblacion_domicilio.Name = "lblid_poblacion_domicilio"
        Me.lblid_poblacion_domicilio.Size = New System.Drawing.Size(56, 21)
        Me.lblid_poblacion_domicilio.TabIndex = 17
        Me.lblid_poblacion_domicilio.Text = "Población"
        Me.lblid_poblacion_domicilio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_usuario
        '
        Me.lblid_usuario.Location = New System.Drawing.Point(11, 23)
        Me.lblid_usuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_usuario.Name = "lblid_usuario"
        Me.lblid_usuario.Size = New System.Drawing.Size(67, 21)
        Me.lblid_usuario.TabIndex = 20
        Me.lblid_usuario.Text = "Usuario"
        Me.lblid_usuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_provincia_domicilio)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbo_pais_domicilio)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btn_pais_domicilio)
        Me.GroupBox1.Controls.Add(Me.btn_provincia_domicilio)
        Me.GroupBox1.Controls.Add(Me.cbo_poblacion_domicilio)
        Me.GroupBox1.Controls.Add(Me.lblid_poblacion_domicilio)
        Me.GroupBox1.Controls.Add(Me.butAddid_poblacion_domicilio)
        Me.GroupBox1.Controls.Add(Me.txtDireccionDomicilio)
        Me.GroupBox1.Controls.Add(Me.txtCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.lblCodigoPostal)
        Me.GroupBox1.Controls.Add(Me.lblDireccionDomicilio)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 279)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(946, 81)
        Me.GroupBox1.TabIndex = 1000000001
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Domicilio"
        '
        'cbo_provincia_domicilio
        '
        Me.cbo_provincia_domicilio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_provincia_domicilio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_provincia_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_provincia_domicilio.Location = New System.Drawing.Point(418, 46)
        Me.cbo_provincia_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_provincia_domicilio.Name = "cbo_provincia_domicilio"
        Me.cbo_provincia_domicilio.Size = New System.Drawing.Size(180, 23)
        Me.cbo_provincia_domicilio.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(314, 46)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 25
        Me.Label2.Text = "Provincia"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_pais_domicilio
        '
        Me.cbo_pais_domicilio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_pais_domicilio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_pais_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_pais_domicilio.Location = New System.Drawing.Point(116, 46)
        Me.cbo_pais_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_pais_domicilio.Name = "cbo_pais_domicilio"
        Me.cbo_pais_domicilio.Size = New System.Drawing.Size(181, 23)
        Me.cbo_pais_domicilio.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(11, 46)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 21)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "País"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btn_pais_domicilio
        '
        Me.btn_pais_domicilio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pais_domicilio.FlatAppearance.BorderSize = 0
        Me.btn_pais_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pais_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_pais_domicilio.Image = CType(resources.GetObject("btn_pais_domicilio.Image"), System.Drawing.Image)
        Me.btn_pais_domicilio.Location = New System.Drawing.Point(94, 46)
        Me.btn_pais_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_pais_domicilio.Name = "btn_pais_domicilio"
        Me.btn_pais_domicilio.Size = New System.Drawing.Size(18, 20)
        Me.btn_pais_domicilio.TabIndex = 23
        Me.btn_pais_domicilio.TabStop = False
        '
        'btn_provincia_domicilio
        '
        Me.btn_provincia_domicilio.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_provincia_domicilio.FlatAppearance.BorderSize = 0
        Me.btn_provincia_domicilio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_provincia_domicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_provincia_domicilio.Image = CType(resources.GetObject("btn_provincia_domicilio.Image"), System.Drawing.Image)
        Me.btn_provincia_domicilio.Location = New System.Drawing.Point(395, 46)
        Me.btn_provincia_domicilio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btn_provincia_domicilio.Name = "btn_provincia_domicilio"
        Me.btn_provincia_domicilio.Size = New System.Drawing.Size(18, 20)
        Me.btn_provincia_domicilio.TabIndex = 27
        Me.btn_provincia_domicilio.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtCorreoEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtExtension)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtMvEmpresa)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtTelefonoFijo)
        Me.GroupBox2.Controls.Add(Me.lblTelefonoFijo)
        Me.GroupBox2.Controls.Add(Me.txtTelefonoMovil)
        Me.GroupBox2.Controls.Add(Me.lblTelefonoMovil)
        Me.GroupBox2.Controls.Add(Me.txtTelefonoUrgencia)
        Me.GroupBox2.Controls.Add(Me.lblTelefonoUrgencia)
        Me.GroupBox2.Controls.Add(Me.txtPersonaContactoUrgencia)
        Me.GroupBox2.Controls.Add(Me.lblPersonaContactoUrgencia)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.lblEmail)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 124)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(946, 95)
        Me.GroupBox2.TabIndex = 1000000002
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Contacto"
        '
        'txtCorreoEmpresa
        '
        Me.txtCorreoEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtCorreoEmpresa.EsUnicoCampo = ""
        Me.txtCorreoEmpresa.EsUnicoCampoID = ""
        Me.txtCorreoEmpresa.EsUnicoID = 0
        Me.txtCorreoEmpresa.EsUnicoTabla = ""
        Me.txtCorreoEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCorreoEmpresa.Location = New System.Drawing.Point(622, 66)
        Me.txtCorreoEmpresa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCorreoEmpresa.MaxLength = 9
        Me.txtCorreoEmpresa.Minimo = 0
        Me.txtCorreoEmpresa.Modificado = False
        Me.txtCorreoEmpresa.Name = "txtCorreoEmpresa"
        Me.txtCorreoEmpresa.Numerico_EsNumerico = False
        Me.txtCorreoEmpresa.Numerico_NumeroDoublees = 0
        Me.txtCorreoEmpresa.Numerico_SeparadorMiles = False
        Me.txtCorreoEmpresa.Obligatorio = False
        Me.txtCorreoEmpresa.ParametroID = 0
        Me.txtCorreoEmpresa.Size = New System.Drawing.Size(311, 21)
        Me.txtCorreoEmpresa.TabIndex = 18
        Me.txtCorreoEmpresa.ValorMaximo = 0.0R
        Me.txtCorreoEmpresa.ValorMinimo = 0.0R
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(532, 67)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Correo empresa"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtExtension
        '
        Me.txtExtension.BackColor = System.Drawing.SystemColors.Window
        Me.txtExtension.EsUnicoCampo = ""
        Me.txtExtension.EsUnicoCampoID = ""
        Me.txtExtension.EsUnicoID = 0
        Me.txtExtension.EsUnicoTabla = ""
        Me.txtExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtension.Location = New System.Drawing.Point(752, 40)
        Me.txtExtension.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtExtension.MaxLength = 9
        Me.txtExtension.Minimo = 0
        Me.txtExtension.Modificado = False
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Numerico_EsNumerico = False
        Me.txtExtension.Numerico_NumeroDoublees = 0
        Me.txtExtension.Numerico_SeparadorMiles = False
        Me.txtExtension.Obligatorio = False
        Me.txtExtension.ParametroID = 0
        Me.txtExtension.Size = New System.Drawing.Size(181, 21)
        Me.txtExtension.TabIndex = 16
        Me.txtExtension.ValorMaximo = 0.0R
        Me.txtExtension.ValorMinimo = 0.0R
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(649, 41)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Extensión"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtMvEmpresa
        '
        Me.txtMvEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtMvEmpresa.EsUnicoCampo = ""
        Me.txtMvEmpresa.EsUnicoCampoID = ""
        Me.txtMvEmpresa.EsUnicoID = 0
        Me.txtMvEmpresa.EsUnicoTabla = ""
        Me.txtMvEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMvEmpresa.Location = New System.Drawing.Point(752, 15)
        Me.txtMvEmpresa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtMvEmpresa.MaxLength = 9
        Me.txtMvEmpresa.Minimo = 0
        Me.txtMvEmpresa.Modificado = False
        Me.txtMvEmpresa.Name = "txtMvEmpresa"
        Me.txtMvEmpresa.Numerico_EsNumerico = False
        Me.txtMvEmpresa.Numerico_NumeroDoublees = 0
        Me.txtMvEmpresa.Numerico_SeparadorMiles = False
        Me.txtMvEmpresa.Obligatorio = False
        Me.txtMvEmpresa.ParametroID = 0
        Me.txtMvEmpresa.Size = New System.Drawing.Size(181, 21)
        Me.txtMvEmpresa.TabIndex = 14
        Me.txtMvEmpresa.ValorMaximo = 0.0R
        Me.txtMvEmpresa.ValorMinimo = 0.0R
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(649, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(98, 19)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Movil empresa"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cbo_provincia_nacimiento)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.cbo_pais_nacimiento)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.btnAddPais_nacimineto)
        Me.GroupBox3.Controls.Add(Me.btnAddProvincia_nacimietno)
        Me.GroupBox3.Controls.Add(Me.cbo_poblacion_nacimiento)
        Me.GroupBox3.Controls.Add(Me.lblid_poblacion_nacimiento)
        Me.GroupBox3.Controls.Add(Me.butAddid_poblacion_nacimiento)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 223)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(946, 50)
        Me.GroupBox3.TabIndex = 1000000002
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lugar de nacimiento"
        '
        'cbo_provincia_nacimiento
        '
        Me.cbo_provincia_nacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_provincia_nacimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_provincia_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_provincia_nacimiento.Location = New System.Drawing.Point(418, 17)
        Me.cbo_provincia_nacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_provincia_nacimiento.Name = "cbo_provincia_nacimiento"
        Me.cbo_provincia_nacimiento.Size = New System.Drawing.Size(180, 23)
        Me.cbo_provincia_nacimiento.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(312, 19)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 19)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Provincia"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbo_pais_nacimiento
        '
        Me.cbo_pais_nacimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbo_pais_nacimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbo_pais_nacimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbo_pais_nacimiento.Location = New System.Drawing.Point(116, 19)
        Me.cbo_pais_nacimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbo_pais_nacimiento.Name = "cbo_pais_nacimiento"
        Me.cbo_pais_nacimiento.Size = New System.Drawing.Size(181, 23)
        Me.cbo_pais_nacimiento.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(11, 17)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(30, 21)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "País"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddPais_nacimineto
        '
        Me.btnAddPais_nacimineto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddPais_nacimineto.FlatAppearance.BorderSize = 0
        Me.btnAddPais_nacimineto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddPais_nacimineto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddPais_nacimineto.Image = CType(resources.GetObject("btnAddPais_nacimineto.Image"), System.Drawing.Image)
        Me.btnAddPais_nacimineto.Location = New System.Drawing.Point(94, 19)
        Me.btnAddPais_nacimineto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddPais_nacimineto.Name = "btnAddPais_nacimineto"
        Me.btnAddPais_nacimineto.Size = New System.Drawing.Size(18, 19)
        Me.btnAddPais_nacimineto.TabIndex = 23
        Me.btnAddPais_nacimineto.TabStop = False
        '
        'btnAddProvincia_nacimietno
        '
        Me.btnAddProvincia_nacimietno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddProvincia_nacimietno.FlatAppearance.BorderSize = 0
        Me.btnAddProvincia_nacimietno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddProvincia_nacimietno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddProvincia_nacimietno.Image = CType(resources.GetObject("btnAddProvincia_nacimietno.Image"), System.Drawing.Image)
        Me.btnAddProvincia_nacimietno.Location = New System.Drawing.Point(395, 17)
        Me.btnAddProvincia_nacimietno.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAddProvincia_nacimietno.Name = "btnAddProvincia_nacimietno"
        Me.btnAddProvincia_nacimietno.Size = New System.Drawing.Size(18, 20)
        Me.btnAddProvincia_nacimietno.TabIndex = 27
        Me.btnAddProvincia_nacimietno.TabStop = False
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lblNombre)
        Me.GroupBox4.Controls.Add(Me.txtNSS)
        Me.GroupBox4.Controls.Add(Me.lblNSS)
        Me.GroupBox4.Controls.Add(Me.txtNIF)
        Me.GroupBox4.Controls.Add(Me.lblNIF)
        Me.GroupBox4.Controls.Add(Me.txtNombre)
        Me.GroupBox4.Controls.Add(Me.dtpFechaNacimiento)
        Me.GroupBox4.Controls.Add(Me.lblFechaNacimiento)
        Me.GroupBox4.Controls.Add(Me.lblPrimerApellido)
        Me.GroupBox4.Controls.Add(Me.txtSegundoApellido)
        Me.GroupBox4.Controls.Add(Me.lblSegundoApellido)
        Me.GroupBox4.Controls.Add(Me.txtPrimerApellido)
        Me.GroupBox4.Location = New System.Drawing.Point(11, 11)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox4.Size = New System.Drawing.Size(946, 107)
        Me.GroupBox4.TabIndex = 1000000003
        Me.GroupBox4.TabStop = False
        '
        'gpUsuario
        '
        Me.gpUsuario.Controls.Add(Me.btnModUsuario)
        Me.gpUsuario.Controls.Add(Me.lblid_usuario)
        Me.gpUsuario.Controls.Add(Me.cboid_usuario)
        Me.gpUsuario.Controls.Add(Me.butAddid_usuario)
        Me.gpUsuario.Location = New System.Drawing.Point(11, 398)
        Me.gpUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpUsuario.Name = "gpUsuario"
        Me.gpUsuario.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gpUsuario.Size = New System.Drawing.Size(946, 61)
        Me.gpUsuario.TabIndex = 1000000004
        Me.gpUsuario.TabStop = False
        '
        'lVigente
        '
        Me.lVigente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lVigente.Location = New System.Drawing.Point(156, 374)
        Me.lVigente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lVigente.Name = "lVigente"
        Me.lVigente.Size = New System.Drawing.Size(226, 20)
        Me.lVigente.TabIndex = 1000000005
        Me.lVigente.Text = "Fecha Finalizacion"
        Me.lVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lVigente.Visible = False
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1251, 775)
        Me.SplitContainer1.SplitterDistance = 493
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1000000006
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pbFoto)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(1009, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(242, 493)
        Me.Panel2.TabIndex = 1000000008
        '
        'pbFoto
        '
        Me.pbFoto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pbFoto.Location = New System.Drawing.Point(0, 0)
        Me.pbFoto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pbFoto.Name = "pbFoto"
        Me.pbFoto.Size = New System.Drawing.Size(234, 493)
        Me.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbFoto.TabIndex = 0
        Me.pbFoto.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(234, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(8, 493)
        Me.Panel3.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gpUsuario)
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.lVigente)
        Me.Panel1.Controls.Add(Me.lblContratoVigente)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Controls.Add(Me.GroupBox4)
        Me.Panel1.Controls.Add(Me.chbContratoVigente)
        Me.Panel1.Controls.Add(Me.GroupBox3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(974, 493)
        Me.Panel1.TabIndex = 1000000007
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpContratos)
        Me.TabControl1.Controls.Add(Me.tpCompetencias)
        Me.TabControl1.Controls.Add(Me.tpCostes)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1251, 279)
        Me.TabControl1.TabIndex = 0
        '
        'tpContratos
        '
        Me.tpContratos.Location = New System.Drawing.Point(4, 22)
        Me.tpContratos.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpContratos.Name = "tpContratos"
        Me.tpContratos.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpContratos.Size = New System.Drawing.Size(1243, 253)
        Me.tpContratos.TabIndex = 1
        Me.tpContratos.Text = "Contrataciones"
        Me.tpContratos.UseVisualStyleBackColor = True
        '
        'tpCompetencias
        '
        Me.tpCompetencias.Location = New System.Drawing.Point(4, 22)
        Me.tpCompetencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCompetencias.Name = "tpCompetencias"
        Me.tpCompetencias.Size = New System.Drawing.Size(1243, 254)
        Me.tpCompetencias.TabIndex = 2
        Me.tpCompetencias.Text = "Competencias"
        Me.tpCompetencias.UseVisualStyleBackColor = True
        '
        'tpCostes
        '
        Me.tpCostes.Location = New System.Drawing.Point(4, 22)
        Me.tpCostes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCostes.Name = "tpCostes"
        Me.tpCostes.Size = New System.Drawing.Size(1243, 254)
        Me.tpCostes.TabIndex = 3
        Me.tpCostes.Text = "Costes anuales"
        Me.tpCostes.UseVisualStyleBackColor = True
        '
        'btnModUsuario
        '
        Me.btnModUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModUsuario.FlatAppearance.BorderSize = 0
        Me.btnModUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnModUsuario.Image = Global.La_Andaluza.My.Resources.Resources.edit_table_cell
        Me.btnModUsuario.Location = New System.Drawing.Point(72, 23)
        Me.btnModUsuario.Margin = New System.Windows.Forms.Padding(2)
        Me.btnModUsuario.Name = "btnModUsuario"
        Me.btnModUsuario.Size = New System.Drawing.Size(18, 21)
        Me.btnModUsuario.TabIndex = 23
        Me.btnModUsuario.TabStop = False
        '
        'frmEntEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1251, 800)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(428, 517)
        Me.Name = "frmEntEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.gpUsuario.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.pbFoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents tpCostes As System.Windows.Forms.TabPage
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPrimerApellido As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSegundoApellido As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaNacimiento As System.Windows.Forms.DateTimePicker
    Private WithEvents txtDireccionDomicilio As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCodigoPostal As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNIF As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNSS As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTelefonoFijo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTelefonoMovil As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTelefonoUrgencia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPersonaContactoUrgencia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEmail As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbContratoVigente As System.Windows.Forms.CheckBox
    Private WithEvents cbo_poblacion_nacimiento As System.Windows.Forms.ComboBox
    Private WithEvents butAddid_poblacion_nacimiento As System.Windows.Forms.Button
    Private WithEvents cbo_poblacion_domicilio As System.Windows.Forms.ComboBox
    Private WithEvents butAddid_poblacion_domicilio As System.Windows.Forms.Button
    Private WithEvents cboid_usuario As System.Windows.Forms.ComboBox
    Private WithEvents butAddid_usuario As System.Windows.Forms.Button
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Private WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Private WithEvents lblFechaNacimiento As System.Windows.Forms.Label
    Private WithEvents lblDireccionDomicilio As System.Windows.Forms.Label
    Private WithEvents lblCodigoPostal As System.Windows.Forms.Label
    Private WithEvents lblNIF As System.Windows.Forms.Label
    Private WithEvents lblNSS As System.Windows.Forms.Label
    Private WithEvents lblTelefonoFijo As System.Windows.Forms.Label
    Private WithEvents lblTelefonoMovil As System.Windows.Forms.Label
    Private WithEvents lblTelefonoUrgencia As System.Windows.Forms.Label
    Private WithEvents lblPersonaContactoUrgencia As System.Windows.Forms.Label
    Private WithEvents lblEmail As System.Windows.Forms.Label
    Private WithEvents lblContratoVigente As System.Windows.Forms.Label
    Private WithEvents lblid_poblacion_nacimiento As System.Windows.Forms.Label
    Private WithEvents lblid_poblacion_domicilio As System.Windows.Forms.Label
    Private WithEvents lblid_usuario As System.Windows.Forms.Label
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents cbo_provincia_domicilio As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents cbo_pais_domicilio As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btn_pais_domicilio As System.Windows.Forms.Button
    Private WithEvents btn_provincia_domicilio As System.Windows.Forms.Button
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Private WithEvents cbo_provincia_nacimiento As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents cbo_pais_nacimiento As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnAddPais_nacimineto As System.Windows.Forms.Button
    Private WithEvents btnAddProvincia_nacimietno As System.Windows.Forms.Button
    Private WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Private WithEvents gpUsuario As System.Windows.Forms.GroupBox
    Private WithEvents lVigente As System.Windows.Forms.Label
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpContratos As System.Windows.Forms.TabPage
    Private WithEvents tpCompetencias As System.Windows.Forms.TabPage
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents pbFoto As System.Windows.Forms.PictureBox
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents txtCorreoEmpresa As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtExtension As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtMvEmpresa As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents btnModUsuario As System.Windows.Forms.Button
End Class
