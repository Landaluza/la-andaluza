<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPosiciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPosiciones))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboAltura = New System.Windows.Forms.ComboBox()
        Me.butVerAlturaID = New System.Windows.Forms.Button()
        Me.butAddAlturaID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblAlturaID = New System.Windows.Forms.Label()
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
        'cboAltura
        '
        Me.cboAltura.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAltura.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAltura.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboAltura.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAltura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAltura.Location = New System.Drawing.Point(86, 42)
        Me.cboAltura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboAltura.Name = "cboAltura"
        Me.cboAltura.Size = New System.Drawing.Size(181, 23)
        Me.cboAltura.TabIndex = 1
        '
        'butVerAlturaID
        '
        Me.butVerAlturaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerAlturaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerAlturaID.FlatAppearance.BorderSize = 0
        Me.butVerAlturaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerAlturaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerAlturaID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerAlturaID.Location = New System.Drawing.Point(271, 42)
        Me.butVerAlturaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerAlturaID.Name = "butVerAlturaID"
        Me.butVerAlturaID.Size = New System.Drawing.Size(18, 26)
        Me.butVerAlturaID.TabIndex = 2
        Me.butVerAlturaID.TabStop = False
        '
        'butAddAlturaID
        '
        Me.butAddAlturaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddAlturaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddAlturaID.FlatAppearance.BorderSize = 0
        Me.butAddAlturaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddAlturaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddAlturaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddAlturaID.Location = New System.Drawing.Point(293, 42)
        Me.butAddAlturaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddAlturaID.Name = "butAddAlturaID"
        Me.butAddAlturaID.Size = New System.Drawing.Size(18, 26)
        Me.butAddAlturaID.TabIndex = 3
        Me.butAddAlturaID.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(62, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Desc"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAlturaID
        '
        Me.lblAlturaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAlturaID.Location = New System.Drawing.Point(20, 40)
        Me.lblAlturaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAlturaID.Name = "lblAlturaID"
        Me.lblAlturaID.Size = New System.Drawing.Size(62, 30)
        Me.lblAlturaID.TabIndex = 1
        Me.lblAlturaID.Text = "Altura"
        Me.lblAlturaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblAlturaID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboAltura, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerAlturaID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddAlturaID, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 24)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(359, 89)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntPosiciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(355, 156)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPosiciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Posiciones"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents cboAltura As System.Windows.Forms.ComboBox
    Private WithEvents butVerAlturaID As System.Windows.Forms.Button
    Private WithEvents butAddAlturaID As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblAlturaID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
