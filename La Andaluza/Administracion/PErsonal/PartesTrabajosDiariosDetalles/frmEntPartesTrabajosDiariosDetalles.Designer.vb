<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPartesTrabajosDiariosDetalles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPartesTrabajosDiariosDetalles))
        Me.butAddTareasID = New System.Windows.Forms.Button()
        Me.butVerTareasID = New System.Windows.Forms.Button()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblTareasID = New System.Windows.Forms.Label()
        Me.cboTareasID = New System.Windows.Forms.ComboBox()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraFinal = New System.Windows.Forms.Label()
        Me.dtpHoraFinal = New System.Windows.Forms.DateTimePicker()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        '
        'butAddTareasID
        '
        Me.butAddTareasID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTareasID.FlatAppearance.BorderSize = 0
        Me.butAddTareasID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTareasID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTareasID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTareasID.Location = New System.Drawing.Point(729, 4)
        Me.butAddTareasID.Margin = New System.Windows.Forms.Padding(4)
        Me.butAddTareasID.Name = "butAddTareasID"
        Me.butAddTareasID.Size = New System.Drawing.Size(27, 25)
        Me.butAddTareasID.TabIndex = 4
        Me.butAddTareasID.TabStop = False
        '
        'butVerTareasID
        '
        Me.butVerTareasID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTareasID.FlatAppearance.BorderSize = 0
        Me.butVerTareasID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTareasID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTareasID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTareasID.Location = New System.Drawing.Point(694, 4)
        Me.butVerTareasID.Margin = New System.Windows.Forms.Padding(4)
        Me.butVerTareasID.Name = "butVerTareasID"
        Me.butVerTareasID.Size = New System.Drawing.Size(27, 25)
        Me.butVerTareasID.TabIndex = 3
        Me.butVerTareasID.TabStop = False
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMiddle.Controls.Add(Me.lblTareasID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboTareasID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerTareasID, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddTareasID, 4, 2)
        Me.tlpMiddle.Controls.Add(Me.lblHoraInicio, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraInicio, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblHoraFinal, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.dtpHoraFinal, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 5)
        Me.tlpMiddle.Location = New System.Drawing.Point(80, 73)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(776, 143)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(142, 102)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(544, 24)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblTareasID
        '
        Me.lblTareasID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTareasID.Location = New System.Drawing.Point(17, 0)
        Me.lblTareasID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTareasID.Name = "lblTareasID"
        Me.lblTareasID.Size = New System.Drawing.Size(117, 26)
        Me.lblTareasID.TabIndex = 2
        Me.lblTareasID.Text = "Tareas"
        Me.lblTareasID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblTareasID.Visible = False
        '
        'cboTareasID
        '
        Me.cboTareasID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTareasID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTareasID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTareasID.Location = New System.Drawing.Point(142, 4)
        Me.cboTareasID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTareasID.Name = "cboTareasID"
        Me.cboTareasID.Size = New System.Drawing.Size(544, 26)
        Me.cboTareasID.TabIndex = 2
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHoraInicio.Location = New System.Drawing.Point(17, 34)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(117, 26)
        Me.lblHoraInicio.TabIndex = 5
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(142, 38)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(73, 24)
        Me.dtpHoraInicio.TabIndex = 3
        '
        'lblHoraFinal
        '
        Me.lblHoraFinal.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHoraFinal.Location = New System.Drawing.Point(17, 66)
        Me.lblHoraFinal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraFinal.Name = "lblHoraFinal"
        Me.lblHoraFinal.Size = New System.Drawing.Size(117, 26)
        Me.lblHoraFinal.TabIndex = 6
        Me.lblHoraFinal.Text = "Final"
        Me.lblHoraFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHoraFinal
        '
        Me.dtpHoraFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFinal.CustomFormat = "HH:mm"
        Me.dtpHoraFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFinal.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFinal.Location = New System.Drawing.Point(142, 70)
        Me.dtpHoraFinal.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpHoraFinal.Name = "dtpHoraFinal"
        Me.dtpHoraFinal.ShowUpDown = True
        Me.dtpHoraFinal.Size = New System.Drawing.Size(73, 24)
        Me.dtpHoraFinal.TabIndex = 4
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 98)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(117, 26)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntPartesTrabajosDiariosDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(955, 263)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(689, 293)
        Me.Name = "frmEntPartesTrabajosDiariosDetalles"
        Me.Text = "PartesTrabajosDiariosDetalles"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents butAddTareasID As System.Windows.Forms.Button
    Private WithEvents butVerTareasID As System.Windows.Forms.Button
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblTareasID As System.Windows.Forms.Label
    Private WithEvents cboTareasID As System.Windows.Forms.ComboBox
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents lblHoraFinal As System.Windows.Forms.Label
    Private WithEvents dtpHoraFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
End Class
