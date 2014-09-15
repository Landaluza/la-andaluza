<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntempleados_contratos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntempleados_contratos))
        Me.dtpfecha_inicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha_final = New System.Windows.Forms.DateTimePicker()
        Me.dtpfecha_baja = New System.Windows.Forms.DateTimePicker()
        Me.txtreferencia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtobservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtruta_documentacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.cboid_tipoContrato = New System.Windows.Forms.ComboBox()
        Me.butVerid_tipoContrato = New System.Windows.Forms.Button()
        Me.butAddid_tipoContrato = New System.Windows.Forms.Button()
        Me.cboid_puestoTrabajo = New System.Windows.Forms.ComboBox()
        Me.butVerid_puestoTrabajo = New System.Windows.Forms.Button()
        Me.butAddid_puestoTrabajo = New System.Windows.Forms.Button()
        Me.lblfecha_inicio = New System.Windows.Forms.Label()
        Me.lblfecha_final = New System.Windows.Forms.Label()
        Me.lblfecha_baja = New System.Windows.Forms.Label()
        Me.lblreferencia = New System.Windows.Forms.Label()
        Me.lblobservaciones = New System.Windows.Forms.Label()
        Me.lblruta_documentacion = New System.Windows.Forms.Label()
        Me.lblid_empleado = New System.Windows.Forms.Label()
        Me.lblid_tipoContrato = New System.Windows.Forms.Label()
        Me.lblid_puestoTrabajo = New System.Windows.Forms.Label()
        Me.cbBaja = New System.Windows.Forms.CheckBox()
        Me.btnruta = New System.Windows.Forms.Button()
        Me.cbFin = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpfecha_inicio
        '
        Me.dtpfecha_inicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpfecha_inicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha_inicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_inicio.Location = New System.Drawing.Point(196, 55)
        Me.dtpfecha_inicio.Name = "dtpfecha_inicio"
        Me.dtpfecha_inicio.Size = New System.Drawing.Size(114, 24)
        Me.dtpfecha_inicio.TabIndex = 2
        '
        'dtpfecha_final
        '
        Me.dtpfecha_final.BackColor = System.Drawing.SystemColors.Window
        Me.dtpfecha_final.Enabled = False
        Me.dtpfecha_final.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha_final.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_final.Location = New System.Drawing.Point(636, 54)
        Me.dtpfecha_final.Name = "dtpfecha_final"
        Me.dtpfecha_final.Size = New System.Drawing.Size(114, 24)
        Me.dtpfecha_final.TabIndex = 4
        '
        'dtpfecha_baja
        '
        Me.dtpfecha_baja.BackColor = System.Drawing.SystemColors.Window
        Me.dtpfecha_baja.Enabled = False
        Me.dtpfecha_baja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha_baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha_baja.Location = New System.Drawing.Point(636, 84)
        Me.dtpfecha_baja.Name = "dtpfecha_baja"
        Me.dtpfecha_baja.Size = New System.Drawing.Size(114, 24)
        Me.dtpfecha_baja.TabIndex = 7
        '
        'txtreferencia
        '
        Me.txtreferencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtreferencia.EsUnicoCampo = ""
        Me.txtreferencia.EsUnicoCampoID = ""
        Me.txtreferencia.EsUnicoID = 0
        Me.txtreferencia.EsUnicoTabla = ""
        Me.txtreferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreferencia.Location = New System.Drawing.Point(196, 127)
        Me.txtreferencia.MaxLength = 50
        Me.txtreferencia.Minimo = 0
        Me.txtreferencia.Modificado = False
        Me.txtreferencia.Name = "txtreferencia"
        Me.txtreferencia.Numerico_EsNumerico = False
        Me.txtreferencia.Numerico_NumeroDoublees = 0
        Me.txtreferencia.Numerico_SeparadorMiles = False
        Me.txtreferencia.Obligatorio = False
        Me.txtreferencia.ParametroID = 0
        Me.txtreferencia.Size = New System.Drawing.Size(240, 24)
        Me.txtreferencia.TabIndex = 9
        Me.txtreferencia.ValorMaximo = 0.0!
        Me.txtreferencia.ValorMinimo = 0.0!
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtobservaciones.EsUnicoCampo = ""
        Me.txtobservaciones.EsUnicoCampoID = ""
        Me.txtobservaciones.EsUnicoID = 0
        Me.txtobservaciones.EsUnicoTabla = ""
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(196, 226)
        Me.txtobservaciones.MaxLength = 1000
        Me.txtobservaciones.Minimo = 0
        Me.txtobservaciones.Modificado = False
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Numerico_EsNumerico = False
        Me.txtobservaciones.Numerico_NumeroDoublees = 0
        Me.txtobservaciones.Numerico_SeparadorMiles = False
        Me.txtobservaciones.Obligatorio = False
        Me.txtobservaciones.ParametroID = 0
        Me.txtobservaciones.Size = New System.Drawing.Size(554, 78)
        Me.txtobservaciones.TabIndex = 19
        Me.txtobservaciones.ValorMaximo = 0.0!
        Me.txtobservaciones.ValorMinimo = 0.0!
        '
        'txtruta_documentacion
        '
        Me.txtruta_documentacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtruta_documentacion.Cursor = System.Windows.Forms.Cursors.No
        Me.txtruta_documentacion.Enabled = False
        Me.txtruta_documentacion.EsUnicoCampo = ""
        Me.txtruta_documentacion.EsUnicoCampoID = ""
        Me.txtruta_documentacion.EsUnicoID = 0
        Me.txtruta_documentacion.EsUnicoTabla = ""
        Me.txtruta_documentacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtruta_documentacion.Location = New System.Drawing.Point(196, 310)
        Me.txtruta_documentacion.MaxLength = 250
        Me.txtruta_documentacion.Minimo = 0
        Me.txtruta_documentacion.Modificado = False
        Me.txtruta_documentacion.Name = "txtruta_documentacion"
        Me.txtruta_documentacion.Numerico_EsNumerico = False
        Me.txtruta_documentacion.Numerico_NumeroDoublees = 0
        Me.txtruta_documentacion.Numerico_SeparadorMiles = False
        Me.txtruta_documentacion.Obligatorio = False
        Me.txtruta_documentacion.ParametroID = 0
        Me.txtruta_documentacion.Size = New System.Drawing.Size(522, 24)
        Me.txtruta_documentacion.TabIndex = 21
        Me.txtruta_documentacion.ValorMaximo = 0.0!
        Me.txtruta_documentacion.ValorMinimo = 0.0!
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.Enabled = False
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(196, 340)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(554, 26)
        Me.cboid_empleado.TabIndex = 23
        Me.cboid_empleado.Visible = False
        '
        'cboid_tipoContrato
        '
        Me.cboid_tipoContrato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_tipoContrato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_tipoContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_tipoContrato.Location = New System.Drawing.Point(196, 157)
        Me.cboid_tipoContrato.Name = "cboid_tipoContrato"
        Me.cboid_tipoContrato.Size = New System.Drawing.Size(240, 26)
        Me.cboid_tipoContrato.TabIndex = 11
        '
        'butVerid_tipoContrato
        '
        Me.butVerid_tipoContrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_tipoContrato.FlatAppearance.BorderSize = 0
        Me.butVerid_tipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_tipoContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_tipoContrato.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_tipoContrato.Location = New System.Drawing.Point(442, 157)
        Me.butVerid_tipoContrato.Name = "butVerid_tipoContrato"
        Me.butVerid_tipoContrato.Size = New System.Drawing.Size(24, 26)
        Me.butVerid_tipoContrato.TabIndex = 12
        Me.butVerid_tipoContrato.TabStop = False
        '
        'butAddid_tipoContrato
        '
        Me.butAddid_tipoContrato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_tipoContrato.FlatAppearance.BorderSize = 0
        Me.butAddid_tipoContrato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_tipoContrato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_tipoContrato.Image = CType(resources.GetObject("butAddid_tipoContrato.Image"), System.Drawing.Image)
        Me.butAddid_tipoContrato.Location = New System.Drawing.Point(472, 157)
        Me.butAddid_tipoContrato.Name = "butAddid_tipoContrato"
        Me.butAddid_tipoContrato.Size = New System.Drawing.Size(24, 26)
        Me.butAddid_tipoContrato.TabIndex = 13
        Me.butAddid_tipoContrato.TabStop = False
        '
        'cboid_puestoTrabajo
        '
        Me.cboid_puestoTrabajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_puestoTrabajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_puestoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_puestoTrabajo.Location = New System.Drawing.Point(196, 194)
        Me.cboid_puestoTrabajo.Name = "cboid_puestoTrabajo"
        Me.cboid_puestoTrabajo.Size = New System.Drawing.Size(240, 26)
        Me.cboid_puestoTrabajo.TabIndex = 15
        '
        'butVerid_puestoTrabajo
        '
        Me.butVerid_puestoTrabajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_puestoTrabajo.FlatAppearance.BorderSize = 0
        Me.butVerid_puestoTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_puestoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_puestoTrabajo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_puestoTrabajo.Location = New System.Drawing.Point(442, 194)
        Me.butVerid_puestoTrabajo.Name = "butVerid_puestoTrabajo"
        Me.butVerid_puestoTrabajo.Size = New System.Drawing.Size(24, 26)
        Me.butVerid_puestoTrabajo.TabIndex = 16
        Me.butVerid_puestoTrabajo.TabStop = False
        '
        'butAddid_puestoTrabajo
        '
        Me.butAddid_puestoTrabajo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_puestoTrabajo.FlatAppearance.BorderSize = 0
        Me.butAddid_puestoTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_puestoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_puestoTrabajo.Image = CType(resources.GetObject("butAddid_puestoTrabajo.Image"), System.Drawing.Image)
        Me.butAddid_puestoTrabajo.Location = New System.Drawing.Point(472, 194)
        Me.butAddid_puestoTrabajo.Name = "butAddid_puestoTrabajo"
        Me.butAddid_puestoTrabajo.Size = New System.Drawing.Size(24, 26)
        Me.butAddid_puestoTrabajo.TabIndex = 17
        Me.butAddid_puestoTrabajo.TabStop = False
        '
        'lblfecha_inicio
        '
        Me.lblfecha_inicio.Location = New System.Drawing.Point(51, 52)
        Me.lblfecha_inicio.Name = "lblfecha_inicio"
        Me.lblfecha_inicio.Size = New System.Drawing.Size(139, 35)
        Me.lblfecha_inicio.TabIndex = 1
        Me.lblfecha_inicio.Text = "Inicio"
        Me.lblfecha_inicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfecha_final
        '
        Me.lblfecha_final.Location = New System.Drawing.Point(491, 51)
        Me.lblfecha_final.Name = "lblfecha_final"
        Me.lblfecha_final.Size = New System.Drawing.Size(139, 35)
        Me.lblfecha_final.TabIndex = 3
        Me.lblfecha_final.Text = "Finalización"
        Me.lblfecha_final.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfecha_baja
        '
        Me.lblfecha_baja.Location = New System.Drawing.Point(491, 81)
        Me.lblfecha_baja.Name = "lblfecha_baja"
        Me.lblfecha_baja.Size = New System.Drawing.Size(139, 34)
        Me.lblfecha_baja.TabIndex = 5
        Me.lblfecha_baja.Text = "Baja"
        Me.lblfecha_baja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblreferencia
        '
        Me.lblreferencia.Location = New System.Drawing.Point(51, 124)
        Me.lblreferencia.Name = "lblreferencia"
        Me.lblreferencia.Size = New System.Drawing.Size(139, 35)
        Me.lblreferencia.TabIndex = 8
        Me.lblreferencia.Text = "Referencia"
        Me.lblreferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblobservaciones
        '
        Me.lblobservaciones.Location = New System.Drawing.Point(51, 223)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(139, 34)
        Me.lblobservaciones.TabIndex = 18
        Me.lblobservaciones.Text = "Observaciones"
        Me.lblobservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblruta_documentacion
        '
        Me.lblruta_documentacion.Location = New System.Drawing.Point(51, 307)
        Me.lblruta_documentacion.Name = "lblruta_documentacion"
        Me.lblruta_documentacion.Size = New System.Drawing.Size(139, 35)
        Me.lblruta_documentacion.TabIndex = 20
        Me.lblruta_documentacion.Text = "Documentacion"
        Me.lblruta_documentacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empleado
        '
        Me.lblid_empleado.Location = New System.Drawing.Point(51, 337)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(139, 37)
        Me.lblid_empleado.TabIndex = 22
        Me.lblid_empleado.Text = "Empleado"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblid_empleado.Visible = False
        '
        'lblid_tipoContrato
        '
        Me.lblid_tipoContrato.Location = New System.Drawing.Point(51, 154)
        Me.lblid_tipoContrato.Name = "lblid_tipoContrato"
        Me.lblid_tipoContrato.Size = New System.Drawing.Size(139, 37)
        Me.lblid_tipoContrato.TabIndex = 10
        Me.lblid_tipoContrato.Text = "Tipo"
        Me.lblid_tipoContrato.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_puestoTrabajo
        '
        Me.lblid_puestoTrabajo.Location = New System.Drawing.Point(51, 191)
        Me.lblid_puestoTrabajo.Name = "lblid_puestoTrabajo"
        Me.lblid_puestoTrabajo.Size = New System.Drawing.Size(139, 37)
        Me.lblid_puestoTrabajo.TabIndex = 14
        Me.lblid_puestoTrabajo.Text = "Puesto"
        Me.lblid_puestoTrabajo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'cbBaja
        '
        Me.cbBaja.AutoSize = True
        Me.cbBaja.Location = New System.Drawing.Point(472, 91)
        Me.cbBaja.Name = "cbBaja"
        Me.cbBaja.Size = New System.Drawing.Size(18, 17)
        Me.cbBaja.TabIndex = 6
        Me.cbBaja.UseVisualStyleBackColor = True
        '
        'btnruta
        '
        Me.btnruta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnruta.FlatAppearance.BorderSize = 0
        Me.btnruta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnruta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.btnruta.Location = New System.Drawing.Point(724, 310)
        Me.btnruta.Name = "btnruta"
        Me.btnruta.Size = New System.Drawing.Size(26, 24)
        Me.btnruta.TabIndex = 24
        Me.btnruta.UseVisualStyleBackColor = True
        '
        'cbFin
        '
        Me.cbFin.AutoSize = True
        Me.cbFin.Location = New System.Drawing.Point(472, 61)
        Me.cbFin.Name = "cbFin"
        Me.cbFin.Size = New System.Drawing.Size(18, 17)
        Me.cbFin.TabIndex = 25
        Me.cbFin.UseVisualStyleBackColor = True
        '
        'frmEntempleados_contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(817, 433)
        Me.Controls.Add(Me.cbFin)
        Me.Controls.Add(Me.btnruta)
        Me.Controls.Add(Me.cbBaja)
        Me.Controls.Add(Me.lblfecha_inicio)
        Me.Controls.Add(Me.dtpfecha_inicio)
        Me.Controls.Add(Me.lblfecha_final)
        Me.Controls.Add(Me.dtpfecha_final)
        Me.Controls.Add(Me.txtreferencia)
        Me.Controls.Add(Me.lblfecha_baja)
        Me.Controls.Add(Me.butAddid_puestoTrabajo)
        Me.Controls.Add(Me.dtpfecha_baja)
        Me.Controls.Add(Me.butVerid_puestoTrabajo)
        Me.Controls.Add(Me.lblreferencia)
        Me.Controls.Add(Me.cboid_puestoTrabajo)
        Me.Controls.Add(Me.lblid_puestoTrabajo)
        Me.Controls.Add(Me.lblobservaciones)
        Me.Controls.Add(Me.butAddid_tipoContrato)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Controls.Add(Me.butVerid_tipoContrato)
        Me.Controls.Add(Me.lblruta_documentacion)
        Me.Controls.Add(Me.cboid_tipoContrato)
        Me.Controls.Add(Me.txtruta_documentacion)
        Me.Controls.Add(Me.lblid_tipoContrato)
        Me.Controls.Add(Me.lblid_empleado)
        Me.Controls.Add(Me.cboid_empleado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntempleados_contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "empleados_contratos"
        Me.Controls.SetChildIndex(Me.cboid_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblid_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblid_tipoContrato, 0)
        Me.Controls.SetChildIndex(Me.txtruta_documentacion, 0)
        Me.Controls.SetChildIndex(Me.cboid_tipoContrato, 0)
        Me.Controls.SetChildIndex(Me.lblruta_documentacion, 0)
        Me.Controls.SetChildIndex(Me.butVerid_tipoContrato, 0)
        Me.Controls.SetChildIndex(Me.txtobservaciones, 0)
        Me.Controls.SetChildIndex(Me.butAddid_tipoContrato, 0)
        Me.Controls.SetChildIndex(Me.lblobservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblid_puestoTrabajo, 0)
        Me.Controls.SetChildIndex(Me.cboid_puestoTrabajo, 0)
        Me.Controls.SetChildIndex(Me.lblreferencia, 0)
        Me.Controls.SetChildIndex(Me.butVerid_puestoTrabajo, 0)
        Me.Controls.SetChildIndex(Me.dtpfecha_baja, 0)
        Me.Controls.SetChildIndex(Me.butAddid_puestoTrabajo, 0)
        Me.Controls.SetChildIndex(Me.lblfecha_baja, 0)
        Me.Controls.SetChildIndex(Me.txtreferencia, 0)
        Me.Controls.SetChildIndex(Me.dtpfecha_final, 0)
        Me.Controls.SetChildIndex(Me.lblfecha_final, 0)
        Me.Controls.SetChildIndex(Me.dtpfecha_inicio, 0)
        Me.Controls.SetChildIndex(Me.lblfecha_inicio, 0)
        Me.Controls.SetChildIndex(Me.cbBaja, 0)
        Me.Controls.SetChildIndex(Me.btnruta, 0)
        Me.Controls.SetChildIndex(Me.cbFin, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpfecha_inicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpfecha_final As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpfecha_baja As System.Windows.Forms.DateTimePicker
    Private WithEvents txtreferencia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtobservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtruta_documentacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents cboid_tipoContrato As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_tipoContrato As System.Windows.Forms.Button
    Private WithEvents butAddid_tipoContrato As System.Windows.Forms.Button
    Private WithEvents cboid_puestoTrabajo As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_puestoTrabajo As System.Windows.Forms.Button
    Private WithEvents butAddid_puestoTrabajo As System.Windows.Forms.Button
    Private WithEvents lblfecha_inicio As System.Windows.Forms.Label
    Private WithEvents lblfecha_final As System.Windows.Forms.Label
    Private WithEvents lblfecha_baja As System.Windows.Forms.Label
    Private WithEvents lblreferencia As System.Windows.Forms.Label
    Private WithEvents lblobservaciones As System.Windows.Forms.Label
    Private WithEvents lblruta_documentacion As System.Windows.Forms.Label
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
    Private WithEvents lblid_tipoContrato As System.Windows.Forms.Label
    Private WithEvents lblid_puestoTrabajo As System.Windows.Forms.Label
    Private WithEvents cbBaja As System.Windows.Forms.CheckBox
   Private WithEvents btnruta As System.Windows.Forms.Button
    Private WithEvents cbFin As System.Windows.Forms.CheckBox
End Class
