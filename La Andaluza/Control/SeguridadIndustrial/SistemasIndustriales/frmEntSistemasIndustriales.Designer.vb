<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntSistemasIndustriales
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntSistemasIndustriales))
        Me.txtSistemaIndustrialID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFechaInstalacion = New System.Windows.Forms.DateTimePicker()
        Me.txtFechaRegistroIndustria = New System.Windows.Forms.DateTimePicker()
        Me.txtReferenciaExpedienteIndustria = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtReferenciaRegistroIndustria = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFechaPresentacionIndustria = New System.Windows.Forms.DateTimePicker()
        Me.txtAutorProyecto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblSistemaIndustrialID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFechaInstalacion = New System.Windows.Forms.Label()
        Me.lblFechaRegistroIndustria = New System.Windows.Forms.Label()
        Me.lblReferenciaExpedienteIndustria = New System.Windows.Forms.Label()
        Me.lblReferenciaRegistroIndustria = New System.Windows.Forms.Label()
        Me.lblFechaPresentacionIndustria = New System.Windows.Forms.Label()
        Me.lblAutorProyecto = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtSistemaIndustrialID
        '
        Me.txtSistemaIndustrialID.BackColor = System.Drawing.SystemColors.Window
        Me.txtSistemaIndustrialID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSistemaIndustrialID.EsUnicoCampo = ""
        Me.txtSistemaIndustrialID.EsUnicoCampoID = ""
        Me.txtSistemaIndustrialID.EsUnicoID = 0
        Me.txtSistemaIndustrialID.EsUnicoTabla = ""
        Me.txtSistemaIndustrialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSistemaIndustrialID.Location = New System.Drawing.Point(193, 3)
        Me.txtSistemaIndustrialID.MaxLength = 9
        Me.txtSistemaIndustrialID.Minimo = 0
        Me.txtSistemaIndustrialID.Modificado = False
        Me.txtSistemaIndustrialID.Name = "txtSistemaIndustrialID"
        Me.txtSistemaIndustrialID.Numerico_EsNumerico = False
        Me.txtSistemaIndustrialID.Numerico_NumeroDoublees = 0
        Me.txtSistemaIndustrialID.Numerico_SeparadorMiles = False
        Me.txtSistemaIndustrialID.Obligatorio = False
        Me.txtSistemaIndustrialID.ParametroID = 0
        Me.txtSistemaIndustrialID.Size = New System.Drawing.Size(56, 21)
        Me.txtSistemaIndustrialID.TabIndex = 0
        Me.txtSistemaIndustrialID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSistemaIndustrialID.ValorMaximo = 0.0R
        Me.txtSistemaIndustrialID.ValorMinimo = 0.0R
        Me.txtSistemaIndustrialID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(193, 30)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtFechaInstalacion
        '
        Me.txtFechaInstalacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaInstalacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaInstalacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaInstalacion.Location = New System.Drawing.Point(193, 57)
        Me.txtFechaInstalacion.Name = "txtFechaInstalacion"
        Me.txtFechaInstalacion.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaInstalacion.TabIndex = 2
        '
        'txtFechaRegistroIndustria
        '
        Me.txtFechaRegistroIndustria.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaRegistroIndustria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaRegistroIndustria.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaRegistroIndustria.Location = New System.Drawing.Point(193, 84)
        Me.txtFechaRegistroIndustria.Name = "txtFechaRegistroIndustria"
        Me.txtFechaRegistroIndustria.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaRegistroIndustria.TabIndex = 3
        '
        'txtReferenciaExpedienteIndustria
        '
        Me.txtReferenciaExpedienteIndustria.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferenciaExpedienteIndustria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferenciaExpedienteIndustria.EsUnicoCampo = ""
        Me.txtReferenciaExpedienteIndustria.EsUnicoCampoID = ""
        Me.txtReferenciaExpedienteIndustria.EsUnicoID = 0
        Me.txtReferenciaExpedienteIndustria.EsUnicoTabla = ""
        Me.txtReferenciaExpedienteIndustria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaExpedienteIndustria.Location = New System.Drawing.Point(193, 111)
        Me.txtReferenciaExpedienteIndustria.MaxLength = 200
        Me.txtReferenciaExpedienteIndustria.Minimo = 0
        Me.txtReferenciaExpedienteIndustria.Modificado = False
        Me.txtReferenciaExpedienteIndustria.Name = "txtReferenciaExpedienteIndustria"
        Me.txtReferenciaExpedienteIndustria.Numerico_EsNumerico = False
        Me.txtReferenciaExpedienteIndustria.Numerico_NumeroDoublees = 0
        Me.txtReferenciaExpedienteIndustria.Numerico_SeparadorMiles = False
        Me.txtReferenciaExpedienteIndustria.Obligatorio = False
        Me.txtReferenciaExpedienteIndustria.ParametroID = 0
        Me.txtReferenciaExpedienteIndustria.Size = New System.Drawing.Size(200, 21)
        Me.txtReferenciaExpedienteIndustria.TabIndex = 4
        Me.txtReferenciaExpedienteIndustria.ValorMaximo = 0.0R
        Me.txtReferenciaExpedienteIndustria.ValorMinimo = 0.0R
        '
        'txtReferenciaRegistroIndustria
        '
        Me.txtReferenciaRegistroIndustria.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferenciaRegistroIndustria.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReferenciaRegistroIndustria.EsUnicoCampo = ""
        Me.txtReferenciaRegistroIndustria.EsUnicoCampoID = ""
        Me.txtReferenciaRegistroIndustria.EsUnicoID = 0
        Me.txtReferenciaRegistroIndustria.EsUnicoTabla = ""
        Me.txtReferenciaRegistroIndustria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferenciaRegistroIndustria.Location = New System.Drawing.Point(193, 138)
        Me.txtReferenciaRegistroIndustria.MaxLength = 200
        Me.txtReferenciaRegistroIndustria.Minimo = 0
        Me.txtReferenciaRegistroIndustria.Modificado = False
        Me.txtReferenciaRegistroIndustria.Name = "txtReferenciaRegistroIndustria"
        Me.txtReferenciaRegistroIndustria.Numerico_EsNumerico = False
        Me.txtReferenciaRegistroIndustria.Numerico_NumeroDoublees = 0
        Me.txtReferenciaRegistroIndustria.Numerico_SeparadorMiles = False
        Me.txtReferenciaRegistroIndustria.Obligatorio = False
        Me.txtReferenciaRegistroIndustria.ParametroID = 0
        Me.txtReferenciaRegistroIndustria.Size = New System.Drawing.Size(200, 21)
        Me.txtReferenciaRegistroIndustria.TabIndex = 5
        Me.txtReferenciaRegistroIndustria.ValorMaximo = 0.0R
        Me.txtReferenciaRegistroIndustria.ValorMinimo = 0.0R
        '
        'txtFechaPresentacionIndustria
        '
        Me.txtFechaPresentacionIndustria.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaPresentacionIndustria.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaPresentacionIndustria.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaPresentacionIndustria.Location = New System.Drawing.Point(193, 165)
        Me.txtFechaPresentacionIndustria.Name = "txtFechaPresentacionIndustria"
        Me.txtFechaPresentacionIndustria.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaPresentacionIndustria.TabIndex = 6
        '
        'txtAutorProyecto
        '
        Me.txtAutorProyecto.BackColor = System.Drawing.SystemColors.Window
        Me.txtAutorProyecto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutorProyecto.EsUnicoCampo = ""
        Me.txtAutorProyecto.EsUnicoCampoID = ""
        Me.txtAutorProyecto.EsUnicoID = 0
        Me.txtAutorProyecto.EsUnicoTabla = ""
        Me.txtAutorProyecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutorProyecto.Location = New System.Drawing.Point(193, 192)
        Me.txtAutorProyecto.MaxLength = 200
        Me.txtAutorProyecto.Minimo = 0
        Me.txtAutorProyecto.Modificado = False
        Me.txtAutorProyecto.Name = "txtAutorProyecto"
        Me.txtAutorProyecto.Numerico_EsNumerico = False
        Me.txtAutorProyecto.Numerico_NumeroDoublees = 0
        Me.txtAutorProyecto.Numerico_SeparadorMiles = False
        Me.txtAutorProyecto.Obligatorio = False
        Me.txtAutorProyecto.ParametroID = 0
        Me.txtAutorProyecto.Size = New System.Drawing.Size(200, 21)
        Me.txtAutorProyecto.TabIndex = 7
        Me.txtAutorProyecto.ValorMaximo = 0.0R
        Me.txtAutorProyecto.ValorMinimo = 0.0R
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
        Me.txtObservaciones.Location = New System.Drawing.Point(193, 219)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 21)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblSistemaIndustrialID
        '
        Me.lblSistemaIndustrialID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSistemaIndustrialID.Location = New System.Drawing.Point(15, 0)
        Me.lblSistemaIndustrialID.Name = "lblSistemaIndustrialID"
        Me.lblSistemaIndustrialID.Size = New System.Drawing.Size(172, 21)
        Me.lblSistemaIndustrialID.TabIndex = 0
        Me.lblSistemaIndustrialID.Text = "SistemaIndustrialID"
        Me.lblSistemaIndustrialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(172, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInstalacion
        '
        Me.lblFechaInstalacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaInstalacion.Location = New System.Drawing.Point(15, 54)
        Me.lblFechaInstalacion.Name = "lblFechaInstalacion"
        Me.lblFechaInstalacion.Size = New System.Drawing.Size(172, 21)
        Me.lblFechaInstalacion.TabIndex = 2
        Me.lblFechaInstalacion.Text = "FechaInstalacion"
        Me.lblFechaInstalacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaRegistroIndustria
        '
        Me.lblFechaRegistroIndustria.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaRegistroIndustria.Location = New System.Drawing.Point(15, 81)
        Me.lblFechaRegistroIndustria.Name = "lblFechaRegistroIndustria"
        Me.lblFechaRegistroIndustria.Size = New System.Drawing.Size(172, 21)
        Me.lblFechaRegistroIndustria.TabIndex = 3
        Me.lblFechaRegistroIndustria.Text = "FechaRegistroIndustria"
        Me.lblFechaRegistroIndustria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReferenciaExpedienteIndustria
        '
        Me.lblReferenciaExpedienteIndustria.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReferenciaExpedienteIndustria.Location = New System.Drawing.Point(15, 108)
        Me.lblReferenciaExpedienteIndustria.Name = "lblReferenciaExpedienteIndustria"
        Me.lblReferenciaExpedienteIndustria.Size = New System.Drawing.Size(172, 21)
        Me.lblReferenciaExpedienteIndustria.TabIndex = 4
        Me.lblReferenciaExpedienteIndustria.Text = "Nº Expediente en Industria"
        Me.lblReferenciaExpedienteIndustria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReferenciaRegistroIndustria
        '
        Me.lblReferenciaRegistroIndustria.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblReferenciaRegistroIndustria.Location = New System.Drawing.Point(15, 135)
        Me.lblReferenciaRegistroIndustria.Name = "lblReferenciaRegistroIndustria"
        Me.lblReferenciaRegistroIndustria.Size = New System.Drawing.Size(172, 21)
        Me.lblReferenciaRegistroIndustria.TabIndex = 5
        Me.lblReferenciaRegistroIndustria.Text = "Nº Registro en Industria"
        Me.lblReferenciaRegistroIndustria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPresentacionIndustria
        '
        Me.lblFechaPresentacionIndustria.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaPresentacionIndustria.Location = New System.Drawing.Point(15, 162)
        Me.lblFechaPresentacionIndustria.Name = "lblFechaPresentacionIndustria"
        Me.lblFechaPresentacionIndustria.Size = New System.Drawing.Size(172, 27)
        Me.lblFechaPresentacionIndustria.TabIndex = 6
        Me.lblFechaPresentacionIndustria.Text = "Fecha de Presentacion en Industria"
        Me.lblFechaPresentacionIndustria.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAutorProyecto
        '
        Me.lblAutorProyecto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAutorProyecto.Location = New System.Drawing.Point(15, 189)
        Me.lblAutorProyecto.Name = "lblAutorProyecto"
        Me.lblAutorProyecto.Size = New System.Drawing.Size(172, 21)
        Me.lblAutorProyecto.TabIndex = 7
        Me.lblAutorProyecto.Text = "AutorProyecto"
        Me.lblAutorProyecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(15, 216)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(172, 21)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.Controls.Add(Me.lblSistemaIndustrialID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtSistemaIndustrialID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFechaInstalacion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtFechaInstalacion, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFechaRegistroIndustria, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtFechaRegistroIndustria, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblReferenciaExpedienteIndustria, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtReferenciaExpedienteIndustria, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblReferenciaRegistroIndustria, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtReferenciaRegistroIndustria, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblFechaPresentacionIndustria, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtFechaPresentacionIndustria, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblAutorProyecto, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtAutorProyecto, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 8)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
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
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(433, 243)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntSistemasIndustriales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(433, 323)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(422, 323)
        Me.Name = "frmEntSistemasIndustriales"
        Me.Text = "SistemasIndustriales"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtSistemaIndustrialID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFechaInstalacion As System.Windows.Forms.DateTimePicker
    Private WithEvents txtFechaRegistroIndustria As System.Windows.Forms.DateTimePicker
    Private WithEvents txtReferenciaExpedienteIndustria As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtReferenciaRegistroIndustria As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFechaPresentacionIndustria As System.Windows.Forms.DateTimePicker
    Private WithEvents txtAutorProyecto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblSistemaIndustrialID As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblFechaInstalacion As System.Windows.Forms.Label
   Private WithEvents lblFechaRegistroIndustria As System.Windows.Forms.Label
   Private WithEvents lblReferenciaExpedienteIndustria As System.Windows.Forms.Label
   Private WithEvents lblReferenciaRegistroIndustria As System.Windows.Forms.Label
   Private WithEvents lblFechaPresentacionIndustria As System.Windows.Forms.Label
   Private WithEvents lblAutorProyecto As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
