<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosClientesMaestros2
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosClientesMaestros2))
        Me.txtPedidoClienteMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboClienteID = New System.Windows.Forms.ComboBox()
        Me.txtNumero = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaServicio = New System.Windows.Forms.DateTimePicker()
        Me.chbServido = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNumeroPedidoCliente = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboPedidoClienteLugarEntregaID = New System.Windows.Forms.ComboBox()
        Me.lblPedidoClienteMaestroID = New System.Windows.Forms.Label()
        Me.lblClienteID = New System.Windows.Forms.Label()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblFechaEmision = New System.Windows.Forms.Label()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.lblServido = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblNumeroPedidoCliente = New System.Windows.Forms.Label()
        Me.lblPedidoClienteLugarEntregaID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpArticulos = New System.Windows.Forms.TabPage()
        Me.tpDocumentos = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtPedidoClienteMaestroID
        '
        Me.txtPedidoClienteMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoClienteMaestroID.EsUnicoCampo = ""
        Me.txtPedidoClienteMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoClienteMaestroID.EsUnicoID = 0
        Me.txtPedidoClienteMaestroID.EsUnicoTabla = ""
        Me.txtPedidoClienteMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoClienteMaestroID.Location = New System.Drawing.Point(270, 4)
        Me.txtPedidoClienteMaestroID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPedidoClienteMaestroID.MaxLength = 9
        Me.txtPedidoClienteMaestroID.Minimo = 0
        Me.txtPedidoClienteMaestroID.Modificado = False
        Me.txtPedidoClienteMaestroID.Name = "txtPedidoClienteMaestroID"
        Me.txtPedidoClienteMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoClienteMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoClienteMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoClienteMaestroID.Obligatorio = False
        Me.txtPedidoClienteMaestroID.ParametroID = 0
        Me.txtPedidoClienteMaestroID.Size = New System.Drawing.Size(73, 24)
        Me.txtPedidoClienteMaestroID.TabIndex = 0
        Me.txtPedidoClienteMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoClienteMaestroID.ValorMaximo = 0.0!
        Me.txtPedidoClienteMaestroID.ValorMinimo = 0.0!
        Me.txtPedidoClienteMaestroID.Visible = False
        '
        'cboClienteID
        '
        Me.cboClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClienteID.Location = New System.Drawing.Point(270, 36)
        Me.cboClienteID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboClienteID.Name = "cboClienteID"
        Me.cboClienteID.Size = New System.Drawing.Size(659, 26)
        Me.cboClienteID.TabIndex = 1
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.EsUnicoCampo = ""
        Me.txtNumero.EsUnicoCampoID = ""
        Me.txtNumero.EsUnicoID = 0
        Me.txtNumero.EsUnicoTabla = ""
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(270, 70)
        Me.txtNumero.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumero.MaxLength = 9
        Me.txtNumero.Minimo = 0
        Me.txtNumero.Modificado = False
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Numerico_EsNumerico = True
        Me.txtNumero.Numerico_NumeroDoublees = 0
        Me.txtNumero.Numerico_SeparadorMiles = False
        Me.txtNumero.Obligatorio = False
        Me.txtNumero.ParametroID = 0
        Me.txtNumero.Size = New System.Drawing.Size(125, 24)
        Me.txtNumero.TabIndex = 2
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumero.ValorMaximo = 0.0!
        Me.txtNumero.ValorMinimo = 0.0!
        '
        'dtpFechaEmision
        '
        Me.dtpFechaEmision.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaEmision.Location = New System.Drawing.Point(270, 102)
        Me.dtpFechaEmision.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaEmision.Name = "dtpFechaEmision"
        Me.dtpFechaEmision.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaEmision.TabIndex = 3
        '
        'dtpFechaServicio
        '
        Me.dtpFechaServicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaServicio.Location = New System.Drawing.Point(270, 134)
        Me.dtpFechaServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaServicio.Name = "dtpFechaServicio"
        Me.dtpFechaServicio.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaServicio.TabIndex = 4
        '
        'chbServido
        '
        Me.chbServido.BackColor = System.Drawing.SystemColors.Control
        Me.chbServido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbServido.Location = New System.Drawing.Point(270, 166)
        Me.chbServido.Margin = New System.Windows.Forms.Padding(4)
        Me.chbServido.Name = "chbServido"
        Me.chbServido.Size = New System.Drawing.Size(21, 26)
        Me.chbServido.TabIndex = 5
        Me.chbServido.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(270, 200)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(804, 24)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'txtNumeroPedidoCliente
        '
        Me.txtNumeroPedidoCliente.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumeroPedidoCliente.EsUnicoCampo = ""
        Me.txtNumeroPedidoCliente.EsUnicoCampoID = ""
        Me.txtNumeroPedidoCliente.EsUnicoID = 0
        Me.txtNumeroPedidoCliente.EsUnicoTabla = ""
        Me.txtNumeroPedidoCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumeroPedidoCliente.Location = New System.Drawing.Point(270, 232)
        Me.txtNumeroPedidoCliente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNumeroPedidoCliente.MaxLength = 9
        Me.txtNumeroPedidoCliente.Minimo = 0
        Me.txtNumeroPedidoCliente.Modificado = False
        Me.txtNumeroPedidoCliente.Name = "txtNumeroPedidoCliente"
        Me.txtNumeroPedidoCliente.Numerico_EsNumerico = True
        Me.txtNumeroPedidoCliente.Numerico_NumeroDoublees = 0
        Me.txtNumeroPedidoCliente.Numerico_SeparadorMiles = False
        Me.txtNumeroPedidoCliente.Obligatorio = False
        Me.txtNumeroPedidoCliente.ParametroID = 0
        Me.txtNumeroPedidoCliente.Size = New System.Drawing.Size(125, 24)
        Me.txtNumeroPedidoCliente.TabIndex = 7
        Me.txtNumeroPedidoCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumeroPedidoCliente.ValorMaximo = 0.0!
        Me.txtNumeroPedidoCliente.ValorMinimo = 0.0!
        '
        'cboPedidoClienteLugarEntregaID
        '
        Me.cboPedidoClienteLugarEntregaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPedidoClienteLugarEntregaID.Location = New System.Drawing.Point(270, 264)
        Me.cboPedidoClienteLugarEntregaID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboPedidoClienteLugarEntregaID.Name = "cboPedidoClienteLugarEntregaID"
        Me.cboPedidoClienteLugarEntregaID.Size = New System.Drawing.Size(339, 26)
        Me.cboPedidoClienteLugarEntregaID.TabIndex = 8
        '
        'lblPedidoClienteMaestroID
        '
        Me.lblPedidoClienteMaestroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoClienteMaestroID.Location = New System.Drawing.Point(50, 0)
        Me.lblPedidoClienteMaestroID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedidoClienteMaestroID.Name = "lblPedidoClienteMaestroID"
        Me.lblPedidoClienteMaestroID.Size = New System.Drawing.Size(212, 26)
        Me.lblPedidoClienteMaestroID.TabIndex = 0
        Me.lblPedidoClienteMaestroID.Text = "PedidoClienteMaestroID"
        Me.lblPedidoClienteMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoClienteMaestroID.Visible = False
        '
        'lblClienteID
        '
        Me.lblClienteID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblClienteID.Location = New System.Drawing.Point(50, 32)
        Me.lblClienteID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblClienteID.Name = "lblClienteID"
        Me.lblClienteID.Size = New System.Drawing.Size(212, 26)
        Me.lblClienteID.TabIndex = 1
        Me.lblClienteID.Text = "Cliente"
        Me.lblClienteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumero
        '
        Me.lblNumero.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNumero.Location = New System.Drawing.Point(50, 66)
        Me.lblNumero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(212, 26)
        Me.lblNumero.TabIndex = 2
        Me.lblNumero.Text = "Numero"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaEmision.Location = New System.Drawing.Point(50, 98)
        Me.lblFechaEmision.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(212, 26)
        Me.lblFechaEmision.TabIndex = 3
        Me.lblFechaEmision.Text = "Emision"
        Me.lblFechaEmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaServicio.Location = New System.Drawing.Point(50, 130)
        Me.lblFechaServicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(212, 26)
        Me.lblFechaServicio.TabIndex = 4
        Me.lblFechaServicio.Text = "Servicio"
        Me.lblFechaServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServido
        '
        Me.lblServido.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblServido.Location = New System.Drawing.Point(50, 162)
        Me.lblServido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServido.Name = "lblServido"
        Me.lblServido.Size = New System.Drawing.Size(212, 26)
        Me.lblServido.TabIndex = 5
        Me.lblServido.Text = "Servido"
        Me.lblServido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(50, 196)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(212, 26)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNumeroPedidoCliente
        '
        Me.lblNumeroPedidoCliente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblNumeroPedidoCliente.Location = New System.Drawing.Point(50, 228)
        Me.lblNumeroPedidoCliente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumeroPedidoCliente.Name = "lblNumeroPedidoCliente"
        Me.lblNumeroPedidoCliente.Size = New System.Drawing.Size(212, 26)
        Me.lblNumeroPedidoCliente.TabIndex = 7
        Me.lblNumeroPedidoCliente.Text = "Numero pedido"
        Me.lblNumeroPedidoCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPedidoClienteLugarEntregaID
        '
        Me.lblPedidoClienteLugarEntregaID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoClienteLugarEntregaID.Location = New System.Drawing.Point(50, 260)
        Me.lblPedidoClienteLugarEntregaID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedidoClienteLugarEntregaID.Name = "lblPedidoClienteLugarEntregaID"
        Me.lblPedidoClienteLugarEntregaID.Size = New System.Drawing.Size(212, 26)
        Me.lblPedidoClienteLugarEntregaID.TabIndex = 8
        Me.lblPedidoClienteLugarEntregaID.Text = "Lugar de entrega"
        Me.lblPedidoClienteLugarEntregaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblPedidoClienteMaestroID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoClienteMaestroID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblClienteID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboClienteID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblNumero, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtNumero, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFechaEmision, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaEmision, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFechaServicio, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaServicio, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblServido, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.chbServido, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblNumeroPedidoCliente, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtNumeroPedidoCliente, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoClienteLugarEntregaID, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.cboPedidoClienteLugarEntregaID, 2, 8)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 10
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1101, 304)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpArticulos)
        Me.TabControl1.Controls.Add(Me.tpDocumentos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 329)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1101, 352)
        Me.TabControl1.TabIndex = 1000000003
        '
        'tbpArticulos
        '
        Me.tbpArticulos.Location = New System.Drawing.Point(4, 25)
        Me.tbpArticulos.Margin = New System.Windows.Forms.Padding(4)
        Me.tbpArticulos.Name = "tbpArticulos"
        Me.tbpArticulos.Padding = New System.Windows.Forms.Padding(4)
        Me.tbpArticulos.Size = New System.Drawing.Size(1093, 323)
        Me.tbpArticulos.TabIndex = 0
        Me.tbpArticulos.Text = "Articulos"
        Me.tbpArticulos.UseVisualStyleBackColor = True
        '
        'tpDocumentos
        '
        Me.tpDocumentos.Location = New System.Drawing.Point(4, 25)
        Me.tpDocumentos.Margin = New System.Windows.Forms.Padding(4)
        Me.tpDocumentos.Name = "tpDocumentos"
        Me.tpDocumentos.Size = New System.Drawing.Size(1093, 323)
        Me.tpDocumentos.TabIndex = 1
        Me.tpDocumentos.Text = "Documentos"
        Me.tpDocumentos.UseVisualStyleBackColor = True
        '
        'frmEntPedidosClientesMaestros2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1101, 681)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPedidosClientesMaestros2"
        Me.Text = "Pedido cliente"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtPedidoClienteMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboClienteID As System.Windows.Forms.ComboBox
    Private WithEvents txtNumero As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaEmision As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaServicio As System.Windows.Forms.DateTimePicker
    Private WithEvents chbServido As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNumeroPedidoCliente As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboPedidoClienteLugarEntregaID As System.Windows.Forms.ComboBox
    Private WithEvents lblPedidoClienteMaestroID As System.Windows.Forms.Label
    Private WithEvents lblClienteID As System.Windows.Forms.Label
    Private WithEvents lblNumero As System.Windows.Forms.Label
    Private WithEvents lblFechaEmision As System.Windows.Forms.Label
    Private WithEvents lblFechaServicio As System.Windows.Forms.Label
    Private WithEvents lblServido As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblNumeroPedidoCliente As System.Windows.Forms.Label
    Private WithEvents lblPedidoClienteLugarEntregaID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tbpArticulos As System.Windows.Forms.TabPage
    Private WithEvents tpDocumentos As System.Windows.Forms.TabPage
End Class
