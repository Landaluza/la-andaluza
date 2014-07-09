<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModLoteTiposFormatosLineas_TiposFormatos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chbVelocidad = New System.Windows.Forms.CheckBox()
        Me.chbPersonal = New System.Windows.Forms.CheckBox()
        Me.txtVelocidad = New System.Windows.Forms.TextBox()
        Me.txtPersonal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Velocidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Personal recomendado"
        '
        'chbVelocidad
        '
        Me.chbVelocidad.AutoSize = True
        Me.chbVelocidad.Checked = True
        Me.chbVelocidad.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbVelocidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVelocidad.Location = New System.Drawing.Point(162, 24)
        Me.chbVelocidad.Name = "chbVelocidad"
        Me.chbVelocidad.Size = New System.Drawing.Size(12, 11)
        Me.chbVelocidad.TabIndex = 2
        Me.chbVelocidad.UseVisualStyleBackColor = True
        '
        'chbPersonal
        '
        Me.chbPersonal.AutoSize = True
        Me.chbPersonal.Checked = True
        Me.chbPersonal.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbPersonal.Location = New System.Drawing.Point(162, 54)
        Me.chbPersonal.Name = "chbPersonal"
        Me.chbPersonal.Size = New System.Drawing.Size(12, 11)
        Me.chbPersonal.TabIndex = 3
        Me.chbPersonal.UseVisualStyleBackColor = True
        '
        'txtVelocidad
        '
        Me.txtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVelocidad.Location = New System.Drawing.Point(183, 21)
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Size = New System.Drawing.Size(100, 20)
        Me.txtVelocidad.TabIndex = 4
        '
        'txtPersonal
        '
        Me.txtPersonal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersonal.Location = New System.Drawing.Point(183, 51)
        Me.txtPersonal.Name = "txtPersonal"
        Me.txtPersonal.Size = New System.Drawing.Size(100, 20)
        Me.txtPersonal.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.Button1.Location = New System.Drawing.Point(183, 83)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 50)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Aplicar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'frmModLoteTiposFormatosLineas_TiposFormatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(311, 141)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtPersonal)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Controls.Add(Me.chbPersonal)
        Me.Controls.Add(Me.chbVelocidad)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmModLoteTiposFormatosLineas_TiposFormatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmModLoteTiposFormatosLineas_TiposFormatos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents chbVelocidad As System.Windows.Forms.CheckBox
    Private WithEvents chbPersonal As System.Windows.Forms.CheckBox
    Private WithEvents txtVelocidad As System.Windows.Forms.TextBox
    Private WithEvents txtPersonal As System.Windows.Forms.TextBox
    Private WithEvents Button1 As System.Windows.Forms.Button
End Class
