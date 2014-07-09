<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsTipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsTipos))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCodigoQS = New System.Windows.Forms.TextBox()
        Me.txtLargo = New System.Windows.Forms.TextBox()
        Me.txtAncho = New System.Windows.Forms.TextBox()
        Me.txtAlto = New System.Windows.Forms.TextBox()
        Me.txtPeso = New System.Windows.Forms.TextBox()
        Me.txtMaterial = New System.Windows.Forms.TextBox()
        Me.chbTratado = New System.Windows.Forms.CheckBox()
        Me.txtAlias = New System.Windows.Forms.TextBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblLargo = New System.Windows.Forms.Label()
        Me.lblAncho = New System.Windows.Forms.Label()
        Me.lblAlto = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblMaterial = New System.Windows.Forms.Label()
        Me.lblTratado = New System.Windows.Forms.Label()
        Me.lblAlias = New System.Windows.Forms.Label()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(98, 18)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(98, 45)
        Me.txtCodigoQS.MaxLength = 9
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Size = New System.Drawing.Size(200, 21)
        Me.txtCodigoQS.TabIndex = 1
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtLargo
        '
        Me.txtLargo.BackColor = System.Drawing.SystemColors.Window
        Me.txtLargo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtLargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLargo.Location = New System.Drawing.Point(98, 72)
        Me.txtLargo.MaxLength = 9
        Me.txtLargo.Name = "txtLargo"
        Me.txtLargo.Size = New System.Drawing.Size(200, 21)
        Me.txtLargo.TabIndex = 2
        Me.txtLargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAncho
        '
        Me.txtAncho.BackColor = System.Drawing.SystemColors.Window
        Me.txtAncho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAncho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAncho.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAncho.Location = New System.Drawing.Point(98, 99)
        Me.txtAncho.MaxLength = 9
        Me.txtAncho.Name = "txtAncho"
        Me.txtAncho.Size = New System.Drawing.Size(200, 21)
        Me.txtAncho.TabIndex = 3
        Me.txtAncho.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtAlto
        '
        Me.txtAlto.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlto.Location = New System.Drawing.Point(98, 126)
        Me.txtAlto.MaxLength = 9
        Me.txtAlto.Name = "txtAlto"
        Me.txtAlto.Size = New System.Drawing.Size(200, 21)
        Me.txtAlto.TabIndex = 4
        Me.txtAlto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(98, 153)
        Me.txtPeso.MaxLength = 9
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Size = New System.Drawing.Size(200, 21)
        Me.txtPeso.TabIndex = 5
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaterial
        '
        Me.txtMaterial.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaterial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaterial.Location = New System.Drawing.Point(98, 180)
        Me.txtMaterial.MaxLength = 100
        Me.txtMaterial.Name = "txtMaterial"
        Me.txtMaterial.Size = New System.Drawing.Size(200, 21)
        Me.txtMaterial.TabIndex = 6
        '
        'chbTratado
        '
        Me.chbTratado.BackColor = System.Drawing.SystemColors.Control
        Me.chbTratado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbTratado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTratado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTratado.Location = New System.Drawing.Point(98, 207)
        Me.chbTratado.Name = "chbTratado"
        Me.chbTratado.Size = New System.Drawing.Size(200, 21)
        Me.chbTratado.TabIndex = 7
        Me.chbTratado.UseVisualStyleBackColor = False
        '
        'txtAlias
        '
        Me.txtAlias.BackColor = System.Drawing.SystemColors.Window
        Me.txtAlias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAlias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAlias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlias.Location = New System.Drawing.Point(98, 234)
        Me.txtAlias.MaxLength = 100
        Me.txtAlias.Name = "txtAlias"
        Me.txtAlias.Size = New System.Drawing.Size(200, 21)
        Me.txtAlias.TabIndex = 8
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 15)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(69, 27)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodigoQS.Location = New System.Drawing.Point(23, 42)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(69, 27)
        Me.lblCodigoQS.TabIndex = 1
        Me.lblCodigoQS.Text = "CodigoQS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLargo
        '
        Me.lblLargo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblLargo.Location = New System.Drawing.Point(23, 69)
        Me.lblLargo.Name = "lblLargo"
        Me.lblLargo.Size = New System.Drawing.Size(69, 27)
        Me.lblLargo.TabIndex = 2
        Me.lblLargo.Text = "Largo"
        Me.lblLargo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAncho
        '
        Me.lblAncho.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAncho.Location = New System.Drawing.Point(23, 96)
        Me.lblAncho.Name = "lblAncho"
        Me.lblAncho.Size = New System.Drawing.Size(69, 27)
        Me.lblAncho.TabIndex = 3
        Me.lblAncho.Text = "Ancho"
        Me.lblAncho.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlto
        '
        Me.lblAlto.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlto.Location = New System.Drawing.Point(23, 123)
        Me.lblAlto.Name = "lblAlto"
        Me.lblAlto.Size = New System.Drawing.Size(69, 27)
        Me.lblAlto.TabIndex = 4
        Me.lblAlto.Text = "Alto"
        Me.lblAlto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPeso
        '
        Me.lblPeso.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPeso.Location = New System.Drawing.Point(23, 150)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(69, 27)
        Me.lblPeso.TabIndex = 5
        Me.lblPeso.Text = "Peso"
        Me.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaterial
        '
        Me.lblMaterial.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMaterial.Location = New System.Drawing.Point(23, 177)
        Me.lblMaterial.Name = "lblMaterial"
        Me.lblMaterial.Size = New System.Drawing.Size(69, 27)
        Me.lblMaterial.TabIndex = 6
        Me.lblMaterial.Text = "Material"
        Me.lblMaterial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTratado
        '
        Me.lblTratado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTratado.Location = New System.Drawing.Point(23, 204)
        Me.lblTratado.Name = "lblTratado"
        Me.lblTratado.Size = New System.Drawing.Size(69, 27)
        Me.lblTratado.TabIndex = 7
        Me.lblTratado.Text = "Tratado"
        Me.lblTratado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlias
        '
        Me.lblAlias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlias.Location = New System.Drawing.Point(23, 231)
        Me.lblAlias.Name = "lblAlias"
        Me.lblAlias.Size = New System.Drawing.Size(69, 27)
        Me.lblAlias.TabIndex = 8
        Me.lblAlias.Text = "Alias"
        Me.lblAlias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblCodigoQS, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtCodigoQS, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblLargo, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtLargo, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblAncho, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtAncho, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblAlto, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtAlto, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblPeso, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtPeso, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblMaterial, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtMaterial, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblTratado, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.chbTratado, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblAlias, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtAlias, 2, 8)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 10
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(399, 269)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntPaletsTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(399, 323)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(399, 323)
        Me.Name = "frmEntPaletsTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PaletsTipos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtCodigoQS As System.Windows.Forms.TextBox
    Private WithEvents txtLargo As System.Windows.Forms.TextBox
    Private WithEvents txtAncho As System.Windows.Forms.TextBox
    Private WithEvents txtAlto As System.Windows.Forms.TextBox
    Private WithEvents txtPeso As System.Windows.Forms.TextBox
    Private WithEvents txtMaterial As System.Windows.Forms.TextBox
    Private WithEvents chbTratado As System.Windows.Forms.CheckBox
    Private WithEvents txtAlias As System.Windows.Forms.TextBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblCodigoQS As System.Windows.Forms.Label
    Private WithEvents lblLargo As System.Windows.Forms.Label
    Private WithEvents lblAncho As System.Windows.Forms.Label
    Private WithEvents lblAlto As System.Windows.Forms.Label
    Private WithEvents lblPeso As System.Windows.Forms.Label
    Private WithEvents lblMaterial As System.Windows.Forms.Label
    Private WithEvents lblTratado As System.Windows.Forms.Label
    Private WithEvents lblAlias As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
