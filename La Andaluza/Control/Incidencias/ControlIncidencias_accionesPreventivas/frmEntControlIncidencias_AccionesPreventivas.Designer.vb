<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_AccionesPreventivas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_AccionesPreventivas))
        Me.cboAccionesPreventivas = New System.Windows.Forms.ComboBox()
        Me.butVerId_AccionesPreventivas = New System.Windows.Forms.Button()
        Me.butAddId_AccionesPreventivas = New System.Windows.Forms.Button()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.dtpFechaPrevista = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.txtResultados = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbRealizado = New System.Windows.Forms.CheckBox()
        Me.lblId_AccionesPreventivas = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblFechaPrevista = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.lblRealizado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAccionesPreventivas
        '
        Me.cboAccionesPreventivas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAccionesPreventivas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccionesPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAccionesPreventivas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccionesPreventivas.Location = New System.Drawing.Point(146, 41)
        Me.cboAccionesPreventivas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboAccionesPreventivas.Name = "cboAccionesPreventivas"
        Me.cboAccionesPreventivas.Size = New System.Drawing.Size(384, 23)
        Me.cboAccionesPreventivas.TabIndex = 1
        '
        'butVerId_AccionesPreventivas
        '
        Me.butVerId_AccionesPreventivas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_AccionesPreventivas.FlatAppearance.BorderSize = 0
        Me.butVerId_AccionesPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_AccionesPreventivas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_AccionesPreventivas.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_AccionesPreventivas.Location = New System.Drawing.Point(534, 41)
        Me.butVerId_AccionesPreventivas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_AccionesPreventivas.Name = "butVerId_AccionesPreventivas"
        Me.butVerId_AccionesPreventivas.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_AccionesPreventivas.TabIndex = 4
        Me.butVerId_AccionesPreventivas.TabStop = False
        '
        'butAddId_AccionesPreventivas
        '
        Me.butAddId_AccionesPreventivas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_AccionesPreventivas.FlatAppearance.BorderSize = 0
        Me.butAddId_AccionesPreventivas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_AccionesPreventivas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_AccionesPreventivas.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_AccionesPreventivas.Location = New System.Drawing.Point(556, 41)
        Me.butAddId_AccionesPreventivas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_AccionesPreventivas.Name = "butAddId_AccionesPreventivas"
        Me.butAddId_AccionesPreventivas.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_AccionesPreventivas.TabIndex = 5
        Me.butAddId_AccionesPreventivas.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(146, 71)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 3000
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(429, 62)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(146, 136)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(384, 23)
        Me.cboempleado.TabIndex = 3
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(534, 137)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_empleado.TabIndex = 8
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(556, 137)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_empleado.TabIndex = 9
        Me.butAddId_empleado.TabStop = False
        '
        'dtpFechaPrevista
        '
        Me.dtpFechaPrevista.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaPrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPrevista.Location = New System.Drawing.Point(146, 167)
        Me.dtpFechaPrevista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaPrevista.Name = "dtpFechaPrevista"
        Me.dtpFechaPrevista.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaPrevista.TabIndex = 4
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(146, 194)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaInicio.TabIndex = 5
        '
        'txtResultados
        '
        Me.txtResultados.BackColor = System.Drawing.SystemColors.Window
        Me.txtResultados.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtResultados.EsUnicoCampo = ""
        Me.txtResultados.EsUnicoCampoID = ""
        Me.txtResultados.EsUnicoID = 0
        Me.txtResultados.EsUnicoTabla = ""
        Me.txtResultados.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtResultados.Location = New System.Drawing.Point(146, 223)
        Me.txtResultados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtResultados.MaxLength = 3000
        Me.txtResultados.Minimo = 0
        Me.txtResultados.Modificado = False
        Me.txtResultados.Multiline = True
        Me.txtResultados.Name = "txtResultados"
        Me.txtResultados.Numerico_EsNumerico = False
        Me.txtResultados.Numerico_NumeroDoublees = 0
        Me.txtResultados.Numerico_SeparadorMiles = False
        Me.txtResultados.Obligatorio = False
        Me.txtResultados.ParametroID = 0
        Me.txtResultados.Size = New System.Drawing.Size(429, 55)
        Me.txtResultados.TabIndex = 6
        Me.txtResultados.ValorMaximo = 0.0R
        Me.txtResultados.ValorMinimo = 0.0R
        '
        'chbRealizado
        '
        Me.chbRealizado.BackColor = System.Drawing.SystemColors.Control
        Me.chbRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRealizado.Location = New System.Drawing.Point(146, 282)
        Me.chbRealizado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbRealizado.Name = "chbRealizado"
        Me.chbRealizado.Size = New System.Drawing.Size(180, 20)
        Me.chbRealizado.TabIndex = 7
        Me.chbRealizado.UseVisualStyleBackColor = False
        '
        'lblId_AccionesPreventivas
        '
        Me.lblId_AccionesPreventivas.Location = New System.Drawing.Point(24, 38)
        Me.lblId_AccionesPreventivas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_AccionesPreventivas.Name = "lblId_AccionesPreventivas"
        Me.lblId_AccionesPreventivas.Size = New System.Drawing.Size(118, 30)
        Me.lblId_AccionesPreventivas.TabIndex = 3
        Me.lblId_AccionesPreventivas.Text = "Acción preventiva"
        Me.lblId_AccionesPreventivas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(24, 68)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(118, 28)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Location = New System.Drawing.Point(24, 134)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(118, 30)
        Me.lblId_empleado.TabIndex = 7
        Me.lblId_empleado.Text = "Responsable"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPrevista
        '
        Me.lblFechaPrevista.Location = New System.Drawing.Point(24, 164)
        Me.lblFechaPrevista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaPrevista.Name = "lblFechaPrevista"
        Me.lblFechaPrevista.Size = New System.Drawing.Size(118, 28)
        Me.lblFechaPrevista.TabIndex = 10
        Me.lblFechaPrevista.Text = "Fecha prevista"
        Me.lblFechaPrevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Location = New System.Drawing.Point(24, 192)
        Me.lblFechaInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(118, 28)
        Me.lblFechaInicio.TabIndex = 11
        Me.lblFechaInicio.Text = "Fecha inicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResultados
        '
        Me.lblResultados.Location = New System.Drawing.Point(24, 220)
        Me.lblResultados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(118, 28)
        Me.lblResultados.TabIndex = 12
        Me.lblResultados.Text = "Resultados"
        Me.lblResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRealizado
        '
        Me.lblRealizado.Location = New System.Drawing.Point(24, 280)
        Me.lblRealizado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRealizado.Name = "lblRealizado"
        Me.lblRealizado.Size = New System.Drawing.Size(118, 25)
        Me.lblRealizado.TabIndex = 13
        Me.lblRealizado.Text = "Realizado"
        Me.lblRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntControlIncidencias_AccionesPreventivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(617, 344)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.cboAccionesPreventivas)
        Me.Controls.Add(Me.lblId_AccionesPreventivas)
        Me.Controls.Add(Me.chbRealizado)
        Me.Controls.Add(Me.lblRealizado)
        Me.Controls.Add(Me.butVerId_AccionesPreventivas)
        Me.Controls.Add(Me.butAddId_AccionesPreventivas)
        Me.Controls.Add(Me.lblResultados)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.dtpFechaInicio)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblFechaInicio)
        Me.Controls.Add(Me.lblId_empleado)
        Me.Controls.Add(Me.dtpFechaPrevista)
        Me.Controls.Add(Me.cboempleado)
        Me.Controls.Add(Me.lblFechaPrevista)
        Me.Controls.Add(Me.butVerId_empleado)
        Me.Controls.Add(Me.butAddId_empleado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(419, 289)
        Me.Name = "frmEntControlIncidencias_AccionesPreventivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_AccionesPreventivas"
        Me.Controls.SetChildIndex(Me.butAddId_empleado, 0)
        Me.Controls.SetChildIndex(Me.butVerId_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblFechaPrevista, 0)
        Me.Controls.SetChildIndex(Me.cboempleado, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaPrevista, 0)
        Me.Controls.SetChildIndex(Me.lblId_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaInicio, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblResultados, 0)
        Me.Controls.SetChildIndex(Me.butAddId_AccionesPreventivas, 0)
        Me.Controls.SetChildIndex(Me.butVerId_AccionesPreventivas, 0)
        Me.Controls.SetChildIndex(Me.lblRealizado, 0)
        Me.Controls.SetChildIndex(Me.chbRealizado, 0)
        Me.Controls.SetChildIndex(Me.lblId_AccionesPreventivas, 0)
        Me.Controls.SetChildIndex(Me.cboAccionesPreventivas, 0)
        Me.Controls.SetChildIndex(Me.txtResultados, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboAccionesPreventivas As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_AccionesPreventivas As System.Windows.Forms.Button
    Private WithEvents butAddId_AccionesPreventivas As System.Windows.Forms.Button
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents dtpFechaPrevista As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents txtResultados As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbRealizado As System.Windows.Forms.CheckBox
    Private WithEvents lblId_AccionesPreventivas As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblFechaPrevista As System.Windows.Forms.Label
    Private WithEvents lblFechaInicio As System.Windows.Forms.Label
    Private WithEvents lblResultados As System.Windows.Forms.Label
    Private WithEvents lblRealizado As System.Windows.Forms.Label
End Class
