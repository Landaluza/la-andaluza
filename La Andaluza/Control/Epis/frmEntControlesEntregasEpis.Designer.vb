<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlesEntregasEpis
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlesEntregasEpis))
        Me.txtControlEntregaEpiID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFechaEntrega = New System.Windows.Forms.DateTimePicker()
        Me.txtEpiID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEmpleadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEntregaAnteriores = New System.Windows.Forms.CheckBox()
        Me.lblControlEntregaEpiID = New System.Windows.Forms.Label()
        Me.lblFechaEntrega = New System.Windows.Forms.Label()
        Me.lblEpiID = New System.Windows.Forms.Label()
        Me.lblEmpleadoID = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblEntregaAnteriores = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.CboEpis = New System.Windows.Forms.ComboBox()
        Me.CboEmpleados = New System.Windows.Forms.ComboBox()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtControlEntregaEpiID
        '
        Me.txtControlEntregaEpiID.BackColor = System.Drawing.SystemColors.Window
        Me.txtControlEntregaEpiID.EsUnicoCampo = ""
        Me.txtControlEntregaEpiID.EsUnicoCampoID = ""
        Me.txtControlEntregaEpiID.EsUnicoID = 0
        Me.txtControlEntregaEpiID.EsUnicoTabla = ""
        Me.txtControlEntregaEpiID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtControlEntregaEpiID.Location = New System.Drawing.Point(135, 3)
        Me.txtControlEntregaEpiID.MaxLength = 9
        Me.txtControlEntregaEpiID.Minimo = 0
        Me.txtControlEntregaEpiID.Modificado = False
        Me.txtControlEntregaEpiID.Name = "txtControlEntregaEpiID"
        Me.txtControlEntregaEpiID.Numerico_EsNumerico = False
        Me.txtControlEntregaEpiID.Numerico_NumeroDoublees = 0
        Me.txtControlEntregaEpiID.Numerico_SeparadorMiles = False
        Me.txtControlEntregaEpiID.Obligatorio = False
        Me.txtControlEntregaEpiID.ParametroID = 0
        Me.txtControlEntregaEpiID.Size = New System.Drawing.Size(56, 21)
        Me.txtControlEntregaEpiID.TabIndex = 0
        Me.txtControlEntregaEpiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtControlEntregaEpiID.ValorMaximo = 0.0R
        Me.txtControlEntregaEpiID.ValorMinimo = 0.0R
        Me.txtControlEntregaEpiID.Visible = False
        '
        'txtFechaEntrega
        '
        Me.txtFechaEntrega.BackColor = System.Drawing.SystemColors.Window
        Me.txtFechaEntrega.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFechaEntrega.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txtFechaEntrega.Location = New System.Drawing.Point(135, 30)
        Me.txtFechaEntrega.Name = "txtFechaEntrega"
        Me.txtFechaEntrega.Size = New System.Drawing.Size(95, 21)
        Me.txtFechaEntrega.TabIndex = 1
        '
        'txtEpiID
        '
        Me.txtEpiID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEpiID.EsUnicoCampo = ""
        Me.txtEpiID.EsUnicoCampoID = ""
        Me.txtEpiID.EsUnicoID = 0
        Me.txtEpiID.EsUnicoTabla = ""
        Me.txtEpiID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpiID.Location = New System.Drawing.Point(404, 57)
        Me.txtEpiID.MaxLength = 9
        Me.txtEpiID.Minimo = 0
        Me.txtEpiID.Modificado = False
        Me.txtEpiID.Name = "txtEpiID"
        Me.txtEpiID.Numerico_EsNumerico = False
        Me.txtEpiID.Numerico_NumeroDoublees = 0
        Me.txtEpiID.Numerico_SeparadorMiles = False
        Me.txtEpiID.Obligatorio = True
        Me.txtEpiID.ParametroID = 0
        Me.txtEpiID.Size = New System.Drawing.Size(10, 21)
        Me.txtEpiID.TabIndex = 2
        Me.txtEpiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEpiID.ValorMaximo = 0.0R
        Me.txtEpiID.ValorMinimo = 0.0R
        Me.txtEpiID.Visible = False
        '
        'txtEmpleadoID
        '
        Me.txtEmpleadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEmpleadoID.EsUnicoCampo = ""
        Me.txtEmpleadoID.EsUnicoCampoID = ""
        Me.txtEmpleadoID.EsUnicoID = 0
        Me.txtEmpleadoID.EsUnicoTabla = ""
        Me.txtEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmpleadoID.Location = New System.Drawing.Point(404, 84)
        Me.txtEmpleadoID.MaxLength = 9
        Me.txtEmpleadoID.Minimo = 0
        Me.txtEmpleadoID.Modificado = False
        Me.txtEmpleadoID.Name = "txtEmpleadoID"
        Me.txtEmpleadoID.Numerico_EsNumerico = False
        Me.txtEmpleadoID.Numerico_NumeroDoublees = 0
        Me.txtEmpleadoID.Numerico_SeparadorMiles = False
        Me.txtEmpleadoID.Obligatorio = True
        Me.txtEmpleadoID.ParametroID = 0
        Me.txtEmpleadoID.Size = New System.Drawing.Size(10, 21)
        Me.txtEmpleadoID.TabIndex = 3
        Me.txtEmpleadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEmpleadoID.ValorMaximo = 0.0R
        Me.txtEmpleadoID.ValorMinimo = 0.0R
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
        Me.txtObservaciones.Location = New System.Drawing.Point(135, 111)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(257, 14)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtEntregaAnteriores
        '
        Me.txtEntregaAnteriores.BackColor = System.Drawing.SystemColors.Control
        Me.txtEntregaAnteriores.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtEntregaAnteriores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntregaAnteriores.Location = New System.Drawing.Point(135, 138)
        Me.txtEntregaAnteriores.Name = "txtEntregaAnteriores"
        Me.txtEntregaAnteriores.Size = New System.Drawing.Size(16, 21)
        Me.txtEntregaAnteriores.TabIndex = 5
        Me.txtEntregaAnteriores.UseVisualStyleBackColor = False
        '
        'lblControlEntregaEpiID
        '
        Me.lblControlEntregaEpiID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblControlEntregaEpiID.Location = New System.Drawing.Point(17, 0)
        Me.lblControlEntregaEpiID.Name = "lblControlEntregaEpiID"
        Me.lblControlEntregaEpiID.Size = New System.Drawing.Size(112, 21)
        Me.lblControlEntregaEpiID.TabIndex = 0
        Me.lblControlEntregaEpiID.Text = "ControlEntregaEpiID"
        Me.lblControlEntregaEpiID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaEntrega
        '
        Me.lblFechaEntrega.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaEntrega.Location = New System.Drawing.Point(17, 27)
        Me.lblFechaEntrega.Name = "lblFechaEntrega"
        Me.lblFechaEntrega.Size = New System.Drawing.Size(112, 21)
        Me.lblFechaEntrega.TabIndex = 1
        Me.lblFechaEntrega.Text = "FechaEntrega"
        Me.lblFechaEntrega.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEpiID
        '
        Me.lblEpiID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEpiID.Location = New System.Drawing.Point(17, 54)
        Me.lblEpiID.Name = "lblEpiID"
        Me.lblEpiID.Size = New System.Drawing.Size(112, 21)
        Me.lblEpiID.TabIndex = 2
        Me.lblEpiID.Text = "EpiID"
        Me.lblEpiID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpleadoID
        '
        Me.lblEmpleadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEmpleadoID.Location = New System.Drawing.Point(17, 81)
        Me.lblEmpleadoID.Name = "lblEmpleadoID"
        Me.lblEmpleadoID.Size = New System.Drawing.Size(112, 21)
        Me.lblEmpleadoID.TabIndex = 3
        Me.lblEmpleadoID.Text = "EmpleadoID"
        Me.lblEmpleadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(17, 108)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(112, 21)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntregaAnteriores
        '
        Me.lblEntregaAnteriores.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEntregaAnteriores.Location = New System.Drawing.Point(17, 135)
        Me.lblEntregaAnteriores.Name = "lblEntregaAnteriores"
        Me.lblEntregaAnteriores.Size = New System.Drawing.Size(112, 21)
        Me.lblEntregaAnteriores.TabIndex = 5
        Me.lblEntregaAnteriores.Text = "EntregaAnteriores"
        Me.lblEntregaAnteriores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.26217!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.868914!))
        Me.tlpMiddle.Controls.Add(Me.lblControlEntregaEpiID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtControlEntregaEpiID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFechaEntrega, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtFechaEntrega, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblEpiID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.lblEmpleadoID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblEntregaAnteriores, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtEntregaAnteriores, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.CboEpis, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.CboEmpleados, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.txtEmpleadoID, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.txtEpiID, 3, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(417, 178)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'CboEpis
        '
        Me.CboEpis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEpis.FormattingEnabled = True
        Me.CboEpis.Location = New System.Drawing.Point(135, 57)
        Me.CboEpis.Name = "CboEpis"
        Me.CboEpis.Size = New System.Drawing.Size(257, 21)
        Me.CboEpis.TabIndex = 6
        '
        'CboEmpleados
        '
        Me.CboEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CboEmpleados.FormattingEnabled = True
        Me.CboEmpleados.Location = New System.Drawing.Point(135, 84)
        Me.CboEmpleados.Name = "CboEmpleados"
        Me.CboEmpleados.Size = New System.Drawing.Size(257, 21)
        Me.CboEmpleados.TabIndex = 7
        '
        'tlpTop
        '




        '
        'frmEntControlesEntregasEpis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(417, 220)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlesEntregasEpis"
        Me.Text = "ControlesEntregasEpis"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtControlEntregaEpiID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFechaEntrega As System.Windows.Forms.DateTimePicker
    Private WithEvents txtEpiID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEmpleadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents txtEntregaAnteriores As System.Windows.Forms.CheckBox
   Private WithEvents lblControlEntregaEpiID As System.Windows.Forms.Label
   Private WithEvents lblFechaEntrega As System.Windows.Forms.Label
   Private WithEvents lblEpiID As System.Windows.Forms.Label
   Private WithEvents lblEmpleadoID As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblEntregaAnteriores As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

   Private WithEvents CboEpis As System.Windows.Forms.ComboBox
   Private WithEvents CboEmpleados As System.Windows.Forms.ComboBox
End Class
