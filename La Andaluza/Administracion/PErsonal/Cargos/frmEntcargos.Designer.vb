<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntcargos
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
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtobservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label
        Me.lblobservaciones = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.MaxLength = 300
        Me.txtnombre.Size = New System.Drawing.Size(200, 42)
        '
        'txtobservaciones
        '
        Me.txtobservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.TabIndex = 1
        Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtobservaciones.MaxLength = 2000
        Me.txtobservaciones.Size = New System.Drawing.Size(200, 42)
        '
        'lblnombre
        '
        Me.lblnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Text = "nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblnombre.Size = New System.Drawing.Size(84, 21)
        Me.lblnombre.Location = New System.Drawing.Point(20, 40)
        '
        'lblobservaciones
        '
        Me.lblobservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Text = "observaciones"
        Me.lblobservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblobservaciones.Size = New System.Drawing.Size(84, 21)
        Me.lblobservaciones.Location = New System.Drawing.Point(20, 40)
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
        Me.tlpMiddle.Controls.Add(Me.lblnombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtnombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblobservaciones, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtobservaciones, 2, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(414, 54)
        '
        'frmEntcargos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(414, 134)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntcargos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "cargos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtobservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblnombre As System.Windows.Forms.Label
   Private WithEvents lblobservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
