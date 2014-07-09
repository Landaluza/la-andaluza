<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosMinMax
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
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.txtMinimoJR = New System.Windows.Forms.TextBox()
        Me.txtMaximoJR = New System.Windows.Forms.TextBox()
        Me.txtMinimoLA = New System.Windows.Forms.TextBox()
        Me.txtMaximoLA = New System.Windows.Forms.TextBox()
        Me.txtMinimoProveedor = New System.Windows.Forms.TextBox()
        Me.txtMaximoProveedor = New System.Windows.Forms.TextBox()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblMinimoJR = New System.Windows.Forms.Label()
        Me.lblMinimoLA = New System.Windows.Forms.Label()
        Me.lblMinimoProveedor = New System.Windows.Forms.Label()
        Me.lblMaximoProveedor = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboArticulo
        '
        Me.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticulo.Location = New System.Drawing.Point(179, 64)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(549, 26)
        Me.cboArticulo.TabIndex = 0
        '
        'txtMinimoJR
        '
        Me.txtMinimoJR.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinimoJR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimoJR.Location = New System.Drawing.Point(179, 155)
        Me.txtMinimoJR.MaxLength = 9
        Me.txtMinimoJR.Name = "txtMinimoJR"
        Me.txtMinimoJR.Size = New System.Drawing.Size(240, 24)
        Me.txtMinimoJR.TabIndex = 1
        Me.txtMinimoJR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaximoJR
        '
        Me.txtMaximoJR.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaximoJR.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximoJR.Location = New System.Drawing.Point(488, 155)
        Me.txtMaximoJR.MaxLength = 9
        Me.txtMaximoJR.Name = "txtMaximoJR"
        Me.txtMaximoJR.Size = New System.Drawing.Size(240, 24)
        Me.txtMaximoJR.TabIndex = 2
        Me.txtMaximoJR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinimoLA
        '
        Me.txtMinimoLA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinimoLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimoLA.Location = New System.Drawing.Point(179, 185)
        Me.txtMinimoLA.MaxLength = 9
        Me.txtMinimoLA.Name = "txtMinimoLA"
        Me.txtMinimoLA.Size = New System.Drawing.Size(240, 24)
        Me.txtMinimoLA.TabIndex = 3
        Me.txtMinimoLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaximoLA
        '
        Me.txtMaximoLA.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaximoLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximoLA.Location = New System.Drawing.Point(488, 185)
        Me.txtMaximoLA.MaxLength = 9
        Me.txtMaximoLA.Name = "txtMaximoLA"
        Me.txtMaximoLA.Size = New System.Drawing.Size(240, 24)
        Me.txtMaximoLA.TabIndex = 4
        Me.txtMaximoLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMinimoProveedor
        '
        Me.txtMinimoProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtMinimoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMinimoProveedor.Location = New System.Drawing.Point(179, 215)
        Me.txtMinimoProveedor.MaxLength = 9
        Me.txtMinimoProveedor.Name = "txtMinimoProveedor"
        Me.txtMinimoProveedor.Size = New System.Drawing.Size(240, 24)
        Me.txtMinimoProveedor.TabIndex = 5
        Me.txtMinimoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtMaximoProveedor
        '
        Me.txtMaximoProveedor.BackColor = System.Drawing.SystemColors.Window
        Me.txtMaximoProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMaximoProveedor.Location = New System.Drawing.Point(488, 215)
        Me.txtMaximoProveedor.MaxLength = 9
        Me.txtMaximoProveedor.Name = "txtMaximoProveedor"
        Me.txtMaximoProveedor.Size = New System.Drawing.Size(240, 24)
        Me.txtMaximoProveedor.TabIndex = 6
        Me.txtMaximoProveedor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(179, 254)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(114, 24)
        Me.dtpFechaInicio.TabIndex = 7
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(179, 289)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(114, 24)
        Me.dtpFechaFinal.TabIndex = 8
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(179, 323)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(240, 24)
        Me.chbVigente.TabIndex = 9
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(179, 354)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(549, 72)
        Me.txtObservaciones.TabIndex = 10
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Location = New System.Drawing.Point(41, 59)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(118, 37)
        Me.lblArticuloID.TabIndex = 0
        Me.lblArticuloID.Text = "Articulo"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinimoJR
        '
        Me.lblMinimoJR.Location = New System.Drawing.Point(41, 152)
        Me.lblMinimoJR.Name = "lblMinimoJR"
        Me.lblMinimoJR.Size = New System.Drawing.Size(118, 35)
        Me.lblMinimoJR.TabIndex = 3
        Me.lblMinimoJR.Text = "JR"
        Me.lblMinimoJR.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinimoLA
        '
        Me.lblMinimoLA.Location = New System.Drawing.Point(41, 182)
        Me.lblMinimoLA.Name = "lblMinimoLA"
        Me.lblMinimoLA.Size = New System.Drawing.Size(118, 35)
        Me.lblMinimoLA.TabIndex = 5
        Me.lblMinimoLA.Text = "LA"
        Me.lblMinimoLA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMinimoProveedor
        '
        Me.lblMinimoProveedor.Location = New System.Drawing.Point(41, 212)
        Me.lblMinimoProveedor.Name = "lblMinimoProveedor"
        Me.lblMinimoProveedor.Size = New System.Drawing.Size(118, 34)
        Me.lblMinimoProveedor.TabIndex = 7
        Me.lblMinimoProveedor.Text = "Proveedor"
        Me.lblMinimoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMaximoProveedor
        '
        Me.lblMaximoProveedor.Location = New System.Drawing.Point(270, 110)
        Me.lblMaximoProveedor.Name = "lblMaximoProveedor"
        Me.lblMaximoProveedor.Size = New System.Drawing.Size(118, 35)
        Me.lblMaximoProveedor.TabIndex = 8
        Me.lblMaximoProveedor.Text = "Minimo"
        Me.lblMaximoProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(41, 251)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(118, 35)
        Me.lblFechaInicio.TabIndex = 9
        Me.lblFechaInicio.Text = "FechaInicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Location = New System.Drawing.Point(41, 286)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(118, 34)
        Me.lblFechaFinal.TabIndex = 10
        Me.lblFechaFinal.Text = "FechaFinal"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Location = New System.Drawing.Point(41, 320)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(118, 31)
        Me.lblVigente.TabIndex = 11
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(41, 351)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(118, 35)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(578, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 35)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Maximo"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntArticulosMinMax
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(791, 481)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblArticuloID)
        Me.Controls.Add(Me.cboArticulo)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblMinimoJR)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtMinimoJR)
        Me.Controls.Add(Me.chbVigente)
        Me.Controls.Add(Me.lblVigente)
        Me.Controls.Add(Me.txtMaximoJR)
        Me.Controls.Add(Me.dtpFechaFinal)
        Me.Controls.Add(Me.lblMinimoLA)
        Me.Controls.Add(Me.lblFechaFinal)
        Me.Controls.Add(Me.txtMinimoLA)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.txtMaximoLA)
        Me.Controls.Add(Me.txtMaximoProveedor)
        Me.Controls.Add(Me.lblMinimoProveedor)
        Me.Controls.Add(Me.lblMaximoProveedor)
        Me.Controls.Add(Me.txtMinimoProveedor)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(550, 437)
        Me.Name = "frmEntArticulosMinMax"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ArticulosMinMax"
        Me.Controls.SetChildIndex(Me.txtMinimoProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblMaximoProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblMinimoProveedor, 0)
        Me.Controls.SetChildIndex(Me.txtMaximoProveedor, 0)
        Me.Controls.SetChildIndex(Me.txtMaximoLA, 0)
        Me.Controls.SetChildIndex(Me.lblFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.txtMinimoLA, 0)
        Me.Controls.SetChildIndex(Me.lblFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.lblMinimoLA, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaFinal, 0)
        Me.Controls.SetChildIndex(Me.txtMaximoJR, 0)
        Me.Controls.SetChildIndex(Me.lblVigente, 0)
        Me.Controls.SetChildIndex(Me.chbVigente, 0)
        Me.Controls.SetChildIndex(Me.txtMinimoJR, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblMinimoJR, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboArticulo, 0)
        Me.Controls.SetChildIndex(Me.lblArticuloID, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Private WithEvents txtMinimoJR As System.Windows.Forms.TextBox
    Private WithEvents txtMaximoJR As System.Windows.Forms.TextBox
    Private WithEvents txtMinimoLA As System.Windows.Forms.TextBox
    Private WithEvents txtMaximoLA As System.Windows.Forms.TextBox
    Private WithEvents txtMinimoProveedor As System.Windows.Forms.TextBox
    Private WithEvents txtMaximoProveedor As System.Windows.Forms.TextBox
    Private WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents chbVigente As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblMinimoJR As System.Windows.Forms.Label
    Private WithEvents lblMinimoLA As System.Windows.Forms.Label
    Private WithEvents lblMinimoProveedor As System.Windows.Forms.Label
    Private WithEvents lblMaximoProveedor As System.Windows.Forms.Label
    Private WithEvents lblFechaInicio As System.Windows.Forms.Label
    Private WithEvents lblFechaFinal As System.Windows.Forms.Label
    Private WithEvents lblVigente As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
End Class
