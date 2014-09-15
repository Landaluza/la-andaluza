<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntReconocimientosMedicosSolicitudes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntReconocimientosMedicosSolicitudes))
        Me.dtpFechaSolicitud = New System.Windows.Forms.DateTimePicker()
        Me.cboReconocimientoMedicoTipo = New System.Windows.Forms.ComboBox()
        Me.butVerReconocimientoMedicoTipoID = New System.Windows.Forms.Button()
        Me.butAddReconocimientoMedicoTipoID = New System.Windows.Forms.Button()
        Me.dtpFechaDeseadaInicio = New System.Windows.Forms.DateTimePicker()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedorID = New System.Windows.Forms.Button()
        Me.butAddProveedorID = New System.Windows.Forms.Button()
        Me.lblFechaSolicitud = New System.Windows.Forms.Label()
        Me.lblReconocimientoMedicoTipoID = New System.Windows.Forms.Label()
        Me.lblFechaDeseadaInicio = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFechaSolicitud
        '
        Me.dtpFechaSolicitud.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaSolicitud.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaSolicitud.Location = New System.Drawing.Point(219, 50)
        Me.dtpFechaSolicitud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaSolicitud.Name = "dtpFechaSolicitud"
        Me.dtpFechaSolicitud.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaSolicitud.TabIndex = 0
        '
        'cboReconocimientoMedicoTipo
        '
        Me.cboReconocimientoMedicoTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboReconocimientoMedicoTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReconocimientoMedicoTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReconocimientoMedicoTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReconocimientoMedicoTipo.Location = New System.Drawing.Point(219, 78)
        Me.cboReconocimientoMedicoTipo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReconocimientoMedicoTipo.Name = "cboReconocimientoMedicoTipo"
        Me.cboReconocimientoMedicoTipo.Size = New System.Drawing.Size(266, 23)
        Me.cboReconocimientoMedicoTipo.TabIndex = 1
        '
        'butVerReconocimientoMedicoTipoID
        '
        Me.butVerReconocimientoMedicoTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerReconocimientoMedicoTipoID.FlatAppearance.BorderSize = 0
        Me.butVerReconocimientoMedicoTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerReconocimientoMedicoTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerReconocimientoMedicoTipoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerReconocimientoMedicoTipoID.Location = New System.Drawing.Point(502, 78)
        Me.butVerReconocimientoMedicoTipoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerReconocimientoMedicoTipoID.Name = "butVerReconocimientoMedicoTipoID"
        Me.butVerReconocimientoMedicoTipoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerReconocimientoMedicoTipoID.TabIndex = 2
        Me.butVerReconocimientoMedicoTipoID.TabStop = False
        '
        'butAddReconocimientoMedicoTipoID
        '
        Me.butAddReconocimientoMedicoTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddReconocimientoMedicoTipoID.FlatAppearance.BorderSize = 0
        Me.butAddReconocimientoMedicoTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddReconocimientoMedicoTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddReconocimientoMedicoTipoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddReconocimientoMedicoTipoID.Location = New System.Drawing.Point(484, 78)
        Me.butAddReconocimientoMedicoTipoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddReconocimientoMedicoTipoID.Name = "butAddReconocimientoMedicoTipoID"
        Me.butAddReconocimientoMedicoTipoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddReconocimientoMedicoTipoID.TabIndex = 3
        Me.butAddReconocimientoMedicoTipoID.TabStop = False
        '
        'dtpFechaDeseadaInicio
        '
        Me.dtpFechaDeseadaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaDeseadaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaDeseadaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaDeseadaInicio.Location = New System.Drawing.Point(219, 108)
        Me.dtpFechaDeseadaInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaDeseadaInicio.Name = "dtpFechaDeseadaInicio"
        Me.dtpFechaDeseadaInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaDeseadaInicio.TabIndex = 2
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(219, 138)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(266, 23)
        Me.cboProveedor.TabIndex = 3
        '
        'butVerProveedorID
        '
        Me.butVerProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProveedorID.FlatAppearance.BorderSize = 0
        Me.butVerProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedorID.Location = New System.Drawing.Point(502, 138)
        Me.butVerProveedorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProveedorID.Name = "butVerProveedorID"
        Me.butVerProveedorID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProveedorID.TabIndex = 6
        Me.butVerProveedorID.TabStop = False
        '
        'butAddProveedorID
        '
        Me.butAddProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProveedorID.FlatAppearance.BorderSize = 0
        Me.butAddProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedorID.Location = New System.Drawing.Point(484, 138)
        Me.butAddProveedorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProveedorID.Name = "butAddProveedorID"
        Me.butAddProveedorID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProveedorID.TabIndex = 7
        Me.butAddProveedorID.TabStop = False
        '
        'lblFechaSolicitud
        '
        Me.lblFechaSolicitud.Location = New System.Drawing.Point(37, 47)
        Me.lblFechaSolicitud.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaSolicitud.Name = "lblFechaSolicitud"
        Me.lblFechaSolicitud.Size = New System.Drawing.Size(170, 28)
        Me.lblFechaSolicitud.TabIndex = 0
        Me.lblFechaSolicitud.Text = "FechaSolicitud"
        Me.lblFechaSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReconocimientoMedicoTipoID
        '
        Me.lblReconocimientoMedicoTipoID.Location = New System.Drawing.Point(37, 76)
        Me.lblReconocimientoMedicoTipoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReconocimientoMedicoTipoID.Name = "lblReconocimientoMedicoTipoID"
        Me.lblReconocimientoMedicoTipoID.Size = New System.Drawing.Size(170, 30)
        Me.lblReconocimientoMedicoTipoID.TabIndex = 1
        Me.lblReconocimientoMedicoTipoID.Text = "ReconocimientoMedicoTipo"
        Me.lblReconocimientoMedicoTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaDeseadaInicio
        '
        Me.lblFechaDeseadaInicio.Location = New System.Drawing.Point(37, 106)
        Me.lblFechaDeseadaInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaDeseadaInicio.Name = "lblFechaDeseadaInicio"
        Me.lblFechaDeseadaInicio.Size = New System.Drawing.Size(170, 28)
        Me.lblFechaDeseadaInicio.TabIndex = 4
        Me.lblFechaDeseadaInicio.Text = "FechaDeseadaInicio"
        Me.lblFechaDeseadaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Location = New System.Drawing.Point(37, 133)
        Me.lblProveedorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(170, 30)
        Me.lblProveedorID.TabIndex = 5
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntReconocimientosMedicosSolicitudes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(592, 184)
        Me.Controls.Add(Me.lblFechaSolicitud)
        Me.Controls.Add(Me.dtpFechaSolicitud)
        Me.Controls.Add(Me.lblReconocimientoMedicoTipoID)
        Me.Controls.Add(Me.cboReconocimientoMedicoTipo)
        Me.Controls.Add(Me.lblProveedorID)
        Me.Controls.Add(Me.butAddProveedorID)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.butVerProveedorID)
        Me.Controls.Add(Me.lblFechaDeseadaInicio)
        Me.Controls.Add(Me.butVerReconocimientoMedicoTipoID)
        Me.Controls.Add(Me.dtpFechaDeseadaInicio)
        Me.Controls.Add(Me.butAddReconocimientoMedicoTipoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntReconocimientosMedicosSolicitudes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReconocimientosMedicosSolicitudes"
        Me.Controls.SetChildIndex(Me.butAddReconocimientoMedicoTipoID, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaDeseadaInicio, 0)
        Me.Controls.SetChildIndex(Me.butVerReconocimientoMedicoTipoID, 0)
        Me.Controls.SetChildIndex(Me.lblFechaDeseadaInicio, 0)
        Me.Controls.SetChildIndex(Me.butVerProveedorID, 0)
        Me.Controls.SetChildIndex(Me.cboProveedor, 0)
        Me.Controls.SetChildIndex(Me.butAddProveedorID, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorID, 0)
        Me.Controls.SetChildIndex(Me.cboReconocimientoMedicoTipo, 0)
        Me.Controls.SetChildIndex(Me.lblReconocimientoMedicoTipoID, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaSolicitud, 0)
        Me.Controls.SetChildIndex(Me.lblFechaSolicitud, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents dtpFechaSolicitud As System.Windows.Forms.DateTimePicker
   Private WithEvents cboReconocimientoMedicoTipo As System.Windows.Forms.ComboBox
   Private WithEvents butVerReconocimientoMedicoTipoID As System.Windows.Forms.Button
   Private WithEvents butAddReconocimientoMedicoTipoID As System.Windows.Forms.Button
   Private WithEvents dtpFechaDeseadaInicio As System.Windows.Forms.DateTimePicker
   Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
   Private WithEvents butVerProveedorID As System.Windows.Forms.Button
   Private WithEvents butAddProveedorID As System.Windows.Forms.Button
   Private WithEvents lblFechaSolicitud As System.Windows.Forms.Label
   Private WithEvents lblReconocimientoMedicoTipoID As System.Windows.Forms.Label
   Private WithEvents lblFechaDeseadaInicio As System.Windows.Forms.Label
   Private WithEvents lblProveedorID As System.Windows.Forms.Label

End Class
