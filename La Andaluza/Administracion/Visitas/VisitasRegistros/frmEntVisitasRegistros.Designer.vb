<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntVisitasRegistros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntVisitasRegistros))
        Me.txtVisitaRegistroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboVisitaTipoID = New System.Windows.Forms.ComboBox()
        Me.cboVisitaNombreID = New System.Windows.Forms.ComboBox()
        Me.butVerVisitaNombreID = New System.Windows.Forms.Button()
        Me.butAddVisitaNombreID = New System.Windows.Forms.Button()
        Me.cboVisitaMotivoID = New System.Windows.Forms.ComboBox()
        Me.butVerVisitaMotivoID = New System.Windows.Forms.Button()
        Me.butAddVisitaMotivoID = New System.Windows.Forms.Button()
        Me.cboEmpresaID = New System.Windows.Forms.ComboBox()
        Me.cboPersonaResponsableVisitaID = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraSalida = New System.Windows.Forms.DateTimePicker()
        Me.txtEmpresaNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblVisitaRegistroID = New System.Windows.Forms.Label()
        Me.lblVisitaTipoID = New System.Windows.Forms.Label()
        Me.lblVisitaNombreID = New System.Windows.Forms.Label()
        Me.lblVisitaMotivoID = New System.Windows.Forms.Label()
        Me.lblEmpresaID = New System.Windows.Forms.Label()
        Me.lblPersonaResponsableVisitaID = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHoraEntrada = New System.Windows.Forms.Label()
        Me.lblHoraSalida = New System.Windows.Forms.Label()
        Me.lblEmpresaNombre = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtVisitaRegistroID
        '
        Me.txtVisitaRegistroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtVisitaRegistroID.EsUnicoCampo = ""
        Me.txtVisitaRegistroID.EsUnicoCampoID = ""
        Me.txtVisitaRegistroID.EsUnicoID = 0
        Me.txtVisitaRegistroID.EsUnicoTabla = ""
        Me.txtVisitaRegistroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitaRegistroID.Location = New System.Drawing.Point(186, 3)
        Me.txtVisitaRegistroID.MaxLength = 9
        Me.txtVisitaRegistroID.Minimo = 0
        Me.txtVisitaRegistroID.Modificado = False
        Me.txtVisitaRegistroID.Name = "txtVisitaRegistroID"
        Me.txtVisitaRegistroID.Numerico_EsNumerico = False
        Me.txtVisitaRegistroID.Numerico_NumeroDoublees = 0
        Me.txtVisitaRegistroID.Numerico_SeparadorMiles = False
        Me.txtVisitaRegistroID.Obligatorio = True
        Me.txtVisitaRegistroID.ParametroID = 0
        Me.txtVisitaRegistroID.Size = New System.Drawing.Size(56, 21)
        Me.txtVisitaRegistroID.TabIndex = 0
        Me.txtVisitaRegistroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVisitaRegistroID.ValorMaximo = 0.0R
        Me.txtVisitaRegistroID.ValorMinimo = 0.0R
        Me.txtVisitaRegistroID.Visible = False
        '
        'cboVisitaTipoID
        '
        Me.cboVisitaTipoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVisitaTipoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVisitaTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVisitaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVisitaTipoID.Location = New System.Drawing.Point(186, 30)
        Me.cboVisitaTipoID.Name = "cboVisitaTipoID"
        Me.cboVisitaTipoID.Size = New System.Drawing.Size(200, 23)
        Me.cboVisitaTipoID.TabIndex = 1
        '
        'cboVisitaNombreID
        '
        Me.cboVisitaNombreID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVisitaNombreID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVisitaNombreID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVisitaNombreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVisitaNombreID.Location = New System.Drawing.Point(186, 59)
        Me.cboVisitaNombreID.Name = "cboVisitaNombreID"
        Me.cboVisitaNombreID.Size = New System.Drawing.Size(380, 23)
        Me.cboVisitaNombreID.TabIndex = 2
        '
        'butVerVisitaNombreID
        '
        Me.butVerVisitaNombreID.FlatAppearance.BorderSize = 0
        Me.butVerVisitaNombreID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVisitaNombreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVisitaNombreID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVisitaNombreID.Location = New System.Drawing.Point(572, 59)
        Me.butVerVisitaNombreID.Name = "butVerVisitaNombreID"
        Me.butVerVisitaNombreID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVisitaNombreID.TabIndex = 5
        Me.butVerVisitaNombreID.TabStop = False
        '
        'butAddVisitaNombreID
        '
        Me.butAddVisitaNombreID.FlatAppearance.BorderSize = 0
        Me.butAddVisitaNombreID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVisitaNombreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVisitaNombreID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVisitaNombreID.Location = New System.Drawing.Point(598, 59)
        Me.butAddVisitaNombreID.Name = "butAddVisitaNombreID"
        Me.butAddVisitaNombreID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVisitaNombreID.TabIndex = 6
        Me.butAddVisitaNombreID.TabStop = False
        '
        'cboVisitaMotivoID
        '
        Me.cboVisitaMotivoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVisitaMotivoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVisitaMotivoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVisitaMotivoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVisitaMotivoID.Location = New System.Drawing.Point(186, 88)
        Me.cboVisitaMotivoID.Name = "cboVisitaMotivoID"
        Me.cboVisitaMotivoID.Size = New System.Drawing.Size(380, 23)
        Me.cboVisitaMotivoID.TabIndex = 3
        '
        'butVerVisitaMotivoID
        '
        Me.butVerVisitaMotivoID.FlatAppearance.BorderSize = 0
        Me.butVerVisitaMotivoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVisitaMotivoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVisitaMotivoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVisitaMotivoID.Location = New System.Drawing.Point(572, 88)
        Me.butVerVisitaMotivoID.Name = "butVerVisitaMotivoID"
        Me.butVerVisitaMotivoID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVisitaMotivoID.TabIndex = 8
        Me.butVerVisitaMotivoID.TabStop = False
        '
        'butAddVisitaMotivoID
        '
        Me.butAddVisitaMotivoID.FlatAppearance.BorderSize = 0
        Me.butAddVisitaMotivoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVisitaMotivoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVisitaMotivoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVisitaMotivoID.Location = New System.Drawing.Point(598, 88)
        Me.butAddVisitaMotivoID.Name = "butAddVisitaMotivoID"
        Me.butAddVisitaMotivoID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVisitaMotivoID.TabIndex = 9
        Me.butAddVisitaMotivoID.TabStop = False
        '
        'cboEmpresaID
        '
        Me.cboEmpresaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmpresaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmpresaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpresaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresaID.Location = New System.Drawing.Point(186, 117)
        Me.cboEmpresaID.Name = "cboEmpresaID"
        Me.cboEmpresaID.Size = New System.Drawing.Size(380, 23)
        Me.cboEmpresaID.TabIndex = 4
        '
        'cboPersonaResponsableVisitaID
        '
        Me.cboPersonaResponsableVisitaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPersonaResponsableVisitaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonaResponsableVisitaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPersonaResponsableVisitaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonaResponsableVisitaID.Location = New System.Drawing.Point(186, 146)
        Me.cboPersonaResponsableVisitaID.Name = "cboPersonaResponsableVisitaID"
        Me.cboPersonaResponsableVisitaID.Size = New System.Drawing.Size(380, 23)
        Me.cboPersonaResponsableVisitaID.TabIndex = 5
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(186, 175)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 6
        '
        'dtpHoraEntrada
        '
        Me.dtpHoraEntrada.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraEntrada.CustomFormat = "HH:mm"
        Me.dtpHoraEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraEntrada.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraEntrada.Location = New System.Drawing.Point(186, 202)
        Me.dtpHoraEntrada.Name = "dtpHoraEntrada"
        Me.dtpHoraEntrada.ShowUpDown = True
        Me.dtpHoraEntrada.Size = New System.Drawing.Size(56, 21)
        Me.dtpHoraEntrada.TabIndex = 7
        '
        'dtpHoraSalida
        '
        Me.dtpHoraSalida.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraSalida.CustomFormat = "HH:mm"
        Me.dtpHoraSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraSalida.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraSalida.Location = New System.Drawing.Point(186, 229)
        Me.dtpHoraSalida.Name = "dtpHoraSalida"
        Me.dtpHoraSalida.ShowUpDown = True
        Me.dtpHoraSalida.Size = New System.Drawing.Size(56, 21)
        Me.dtpHoraSalida.TabIndex = 8
        '
        'txtEmpresaNombre
        '
        Me.txtEmpresaNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpresaNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmpresaNombre.EsUnicoCampo = ""
        Me.txtEmpresaNombre.EsUnicoCampoID = ""
        Me.txtEmpresaNombre.EsUnicoID = 0
        Me.txtEmpresaNombre.EsUnicoTabla = ""
        Me.txtEmpresaNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpresaNombre.Location = New System.Drawing.Point(186, 283)
        Me.txtEmpresaNombre.MaxLength = 4000
        Me.txtEmpresaNombre.Minimo = 0
        Me.txtEmpresaNombre.Modificado = False
        Me.txtEmpresaNombre.Name = "txtEmpresaNombre"
        Me.txtEmpresaNombre.Numerico_EsNumerico = False
        Me.txtEmpresaNombre.Numerico_NumeroDoublees = 0
        Me.txtEmpresaNombre.Numerico_SeparadorMiles = False
        Me.txtEmpresaNombre.Obligatorio = False
        Me.txtEmpresaNombre.ParametroID = 0
        Me.txtEmpresaNombre.Size = New System.Drawing.Size(380, 21)
        Me.txtEmpresaNombre.TabIndex = 9
        Me.txtEmpresaNombre.ValorMaximo = 0.0R
        Me.txtEmpresaNombre.ValorMinimo = 0.0R
        Me.txtEmpresaNombre.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(186, 256)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(380, 21)
        Me.txtObservaciones.TabIndex = 10
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblVisitaRegistroID
        '
        Me.lblVisitaRegistroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVisitaRegistroID.Location = New System.Drawing.Point(23, 0)
        Me.lblVisitaRegistroID.Name = "lblVisitaRegistroID"
        Me.lblVisitaRegistroID.Size = New System.Drawing.Size(157, 21)
        Me.lblVisitaRegistroID.TabIndex = 0
        Me.lblVisitaRegistroID.Text = "VisitaRegistroID"
        Me.lblVisitaRegistroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVisitaRegistroID.Visible = False
        '
        'lblVisitaTipoID
        '
        Me.lblVisitaTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVisitaTipoID.Location = New System.Drawing.Point(23, 27)
        Me.lblVisitaTipoID.Name = "lblVisitaTipoID"
        Me.lblVisitaTipoID.Size = New System.Drawing.Size(157, 21)
        Me.lblVisitaTipoID.TabIndex = 1
        Me.lblVisitaTipoID.Text = "Tipo "
        Me.lblVisitaTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVisitaNombreID
        '
        Me.lblVisitaNombreID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVisitaNombreID.Location = New System.Drawing.Point(23, 56)
        Me.lblVisitaNombreID.Name = "lblVisitaNombreID"
        Me.lblVisitaNombreID.Size = New System.Drawing.Size(157, 21)
        Me.lblVisitaNombreID.TabIndex = 4
        Me.lblVisitaNombreID.Text = "Nombre"
        Me.lblVisitaNombreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVisitaMotivoID
        '
        Me.lblVisitaMotivoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVisitaMotivoID.Location = New System.Drawing.Point(23, 85)
        Me.lblVisitaMotivoID.Name = "lblVisitaMotivoID"
        Me.lblVisitaMotivoID.Size = New System.Drawing.Size(157, 21)
        Me.lblVisitaMotivoID.TabIndex = 7
        Me.lblVisitaMotivoID.Text = "Motivo"
        Me.lblVisitaMotivoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpresaID
        '
        Me.lblEmpresaID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEmpresaID.Location = New System.Drawing.Point(23, 114)
        Me.lblEmpresaID.Name = "lblEmpresaID"
        Me.lblEmpresaID.Size = New System.Drawing.Size(157, 21)
        Me.lblEmpresaID.TabIndex = 10
        Me.lblEmpresaID.Text = "Empresa"
        Me.lblEmpresaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPersonaResponsableVisitaID
        '
        Me.lblPersonaResponsableVisitaID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPersonaResponsableVisitaID.Location = New System.Drawing.Point(23, 143)
        Me.lblPersonaResponsableVisitaID.Name = "lblPersonaResponsableVisitaID"
        Me.lblPersonaResponsableVisitaID.Size = New System.Drawing.Size(157, 21)
        Me.lblPersonaResponsableVisitaID.TabIndex = 11
        Me.lblPersonaResponsableVisitaID.Text = "Responsable"
        Me.lblPersonaResponsableVisitaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(23, 172)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(157, 21)
        Me.lblFecha.TabIndex = 12
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraEntrada
        '
        Me.lblHoraEntrada.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHoraEntrada.Location = New System.Drawing.Point(23, 199)
        Me.lblHoraEntrada.Name = "lblHoraEntrada"
        Me.lblHoraEntrada.Size = New System.Drawing.Size(157, 21)
        Me.lblHoraEntrada.TabIndex = 13
        Me.lblHoraEntrada.Text = "Entrada"
        Me.lblHoraEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraSalida
        '
        Me.lblHoraSalida.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHoraSalida.Location = New System.Drawing.Point(23, 226)
        Me.lblHoraSalida.Name = "lblHoraSalida"
        Me.lblHoraSalida.Size = New System.Drawing.Size(157, 21)
        Me.lblHoraSalida.TabIndex = 14
        Me.lblHoraSalida.Text = "Salida"
        Me.lblHoraSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpresaNombre
        '
        Me.lblEmpresaNombre.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEmpresaNombre.Location = New System.Drawing.Point(23, 283)
        Me.lblEmpresaNombre.Name = "lblEmpresaNombre"
        Me.lblEmpresaNombre.Size = New System.Drawing.Size(157, 20)
        Me.lblEmpresaNombre.TabIndex = 15
        Me.lblEmpresaNombre.Text = "Empresa"
        Me.lblEmpresaNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEmpresaNombre.Visible = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 253)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(157, 21)
        Me.lblObservaciones.TabIndex = 16
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMiddle.Controls.Add(Me.lblVisitaRegistroID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtVisitaRegistroID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblVisitaTipoID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.lblEmpresaNombre, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.txtEmpresaNombre, 2, 11)
        Me.tlpMiddle.Controls.Add(Me.cboVisitaTipoID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblVisitaNombreID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboVisitaNombreID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerVisitaNombreID, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddVisitaNombreID, 4, 2)
        Me.tlpMiddle.Controls.Add(Me.lblVisitaMotivoID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboVisitaMotivoID, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerVisitaMotivoID, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddVisitaMotivoID, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblEmpresaID, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboEmpresaID, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblPersonaResponsableVisitaID, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.cboPersonaResponsableVisitaID, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblHoraEntrada, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraEntrada, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblHoraSalida, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraSalida, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 10)
        Me.tlpMiddle.Location = New System.Drawing.Point(20, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 12
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
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(663, 307)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntVisitasRegistros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(693, 387)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntVisitasRegistros"
        Me.Text = "VisitasRegistros"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtVisitaRegistroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboVisitaTipoID As System.Windows.Forms.ComboBox
    Private WithEvents cboVisitaNombreID As System.Windows.Forms.ComboBox
    Private WithEvents butVerVisitaNombreID As System.Windows.Forms.Button
    Private WithEvents butAddVisitaNombreID As System.Windows.Forms.Button
    Private WithEvents cboVisitaMotivoID As System.Windows.Forms.ComboBox
    Private WithEvents butVerVisitaMotivoID As System.Windows.Forms.Button
    Private WithEvents butAddVisitaMotivoID As System.Windows.Forms.Button
    Private WithEvents cboEmpresaID As System.Windows.Forms.ComboBox
    Private WithEvents cboPersonaResponsableVisitaID As System.Windows.Forms.ComboBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraEntrada As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraSalida As System.Windows.Forms.DateTimePicker
    Private WithEvents txtEmpresaNombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblVisitaRegistroID As System.Windows.Forms.Label
   Private WithEvents lblVisitaTipoID As System.Windows.Forms.Label
   Private WithEvents lblVisitaNombreID As System.Windows.Forms.Label
   Private WithEvents lblVisitaMotivoID As System.Windows.Forms.Label
   Private WithEvents lblEmpresaID As System.Windows.Forms.Label
   Private WithEvents lblPersonaResponsableVisitaID As System.Windows.Forms.Label
   Private WithEvents lblFecha As System.Windows.Forms.Label
   Private WithEvents lblHoraEntrada As System.Windows.Forms.Label
   Private WithEvents lblHoraSalida As System.Windows.Forms.Label
   Private WithEvents lblEmpresaNombre As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
