<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEnvasados2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MonthCalendar = New System.Windows.Forms.MonthCalendar()
        Me.PanDBelow = New System.Windows.Forms.Panel()
        Me.panExtras = New System.Windows.Forms.Panel()
        Me.btnLinea = New System.Windows.Forms.Button()
        Me.btnCajas = New System.Windows.Forms.Button()
        Me.btnBotellas = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btnConfigurarImpresora = New System.Windows.Forms.Button()
        Me.Panconversor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJuliana = New System.Windows.Forms.TextBox()
        Me.btnJulianaToGregoriana = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGregorianaToJuliana = New System.Windows.Forms.Button()
        Me.dtpGregoriana = New System.Windows.Forms.DateTimePicker()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanDBelow.SuspendLayout()
        Me.panExtras.SuspendLayout()
        Me.Panconversor.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonthCalendar
        '
        Me.MonthCalendar.CalendarDimensions = New System.Drawing.Size(3, 2)
        Me.MonthCalendar.FirstDayOfWeek = System.Windows.Forms.Day.Monday
        Me.MonthCalendar.ForeColor = System.Drawing.SystemColors.WindowText
        Me.MonthCalendar.Location = New System.Drawing.Point(28, 25)
        Me.MonthCalendar.MaxDate = New Date(2012, 12, 31, 0, 0, 0, 0)
        Me.MonthCalendar.Name = "MonthCalendar"
        Me.MonthCalendar.TabIndex = 0
        '
        'PanDBelow
        '
        Me.PanDBelow.Controls.Add(Me.panExtras)
        Me.PanDBelow.Controls.Add(Me.btnConfigurarImpresora)
        Me.PanDBelow.Controls.Add(Me.Panconversor)
        Me.PanDBelow.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanDBelow.Location = New System.Drawing.Point(0, 473)
        Me.PanDBelow.Name = "PanDBelow"
        Me.PanDBelow.Size = New System.Drawing.Size(942, 94)
        Me.PanDBelow.TabIndex = 12
        '
        'panExtras
        '
        Me.panExtras.Controls.Add(Me.btnLinea)
        Me.panExtras.Controls.Add(Me.btnCajas)
        Me.panExtras.Controls.Add(Me.btnBotellas)
        Me.panExtras.Controls.Add(Me.Button1)
        Me.panExtras.Controls.Add(Me.Button2)
        Me.panExtras.Dock = System.Windows.Forms.DockStyle.Left
        Me.panExtras.Location = New System.Drawing.Point(0, 0)
        Me.panExtras.Name = "panExtras"
        Me.panExtras.Size = New System.Drawing.Size(494, 94)
        Me.panExtras.TabIndex = 19
        '
        'btnLinea
        '
        Me.btnLinea.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLinea.FlatAppearance.BorderSize = 0
        Me.btnLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLinea.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.btnLinea.Location = New System.Drawing.Point(397, 18)
        Me.btnLinea.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btnLinea.Name = "btnLinea"
        Me.btnLinea.Size = New System.Drawing.Size(75, 61)
        Me.btnLinea.TabIndex = 21
        Me.btnLinea.Text = "Lineas"
        Me.btnLinea.UseVisualStyleBackColor = True
        '
        'btnCajas
        '
        Me.btnCajas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCajas.FlatAppearance.BorderSize = 0
        Me.btnCajas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCajas.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.btnCajas.Location = New System.Drawing.Point(295, 18)
        Me.btnCajas.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btnCajas.Name = "btnCajas"
        Me.btnCajas.Size = New System.Drawing.Size(75, 61)
        Me.btnCajas.TabIndex = 20
        Me.btnCajas.Text = "Cajas"
        Me.btnCajas.UseVisualStyleBackColor = True
        '
        'btnBotellas
        '
        Me.btnBotellas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBotellas.FlatAppearance.BorderSize = 0
        Me.btnBotellas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBotellas.Image = Global.La_Andaluza.My.Resources.Resources.application_java_archive
        Me.btnBotellas.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnBotellas.Location = New System.Drawing.Point(197, 18)
        Me.btnBotellas.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.btnBotellas.Name = "btnBotellas"
        Me.btnBotellas.Size = New System.Drawing.Size(75, 61)
        Me.btnBotellas.TabIndex = 19
        Me.btnBotellas.Text = "Botellas"
        Me.btnBotellas.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.view_calendar_week256
        Me.Button1.Location = New System.Drawing.Point(12, 18)
        Me.Button1.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 61)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Loteados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Image = Global.La_Andaluza.My.Resources.Resources.view_calendar_day_2_256
        Me.Button2.Location = New System.Drawing.Point(104, 18)
        Me.Button2.Margin = New System.Windows.Forms.Padding(5, 3, 3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 61)
        Me.Button2.TabIndex = 18
        Me.Button2.Text = "Articulos Loteados"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnConfigurarImpresora
        '
        Me.btnConfigurarImpresora.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnConfigurarImpresora.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnConfigurarImpresora.FlatAppearance.BorderSize = 0
        Me.btnConfigurarImpresora.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnConfigurarImpresora.Image = Global.La_Andaluza.My.Resources.Resources.printer_laser_64
        Me.btnConfigurarImpresora.Location = New System.Drawing.Point(844, 0)
        Me.btnConfigurarImpresora.Margin = New System.Windows.Forms.Padding(2)
        Me.btnConfigurarImpresora.Name = "btnConfigurarImpresora"
        Me.btnConfigurarImpresora.Size = New System.Drawing.Size(98, 94)
        Me.btnConfigurarImpresora.TabIndex = 16
        Me.ToolTip1.SetToolTip(Me.btnConfigurarImpresora, "Configurar impresora de etiquetas")
        Me.btnConfigurarImpresora.UseVisualStyleBackColor = True
        '
        'Panconversor
        '
        Me.Panconversor.Controls.Add(Me.Label1)
        Me.Panconversor.Controls.Add(Me.txtJuliana)
        Me.Panconversor.Controls.Add(Me.btnJulianaToGregoriana)
        Me.Panconversor.Controls.Add(Me.Label2)
        Me.Panconversor.Controls.Add(Me.btnGregorianaToJuliana)
        Me.Panconversor.Controls.Add(Me.dtpGregoriana)
        Me.Panconversor.Location = New System.Drawing.Point(531, 21)
        Me.Panconversor.Name = "Panconversor"
        Me.Panconversor.Size = New System.Drawing.Size(292, 61)
        Me.Panconversor.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(40, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Juliana"
        '
        'txtJuliana
        '
        Me.txtJuliana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtJuliana.Location = New System.Drawing.Point(27, 26)
        Me.txtJuliana.Name = "txtJuliana"
        Me.txtJuliana.Size = New System.Drawing.Size(62, 20)
        Me.txtJuliana.TabIndex = 9
        '
        'btnJulianaToGregoriana
        '
        Me.btnJulianaToGregoriana.FlatAppearance.BorderSize = 0
        Me.btnJulianaToGregoriana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnJulianaToGregoriana.Image = Global.La_Andaluza.My.Resources.Resources.go_next_5
        Me.btnJulianaToGregoriana.Location = New System.Drawing.Point(95, 19)
        Me.btnJulianaToGregoriana.Name = "btnJulianaToGregoriana"
        Me.btnJulianaToGregoriana.Size = New System.Drawing.Size(36, 36)
        Me.btnJulianaToGregoriana.TabIndex = 10
        Me.btnJulianaToGregoriana.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(195, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Gregoriana"
        '
        'btnGregorianaToJuliana
        '
        Me.btnGregorianaToJuliana.FlatAppearance.BorderSize = 0
        Me.btnGregorianaToJuliana.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGregorianaToJuliana.Image = Global.La_Andaluza.My.Resources.Resources.go_previous_5
        Me.btnGregorianaToJuliana.Location = New System.Drawing.Point(137, 19)
        Me.btnGregorianaToJuliana.Name = "btnGregorianaToJuliana"
        Me.btnGregorianaToJuliana.Size = New System.Drawing.Size(35, 36)
        Me.btnGregorianaToJuliana.TabIndex = 11
        Me.btnGregorianaToJuliana.UseVisualStyleBackColor = True
        '
        'dtpGregoriana
        '
        Me.dtpGregoriana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGregoriana.Location = New System.Drawing.Point(178, 26)
        Me.dtpGregoriana.Name = "dtpGregoriana"
        Me.dtpGregoriana.Size = New System.Drawing.Size(88, 20)
        Me.dtpGregoriana.TabIndex = 12
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel2.Location = New System.Drawing.Point(914, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(28, 448)
        Me.Panel2.TabIndex = 13
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 25)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(28, 448)
        Me.Panel3.TabIndex = 14
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 300
        Me.ToolTip1.ReshowDelay = 100
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.StripAmpersands = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(942, 567)
        Me.Controls.Add(Me.MonthCalendar)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.PanDBelow)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEnvasados2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Envasados"
        Me.Controls.SetChildIndex(Me.PanDBelow, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel3, 0)
        Me.Controls.SetChildIndex(Me.MonthCalendar, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanDBelow.ResumeLayout(False)
        Me.panExtras.ResumeLayout(False)
        Me.Panconversor.ResumeLayout(False)
        Me.Panconversor.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panconversor As System.Windows.Forms.Panel
    Private WithEvents MonthCalendar As System.Windows.Forms.MonthCalendar
    Private WithEvents PanDBelow As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnJulianaToGregoriana As System.Windows.Forms.Button
    Private WithEvents txtJuliana As System.Windows.Forms.TextBox
    Private WithEvents dtpGregoriana As System.Windows.Forms.DateTimePicker
    Private WithEvents btnGregorianaToJuliana As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents btnConfigurarImpresora As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents panExtras As System.Windows.Forms.Panel
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents btnCajas As System.Windows.Forms.Button
    Private WithEvents btnBotellas As System.Windows.Forms.Button
    Private WithEvents btnLinea As System.Windows.Forms.Button

End Class
