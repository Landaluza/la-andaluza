<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntControlIncidencias_origen
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
        Me.gbOrigen = New System.Windows.Forms.GroupBox()
        Me.rbProveedor = New System.Windows.Forms.RadioButton()
        Me.rbEmpleado = New System.Windows.Forms.RadioButton()
        Me.rbCliente = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.panForm = New System.Windows.Forms.Panel()
        Me.gbOrigen.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbOrigen
        '
        Me.gbOrigen.Controls.Add(Me.rbProveedor)
        Me.gbOrigen.Controls.Add(Me.rbEmpleado)
        Me.gbOrigen.Controls.Add(Me.rbCliente)
        Me.gbOrigen.Location = New System.Drawing.Point(9, 72)
        Me.gbOrigen.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbOrigen.Name = "gbOrigen"
        Me.gbOrigen.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.gbOrigen.Size = New System.Drawing.Size(122, 141)
        Me.gbOrigen.TabIndex = 0
        Me.gbOrigen.TabStop = False
        Me.gbOrigen.Text = "Origen"
        '
        'rbProveedor
        '
        Me.rbProveedor.AutoSize = True
        Me.rbProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbProveedor.Location = New System.Drawing.Point(25, 84)
        Me.rbProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbProveedor.Name = "rbProveedor"
        Me.rbProveedor.Size = New System.Drawing.Size(73, 17)
        Me.rbProveedor.TabIndex = 2
        Me.rbProveedor.TabStop = True
        Me.rbProveedor.Text = "Proveedor"
        Me.rbProveedor.UseVisualStyleBackColor = True
        '
        'rbEmpleado
        '
        Me.rbEmpleado.AutoSize = True
        Me.rbEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbEmpleado.Location = New System.Drawing.Point(25, 53)
        Me.rbEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbEmpleado.Name = "rbEmpleado"
        Me.rbEmpleado.Size = New System.Drawing.Size(71, 17)
        Me.rbEmpleado.TabIndex = 1
        Me.rbEmpleado.TabStop = True
        Me.rbEmpleado.Text = "Empleado"
        Me.rbEmpleado.UseVisualStyleBackColor = True
        '
        'rbCliente
        '
        Me.rbCliente.AutoSize = True
        Me.rbCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.rbCliente.Location = New System.Drawing.Point(25, 23)
        Me.rbCliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.rbCliente.Name = "rbCliente"
        Me.rbCliente.Size = New System.Drawing.Size(56, 17)
        Me.rbCliente.TabIndex = 0
        Me.rbCliente.TabStop = True
        Me.rbCliente.Text = "Cliente"
        Me.rbCliente.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbOrigen)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.MaximumSize = New System.Drawing.Size(140, 304)
        Me.Panel1.MinimumSize = New System.Drawing.Size(140, 304)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(140, 304)
        Me.Panel1.TabIndex = 1
        '
        'panForm
        '
        Me.panForm.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panForm.Location = New System.Drawing.Point(140, 0)
        Me.panForm.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panForm.Name = "panForm"
        Me.panForm.Size = New System.Drawing.Size(620, 304)
        Me.panForm.TabIndex = 2
        '
        'frmEntControlIncidencias_origen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 304)
        Me.Controls.Add(Me.panForm)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEntControlIncidencias_origen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntControlIncidencias_origen"
        Me.gbOrigen.ResumeLayout(False)
        Me.gbOrigen.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents gbOrigen As System.Windows.Forms.GroupBox
    Private WithEvents rbProveedor As System.Windows.Forms.RadioButton
    Private WithEvents rbEmpleado As System.Windows.Forms.RadioButton
    Private WithEvents rbCliente As System.Windows.Forms.RadioButton
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents panForm As System.Windows.Forms.Panel
End Class
