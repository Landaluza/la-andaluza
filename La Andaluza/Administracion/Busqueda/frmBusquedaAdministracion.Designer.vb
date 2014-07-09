<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBusquedaAdministracion
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
        Me.components = New System.ComponentModel.Container()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtBusqueda = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dgvResultados = New System.Windows.Forms.DataGridView()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cbCamiones = New System.Windows.Forms.CheckBox()
        Me.cbConductores = New System.Windows.Forms.CheckBox()
        Me.Panel1.SuspendLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBusqueda)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(12, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(275, 45)
        Me.Panel1.TabIndex = 0
        '
        'txtBusqueda
        '
        Me.txtBusqueda.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusqueda.Location = New System.Drawing.Point(0, 20)
        Me.txtBusqueda.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtBusqueda.Name = "txtBusqueda"
        Me.txtBusqueda.Size = New System.Drawing.Size(273, 20)
        Me.txtBusqueda.TabIndex = 0
        Me.ToolTip1.SetToolTip(Me.txtBusqueda, "Escribe el texto a buscar y pulsa intro")
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(12, 390)
        Me.Panel2.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel3.Location = New System.Drawing.Point(287, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(11, 390)
        Me.Panel3.TabIndex = 2
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(12, 282)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(275, 13)
        Me.Panel4.TabIndex = 4
        '
        'dgvResultados
        '
        Me.dgvResultados.AllowUserToAddRows = False
        Me.dgvResultados.AllowUserToDeleteRows = False
        Me.dgvResultados.AllowUserToResizeColumns = False
        Me.dgvResultados.AllowUserToResizeRows = False
        Me.dgvResultados.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResultados.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dgvResultados.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvResultados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvResultados.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.dgvResultados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResultados.ColumnHeadersVisible = False
        Me.dgvResultados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvResultados.EnableHeadersVisualStyles = False
        Me.dgvResultados.Location = New System.Drawing.Point(12, 45)
        Me.dgvResultados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dgvResultados.MultiSelect = False
        Me.dgvResultados.Name = "dgvResultados"
        Me.dgvResultados.ReadOnly = True
        Me.dgvResultados.RowHeadersVisible = False
        Me.dgvResultados.RowTemplate.Height = 24
        Me.dgvResultados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvResultados.Size = New System.Drawing.Size(275, 237)
        Me.dgvResultados.TabIndex = 1
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel5.Location = New System.Drawing.Point(12, 376)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(275, 14)
        Me.Panel5.TabIndex = 6
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cbCamiones)
        Me.Panel6.Controls.Add(Me.cbConductores)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel6.Location = New System.Drawing.Point(12, 295)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(275, 81)
        Me.Panel6.TabIndex = 2
        '
        'cbCamiones
        '
        Me.cbCamiones.AutoSize = True
        Me.cbCamiones.Checked = True
        Me.cbCamiones.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbCamiones.Image = Global.La_Andaluza.My.Resources.Resources.car
        Me.cbCamiones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbCamiones.Location = New System.Drawing.Point(4, 27)
        Me.cbCamiones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCamiones.Name = "cbCamiones"
        Me.cbCamiones.Size = New System.Drawing.Size(87, 17)
        Me.cbCamiones.TabIndex = 1
        Me.cbCamiones.Text = "     Camiones"
        Me.cbCamiones.UseVisualStyleBackColor = True
        '
        'cbConductores
        '
        Me.cbConductores.AutoSize = True
        Me.cbConductores.Checked = True
        Me.cbConductores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbConductores.Image = Global.La_Andaluza.My.Resources.Resources.vcard
        Me.cbConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cbConductores.Location = New System.Drawing.Point(4, 5)
        Me.cbConductores.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbConductores.Name = "cbConductores"
        Me.cbConductores.Size = New System.Drawing.Size(101, 17)
        Me.cbConductores.TabIndex = 0
        Me.cbConductores.Text = "     Conductores"
        Me.cbConductores.UseVisualStyleBackColor = True
        '
        'frmBusquedaAdministracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 390)
        Me.Controls.Add(Me.dgvResultados)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmBusquedaAdministracion"
        Me.Text = "frmBusquedaAdministracion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgvResultados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents txtBusqueda As System.Windows.Forms.TextBox
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents dgvResultados As System.Windows.Forms.DataGridView
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents cbCamiones As System.Windows.Forms.CheckBox
    Private WithEvents cbConductores As System.Windows.Forms.CheckBox
End Class
