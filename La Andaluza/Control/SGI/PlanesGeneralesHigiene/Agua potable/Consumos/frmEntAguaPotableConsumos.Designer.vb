<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotableConsumos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotableConsumos))
        Me.txtPeriodo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtLitros = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_factura = New System.Windows.Forms.ComboBox()
        Me.butVerid_factura = New System.Windows.Forms.Button()
        Me.butAddid_factura = New System.Windows.Forms.Button()
        Me.lblPeriodo = New System.Windows.Forms.Label()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblid_factura = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtPeriodo
        '
        Me.txtPeriodo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeriodo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPeriodo.EsUnicoCampo = ""
        Me.txtPeriodo.EsUnicoCampoID = ""
        Me.txtPeriodo.EsUnicoID = 0
        Me.txtPeriodo.EsUnicoTabla = ""
        Me.txtPeriodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodo.Location = New System.Drawing.Point(107, 37)
        Me.txtPeriodo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPeriodo.MaxLength = 120
        Me.txtPeriodo.Minimo = 0
        Me.txtPeriodo.Modificado = False
        Me.txtPeriodo.Name = "txtPeriodo"
        Me.txtPeriodo.Numerico_EsNumerico = False
        Me.txtPeriodo.Numerico_NumeroDoublees = 0
        Me.txtPeriodo.Numerico_SeparadorMiles = False
        Me.txtPeriodo.Obligatorio = False
        Me.txtPeriodo.ParametroID = 0
        Me.txtPeriodo.Size = New System.Drawing.Size(408, 14)
        Me.txtPeriodo.TabIndex = 0
        Me.txtPeriodo.ValorMaximo = 0.0R
        Me.txtPeriodo.ValorMinimo = 0.0R
        '
        'txtLitros
        '
        Me.txtLitros.BackColor = System.Drawing.SystemColors.Window
        Me.txtLitros.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtLitros.EsUnicoCampo = ""
        Me.txtLitros.EsUnicoCampoID = ""
        Me.txtLitros.EsUnicoID = 0
        Me.txtLitros.EsUnicoTabla = ""
        Me.txtLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLitros.Location = New System.Drawing.Point(107, 66)
        Me.txtLitros.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtLitros.MaxLength = 9
        Me.txtLitros.Minimo = 0
        Me.txtLitros.Modificado = False
        Me.txtLitros.Name = "txtLitros"
        Me.txtLitros.Numerico_EsNumerico = False
        Me.txtLitros.Numerico_NumeroDoublees = 0
        Me.txtLitros.Numerico_SeparadorMiles = False
        Me.txtLitros.Obligatorio = False
        Me.txtLitros.ParametroID = 0
        Me.txtLitros.Size = New System.Drawing.Size(104, 14)
        Me.txtLitros.TabIndex = 1
        Me.txtLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLitros.ValorMaximo = 0.0R
        Me.txtLitros.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(107, 93)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(408, 61)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'cboid_factura
        '
        Me.cboid_factura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_factura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_factura.Location = New System.Drawing.Point(107, 169)
        Me.cboid_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_factura.Name = "cboid_factura"
        Me.cboid_factura.Size = New System.Drawing.Size(408, 23)
        Me.cboid_factura.TabIndex = 3
        '
        'butVerid_factura
        '
        Me.butVerid_factura.FlatAppearance.BorderSize = 0
        Me.butVerid_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_factura.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_factura.Location = New System.Drawing.Point(519, 168)
        Me.butVerid_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_factura.Name = "butVerid_factura"
        Me.butVerid_factura.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_factura.TabIndex = 4
        Me.butVerid_factura.TabStop = False
        '
        'butAddid_factura
        '
        Me.butAddid_factura.FlatAppearance.BorderSize = 0
        Me.butAddid_factura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_factura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_factura.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_factura.Location = New System.Drawing.Point(542, 168)
        Me.butAddid_factura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_factura.Name = "butAddid_factura"
        Me.butAddid_factura.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_factura.TabIndex = 5
        Me.butAddid_factura.TabStop = False
        '
        'lblPeriodo
        '
        Me.lblPeriodo.Location = New System.Drawing.Point(22, 34)
        Me.lblPeriodo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeriodo.Name = "lblPeriodo"
        Me.lblPeriodo.Size = New System.Drawing.Size(80, 28)
        Me.lblPeriodo.TabIndex = 0
        Me.lblPeriodo.Text = "Periodo"
        Me.lblPeriodo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLitros
        '
        Me.lblLitros.Location = New System.Drawing.Point(22, 63)
        Me.lblLitros.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(80, 28)
        Me.lblLitros.TabIndex = 1
        Me.lblLitros.Text = "Litros"
        Me.lblLitros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 91)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(82, 28)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_factura
        '
        Me.lblid_factura.Location = New System.Drawing.Point(22, 167)
        Me.lblid_factura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_factura.Name = "lblid_factura"
        Me.lblid_factura.Size = New System.Drawing.Size(80, 30)
        Me.lblid_factura.TabIndex = 3
        Me.lblid_factura.Text = "Factura"
        Me.lblid_factura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotableConsumos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(584, 228)
        Me.Controls.Add(Me.lblPeriodo)
        Me.Controls.Add(Me.txtPeriodo)
        Me.Controls.Add(Me.lblLitros)
        Me.Controls.Add(Me.txtLitros)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butAddid_factura)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.butVerid_factura)
        Me.Controls.Add(Me.lblid_factura)
        Me.Controls.Add(Me.cboid_factura)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(403, 184)
        Me.Name = "frmEntAguaPotableConsumos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotableConsumos"
        Me.Controls.SetChildIndex(Me.cboid_factura, 0)
        Me.Controls.SetChildIndex(Me.lblid_factura, 0)
        Me.Controls.SetChildIndex(Me.butVerid_factura, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butAddid_factura, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtLitros, 0)
        Me.Controls.SetChildIndex(Me.lblLitros, 0)
        Me.Controls.SetChildIndex(Me.txtPeriodo, 0)
        Me.Controls.SetChildIndex(Me.lblPeriodo, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtPeriodo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtLitros As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboid_factura As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_factura As System.Windows.Forms.Button
   Private WithEvents butAddid_factura As System.Windows.Forms.Button
   Private WithEvents lblPeriodo As System.Windows.Forms.Label
   Private WithEvents lblLitros As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblid_factura As System.Windows.Forms.Label

End Class
