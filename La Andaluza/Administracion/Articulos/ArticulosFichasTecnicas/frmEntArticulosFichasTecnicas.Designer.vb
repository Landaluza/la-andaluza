<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosFichasTecnicas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosFichasTecnicas))
        Me.txtArticuloFichaTecnicaID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloID = New System.Windows.Forms.ComboBox()
        Me.cboProveedorID = New System.Windows.Forms.ComboBox()
        Me.cboAprobadorID = New System.Windows.Forms.ComboBox()
        Me.cboEstadoID = New System.Windows.Forms.ComboBox()
        Me.txtVersion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaAprobacion = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaObsoleta = New System.Windows.Forms.DateTimePicker()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCambiosAnterior = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPropuestasCambios = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtMotivoPasoObsoleta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloFichaTecnicaID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblAprobadorID = New System.Windows.Forms.Label()
        Me.lblEstadoID = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblFechaAprobacion = New System.Windows.Forms.Label()
        Me.lblFechaObsoleta = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblCambiosAnterior = New System.Windows.Forms.Label()
        Me.lblPropuestasCambios = New System.Windows.Forms.Label()
        Me.lblMotivoPasoObsoleta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.butRuta = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtArticuloFichaTecnicaID
        '
        Me.txtArticuloFichaTecnicaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloFichaTecnicaID.EsUnicoCampo = ""
        Me.txtArticuloFichaTecnicaID.EsUnicoCampoID = ""
        Me.txtArticuloFichaTecnicaID.EsUnicoID = 0
        Me.txtArticuloFichaTecnicaID.EsUnicoTabla = ""
        Me.txtArticuloFichaTecnicaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloFichaTecnicaID.Location = New System.Drawing.Point(236, 4)
        Me.txtArticuloFichaTecnicaID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArticuloFichaTecnicaID.MaxLength = 9
        Me.txtArticuloFichaTecnicaID.Minimo = 0
        Me.txtArticuloFichaTecnicaID.Modificado = False
        Me.txtArticuloFichaTecnicaID.Name = "txtArticuloFichaTecnicaID"
        Me.txtArticuloFichaTecnicaID.Numerico_EsNumerico = False
        Me.txtArticuloFichaTecnicaID.Numerico_NumeroDoublees = 0
        Me.txtArticuloFichaTecnicaID.Numerico_SeparadorMiles = False
        Me.txtArticuloFichaTecnicaID.Obligatorio = False
        Me.txtArticuloFichaTecnicaID.ParametroID = 0
        Me.txtArticuloFichaTecnicaID.Size = New System.Drawing.Size(73, 24)
        Me.txtArticuloFichaTecnicaID.TabIndex = 0
        Me.txtArticuloFichaTecnicaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloFichaTecnicaID.ValorMaximo = 0.0!
        Me.txtArticuloFichaTecnicaID.ValorMinimo = 0.0!
        Me.txtArticuloFichaTecnicaID.Visible = False
        '
        'cboArticuloID
        '
        Me.cboArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloID.Location = New System.Drawing.Point(236, 36)
        Me.cboArticuloID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloID.Name = "cboArticuloID"
        Me.cboArticuloID.Size = New System.Drawing.Size(657, 26)
        Me.cboArticuloID.TabIndex = 1
        '
        'cboProveedorID
        '
        Me.cboProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorID.Location = New System.Drawing.Point(236, 70)
        Me.cboProveedorID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboProveedorID.Name = "cboProveedorID"
        Me.cboProveedorID.Size = New System.Drawing.Size(657, 26)
        Me.cboProveedorID.TabIndex = 2
        '
        'cboAprobadorID
        '
        Me.cboAprobadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAprobadorID.Location = New System.Drawing.Point(236, 104)
        Me.cboAprobadorID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboAprobadorID.Name = "cboAprobadorID"
        Me.cboAprobadorID.Size = New System.Drawing.Size(424, 26)
        Me.cboAprobadorID.TabIndex = 3
        '
        'cboEstadoID
        '
        Me.cboEstadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstadoID.Location = New System.Drawing.Point(236, 138)
        Me.cboEstadoID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboEstadoID.Name = "cboEstadoID"
        Me.cboEstadoID.Size = New System.Drawing.Size(199, 26)
        Me.cboEstadoID.TabIndex = 4
        '
        'txtVersion
        '
        Me.txtVersion.BackColor = System.Drawing.SystemColors.Window
        Me.txtVersion.EsUnicoCampo = ""
        Me.txtVersion.EsUnicoCampoID = ""
        Me.txtVersion.EsUnicoID = 0
        Me.txtVersion.EsUnicoTabla = ""
        Me.txtVersion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVersion.Location = New System.Drawing.Point(236, 172)
        Me.txtVersion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtVersion.MaxLength = 9
        Me.txtVersion.Minimo = 0
        Me.txtVersion.Modificado = False
        Me.txtVersion.Name = "txtVersion"
        Me.txtVersion.Numerico_EsNumerico = False
        Me.txtVersion.Numerico_NumeroDoublees = 0
        Me.txtVersion.Numerico_SeparadorMiles = False
        Me.txtVersion.Obligatorio = False
        Me.txtVersion.ParametroID = 0
        Me.txtVersion.Size = New System.Drawing.Size(73, 24)
        Me.txtVersion.TabIndex = 5
        Me.txtVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVersion.ValorMaximo = 0.0!
        Me.txtVersion.ValorMinimo = 0.0!
        '
        'dtpFechaAprobacion
        '
        Me.dtpFechaAprobacion.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaAprobacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaAprobacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaAprobacion.Location = New System.Drawing.Point(236, 204)
        Me.dtpFechaAprobacion.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaAprobacion.Name = "dtpFechaAprobacion"
        Me.dtpFechaAprobacion.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaAprobacion.TabIndex = 6
        '
        'dtpFechaObsoleta
        '
        Me.dtpFechaObsoleta.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaObsoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaObsoleta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaObsoleta.Location = New System.Drawing.Point(236, 236)
        Me.dtpFechaObsoleta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaObsoleta.Name = "dtpFechaObsoleta"
        Me.dtpFechaObsoleta.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaObsoleta.TabIndex = 7
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(236, 268)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = True
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(1065, 24)
        Me.txtRuta.TabIndex = 8
        Me.txtRuta.ValorMaximo = 0.0!
        Me.txtRuta.ValorMinimo = 0.0!
        '
        'txtCambiosAnterior
        '
        Me.txtCambiosAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtCambiosAnterior.EsUnicoCampo = ""
        Me.txtCambiosAnterior.EsUnicoCampoID = ""
        Me.txtCambiosAnterior.EsUnicoID = 0
        Me.txtCambiosAnterior.EsUnicoTabla = ""
        Me.txtCambiosAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambiosAnterior.Location = New System.Drawing.Point(236, 306)
        Me.txtCambiosAnterior.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCambiosAnterior.MaxLength = 4000
        Me.txtCambiosAnterior.Minimo = 0
        Me.txtCambiosAnterior.Modificado = False
        Me.txtCambiosAnterior.Name = "txtCambiosAnterior"
        Me.txtCambiosAnterior.Numerico_EsNumerico = False
        Me.txtCambiosAnterior.Numerico_NumeroDoublees = 0
        Me.txtCambiosAnterior.Numerico_SeparadorMiles = False
        Me.txtCambiosAnterior.Obligatorio = False
        Me.txtCambiosAnterior.ParametroID = 0
        Me.txtCambiosAnterior.Size = New System.Drawing.Size(1065, 24)
        Me.txtCambiosAnterior.TabIndex = 9
        Me.txtCambiosAnterior.ValorMaximo = 0.0!
        Me.txtCambiosAnterior.ValorMinimo = 0.0!
        '
        'txtPropuestasCambios
        '
        Me.txtPropuestasCambios.BackColor = System.Drawing.SystemColors.Window
        Me.txtPropuestasCambios.EsUnicoCampo = ""
        Me.txtPropuestasCambios.EsUnicoCampoID = ""
        Me.txtPropuestasCambios.EsUnicoID = 0
        Me.txtPropuestasCambios.EsUnicoTabla = ""
        Me.txtPropuestasCambios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropuestasCambios.Location = New System.Drawing.Point(236, 338)
        Me.txtPropuestasCambios.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPropuestasCambios.MaxLength = 4000
        Me.txtPropuestasCambios.Minimo = 0
        Me.txtPropuestasCambios.Modificado = False
        Me.txtPropuestasCambios.Name = "txtPropuestasCambios"
        Me.txtPropuestasCambios.Numerico_EsNumerico = False
        Me.txtPropuestasCambios.Numerico_NumeroDoublees = 0
        Me.txtPropuestasCambios.Numerico_SeparadorMiles = False
        Me.txtPropuestasCambios.Obligatorio = False
        Me.txtPropuestasCambios.ParametroID = 0
        Me.txtPropuestasCambios.Size = New System.Drawing.Size(1065, 24)
        Me.txtPropuestasCambios.TabIndex = 10
        Me.txtPropuestasCambios.ValorMaximo = 0.0!
        Me.txtPropuestasCambios.ValorMinimo = 0.0!
        '
        'txtMotivoPasoObsoleta
        '
        Me.txtMotivoPasoObsoleta.BackColor = System.Drawing.SystemColors.Window
        Me.txtMotivoPasoObsoleta.EsUnicoCampo = ""
        Me.txtMotivoPasoObsoleta.EsUnicoCampoID = ""
        Me.txtMotivoPasoObsoleta.EsUnicoID = 0
        Me.txtMotivoPasoObsoleta.EsUnicoTabla = ""
        Me.txtMotivoPasoObsoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMotivoPasoObsoleta.Location = New System.Drawing.Point(236, 370)
        Me.txtMotivoPasoObsoleta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtMotivoPasoObsoleta.MaxLength = 4000
        Me.txtMotivoPasoObsoleta.Minimo = 0
        Me.txtMotivoPasoObsoleta.Modificado = False
        Me.txtMotivoPasoObsoleta.Name = "txtMotivoPasoObsoleta"
        Me.txtMotivoPasoObsoleta.Numerico_EsNumerico = False
        Me.txtMotivoPasoObsoleta.Numerico_NumeroDoublees = 0
        Me.txtMotivoPasoObsoleta.Numerico_SeparadorMiles = False
        Me.txtMotivoPasoObsoleta.Obligatorio = False
        Me.txtMotivoPasoObsoleta.ParametroID = 0
        Me.txtMotivoPasoObsoleta.Size = New System.Drawing.Size(1065, 24)
        Me.txtMotivoPasoObsoleta.TabIndex = 11
        Me.txtMotivoPasoObsoleta.ValorMaximo = 0.0!
        Me.txtMotivoPasoObsoleta.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(236, 402)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = True
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(1065, 24)
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblArticuloFichaTecnicaID
        '
        Me.lblArticuloFichaTecnicaID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloFichaTecnicaID.Location = New System.Drawing.Point(64, 0)
        Me.lblArticuloFichaTecnicaID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloFichaTecnicaID.Name = "lblArticuloFichaTecnicaID"
        Me.lblArticuloFichaTecnicaID.Size = New System.Drawing.Size(164, 26)
        Me.lblArticuloFichaTecnicaID.TabIndex = 0
        Me.lblArticuloFichaTecnicaID.Text = "ArticuloFichaTecnicaID"
        Me.lblArticuloFichaTecnicaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloFichaTecnicaID.Visible = False
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloID.Location = New System.Drawing.Point(64, 32)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(164, 26)
        Me.lblArticuloID.TabIndex = 1
        Me.lblArticuloID.Text = "ArticuloID"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProveedorID.Location = New System.Drawing.Point(64, 66)
        Me.lblProveedorID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(164, 26)
        Me.lblProveedorID.TabIndex = 2
        Me.lblProveedorID.Text = "ProveedorID"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAprobadorID
        '
        Me.lblAprobadorID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAprobadorID.Location = New System.Drawing.Point(64, 100)
        Me.lblAprobadorID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAprobadorID.Name = "lblAprobadorID"
        Me.lblAprobadorID.Size = New System.Drawing.Size(164, 26)
        Me.lblAprobadorID.TabIndex = 3
        Me.lblAprobadorID.Text = "AprobadorID"
        Me.lblAprobadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstadoID
        '
        Me.lblEstadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEstadoID.Location = New System.Drawing.Point(64, 134)
        Me.lblEstadoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEstadoID.Name = "lblEstadoID"
        Me.lblEstadoID.Size = New System.Drawing.Size(164, 26)
        Me.lblEstadoID.TabIndex = 4
        Me.lblEstadoID.Text = "EstadoID"
        Me.lblEstadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVersion
        '
        Me.lblVersion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVersion.Location = New System.Drawing.Point(64, 168)
        Me.lblVersion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(164, 26)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "Version"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaAprobacion
        '
        Me.lblFechaAprobacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaAprobacion.Location = New System.Drawing.Point(64, 200)
        Me.lblFechaAprobacion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaAprobacion.Name = "lblFechaAprobacion"
        Me.lblFechaAprobacion.Size = New System.Drawing.Size(164, 26)
        Me.lblFechaAprobacion.TabIndex = 6
        Me.lblFechaAprobacion.Text = "Fecha aprobacion"
        Me.lblFechaAprobacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaObsoleta
        '
        Me.lblFechaObsoleta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaObsoleta.Location = New System.Drawing.Point(64, 232)
        Me.lblFechaObsoleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaObsoleta.Name = "lblFechaObsoleta"
        Me.lblFechaObsoleta.Size = New System.Drawing.Size(164, 26)
        Me.lblFechaObsoleta.TabIndex = 7
        Me.lblFechaObsoleta.Text = "Fecha obsoleta"
        Me.lblFechaObsoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(64, 264)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(164, 26)
        Me.lblRuta.TabIndex = 8
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCambiosAnterior
        '
        Me.lblCambiosAnterior.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCambiosAnterior.Location = New System.Drawing.Point(64, 302)
        Me.lblCambiosAnterior.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCambiosAnterior.Name = "lblCambiosAnterior"
        Me.lblCambiosAnterior.Size = New System.Drawing.Size(164, 26)
        Me.lblCambiosAnterior.TabIndex = 9
        Me.lblCambiosAnterior.Text = "Cambios anterior"
        Me.lblCambiosAnterior.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPropuestasCambios
        '
        Me.lblPropuestasCambios.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPropuestasCambios.Location = New System.Drawing.Point(64, 334)
        Me.lblPropuestasCambios.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPropuestasCambios.Name = "lblPropuestasCambios"
        Me.lblPropuestasCambios.Size = New System.Drawing.Size(164, 26)
        Me.lblPropuestasCambios.TabIndex = 10
        Me.lblPropuestasCambios.Text = "Propuestas cambios"
        Me.lblPropuestasCambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMotivoPasoObsoleta
        '
        Me.lblMotivoPasoObsoleta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMotivoPasoObsoleta.Location = New System.Drawing.Point(64, 366)
        Me.lblMotivoPasoObsoleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMotivoPasoObsoleta.Name = "lblMotivoPasoObsoleta"
        Me.lblMotivoPasoObsoleta.Size = New System.Drawing.Size(164, 26)
        Me.lblMotivoPasoObsoleta.TabIndex = 11
        Me.lblMotivoPasoObsoleta.Text = "Motivo de paso a obsoleta"
        Me.lblMotivoPasoObsoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(64, 398)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(164, 26)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.Controls.Add(Me.lblArticuloFichaTecnicaID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloFichaTecnicaID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblProveedorID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.lblAprobadorID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboAprobadorID, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblEstadoID, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboEstadoID, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblVersion, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtVersion, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblFechaAprobacion, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaAprobacion, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblFechaObsoleta, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaObsoleta, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lblCambiosAnterior, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.txtCambiosAnterior, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lblPropuestasCambios, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtPropuestasCambios, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.lblMotivoPasoObsoleta, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.txtMotivoPasoObsoleta, 2, 11)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 12)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 12)
        Me.tlpMiddle.Controls.Add(Me.cboProveedorID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 8)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 14
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
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1385, 454)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'butRuta
        '
        Me.butRuta.Location = New System.Drawing.Point(1327, 268)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(44, 30)
        Me.butRuta.TabIndex = 1000000002
        Me.butRuta.Image = My.Resources.folder_magnify
        Me.butRuta.UseVisualStyleBackColor = True
        '
        '
        'frmEntArticulosFichasTecnicas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1385, 512)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(495, 533)
        Me.Name = "frmEntArticulosFichasTecnicas"
        Me.Text = "ArticulosFichasTecnicas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtArticuloFichaTecnicaID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloID As System.Windows.Forms.ComboBox
    Private WithEvents cboProveedorID As System.Windows.Forms.ComboBox
    Private WithEvents cboAprobadorID As System.Windows.Forms.ComboBox
    Private WithEvents cboEstadoID As System.Windows.Forms.ComboBox
    Private WithEvents txtVersion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaAprobacion As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaObsoleta As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCambiosAnterior As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPropuestasCambios As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtMotivoPasoObsoleta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloFichaTecnicaID As System.Windows.Forms.Label
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblAprobadorID As System.Windows.Forms.Label
    Private WithEvents lblEstadoID As System.Windows.Forms.Label
    Private WithEvents lblVersion As System.Windows.Forms.Label
    Private WithEvents lblFechaAprobacion As System.Windows.Forms.Label
    Private WithEvents lblFechaObsoleta As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblCambiosAnterior As System.Windows.Forms.Label
    Private WithEvents lblPropuestasCambios As System.Windows.Forms.Label
    Private WithEvents lblMotivoPasoObsoleta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents butRuta As System.Windows.Forms.Button
End Class
