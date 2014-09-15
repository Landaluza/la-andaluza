<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotableAnaliticasCloro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotableAnaliticasCloro))
        Me.cboPuntoMuestreo = New System.Windows.Forms.ComboBox()
        Me.butVerPuntoMuestreoID = New System.Windows.Forms.Button()
        Me.butAddPuntoMuestreoID = New System.Windows.Forms.Button()
        Me.cboAnalista = New System.Windows.Forms.ComboBox()
        Me.butVerAnalistaID = New System.Windows.Forms.Button()
        Me.butAddAnalistaID = New System.Windows.Forms.Button()
        Me.cboVerificador = New System.Windows.Forms.ComboBox()
        Me.butVerVerificadorID = New System.Windows.Forms.Button()
        Me.butAddVerificadorID = New System.Windows.Forms.Button()
        Me.chbVerificado = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtValor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbCorrecto = New System.Windows.Forms.CheckBox()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPuntoMuestreoID = New System.Windows.Forms.Label()
        Me.lblAnalistaID = New System.Windows.Forms.Label()
        Me.lblVerificadorID = New System.Windows.Forms.Label()
        Me.lblVerificado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblCorrecto = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPuntoMuestreo
        '
        Me.cboPuntoMuestreo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPuntoMuestreo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuntoMuestreo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPuntoMuestreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuntoMuestreo.Location = New System.Drawing.Point(137, 44)
        Me.cboPuntoMuestreo.Name = "cboPuntoMuestreo"
        Me.cboPuntoMuestreo.Size = New System.Drawing.Size(200, 23)
        Me.cboPuntoMuestreo.TabIndex = 0
        '
        'butVerPuntoMuestreoID
        '
        Me.butVerPuntoMuestreoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerPuntoMuestreoID.FlatAppearance.BorderSize = 0
        Me.butVerPuntoMuestreoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPuntoMuestreoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPuntoMuestreoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerPuntoMuestreoID.Location = New System.Drawing.Point(343, 44)
        Me.butVerPuntoMuestreoID.Name = "butVerPuntoMuestreoID"
        Me.butVerPuntoMuestreoID.Size = New System.Drawing.Size(20, 20)
        Me.butVerPuntoMuestreoID.TabIndex = 1
        Me.butVerPuntoMuestreoID.TabStop = False
        '
        'butAddPuntoMuestreoID
        '
        Me.butAddPuntoMuestreoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddPuntoMuestreoID.FlatAppearance.BorderSize = 0
        Me.butAddPuntoMuestreoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPuntoMuestreoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPuntoMuestreoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPuntoMuestreoID.Location = New System.Drawing.Point(369, 44)
        Me.butAddPuntoMuestreoID.Name = "butAddPuntoMuestreoID"
        Me.butAddPuntoMuestreoID.Size = New System.Drawing.Size(20, 20)
        Me.butAddPuntoMuestreoID.TabIndex = 2
        Me.butAddPuntoMuestreoID.TabStop = False
        '
        'cboAnalista
        '
        Me.cboAnalista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAnalista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAnalista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAnalista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalista.Location = New System.Drawing.Point(137, 73)
        Me.cboAnalista.Name = "cboAnalista"
        Me.cboAnalista.Size = New System.Drawing.Size(200, 23)
        Me.cboAnalista.TabIndex = 1
        '
        'butVerAnalistaID
        '
        Me.butVerAnalistaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerAnalistaID.FlatAppearance.BorderSize = 0
        Me.butVerAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerAnalistaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerAnalistaID.Location = New System.Drawing.Point(343, 73)
        Me.butVerAnalistaID.Name = "butVerAnalistaID"
        Me.butVerAnalistaID.Size = New System.Drawing.Size(20, 20)
        Me.butVerAnalistaID.TabIndex = 4
        Me.butVerAnalistaID.TabStop = False
        '
        'butAddAnalistaID
        '
        Me.butAddAnalistaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddAnalistaID.FlatAppearance.BorderSize = 0
        Me.butAddAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddAnalistaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddAnalistaID.Location = New System.Drawing.Point(369, 73)
        Me.butAddAnalistaID.Name = "butAddAnalistaID"
        Me.butAddAnalistaID.Size = New System.Drawing.Size(20, 20)
        Me.butAddAnalistaID.TabIndex = 5
        Me.butAddAnalistaID.TabStop = False
        '
        'cboVerificador
        '
        Me.cboVerificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVerificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVerificador.Location = New System.Drawing.Point(137, 102)
        Me.cboVerificador.Name = "cboVerificador"
        Me.cboVerificador.Size = New System.Drawing.Size(200, 23)
        Me.cboVerificador.TabIndex = 2
        '
        'butVerVerificadorID
        '
        Me.butVerVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerVerificadorID.FlatAppearance.BorderSize = 0
        Me.butVerVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVerificadorID.Location = New System.Drawing.Point(343, 102)
        Me.butVerVerificadorID.Name = "butVerVerificadorID"
        Me.butVerVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVerificadorID.TabIndex = 7
        Me.butVerVerificadorID.TabStop = False
        '
        'butAddVerificadorID
        '
        Me.butAddVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddVerificadorID.FlatAppearance.BorderSize = 0
        Me.butAddVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVerificadorID.Location = New System.Drawing.Point(369, 102)
        Me.butAddVerificadorID.Name = "butAddVerificadorID"
        Me.butAddVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVerificadorID.TabIndex = 8
        Me.butAddVerificadorID.TabStop = False
        '
        'chbVerificado
        '
        Me.chbVerificado.BackColor = System.Drawing.SystemColors.Control
        Me.chbVerificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVerificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVerificado.Location = New System.Drawing.Point(137, 131)
        Me.chbVerificado.Name = "chbVerificado"
        Me.chbVerificado.Size = New System.Drawing.Size(16, 21)
        Me.chbVerificado.TabIndex = 3
        Me.chbVerificado.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(137, 158)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(101, 21)
        Me.dtpFecha.TabIndex = 4
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Window
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtValor.EsUnicoCampo = ""
        Me.txtValor.EsUnicoCampoID = ""
        Me.txtValor.EsUnicoID = 0
        Me.txtValor.EsUnicoTabla = ""
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(137, 185)
        Me.txtValor.Minimo = 0
        Me.txtValor.Modificado = False
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico_EsNumerico = False
        Me.txtValor.Numerico_NumeroDoublees = 2
        Me.txtValor.Numerico_SeparadorMiles = False
        Me.txtValor.Obligatorio = False
        Me.txtValor.ParametroID = 0
        Me.txtValor.Size = New System.Drawing.Size(101, 14)
        Me.txtValor.TabIndex = 5
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.ValorMaximo = 0.0R
        Me.txtValor.ValorMinimo = 0.0R
        '
        'chbCorrecto
        '
        Me.chbCorrecto.BackColor = System.Drawing.SystemColors.Control
        Me.chbCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCorrecto.Location = New System.Drawing.Point(137, 212)
        Me.chbCorrecto.Name = "chbCorrecto"
        Me.chbCorrecto.Size = New System.Drawing.Size(16, 21)
        Me.chbCorrecto.TabIndex = 6
        Me.chbCorrecto.UseVisualStyleBackColor = False
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRuta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(137, 239)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(280, 14)
        Me.txtRuta.TabIndex = 7
        Me.txtRuta.ValorMaximo = 0.0R
        Me.txtRuta.ValorMinimo = 0.0R
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(423, 239)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(20, 20)
        Me.butRuta.TabIndex = 14
        Me.butRuta.TabStop = False
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
        Me.txtObservaciones.Location = New System.Drawing.Point(137, 266)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 14)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblPuntoMuestreoID
        '
        Me.lblPuntoMuestreoID.Location = New System.Drawing.Point(36, 46)
        Me.lblPuntoMuestreoID.Name = "lblPuntoMuestreoID"
        Me.lblPuntoMuestreoID.Size = New System.Drawing.Size(92, 21)
        Me.lblPuntoMuestreoID.TabIndex = 0
        Me.lblPuntoMuestreoID.Text = "Punto muestreo"
        Me.lblPuntoMuestreoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAnalistaID
        '
        Me.lblAnalistaID.Location = New System.Drawing.Point(36, 70)
        Me.lblAnalistaID.Name = "lblAnalistaID"
        Me.lblAnalistaID.Size = New System.Drawing.Size(95, 21)
        Me.lblAnalistaID.TabIndex = 3
        Me.lblAnalistaID.Text = "Analista"
        Me.lblAnalistaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificadorID
        '
        Me.lblVerificadorID.Location = New System.Drawing.Point(36, 99)
        Me.lblVerificadorID.Name = "lblVerificadorID"
        Me.lblVerificadorID.Size = New System.Drawing.Size(95, 21)
        Me.lblVerificadorID.TabIndex = 6
        Me.lblVerificadorID.Text = "Verificador"
        Me.lblVerificadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificado
        '
        Me.lblVerificado.Location = New System.Drawing.Point(36, 128)
        Me.lblVerificado.Name = "lblVerificado"
        Me.lblVerificado.Size = New System.Drawing.Size(95, 21)
        Me.lblVerificado.TabIndex = 9
        Me.lblVerificado.Text = "Verificado"
        Me.lblVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(36, 155)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(95, 21)
        Me.lblFecha.TabIndex = 10
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(36, 182)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(95, 21)
        Me.lblValor.TabIndex = 11
        Me.lblValor.Text = "Valor"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorrecto
        '
        Me.lblCorrecto.Location = New System.Drawing.Point(36, 209)
        Me.lblCorrecto.Name = "lblCorrecto"
        Me.lblCorrecto.Size = New System.Drawing.Size(95, 21)
        Me.lblCorrecto.TabIndex = 12
        Me.lblCorrecto.Text = "Correcto"
        Me.lblCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(36, 236)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(95, 21)
        Me.lblRuta.TabIndex = 13
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(36, 263)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(95, 21)
        Me.lblObservaciones.TabIndex = 15
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotableAnaliticasCloro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(492, 329)
        Me.Controls.Add(Me.chbVerificado)
        Me.Controls.Add(Me.lblPuntoMuestreoID)
        Me.Controls.Add(Me.cboPuntoMuestreo)
        Me.Controls.Add(Me.butVerPuntoMuestreoID)
        Me.Controls.Add(Me.butAddPuntoMuestreoID)
        Me.Controls.Add(Me.cboVerificador)
        Me.Controls.Add(Me.lblAnalistaID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboAnalista)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butVerAnalistaID)
        Me.Controls.Add(Me.butRuta)
        Me.Controls.Add(Me.butAddAnalistaID)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.lblVerificadorID)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.chbCorrecto)
        Me.Controls.Add(Me.butVerVerificadorID)
        Me.Controls.Add(Me.lblCorrecto)
        Me.Controls.Add(Me.butAddVerificadorID)
        Me.Controls.Add(Me.txtValor)
        Me.Controls.Add(Me.lblVerificado)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntAguaPotableAnaliticasCloro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotableAnaliticasCloro"
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.lblValor, 0)
        Me.Controls.SetChildIndex(Me.lblVerificado, 0)
        Me.Controls.SetChildIndex(Me.txtValor, 0)
        Me.Controls.SetChildIndex(Me.butAddVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblCorrecto, 0)
        Me.Controls.SetChildIndex(Me.butVerVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.chbCorrecto, 0)
        Me.Controls.SetChildIndex(Me.lblRuta, 0)
        Me.Controls.SetChildIndex(Me.lblVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.txtRuta, 0)
        Me.Controls.SetChildIndex(Me.butAddAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.butRuta, 0)
        Me.Controls.SetChildIndex(Me.butVerAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboAnalista, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.cboVerificador, 0)
        Me.Controls.SetChildIndex(Me.butAddPuntoMuestreoID, 0)
        Me.Controls.SetChildIndex(Me.butVerPuntoMuestreoID, 0)
        Me.Controls.SetChildIndex(Me.cboPuntoMuestreo, 0)
        Me.Controls.SetChildIndex(Me.lblPuntoMuestreoID, 0)
        Me.Controls.SetChildIndex(Me.chbVerificado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboPuntoMuestreo As System.Windows.Forms.ComboBox
    Private WithEvents butVerPuntoMuestreoID As System.Windows.Forms.Button
    Private WithEvents butAddPuntoMuestreoID As System.Windows.Forms.Button
    Private WithEvents cboAnalista As System.Windows.Forms.ComboBox
    Private WithEvents butVerAnalistaID As System.Windows.Forms.Button
    Private WithEvents butAddAnalistaID As System.Windows.Forms.Button
    Private WithEvents cboVerificador As System.Windows.Forms.ComboBox
    Private WithEvents butVerVerificadorID As System.Windows.Forms.Button
    Private WithEvents butAddVerificadorID As System.Windows.Forms.Button
    Private WithEvents chbVerificado As System.Windows.Forms.CheckBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtValor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbCorrecto As System.Windows.Forms.CheckBox
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPuntoMuestreoID As System.Windows.Forms.Label
    Private WithEvents lblAnalistaID As System.Windows.Forms.Label
    Private WithEvents lblVerificadorID As System.Windows.Forms.Label
    Private WithEvents lblVerificado As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblValor As System.Windows.Forms.Label
    Private WithEvents lblCorrecto As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
