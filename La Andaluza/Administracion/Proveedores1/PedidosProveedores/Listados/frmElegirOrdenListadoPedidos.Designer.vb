<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmElegirOrdenListadoPedidos
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.butByProveedor = New System.Windows.Forms.Button()
        Me.butByNumero = New System.Windows.Forms.Button()
        Me.butByFecha = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.butDia = New System.Windows.Forms.Button()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.butProveedor = New System.Windows.Forms.Button()
        Me.butEntregaIncumplida = New System.Windows.Forms.Button()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'butByProveedor
        '
        Me.butByProveedor.FlatAppearance.BorderSize = 0
        Me.butByProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butByProveedor.Location = New System.Drawing.Point(178, 69)
        Me.butByProveedor.Name = "butByProveedor"
        Me.butByProveedor.Size = New System.Drawing.Size(89, 23)
        Me.butByProveedor.TabIndex = 3
        Me.butByProveedor.Text = "Por proveedor"
        Me.butByProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butByProveedor.UseVisualStyleBackColor = True
        '
        'butByNumero
        '
        Me.butByNumero.FlatAppearance.BorderSize = 0
        Me.butByNumero.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butByNumero.Location = New System.Drawing.Point(24, 69)
        Me.butByNumero.Name = "butByNumero"
        Me.butByNumero.Size = New System.Drawing.Size(89, 23)
        Me.butByNumero.TabIndex = 4
        Me.butByNumero.Text = "Por numero"
        Me.butByNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butByNumero.UseVisualStyleBackColor = True
        '
        'butByFecha
        '
        Me.butByFecha.FlatAppearance.BorderSize = 0
        Me.butByFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butByFecha.Location = New System.Drawing.Point(318, 69)
        Me.butByFecha.Name = "butByFecha"
        Me.butByFecha.Size = New System.Drawing.Size(89, 23)
        Me.butByFecha.TabIndex = 5
        Me.butByFecha.Text = "Por fecha"
        Me.butByFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butByFecha.UseVisualStyleBackColor = True
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(120, 116)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(147, 20)
        Me.dtpFecha.TabIndex = 6
        '
        'butDia
        '
        Me.butDia.FlatAppearance.BorderSize = 0
        Me.butDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butDia.Location = New System.Drawing.Point(24, 113)
        Me.butDia.Name = "butDia"
        Me.butDia.Size = New System.Drawing.Size(63, 23)
        Me.butDia.TabIndex = 7
        Me.butDia.Text = "Un dia"
        Me.butDia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butDia.UseVisualStyleBackColor = True
        '
        'cboProveedores
        '
        Me.cboProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(120, 154)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(345, 21)
        Me.cboProveedores.TabIndex = 8
        '
        'butProveedor
        '
        Me.butProveedor.FlatAppearance.BorderSize = 0
        Me.butProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butProveedor.Location = New System.Drawing.Point(24, 152)
        Me.butProveedor.Name = "butProveedor"
        Me.butProveedor.Size = New System.Drawing.Size(90, 23)
        Me.butProveedor.TabIndex = 9
        Me.butProveedor.Text = "Un proveedor"
        Me.butProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butProveedor.UseVisualStyleBackColor = True
        '
        'butEntregaIncumplida
        '
        Me.butEntregaIncumplida.FlatAppearance.BorderSize = 0
        Me.butEntregaIncumplida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butEntregaIncumplida.Location = New System.Drawing.Point(318, 113)
        Me.butEntregaIncumplida.Name = "butEntregaIncumplida"
        Me.butEntregaIncumplida.Size = New System.Drawing.Size(157, 23)
        Me.butEntregaIncumplida.TabIndex = 10
        Me.butEntregaIncumplida.Text = "Fecha de entrega incumplida"
        Me.butEntregaIncumplida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.butEntregaIncumplida.UseVisualStyleBackColor = True
        '
        'btnCerrar
        '
        Me.btnCerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Image = Global.La_Andaluza.My.Resources.Resources.application_exit_4
        Me.btnCerrar.Location = New System.Drawing.Point(9, 9)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(29, 23)
        Me.btnCerrar.TabIndex = 11
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'frmElegirOrdenListadoPedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCerrar
        Me.ClientSize = New System.Drawing.Size(509, 236)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.butEntregaIncumplida)
        Me.Controls.Add(Me.butProveedor)
        Me.Controls.Add(Me.cboProveedores)
        Me.Controls.Add(Me.butDia)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.butByFecha)
        Me.Controls.Add(Me.butByNumero)
        Me.Controls.Add(Me.butByProveedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmElegirOrdenListadoPedidos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmElegirOrdenListadoPedidos"
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents btnCerrar As System.Windows.Forms.Button
    Private WithEvents butByProveedor As System.Windows.Forms.Button
    Private WithEvents butByNumero As System.Windows.Forms.Button
    Private WithEvents butByFecha As System.Windows.Forms.Button
    Public WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents butDia As System.Windows.Forms.Button
    Public WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Private WithEvents butProveedor As System.Windows.Forms.Button
    Private WithEvents butEntregaIncumplida As System.Windows.Forms.Button
End Class
