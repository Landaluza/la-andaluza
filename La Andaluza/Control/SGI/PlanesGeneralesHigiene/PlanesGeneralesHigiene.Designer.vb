<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanesGeneralesHigiene
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
        Me.tpAgua = New System.Windows.Forms.TabPage()
        Me.tpDDD = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TabControl1.SuspendLayout()
        Me.tpAgua.SuspendLayout()
        Me.tpDDD.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tpAgua)
        Me.TabControl1.Controls.Add(Me.tpDDD)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1000, 661)
        Me.TabControl1.TabIndex = 4
        '
        'tpAgua
        '
        Me.tpAgua.Controls.Add(Me.GroupBox2)
        Me.tpAgua.Location = New System.Drawing.Point(25, 4)
        Me.tpAgua.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpAgua.Name = "tpAgua"
        Me.tpAgua.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpAgua.Size = New System.Drawing.Size(971, 653)
        Me.tpAgua.TabIndex = 0
        Me.tpAgua.Text = "Control de agua potable"
        Me.tpAgua.UseVisualStyleBackColor = True
        '
        'tpDDD
        '
        Me.tpDDD.Controls.Add(Me.GroupBox1)
        Me.tpDDD.Location = New System.Drawing.Point(25, 4)
        Me.tpDDD.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpDDD.Name = "tpDDD"
        Me.tpDDD.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tpDDD.Size = New System.Drawing.Size(971, 653)
        Me.tpDDD.TabIndex = 1
        Me.tpDDD.Text = "Planes DDD"
        Me.tpDDD.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(963, 645)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Planes DDD"
        '
        'GroupBox2
        '
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(963, 645)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Control de agua potable"
        '
        'PlanesGeneralesHigiene
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 661)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeBox = False
        Me.Name = "PlanesGeneralesHigiene"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PlanesGeneralesHigiene"
        Me.TabControl1.ResumeLayout(False)
        Me.tpAgua.ResumeLayout(False)
        Me.tpDDD.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpAgua As System.Windows.Forms.TabPage
    Private WithEvents tpDDD As System.Windows.Forms.TabPage
    Private WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
