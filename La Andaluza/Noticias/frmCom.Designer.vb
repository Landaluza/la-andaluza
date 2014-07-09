<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCom
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpCircular = New System.Windows.Forms.TabPage()
        Me.tpConmtacto = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpCircular)
        Me.TabControl1.Controls.Add(Me.tpConmtacto)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(849, 547)
        Me.TabControl1.TabIndex = 1
        '
        'tpCircular
        '
        Me.tpCircular.Location = New System.Drawing.Point(4, 28)
        Me.tpCircular.Name = "tpCircular"
        Me.tpCircular.Padding = New System.Windows.Forms.Padding(3)
        Me.tpCircular.Size = New System.Drawing.Size(841, 515)
        Me.tpCircular.TabIndex = 0
        Me.tpCircular.Text = "Circulares"
        Me.tpCircular.UseVisualStyleBackColor = True
        '
        'tpConmtacto
        '
        Me.tpConmtacto.Location = New System.Drawing.Point(4, 28)
        Me.tpConmtacto.Name = "tpConmtacto"
        Me.tpConmtacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tpConmtacto.Size = New System.Drawing.Size(841, 515)
        Me.tpConmtacto.TabIndex = 1
        Me.tpConmtacto.Text = "Contacto"
        Me.tpConmtacto.UseVisualStyleBackColor = True
        '
        'frmCom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(849, 547)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "frmCom"
        Me.Text = "Comunicaciones"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpCircular As System.Windows.Forms.TabPage
    Private WithEvents tpConmtacto As System.Windows.Forms.TabPage
End Class
