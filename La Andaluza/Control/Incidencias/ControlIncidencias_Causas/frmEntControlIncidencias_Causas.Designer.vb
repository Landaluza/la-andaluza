<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_Causas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_Causas))
        Me.cbocausa = New System.Windows.Forms.ComboBox()
        Me.butVerId_causa = New System.Windows.Forms.Button()
        Me.butAddId_causa = New System.Windows.Forms.Button()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblId_causa = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbocausa
        '
        Me.cbocausa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbocausa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbocausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocausa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocausa.Location = New System.Drawing.Point(146, 50)
        Me.cbocausa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbocausa.Name = "cbocausa"
        Me.cbocausa.Size = New System.Drawing.Size(388, 23)
        Me.cbocausa.TabIndex = 5
        '
        'butVerId_causa
        '
        Me.butVerId_causa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_causa.FlatAppearance.BorderSize = 0
        Me.butVerId_causa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_causa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_causa.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_causa.Location = New System.Drawing.Point(538, 51)
        Me.butVerId_causa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_causa.Name = "butVerId_causa"
        Me.butVerId_causa.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_causa.TabIndex = 6
        Me.butVerId_causa.TabStop = False
        '
        'butAddId_causa
        '
        Me.butAddId_causa.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_causa.FlatAppearance.BorderSize = 0
        Me.butAddId_causa.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_causa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_causa.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_causa.Location = New System.Drawing.Point(560, 51)
        Me.butAddId_causa.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_causa.Name = "butAddId_causa"
        Me.butAddId_causa.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_causa.TabIndex = 7
        Me.butAddId_causa.TabStop = False
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(146, 76)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(388, 23)
        Me.cboempleado.TabIndex = 9
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(538, 77)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_empleado.TabIndex = 10
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(560, 77)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_empleado.TabIndex = 11
        Me.butAddId_empleado.TabStop = False
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
        Me.txtObservaciones.Location = New System.Drawing.Point(146, 106)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(433, 58)
        Me.txtObservaciones.TabIndex = 13
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(146, 168)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 15
        '
        'lblId_causa
        '
        Me.lblId_causa.Location = New System.Drawing.Point(29, 48)
        Me.lblId_causa.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_causa.Name = "lblId_causa"
        Me.lblId_causa.Size = New System.Drawing.Size(112, 30)
        Me.lblId_causa.TabIndex = 4
        Me.lblId_causa.Text = "Causa"
        Me.lblId_causa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Location = New System.Drawing.Point(29, 74)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(112, 30)
        Me.lblId_empleado.TabIndex = 8
        Me.lblId_empleado.Text = "Responsable"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(29, 104)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(112, 28)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(29, 166)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(112, 28)
        Me.lblFecha.TabIndex = 14
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntControlIncidencias_Causas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(614, 220)
        Me.Controls.Add(Me.cbocausa)
        Me.Controls.Add(Me.lblId_empleado)
        Me.Controls.Add(Me.cboempleado)
        Me.Controls.Add(Me.lblId_causa)
        Me.Controls.Add(Me.butVerId_empleado)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.butVerId_causa)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butAddId_causa)
        Me.Controls.Add(Me.butAddId_empleado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias_Causas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_Causas"
        Me.Controls.SetChildIndex(Me.butAddId_empleado, 0)
        Me.Controls.SetChildIndex(Me.butAddId_causa, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.butVerId_causa, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.butVerId_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblId_causa, 0)
        Me.Controls.SetChildIndex(Me.cboempleado, 0)
        Me.Controls.SetChildIndex(Me.lblId_empleado, 0)
        Me.Controls.SetChildIndex(Me.cbocausa, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cbocausa As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_causa As System.Windows.Forms.Button
    Private WithEvents butAddId_causa As System.Windows.Forms.Button
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents lblId_causa As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
End Class
