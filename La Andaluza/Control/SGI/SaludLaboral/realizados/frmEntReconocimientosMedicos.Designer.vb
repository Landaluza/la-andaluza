<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntReconocimientosMedicos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntReconocimientosMedicos))
        Me.cboReconocimientoMedicoSolicitudEmpleado = New System.Windows.Forms.ComboBox()
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID = New System.Windows.Forms.Button()
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID = New System.Windows.Forms.Button()
        Me.dtpFechaRealizado = New System.Windows.Forms.DateTimePicker()
        Me.chbApto = New System.Windows.Forms.CheckBox()
        Me.cboid_grupo_riesgo = New System.Windows.Forms.ComboBox()
        Me.butVerid_grupo_riesgo = New System.Windows.Forms.Button()
        Me.butAddid_grupo_riesgo = New System.Windows.Forms.Button()
        Me.cboid_medico = New System.Windows.Forms.ComboBox()
        Me.butVerid_medico = New System.Windows.Forms.Button()
        Me.butAddid_medico = New System.Windows.Forms.Button()
        Me.lblReconocimientoMedicoSolicitudEmpleadoID = New System.Windows.Forms.Label()
        Me.lblFechaRealizado = New System.Windows.Forms.Label()
        Me.lblApto = New System.Windows.Forms.Label()
        Me.lblid_grupo_riesgo = New System.Windows.Forms.Label()
        Me.lblid_medico = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboReconocimientoMedicoSolicitudEmpleado
        '
        Me.cboReconocimientoMedicoSolicitudEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboReconocimientoMedicoSolicitudEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReconocimientoMedicoSolicitudEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReconocimientoMedicoSolicitudEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReconocimientoMedicoSolicitudEmpleado.Location = New System.Drawing.Point(142, 47)
        Me.cboReconocimientoMedicoSolicitudEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReconocimientoMedicoSolicitudEmpleado.Name = "cboReconocimientoMedicoSolicitudEmpleado"
        Me.cboReconocimientoMedicoSolicitudEmpleado.Size = New System.Drawing.Size(284, 23)
        Me.cboReconocimientoMedicoSolicitudEmpleado.TabIndex = 0
        '
        'butVerReconocimientoMedicoSolicitudEmpleadoID
        '
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.FlatAppearance.BorderSize = 0
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Location = New System.Drawing.Point(430, 47)
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Name = "butVerReconocimientoMedicoSolicitudEmpleadoID"
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.TabIndex = 1
        Me.butVerReconocimientoMedicoSolicitudEmpleadoID.TabStop = False
        '
        'butAddReconocimientoMedicoSolicitudEmpleadoID
        '
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.FlatAppearance.BorderSize = 0
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Location = New System.Drawing.Point(452, 47)
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Name = "butAddReconocimientoMedicoSolicitudEmpleadoID"
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.TabIndex = 2
        Me.butAddReconocimientoMedicoSolicitudEmpleadoID.TabStop = False
        '
        'dtpFechaRealizado
        '
        Me.dtpFechaRealizado.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaRealizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaRealizado.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaRealizado.Location = New System.Drawing.Point(142, 78)
        Me.dtpFechaRealizado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaRealizado.Name = "dtpFechaRealizado"
        Me.dtpFechaRealizado.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaRealizado.TabIndex = 1
        '
        'chbApto
        '
        Me.chbApto.BackColor = System.Drawing.SystemColors.Control
        Me.chbApto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbApto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbApto.Location = New System.Drawing.Point(142, 106)
        Me.chbApto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbApto.Name = "chbApto"
        Me.chbApto.Size = New System.Drawing.Size(180, 20)
        Me.chbApto.TabIndex = 2
        Me.chbApto.UseVisualStyleBackColor = False
        '
        'cboid_grupo_riesgo
        '
        Me.cboid_grupo_riesgo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_grupo_riesgo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_grupo_riesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_grupo_riesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_grupo_riesgo.Location = New System.Drawing.Point(142, 131)
        Me.cboid_grupo_riesgo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_grupo_riesgo.Name = "cboid_grupo_riesgo"
        Me.cboid_grupo_riesgo.Size = New System.Drawing.Size(284, 23)
        Me.cboid_grupo_riesgo.TabIndex = 3
        '
        'butVerid_grupo_riesgo
        '
        Me.butVerid_grupo_riesgo.FlatAppearance.BorderSize = 0
        Me.butVerid_grupo_riesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_grupo_riesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_grupo_riesgo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_grupo_riesgo.Location = New System.Drawing.Point(430, 131)
        Me.butVerid_grupo_riesgo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_grupo_riesgo.Name = "butVerid_grupo_riesgo"
        Me.butVerid_grupo_riesgo.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_grupo_riesgo.TabIndex = 6
        Me.butVerid_grupo_riesgo.TabStop = False
        '
        'butAddid_grupo_riesgo
        '
        Me.butAddid_grupo_riesgo.FlatAppearance.BorderSize = 0
        Me.butAddid_grupo_riesgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_grupo_riesgo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_grupo_riesgo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_grupo_riesgo.Location = New System.Drawing.Point(452, 131)
        Me.butAddid_grupo_riesgo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_grupo_riesgo.Name = "butAddid_grupo_riesgo"
        Me.butAddid_grupo_riesgo.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_grupo_riesgo.TabIndex = 7
        Me.butAddid_grupo_riesgo.TabStop = False
        '
        'cboid_medico
        '
        Me.cboid_medico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_medico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_medico.Location = New System.Drawing.Point(142, 161)
        Me.cboid_medico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_medico.Name = "cboid_medico"
        Me.cboid_medico.Size = New System.Drawing.Size(284, 23)
        Me.cboid_medico.TabIndex = 4
        '
        'butVerid_medico
        '
        Me.butVerid_medico.FlatAppearance.BorderSize = 0
        Me.butVerid_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_medico.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_medico.Location = New System.Drawing.Point(430, 161)
        Me.butVerid_medico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_medico.Name = "butVerid_medico"
        Me.butVerid_medico.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_medico.TabIndex = 9
        Me.butVerid_medico.TabStop = False
        '
        'butAddid_medico
        '
        Me.butAddid_medico.FlatAppearance.BorderSize = 0
        Me.butAddid_medico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_medico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_medico.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_medico.Location = New System.Drawing.Point(452, 161)
        Me.butAddid_medico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_medico.Name = "butAddid_medico"
        Me.butAddid_medico.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_medico.TabIndex = 10
        Me.butAddid_medico.TabStop = False
        '
        'lblReconocimientoMedicoSolicitudEmpleadoID
        '
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.Location = New System.Drawing.Point(25, 45)
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.Name = "lblReconocimientoMedicoSolicitudEmpleadoID"
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.Size = New System.Drawing.Size(113, 30)
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.TabIndex = 0
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.Text = "Solicitud de empleado"
        Me.lblReconocimientoMedicoSolicitudEmpleadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaRealizado
        '
        Me.lblFechaRealizado.Location = New System.Drawing.Point(25, 75)
        Me.lblFechaRealizado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaRealizado.Name = "lblFechaRealizado"
        Me.lblFechaRealizado.Size = New System.Drawing.Size(113, 28)
        Me.lblFechaRealizado.TabIndex = 3
        Me.lblFechaRealizado.Text = "Fecha realizacion"
        Me.lblFechaRealizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblApto
        '
        Me.lblApto.Location = New System.Drawing.Point(25, 103)
        Me.lblApto.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblApto.Name = "lblApto"
        Me.lblApto.Size = New System.Drawing.Size(113, 25)
        Me.lblApto.TabIndex = 4
        Me.lblApto.Text = "Apto"
        Me.lblApto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_grupo_riesgo
        '
        Me.lblid_grupo_riesgo.Location = New System.Drawing.Point(25, 128)
        Me.lblid_grupo_riesgo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_grupo_riesgo.Name = "lblid_grupo_riesgo"
        Me.lblid_grupo_riesgo.Size = New System.Drawing.Size(113, 30)
        Me.lblid_grupo_riesgo.TabIndex = 5
        Me.lblid_grupo_riesgo.Text = "Grupo de riesgo"
        Me.lblid_grupo_riesgo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_medico
        '
        Me.lblid_medico.Location = New System.Drawing.Point(25, 158)
        Me.lblid_medico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_medico.Name = "lblid_medico"
        Me.lblid_medico.Size = New System.Drawing.Size(113, 30)
        Me.lblid_medico.TabIndex = 8
        Me.lblid_medico.Text = "Médico"
        Me.lblid_medico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntReconocimientosMedicos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(508, 223)
        Me.Controls.Add(Me.lblReconocimientoMedicoSolicitudEmpleadoID)
        Me.Controls.Add(Me.cboReconocimientoMedicoSolicitudEmpleado)
        Me.Controls.Add(Me.butVerReconocimientoMedicoSolicitudEmpleadoID)
        Me.Controls.Add(Me.butAddReconocimientoMedicoSolicitudEmpleadoID)
        Me.Controls.Add(Me.lblFechaRealizado)
        Me.Controls.Add(Me.butAddid_medico)
        Me.Controls.Add(Me.dtpFechaRealizado)
        Me.Controls.Add(Me.butVerid_medico)
        Me.Controls.Add(Me.lblApto)
        Me.Controls.Add(Me.cboid_medico)
        Me.Controls.Add(Me.chbApto)
        Me.Controls.Add(Me.lblid_medico)
        Me.Controls.Add(Me.lblid_grupo_riesgo)
        Me.Controls.Add(Me.butAddid_grupo_riesgo)
        Me.Controls.Add(Me.cboid_grupo_riesgo)
        Me.Controls.Add(Me.butVerid_grupo_riesgo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntReconocimientosMedicos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReconocimientosMedicos"
        Me.Controls.SetChildIndex(Me.butVerid_grupo_riesgo, 0)
        Me.Controls.SetChildIndex(Me.cboid_grupo_riesgo, 0)
        Me.Controls.SetChildIndex(Me.butAddid_grupo_riesgo, 0)
        Me.Controls.SetChildIndex(Me.lblid_grupo_riesgo, 0)
        Me.Controls.SetChildIndex(Me.lblid_medico, 0)
        Me.Controls.SetChildIndex(Me.chbApto, 0)
        Me.Controls.SetChildIndex(Me.cboid_medico, 0)
        Me.Controls.SetChildIndex(Me.lblApto, 0)
        Me.Controls.SetChildIndex(Me.butVerid_medico, 0)
        Me.Controls.SetChildIndex(Me.dtpFechaRealizado, 0)
        Me.Controls.SetChildIndex(Me.butAddid_medico, 0)
        Me.Controls.SetChildIndex(Me.lblFechaRealizado, 0)
        Me.Controls.SetChildIndex(Me.butAddReconocimientoMedicoSolicitudEmpleadoID, 0)
        Me.Controls.SetChildIndex(Me.butVerReconocimientoMedicoSolicitudEmpleadoID, 0)
        Me.Controls.SetChildIndex(Me.cboReconocimientoMedicoSolicitudEmpleado, 0)
        Me.Controls.SetChildIndex(Me.lblReconocimientoMedicoSolicitudEmpleadoID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboReconocimientoMedicoSolicitudEmpleado As System.Windows.Forms.ComboBox
   Private WithEvents butVerReconocimientoMedicoSolicitudEmpleadoID As System.Windows.Forms.Button
   Private WithEvents butAddReconocimientoMedicoSolicitudEmpleadoID As System.Windows.Forms.Button
   Private WithEvents dtpFechaRealizado As System.Windows.Forms.DateTimePicker
   Private WithEvents chbApto As System.Windows.Forms.CheckBox
   Private WithEvents cboid_grupo_riesgo As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_grupo_riesgo As System.Windows.Forms.Button
   Private WithEvents butAddid_grupo_riesgo As System.Windows.Forms.Button
   Private WithEvents cboid_medico As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_medico As System.Windows.Forms.Button
   Private WithEvents butAddid_medico As System.Windows.Forms.Button
   Private WithEvents lblReconocimientoMedicoSolicitudEmpleadoID As System.Windows.Forms.Label
   Private WithEvents lblFechaRealizado As System.Windows.Forms.Label
   Private WithEvents lblApto As System.Windows.Forms.Label
   Private WithEvents lblid_grupo_riesgo As System.Windows.Forms.Label
   Private WithEvents lblid_medico As System.Windows.Forms.Label

End Class
