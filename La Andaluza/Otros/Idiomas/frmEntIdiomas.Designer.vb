<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntIdiomas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntIdiomas))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.chbTraduccion = New System.Windows.Forms.CheckBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTraduccion = New System.Windows.Forms.Label()
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
        'chbTraduccion
        '
        Me.chbTraduccion.BackColor = System.Drawing.SystemColors.Control
        Me.chbTraduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbTraduccion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbTraduccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTraduccion.Location = New System.Drawing.Point(86, 42)
        Me.chbTraduccion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbTraduccion.Name = "chbTraduccion"
        Me.chbTraduccion.Size = New System.Drawing.Size(181, 21)
        Me.chbTraduccion.TabIndex = 1
        Me.chbTraduccion.UseVisualStyleBackColor = False
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
        'lblTraduccion
        '
        Me.lblTraduccion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTraduccion.Location = New System.Drawing.Point(20, 40)
        Me.lblTraduccion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTraduccion.Name = "lblTraduccion"
        Me.lblTraduccion.Size = New System.Drawing.Size(62, 25)
        Me.lblTraduccion.TabIndex = 1
        Me.lblTraduccion.Text = "Traduccion"
        Me.lblTraduccion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 91.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblTraduccion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.chbTraduccion, 2, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(34, 23)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(288, 83)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntIdiomas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(355, 125)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntIdiomas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Idiomas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents chbTraduccion As System.Windows.Forms.CheckBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblTraduccion As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
