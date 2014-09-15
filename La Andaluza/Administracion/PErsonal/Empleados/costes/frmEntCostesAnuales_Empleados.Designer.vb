<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCostesAnuales_Empleados
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
        Me.txtNormal = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtExtra = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFestivo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTurno = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtNocturnidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.lblNormal = New System.Windows.Forms.Label()
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.lblFestivo = New System.Windows.Forms.Label()
        Me.lblTurno = New System.Windows.Forms.Label()
        Me.lblNocturnidad = New System.Windows.Forms.Label()
        Me.dtpAno = New System.Windows.Forms.DateTimePicker()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtNormal
        '
        Me.txtNormal.BackColor = System.Drawing.SystemColors.Window
        Me.txtNormal.EsUnicoCampo = ""
        Me.txtNormal.EsUnicoCampoID = ""
        Me.txtNormal.EsUnicoID = 0
        Me.txtNormal.EsUnicoTabla = ""
        Me.txtNormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNormal.Location = New System.Drawing.Point(158, 84)
        Me.txtNormal.Minimo = 0
        Me.txtNormal.Modificado = False
        Me.txtNormal.Name = "txtNormal"
        Me.txtNormal.Numerico_EsNumerico = False
        Me.txtNormal.Numerico_NumeroDoublees = 2
        Me.txtNormal.Numerico_SeparadorMiles = False
        Me.txtNormal.Obligatorio = False
        Me.txtNormal.ParametroID = 0
        Me.txtNormal.Size = New System.Drawing.Size(240, 24)
        Me.txtNormal.TabIndex = 2
        Me.txtNormal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNormal.ValorMaximo = 0.0!
        Me.txtNormal.ValorMinimo = 0.0!
        '
        'txtExtra
        '
        Me.txtExtra.BackColor = System.Drawing.SystemColors.Window
        Me.txtExtra.EsUnicoCampo = ""
        Me.txtExtra.EsUnicoCampoID = ""
        Me.txtExtra.EsUnicoID = 0
        Me.txtExtra.EsUnicoTabla = ""
        Me.txtExtra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExtra.Location = New System.Drawing.Point(158, 118)
        Me.txtExtra.Minimo = 0
        Me.txtExtra.Modificado = False
        Me.txtExtra.Name = "txtExtra"
        Me.txtExtra.Numerico_EsNumerico = False
        Me.txtExtra.Numerico_NumeroDoublees = 2
        Me.txtExtra.Numerico_SeparadorMiles = False
        Me.txtExtra.Obligatorio = False
        Me.txtExtra.ParametroID = 0
        Me.txtExtra.Size = New System.Drawing.Size(240, 24)
        Me.txtExtra.TabIndex = 3
        Me.txtExtra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtExtra.ValorMaximo = 0.0!
        Me.txtExtra.ValorMinimo = 0.0!
        '
        'txtFestivo
        '
        Me.txtFestivo.BackColor = System.Drawing.SystemColors.Window
        Me.txtFestivo.EsUnicoCampo = ""
        Me.txtFestivo.EsUnicoCampoID = ""
        Me.txtFestivo.EsUnicoID = 0
        Me.txtFestivo.EsUnicoTabla = ""
        Me.txtFestivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFestivo.Location = New System.Drawing.Point(158, 153)
        Me.txtFestivo.Minimo = 0
        Me.txtFestivo.Modificado = False
        Me.txtFestivo.Name = "txtFestivo"
        Me.txtFestivo.Numerico_EsNumerico = False
        Me.txtFestivo.Numerico_NumeroDoublees = 2
        Me.txtFestivo.Numerico_SeparadorMiles = False
        Me.txtFestivo.Obligatorio = False
        Me.txtFestivo.ParametroID = 0
        Me.txtFestivo.Size = New System.Drawing.Size(240, 24)
        Me.txtFestivo.TabIndex = 4
        Me.txtFestivo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFestivo.ValorMaximo = 0.0!
        Me.txtFestivo.ValorMinimo = 0.0!
        '
        'txtTurno
        '
        Me.txtTurno.BackColor = System.Drawing.SystemColors.Window
        Me.txtTurno.EsUnicoCampo = ""
        Me.txtTurno.EsUnicoCampoID = ""
        Me.txtTurno.EsUnicoID = 0
        Me.txtTurno.EsUnicoTabla = ""
        Me.txtTurno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurno.Location = New System.Drawing.Point(158, 188)
        Me.txtTurno.Minimo = 0
        Me.txtTurno.Modificado = False
        Me.txtTurno.Name = "txtTurno"
        Me.txtTurno.Numerico_EsNumerico = False
        Me.txtTurno.Numerico_NumeroDoublees = 2
        Me.txtTurno.Numerico_SeparadorMiles = False
        Me.txtTurno.Obligatorio = False
        Me.txtTurno.ParametroID = 0
        Me.txtTurno.Size = New System.Drawing.Size(240, 24)
        Me.txtTurno.TabIndex = 5
        Me.txtTurno.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTurno.ValorMaximo = 0.0!
        Me.txtTurno.ValorMinimo = 0.0!
        '
        'txtNocturnidad
        '
        Me.txtNocturnidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtNocturnidad.EsUnicoCampo = ""
        Me.txtNocturnidad.EsUnicoCampoID = ""
        Me.txtNocturnidad.EsUnicoID = 0
        Me.txtNocturnidad.EsUnicoTabla = ""
        Me.txtNocturnidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNocturnidad.Location = New System.Drawing.Point(158, 222)
        Me.txtNocturnidad.Minimo = 0
        Me.txtNocturnidad.Modificado = False
        Me.txtNocturnidad.Name = "txtNocturnidad"
        Me.txtNocturnidad.Numerico_EsNumerico = False
        Me.txtNocturnidad.Numerico_NumeroDoublees = 2
        Me.txtNocturnidad.Numerico_SeparadorMiles = False
        Me.txtNocturnidad.Obligatorio = False
        Me.txtNocturnidad.ParametroID = 0
        Me.txtNocturnidad.Size = New System.Drawing.Size(240, 24)
        Me.txtNocturnidad.TabIndex = 6
        Me.txtNocturnidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNocturnidad.ValorMaximo = 0.0!
        Me.txtNocturnidad.ValorMinimo = 0.0!
        '
        'lblAno
        '
        Me.lblAno.Location = New System.Drawing.Point(65, 51)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(87, 35)
        Me.lblAno.TabIndex = 0
        Me.lblAno.Text = "Fecha inicio"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNormal
        '
        Me.lblNormal.Location = New System.Drawing.Point(65, 81)
        Me.lblNormal.Name = "lblNormal"
        Me.lblNormal.Size = New System.Drawing.Size(87, 34)
        Me.lblNormal.TabIndex = 4
        Me.lblNormal.Text = "Normal"
        Me.lblNormal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblExtra
        '
        Me.lblExtra.Location = New System.Drawing.Point(65, 115)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(87, 35)
        Me.lblExtra.TabIndex = 5
        Me.lblExtra.Text = "Extra"
        Me.lblExtra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFestivo
        '
        Me.lblFestivo.Location = New System.Drawing.Point(65, 150)
        Me.lblFestivo.Name = "lblFestivo"
        Me.lblFestivo.Size = New System.Drawing.Size(87, 35)
        Me.lblFestivo.TabIndex = 6
        Me.lblFestivo.Text = "Festivo"
        Me.lblFestivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTurno
        '
        Me.lblTurno.Location = New System.Drawing.Point(65, 185)
        Me.lblTurno.Name = "lblTurno"
        Me.lblTurno.Size = New System.Drawing.Size(87, 34)
        Me.lblTurno.TabIndex = 7
        Me.lblTurno.Text = "Turno"
        Me.lblTurno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNocturnidad
        '
        Me.lblNocturnidad.Location = New System.Drawing.Point(65, 219)
        Me.lblNocturnidad.Name = "lblNocturnidad"
        Me.lblNocturnidad.Size = New System.Drawing.Size(87, 35)
        Me.lblNocturnidad.TabIndex = 8
        Me.lblNocturnidad.Text = "Nocturnidad"
        Me.lblNocturnidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpAno
        '
        Me.dtpAno.CustomFormat = "dd/mm/yyyy"
        Me.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAno.Location = New System.Drawing.Point(158, 51)
        Me.dtpAno.Name = "dtpAno"
        Me.dtpAno.Size = New System.Drawing.Size(122, 22)
        Me.dtpAno.TabIndex = 1000000001
        '
        'frmEntCostesAnuales_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(478, 287)
        Me.Controls.Add(Me.dtpAno)
        Me.Controls.Add(Me.lblAno)
        Me.Controls.Add(Me.txtFestivo)
        Me.Controls.Add(Me.txtNocturnidad)
        Me.Controls.Add(Me.lblNocturnidad)
        Me.Controls.Add(Me.lblNormal)
        Me.Controls.Add(Me.txtTurno)
        Me.Controls.Add(Me.txtNormal)
        Me.Controls.Add(Me.lblTurno)
        Me.Controls.Add(Me.lblExtra)
        Me.Controls.Add(Me.lblFestivo)
        Me.Controls.Add(Me.txtExtra)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntCostesAnuales_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CostesAnuales_Empleados"
        Me.Controls.SetChildIndex(Me.txtExtra, 0)
        Me.Controls.SetChildIndex(Me.lblFestivo, 0)
        Me.Controls.SetChildIndex(Me.lblExtra, 0)
        Me.Controls.SetChildIndex(Me.lblTurno, 0)
        Me.Controls.SetChildIndex(Me.txtNormal, 0)
        Me.Controls.SetChildIndex(Me.txtTurno, 0)
        Me.Controls.SetChildIndex(Me.lblNormal, 0)
        Me.Controls.SetChildIndex(Me.lblNocturnidad, 0)
        Me.Controls.SetChildIndex(Me.txtNocturnidad, 0)
        Me.Controls.SetChildIndex(Me.txtFestivo, 0)
        Me.Controls.SetChildIndex(Me.lblAno, 0)
        Me.Controls.SetChildIndex(Me.dtpAno, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtNormal As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtExtra As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFestivo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTurno As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNocturnidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblAno As System.Windows.Forms.Label
    Private WithEvents lblNormal As System.Windows.Forms.Label
    Private WithEvents lblExtra As System.Windows.Forms.Label
    Private WithEvents lblFestivo As System.Windows.Forms.Label
    Private WithEvents lblTurno As System.Windows.Forms.Label
    Private WithEvents lblNocturnidad As System.Windows.Forms.Label
    Private WithEvents dtpAno As System.Windows.Forms.DateTimePicker
End Class
