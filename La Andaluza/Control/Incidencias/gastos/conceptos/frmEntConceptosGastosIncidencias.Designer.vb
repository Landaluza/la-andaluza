<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntConceptosGastosIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntConceptosGastosIncidencias))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cbotiposConceptos = New System.Windows.Forms.ComboBox()
        Me.butVerId_tiposConceptos = New System.Windows.Forms.Button()
        Me.butAddId_tiposConceptos = New System.Windows.Forms.Button()
        Me.cbomedidaProducto = New System.Windows.Forms.ComboBox()
        Me.butVerId_medidaProducto = New System.Windows.Forms.Button()
        Me.butAddId_medidaProducto = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblId_tiposConceptos = New System.Windows.Forms.Label()
        Me.lblId_medidaProducto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(136, 18)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'cbotiposConceptos
        '
        Me.cbotiposConceptos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbotiposConceptos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotiposConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbotiposConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbotiposConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotiposConceptos.Location = New System.Drawing.Point(136, 45)
        Me.cbotiposConceptos.Name = "cbotiposConceptos"
        Me.cbotiposConceptos.Size = New System.Drawing.Size(200, 23)
        Me.cbotiposConceptos.TabIndex = 1
        '
        'butVerId_tiposConceptos
        '
        Me.butVerId_tiposConceptos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_tiposConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_tiposConceptos.FlatAppearance.BorderSize = 0
        Me.butVerId_tiposConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_tiposConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_tiposConceptos.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_tiposConceptos.Location = New System.Drawing.Point(342, 45)
        Me.butVerId_tiposConceptos.Name = "butVerId_tiposConceptos"
        Me.butVerId_tiposConceptos.Size = New System.Drawing.Size(20, 23)
        Me.butVerId_tiposConceptos.TabIndex = 2
        Me.butVerId_tiposConceptos.TabStop = False
        '
        'butAddId_tiposConceptos
        '
        Me.butAddId_tiposConceptos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_tiposConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_tiposConceptos.FlatAppearance.BorderSize = 0
        Me.butAddId_tiposConceptos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_tiposConceptos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_tiposConceptos.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_tiposConceptos.Location = New System.Drawing.Point(368, 45)
        Me.butAddId_tiposConceptos.Name = "butAddId_tiposConceptos"
        Me.butAddId_tiposConceptos.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_tiposConceptos.TabIndex = 3
        Me.butAddId_tiposConceptos.TabStop = False
        '
        'cbomedidaProducto
        '
        Me.cbomedidaProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbomedidaProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbomedidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbomedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbomedidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbomedidaProducto.Location = New System.Drawing.Point(136, 74)
        Me.cbomedidaProducto.Name = "cbomedidaProducto"
        Me.cbomedidaProducto.Size = New System.Drawing.Size(200, 23)
        Me.cbomedidaProducto.TabIndex = 2
        '
        'butVerId_medidaProducto
        '
        Me.butVerId_medidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_medidaProducto.FlatAppearance.BorderSize = 0
        Me.butVerId_medidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_medidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_medidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_medidaProducto.Location = New System.Drawing.Point(342, 74)
        Me.butVerId_medidaProducto.Name = "butVerId_medidaProducto"
        Me.butVerId_medidaProducto.Size = New System.Drawing.Size(20, 23)
        Me.butVerId_medidaProducto.TabIndex = 5
        Me.butVerId_medidaProducto.TabStop = False
        '
        'butAddId_medidaProducto
        '
        Me.butAddId_medidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_medidaProducto.FlatAppearance.BorderSize = 0
        Me.butAddId_medidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_medidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_medidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_medidaProducto.Location = New System.Drawing.Point(368, 74)
        Me.butAddId_medidaProducto.Name = "butAddId_medidaProducto"
        Me.butAddId_medidaProducto.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_medidaProducto.TabIndex = 6
        Me.butAddId_medidaProducto.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 15)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(107, 27)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_tiposConceptos
        '
        Me.lblId_tiposConceptos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_tiposConceptos.Location = New System.Drawing.Point(23, 42)
        Me.lblId_tiposConceptos.Name = "lblId_tiposConceptos"
        Me.lblId_tiposConceptos.Size = New System.Drawing.Size(107, 29)
        Me.lblId_tiposConceptos.TabIndex = 1
        Me.lblId_tiposConceptos.Text = "Tiposconceptos"
        Me.lblId_tiposConceptos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_medidaProducto
        '
        Me.lblId_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_medidaProducto.Location = New System.Drawing.Point(23, 71)
        Me.lblId_medidaProducto.Name = "lblId_medidaProducto"
        Me.lblId_medidaProducto.Size = New System.Drawing.Size(107, 29)
        Me.lblId_medidaProducto.TabIndex = 4
        Me.lblId_medidaProducto.Text = "Medaproducto"
        Me.lblId_medidaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblId_tiposConceptos, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cbotiposConceptos, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_tiposConceptos, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_tiposConceptos, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblId_medidaProducto, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cbomedidaProducto, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerId_medidaProducto, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddId_medidaProducto, 4, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(437, 120)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntConceptosGastosIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(421, 163)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(437, 165)
        Me.Name = "frmEntConceptosGastosIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ConceptosGastosIncidencias"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents cbotiposConceptos As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_tiposConceptos As System.Windows.Forms.Button
    Private WithEvents butAddId_tiposConceptos As System.Windows.Forms.Button
    Private WithEvents cbomedidaProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_medidaProducto As System.Windows.Forms.Button
    Private WithEvents butAddId_medidaProducto As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblId_tiposConceptos As System.Windows.Forms.Label
    Private WithEvents lblId_medidaProducto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
