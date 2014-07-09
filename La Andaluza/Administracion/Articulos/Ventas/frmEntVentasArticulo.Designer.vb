<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntVentasArticulo
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
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtCodigoQS = New System.Windows.Forms.TextBox()
        Me.txtCodigoLA = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lMes = New System.Windows.Forms.Label()
        Me.lAgno = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboArticulo
        '
        Me.cboArticulo.FormattingEnabled = True
        Me.cboArticulo.Location = New System.Drawing.Point(81, 230)
        Me.cboArticulo.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(780, 24)
        Me.cboArticulo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.ForeColor = System.Drawing.Color.DarkRed
        Me.Label1.Location = New System.Drawing.Point(144, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(684, 50)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Tenga precaución al manipular los datos del articulo, si el codigoQS y el codigoL" & _
    "A no son correctos podria crear registros de ventas ficticios o manipular unos y" & _
    "a existentes."
        '
        'Button1
        '
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.Button1.Location = New System.Drawing.Point(683, 363)
        Me.Button1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(176, 75)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guardar"
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(10, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Articulo"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Panel1.Location = New System.Drawing.Point(10, 13)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 136)
        Me.Panel1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Image = Global.La_Andaluza.My.Resources.Resources.emblem_important_2_256
        Me.Label3.Location = New System.Drawing.Point(19, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 108)
        Me.Label3.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(81, 259)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(100, 22)
        Me.txtCantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 263)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Cantidad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Enabled = False
        Me.Label5.Location = New System.Drawing.Point(271, 264)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CodigoQS:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Enabled = False
        Me.Label6.Location = New System.Drawing.Point(603, 264)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "CodigoLA:"
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.Enabled = False
        Me.txtCodigoQS.Location = New System.Drawing.Point(353, 263)
        Me.txtCodigoQS.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Size = New System.Drawing.Size(183, 22)
        Me.txtCodigoQS.TabIndex = 9
        '
        'txtCodigoLA
        '
        Me.txtCodigoLA.Enabled = False
        Me.txtCodigoLA.Location = New System.Drawing.Point(685, 263)
        Me.txtCodigoLA.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtCodigoLA.Name = "txtCodigoLA"
        Me.txtCodigoLA.Size = New System.Drawing.Size(175, 22)
        Me.txtCodigoLA.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 195)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(38, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Mes:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(155, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(37, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Año:"
        '
        'lMes
        '
        Me.lMes.AutoSize = True
        Me.lMes.Location = New System.Drawing.Point(54, 195)
        Me.lMes.Name = "lMes"
        Me.lMes.Size = New System.Drawing.Size(55, 17)
        Me.lMes.TabIndex = 13
        Me.lMes.Text = "Articulo"
        '
        'lAgno
        '
        Me.lAgno.AutoSize = True
        Me.lAgno.Location = New System.Drawing.Point(198, 195)
        Me.lAgno.Name = "lAgno"
        Me.lAgno.Size = New System.Drawing.Size(55, 17)
        Me.lAgno.TabIndex = 14
        Me.lAgno.Text = "Articulo"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel1)
        Me.Panel2.Controls.Add(Me.lAgno)
        Me.Panel2.Controls.Add(Me.cboArticulo)
        Me.Panel2.Controls.Add(Me.lMes)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.txtCantidad)
        Me.Panel2.Controls.Add(Me.txtCodigoLA)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.txtCodigoQS)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(36, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(869, 451)
        Me.Panel2.TabIndex = 15
        '
        'frmEntVentasArticulo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(933, 484)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntVentasArticulo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntVentasArticulo"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtCodigoQS As System.Windows.Forms.TextBox
    Private WithEvents txtCodigoLA As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents lMes As System.Windows.Forms.Label
    Private WithEvents lAgno As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
End Class
