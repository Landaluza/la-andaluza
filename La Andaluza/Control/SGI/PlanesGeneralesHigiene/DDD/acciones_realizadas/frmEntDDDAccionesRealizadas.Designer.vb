<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntDDDAccionesRealizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDDDAccionesRealizadas))
        Me.cboDDDPlan = New System.Windows.Forms.ComboBox()
        Me.butVerDDDPlanID = New System.Windows.Forms.Button()
        Me.butAddDDDPlanID = New System.Windows.Forms.Button()
        Me.dtpFechaPlanificada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaEjecutada = New System.Windows.Forms.DateTimePicker()
        Me.cboDDDAccion = New System.Windows.Forms.ComboBox()
        Me.butVerDDDAccionID = New System.Windows.Forms.Button()
        Me.butAddDDDAccionID = New System.Windows.Forms.Button()
        Me.cboPersona = New System.Windows.Forms.ComboBox()
        Me.butVerPersonaID = New System.Windows.Forms.Button()
        Me.butAddPersonaID = New System.Windows.Forms.Button()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.butVerProductoID = New System.Windows.Forms.Button()
        Me.butAddProductoID = New System.Windows.Forms.Button()
        Me.txtRutaParteTrabajo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRutaParteTrabajo = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDDDPlanID = New System.Windows.Forms.Label()
        Me.lblFechaPlanificada = New System.Windows.Forms.Label()
        Me.lblFechaEjecutada = New System.Windows.Forms.Label()
        Me.lblDDDAccionID = New System.Windows.Forms.Label()
        Me.lblPersonaID = New System.Windows.Forms.Label()
        Me.lblProductoID = New System.Windows.Forms.Label()
        Me.lblRutaParteTrabajo = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDDDPlan
        '
        Me.cboDDDPlan.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDDDPlan.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDDDPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDDDPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDDDPlan.Location = New System.Drawing.Point(129, 39)
        Me.cboDDDPlan.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDDDPlan.Name = "cboDDDPlan"
        Me.cboDDDPlan.Size = New System.Drawing.Size(422, 23)
        Me.cboDDDPlan.TabIndex = 0
        '
        'butVerDDDPlanID
        '
        Me.butVerDDDPlanID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerDDDPlanID.FlatAppearance.BorderSize = 0
        Me.butVerDDDPlanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerDDDPlanID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerDDDPlanID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerDDDPlanID.Location = New System.Drawing.Point(554, 38)
        Me.butVerDDDPlanID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerDDDPlanID.Name = "butVerDDDPlanID"
        Me.butVerDDDPlanID.Size = New System.Drawing.Size(18, 21)
        Me.butVerDDDPlanID.TabIndex = 1
        Me.butVerDDDPlanID.TabStop = False
        '
        'butAddDDDPlanID
        '
        Me.butAddDDDPlanID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddDDDPlanID.FlatAppearance.BorderSize = 0
        Me.butAddDDDPlanID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddDDDPlanID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddDDDPlanID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddDDDPlanID.Location = New System.Drawing.Point(577, 38)
        Me.butAddDDDPlanID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddDDDPlanID.Name = "butAddDDDPlanID"
        Me.butAddDDDPlanID.Size = New System.Drawing.Size(18, 21)
        Me.butAddDDDPlanID.TabIndex = 2
        Me.butAddDDDPlanID.TabStop = False
        '
        'dtpFechaPlanificada
        '
        Me.dtpFechaPlanificada.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaPlanificada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPlanificada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPlanificada.Location = New System.Drawing.Point(129, 69)
        Me.dtpFechaPlanificada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaPlanificada.Name = "dtpFechaPlanificada"
        Me.dtpFechaPlanificada.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaPlanificada.TabIndex = 1
        '
        'dtpFechaEjecutada
        '
        Me.dtpFechaEjecutada.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaEjecutada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEjecutada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEjecutada.Location = New System.Drawing.Point(129, 98)
        Me.dtpFechaEjecutada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaEjecutada.Name = "dtpFechaEjecutada"
        Me.dtpFechaEjecutada.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaEjecutada.TabIndex = 2
        '
        'cboDDDAccion
        '
        Me.cboDDDAccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDDDAccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDDDAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDDDAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDDDAccion.Location = New System.Drawing.Point(129, 125)
        Me.cboDDDAccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboDDDAccion.Name = "cboDDDAccion"
        Me.cboDDDAccion.Size = New System.Drawing.Size(422, 23)
        Me.cboDDDAccion.TabIndex = 3
        '
        'butVerDDDAccionID
        '
        Me.butVerDDDAccionID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerDDDAccionID.FlatAppearance.BorderSize = 0
        Me.butVerDDDAccionID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerDDDAccionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerDDDAccionID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerDDDAccionID.Location = New System.Drawing.Point(554, 124)
        Me.butVerDDDAccionID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerDDDAccionID.Name = "butVerDDDAccionID"
        Me.butVerDDDAccionID.Size = New System.Drawing.Size(18, 21)
        Me.butVerDDDAccionID.TabIndex = 6
        Me.butVerDDDAccionID.TabStop = False
        '
        'butAddDDDAccionID
        '
        Me.butAddDDDAccionID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddDDDAccionID.FlatAppearance.BorderSize = 0
        Me.butAddDDDAccionID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddDDDAccionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddDDDAccionID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddDDDAccionID.Location = New System.Drawing.Point(577, 124)
        Me.butAddDDDAccionID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddDDDAccionID.Name = "butAddDDDAccionID"
        Me.butAddDDDAccionID.Size = New System.Drawing.Size(18, 21)
        Me.butAddDDDAccionID.TabIndex = 7
        Me.butAddDDDAccionID.TabStop = False
        '
        'cboPersona
        '
        Me.cboPersona.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPersona.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersona.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPersona.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersona.Location = New System.Drawing.Point(129, 155)
        Me.cboPersona.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPersona.Name = "cboPersona"
        Me.cboPersona.Size = New System.Drawing.Size(422, 23)
        Me.cboPersona.TabIndex = 4
        '
        'butVerPersonaID
        '
        Me.butVerPersonaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerPersonaID.FlatAppearance.BorderSize = 0
        Me.butVerPersonaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPersonaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPersonaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerPersonaID.Location = New System.Drawing.Point(554, 154)
        Me.butVerPersonaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerPersonaID.Name = "butVerPersonaID"
        Me.butVerPersonaID.Size = New System.Drawing.Size(18, 21)
        Me.butVerPersonaID.TabIndex = 9
        Me.butVerPersonaID.TabStop = False
        '
        'butAddPersonaID
        '
        Me.butAddPersonaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddPersonaID.FlatAppearance.BorderSize = 0
        Me.butAddPersonaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPersonaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPersonaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPersonaID.Location = New System.Drawing.Point(577, 154)
        Me.butAddPersonaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddPersonaID.Name = "butAddPersonaID"
        Me.butAddPersonaID.Size = New System.Drawing.Size(18, 21)
        Me.butAddPersonaID.TabIndex = 10
        Me.butAddPersonaID.TabStop = False
        '
        'cboProducto
        '
        Me.cboProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProducto.Location = New System.Drawing.Point(129, 185)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(422, 23)
        Me.cboProducto.TabIndex = 5
        '
        'butVerProductoID
        '
        Me.butVerProductoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProductoID.FlatAppearance.BorderSize = 0
        Me.butVerProductoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProductoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProductoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProductoID.Location = New System.Drawing.Point(554, 184)
        Me.butVerProductoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProductoID.Name = "butVerProductoID"
        Me.butVerProductoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProductoID.TabIndex = 12
        Me.butVerProductoID.TabStop = False
        '
        'butAddProductoID
        '
        Me.butAddProductoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProductoID.FlatAppearance.BorderSize = 0
        Me.butAddProductoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProductoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProductoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProductoID.Location = New System.Drawing.Point(577, 184)
        Me.butAddProductoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProductoID.Name = "butAddProductoID"
        Me.butAddProductoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProductoID.TabIndex = 13
        Me.butAddProductoID.TabStop = False
        '
        'txtRutaParteTrabajo
        '
        Me.txtRutaParteTrabajo.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaParteTrabajo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaParteTrabajo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaParteTrabajo.EsUnicoCampo = ""
        Me.txtRutaParteTrabajo.EsUnicoCampoID = ""
        Me.txtRutaParteTrabajo.EsUnicoID = 0
        Me.txtRutaParteTrabajo.EsUnicoTabla = ""
        Me.txtRutaParteTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaParteTrabajo.Location = New System.Drawing.Point(129, 215)
        Me.txtRutaParteTrabajo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaParteTrabajo.MaxLength = 250
        Me.txtRutaParteTrabajo.Minimo = 0
        Me.txtRutaParteTrabajo.Modificado = False
        Me.txtRutaParteTrabajo.Name = "txtRutaParteTrabajo"
        Me.txtRutaParteTrabajo.Numerico_EsNumerico = False
        Me.txtRutaParteTrabajo.Numerico_NumeroDoublees = 0
        Me.txtRutaParteTrabajo.Numerico_SeparadorMiles = False
        Me.txtRutaParteTrabajo.Obligatorio = False
        Me.txtRutaParteTrabajo.ParametroID = 0
        Me.txtRutaParteTrabajo.Size = New System.Drawing.Size(422, 14)
        Me.txtRutaParteTrabajo.TabIndex = 6
        Me.txtRutaParteTrabajo.ValorMaximo = 0.0R
        Me.txtRutaParteTrabajo.ValorMinimo = 0.0R
        '
        'butRutaParteTrabajo
        '
        Me.butRutaParteTrabajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRutaParteTrabajo.FlatAppearance.BorderSize = 0
        Me.butRutaParteTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaParteTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaParteTrabajo.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaParteTrabajo.Location = New System.Drawing.Point(577, 215)
        Me.butRutaParteTrabajo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaParteTrabajo.Name = "butRutaParteTrabajo"
        Me.butRutaParteTrabajo.Size = New System.Drawing.Size(18, 20)
        Me.butRutaParteTrabajo.TabIndex = 15
        Me.butRutaParteTrabajo.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(129, 244)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(422, 54)
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblDDDPlanID
        '
        Me.lblDDDPlanID.Location = New System.Drawing.Point(15, 37)
        Me.lblDDDPlanID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDDDPlanID.Name = "lblDDDPlanID"
        Me.lblDDDPlanID.Size = New System.Drawing.Size(110, 30)
        Me.lblDDDPlanID.TabIndex = 0
        Me.lblDDDPlanID.Text = "DDDPlan"
        Me.lblDDDPlanID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPlanificada
        '
        Me.lblFechaPlanificada.Location = New System.Drawing.Point(15, 67)
        Me.lblFechaPlanificada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaPlanificada.Name = "lblFechaPlanificada"
        Me.lblFechaPlanificada.Size = New System.Drawing.Size(110, 28)
        Me.lblFechaPlanificada.TabIndex = 3
        Me.lblFechaPlanificada.Text = "FechaPlanificada"
        Me.lblFechaPlanificada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaEjecutada
        '
        Me.lblFechaEjecutada.Location = New System.Drawing.Point(15, 95)
        Me.lblFechaEjecutada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaEjecutada.Name = "lblFechaEjecutada"
        Me.lblFechaEjecutada.Size = New System.Drawing.Size(110, 28)
        Me.lblFechaEjecutada.TabIndex = 4
        Me.lblFechaEjecutada.Text = "FechaEjecutada"
        Me.lblFechaEjecutada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDDDAccionID
        '
        Me.lblDDDAccionID.Location = New System.Drawing.Point(15, 123)
        Me.lblDDDAccionID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDDDAccionID.Name = "lblDDDAccionID"
        Me.lblDDDAccionID.Size = New System.Drawing.Size(110, 30)
        Me.lblDDDAccionID.TabIndex = 5
        Me.lblDDDAccionID.Text = "DDDAccion"
        Me.lblDDDAccionID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPersonaID
        '
        Me.lblPersonaID.Location = New System.Drawing.Point(15, 153)
        Me.lblPersonaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPersonaID.Name = "lblPersonaID"
        Me.lblPersonaID.Size = New System.Drawing.Size(110, 30)
        Me.lblPersonaID.TabIndex = 8
        Me.lblPersonaID.Text = "Persona"
        Me.lblPersonaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProductoID
        '
        Me.lblProductoID.Location = New System.Drawing.Point(15, 183)
        Me.lblProductoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProductoID.Name = "lblProductoID"
        Me.lblProductoID.Size = New System.Drawing.Size(110, 30)
        Me.lblProductoID.TabIndex = 11
        Me.lblProductoID.Text = "Producto"
        Me.lblProductoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaParteTrabajo
        '
        Me.lblRutaParteTrabajo.Location = New System.Drawing.Point(15, 213)
        Me.lblRutaParteTrabajo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaParteTrabajo.Name = "lblRutaParteTrabajo"
        Me.lblRutaParteTrabajo.Size = New System.Drawing.Size(110, 28)
        Me.lblRutaParteTrabajo.TabIndex = 14
        Me.lblRutaParteTrabajo.Text = "RutaParteTrabajo"
        Me.lblRutaParteTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(15, 241)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(110, 28)
        Me.lblObservaciones.TabIndex = 16
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntDDDAccionesRealizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(604, 323)
        Me.Controls.Add(Me.cboDDDPlan)
        Me.Controls.Add(Me.cboPersona)
        Me.Controls.Add(Me.lblDDDPlanID)
        Me.Controls.Add(Me.cboDDDAccion)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.butVerPersonaID)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butVerDDDPlanID)
        Me.Controls.Add(Me.lblFechaPlanificada)
        Me.Controls.Add(Me.butAddDDDPlanID)
        Me.Controls.Add(Me.dtpFechaPlanificada)
        Me.Controls.Add(Me.txtRutaParteTrabajo)
        Me.Controls.Add(Me.butRutaParteTrabajo)
        Me.Controls.Add(Me.lblFechaEjecutada)
        Me.Controls.Add(Me.lblRutaParteTrabajo)
        Me.Controls.Add(Me.dtpFechaEjecutada)
        Me.Controls.Add(Me.lblDDDAccionID)
        Me.Controls.Add(Me.butAddProductoID)
        Me.Controls.Add(Me.cboProducto)
        Me.Controls.Add(Me.lblProductoID)
        Me.Controls.Add(Me.butVerProductoID)
        Me.Controls.Add(Me.lblPersonaID)
        Me.Controls.Add(Me.butVerDDDAccionID)
        Me.Controls.Add(Me.butAddPersonaID)
        Me.Controls.Add(Me.butAddDDDAccionID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(437, 292)
        Me.Name = "frmEntDDDAccionesRealizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DDDAccionesRealizadas"
        Me.Controls.SetChildIndex(Me.butAddDDDAccionID, 0)
        Me.Controls.SetChildIndex(Me.butAddPersonaID, 0)
        Me.Controls.SetChildIndex(Me.butVerDDDAccionID, 0)
        Me.Controls.SetChildIndex(Me.lblPersonaID, 0)
        Me.Controls.SetChildIndex(Me.butVerProductoID, 0)
        Me.Controls.SetChildIndex(Me.lblProductoID, 0)
        Me.Controls.SetChildIndex(Me.cboProducto, 0)
        Me.Controls.SetChildIndex(Me.butAddProductoID, 0)
        Me.Controls.SetChildIndex(Me.lblDDDAccionID, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaEjecutada, 0)
        Me.Controls.SetChildIndex(Me.lblRutaParteTrabajo, 0)
        Me.Controls.SetChildIndex(Me.lblFechaEjecutada, 0)
        Me.Controls.SetChildIndex(Me.butRutaParteTrabajo, 0)
        Me.Controls.SetChildIndex(Me.txtRutaParteTrabajo, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaPlanificada, 0)
        Me.Controls.SetChildIndex(Me.butAddDDDPlanID, 0)
        Me.Controls.SetChildIndex(Me.lblFechaPlanificada, 0)
        Me.Controls.SetChildIndex(Me.butVerDDDPlanID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butVerPersonaID, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboDDDAccion, 0)
        Me.Controls.SetChildIndex(Me.lblDDDPlanID, 0)
        Me.Controls.SetChildIndex(Me.cboPersona, 0)
        Me.Controls.SetChildIndex(Me.cboDDDPlan, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboDDDPlan As System.Windows.Forms.ComboBox
    Private WithEvents butVerDDDPlanID As System.Windows.Forms.Button
    Private WithEvents butAddDDDPlanID As System.Windows.Forms.Button
    Private WithEvents dtpFechaPlanificada As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaEjecutada As System.Windows.Forms.DateTimePicker
    Private WithEvents cboDDDAccion As System.Windows.Forms.ComboBox
    Private WithEvents butVerDDDAccionID As System.Windows.Forms.Button
    Private WithEvents butAddDDDAccionID As System.Windows.Forms.Button
    Private WithEvents cboPersona As System.Windows.Forms.ComboBox
    Private WithEvents butVerPersonaID As System.Windows.Forms.Button
    Private WithEvents butAddPersonaID As System.Windows.Forms.Button
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerProductoID As System.Windows.Forms.Button
    Private WithEvents butAddProductoID As System.Windows.Forms.Button
    Private WithEvents txtRutaParteTrabajo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRutaParteTrabajo As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDDDPlanID As System.Windows.Forms.Label
    Private WithEvents lblFechaPlanificada As System.Windows.Forms.Label
    Private WithEvents lblFechaEjecutada As System.Windows.Forms.Label
    Private WithEvents lblDDDAccionID As System.Windows.Forms.Label
    Private WithEvents lblPersonaID As System.Windows.Forms.Label
    Private WithEvents lblProductoID As System.Windows.Forms.Label
    Private WithEvents lblRutaParteTrabajo As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
