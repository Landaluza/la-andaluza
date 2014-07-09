<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PlanesDDD
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
        Me.tpPlanes = New System.Windows.Forms.TabPage()
        Me.tpProductos = New System.Windows.Forms.TabPage()
        Me.tpAcciones = New System.Windows.Forms.TabPage()
        Me.tpPersonas = New System.Windows.Forms.TabPage()
        Me.tpAccionesRealizadas = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpPlanes)
        Me.TabControl1.Controls.Add(Me.tpProductos)
        Me.TabControl1.Controls.Add(Me.tpAcciones)
        Me.TabControl1.Controls.Add(Me.tpPersonas)
        Me.TabControl1.Controls.Add(Me.tpAccionesRealizadas)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(851, 543)
        Me.TabControl1.TabIndex = 5
        '
        'tpPlanes
        '
        Me.tpPlanes.Location = New System.Drawing.Point(4, 28)
        Me.tpPlanes.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPlanes.Name = "tpPlanes"
        Me.tpPlanes.Padding = New System.Windows.Forms.Padding(4)
        Me.tpPlanes.Size = New System.Drawing.Size(843, 511)
        Me.tpPlanes.TabIndex = 0
        Me.tpPlanes.Text = "Planes"
        Me.tpPlanes.UseVisualStyleBackColor = True
        '
        'tpProductos
        '
        Me.tpProductos.Location = New System.Drawing.Point(4, 28)
        Me.tpProductos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpProductos.Name = "tpProductos"
        Me.tpProductos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpProductos.Size = New System.Drawing.Size(843, 511)
        Me.tpProductos.TabIndex = 1
        Me.tpProductos.Text = "Productos"
        Me.tpProductos.UseVisualStyleBackColor = True
        '
        'tpAcciones
        '
        Me.tpAcciones.Location = New System.Drawing.Point(4, 28)
        Me.tpAcciones.Margin = New System.Windows.Forms.Padding(4)
        Me.tpAcciones.Name = "tpAcciones"
        Me.tpAcciones.Size = New System.Drawing.Size(843, 511)
        Me.tpAcciones.TabIndex = 2
        Me.tpAcciones.Text = "Acciones"
        Me.tpAcciones.UseVisualStyleBackColor = True
        '
        'tpPersonas
        '
        Me.tpPersonas.Location = New System.Drawing.Point(4, 28)
        Me.tpPersonas.Margin = New System.Windows.Forms.Padding(4)
        Me.tpPersonas.Name = "tpPersonas"
        Me.tpPersonas.Size = New System.Drawing.Size(843, 511)
        Me.tpPersonas.TabIndex = 3
        Me.tpPersonas.Text = "Personas autorizadas"
        Me.tpPersonas.UseVisualStyleBackColor = True
        '
        'tpAccionesRealizadas
        '
        Me.tpAccionesRealizadas.Location = New System.Drawing.Point(4, 28)
        Me.tpAccionesRealizadas.Name = "tpAccionesRealizadas"
        Me.tpAccionesRealizadas.Size = New System.Drawing.Size(843, 511)
        Me.tpAccionesRealizadas.TabIndex = 4
        Me.tpAccionesRealizadas.Text = "Acciones realizadas"
        Me.tpAccionesRealizadas.UseVisualStyleBackColor = True
        '
        'PlanesDDD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(851, 543)
        Me.Controls.Add(Me.TabControl1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimizeBox = False
        Me.Name = "PlanesDDD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PlanesDDD"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpPlanes As System.Windows.Forms.TabPage
    Private WithEvents tpProductos As System.Windows.Forms.TabPage
    Private WithEvents tpAcciones As System.Windows.Forms.TabPage
    Private WithEvents tpPersonas As System.Windows.Forms.TabPage
    Private WithEvents tpAccionesRealizadas As System.Windows.Forms.TabPage
End Class
