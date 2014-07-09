<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntVelocidadEnvasados2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntVelocidadEnvasados2))

        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblVelocidad = New System.Windows.Forms.Label()
        Me.txtVelocidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblObservacion = New System.Windows.Forms.Label()
        Me.txtObservacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPersonalID = New System.Windows.Forms.Label()
        Me.cboPersonalID = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)

        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(25, 41)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(83, 21)
        Me.lblHoraInicio.TabIndex = 1
        Me.lblHoraInicio.Text = "HoraInicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(137, 38)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(83, 21)
        Me.dtpHoraInicio.TabIndex = 2
        '
        'lblVelocidad
        '
        Me.lblVelocidad.Location = New System.Drawing.Point(28, 66)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(80, 21)
        Me.lblVelocidad.TabIndex = 3
        Me.lblVelocidad.Text = "Velocidad"
        Me.lblVelocidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtVelocidad
        '
        Me.txtVelocidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVelocidad.EsUnicoCampo = ""
        Me.txtVelocidad.EsUnicoCampoID = ""
        Me.txtVelocidad.EsUnicoID = 0
        Me.txtVelocidad.EsUnicoTabla = ""
        Me.txtVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidad.Location = New System.Drawing.Point(137, 65)
        Me.txtVelocidad.MaxLength = 9
        Me.txtVelocidad.Minimo = 0
        Me.txtVelocidad.Modificado = False
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Numerico_EsNumerico = True
        Me.txtVelocidad.Numerico_NumeroDoublees = 0
        Me.txtVelocidad.Numerico_SeparadorMiles = True
        Me.txtVelocidad.Obligatorio = False
        Me.txtVelocidad.ParametroID = 0
        Me.txtVelocidad.Size = New System.Drawing.Size(83, 21)
        Me.txtVelocidad.TabIndex = 4
        Me.txtVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVelocidad.ValorMaximo = 0.0R
        Me.txtVelocidad.ValorMinimo = 0.0R
        '
        'lblObservacion
        '
        Me.lblObservacion.Location = New System.Drawing.Point(25, 122)
        Me.lblObservacion.Name = "lblObservacion"
        Me.lblObservacion.Size = New System.Drawing.Size(83, 21)
        Me.lblObservacion.TabIndex = 7
        Me.lblObservacion.Text = "Observacion"
        Me.lblObservacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservacion
        '
        Me.txtObservacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservacion.EsUnicoCampo = ""
        Me.txtObservacion.EsUnicoCampoID = ""
        Me.txtObservacion.EsUnicoID = 0
        Me.txtObservacion.EsUnicoTabla = ""
        Me.txtObservacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservacion.Location = New System.Drawing.Point(137, 121)
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
        Me.txtObservacion.Size = New System.Drawing.Size(236, 104)
        Me.txtObservacion.TabIndex = 8
        Me.txtObservacion.ValorMaximo = 0.0R
        Me.txtObservacion.ValorMinimo = 0.0R
        '
        'lblPersonalID
        '
        Me.lblPersonalID.Location = New System.Drawing.Point(25, 94)
        Me.lblPersonalID.Name = "lblPersonalID"
        Me.lblPersonalID.Size = New System.Drawing.Size(83, 21)
        Me.lblPersonalID.TabIndex = 5
        Me.lblPersonalID.Text = "Personal"
        Me.lblPersonalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPersonalID
        '
        Me.cboPersonalID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPersonalID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonalID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPersonalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonalID.Location = New System.Drawing.Point(137, 92)
        Me.cboPersonalID.Name = "cboPersonalID"
        Me.cboPersonalID.Size = New System.Drawing.Size(236, 23)
        Me.cboPersonalID.TabIndex = 6
        '
        'frmEntVelocidadEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(421, 250)
        Me.Controls.Add(Me.lblHoraInicio)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.lblObservacion)
        Me.Controls.Add(Me.txtObservacion)
        Me.Controls.Add(Me.lblPersonalID)
        Me.Controls.Add(Me.cboPersonalID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(372, 247)
        Me.Name = "frmEntVelocidadEnvasados2"
        Me.Text = "VelocidadEnvasados2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.cboPersonalID, 0)
        Me.Controls.SetChildIndex(Me.lblPersonalID, 0)
        Me.Controls.SetChildIndex(Me.txtObservacion, 0)
        Me.Controls.SetChildIndex(Me.lblObservacion, 0)
        Me.Controls.SetChildIndex(Me.txtVelocidad, 0)
        Me.Controls.SetChildIndex(Me.lblVelocidad, 0)
        Me.Controls.SetChildIndex(Me.dtpHoraInicio, 0)
        Me.Controls.SetChildIndex(Me.lblHoraInicio, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblVelocidad As System.Windows.Forms.Label
    Private WithEvents txtVelocidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblObservacion As System.Windows.Forms.Label
    Private WithEvents txtObservacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPersonalID As System.Windows.Forms.Label
    Private WithEvents cboPersonalID As System.Windows.Forms.ComboBox
End Class
