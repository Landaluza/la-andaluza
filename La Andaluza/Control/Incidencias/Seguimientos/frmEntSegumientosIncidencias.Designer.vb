<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntSegumientosIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntSegumientosIncidencias))
        Me.cbotipoSeguimiento = New System.Windows.Forms.ComboBox()
        Me.butVerId_tipoSeguimiento = New System.Windows.Forms.Button()
        Me.butAddId_tipoSeguimiento = New System.Windows.Forms.Button()
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.butVerResponsable = New System.Windows.Forms.Button()
        Me.butAddResponsable = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblId_tipoSeguimiento = New System.Windows.Forms.Label()
        Me.lblResponsable = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbotipoSeguimiento
        '
        Me.cbotipoSeguimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbotipoSeguimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotipoSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbotipoSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipoSeguimiento.Location = New System.Drawing.Point(108, 35)
        Me.cbotipoSeguimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbotipoSeguimiento.Name = "cbotipoSeguimiento"
        Me.cbotipoSeguimiento.Size = New System.Drawing.Size(363, 23)
        Me.cbotipoSeguimiento.TabIndex = 1
        '
        'butVerId_tipoSeguimiento
        '
        Me.butVerId_tipoSeguimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_tipoSeguimiento.FlatAppearance.BorderSize = 0
        Me.butVerId_tipoSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_tipoSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_tipoSeguimiento.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_tipoSeguimiento.Location = New System.Drawing.Point(475, 34)
        Me.butVerId_tipoSeguimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_tipoSeguimiento.Name = "butVerId_tipoSeguimiento"
        Me.butVerId_tipoSeguimiento.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_tipoSeguimiento.TabIndex = 4
        Me.butVerId_tipoSeguimiento.TabStop = False
        '
        'butAddId_tipoSeguimiento
        '
        Me.butAddId_tipoSeguimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_tipoSeguimiento.FlatAppearance.BorderSize = 0
        Me.butAddId_tipoSeguimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_tipoSeguimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_tipoSeguimiento.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_tipoSeguimiento.Location = New System.Drawing.Point(497, 33)
        Me.butAddId_tipoSeguimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_tipoSeguimiento.Name = "butAddId_tipoSeguimiento"
        Me.butAddId_tipoSeguimiento.Size = New System.Drawing.Size(18, 23)
        Me.butAddId_tipoSeguimiento.TabIndex = 5
        Me.butAddId_tipoSeguimiento.TabStop = False
        '
        'cboResponsable
        '
        Me.cboResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.Location = New System.Drawing.Point(108, 63)
        Me.cboResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(363, 23)
        Me.cboResponsable.TabIndex = 2
        '
        'butVerResponsable
        '
        Me.butVerResponsable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerResponsable.FlatAppearance.BorderSize = 0
        Me.butVerResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerResponsable.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerResponsable.Location = New System.Drawing.Point(475, 64)
        Me.butVerResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerResponsable.Name = "butVerResponsable"
        Me.butVerResponsable.Size = New System.Drawing.Size(18, 21)
        Me.butVerResponsable.TabIndex = 7
        Me.butVerResponsable.TabStop = False
        '
        'butAddResponsable
        '
        Me.butAddResponsable.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddResponsable.FlatAppearance.BorderSize = 0
        Me.butAddResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddResponsable.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddResponsable.Location = New System.Drawing.Point(497, 64)
        Me.butAddResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddResponsable.Name = "butAddResponsable"
        Me.butAddResponsable.Size = New System.Drawing.Size(18, 21)
        Me.butAddResponsable.TabIndex = 8
        Me.butAddResponsable.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(108, 93)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 3
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
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 123)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(363, 85)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblId_tipoSeguimiento
        '
        Me.lblId_tipoSeguimiento.Location = New System.Drawing.Point(20, 31)
        Me.lblId_tipoSeguimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_tipoSeguimiento.Name = "lblId_tipoSeguimiento"
        Me.lblId_tipoSeguimiento.Size = New System.Drawing.Size(84, 30)
        Me.lblId_tipoSeguimiento.TabIndex = 3
        Me.lblId_tipoSeguimiento.Text = "Tipo"
        Me.lblId_tipoSeguimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblResponsable
        '
        Me.lblResponsable.Location = New System.Drawing.Point(20, 61)
        Me.lblResponsable.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponsable.Name = "lblResponsable"
        Me.lblResponsable.Size = New System.Drawing.Size(84, 30)
        Me.lblResponsable.TabIndex = 6
        Me.lblResponsable.Text = "Responsable"
        Me.lblResponsable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(20, 91)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 9
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 119)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 28)
        Me.lblObservaciones.TabIndex = 10
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntSegumientosIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(538, 236)
        Me.Controls.Add(Me.lblId_tipoSeguimiento)
        Me.Controls.Add(Me.cbotipoSeguimiento)
        Me.Controls.Add(Me.cboResponsable)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.butVerResponsable)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblResponsable)
        Me.Controls.Add(Me.butVerId_tipoSeguimiento)
        Me.Controls.Add(Me.butAddResponsable)
        Me.Controls.Add(Me.butAddId_tipoSeguimiento)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(433, 214)
        Me.Name = "frmEntSegumientosIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "SegumientosIncidencias"
        Me.Controls.SetChildIndex(Me.butAddId_tipoSeguimiento, 0)
        Me.Controls.SetChildIndex(Me.butAddResponsable, 0)
        Me.Controls.SetChildIndex(Me.butVerId_tipoSeguimiento, 0)
        Me.Controls.SetChildIndex(Me.lblResponsable, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.butVerResponsable, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboResponsable, 0)
        Me.Controls.SetChildIndex(Me.cbotipoSeguimiento, 0)
        Me.Controls.SetChildIndex(Me.lblId_tipoSeguimiento, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbotipoSeguimiento As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_tipoSeguimiento As System.Windows.Forms.Button
    Private WithEvents butAddId_tipoSeguimiento As System.Windows.Forms.Button
    Private WithEvents cboResponsable As System.Windows.Forms.ComboBox
    Private WithEvents butVerResponsable As System.Windows.Forms.Button
    Private WithEvents butAddResponsable As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblId_tipoSeguimiento As System.Windows.Forms.Label
    Private WithEvents lblResponsable As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label

End Class
