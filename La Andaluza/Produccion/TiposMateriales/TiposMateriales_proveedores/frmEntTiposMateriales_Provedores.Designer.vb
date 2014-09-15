<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposMateriales_Provedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposMateriales_Provedores))
        Me.cboid_TiposMateriales = New System.Windows.Forms.ComboBox()
        Me.butVerid_TiposMateriales = New System.Windows.Forms.Button()
        Me.butAddid_TiposMateriales = New System.Windows.Forms.Button()
        Me.cboid_proveedor = New System.Windows.Forms.ComboBox()
        Me.butVerid_proveedor = New System.Windows.Forms.Button()
        Me.butAddid_proveedor = New System.Windows.Forms.Button()
        Me.lblid_TiposMateriales = New System.Windows.Forms.Label()
        Me.lblid_proveedor = New System.Windows.Forms.Label()

        Me.PanProveedor = New System.Windows.Forms.Panel()
        Me.PanTipoMaterial = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanProveedor.SuspendLayout()
        Me.PanTipoMaterial.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboid_TiposMateriales
        '
        Me.cboid_TiposMateriales.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_TiposMateriales.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_TiposMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_TiposMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_TiposMateriales.Location = New System.Drawing.Point(102, 9)
        Me.cboid_TiposMateriales.Margin = New System.Windows.Forms.Padding(2)
        Me.cboid_TiposMateriales.Name = "cboid_TiposMateriales"
        Me.cboid_TiposMateriales.Size = New System.Drawing.Size(296, 23)
        Me.cboid_TiposMateriales.TabIndex = 0
        '
        'butVerid_TiposMateriales
        '
        Me.butVerid_TiposMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_TiposMateriales.FlatAppearance.BorderSize = 0
        Me.butVerid_TiposMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_TiposMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_TiposMateriales.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_TiposMateriales.Location = New System.Drawing.Point(401, 8)
        Me.butVerid_TiposMateriales.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerid_TiposMateriales.Name = "butVerid_TiposMateriales"
        Me.butVerid_TiposMateriales.Size = New System.Drawing.Size(18, 22)
        Me.butVerid_TiposMateriales.TabIndex = 1
        Me.butVerid_TiposMateriales.TabStop = False
        '
        'butAddid_TiposMateriales
        '
        Me.butAddid_TiposMateriales.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_TiposMateriales.FlatAppearance.BorderSize = 0
        Me.butAddid_TiposMateriales.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_TiposMateriales.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_TiposMateriales.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_TiposMateriales.Location = New System.Drawing.Point(424, 8)
        Me.butAddid_TiposMateriales.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddid_TiposMateriales.Name = "butAddid_TiposMateriales"
        Me.butAddid_TiposMateriales.Size = New System.Drawing.Size(18, 22)
        Me.butAddid_TiposMateriales.TabIndex = 2
        Me.butAddid_TiposMateriales.TabStop = False
        '
        'cboid_proveedor
        '
        Me.cboid_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_proveedor.Location = New System.Drawing.Point(100, 6)
        Me.cboid_proveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.cboid_proveedor.Name = "cboid_proveedor"
        Me.cboid_proveedor.Size = New System.Drawing.Size(296, 23)
        Me.cboid_proveedor.TabIndex = 1
        '
        'butVerid_proveedor
        '
        Me.butVerid_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_proveedor.FlatAppearance.BorderSize = 0
        Me.butVerid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_proveedor.Location = New System.Drawing.Point(399, 5)
        Me.butVerid_proveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerid_proveedor.Name = "butVerid_proveedor"
        Me.butVerid_proveedor.Size = New System.Drawing.Size(18, 22)
        Me.butVerid_proveedor.TabIndex = 4
        Me.butVerid_proveedor.TabStop = False
        '
        'butAddid_proveedor
        '
        Me.butAddid_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_proveedor.Location = New System.Drawing.Point(422, 5)
        Me.butAddid_proveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddid_proveedor.Name = "butAddid_proveedor"
        Me.butAddid_proveedor.Size = New System.Drawing.Size(18, 22)
        Me.butAddid_proveedor.TabIndex = 5
        Me.butAddid_proveedor.TabStop = False
        '
        'lblid_TiposMateriales
        '
        Me.lblid_TiposMateriales.Location = New System.Drawing.Point(2, 6)
        Me.lblid_TiposMateriales.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_TiposMateriales.Name = "lblid_TiposMateriales"
        Me.lblid_TiposMateriales.Size = New System.Drawing.Size(95, 30)
        Me.lblid_TiposMateriales.TabIndex = 0
        Me.lblid_TiposMateriales.Text = "Tipo material"
        Me.lblid_TiposMateriales.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.Location = New System.Drawing.Point(-2, 3)
        Me.lblid_proveedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(98, 30)
        Me.lblid_proveedor.TabIndex = 3
        Me.lblid_proveedor.Text = "Proveedor"
        Me.lblid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'PanProveedor
        '
        Me.PanProveedor.Controls.Add(Me.cboid_proveedor)
        Me.PanProveedor.Controls.Add(Me.butVerid_proveedor)
        Me.PanProveedor.Controls.Add(Me.butAddid_proveedor)
        Me.PanProveedor.Controls.Add(Me.lblid_proveedor)
        Me.PanProveedor.Location = New System.Drawing.Point(38, 60)
        Me.PanProveedor.Margin = New System.Windows.Forms.Padding(2)
        Me.PanProveedor.Name = "PanProveedor"
        Me.PanProveedor.Size = New System.Drawing.Size(452, 32)
        Me.PanProveedor.TabIndex = 1000000001
        '
        'PanTipoMaterial
        '
        Me.PanTipoMaterial.Controls.Add(Me.cboid_TiposMateriales)
        Me.PanTipoMaterial.Controls.Add(Me.butAddid_TiposMateriales)
        Me.PanTipoMaterial.Controls.Add(Me.lblid_TiposMateriales)
        Me.PanTipoMaterial.Controls.Add(Me.butVerid_TiposMateriales)
        Me.PanTipoMaterial.Location = New System.Drawing.Point(35, 23)
        Me.PanTipoMaterial.Margin = New System.Windows.Forms.Padding(2)
        Me.PanTipoMaterial.Name = "PanTipoMaterial"
        Me.PanTipoMaterial.Size = New System.Drawing.Size(454, 32)
        Me.PanTipoMaterial.TabIndex = 1000000002
        '
        'frmEntTiposMateriales_Provedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(526, 111)
        Me.Controls.Add(Me.PanTipoMaterial)
        Me.Controls.Add(Me.PanProveedor)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTiposMateriales_Provedores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposMateriales_Provedores"
        Me.Controls.SetChildIndex(Me.PanProveedor, 0)
        Me.Controls.SetChildIndex(Me.PanTipoMaterial, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanProveedor.ResumeLayout(False)
        Me.PanTipoMaterial.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboid_TiposMateriales As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_TiposMateriales As System.Windows.Forms.Button
   Private WithEvents butAddid_TiposMateriales As System.Windows.Forms.Button
   Private WithEvents cboid_proveedor As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_proveedor As System.Windows.Forms.Button
   Private WithEvents butAddid_proveedor As System.Windows.Forms.Button
   Private WithEvents lblid_TiposMateriales As System.Windows.Forms.Label
   Private WithEvents lblid_proveedor As System.Windows.Forms.Label

    Private WithEvents PanProveedor As System.Windows.Forms.Panel
    Private WithEvents PanTipoMaterial As System.Windows.Forms.Panel
End Class
