<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntUsuarios
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
        Me.txtUsuario = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.butVerTipoUsuarioID = New System.Windows.Forms.Button()
        Me.butAddTipoUsuarioID = New System.Windows.Forms.Button()
        Me.txtemail = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtpass = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtservidorDeCorreo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtcryptedPassword = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblUsuario = New System.Windows.Forms.Label()
        Me.lblTipoUsuarioID = New System.Windows.Forms.Label()
        Me.lblemail = New System.Windows.Forms.Label()
        Me.lblpass = New System.Windows.Forms.Label()
        Me.lblservidorDeCorreo = New System.Windows.Forms.Label()
        Me.lblcryptedPassword = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '                
        'txtUsuario
        '
        Me.txtUsuario.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsuario.EsUnicoCampo = ""
        Me.txtUsuario.EsUnicoCampoID = ""
        Me.txtUsuario.EsUnicoID = 0
        Me.txtUsuario.EsUnicoTabla = ""
        Me.txtUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsuario.Location = New System.Drawing.Point(157, 48)
        Me.txtUsuario.MaxLength = 20
        Me.txtUsuario.Minimo = 0
        Me.txtUsuario.Modificado = False
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Numerico_EsNumerico = False
        Me.txtUsuario.Numerico_NumeroDoublees = 0
        Me.txtUsuario.Numerico_SeparadorMiles = False
        Me.txtUsuario.Obligatorio = False
        Me.txtUsuario.ParametroID = 0
        Me.txtUsuario.Size = New System.Drawing.Size(240, 24)
        Me.txtUsuario.TabIndex = 0
        Me.txtUsuario.ValorMaximo = 0.0!
        Me.txtUsuario.ValorMinimo = 0.0!
        '
        'cboTipoUsuario
        '
        Me.cboTipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoUsuario.Location = New System.Drawing.Point(157, 83)
        Me.cboTipoUsuario.Name = "cboTipoUsuario"
        Me.cboTipoUsuario.Size = New System.Drawing.Size(240, 26)
        Me.cboTipoUsuario.TabIndex = 1
        '
        'butVerTipoUsuarioID
        '
        Me.butVerTipoUsuarioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoUsuarioID.FlatAppearance.BorderSize = 0
        Me.butVerTipoUsuarioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoUsuarioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoUsuarioID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTipoUsuarioID.Location = New System.Drawing.Point(403, 83)
        Me.butVerTipoUsuarioID.Name = "butVerTipoUsuarioID"
        Me.butVerTipoUsuarioID.Size = New System.Drawing.Size(24, 26)
        Me.butVerTipoUsuarioID.TabIndex = 2
        Me.butVerTipoUsuarioID.TabStop = False
        '
        'butAddTipoUsuarioID
        '
        Me.butAddTipoUsuarioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoUsuarioID.FlatAppearance.BorderSize = 0
        Me.butAddTipoUsuarioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoUsuarioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoUsuarioID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoUsuarioID.Location = New System.Drawing.Point(433, 83)
        Me.butAddTipoUsuarioID.Name = "butAddTipoUsuarioID"
        Me.butAddTipoUsuarioID.Size = New System.Drawing.Size(24, 26)
        Me.butAddTipoUsuarioID.TabIndex = 3
        Me.butAddTipoUsuarioID.TabStop = False
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.SystemColors.Window
        Me.txtemail.EsUnicoCampo = ""
        Me.txtemail.EsUnicoCampoID = ""
        Me.txtemail.EsUnicoID = 0
        Me.txtemail.EsUnicoTabla = ""
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(157, 120)
        Me.txtemail.MaxLength = 255
        Me.txtemail.Minimo = 0
        Me.txtemail.Modificado = False
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Numerico_EsNumerico = False
        Me.txtemail.Numerico_NumeroDoublees = 0
        Me.txtemail.Numerico_SeparadorMiles = False
        Me.txtemail.Obligatorio = False
        Me.txtemail.ParametroID = 0
        Me.txtemail.Size = New System.Drawing.Size(240, 24)
        Me.txtemail.TabIndex = 2
        Me.txtemail.ValorMaximo = 0.0!
        Me.txtemail.ValorMinimo = 0.0!
        '
        'txtpass
        '
        Me.txtpass.BackColor = System.Drawing.SystemColors.Window
        Me.txtpass.EsUnicoCampo = ""
        Me.txtpass.EsUnicoCampoID = ""
        Me.txtpass.EsUnicoID = 0
        Me.txtpass.EsUnicoTabla = ""
        Me.txtpass.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(157, 154)
        Me.txtpass.MaxLength = 255
        Me.txtpass.Minimo = 0
        Me.txtpass.Modificado = False
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Numerico_EsNumerico = False
        Me.txtpass.Numerico_NumeroDoublees = 0
        Me.txtpass.Numerico_SeparadorMiles = False
        Me.txtpass.Obligatorio = False
        Me.txtpass.ParametroID = 0
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(240, 24)
        Me.txtpass.TabIndex = 3
        Me.txtpass.ValorMaximo = 0.0!
        Me.txtpass.ValorMinimo = 0.0!
        '
        'txtservidorDeCorreo
        '
        Me.txtservidorDeCorreo.BackColor = System.Drawing.SystemColors.Window
        Me.txtservidorDeCorreo.EsUnicoCampo = ""
        Me.txtservidorDeCorreo.EsUnicoCampoID = ""
        Me.txtservidorDeCorreo.EsUnicoID = 0
        Me.txtservidorDeCorreo.EsUnicoTabla = ""
        Me.txtservidorDeCorreo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservidorDeCorreo.Location = New System.Drawing.Point(157, 189)
        Me.txtservidorDeCorreo.MaxLength = 255
        Me.txtservidorDeCorreo.Minimo = 0
        Me.txtservidorDeCorreo.Modificado = False
        Me.txtservidorDeCorreo.Name = "txtservidorDeCorreo"
        Me.txtservidorDeCorreo.Numerico_EsNumerico = False
        Me.txtservidorDeCorreo.Numerico_NumeroDoublees = 0
        Me.txtservidorDeCorreo.Numerico_SeparadorMiles = False
        Me.txtservidorDeCorreo.Obligatorio = False
        Me.txtservidorDeCorreo.ParametroID = 0
        Me.txtservidorDeCorreo.Size = New System.Drawing.Size(240, 24)
        Me.txtservidorDeCorreo.TabIndex = 4
        Me.txtservidorDeCorreo.ValorMaximo = 0.0!
        Me.txtservidorDeCorreo.ValorMinimo = 0.0!
        '
        'txtcryptedPassword
        '
        Me.txtcryptedPassword.BackColor = System.Drawing.SystemColors.Window
        Me.txtcryptedPassword.EsUnicoCampo = ""
        Me.txtcryptedPassword.EsUnicoCampoID = ""
        Me.txtcryptedPassword.EsUnicoID = 0
        Me.txtcryptedPassword.EsUnicoTabla = ""
        Me.txtcryptedPassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcryptedPassword.Location = New System.Drawing.Point(157, 224)
        Me.txtcryptedPassword.MaxLength = 1000
        Me.txtcryptedPassword.Minimo = 0
        Me.txtcryptedPassword.Modificado = False
        Me.txtcryptedPassword.Name = "txtcryptedPassword"
        Me.txtcryptedPassword.Numerico_EsNumerico = False
        Me.txtcryptedPassword.Numerico_NumeroDoublees = 0
        Me.txtcryptedPassword.Numerico_SeparadorMiles = False
        Me.txtcryptedPassword.Obligatorio = False
        Me.txtcryptedPassword.ParametroID = 0
        Me.txtcryptedPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcryptedPassword.Size = New System.Drawing.Size(240, 24)
        Me.txtcryptedPassword.TabIndex = 5
        Me.txtcryptedPassword.ValorMaximo = 0.0!
        Me.txtcryptedPassword.ValorMinimo = 0.0!
        '
        'lblUsuario
        '
        Me.lblUsuario.Location = New System.Drawing.Point(33, 45)
        Me.lblUsuario.Name = "lblUsuario"
        Me.lblUsuario.Size = New System.Drawing.Size(118, 35)
        Me.lblUsuario.TabIndex = 0
        Me.lblUsuario.Text = "Usuario"
        Me.lblUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoUsuarioID
        '
        Me.lblTipoUsuarioID.Location = New System.Drawing.Point(33, 80)
        Me.lblTipoUsuarioID.Name = "lblTipoUsuarioID"
        Me.lblTipoUsuarioID.Size = New System.Drawing.Size(118, 37)
        Me.lblTipoUsuarioID.TabIndex = 1
        Me.lblTipoUsuarioID.Text = "Tipo usuario"
        Me.lblTipoUsuarioID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblemail
        '
        Me.lblemail.Location = New System.Drawing.Point(33, 117)
        Me.lblemail.Name = "lblemail"
        Me.lblemail.Size = New System.Drawing.Size(118, 34)
        Me.lblemail.TabIndex = 4
        Me.lblemail.Text = "Direccion correo"
        Me.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpass
        '
        Me.lblpass.Location = New System.Drawing.Point(33, 151)
        Me.lblpass.Name = "lblpass"
        Me.lblpass.Size = New System.Drawing.Size(118, 35)
        Me.lblpass.TabIndex = 5
        Me.lblpass.Text = "Contraseña correo"
        Me.lblpass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblservidorDeCorreo
        '
        Me.lblservidorDeCorreo.Location = New System.Drawing.Point(33, 186)
        Me.lblservidorDeCorreo.Name = "lblservidorDeCorreo"
        Me.lblservidorDeCorreo.Size = New System.Drawing.Size(118, 35)
        Me.lblservidorDeCorreo.TabIndex = 6
        Me.lblservidorDeCorreo.Text = "Servidor de correo"
        Me.lblservidorDeCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcryptedPassword
        '
        Me.lblcryptedPassword.Location = New System.Drawing.Point(33, 221)
        Me.lblcryptedPassword.Name = "lblcryptedPassword"
        Me.lblcryptedPassword.Size = New System.Drawing.Size(118, 34)
        Me.lblcryptedPassword.TabIndex = 7
        Me.lblcryptedPassword.Text = "Contraseña"
        Me.lblcryptedPassword.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(509, 291)
        Me.Controls.Add(Me.lblUsuario)
        Me.Controls.Add(Me.txtUsuario)
        Me.Controls.Add(Me.lblTipoUsuarioID)
        Me.Controls.Add(Me.cboTipoUsuario)
        Me.Controls.Add(Me.txtservidorDeCorreo)
        Me.Controls.Add(Me.butVerTipoUsuarioID)
        Me.Controls.Add(Me.txtcryptedPassword)
        Me.Controls.Add(Me.butAddTipoUsuarioID)
        Me.Controls.Add(Me.lblcryptedPassword)
        Me.Controls.Add(Me.lblemail)
        Me.Controls.Add(Me.lblservidorDeCorreo)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.lblpass)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(515, 282)
        Me.Name = "frmEntUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Usuarios"
        Me.Controls.SetChildIndex(Me.lblpass, 0)
        Me.Controls.SetChildIndex(Me.txtpass, 0)
        Me.Controls.SetChildIndex(Me.txtemail, 0)
        Me.Controls.SetChildIndex(Me.lblservidorDeCorreo, 0)
        Me.Controls.SetChildIndex(Me.lblemail, 0)
        Me.Controls.SetChildIndex(Me.lblcryptedPassword, 0)
        Me.Controls.SetChildIndex(Me.butAddTipoUsuarioID, 0)
        Me.Controls.SetChildIndex(Me.txtcryptedPassword, 0)
        Me.Controls.SetChildIndex(Me.butVerTipoUsuarioID, 0)
        Me.Controls.SetChildIndex(Me.txtservidorDeCorreo, 0)
        Me.Controls.SetChildIndex(Me.cboTipoUsuario, 0)
        Me.Controls.SetChildIndex(Me.lblTipoUsuarioID, 0)
        Me.Controls.SetChildIndex(Me.txtUsuario, 0)
        Me.Controls.SetChildIndex(Me.lblUsuario, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtUsuario As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboTipoUsuario As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoUsuarioID As System.Windows.Forms.Button
    Private WithEvents butAddTipoUsuarioID As System.Windows.Forms.Button
    Private WithEvents txtemail As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtpass As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtservidorDeCorreo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtcryptedPassword As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblUsuario As System.Windows.Forms.Label
    Private WithEvents lblTipoUsuarioID As System.Windows.Forms.Label
    Private WithEvents lblemail As System.Windows.Forms.Label
    Private WithEvents lblpass As System.Windows.Forms.Label
    Private WithEvents lblservidorDeCorreo As System.Windows.Forms.Label
    Private WithEvents lblcryptedPassword As System.Windows.Forms.Label
End Class
