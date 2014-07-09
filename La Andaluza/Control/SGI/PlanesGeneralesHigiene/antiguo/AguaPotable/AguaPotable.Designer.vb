<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AguaPotable
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
        Me.tabAguaPotable = New System.Windows.Forms.TabControl()
        Me.tbpAnaliticasCloro = New System.Windows.Forms.TabPage()
        Me.tabAnaliticasCloro = New System.Windows.Forms.TabControl()
        Me.tbpAnaliticas = New System.Windows.Forms.TabPage()
        Me.tbpGrafica = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.tbpAnaliticasOrganolepticas = New System.Windows.Forms.TabPage()
        Me.tbpAnaliticasAnuales = New System.Windows.Forms.TabPage()
        Me.tbpPuntosMuestreo = New System.Windows.Forms.TabPage()
        Me.tbpInformesMensuales = New System.Windows.Forms.TabPage()
        Me.tbpConsumos = New System.Windows.Forms.TabPage()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpFacturas = New System.Windows.Forms.TabPage()
        Me.tbpGraficaConsumo = New System.Windows.Forms.TabPage()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnAnaliticasCloro = New System.Windows.Forms.Button()
        Me.tabAguaPotable.SuspendLayout()
        Me.tbpAnaliticasCloro.SuspendLayout()
        Me.tabAnaliticasCloro.SuspendLayout()
        Me.tbpGrafica.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tbpConsumos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpGraficaConsumo.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabAguaPotable
        '
        Me.tabAguaPotable.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabAguaPotable.Controls.Add(Me.tbpAnaliticasCloro)
        Me.tabAguaPotable.Controls.Add(Me.tbpAnaliticasOrganolepticas)
        Me.tabAguaPotable.Controls.Add(Me.tbpAnaliticasAnuales)
        Me.tabAguaPotable.Controls.Add(Me.tbpPuntosMuestreo)
        Me.tabAguaPotable.Controls.Add(Me.tbpInformesMensuales)
        Me.tabAguaPotable.Controls.Add(Me.tbpConsumos)
        Me.tabAguaPotable.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAguaPotable.Location = New System.Drawing.Point(0, 0)
        Me.tabAguaPotable.Multiline = True
        Me.tabAguaPotable.Name = "tabAguaPotable"
        Me.tabAguaPotable.SelectedIndex = 0
        Me.tabAguaPotable.Size = New System.Drawing.Size(999, 372)
        Me.tabAguaPotable.TabIndex = 0
        '
        'tbpAnaliticasCloro
        '
        Me.tbpAnaliticasCloro.Controls.Add(Me.tabAnaliticasCloro)
        Me.tbpAnaliticasCloro.Location = New System.Drawing.Point(4, 25)
        Me.tbpAnaliticasCloro.Name = "tbpAnaliticasCloro"
        Me.tbpAnaliticasCloro.Size = New System.Drawing.Size(991, 343)
        Me.tbpAnaliticasCloro.TabIndex = 2
        Me.tbpAnaliticasCloro.Text = "Analiticas cloro"
        Me.tbpAnaliticasCloro.UseVisualStyleBackColor = True
        '
        'tabAnaliticasCloro
        '
        Me.tabAnaliticasCloro.Controls.Add(Me.tbpAnaliticas)
        Me.tabAnaliticasCloro.Controls.Add(Me.tbpGrafica)
        Me.tabAnaliticasCloro.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabAnaliticasCloro.Location = New System.Drawing.Point(0, 0)
        Me.tabAnaliticasCloro.Name = "tabAnaliticasCloro"
        Me.tabAnaliticasCloro.SelectedIndex = 0
        Me.tabAnaliticasCloro.Size = New System.Drawing.Size(991, 343)
        Me.tabAnaliticasCloro.TabIndex = 0
        '
        'tbpAnaliticas
        '
        Me.tbpAnaliticas.Location = New System.Drawing.Point(4, 22)
        Me.tbpAnaliticas.Name = "tbpAnaliticas"
        Me.tbpAnaliticas.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpAnaliticas.Size = New System.Drawing.Size(983, 317)
        Me.tbpAnaliticas.TabIndex = 0
        Me.tbpAnaliticas.Text = "Analiticas"
        Me.tbpAnaliticas.UseVisualStyleBackColor = True
        '
        'tbpGrafica
        '
        Me.tbpGrafica.Controls.Add(Me.PictureBox1)
        Me.tbpGrafica.Location = New System.Drawing.Point(4, 22)
        Me.tbpGrafica.Name = "tbpGrafica"
        Me.tbpGrafica.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpGrafica.Size = New System.Drawing.Size(983, 317)
        Me.tbpGrafica.TabIndex = 1
        Me.tbpGrafica.Text = "Grafica"
        Me.tbpGrafica.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = Global.La_Andaluza.My.Resources.Resources.no_imagen_64
        Me.PictureBox1.InitialImage = Global.La_Andaluza.My.Resources.Resources.no_imagen_64
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(977, 311)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'tbpAnaliticasOrganolepticas
        '
        Me.tbpAnaliticasOrganolepticas.Location = New System.Drawing.Point(4, 25)
        Me.tbpAnaliticasOrganolepticas.Name = "tbpAnaliticasOrganolepticas"
        Me.tbpAnaliticasOrganolepticas.Size = New System.Drawing.Size(991, 343)
        Me.tbpAnaliticasOrganolepticas.TabIndex = 3
        Me.tbpAnaliticasOrganolepticas.Text = "Analiticas organolepticas"
        Me.tbpAnaliticasOrganolepticas.UseVisualStyleBackColor = True
        '
        'tbpAnaliticasAnuales
        '
        Me.tbpAnaliticasAnuales.Location = New System.Drawing.Point(4, 25)
        Me.tbpAnaliticasAnuales.Name = "tbpAnaliticasAnuales"
        Me.tbpAnaliticasAnuales.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpAnaliticasAnuales.Size = New System.Drawing.Size(991, 343)
        Me.tbpAnaliticasAnuales.TabIndex = 1
        Me.tbpAnaliticasAnuales.Text = "Analiticas anuales"
        Me.tbpAnaliticasAnuales.UseVisualStyleBackColor = True
        '
        'tbpPuntosMuestreo
        '
        Me.tbpPuntosMuestreo.Location = New System.Drawing.Point(4, 25)
        Me.tbpPuntosMuestreo.Name = "tbpPuntosMuestreo"
        Me.tbpPuntosMuestreo.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpPuntosMuestreo.Size = New System.Drawing.Size(991, 343)
        Me.tbpPuntosMuestreo.TabIndex = 0
        Me.tbpPuntosMuestreo.Text = "Puntos de muestreo"
        Me.tbpPuntosMuestreo.UseVisualStyleBackColor = True
        '
        'tbpInformesMensuales
        '
        Me.tbpInformesMensuales.Location = New System.Drawing.Point(4, 25)
        Me.tbpInformesMensuales.Name = "tbpInformesMensuales"
        Me.tbpInformesMensuales.Size = New System.Drawing.Size(991, 343)
        Me.tbpInformesMensuales.TabIndex = 4
        Me.tbpInformesMensuales.Text = "Informes mensuales"
        Me.tbpInformesMensuales.UseVisualStyleBackColor = True
        '
        'tbpConsumos
        '
        Me.tbpConsumos.Controls.Add(Me.TabControl1)
        Me.tbpConsumos.Location = New System.Drawing.Point(4, 25)
        Me.tbpConsumos.Name = "tbpConsumos"
        Me.tbpConsumos.Size = New System.Drawing.Size(991, 343)
        Me.tbpConsumos.TabIndex = 5
        Me.tbpConsumos.Text = "Consumos"
        Me.tbpConsumos.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpFacturas)
        Me.TabControl1.Controls.Add(Me.tbpGraficaConsumo)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(991, 343)
        Me.TabControl1.TabIndex = 1
        '
        'tbpFacturas
        '
        Me.tbpFacturas.Location = New System.Drawing.Point(4, 22)
        Me.tbpFacturas.Name = "tbpFacturas"
        Me.tbpFacturas.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpFacturas.Size = New System.Drawing.Size(983, 317)
        Me.tbpFacturas.TabIndex = 0
        Me.tbpFacturas.Text = "Facturas"
        Me.tbpFacturas.UseVisualStyleBackColor = True
        '
        'tbpGraficaConsumo
        '
        Me.tbpGraficaConsumo.Controls.Add(Me.PictureBox2)
        Me.tbpGraficaConsumo.Location = New System.Drawing.Point(4, 22)
        Me.tbpGraficaConsumo.Name = "tbpGraficaConsumo"
        Me.tbpGraficaConsumo.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpGraficaConsumo.Size = New System.Drawing.Size(985, 300)
        Me.tbpGraficaConsumo.TabIndex = 1
        Me.tbpGraficaConsumo.Text = "Grafica"
        Me.tbpGraficaConsumo.UseVisualStyleBackColor = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(6, 6)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(947, 338)
        Me.PictureBox2.TabIndex = 0
        Me.PictureBox2.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnAnaliticasCloro)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 372)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(999, 68)
        Me.Panel1.TabIndex = 8
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(43, 4)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(907, 2)
        Me.Panel2.TabIndex = 9
        '
        'btnAnaliticasCloro
        '
        Me.btnAnaliticasCloro.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAnaliticasCloro.Image = Global.La_Andaluza.My.Resources.Resources.application_x_theme
        Me.btnAnaliticasCloro.Location = New System.Drawing.Point(20, 10)
        Me.btnAnaliticasCloro.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAnaliticasCloro.Name = "btnAnaliticasCloro"
        Me.btnAnaliticasCloro.Size = New System.Drawing.Size(94, 50)
        Me.btnAnaliticasCloro.TabIndex = 4
        Me.btnAnaliticasCloro.Text = "Analiticas cloro"
        Me.btnAnaliticasCloro.UseVisualStyleBackColor = True
        '
        'AguaPotable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 440)
        Me.Controls.Add(Me.tabAguaPotable)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "AguaPotable"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Agua potable"
        Me.tabAguaPotable.ResumeLayout(False)
        Me.tbpAnaliticasCloro.ResumeLayout(False)
        Me.tabAnaliticasCloro.ResumeLayout(False)
        Me.tbpGrafica.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tbpConsumos.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbpGraficaConsumo.ResumeLayout(False)
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tabAguaPotable As System.Windows.Forms.TabControl
    Private WithEvents tbpPuntosMuestreo As System.Windows.Forms.TabPage
    Private WithEvents tbpAnaliticasAnuales As System.Windows.Forms.TabPage
    Private WithEvents tbpAnaliticasCloro As System.Windows.Forms.TabPage
    Private WithEvents tbpAnaliticasOrganolepticas As System.Windows.Forms.TabPage
    Private WithEvents tabAnaliticasCloro As System.Windows.Forms.TabControl
    Private WithEvents tbpAnaliticas As System.Windows.Forms.TabPage
    Private WithEvents tbpGrafica As System.Windows.Forms.TabPage
    Private WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Private WithEvents tbpInformesMensuales As System.Windows.Forms.TabPage
    Private WithEvents tbpConsumos As System.Windows.Forms.TabPage
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tbpFacturas As System.Windows.Forms.TabPage
    Private WithEvents tbpGraficaConsumo As System.Windows.Forms.TabPage
    Private WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents btnAnaliticasCloro As System.Windows.Forms.Button
End Class
