<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_AccionesCorrectivas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_AccionesCorrectivas))
        Me.cboAccionCorrectiva = New System.Windows.Forms.ComboBox()
        Me.butVerId_AccionCorrectiva = New System.Windows.Forms.Button()
        Me.butAddId_AccionCorrectiva = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.butVerid_empleado = New System.Windows.Forms.Button()
        Me.butAddid_empleado = New System.Windows.Forms.Button()
        Me.dtpFechaPrevista = New System.Windows.Forms.DateTimePicker()
        Me.txtResultados = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbRealizado = New System.Windows.Forms.CheckBox()
        Me.lblId_AccionCorrectiva = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblid_empleado = New System.Windows.Forms.Label()
        Me.lblFechaPrevista = New System.Windows.Forms.Label()
        Me.lblResultados = New System.Windows.Forms.Label()
        Me.lblRealizado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAccionCorrectiva
        '
        Me.cboAccionCorrectiva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAccionCorrectiva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccionCorrectiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAccionCorrectiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccionCorrectiva.Location = New System.Drawing.Point(144, 46)
        Me.cboAccionCorrectiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboAccionCorrectiva.Name = "cboAccionCorrectiva"
        Me.cboAccionCorrectiva.Size = New System.Drawing.Size(333, 23)
        Me.cboAccionCorrectiva.TabIndex = 1
        '
        'butVerId_AccionCorrectiva
        '
        Me.butVerId_AccionCorrectiva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_AccionCorrectiva.FlatAppearance.BorderSize = 0
        Me.butVerId_AccionCorrectiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_AccionCorrectiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_AccionCorrectiva.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_AccionCorrectiva.Location = New System.Drawing.Point(481, 45)
        Me.butVerId_AccionCorrectiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_AccionCorrectiva.Name = "butVerId_AccionCorrectiva"
        Me.butVerId_AccionCorrectiva.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_AccionCorrectiva.TabIndex = 4
        Me.butVerId_AccionCorrectiva.TabStop = False
        '
        'butAddId_AccionCorrectiva
        '
        Me.butAddId_AccionCorrectiva.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_AccionCorrectiva.FlatAppearance.BorderSize = 0
        Me.butAddId_AccionCorrectiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_AccionCorrectiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_AccionCorrectiva.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_AccionCorrectiva.Location = New System.Drawing.Point(503, 45)
        Me.butAddId_AccionCorrectiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_AccionCorrectiva.Name = "butAddId_AccionCorrectiva"
        Me.butAddId_AccionCorrectiva.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_AccionCorrectiva.TabIndex = 5
        Me.butAddId_AccionCorrectiva.TabStop = False
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
        Me.txtObservaciones.Location = New System.Drawing.Point(144, 76)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 3000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(333, 51)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(144, 131)
        Me.cboid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(333, 23)
        Me.cboid_empleado.TabIndex = 3
        '
        'butVerid_empleado
        '
        Me.butVerid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_empleado.FlatAppearance.BorderSize = 0
        Me.butVerid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_empleado.Location = New System.Drawing.Point(481, 130)
        Me.butVerid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_empleado.Name = "butVerid_empleado"
        Me.butVerid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_empleado.TabIndex = 8
        Me.butVerid_empleado.TabStop = False
        '
        'butAddid_empleado
        '
        Me.butAddid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_empleado.FlatAppearance.BorderSize = 0
        Me.butAddid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_empleado.Location = New System.Drawing.Point(503, 130)
        Me.butAddid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_empleado.Name = "butAddid_empleado"
        Me.butAddid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_empleado.TabIndex = 9
        Me.butAddid_empleado.TabStop = False
        '
        'dtpFechaPrevista
        '
        Me.dtpFechaPrevista.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaPrevista.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaPrevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaPrevista.Location = New System.Drawing.Point(144, 161)
        Me.dtpFechaPrevista.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaPrevista.Name = "dtpFechaPrevista"
        Me.dtpFechaPrevista.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaPrevista.TabIndex = 4
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
        Me.txtResultados.Location = New System.Drawing.Point(144, 188)
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
        Me.txtResultados.Size = New System.Drawing.Size(333, 50)
        Me.txtResultados.TabIndex = 5
        Me.txtResultados.ValorMaximo = 0.0R
        Me.txtResultados.ValorMinimo = 0.0R
        '
        'chbRealizado
        '
        Me.chbRealizado.BackColor = System.Drawing.SystemColors.Control
        Me.chbRealizado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbRealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbRealizado.Location = New System.Drawing.Point(144, 243)
        Me.chbRealizado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbRealizado.Name = "chbRealizado"
        Me.chbRealizado.Size = New System.Drawing.Size(180, 20)
        Me.chbRealizado.TabIndex = 6
        Me.chbRealizado.UseVisualStyleBackColor = False
        '
        'lblId_AccionCorrectiva
        '
        Me.lblId_AccionCorrectiva.Location = New System.Drawing.Point(27, 43)
        Me.lblId_AccionCorrectiva.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_AccionCorrectiva.Name = "lblId_AccionCorrectiva"
        Me.lblId_AccionCorrectiva.Size = New System.Drawing.Size(112, 30)
        Me.lblId_AccionCorrectiva.TabIndex = 3
        Me.lblId_AccionCorrectiva.Text = "Accion correctiva"
        Me.lblId_AccionCorrectiva.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 73)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(112, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empleado
        '
        Me.lblid_empleado.Location = New System.Drawing.Point(27, 128)
        Me.lblid_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(112, 30)
        Me.lblid_empleado.TabIndex = 7
        Me.lblid_empleado.Text = "Responsable"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaPrevista
        '
        Me.lblFechaPrevista.Location = New System.Drawing.Point(27, 158)
        Me.lblFechaPrevista.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaPrevista.Name = "lblFechaPrevista"
        Me.lblFechaPrevista.Size = New System.Drawing.Size(112, 28)
        Me.lblFechaPrevista.TabIndex = 10
        Me.lblFechaPrevista.Text = "Fecha prevista"
        Me.lblFechaPrevista.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResultados
        '
        Me.lblResultados.Location = New System.Drawing.Point(27, 186)
        Me.lblResultados.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResultados.Name = "lblResultados"
        Me.lblResultados.Size = New System.Drawing.Size(112, 28)
        Me.lblResultados.TabIndex = 11
        Me.lblResultados.Text = "Resultados"
        Me.lblResultados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRealizado
        '
        Me.lblRealizado.Location = New System.Drawing.Point(27, 240)
        Me.lblRealizado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRealizado.Name = "lblRealizado"
        Me.lblRealizado.Size = New System.Drawing.Size(112, 25)
        Me.lblRealizado.TabIndex = 12
        Me.lblRealizado.Text = "Realizado"
        Me.lblRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntControlIncidencias_AccionesCorrectivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(554, 292)
        Me.Controls.Add(Me.chbRealizado)
        Me.Controls.Add(Me.lblId_AccionCorrectiva)
        Me.Controls.Add(Me.lblRealizado)
        Me.Controls.Add(Me.cboAccionCorrectiva)
        Me.Controls.Add(Me.txtResultados)
        Me.Controls.Add(Me.butVerId_AccionCorrectiva)
        Me.Controls.Add(Me.lblResultados)
        Me.Controls.Add(Me.butAddId_AccionCorrectiva)
        Me.Controls.Add(Me.dtpFechaPrevista)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblFechaPrevista)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.butAddid_empleado)
        Me.Controls.Add(Me.lblid_empleado)
        Me.Controls.Add(Me.butVerid_empleado)
        Me.Controls.Add(Me.cboid_empleado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias_AccionesCorrectivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_AccionesCorrectivas"
        Me.Controls.SetChildIndex(Me.cboid_empleado, 0)
        Me.Controls.SetChildIndex(Me.butVerid_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblid_empleado, 0)
        Me.Controls.SetChildIndex(Me.butAddid_empleado, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblFechaPrevista, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaPrevista, 0)
        Me.Controls.SetChildIndex(Me.butAddId_AccionCorrectiva, 0)
        Me.Controls.SetChildIndex(Me.lblResultados, 0)
        Me.Controls.SetChildIndex(Me.butVerId_AccionCorrectiva, 0)
        Me.Controls.SetChildIndex(Me.txtResultados, 0)
        Me.Controls.SetChildIndex(Me.cboAccionCorrectiva, 0)
        Me.Controls.SetChildIndex(Me.lblRealizado, 0)
        Me.Controls.SetChildIndex(Me.lblId_AccionCorrectiva, 0)
        Me.Controls.SetChildIndex(Me.chbRealizado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboAccionCorrectiva As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_AccionCorrectiva As System.Windows.Forms.Button
    Private WithEvents butAddId_AccionCorrectiva As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_empleado As System.Windows.Forms.Button
    Private WithEvents butAddid_empleado As System.Windows.Forms.Button
    Private WithEvents dtpFechaPrevista As System.Windows.Forms.DateTimePicker
    Private WithEvents txtResultados As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbRealizado As System.Windows.Forms.CheckBox
    Private WithEvents lblId_AccionCorrectiva As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
    Private WithEvents lblFechaPrevista As System.Windows.Forms.Label
    Private WithEvents lblResultados As System.Windows.Forms.Label
    Private WithEvents lblRealizado As System.Windows.Forms.Label
End Class
