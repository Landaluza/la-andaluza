<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PaletsEntAutoGuardado
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
        Me.pbSCC = New System.Windows.Forms.ProgressBar()
        Me.lMensaje = New System.Windows.Forms.Label()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'pbSCC
        '
        Me.pbSCC.Location = New System.Drawing.Point(53, 38)
        Me.pbSCC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pbSCC.Name = "pbSCC"
        Me.pbSCC.Size = New System.Drawing.Size(407, 53)
        Me.pbSCC.TabIndex = 0
        '
        'lMensaje
        '
        Me.lMensaje.AutoSize = True
        Me.lMensaje.Location = New System.Drawing.Point(49, 107)
        Me.lMensaje.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lMensaje.MaximumSize = New System.Drawing.Size(333, 16)
        Me.lMensaje.MinimumSize = New System.Drawing.Size(165, 16)
        Me.lMensaje.Name = "lMensaje"
        Me.lMensaje.Size = New System.Drawing.Size(165, 16)
        Me.lMensaje.TabIndex = 1
        Me.lMensaje.Text = "Generando nuevo SSCC"
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(348, 154)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(112, 44)
        Me.btnCancelar.TabIndex = 2
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'PaletsEntAutoGuardado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 204)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.lMensaje)
        Me.Controls.Add(Me.pbSCC)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(527, 249)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(527, 249)
        Me.Name = "PaletsEntAutoGuardado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Auto-guardado de Palet"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents pbSCC As System.Windows.Forms.ProgressBar
    Private WithEvents lMensaje As System.Windows.Forms.Label
    Private WithEvents btnCancelar As System.Windows.Forms.Button
End Class
