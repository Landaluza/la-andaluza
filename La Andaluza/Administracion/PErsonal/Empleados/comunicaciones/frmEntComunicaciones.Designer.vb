<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntComunicaciones
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
        Me.txtPrimerApellido = New System.Windows.Forms.TextBox()
        Me.txtSegundoApellido = New System.Windows.Forms.TextBox()
        Me.txtMovilEmpresa = New System.Windows.Forms.TextBox()
        Me.txtEmailEmpresa = New System.Windows.Forms.TextBox()
        Me.txtExtension = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblPrimerApellido = New System.Windows.Forms.Label()
        Me.lblSegundoApellido = New System.Windows.Forms.Label()
        Me.lblMovilEmpresa = New System.Windows.Forms.Label()
        Me.lblEmailEmpresa = New System.Windows.Forms.Label()
        Me.lblExtension = New System.Windows.Forms.Label()
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
        Me.txtNombre.Location = New System.Drawing.Point(162, 18)
        Me.txtNombre.MaxLength = 100
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(240, 24)
        Me.txtNombre.TabIndex = 0
        '
        'txtPrimerApellido
        '
        Me.txtPrimerApellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtPrimerApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPrimerApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrimerApellido.Location = New System.Drawing.Point(162, 53)
        Me.txtPrimerApellido.MaxLength = 200
        Me.txtPrimerApellido.Name = "txtPrimerApellido"
        Me.txtPrimerApellido.Size = New System.Drawing.Size(240, 24)
        Me.txtPrimerApellido.TabIndex = 1
        '
        'txtSegundoApellido
        '
        Me.txtSegundoApellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtSegundoApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtSegundoApellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSegundoApellido.Location = New System.Drawing.Point(162, 88)
        Me.txtSegundoApellido.MaxLength = 200
        Me.txtSegundoApellido.Name = "txtSegundoApellido"
        Me.txtSegundoApellido.Size = New System.Drawing.Size(240, 24)
        Me.txtSegundoApellido.TabIndex = 2
        '
        'txtMovilEmpresa
        '
        Me.txtMovilEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtMovilEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMovilEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMovilEmpresa.Location = New System.Drawing.Point(162, 122)
        Me.txtMovilEmpresa.MaxLength = 9
        Me.txtMovilEmpresa.Name = "txtMovilEmpresa"
        Me.txtMovilEmpresa.Size = New System.Drawing.Size(240, 24)
        Me.txtMovilEmpresa.TabIndex = 3
        '
        'txtEmailEmpresa
        '
        Me.txtEmailEmpresa.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmailEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtEmailEmpresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailEmpresa.Location = New System.Drawing.Point(162, 157)
        Me.txtEmailEmpresa.MaxLength = 300
        Me.txtEmailEmpresa.Name = "txtEmailEmpresa"
        Me.txtEmailEmpresa.Size = New System.Drawing.Size(240, 24)
        Me.txtEmailEmpresa.TabIndex = 4
        '
        'txtExtension
        '
        Me.txtExtension.BackColor = System.Drawing.SystemColors.Window
        Me.txtExtension.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtExtension.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtension.Location = New System.Drawing.Point(162, 191)
        Me.txtExtension.MaxLength = 3
        Me.txtExtension.Name = "txtExtension"
        Me.txtExtension.Size = New System.Drawing.Size(240, 24)
        Me.txtExtension.TabIndex = 5
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(26, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(130, 35)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPrimerApellido
        '
        Me.lblPrimerApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPrimerApellido.Location = New System.Drawing.Point(26, 50)
        Me.lblPrimerApellido.Name = "lblPrimerApellido"
        Me.lblPrimerApellido.Size = New System.Drawing.Size(130, 35)
        Me.lblPrimerApellido.TabIndex = 1
        Me.lblPrimerApellido.Text = "Primer Apellido"
        Me.lblPrimerApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSegundoApellido
        '
        Me.lblSegundoApellido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblSegundoApellido.Location = New System.Drawing.Point(26, 85)
        Me.lblSegundoApellido.Name = "lblSegundoApellido"
        Me.lblSegundoApellido.Size = New System.Drawing.Size(130, 34)
        Me.lblSegundoApellido.TabIndex = 2
        Me.lblSegundoApellido.Text = "Segundo Apellido"
        Me.lblSegundoApellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMovilEmpresa
        '
        Me.lblMovilEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMovilEmpresa.Location = New System.Drawing.Point(26, 119)
        Me.lblMovilEmpresa.Name = "lblMovilEmpresa"
        Me.lblMovilEmpresa.Size = New System.Drawing.Size(130, 35)
        Me.lblMovilEmpresa.TabIndex = 3
        Me.lblMovilEmpresa.Text = "Movil Empresa"
        Me.lblMovilEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmailEmpresa
        '
        Me.lblEmailEmpresa.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEmailEmpresa.Location = New System.Drawing.Point(26, 154)
        Me.lblEmailEmpresa.Name = "lblEmailEmpresa"
        Me.lblEmailEmpresa.Size = New System.Drawing.Size(130, 34)
        Me.lblEmailEmpresa.TabIndex = 4
        Me.lblEmailEmpresa.Text = "Email Empresa"
        Me.lblEmailEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExtension
        '
        Me.lblExtension.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblExtension.Location = New System.Drawing.Point(26, 188)
        Me.lblExtension.Name = "lblExtension"
        Me.lblExtension.Size = New System.Drawing.Size(130, 35)
        Me.lblExtension.TabIndex = 5
        Me.lblExtension.Text = "Extension"
        Me.lblExtension.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 136.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblPrimerApellido, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtPrimerApellido, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblSegundoApellido, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtSegundoApellido, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblMovilEmpresa, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtMovilEmpresa, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblEmailEmpresa, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtEmailEmpresa, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblExtension, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtExtension, 2, 5)
        Me.tlpMiddle.Location = New System.Drawing.Point(59, 28)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(415, 239)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntComunicaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(556, 298)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntComunicaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Comunicaciones"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents txtPrimerApellido As System.Windows.Forms.TextBox
    Private WithEvents txtSegundoApellido As System.Windows.Forms.TextBox
    Private WithEvents txtMovilEmpresa As System.Windows.Forms.TextBox
    Private WithEvents txtEmailEmpresa As System.Windows.Forms.TextBox
    Private WithEvents txtExtension As System.Windows.Forms.TextBox
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblPrimerApellido As System.Windows.Forms.Label
    Private WithEvents lblSegundoApellido As System.Windows.Forms.Label
    Private WithEvents lblMovilEmpresa As System.Windows.Forms.Label
    Private WithEvents lblEmailEmpresa As System.Windows.Forms.Label
    Private WithEvents lblExtension As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
