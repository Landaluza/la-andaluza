<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConversorJulianoGregoriano
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panconversor = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtJuliana = New System.Windows.Forms.TextBox()
        Me.btnJulianaToGregoriana = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnGregorianaToJuliana = New System.Windows.Forms.Button()
        Me.dtpGregoriana = New System.Windows.Forms.DateTimePicker()
        Me.Panconversor.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panconversor
        '
        Me.Panconversor.Controls.Add(Me.Label1)
        Me.Panconversor.Controls.Add(Me.txtJuliana)
        Me.Panconversor.Controls.Add(Me.btnJulianaToGregoriana)
        Me.Panconversor.Controls.Add(Me.Label2)
        Me.Panconversor.Controls.Add(Me.btnGregorianaToJuliana)
        Me.Panconversor.Controls.Add(Me.dtpGregoriana)
        Me.Panconversor.Location = New System.Drawing.Point(3, 42)
        Me.Panconversor.Margin = New System.Windows.Forms.Padding(4)
        Me.Panconversor.Name = "Panconversor"
        Me.Panconversor.Size = New System.Drawing.Size(389, 75)
        Me.Panconversor.TabIndex = 16
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(69, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 17)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Juliana"
        '
        'txtJuliana
        '
        Me.txtJuliana.Location = New System.Drawing.Point(52, 32)
        Me.txtJuliana.Margin = New System.Windows.Forms.Padding(4)
        Me.txtJuliana.Name = "txtJuliana"
        Me.txtJuliana.Size = New System.Drawing.Size(81, 22)
        Me.txtJuliana.TabIndex = 9
        '
        'btnJulianaToGregoriana
        '
        Me.btnJulianaToGregoriana.Location = New System.Drawing.Point(143, 32)
        Me.btnJulianaToGregoriana.Margin = New System.Windows.Forms.Padding(4)
        Me.btnJulianaToGregoriana.Name = "btnJulianaToGregoriana"
        Me.btnJulianaToGregoriana.Size = New System.Drawing.Size(32, 25)
        Me.btnJulianaToGregoriana.TabIndex = 10
        Me.btnJulianaToGregoriana.Text = ">"
        Me.btnJulianaToGregoriana.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(245, 11)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Gregoriana"
        '
        'btnGregorianaToJuliana
        '
        Me.btnGregorianaToJuliana.Location = New System.Drawing.Point(183, 32)
        Me.btnGregorianaToJuliana.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGregorianaToJuliana.Name = "btnGregorianaToJuliana"
        Me.btnGregorianaToJuliana.Size = New System.Drawing.Size(32, 25)
        Me.btnGregorianaToJuliana.TabIndex = 11
        Me.btnGregorianaToJuliana.Text = "<"
        Me.btnGregorianaToJuliana.UseVisualStyleBackColor = True
        '
        'dtpGregoriana
        '
        Me.dtpGregoriana.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpGregoriana.Location = New System.Drawing.Point(223, 32)
        Me.dtpGregoriana.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpGregoriana.Name = "dtpGregoriana"
        Me.dtpGregoriana.Size = New System.Drawing.Size(116, 22)
        Me.dtpGregoriana.TabIndex = 12
        '
        'frmConversorJulianoGregoriano
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 158)
        Me.Controls.Add(Me.Panconversor)
        Me.Name = "frmConversorJulianoGregoriano"
        Me.Text = "Conversor fechas"
        Me.Panconversor.ResumeLayout(False)
        Me.Panconversor.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
   Private WithEvents Panconversor As System.Windows.Forms.Panel
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents txtJuliana As System.Windows.Forms.TextBox
   Private WithEvents btnJulianaToGregoriana As System.Windows.Forms.Button
   Private WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents btnGregorianaToJuliana As System.Windows.Forms.Button
   Private WithEvents dtpGregoriana As System.Windows.Forms.DateTimePicker
End Class
