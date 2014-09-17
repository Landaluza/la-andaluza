<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntDetallePorFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDetallePorFamilia))
        Me.cboFamiliaProducto = New System.Windows.Forms.ComboBox()
        Me.lblId_FamiliaProducto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboFamiliaProducto
        '
        Me.cboFamiliaProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFamiliaProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFamiliaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboFamiliaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboFamiliaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFamiliaProducto.Location = New System.Drawing.Point(138, 18)
        Me.cboFamiliaProducto.Name = "cboFamiliaProducto"
        Me.cboFamiliaProducto.Size = New System.Drawing.Size(200, 23)
        Me.cboFamiliaProducto.TabIndex = 0
        '
        'lblId_FamiliaProducto
        '
        Me.lblId_FamiliaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_FamiliaProducto.Location = New System.Drawing.Point(23, 15)
        Me.lblId_FamiliaProducto.Name = "lblId_FamiliaProducto"
        Me.lblId_FamiliaProducto.Size = New System.Drawing.Size(109, 29)
        Me.lblId_FamiliaProducto.TabIndex = 0
        Me.lblId_FamiliaProducto.Text = "Producto"
        Me.lblId_FamiliaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_FamiliaProducto, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboFamiliaProducto, 2, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 2
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(439, 64)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntDetallePorFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(423, 111)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(439, 109)
        Me.Name = "frmEntDetallePorFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FamliaProductos_TiposProductos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboFamiliaProducto As System.Windows.Forms.ComboBox
    Private WithEvents lblId_FamiliaProducto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
