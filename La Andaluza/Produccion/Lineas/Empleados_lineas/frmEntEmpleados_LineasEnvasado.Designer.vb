<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEmpleados_LineasEnvasado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEmpleados_LineasEnvasado))
        Me.cboEmpleado = New System.Windows.Forms.ComboBox()
        Me.cboLineaEnvasado = New System.Windows.Forms.ComboBox()
        Me.lblId_Empleado = New System.Windows.Forms.Label()
        Me.lblId_LineaEnvasado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboEmpleado
        '
        Me.cboEmpleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmpleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpleado.Location = New System.Drawing.Point(92, 38)
        Me.cboEmpleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboEmpleado.Name = "cboEmpleado"
        Me.cboEmpleado.Size = New System.Drawing.Size(396, 23)
        Me.cboEmpleado.TabIndex = 0
        '
        'cboLineaEnvasado
        '
        Me.cboLineaEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLineaEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLineaEnvasado.Enabled = False
        Me.cboLineaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLineaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineaEnvasado.Location = New System.Drawing.Point(92, 68)
        Me.cboLineaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboLineaEnvasado.Name = "cboLineaEnvasado"
        Me.cboLineaEnvasado.Size = New System.Drawing.Size(396, 23)
        Me.cboLineaEnvasado.TabIndex = 1
        '
        'lblId_Empleado
        '
        Me.lblId_Empleado.Location = New System.Drawing.Point(21, 36)
        Me.lblId_Empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_Empleado.Name = "lblId_Empleado"
        Me.lblId_Empleado.Size = New System.Drawing.Size(67, 30)
        Me.lblId_Empleado.TabIndex = 0
        Me.lblId_Empleado.Text = "Empleado"
        Me.lblId_Empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_LineaEnvasado
        '
        Me.lblId_LineaEnvasado.Enabled = False
        Me.lblId_LineaEnvasado.Location = New System.Drawing.Point(21, 66)
        Me.lblId_LineaEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_LineaEnvasado.Name = "lblId_LineaEnvasado"
        Me.lblId_LineaEnvasado.Size = New System.Drawing.Size(67, 30)
        Me.lblId_LineaEnvasado.TabIndex = 3
        Me.lblId_LineaEnvasado.Text = "Linea"
        Me.lblId_LineaEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntEmpleados_LineasEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(554, 115)
        Me.Controls.Add(Me.lblId_Empleado)
        Me.Controls.Add(Me.cboEmpleado)
        Me.Controls.Add(Me.cboLineaEnvasado)
        Me.Controls.Add(Me.lblId_LineaEnvasado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(392, 136)
        Me.Name = "frmEntEmpleados_LineasEnvasado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados_LineasEnvasado"
        Me.Controls.SetChildIndex(Me.lblId_LineaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.cboLineaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.cboEmpleado, 0)
        Me.Controls.SetChildIndex(Me.lblId_Empleado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboEmpleado As System.Windows.Forms.ComboBox
    Private WithEvents cboLineaEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents lblId_Empleado As System.Windows.Forms.Label
    Private WithEvents lblId_LineaEnvasado As System.Windows.Forms.Label

End Class
