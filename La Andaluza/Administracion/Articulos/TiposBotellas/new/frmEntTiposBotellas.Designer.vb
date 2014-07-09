<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposBotellas
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
        Me.txtCodigoQS = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.cboid_tipoEnvase = New System.Windows.Forms.ComboBox()
        Me.butVerid_tipoEnvase = New System.Windows.Forms.Button()
        Me.butAddid_tipoEnvase = New System.Windows.Forms.Button()
        Me.cboid_medidaProducto = New System.Windows.Forms.ComboBox()
        Me.butVerid_medidaProducto = New System.Windows.Forms.Button()
        Me.butAddid_medidaProducto = New System.Windows.Forms.Button()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblid_tipoEnvase = New System.Windows.Forms.Label()
        Me.lblid_medidaProducto = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(161, 18)
        Me.txtCodigoQS.MaxLength = 9
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Size = New System.Drawing.Size(240, 24)
        Me.txtCodigoQS.TabIndex = 0
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(161, 53)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 24)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCapacidad
        '
        Me.txtCapacidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCapacidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(161, 88)
        Me.txtCapacidad.MaxLength = 9
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(240, 24)
        Me.txtCapacidad.TabIndex = 2
        Me.txtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboid_tipoEnvase
        '
        Me.cboid_tipoEnvase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_tipoEnvase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_tipoEnvase.Location = New System.Drawing.Point(161, 122)
        Me.cboid_tipoEnvase.Name = "cboid_tipoEnvase"
        Me.cboid_tipoEnvase.Size = New System.Drawing.Size(240, 26)
        Me.cboid_tipoEnvase.TabIndex = 3
        '
        'butVerid_tipoEnvase
        '
        Me.butVerid_tipoEnvase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerid_tipoEnvase.FlatAppearance.BorderSize = 0
        Me.butVerid_tipoEnvase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_tipoEnvase.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerid_tipoEnvase.Location = New System.Drawing.Point(407, 122)
        Me.butVerid_tipoEnvase.Name = "butVerid_tipoEnvase"
        Me.butVerid_tipoEnvase.Size = New System.Drawing.Size(24, 31)
        Me.butVerid_tipoEnvase.TabIndex = 4
        Me.butVerid_tipoEnvase.TabStop = False
        '
        'butAddid_tipoEnvase
        '
        Me.butAddid_tipoEnvase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddid_tipoEnvase.FlatAppearance.BorderSize = 0
        Me.butAddid_tipoEnvase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_tipoEnvase.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_tipoEnvase.Location = New System.Drawing.Point(437, 122)
        Me.butAddid_tipoEnvase.Name = "butAddid_tipoEnvase"
        Me.butAddid_tipoEnvase.Size = New System.Drawing.Size(24, 31)
        Me.butAddid_tipoEnvase.TabIndex = 5
        Me.butAddid_tipoEnvase.TabStop = False
        '
        'cboid_medidaProducto
        '
        Me.cboid_medidaProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_medidaProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_medidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_medidaProducto.Location = New System.Drawing.Point(161, 159)
        Me.cboid_medidaProducto.Name = "cboid_medidaProducto"
        Me.cboid_medidaProducto.Size = New System.Drawing.Size(240, 26)
        Me.cboid_medidaProducto.TabIndex = 4
        '
        'butVerid_medidaProducto
        '
        Me.butVerid_medidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerid_medidaProducto.FlatAppearance.BorderSize = 0
        Me.butVerid_medidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_medidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_medidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerid_medidaProducto.Location = New System.Drawing.Point(407, 159)
        Me.butVerid_medidaProducto.Name = "butVerid_medidaProducto"
        Me.butVerid_medidaProducto.Size = New System.Drawing.Size(24, 31)
        Me.butVerid_medidaProducto.TabIndex = 7
        Me.butVerid_medidaProducto.TabStop = False
        '
        'butAddid_medidaProducto
        '
        Me.butAddid_medidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddid_medidaProducto.FlatAppearance.BorderSize = 0
        Me.butAddid_medidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_medidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_medidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_medidaProducto.Location = New System.Drawing.Point(437, 159)
        Me.butAddid_medidaProducto.Name = "butAddid_medidaProducto"
        Me.butAddid_medidaProducto.Size = New System.Drawing.Size(24, 31)
        Me.butAddid_medidaProducto.TabIndex = 8
        Me.butAddid_medidaProducto.TabStop = False
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodigoQS.Location = New System.Drawing.Point(27, 15)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(128, 35)
        Me.lblCodigoQS.TabIndex = 0
        Me.lblCodigoQS.Text = "CodigoQS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(27, 50)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(128, 35)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCapacidad
        '
        Me.lblCapacidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCapacidad.Location = New System.Drawing.Point(27, 85)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(128, 34)
        Me.lblCapacidad.TabIndex = 2
        Me.lblCapacidad.Text = "Capacidad"
        Me.lblCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tipoEnvase
        '
        Me.lblid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_tipoEnvase.Location = New System.Drawing.Point(27, 119)
        Me.lblid_tipoEnvase.Name = "lblid_tipoEnvase"
        Me.lblid_tipoEnvase.Size = New System.Drawing.Size(128, 37)
        Me.lblid_tipoEnvase.TabIndex = 3
        Me.lblid_tipoEnvase.Text = "Envase"
        Me.lblid_tipoEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_medidaProducto
        '
        Me.lblid_medidaProducto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_medidaProducto.Location = New System.Drawing.Point(27, 156)
        Me.lblid_medidaProducto.Name = "lblid_medidaProducto"
        Me.lblid_medidaProducto.Size = New System.Drawing.Size(128, 37)
        Me.lblid_medidaProducto.TabIndex = 6
        Me.lblid_medidaProducto.Text = "Medida"
        Me.lblid_medidaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 55.0!))
        Me.tlpMiddle.Controls.Add(Me.lblCodigoQS, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtCodigoQS, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblCapacidad, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtCapacidad, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblid_tipoEnvase, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboid_tipoEnvase, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerid_tipoEnvase, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddid_tipoEnvase, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblid_medidaProducto, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboid_medidaProducto, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerid_medidaProducto, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddid_medidaProducto, 4, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 29)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(524, 214)
        Me.tlpMiddle.TabIndex = 8
        '
        '
        'frmEntTiposBotellas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(522, 263)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(524, 253)
        Me.Name = "frmEntTiposBotellas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposBotellas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCodigoQS As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Private WithEvents cboid_tipoEnvase As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_tipoEnvase As System.Windows.Forms.Button
    Private WithEvents butAddid_tipoEnvase As System.Windows.Forms.Button
    Private WithEvents cboid_medidaProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_medidaProducto As System.Windows.Forms.Button
    Private WithEvents butAddid_medidaProducto As System.Windows.Forms.Button
    Private WithEvents lblCodigoQS As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblCapacidad As System.Windows.Forms.Label
    Private WithEvents lblid_tipoEnvase As System.Windows.Forms.Label
    Private WithEvents lblid_medidaProducto As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
