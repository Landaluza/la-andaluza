<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntReuniones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntReuniones))
        Me.cboId_proveedor = New System.Windows.Forms.ComboBox()
        Me.butAddId_proveedor = New System.Windows.Forms.Button()
        Me.cboId_TipoReunion = New System.Windows.Forms.ComboBox()
        Me.butAddId_TipoReunion = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRutaDocumento = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRutaDocumento = New System.Windows.Forms.Button()
        Me.lblId_proveedor = New System.Windows.Forms.Label()
        Me.lblId_TipoReunion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblRutaDocumento = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboId_proveedor
        '
        Me.cboId_proveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboId_proveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboId_proveedor.Location = New System.Drawing.Point(119, 46)
        Me.cboId_proveedor.Name = "cboId_proveedor"
        Me.cboId_proveedor.Size = New System.Drawing.Size(280, 23)
        Me.cboId_proveedor.TabIndex = 0
        '
        'butAddId_proveedor
        '
        Me.butAddId_proveedor.FlatAppearance.BorderSize = 0
        Me.butAddId_proveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_proveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_proveedor.Image = CType(resources.GetObject("butAddId_proveedor.Image"), System.Drawing.Image)
        Me.butAddId_proveedor.Location = New System.Drawing.Point(402, 46)
        Me.butAddId_proveedor.Name = "butAddId_proveedor"
        Me.butAddId_proveedor.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_proveedor.TabIndex = 2
        Me.butAddId_proveedor.TabStop = False
        '
        'cboId_TipoReunion
        '
        Me.cboId_TipoReunion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboId_TipoReunion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboId_TipoReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboId_TipoReunion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboId_TipoReunion.Location = New System.Drawing.Point(119, 75)
        Me.cboId_TipoReunion.Name = "cboId_TipoReunion"
        Me.cboId_TipoReunion.Size = New System.Drawing.Size(280, 23)
        Me.cboId_TipoReunion.TabIndex = 1
        '
        'butAddId_TipoReunion
        '
        Me.butAddId_TipoReunion.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoReunion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoReunion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoReunion.Image = CType(resources.GetObject("butAddId_TipoReunion.Image"), System.Drawing.Image)
        Me.butAddId_TipoReunion.Location = New System.Drawing.Point(402, 74)
        Me.butAddId_TipoReunion.Name = "butAddId_TipoReunion"
        Me.butAddId_TipoReunion.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_TipoReunion.TabIndex = 5
        Me.butAddId_TipoReunion.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(119, 104)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(119, 131)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(280, 44)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtRutaDocumento
        '
        Me.txtRutaDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutaDocumento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaDocumento.Enabled = False
        Me.txtRutaDocumento.EsUnicoCampo = ""
        Me.txtRutaDocumento.EsUnicoCampoID = ""
        Me.txtRutaDocumento.EsUnicoID = 0
        Me.txtRutaDocumento.EsUnicoTabla = ""
        Me.txtRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaDocumento.Location = New System.Drawing.Point(119, 181)
        Me.txtRutaDocumento.MaxLength = 250
        Me.txtRutaDocumento.Minimo = 0
        Me.txtRutaDocumento.Modificado = False
        Me.txtRutaDocumento.Name = "txtRutaDocumento"
        Me.txtRutaDocumento.Numerico_EsNumerico = False
        Me.txtRutaDocumento.Numerico_NumeroDoublees = 0
        Me.txtRutaDocumento.Numerico_SeparadorMiles = False
        Me.txtRutaDocumento.Obligatorio = False
        Me.txtRutaDocumento.ParametroID = 0
        Me.txtRutaDocumento.Size = New System.Drawing.Size(280, 21)
        Me.txtRutaDocumento.TabIndex = 4
        Me.txtRutaDocumento.ValorMaximo = 0.0R
        Me.txtRutaDocumento.ValorMinimo = 0.0R
        '
        'butRutaDocumento
        '
        Me.butRutaDocumento.FlatAppearance.BorderSize = 0
        Me.butRutaDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaDocumento.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaDocumento.Location = New System.Drawing.Point(402, 181)
        Me.butRutaDocumento.Name = "butRutaDocumento"
        Me.butRutaDocumento.Size = New System.Drawing.Size(20, 21)
        Me.butRutaDocumento.TabIndex = 9
        Me.butRutaDocumento.TabStop = False
        '
        'lblId_proveedor
        '
        Me.lblId_proveedor.Location = New System.Drawing.Point(27, 43)
        Me.lblId_proveedor.Name = "lblId_proveedor"
        Me.lblId_proveedor.Size = New System.Drawing.Size(86, 29)
        Me.lblId_proveedor.TabIndex = 0
        Me.lblId_proveedor.Text = "Proveedor"
        Me.lblId_proveedor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_TipoReunion
        '
        Me.lblId_TipoReunion.Location = New System.Drawing.Point(27, 72)
        Me.lblId_TipoReunion.Name = "lblId_TipoReunion"
        Me.lblId_TipoReunion.Size = New System.Drawing.Size(86, 29)
        Me.lblId_TipoReunion.TabIndex = 3
        Me.lblId_TipoReunion.Text = "Tipo de reunión"
        Me.lblId_TipoReunion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(27, 101)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(86, 27)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 128)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(86, 27)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaDocumento
        '
        Me.lblRutaDocumento.Location = New System.Drawing.Point(27, 178)
        Me.lblRutaDocumento.Name = "lblRutaDocumento"
        Me.lblRutaDocumento.Size = New System.Drawing.Size(86, 27)
        Me.lblRutaDocumento.TabIndex = 8
        Me.lblRutaDocumento.Text = "Documento"
        Me.lblRutaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntReuniones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(448, 211)
        Me.Controls.Add(Me.lblId_proveedor)
        Me.Controls.Add(Me.cboId_proveedor)
        Me.Controls.Add(Me.butAddId_proveedor)
        Me.Controls.Add(Me.cboId_TipoReunion)
        Me.Controls.Add(Me.lblId_TipoReunion)
        Me.Controls.Add(Me.butRutaDocumento)
        Me.Controls.Add(Me.txtRutaDocumento)
        Me.Controls.Add(Me.lblRutaDocumento)
        Me.Controls.Add(Me.butAddId_TipoReunion)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.dtpFecha)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(464, 249)
        Me.MinimumSize = New System.Drawing.Size(464, 249)
        Me.Name = "frmEntReuniones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reuniones"
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butAddId_TipoReunion, 0)
        Me.Controls.SetChildIndex(Me.lblRutaDocumento, 0)
        Me.Controls.SetChildIndex(Me.txtRutaDocumento, 0)
        Me.Controls.SetChildIndex(Me.butRutaDocumento, 0)
        Me.Controls.SetChildIndex(Me.lblId_TipoReunion, 0)
        Me.Controls.SetChildIndex(Me.cboId_TipoReunion, 0)
        Me.Controls.SetChildIndex(Me.butAddId_proveedor, 0)
        Me.Controls.SetChildIndex(Me.cboId_proveedor, 0)
        Me.Controls.SetChildIndex(Me.lblId_proveedor, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboId_proveedor As System.Windows.Forms.ComboBox
    Private WithEvents butAddId_proveedor As System.Windows.Forms.Button
    Private WithEvents cboId_TipoReunion As System.Windows.Forms.ComboBox
    Private WithEvents butAddId_TipoReunion As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRutaDocumento As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRutaDocumento As System.Windows.Forms.Button
    Private WithEvents lblId_proveedor As System.Windows.Forms.Label
    Private WithEvents lblId_TipoReunion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblRutaDocumento As System.Windows.Forms.Label
End Class
