<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntCargaNecesidadesJR2Maestro
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
        Me.txtCargaNecesidadesJRMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtReserva1 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtReserva2 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtReserva3 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtServido = New System.Windows.Forms.CheckBox()
        Me.lblCargaNecesidadesJRMaestroID = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblReserva1 = New System.Windows.Forms.Label()
        Me.lblReserva2 = New System.Windows.Forms.Label()
        Me.lblReserva3 = New System.Windows.Forms.Label()
        Me.lblServido = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpDetalle = New System.Windows.Forms.TabPage()
        Me.grbContenido = New System.Windows.Forms.GroupBox()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.tsFormatos1 = New System.Windows.Forms.ToolStrip()
        Me.tsInsertar = New System.Windows.Forms.ToolStripButton()
        Me.tsModificar = New System.Windows.Forms.ToolStripButton()
        Me.tsEliminar = New System.Windows.Forms.ToolStripButton()
        Me.tbpDocumentacion = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpDetalle.SuspendLayout()
        Me.grbContenido.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsFormatos1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'txtCargaNecesidadesJRMaestroID
        '
        Me.txtCargaNecesidadesJRMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtCargaNecesidadesJRMaestroID.EsUnicoCampo = ""
        Me.txtCargaNecesidadesJRMaestroID.EsUnicoCampoID = ""
        Me.txtCargaNecesidadesJRMaestroID.EsUnicoID = 0
        Me.txtCargaNecesidadesJRMaestroID.EsUnicoTabla = ""
        Me.txtCargaNecesidadesJRMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCargaNecesidadesJRMaestroID.Location = New System.Drawing.Point(252, 4)
        Me.txtCargaNecesidadesJRMaestroID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtCargaNecesidadesJRMaestroID.MaxLength = 9
        Me.txtCargaNecesidadesJRMaestroID.Minimo = 0
        Me.txtCargaNecesidadesJRMaestroID.Modificado = False
        Me.txtCargaNecesidadesJRMaestroID.Name = "txtCargaNecesidadesJRMaestroID"
        Me.txtCargaNecesidadesJRMaestroID.Numerico_EsNumerico = False
        Me.txtCargaNecesidadesJRMaestroID.Numerico_NumeroDoublees = 0
        Me.txtCargaNecesidadesJRMaestroID.Numerico_SeparadorMiles = False
        Me.txtCargaNecesidadesJRMaestroID.Obligatorio = False
        Me.txtCargaNecesidadesJRMaestroID.ParametroID = 0
        Me.txtCargaNecesidadesJRMaestroID.Size = New System.Drawing.Size(73, 24)
        Me.txtCargaNecesidadesJRMaestroID.TabIndex = 0
        Me.txtCargaNecesidadesJRMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCargaNecesidadesJRMaestroID.ValorMaximo = 0.0!
        Me.txtCargaNecesidadesJRMaestroID.ValorMinimo = 0.0!
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.CustomFormat = "yyyy-MM-dd hh:mm tt"
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha.Location = New System.Drawing.Point(252, 38)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowUpDown = True
        Me.dtpFecha.Size = New System.Drawing.Size(265, 24)
        Me.dtpFecha.TabIndex = 1
        '
        'dtpHora
        '
        Me.dtpHora.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHora.Location = New System.Drawing.Point(626, 38)
        Me.dtpHora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.Size = New System.Drawing.Size(125, 24)
        Me.dtpHora.TabIndex = 2
        Me.dtpHora.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(252, 70)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(265, 24)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'txtReserva1
        '
        Me.txtReserva1.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva1.EsUnicoCampo = ""
        Me.txtReserva1.EsUnicoCampoID = ""
        Me.txtReserva1.EsUnicoID = 0
        Me.txtReserva1.EsUnicoTabla = ""
        Me.txtReserva1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva1.Location = New System.Drawing.Point(252, 102)
        Me.txtReserva1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReserva1.MaxLength = 50
        Me.txtReserva1.Minimo = 0
        Me.txtReserva1.Modificado = False
        Me.txtReserva1.Name = "txtReserva1"
        Me.txtReserva1.Numerico_EsNumerico = False
        Me.txtReserva1.Numerico_NumeroDoublees = 0
        Me.txtReserva1.Numerico_SeparadorMiles = False
        Me.txtReserva1.Obligatorio = True
        Me.txtReserva1.ParametroID = 0
        Me.txtReserva1.Size = New System.Drawing.Size(265, 24)
        Me.txtReserva1.TabIndex = 4
        Me.txtReserva1.ValorMaximo = 0.0!
        Me.txtReserva1.ValorMinimo = 0.0!
        '
        'txtReserva2
        '
        Me.txtReserva2.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva2.EsUnicoCampo = ""
        Me.txtReserva2.EsUnicoCampoID = ""
        Me.txtReserva2.EsUnicoID = 0
        Me.txtReserva2.EsUnicoTabla = ""
        Me.txtReserva2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva2.Location = New System.Drawing.Point(626, 70)
        Me.txtReserva2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReserva2.MaxLength = 50
        Me.txtReserva2.Minimo = 0
        Me.txtReserva2.Modificado = False
        Me.txtReserva2.Name = "txtReserva2"
        Me.txtReserva2.Numerico_EsNumerico = False
        Me.txtReserva2.Numerico_NumeroDoublees = 0
        Me.txtReserva2.Numerico_SeparadorMiles = False
        Me.txtReserva2.Obligatorio = True
        Me.txtReserva2.ParametroID = 0
        Me.txtReserva2.Size = New System.Drawing.Size(265, 24)
        Me.txtReserva2.TabIndex = 5
        Me.txtReserva2.ValorMaximo = 0.0!
        Me.txtReserva2.ValorMinimo = 0.0!
        '
        'txtReserva3
        '
        Me.txtReserva3.BackColor = System.Drawing.SystemColors.Window
        Me.txtReserva3.EsUnicoCampo = ""
        Me.txtReserva3.EsUnicoCampoID = ""
        Me.txtReserva3.EsUnicoID = 0
        Me.txtReserva3.EsUnicoTabla = ""
        Me.txtReserva3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReserva3.Location = New System.Drawing.Point(626, 102)
        Me.txtReserva3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtReserva3.MaxLength = 50
        Me.txtReserva3.Minimo = 0
        Me.txtReserva3.Modificado = False
        Me.txtReserva3.Name = "txtReserva3"
        Me.txtReserva3.Numerico_EsNumerico = False
        Me.txtReserva3.Numerico_NumeroDoublees = 0
        Me.txtReserva3.Numerico_SeparadorMiles = False
        Me.txtReserva3.Obligatorio = True
        Me.txtReserva3.ParametroID = 0
        Me.txtReserva3.Size = New System.Drawing.Size(265, 24)
        Me.txtReserva3.TabIndex = 6
        Me.txtReserva3.ValorMaximo = 0.0!
        Me.txtReserva3.ValorMinimo = 0.0!
        '
        'txtServido
        '
        Me.txtServido.BackColor = System.Drawing.SystemColors.Control
        Me.txtServido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServido.Location = New System.Drawing.Point(626, 4)
        Me.txtServido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtServido.Name = "txtServido"
        Me.txtServido.Size = New System.Drawing.Size(21, 26)
        Me.txtServido.TabIndex = 7
        Me.txtServido.UseVisualStyleBackColor = False
        '
        'lblCargaNecesidadesJRMaestroID
        '
        Me.lblCargaNecesidadesJRMaestroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCargaNecesidadesJRMaestroID.Location = New System.Drawing.Point(23, 0)
        Me.lblCargaNecesidadesJRMaestroID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCargaNecesidadesJRMaestroID.Name = "lblCargaNecesidadesJRMaestroID"
        Me.lblCargaNecesidadesJRMaestroID.Size = New System.Drawing.Size(221, 26)
        Me.lblCargaNecesidadesJRMaestroID.TabIndex = 0
        Me.lblCargaNecesidadesJRMaestroID.Text = "CargaNecesidadesJRMaestroID"
        Me.lblCargaNecesidadesJRMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(23, 34)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(221, 26)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHora
        '
        Me.lblHora.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHora.Location = New System.Drawing.Point(544, 34)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(74, 26)
        Me.lblHora.TabIndex = 2
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblHora.Visible = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 66)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(221, 26)
        Me.lblObservaciones.TabIndex = 3
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva1
        '
        Me.lblReserva1.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReserva1.Location = New System.Drawing.Point(23, 98)
        Me.lblReserva1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReserva1.Name = "lblReserva1"
        Me.lblReserva1.Size = New System.Drawing.Size(221, 26)
        Me.lblReserva1.TabIndex = 4
        Me.lblReserva1.Text = "Reserva1"
        Me.lblReserva1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva2
        '
        Me.lblReserva2.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReserva2.Location = New System.Drawing.Point(544, 66)
        Me.lblReserva2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReserva2.Name = "lblReserva2"
        Me.lblReserva2.Size = New System.Drawing.Size(74, 26)
        Me.lblReserva2.TabIndex = 5
        Me.lblReserva2.Text = "Reserva2"
        Me.lblReserva2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReserva3
        '
        Me.lblReserva3.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReserva3.Location = New System.Drawing.Point(544, 98)
        Me.lblReserva3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblReserva3.Name = "lblReserva3"
        Me.lblReserva3.Size = New System.Drawing.Size(74, 26)
        Me.lblReserva3.TabIndex = 6
        Me.lblReserva3.Text = "Reserva3"
        Me.lblReserva3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblServido
        '
        Me.lblServido.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblServido.Location = New System.Drawing.Point(544, 0)
        Me.lblServido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblServido.Name = "lblServido"
        Me.lblServido.Size = New System.Drawing.Size(74, 26)
        Me.lblServido.TabIndex = 7
        Me.lblServido.Text = "Servido"
        Me.lblServido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 6
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 74.24242!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.90909!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 399.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.tlpMiddle.Controls.Add(Me.lblCargaNecesidadesJRMaestroID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtCargaNecesidadesJRMaestroID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblReserva1, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.dtpHora, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.txtReserva1, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtReserva2, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.txtReserva3, 4, 4)
        Me.tlpMiddle.Controls.Add(Me.lblHora, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.lblReserva2, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.lblReserva3, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.lblServido, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.txtServido, 4, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1063, 143)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.tbpDetalle)
        Me.TabControl1.Controls.Add(Me.tbpDocumentacion)
        Me.TabControl1.Location = New System.Drawing.Point(16, 199)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1031, 428)
        Me.TabControl1.TabIndex = 1000000002
        '
        'tbpDetalle
        '
        Me.tbpDetalle.Controls.Add(Me.grbContenido)
        Me.tbpDetalle.Location = New System.Drawing.Point(4, 25)
        Me.tbpDetalle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDetalle.Name = "tbpDetalle"
        Me.tbpDetalle.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDetalle.Size = New System.Drawing.Size(1023, 399)
        Me.tbpDetalle.TabIndex = 0
        Me.tbpDetalle.Text = "Artículos"
        Me.tbpDetalle.UseVisualStyleBackColor = True
        '
        'grbContenido
        '
        Me.grbContenido.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grbContenido.Controls.Add(Me.dgvDetalles)
        Me.grbContenido.Controls.Add(Me.tsFormatos1)
        Me.grbContenido.Location = New System.Drawing.Point(8, 7)
        Me.grbContenido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbContenido.Name = "grbContenido"
        Me.grbContenido.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grbContenido.Size = New System.Drawing.Size(1004, 382)
        Me.grbContenido.TabIndex = 1000000032
        Me.grbContenido.TabStop = False
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvDetalles.Location = New System.Drawing.Point(4, 19)
        Me.dgvDetalles.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(972, 359)
        Me.dgvDetalles.TabIndex = 13
        '
        'tsFormatos1
        '
        Me.tsFormatos1.Dock = System.Windows.Forms.DockStyle.Right
        Me.tsFormatos1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsInsertar, Me.tsModificar, Me.tsEliminar})
        Me.tsFormatos1.Location = New System.Drawing.Point(976, 19)
        Me.tsFormatos1.Name = "tsFormatos1"
        Me.tsFormatos1.Size = New System.Drawing.Size(24, 359)
        Me.tsFormatos1.TabIndex = 12
        Me.tsFormatos1.Text = "ToolStrip2"
        '
        'tsInsertar
        '
        Me.tsInsertar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsInsertar.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.tsInsertar.Name = "tsInsertar"
        Me.tsInsertar.RightToLeftAutoMirrorImage = True
        Me.tsInsertar.Size = New System.Drawing.Size(21, 20)
        Me.tsInsertar.Text = "Añadir"
        Me.tsInsertar.ToolTipText = "Añadir"
        '
        'tsModificar
        '
        Me.tsModificar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsModificar.Image = Global.La_Andaluza.My.Resources.Resources.Modificar
        Me.tsModificar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsModificar.Name = "tsModificar"
        Me.tsModificar.Size = New System.Drawing.Size(21, 20)
        Me.tsModificar.Text = "Modificar"
        Me.tsModificar.ToolTipText = "Modificar"
        '
        'tsEliminar
        '
        Me.tsEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsEliminar.Image = Global.La_Andaluza.My.Resources.Resources.edit_remove_3
        Me.tsEliminar.Name = "tsEliminar"
        Me.tsEliminar.RightToLeftAutoMirrorImage = True
        Me.tsEliminar.Size = New System.Drawing.Size(21, 20)
        Me.tsEliminar.Text = "Eliminar"
        Me.tsEliminar.ToolTipText = "Eliminar"
        '
        'tbpDocumentacion
        '
        Me.tbpDocumentacion.Location = New System.Drawing.Point(4, 25)
        Me.tbpDocumentacion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDocumentacion.Name = "tbpDocumentacion"
        Me.tbpDocumentacion.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbpDocumentacion.Size = New System.Drawing.Size(1023, 399)
        Me.tbpDocumentacion.TabIndex = 1
        Me.tbpDocumentacion.Text = "Documentación"
        Me.tbpDocumentacion.UseVisualStyleBackColor = True
        '
        'frmEntCargaNecesidadesJR2Maestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1063, 642)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.TabControl1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntCargaNecesidadesJR2Maestro"
        Me.Text = "CargaNecesidadesJRMaestro"
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tbpDetalle.ResumeLayout(False)
        Me.grbContenido.ResumeLayout(False)
        Me.grbContenido.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsFormatos1.ResumeLayout(False)
        Me.tsFormatos1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCargaNecesidadesJRMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtReserva1 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtReserva2 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtReserva3 As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents txtServido As System.Windows.Forms.CheckBox
   Private WithEvents lblCargaNecesidadesJRMaestroID As System.Windows.Forms.Label
   Private WithEvents lblFecha As System.Windows.Forms.Label
   Private WithEvents lblHora As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblReserva1 As System.Windows.Forms.Label
   Private WithEvents lblReserva2 As System.Windows.Forms.Label
   Private WithEvents lblReserva3 As System.Windows.Forms.Label
   Private WithEvents lblServido As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
   Private WithEvents TabControl1 As System.Windows.Forms.TabControl
   Private WithEvents tbpDetalle As System.Windows.Forms.TabPage
   Private WithEvents tbpDocumentacion As System.Windows.Forms.TabPage
   Private WithEvents grbContenido As System.Windows.Forms.GroupBox
   Private WithEvents dgvDetalles As System.Windows.Forms.DataGridView
   Private WithEvents tsFormatos1 As System.Windows.Forms.ToolStrip
   Private WithEvents tsInsertar As System.Windows.Forms.ToolStripButton
   Private WithEvents tsModificar As System.Windows.Forms.ToolStripButton
   Private WithEvents tsEliminar As System.Windows.Forms.ToolStripButton
End Class
