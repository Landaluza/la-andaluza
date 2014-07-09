<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class resumenPersonal
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
        Me.dgvGeneral = New System.Windows.Forms.DataGridView()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnResfrescar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvGeneral
        '
        Me.dgvGeneral.AllowUserToAddRows = False
        Me.dgvGeneral.AllowUserToDeleteRows = False
        Me.dgvGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvGeneral.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvGeneral.Location = New System.Drawing.Point(0, 25)
        Me.dgvGeneral.Name = "dgvGeneral"
        Me.dgvGeneral.ReadOnly = True
        Me.dgvGeneral.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvGeneral.RowHeadersVisible = False
        Me.dgvGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvGeneral.Size = New System.Drawing.Size(825, 350)
        Me.dgvGeneral.TabIndex = 0
        '
        'BackgroundWorker1
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnResfrescar})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(825, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnResfrescar
        '
        Me.btnResfrescar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnResfrescar.Image = Global.La_Andaluza.My.Resources.Resources.view_refresh_4
        Me.btnResfrescar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnResfrescar.Name = "btnResfrescar"
        Me.btnResfrescar.Size = New System.Drawing.Size(23, 22)
        Me.btnResfrescar.Text = "ToolStripButton1"
        '
        'resumenPersonal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 375)
        Me.Controls.Add(Me.dgvGeneral)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "resumenPersonal"
        Me.Text = "resumenPersonal"
        CType(Me.dgvGeneral, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents dgvGeneral As System.Windows.Forms.DataGridView
    Private WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Private WithEvents btnResfrescar As System.Windows.Forms.ToolStripButton
End Class
