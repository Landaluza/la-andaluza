<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTurnosTrabajo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTurnosTrabajo))
        Me.txtTurnoTrabajoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpAno = New System.Windows.Forms.DateTimePicker()
        Me.txtSemana = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblTurnoTrabajoID = New System.Windows.Forms.Label()
        Me.lblAno = New System.Windows.Forms.Label()
        Me.lblSemana = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.lblRutaFichero = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRutaFichero = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtTurnoTrabajoID
        '
        Me.txtTurnoTrabajoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtTurnoTrabajoID.EsUnicoCampo = ""
        Me.txtTurnoTrabajoID.EsUnicoCampoID = ""
        Me.txtTurnoTrabajoID.EsUnicoID = 0
        Me.txtTurnoTrabajoID.EsUnicoTabla = ""
        Me.txtTurnoTrabajoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTurnoTrabajoID.Location = New System.Drawing.Point(102, 3)
        Me.txtTurnoTrabajoID.MaxLength = 9
        Me.txtTurnoTrabajoID.Minimo = 0
        Me.txtTurnoTrabajoID.Modificado = False
        Me.txtTurnoTrabajoID.Name = "txtTurnoTrabajoID"
        Me.txtTurnoTrabajoID.Numerico_EsNumerico = False
        Me.txtTurnoTrabajoID.Numerico_NumeroDoublees = 0
        Me.txtTurnoTrabajoID.Numerico_SeparadorMiles = False
        Me.txtTurnoTrabajoID.Obligatorio = False
        Me.txtTurnoTrabajoID.ParametroID = 0
        Me.txtTurnoTrabajoID.Size = New System.Drawing.Size(56, 21)
        Me.txtTurnoTrabajoID.TabIndex = 0
        Me.txtTurnoTrabajoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTurnoTrabajoID.ValorMaximo = 0.0R
        Me.txtTurnoTrabajoID.ValorMinimo = 0.0R
        Me.txtTurnoTrabajoID.Visible = False
        '
        'dtpAno
        '
        Me.dtpAno.BackColor = System.Drawing.SystemColors.Window
        Me.dtpAno.Dock = System.Windows.Forms.DockStyle.Left
        Me.dtpAno.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpAno.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpAno.Location = New System.Drawing.Point(102, 30)
        Me.dtpAno.Name = "dtpAno"
        Me.dtpAno.Size = New System.Drawing.Size(95, 21)
        Me.dtpAno.TabIndex = 1
        '
        'txtSemana
        '
        Me.txtSemana.BackColor = System.Drawing.SystemColors.Window
        Me.txtSemana.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSemana.Dock = System.Windows.Forms.DockStyle.Left
        Me.txtSemana.EsUnicoCampo = ""
        Me.txtSemana.EsUnicoCampoID = ""
        Me.txtSemana.EsUnicoID = 0
        Me.txtSemana.EsUnicoTabla = ""
        Me.txtSemana.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSemana.Location = New System.Drawing.Point(102, 57)
        Me.txtSemana.MaxLength = 9
        Me.txtSemana.Minimo = 0
        Me.txtSemana.Modificado = False
        Me.txtSemana.Name = "txtSemana"
        Me.txtSemana.Numerico_EsNumerico = False
        Me.txtSemana.Numerico_NumeroDoublees = 0
        Me.txtSemana.Numerico_SeparadorMiles = False
        Me.txtSemana.Obligatorio = False
        Me.txtSemana.ParametroID = 0
        Me.txtSemana.Size = New System.Drawing.Size(56, 21)
        Me.txtSemana.TabIndex = 2
        Me.txtSemana.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSemana.ValorMaximo = 0.0R
        Me.txtSemana.ValorMinimo = 0.0R
        '
        'lblTurnoTrabajoID
        '
        Me.lblTurnoTrabajoID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblTurnoTrabajoID.Location = New System.Drawing.Point(12, 3)
        Me.lblTurnoTrabajoID.Name = "lblTurnoTrabajoID"
        Me.lblTurnoTrabajoID.Size = New System.Drawing.Size(84, 21)
        Me.lblTurnoTrabajoID.TabIndex = 0
        Me.lblTurnoTrabajoID.Text = "TurnoTrabajoID"
        Me.lblTurnoTrabajoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTurnoTrabajoID.Visible = False
        '
        'lblAno
        '
        Me.lblAno.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblAno.Location = New System.Drawing.Point(12, 30)
        Me.lblAno.Name = "lblAno"
        Me.lblAno.Size = New System.Drawing.Size(84, 21)
        Me.lblAno.TabIndex = 1
        Me.lblAno.Text = "Año"
        Me.lblAno.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSemana
        '
        Me.lblSemana.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblSemana.Location = New System.Drawing.Point(12, 57)
        Me.lblSemana.Name = "lblSemana"
        Me.lblSemana.Size = New System.Drawing.Size(84, 21)
        Me.lblSemana.TabIndex = 2
        Me.lblSemana.Text = "Semana"
        Me.lblSemana.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.41844!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 92.84165!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.748373!))
        Me.tlpMiddle.Controls.Add(Me.txtTurnoTrabajoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblAno, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpAno, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblSemana, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtSemana, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblTurnoTrabajoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.lblRutaFichero, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtRutaFichero, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(32, 43)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.Size = New System.Drawing.Size(782, 169)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'lblRutaFichero
        '
        Me.lblRutaFichero.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblRutaFichero.Location = New System.Drawing.Point(12, 84)
        Me.lblRutaFichero.Name = "lblRutaFichero"
        Me.lblRutaFichero.Size = New System.Drawing.Size(84, 21)
        Me.lblRutaFichero.TabIndex = 4
        Me.lblRutaFichero.Text = "RutaFichero"
        Me.lblRutaFichero.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(102, 111)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(636, 55)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtRutaFichero
        '
        Me.txtRutaFichero.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaFichero.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutaFichero.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRutaFichero.EsUnicoCampo = ""
        Me.txtRutaFichero.EsUnicoCampoID = ""
        Me.txtRutaFichero.EsUnicoID = 0
        Me.txtRutaFichero.EsUnicoTabla = ""
        Me.txtRutaFichero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaFichero.Location = New System.Drawing.Point(102, 84)
        Me.txtRutaFichero.MaxLength = 250
        Me.txtRutaFichero.Minimo = 0
        Me.txtRutaFichero.Modificado = False
        Me.txtRutaFichero.Name = "txtRutaFichero"
        Me.txtRutaFichero.Numerico_EsNumerico = False
        Me.txtRutaFichero.Numerico_NumeroDoublees = 0
        Me.txtRutaFichero.Numerico_SeparadorMiles = False
        Me.txtRutaFichero.Obligatorio = False
        Me.txtRutaFichero.ParametroID = 0
        Me.txtRutaFichero.Size = New System.Drawing.Size(636, 21)
        Me.txtRutaFichero.TabIndex = 4
        Me.txtRutaFichero.ValorMaximo = 0.0R
        Me.txtRutaFichero.ValorMinimo = 0.0R
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(744, 84)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(23, 20)
        Me.butRuta.TabIndex = 5
        Me.butRuta.UseVisualStyleBackColor = True
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 108)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 21)
        Me.lblObservaciones.TabIndex = 3
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntTurnosTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(854, 214)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(336, 217)
        Me.Name = "frmEntTurnosTrabajo"
        Me.Text = "TurnosTrabajo"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtTurnoTrabajoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpAno As System.Windows.Forms.DateTimePicker
    Private WithEvents txtSemana As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblTurnoTrabajoID As System.Windows.Forms.Label
    Private WithEvents lblAno As System.Windows.Forms.Label
    Private WithEvents lblSemana As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblRutaFichero As System.Windows.Forms.Label
    Private WithEvents txtRutaFichero As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
