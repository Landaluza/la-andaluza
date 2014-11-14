<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntCompletado
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.lblCantidadCajas = New System.Windows.Forms.Label()
        Me.txtCantidadCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(38, 24)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraInicio.TabIndex = 8
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(84, 25)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraInicio.TabIndex = 7
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(38, 52)
        Me.lblHoraFin.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(42, 28)
        Me.lblHoraFin.TabIndex = 10
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(84, 54)
        Me.dtpHoraFin.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(86, 21)
        Me.dtpHoraFin.TabIndex = 9
        '
        'lblCantidadCajas
        '
        Me.lblCantidadCajas.Location = New System.Drawing.Point(268, 24)
        Me.lblCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCantidadCajas.Name = "lblCantidadCajas"
        Me.lblCantidadCajas.Size = New System.Drawing.Size(39, 28)
        Me.lblCantidadCajas.TabIndex = 12
        Me.lblCantidadCajas.Text = "Cajas"
        Me.lblCantidadCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadCajas
        '
        Me.txtCantidadCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadCajas.EsUnicoCampo = ""
        Me.txtCantidadCajas.EsUnicoCampoID = ""
        Me.txtCantidadCajas.EsUnicoID = 0
        Me.txtCantidadCajas.EsUnicoTabla = ""
        Me.txtCantidadCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCajas.Location = New System.Drawing.Point(306, 27)
        Me.txtCantidadCajas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCantidadCajas.MaxLength = 9
        Me.txtCantidadCajas.Minimo = 0
        Me.txtCantidadCajas.Modificado = False
        Me.txtCantidadCajas.Name = "txtCantidadCajas"
        Me.txtCantidadCajas.Numerico_EsNumerico = False
        Me.txtCantidadCajas.Numerico_NumeroDoublees = 0
        Me.txtCantidadCajas.Numerico_SeparadorMiles = False
        Me.txtCantidadCajas.Obligatorio = False
        Me.txtCantidadCajas.ParametroID = 0
        Me.txtCantidadCajas.Size = New System.Drawing.Size(101, 21)
        Me.txtCantidadCajas.TabIndex = 11
        Me.txtCantidadCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadCajas.ValorMaximo = 0.0R
        Me.txtCantidadCajas.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(40, 111)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(367, 50)
        Me.txtObservaciones.TabIndex = 13
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(38, 85)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(83, 28)
        Me.lblObservaciones.TabIndex = 14
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntCompletado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(448, 198)
        Me.Controls.Add(Me.lblHoraInicio)
        Me.Controls.Add(Me.dtpHoraInicio)
        Me.Controls.Add(Me.lblHoraFin)
        Me.Controls.Add(Me.dtpHoraFin)
        Me.Controls.Add(Me.lblCantidadCajas)
        Me.Controls.Add(Me.txtCantidadCajas)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmEntCompletado"
        Me.Text = "frmEntCompletado"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents lblCantidadCajas As System.Windows.Forms.Label
    Private WithEvents txtCantidadCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
