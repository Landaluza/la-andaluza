<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProveedores_Articulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProveedores_Articulos))
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.cboArticulo = New System.Windows.Forms.ComboBox()
        Me.chbProveedorPrincipal = New System.Windows.Forms.CheckBox()
        Me.chbProveedorUnico = New System.Windows.Forms.CheckBox()
        Me.txtCantidadPedidoHabitual = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidadPedidoMinima = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPlazoEntrega = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPeriodosServicio = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblProveedorPrincipal = New System.Windows.Forms.Label()
        Me.lblProveedorUnico = New System.Windows.Forms.Label()
        Me.lblCantidadPedidoHabitual = New System.Windows.Forms.Label()
        Me.lblCantidadPedidoMinima = New System.Windows.Forms.Label()
        Me.lblPlazoEntrega = New System.Windows.Forms.Label()
        Me.lblPeriodosServicio = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(146, 37)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(472, 23)
        Me.cboProveedor.TabIndex = 0
        '
        'cboArticulo
        '
        Me.cboArticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboArticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticulo.Location = New System.Drawing.Point(146, 67)
        Me.cboArticulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboArticulo.Name = "cboArticulo"
        Me.cboArticulo.Size = New System.Drawing.Size(472, 23)
        Me.cboArticulo.TabIndex = 1
        '
        'chbProveedorPrincipal
        '
        Me.chbProveedorPrincipal.BackColor = System.Drawing.SystemColors.Control
        Me.chbProveedorPrincipal.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbProveedorPrincipal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbProveedorPrincipal.Location = New System.Drawing.Point(146, 97)
        Me.chbProveedorPrincipal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbProveedorPrincipal.Name = "chbProveedorPrincipal"
        Me.chbProveedorPrincipal.Size = New System.Drawing.Size(180, 20)
        Me.chbProveedorPrincipal.TabIndex = 2
        Me.chbProveedorPrincipal.UseVisualStyleBackColor = False
        '
        'chbProveedorUnico
        '
        Me.chbProveedorUnico.BackColor = System.Drawing.SystemColors.Control
        Me.chbProveedorUnico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbProveedorUnico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbProveedorUnico.Location = New System.Drawing.Point(146, 122)
        Me.chbProveedorUnico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbProveedorUnico.Name = "chbProveedorUnico"
        Me.chbProveedorUnico.Size = New System.Drawing.Size(180, 20)
        Me.chbProveedorUnico.TabIndex = 3
        Me.chbProveedorUnico.UseVisualStyleBackColor = False
        '
        'txtCantidadPedidoHabitual
        '
        Me.txtCantidadPedidoHabitual.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadPedidoHabitual.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadPedidoHabitual.EsUnicoCampo = ""
        Me.txtCantidadPedidoHabitual.EsUnicoCampoID = ""
        Me.txtCantidadPedidoHabitual.EsUnicoID = 0
        Me.txtCantidadPedidoHabitual.EsUnicoTabla = ""
        Me.txtCantidadPedidoHabitual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPedidoHabitual.Location = New System.Drawing.Point(146, 147)
        Me.txtCantidadPedidoHabitual.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidadPedidoHabitual.MaxLength = 9
        Me.txtCantidadPedidoHabitual.Minimo = 0
        Me.txtCantidadPedidoHabitual.Modificado = False
        Me.txtCantidadPedidoHabitual.Name = "txtCantidadPedidoHabitual"
        Me.txtCantidadPedidoHabitual.Numerico_EsNumerico = False
        Me.txtCantidadPedidoHabitual.Numerico_NumeroDoublees = 0
        Me.txtCantidadPedidoHabitual.Numerico_SeparadorMiles = False
        Me.txtCantidadPedidoHabitual.Obligatorio = False
        Me.txtCantidadPedidoHabitual.ParametroID = 0
        Me.txtCantidadPedidoHabitual.Size = New System.Drawing.Size(181, 14)
        Me.txtCantidadPedidoHabitual.TabIndex = 4
        Me.txtCantidadPedidoHabitual.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadPedidoHabitual.ValorMaximo = 0.0R
        Me.txtCantidadPedidoHabitual.ValorMinimo = 0.0R
        '
        'txtCantidadPedidoMinima
        '
        Me.txtCantidadPedidoMinima.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadPedidoMinima.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadPedidoMinima.EsUnicoCampo = ""
        Me.txtCantidadPedidoMinima.EsUnicoCampoID = ""
        Me.txtCantidadPedidoMinima.EsUnicoID = 0
        Me.txtCantidadPedidoMinima.EsUnicoTabla = ""
        Me.txtCantidadPedidoMinima.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPedidoMinima.Location = New System.Drawing.Point(146, 176)
        Me.txtCantidadPedidoMinima.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidadPedidoMinima.MaxLength = 9
        Me.txtCantidadPedidoMinima.Minimo = 0
        Me.txtCantidadPedidoMinima.Modificado = False
        Me.txtCantidadPedidoMinima.Name = "txtCantidadPedidoMinima"
        Me.txtCantidadPedidoMinima.Numerico_EsNumerico = False
        Me.txtCantidadPedidoMinima.Numerico_NumeroDoublees = 0
        Me.txtCantidadPedidoMinima.Numerico_SeparadorMiles = False
        Me.txtCantidadPedidoMinima.Obligatorio = False
        Me.txtCantidadPedidoMinima.ParametroID = 0
        Me.txtCantidadPedidoMinima.Size = New System.Drawing.Size(181, 14)
        Me.txtCantidadPedidoMinima.TabIndex = 5
        Me.txtCantidadPedidoMinima.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadPedidoMinima.ValorMaximo = 0.0R
        Me.txtCantidadPedidoMinima.ValorMinimo = 0.0R
        '
        'txtPlazoEntrega
        '
        Me.txtPlazoEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.txtPlazoEntrega.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPlazoEntrega.EsUnicoCampo = ""
        Me.txtPlazoEntrega.EsUnicoCampoID = ""
        Me.txtPlazoEntrega.EsUnicoID = 0
        Me.txtPlazoEntrega.EsUnicoTabla = ""
        Me.txtPlazoEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPlazoEntrega.Location = New System.Drawing.Point(146, 204)
        Me.txtPlazoEntrega.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPlazoEntrega.MaxLength = 9
        Me.txtPlazoEntrega.Minimo = 0
        Me.txtPlazoEntrega.Modificado = False
        Me.txtPlazoEntrega.Name = "txtPlazoEntrega"
        Me.txtPlazoEntrega.Numerico_EsNumerico = False
        Me.txtPlazoEntrega.Numerico_NumeroDoublees = 0
        Me.txtPlazoEntrega.Numerico_SeparadorMiles = False
        Me.txtPlazoEntrega.Obligatorio = False
        Me.txtPlazoEntrega.ParametroID = 0
        Me.txtPlazoEntrega.Size = New System.Drawing.Size(181, 14)
        Me.txtPlazoEntrega.TabIndex = 6
        Me.txtPlazoEntrega.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPlazoEntrega.ValorMaximo = 0.0R
        Me.txtPlazoEntrega.ValorMinimo = 0.0R
        '
        'txtPeriodosServicio
        '
        Me.txtPeriodosServicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeriodosServicio.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPeriodosServicio.EsUnicoCampo = ""
        Me.txtPeriodosServicio.EsUnicoCampoID = ""
        Me.txtPeriodosServicio.EsUnicoID = 0
        Me.txtPeriodosServicio.EsUnicoTabla = ""
        Me.txtPeriodosServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeriodosServicio.Location = New System.Drawing.Point(146, 232)
        Me.txtPeriodosServicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPeriodosServicio.MaxLength = 9
        Me.txtPeriodosServicio.Minimo = 0
        Me.txtPeriodosServicio.Modificado = False
        Me.txtPeriodosServicio.Name = "txtPeriodosServicio"
        Me.txtPeriodosServicio.Numerico_EsNumerico = False
        Me.txtPeriodosServicio.Numerico_NumeroDoublees = 0
        Me.txtPeriodosServicio.Numerico_SeparadorMiles = False
        Me.txtPeriodosServicio.Obligatorio = False
        Me.txtPeriodosServicio.ParametroID = 0
        Me.txtPeriodosServicio.Size = New System.Drawing.Size(181, 14)
        Me.txtPeriodosServicio.TabIndex = 7
        Me.txtPeriodosServicio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPeriodosServicio.ValorMaximo = 0.0R
        Me.txtPeriodosServicio.ValorMinimo = 0.0R
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
        Me.txtObservaciones.Location = New System.Drawing.Point(146, 260)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(472, 46)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Location = New System.Drawing.Point(22, 34)
        Me.lblProveedorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(118, 30)
        Me.lblProveedorID.TabIndex = 0
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Location = New System.Drawing.Point(22, 64)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(118, 30)
        Me.lblArticuloID.TabIndex = 3
        Me.lblArticuloID.Text = "Articulo"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorPrincipal
        '
        Me.lblProveedorPrincipal.Location = New System.Drawing.Point(22, 94)
        Me.lblProveedorPrincipal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedorPrincipal.Name = "lblProveedorPrincipal"
        Me.lblProveedorPrincipal.Size = New System.Drawing.Size(118, 25)
        Me.lblProveedorPrincipal.TabIndex = 6
        Me.lblProveedorPrincipal.Text = "Proveedor principal"
        Me.lblProveedorPrincipal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorUnico
        '
        Me.lblProveedorUnico.Location = New System.Drawing.Point(22, 119)
        Me.lblProveedorUnico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedorUnico.Name = "lblProveedorUnico"
        Me.lblProveedorUnico.Size = New System.Drawing.Size(118, 25)
        Me.lblProveedorUnico.TabIndex = 7
        Me.lblProveedorUnico.Text = "Proveedor unico"
        Me.lblProveedorUnico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadPedidoHabitual
        '
        Me.lblCantidadPedidoHabitual.Location = New System.Drawing.Point(22, 145)
        Me.lblCantidadPedidoHabitual.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadPedidoHabitual.Name = "lblCantidadPedidoHabitual"
        Me.lblCantidadPedidoHabitual.Size = New System.Drawing.Size(118, 28)
        Me.lblCantidadPedidoHabitual.TabIndex = 8
        Me.lblCantidadPedidoHabitual.Text = "Cantidad pedido habitual"
        Me.lblCantidadPedidoHabitual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadPedidoMinima
        '
        Me.lblCantidadPedidoMinima.Location = New System.Drawing.Point(22, 173)
        Me.lblCantidadPedidoMinima.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadPedidoMinima.Name = "lblCantidadPedidoMinima"
        Me.lblCantidadPedidoMinima.Size = New System.Drawing.Size(118, 28)
        Me.lblCantidadPedidoMinima.TabIndex = 9
        Me.lblCantidadPedidoMinima.Text = "Cantidad pedido minima"
        Me.lblCantidadPedidoMinima.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPlazoEntrega
        '
        Me.lblPlazoEntrega.Location = New System.Drawing.Point(22, 202)
        Me.lblPlazoEntrega.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPlazoEntrega.Name = "lblPlazoEntrega"
        Me.lblPlazoEntrega.Size = New System.Drawing.Size(118, 28)
        Me.lblPlazoEntrega.TabIndex = 10
        Me.lblPlazoEntrega.Text = "Plazo entrega"
        Me.lblPlazoEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPeriodosServicio
        '
        Me.lblPeriodosServicio.Location = New System.Drawing.Point(22, 229)
        Me.lblPeriodosServicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPeriodosServicio.Name = "lblPeriodosServicio"
        Me.lblPeriodosServicio.Size = New System.Drawing.Size(118, 28)
        Me.lblPeriodosServicio.TabIndex = 11
        Me.lblPeriodosServicio.Text = "Periodos servicio"
        Me.lblPeriodosServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(22, 258)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(118, 28)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'frmEntProveedores_Articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(644, 317)
        Me.Controls.Add(Me.lblProveedorID)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.txtCantidadPedidoHabitual)
        Me.Controls.Add(Me.lblArticuloID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboArticulo)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtPeriodosServicio)
        Me.Controls.Add(Me.lblPeriodosServicio)
        Me.Controls.Add(Me.lblProveedorPrincipal)
        Me.Controls.Add(Me.txtPlazoEntrega)
        Me.Controls.Add(Me.chbProveedorPrincipal)
        Me.Controls.Add(Me.lblPlazoEntrega)
        Me.Controls.Add(Me.lblProveedorUnico)
        Me.Controls.Add(Me.txtCantidadPedidoMinima)
        Me.Controls.Add(Me.chbProveedorUnico)
        Me.Controls.Add(Me.lblCantidadPedidoMinima)
        Me.Controls.Add(Me.lblCantidadPedidoHabitual)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntProveedores_Articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Proveedores_Articulos"
        Me.Controls.SetChildIndex(Me.lblCantidadPedidoHabitual, 0)
        Me.Controls.SetChildIndex(Me.lblCantidadPedidoMinima, 0)
        Me.Controls.SetChildIndex(Me.chbProveedorUnico, 0)
        Me.Controls.SetChildIndex(Me.txtCantidadPedidoMinima, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorUnico, 0)
        Me.Controls.SetChildIndex(Me.lblPlazoEntrega, 0)
        Me.Controls.SetChildIndex(Me.chbProveedorPrincipal, 0)
        Me.Controls.SetChildIndex(Me.txtPlazoEntrega, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorPrincipal, 0)
        Me.Controls.SetChildIndex(Me.lblPeriodosServicio, 0)
        Me.Controls.SetChildIndex(Me.txtPeriodosServicio, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboArticulo, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblArticuloID, 0)
        Me.Controls.SetChildIndex(Me.txtCantidadPedidoHabitual, 0)
        Me.Controls.SetChildIndex(Me.cboProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents cboArticulo As System.Windows.Forms.ComboBox
    Private WithEvents chbProveedorPrincipal As System.Windows.Forms.CheckBox
    Private WithEvents chbProveedorUnico As System.Windows.Forms.CheckBox
    Private WithEvents txtCantidadPedidoHabitual As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCantidadPedidoMinima As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPlazoEntrega As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPeriodosServicio As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblProveedorPrincipal As System.Windows.Forms.Label
    Private WithEvents lblProveedorUnico As System.Windows.Forms.Label
    Private WithEvents lblCantidadPedidoHabitual As System.Windows.Forms.Label
    Private WithEvents lblCantidadPedidoMinima As System.Windows.Forms.Label
    Private WithEvents lblPlazoEntrega As System.Windows.Forms.Label
    Private WithEvents lblPeriodosServicio As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
