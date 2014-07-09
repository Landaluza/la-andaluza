<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIncidenciasCalidadMain
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
        Me.tpIncidenciasGenerales = New System.Windows.Forms.TabPage()
        Me.tpControlIncidencias = New System.Windows.Forms.TabPage()
        Me.tpTiposEnvasados = New System.Windows.Forms.TabPage()
        Me.tpCalsesEnvasados = New System.Windows.Forms.TabPage()
        Me.tpCAtegoriasEnvasados = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnNC = New System.Windows.Forms.Button()
        Me.btnVigentes = New System.Windows.Forms.Button()
        Me.btnIncidencias = New System.Windows.Forms.Button()
        Me.btnEvaluacion = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.TabControl1.Controls.Add(Me.tpIncidenciasGenerales)
        Me.TabControl1.Controls.Add(Me.tpControlIncidencias)
        Me.TabControl1.Controls.Add(Me.tpTiposEnvasados)
        Me.TabControl1.Controls.Add(Me.tpCalsesEnvasados)
        Me.TabControl1.Controls.Add(Me.tpCAtegoriasEnvasados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(926, 243)
        Me.TabControl1.TabIndex = 0
        '
        'tpIncidenciasGenerales
        '
        Me.tpIncidenciasGenerales.Location = New System.Drawing.Point(4, 25)
        Me.tpIncidenciasGenerales.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpIncidenciasGenerales.Name = "tpIncidenciasGenerales"
        Me.tpIncidenciasGenerales.Size = New System.Drawing.Size(918, 214)
        Me.tpIncidenciasGenerales.TabIndex = 7
        Me.tpIncidenciasGenerales.Text = "Incidencias generales"
        Me.tpIncidenciasGenerales.UseVisualStyleBackColor = True
        '
        'tpControlIncidencias
        '
        Me.tpControlIncidencias.Location = New System.Drawing.Point(4, 25)
        Me.tpControlIncidencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpControlIncidencias.Name = "tpControlIncidencias"
        Me.tpControlIncidencias.Size = New System.Drawing.Size(918, 215)
        Me.tpControlIncidencias.TabIndex = 10
        Me.tpControlIncidencias.Text = "Cotroles"
        Me.tpControlIncidencias.UseVisualStyleBackColor = True
        '
        'tpTiposEnvasados
        '
        Me.tpTiposEnvasados.Location = New System.Drawing.Point(4, 25)
        Me.tpTiposEnvasados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTiposEnvasados.Name = "tpTiposEnvasados"
        Me.tpTiposEnvasados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpTiposEnvasados.Size = New System.Drawing.Size(918, 215)
        Me.tpTiposEnvasados.TabIndex = 11
        Me.tpTiposEnvasados.Text = "Tipos envasados"
        Me.tpTiposEnvasados.UseVisualStyleBackColor = True
        '
        'tpCalsesEnvasados
        '
        Me.tpCalsesEnvasados.Location = New System.Drawing.Point(4, 25)
        Me.tpCalsesEnvasados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCalsesEnvasados.Name = "tpCalsesEnvasados"
        Me.tpCalsesEnvasados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCalsesEnvasados.Size = New System.Drawing.Size(918, 215)
        Me.tpCalsesEnvasados.TabIndex = 12
        Me.tpCalsesEnvasados.Text = "Clases envasados"
        Me.tpCalsesEnvasados.UseVisualStyleBackColor = True
        '
        'tpCAtegoriasEnvasados
        '
        Me.tpCAtegoriasEnvasados.Location = New System.Drawing.Point(4, 25)
        Me.tpCAtegoriasEnvasados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCAtegoriasEnvasados.Name = "tpCAtegoriasEnvasados"
        Me.tpCAtegoriasEnvasados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpCAtegoriasEnvasados.Size = New System.Drawing.Size(918, 215)
        Me.tpCAtegoriasEnvasados.TabIndex = 13
        Me.tpCAtegoriasEnvasados.Text = "Categorias envasados"
        Me.tpCAtegoriasEnvasados.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnEvaluacion)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.btnNC)
        Me.Panel1.Controls.Add(Me.btnVigentes)
        Me.Panel1.Controls.Add(Me.btnIncidencias)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 243)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(926, 76)
        Me.Panel1.TabIndex = 2
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.White
        Me.Panel2.Location = New System.Drawing.Point(40, 7)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(827, 2)
        Me.Panel2.TabIndex = 10
        '
        'btnNC
        '
        Me.btnNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNC.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.btnNC.Location = New System.Drawing.Point(242, 18)
        Me.btnNC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnNC.Name = "btnNC"
        Me.btnNC.Size = New System.Drawing.Size(94, 50)
        Me.btnNC.TabIndex = 7
        Me.btnNC.Text = "Almacen no conforme"
        Me.btnNC.UseVisualStyleBackColor = True
        '
        'btnVigentes
        '
        Me.btnVigentes.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVigentes.Image = Global.La_Andaluza.My.Resources.Resources.application_vnd_oasis_opendocument_spreadsheet
        Me.btnVigentes.Location = New System.Drawing.Point(130, 18)
        Me.btnVigentes.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnVigentes.Name = "btnVigentes"
        Me.btnVigentes.Size = New System.Drawing.Size(94, 50)
        Me.btnVigentes.TabIndex = 6
        Me.btnVigentes.Text = "Incidencias vigentes"
        Me.btnVigentes.UseVisualStyleBackColor = True
        '
        'btnIncidencias
        '
        Me.btnIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIncidencias.Image = Global.La_Andaluza.My.Resources.Resources.application_x_kexiproject_sqlite3
        Me.btnIncidencias.Location = New System.Drawing.Point(18, 18)
        Me.btnIncidencias.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnIncidencias.Name = "btnIncidencias"
        Me.btnIncidencias.Size = New System.Drawing.Size(94, 50)
        Me.btnIncidencias.TabIndex = 5
        Me.btnIncidencias.Text = "Informe incidencias"
        Me.btnIncidencias.UseVisualStyleBackColor = True
        '
        'btnEvaluacion
        '
        Me.btnEvaluacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvaluacion.Image = Global.La_Andaluza.My.Resources.Resources.emblem_package
        Me.btnEvaluacion.Location = New System.Drawing.Point(356, 18)
        Me.btnEvaluacion.Margin = New System.Windows.Forms.Padding(2)
        Me.btnEvaluacion.Name = "btnEvaluacion"
        Me.btnEvaluacion.Size = New System.Drawing.Size(94, 50)
        Me.btnEvaluacion.TabIndex = 11
        Me.btnEvaluacion.Text = "Evaluación"
        Me.btnEvaluacion.UseVisualStyleBackColor = True
        '
        'frmIncidenciasCalidadMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(926, 319)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmIncidenciasCalidadMain"
        Me.Text = "frmIncidenciasCalidad"
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpIncidenciasGenerales As System.Windows.Forms.TabPage
    Private WithEvents tpControlIncidencias As System.Windows.Forms.TabPage
    Private WithEvents tpTiposEnvasados As System.Windows.Forms.TabPage
    Private WithEvents tpCalsesEnvasados As System.Windows.Forms.TabPage
    Private WithEvents tpCAtegoriasEnvasados As System.Windows.Forms.TabPage
    Private WithEvents btnNC As System.Windows.Forms.Button
    Private WithEvents btnVigentes As System.Windows.Forms.Button
    Private WithEvents btnIncidencias As System.Windows.Forms.Button
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents btnEvaluacion As System.Windows.Forms.Button
End Class
