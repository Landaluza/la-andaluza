<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntempresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntempresas))
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtruta_logo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtfax = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txttlf = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtemail = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtweb = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtdireccion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblruta_logo = New System.Windows.Forms.Label()
        Me.lblfax = New System.Windows.Forms.Label()
        Me.lbltlf = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblweb = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.Button1 = New System.Windows.Forms.Button()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnombre.EsUnicoCampo = ""
        Me.txtnombre.EsUnicoCampoID = ""
        Me.txtnombre.EsUnicoID = 0
        Me.txtnombre.EsUnicoTabla = ""
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(70, 14)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre.MaxLength = 500
        Me.txtnombre.Minimo = 0
        Me.txtnombre.Modificado = False
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Numerico_EsNumerico = False
        Me.txtnombre.Numerico_NumeroDoublees = 0
        Me.txtnombre.Numerico_SeparadorMiles = False
        Me.txtnombre.Obligatorio = False
        Me.txtnombre.ParametroID = 0
        Me.txtnombre.Size = New System.Drawing.Size(181, 21)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.ValorMaximo = 0.0R
        Me.txtnombre.ValorMinimo = 0.0R
        '
        'txtruta_logo
        '
        Me.txtruta_logo.BackColor = System.Drawing.SystemColors.Window
        Me.txtruta_logo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtruta_logo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtruta_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtruta_logo.Enabled = False
        Me.txtruta_logo.EsUnicoCampo = ""
        Me.txtruta_logo.EsUnicoCampoID = ""
        Me.txtruta_logo.EsUnicoID = 0
        Me.txtruta_logo.EsUnicoTabla = ""
        Me.txtruta_logo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta_logo.Location = New System.Drawing.Point(70, 42)
        Me.txtruta_logo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtruta_logo.MaxLength = 250
        Me.txtruta_logo.Minimo = 0
        Me.txtruta_logo.Modificado = False
        Me.txtruta_logo.Name = "txtruta_logo"
        Me.txtruta_logo.Numerico_EsNumerico = False
        Me.txtruta_logo.Numerico_NumeroDoublees = 0
        Me.txtruta_logo.Numerico_SeparadorMiles = False
        Me.txtruta_logo.Obligatorio = False
        Me.txtruta_logo.ParametroID = 0
        Me.txtruta_logo.Size = New System.Drawing.Size(181, 21)
        Me.txtruta_logo.TabIndex = 1
        Me.txtruta_logo.ValorMaximo = 0.0R
        Me.txtruta_logo.ValorMinimo = 0.0R
        '
        'txtfax
        '
        Me.txtfax.BackColor = System.Drawing.SystemColors.Window
        Me.txtfax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfax.EsUnicoCampo = ""
        Me.txtfax.EsUnicoCampoID = ""
        Me.txtfax.EsUnicoID = 0
        Me.txtfax.EsUnicoTabla = ""
        Me.txtfax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfax.Location = New System.Drawing.Point(70, 70)
        Me.txtfax.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtfax.MaxLength = 9
        Me.txtfax.Minimo = 0
        Me.txtfax.Modificado = False
        Me.txtfax.Name = "txtfax"
        Me.txtfax.Numerico_EsNumerico = False
        Me.txtfax.Numerico_NumeroDoublees = 0
        Me.txtfax.Numerico_SeparadorMiles = False
        Me.txtfax.Obligatorio = False
        Me.txtfax.ParametroID = 0
        Me.txtfax.Size = New System.Drawing.Size(181, 21)
        Me.txtfax.TabIndex = 2
        Me.txtfax.ValorMaximo = 0.0R
        Me.txtfax.ValorMinimo = 0.0R
        '
        'txttlf
        '
        Me.txttlf.BackColor = System.Drawing.SystemColors.Window
        Me.txttlf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttlf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txttlf.EsUnicoCampo = ""
        Me.txttlf.EsUnicoCampoID = ""
        Me.txttlf.EsUnicoID = 0
        Me.txttlf.EsUnicoTabla = ""
        Me.txttlf.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttlf.Location = New System.Drawing.Point(70, 98)
        Me.txttlf.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txttlf.MaxLength = 9
        Me.txttlf.Minimo = 0
        Me.txttlf.Modificado = False
        Me.txttlf.Name = "txttlf"
        Me.txttlf.Numerico_EsNumerico = False
        Me.txttlf.Numerico_NumeroDoublees = 0
        Me.txttlf.Numerico_SeparadorMiles = False
        Me.txttlf.Obligatorio = False
        Me.txttlf.ParametroID = 0
        Me.txttlf.Size = New System.Drawing.Size(181, 21)
        Me.txttlf.TabIndex = 3
        Me.txttlf.ValorMaximo = 0.0R
        Me.txttlf.ValorMinimo = 0.0R
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.SystemColors.Window
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtemail.EsUnicoCampo = ""
        Me.txtemail.EsUnicoCampoID = ""
        Me.txtemail.EsUnicoID = 0
        Me.txtemail.EsUnicoTabla = ""
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(70, 126)
        Me.txtemail.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtemail.MaxLength = 500
        Me.txtemail.Minimo = 0
        Me.txtemail.Modificado = False
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Numerico_EsNumerico = False
        Me.txtemail.Numerico_NumeroDoublees = 0
        Me.txtemail.Numerico_SeparadorMiles = False
        Me.txtemail.Obligatorio = False
        Me.txtemail.ParametroID = 0
        Me.txtemail.Size = New System.Drawing.Size(181, 21)
        Me.txtemail.TabIndex = 4
        Me.txtemail.ValorMaximo = 0.0R
        Me.txtemail.ValorMinimo = 0.0R
        '
        'txtweb
        '
        Me.txtweb.BackColor = System.Drawing.SystemColors.Window
        Me.txtweb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtweb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtweb.EsUnicoCampo = ""
        Me.txtweb.EsUnicoCampoID = ""
        Me.txtweb.EsUnicoID = 0
        Me.txtweb.EsUnicoTabla = ""
        Me.txtweb.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtweb.Location = New System.Drawing.Point(70, 154)
        Me.txtweb.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtweb.MaxLength = 500
        Me.txtweb.Minimo = 0
        Me.txtweb.Modificado = False
        Me.txtweb.Name = "txtweb"
        Me.txtweb.Numerico_EsNumerico = False
        Me.txtweb.Numerico_NumeroDoublees = 0
        Me.txtweb.Numerico_SeparadorMiles = False
        Me.txtweb.Obligatorio = False
        Me.txtweb.ParametroID = 0
        Me.txtweb.Size = New System.Drawing.Size(181, 21)
        Me.txtweb.TabIndex = 5
        Me.txtweb.ValorMaximo = 0.0R
        Me.txtweb.ValorMinimo = 0.0R
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.SystemColors.Window
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtdireccion.EsUnicoCampo = ""
        Me.txtdireccion.EsUnicoCampoID = ""
        Me.txtdireccion.EsUnicoID = 0
        Me.txtdireccion.EsUnicoTabla = ""
        Me.txtdireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.Location = New System.Drawing.Point(70, 182)
        Me.txtdireccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtdireccion.MaxLength = 600
        Me.txtdireccion.Minimo = 0
        Me.txtdireccion.Modificado = False
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Numerico_EsNumerico = False
        Me.txtdireccion.Numerico_NumeroDoublees = 0
        Me.txtdireccion.Numerico_SeparadorMiles = False
        Me.txtdireccion.Obligatorio = False
        Me.txtdireccion.ParametroID = 0
        Me.txtdireccion.Size = New System.Drawing.Size(181, 21)
        Me.txtdireccion.TabIndex = 6
        Me.txtdireccion.ValorMaximo = 0.0R
        Me.txtdireccion.ValorMinimo = 0.0R
        '
        'lblnombre
        '
        Me.lblnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblnombre.Location = New System.Drawing.Point(2, 12)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(64, 28)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblruta_logo
        '
        Me.lblruta_logo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblruta_logo.Location = New System.Drawing.Point(2, 40)
        Me.lblruta_logo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblruta_logo.Name = "lblruta_logo"
        Me.lblruta_logo.Size = New System.Drawing.Size(64, 28)
        Me.lblruta_logo.TabIndex = 1
        Me.lblruta_logo.Text = "Ruta logo"
        Me.lblruta_logo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfax
        '
        Me.lblfax.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblfax.Location = New System.Drawing.Point(2, 68)
        Me.lblfax.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfax.Name = "lblfax"
        Me.lblfax.Size = New System.Drawing.Size(64, 28)
        Me.lblfax.TabIndex = 2
        Me.lblfax.Text = "Fax"
        Me.lblfax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbltlf
        '
        Me.lbltlf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbltlf.Location = New System.Drawing.Point(2, 96)
        Me.lbltlf.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltlf.Name = "lbltlf"
        Me.lbltlf.Size = New System.Drawing.Size(64, 28)
        Me.lbltlf.TabIndex = 3
        Me.lbltlf.Text = "Tlf"
        Me.lbltlf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblemail
        '
        Me.lblemail.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblemail.Location = New System.Drawing.Point(2, 124)
        Me.lblemail.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(64, 28)
        Me.lblemail.TabIndex = 4
        Me.lblemail.Text = "Email"
        Me.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblweb
        '
        Me.lblweb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblweb.Location = New System.Drawing.Point(2, 152)
        Me.lblweb.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblweb.Name = "lblweb"
        Me.lblweb.Size = New System.Drawing.Size(64, 28)
        Me.lblweb.TabIndex = 5
        Me.lblweb.Text = "Web"
        Me.lblweb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldireccion
        '
        Me.lbldireccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lbldireccion.Location = New System.Drawing.Point(2, 180)
        Me.lbldireccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(64, 28)
        Me.lbldireccion.TabIndex = 6
        Me.lbldireccion.Text = "Direccion"
        Me.lbldireccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblnombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtnombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblruta_logo, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtruta_logo, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblfax, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtfax, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lbltlf, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txttlf, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblemail, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtemail, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblweb, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtweb, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lbldireccion, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtdireccion, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.Button1, 3, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(34, 23)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(277, 228)
        Me.tlpMiddle.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.Button1.Location = New System.Drawing.Point(255, 42)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(19, 19)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = True
        '
        'tlpTop
        '




        '
        'frmEntempresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(346, 249)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(355, 258)
        Me.Name = "frmEntempresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "empresas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents Button1 As System.Windows.Forms.Button
    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtruta_logo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtfax As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txttlf As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtemail As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtweb As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtdireccion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblnombre As System.Windows.Forms.Label
    Private WithEvents lblruta_logo As System.Windows.Forms.Label
    Private WithEvents lblfax As System.Windows.Forms.Label
    Private WithEvents lbltlf As System.Windows.Forms.Label
    Private WithEvents lblemail As System.Windows.Forms.Label
    Private WithEvents lblweb As System.Windows.Forms.Label
    Private WithEvents lbldireccion As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
