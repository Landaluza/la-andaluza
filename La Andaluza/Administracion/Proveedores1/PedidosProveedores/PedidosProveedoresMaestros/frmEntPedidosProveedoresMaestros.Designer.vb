<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosProveedoresMaestros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosProveedoresMaestros))
        Me.txtPedidoProveedorMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNumero = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtProveedorID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFechaEmision = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaServicio = New System.Windows.Forms.DateTimePicker()
        Me.txtEstadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtSolicitanteID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblNumero = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblFechaEmision = New System.Windows.Forms.Label()
        Me.lblFechaServicio = New System.Windows.Forms.Label()
        Me.lblEstadoID = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblSolicitanteID = New System.Windows.Forms.Label()
        Me.cboProveedores = New System.Windows.Forms.ComboBox()
        Me.cboEstados = New System.Windows.Forms.ComboBox()
        Me.cboEmpleados = New System.Windows.Forms.ComboBox()
        Me.grbNivel1 = New System.Windows.Forms.GroupBox()
        Me.dgvNivel1 = New System.Windows.Forms.DataGridView()
        Me.bdnNivel1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorCountItem1 = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorMoveFirstItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem1 = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem1 = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.bdnNivel1Add = New System.Windows.Forms.ToolStripButton()
        Me.bdnNivel1Edit = New System.Windows.Forms.ToolStripButton()
        Me.bdnNivel1Delete = New System.Windows.Forms.ToolStripButton()
        Me.bdsNivel1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.tabSeguimiento = New System.Windows.Forms.TabControl()
        Me.tpDatos = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Empleado = New System.Windows.Forms.Label()
        Me.grbNivel2 = New System.Windows.Forms.GroupBox()
        Me.dgvNivel2 = New System.Windows.Forms.DataGridView()
        Me.bdnNivel2 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.bdnNivel2Add = New System.Windows.Forms.ToolStripButton()
        Me.bdnNivel2Edit = New System.Windows.Forms.ToolStripButton()
        Me.bdnNivel2Delete = New System.Windows.Forms.ToolStripButton()
        Me.tpDocumentos = New System.Windows.Forms.TabPage()
        Me.bdsNivel2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.bdsDocumentos = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grbNivel1.SuspendLayout()
        CType(Me.dgvNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdnNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNivel1.SuspendLayout()
        CType(Me.bdsNivel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabSeguimiento.SuspendLayout()
        Me.tpDatos.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.grbNivel2.SuspendLayout()
        CType(Me.dgvNivel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdnNivel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.bdnNivel2.SuspendLayout()
        CType(Me.bdsNivel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bdsDocumentos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtPedidoProveedorMaestroID
        '
        Me.txtPedidoProveedorMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorMaestroID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPedidoProveedorMaestroID.EsUnicoCampo = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoID = 0
        Me.txtPedidoProveedorMaestroID.EsUnicoTabla = ""
        Me.txtPedidoProveedorMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorMaestroID.Location = New System.Drawing.Point(164, 6)
        Me.txtPedidoProveedorMaestroID.MaxLength = 9
        Me.txtPedidoProveedorMaestroID.Minimo = 0
        Me.txtPedidoProveedorMaestroID.Modificado = False
        Me.txtPedidoProveedorMaestroID.Name = "txtPedidoProveedorMaestroID"
        Me.txtPedidoProveedorMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorMaestroID.Obligatorio = False
        Me.txtPedidoProveedorMaestroID.ParametroID = 0
        Me.txtPedidoProveedorMaestroID.Size = New System.Drawing.Size(56, 14)
        Me.txtPedidoProveedorMaestroID.TabIndex = 0
        Me.txtPedidoProveedorMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorMaestroID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorMaestroID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorMaestroID.Visible = False
        '
        'txtNumero
        '
        Me.txtNumero.BackColor = System.Drawing.SystemColors.Window
        Me.txtNumero.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNumero.EsUnicoCampo = ""
        Me.txtNumero.EsUnicoCampoID = ""
        Me.txtNumero.EsUnicoID = 0
        Me.txtNumero.EsUnicoTabla = ""
        Me.txtNumero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumero.Location = New System.Drawing.Point(88, 6)
        Me.txtNumero.MaxLength = 9
        Me.txtNumero.Minimo = 0
        Me.txtNumero.Modificado = False
        Me.txtNumero.Name = "txtNumero"
        Me.txtNumero.Numerico_EsNumerico = False
        Me.txtNumero.Numerico_NumeroDoublees = 0
        Me.txtNumero.Numerico_SeparadorMiles = False
        Me.txtNumero.Obligatorio = False
        Me.txtNumero.ParametroID = 0
        Me.txtNumero.Size = New System.Drawing.Size(56, 14)
        Me.txtNumero.TabIndex = 0
        Me.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNumero.ValorMaximo = 0.0R
        Me.txtNumero.ValorMinimo = 0.0R
        '
        'txtProveedorID
        '
        Me.txtProveedorID.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedorID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtProveedorID.EsUnicoCampo = ""
        Me.txtProveedorID.EsUnicoCampoID = ""
        Me.txtProveedorID.EsUnicoID = 0
        Me.txtProveedorID.EsUnicoTabla = ""
        Me.txtProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorID.Location = New System.Drawing.Point(240, 6)
        Me.txtProveedorID.MaxLength = 9
        Me.txtProveedorID.Minimo = 0
        Me.txtProveedorID.Modificado = False
        Me.txtProveedorID.Name = "txtProveedorID"
        Me.txtProveedorID.Numerico_EsNumerico = False
        Me.txtProveedorID.Numerico_NumeroDoublees = 0
        Me.txtProveedorID.Numerico_SeparadorMiles = False
        Me.txtProveedorID.Obligatorio = False
        Me.txtProveedorID.ParametroID = 0
        Me.txtProveedorID.Size = New System.Drawing.Size(56, 14)
        Me.txtProveedorID.TabIndex = 2
        Me.txtProveedorID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtProveedorID.ValorMaximo = 0.0R
        Me.txtProveedorID.ValorMinimo = 0.0R
        Me.txtProveedorID.Visible = False
        '
        'txtFechaEmision
        '
        Me.txtFechaEmision.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaEmision.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaEmision.Location = New System.Drawing.Point(550, 6)
        Me.txtFechaEmision.Name = "txtFechaEmision"
        Me.txtFechaEmision.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaEmision.TabIndex = 2
        '
        'txtFechaServicio
        '
        Me.txtFechaServicio.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaServicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaServicio.Location = New System.Drawing.Point(550, 32)
        Me.txtFechaServicio.Name = "txtFechaServicio"
        Me.txtFechaServicio.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaServicio.TabIndex = 3
        '
        'txtEstadoID
        '
        Me.txtEstadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEstadoID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtEstadoID.EsUnicoCampo = ""
        Me.txtEstadoID.EsUnicoCampoID = ""
        Me.txtEstadoID.EsUnicoID = 0
        Me.txtEstadoID.EsUnicoTabla = ""
        Me.txtEstadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEstadoID.Location = New System.Drawing.Point(816, 62)
        Me.txtEstadoID.MaxLength = 9
        Me.txtEstadoID.Minimo = 0
        Me.txtEstadoID.Modificado = False
        Me.txtEstadoID.Name = "txtEstadoID"
        Me.txtEstadoID.Numerico_EsNumerico = False
        Me.txtEstadoID.Numerico_NumeroDoublees = 0
        Me.txtEstadoID.Numerico_SeparadorMiles = False
        Me.txtEstadoID.Obligatorio = False
        Me.txtEstadoID.ParametroID = 0
        Me.txtEstadoID.Size = New System.Drawing.Size(56, 14)
        Me.txtEstadoID.TabIndex = 5
        Me.txtEstadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEstadoID.ValorMaximo = 0.0R
        Me.txtEstadoID.ValorMinimo = 0.0R
        Me.txtEstadoID.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(88, 116)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(661, 14)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtSolicitanteID
        '
        Me.txtSolicitanteID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSolicitanteID.EsUnicoCampo = ""
        Me.txtSolicitanteID.EsUnicoCampoID = ""
        Me.txtSolicitanteID.EsUnicoID = 0
        Me.txtSolicitanteID.EsUnicoTabla = ""
        Me.txtSolicitanteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSolicitanteID.Location = New System.Drawing.Point(88, 88)
        Me.txtSolicitanteID.MaxLength = 9
        Me.txtSolicitanteID.Minimo = 0
        Me.txtSolicitanteID.Modificado = False
        Me.txtSolicitanteID.Name = "txtSolicitanteID"
        Me.txtSolicitanteID.Numerico_EsNumerico = False
        Me.txtSolicitanteID.Numerico_NumeroDoublees = 0
        Me.txtSolicitanteID.Numerico_SeparadorMiles = False
        Me.txtSolicitanteID.Obligatorio = False
        Me.txtSolicitanteID.ParametroID = 0
        Me.txtSolicitanteID.Size = New System.Drawing.Size(318, 21)
        Me.txtSolicitanteID.TabIndex = 7
        Me.txtSolicitanteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSolicitanteID.ValorMaximo = 0.0R
        Me.txtSolicitanteID.ValorMinimo = 0.0R
        Me.txtSolicitanteID.Visible = False
        '
        'txtPedidosProveedoresEstados_PedidoProveedorEstadoID
        '
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.EsUnicoCampo = ""
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.EsUnicoCampoID = ""
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.EsUnicoID = 0
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.EsUnicoTabla = ""
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Location = New System.Drawing.Point(816, 2)
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.MaxLength = 9
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Minimo = 0
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Modificado = False
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Name = "txtPedidosProveedoresEstados_PedidoProveedorEstadoID"
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Numerico_EsNumerico = False
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Numerico_NumeroDoublees = 0
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Numerico_SeparadorMiles = False
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Obligatorio = False
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.ParametroID = 0
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Size = New System.Drawing.Size(56, 14)
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.TabIndex = 8
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.ValorMaximo = 0.0R
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.ValorMinimo = 0.0R
        Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID.Visible = False
        '
        'lblNumero
        '
        Me.lblNumero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumero.Location = New System.Drawing.Point(12, 6)
        Me.lblNumero.Name = "lblNumero"
        Me.lblNumero.Size = New System.Drawing.Size(57, 21)
        Me.lblNumero.TabIndex = 1
        Me.lblNumero.Text = "Numero"
        Me.lblNumero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblProveedorID.Location = New System.Drawing.Point(12, 34)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(58, 21)
        Me.lblProveedorID.TabIndex = 2
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaEmision
        '
        Me.lblFechaEmision.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaEmision.Location = New System.Drawing.Point(501, 6)
        Me.lblFechaEmision.Name = "lblFechaEmision"
        Me.lblFechaEmision.Size = New System.Drawing.Size(68, 21)
        Me.lblFechaEmision.TabIndex = 3
        Me.lblFechaEmision.Text = "Emision"
        Me.lblFechaEmision.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaServicio
        '
        Me.lblFechaServicio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFechaServicio.Location = New System.Drawing.Point(501, 32)
        Me.lblFechaServicio.Name = "lblFechaServicio"
        Me.lblFechaServicio.Size = New System.Drawing.Size(64, 21)
        Me.lblFechaServicio.TabIndex = 4
        Me.lblFechaServicio.Text = "Servicio"
        Me.lblFechaServicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEstadoID
        '
        Me.lblEstadoID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblEstadoID.Location = New System.Drawing.Point(501, 58)
        Me.lblEstadoID.Name = "lblEstadoID"
        Me.lblEstadoID.Size = New System.Drawing.Size(54, 21)
        Me.lblEstadoID.TabIndex = 5
        Me.lblEstadoID.Text = "Estado"
        Me.lblEstadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 116)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 21)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSolicitanteID
        '
        Me.lblSolicitanteID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblSolicitanteID.Location = New System.Drawing.Point(13, 83)
        Me.lblSolicitanteID.Name = "lblSolicitanteID"
        Me.lblSolicitanteID.Size = New System.Drawing.Size(66, 24)
        Me.lblSolicitanteID.TabIndex = 7
        Me.lblSolicitanteID.Text = "Solicitante"
        Me.lblSolicitanteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboProveedores
        '
        Me.cboProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedores.FormattingEnabled = True
        Me.cboProveedores.Location = New System.Drawing.Point(88, 34)
        Me.cboProveedores.Name = "cboProveedores"
        Me.cboProveedores.Size = New System.Drawing.Size(318, 21)
        Me.cboProveedores.TabIndex = 1
        '
        'cboEstados
        '
        Me.cboEstados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEstados.FormattingEnabled = True
        Me.cboEstados.Location = New System.Drawing.Point(550, 60)
        Me.cboEstados.Name = "cboEstados"
        Me.cboEstados.Size = New System.Drawing.Size(199, 21)
        Me.cboEstados.TabIndex = 4
        '
        'cboEmpleados
        '
        Me.cboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpleados.FormattingEnabled = True
        Me.cboEmpleados.Location = New System.Drawing.Point(88, 58)
        Me.cboEmpleados.Name = "cboEmpleados"
        Me.cboEmpleados.Size = New System.Drawing.Size(318, 21)
        Me.cboEmpleados.TabIndex = 6
        '
        '
        'grbNivel1
        '
        Me.grbNivel1.Controls.Add(Me.dgvNivel1)
        Me.grbNivel1.Controls.Add(Me.bdnNivel1)
        Me.grbNivel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbNivel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNivel1.Location = New System.Drawing.Point(3, 138)
        Me.grbNivel1.Name = "grbNivel1"
        Me.grbNivel1.Size = New System.Drawing.Size(919, 283)
        Me.grbNivel1.TabIndex = 1000000073
        Me.grbNivel1.TabStop = False
        Me.grbNivel1.Text = "Articulos del pedido."
        '
        'dgvNivel1
        '
        Me.dgvNivel1.AllowUserToAddRows = False
        Me.dgvNivel1.AllowUserToDeleteRows = False
        Me.dgvNivel1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNivel1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvNivel1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNivel1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNivel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNivel1.Location = New System.Drawing.Point(3, 42)
        Me.dgvNivel1.Name = "dgvNivel1"
        Me.dgvNivel1.ReadOnly = True
        Me.dgvNivel1.RowHeadersWidth = 14
        Me.dgvNivel1.Size = New System.Drawing.Size(913, 238)
        Me.dgvNivel1.TabIndex = 13
        '
        'bdnNivel1
        '
        Me.bdnNivel1.AddNewItem = Me.BindingNavigatorCountItem
        Me.bdnNivel1.CountItem = Me.BindingNavigatorCountItem1
        Me.bdnNivel1.DeleteItem = Nothing
        Me.bdnNivel1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bdnNivel1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem1, Me.BindingNavigatorMovePreviousItem1, Me.BindingNavigatorSeparator3, Me.BindingNavigatorPositionItem1, Me.BindingNavigatorCountItem1, Me.BindingNavigatorSeparator4, Me.BindingNavigatorMoveNextItem1, Me.BindingNavigatorMoveLastItem1, Me.BindingNavigatorSeparator5, Me.bdnNivel1Add, Me.bdnNivel1Edit, Me.bdnNivel1Delete})
        Me.bdnNivel1.Location = New System.Drawing.Point(3, 17)
        Me.bdnNivel1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem1
        Me.bdnNivel1.MoveLastItem = Me.BindingNavigatorMoveLastItem1
        Me.bdnNivel1.MoveNextItem = Me.BindingNavigatorMoveNextItem1
        Me.bdnNivel1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem1
        Me.bdnNivel1.Name = "bdnNivel1"
        Me.bdnNivel1.PositionItem = Me.BindingNavigatorPositionItem1
        Me.bdnNivel1.Size = New System.Drawing.Size(913, 25)
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
        'bdnNivel1Edit
        '
        Me.bdnNivel1Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel1Edit.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.bdnNivel1Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bdnNivel1Edit.Name = "bdnNivel1Edit"
        Me.bdnNivel1Edit.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel1Edit.Text = "Modificar"
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
        'tabSeguimiento
        '
        Me.tabSeguimiento.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tabSeguimiento.Controls.Add(Me.tpDatos)
        Me.tabSeguimiento.Controls.Add(Me.tpDocumentos)
        Me.tabSeguimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tabSeguimiento.Location = New System.Drawing.Point(0, 25)
        Me.tabSeguimiento.Name = "tabSeguimiento"
        Me.tabSeguimiento.SelectedIndex = 0
        Me.tabSeguimiento.Size = New System.Drawing.Size(933, 721)
        Me.tabSeguimiento.TabIndex = 1000000074
        '
        'tpDatos
        '
        Me.tpDatos.BackColor = System.Drawing.SystemColors.Control
        Me.tpDatos.Controls.Add(Me.Panel1)
        Me.tpDatos.Controls.Add(Me.grbNivel1)
        Me.tpDatos.Controls.Add(Me.grbNivel2)
        Me.tpDatos.Location = New System.Drawing.Point(4, 25)
        Me.tpDatos.Name = "tpDatos"
        Me.tpDatos.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpDatos.Size = New System.Drawing.Size(925, 692)
        Me.tpDatos.TabIndex = 0
        Me.tpDatos.Text = "Datos"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Empleado)
        Me.Panel1.Controls.Add(Me.lblNumero)
        Me.Panel1.Controls.Add(Me.txtPedidoProveedorMaestroID)
        Me.Panel1.Controls.Add(Me.txtFechaServicio)
        Me.Panel1.Controls.Add(Me.cboEstados)
        Me.Panel1.Controls.Add(Me.lblFechaServicio)
        Me.Panel1.Controls.Add(Me.txtNumero)
        Me.Panel1.Controls.Add(Me.txtFechaEmision)
        Me.Panel1.Controls.Add(Me.lblProveedorID)
        Me.Panel1.Controls.Add(Me.txtEstadoID)
        Me.Panel1.Controls.Add(Me.txtProveedorID)
        Me.Panel1.Controls.Add(Me.txtSolicitanteID)
        Me.Panel1.Controls.Add(Me.cboEmpleados)
        Me.Panel1.Controls.Add(Me.lblSolicitanteID)
        Me.Panel1.Controls.Add(Me.txtPedidosProveedoresEstados_PedidoProveedorEstadoID)
        Me.Panel1.Controls.Add(Me.cboProveedores)
        Me.Panel1.Controls.Add(Me.txtObservaciones)
        Me.Panel1.Controls.Add(Me.lblEstadoID)
        Me.Panel1.Controls.Add(Me.lblFechaEmision)
        Me.Panel1.Controls.Add(Me.lblObservaciones)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(919, 144)
        Me.Panel1.TabIndex = 1000000075
        '
        'Empleado
        '
        Me.Empleado.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Empleado.Location = New System.Drawing.Point(12, 58)
        Me.Empleado.Name = "Empleado"
        Me.Empleado.Size = New System.Drawing.Size(68, 21)
        Me.Empleado.TabIndex = 9
        Me.Empleado.Text = "Responsable"
        Me.Empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grbNivel2
        '
        Me.grbNivel2.Controls.Add(Me.dgvNivel2)
        Me.grbNivel2.Controls.Add(Me.bdnNivel2)
        Me.grbNivel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.grbNivel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbNivel2.Location = New System.Drawing.Point(3, 421)
        Me.grbNivel2.Name = "grbNivel2"
        Me.grbNivel2.Size = New System.Drawing.Size(919, 268)
        Me.grbNivel2.TabIndex = 1000000074
        Me.grbNivel2.TabStop = False
        Me.grbNivel2.Text = "Entregas del articulo."
        '
        'dgvNivel2
        '
        Me.dgvNivel2.AllowUserToAddRows = False
        Me.dgvNivel2.AllowUserToDeleteRows = False
        Me.dgvNivel2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvNivel2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        Me.dgvNivel2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvNivel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvNivel2.Location = New System.Drawing.Point(3, 42)
        Me.dgvNivel2.Name = "dgvNivel2"
        Me.dgvNivel2.ReadOnly = True
        Me.dgvNivel2.Size = New System.Drawing.Size(913, 223)
        Me.dgvNivel2.TabIndex = 13
        '
        'bdnNivel2
        '
        Me.bdnNivel2.AddNewItem = Me.BindingNavigatorCountItem
        Me.bdnNivel2.CountItem = Me.ToolStripLabel1
        Me.bdnNivel2.DeleteItem = Nothing
        Me.bdnNivel2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.bdnNivel2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripTextBox1, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton4, Me.ToolStripButton5, Me.ToolStripSeparator3, Me.bdnNivel2Add, Me.bdnNivel2Edit, Me.bdnNivel2Delete})
        Me.bdnNivel2.Location = New System.Drawing.Point(3, 17)
        Me.bdnNivel2.MoveFirstItem = Me.ToolStripButton2
        Me.bdnNivel2.MoveLastItem = Me.ToolStripButton5
        Me.bdnNivel2.MoveNextItem = Me.ToolStripButton4
        Me.bdnNivel2.MovePreviousItem = Me.ToolStripButton3
        Me.bdnNivel2.Name = "bdnNivel2"
        Me.bdnNivel2.PositionItem = Me.ToolStripTextBox1
        Me.bdnNivel2.Size = New System.Drawing.Size(913, 25)
        Me.bdnNivel2.TabIndex = 1000000073
        Me.bdnNivel2.Text = "BindingNavigator1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(37, 22)
        Me.ToolStripLabel1.Text = "de {0}"
        Me.ToolStripLabel1.ToolTipText = "Total number of items"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Move first"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Move previous"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.AccessibleName = "Position"
        Me.ToolStripTextBox1.AutoSize = False
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(50, 23)
        Me.ToolStripTextBox1.Text = "0"
        Me.ToolStripTextBox1.ToolTipText = "Current position"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton4.Image = CType(resources.GetObject("ToolStripButton4.Image"), System.Drawing.Image)
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton4.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton4.Text = "Move next"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton5.Image = CType(resources.GetObject("ToolStripButton5.Image"), System.Drawing.Image)
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.RightToLeftAutoMirrorImage = True
        Me.ToolStripButton5.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton5.Text = "Move last"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'bdnNivel2Add
        '
        Me.bdnNivel2Add.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel2Add.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.bdnNivel2Add.Name = "bdnNivel2Add"
        Me.bdnNivel2Add.RightToLeftAutoMirrorImage = True
        Me.bdnNivel2Add.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel2Add.Text = "Añadir"
        '
        'bdnNivel2Edit
        '
        Me.bdnNivel2Edit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel2Edit.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.bdnNivel2Edit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.bdnNivel2Edit.Name = "bdnNivel2Edit"
        Me.bdnNivel2Edit.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel2Edit.Text = "Modificar"
        '
        'bdnNivel2Delete
        '
        Me.bdnNivel2Delete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.bdnNivel2Delete.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.bdnNivel2Delete.Name = "bdnNivel2Delete"
        Me.bdnNivel2Delete.RightToLeftAutoMirrorImage = True
        Me.bdnNivel2Delete.Size = New System.Drawing.Size(23, 22)
        Me.bdnNivel2Delete.Text = "Eliminar"
        '
        'tpDocumentos
        '
        Me.tpDocumentos.BackColor = System.Drawing.SystemColors.Control
        Me.tpDocumentos.Location = New System.Drawing.Point(4, 25)
        Me.tpDocumentos.Name = "tpDocumentos"
        Me.tpDocumentos.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tpDocumentos.Size = New System.Drawing.Size(925, 692)
        Me.tpDocumentos.TabIndex = 1
        Me.tpDocumentos.Text = "Documentos"
        '
        'frmEntPedidosProveedoresMaestros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(933, 746)
        Me.Controls.Add(Me.tabSeguimiento)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(554, 352)
        Me.Name = "frmEntPedidosProveedoresMaestros"
        Me.Text = "PedidosProveedoresMaestros"
        Me.Controls.SetChildIndex(Me.tabSeguimiento, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grbNivel1.ResumeLayout(False)
        Me.grbNivel1.PerformLayout()
        CType(Me.dgvNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdnNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNivel1.ResumeLayout(False)
        Me.bdnNivel1.PerformLayout()
        CType(Me.bdsNivel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabSeguimiento.ResumeLayout(False)
        Me.tpDatos.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.grbNivel2.ResumeLayout(False)
        Me.grbNivel2.PerformLayout()
        CType(Me.dgvNivel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdnNivel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.bdnNivel2.ResumeLayout(False)
        Me.bdnNivel2.PerformLayout()
        CType(Me.bdsNivel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bdsDocumentos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents bdnNivel1 As System.Windows.Forms.BindingNavigator
   Private WithEvents bdnNivel1Delete As System.Windows.Forms.ToolStripButton
   Private WithEvents BindingNavigatorMoveNextItem1 As System.Windows.Forms.ToolStripButton
   Private WithEvents bdnNivel1Add As System.Windows.Forms.ToolStripButton
   Private WithEvents bdnNivel1Edit As System.Windows.Forms.ToolStripButton
   Private WithEvents bdsNivel1 As System.Windows.Forms.BindingSource
   Private WithEvents grbNivel2 As System.Windows.Forms.GroupBox
   Private WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
   Private WithEvents bdsNivel2 As System.Windows.Forms.BindingSource
   Private WithEvents bdsDocumentos As System.Windows.Forms.BindingSource
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Empleado As System.Windows.Forms.Label
    Private WithEvents txtPedidoProveedorMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNumero As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtProveedorID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFechaEmision As System.Windows.Forms.DateTimePicker
    Private WithEvents txtFechaServicio As System.Windows.Forms.DateTimePicker
    Private WithEvents txtEstadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSolicitanteID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidosProveedoresEstados_PedidoProveedorEstadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblNumero As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblFechaEmision As System.Windows.Forms.Label
    Private WithEvents lblFechaServicio As System.Windows.Forms.Label
    Private WithEvents lblEstadoID As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblSolicitanteID As System.Windows.Forms.Label
    Private WithEvents grbNivel1 As System.Windows.Forms.GroupBox
    Private WithEvents BindingNavigatorCountItem1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents BindingNavigatorMoveFirstItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorMovePreviousItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorSeparator3 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents BindingNavigatorPositionItem1 As System.Windows.Forms.ToolStripTextBox
    Private WithEvents BindingNavigatorSeparator4 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents BindingNavigatorMoveLastItem1 As System.Windows.Forms.ToolStripButton
    Private WithEvents BindingNavigatorSeparator5 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents dgvNivel1 As System.Windows.Forms.DataGridView
    Private WithEvents cboProveedores As System.Windows.Forms.ComboBox
    Private WithEvents cboEstados As System.Windows.Forms.ComboBox
    Private WithEvents cboEmpleados As System.Windows.Forms.ComboBox
    Private WithEvents tabSeguimiento As System.Windows.Forms.TabControl
    Private WithEvents tpDatos As System.Windows.Forms.TabPage
    Private WithEvents bdnNivel2 As System.Windows.Forms.BindingNavigator
    Private WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Private WithEvents bdnNivel2Delete As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    ' Private WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Private WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Private WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Private WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
    Private WithEvents bdnNivel2Add As System.Windows.Forms.ToolStripButton
    Private WithEvents bdnNivel2Edit As System.Windows.Forms.ToolStripButton
    Private WithEvents dgvNivel2 As System.Windows.Forms.DataGridView
    Private WithEvents tpDocumentos As System.Windows.Forms.TabPage
    ' Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
End Class
