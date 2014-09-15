<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGeneradorBoletines
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
        Me.btnAgnadir = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboPlantilla = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.cboLote = New System.Windows.Forms.ComboBox()
        Me.panReporte = New System.Windows.Forms.Panel()
        Me.panBoletin = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.panReporte.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.btnAgnadir)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.cboPlantilla)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cboTipoProducto)
        Me.Panel1.Controls.Add(Me.cboLote)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1028, 65)
        Me.Panel1.TabIndex = 2
        '
        'btnAgnadir
        '
        Me.btnAgnadir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgnadir.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.btnAgnadir.FlatAppearance.BorderSize = 0
        Me.btnAgnadir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAgnadir.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnAgnadir.Location = New System.Drawing.Point(985, 23)
        Me.btnAgnadir.Name = "btnAgnadir"
        Me.btnAgnadir.Size = New System.Drawing.Size(29, 21)
        Me.btnAgnadir.TabIndex = 8
        Me.btnAgnadir.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel3.Location = New System.Drawing.Point(402, 5)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1, 50)
        Me.Panel3.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.Panel2.Location = New System.Drawing.Point(655, 5)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1, 50)
        Me.Panel2.TabIndex = 6
        '
        'cboPlantilla
        '
        Me.cboPlantilla.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboPlantilla.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPlantilla.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPlantilla.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPlantilla.FormattingEnabled = True
        Me.cboPlantilla.Location = New System.Drawing.Point(721, 23)
        Me.cboPlantilla.Name = "cboPlantilla"
        Me.cboPlantilla.Size = New System.Drawing.Size(265, 21)
        Me.cboPlantilla.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(673, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Plantilla"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(420, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(28, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Lote"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Tipo Producto"
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(92, 23)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(292, 21)
        Me.cboTipoProducto.TabIndex = 0
        '
        'cboLote
        '
        Me.cboLote.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cboLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLote.FormattingEnabled = True
        Me.cboLote.Location = New System.Drawing.Point(454, 23)
        Me.cboLote.Name = "cboLote"
        Me.cboLote.Size = New System.Drawing.Size(184, 21)
        Me.cboLote.TabIndex = 1
        '
        'panReporte
        '
        Me.panReporte.Controls.Add(Me.panBoletin)
        Me.panReporte.Controls.Add(Me.Panel5)
        Me.panReporte.Controls.Add(Me.Panel4)
        Me.panReporte.Controls.Add(Me.Panel1)
        Me.panReporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panReporte.Location = New System.Drawing.Point(0, 0)
        Me.panReporte.Name = "panReporte"
        Me.panReporte.Size = New System.Drawing.Size(1028, 687)
        Me.panReporte.TabIndex = 3
        '
        'panBoletin
        '
        Me.panBoletin.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panBoletin.Location = New System.Drawing.Point(55, 65)
        Me.panBoletin.Name = "panBoletin"
        Me.panBoletin.Size = New System.Drawing.Size(922, 622)
        Me.panBoletin.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 65)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(55, 622)
        Me.Panel5.TabIndex = 5
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(977, 65)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(51, 622)
        Me.Panel4.TabIndex = 4
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 350
        Me.ToolTip1.ShowAlways = True
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmGeneradorBoletines
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1028, 687)
        Me.Controls.Add(Me.panReporte)
        Me.DoubleBuffered = True
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmGeneradorBoletines"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Boletines"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.panReporte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
   Private WithEvents Panel1 As System.Windows.Forms.Panel
   Private WithEvents Panel3 As System.Windows.Forms.Panel
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents cboPlantilla As System.Windows.Forms.ComboBox
   Private WithEvents Label3 As System.Windows.Forms.Label
   Private WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
   Private WithEvents cboLote As System.Windows.Forms.ComboBox
   Private WithEvents panReporte As System.Windows.Forms.Panel
   Private WithEvents btnAgnadir As System.Windows.Forms.Button
   Private WithEvents panBoletin As System.Windows.Forms.Panel
   Private WithEvents Panel5 As System.Windows.Forms.Panel
   Private WithEvents Panel4 As System.Windows.Forms.Panel
   Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
