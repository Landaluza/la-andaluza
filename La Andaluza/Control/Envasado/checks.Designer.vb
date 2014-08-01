<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class checks
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
        Me.tpChProduccion = New System.Windows.Forms.TabPage()
        Me.tpchMoidificacion = New System.Windows.Forms.TabPage()
        Me.tpMediaProduccion = New System.Windows.Forms.TabPage()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsOEE = New System.Windows.Forms.ToolStripButton()
        Me.tsEntreFechas = New System.Windows.Forms.ToolStripButton()
        Me.tsResumenOEE = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpChProduccion)
        Me.TabControl1.Controls.Add(Me.tpchMoidificacion)
        Me.TabControl1.Controls.Add(Me.tpMediaProduccion)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(691, 505)
        Me.TabControl1.TabIndex = 0
        '
        'tpChProduccion
        '
        Me.tpChProduccion.Location = New System.Drawing.Point(4, 25)
        Me.tpChProduccion.Margin = New System.Windows.Forms.Padding(2)
        Me.tpChProduccion.Name = "tpChProduccion"
        Me.tpChProduccion.Padding = New System.Windows.Forms.Padding(2)
        Me.tpChProduccion.Size = New System.Drawing.Size(683, 476)
        Me.tpChProduccion.TabIndex = 0
        Me.tpChProduccion.Text = "Comparacion entradas-producción"
        Me.tpChProduccion.UseVisualStyleBackColor = True
        '
        'tpchMoidificacion
        '
        Me.tpchMoidificacion.Location = New System.Drawing.Point(4, 25)
        Me.tpchMoidificacion.Margin = New System.Windows.Forms.Padding(2)
        Me.tpchMoidificacion.Name = "tpchMoidificacion"
        Me.tpchMoidificacion.Size = New System.Drawing.Size(683, 476)
        Me.tpchMoidificacion.TabIndex = 1
        Me.tpchMoidificacion.Text = "Palets por usuario"
        Me.tpchMoidificacion.UseVisualStyleBackColor = True
        '
        'tpMediaProduccion
        '
        Me.tpMediaProduccion.Location = New System.Drawing.Point(4, 25)
        Me.tpMediaProduccion.Margin = New System.Windows.Forms.Padding(2)
        Me.tpMediaProduccion.Name = "tpMediaProduccion"
        Me.tpMediaProduccion.Size = New System.Drawing.Size(683, 476)
        Me.tpMediaProduccion.TabIndex = 2
        Me.tpMediaProduccion.Text = "Media produccion"
        Me.tpMediaProduccion.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsOEE, Me.tsEntreFechas, Me.tsResumenOEE})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 505)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(691, 56)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsOEE
        '
        Me.tsOEE.AutoSize = False
        Me.tsOEE.Image = Global.La_Andaluza.My.Resources.Resources.download_later
        Me.tsOEE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsOEE.Name = "tsOEE"
        Me.tsOEE.Size = New System.Drawing.Size(104, 66)
        Me.tsOEE.Text = "Calculo OEE"
        '
        'tsEntreFechas
        '
        Me.tsEntreFechas.Image = Global.La_Andaluza.My.Resources.Resources.appointmentmissed16
        Me.tsEntreFechas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsEntreFechas.Name = "tsEntreFechas"
        Me.tsEntreFechas.Size = New System.Drawing.Size(91, 53)
        Me.tsEntreFechas.Text = "Entre fechas"
        '
        'tsResumenOEE
        '
        Me.tsResumenOEE.Image = Global.La_Andaluza.My.Resources.Resources.document_open_recent
        Me.tsResumenOEE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsResumenOEE.Name = "tsResumenOEE"
        Me.tsResumenOEE.Size = New System.Drawing.Size(100, 53)
        Me.tsResumenOEE.Text = "Resumen OEE"
        '
        'checks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(691, 561)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "checks"
        Me.Text = "Comprobaciones de procccion"
        Me.TabControl1.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpChProduccion As System.Windows.Forms.TabPage
    Private WithEvents tpchMoidificacion As System.Windows.Forms.TabPage
    Private WithEvents tpMediaProduccion As System.Windows.Forms.TabPage
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents tsOEE As System.Windows.Forms.ToolStripButton
    Private WithEvents tsEntreFechas As System.Windows.Forms.ToolStripButton
    Private WithEvents tsResumenOEE As System.Windows.Forms.ToolStripButton
End Class
