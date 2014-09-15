<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCambiosFormatosEnvasados2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCambiosFormatosEnvasados2))

        Me.lblCambioFormatoEnvasadoId = New System.Windows.Forms.Label()
        Me.txtCambioFormatoEnvasadoId = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPersonalID = New System.Windows.Forms.Label()
        Me.cboPersonalID = New System.Windows.Forms.ComboBox()
        Me.lblTipoformatoInicialID = New System.Windows.Forms.Label()
        Me.cboTipoformatoInicialID = New System.Windows.Forms.ComboBox()
        Me.lblFormatoEnvasadoAID = New System.Windows.Forms.Label()
        Me.cboFormatoEnvasadoAID = New System.Windows.Forms.ComboBox()
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
        'lblCambioFormatoEnvasadoId
        '
        Me.lblCambioFormatoEnvasadoId.Location = New System.Drawing.Point(206, 327)
        Me.lblCambioFormatoEnvasadoId.Name = "lblCambioFormatoEnvasadoId"
        Me.lblCambioFormatoEnvasadoId.Size = New System.Drawing.Size(143, 21)
        Me.lblCambioFormatoEnvasadoId.TabIndex = 1000000002
        Me.lblCambioFormatoEnvasadoId.Text = "CambioFormatoEnvasadoId"
        Me.lblCambioFormatoEnvasadoId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCambioFormatoEnvasadoId.Visible = False
        '
        'txtCambioFormatoEnvasadoId
        '
        Me.txtCambioFormatoEnvasadoId.BackColor = System.Drawing.SystemColors.Window
        Me.txtCambioFormatoEnvasadoId.Enabled = False
        Me.txtCambioFormatoEnvasadoId.EsUnicoCampo = ""
        Me.txtCambioFormatoEnvasadoId.EsUnicoCampoID = ""
        Me.txtCambioFormatoEnvasadoId.EsUnicoID = 0
        Me.txtCambioFormatoEnvasadoId.EsUnicoTabla = ""
        Me.txtCambioFormatoEnvasadoId.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCambioFormatoEnvasadoId.Location = New System.Drawing.Point(355, 327)
        Me.txtCambioFormatoEnvasadoId.MaxLength = 9
        Me.txtCambioFormatoEnvasadoId.Minimo = 0
        Me.txtCambioFormatoEnvasadoId.Modificado = False
        Me.txtCambioFormatoEnvasadoId.Name = "txtCambioFormatoEnvasadoId"
        Me.txtCambioFormatoEnvasadoId.Numerico_EsNumerico = False
        Me.txtCambioFormatoEnvasadoId.Numerico_NumeroDoublees = 0
        Me.txtCambioFormatoEnvasadoId.Numerico_SeparadorMiles = False
        Me.txtCambioFormatoEnvasadoId.Obligatorio = True
        Me.txtCambioFormatoEnvasadoId.ParametroID = 0
        Me.txtCambioFormatoEnvasadoId.Size = New System.Drawing.Size(56, 21)
        Me.txtCambioFormatoEnvasadoId.TabIndex = 1000000001
        Me.txtCambioFormatoEnvasadoId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCambioFormatoEnvasadoId.ValorMaximo = 0.0R
        Me.txtCambioFormatoEnvasadoId.ValorMinimo = 0.0R
        Me.txtCambioFormatoEnvasadoId.Visible = False
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(17, 95)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(109, 21)
        Me.lblHoraInicio.TabIndex = 4
        Me.lblHoraInicio.Text = "HoraInicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(132, 94)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraInicio.TabIndex = 5
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(343, 98)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(56, 21)
        Me.lblHoraFin.TabIndex = 6
        Me.lblHoraFin.Text = "HoraFin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(405, 98)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(95, 21)
        Me.dtpHoraFin.TabIndex = 7
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(11, 156)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(115, 21)
        Me.lblObservacion.TabIndex = 10
        Me.lblObservacion.Text = "Observacion"
        Me.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservacion.EsUnicoCampo = ""
        Me.txtObservacion.EsUnicoCampoID = ""
        Me.txtObservacion.EsUnicoID = 0
        Me.txtObservacion.EsUnicoTabla = ""
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(132, 156)
        Me.txtObservacion.MaxLength = 500
        Me.txtObservacion.Minimo = 0
        Me.txtObservacion.Modificado = False
        Me.txtObservacion.Multiline = True
        Me.txtObservacion.Name = "txtObservacion"
        Me.txtObservacion.Numerico_EsNumerico = False
        Me.txtObservacion.Numerico_NumeroDoublees = 0
        Me.txtObservacion.Numerico_SeparadorMiles = False
        Me.txtObservacion.Obligatorio = False
        Me.txtObservacion.ParametroID = 0
        Me.txtObservacion.Size = New System.Drawing.Size(368, 78)
        Me.txtObservacion.TabIndex = 11
        Me.txtObservacion.ValorMaximo = 0.0R
        Me.txtObservacion.ValorMinimo = 0.0R
        '
        'lblPersonalID
        '
        Me.lblPersonalID.Location = New System.Drawing.Point(11, 124)
        Me.lblPersonalID.Name = "lblPersonalID"
        Me.lblPersonalID.Size = New System.Drawing.Size(115, 21)
        Me.lblPersonalID.TabIndex = 8
        Me.lblPersonalID.Text = "Personal"
        Me.lblPersonalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPersonalID
        '
        Me.cboPersonalID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPersonalID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonalID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPersonalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonalID.Location = New System.Drawing.Point(132, 124)
        Me.cboPersonalID.Name = "cboPersonalID"
        Me.cboPersonalID.Size = New System.Drawing.Size(368, 23)
        Me.cboPersonalID.TabIndex = 9
        '
        'lblTipoformatoInicialID
        '
        Me.lblTipoformatoInicialID.Location = New System.Drawing.Point(11, 38)
        Me.lblTipoformatoInicialID.Name = "lblTipoformatoInicialID"
        Me.lblTipoformatoInicialID.Size = New System.Drawing.Size(115, 21)
        Me.lblTipoformatoInicialID.TabIndex = 0
        Me.lblTipoformatoInicialID.Text = "Formato Inicial"
        Me.lblTipoformatoInicialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTipoformatoInicialID
        '
        Me.cboTipoformatoInicialID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoformatoInicialID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoformatoInicialID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoformatoInicialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoformatoInicialID.Location = New System.Drawing.Point(132, 38)
        Me.cboTipoformatoInicialID.Name = "cboTipoformatoInicialID"
        Me.cboTipoformatoInicialID.Size = New System.Drawing.Size(368, 23)
        Me.cboTipoformatoInicialID.TabIndex = 1
        '
        'lblFormatoEnvasadoAID
        '
        Me.lblFormatoEnvasadoAID.Location = New System.Drawing.Point(8, 69)
        Me.lblFormatoEnvasadoAID.Name = "lblFormatoEnvasadoAID"
        Me.lblFormatoEnvasadoAID.Size = New System.Drawing.Size(118, 21)
        Me.lblFormatoEnvasadoAID.TabIndex = 2
        Me.lblFormatoEnvasadoAID.Text = "Formato a"
        Me.lblFormatoEnvasadoAID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboFormatoEnvasadoAID
        '
        Me.cboFormatoEnvasadoAID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFormatoEnvasadoAID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFormatoEnvasadoAID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFormatoEnvasadoAID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormatoEnvasadoAID.Location = New System.Drawing.Point(132, 67)
        Me.cboFormatoEnvasadoAID.Name = "cboFormatoEnvasadoAID"
        Me.cboFormatoEnvasadoAID.Size = New System.Drawing.Size(368, 23)
        Me.cboFormatoEnvasadoAID.TabIndex = 3
        '
        'frmEntCambiosFormatosEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(580, 258)
        Me.Controls.Add(Me.lblCambioFormatoEnvasadoId)
        Me.Controls.Add(Me.txtCambioFormatoEnvasadoId)
        Me.Controls.Add(Me.lblHoraInicio)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.lblHoraFin)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblPersonalID)
        Me.Controls.Add(Me.cboPersonalID)
        Me.Controls.Add(Me.lblTipoformatoInicialID)
        Me.Controls.Add(Me.cboTipoformatoInicialID)
        Me.Controls.Add(Me.lblFormatoEnvasadoAID)
        Me.Controls.Add(Me.cboFormatoEnvasadoAID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntCambiosFormatosEnvasados2"
        Me.Text = "CambiosFormatosEnvasados2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.cboFormatoEnvasadoAID, 0)
        Me.Controls.SetChildIndex(Me.lblFormatoEnvasadoAID, 0)
        Me.Controls.SetChildIndex(Me.cboTipoformatoInicialID, 0)
        Me.Controls.SetChildIndex(Me.lblTipoformatoInicialID, 0)
        Me.Controls.SetChildIndex(Me.cboPersonalID, 0)
        Me.Controls.SetChildIndex(Me.lblPersonalID, 0)
        Me.Controls.SetChildIndex(Me.txtObservacion, 0)
        Me.Controls.SetChildIndex(Me.lblObservacion, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraFin, 0)
        Me.Controls.SetChildIndex(Me.lblHoraFin, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraInicio, 0)
        Me.Controls.SetChildIndex(Me.lblHoraInicio, 0)
        Me.Controls.SetChildIndex(Me.txtCambioFormatoEnvasadoId, 0)
        Me.Controls.SetChildIndex(Me.lblCambioFormatoEnvasadoId, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents lblCambioFormatoEnvasadoId As System.Windows.Forms.Label
    Private WithEvents txtCambioFormatoEnvasadoId As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents lblObservacion As System.Windows.Forms.Label
    Private WithEvents txtObservacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPersonalID As System.Windows.Forms.Label
    Private WithEvents cboPersonalID As System.Windows.Forms.ComboBox
    Private WithEvents lblTipoformatoInicialID As System.Windows.Forms.Label
    Private WithEvents cboTipoformatoInicialID As System.Windows.Forms.ComboBox
    Private WithEvents lblFormatoEnvasadoAID As System.Windows.Forms.Label
    Private WithEvents cboFormatoEnvasadoAID As System.Windows.Forms.ComboBox
End Class
