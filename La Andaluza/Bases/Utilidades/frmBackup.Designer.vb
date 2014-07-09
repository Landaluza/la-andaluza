<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBackup
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
        Me.txtBackup = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnExaminar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.rdbBackup = New System.Windows.Forms.RadioButton()
        Me.rdbRestore = New System.Windows.Forms.RadioButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'txtBackup
        '
        Me.txtBackup.Location = New System.Drawing.Point(145, 126)
        Me.txtBackup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtBackup.Name = "txtBackup"
        Me.txtBackup.Size = New System.Drawing.Size(471, 22)
        Me.txtBackup.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 129)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Ruta de la copia"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(507, 447)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(123, 28)
        Me.btnAceptar.TabIndex = 2
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnExaminar
        '
        Me.btnExaminar.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExaminar.Location = New System.Drawing.Point(645, 129)
        Me.btnExaminar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnExaminar.Name = "btnExaminar"
        Me.btnExaminar.Size = New System.Drawing.Size(51, 33)
        Me.btnExaminar.TabIndex = 3
        Me.btnExaminar.Text = ""
        Me.btnExaminar.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.btnExaminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExaminar.FlatAppearance.BorderSize = 0
        Me.btnExaminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExaminar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 165)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 17)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre de la copia"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(145, 161)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(471, 22)
        Me.txtNombre.TabIndex = 4
        Me.txtNombre.Text = "Copia LA"
        '
        'rdbBackup
        '
        Me.rdbBackup.AutoSize = True
        Me.rdbBackup.Checked = True
        Me.rdbBackup.Location = New System.Drawing.Point(145, 44)
        Me.rdbBackup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbBackup.Name = "rdbBackup"
        Me.rdbBackup.Size = New System.Drawing.Size(76, 21)
        Me.rdbBackup.TabIndex = 6
        Me.rdbBackup.TabStop = True
        Me.rdbBackup.Text = "Backup"
        Me.rdbBackup.UseVisualStyleBackColor = True
        '
        'rdbRestore
        '
        Me.rdbRestore.AutoSize = True
        Me.rdbRestore.Location = New System.Drawing.Point(355, 44)
        Me.rdbRestore.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rdbRestore.Name = "rdbRestore"
        Me.rdbRestore.Size = New System.Drawing.Size(79, 21)
        Me.rdbRestore.TabIndex = 7
        Me.rdbRestore.Text = "Restore"
        Me.rdbRestore.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(945, 508)
        Me.Controls.Add(Me.rdbRestore)
        Me.Controls.Add(Me.rdbBackup)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.btnExaminar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtBackup)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmBackup"
        Me.Text = "frmBackup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtBackup As System.Windows.Forms.TextBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btnExaminar As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents rdbBackup As System.Windows.Forms.RadioButton
    Private WithEvents rdbRestore As System.Windows.Forms.RadioButton
    Private WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class
