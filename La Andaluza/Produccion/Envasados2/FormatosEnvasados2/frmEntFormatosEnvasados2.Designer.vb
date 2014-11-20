<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntFormatosEnvasados2
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
        Dim FormatoLabel As System.Windows.Forms.Label
        Dim Label4 As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim GenericasLabel As System.Windows.Forms.Label
        Dim ParticularesLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntFormatosEnvasados2))
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.lblTipoFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.lblTipoFormatoLineaID = New System.Windows.Forms.Label()
        Me.lblEnvasadoID = New System.Windows.Forms.Label()
        Me.tpgProduccion = New System.Windows.Forms.TabControl()
        Me.tpPalets = New System.Windows.Forms.TabPage()
        Me.tpIncidencias = New System.Windows.Forms.TabPage()
        Me.tpSeguimientos = New System.Windows.Forms.TabPage()
        Me.dgvSeguimientoProduccion = New System.Windows.Forms.DataGridView()
        Me.tpPropuestas = New System.Windows.Forms.TabPage()
        Me.tpCambiosFormatos = New System.Windows.Forms.TabPage()
        Me.tpVelocidad = New System.Windows.Forms.TabPage()
        Me.tpProducto = New System.Windows.Forms.TabPage()
        Me.tpTrazabilidadMatAux = New System.Windows.Forms.TabPage()
        Me.tpTiempoAsignado = New System.Windows.Forms.TabPage()
        Me.tpEspecificaciones = New System.Windows.Forms.TabPage()
        Me.pnlEspecificaciones = New System.Windows.Forms.Panel()
        Me.grbEspecificaciones = New System.Windows.Forms.GroupBox()
        Me.cmdCerrar = New System.Windows.Forms.Button()
        Me.ParticularesTextBox = New System.Windows.Forms.TextBox()
        Me.GenericasTextBox = New System.Windows.Forms.TextBox()
        Me.tpControlesCalidad = New System.Windows.Forms.TabPage()
        Me.tpResumen = New System.Windows.Forms.TabPage()
        Me.tpFormatos_empleados = New System.Windows.Forms.TabPage()
        Me.panEmpleados = New System.Windows.Forms.Panel()
        Me.PanPersonalOcupados = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.cboTipoFormatoID = New System.Windows.Forms.ComboBox()
        Me.cboTipoFormatoLinea = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnModificar = New System.Windows.Forms.Button()
        FormatoLabel = New System.Windows.Forms.Label()
        Label4 = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        GenericasLabel = New System.Windows.Forms.Label()
        ParticularesLabel = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgProduccion.SuspendLayout()
        Me.tpSeguimientos.SuspendLayout()
        CType(Me.dgvSeguimientoProduccion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpEspecificaciones.SuspendLayout()
        Me.pnlEspecificaciones.SuspendLayout()
        Me.grbEspecificaciones.SuspendLayout()
        Me.tpFormatos_empleados.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2)
        '
        'FormatoLabel
        '
        FormatoLabel.AutoSize = True
        FormatoLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        FormatoLabel.Location = New System.Drawing.Point(12, 46)
        FormatoLabel.Name = "FormatoLabel"
        FormatoLabel.Size = New System.Drawing.Size(45, 13)
        FormatoLabel.TabIndex = 10
        FormatoLabel.Text = "Articulo:"
        '
        'Label4
        '
        Label4.AutoSize = True
        Label4.Location = New System.Drawing.Point(470, 15)
        Label4.Name = "Label4"
        Label4.Size = New System.Drawing.Size(77, 13)
        Label4.TabIndex = 9
        Label4.Text = "Formato Linea:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Label1.Location = New System.Drawing.Point(12, 14)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(76, 13)
        Label1.TabIndex = 14
        Label1.Text = "Tipo producto:"
        '
        'GenericasLabel
        '
        GenericasLabel.AutoSize = True
        GenericasLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GenericasLabel.Location = New System.Drawing.Point(9, 33)
        GenericasLabel.Name = "GenericasLabel"
        GenericasLabel.Size = New System.Drawing.Size(68, 13)
        GenericasLabel.TabIndex = 13
        GenericasLabel.Text = "Genéricas:"
        '
        'ParticularesLabel
        '
        ParticularesLabel.AutoSize = True
        ParticularesLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ParticularesLabel.Location = New System.Drawing.Point(9, 139)
        ParticularesLabel.Name = "ParticularesLabel"
        ParticularesLabel.Size = New System.Drawing.Size(78, 13)
        ParticularesLabel.TabIndex = 14
        ParticularesLabel.Text = "Particulares:"
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(397, -47)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(131, 21)
        Me.lblFormatoEnvasadoID.TabIndex = 14
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Visible = False
        '
        'lblTipoFormatoEnvasadoID
        '
        Me.lblTipoFormatoEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoFormatoEnvasadoID.Location = New System.Drawing.Point(786, -48)
        Me.lblTipoFormatoEnvasadoID.Name = "lblTipoFormatoEnvasadoID"
        Me.lblTipoFormatoEnvasadoID.Size = New System.Drawing.Size(131, 21)
        Me.lblTipoFormatoEnvasadoID.TabIndex = 17
        Me.lblTipoFormatoEnvasadoID.Text = "TipoFormatoEnvasadoID"
        Me.lblTipoFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoFormatoEnvasadoID.Visible = False
        '
        'lblTipoFormatoLineaID
        '
        Me.lblTipoFormatoLineaID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTipoFormatoLineaID.Location = New System.Drawing.Point(588, -44)
        Me.lblTipoFormatoLineaID.Name = "lblTipoFormatoLineaID"
        Me.lblTipoFormatoLineaID.Size = New System.Drawing.Size(45, 21)
        Me.lblTipoFormatoLineaID.TabIndex = 16
        Me.lblTipoFormatoLineaID.Text = "TipoFormatoLineaID"
        Me.lblTipoFormatoLineaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTipoFormatoLineaID.Visible = False
        '
        'lblEnvasadoID
        '
        Me.lblEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblEnvasadoID.Location = New System.Drawing.Point(675, -48)
        Me.lblEnvasadoID.Name = "lblEnvasadoID"
        Me.lblEnvasadoID.Size = New System.Drawing.Size(72, 21)
        Me.lblEnvasadoID.TabIndex = 17
        Me.lblEnvasadoID.Text = "EnvasadoID"
        Me.lblEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEnvasadoID.Visible = False
        '
        'tpgProduccion
        '
        Me.tpgProduccion.Controls.Add(Me.tpPalets)
        Me.tpgProduccion.Controls.Add(Me.tpIncidencias)
        Me.tpgProduccion.Controls.Add(Me.tpSeguimientos)
        Me.tpgProduccion.Controls.Add(Me.tpPropuestas)
        Me.tpgProduccion.Controls.Add(Me.tpCambiosFormatos)
        Me.tpgProduccion.Controls.Add(Me.tpVelocidad)
        Me.tpgProduccion.Controls.Add(Me.tpProducto)
        Me.tpgProduccion.Controls.Add(Me.tpTrazabilidadMatAux)
        Me.tpgProduccion.Controls.Add(Me.tpTiempoAsignado)
        Me.tpgProduccion.Controls.Add(Me.tpEspecificaciones)
        Me.tpgProduccion.Controls.Add(Me.tpControlesCalidad)
        Me.tpgProduccion.Controls.Add(Me.tpResumen)
        Me.tpgProduccion.Controls.Add(Me.tpFormatos_empleados)
        Me.tpgProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tpgProduccion.Location = New System.Drawing.Point(0, 0)
        Me.tpgProduccion.Multiline = True
        Me.tpgProduccion.Name = "tpgProduccion"
        Me.tpgProduccion.SelectedIndex = 0
        Me.tpgProduccion.Size = New System.Drawing.Size(957, 505)
        Me.tpgProduccion.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight
        Me.tpgProduccion.TabIndex = 2
        '
        'tpPalets
        '
        Me.tpPalets.BackColor = System.Drawing.SystemColors.Control
        Me.tpPalets.Location = New System.Drawing.Point(4, 40)
        Me.tpPalets.Name = "tpPalets"
        Me.tpPalets.Size = New System.Drawing.Size(949, 461)
        Me.tpPalets.TabIndex = 10
        Me.tpPalets.Text = "Palets Producidos"
        '
        'tpIncidencias
        '
        Me.tpIncidencias.Location = New System.Drawing.Point(4, 40)
        Me.tpIncidencias.Name = "tpIncidencias"
        Me.tpIncidencias.Size = New System.Drawing.Size(949, 461)
        Me.tpIncidencias.TabIndex = 11
        Me.tpIncidencias.Text = "Incidencias"
        Me.tpIncidencias.UseVisualStyleBackColor = True
        '
        'tpSeguimientos
        '
        Me.tpSeguimientos.Controls.Add(Me.dgvSeguimientoProduccion)
        Me.tpSeguimientos.Location = New System.Drawing.Point(4, 40)
        Me.tpSeguimientos.Name = "tpSeguimientos"
        Me.tpSeguimientos.Size = New System.Drawing.Size(949, 461)
        Me.tpSeguimientos.TabIndex = 12
        Me.tpSeguimientos.Text = "Seguimiento Producción"
        Me.tpSeguimientos.UseVisualStyleBackColor = True
        '
        'dgvSeguimientoProduccion
        '
        Me.dgvSeguimientoProduccion.AllowUserToAddRows = False
        Me.dgvSeguimientoProduccion.AllowUserToDeleteRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow
        Me.dgvSeguimientoProduccion.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvSeguimientoProduccion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.AliceBlue
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvSeguimientoProduccion.DefaultCellStyle = DataGridViewCellStyle2
        Me.dgvSeguimientoProduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvSeguimientoProduccion.Location = New System.Drawing.Point(0, 0)
        Me.dgvSeguimientoProduccion.Name = "dgvSeguimientoProduccion"
        Me.dgvSeguimientoProduccion.RowHeadersVisible = False
        Me.dgvSeguimientoProduccion.Size = New System.Drawing.Size(949, 461)
        Me.dgvSeguimientoProduccion.TabIndex = 0
        '
        'tpPropuestas
        '
        Me.tpPropuestas.BackColor = System.Drawing.SystemColors.Control
        Me.tpPropuestas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.tpPropuestas.Location = New System.Drawing.Point(4, 40)
        Me.tpPropuestas.Name = "tpPropuestas"
        Me.tpPropuestas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpPropuestas.Size = New System.Drawing.Size(949, 461)
        Me.tpPropuestas.TabIndex = 13
        Me.tpPropuestas.Text = "Propuestas"
        '
        'tpCambiosFormatos
        '
        Me.tpCambiosFormatos.BackColor = System.Drawing.SystemColors.Control
        Me.tpCambiosFormatos.Location = New System.Drawing.Point(4, 40)
        Me.tpCambiosFormatos.Name = "tpCambiosFormatos"
        Me.tpCambiosFormatos.Size = New System.Drawing.Size(949, 461)
        Me.tpCambiosFormatos.TabIndex = 14
        Me.tpCambiosFormatos.Text = "Cambios Formatos"
        '
        'tpVelocidad
        '
        Me.tpVelocidad.BackColor = System.Drawing.SystemColors.Control
        Me.tpVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tpVelocidad.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.tpVelocidad.Location = New System.Drawing.Point(4, 40)
        Me.tpVelocidad.Name = "tpVelocidad"
        Me.tpVelocidad.Padding = New System.Windows.Forms.Padding(3)
        Me.tpVelocidad.Size = New System.Drawing.Size(949, 461)
        Me.tpVelocidad.TabIndex = 16
        Me.tpVelocidad.Text = "Velocidad línea"
        '
        'tpProducto
        '
        Me.tpProducto.Location = New System.Drawing.Point(4, 40)
        Me.tpProducto.Name = "tpProducto"
        Me.tpProducto.Size = New System.Drawing.Size(949, 461)
        Me.tpProducto.TabIndex = 18
        Me.tpProducto.Text = "Producto"
        Me.tpProducto.ToolTipText = "Seguimiento lotes del producto que se esta envasando"
        Me.tpProducto.UseVisualStyleBackColor = True
        '
        'tpTrazabilidadMatAux
        '
        Me.tpTrazabilidadMatAux.Location = New System.Drawing.Point(4, 40)
        Me.tpTrazabilidadMatAux.Name = "tpTrazabilidadMatAux"
        Me.tpTrazabilidadMatAux.Padding = New System.Windows.Forms.Padding(3)
        Me.tpTrazabilidadMatAux.Size = New System.Drawing.Size(949, 461)
        Me.tpTrazabilidadMatAux.TabIndex = 19
        Me.tpTrazabilidadMatAux.Text = "Trazabilidad Material auxiliar"
        Me.tpTrazabilidadMatAux.UseVisualStyleBackColor = True
        '
        'tpTiempoAsignado
        '
        Me.tpTiempoAsignado.Location = New System.Drawing.Point(4, 40)
        Me.tpTiempoAsignado.Name = "tpTiempoAsignado"
        Me.tpTiempoAsignado.Size = New System.Drawing.Size(949, 461)
        Me.tpTiempoAsignado.TabIndex = 21
        Me.tpTiempoAsignado.Text = "Paradas Ordenadas"
        Me.tpTiempoAsignado.UseVisualStyleBackColor = True
        '
        'tpEspecificaciones
        '
        Me.tpEspecificaciones.Controls.Add(Me.pnlEspecificaciones)
        Me.tpEspecificaciones.Location = New System.Drawing.Point(4, 40)
        Me.tpEspecificaciones.Name = "tpEspecificaciones"
        Me.tpEspecificaciones.Padding = New System.Windows.Forms.Padding(3)
        Me.tpEspecificaciones.Size = New System.Drawing.Size(949, 461)
        Me.tpEspecificaciones.TabIndex = 25
        Me.tpEspecificaciones.Text = "Especificaciones"
        Me.tpEspecificaciones.UseVisualStyleBackColor = True
        '
        'pnlEspecificaciones
        '
        Me.pnlEspecificaciones.BackColor = System.Drawing.Color.LightSteelBlue
        Me.pnlEspecificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlEspecificaciones.Controls.Add(Me.grbEspecificaciones)
        Me.pnlEspecificaciones.Location = New System.Drawing.Point(30, 30)
        Me.pnlEspecificaciones.Name = "pnlEspecificaciones"
        Me.pnlEspecificaciones.Size = New System.Drawing.Size(895, 353)
        Me.pnlEspecificaciones.TabIndex = 1000000060
        Me.pnlEspecificaciones.Visible = False
        '
        'grbEspecificaciones
        '
        Me.grbEspecificaciones.BackColor = System.Drawing.Color.LightSteelBlue
        Me.grbEspecificaciones.Controls.Add(Me.cmdCerrar)
        Me.grbEspecificaciones.Controls.Add(ParticularesLabel)
        Me.grbEspecificaciones.Controls.Add(Me.ParticularesTextBox)
        Me.grbEspecificaciones.Controls.Add(GenericasLabel)
        Me.grbEspecificaciones.Controls.Add(Me.GenericasTextBox)
        Me.grbEspecificaciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.grbEspecificaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grbEspecificaciones.Location = New System.Drawing.Point(31, 30)
        Me.grbEspecificaciones.Name = "grbEspecificaciones"
        Me.grbEspecificaciones.Size = New System.Drawing.Size(814, 278)
        Me.grbEspecificaciones.TabIndex = 23
        Me.grbEspecificaciones.TabStop = False
        Me.grbEspecificaciones.Text = "Especificaciones"
        '
        'cmdCerrar
        '
        Me.cmdCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCerrar.Location = New System.Drawing.Point(701, 250)
        Me.cmdCerrar.Name = "cmdCerrar"
        Me.cmdCerrar.Size = New System.Drawing.Size(72, 22)
        Me.cmdCerrar.TabIndex = 16
        Me.cmdCerrar.Text = "BasesParaCompatibilidad.BD.Cerrar"
        Me.cmdCerrar.UseVisualStyleBackColor = True
        '
        'ParticularesTextBox
        '
        Me.ParticularesTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.ParticularesTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ParticularesTextBox.Location = New System.Drawing.Point(12, 155)
        Me.ParticularesTextBox.Multiline = True
        Me.ParticularesTextBox.Name = "ParticularesTextBox"
        Me.ParticularesTextBox.ReadOnly = True
        Me.ParticularesTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.ParticularesTextBox.Size = New System.Drawing.Size(788, 79)
        Me.ParticularesTextBox.TabIndex = 15
        '
        'GenericasTextBox
        '
        Me.GenericasTextBox.BackColor = System.Drawing.SystemColors.Window
        Me.GenericasTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenericasTextBox.Location = New System.Drawing.Point(6, 49)
        Me.GenericasTextBox.Multiline = True
        Me.GenericasTextBox.Name = "GenericasTextBox"
        Me.GenericasTextBox.ReadOnly = True
        Me.GenericasTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.GenericasTextBox.Size = New System.Drawing.Size(788, 79)
        Me.GenericasTextBox.TabIndex = 14
        '
        'tpControlesCalidad
        '
        Me.tpControlesCalidad.Location = New System.Drawing.Point(4, 40)
        Me.tpControlesCalidad.Name = "tpControlesCalidad"
        Me.tpControlesCalidad.Size = New System.Drawing.Size(949, 461)
        Me.tpControlesCalidad.TabIndex = 26
        Me.tpControlesCalidad.Text = "Controles Calidad"
        Me.tpControlesCalidad.UseVisualStyleBackColor = True
        '
        'tpResumen
        '
        Me.tpResumen.Location = New System.Drawing.Point(4, 40)
        Me.tpResumen.Name = "tpResumen"
        Me.tpResumen.Size = New System.Drawing.Size(949, 461)
        Me.tpResumen.TabIndex = 27
        Me.tpResumen.Text = "Resumen"
        Me.tpResumen.UseVisualStyleBackColor = True
        '
        'tpFormatos_empleados
        '
        Me.tpFormatos_empleados.Controls.Add(Me.panEmpleados)
        Me.tpFormatos_empleados.Controls.Add(Me.PanPersonalOcupados)
        Me.tpFormatos_empleados.Location = New System.Drawing.Point(4, 40)
        Me.tpFormatos_empleados.Margin = New System.Windows.Forms.Padding(2)
        Me.tpFormatos_empleados.Name = "tpFormatos_empleados"
        Me.tpFormatos_empleados.Size = New System.Drawing.Size(949, 461)
        Me.tpFormatos_empleados.TabIndex = 28
        Me.tpFormatos_empleados.Text = "Personal en linea"
        Me.tpFormatos_empleados.UseVisualStyleBackColor = True
        '
        'panEmpleados
        '
        Me.panEmpleados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panEmpleados.Location = New System.Drawing.Point(0, 0)
        Me.panEmpleados.Margin = New System.Windows.Forms.Padding(2)
        Me.panEmpleados.Name = "panEmpleados"
        Me.panEmpleados.Size = New System.Drawing.Size(949, 281)
        Me.panEmpleados.TabIndex = 2
        '
        'PanPersonalOcupados
        '
        Me.PanPersonalOcupados.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PanPersonalOcupados.Location = New System.Drawing.Point(0, 281)
        Me.PanPersonalOcupados.Margin = New System.Windows.Forms.Padding(2)
        Me.PanPersonalOcupados.Name = "PanPersonalOcupados"
        Me.PanPersonalOcupados.Size = New System.Drawing.Size(949, 180)
        Me.PanPersonalOcupados.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnModificar)
        Me.Panel2.Controls.Add(Label1)
        Me.Panel2.Controls.Add(Me.cboTipoProducto)
        Me.Panel2.Controls.Add(Label4)
        Me.Panel2.Controls.Add(FormatoLabel)
        Me.Panel2.Controls.Add(Me.cboTipoFormatoID)
        Me.Panel2.Controls.Add(Me.cboTipoFormatoLinea)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(957, 76)
        Me.Panel2.TabIndex = 0
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoProducto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoProducto.FormattingEnabled = True
        Me.cboTipoProducto.Location = New System.Drawing.Point(95, 11)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(330, 21)
        Me.cboTipoProducto.TabIndex = 13
        '
        'cboTipoFormatoID
        '
        Me.cboTipoFormatoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoFormatoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoFormatoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoFormatoID.FormattingEnabled = True
        Me.cboTipoFormatoID.Location = New System.Drawing.Point(95, 43)
        Me.cboTipoFormatoID.Name = "cboTipoFormatoID"
        Me.cboTipoFormatoID.Size = New System.Drawing.Size(788, 21)
        Me.cboTipoFormatoID.TabIndex = 1
        '
        'cboTipoFormatoLinea
        '
        Me.cboTipoFormatoLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoFormatoLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoFormatoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoFormatoLinea.FormattingEnabled = True
        Me.cboTipoFormatoLinea.Location = New System.Drawing.Point(554, 11)
        Me.cboTipoFormatoLinea.Name = "cboTipoFormatoLinea"
        Me.cboTipoFormatoLinea.Size = New System.Drawing.Size(330, 21)
        Me.cboTipoFormatoLinea.TabIndex = 0
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 101)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.tpgProduccion)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(957, 505)
        Me.SplitContainer1.SplitterDistance = 319
        Me.SplitContainer1.TabIndex = 1000000002
        '
        'btnModificar
        '
        Me.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnModificar.FlatAppearance.BorderSize = 0
        Me.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnModificar.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_32
        Me.btnModificar.Location = New System.Drawing.Point(894, 14)
        Me.btnModificar.Name = "btnModificar"
        Me.btnModificar.Size = New System.Drawing.Size(51, 50)
        Me.btnModificar.TabIndex = 15
        Me.btnModificar.UseVisualStyleBackColor = True
        Me.btnModificar.Visible = False
        '
        'frmEntFormatosEnvasados2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(957, 606)
        Me.ControlBox = True
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.lblFormatoEnvasadoID)
        Me.Controls.Add(Me.lblTipoFormatoLineaID)
        Me.Controls.Add(Me.lblEnvasadoID)
        Me.Controls.Add(Me.lblTipoFormatoEnvasadoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = True
        Me.Name = "frmEntFormatosEnvasados2"
        Me.Text = "FormatosEnvasados2"
        Me.Controls.SetChildIndex(Me.lblTipoFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.lblEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.lblTipoFormatoLineaID, 0)
        Me.Controls.SetChildIndex(Me.lblFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgProduccion.ResumeLayout(False)
        Me.tpSeguimientos.ResumeLayout(False)
        CType(Me.dgvSeguimientoProduccion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpEspecificaciones.ResumeLayout(False)
        Me.pnlEspecificaciones.ResumeLayout(False)
        Me.grbEspecificaciones.ResumeLayout(False)
        Me.grbEspecificaciones.PerformLayout()
        Me.tpFormatos_empleados.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblTipoFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblTipoFormatoLineaID As System.Windows.Forms.Label
    Private WithEvents lblEnvasadoID As System.Windows.Forms.Label

    Private WithEvents tpgProduccion As System.Windows.Forms.TabControl
    Private WithEvents tpPalets As System.Windows.Forms.TabPage
    Private WithEvents tpIncidencias As System.Windows.Forms.TabPage
    Private WithEvents tpSeguimientos As System.Windows.Forms.TabPage
    Private WithEvents dgvSeguimientoProduccion As System.Windows.Forms.DataGridView
    Private WithEvents tpPropuestas As System.Windows.Forms.TabPage
    Private WithEvents tpCambiosFormatos As System.Windows.Forms.TabPage
    Private WithEvents tpVelocidad As System.Windows.Forms.TabPage
    Private WithEvents tpProducto As System.Windows.Forms.TabPage
    Private WithEvents tpTrazabilidadMatAux As System.Windows.Forms.TabPage
    Private WithEvents tpTiempoAsignado As System.Windows.Forms.TabPage
    Private WithEvents tpEspecificaciones As System.Windows.Forms.TabPage
    Private WithEvents pnlEspecificaciones As System.Windows.Forms.Panel
    Private WithEvents grbEspecificaciones As System.Windows.Forms.GroupBox
    Private WithEvents cmdCerrar As System.Windows.Forms.Button
   Private WithEvents ParticularesTextBox As System.Windows.Forms.TextBox
   Private WithEvents GenericasTextBox As System.Windows.Forms.TextBox
    Private WithEvents tpControlesCalidad As System.Windows.Forms.TabPage
    Private WithEvents tpResumen As System.Windows.Forms.TabPage
    Private WithEvents tpFormatos_empleados As System.Windows.Forms.TabPage
    Private WithEvents PanPersonalOcupados As System.Windows.Forms.Panel
    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents cboTipoFormatoID As System.Windows.Forms.ComboBox
    Private WithEvents cboTipoFormatoLinea As System.Windows.Forms.ComboBox
    Private WithEvents panEmpleados As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents btnModificar As System.Windows.Forms.Button
End Class
