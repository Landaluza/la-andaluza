<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulos_AlmacenNoConforme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulos_AlmacenNoConforme))
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaEntrada = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaSalida = New System.Windows.Forms.DateTimePicker()
        Me.cboTipoAccion = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoAccion = New System.Windows.Forms.Button()
        Me.butAddId_TipoAccion = New System.Windows.Forms.Button()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_MedidaProducto = New System.Windows.Forms.ComboBox()
        Me.butVerid_MedidaProducto = New System.Windows.Forms.Button()
        Me.butAddid_MedidaProducto = New System.Windows.Forms.Button()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblFechaEntrada = New System.Windows.Forms.Label()
        Me.lblFechaSalida = New System.Windows.Forms.Label()
        Me.lblId_TipoAccion = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblid_MedidaProducto = New System.Windows.Forms.Label()

        Me.chbSalida = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtObservaciones.Location = New System.Drawing.Point(139, 52)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(208, 64)
        Me.txtObservaciones.TabIndex = 0
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'dtpFechaEntrada
        '
        Me.dtpFechaEntrada.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaEntrada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEntrada.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEntrada.Location = New System.Drawing.Point(139, 120)
        Me.dtpFechaEntrada.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaEntrada.Name = "dtpFechaEntrada"
        Me.dtpFechaEntrada.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaEntrada.TabIndex = 1
        '
        'dtpFechaSalida
        '
        Me.dtpFechaSalida.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaSalida.Enabled = False
        Me.dtpFechaSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSalida.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSalida.Location = New System.Drawing.Point(139, 149)
        Me.dtpFechaSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaSalida.Name = "dtpFechaSalida"
        Me.dtpFechaSalida.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaSalida.TabIndex = 2
        '
        'cboTipoAccion
        '
        Me.cboTipoAccion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoAccion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoAccion.Location = New System.Drawing.Point(139, 176)
        Me.cboTipoAccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoAccion.Name = "cboTipoAccion"
        Me.cboTipoAccion.Size = New System.Drawing.Size(208, 23)
        Me.cboTipoAccion.TabIndex = 3
        '
        'butVerId_TipoAccion
        '
        Me.butVerId_TipoAccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoAccion.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoAccion.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_TipoAccion.Location = New System.Drawing.Point(350, 176)
        Me.butVerId_TipoAccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_TipoAccion.Name = "butVerId_TipoAccion"
        Me.butVerId_TipoAccion.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_TipoAccion.TabIndex = 4
        Me.butVerId_TipoAccion.TabStop = False
        '
        'butAddId_TipoAccion
        '
        Me.butAddId_TipoAccion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoAccion.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoAccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoAccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoAccion.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoAccion.Location = New System.Drawing.Point(373, 176)
        Me.butAddId_TipoAccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_TipoAccion.Name = "butAddId_TipoAccion"
        Me.butAddId_TipoAccion.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_TipoAccion.TabIndex = 5
        Me.butAddId_TipoAccion.TabStop = False
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(139, 206)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = False
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = False
        Me.txtCantidad.Obligatorio = False
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(208, 14)
        Me.txtCantidad.TabIndex = 4
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'cboid_MedidaProducto
        '
        Me.cboid_MedidaProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_MedidaProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_MedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_MedidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_MedidaProducto.Location = New System.Drawing.Point(139, 235)
        Me.cboid_MedidaProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_MedidaProducto.Name = "cboid_MedidaProducto"
        Me.cboid_MedidaProducto.Size = New System.Drawing.Size(208, 23)
        Me.cboid_MedidaProducto.TabIndex = 5
        '
        'butVerid_MedidaProducto
        '
        Me.butVerid_MedidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_MedidaProducto.FlatAppearance.BorderSize = 0
        Me.butVerid_MedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_MedidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_MedidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_MedidaProducto.Location = New System.Drawing.Point(350, 234)
        Me.butVerid_MedidaProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_MedidaProducto.Name = "butVerid_MedidaProducto"
        Me.butVerid_MedidaProducto.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_MedidaProducto.TabIndex = 8
        Me.butVerid_MedidaProducto.TabStop = False
        '
        'butAddid_MedidaProducto
        '
        Me.butAddid_MedidaProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_MedidaProducto.FlatAppearance.BorderSize = 0
        Me.butAddid_MedidaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_MedidaProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_MedidaProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_MedidaProducto.Location = New System.Drawing.Point(373, 234)
        Me.butAddid_MedidaProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_MedidaProducto.Name = "butAddid_MedidaProducto"
        Me.butAddid_MedidaProducto.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_MedidaProducto.TabIndex = 9
        Me.butAddid_MedidaProducto.TabStop = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(28, 50)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(106, 28)
        Me.lblObservaciones.TabIndex = 0
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaEntrada
        '
        Me.lblFechaEntrada.Location = New System.Drawing.Point(28, 118)
        Me.lblFechaEntrada.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaEntrada.Name = "lblFechaEntrada"
        Me.lblFechaEntrada.Size = New System.Drawing.Size(106, 28)
        Me.lblFechaEntrada.TabIndex = 1
        Me.lblFechaEntrada.Text = "Entrada"
        Me.lblFechaEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaSalida
        '
        Me.lblFechaSalida.Location = New System.Drawing.Point(28, 146)
        Me.lblFechaSalida.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaSalida.Name = "lblFechaSalida"
        Me.lblFechaSalida.Size = New System.Drawing.Size(106, 28)
        Me.lblFechaSalida.TabIndex = 2
        Me.lblFechaSalida.Text = "Salida"
        Me.lblFechaSalida.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_TipoAccion
        '
        Me.lblId_TipoAccion.Location = New System.Drawing.Point(28, 174)
        Me.lblId_TipoAccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_TipoAccion.Name = "lblId_TipoAccion"
        Me.lblId_TipoAccion.Size = New System.Drawing.Size(106, 30)
        Me.lblId_TipoAccion.TabIndex = 3
        Me.lblId_TipoAccion.Text = "Acción"
        Me.lblId_TipoAccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.Location = New System.Drawing.Point(28, 204)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(106, 28)
        Me.lblCantidad.TabIndex = 6
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_MedidaProducto
        '
        Me.lblid_MedidaProducto.Location = New System.Drawing.Point(28, 232)
        Me.lblid_MedidaProducto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_MedidaProducto.Name = "lblid_MedidaProducto"
        Me.lblid_MedidaProducto.Size = New System.Drawing.Size(106, 30)
        Me.lblid_MedidaProducto.TabIndex = 7
        Me.lblid_MedidaProducto.Text = "Medida"
        Me.lblid_MedidaProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'chbSalida
        '
        Me.chbSalida.AutoSize = True
        Me.chbSalida.Location = New System.Drawing.Point(226, 150)
        Me.chbSalida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbSalida.Name = "chbSalida"
        Me.chbSalida.Size = New System.Drawing.Size(15, 14)
        Me.chbSalida.TabIndex = 1000000001
        Me.chbSalida.UseVisualStyleBackColor = True
        '
        'frmEntArticulos_AlmacenNoConforme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(424, 290)
        Me.Controls.Add(Me.chbSalida)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblFechaEntrada)
        Me.Controls.Add(Me.dtpFechaEntrada)
        Me.Controls.Add(Me.cboTipoAccion)
        Me.Controls.Add(Me.lblFechaSalida)
        Me.Controls.Add(Me.dtpFechaSalida)
        Me.Controls.Add(Me.lblId_TipoAccion)
        Me.Controls.Add(Me.butVerId_TipoAccion)
        Me.Controls.Add(Me.butAddid_MedidaProducto)
        Me.Controls.Add(Me.butAddId_TipoAccion)
        Me.Controls.Add(Me.butVerid_MedidaProducto)
        Me.Controls.Add(Me.lblCantidad)
        Me.Controls.Add(Me.cboid_MedidaProducto)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.lblid_MedidaProducto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulos_AlmacenNoConforme"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos_AlmacenNoConforme"
        Me.Controls.SetChildIndex(Me.lblid_MedidaProducto, 0)
        Me.Controls.SetChildIndex(Me.txtCantidad, 0)
        Me.Controls.SetChildIndex(Me.cboid_MedidaProducto, 0)
        Me.Controls.SetChildIndex(Me.lblCantidad, 0)
        Me.Controls.SetChildIndex(Me.butVerid_MedidaProducto, 0)
        Me.Controls.SetChildIndex(Me.butAddId_TipoAccion, 0)
        Me.Controls.SetChildIndex(Me.butAddid_MedidaProducto, 0)
        Me.Controls.SetChildIndex(Me.butVerId_TipoAccion, 0)
        Me.Controls.SetChildIndex(Me.lblId_TipoAccion, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaSalida, 0)
        Me.Controls.SetChildIndex(Me.lblFechaSalida, 0)
        Me.Controls.SetChildIndex(Me.cboTipoAccion, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaEntrada, 0)
        Me.Controls.SetChildIndex(Me.lblFechaEntrada, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.chbSalida, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaEntrada As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaSalida As System.Windows.Forms.DateTimePicker
    Private WithEvents cboTipoAccion As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoAccion As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoAccion As System.Windows.Forms.Button
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboid_MedidaProducto As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_MedidaProducto As System.Windows.Forms.Button
    Private WithEvents butAddid_MedidaProducto As System.Windows.Forms.Button
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblFechaEntrada As System.Windows.Forms.Label
    Private WithEvents lblFechaSalida As System.Windows.Forms.Label
    Private WithEvents lblId_TipoAccion As System.Windows.Forms.Label
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblid_MedidaProducto As System.Windows.Forms.Label

    Private WithEvents chbSalida As System.Windows.Forms.CheckBox
End Class
