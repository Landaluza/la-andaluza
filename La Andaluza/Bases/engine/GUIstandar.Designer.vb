<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUIstandar
    Inherits La_Andaluza.GUImain

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
        Me.components = New System.ComponentModel.Container()
        Me.TimerNotificaciones = New System.Windows.Forms.Timer(Me.components)
        Me.TimerActualizaciones = New System.Windows.Forms.Timer(Me.components)
        Me.lActualizaciones = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.PanContenido.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.scExtra, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.scExtra.Panel1.SuspendLayout()
        Me.scExtra.Panel2.SuspendLayout()
        Me.scExtra.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel9.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lActualizaciones)
        Me.Panel1.Controls.SetChildIndex(Me.lServ, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lReportBug, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lMensajes, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lUser, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lAyuda, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lPersonalSinFin, 0)
        Me.Panel1.Controls.SetChildIndex(Me.LAgenda, 0)
        Me.Panel1.Controls.SetChildIndex(Me.lActualizaciones, 0)
        '
        'SplitContainer1
        '
        '
        'scExtra
        '
        '
        'TabPage1
        '
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(0, 0)
        '
        'Panel9
        '
        Me.Panel9.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel9.Size = New System.Drawing.Size(0, 0)
        '
        'TabControl1
        '
        '
        'TabControl2
        '
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Size = New System.Drawing.Size(0, 0)
        '
        'TimerNotificaciones
        '
        Me.TimerNotificaciones.Interval = 36000000
        Me.TimerNotificaciones.Tag = "36000000"
        '
        'TimerActualizaciones
        '
        Me.TimerActualizaciones.Enabled = True
        Me.TimerActualizaciones.Interval = 300000
        '
        'lActualizaciones
        '
        Me.lActualizaciones.Cursor = System.Windows.Forms.Cursors.Hand
        Me.lActualizaciones.Dock = System.Windows.Forms.DockStyle.Right
        Me.lActualizaciones.Font = New System.Drawing.Font("Comic Sans MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lActualizaciones.ForeColor = System.Drawing.Color.Firebrick
        Me.lActualizaciones.Image = Global.La_Andaluza.My.Resources.Resources.glyphicons_371_global
        Me.lActualizaciones.Location = New System.Drawing.Point(866, 0)
        Me.lActualizaciones.Name = "lActualizaciones"
        Me.lActualizaciones.Size = New System.Drawing.Size(60, 21)
        Me.lActualizaciones.TabIndex = 65
        Me.lActualizaciones.Text = " 1"
        Me.lActualizaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.ToolTip1.SetToolTip(Me.lActualizaciones, "Hay actualizaciones disponibles")
        Me.lActualizaciones.Visible = False
        '
        'GUIstandar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 682)
        Me.Location = New System.Drawing.Point(0, 0)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "GUIstandar"
        Me.Text = "GUIEnvasado"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.PanContenido, 0)
        Me.Panel1.ResumeLayout(False)
        Me.PanContenido.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.scExtra.Panel1.ResumeLayout(False)
        Me.scExtra.Panel2.ResumeLayout(False)
        CType(Me.scExtra, System.ComponentModel.ISupportInitialize).EndInit()
        Me.scExtra.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel9.ResumeLayout(False)
        Me.Panel9.PerformLayout()
        Me.TabControl2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Protected WithEvents TimerNotificaciones As System.Windows.Forms.Timer
    Private WithEvents TimerActualizaciones As System.Windows.Forms.Timer
    Protected WithEvents lActualizaciones As System.Windows.Forms.Label
End Class
