<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepFormato
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodigoQS = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Location = New System.Drawing.Point(93, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 300)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(76, 64)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(240, 21)
        Me.ComboBox1.TabIndex = 3
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblCodigoQS)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.txtCodigoQS)
        Me.Panel2.Location = New System.Drawing.Point(85, 129)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(387, 74)
        Me.Panel2.TabIndex = 2
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Location = New System.Drawing.Point(-3, 41)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(71, 21)
        Me.lblCodigoQS.TabIndex = 5
        Me.lblCodigoQS.Text = "CodigoQS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(-3, 14)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(71, 21)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(85, 41)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(277, 21)
        Me.txtDescripcion.TabIndex = 4
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.EsUnicoCampo = ""
        Me.txtCodigoQS.EsUnicoCampoID = ""
        Me.txtCodigoQS.EsUnicoID = 0
        Me.txtCodigoQS.EsUnicoTabla = ""
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(85, 14)
        Me.txtCodigoQS.MaxLength = 9
        Me.txtCodigoQS.Minimo = 0
        Me.txtCodigoQS.Modificado = False
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Numerico_EsNumerico = True
        Me.txtCodigoQS.Numerico_NumeroDoublees = 0
        Me.txtCodigoQS.Numerico_SeparadorMiles = False
        Me.txtCodigoQS.Obligatorio = True
        Me.txtCodigoQS.ParametroID = 0
        Me.txtCodigoQS.Size = New System.Drawing.Size(146, 21)
        Me.txtCodigoQS.TabIndex = 3
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigoQS.ValorMaximo = 0.0!
        Me.txtCodigoQS.ValorMinimo = 0.0!
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(57, 100)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton2.TabIndex = 1
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RadioButton2"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(57, 41)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(90, 17)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "RadioButton1"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'frmWstepFormato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(656, 429)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmWstepFormato"
        Me.Text = "frmWstepFormato"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Private WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Private WithEvents lblCodigoQS As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCodigoQS As BasesParaCompatibilidad.CuadroDeTexto
End Class
