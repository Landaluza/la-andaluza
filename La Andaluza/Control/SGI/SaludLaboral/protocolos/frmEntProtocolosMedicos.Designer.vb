<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProtocolosMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProtocolosMedicos))
        Me.txtReferencia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.cboMedico = New System.Windows.Forms.ComboBox()
        Me.butVerMedico = New System.Windows.Forms.Button()
        Me.butAddMedico = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblMedico = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferencia.EsUnicoCampo = ""
        Me.txtReferencia.EsUnicoCampoID = ""
        Me.txtReferencia.EsUnicoID = 0
        Me.txtReferencia.EsUnicoTabla = ""
        Me.txtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(147, 45)
        Me.txtReferencia.MaxLength = 60
        Me.txtReferencia.Minimo = 0
        Me.txtReferencia.Modificado = False
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Numerico_EsNumerico = False
        Me.txtReferencia.Numerico_NumeroDoublees = 0
        Me.txtReferencia.Numerico_SeparadorMiles = False
        Me.txtReferencia.Obligatorio = False
        Me.txtReferencia.ParametroID = 0
        Me.txtReferencia.Size = New System.Drawing.Size(200, 21)
        Me.txtReferencia.TabIndex = 0
        Me.txtReferencia.ValorMaximo = 0.0R
        Me.txtReferencia.ValorMinimo = 0.0R
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(147, 72)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(467, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(147, 99)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(95, 21)
        Me.dtpFechaInicio.TabIndex = 2
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(147, 126)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(95, 21)
        Me.dtpFechaFinal.TabIndex = 3
        '
        'cboMedico
        '
        Me.cboMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedico.Location = New System.Drawing.Point(147, 153)
        Me.cboMedico.Name = "cboMedico"
        Me.cboMedico.Size = New System.Drawing.Size(415, 23)
        Me.cboMedico.TabIndex = 4
        '
        'butVerMedico
        '
        Me.butVerMedico.FlatAppearance.BorderSize = 0
        Me.butVerMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerMedico.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerMedico.Location = New System.Drawing.Point(568, 153)
        Me.butVerMedico.Name = "butVerMedico"
        Me.butVerMedico.Size = New System.Drawing.Size(20, 20)
        Me.butVerMedico.TabIndex = 5
        Me.butVerMedico.TabStop = False
        '
        'butAddMedico
        '
        Me.butAddMedico.FlatAppearance.BorderSize = 0
        Me.butAddMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMedico.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMedico.Location = New System.Drawing.Point(594, 153)
        Me.butAddMedico.Name = "butAddMedico"
        Me.butAddMedico.Size = New System.Drawing.Size(20, 20)
        Me.butAddMedico.TabIndex = 6
        Me.butAddMedico.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(147, 182)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(467, 21)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(147, 209)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(16, 21)
        Me.chbVigente.TabIndex = 6
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(35, 42)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(106, 21)
        Me.lblReferencia.TabIndex = 0
        Me.lblReferencia.Text = "Referencia"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(35, 69)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(106, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(35, 96)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(106, 21)
        Me.lblFechaInicio.TabIndex = 2
        Me.lblFechaInicio.Text = "FechaInicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(35, 123)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(106, 21)
        Me.lblFechaFinal.TabIndex = 3
        Me.lblFechaFinal.Text = "FechaFinal"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedico
        '
        Me.lblMedico.Location = New System.Drawing.Point(35, 150)
        Me.lblMedico.Name = "lblMedico"
        Me.lblMedico.Size = New System.Drawing.Size(106, 21)
        Me.lblMedico.TabIndex = 4
        Me.lblMedico.Text = "Medico"
        Me.lblMedico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(35, 179)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(106, 21)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Location = New System.Drawing.Point(35, 206)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(106, 21)
        Me.lblVigente.TabIndex = 8
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntProtocolosMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(654, 249)
        Me.Controls.Add(Me.cboMedico)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.chbVigente)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblVigente)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.butAddMedico)
        Me.Controls.Add(Me.lblMedico)
        Me.Controls.Add(Me.butVerMedico)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntProtocolosMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProtocolosMedicos"
        Me.Controls.SetChildIndex(Me.butVerMedico, 0)
        Me.Controls.SetChildIndex(Me.lblMedico, 0)
        Me.Controls.SetChildIndex(Me.butAddMedico, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.lblVigente, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.chbVigente, 0)
        Me.Controls.SetChildIndex(Me.lblFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        Me.Controls.SetChildIndex(Me.lblReferencia, 0)
        Me.Controls.SetChildIndex(Me.cboMedico, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtReferencia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents cboMedico As System.Windows.Forms.ComboBox
    Private WithEvents butVerMedico As System.Windows.Forms.Button
    Private WithEvents butAddMedico As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents chbVigente As System.Windows.Forms.CheckBox
   Private WithEvents lblReferencia As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblFechaInicio As System.Windows.Forms.Label
   Private WithEvents lblFechaFinal As System.Windows.Forms.Label
   Private WithEvents lblMedico As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblVigente As System.Windows.Forms.Label

End Class
