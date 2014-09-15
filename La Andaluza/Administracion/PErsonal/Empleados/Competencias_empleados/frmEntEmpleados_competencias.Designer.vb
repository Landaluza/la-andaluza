<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEmpleados_competencias
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
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.cboid_personalCompetencia = New System.Windows.Forms.ComboBox()
        Me.butVerid_personalCompetencia = New System.Windows.Forms.Button()
        Me.butAddid_personalCompetencia = New System.Windows.Forms.Button()
        Me.chbactivo = New System.Windows.Forms.CheckBox()
        Me.lblid_empleado = New System.Windows.Forms.Label()
        Me.lblid_personalCompetencia = New System.Windows.Forms.Label()
        Me.lblactivo = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.Enabled = False
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(201, 28)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(240, 26)
        Me.cboid_empleado.TabIndex = 0
        Me.cboid_empleado.Visible = False
        '
        'cboid_personalCompetencia
        '
        Me.cboid_personalCompetencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_personalCompetencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_personalCompetencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_personalCompetencia.Location = New System.Drawing.Point(201, 65)
        Me.cboid_personalCompetencia.Name = "cboid_personalCompetencia"
        Me.cboid_personalCompetencia.Size = New System.Drawing.Size(240, 26)
        Me.cboid_personalCompetencia.TabIndex = 1
        '
        'butVerid_personalCompetencia
        '
        Me.butVerid_personalCompetencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_personalCompetencia.FlatAppearance.BorderSize = 0
        Me.butVerid_personalCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_personalCompetencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_personalCompetencia.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_personalCompetencia.Location = New System.Drawing.Point(447, 65)
        Me.butVerid_personalCompetencia.Name = "butVerid_personalCompetencia"
        Me.butVerid_personalCompetencia.Size = New System.Drawing.Size(24, 26)
        Me.butVerid_personalCompetencia.TabIndex = 4
        Me.butVerid_personalCompetencia.TabStop = False
        '
        'butAddid_personalCompetencia
        '
        Me.butAddid_personalCompetencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_personalCompetencia.FlatAppearance.BorderSize = 0
        Me.butAddid_personalCompetencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_personalCompetencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_personalCompetencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_personalCompetencia.Location = New System.Drawing.Point(477, 65)
        Me.butAddid_personalCompetencia.Name = "butAddid_personalCompetencia"
        Me.butAddid_personalCompetencia.Size = New System.Drawing.Size(24, 26)
        Me.butAddid_personalCompetencia.TabIndex = 5
        Me.butAddid_personalCompetencia.TabStop = False
        '
        'chbactivo
        '
        Me.chbactivo.BackColor = System.Drawing.SystemColors.Control
        Me.chbactivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbactivo.Location = New System.Drawing.Point(201, 102)
        Me.chbactivo.Name = "chbactivo"
        Me.chbactivo.Size = New System.Drawing.Size(240, 24)
        Me.chbactivo.TabIndex = 2
        Me.chbactivo.UseVisualStyleBackColor = False
        '
        'lblid_empleado
        '
        Me.lblid_empleado.Enabled = False
        Me.lblid_empleado.Location = New System.Drawing.Point(31, 25)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(164, 37)
        Me.lblid_empleado.TabIndex = 0
        Me.lblid_empleado.Text = "Empleado"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblid_empleado.Visible = False
        '
        'lblid_personalCompetencia
        '
        Me.lblid_personalCompetencia.Location = New System.Drawing.Point(31, 62)
        Me.lblid_personalCompetencia.Name = "lblid_personalCompetencia"
        Me.lblid_personalCompetencia.Size = New System.Drawing.Size(164, 37)
        Me.lblid_personalCompetencia.TabIndex = 3
        Me.lblid_personalCompetencia.Text = "Competencia"
        Me.lblid_personalCompetencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblactivo
        '
        Me.lblactivo.Location = New System.Drawing.Point(31, 99)
        Me.lblactivo.Name = "lblactivo"
        Me.lblactivo.Size = New System.Drawing.Size(164, 31)
        Me.lblactivo.TabIndex = 6
        Me.lblactivo.Text = "Activo"
        Me.lblactivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmEntEmpleados_competencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(554, 164)
        Me.Controls.Add(Me.lblid_empleado)
        Me.Controls.Add(Me.cboid_empleado)
        Me.Controls.Add(Me.cboid_personalCompetencia)
        Me.Controls.Add(Me.lblid_personalCompetencia)
        Me.Controls.Add(Me.chbactivo)
        Me.Controls.Add(Me.lblactivo)
        Me.Controls.Add(Me.butVerid_personalCompetencia)
        Me.Controls.Add(Me.butAddid_personalCompetencia)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntEmpleados_competencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados_competencias"
        Me.Controls.SetChildIndex(Me.butAddid_personalCompetencia, 0)
        Me.Controls.SetChildIndex(Me.butVerid_personalCompetencia, 0)
        Me.Controls.SetChildIndex(Me.lblactivo, 0)
        Me.Controls.SetChildIndex(Me.chbactivo, 0)
        Me.Controls.SetChildIndex(Me.lblid_personalCompetencia, 0)
        Me.Controls.SetChildIndex(Me.cboid_personalCompetencia, 0)
        Me.Controls.SetChildIndex(Me.cboid_empleado, 0)
        Me.Controls.SetChildIndex(Me.lblid_empleado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents cboid_personalCompetencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_personalCompetencia As System.Windows.Forms.Button
    Private WithEvents butAddid_personalCompetencia As System.Windows.Forms.Button
    Private WithEvents chbactivo As System.Windows.Forms.CheckBox
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
    Private WithEvents lblid_personalCompetencia As System.Windows.Forms.Label
    Private WithEvents lblactivo As System.Windows.Forms.Label
End Class
