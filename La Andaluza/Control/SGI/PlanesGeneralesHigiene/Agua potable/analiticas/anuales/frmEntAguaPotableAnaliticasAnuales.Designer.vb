<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotableAnaliticasAnuales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotableAnaliticasAnuales))
        Me.cboLaboratorio = New System.Windows.Forms.ComboBox()
        Me.butVerLaboratorioID = New System.Windows.Forms.Button()
        Me.butAddLaboratorioID = New System.Windows.Forms.Button()
        Me.cboVerificador = New System.Windows.Forms.ComboBox()
        Me.butVerVerificadorID = New System.Windows.Forms.Button()
        Me.butAddVerificadorID = New System.Windows.Forms.Button()
        Me.chbVerificado = New System.Windows.Forms.CheckBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLaboratorioID = New System.Windows.Forms.Label()
        Me.lblVerificadorID = New System.Windows.Forms.Label()
        Me.lblVerificado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboLaboratorio
        '
        Me.cboLaboratorio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLaboratorio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLaboratorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLaboratorio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLaboratorio.Location = New System.Drawing.Point(121, 50)
        Me.cboLaboratorio.Name = "cboLaboratorio"
        Me.cboLaboratorio.Size = New System.Drawing.Size(200, 23)
        Me.cboLaboratorio.TabIndex = 0
        '
        'butVerLaboratorioID
        '
        Me.butVerLaboratorioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerLaboratorioID.FlatAppearance.BorderSize = 0
        Me.butVerLaboratorioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerLaboratorioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerLaboratorioID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerLaboratorioID.Location = New System.Drawing.Point(327, 50)
        Me.butVerLaboratorioID.Name = "butVerLaboratorioID"
        Me.butVerLaboratorioID.Size = New System.Drawing.Size(20, 20)
        Me.butVerLaboratorioID.TabIndex = 1
        Me.butVerLaboratorioID.TabStop = False
        '
        'butAddLaboratorioID
        '
        Me.butAddLaboratorioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddLaboratorioID.FlatAppearance.BorderSize = 0
        Me.butAddLaboratorioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddLaboratorioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddLaboratorioID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddLaboratorioID.Location = New System.Drawing.Point(353, 50)
        Me.butAddLaboratorioID.Name = "butAddLaboratorioID"
        Me.butAddLaboratorioID.Size = New System.Drawing.Size(20, 20)
        Me.butAddLaboratorioID.TabIndex = 2
        Me.butAddLaboratorioID.TabStop = False
        '
        'cboVerificador
        '
        Me.cboVerificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVerificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVerificador.Location = New System.Drawing.Point(121, 79)
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
        Me.butVerVerificadorID.Location = New System.Drawing.Point(327, 79)
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
        Me.butAddVerificadorID.Location = New System.Drawing.Point(353, 79)
        Me.butAddVerificadorID.Name = "butAddVerificadorID"
        Me.butAddVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVerificadorID.TabIndex = 5
        Me.butAddVerificadorID.TabStop = False
        '
        'chbVerificado
        '
        Me.chbVerificado.BackColor = System.Drawing.SystemColors.Control
        Me.chbVerificado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVerificado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVerificado.Location = New System.Drawing.Point(121, 108)
        Me.chbVerificado.Name = "chbVerificado"
        Me.chbVerificado.Size = New System.Drawing.Size(16, 21)
        Me.chbVerificado.TabIndex = 2
        Me.chbVerificado.UseVisualStyleBackColor = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(121, 135)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 3
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
        Me.txtRuta.Location = New System.Drawing.Point(121, 162)
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
        Me.txtRuta.TabIndex = 4
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
        Me.butRuta.Location = New System.Drawing.Point(407, 162)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(20, 20)
        Me.butRuta.TabIndex = 9
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
        Me.txtObservaciones.Location = New System.Drawing.Point(121, 189)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 14)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblLaboratorioID
        '
        Me.lblLaboratorioID.Location = New System.Drawing.Point(24, 47)
        Me.lblLaboratorioID.Name = "lblLaboratorioID"
        Me.lblLaboratorioID.Size = New System.Drawing.Size(91, 21)
        Me.lblLaboratorioID.TabIndex = 0
        Me.lblLaboratorioID.Text = "Laboratorio"
        Me.lblLaboratorioID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificadorID
        '
        Me.lblVerificadorID.Location = New System.Drawing.Point(24, 76)
        Me.lblVerificadorID.Name = "lblVerificadorID"
        Me.lblVerificadorID.Size = New System.Drawing.Size(91, 21)
        Me.lblVerificadorID.TabIndex = 3
        Me.lblVerificadorID.Text = "Verificador"
        Me.lblVerificadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificado
        '
        Me.lblVerificado.Location = New System.Drawing.Point(24, 105)
        Me.lblVerificado.Name = "lblVerificado"
        Me.lblVerificado.Size = New System.Drawing.Size(91, 21)
        Me.lblVerificado.TabIndex = 6
        Me.lblVerificado.Text = "Verificado"
        Me.lblVerificado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(24, 132)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(91, 21)
        Me.lblFecha.TabIndex = 7
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(24, 159)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(91, 21)
        Me.lblRuta.TabIndex = 8
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(24, 186)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(91, 21)
        Me.lblObservaciones.TabIndex = 10
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotableAnaliticasAnuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(455, 246)
        Me.Controls.Add(Me.lblLaboratorioID)
        Me.Controls.Add(Me.cboLaboratorio)
        Me.Controls.Add(Me.butVerLaboratorioID)
        Me.Controls.Add(Me.butAddLaboratorioID)
        Me.Controls.Add(Me.cboVerificador)
        Me.Controls.Add(Me.lblVerificadorID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butVerVerificadorID)
        Me.Controls.Add(Me.butRuta)
        Me.Controls.Add(Me.butAddVerificadorID)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.lblVerificado)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.chbVerificado)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblFecha)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(452, 248)
        Me.Name = "frmEntAguaPotableAnaliticasAnuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotableAnaliticasAnuales"
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.chbVerificado, 0)
        Me.Controls.SetChildIndex(Me.lblRuta, 0)
        Me.Controls.SetChildIndex(Me.lblVerificado, 0)
        Me.Controls.SetChildIndex(Me.txtRuta, 0)
        Me.Controls.SetChildIndex(Me.butAddVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.butRuta, 0)
        Me.Controls.SetChildIndex(Me.butVerVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.cboVerificador, 0)
        Me.Controls.SetChildIndex(Me.butAddLaboratorioID, 0)
        Me.Controls.SetChildIndex(Me.butVerLaboratorioID, 0)
        Me.Controls.SetChildIndex(Me.cboLaboratorio, 0)
        Me.Controls.SetChildIndex(Me.lblLaboratorioID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboLaboratorio As System.Windows.Forms.ComboBox
    Private WithEvents butVerLaboratorioID As System.Windows.Forms.Button
    Private WithEvents butAddLaboratorioID As System.Windows.Forms.Button
    Private WithEvents cboVerificador As System.Windows.Forms.ComboBox
    Private WithEvents butVerVerificadorID As System.Windows.Forms.Button
    Private WithEvents butAddVerificadorID As System.Windows.Forms.Button
    Private WithEvents chbVerificado As System.Windows.Forms.CheckBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLaboratorioID As System.Windows.Forms.Label
    Private WithEvents lblVerificadorID As System.Windows.Forms.Label
    Private WithEvents lblVerificado As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
