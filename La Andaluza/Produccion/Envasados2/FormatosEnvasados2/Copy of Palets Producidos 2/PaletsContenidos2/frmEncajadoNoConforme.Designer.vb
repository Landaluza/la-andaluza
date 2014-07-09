<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEncajadoNoConforme
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
        Me.cbNoConforme = New System.Windows.Forms.CheckBox()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.btnContinuar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'cbNoConforme
        '
        Me.cbNoConforme.AutoSize = True
        Me.cbNoConforme.Location = New System.Drawing.Point(15, 71)
        Me.cbNoConforme.Name = "cbNoConforme"
        Me.cbNoConforme.Size = New System.Drawing.Size(253, 21)
        Me.cbNoConforme.TabIndex = 0
        Me.cbNoConforme.Text = "Mover esta cantidad a no conforme"
        Me.cbNoConforme.UseVisualStyleBackColor = True
        '
        'txtCantidad
        '
        Me.txtCantidad.Enabled = False
        Me.txtCantidad.Location = New System.Drawing.Point(15, 98)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(253, 22)
        Me.txtCantidad.TabIndex = 1
        '
        'btnContinuar
        '
        Me.btnContinuar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnContinuar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnContinuar.Location = New System.Drawing.Point(426, 173)
        Me.btnContinuar.Name = "btnContinuar"
        Me.btnContinuar.Size = New System.Drawing.Size(174, 56)
        Me.btnContinuar.TabIndex = 2
        Me.btnContinuar.Text = "Continuar"
        Me.btnContinuar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnContinuar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(588, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "El palet esta marcado como no conforme. Marque si desea mover alguno de sus conte" & _
    "nidos"
        '
        'frmEncajadoNoConforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(616, 241)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnContinuar)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.cbNoConforme)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frmEncajadoNoConforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEncajadoNoConforme"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents cbNoConforme As System.Windows.Forms.CheckBox
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents btnContinuar As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
End Class
