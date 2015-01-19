<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPeriodosServicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPeriodosServicio))
        Me.cboMotivoCeseServicio = New System.Windows.Forms.ComboBox()
        Me.butVerMotivoCeseServicioID = New System.Windows.Forms.Button()
        Me.butAddMotivoCeseServicioID = New System.Windows.Forms.Button()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblMotivoCeseServicioID = New System.Windows.Forms.Label()
        Me.lblDesde = New System.Windows.Forms.Label()
        Me.lblHasta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboMotivoCeseServicio
        '
        Me.cboMotivoCeseServicio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMotivoCeseServicio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMotivoCeseServicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboMotivoCeseServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMotivoCeseServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMotivoCeseServicio.Location = New System.Drawing.Point(135, 14)
        Me.cboMotivoCeseServicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMotivoCeseServicio.Name = "cboMotivoCeseServicio"
        Me.cboMotivoCeseServicio.Size = New System.Drawing.Size(181, 23)
        Me.cboMotivoCeseServicio.TabIndex = 0
        '
        'butVerMotivoCeseServicioID
        '
        Me.butVerMotivoCeseServicioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerMotivoCeseServicioID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerMotivoCeseServicioID.FlatAppearance.BorderSize = 0
        Me.butVerMotivoCeseServicioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerMotivoCeseServicioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerMotivoCeseServicioID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerMotivoCeseServicioID.Location = New System.Drawing.Point(320, 14)
        Me.butVerMotivoCeseServicioID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerMotivoCeseServicioID.Name = "butVerMotivoCeseServicioID"
        Me.butVerMotivoCeseServicioID.Size = New System.Drawing.Size(18, 26)
        Me.butVerMotivoCeseServicioID.TabIndex = 1
        Me.butVerMotivoCeseServicioID.TabStop = False
        '
        'butAddMotivoCeseServicioID
        '
        Me.butAddMotivoCeseServicioID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddMotivoCeseServicioID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddMotivoCeseServicioID.FlatAppearance.BorderSize = 0
        Me.butAddMotivoCeseServicioID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMotivoCeseServicioID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMotivoCeseServicioID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMotivoCeseServicioID.Location = New System.Drawing.Point(342, 14)
        Me.butAddMotivoCeseServicioID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddMotivoCeseServicioID.Name = "butAddMotivoCeseServicioID"
        Me.butAddMotivoCeseServicioID.Size = New System.Drawing.Size(18, 26)
        Me.butAddMotivoCeseServicioID.TabIndex = 2
        Me.butAddMotivoCeseServicioID.TabStop = False
        '
        'dtpDesde
        '
        Me.dtpDesde.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDesde.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(135, 44)
        Me.dtpDesde.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(86, 21)
        Me.dtpDesde.TabIndex = 1
        '
        'dtpHasta
        '
        Me.dtpHasta.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHasta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(135, 72)
        Me.dtpHasta.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(86, 21)
        Me.dtpHasta.TabIndex = 2
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(135, 100)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 150
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(253, 21)
        Me.txtObservaciones.TabIndex = 3
        '
        'lblMotivoCeseServicioID
        '
        Me.lblMotivoCeseServicioID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMotivoCeseServicioID.Location = New System.Drawing.Point(20, 12)
        Me.lblMotivoCeseServicioID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMotivoCeseServicioID.Name = "lblMotivoCeseServicioID"
        Me.lblMotivoCeseServicioID.Size = New System.Drawing.Size(111, 30)
        Me.lblMotivoCeseServicioID.TabIndex = 0
        Me.lblMotivoCeseServicioID.Text = "MotivoCeseServicio"
        Me.lblMotivoCeseServicioID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDesde
        '
        Me.lblDesde.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDesde.Location = New System.Drawing.Point(20, 42)
        Me.lblDesde.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDesde.Name = "lblDesde"
        Me.lblDesde.Size = New System.Drawing.Size(111, 28)
        Me.lblDesde.TabIndex = 3
        Me.lblDesde.Text = "Desde"
        Me.lblDesde.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHasta
        '
        Me.lblHasta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblHasta.Location = New System.Drawing.Point(20, 70)
        Me.lblHasta.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblHasta.Name = "lblHasta"
        Me.lblHasta.Size = New System.Drawing.Size(111, 28)
        Me.lblHasta.TabIndex = 4
        Me.lblHasta.Text = "Hasta"
        Me.lblHasta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 98)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(111, 28)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpMiddle.Controls.Add(Me.lblMotivoCeseServicioID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboMotivoCeseServicio, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerMotivoCeseServicioID, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddMotivoCeseServicioID, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDesde, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpDesde, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblHasta, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpHasta, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 3)
        Me.tlpMiddle.Location = New System.Drawing.Point(28, 34)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(408, 143)
        Me.tlpMiddle.TabIndex = 8
        '
        '
        'frmEntPeriodosServicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(479, 194)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPeriodosServicio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PeriodosServicio"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboMotivoCeseServicio As System.Windows.Forms.ComboBox
    Private WithEvents butVerMotivoCeseServicioID As System.Windows.Forms.Button
    Private WithEvents butAddMotivoCeseServicioID As System.Windows.Forms.Button
    Private WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblMotivoCeseServicioID As System.Windows.Forms.Label
    Private WithEvents lblDesde As System.Windows.Forms.Label
    Private WithEvents lblHasta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
