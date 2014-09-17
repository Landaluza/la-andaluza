<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntFamiliaProducto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntFamiliaProducto))
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpProductos = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(113, 18)
        Me.txtNombre.MaxLength = 300
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(200, 21)
        Me.txtNombre.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(113, 45)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 21)
        Me.txtObservaciones.TabIndex = 1
        '
        'lblNombre
        '
        Me.lblNombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNombre.Location = New System.Drawing.Point(23, 15)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(84, 27)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 42)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 27)
        Me.lblObservaciones.TabIndex = 1
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 1)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(442, 89)
        Me.tlpMiddle.TabIndex = 8
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpProductos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 114)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(442, 227)
        Me.TabControl1.TabIndex = 9
        '
        'tpProductos
        '
        Me.tpProductos.Location = New System.Drawing.Point(4, 22)
        Me.tpProductos.Name = "tpProductos"
        Me.tpProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProductos.Size = New System.Drawing.Size(434, 201)
        Me.tpProductos.TabIndex = 0
        Me.tpProductos.Text = "Productos"
        Me.tpProductos.UseVisualStyleBackColor = True
        '
        'frmEntFamiliaProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(442, 341)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(443, 134)
        Me.Name = "frmEntFamiliaProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FamiliaProducto"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtNombre As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpProductos As System.Windows.Forms.TabPage
End Class
