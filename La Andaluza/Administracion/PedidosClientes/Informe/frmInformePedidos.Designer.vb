<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInformePedidos
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
        Me.components = New System.ComponentModel.Container()
        Me.dgvPedidos = New System.Windows.Forms.DataGridView()
        Me.butOK = New System.Windows.Forms.Button()
        Me.butReport = New System.Windows.Forms.Button()
        Me.butLimpiar = New System.Windows.Forms.Button()
        Me.dgvAlbaranes = New System.Windows.Forms.DataGridView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.chbMostrar0 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvPedidos
        '
        Me.dgvPedidos.AllowUserToAddRows = False
        Me.dgvPedidos.AllowUserToDeleteRows = False
        Me.dgvPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPedidos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvPedidos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvPedidos.Location = New System.Drawing.Point(0, 0)
        Me.dgvPedidos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvPedidos.Name = "dgvPedidos"
        Me.dgvPedidos.RowTemplate.Height = 24
        Me.dgvPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect
        Me.dgvPedidos.Size = New System.Drawing.Size(1839, 829)
        Me.dgvPedidos.TabIndex = 0
        '
        'butOK
        '
        Me.butOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.butOK.Location = New System.Drawing.Point(320, 747)
        Me.butOK.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butOK.Name = "butOK"
        Me.butOK.Size = New System.Drawing.Size(100, 28)
        Me.butOK.TabIndex = 1
        Me.butOK.Text = "Ver"
        Me.butOK.UseVisualStyleBackColor = True
        Me.butOK.Visible = False
        '
        'butReport
        '
        Me.butReport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.butReport.Enabled = False
        Me.butReport.Location = New System.Drawing.Point(1597, 730)
        Me.butReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butReport.Name = "butReport"
        Me.butReport.Size = New System.Drawing.Size(100, 28)
        Me.butReport.TabIndex = 2
        Me.butReport.Text = "Reporte"
        Me.butReport.UseVisualStyleBackColor = True
        Me.butReport.Visible = False
        '
        'butLimpiar
        '
        Me.butLimpiar.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.butLimpiar.Location = New System.Drawing.Point(-329, 797)
        Me.butLimpiar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butLimpiar.Name = "butLimpiar"
        Me.butLimpiar.Size = New System.Drawing.Size(153, 28)
        Me.butLimpiar.TabIndex = 5
        Me.butLimpiar.Text = "Limpiar selecciones"
        Me.butLimpiar.UseVisualStyleBackColor = True
        Me.butLimpiar.Visible = False
        '
        'dgvAlbaranes
        '
        Me.dgvAlbaranes.AllowUserToAddRows = False
        Me.dgvAlbaranes.AllowUserToDeleteRows = False
        Me.dgvAlbaranes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvAlbaranes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvAlbaranes.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.dgvAlbaranes.Location = New System.Drawing.Point(4, 28)
        Me.dgvAlbaranes.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvAlbaranes.Name = "dgvAlbaranes"
        Me.dgvAlbaranes.RowTemplate.Height = 24
        Me.dgvAlbaranes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvAlbaranes.Size = New System.Drawing.Size(45, 1028)
        Me.dgvAlbaranes.TabIndex = 6
        Me.dgvAlbaranes.Visible = False
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvAlbaranes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.butLimpiar)
        Me.ToolTip1.SetToolTip(Me.SplitContainer1.Panel1, "Para seleccionar mas de " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "un registro utilice [Ctrl + Clic]")
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.btnSalir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.chbMostrar0)
        Me.SplitContainer1.Panel2.Controls.Add(Me.butReport)
        Me.SplitContainer1.Panel2.Controls.Add(Me.butOK)
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvPedidos)
        Me.SplitContainer1.Size = New System.Drawing.Size(1871, 831)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-329, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(357, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "ALBARANES EN TRANSITO (Multiselescion Ctrl + click)"
        Me.Label1.Visible = False
        '
        'btnSalir
        '
        Me.btnSalir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnSalir.Location = New System.Drawing.Point(1723, 709)
        Me.btnSalir.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(100, 28)
        Me.btnSalir.TabIndex = 10
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        Me.btnSalir.Visible = False
        '
        'chbMostrar0
        '
        Me.chbMostrar0.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.chbMostrar0.AutoSize = True
        Me.chbMostrar0.Location = New System.Drawing.Point(4, 754)
        Me.chbMostrar0.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbMostrar0.Name = "chbMostrar0"
        Me.chbMostrar0.Size = New System.Drawing.Size(237, 21)
        Me.chbMostrar0.TabIndex = 9
        Me.chbMostrar0.Text = "Mostrar Articulos con valores = 0"
        Me.chbMostrar0.UseVisualStyleBackColor = True
        Me.chbMostrar0.Visible = False
        '
        'ToolTip1
        '
        Me.ToolTip1.BackColor = System.Drawing.Color.Khaki
        Me.ToolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info
        '
        'frmInformePedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1871, 831)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmInformePedidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "2010.09.07 INFORME PEDIDOS"
        CType(Me.dgvPedidos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvAlbaranes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents dgvPedidos As System.Windows.Forms.DataGridView
    Private WithEvents butOK As System.Windows.Forms.Button
    Private WithEvents butReport As System.Windows.Forms.Button
    Private WithEvents butLimpiar As System.Windows.Forms.Button
    Private WithEvents dgvAlbaranes As System.Windows.Forms.DataGridView
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents chbMostrar0 As System.Windows.Forms.CheckBox
    Private WithEvents btnSalir As System.Windows.Forms.Button
End Class
