<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntReconocimientosMedicosSolicitudesEmpleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntReconocimientosMedicosSolicitudesEmpleados))

        Me.lblReconocimientoMedicoSolicitudID = New System.Windows.Forms.Label()
        Me.lblEmpleadoID = New System.Windows.Forms.Label()
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.cboReconocimientoMedicoSolicitud = New System.Windows.Forms.ComboBox()
        Me.butVerReconocimientoMedicoSolicitudID = New System.Windows.Forms.Button()
        Me.butAddReconocimientoMedicoSolicitudID = New System.Windows.Forms.Button()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tlpTop
        '




        '
        'lblReconocimientoMedicoSolicitudID
        '
        Me.lblReconocimientoMedicoSolicitudID.Location = New System.Drawing.Point(34, 43)
        Me.lblReconocimientoMedicoSolicitudID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReconocimientoMedicoSolicitudID.Name = "lblReconocimientoMedicoSolicitudID"
        Me.lblReconocimientoMedicoSolicitudID.Size = New System.Drawing.Size(62, 30)
        Me.lblReconocimientoMedicoSolicitudID.TabIndex = 0
        Me.lblReconocimientoMedicoSolicitudID.Text = "Solicitud"
        Me.lblReconocimientoMedicoSolicitudID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEmpleadoID
        '
        Me.lblEmpleadoID.Location = New System.Drawing.Point(34, 73)
        Me.lblEmpleadoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEmpleadoID.Name = "lblEmpleadoID"
        Me.lblEmpleadoID.Size = New System.Drawing.Size(62, 30)
        Me.lblEmpleadoID.TabIndex = 3
        Me.lblEmpleadoID.Text = "Empleado"
        Me.lblEmpleadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEmpleado
        '
        Me.cboEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.Location = New System.Drawing.Point(100, 76)
        Me.cboEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(408, 23)
        Me.cboEmpleado.TabIndex = 1
        '
        'cboReconocimientoMedicoSolicitud
        '
        Me.cboReconocimientoMedicoSolicitud.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboReconocimientoMedicoSolicitud.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReconocimientoMedicoSolicitud.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReconocimientoMedicoSolicitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReconocimientoMedicoSolicitud.Location = New System.Drawing.Point(100, 46)
        Me.cboReconocimientoMedicoSolicitud.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReconocimientoMedicoSolicitud.Name = "cboReconocimientoMedicoSolicitud"
        Me.cboReconocimientoMedicoSolicitud.Size = New System.Drawing.Size(408, 23)
        Me.cboReconocimientoMedicoSolicitud.TabIndex = 0
        '
        'butVerReconocimientoMedicoSolicitudID
        '
        Me.butVerReconocimientoMedicoSolicitudID.FlatAppearance.BorderSize = 0
        Me.butVerReconocimientoMedicoSolicitudID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerReconocimientoMedicoSolicitudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerReconocimientoMedicoSolicitudID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerReconocimientoMedicoSolicitudID.Location = New System.Drawing.Point(512, 46)
        Me.butVerReconocimientoMedicoSolicitudID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerReconocimientoMedicoSolicitudID.Name = "butVerReconocimientoMedicoSolicitudID"
        Me.butVerReconocimientoMedicoSolicitudID.Size = New System.Drawing.Size(18, 22)
        Me.butVerReconocimientoMedicoSolicitudID.TabIndex = 1
        Me.butVerReconocimientoMedicoSolicitudID.TabStop = False
        '
        'butAddReconocimientoMedicoSolicitudID
        '
        Me.butAddReconocimientoMedicoSolicitudID.FlatAppearance.BorderSize = 0
        Me.butAddReconocimientoMedicoSolicitudID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddReconocimientoMedicoSolicitudID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddReconocimientoMedicoSolicitudID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddReconocimientoMedicoSolicitudID.Location = New System.Drawing.Point(534, 46)
        Me.butAddReconocimientoMedicoSolicitudID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddReconocimientoMedicoSolicitudID.Name = "butAddReconocimientoMedicoSolicitudID"
        Me.butAddReconocimientoMedicoSolicitudID.Size = New System.Drawing.Size(18, 22)
        Me.butAddReconocimientoMedicoSolicitudID.TabIndex = 2
        Me.butAddReconocimientoMedicoSolicitudID.TabStop = False
        '
        'frmEntReconocimientosMedicosSolicitudesEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(581, 136)
        Me.Controls.Add(Me.lblReconocimientoMedicoSolicitudID)
        Me.Controls.Add(Me.cboReconocimientoMedicoSolicitud)
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.lblEmpleadoID)
        Me.Controls.Add(Me.butVerReconocimientoMedicoSolicitudID)
        Me.Controls.Add(Me.butAddReconocimientoMedicoSolicitudID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(517, 136)
        Me.Name = "frmEntReconocimientosMedicosSolicitudesEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReconocimientosMedicosSolicitudesEmpleados"
        Me.Controls.SetChildIndex(Me.butAddReconocimientoMedicoSolicitudID, 0)
        Me.Controls.SetChildIndex(Me.butVerReconocimientoMedicoSolicitudID, 0)
        Me.Controls.SetChildIndex(Me.lblEmpleadoID, 0)
        Me.Controls.SetChildIndex(Me.cboEmpleado, 0)
        Me.Controls.SetChildIndex(Me.cboReconocimientoMedicoSolicitud, 0)
        Me.Controls.SetChildIndex(Me.lblReconocimientoMedicoSolicitudID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents lblReconocimientoMedicoSolicitudID As System.Windows.Forms.Label
   Private WithEvents lblEmpleadoID As System.Windows.Forms.Label
   Private WithEvents cboEmpleado As System.Windows.Forms.ComboBox
   Private WithEvents cboReconocimientoMedicoSolicitud As System.Windows.Forms.ComboBox
   Private WithEvents butVerReconocimientoMedicoSolicitudID As System.Windows.Forms.Button
   Private WithEvents butAddReconocimientoMedicoSolicitudID As System.Windows.Forms.Button
End Class
