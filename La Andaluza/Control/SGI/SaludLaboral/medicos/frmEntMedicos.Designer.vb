<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntMedicos))
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtapellido = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtapellido2 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtobservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblapellido = New System.Windows.Forms.Label()
        Me.lblapellido2 = New System.Windows.Forms.Label()
        Me.lblobservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.EsUnicoCampo = ""
        Me.txtnombre.EsUnicoCampoID = ""
        Me.txtnombre.EsUnicoID = 0
        Me.txtnombre.EsUnicoTabla = ""
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(136, 51)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre.MaxLength = 300
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
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.SystemColors.Window
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.EsUnicoCampo = ""
        Me.txtapellido.EsUnicoCampoID = ""
        Me.txtapellido.EsUnicoID = 0
        Me.txtapellido.EsUnicoTabla = ""
        Me.txtapellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.Location = New System.Drawing.Point(136, 80)
        Me.txtapellido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtapellido.MaxLength = 300
        Me.txtapellido.Minimo = 0
        Me.txtapellido.Modificado = False
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Numerico_EsNumerico = False
        Me.txtapellido.Numerico_NumeroDoublees = 0
        Me.txtapellido.Numerico_SeparadorMiles = False
        Me.txtapellido.Obligatorio = False
        Me.txtapellido.ParametroID = 0
        Me.txtapellido.Size = New System.Drawing.Size(181, 21)
        Me.txtapellido.TabIndex = 1
        Me.txtapellido.ValorMaximo = 0.0R
        Me.txtapellido.ValorMinimo = 0.0R
        '
        'txtapellido2
        '
        Me.txtapellido2.BackColor = System.Drawing.SystemColors.Window
        Me.txtapellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido2.EsUnicoCampo = ""
        Me.txtapellido2.EsUnicoCampoID = ""
        Me.txtapellido2.EsUnicoID = 0
        Me.txtapellido2.EsUnicoTabla = ""
        Me.txtapellido2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido2.Location = New System.Drawing.Point(136, 108)
        Me.txtapellido2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtapellido2.MaxLength = 300
        Me.txtapellido2.Minimo = 0
        Me.txtapellido2.Modificado = False
        Me.txtapellido2.Name = "txtapellido2"
        Me.txtapellido2.Numerico_EsNumerico = False
        Me.txtapellido2.Numerico_NumeroDoublees = 0
        Me.txtapellido2.Numerico_SeparadorMiles = False
        Me.txtapellido2.Obligatorio = False
        Me.txtapellido2.ParametroID = 0
        Me.txtapellido2.Size = New System.Drawing.Size(181, 21)
        Me.txtapellido2.TabIndex = 2
        Me.txtapellido2.ValorMaximo = 0.0R
        Me.txtapellido2.ValorMinimo = 0.0R
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.EsUnicoCampo = ""
        Me.txtobservaciones.EsUnicoCampoID = ""
        Me.txtobservaciones.EsUnicoID = 0
        Me.txtobservaciones.EsUnicoTabla = ""
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(58, 164)
        Me.txtobservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtobservaciones.MaxLength = 1000
        Me.txtobservaciones.Minimo = 0
        Me.txtobservaciones.Modificado = False
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Numerico_EsNumerico = False
        Me.txtobservaciones.Numerico_NumeroDoublees = 0
        Me.txtobservaciones.Numerico_SeparadorMiles = False
        Me.txtobservaciones.Obligatorio = False
        Me.txtobservaciones.ParametroID = 0
        Me.txtobservaciones.Size = New System.Drawing.Size(258, 91)
        Me.txtobservaciones.TabIndex = 3
        Me.txtobservaciones.ValorMaximo = 0.0R
        Me.txtobservaciones.ValorMinimo = 0.0R
        '
        'lblnombre
        '
        Me.lblnombre.Location = New System.Drawing.Point(56, 49)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(75, 28)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblapellido
        '
        Me.lblapellido.Location = New System.Drawing.Point(56, 77)
        Me.lblapellido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblapellido.Name = "lblapellido"
        Me.lblapellido.Size = New System.Drawing.Size(75, 28)
        Me.lblapellido.TabIndex = 1
        Me.lblapellido.Text = "Apellido"
        Me.lblapellido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblapellido2
        '
        Me.lblapellido2.Location = New System.Drawing.Point(56, 106)
        Me.lblapellido2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblapellido2.Name = "lblapellido2"
        Me.lblapellido2.Size = New System.Drawing.Size(75, 28)
        Me.lblapellido2.TabIndex = 2
        Me.lblapellido2.Text = "Segundo apellido"
        Me.lblapellido2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblobservaciones
        '
        Me.lblobservaciones.Location = New System.Drawing.Point(56, 145)
        Me.lblobservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(88, 17)
        Me.lblobservaciones.TabIndex = 3
        Me.lblobservaciones.Text = "Observaciones"
        Me.lblobservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(368, 280)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtnombre)
        Me.Controls.Add(Me.lblapellido)
        Me.Controls.Add(Me.txtapellido)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.lblapellido2)
        Me.Controls.Add(Me.lblobservaciones)
        Me.Controls.Add(Me.txtapellido2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(377, 183)
        Me.Name = "frmEntMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Medicos"
        Me.Controls.SetChildIndex(Me.txtapellido2, 0)
        Me.Controls.SetChildIndex(Me.lblobservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblapellido2, 0)
        Me.Controls.SetChildIndex(Me.txtobservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtapellido, 0)
        Me.Controls.SetChildIndex(Me.lblapellido, 0)
        Me.Controls.SetChildIndex(Me.txtnombre, 0)
        Me.Controls.SetChildIndex(Me.lblnombre, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtapellido As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtapellido2 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtobservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblnombre As System.Windows.Forms.Label
   Private WithEvents lblapellido As System.Windows.Forms.Label
   Private WithEvents lblapellido2 As System.Windows.Forms.Label
   Private WithEvents lblobservaciones As System.Windows.Forms.Label

End Class
