<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntConductores
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
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApodo = New System.Windows.Forms.TextBox()
        Me.txtDNI = New System.Windows.Forms.TextBox()
        Me.txtMovil = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblApellido1 = New System.Windows.Forms.Label()
        Me.lblApellido2 = New System.Windows.Forms.Label()
        Me.lblApodo = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblMovil = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(146, 18)
        Me.txtNombre.MaxLength = 40
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 24)
        Me.txtNombre.TabIndex = 0
        '
        'txtApellido1
        '
        Me.txtApellido1.BackColor = System.Drawing.SystemColors.Window
        Me.txtApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApellido1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido1.Location = New System.Drawing.Point(146, 53)
        Me.txtApellido1.MaxLength = 40
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(240, 24)
        Me.txtApellido1.TabIndex = 1
        '
        'txtApellido2
        '
        Me.txtApellido2.BackColor = System.Drawing.SystemColors.Window
        Me.txtApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApellido2.Location = New System.Drawing.Point(146, 88)
        Me.txtApellido2.MaxLength = 40
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(240, 24)
        Me.txtApellido2.TabIndex = 2
        '
        'txtApodo
        '
        Me.txtApodo.BackColor = System.Drawing.SystemColors.Window
        Me.txtApodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtApodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtApodo.Location = New System.Drawing.Point(146, 122)
        Me.txtApodo.MaxLength = 40
        Me.txtApodo.Name = "txtApodo"
        Me.txtApodo.Size = New System.Drawing.Size(240, 24)
        Me.txtApodo.TabIndex = 3
        '
        'txtDNI
        '
        Me.txtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.txtDNI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(146, 157)
        Me.txtDNI.MaxLength = 20
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Size = New System.Drawing.Size(240, 24)
        Me.txtDNI.TabIndex = 4
        '
        'txtMovil
        '
        Me.txtMovil.BackColor = System.Drawing.SystemColors.Window
        Me.txtMovil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMovil.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovil.Location = New System.Drawing.Point(146, 191)
        Me.txtMovil.MaxLength = 20
        Me.txtMovil.Name = "txtMovil"
        Me.txtMovil.Size = New System.Drawing.Size(240, 24)
        Me.txtMovil.TabIndex = 5
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(146, 226)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 24)
        Me.txtObservaciones.TabIndex = 6
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(27, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(113, 35)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellido1
        '
        Me.lblApellido1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApellido1.Location = New System.Drawing.Point(27, 50)
        Me.lblApellido1.Name = "lblApellido1"
        Me.lblApellido1.Size = New System.Drawing.Size(113, 35)
        Me.lblApellido1.TabIndex = 1
        Me.lblApellido1.Text = "Apellido1"
        Me.lblApellido1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApellido2
        '
        Me.lblApellido2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApellido2.Location = New System.Drawing.Point(27, 85)
        Me.lblApellido2.Name = "lblApellido2"
        Me.lblApellido2.Size = New System.Drawing.Size(113, 34)
        Me.lblApellido2.TabIndex = 2
        Me.lblApellido2.Text = "Apellido2"
        Me.lblApellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApodo
        '
        Me.lblApodo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblApodo.Location = New System.Drawing.Point(27, 119)
        Me.lblApodo.Name = "lblApodo"
        Me.lblApodo.Size = New System.Drawing.Size(113, 35)
        Me.lblApodo.TabIndex = 3
        Me.lblApodo.Text = "Apodo"
        Me.lblApodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNI
        '
        Me.lblDNI.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDNI.Location = New System.Drawing.Point(27, 154)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(113, 34)
        Me.lblDNI.TabIndex = 4
        Me.lblDNI.Text = "DNI"
        Me.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMovil
        '
        Me.lblMovil.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMovil.Location = New System.Drawing.Point(27, 188)
        Me.lblMovil.Name = "lblMovil"
        Me.lblMovil.Size = New System.Drawing.Size(113, 35)
        Me.lblMovil.TabIndex = 5
        Me.lblMovil.Text = "Movil"
        Me.lblMovil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 223)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(113, 35)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblApellido1, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtApellido1, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblApellido2, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtApellido2, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblApodo, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtApodo, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblDNI, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtDNI, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblMovil, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtMovil, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Location = New System.Drawing.Point(81, 67)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(508, 277)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntConductores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(670, 406)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntConductores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Conductores"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents txtApellido1 As System.Windows.Forms.TextBox
    Private WithEvents txtApellido2 As System.Windows.Forms.TextBox
    Private WithEvents txtApodo As System.Windows.Forms.TextBox
    Private WithEvents txtDNI As System.Windows.Forms.TextBox
    Private WithEvents txtMovil As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblApellido1 As System.Windows.Forms.Label
    Private WithEvents lblApellido2 As System.Windows.Forms.Label
    Private WithEvents lblApodo As System.Windows.Forms.Label
    Private WithEvents lblDNI As System.Windows.Forms.Label
    Private WithEvents lblMovil As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
