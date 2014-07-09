<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntEnvasadosProductosAnaliticas2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEnvasadosProductosAnaliticas2))

        Me.lblEnvasadoProductoAnaliticaID = New System.Windows.Forms.Label()
        Me.txtEnvasadoProductoAnaliticaID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblParametroID = New System.Windows.Forms.Label()
        Me.cboParametroID = New System.Windows.Forms.ComboBox()
        Me.butVerParametroID = New System.Windows.Forms.Button()
        Me.butAddParametroID = New System.Windows.Forms.Button()
        Me.lblAnalistaID = New System.Windows.Forms.Label()
        Me.cboAnalistaID = New System.Windows.Forms.ComboBox()
        Me.butVerAnalistaID = New System.Windows.Forms.Button()
        Me.lblValor = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEnvasadoProductoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblEnvasadoProductoID = New System.Windows.Forms.Label()
        Me.txtValor = New BasesParaCompatibilidad.CuadroDeTexto()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'tlpTop
        '




        '
        'lblEnvasadoProductoAnaliticaID
        '
        Me.lblEnvasadoProductoAnaliticaID.Location = New System.Drawing.Point(31, 383)
        Me.lblEnvasadoProductoAnaliticaID.Name = "lblEnvasadoProductoAnaliticaID"
        Me.lblEnvasadoProductoAnaliticaID.Size = New System.Drawing.Size(163, 21)
        Me.lblEnvasadoProductoAnaliticaID.TabIndex = 1000000002
        Me.lblEnvasadoProductoAnaliticaID.Text = "EnvasadoProductoAnaliticaID"
        Me.lblEnvasadoProductoAnaliticaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEnvasadoProductoAnaliticaID.Visible = False
        '
        'txtEnvasadoProductoAnaliticaID
        '
        Me.txtEnvasadoProductoAnaliticaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoProductoAnaliticaID.EsUnicoCampo = ""
        Me.txtEnvasadoProductoAnaliticaID.EsUnicoCampoID = ""
        Me.txtEnvasadoProductoAnaliticaID.EsUnicoID = 0
        Me.txtEnvasadoProductoAnaliticaID.EsUnicoTabla = ""
        Me.txtEnvasadoProductoAnaliticaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtEnvasadoProductoAnaliticaID.Location = New System.Drawing.Point(214, 382)
        Me.txtEnvasadoProductoAnaliticaID.MaxLength = 9
        Me.txtEnvasadoProductoAnaliticaID.Minimo = 0
        Me.txtEnvasadoProductoAnaliticaID.Modificado = False
        Me.txtEnvasadoProductoAnaliticaID.Name = "txtEnvasadoProductoAnaliticaID"
        Me.txtEnvasadoProductoAnaliticaID.Numerico_EsNumerico = False
        Me.txtEnvasadoProductoAnaliticaID.Numerico_NumeroDoublees = 0
        Me.txtEnvasadoProductoAnaliticaID.Numerico_SeparadorMiles = False
        Me.txtEnvasadoProductoAnaliticaID.Obligatorio = True
        Me.txtEnvasadoProductoAnaliticaID.ParametroID = 0
        Me.txtEnvasadoProductoAnaliticaID.Size = New System.Drawing.Size(56, 21)
        Me.txtEnvasadoProductoAnaliticaID.TabIndex = 1000000001
        Me.txtEnvasadoProductoAnaliticaID.ValorMaximo = 0.0R
        Me.txtEnvasadoProductoAnaliticaID.ValorMinimo = 0.0R
        Me.txtEnvasadoProductoAnaliticaID.Visible = False
        '
        'lblParametroID
        '
        Me.lblParametroID.Location = New System.Drawing.Point(13, 39)
        Me.lblParametroID.Name = "lblParametroID"
        Me.lblParametroID.Size = New System.Drawing.Size(84, 21)
        Me.lblParametroID.TabIndex = 0
        Me.lblParametroID.Text = "Parametro"
        Me.lblParametroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboParametroID
        '
        Me.cboParametroID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboParametroID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboParametroID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboParametroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboParametroID.Location = New System.Drawing.Point(123, 38)
        Me.cboParametroID.Name = "cboParametroID"
        Me.cboParametroID.Size = New System.Drawing.Size(349, 23)
        Me.cboParametroID.TabIndex = 1
        '
        'butVerParametroID
        '
        Me.butVerParametroID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerParametroID.FlatAppearance.BorderSize = 0
        Me.butVerParametroID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerParametroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.butVerParametroID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerParametroID.Location = New System.Drawing.Point(478, 38)
        Me.butVerParametroID.Name = "butVerParametroID"
        Me.butVerParametroID.Size = New System.Drawing.Size(20, 20)
        Me.butVerParametroID.TabIndex = 2
        Me.butVerParametroID.TabStop = False
        '
        'butAddParametroID
        '
        Me.butAddParametroID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddParametroID.FlatAppearance.BorderSize = 0
        Me.butAddParametroID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddParametroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.butAddParametroID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddParametroID.Location = New System.Drawing.Point(504, 38)
        Me.butAddParametroID.Name = "butAddParametroID"
        Me.butAddParametroID.Size = New System.Drawing.Size(20, 20)
        Me.butAddParametroID.TabIndex = 3
        Me.butAddParametroID.TabStop = False
        '
        'lblAnalistaID
        '
        Me.lblAnalistaID.Location = New System.Drawing.Point(13, 71)
        Me.lblAnalistaID.Name = "lblAnalistaID"
        Me.lblAnalistaID.Size = New System.Drawing.Size(81, 21)
        Me.lblAnalistaID.TabIndex = 4
        Me.lblAnalistaID.Text = "Analista"
        Me.lblAnalistaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboAnalistaID
        '
        Me.cboAnalistaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAnalistaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.cboAnalistaID.Location = New System.Drawing.Point(123, 67)
        Me.cboAnalistaID.Name = "cboAnalistaID"
        Me.cboAnalistaID.Size = New System.Drawing.Size(349, 23)
        Me.cboAnalistaID.TabIndex = 5
        '
        'butVerAnalistaID
        '
        Me.butVerAnalistaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerAnalistaID.FlatAppearance.BorderSize = 0
        Me.butVerAnalistaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerAnalistaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.butVerAnalistaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerAnalistaID.Location = New System.Drawing.Point(478, 67)
        Me.butVerAnalistaID.Name = "butVerAnalistaID"
        Me.butVerAnalistaID.Size = New System.Drawing.Size(20, 20)
        Me.butVerAnalistaID.TabIndex = 6
        Me.butVerAnalistaID.TabStop = False
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(13, 97)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(100, 21)
        Me.lblValor.TabIndex = 7
        Me.lblValor.Text = "Valor"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(13, 123)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(97, 21)
        Me.lblHora.TabIndex = 9
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHora
        '
        Me.dtpHora.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(123, 123)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(56, 21)
        Me.dtpHora.TabIndex = 10
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 151)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 21)
        Me.lblObservaciones.TabIndex = 11
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtObservaciones.Location = New System.Drawing.Point(123, 150)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(349, 83)
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtEnvasadoProductoID
        '
        Me.txtEnvasadoProductoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnvasadoProductoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoProductoID.EsUnicoCampo = ""
        Me.txtEnvasadoProductoID.EsUnicoCampoID = ""
        Me.txtEnvasadoProductoID.EsUnicoID = 0
        Me.txtEnvasadoProductoID.EsUnicoTabla = ""
        Me.txtEnvasadoProductoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtEnvasadoProductoID.Location = New System.Drawing.Point(424, -87)
        Me.txtEnvasadoProductoID.MaxLength = 9
        Me.txtEnvasadoProductoID.Minimo = 0
        Me.txtEnvasadoProductoID.Modificado = False
        Me.txtEnvasadoProductoID.Name = "txtEnvasadoProductoID"
        Me.txtEnvasadoProductoID.Numerico_EsNumerico = False
        Me.txtEnvasadoProductoID.Numerico_NumeroDoublees = 0
        Me.txtEnvasadoProductoID.Numerico_SeparadorMiles = False
        Me.txtEnvasadoProductoID.Obligatorio = False
        Me.txtEnvasadoProductoID.ParametroID = 0
        Me.txtEnvasadoProductoID.Size = New System.Drawing.Size(65, 21)
        Me.txtEnvasadoProductoID.TabIndex = 1000000004
        Me.txtEnvasadoProductoID.ValorMaximo = 0.0R
        Me.txtEnvasadoProductoID.ValorMinimo = 0.0R
        Me.txtEnvasadoProductoID.Visible = False
        '
        'lblEnvasadoProductoID
        '
        Me.lblEnvasadoProductoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblEnvasadoProductoID.Location = New System.Drawing.Point(512, -87)
        Me.lblEnvasadoProductoID.Name = "lblEnvasadoProductoID"
        Me.lblEnvasadoProductoID.Size = New System.Drawing.Size(128, 21)
        Me.lblEnvasadoProductoID.TabIndex = 1000000003
        Me.lblEnvasadoProductoID.Text = "EnvasadoProductoID"
        Me.lblEnvasadoProductoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEnvasadoProductoID.Visible = False
        '
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Window
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.EsUnicoCampo = ""
        Me.txtValor.EsUnicoCampoID = ""
        Me.txtValor.EsUnicoID = 0
        Me.txtValor.EsUnicoTabla = ""
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.txtValor.Location = New System.Drawing.Point(123, 96)
        Me.txtValor.Minimo = 0
        Me.txtValor.Modificado = False
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico_EsNumerico = True
        Me.txtValor.Numerico_NumeroDoublees = 2
        Me.txtValor.Numerico_SeparadorMiles = False
        Me.txtValor.Obligatorio = False
        Me.txtValor.ParametroID = 0
        Me.txtValor.Size = New System.Drawing.Size(56, 21)
        Me.txtValor.TabIndex = 8
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.ValorMaximo = 0.0R
        Me.txtValor.ValorMinimo = 0.0R
        '
        'frmEntEnvasadosProductosAnaliticas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(540, 252)
        Me.Controls.Add(Me.lblEnvasadoProductoAnaliticaID)
        Me.Controls.Add(Me.txtEnvasadoProductoAnaliticaID)
        Me.Controls.Add(Me.lblParametroID)
        Me.Controls.Add(Me.cboParametroID)
        Me.Controls.Add(Me.butVerParametroID)
        Me.Controls.Add(Me.butAddParametroID)
        Me.Controls.Add(Me.lblAnalistaID)
        Me.Controls.Add(Me.cboAnalistaID)
        Me.Controls.Add(Me.butVerAnalistaID)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtEnvasadoProductoID)
        Me.Controls.Add(Me.lblEnvasadoProductoID)
        Me.Controls.Add(Me.txtValor)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmEntEnvasadosProductosAnaliticas2"
        Me.Text = "EnvasadosProductosAnaliticas"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.txtValor, 0)
        Me.Controls.SetChildIndex(Me.lblEnvasadoProductoID, 0)
        Me.Controls.SetChildIndex(Me.txtEnvasadoProductoID, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpHora, 0)
        Me.Controls.SetChildIndex(Me.lblHora, 0)
        Me.Controls.SetChildIndex(Me.lblValor, 0)
        Me.Controls.SetChildIndex(Me.butVerAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.cboAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.lblAnalistaID, 0)
        Me.Controls.SetChildIndex(Me.butAddParametroID, 0)
        Me.Controls.SetChildIndex(Me.butVerParametroID, 0)
        Me.Controls.SetChildIndex(Me.cboParametroID, 0)
        Me.Controls.SetChildIndex(Me.lblParametroID, 0)
        Me.Controls.SetChildIndex(Me.txtEnvasadoProductoAnaliticaID, 0)
        Me.Controls.SetChildIndex(Me.lblEnvasadoProductoAnaliticaID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents lblEnvasadoProductoAnaliticaID As System.Windows.Forms.Label
    Private WithEvents txtEnvasadoProductoAnaliticaID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEnvasadoProductoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblEnvasadoProductoID As System.Windows.Forms.Label
    Private WithEvents lblParametroID As System.Windows.Forms.Label
    Private WithEvents cboParametroID As System.Windows.Forms.ComboBox
    Private WithEvents butVerParametroID As System.Windows.Forms.Button
    Private WithEvents butAddParametroID As System.Windows.Forms.Button
    Private WithEvents lblAnalistaID As System.Windows.Forms.Label
    Private WithEvents cboAnalistaID As System.Windows.Forms.ComboBox
    Private WithEvents butVerAnalistaID As System.Windows.Forms.Button
    Private WithEvents lblValor As System.Windows.Forms.Label
    Private WithEvents lblHora As System.Windows.Forms.Label
    Private WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtValor As BasesParaCompatibilidad.CuadroDeTexto
End Class
