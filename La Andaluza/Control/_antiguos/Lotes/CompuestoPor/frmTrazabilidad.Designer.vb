<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTrazabilidad
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
        Dim Label20 As System.Windows.Forms.Label
        Dim Label37 As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.dgvCompuestoPor = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripCompuestopor = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarCompuestoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvComponenteDe = New System.Windows.Forms.DataGridView()
        Me.ContextMenuStripformaparte = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ModificarFormaPArtedeToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Label20 = New System.Windows.Forms.Label()
        Label37 = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.dgvCompuestoPor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripCompuestopor.SuspendLayout()
        CType(Me.dgvComponenteDe, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripformaparte.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label20
        '
        Label20.AutoSize = True
        Label20.Dock = System.Windows.Forms.DockStyle.Top
        Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label20.Location = New System.Drawing.Point(0, 0)
        Label20.Name = "Label20"
        Label20.Size = New System.Drawing.Size(141, 15)
        Label20.TabIndex = 71
        Label20.Text = "Esta Compuesto Por:"
        '
        'Label37
        '
        Label37.AutoSize = True
        Label37.Dock = System.Windows.Forms.DockStyle.Top
        Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label37.Location = New System.Drawing.Point(0, 0)
        Label37.Name = "Label37"
        Label37.Size = New System.Drawing.Size(112, 15)
        Label37.TabIndex = 72
        Label37.Text = "Forma Parte De:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.dgvCompuestoPor)
        Me.SplitContainer1.Panel1.Controls.Add(Label20)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.dgvComponenteDe)
        Me.SplitContainer1.Panel2.Controls.Add(Label37)
        Me.SplitContainer1.Size = New System.Drawing.Size(825, 266)
        Me.SplitContainer1.SplitterDistance = 374
        Me.SplitContainer1.SplitterWidth = 19
        Me.SplitContainer1.TabIndex = 74
        '
        'dgvCompuestoPor
        '
        Me.dgvCompuestoPor.AllowUserToAddRows = False
        Me.dgvCompuestoPor.AllowUserToDeleteRows = False
        Me.dgvCompuestoPor.AllowUserToResizeRows = False
        Me.dgvCompuestoPor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvCompuestoPor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvCompuestoPor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCompuestoPor.ContextMenuStrip = Me.ContextMenuStripCompuestopor
        Me.dgvCompuestoPor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvCompuestoPor.Location = New System.Drawing.Point(0, 15)
        Me.dgvCompuestoPor.Name = "dgvCompuestoPor"
        Me.dgvCompuestoPor.ReadOnly = True
        Me.dgvCompuestoPor.RowHeadersVisible = False
        Me.dgvCompuestoPor.RowHeadersWidth = 14
        DataGridViewCellStyle1.Format = "N0"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.dgvCompuestoPor.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvCompuestoPor.RowTemplate.DefaultCellStyle.Format = "N0"
        Me.dgvCompuestoPor.RowTemplate.DefaultCellStyle.NullValue = Nothing
        Me.dgvCompuestoPor.RowTemplate.Height = 24
        Me.dgvCompuestoPor.Size = New System.Drawing.Size(374, 251)
        Me.dgvCompuestoPor.TabIndex = 0
        '
        'ContextMenuStripCompuestopor
        '
        Me.ContextMenuStripCompuestopor.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarCompuestoToolStripMenuItem})
        Me.ContextMenuStripCompuestopor.Name = "ContextMenuStrip1"
        Me.ContextMenuStripCompuestopor.Size = New System.Drawing.Size(126, 26)
        '
        'ModificarCompuestoToolStripMenuItem
        '
        Me.ModificarCompuestoToolStripMenuItem.Name = "ModificarCompuestoToolStripMenuItem"
        Me.ModificarCompuestoToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.ModificarCompuestoToolStripMenuItem.Text = "Modificar"
        '
        'dgvComponenteDe
        '
        Me.dgvComponenteDe.AllowUserToAddRows = False
        Me.dgvComponenteDe.AllowUserToDeleteRows = False
        Me.dgvComponenteDe.AllowUserToResizeRows = False
        Me.dgvComponenteDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvComponenteDe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvComponenteDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvComponenteDe.ContextMenuStrip = Me.ContextMenuStripformaparte
        Me.dgvComponenteDe.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvComponenteDe.Location = New System.Drawing.Point(0, 15)
        Me.dgvComponenteDe.Name = "dgvComponenteDe"
        Me.dgvComponenteDe.ReadOnly = True
        Me.dgvComponenteDe.RowHeadersVisible = False
        Me.dgvComponenteDe.RowHeadersWidth = 14
        Me.dgvComponenteDe.RowTemplate.Height = 24
        Me.dgvComponenteDe.Size = New System.Drawing.Size(432, 251)
        Me.dgvComponenteDe.TabIndex = 1
        '
        'ContextMenuStripformaparte
        '
        Me.ContextMenuStripformaparte.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ModificarFormaPArtedeToolStripMenuItem1})
        Me.ContextMenuStripformaparte.Name = "ContextMenuStrip2"
        Me.ContextMenuStripformaparte.Size = New System.Drawing.Size(153, 48)
        '
        'ModificarFormaPArtedeToolStripMenuItem1
        '
        Me.ModificarFormaPArtedeToolStripMenuItem1.Name = "ModificarFormaPArtedeToolStripMenuItem1"
        Me.ModificarFormaPArtedeToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ModificarFormaPArtedeToolStripMenuItem1.Text = "Modificar"
        '
        'BackgroundWorker1
        '
        '
        'frmTrazabilidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 266)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmTrazabilidad"
        Me.Text = "frmTrazabilidad"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.dgvCompuestoPor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripCompuestopor.ResumeLayout(False)
        CType(Me.dgvComponenteDe, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripformaparte.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents dgvCompuestoPor As System.Windows.Forms.DataGridView
    Private WithEvents dgvComponenteDe As System.Windows.Forms.DataGridView
    Private WithEvents ContextMenuStripformaparte As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ModificarFormaPArtedeToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents ContextMenuStripCompuestopor As System.Windows.Forms.ContextMenuStrip
    Private WithEvents ModificarCompuestoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
End Class
