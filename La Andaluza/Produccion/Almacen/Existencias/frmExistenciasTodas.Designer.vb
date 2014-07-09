<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExistenciasTodas
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
        Me.tbconforme = New System.Windows.Forms.TabPage()
        Me.tbnoconforme = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tbconforme)
        Me.TabControl1.Controls.Add(Me.tbnoconforme)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(767, 582)
        Me.TabControl1.TabIndex = 0
        '
        'tbconforme
        '
        Me.tbconforme.Location = New System.Drawing.Point(23, 4)
        Me.tbconforme.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbconforme.Name = "tbconforme"
        Me.tbconforme.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbconforme.Size = New System.Drawing.Size(740, 574)
        Me.tbconforme.TabIndex = 0
        Me.tbconforme.Text = "Conformes"
        Me.tbconforme.UseVisualStyleBackColor = True
        '
        'tbnoconforme
        '
        Me.tbnoconforme.Location = New System.Drawing.Point(23, 4)
        Me.tbnoconforme.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbnoconforme.Name = "tbnoconforme"
        Me.tbnoconforme.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tbnoconforme.Size = New System.Drawing.Size(740, 574)
        Me.tbnoconforme.TabIndex = 1
        Me.tbnoconforme.Text = "No conformes"
        Me.tbnoconforme.UseVisualStyleBackColor = True
        '
        'frmExistenciasTodas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(767, 582)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmExistenciasTodas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Resumen existencias"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tbconforme As System.Windows.Forms.TabPage
    Private WithEvents tbnoconforme As System.Windows.Forms.TabPage
End Class
