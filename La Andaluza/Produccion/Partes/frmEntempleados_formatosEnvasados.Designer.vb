<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntempleados_formatosEnvasados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntempleados_formatosEnvasados))

        Me.lblid_empleado = New System.Windows.Forms.Label()
        Me.lblInicio = New System.Windows.Forms.Label()
        Me.lblFin = New System.Windows.Forms.Label()
        Me.dtpFin = New System.Windows.Forms.DateTimePicker()
        Me.dtpInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.butVerid_empleado = New System.Windows.Forms.Button()
        Me.butAddid_empleado = New System.Windows.Forms.Button()
        Me.panGeneral = New System.Windows.Forms.Panel()
        Me.cbFin = New System.Windows.Forms.CheckBox()
        Me.cbApoyo = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panGeneral.SuspendLayout()
        Me.SuspendLayout()
        '
        'tlpTop
        '




        '
        'lblid_empleado
        '
        Me.lblid_empleado.Location = New System.Drawing.Point(10, 16)
        Me.lblid_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(104, 30)
        Me.lblid_empleado.TabIndex = 3
        Me.lblid_empleado.Text = "Empleado"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblInicio
        '
        Me.lblInicio.Location = New System.Drawing.Point(10, 46)
        Me.lblInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblInicio.Name = "lblInicio"
        Me.lblInicio.Size = New System.Drawing.Size(104, 28)
        Me.lblInicio.TabIndex = 6
        Me.lblInicio.Text = "Inicio"
        Me.lblInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFin
        '
        Me.lblFin.Location = New System.Drawing.Point(10, 74)
        Me.lblFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFin.Name = "lblFin"
        Me.lblFin.Size = New System.Drawing.Size(104, 28)
        Me.lblFin.TabIndex = 7
        Me.lblFin.Text = "Fin"
        Me.lblFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpFin
        '
        Me.dtpFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFin.CustomFormat = "HH:mm"
        Me.dtpFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFin.Location = New System.Drawing.Point(118, 77)
        Me.dtpFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFin.Name = "dtpFin"
        Me.dtpFin.ShowUpDown = True
        Me.dtpFin.Size = New System.Drawing.Size(63, 21)
        Me.dtpFin.TabIndex = 3
        '
        'dtpInicio
        '
        Me.dtpInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpInicio.CustomFormat = "HH:mm"
        Me.dtpInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpInicio.Location = New System.Drawing.Point(118, 48)
        Me.dtpInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpInicio.Name = "dtpInicio"
        Me.dtpInicio.ShowUpDown = True
        Me.dtpInicio.Size = New System.Drawing.Size(63, 21)
        Me.dtpInicio.TabIndex = 2
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(118, 18)
        Me.cboid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(305, 23)
        Me.cboid_empleado.TabIndex = 1
        '
        'butVerid_empleado
        '
        Me.butVerid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_empleado.FlatAppearance.BorderSize = 0
        Me.butVerid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_empleado.Location = New System.Drawing.Point(426, 19)
        Me.butVerid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_empleado.Name = "butVerid_empleado"
        Me.butVerid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_empleado.TabIndex = 4
        Me.butVerid_empleado.TabStop = False
        '
        'butAddid_empleado
        '
        Me.butAddid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_empleado.FlatAppearance.BorderSize = 0
        Me.butAddid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_empleado.Location = New System.Drawing.Point(446, 19)
        Me.butAddid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_empleado.Name = "butAddid_empleado"
        Me.butAddid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_empleado.TabIndex = 5
        Me.butAddid_empleado.TabStop = False
        '
        'panGeneral
        '
        Me.panGeneral.Controls.Add(Me.cbFin)
        Me.panGeneral.Controls.Add(Me.cbApoyo)
        Me.panGeneral.Controls.Add(Me.cboid_empleado)
        Me.panGeneral.Controls.Add(Me.lblFin)
        Me.panGeneral.Controls.Add(Me.dtpFin)
        Me.panGeneral.Controls.Add(Me.lblid_empleado)
        Me.panGeneral.Controls.Add(Me.butAddid_empleado)
        Me.panGeneral.Controls.Add(Me.butVerid_empleado)
        Me.panGeneral.Controls.Add(Me.dtpInicio)
        Me.panGeneral.Controls.Add(Me.lblInicio)
        Me.panGeneral.Location = New System.Drawing.Point(0, 28)
        Me.panGeneral.Name = "panGeneral"
        Me.panGeneral.Size = New System.Drawing.Size(477, 139)
        Me.panGeneral.TabIndex = 1000000003
        '
        'cbFin
        '
        Me.cbFin.AutoSize = True
        Me.cbFin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbFin.Location = New System.Drawing.Point(100, 79)
        Me.cbFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbFin.Name = "cbFin"
        Me.cbFin.Size = New System.Drawing.Size(12, 11)
        Me.cbFin.TabIndex = 10
        Me.cbFin.UseVisualStyleBackColor = True
        '
        'cbApoyo
        '
        Me.cbApoyo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cbApoyo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbApoyo.Location = New System.Drawing.Point(9, 103)
        Me.cbApoyo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbApoyo.Name = "cbApoyo"
        Me.cbApoyo.Size = New System.Drawing.Size(104, 17)
        Me.cbApoyo.TabIndex = 9
        Me.cbApoyo.Text = "Apoyo de linea"
        Me.cbApoyo.UseVisualStyleBackColor = True
        '
        'frmEntempleados_formatosEnvasados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(487, 182)
        Me.Controls.Add(Me.panGeneral)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(404, 184)
        Me.Name = "frmEntempleados_formatosEnvasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "empleados_formatosEnvasados"
        Me.Controls.SetChildIndex(Me.panGeneral, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panGeneral.ResumeLayout(False)
        Me.panGeneral.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents panGeneral As System.Windows.Forms.Panel
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
    Private WithEvents lblInicio As System.Windows.Forms.Label
    Private WithEvents lblFin As System.Windows.Forms.Label
    Private WithEvents dtpFin As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_empleado As System.Windows.Forms.Button
    Private WithEvents butAddid_empleado As System.Windows.Forms.Button
    Private WithEvents cbApoyo As System.Windows.Forms.CheckBox
    Private WithEvents cbFin As System.Windows.Forms.CheckBox
End Class
