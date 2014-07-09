<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosProveedoresEntregas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosProveedoresEntregas))
        Me.txtPedidoProveedorEntregaID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidoProveedorDetalleID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPedidoProveedorEntregaID = New System.Windows.Forms.Label()
        Me.lblPedidoProveedorDetalleID = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtPedidoProveedorEntregaID
        '
        Me.txtPedidoProveedorEntregaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorEntregaID.EsUnicoCampo = ""
        Me.txtPedidoProveedorEntregaID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorEntregaID.EsUnicoID = 0
        Me.txtPedidoProveedorEntregaID.EsUnicoTabla = ""
        Me.txtPedidoProveedorEntregaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorEntregaID.Location = New System.Drawing.Point(116, 3)
        Me.txtPedidoProveedorEntregaID.MaxLength = 9
        Me.txtPedidoProveedorEntregaID.Minimo = 0
        Me.txtPedidoProveedorEntregaID.Modificado = False
        Me.txtPedidoProveedorEntregaID.Name = "txtPedidoProveedorEntregaID"
        Me.txtPedidoProveedorEntregaID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorEntregaID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorEntregaID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorEntregaID.Obligatorio = False
        Me.txtPedidoProveedorEntregaID.ParametroID = 0
        Me.txtPedidoProveedorEntregaID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoProveedorEntregaID.TabIndex = 0
        Me.txtPedidoProveedorEntregaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorEntregaID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorEntregaID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorEntregaID.Visible = False
        '
        'txtPedidoProveedorDetalleID
        '
        Me.txtPedidoProveedorDetalleID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorDetalleID.EsUnicoCampo = ""
        Me.txtPedidoProveedorDetalleID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorDetalleID.EsUnicoID = 0
        Me.txtPedidoProveedorDetalleID.EsUnicoTabla = ""
        Me.txtPedidoProveedorDetalleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorDetalleID.Location = New System.Drawing.Point(116, 30)
        Me.txtPedidoProveedorDetalleID.MaxLength = 9
        Me.txtPedidoProveedorDetalleID.Minimo = 0
        Me.txtPedidoProveedorDetalleID.Modificado = False
        Me.txtPedidoProveedorDetalleID.Name = "txtPedidoProveedorDetalleID"
        Me.txtPedidoProveedorDetalleID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorDetalleID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorDetalleID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorDetalleID.Obligatorio = False
        Me.txtPedidoProveedorDetalleID.ParametroID = 0
        Me.txtPedidoProveedorDetalleID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoProveedorDetalleID.TabIndex = 1
        Me.txtPedidoProveedorDetalleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorDetalleID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorDetalleID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorDetalleID.Visible = False
        '
        'txtFecha
        '
        Me.txtFecha.BackColor = System.Drawing.SystemColors.Window
        Me.txtFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFecha.Location = New System.Drawing.Point(116, 57)
        Me.txtFecha.Name = "txtFecha"
        Me.txtFecha.Size = New System.Drawing.Size(95, 21)
        Me.txtFecha.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(116, 84)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = True
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = True
        Me.txtCantidad.Obligatorio = True
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(95, 21)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0R
        Me.txtCantidad.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 2)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(116, 111)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(547, 44)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtPedidosProveedoresDetalle_PedidoProveedorDetalleID
        '
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.EsUnicoCampo = ""
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.EsUnicoCampoID = ""
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.EsUnicoID = 0
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.EsUnicoTabla = ""
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Location = New System.Drawing.Point(116, 161)
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.MaxLength = 9
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Minimo = 0
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Modificado = False
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Name = "txtPedidosProveedoresDetalle_PedidoProveedorDetalleID"
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Numerico_EsNumerico = False
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Numerico_NumeroDoublees = 0
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Numerico_SeparadorMiles = False
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Obligatorio = False
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.ParametroID = 0
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.TabIndex = 5
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.ValorMaximo = 0.0R
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.ValorMinimo = 0.0R
        Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID.Visible = False
        '
        'lblPedidoProveedorEntregaID
        '
        Me.lblPedidoProveedorEntregaID.Location = New System.Drawing.Point(217, 0)
        Me.lblPedidoProveedorEntregaID.Name = "lblPedidoProveedorEntregaID"
        Me.lblPedidoProveedorEntregaID.Size = New System.Drawing.Size(136, 21)
        Me.lblPedidoProveedorEntregaID.TabIndex = 0
        Me.lblPedidoProveedorEntregaID.Text = "PedidoProveedorEntregaID"
        Me.lblPedidoProveedorEntregaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorEntregaID.Visible = False
        '
        'lblPedidoProveedorDetalleID
        '
        Me.lblPedidoProveedorDetalleID.Location = New System.Drawing.Point(217, 27)
        Me.lblPedidoProveedorDetalleID.Name = "lblPedidoProveedorDetalleID"
        Me.lblPedidoProveedorDetalleID.Size = New System.Drawing.Size(136, 21)
        Me.lblPedidoProveedorDetalleID.TabIndex = 1
        Me.lblPedidoProveedorDetalleID.Text = "PedidoProveedorDetalleID"
        Me.lblPedidoProveedorDetalleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorDetalleID.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.Location = New System.Drawing.Point(3, 57)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(107, 21)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblCantidad.Location = New System.Drawing.Point(3, 84)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(107, 21)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblObservaciones.Location = New System.Drawing.Point(3, 122)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(107, 21)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPedidosProveedoresDetalle_PedidoProveedorDetalleID
        '
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.Location = New System.Drawing.Point(217, 158)
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.Name = "lblPedidosProveedoresDetalle_PedidoProveedorDetalleID"
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.Size = New System.Drawing.Size(239, 21)
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.TabIndex = 5
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.Text = "PedidosProveedoresDetalle_PedidoProveedorDetalleID"
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID.Visible = False
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorEntregaID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorDetalleID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtFecha, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtPedidosProveedoresDetalle_PedidoProveedorDetalleID, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorEntregaID, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.lblPedidosProveedoresDetalle_PedidoProveedorDetalleID, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorDetalleID, 3, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(686, 162)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntPedidosProveedoresEntregas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(708, 242)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(549, 242)
        Me.Name = "frmEntPedidosProveedoresEntregas"
        Me.Text = "PedidosProveedoresEntregas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtPedidoProveedorEntregaID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidoProveedorDetalleID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidosProveedoresDetalle_PedidoProveedorDetalleID As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblPedidoProveedorEntregaID As System.Windows.Forms.Label
   Private WithEvents lblPedidoProveedorDetalleID As System.Windows.Forms.Label
   Private WithEvents lblFecha As System.Windows.Forms.Label
   Private WithEvents lblCantidad As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblPedidosProveedoresDetalle_PedidoProveedorDetalleID As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
