<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntTiposProductosCompuestoPor
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Can = New System.Windows.Forms.Label()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Producto"
        '
        'ComboBox1
        '
        Me.ComboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(58, 19)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'Can
        '
        Me.Can.AutoSize = True
        Me.Can.Location = New System.Drawing.Point(7, 46)
        Me.Can.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Can.Name = "Can"
        Me.Can.Size = New System.Drawing.Size(49, 13)
        Me.Can.TabIndex = 2
        Me.Can.Text = "Cantidad"
        '
        'txtDensidad
        '
        Me.txtDensidad.EsUnicoCampo = "Abreviatura"
        Me.txtDensidad.EsUnicoCampoID = "TipoProductoID"
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = "TiposProductos"
        Me.txtDensidad.Location = New System.Drawing.Point(58, 44)
        Me.txtDensidad.MaxLength = 11
        Me.txtDensidad.Minimo = 1
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 3
        Me.txtDensidad.Numerico_SeparadorMiles = False
        Me.txtDensidad.Obligatorio = False
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(60, 20)
        Me.txtDensidad.TabIndex = 1000000005
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0.0R
        Me.txtDensidad.ValorMinimo = 0.0R
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_cancel_3
        Me.btnCancelar.Location = New System.Drawing.Point(9, 101)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(120, 46)
        Me.btnCancelar.TabIndex = 1000000006
        Me.btnCancelar.Text = "&Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnAceptar.Location = New System.Drawing.Point(183, 101)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(115, 46)
        Me.btnAceptar.TabIndex = 1000000007
        Me.btnAceptar.Text = "&Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'frmEntTiposProductosCompuestoPor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 156)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.txtDensidad)
        Me.Controls.Add(Me.Can)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmEntTiposProductosCompuestoPor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmEntTiposProductosCompuestoPor"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
   Private WithEvents Can As System.Windows.Forms.Label
    Private WithEvents txtDensidad As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents btnCancelar As System.Windows.Forms.Button
   Private WithEvents btnAceptar As System.Windows.Forms.Button
End Class
