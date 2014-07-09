<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOrganizacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmOrganizacion))
        Me.btnInformeEmpelados = New System.Windows.Forms.Button()
        Me.btnControlHorario = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnInfContratos = New System.Windows.Forms.Button()
        Me.btnControlHoras = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnInformeEmpelados
        '
        Me.btnInformeEmpelados.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformeEmpelados.Image = Global.La_Andaluza.My.Resources.Resources.application_x_theme
        Me.btnInformeEmpelados.Location = New System.Drawing.Point(27, 12)
        Me.btnInformeEmpelados.Name = "btnInformeEmpelados"
        Me.btnInformeEmpelados.Size = New System.Drawing.Size(125, 62)
        Me.btnInformeEmpelados.TabIndex = 4
        Me.btnInformeEmpelados.Text = "Informe empleados"
        Me.btnInformeEmpelados.UseVisualStyleBackColor = True
        '
        'btnControlHorario
        '
        Me.btnControlHorario.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlHorario.Image = Global.La_Andaluza.My.Resources.Resources.application_x_kexiproject_sqlite3
        Me.btnControlHorario.Location = New System.Drawing.Point(169, 12)
        Me.btnControlHorario.Name = "btnControlHorario"
        Me.btnControlHorario.Size = New System.Drawing.Size(125, 62)
        Me.btnControlHorario.TabIndex = 5
        Me.btnControlHorario.Text = "Control horario empleados"
        Me.btnControlHorario.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(946, 272)
        Me.TabControl1.TabIndex = 6
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(938, 240)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Empleados"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(938, 240)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Puestos de trabajo"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.Location = New System.Drawing.Point(4, 28)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(938, 240)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Tipos de contratos"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Location = New System.Drawing.Point(4, 28)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(938, 240)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Competencias"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'TabPage5
        '
        Me.TabPage5.Location = New System.Drawing.Point(4, 28)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage5.Size = New System.Drawing.Size(938, 240)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Tipos de usuarios"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnInfContratos)
        Me.Panel1.Controls.Add(Me.btnControlHoras)
        Me.Panel1.Controls.Add(Me.btnInformeEmpelados)
        Me.Panel1.Controls.Add(Me.btnControlHorario)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 272)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(946, 84)
        Me.Panel1.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(606, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(125, 62)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Puestos empleados"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(57, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(823, 2)
        Me.Panel2.TabIndex = 9
        '
        'btnInfContratos
        '
        Me.btnInfContratos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInfContratos.Image = Global.La_Andaluza.My.Resources.Resources.document_open_256
        Me.btnInfContratos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInfContratos.Location = New System.Drawing.Point(459, 12)
        Me.btnInfContratos.Name = "btnInfContratos"
        Me.btnInfContratos.Size = New System.Drawing.Size(125, 62)
        Me.btnInfContratos.TabIndex = 8
        Me.btnInfContratos.Text = "Contratos empleados"
        Me.btnInfContratos.UseVisualStyleBackColor = True
        '
        'btnControlHoras
        '
        Me.btnControlHoras.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnControlHoras.Image = Global.La_Andaluza.My.Resources.Resources.appointment_256
        Me.btnControlHoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnControlHoras.Location = New System.Drawing.Point(314, 12)
        Me.btnControlHoras.Name = "btnControlHoras"
        Me.btnControlHoras.Size = New System.Drawing.Size(125, 62)
        Me.btnControlHoras.TabIndex = 7
        Me.btnControlHoras.Text = "Control de horas"
        Me.btnControlHoras.UseVisualStyleBackColor = True
        '
        'frmOrganizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(946, 356)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmOrganizacion"
        Me.Text = "Organizacion"
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnInformeEmpelados As System.Windows.Forms.Button
    Private WithEvents btnControlHorario As System.Windows.Forms.Button
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents TabPage3 As System.Windows.Forms.TabPage
   Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnInfContratos As System.Windows.Forms.Button
    Private WithEvents btnControlHoras As System.Windows.Forms.Button
    Private WithEvents TabPage4 As System.Windows.Forms.TabPage
    Private WithEvents TabPage5 As System.Windows.Forms.TabPage
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Button1 As System.Windows.Forms.Button
End Class
