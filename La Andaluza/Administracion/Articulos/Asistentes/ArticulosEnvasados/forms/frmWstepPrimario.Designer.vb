<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepPrimario
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
        Me.panContenidos = New System.Windows.Forms.Panel()
        Me.pansubtipo = New System.Windows.Forms.Panel()
        Me.gpTipo = New System.Windows.Forms.GroupBox()
        Me.rbNinguno = New System.Windows.Forms.RadioButton()
        Me.rbDoypack = New System.Windows.Forms.RadioButton()
        Me.rbmonodosis = New System.Windows.Forms.RadioButton()
        Me.panContenidos.SuspendLayout()
        Me.gpTipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'panContenidos
        '
        Me.panContenidos.Controls.Add(Me.pansubtipo)
        Me.panContenidos.Controls.Add(Me.gpTipo)
        Me.panContenidos.Location = New System.Drawing.Point(86, 28)
        Me.panContenidos.Name = "panContenidos"
        Me.panContenidos.Size = New System.Drawing.Size(586, 487)
        Me.panContenidos.TabIndex = 1
        '
        'pansubtipo
        '
        Me.pansubtipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pansubtipo.Location = New System.Drawing.Point(0, 54)
        Me.pansubtipo.Name = "pansubtipo"
        Me.pansubtipo.Size = New System.Drawing.Size(586, 433)
        Me.pansubtipo.TabIndex = 1
        '
        'gpTipo
        '
        Me.gpTipo.Controls.Add(Me.rbNinguno)
        Me.gpTipo.Controls.Add(Me.rbDoypack)
        Me.gpTipo.Controls.Add(Me.rbmonodosis)
        Me.gpTipo.Dock = System.Windows.Forms.DockStyle.Top
        Me.gpTipo.Location = New System.Drawing.Point(0, 0)
        Me.gpTipo.Name = "gpTipo"
        Me.gpTipo.Size = New System.Drawing.Size(586, 54)
        Me.gpTipo.TabIndex = 0
        Me.gpTipo.TabStop = False
        Me.gpTipo.Text = "Tipo"
        '
        'rbNinguno
        '
        Me.rbNinguno.AutoSize = True
        Me.rbNinguno.Checked = True
        Me.rbNinguno.Location = New System.Drawing.Point(479, 19)
        Me.rbNinguno.Name = "rbNinguno"
        Me.rbNinguno.Size = New System.Drawing.Size(65, 17)
        Me.rbNinguno.TabIndex = 2
        Me.rbNinguno.TabStop = True
        Me.rbNinguno.Text = "Ninguno"
        Me.rbNinguno.UseVisualStyleBackColor = True
        '
        'rbDoypack
        '
        Me.rbDoypack.AutoSize = True
        Me.rbDoypack.Location = New System.Drawing.Point(253, 19)
        Me.rbDoypack.Name = "rbDoypack"
        Me.rbDoypack.Size = New System.Drawing.Size(68, 17)
        Me.rbDoypack.TabIndex = 1
        Me.rbDoypack.Text = "Doypack"
        Me.rbDoypack.UseVisualStyleBackColor = True
        '
        'rbmonodosis
        '
        Me.rbmonodosis.AutoSize = True
        Me.rbmonodosis.Location = New System.Drawing.Point(46, 19)
        Me.rbmonodosis.Name = "rbmonodosis"
        Me.rbmonodosis.Size = New System.Drawing.Size(76, 17)
        Me.rbmonodosis.TabIndex = 0
        Me.rbmonodosis.Text = "Monodosis"
        Me.rbmonodosis.UseVisualStyleBackColor = True
        '
        'frmWstepPrimario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(715, 557)
        Me.Controls.Add(Me.panContenidos)
        Me.Name = "frmWstepPrimario"
        Me.Text = "frmWstepPrimario"
        Me.panContenidos.ResumeLayout(False)
        Me.gpTipo.ResumeLayout(False)
        Me.gpTipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents panContenidos As System.Windows.Forms.Panel
    Private WithEvents pansubtipo As System.Windows.Forms.Panel
    Private WithEvents gpTipo As System.Windows.Forms.GroupBox
    Private WithEvents rbNinguno As System.Windows.Forms.RadioButton
    Private WithEvents rbDoypack As System.Windows.Forms.RadioButton
    Private WithEvents rbmonodosis As System.Windows.Forms.RadioButton
End Class
