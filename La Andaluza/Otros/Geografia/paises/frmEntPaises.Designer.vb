<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaises))
        Me.txtPais = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.SystemColors.Window
        Me.txtPais.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPais.EsUnicoCampo = ""
        Me.txtPais.EsUnicoCampoID = ""
        Me.txtPais.EsUnicoID = 0
        Me.txtPais.EsUnicoTabla = ""
        Me.txtPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPais.Location = New System.Drawing.Point(118, 50)
        Me.txtPais.MaxLength = 3
        Me.txtPais.Minimo = 0
        Me.txtPais.Modificado = False
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Numerico_EsNumerico = False
        Me.txtPais.Numerico_NumeroDoublees = 0
        Me.txtPais.Numerico_SeparadorMiles = False
        Me.txtPais.Obligatorio = False
        Me.txtPais.ParametroID = 0
        Me.txtPais.Size = New System.Drawing.Size(200, 21)
        Me.txtPais.TabIndex = 0
        Me.txtPais.ValorMaximo = 0.0R
        Me.txtPais.ValorMinimo = 0.0R
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.EsUnicoCampo = ""
        Me.txtNombre.EsUnicoCampoID = ""
        Me.txtNombre.EsUnicoID = 0
        Me.txtNombre.EsUnicoTabla = ""
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(118, 80)
        Me.txtNombre.MaxLength = 200
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(200, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'lblPais
        '
        Me.lblPais.Location = New System.Drawing.Point(41, 46)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(71, 30)
        Me.lblPais.TabIndex = 0
        Me.lblPais.Text = "Abreviación"
        Me.lblPais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(44, 76)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(69, 30)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntPaises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(369, 132)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(378, 135)
        Me.Name = "frmEntPaises"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Paises"
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtPais, 0)
        Me.Controls.SetChildIndex(Me.lblPais, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtPais As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblPais As System.Windows.Forms.Label
   Private WithEvents lblNombre As System.Windows.Forms.Label

End Class
