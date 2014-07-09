<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotableInformesMensuales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotableInformesMensuales))
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.cboCreador = New System.Windows.Forms.ComboBox()
        Me.butVerCreadorID = New System.Windows.Forms.Button()
        Me.butAddCreadorID = New System.Windows.Forms.Button()
        Me.cboVerificador = New System.Windows.Forms.ComboBox()
        Me.butVerVerificadorID = New System.Windows.Forms.Button()
        Me.butAddVerificadorID = New System.Windows.Forms.Button()
        Me.txtPeriodo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCreadorID = New System.Windows.Forms.Label()
        Me.lblVerificadorID = New System.Windows.Forms.Label()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(112, 31)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 0
        '
        'cboCreador
        '
        Me.cboCreador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCreador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCreador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCreador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCreador.Location = New System.Drawing.Point(112, 59)
        Me.cboCreador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCreador.Name = "cboCreador"
        Me.cboCreador.Size = New System.Drawing.Size(336, 23)
        Me.cboCreador.TabIndex = 1
        '
        'butVerCreadorID
        '
        Me.butVerCreadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerCreadorID.FlatAppearance.BorderSize = 0
        Me.butVerCreadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerCreadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerCreadorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerCreadorID.Location = New System.Drawing.Point(452, 62)
        Me.butVerCreadorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerCreadorID.Name = "butVerCreadorID"
        Me.butVerCreadorID.Size = New System.Drawing.Size(18, 19)
        Me.butVerCreadorID.TabIndex = 2
        Me.butVerCreadorID.TabStop = False
        '
        'butAddCreadorID
        '
        Me.butAddCreadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddCreadorID.FlatAppearance.BorderSize = 0
        Me.butAddCreadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddCreadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCreadorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddCreadorID.Location = New System.Drawing.Point(474, 62)
        Me.butAddCreadorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddCreadorID.Name = "butAddCreadorID"
        Me.butAddCreadorID.Size = New System.Drawing.Size(18, 19)
        Me.butAddCreadorID.TabIndex = 3
        Me.butAddCreadorID.TabStop = False
        '
        'cboVerificador
        '
        Me.cboVerificador.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVerificador.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVerificador.Location = New System.Drawing.Point(112, 89)
        Me.cboVerificador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboVerificador.Name = "cboVerificador"
        Me.cboVerificador.Size = New System.Drawing.Size(336, 23)
        Me.cboVerificador.TabIndex = 2
        '
        'butVerVerificadorID
        '
        Me.butVerVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerVerificadorID.FlatAppearance.BorderSize = 0
        Me.butVerVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVerificadorID.Location = New System.Drawing.Point(452, 92)
        Me.butVerVerificadorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerVerificadorID.Name = "butVerVerificadorID"
        Me.butVerVerificadorID.Size = New System.Drawing.Size(18, 19)
        Me.butVerVerificadorID.TabIndex = 5
        Me.butVerVerificadorID.TabStop = False
        '
        'butAddVerificadorID
        '
        Me.butAddVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddVerificadorID.FlatAppearance.BorderSize = 0
        Me.butAddVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVerificadorID.Location = New System.Drawing.Point(474, 92)
        Me.butAddVerificadorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddVerificadorID.Name = "butAddVerificadorID"
        Me.butAddVerificadorID.Size = New System.Drawing.Size(18, 19)
        Me.butAddVerificadorID.TabIndex = 6
        Me.butAddVerificadorID.TabStop = False
        '
        'txtPeriodo
        '
        Me.txtPeriodo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeriodo.EsUnicoCampo = ""
        Me.txtPeriodo.EsUnicoCampoID = ""
        Me.txtPeriodo.EsUnicoID = 0
        Me.txtPeriodo.EsUnicoTabla = ""
        Me.txtPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodo.Location = New System.Drawing.Point(112, 119)
        Me.txtPeriodo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPeriodo.MaxLength = 120
        Me.txtPeriodo.Minimo = 0
        Me.txtPeriodo.Modificado = False
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Numerico_EsNumerico = False
        Me.txtPeriodo.Numerico_NumeroDoublees = 0
        Me.txtPeriodo.Numerico_SeparadorMiles = False
        Me.txtPeriodo.Obligatorio = False
        Me.txtPeriodo.ParametroID = 0
        Me.txtPeriodo.Size = New System.Drawing.Size(336, 21)
        Me.txtPeriodo.TabIndex = 3
        Me.txtPeriodo.ValorMaximo = 0.0R
        Me.txtPeriodo.ValorMinimo = 0.0R
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
        Me.txtRuta.Location = New System.Drawing.Point(112, 147)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(336, 14)
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
        Me.butRuta.Location = New System.Drawing.Point(452, 148)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(18, 20)
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
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 176)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 65)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(17, 28)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(91, 28)
        Me.lblFecha.TabIndex = 0
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCreadorID
        '
        Me.lblCreadorID.Location = New System.Drawing.Point(17, 57)
        Me.lblCreadorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCreadorID.Name = "lblCreadorID"
        Me.lblCreadorID.Size = New System.Drawing.Size(91, 30)
        Me.lblCreadorID.TabIndex = 1
        Me.lblCreadorID.Text = "Creador"
        Me.lblCreadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVerificadorID
        '
        Me.lblVerificadorID.Location = New System.Drawing.Point(17, 87)
        Me.lblVerificadorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVerificadorID.Name = "lblVerificadorID"
        Me.lblVerificadorID.Size = New System.Drawing.Size(91, 30)
        Me.lblVerificadorID.TabIndex = 4
        Me.lblVerificadorID.Text = "Verificador"
        Me.lblVerificadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(17, 117)
        Me.lblPeriodo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(91, 28)
        Me.lblPeriodo.TabIndex = 7
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Location = New System.Drawing.Point(17, 145)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(91, 28)
        Me.lblRuta.TabIndex = 8
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 173)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(91, 28)
        Me.lblObservaciones.TabIndex = 10
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotableInformesMensuales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(517, 274)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblCreadorID)
        Me.Controls.Add(Me.cboCreador)
        Me.Controls.Add(Me.txtRuta)
        Me.Controls.Add(Me.butVerCreadorID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.butAddCreadorID)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblVerificadorID)
        Me.Controls.Add(Me.butRuta)
        Me.Controls.Add(Me.cboVerificador)
        Me.Controls.Add(Me.lblRuta)
        Me.Controls.Add(Me.butVerVerificadorID)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.butAddVerificadorID)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(418, 237)
        Me.Name = "frmEntAguaPotableInformesMensuales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotableInformesMensuales"
        Me.Controls.SetChildIndex(Me.lblPeriodo, 0)
        Me.Controls.SetChildIndex(Me.butAddVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.txtPeriodo, 0)
        Me.Controls.SetChildIndex(Me.butVerVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblRuta, 0)
        Me.Controls.SetChildIndex(Me.cboVerificador, 0)
        Me.Controls.SetChildIndex(Me.butRuta, 0)
        Me.Controls.SetChildIndex(Me.lblVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butAddCreadorID, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butVerCreadorID, 0)
        Me.Controls.SetChildIndex(Me.txtRuta, 0)
        Me.Controls.SetChildIndex(Me.cboCreador, 0)
        Me.Controls.SetChildIndex(Me.lblCreadorID, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents cboCreador As System.Windows.Forms.ComboBox
    Private WithEvents butVerCreadorID As System.Windows.Forms.Button
    Private WithEvents butAddCreadorID As System.Windows.Forms.Button
    Private WithEvents cboVerificador As System.Windows.Forms.ComboBox
    Private WithEvents butVerVerificadorID As System.Windows.Forms.Button
    Private WithEvents butAddVerificadorID As System.Windows.Forms.Button
    Private WithEvents txtPeriodo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblCreadorID As System.Windows.Forms.Label
    Private WithEvents lblVerificadorID As System.Windows.Forms.Label
    Private WithEvents lblPeriodo As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
