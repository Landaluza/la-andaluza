<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotableAnaliticasOrganolepticas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotableAnaliticasOrganolepticas))
        Me.cboAnalista = New System.Windows.Forms.ComboBox()
        Me.butVerAnalistaID = New System.Windows.Forms.Button()
        Me.butAddAnalistaID = New System.Windows.Forms.Button()
        Me.cboVerificador = New System.Windows.Forms.ComboBox()
        Me.butVerVerificadorID = New System.Windows.Forms.Button()
        Me.butAddVerificadorID = New System.Windows.Forms.Button()
        Me.chbIncoloro = New System.Windows.Forms.CheckBox()
        Me.chbInodoro = New System.Windows.Forms.CheckBox()
        Me.chbInsipido = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.chbVerificado = New System.Windows.Forms.CheckBox()
        Me.chbCorrecto = New System.Windows.Forms.CheckBox()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblAnalistaID = New System.Windows.Forms.Label()
        Me.lblVerificadorID = New System.Windows.Forms.Label()
        Me.lblIncoloro = New System.Windows.Forms.Label()
        Me.lblInodoro = New System.Windows.Forms.Label()
        Me.lblInsipido = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblVerificado = New System.Windows.Forms.Label()
        Me.lblCorrecto = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAnalista
        '
        Me.cboAnalista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAnalista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAnalista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAnalista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAnalista.Location = New System.Drawing.Point(165, 43)
        Me.cboAnalista.Name = "cboAnalista"
        Me.cboAnalista.Size = New System.Drawing.Size(200, 23)
        Me.cboAnalista.TabIndex = 0
        '
        'butVerAnalistaID
        '
        Me.butVerAnalistaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerAnalistaID.FlatAppearance.BorderSize = 0
        Me.butVerAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerAnalistaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerAnalistaID.Location = New System.Drawing.Point(371, 43)
        Me.butVerAnalistaID.Name = "butVerAnalistaID"
        Me.butVerAnalistaID.Size = New System.Drawing.Size(20, 20)
        Me.butVerAnalistaID.TabIndex = 1
        Me.butVerAnalistaID.TabStop = False
        '
        'butAddAnalistaID
        '
        Me.butAddAnalistaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddAnalistaID.FlatAppearance.BorderSize = 0
        Me.butAddAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddAnalistaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddAnalistaID.Location = New System.Drawing.Point(397, 43)
        Me.butAddAnalistaID.Name = "butAddAnalistaID"
        Me.butAddAnalistaID.Size = New System.Drawing.Size(20, 20)
        Me.butAddAnalistaID.TabIndex = 2
        Me.butAddAnalistaID.TabStop = False
        '
        'cboVerificador
        '
        Me.cboVerificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVerificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVerificador.Location = New System.Drawing.Point(165, 72)
        Me.cboVerificador.Name = "cboVerificador"
        Me.cboVerificador.Size = New System.Drawing.Size(200, 23)
        Me.cboVerificador.TabIndex = 1
        '
        'butVerVerificadorID
        '
        Me.butVerVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerVerificadorID.FlatAppearance.BorderSize = 0
        Me.butVerVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVerificadorID.Location = New System.Drawing.Point(371, 72)
        Me.butVerVerificadorID.Name = "butVerVerificadorID"
        Me.butVerVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVerificadorID.TabIndex = 4
        Me.butVerVerificadorID.TabStop = False
        '
        'butAddVerificadorID
        '
        Me.butAddVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddVerificadorID.FlatAppearance.BorderSize = 0
        Me.butAddVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVerificadorID.Location = New System.Drawing.Point(397, 72)
        Me.butAddVerificadorID.Name = "butAddVerificadorID"
        Me.butAddVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVerificadorID.TabIndex = 5
        Me.butAddVerificadorID.TabStop = False
        '
        'chbIncoloro
        '
        Me.chbIncoloro.BackColor = System.Drawing.SystemColors.Control
        Me.chbIncoloro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbIncoloro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbIncoloro.Location = New System.Drawing.Point(165, 101)
        Me.chbIncoloro.Name = "chbIncoloro"
        Me.chbIncoloro.Size = New System.Drawing.Size(16, 21)
        Me.chbIncoloro.TabIndex = 2
        Me.chbIncoloro.UseVisualStyleBackColor = False
        '
        'chbInodoro
        '
        Me.chbInodoro.BackColor = System.Drawing.SystemColors.Control
        Me.chbInodoro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbInodoro.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbInodoro.Location = New System.Drawing.Point(165, 128)
        Me.chbInodoro.Name = "chbInodoro"
        Me.chbInodoro.Size = New System.Drawing.Size(16, 21)
        Me.chbInodoro.TabIndex = 3
        Me.chbInodoro.UseVisualStyleBackColor = False
        '
        'chbInsipido
        '
        Me.chbInsipido.BackColor = System.Drawing.SystemColors.Control
        Me.chbInsipido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbInsipido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbInsipido.Location = New System.Drawing.Point(165, 155)
        Me.chbInsipido.Name = "chbInsipido"
        Me.chbInsipido.Size = New System.Drawing.Size(16, 21)
        Me.chbInsipido.TabIndex = 4
        Me.chbInsipido.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(165, 182)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 5
        '
        'chbVerificado
        '
        Me.chbVerificado.BackColor = System.Drawing.SystemColors.Control
        Me.chbVerificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVerificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVerificado.Location = New System.Drawing.Point(165, 209)
        Me.chbVerificado.Name = "chbVerificado"
        Me.chbVerificado.Size = New System.Drawing.Size(16, 21)
        Me.chbVerificado.TabIndex = 6
        Me.chbVerificado.UseVisualStyleBackColor = False
        '
        'chbCorrecto
        '
        Me.chbCorrecto.BackColor = System.Drawing.SystemColors.Control
        Me.chbCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCorrecto.Location = New System.Drawing.Point(165, 236)
        Me.chbCorrecto.Name = "chbCorrecto"
        Me.chbCorrecto.Size = New System.Drawing.Size(16, 21)
        Me.chbCorrecto.TabIndex = 7
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
        Me.txtRuta.Location = New System.Drawing.Point(165, 263)
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
        Me.txtRuta.TabIndex = 8
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
        Me.butRuta.Location = New System.Drawing.Point(451, 263)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(20, 20)
        Me.butRuta.TabIndex = 13
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
        Me.txtObservaciones.Location = New System.Drawing.Point(165, 290)
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
        Me.txtObservaciones.TabIndex = 9
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblAnalistaID
        '
        Me.lblAnalistaID.Location = New System.Drawing.Point(23, 40)
        Me.lblAnalistaID.Name = "lblAnalistaID"
        Me.lblAnalistaID.Size = New System.Drawing.Size(136, 21)
        Me.lblAnalistaID.TabIndex = 0
        Me.lblAnalistaID.Text = "Analista"
        Me.lblAnalistaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificadorID
        '
        Me.lblVerificadorID.Location = New System.Drawing.Point(23, 69)
        Me.lblVerificadorID.Name = "lblVerificadorID"
        Me.lblVerificadorID.Size = New System.Drawing.Size(136, 21)
        Me.lblVerificadorID.TabIndex = 3
        Me.lblVerificadorID.Text = "Verificador"
        Me.lblVerificadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblIncoloro
        '
        Me.lblIncoloro.Location = New System.Drawing.Point(23, 98)
        Me.lblIncoloro.Name = "lblIncoloro"
        Me.lblIncoloro.Size = New System.Drawing.Size(136, 21)
        Me.lblIncoloro.TabIndex = 6
        Me.lblIncoloro.Text = "Incoloro"
        Me.lblIncoloro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInodoro
        '
        Me.lblInodoro.Location = New System.Drawing.Point(23, 125)
        Me.lblInodoro.Name = "lblInodoro"
        Me.lblInodoro.Size = New System.Drawing.Size(136, 21)
        Me.lblInodoro.TabIndex = 7
        Me.lblInodoro.Text = "Inodoro"
        Me.lblInodoro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInsipido
        '
        Me.lblInsipido.Location = New System.Drawing.Point(23, 152)
        Me.lblInsipido.Name = "lblInsipido"
        Me.lblInsipido.Size = New System.Drawing.Size(136, 21)
        Me.lblInsipido.TabIndex = 8
        Me.lblInsipido.Text = "Insipido"
        Me.lblInsipido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(23, 179)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(136, 21)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificado
        '
        Me.lblVerificado.Location = New System.Drawing.Point(23, 206)
        Me.lblVerificado.Name = "lblVerificado"
        Me.lblVerificado.Size = New System.Drawing.Size(136, 21)
        Me.lblVerificado.TabIndex = 10
        Me.lblVerificado.Text = "Verificado"
        Me.lblVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorrecto
        '
        Me.lblCorrecto.Location = New System.Drawing.Point(23, 233)
        Me.lblCorrecto.Name = "lblCorrecto"
        Me.lblCorrecto.Size = New System.Drawing.Size(136, 21)
        Me.lblCorrecto.TabIndex = 11
        Me.lblCorrecto.Text = "Correcto"
        Me.lblCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(23, 260)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(136, 21)
        Me.lblRuta.TabIndex = 12
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 287)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(136, 21)
        Me.lblObservaciones.TabIndex = 14
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotableAnaliticasOrganolepticas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(499, 354)
        Me.Controls.Add(Me.lblAnalistaID)
        Me.Controls.Add(Me.cboAnalista)
        Me.Controls.Add(Me.butVerAnalistaID)
        Me.Controls.Add(Me.butAddAnalistaID)
        Me.Controls.Add(Me.lblInodoro)
        Me.Controls.Add(Me.lblVerificadorID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboVerificador)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butVerVerificadorID)
        Me.Controls.Add(Me.butRuta)
        Me.Controls.Add(Me.butAddVerificadorID)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.lblIncoloro)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.chbIncoloro)
        Me.Controls.Add(Me.chbCorrecto)
        Me.Controls.Add(Me.lblCorrecto)
        Me.Controls.Add(Me.chbInodoro)
        Me.Controls.Add(Me.chbVerificado)
        Me.Controls.Add(Me.lblInsipido)
        Me.Controls.Add(Me.lblVerificado)
        Me.Controls.Add(Me.chbInsipido)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(498, 356)
        Me.Name = "frmEntAguaPotableAnaliticasOrganolepticas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotableAnaliticasOrganolepticas"
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.chbInsipido, 0)
        Me.Controls.SetChildIndex(Me.lblVerificado, 0)
        Me.Controls.SetChildIndex(Me.lblInsipido, 0)
        Me.Controls.SetChildIndex(Me.chbVerificado, 0)
        Me.Controls.SetChildIndex(Me.chbInodoro, 0)
        Me.Controls.SetChildIndex(Me.lblCorrecto, 0)
        Me.Controls.SetChildIndex(Me.chbCorrecto, 0)
        Me.Controls.SetChildIndex(Me.chbIncoloro, 0)
        Me.Controls.SetChildIndex(Me.lblRuta, 0)
        Me.Controls.SetChildIndex(Me.lblIncoloro, 0)
        Me.Controls.SetChildIndex(Me.txtRuta, 0)
        Me.Controls.SetChildIndex(Me.butAddVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.butRuta, 0)
        Me.Controls.SetChildIndex(Me.butVerVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboVerificador, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblInodoro, 0)
        Me.Controls.SetChildIndex(Me.butAddAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.butVerAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.cboAnalista, 0)
        Me.Controls.SetChildIndex(Me.lblAnalistaID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboAnalista As System.Windows.Forms.ComboBox
    Private WithEvents butVerAnalistaID As System.Windows.Forms.Button
    Private WithEvents butAddAnalistaID As System.Windows.Forms.Button
    Private WithEvents cboVerificador As System.Windows.Forms.ComboBox
    Private WithEvents butVerVerificadorID As System.Windows.Forms.Button
    Private WithEvents butAddVerificadorID As System.Windows.Forms.Button
    Private WithEvents chbIncoloro As System.Windows.Forms.CheckBox
    Private WithEvents chbInodoro As System.Windows.Forms.CheckBox
    Private WithEvents chbInsipido As System.Windows.Forms.CheckBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents chbVerificado As System.Windows.Forms.CheckBox
    Private WithEvents chbCorrecto As System.Windows.Forms.CheckBox
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblAnalistaID As System.Windows.Forms.Label
    Private WithEvents lblVerificadorID As System.Windows.Forms.Label
    Private WithEvents lblIncoloro As System.Windows.Forms.Label
    Private WithEvents lblInodoro As System.Windows.Forms.Label
    Private WithEvents lblInsipido As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblVerificado As System.Windows.Forms.Label
    Private WithEvents lblCorrecto As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
