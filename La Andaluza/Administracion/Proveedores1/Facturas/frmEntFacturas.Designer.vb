<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntFacturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntFacturas))
        Me.txtnumero = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.txtarchivo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_proveedor = New System.Windows.Forms.ComboBox()
        Me.butVerid_proveedor = New System.Windows.Forms.Button()
        Me.butAddid_proveedor = New System.Windows.Forms.Button()
        Me.lblnumero = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.lblarchivo = New System.Windows.Forms.Label()
        Me.lblid_proveedor = New System.Windows.Forms.Label()
        Me.btnaddFile = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnumero
        '
        Me.txtnumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtnumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtnumero.EsUnicoCampo = ""
        Me.txtnumero.EsUnicoCampoID = ""
        Me.txtnumero.EsUnicoID = 0
        Me.txtnumero.EsUnicoTabla = ""
        Me.txtnumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnumero.Location = New System.Drawing.Point(100, 37)
        Me.txtnumero.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnumero.MaxLength = 9
        Me.txtnumero.Minimo = 0
        Me.txtnumero.Modificado = False
        Me.txtnumero.Name = "txtnumero"
        Me.txtnumero.Numerico_EsNumerico = False
        Me.txtnumero.Numerico_NumeroDoublees = 0
        Me.txtnumero.Numerico_SeparadorMiles = False
        Me.txtnumero.Obligatorio = False
        Me.txtnumero.ParametroID = 0
        Me.txtnumero.Size = New System.Drawing.Size(181, 14)
        Me.txtnumero.TabIndex = 0
        Me.txtnumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtnumero.ValorMaximo = 0.0R
        Me.txtnumero.ValorMinimo = 0.0R
        '
        'dtpfecha
        '
        Me.dtpfecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(100, 62)
        Me.dtpfecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpfecha.TabIndex = 1
        '
        'txtarchivo
        '
        Me.txtarchivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtarchivo.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtarchivo.Cursor = System.Windows.Forms.Cursors.No
        Me.txtarchivo.Enabled = False
        Me.txtarchivo.EsUnicoCampo = ""
        Me.txtarchivo.EsUnicoCampoID = ""
        Me.txtarchivo.EsUnicoID = 0
        Me.txtarchivo.EsUnicoTabla = ""
        Me.txtarchivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarchivo.Location = New System.Drawing.Point(100, 96)
        Me.txtarchivo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtarchivo.MaxLength = 3000
        Me.txtarchivo.Minimo = 0
        Me.txtarchivo.Modificado = False
        Me.txtarchivo.Name = "txtarchivo"
        Me.txtarchivo.Numerico_EsNumerico = False
        Me.txtarchivo.Numerico_NumeroDoublees = 0
        Me.txtarchivo.Numerico_SeparadorMiles = False
        Me.txtarchivo.Obligatorio = False
        Me.txtarchivo.ParametroID = 0
        Me.txtarchivo.Size = New System.Drawing.Size(451, 14)
        Me.txtarchivo.TabIndex = 2
        Me.txtarchivo.ValorMaximo = 0.0R
        Me.txtarchivo.ValorMinimo = 0.0R
        '
        'cboid_proveedor
        '
        Me.cboid_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_proveedor.Location = New System.Drawing.Point(100, 118)
        Me.cboid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_proveedor.Name = "cboid_proveedor"
        Me.cboid_proveedor.Size = New System.Drawing.Size(428, 23)
        Me.cboid_proveedor.TabIndex = 3
        '
        'butVerid_proveedor
        '
        Me.butVerid_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_proveedor.FlatAppearance.BorderSize = 0
        Me.butVerid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_proveedor.Location = New System.Drawing.Point(532, 119)
        Me.butVerid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_proveedor.Name = "butVerid_proveedor"
        Me.butVerid_proveedor.Size = New System.Drawing.Size(18, 19)
        Me.butVerid_proveedor.TabIndex = 4
        Me.butVerid_proveedor.TabStop = False
        '
        'butAddid_proveedor
        '
        Me.butAddid_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddid_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_proveedor.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_proveedor.Location = New System.Drawing.Point(555, 119)
        Me.butAddid_proveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_proveedor.Name = "butAddid_proveedor"
        Me.butAddid_proveedor.Size = New System.Drawing.Size(18, 19)
        Me.butAddid_proveedor.TabIndex = 5
        Me.butAddid_proveedor.TabStop = False
        '
        'lblnumero
        '
        Me.lblnumero.Location = New System.Drawing.Point(28, 31)
        Me.lblnumero.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnumero.Name = "lblnumero"
        Me.lblnumero.Size = New System.Drawing.Size(68, 28)
        Me.lblnumero.TabIndex = 0
        Me.lblnumero.Text = "Número"
        Me.lblnumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfecha
        '
        Me.lblfecha.Location = New System.Drawing.Point(28, 59)
        Me.lblfecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(68, 28)
        Me.lblfecha.TabIndex = 1
        Me.lblfecha.Text = "Fecha"
        Me.lblfecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblarchivo
        '
        Me.lblarchivo.Location = New System.Drawing.Point(28, 88)
        Me.lblarchivo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblarchivo.Name = "lblarchivo"
        Me.lblarchivo.Size = New System.Drawing.Size(68, 28)
        Me.lblarchivo.TabIndex = 2
        Me.lblarchivo.Text = "Archivo"
        Me.lblarchivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_proveedor
        '
        Me.lblid_proveedor.Location = New System.Drawing.Point(28, 115)
        Me.lblid_proveedor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_proveedor.Name = "lblid_proveedor"
        Me.lblid_proveedor.Size = New System.Drawing.Size(68, 30)
        Me.lblid_proveedor.TabIndex = 3
        Me.lblid_proveedor.Text = "Proveedor"
        Me.lblid_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnaddFile
        '
        Me.btnaddFile.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnaddFile.FlatAppearance.BorderSize = 0
        Me.btnaddFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnaddFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnaddFile.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.btnaddFile.Location = New System.Drawing.Point(555, 90)
        Me.btnaddFile.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnaddFile.Name = "btnaddFile"
        Me.btnaddFile.Size = New System.Drawing.Size(18, 20)
        Me.btnaddFile.TabIndex = 1000000001
        Me.btnaddFile.TabStop = False
        '
        'frmEntFacturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(600, 171)
        Me.Controls.Add(Me.btnaddFile)
        Me.Controls.Add(Me.lblnumero)
        Me.Controls.Add(Me.txtnumero)
        Me.Controls.Add(Me.lblfecha)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.cboid_proveedor)
        Me.Controls.Add(Me.lblarchivo)
        Me.Controls.Add(Me.butAddid_proveedor)
        Me.Controls.Add(Me.txtarchivo)
        Me.Controls.Add(Me.butVerid_proveedor)
        Me.Controls.Add(Me.lblid_proveedor)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(369, 184)
        Me.Name = "frmEntFacturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Facturas"
        Me.Controls.SetChildIndex(Me.lblid_proveedor, 0)
        Me.Controls.SetChildIndex(Me.butVerid_proveedor, 0)
        Me.Controls.SetChildIndex(Me.txtarchivo, 0)
        Me.Controls.SetChildIndex(Me.butAddid_proveedor, 0)
        Me.Controls.SetChildIndex(Me.lblarchivo, 0)
        Me.Controls.SetChildIndex(Me.cboid_proveedor, 0)
        Me.Controls.SetChildIndex(Me.dtpfecha, 0)
        Me.Controls.SetChildIndex(Me.lblfecha, 0)
        Me.Controls.SetChildIndex(Me.txtnumero, 0)
        Me.Controls.SetChildIndex(Me.lblnumero, 0)
        Me.Controls.SetChildIndex(Me.btnaddFile, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtnumero As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpfecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtarchivo As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboid_proveedor As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_proveedor As System.Windows.Forms.Button
   Private WithEvents butAddid_proveedor As System.Windows.Forms.Button
   Private WithEvents lblnumero As System.Windows.Forms.Label
   Private WithEvents lblfecha As System.Windows.Forms.Label
   Private WithEvents lblarchivo As System.Windows.Forms.Label
   Private WithEvents lblid_proveedor As System.Windows.Forms.Label
   Private WithEvents btnaddFile As System.Windows.Forms.Button
End Class
