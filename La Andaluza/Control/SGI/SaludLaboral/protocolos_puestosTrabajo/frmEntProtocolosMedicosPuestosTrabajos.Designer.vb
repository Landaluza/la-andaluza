<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProtocolosMedicosPuestosTrabajos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProtocolosMedicosPuestosTrabajos))
        Me.cboPuestoTrabajo = New System.Windows.Forms.ComboBox()
        Me.butVerPuestoTrabajoID = New System.Windows.Forms.Button()
        Me.butAddPuestoTrabajoID = New System.Windows.Forms.Button()
        Me.cboProtocoloMedico = New System.Windows.Forms.ComboBox()
        Me.butVerProtocoloMedicoID = New System.Windows.Forms.Button()
        Me.butAddProtocoloMedicoID = New System.Windows.Forms.Button()
        Me.cboProgramaActividadPreventiva = New System.Windows.Forms.ComboBox()
        Me.butVerProgramaActividadPreventivaID = New System.Windows.Forms.Button()
        Me.butAddProgramaActividadPreventivaID = New System.Windows.Forms.Button()
        Me.lblPuestoTrabajoID = New System.Windows.Forms.Label()
        Me.lblProtocoloMedicoID = New System.Windows.Forms.Label()
        Me.lblProgramaActividadPreventivaID = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboPuestoTrabajo
        '
        Me.cboPuestoTrabajo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPuestoTrabajo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPuestoTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPuestoTrabajo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPuestoTrabajo.Location = New System.Drawing.Point(154, 51)
        Me.cboPuestoTrabajo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPuestoTrabajo.Name = "cboPuestoTrabajo"
        Me.cboPuestoTrabajo.Size = New System.Drawing.Size(384, 23)
        Me.cboPuestoTrabajo.TabIndex = 0
        '
        'butVerPuestoTrabajoID
        '
        Me.butVerPuestoTrabajoID.FlatAppearance.BorderSize = 0
        Me.butVerPuestoTrabajoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPuestoTrabajoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPuestoTrabajoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerPuestoTrabajoID.Location = New System.Drawing.Point(541, 51)
        Me.butVerPuestoTrabajoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerPuestoTrabajoID.Name = "butVerPuestoTrabajoID"
        Me.butVerPuestoTrabajoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerPuestoTrabajoID.TabIndex = 1
        Me.butVerPuestoTrabajoID.TabStop = False
        '
        'butAddPuestoTrabajoID
        '
        Me.butAddPuestoTrabajoID.FlatAppearance.BorderSize = 0
        Me.butAddPuestoTrabajoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPuestoTrabajoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPuestoTrabajoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPuestoTrabajoID.Location = New System.Drawing.Point(563, 51)
        Me.butAddPuestoTrabajoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddPuestoTrabajoID.Name = "butAddPuestoTrabajoID"
        Me.butAddPuestoTrabajoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddPuestoTrabajoID.TabIndex = 2
        Me.butAddPuestoTrabajoID.TabStop = False
        '
        'cboProtocoloMedico
        '
        Me.cboProtocoloMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProtocoloMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProtocoloMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProtocoloMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProtocoloMedico.Location = New System.Drawing.Point(154, 81)
        Me.cboProtocoloMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProtocoloMedico.Name = "cboProtocoloMedico"
        Me.cboProtocoloMedico.Size = New System.Drawing.Size(384, 23)
        Me.cboProtocoloMedico.TabIndex = 1
        '
        'butVerProtocoloMedicoID
        '
        Me.butVerProtocoloMedicoID.FlatAppearance.BorderSize = 0
        Me.butVerProtocoloMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProtocoloMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProtocoloMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProtocoloMedicoID.Location = New System.Drawing.Point(541, 81)
        Me.butVerProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProtocoloMedicoID.Name = "butVerProtocoloMedicoID"
        Me.butVerProtocoloMedicoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProtocoloMedicoID.TabIndex = 4
        Me.butVerProtocoloMedicoID.TabStop = False
        '
        'butAddProtocoloMedicoID
        '
        Me.butAddProtocoloMedicoID.FlatAppearance.BorderSize = 0
        Me.butAddProtocoloMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProtocoloMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProtocoloMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProtocoloMedicoID.Location = New System.Drawing.Point(563, 81)
        Me.butAddProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProtocoloMedicoID.Name = "butAddProtocoloMedicoID"
        Me.butAddProtocoloMedicoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProtocoloMedicoID.TabIndex = 5
        Me.butAddProtocoloMedicoID.TabStop = False
        '
        'cboProgramaActividadPreventiva
        '
        Me.cboProgramaActividadPreventiva.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProgramaActividadPreventiva.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProgramaActividadPreventiva.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProgramaActividadPreventiva.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProgramaActividadPreventiva.Location = New System.Drawing.Point(154, 111)
        Me.cboProgramaActividadPreventiva.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProgramaActividadPreventiva.Name = "cboProgramaActividadPreventiva"
        Me.cboProgramaActividadPreventiva.Size = New System.Drawing.Size(384, 23)
        Me.cboProgramaActividadPreventiva.TabIndex = 2
        '
        'butVerProgramaActividadPreventivaID
        '
        Me.butVerProgramaActividadPreventivaID.FlatAppearance.BorderSize = 0
        Me.butVerProgramaActividadPreventivaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProgramaActividadPreventivaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProgramaActividadPreventivaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProgramaActividadPreventivaID.Location = New System.Drawing.Point(541, 111)
        Me.butVerProgramaActividadPreventivaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProgramaActividadPreventivaID.Name = "butVerProgramaActividadPreventivaID"
        Me.butVerProgramaActividadPreventivaID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProgramaActividadPreventivaID.TabIndex = 7
        Me.butVerProgramaActividadPreventivaID.TabStop = False
        '
        'butAddProgramaActividadPreventivaID
        '
        Me.butAddProgramaActividadPreventivaID.FlatAppearance.BorderSize = 0
        Me.butAddProgramaActividadPreventivaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProgramaActividadPreventivaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProgramaActividadPreventivaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProgramaActividadPreventivaID.Location = New System.Drawing.Point(563, 111)
        Me.butAddProgramaActividadPreventivaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProgramaActividadPreventivaID.Name = "butAddProgramaActividadPreventivaID"
        Me.butAddProgramaActividadPreventivaID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProgramaActividadPreventivaID.TabIndex = 8
        Me.butAddProgramaActividadPreventivaID.TabStop = False
        '
        'lblPuestoTrabajoID
        '
        Me.lblPuestoTrabajoID.Location = New System.Drawing.Point(29, 49)
        Me.lblPuestoTrabajoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPuestoTrabajoID.Name = "lblPuestoTrabajoID"
        Me.lblPuestoTrabajoID.Size = New System.Drawing.Size(120, 30)
        Me.lblPuestoTrabajoID.TabIndex = 0
        Me.lblPuestoTrabajoID.Text = "Puesto  de trabajo"
        Me.lblPuestoTrabajoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProtocoloMedicoID
        '
        Me.lblProtocoloMedicoID.Location = New System.Drawing.Point(29, 79)
        Me.lblProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProtocoloMedicoID.Name = "lblProtocoloMedicoID"
        Me.lblProtocoloMedicoID.Size = New System.Drawing.Size(120, 30)
        Me.lblProtocoloMedicoID.TabIndex = 3
        Me.lblProtocoloMedicoID.Text = "Protocolo medico"
        Me.lblProtocoloMedicoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProgramaActividadPreventivaID
        '
        Me.lblProgramaActividadPreventivaID.Location = New System.Drawing.Point(29, 109)
        Me.lblProgramaActividadPreventivaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProgramaActividadPreventivaID.Name = "lblProgramaActividadPreventivaID"
        Me.lblProgramaActividadPreventivaID.Size = New System.Drawing.Size(120, 30)
        Me.lblProgramaActividadPreventivaID.TabIndex = 6
        Me.lblProgramaActividadPreventivaID.Text = "Programa"
        Me.lblProgramaActividadPreventivaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntProtocolosMedicosPuestosTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 155)
        Me.Controls.Add(Me.lblPuestoTrabajoID)
        Me.Controls.Add(Me.cboPuestoTrabajo)
        Me.Controls.Add(Me.butVerPuestoTrabajoID)
        Me.Controls.Add(Me.butAddPuestoTrabajoID)
        Me.Controls.Add(Me.cboProtocoloMedico)
        Me.Controls.Add(Me.lblProtocoloMedicoID)
        Me.Controls.Add(Me.butAddProgramaActividadPreventivaID)
        Me.Controls.Add(Me.butVerProgramaActividadPreventivaID)
        Me.Controls.Add(Me.butVerProtocoloMedicoID)
        Me.Controls.Add(Me.cboProgramaActividadPreventiva)
        Me.Controls.Add(Me.butAddProtocoloMedicoID)
        Me.Controls.Add(Me.lblProgramaActividadPreventivaID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntProtocolosMedicosPuestosTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProtocolosMedicosPuestosTrabajos"
        Me.Controls.SetChildIndex(Me.lblProgramaActividadPreventivaID, 0)
        Me.Controls.SetChildIndex(Me.butAddProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.cboProgramaActividadPreventiva, 0)
        Me.Controls.SetChildIndex(Me.butVerProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.butVerProgramaActividadPreventivaID, 0)
        Me.Controls.SetChildIndex(Me.butAddProgramaActividadPreventivaID, 0)
        Me.Controls.SetChildIndex(Me.lblProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.cboProtocoloMedico, 0)
        Me.Controls.SetChildIndex(Me.butAddPuestoTrabajoID, 0)
        Me.Controls.SetChildIndex(Me.butVerPuestoTrabajoID, 0)
        Me.Controls.SetChildIndex(Me.cboPuestoTrabajo, 0)
        Me.Controls.SetChildIndex(Me.lblPuestoTrabajoID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboPuestoTrabajo As System.Windows.Forms.ComboBox
   Private WithEvents butVerPuestoTrabajoID As System.Windows.Forms.Button
   Private WithEvents butAddPuestoTrabajoID As System.Windows.Forms.Button
   Private WithEvents cboProtocoloMedico As System.Windows.Forms.ComboBox
   Private WithEvents butVerProtocoloMedicoID As System.Windows.Forms.Button
   Private WithEvents butAddProtocoloMedicoID As System.Windows.Forms.Button
   Private WithEvents cboProgramaActividadPreventiva As System.Windows.Forms.ComboBox
   Private WithEvents butVerProgramaActividadPreventivaID As System.Windows.Forms.Button
   Private WithEvents butAddProgramaActividadPreventivaID As System.Windows.Forms.Button
   Private WithEvents lblPuestoTrabajoID As System.Windows.Forms.Label
   Private WithEvents lblProtocoloMedicoID As System.Windows.Forms.Label
   Private WithEvents lblProgramaActividadPreventivaID As System.Windows.Forms.Label

End Class
