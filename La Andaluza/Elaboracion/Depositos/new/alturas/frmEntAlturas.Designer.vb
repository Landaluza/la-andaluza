<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAlturas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAlturas))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboPierna = New System.Windows.Forms.ComboBox()
        Me.butVerPiernaID = New System.Windows.Forms.Button()
        Me.butAddPiernaID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblPiernaID = New System.Windows.Forms.Label()
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
        'cboPierna
        '
        Me.cboPierna.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPierna.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPierna.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboPierna.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPierna.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPierna.Location = New System.Drawing.Point(86, 42)
        Me.cboPierna.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboPierna.Name = "cboPierna"
        Me.cboPierna.Size = New System.Drawing.Size(181, 23)
        Me.cboPierna.TabIndex = 1
        '
        'butVerPiernaID
        '
        Me.butVerPiernaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerPiernaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerPiernaID.FlatAppearance.BorderSize = 0
        Me.butVerPiernaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerPiernaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerPiernaID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerPiernaID.Location = New System.Drawing.Point(271, 42)
        Me.butVerPiernaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerPiernaID.Name = "butVerPiernaID"
        Me.butVerPiernaID.Size = New System.Drawing.Size(18, 26)
        Me.butVerPiernaID.TabIndex = 2
        Me.butVerPiernaID.TabStop = False
        '
        'butAddPiernaID
        '
        Me.butAddPiernaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddPiernaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddPiernaID.FlatAppearance.BorderSize = 0
        Me.butAddPiernaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddPiernaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddPiernaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddPiernaID.Location = New System.Drawing.Point(293, 42)
        Me.butAddPiernaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddPiernaID.Name = "butAddPiernaID"
        Me.butAddPiernaID.Size = New System.Drawing.Size(18, 26)
        Me.butAddPiernaID.TabIndex = 3
        Me.butAddPiernaID.TabStop = False
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
        'lblPiernaID
        '
        Me.lblPiernaID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblPiernaID.Location = New System.Drawing.Point(20, 40)
        Me.lblPiernaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPiernaID.Name = "lblPiernaID"
        Me.lblPiernaID.Size = New System.Drawing.Size(62, 30)
        Me.lblPiernaID.TabIndex = 1
        Me.lblPiernaID.Text = "Pierna"
        Me.lblPiernaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblPiernaID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboPierna, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerPiernaID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddPiernaID, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(11, 32)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(334, 81)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntAlturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(355, 136)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(363, 134)
        Me.Name = "frmEntAlturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Alturas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents cboPierna As System.Windows.Forms.ComboBox
    Private WithEvents butVerPiernaID As System.Windows.Forms.Button
    Private WithEvents butAddPiernaID As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblPiernaID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
