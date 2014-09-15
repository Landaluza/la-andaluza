<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlesLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlesLotes))
        Me.txtResultado = New System.Windows.Forms.TextBox()
        Me.chbCorrecto = New System.Windows.Forms.CheckBox()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtRutaControl = New System.Windows.Forms.TextBox()
        Me.butRutaControl = New System.Windows.Forms.Button()
        Me.butAddId_controlIncidencia = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblResultado = New System.Windows.Forms.Label()
        Me.lblCorrecto = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblRutaControl = New System.Windows.Forms.Label()
        Me.lblId_controlIncidencia = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.txtControlIncidencia = New System.Windows.Forms.TextBox()
        Me.btnLimpiarIncidencia = New System.Windows.Forms.Button()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtResultado
        '
        Me.txtResultado.BackColor = System.Drawing.SystemColors.Window
        Me.txtResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtResultado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultado.Location = New System.Drawing.Point(140, 14)
        Me.txtResultado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtResultado.MaxLength = 500
        Me.txtResultado.Name = "txtResultado"
        Me.txtResultado.Size = New System.Drawing.Size(181, 21)
        Me.txtResultado.TabIndex = 2
        '
        'chbCorrecto
        '
        Me.chbCorrecto.BackColor = System.Drawing.SystemColors.Control
        Me.chbCorrecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCorrecto.Location = New System.Drawing.Point(140, 42)
        Me.chbCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbCorrecto.Name = "chbCorrecto"
        Me.chbCorrecto.Size = New System.Drawing.Size(181, 21)
        Me.chbCorrecto.TabIndex = 3
        Me.chbCorrecto.UseVisualStyleBackColor = False
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(140, 67)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(181, 23)
        Me.cboempleado.TabIndex = 4
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_empleado.Location = New System.Drawing.Point(325, 67)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_empleado.TabIndex = 9
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(347, 67)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_empleado.TabIndex = 10
        Me.butAddId_empleado.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(140, 97)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 5
        '
        'txtRutaControl
        '
        Me.txtRutaControl.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtRutaControl, 4)
        Me.txtRutaControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRutaControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaControl.Location = New System.Drawing.Point(140, 125)
        Me.txtRutaControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaControl.MaxLength = 250
        Me.txtRutaControl.Name = "txtRutaControl"
        Me.txtRutaControl.Size = New System.Drawing.Size(253, 21)
        Me.txtRutaControl.TabIndex = 6
        '
        'butRutaControl
        '
        Me.butRutaControl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRutaControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butRutaControl.FlatAppearance.BorderSize = 0
        Me.butRutaControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaControl.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaControl.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaControl.Location = New System.Drawing.Point(397, 125)
        Me.butRutaControl.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaControl.Name = "butRutaControl"
        Me.butRutaControl.Size = New System.Drawing.Size(18, 24)
        Me.butRutaControl.TabIndex = 13
        Me.butRutaControl.TabStop = False
        '
        'butAddId_controlIncidencia
        '
        Me.butAddId_controlIncidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_controlIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_controlIncidencia.FlatAppearance.BorderSize = 0
        Me.butAddId_controlIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_controlIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_controlIncidencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_controlIncidencia.Location = New System.Drawing.Point(325, 153)
        Me.butAddId_controlIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_controlIncidencia.Name = "butAddId_controlIncidencia"
        Me.butAddId_controlIncidencia.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_controlIncidencia.TabIndex = 16
        Me.butAddId_controlIncidencia.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(140, 183)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(253, 51)
        Me.txtObservaciones.TabIndex = 8
        '
        'lblResultado
        '
        Me.lblResultado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResultado.Location = New System.Drawing.Point(20, 12)
        Me.lblResultado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultado.Name = "lblResultado"
        Me.lblResultado.Size = New System.Drawing.Size(116, 28)
        Me.lblResultado.TabIndex = 6
        Me.lblResultado.Text = "Resultado"
        Me.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCorrecto
        '
        Me.lblCorrecto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCorrecto.Location = New System.Drawing.Point(20, 40)
        Me.lblCorrecto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCorrecto.Name = "lblCorrecto"
        Me.lblCorrecto.Size = New System.Drawing.Size(116, 25)
        Me.lblCorrecto.TabIndex = 7
        Me.lblCorrecto.Text = "Correcto"
        Me.lblCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_empleado.Location = New System.Drawing.Point(20, 65)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(116, 30)
        Me.lblId_empleado.TabIndex = 8
        Me.lblId_empleado.Text = "Empleado"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Location = New System.Drawing.Point(20, 95)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(116, 28)
        Me.lblFecha.TabIndex = 11
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaControl
        '
        Me.lblRutaControl.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRutaControl.Location = New System.Drawing.Point(20, 123)
        Me.lblRutaControl.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaControl.Name = "lblRutaControl"
        Me.lblRutaControl.Size = New System.Drawing.Size(116, 28)
        Me.lblRutaControl.TabIndex = 12
        Me.lblRutaControl.Text = "Ruta"
        Me.lblRutaControl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_controlIncidencia
        '
        Me.lblId_controlIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_controlIncidencia.Location = New System.Drawing.Point(20, 151)
        Me.lblId_controlIncidencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_controlIncidencia.Name = "lblId_controlIncidencia"
        Me.lblId_controlIncidencia.Size = New System.Drawing.Size(116, 30)
        Me.lblId_controlIncidencia.TabIndex = 14
        Me.lblId_controlIncidencia.Text = "Control incidencia"
        Me.lblId_controlIncidencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 181)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(116, 55)
        Me.lblObservaciones.TabIndex = 17
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMiddle.Controls.Add(Me.lblResultado, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtResultado, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCorrecto, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.chbCorrecto, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblId_empleado, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboempleado, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerId_empleado, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddId_empleado, 4, 4)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblRutaControl, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtRutaControl, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.butRutaControl, 6, 6)
        Me.tlpMiddle.Controls.Add(Me.lblId_controlIncidencia, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.txtControlIncidencia, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.butAddId_controlIncidencia, 3, 7)
        Me.tlpMiddle.Controls.Add(Me.btnLimpiarIncidencia, 4, 7)
        Me.tlpMiddle.Location = New System.Drawing.Point(22, 44)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 10
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(440, 235)
        Me.tlpMiddle.TabIndex = 8
        '
        'txtControlIncidencia
        '
        Me.txtControlIncidencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtControlIncidencia.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtControlIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtControlIncidencia.Enabled = False
        Me.txtControlIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlIncidencia.Location = New System.Drawing.Point(140, 153)
        Me.txtControlIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtControlIncidencia.MaxLength = 500
        Me.txtControlIncidencia.Name = "txtControlIncidencia"
        Me.txtControlIncidencia.Size = New System.Drawing.Size(181, 21)
        Me.txtControlIncidencia.TabIndex = 19
        '
        'btnLimpiarIncidencia
        '
        Me.btnLimpiarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarIncidencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.btnLimpiarIncidencia.FlatAppearance.BorderSize = 0
        Me.btnLimpiarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarIncidencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnLimpiarIncidencia.Location = New System.Drawing.Point(347, 153)
        Me.btnLimpiarIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiarIncidencia.Name = "btnLimpiarIncidencia"
        Me.btnLimpiarIncidencia.Size = New System.Drawing.Size(18, 26)
        Me.btnLimpiarIncidencia.TabIndex = 18
        Me.btnLimpiarIncidencia.TabStop = False
        Me.MyToolTip.SetToolTip(Me.btnLimpiarIncidencia, "No añadir controld e incidencia")
        '
        'tlpTop
        '




        '
        'frmEntControlesLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(501, 311)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlesLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlesLotes"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtResultado As System.Windows.Forms.TextBox
    Private WithEvents chbCorrecto As System.Windows.Forms.CheckBox
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRutaControl As System.Windows.Forms.TextBox
    Private WithEvents butRutaControl As System.Windows.Forms.Button
    Private WithEvents butAddId_controlIncidencia As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblResultado As System.Windows.Forms.Label
    Private WithEvents lblCorrecto As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblRutaControl As System.Windows.Forms.Label
    Private WithEvents lblId_controlIncidencia As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

    Private WithEvents btnLimpiarIncidencia As System.Windows.Forms.Button
    Private WithEvents txtControlIncidencia As System.Windows.Forms.TextBox
End Class
