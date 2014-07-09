<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposCajas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposCajas))
        Me.txtCodigoQS = New System.Windows.Forms.TextBox()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtCapacidad = New System.Windows.Forms.TextBox()
        Me.cboTipoBotella = New System.Windows.Forms.ComboBox()
        Me.butVerTipoBotellaID = New System.Windows.Forms.Button()
        Me.butAddTipoBotellaID = New System.Windows.Forms.Button()
        Me.cboid_MovimentoEncajado = New System.Windows.Forms.ComboBox()
        Me.butVerid_MovimentoEncajado = New System.Windows.Forms.Button()
        Me.butAddid_MovimentoEncajado = New System.Windows.Forms.Button()
        Me.chbFabricacionPropia = New System.Windows.Forms.CheckBox()
        Me.cboid_tipoEnvase = New System.Windows.Forms.ComboBox()
        Me.butVerid_tipoEnvase = New System.Windows.Forms.Button()
        Me.butAddid_tipoEnvase = New System.Windows.Forms.Button()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblCapacidad = New System.Windows.Forms.Label()
        Me.lblTipoBotellaID = New System.Windows.Forms.Label()
        Me.lblid_MovimentoEncajado = New System.Windows.Forms.Label()
        Me.lblFabricacionPropia = New System.Windows.Forms.Label()
        Me.lblid_tipoEnvase = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(138, 14)
        Me.txtCodigoQS.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCodigoQS.MaxLength = 9
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Size = New System.Drawing.Size(181, 21)
        Me.txtCodigoQS.TabIndex = 0
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(138, 42)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 21)
        Me.txtDescripcion.TabIndex = 1
        '
        'txtCapacidad
        '
        Me.txtCapacidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtCapacidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCapacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCapacidad.Location = New System.Drawing.Point(138, 70)
        Me.txtCapacidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCapacidad.MaxLength = 9
        Me.txtCapacidad.Name = "txtCapacidad"
        Me.txtCapacidad.Size = New System.Drawing.Size(181, 21)
        Me.txtCapacidad.TabIndex = 2
        Me.txtCapacidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cboTipoBotella
        '
        Me.cboTipoBotella.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoBotella.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoBotella.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoBotella.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoBotella.Location = New System.Drawing.Point(138, 98)
        Me.cboTipoBotella.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoBotella.Name = "cboTipoBotella"
        Me.cboTipoBotella.Size = New System.Drawing.Size(181, 23)
        Me.cboTipoBotella.TabIndex = 3
        '
        'butVerTipoBotellaID
        '
        Me.butVerTipoBotellaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoBotellaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerTipoBotellaID.FlatAppearance.BorderSize = 0
        Me.butVerTipoBotellaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoBotellaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoBotellaID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerTipoBotellaID.Location = New System.Drawing.Point(323, 98)
        Me.butVerTipoBotellaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerTipoBotellaID.Name = "butVerTipoBotellaID"
        Me.butVerTipoBotellaID.Size = New System.Drawing.Size(18, 26)
        Me.butVerTipoBotellaID.TabIndex = 4
        Me.butVerTipoBotellaID.TabStop = False
        '
        'butAddTipoBotellaID
        '
        Me.butAddTipoBotellaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoBotellaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoBotellaID.FlatAppearance.BorderSize = 0
        Me.butAddTipoBotellaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoBotellaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoBotellaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoBotellaID.Location = New System.Drawing.Point(345, 98)
        Me.butAddTipoBotellaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddTipoBotellaID.Name = "butAddTipoBotellaID"
        Me.butAddTipoBotellaID.Size = New System.Drawing.Size(18, 26)
        Me.butAddTipoBotellaID.TabIndex = 5
        Me.butAddTipoBotellaID.TabStop = False
        '
        'cboid_MovimentoEncajado
        '
        Me.cboid_MovimentoEncajado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_MovimentoEncajado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_MovimentoEncajado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_MovimentoEncajado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_MovimentoEncajado.Location = New System.Drawing.Point(138, 128)
        Me.cboid_MovimentoEncajado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_MovimentoEncajado.Name = "cboid_MovimentoEncajado"
        Me.cboid_MovimentoEncajado.Size = New System.Drawing.Size(181, 23)
        Me.cboid_MovimentoEncajado.TabIndex = 4
        '
        'butVerid_MovimentoEncajado
        '
        Me.butVerid_MovimentoEncajado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_MovimentoEncajado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerid_MovimentoEncajado.FlatAppearance.BorderSize = 0
        Me.butVerid_MovimentoEncajado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_MovimentoEncajado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_MovimentoEncajado.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerid_MovimentoEncajado.Location = New System.Drawing.Point(323, 128)
        Me.butVerid_MovimentoEncajado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_MovimentoEncajado.Name = "butVerid_MovimentoEncajado"
        Me.butVerid_MovimentoEncajado.Size = New System.Drawing.Size(18, 26)
        Me.butVerid_MovimentoEncajado.TabIndex = 7
        Me.butVerid_MovimentoEncajado.TabStop = False
        '
        'butAddid_MovimentoEncajado
        '
        Me.butAddid_MovimentoEncajado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_MovimentoEncajado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddid_MovimentoEncajado.FlatAppearance.BorderSize = 0
        Me.butAddid_MovimentoEncajado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_MovimentoEncajado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_MovimentoEncajado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_MovimentoEncajado.Location = New System.Drawing.Point(345, 128)
        Me.butAddid_MovimentoEncajado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_MovimentoEncajado.Name = "butAddid_MovimentoEncajado"
        Me.butAddid_MovimentoEncajado.Size = New System.Drawing.Size(18, 26)
        Me.butAddid_MovimentoEncajado.TabIndex = 8
        Me.butAddid_MovimentoEncajado.TabStop = False
        '
        'chbFabricacionPropia
        '
        Me.chbFabricacionPropia.BackColor = System.Drawing.SystemColors.Control
        Me.chbFabricacionPropia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbFabricacionPropia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbFabricacionPropia.Location = New System.Drawing.Point(138, 158)
        Me.chbFabricacionPropia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbFabricacionPropia.Name = "chbFabricacionPropia"
        Me.chbFabricacionPropia.Size = New System.Drawing.Size(181, 21)
        Me.chbFabricacionPropia.TabIndex = 5
        Me.chbFabricacionPropia.UseVisualStyleBackColor = False
        '
        'cboid_tipoEnvase
        '
        Me.cboid_tipoEnvase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_tipoEnvase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_tipoEnvase.Location = New System.Drawing.Point(138, 183)
        Me.cboid_tipoEnvase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_tipoEnvase.Name = "cboid_tipoEnvase"
        Me.cboid_tipoEnvase.Size = New System.Drawing.Size(181, 23)
        Me.cboid_tipoEnvase.TabIndex = 6
        '
        'butVerid_tipoEnvase
        '
        Me.butVerid_tipoEnvase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerid_tipoEnvase.FlatAppearance.BorderSize = 0
        Me.butVerid_tipoEnvase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_tipoEnvase.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerid_tipoEnvase.Location = New System.Drawing.Point(323, 183)
        Me.butVerid_tipoEnvase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_tipoEnvase.Name = "butVerid_tipoEnvase"
        Me.butVerid_tipoEnvase.Size = New System.Drawing.Size(18, 26)
        Me.butVerid_tipoEnvase.TabIndex = 11
        Me.butVerid_tipoEnvase.TabStop = False
        '
        'butAddid_tipoEnvase
        '
        Me.butAddid_tipoEnvase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddid_tipoEnvase.FlatAppearance.BorderSize = 0
        Me.butAddid_tipoEnvase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_tipoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_tipoEnvase.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_tipoEnvase.Location = New System.Drawing.Point(345, 183)
        Me.butAddid_tipoEnvase.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_tipoEnvase.Name = "butAddid_tipoEnvase"
        Me.butAddid_tipoEnvase.Size = New System.Drawing.Size(18, 26)
        Me.butAddid_tipoEnvase.TabIndex = 12
        Me.butAddid_tipoEnvase.TabStop = False
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCodigoQS.Location = New System.Drawing.Point(20, 12)
        Me.lblCodigoQS.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(114, 28)
        Me.lblCodigoQS.TabIndex = 0
        Me.lblCodigoQS.Text = "CodigoQS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 40)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(114, 28)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCapacidad
        '
        Me.lblCapacidad.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCapacidad.Location = New System.Drawing.Point(20, 68)
        Me.lblCapacidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCapacidad.Name = "lblCapacidad"
        Me.lblCapacidad.Size = New System.Drawing.Size(114, 28)
        Me.lblCapacidad.TabIndex = 2
        Me.lblCapacidad.Text = "Capacidad"
        Me.lblCapacidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoBotellaID
        '
        Me.lblTipoBotellaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoBotellaID.Location = New System.Drawing.Point(20, 96)
        Me.lblTipoBotellaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoBotellaID.Name = "lblTipoBotellaID"
        Me.lblTipoBotellaID.Size = New System.Drawing.Size(114, 30)
        Me.lblTipoBotellaID.TabIndex = 3
        Me.lblTipoBotellaID.Text = "Botella"
        Me.lblTipoBotellaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_MovimentoEncajado
        '
        Me.lblid_MovimentoEncajado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_MovimentoEncajado.Location = New System.Drawing.Point(20, 126)
        Me.lblid_MovimentoEncajado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_MovimentoEncajado.Name = "lblid_MovimentoEncajado"
        Me.lblid_MovimentoEncajado.Size = New System.Drawing.Size(114, 30)
        Me.lblid_MovimentoEncajado.TabIndex = 6
        Me.lblid_MovimentoEncajado.Text = "Movimento encajado"
        Me.lblid_MovimentoEncajado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFabricacionPropia
        '
        Me.lblFabricacionPropia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFabricacionPropia.Location = New System.Drawing.Point(20, 156)
        Me.lblFabricacionPropia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFabricacionPropia.Name = "lblFabricacionPropia"
        Me.lblFabricacionPropia.Size = New System.Drawing.Size(114, 25)
        Me.lblFabricacionPropia.TabIndex = 9
        Me.lblFabricacionPropia.Text = "Fabricacion propia"
        Me.lblFabricacionPropia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_tipoEnvase
        '
        Me.lblid_tipoEnvase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_tipoEnvase.Location = New System.Drawing.Point(20, 181)
        Me.lblid_tipoEnvase.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_tipoEnvase.Name = "lblid_tipoEnvase"
        Me.lblid_tipoEnvase.Size = New System.Drawing.Size(114, 30)
        Me.lblid_tipoEnvase.TabIndex = 10
        Me.lblid_tipoEnvase.Text = "Tipo envase"
        Me.lblid_tipoEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblCodigoQS, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtCodigoQS, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblCapacidad, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtCapacidad, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblTipoBotellaID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboTipoBotella, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoBotellaID, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoBotellaID, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblid_MovimentoEncajado, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.cboid_MovimentoEncajado, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.butVerid_MovimentoEncajado, 3, 4)
        Me.tlpMiddle.Controls.Add(Me.butAddid_MovimentoEncajado, 4, 4)
        Me.tlpMiddle.Controls.Add(Me.lblFabricacionPropia, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.chbFabricacionPropia, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblid_tipoEnvase, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.cboid_tipoEnvase, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.butVerid_tipoEnvase, 3, 6)
        Me.tlpMiddle.Controls.Add(Me.butAddid_tipoEnvase, 4, 6)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 24)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(411, 214)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntTiposCajas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(406, 247)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(415, 264)
        Me.Name = "frmEntTiposCajas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposCajas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCodigoQS As System.Windows.Forms.TextBox
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtCapacidad As System.Windows.Forms.TextBox
    Private WithEvents cboTipoBotella As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoBotellaID As System.Windows.Forms.Button
    Private WithEvents butAddTipoBotellaID As System.Windows.Forms.Button
    Private WithEvents cboid_MovimentoEncajado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_MovimentoEncajado As System.Windows.Forms.Button
    Private WithEvents butAddid_MovimentoEncajado As System.Windows.Forms.Button
    Private WithEvents chbFabricacionPropia As System.Windows.Forms.CheckBox
    Private WithEvents cboid_tipoEnvase As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_tipoEnvase As System.Windows.Forms.Button
    Private WithEvents butAddid_tipoEnvase As System.Windows.Forms.Button
    Private WithEvents lblCodigoQS As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblCapacidad As System.Windows.Forms.Label
    Private WithEvents lblTipoBotellaID As System.Windows.Forms.Label
    Private WithEvents lblid_MovimentoEncajado As System.Windows.Forms.Label
    Private WithEvents lblFabricacionPropia As System.Windows.Forms.Label
    Private WithEvents lblid_tipoEnvase As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
