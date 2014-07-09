<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPiernas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPiernas))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboNave = New System.Windows.Forms.ComboBox()
        Me.butVerNaveID = New System.Windows.Forms.Button()
        Me.butAddNaveID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblNaveID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(86, 14)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'cboNave
        '
        Me.cboNave.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboNave.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboNave.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboNave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboNave.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboNave.Location = New System.Drawing.Point(86, 42)
        Me.cboNave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboNave.Name = "cboNave"
        Me.cboNave.Size = New System.Drawing.Size(181, 23)
        Me.cboNave.TabIndex = 1
        '
        'butVerNaveID
        '
        Me.butVerNaveID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerNaveID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerNaveID.FlatAppearance.BorderSize = 0
        Me.butVerNaveID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerNaveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerNaveID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerNaveID.Location = New System.Drawing.Point(271, 42)
        Me.butVerNaveID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerNaveID.Name = "butVerNaveID"
        Me.butVerNaveID.Size = New System.Drawing.Size(18, 26)
        Me.butVerNaveID.TabIndex = 2
        Me.butVerNaveID.TabStop = False
        '
        'butAddNaveID
        '
        Me.butAddNaveID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddNaveID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddNaveID.FlatAppearance.BorderSize = 0
        Me.butAddNaveID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddNaveID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddNaveID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddNaveID.Location = New System.Drawing.Point(293, 42)
        Me.butAddNaveID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddNaveID.Name = "butAddNaveID"
        Me.butAddNaveID.Size = New System.Drawing.Size(18, 26)
        Me.butAddNaveID.TabIndex = 3
        Me.butAddNaveID.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(62, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Des"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNaveID
        '
        Me.lblNaveID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblNaveID.Location = New System.Drawing.Point(20, 40)
        Me.lblNaveID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNaveID.Name = "lblNaveID"
        Me.lblNaveID.Size = New System.Drawing.Size(62, 30)
        Me.lblNaveID.TabIndex = 1
        Me.lblNaveID.Text = "Nave"
        Me.lblNaveID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblNaveID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboNave, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerNaveID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddNaveID, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(9, 37)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(332, 85)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntPiernas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(356, 167)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(363, 134)
        Me.Name = "frmEntPiernas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Piernas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents cboNave As System.Windows.Forms.ComboBox
    Private WithEvents butVerNaveID As System.Windows.Forms.Button
    Private WithEvents butAddNaveID As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblNaveID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
