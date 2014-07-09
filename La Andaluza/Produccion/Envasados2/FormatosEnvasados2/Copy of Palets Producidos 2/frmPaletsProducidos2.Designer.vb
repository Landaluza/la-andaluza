<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPaletsProducidos2
    Inherits BasesParaCompatibilidad.FrmAheredarOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Overloads Sub InitializeComponent()
        Me.PrintGrilla = New System.Drawing.Printing.PrintDocument()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lEstado = New System.Windows.Forms.Label()
        Me.cbEstado = New System.Windows.Forms.CheckBox()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'PrintGrilla
        '
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lEstado)
        Me.Panel1.Controls.Add(Me.cbEstado)
        Me.Panel1.Controls.Add(Me.cboEstado)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(988, 39)
        Me.Panel1.TabIndex = 12
        '
        'lEstado
        '
        Me.lEstado.AutoSize = True
        Me.lEstado.Location = New System.Drawing.Point(36, 10)
        Me.lEstado.Name = "lEstado"
        Me.lEstado.Size = New System.Drawing.Size(116, 17)
        Me.lEstado.TabIndex = 2
        Me.lEstado.Text = "Filtrar por estado"
        '
        'cbEstado
        '
        Me.cbEstado.AutoSize = True
        Me.cbEstado.Location = New System.Drawing.Point(16, 11)
        Me.cbEstado.Name = "cbEstado"
        Me.cbEstado.Size = New System.Drawing.Size(18, 17)
        Me.cbEstado.TabIndex = 1
        Me.cbEstado.UseVisualStyleBackColor = True
        '
        'cboEstado
        '
        Me.cboEstado.Enabled = False
        Me.cboEstado.FormattingEnabled = True
        Me.cboEstado.Location = New System.Drawing.Point(158, 7)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(269, 24)
        Me.cboEstado.TabIndex = 0
        '
        'frmPaletsProducidos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(988, 567)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(398, 55)
        Me.Name = "frmPaletsProducidos2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Palets producidos"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents PrintGrilla As System.Drawing.Printing.PrintDocument
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents lEstado As System.Windows.Forms.Label
    Private WithEvents cbEstado As System.Windows.Forms.CheckBox
    Private WithEvents cboEstado As System.Windows.Forms.ComboBox

End Class
