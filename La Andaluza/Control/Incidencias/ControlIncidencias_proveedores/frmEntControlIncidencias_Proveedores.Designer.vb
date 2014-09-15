<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_Proveedores))
        Me.cboid_proveedor = New System.Windows.Forms.ComboBox()
        Me.butVerid_proveedor = New System.Windows.Forms.Button()
        Me.butAddid_proveedor = New System.Windows.Forms.Button()
        Me.lblid_proveedor = New System.Windows.Forms.Label()

        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboid_proveedor
        '
        Me.cboid_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_proveedor.Location = New System.Drawing.Point(88, 22)
        Me.cboid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_proveedor.Name = "cboid_proveedor"
        Me.cboid_proveedor.Size = New System.Drawing.Size(455, 23)
        Me.cboid_proveedor.TabIndex = 1
        '
        'butVerid_proveedor
        '
        Me.butVerid_proveedor.FlatAppearance.BorderSize = 0
        Me.butVerid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_proveedor.Location = New System.Drawing.Point(546, 23)
        Me.butVerid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_proveedor.Name = "butVerid_proveedor"
        Me.butVerid_proveedor.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_proveedor.TabIndex = 4
        Me.butVerid_proveedor.TabStop = False
        '
        'butAddid_proveedor
        '
        Me.butAddid_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_proveedor.Location = New System.Drawing.Point(568, 23)
        Me.butAddid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_proveedor.Name = "butAddid_proveedor"
        Me.butAddid_proveedor.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_proveedor.TabIndex = 5
        Me.butAddid_proveedor.TabStop = False
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.Location = New System.Drawing.Point(11, 20)
        Me.lblid_proveedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(77, 30)
        Me.lblid_proveedor.TabIndex = 3
        Me.lblid_proveedor.Text = "Proveedores"
        Me.lblid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cboid_proveedor)
        Me.Panel1.Controls.Add(Me.lblid_proveedor)
        Me.Panel1.Controls.Add(Me.butAddid_proveedor)
        Me.Panel1.Controls.Add(Me.butVerid_proveedor)
        Me.Panel1.Location = New System.Drawing.Point(26, 33)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(601, 81)
        Me.Panel1.TabIndex = 1000000001
        '
        'frmEntControlIncidencias_Proveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(644, 130)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias_Proveedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_Proveedores"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboid_proveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_proveedor As System.Windows.Forms.Button
    Private WithEvents butAddid_proveedor As System.Windows.Forms.Button
    Private WithEvents lblid_proveedor As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
