<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDepositosMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.btndepositos = New System.Windows.Forms.Button()
        Me.btnTipos = New System.Windows.Forms.Button()
        Me.btnFechas = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnFechas)
        Me.Panel1.Controls.Add(Me.btnTipos)
        Me.Panel1.Controls.Add(Me.btndepositos)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 402)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(951, 82)
        Me.Panel1.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(951, 402)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 28)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(943, 370)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Depositos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 28)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(943, 370)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Material de construccion"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'btndepositos
        '
        Me.btndepositos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndepositos.Image = Global.La_Andaluza.My.Resources.Resources.application_java_archive
        Me.btndepositos.Location = New System.Drawing.Point(29, 13)
        Me.btndepositos.Name = "btndepositos"
        Me.btndepositos.Size = New System.Drawing.Size(125, 62)
        Me.btndepositos.TabIndex = 5
        Me.btndepositos.Text = "Existencias por deposito"
        Me.btndepositos.UseVisualStyleBackColor = True
        '
        'btnTipos
        '
        Me.btnTipos.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTipos.Image = Global.La_Andaluza.My.Resources.Resources.color_picker_grey
        Me.btnTipos.Location = New System.Drawing.Point(182, 13)
        Me.btnTipos.Name = "btnTipos"
        Me.btnTipos.Size = New System.Drawing.Size(125, 62)
        Me.btnTipos.TabIndex = 6
        Me.btnTipos.Text = "Existencias por tipo"
        Me.btnTipos.UseVisualStyleBackColor = True
        '
        'btnFechas
        '
        Me.btnFechas.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFechas.Image = Global.La_Andaluza.My.Resources.Resources.view_calendar_workweek256
        Me.btnFechas.Location = New System.Drawing.Point(333, 13)
        Me.btnFechas.Name = "btnFechas"
        Me.btnFechas.Size = New System.Drawing.Size(125, 62)
        Me.btnFechas.TabIndex = 7
        Me.btnFechas.Text = "Existencias entre fechas"
        Me.btnFechas.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(73, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(788, 2)
        Me.Panel2.TabIndex = 8
        '
        'frmDepositosMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(951, 484)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmDepositosMain"
        Me.Text = "Depositos"
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents TabPage1 As System.Windows.Forms.TabPage
    Private WithEvents TabPage2 As System.Windows.Forms.TabPage
    Private WithEvents btnFechas As System.Windows.Forms.Button
    Private WithEvents btnTipos As System.Windows.Forms.Button
    Private WithEvents btndepositos As System.Windows.Forms.Button
    Private WithEvents Panel2 As System.Windows.Forms.Panel
End Class
