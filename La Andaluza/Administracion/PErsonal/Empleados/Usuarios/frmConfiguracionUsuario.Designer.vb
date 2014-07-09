<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmConfiguracionUsuario
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PanContraseña = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtoldPass = New System.Windows.Forms.TextBox()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lPass = New System.Windows.Forms.Label()
        Me.cbPass = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txtCorreoPass = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PanContraseña.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 421)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 89)
        Me.Panel1.TabIndex = 0
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.AutoSize = True
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAceptar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnAceptar.Location = New System.Drawing.Point(580, 9)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(117, 54)
        Me.btnAceptar.TabIndex = 12
        Me.btnAceptar.Text = "&Guardar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PanContraseña)
        Me.GroupBox2.Controls.Add(Me.lPass)
        Me.GroupBox2.Controls.Add(Me.cbPass)
        Me.GroupBox2.Location = New System.Drawing.Point(23, 122)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(415, 126)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Acceso"
        '
        'PanContraseña
        '
        Me.PanContraseña.Controls.Add(Me.Label4)
        Me.PanContraseña.Controls.Add(Me.txtoldPass)
        Me.PanContraseña.Controls.Add(Me.txtNewPass)
        Me.PanContraseña.Controls.Add(Me.Label5)
        Me.PanContraseña.Enabled = False
        Me.PanContraseña.Location = New System.Drawing.Point(52, 55)
        Me.PanContraseña.Name = "PanContraseña"
        Me.PanContraseña.Size = New System.Drawing.Size(333, 73)
        Me.PanContraseña.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-3, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Contraseña actual"
        '
        'txtoldPass
        '
        Me.txtoldPass.Location = New System.Drawing.Point(104, 6)
        Me.txtoldPass.Name = "txtoldPass"
        Me.txtoldPass.Size = New System.Drawing.Size(214, 20)
        Me.txtoldPass.TabIndex = 7
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(104, 38)
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.Size = New System.Drawing.Size(214, 20)
        Me.txtNewPass.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(-3, 38)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Contraseña nueva"
        '
        'lPass
        '
        Me.lPass.AutoSize = True
        Me.lPass.Location = New System.Drawing.Point(49, 35)
        Me.lPass.Name = "lPass"
        Me.lPass.Size = New System.Drawing.Size(101, 13)
        Me.lPass.TabIndex = 2
        Me.lPass.Text = "Cambiar contraseña"
        '
        'cbPass
        '
        Me.cbPass.AutoSize = True
        Me.cbPass.Location = New System.Drawing.Point(156, 35)
        Me.cbPass.Name = "cbPass"
        Me.cbPass.Size = New System.Drawing.Size(15, 14)
        Me.cbPass.TabIndex = 9
        Me.cbPass.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCorreo)
        Me.GroupBox1.Controls.Add(Me.txtCorreoPass)
        Me.GroupBox1.Location = New System.Drawing.Point(23, 16)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(415, 100)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Correo"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(100, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Dirección de correo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(46, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña"
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(153, 25)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreo.TabIndex = 5
        '
        'txtCorreoPass
        '
        Me.txtCorreoPass.Location = New System.Drawing.Point(153, 58)
        Me.txtCorreoPass.Name = "txtCorreoPass"
        Me.txtCorreoPass.Size = New System.Drawing.Size(217, 20)
        Me.txtCorreoPass.TabIndex = 6
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.GroupBox2)
        Me.Panel2.Location = New System.Drawing.Point(126, 58)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(458, 302)
        Me.Panel2.TabIndex = 12
        '
        'frmConfiguracionUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(709, 510)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmConfiguracionUsuario"
        Me.Text = "frmConfiguracionUsuario"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PanContraseña.ResumeLayout(False)
        Me.PanContraseña.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Private WithEvents Panel1 As System.Windows.Forms.Panel
   Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
   Private WithEvents Label4 As System.Windows.Forms.Label
   Private WithEvents lPass As System.Windows.Forms.Label
   Private WithEvents cbPass As System.Windows.Forms.CheckBox
   Private WithEvents Label5 As System.Windows.Forms.Label
   Private WithEvents txtNewPass As System.Windows.Forms.TextBox
   Private WithEvents txtoldPass As System.Windows.Forms.TextBox
   Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents txtCorreo As System.Windows.Forms.TextBox
   Private WithEvents txtCorreoPass As System.Windows.Forms.TextBox
   Private WithEvents btnAceptar As System.Windows.Forms.Button
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents PanContraseña As System.Windows.Forms.Panel
End Class
