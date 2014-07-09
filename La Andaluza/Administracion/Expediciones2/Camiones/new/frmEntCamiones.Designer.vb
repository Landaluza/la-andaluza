<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCamiones
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
        Me.cboAgenciaTransporte = New System.Windows.Forms.ComboBox()
        Me.butVerAgenciaTransporteID = New System.Windows.Forms.Button()
        Me.butAddAgenciaTransporteID = New System.Windows.Forms.Button()
        Me.cboConductorHabitual = New System.Windows.Forms.ComboBox()
        Me.butVerConductorHabitualID = New System.Windows.Forms.Button()
        Me.butAddConductorHabitualID = New System.Windows.Forms.Button()
        Me.cboCamionTipo = New System.Windows.Forms.ComboBox()
        Me.butVerCamionTipoID = New System.Windows.Forms.Button()
        Me.butAddCamionTipoID = New System.Windows.Forms.Button()
        Me.txtMatriculaCabeza = New System.Windows.Forms.TextBox()
        Me.txtMatriculaRemolque = New System.Windows.Forms.TextBox()
        Me.txtTara = New System.Windows.Forms.TextBox()
        Me.txtPesoMaximo = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblAgenciaTransporteID = New System.Windows.Forms.Label()
        Me.lblConductorHabitualID = New System.Windows.Forms.Label()
        Me.lblCamionTipoID = New System.Windows.Forms.Label()
        Me.lblMatriculaCabeza = New System.Windows.Forms.Label()
        Me.lblMatriculaRemolque = New System.Windows.Forms.Label()
        Me.lblTara = New System.Windows.Forms.Label()
        Me.lblPesoMaximo = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAgenciaTransporte
        '
        Me.cboAgenciaTransporte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAgenciaTransporte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAgenciaTransporte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboAgenciaTransporte.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAgenciaTransporte.Location = New System.Drawing.Point(169, 18)
        Me.cboAgenciaTransporte.Name = "cboAgenciaTransporte"
        Me.cboAgenciaTransporte.Size = New System.Drawing.Size(240, 26)
        Me.cboAgenciaTransporte.TabIndex = 0
        '
        'butVerAgenciaTransporteID
        '
        Me.butVerAgenciaTransporteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerAgenciaTransporteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerAgenciaTransporteID.FlatAppearance.BorderSize = 0
        Me.butVerAgenciaTransporteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerAgenciaTransporteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerAgenciaTransporteID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerAgenciaTransporteID.Location = New System.Drawing.Point(415, 18)
        Me.butVerAgenciaTransporteID.Name = "butVerAgenciaTransporteID"
        Me.butVerAgenciaTransporteID.Size = New System.Drawing.Size(24, 31)
        Me.butVerAgenciaTransporteID.TabIndex = 1
        Me.butVerAgenciaTransporteID.TabStop = False
        '
        'butAddAgenciaTransporteID
        '
        Me.butAddAgenciaTransporteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddAgenciaTransporteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddAgenciaTransporteID.FlatAppearance.BorderSize = 0
        Me.butAddAgenciaTransporteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddAgenciaTransporteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddAgenciaTransporteID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddAgenciaTransporteID.Location = New System.Drawing.Point(445, 18)
        Me.butAddAgenciaTransporteID.Name = "butAddAgenciaTransporteID"
        Me.butAddAgenciaTransporteID.Size = New System.Drawing.Size(24, 31)
        Me.butAddAgenciaTransporteID.TabIndex = 2
        Me.butAddAgenciaTransporteID.TabStop = False
        '
        'cboConductorHabitual
        '
        Me.cboConductorHabitual.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboConductorHabitual.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConductorHabitual.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboConductorHabitual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConductorHabitual.Location = New System.Drawing.Point(169, 55)
        Me.cboConductorHabitual.Name = "cboConductorHabitual"
        Me.cboConductorHabitual.Size = New System.Drawing.Size(240, 26)
        Me.cboConductorHabitual.TabIndex = 1
        '
        'butVerConductorHabitualID
        '
        Me.butVerConductorHabitualID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerConductorHabitualID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerConductorHabitualID.FlatAppearance.BorderSize = 0
        Me.butVerConductorHabitualID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerConductorHabitualID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerConductorHabitualID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerConductorHabitualID.Location = New System.Drawing.Point(415, 55)
        Me.butVerConductorHabitualID.Name = "butVerConductorHabitualID"
        Me.butVerConductorHabitualID.Size = New System.Drawing.Size(24, 31)
        Me.butVerConductorHabitualID.TabIndex = 4
        Me.butVerConductorHabitualID.TabStop = False
        '
        'butAddConductorHabitualID
        '
        Me.butAddConductorHabitualID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddConductorHabitualID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddConductorHabitualID.FlatAppearance.BorderSize = 0
        Me.butAddConductorHabitualID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddConductorHabitualID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddConductorHabitualID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddConductorHabitualID.Location = New System.Drawing.Point(445, 55)
        Me.butAddConductorHabitualID.Name = "butAddConductorHabitualID"
        Me.butAddConductorHabitualID.Size = New System.Drawing.Size(24, 31)
        Me.butAddConductorHabitualID.TabIndex = 5
        Me.butAddConductorHabitualID.TabStop = False
        '
        'cboCamionTipo
        '
        Me.cboCamionTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCamionTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCamionTipo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCamionTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCamionTipo.Location = New System.Drawing.Point(169, 92)
        Me.cboCamionTipo.Name = "cboCamionTipo"
        Me.cboCamionTipo.Size = New System.Drawing.Size(240, 26)
        Me.cboCamionTipo.TabIndex = 2
        '
        'butVerCamionTipoID
        '
        Me.butVerCamionTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerCamionTipoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerCamionTipoID.FlatAppearance.BorderSize = 0
        Me.butVerCamionTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerCamionTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerCamionTipoID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerCamionTipoID.Location = New System.Drawing.Point(415, 92)
        Me.butVerCamionTipoID.Name = "butVerCamionTipoID"
        Me.butVerCamionTipoID.Size = New System.Drawing.Size(24, 31)
        Me.butVerCamionTipoID.TabIndex = 7
        Me.butVerCamionTipoID.TabStop = False
        '
        'butAddCamionTipoID
        '
        Me.butAddCamionTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddCamionTipoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddCamionTipoID.FlatAppearance.BorderSize = 0
        Me.butAddCamionTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddCamionTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCamionTipoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddCamionTipoID.Location = New System.Drawing.Point(445, 92)
        Me.butAddCamionTipoID.Name = "butAddCamionTipoID"
        Me.butAddCamionTipoID.Size = New System.Drawing.Size(24, 31)
        Me.butAddCamionTipoID.TabIndex = 8
        Me.butAddCamionTipoID.TabStop = False
        '
        'txtMatriculaCabeza
        '
        Me.txtMatriculaCabeza.BackColor = System.Drawing.SystemColors.Window
        Me.txtMatriculaCabeza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMatriculaCabeza.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaCabeza.Location = New System.Drawing.Point(169, 129)
        Me.txtMatriculaCabeza.MaxLength = 20
        Me.txtMatriculaCabeza.Name = "txtMatriculaCabeza"
        Me.txtMatriculaCabeza.Size = New System.Drawing.Size(240, 24)
        Me.txtMatriculaCabeza.TabIndex = 3
        '
        'txtMatriculaRemolque
        '
        Me.txtMatriculaRemolque.BackColor = System.Drawing.SystemColors.Window
        Me.txtMatriculaRemolque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtMatriculaRemolque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMatriculaRemolque.Location = New System.Drawing.Point(169, 164)
        Me.txtMatriculaRemolque.MaxLength = 20
        Me.txtMatriculaRemolque.Name = "txtMatriculaRemolque"
        Me.txtMatriculaRemolque.Size = New System.Drawing.Size(240, 24)
        Me.txtMatriculaRemolque.TabIndex = 4
        '
        'txtTara
        '
        Me.txtTara.BackColor = System.Drawing.SystemColors.Window
        Me.txtTara.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTara.Location = New System.Drawing.Point(169, 198)
        Me.txtTara.MaxLength = 9
        Me.txtTara.Name = "txtTara"
        Me.txtTara.Size = New System.Drawing.Size(240, 24)
        Me.txtTara.TabIndex = 5
        Me.txtTara.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPesoMaximo
        '
        Me.txtPesoMaximo.BackColor = System.Drawing.SystemColors.Window
        Me.txtPesoMaximo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtPesoMaximo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPesoMaximo.Location = New System.Drawing.Point(169, 233)
        Me.txtPesoMaximo.MaxLength = 9
        Me.txtPesoMaximo.Name = "txtPesoMaximo"
        Me.txtPesoMaximo.Size = New System.Drawing.Size(240, 24)
        Me.txtPesoMaximo.TabIndex = 6
        Me.txtPesoMaximo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(169, 268)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 24)
        Me.txtObservaciones.TabIndex = 7
        '
        'lblAgenciaTransporteID
        '
        Me.lblAgenciaTransporteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAgenciaTransporteID.Location = New System.Drawing.Point(27, 15)
        Me.lblAgenciaTransporteID.Name = "lblAgenciaTransporteID"
        Me.lblAgenciaTransporteID.Size = New System.Drawing.Size(136, 37)
        Me.lblAgenciaTransporteID.TabIndex = 0
        Me.lblAgenciaTransporteID.Text = "AgenciaTransporte"
        Me.lblAgenciaTransporteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConductorHabitualID
        '
        Me.lblConductorHabitualID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConductorHabitualID.Location = New System.Drawing.Point(27, 52)
        Me.lblConductorHabitualID.Name = "lblConductorHabitualID"
        Me.lblConductorHabitualID.Size = New System.Drawing.Size(136, 37)
        Me.lblConductorHabitualID.TabIndex = 3
        Me.lblConductorHabitualID.Text = "ConductorHabitual"
        Me.lblConductorHabitualID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCamionTipoID
        '
        Me.lblCamionTipoID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCamionTipoID.Location = New System.Drawing.Point(27, 89)
        Me.lblCamionTipoID.Name = "lblCamionTipoID"
        Me.lblCamionTipoID.Size = New System.Drawing.Size(136, 37)
        Me.lblCamionTipoID.TabIndex = 6
        Me.lblCamionTipoID.Text = "CamionTipo"
        Me.lblCamionTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMatriculaCabeza
        '
        Me.lblMatriculaCabeza.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatriculaCabeza.Location = New System.Drawing.Point(27, 126)
        Me.lblMatriculaCabeza.Name = "lblMatriculaCabeza"
        Me.lblMatriculaCabeza.Size = New System.Drawing.Size(136, 35)
        Me.lblMatriculaCabeza.TabIndex = 9
        Me.lblMatriculaCabeza.Text = "MatriculaCabeza"
        Me.lblMatriculaCabeza.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMatriculaRemolque
        '
        Me.lblMatriculaRemolque.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblMatriculaRemolque.Location = New System.Drawing.Point(27, 161)
        Me.lblMatriculaRemolque.Name = "lblMatriculaRemolque"
        Me.lblMatriculaRemolque.Size = New System.Drawing.Size(136, 34)
        Me.lblMatriculaRemolque.TabIndex = 10
        Me.lblMatriculaRemolque.Text = "MatriculaRemolque"
        Me.lblMatriculaRemolque.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTara
        '
        Me.lblTara.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTara.Location = New System.Drawing.Point(27, 195)
        Me.lblTara.Name = "lblTara"
        Me.lblTara.Size = New System.Drawing.Size(136, 35)
        Me.lblTara.TabIndex = 11
        Me.lblTara.Text = "Tara"
        Me.lblTara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPesoMaximo
        '
        Me.lblPesoMaximo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPesoMaximo.Location = New System.Drawing.Point(27, 230)
        Me.lblPesoMaximo.Name = "lblPesoMaximo"
        Me.lblPesoMaximo.Size = New System.Drawing.Size(136, 35)
        Me.lblPesoMaximo.TabIndex = 12
        Me.lblPesoMaximo.Text = "PesoMaximo"
        Me.lblPesoMaximo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 265)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(136, 34)
        Me.lblObservaciones.TabIndex = 13
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpMiddle.Controls.Add(Me.lblAgenciaTransporteID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboAgenciaTransporte, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerAgenciaTransporteID, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddAgenciaTransporteID, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblConductorHabitualID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboConductorHabitual, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerConductorHabitualID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddConductorHabitualID, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblCamionTipoID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboCamionTipo, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerCamionTipoID, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddCamionTipoID, 4, 2)
        Me.tlpMiddle.Controls.Add(Me.lblMatriculaCabeza, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtMatriculaCabeza, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblMatriculaRemolque, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtMatriculaRemolque, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblTara, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtTara, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblPesoMaximo, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtPesoMaximo, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 7)
        Me.tlpMiddle.Location = New System.Drawing.Point(54, 28)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(539, 332)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntCamiones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(665, 393)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(568, 348)
        Me.Name = "frmEntCamiones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Camiones"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboAgenciaTransporte As System.Windows.Forms.ComboBox
    Private WithEvents butVerAgenciaTransporteID As System.Windows.Forms.Button
    Private WithEvents butAddAgenciaTransporteID As System.Windows.Forms.Button
    Private WithEvents cboConductorHabitual As System.Windows.Forms.ComboBox
    Private WithEvents butVerConductorHabitualID As System.Windows.Forms.Button
    Private WithEvents butAddConductorHabitualID As System.Windows.Forms.Button
    Private WithEvents cboCamionTipo As System.Windows.Forms.ComboBox
    Private WithEvents butVerCamionTipoID As System.Windows.Forms.Button
    Private WithEvents butAddCamionTipoID As System.Windows.Forms.Button
    Private WithEvents txtMatriculaCabeza As System.Windows.Forms.TextBox
    Private WithEvents txtMatriculaRemolque As System.Windows.Forms.TextBox
    Private WithEvents txtTara As System.Windows.Forms.TextBox
    Private WithEvents txtPesoMaximo As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblAgenciaTransporteID As System.Windows.Forms.Label
    Private WithEvents lblConductorHabitualID As System.Windows.Forms.Label
    Private WithEvents lblCamionTipoID As System.Windows.Forms.Label
    Private WithEvents lblMatriculaCabeza As System.Windows.Forms.Label
    Private WithEvents lblMatriculaRemolque As System.Windows.Forms.Label
    Private WithEvents lblTara As System.Windows.Forms.Label
    Private WithEvents lblPesoMaximo As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
