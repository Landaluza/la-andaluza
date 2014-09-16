<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntClasesProductos
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblObservaciones = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Name = "txtNombre
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.MaxLength = 300
        Me.txtNombre.Size = New System.Drawing.Size(200,42)
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Name = "txtObservaciones
        Me.txtObservaciones.TabIndex = 1
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Size = New System.Drawing.Size(280,42)
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Name = "lblNombre
        Me.lblNombre.Text = "Nombre
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblNombre.Size = New System.Drawing.Size(84,21)
        Me.lblNombre.Location = New System.Drawing.Point(20,40)
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Name = "lblObservaciones
        Me.lblObservaciones.Text = "Observaciones
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblObservaciones.Size = New System.Drawing.Size(84,21)
        Me.lblObservaciones.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(443, 54)
        '
        '
        'frmEntClasesProductos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(443, 134)
        Me.MinimumSize = New System.Drawing.Size(443, 134)
        Me.Name = "frmEntClasesProductos
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ClasesProductos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(414,324)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
