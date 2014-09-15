<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_Empleados))
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.lblId_empleado = New System.Windows.Forms.Label()

        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(68, 28)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(382, 23)
        Me.cboempleado.TabIndex = 1
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(453, 29)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_empleado.TabIndex = 4
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(476, 29)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_empleado.TabIndex = 5
        Me.butAddId_empleado.TabStop = False
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Location = New System.Drawing.Point(8, 26)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(61, 30)
        Me.lblId_empleado.TabIndex = 3
        Me.lblId_empleado.Text = "Empleado"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboempleado)
        Me.Panel1.Controls.Add(Me.lblId_empleado)
        Me.Panel1.Controls.Add(Me.butAddId_empleado)
        Me.Panel1.Controls.Add(Me.butVerId_empleado)
        Me.Panel1.Location = New System.Drawing.Point(9, 41)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(507, 81)
        Me.Panel1.TabIndex = 1000000001
        '
        'frmEntControlIncidencias_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(529, 150)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_Empleados"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
