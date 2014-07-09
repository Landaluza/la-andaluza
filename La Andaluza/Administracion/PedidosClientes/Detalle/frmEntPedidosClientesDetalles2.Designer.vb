<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosClientesDetalles2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosClientesDetalles2))
        Me.txtPedidoClienteDatalleID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidoclienteMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloID = New System.Windows.Forms.ComboBox()
        Me.txtCantidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbServido = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaServicio = New System.Windows.Forms.DateTimePicker()
        Me.lblPedidoClienteDatalleID = New System.Windows.Forms.Label()
        Me.lblPedidoclienteMaestroID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblServido = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtPedidoClienteDatalleID
        '
        Me.txtPedidoClienteDatalleID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoClienteDatalleID.EsUnicoCampo = ""
        Me.txtPedidoClienteDatalleID.EsUnicoCampoID = ""
        Me.txtPedidoClienteDatalleID.EsUnicoID = 0
        Me.txtPedidoClienteDatalleID.EsUnicoTabla = ""
        Me.txtPedidoClienteDatalleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoClienteDatalleID.Location = New System.Drawing.Point(228, 4)
        Me.txtPedidoClienteDatalleID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPedidoClienteDatalleID.MaxLength = 9
        Me.txtPedidoClienteDatalleID.Minimo = 0
        Me.txtPedidoClienteDatalleID.Modificado = False
        Me.txtPedidoClienteDatalleID.Name = "txtPedidoClienteDatalleID"
        Me.txtPedidoClienteDatalleID.Numerico_EsNumerico = False
        Me.txtPedidoClienteDatalleID.Numerico_NumeroDoublees = 0
        Me.txtPedidoClienteDatalleID.Numerico_SeparadorMiles = False
        Me.txtPedidoClienteDatalleID.Obligatorio = False
        Me.txtPedidoClienteDatalleID.ParametroID = 0
        Me.txtPedidoClienteDatalleID.Size = New System.Drawing.Size(73, 24)
        Me.txtPedidoClienteDatalleID.TabIndex = 0
        Me.txtPedidoClienteDatalleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoClienteDatalleID.ValorMaximo = 0.0!
        Me.txtPedidoClienteDatalleID.ValorMinimo = 0.0!
        Me.txtPedidoClienteDatalleID.Visible = False
        '
        'txtPedidoclienteMaestroID
        '
        Me.txtPedidoclienteMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoclienteMaestroID.EsUnicoCampo = ""
        Me.txtPedidoclienteMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoclienteMaestroID.EsUnicoID = 0
        Me.txtPedidoclienteMaestroID.EsUnicoTabla = ""
        Me.txtPedidoclienteMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoclienteMaestroID.Location = New System.Drawing.Point(228, 36)
        Me.txtPedidoclienteMaestroID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPedidoclienteMaestroID.MaxLength = 9
        Me.txtPedidoclienteMaestroID.Minimo = 0
        Me.txtPedidoclienteMaestroID.Modificado = False
        Me.txtPedidoclienteMaestroID.Name = "txtPedidoclienteMaestroID"
        Me.txtPedidoclienteMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoclienteMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoclienteMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoclienteMaestroID.Obligatorio = False
        Me.txtPedidoclienteMaestroID.ParametroID = 0
        Me.txtPedidoclienteMaestroID.Size = New System.Drawing.Size(73, 24)
        Me.txtPedidoclienteMaestroID.TabIndex = 1
        Me.txtPedidoclienteMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoclienteMaestroID.ValorMaximo = 0.0!
        Me.txtPedidoclienteMaestroID.ValorMinimo = 0.0!
        '
        'cboArticuloID
        '
        Me.cboArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloID.Location = New System.Drawing.Point(228, 68)
        Me.cboArticuloID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloID.Name = "cboArticuloID"
        Me.cboArticuloID.Size = New System.Drawing.Size(656, 26)
        Me.cboArticuloID.TabIndex = 2
        '
        'txtCantidad
        '
        Me.txtCantidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidad.EsUnicoCampo = ""
        Me.txtCantidad.EsUnicoCampoID = ""
        Me.txtCantidad.EsUnicoID = 0
        Me.txtCantidad.EsUnicoTabla = ""
        Me.txtCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidad.Location = New System.Drawing.Point(228, 102)
        Me.txtCantidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidad.MaxLength = 9
        Me.txtCantidad.Minimo = 0
        Me.txtCantidad.Modificado = False
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Numerico_EsNumerico = False
        Me.txtCantidad.Numerico_NumeroDoublees = 0
        Me.txtCantidad.Numerico_SeparadorMiles = False
        Me.txtCantidad.Obligatorio = False
        Me.txtCantidad.ParametroID = 0
        Me.txtCantidad.Size = New System.Drawing.Size(73, 24)
        Me.txtCantidad.TabIndex = 3
        Me.txtCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidad.ValorMaximo = 0.0!
        Me.txtCantidad.ValorMinimo = 0.0!
        '
        'chbServido
        '
        Me.chbServido.BackColor = System.Drawing.SystemColors.Control
        Me.chbServido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbServido.Location = New System.Drawing.Point(228, 134)
        Me.chbServido.Margin = New System.Windows.Forms.Padding(4)
        Me.chbServido.Name = "chbServido"
        Me.chbServido.Size = New System.Drawing.Size(21, 26)
        Me.chbServido.TabIndex = 4
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
        Me.txtObservaciones.Location = New System.Drawing.Point(228, 168)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(656, 24)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'dtpFechaServicio
        '
        Me.dtpFechaServicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaServicio.Location = New System.Drawing.Point(228, 200)
        Me.dtpFechaServicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaServicio.Name = "dtpFechaServicio"
        Me.dtpFechaServicio.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaServicio.TabIndex = 6
        '
        'lblPedidoClienteDatalleID
        '
        Me.lblPedidoClienteDatalleID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoClienteDatalleID.Location = New System.Drawing.Point(43, 0)
        Me.lblPedidoClienteDatalleID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedidoClienteDatalleID.Name = "lblPedidoClienteDatalleID"
        Me.lblPedidoClienteDatalleID.Size = New System.Drawing.Size(177, 26)
        Me.lblPedidoClienteDatalleID.TabIndex = 0
        Me.lblPedidoClienteDatalleID.Text = "PedidoClienteDatalleID"
        Me.lblPedidoClienteDatalleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoClienteDatalleID.Visible = False
        '
        'lblPedidoclienteMaestroID
        '
        Me.lblPedidoclienteMaestroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoclienteMaestroID.Location = New System.Drawing.Point(43, 32)
        Me.lblPedidoclienteMaestroID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPedidoclienteMaestroID.Name = "lblPedidoclienteMaestroID"
        Me.lblPedidoclienteMaestroID.Size = New System.Drawing.Size(177, 26)
        Me.lblPedidoclienteMaestroID.TabIndex = 1
        Me.lblPedidoclienteMaestroID.Text = "PedidoclienteMaestroID"
        Me.lblPedidoclienteMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloID.Location = New System.Drawing.Point(43, 64)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(177, 26)
        Me.lblArticuloID.TabIndex = 2
        Me.lblArticuloID.Text = "ArticuloID"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCantidad.Location = New System.Drawing.Point(43, 98)
        Me.lblCantidad.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(177, 26)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServido
        '
        Me.lblServido.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblServido.Location = New System.Drawing.Point(43, 130)
        Me.lblServido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServido.Name = "lblServido"
        Me.lblServido.Size = New System.Drawing.Size(177, 26)
        Me.lblServido.TabIndex = 4
        Me.lblServido.Text = "Servido"
        Me.lblServido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(43, 164)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(177, 26)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaServicio.Location = New System.Drawing.Point(43, 196)
        Me.lblFechaServicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(177, 26)
        Me.lblFechaServicio.TabIndex = 6
        Me.lblFechaServicio.Text = "FechaServicio"
        Me.lblFechaServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblPedidoClienteDatalleID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoClienteDatalleID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoclienteMaestroID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoclienteMaestroID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCantidad, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblServido, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbServido, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblFechaServicio, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaServicio, 2, 6)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(929, 235)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntPedidosClientesDetalles2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(929, 334)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(509, 328)
        Me.Name = "frmEntPedidosClientesDetalles2"
        Me.Text = "Detalle pedido"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtPedidoClienteDatalleID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidoclienteMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloID As System.Windows.Forms.ComboBox
    Private WithEvents txtCantidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbServido As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaServicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblPedidoClienteDatalleID As System.Windows.Forms.Label
    Private WithEvents lblPedidoclienteMaestroID As System.Windows.Forms.Label
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblServido As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblFechaServicio As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
