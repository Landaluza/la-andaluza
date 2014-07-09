<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPanMonodosis
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
        Me.components = New System.ComponentModel.Container()
        Me.Pancontenidos = New System.Windows.Forms.Panel()
        Me.cboformato = New System.Windows.Forms.ComboBox()
        Me.btnaddMarcas = New System.Windows.Forms.Button()
        Me.btnverMarcas = New System.Windows.Forms.Button()
        Me.txtEan = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboSccNC = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboCaja = New System.Windows.Forms.ComboBox()
        Me.lCaja = New System.Windows.Forms.Label()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboMarca = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbEnvasado = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Pancontenidos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Pancontenidos
        '
        Me.Pancontenidos.Controls.Add(Me.txtCantidad)
        Me.Pancontenidos.Controls.Add(Me.Label6)
        Me.Pancontenidos.Controls.Add(Me.cboformato)
        Me.Pancontenidos.Controls.Add(Me.btnaddMarcas)
        Me.Pancontenidos.Controls.Add(Me.btnverMarcas)
        Me.Pancontenidos.Controls.Add(Me.txtEan)
        Me.Pancontenidos.Controls.Add(Me.Label4)
        Me.Pancontenidos.Controls.Add(Me.cboSccNC)
        Me.Pancontenidos.Controls.Add(Me.Label3)
        Me.Pancontenidos.Controls.Add(Me.cboCaja)
        Me.Pancontenidos.Controls.Add(Me.lCaja)
        Me.Pancontenidos.Controls.Add(Me.cboProducto)
        Me.Pancontenidos.Controls.Add(Me.Label5)
        Me.Pancontenidos.Controls.Add(Me.cboMarca)
        Me.Pancontenidos.Controls.Add(Me.Label2)
        Me.Pancontenidos.Controls.Add(Me.Panel1)
        Me.Pancontenidos.Location = New System.Drawing.Point(12, 26)
        Me.Pancontenidos.Name = "Pancontenidos"
        Me.Pancontenidos.Size = New System.Drawing.Size(436, 272)
        Me.Pancontenidos.TabIndex = 0
        '
        'cboformato
        '
        Me.cboformato.FormattingEnabled = True
        Me.cboformato.Location = New System.Drawing.Point(0, 23)
        Me.cboformato.Name = "cboformato"
        Me.cboformato.Size = New System.Drawing.Size(437, 21)
        Me.cboformato.TabIndex = 0
        '
        'btnaddMarcas
        '
        Me.btnaddMarcas.FlatAppearance.BorderSize = 0
        Me.btnaddMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddMarcas.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnaddMarcas.Location = New System.Drawing.Point(416, 52)
        Me.btnaddMarcas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnaddMarcas.Name = "btnaddMarcas"
        Me.btnaddMarcas.Size = New System.Drawing.Size(18, 19)
        Me.btnaddMarcas.TabIndex = 64
        Me.btnaddMarcas.UseVisualStyleBackColor = True
        '
        'btnverMarcas
        '
        Me.btnverMarcas.FlatAppearance.BorderSize = 0
        Me.btnverMarcas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnverMarcas.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnverMarcas.Location = New System.Drawing.Point(394, 52)
        Me.btnverMarcas.Margin = New System.Windows.Forms.Padding(2)
        Me.btnverMarcas.Name = "btnverMarcas"
        Me.btnverMarcas.Size = New System.Drawing.Size(20, 19)
        Me.btnverMarcas.TabIndex = 63
        Me.btnverMarcas.UseVisualStyleBackColor = True
        '
        'txtEan
        '
        Me.txtEan.Location = New System.Drawing.Point(0, 204)
        Me.txtEan.MaxLength = 13
        Me.txtEan.Name = "txtEan"
        Me.txtEan.Size = New System.Drawing.Size(437, 20)
        Me.txtEan.TabIndex = 10
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 183)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(436, 21)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "EAN13"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSccNC
        '
        Me.cboSccNC.FormattingEnabled = True
        Me.cboSccNC.Location = New System.Drawing.Point(0, 163)
        Me.cboSccNC.Margin = New System.Windows.Forms.Padding(2)
        Me.cboSccNC.Name = "cboSccNC"
        Me.cboSccNC.Size = New System.Drawing.Size(437, 21)
        Me.cboSccNC.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(436, 21)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SSCC no coforme"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCaja
        '
        Me.cboCaja.FormattingEnabled = True
        Me.cboCaja.Location = New System.Drawing.Point(0, 123)
        Me.cboCaja.Margin = New System.Windows.Forms.Padding(2)
        Me.cboCaja.Name = "cboCaja"
        Me.cboCaja.Size = New System.Drawing.Size(437, 21)
        Me.cboCaja.TabIndex = 6
        '
        'lCaja
        '
        Me.lCaja.AutoSize = True
        Me.lCaja.Location = New System.Drawing.Point(0, 109)
        Me.lCaja.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lCaja.Name = "lCaja"
        Me.lCaja.Size = New System.Drawing.Size(28, 13)
        Me.lCaja.TabIndex = 5
        Me.lCaja.Text = "Caja"
        '
        'cboProducto
        '
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(0, 89)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(437, 21)
        Me.cboProducto.TabIndex = 4
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(0, 76)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Producto"
        '
        'cboMarca
        '
        Me.cboMarca.FormattingEnabled = True
        Me.cboMarca.Location = New System.Drawing.Point(0, 56)
        Me.cboMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.cboMarca.Name = "cboMarca"
        Me.cboMarca.Size = New System.Drawing.Size(390, 21)
        Me.cboMarca.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(0, 42)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Marca"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbEnvasado)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(436, 28)
        Me.Panel1.TabIndex = 62
        '
        'cbEnvasado
        '
        Me.cbEnvasado.Checked = True
        Me.cbEnvasado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.cbEnvasado.Dock = System.Windows.Forms.DockStyle.Left
        Me.cbEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.emblem_notice
        Me.cbEnvasado.Location = New System.Drawing.Point(55, 0)
        Me.cbEnvasado.Margin = New System.Windows.Forms.Padding(2)
        Me.cbEnvasado.Name = "cbEnvasado"
        Me.cbEnvasado.Size = New System.Drawing.Size(43, 28)
        Me.cbEnvasado.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cbEnvasado, "Desmarcar para monodosis de nueva creación. Marcar para monodosis ya creadas ante" & _
        "riormente que ya dispongan de un formato")
        Me.cbEnvasado.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 28)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Envasado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(-1, 249)
        Me.txtCantidad.MaxLength = 13
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(437, 20)
        Me.txtCantidad.TabIndex = 66
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-1, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(436, 21)
        Me.Label6.TabIndex = 65
        Me.Label6.Text = "Cantidad por matricula"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmPanMonodosis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(460, 310)
        Me.Controls.Add(Me.Pancontenidos)
        Me.Name = "frmPanMonodosis"
        Me.Text = "frmPanMonodosis"
        Me.Pancontenidos.ResumeLayout(False)
        Me.Pancontenidos.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents cboMarca As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Pancontenidos As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboformato As System.Windows.Forms.ComboBox
    Private WithEvents cboSccNC As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents cbEnvasado As System.Windows.Forms.CheckBox
    Private WithEvents cboCaja As System.Windows.Forms.ComboBox
    Private WithEvents lCaja As System.Windows.Forms.Label
    Private WithEvents cboProducto As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtEan As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents btnaddMarcas As System.Windows.Forms.Button
    Private WithEvents btnverMarcas As System.Windows.Forms.Button
    Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Private WithEvents txtCantidad As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
End Class
