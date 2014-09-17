<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposProductos_ClasesProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposProductos_ClasesProductos))
        Me.cboClaseProducto = New System.Windows.Forms.ComboBox()
        Me.butVerId_ClaseProducto = New System.Windows.Forms.Button()
        Me.butAddId_ClaseProducto = New System.Windows.Forms.Button()
        Me.lblId_ClaseProducto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboClaseProducto
        '
        Me.cboClaseProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboClaseProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClaseProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboClaseProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClaseProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClaseProducto.Location = New System.Drawing.Point(128, 18)
        Me.cboClaseProducto.Name = "cboClaseProducto"
        Me.cboClaseProducto.Size = New System.Drawing.Size(200, 23)
        Me.cboClaseProducto.TabIndex = 1
        '
        'butVerId_ClaseProducto
        '
        Me.butVerId_ClaseProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_ClaseProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_ClaseProducto.FlatAppearance.BorderSize = 0
        Me.butVerId_ClaseProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_ClaseProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_ClaseProducto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_ClaseProducto.Location = New System.Drawing.Point(334, 18)
        Me.butVerId_ClaseProducto.Name = "butVerId_ClaseProducto"
        Me.butVerId_ClaseProducto.Size = New System.Drawing.Size(20, 23)
        Me.butVerId_ClaseProducto.TabIndex = 4
        Me.butVerId_ClaseProducto.TabStop = False
        '
        'butAddId_ClaseProducto
        '
        Me.butAddId_ClaseProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_ClaseProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_ClaseProducto.FlatAppearance.BorderSize = 0
        Me.butAddId_ClaseProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_ClaseProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_ClaseProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_ClaseProducto.Location = New System.Drawing.Point(360, 18)
        Me.butAddId_ClaseProducto.Name = "butAddId_ClaseProducto"
        Me.butAddId_ClaseProducto.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_ClaseProducto.TabIndex = 5
        Me.butAddId_ClaseProducto.TabStop = False
        '
        'lblId_ClaseProducto
        '
        Me.lblId_ClaseProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_ClaseProducto.Location = New System.Drawing.Point(23, 15)
        Me.lblId_ClaseProducto.Name = "lblId_ClaseProducto"
        Me.lblId_ClaseProducto.Size = New System.Drawing.Size(99, 29)
        Me.lblId_ClaseProducto.TabIndex = 3
        Me.lblId_ClaseProducto.Text = "Clase"
        Me.lblId_ClaseProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblId_ClaseProducto, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboClaseProducto, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_ClaseProducto, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_ClaseProducto, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(429, 64)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntTiposProductos_ClasesProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(413, 121)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(429, 138)
        Me.Name = "frmEntTiposProductos_ClasesProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposProductos_ClasesProductos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboClaseProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_ClaseProducto As System.Windows.Forms.Button
    Private WithEvents butAddId_ClaseProducto As System.Windows.Forms.Button
    Private WithEvents lblId_ClaseProducto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
