<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmModGranelesCompuestoPor
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.lUnidad = New System.Windows.Forms.Label()
        Me.cboFase = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnaddfase = New System.Windows.Forms.Button()
        Me.txtOrden = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnGuardar.Location = New System.Drawing.Point(647, 194)
        Me.btnGuardar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(142, 63)
        Me.btnGuardar.TabIndex = 10
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(74, 48)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Artículo"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(149, 97)
        Me.txtcantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(144, 22)
        Me.txtcantidad.TabIndex = 3
        '
        'cboArticulo
        '
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.Location = New System.Drawing.Point(149, 45)
        Me.cboArticulo.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(631, 24)
        Me.cboArticulo.TabIndex = 1
        '
        'lUnidad
        '
        Me.lUnidad.AutoSize = True
        Me.lUnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 4.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lUnidad.Location = New System.Drawing.Point(297, 102)
        Me.lUnidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lUnidad.Name = "lUnidad"
        Me.lUnidad.Size = New System.Drawing.Size(16, 12)
        Me.lUnidad.TabIndex = 4
        Me.lUnidad.Text = "Kg"
        '
        'cboFase
        '
        Me.cboFase.FormattingEnabled = True
        Me.cboFase.Location = New System.Drawing.Point(471, 94)
        Me.cboFase.Margin = New System.Windows.Forms.Padding(4)
        Me.cboFase.Name = "cboFase"
        Me.cboFase.Size = New System.Drawing.Size(84, 24)
        Me.cboFase.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(396, 97)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Fase"
        '
        'btnaddfase
        '
        Me.btnaddfase.FlatAppearance.BorderSize = 0
        Me.btnaddfase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddfase.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnaddfase.Location = New System.Drawing.Point(563, 94)
        Me.btnaddfase.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaddfase.Name = "btnaddfase"
        Me.btnaddfase.Size = New System.Drawing.Size(30, 24)
        Me.btnaddfase.TabIndex = 7
        Me.btnaddfase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnaddfase.UseVisualStyleBackColor = True
        '
        'txtOrden
        '
        Me.txtOrden.Location = New System.Drawing.Point(701, 97)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(4)
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Size = New System.Drawing.Size(79, 22)
        Me.txtOrden.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(654, 97)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Orden"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(74, 98)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cantidad"
        '
        'frmModGranelesCompuestoPor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(862, 282)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtOrden)
        Me.Controls.Add(Me.btnaddfase)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cboFase)
        Me.Controls.Add(Me.lUnidad)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.cboArticulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(880, 327)
        Me.MinimizeBox = False
        Me.Name = "frmModGranelesCompuestoPor"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmModGranelesCompuestoPor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents btnGuardar As System.Windows.Forms.Button
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents txtcantidad As System.Windows.Forms.TextBox
   Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
   Private WithEvents lUnidad As System.Windows.Forms.Label
   Private WithEvents cboFase As System.Windows.Forms.ComboBox
   Private WithEvents Label4 As System.Windows.Forms.Label
   Private WithEvents btnaddfase As System.Windows.Forms.Button
   Private WithEvents txtOrden As System.Windows.Forms.TextBox
   Private WithEvents Label5 As System.Windows.Forms.Label
   Private WithEvents Label2 As System.Windows.Forms.Label
End Class
