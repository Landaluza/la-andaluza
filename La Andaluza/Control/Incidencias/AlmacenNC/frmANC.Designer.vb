<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmANC
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
        Me.splitPrincipal = New System.Windows.Forms.SplitContainer()
        Me.splitDetalles = New System.Windows.Forms.SplitContainer()
        Me.panSeguimiento = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PanPalets = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitPrincipal.Panel2.SuspendLayout()
        Me.splitPrincipal.SuspendLayout()
        CType(Me.splitDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitDetalles.Panel1.SuspendLayout()
        Me.splitDetalles.Panel2.SuspendLayout()
        Me.splitDetalles.SuspendLayout()
        Me.SuspendLayout()
        '
        'splitPrincipal
        '
        Me.splitPrincipal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitPrincipal.Location = New System.Drawing.Point(0, 0)
        Me.splitPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.splitPrincipal.Name = "splitPrincipal"
        '
        'splitPrincipal.Panel2
        '
        Me.splitPrincipal.Panel2.Controls.Add(Me.splitDetalles)
        Me.splitPrincipal.Size = New System.Drawing.Size(798, 399)
        Me.splitPrincipal.SplitterDistance = 560
        Me.splitPrincipal.SplitterWidth = 3
        Me.splitPrincipal.TabIndex = 0
        '
        'splitDetalles
        '
        Me.splitDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.splitDetalles.Location = New System.Drawing.Point(0, 0)
        Me.splitDetalles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.splitDetalles.Name = "splitDetalles"
        '
        'splitDetalles.Panel1
        '
        Me.splitDetalles.Panel1.Controls.Add(Me.panSeguimiento)
        Me.splitDetalles.Panel1.Controls.Add(Me.Label1)
        '
        'splitDetalles.Panel2
        '
        Me.splitDetalles.Panel2.Controls.Add(Me.PanPalets)
        Me.splitDetalles.Panel2.Controls.Add(Me.Label2)
        Me.splitDetalles.Size = New System.Drawing.Size(235, 399)
        Me.splitDetalles.SplitterDistance = 119
        Me.splitDetalles.SplitterWidth = 3
        Me.splitDetalles.TabIndex = 0
        '
        'panSeguimiento
        '
        Me.panSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panSeguimiento.Location = New System.Drawing.Point(0, 13)
        Me.panSeguimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panSeguimiento.Name = "panSeguimiento"
        Me.panSeguimiento.Size = New System.Drawing.Size(119, 386)
        Me.panSeguimiento.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Seguimiento"
        '
        'PanPalets
        '
        Me.PanPalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanPalets.Location = New System.Drawing.Point(0, 13)
        Me.PanPalets.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanPalets.Name = "PanPalets"
        Me.PanPalets.Size = New System.Drawing.Size(113, 386)
        Me.PanPalets.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(0, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Palets"
        '
        'frmANC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(798, 399)
        Me.Controls.Add(Me.splitPrincipal)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmANC"
        Me.Text = "frmANC"
        Me.splitPrincipal.Panel2.ResumeLayout(False)
        CType(Me.splitPrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitPrincipal.ResumeLayout(False)
        Me.splitDetalles.Panel1.ResumeLayout(False)
        Me.splitDetalles.Panel1.PerformLayout()
        Me.splitDetalles.Panel2.ResumeLayout(False)
        Me.splitDetalles.Panel2.PerformLayout()
        CType(Me.splitDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitDetalles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Private WithEvents splitPrincipal As System.Windows.Forms.SplitContainer
   Private WithEvents splitDetalles As System.Windows.Forms.SplitContainer
    Private WithEvents panSeguimiento As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents PanPalets As System.Windows.Forms.Panel
    Private WithEvents Label2 As System.Windows.Forms.Label
End Class
