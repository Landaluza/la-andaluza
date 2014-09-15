<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntempleados_envasados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntempleados_envasados))
        Me.cboenvasado = New System.Windows.Forms.ComboBox()
        Me.butVerId_envasado = New System.Windows.Forms.Button()
        Me.butAddId_envasado = New System.Windows.Forms.Button()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.cbolinea = New System.Windows.Forms.ComboBox()
        Me.butVerId_linea = New System.Windows.Forms.Button()
        Me.butAddId_linea = New System.Windows.Forms.Button()
        Me.lblId_envasado = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblId_linea = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboenvasado
        '
        Me.cboenvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboenvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboenvasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboenvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboenvasado.Location = New System.Drawing.Point(89, 14)
        Me.cboenvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboenvasado.Name = "cboenvasado"
        Me.cboenvasado.Size = New System.Drawing.Size(181, 23)
        Me.cboenvasado.TabIndex = 0
        '
        'butVerId_envasado
        '
        Me.butVerId_envasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_envasado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_envasado.Location = New System.Drawing.Point(274, 14)
        Me.butVerId_envasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_envasado.Name = "butVerId_envasado"
        Me.butVerId_envasado.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_envasado.TabIndex = 1
        Me.butVerId_envasado.TabStop = False
        '
        'butAddId_envasado
        '
        Me.butAddId_envasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_envasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_envasado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_envasado.Location = New System.Drawing.Point(296, 14)
        Me.butAddId_envasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_envasado.Name = "butAddId_envasado"
        Me.butAddId_envasado.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_envasado.TabIndex = 2
        Me.butAddId_envasado.TabStop = False
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(89, 44)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(181, 23)
        Me.cboempleado.TabIndex = 1
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(274, 44)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_empleado.TabIndex = 4
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(296, 44)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_empleado.TabIndex = 5
        Me.butAddId_empleado.TabStop = False
        '
        'cbolinea
        '
        Me.cbolinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbolinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbolinea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbolinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbolinea.Location = New System.Drawing.Point(89, 74)
        Me.cbolinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbolinea.Name = "cbolinea"
        Me.cbolinea.Size = New System.Drawing.Size(181, 23)
        Me.cbolinea.TabIndex = 2
        '
        'butVerId_linea
        '
        Me.butVerId_linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_linea.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_linea.Location = New System.Drawing.Point(274, 74)
        Me.butVerId_linea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_linea.Name = "butVerId_linea"
        Me.butVerId_linea.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_linea.TabIndex = 7
        Me.butVerId_linea.TabStop = False
        '
        'butAddId_linea
        '
        Me.butAddId_linea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_linea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_linea.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_linea.Location = New System.Drawing.Point(296, 74)
        Me.butAddId_linea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_linea.Name = "butAddId_linea"
        Me.butAddId_linea.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_linea.TabIndex = 8
        Me.butAddId_linea.TabStop = False
        '
        'lblId_envasado
        '
        Me.lblId_envasado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_envasado.Location = New System.Drawing.Point(20, 12)
        Me.lblId_envasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_envasado.Name = "lblId_envasado"
        Me.lblId_envasado.Size = New System.Drawing.Size(65, 30)
        Me.lblId_envasado.TabIndex = 0
        Me.lblId_envasado.Text = "envasado"
        Me.lblId_envasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_empleado.Location = New System.Drawing.Point(20, 42)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(65, 30)
        Me.lblId_empleado.TabIndex = 3
        Me.lblId_empleado.Text = "empleado"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_linea
        '
        Me.lblId_linea.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_linea.Location = New System.Drawing.Point(20, 72)
        Me.lblId_linea.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_linea.Name = "lblId_linea"
        Me.lblId_linea.Size = New System.Drawing.Size(65, 30)
        Me.lblId_linea.TabIndex = 6
        Me.lblId_linea.Text = "linea"
        Me.lblId_linea.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 41.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_envasado, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboenvasado, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerId_envasado, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddId_envasado, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblId_empleado, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboempleado, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_empleado, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_empleado, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblId_linea, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cbolinea, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butVerId_linea, 3, 2)
        Me.tlpMiddle.Controls.Add(Me.butAddId_linea, 4, 2)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(358, 111)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntempleados_envasados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(358, 136)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntempleados_envasados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "empleados_envasados"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboenvasado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_envasado As System.Windows.Forms.Button
    Private WithEvents butAddId_envasado As System.Windows.Forms.Button
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents cbolinea As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_linea As System.Windows.Forms.Button
    Private WithEvents butAddId_linea As System.Windows.Forms.Button
    Private WithEvents lblId_envasado As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblId_linea As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
