<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntDEtallePorFamilia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDEtallePorFamilia))
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoProducto = New System.Windows.Forms.Button()
        Me.butAddId_TipoProducto = New System.Windows.Forms.Button()
        Me.lblId_TipoProducto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.Location = New System.Drawing.Point(138, 18)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(200, 23)
        Me.cboTipoProducto.TabIndex = 1
        '
        'butVerId_TipoProducto
        '
        Me.butVerId_TipoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_TipoProducto.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoProducto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_TipoProducto.Location = New System.Drawing.Point(344, 18)
        Me.butVerId_TipoProducto.Name = "butVerId_TipoProducto"
        Me.butVerId_TipoProducto.Size = New System.Drawing.Size(20, 23)
        Me.butVerId_TipoProducto.TabIndex = 4
        Me.butVerId_TipoProducto.TabStop = False
        '
        'butAddId_TipoProducto
        '
        Me.butAddId_TipoProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoProducto.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoProducto.Location = New System.Drawing.Point(370, 18)
        Me.butAddId_TipoProducto.Name = "butAddId_TipoProducto"
        Me.butAddId_TipoProducto.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_TipoProducto.TabIndex = 5
        Me.butAddId_TipoProducto.TabStop = False
        '
        'lblId_TipoProducto
        '
        Me.lblId_TipoProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoProducto.Location = New System.Drawing.Point(23, 15)
        Me.lblId_TipoProducto.Name = "lblId_TipoProducto"
        Me.lblId_TipoProducto.Size = New System.Drawing.Size(109, 29)
        Me.lblId_TipoProducto.TabIndex = 3
        Me.lblId_TipoProducto.Text = "Producto"
        Me.lblId_TipoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoProducto, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboTipoProducto, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_TipoProducto, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoProducto, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(439, 64)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntDEtallePorFamilia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(423, 118)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(439, 138)
        Me.Name = "frmEntDEtallePorFamilia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FamliaProductos_TiposProductos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoProducto As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoProducto As System.Windows.Forms.Button
    Private WithEvents lblId_TipoProducto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
