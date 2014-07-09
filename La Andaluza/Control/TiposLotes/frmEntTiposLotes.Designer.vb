<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposLotes))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbreviatura = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtOrden = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.lblOrden = New System.Windows.Forms.Label()

        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(161, 11)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 21)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbreviatura.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAbreviatura.EsUnicoCampo = ""
        Me.txtAbreviatura.EsUnicoCampoID = ""
        Me.txtAbreviatura.EsUnicoID = 0
        Me.txtAbreviatura.EsUnicoTabla = ""
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(161, 40)
        Me.txtAbreviatura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAbreviatura.MaxLength = 3
        Me.txtAbreviatura.Minimo = 0
        Me.txtAbreviatura.Modificado = False
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Numerico_EsNumerico = False
        Me.txtAbreviatura.Numerico_NumeroDoublees = 0
        Me.txtAbreviatura.Numerico_SeparadorMiles = False
        Me.txtAbreviatura.Obligatorio = False
        Me.txtAbreviatura.ParametroID = 0
        Me.txtAbreviatura.Size = New System.Drawing.Size(181, 21)
        Me.txtAbreviatura.TabIndex = 1
        Me.txtAbreviatura.ValorMaximo = 0.0R
        Me.txtAbreviatura.ValorMinimo = 0.0R
        '
        'txtOrden
        '
        Me.txtOrden.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrden.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOrden.EsUnicoCampo = ""
        Me.txtOrden.EsUnicoCampoID = ""
        Me.txtOrden.EsUnicoID = 0
        Me.txtOrden.EsUnicoTabla = ""
        Me.txtOrden.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrden.Location = New System.Drawing.Point(161, 68)
        Me.txtOrden.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtOrden.MaxLength = 9
        Me.txtOrden.Minimo = 0
        Me.txtOrden.Modificado = False
        Me.txtOrden.Name = "txtOrden"
        Me.txtOrden.Numerico_EsNumerico = False
        Me.txtOrden.Numerico_NumeroDoublees = 0
        Me.txtOrden.Numerico_SeparadorMiles = False
        Me.txtOrden.Obligatorio = False
        Me.txtOrden.ParametroID = 0
        Me.txtOrden.Size = New System.Drawing.Size(181, 21)
        Me.txtOrden.TabIndex = 2
        Me.txtOrden.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOrden.ValorMaximo = 0.0R
        Me.txtOrden.ValorMinimo = 0.0R
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(87, 9)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(70, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.Location = New System.Drawing.Point(90, 37)
        Me.lblAbreviatura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(67, 28)
        Me.lblAbreviatura.TabIndex = 1
        Me.lblAbreviatura.Text = "Abreviatura"
        Me.lblAbreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOrden
        '
        Me.lblOrden.Location = New System.Drawing.Point(90, 66)
        Me.lblOrden.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblOrden.Name = "lblOrden"
        Me.lblOrden.Size = New System.Drawing.Size(67, 28)
        Me.lblOrden.TabIndex = 2
        Me.lblOrden.Text = "Orden"
        Me.lblOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblOrden)
        Me.Panel1.Controls.Add(Me.txtOrden)
        Me.Panel1.Controls.Add(Me.txtAbreviatura)
        Me.Panel1.Controls.Add(Me.lblAbreviatura)
        Me.Panel1.Location = New System.Drawing.Point(47, 35)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 102)
        Me.Panel1.TabIndex = 8
        '
        'frmEntTiposLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(588, 158)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(363, 158)
        Me.Name = "frmEntTiposLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposLotes"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAbreviatura As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtOrden As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblAbreviatura As System.Windows.Forms.Label
    Private WithEvents lblOrden As System.Windows.Forms.Label

    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
