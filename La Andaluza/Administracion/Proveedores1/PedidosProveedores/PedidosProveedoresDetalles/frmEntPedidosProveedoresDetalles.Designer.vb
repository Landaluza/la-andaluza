<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosProveedoresDetalles
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosProveedoresDetalles))
        Me.txtPedidoProveedorDetalleID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidoProveedorMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtArticuloID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFechaServicio = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEstadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPedidoProveedorDetalleID = New System.Windows.Forms.Label()
        Me.lblPedidoProveedorMaestroID = New System.Windows.Forms.Label()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblCantidad = New System.Windows.Forms.Label()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblEstadoID = New System.Windows.Forms.Label()
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.cboArticulos = New System.Windows.Forms.ComboBox()
        Me.cboUnidades = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lArticulosObservaciones = New System.Windows.Forms.Label()
        Me.txtCantidadPedida = New System.Windows.Forms.TextBox()
        Me.txtCantidadServida = New System.Windows.Forms.TextBox()
        Me.txtCAntidadRetante = New System.Windows.Forms.TextBox()
        Me.btnAddUnidad = New System.Windows.Forms.Button()
        Me.grbDetalles = New System.Windows.Forms.GroupBox()
        Me.dgvNivel1 = New System.Windows.Forms.DataGridView()
        Me.bdnNivel1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.bdnNivel1Delete = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bdnNivel1Add = New System.Windows.Forms.ToolStripButton()
        Me.bdnNivel1Modificar = New System.Windows.Forms.ToolStripButton()
        Me.bdsNivel1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.grbDetalles.SuspendLayout()
        CType(Me.dgvNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdnNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNivel1.SuspendLayout()
        CType(Me.bdsNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4)
        '
        'txtPedidoProveedorDetalleID
        '
        Me.txtPedidoProveedorDetalleID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorDetalleID.EsUnicoCampo = ""
        Me.txtPedidoProveedorDetalleID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorDetalleID.EsUnicoID = 0
        Me.txtPedidoProveedorDetalleID.EsUnicoTabla = ""
        Me.txtPedidoProveedorDetalleID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorDetalleID.Location = New System.Drawing.Point(147, 3)
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
        Me.txtPedidoProveedorDetalleID.TabIndex = 0
        Me.txtPedidoProveedorDetalleID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorDetalleID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorDetalleID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorDetalleID.Visible = False
        '
        'txtPedidoProveedorMaestroID
        '
        Me.txtPedidoProveedorMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorMaestroID.EsUnicoCampo = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoID = 0
        Me.txtPedidoProveedorMaestroID.EsUnicoTabla = ""
        Me.txtPedidoProveedorMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorMaestroID.Location = New System.Drawing.Point(147, 30)
        Me.txtPedidoProveedorMaestroID.MaxLength = 9
        Me.txtPedidoProveedorMaestroID.Minimo = 0
        Me.txtPedidoProveedorMaestroID.Modificado = False
        Me.txtPedidoProveedorMaestroID.Name = "txtPedidoProveedorMaestroID"
        Me.txtPedidoProveedorMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorMaestroID.Obligatorio = False
        Me.txtPedidoProveedorMaestroID.ParametroID = 0
        Me.txtPedidoProveedorMaestroID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoProveedorMaestroID.TabIndex = 1
        Me.txtPedidoProveedorMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorMaestroID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorMaestroID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorMaestroID.Visible = False
        '
        'txtArticuloID
        '
        Me.txtArticuloID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloID.EsUnicoCampo = ""
        Me.txtArticuloID.EsUnicoCampoID = ""
        Me.txtArticuloID.EsUnicoID = 0
        Me.txtArticuloID.EsUnicoTabla = ""
        Me.txtArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloID.Location = New System.Drawing.Point(337, 30)
        Me.txtArticuloID.MaxLength = 9
        Me.txtArticuloID.Minimo = 0
        Me.txtArticuloID.Modificado = False
        Me.txtArticuloID.Name = "txtArticuloID"
        Me.txtArticuloID.Numerico_EsNumerico = False
        Me.txtArticuloID.Numerico_NumeroDoublees = 0
        Me.txtArticuloID.Numerico_SeparadorMiles = False
        Me.txtArticuloID.Obligatorio = False
        Me.txtArticuloID.ParametroID = 0
        Me.txtArticuloID.Size = New System.Drawing.Size(56, 21)
        Me.txtArticuloID.TabIndex = 2
        Me.txtArticuloID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloID.ValorMaximo = 0.0R
        Me.txtArticuloID.ValorMinimo = 0.0R
        Me.txtArticuloID.Visible = False
        '
        'txtFechaServicio
        '
        Me.txtFechaServicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaServicio.Location = New System.Drawing.Point(147, 159)
        Me.txtFechaServicio.Name = "txtFechaServicio"
        Me.txtFechaServicio.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaServicio.TabIndex = 4
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(147, 186)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(669, 14)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtEstadoID
        '
        Me.txtEstadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstadoID.EsUnicoCampo = ""
        Me.txtEstadoID.EsUnicoCampoID = ""
        Me.txtEstadoID.EsUnicoID = 0
        Me.txtEstadoID.EsUnicoTabla = ""
        Me.txtEstadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoID.Location = New System.Drawing.Point(508, 217)
        Me.txtEstadoID.MaxLength = 9
        Me.txtEstadoID.Minimo = 0
        Me.txtEstadoID.Modificado = False
        Me.txtEstadoID.Name = "txtEstadoID"
        Me.txtEstadoID.Numerico_EsNumerico = False
        Me.txtEstadoID.Numerico_NumeroDoublees = 0
        Me.txtEstadoID.Numerico_SeparadorMiles = False
        Me.txtEstadoID.Obligatorio = False
        Me.txtEstadoID.ParametroID = 0
        Me.txtEstadoID.Size = New System.Drawing.Size(56, 21)
        Me.txtEstadoID.TabIndex = 6
        Me.txtEstadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEstadoID.ValorMaximo = 0.0R
        Me.txtEstadoID.ValorMinimo = 0.0R
        Me.txtEstadoID.Visible = False
        '
        'txtPedidosProveedoresMaestro_PedidoProveedorMaestroID
        '
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.EsUnicoCampo = ""
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.EsUnicoCampoID = ""
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.EsUnicoID = 0
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.EsUnicoTabla = ""
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Location = New System.Drawing.Point(147, 247)
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.MaxLength = 9
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Minimo = 0
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Modificado = False
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Name = "txtPedidosProveedoresMaestro_PedidoProveedorMaestroID"
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Numerico_EsNumerico = False
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Obligatorio = False
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.ParametroID = 0
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.TabIndex = 3
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.ValorMaximo = 0.0R
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.ValorMinimo = 0.0R
        Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID.Visible = False
        '
        'lblPedidoProveedorDetalleID
        '
        Me.lblPedidoProveedorDetalleID.Location = New System.Drawing.Point(3, 0)
        Me.lblPedidoProveedorDetalleID.Name = "lblPedidoProveedorDetalleID"
        Me.lblPedidoProveedorDetalleID.Size = New System.Drawing.Size(135, 21)
        Me.lblPedidoProveedorDetalleID.TabIndex = 0
        Me.lblPedidoProveedorDetalleID.Text = "PedidoProveedorDetalleID"
        Me.lblPedidoProveedorDetalleID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorDetalleID.Visible = False
        '
        'lblPedidoProveedorMaestroID
        '
        Me.lblPedidoProveedorMaestroID.Location = New System.Drawing.Point(3, 27)
        Me.lblPedidoProveedorMaestroID.Name = "lblPedidoProveedorMaestroID"
        Me.lblPedidoProveedorMaestroID.Size = New System.Drawing.Size(138, 21)
        Me.lblPedidoProveedorMaestroID.TabIndex = 1
        Me.lblPedidoProveedorMaestroID.Text = "PedidoProveedorMaestroID"
        Me.lblPedidoProveedorMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorMaestroID.Visible = False
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblArticuloID.Location = New System.Drawing.Point(32, 54)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(109, 21)
        Me.lblArticuloID.TabIndex = 2
        Me.lblArticuloID.Text = "Articulo"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidad
        '
        Me.lblCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCantidad.Location = New System.Drawing.Point(32, 81)
        Me.lblCantidad.Name = "lblCantidad"
        Me.lblCantidad.Size = New System.Drawing.Size(109, 21)
        Me.lblCantidad.TabIndex = 3
        Me.lblCantidad.Text = "Cantidad pedida"
        Me.lblCantidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaServicio.Location = New System.Drawing.Point(32, 156)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(109, 21)
        Me.lblFechaServicio.TabIndex = 4
        Me.lblFechaServicio.Text = "FechaServicio"
        Me.lblFechaServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblObservaciones.Location = New System.Drawing.Point(32, 183)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(109, 21)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstadoID
        '
        Me.lblEstadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstadoID.Location = New System.Drawing.Point(32, 214)
        Me.lblEstadoID.Name = "lblEstadoID"
        Me.lblEstadoID.Size = New System.Drawing.Size(109, 21)
        Me.lblEstadoID.TabIndex = 6
        Me.lblEstadoID.Text = "Estado"
        Me.lblEstadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPedidosProveedoresMaestro_PedidoProveedorMaestroID
        '
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.tlpMiddle.SetColumnSpan(Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID, 3)
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Location = New System.Drawing.Point(274, 258)
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Name = "lblPedidosProveedoresMaestro_PedidoProveedorMaestroID"
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Size = New System.Drawing.Size(286, 8)
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.TabIndex = 7
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Text = "PedidosProveedoresMaestro_PedidoProveedorMaestroID"
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID.Visible = False
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 6
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorDetalleID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorMaestroID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboArticulos, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.cboUnidades, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.Label2, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorDetalleID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorMaestroID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.Label1, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtPedidosProveedoresMaestro_PedidoProveedorMaestroID, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.cboEstados, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lblEstadoID, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.txtFechaServicio, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.lblFechaServicio, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.Label3, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.lblPedidosProveedoresMaestro_PedidoProveedorMaestroID, 3, 10)
        Me.tlpMiddle.Controls.Add(Me.lblCantidad, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtEstadoID, 5, 9)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloID, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lArticulosObservaciones, 5, 2)
        Me.tlpMiddle.Controls.Add(Me.txtCantidadPedida, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.txtCantidadServida, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtCAntidadRetante, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.btnAddUnidad, 5, 3)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 11
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30.0!))
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(831, 281)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'cboArticulos
        '
        Me.tlpMiddle.SetColumnSpan(Me.cboArticulos, 3)
        Me.cboArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboArticulos.FormattingEnabled = True
        Me.cboArticulos.Location = New System.Drawing.Point(147, 57)
        Me.cboArticulos.Name = "cboArticulos"
        Me.cboArticulos.Size = New System.Drawing.Size(355, 21)
        Me.cboArticulos.TabIndex = 0
        '
        'cboUnidades
        '
        Me.cboUnidades.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUnidades.FormattingEnabled = True
        Me.cboUnidades.Location = New System.Drawing.Point(337, 84)
        Me.cboUnidades.Name = "cboUnidades"
        Me.cboUnidades.Size = New System.Drawing.Size(165, 21)
        Me.cboUnidades.TabIndex = 1000000075
        '
        'Label2
        '
        Me.Label2.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label2.Location = New System.Drawing.Point(274, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 21)
        Me.Label2.TabIndex = 1000000076
        Me.Label2.Text = "Unidades"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label1.Location = New System.Drawing.Point(52, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 21)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cantidad servida"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEstados
        '
        Me.cboEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Location = New System.Drawing.Point(147, 217)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(121, 21)
        Me.cboEstados.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.Location = New System.Drawing.Point(32, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(109, 21)
        Me.Label3.TabIndex = 1000000077
        Me.Label3.Text = "Cantidad restante"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lArticulosObservaciones
        '
        Me.lArticulosObservaciones.AutoSize = True
        Me.lArticulosObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lArticulosObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lArticulosObservaciones.Location = New System.Drawing.Point(507, 54)
        Me.lArticulosObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lArticulosObservaciones.Name = "lArticulosObservaciones"
        Me.lArticulosObservaciones.Size = New System.Drawing.Size(322, 27)
        Me.lArticulosObservaciones.TabIndex = 1000000079
        Me.lArticulosObservaciones.Text = "Label4"
        '
        'txtCantidadPedida
        '
        Me.txtCantidadPedida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadPedida.Location = New System.Drawing.Point(146, 83)
        Me.txtCantidadPedida.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadPedida.Name = "txtCantidadPedida"
        Me.txtCantidadPedida.Size = New System.Drawing.Size(76, 13)
        Me.txtCantidadPedida.TabIndex = 1000000080
        '
        'txtCantidadServida
        '
        Me.txtCantidadServida.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCantidadServida.Location = New System.Drawing.Point(146, 110)
        Me.txtCantidadServida.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCantidadServida.Name = "txtCantidadServida"
        Me.txtCantidadServida.Size = New System.Drawing.Size(76, 13)
        Me.txtCantidadServida.TabIndex = 1000000081
        '
        'txtCAntidadRetante
        '
        Me.txtCAntidadRetante.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCAntidadRetante.Location = New System.Drawing.Point(146, 134)
        Me.txtCAntidadRetante.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCAntidadRetante.Name = "txtCAntidadRetante"
        Me.txtCAntidadRetante.Size = New System.Drawing.Size(76, 13)
        Me.txtCAntidadRetante.TabIndex = 1000000082
        '
        'btnAddUnidad
        '
        Me.btnAddUnidad.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddUnidad.FlatAppearance.BorderSize = 0
        Me.btnAddUnidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddUnidad.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnAddUnidad.Location = New System.Drawing.Point(508, 84)
        Me.btnAddUnidad.Name = "btnAddUnidad"
        Me.btnAddUnidad.Size = New System.Drawing.Size(26, 21)
        Me.btnAddUnidad.TabIndex = 1000000083
        Me.btnAddUnidad.UseVisualStyleBackColor = True
        '
        'grbDetalles
        '
        Me.grbDetalles.Controls.Add(Me.dgvNivel1)
        Me.grbDetalles.Controls.Add(Me.bdnNivel1)
        Me.grbDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grbDetalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbDetalles.Location = New System.Drawing.Point(0, 306)
        Me.grbDetalles.Name = "grbDetalles"
        Me.grbDetalles.Size = New System.Drawing.Size(831, 440)
        Me.grbDetalles.TabIndex = 1000000074
        Me.grbDetalles.TabStop = False
        Me.grbDetalles.Text = "Entregas del articulo."
        '
        'dgvNivel1
        '
        Me.dgvNivel1.AllowUserToAddRows = False
        Me.dgvNivel1.AllowUserToDeleteRows = False
        Me.dgvNivel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNivel1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNivel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNivel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNivel1.Location = New System.Drawing.Point(3, 42)
        Me.dgvNivel1.Name = "dgvNivel1"
        Me.dgvNivel1.ReadOnly = True
        Me.dgvNivel1.Size = New System.Drawing.Size(825, 395)
        Me.dgvNivel1.TabIndex = 13
        '
        'bdnNivel1
        '
        Me.bdnNivel1.AddNewItem = Me.BindingNavigatorCountItem
        Me.bdnNivel1.CountItem = Me.BindingNavigatorCountItem1
        Me.bdnNivel1.DeleteItem = Me.bdnNivel1Delete
        Me.bdnNivel1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bdnNivel1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.bdnNivel1Add, Me.bdnNivel1Modificar, Me.bdnNivel1Delete})
        Me.bdnNivel1.Location = New System.Drawing.Point(3, 17)
        Me.bdnNivel1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bdnNivel1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bdnNivel1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bdnNivel1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bdnNivel1.Name = "bdnNivel1"
        Me.bdnNivel1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bdnNivel1.Size = New System.Drawing.Size(825, 25)
        Me.bdnNivel1.TabIndex = 1000000073
        Me.bdnNivel1.Text = "BindingNavigator1"
        '
        'BindingNavigatorCountItem1
        '
        Me.BindingNavigatorCountItem1.Name = "BindingNavigatorCountItem1"
        Me.BindingNavigatorCountItem1.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem1.Text = "de {0}"
        Me.BindingNavigatorCountItem1.ToolTipText = "Total number of items"
        '
        'bdnNivel1Delete
        '
        Me.bdnNivel1Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel1Delete.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.bdnNivel1Delete.Name = "bdnNivel1Delete"
        Me.bdnNivel1Delete.RightToLeftAutoMirrorImage = True
        Me.bdnNivel1Delete.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel1Delete.Text = "Eliminar"
        '
        'BindingNavigatorMoveFirstItem1
        '
        Me.BindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem1.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem1.Name = "BindingNavigatorMoveFirstItem1"
        Me.BindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem1.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem1
        '
        Me.BindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem1.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem1.Name = "BindingNavigatorMovePreviousItem1"
        Me.BindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem1.Text = "Move previous"
        '
        'BindingNavigatorSeparator3
        '
        Me.BindingNavigatorSeparator3.Name = "BindingNavigatorSeparator3"
        Me.BindingNavigatorSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem1
        '
        Me.BindingNavigatorPositionItem1.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem1.AutoSize = False
        Me.BindingNavigatorPositionItem1.Name = "BindingNavigatorPositionItem1"
        Me.BindingNavigatorPositionItem1.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem1.Text = "0"
        Me.BindingNavigatorPositionItem1.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator4
        '
        Me.BindingNavigatorSeparator4.Name = "BindingNavigatorSeparator4"
        Me.BindingNavigatorSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem1
        '
        Me.BindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem1.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem1.Name = "BindingNavigatorMoveNextItem1"
        Me.BindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem1.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem1
        '
        Me.BindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem1.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem1.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem1.Name = "BindingNavigatorMoveLastItem1"
        Me.BindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem1.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem1.Text = "Move last"
        '
        'BindingNavigatorSeparator5
        '
        Me.BindingNavigatorSeparator5.Name = "BindingNavigatorSeparator5"
        Me.BindingNavigatorSeparator5.Size = New System.Drawing.Size(6, 25)
        '
        'bdnNivel1Add
        '
        Me.bdnNivel1Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel1Add.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.bdnNivel1Add.Name = "bdnNivel1Add"
        Me.bdnNivel1Add.RightToLeftAutoMirrorImage = True
        Me.bdnNivel1Add.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel1Add.Text = "Añadir"
        '
        'bdnNivel1Modificar
        '
        Me.bdnNivel1Modificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel1Modificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.bdnNivel1Modificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bdnNivel1Modificar.Name = "bdnNivel1Modificar"
        Me.bdnNivel1Modificar.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel1Modificar.Text = "Modificar"
        '
        'frmEntPedidosProveedoresDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(831, 746)
        Me.Controls.Add(Me.grbDetalles)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPedidosProveedoresDetalles"
        Me.Text = "PedidosProveedoresDetalles"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.grbDetalles, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.grbDetalles.ResumeLayout(False)
        Me.grbDetalles.PerformLayout()
        CType(Me.dgvNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdnNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNivel1.ResumeLayout(False)
        Me.bdnNivel1.PerformLayout()
        CType(Me.bdsNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
   Private WithEvents bdsNivel1 As System.Windows.Forms.BindingSource
   Private WithEvents lArticulosObservaciones As System.Windows.Forms.Label
    Private WithEvents txtPedidoProveedorDetalleID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidoProveedorMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtArticuloID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFechaServicio As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEstadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidosProveedoresMaestro_PedidoProveedorMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPedidoProveedorDetalleID As System.Windows.Forms.Label
    Private WithEvents lblPedidoProveedorMaestroID As System.Windows.Forms.Label
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblCantidad As System.Windows.Forms.Label
    Private WithEvents lblFechaServicio As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblEstadoID As System.Windows.Forms.Label
    Private WithEvents lblPedidosProveedoresMaestro_PedidoProveedorMaestroID As System.Windows.Forms.Label
    Private WithEvents cboArticulos As System.Windows.Forms.ComboBox
    Private WithEvents cboEstados As System.Windows.Forms.ComboBox
    Private WithEvents grbDetalles As System.Windows.Forms.GroupBox
    Private WithEvents bdnNivel1 As System.Windows.Forms.BindingNavigator
    Private WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents bdnNivel1Delete As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Private WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents bdnNivel1Add As System.Windows.Forms.ToolStripButton
    Private WithEvents bdnNivel1Modificar As System.Windows.Forms.ToolStripButton
    Private WithEvents dgvNivel1 As System.Windows.Forms.DataGridView
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboUnidades As System.Windows.Forms.ComboBox
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCantidadPedida As System.Windows.Forms.TextBox
    Private WithEvents txtCantidadServida As System.Windows.Forms.TextBox
    Private WithEvents txtCAntidadRetante As System.Windows.Forms.TextBox
    Private WithEvents btnAddUnidad As System.Windows.Forms.Button
End Class
