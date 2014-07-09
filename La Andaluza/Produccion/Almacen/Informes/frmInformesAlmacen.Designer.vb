<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformesAlmacen
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
        Me.tpSalidas = New System.Windows.Forms.TabPage()
        Me.tpEntradas = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl1.Controls.Add(Me.tpSalidas)
        Me.TabControl1.Controls.Add(Me.tpEntradas)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 516)
        Me.TabControl1.TabIndex = 0
        '
        'tpSalidas
        '
        Me.tpSalidas.Location = New System.Drawing.Point(23, 4)
        Me.tpSalidas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpSalidas.Name = "tpSalidas"
        Me.tpSalidas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpSalidas.Size = New System.Drawing.Size(755, 508)
        Me.tpSalidas.TabIndex = 0
        Me.tpSalidas.Text = "Salidas"
        Me.tpSalidas.UseVisualStyleBackColor = True
        '
        'tpEntradas
        '
        Me.tpEntradas.Location = New System.Drawing.Point(23, 4)
        Me.tpEntradas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEntradas.Name = "tpEntradas"
        Me.tpEntradas.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEntradas.Size = New System.Drawing.Size(755, 508)
        Me.tpEntradas.TabIndex = 1
        Me.tpEntradas.Text = "Entradas"
        Me.tpEntradas.UseVisualStyleBackColor = True
        '
        'frmInformesAlmacen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(782, 516)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmInformesAlmacen"
        Me.Text = "Informes almacen"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpSalidas As System.Windows.Forms.TabPage
    Private WithEvents tpEntradas As System.Windows.Forms.TabPage
End Class
