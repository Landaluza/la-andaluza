<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSaludLaboral
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
        Me.grbReconocimientosMedicos = New System.Windows.Forms.GroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpSolicitudes = New System.Windows.Forms.TabPage()
        Me.tpSolicitudesEmpleados = New System.Windows.Forms.TabPage()
        Me.tpRealizados = New System.Windows.Forms.TabPage()
        Me.tpTipos = New System.Windows.Forms.TabPage()
        Me.TabControl2 = New System.Windows.Forms.TabControl()
        Me.tppReconocimientosMedicos = New System.Windows.Forms.TabPage()
        Me.tppProtocolos = New System.Windows.Forms.TabPage()
        Me.TabControl3 = New System.Windows.Forms.TabControl()
        Me.tpProtocolos = New System.Windows.Forms.TabPage()
        Me.tpProtocolosAsignadosaPuestos = New System.Windows.Forms.TabPage()
        Me.tpprotocolosRealizadosReconocimientos = New System.Windows.Forms.TabPage()
        Me.tpActividadesPreventivas = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnGrupos = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnMedicos = New System.Windows.Forms.Button()
        Me.btnEmpleados = New System.Windows.Forms.Button()
        Me.btnPuestos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grbReconocimientosMedicos.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabControl2.SuspendLayout()
        Me.tppReconocimientosMedicos.SuspendLayout()
        Me.tppProtocolos.SuspendLayout()
        Me.TabControl3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grbReconocimientosMedicos
        '
        Me.grbReconocimientosMedicos.Controls.Add(Me.TabControl1)
        Me.grbReconocimientosMedicos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbReconocimientosMedicos.Location = New System.Drawing.Point(4, 4)
        Me.grbReconocimientosMedicos.Margin = New System.Windows.Forms.Padding(4)
        Me.grbReconocimientosMedicos.Name = "grbReconocimientosMedicos"
        Me.grbReconocimientosMedicos.Padding = New System.Windows.Forms.Padding(4)
        Me.grbReconocimientosMedicos.Size = New System.Drawing.Size(1097, 324)
        Me.grbReconocimientosMedicos.TabIndex = 8
        Me.grbReconocimientosMedicos.TabStop = False
        Me.grbReconocimientosMedicos.Text = "Reconocimientos medicos"
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpSolicitudes)
        Me.TabControl1.Controls.Add(Me.tpSolicitudesEmpleados)
        Me.TabControl1.Controls.Add(Me.tpRealizados)
        Me.TabControl1.Controls.Add(Me.tpTipos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(4, 19)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Multiline = True
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1089, 301)
        Me.TabControl1.TabIndex = 9
        '
        'tpSolicitudes
        '
        Me.tpSolicitudes.Location = New System.Drawing.Point(4, 28)
        Me.tpSolicitudes.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpSolicitudes.Name = "tpSolicitudes"
        Me.tpSolicitudes.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpSolicitudes.Size = New System.Drawing.Size(1081, 269)
        Me.tpSolicitudes.TabIndex = 0
        Me.tpSolicitudes.Text = "Solicitudes de reconocimientos medicos"
        Me.tpSolicitudes.UseVisualStyleBackColor = True
        '
        'tpSolicitudesEmpleados
        '
        Me.tpSolicitudesEmpleados.Location = New System.Drawing.Point(4, 28)
        Me.tpSolicitudesEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpSolicitudesEmpleados.Name = "tpSolicitudesEmpleados"
        Me.tpSolicitudesEmpleados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpSolicitudesEmpleados.Size = New System.Drawing.Size(1081, 269)
        Me.tpSolicitudesEmpleados.TabIndex = 1
        Me.tpSolicitudesEmpleados.Text = "Solicitudes Empleados"
        Me.tpSolicitudesEmpleados.UseVisualStyleBackColor = True
        '
        'tpRealizados
        '
        Me.tpRealizados.Location = New System.Drawing.Point(4, 28)
        Me.tpRealizados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpRealizados.Name = "tpRealizados"
        Me.tpRealizados.Size = New System.Drawing.Size(1081, 269)
        Me.tpRealizados.TabIndex = 2
        Me.tpRealizados.Text = "Reconocimientos realizados"
        Me.tpRealizados.UseVisualStyleBackColor = True
        '
        'tpTipos
        '
        Me.tpTipos.Location = New System.Drawing.Point(4, 28)
        Me.tpTipos.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpTipos.Name = "tpTipos"
        Me.tpTipos.Size = New System.Drawing.Size(1081, 269)
        Me.tpTipos.TabIndex = 3
        Me.tpTipos.Text = "Tipos"
        Me.tpTipos.UseVisualStyleBackColor = True
        '
        'TabControl2
        '
        Me.TabControl2.Alignment = System.Windows.Forms.TabAlignment.Left
        Me.TabControl2.Controls.Add(Me.tppReconocimientosMedicos)
        Me.TabControl2.Controls.Add(Me.tppProtocolos)
        Me.TabControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl2.Location = New System.Drawing.Point(0, 0)
        Me.TabControl2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl2.Multiline = True
        Me.TabControl2.Name = "TabControl2"
        Me.TabControl2.SelectedIndex = 0
        Me.TabControl2.Size = New System.Drawing.Size(1134, 340)
        Me.TabControl2.TabIndex = 9
        '
        'tppReconocimientosMedicos
        '
        Me.tppReconocimientosMedicos.Controls.Add(Me.grbReconocimientosMedicos)
        Me.tppReconocimientosMedicos.Location = New System.Drawing.Point(25, 4)
        Me.tppReconocimientosMedicos.Margin = New System.Windows.Forms.Padding(4)
        Me.tppReconocimientosMedicos.Name = "tppReconocimientosMedicos"
        Me.tppReconocimientosMedicos.Padding = New System.Windows.Forms.Padding(4)
        Me.tppReconocimientosMedicos.Size = New System.Drawing.Size(1105, 332)
        Me.tppReconocimientosMedicos.TabIndex = 0
        Me.tppReconocimientosMedicos.Text = "Reconocimientos médicos"
        Me.tppReconocimientosMedicos.UseVisualStyleBackColor = True
        '
        'tppProtocolos
        '
        Me.tppProtocolos.Controls.Add(Me.GroupBox1)
        Me.tppProtocolos.Location = New System.Drawing.Point(25, 4)
        Me.tppProtocolos.Margin = New System.Windows.Forms.Padding(4)
        Me.tppProtocolos.Name = "tppProtocolos"
        Me.tppProtocolos.Padding = New System.Windows.Forms.Padding(4)
        Me.tppProtocolos.Size = New System.Drawing.Size(1105, 332)
        Me.tppProtocolos.TabIndex = 1
        Me.tppProtocolos.Text = "Protocolos médicos"
        Me.tppProtocolos.UseVisualStyleBackColor = True
        '
        'TabControl3
        '
        Me.TabControl3.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl3.Controls.Add(Me.tpProtocolos)
        Me.TabControl3.Controls.Add(Me.tpProtocolosAsignadosaPuestos)
        Me.TabControl3.Controls.Add(Me.tpprotocolosRealizadosReconocimientos)
        Me.TabControl3.Controls.Add(Me.tpActividadesPreventivas)
        Me.TabControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl3.Location = New System.Drawing.Point(3, 18)
        Me.TabControl3.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl3.Multiline = True
        Me.TabControl3.Name = "TabControl3"
        Me.TabControl3.SelectedIndex = 0
        Me.TabControl3.Size = New System.Drawing.Size(1091, 303)
        Me.TabControl3.TabIndex = 0
        '
        'tpProtocolos
        '
        Me.tpProtocolos.Location = New System.Drawing.Point(4, 28)
        Me.tpProtocolos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpProtocolos.Name = "tpProtocolos"
        Me.tpProtocolos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpProtocolos.Size = New System.Drawing.Size(1083, 271)
        Me.tpProtocolos.TabIndex = 0
        Me.tpProtocolos.Text = "Protocolos médicos"
        Me.tpProtocolos.UseVisualStyleBackColor = True
        '
        'tpProtocolosAsignadosaPuestos
        '
        Me.tpProtocolosAsignadosaPuestos.Location = New System.Drawing.Point(4, 28)
        Me.tpProtocolosAsignadosaPuestos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpProtocolosAsignadosaPuestos.Name = "tpProtocolosAsignadosaPuestos"
        Me.tpProtocolosAsignadosaPuestos.Padding = New System.Windows.Forms.Padding(4)
        Me.tpProtocolosAsignadosaPuestos.Size = New System.Drawing.Size(1089, 267)
        Me.tpProtocolosAsignadosaPuestos.TabIndex = 1
        Me.tpProtocolosAsignadosaPuestos.Text = "Protocolos asignados a puestos de trabajo"
        Me.tpProtocolosAsignadosaPuestos.UseVisualStyleBackColor = True
        '
        'tpprotocolosRealizadosReconocimientos
        '
        Me.tpprotocolosRealizadosReconocimientos.Location = New System.Drawing.Point(4, 28)
        Me.tpprotocolosRealizadosReconocimientos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpprotocolosRealizadosReconocimientos.Name = "tpprotocolosRealizadosReconocimientos"
        Me.tpprotocolosRealizadosReconocimientos.Size = New System.Drawing.Size(1089, 267)
        Me.tpprotocolosRealizadosReconocimientos.TabIndex = 2
        Me.tpprotocolosRealizadosReconocimientos.Text = "Protocolos realizados en reconocimientos"
        Me.tpprotocolosRealizadosReconocimientos.UseVisualStyleBackColor = True
        '
        'tpActividadesPreventivas
        '
        Me.tpActividadesPreventivas.Location = New System.Drawing.Point(4, 28)
        Me.tpActividadesPreventivas.Margin = New System.Windows.Forms.Padding(4)
        Me.tpActividadesPreventivas.Name = "tpActividadesPreventivas"
        Me.tpActividadesPreventivas.Size = New System.Drawing.Size(1089, 267)
        Me.tpActividadesPreventivas.TabIndex = 3
        Me.tpActividadesPreventivas.Text = "Programas actividades preventivas"
        Me.tpActividadesPreventivas.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.btnGrupos)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnMedicos)
        Me.Panel1.Controls.Add(Me.btnEmpleados)
        Me.Panel1.Controls.Add(Me.btnPuestos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 340)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1134, 84)
        Me.Panel1.TabIndex = 11
        '
        'btnGrupos
        '
        Me.btnGrupos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGrupos.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.btnGrupos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnGrupos.Location = New System.Drawing.Point(459, 12)
        Me.btnGrupos.Name = "btnGrupos"
        Me.btnGrupos.Size = New System.Drawing.Size(125, 62)
        Me.btnGrupos.TabIndex = 10
        Me.btnGrupos.Text = "Grupos de riesgo"
        Me.btnGrupos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(57, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1011, 2)
        Me.Panel2.TabIndex = 9
        '
        'btnMedicos
        '
        Me.btnMedicos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMedicos.Image = Global.La_Andaluza.My.Resources.Resources.contact_new_2
        Me.btnMedicos.Location = New System.Drawing.Point(314, 12)
        Me.btnMedicos.Name = "btnMedicos"
        Me.btnMedicos.Size = New System.Drawing.Size(125, 62)
        Me.btnMedicos.TabIndex = 7
        Me.btnMedicos.Text = "Medicos"
        Me.btnMedicos.UseVisualStyleBackColor = True
        '
        'btnEmpleados
        '
        Me.btnEmpleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEmpleados.Image = Global.La_Andaluza.My.Resources.Resources.application_x_theme
        Me.btnEmpleados.Location = New System.Drawing.Point(27, 12)
        Me.btnEmpleados.Name = "btnEmpleados"
        Me.btnEmpleados.Size = New System.Drawing.Size(125, 62)
        Me.btnEmpleados.TabIndex = 4
        Me.btnEmpleados.Text = "Empleados"
        Me.btnEmpleados.UseVisualStyleBackColor = True
        '
        'btnPuestos
        '
        Me.btnPuestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPuestos.Image = Global.La_Andaluza.My.Resources.Resources.application_x_kexiproject_sqlite3
        Me.btnPuestos.Location = New System.Drawing.Point(169, 12)
        Me.btnPuestos.Name = "btnPuestos"
        Me.btnPuestos.Size = New System.Drawing.Size(125, 62)
        Me.btnPuestos.TabIndex = 5
        Me.btnPuestos.Text = "Puestos de trabajo"
        Me.btnPuestos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TabControl3)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1097, 324)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Protocolos medicos"
        '
        'frmSaludLaboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1134, 424)
        Me.Controls.Add(Me.TabControl2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmSaludLaboral"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Salud Laboral"
        Me.grbReconocimientosMedicos.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabControl2.ResumeLayout(False)
        Me.tppReconocimientosMedicos.ResumeLayout(False)
        Me.tppProtocolos.ResumeLayout(False)
        Me.TabControl3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Private WithEvents grbReconocimientosMedicos As System.Windows.Forms.GroupBox
   Private WithEvents TabControl1 As System.Windows.Forms.TabControl
   Private WithEvents tpSolicitudes As System.Windows.Forms.TabPage
   Private WithEvents tpSolicitudesEmpleados As System.Windows.Forms.TabPage
   Private WithEvents tpRealizados As System.Windows.Forms.TabPage
   Private WithEvents tpTipos As System.Windows.Forms.TabPage
   Private WithEvents TabControl2 As System.Windows.Forms.TabControl
   Private WithEvents tppReconocimientosMedicos As System.Windows.Forms.TabPage
   Private WithEvents tppProtocolos As System.Windows.Forms.TabPage
   Private WithEvents TabControl3 As System.Windows.Forms.TabControl
   Private WithEvents tpProtocolos As System.Windows.Forms.TabPage
   Private WithEvents tpProtocolosAsignadosaPuestos As System.Windows.Forms.TabPage
   Private WithEvents tpprotocolosRealizadosReconocimientos As System.Windows.Forms.TabPage
   Private WithEvents tpActividadesPreventivas As System.Windows.Forms.TabPage
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnGrupos As System.Windows.Forms.Button
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents btnMedicos As System.Windows.Forms.Button
    Private WithEvents btnEmpleados As System.Windows.Forms.Button
    Private WithEvents btnPuestos As System.Windows.Forms.Button
    Private WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
