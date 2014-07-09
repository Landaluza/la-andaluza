<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntNoticias_TiposUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntNoticias_TiposUsuarios))
        Me.cbotipoUsuario = New System.Windows.Forms.ComboBox()
        Me.butVerId_tipoUsuario = New System.Windows.Forms.Button()
        Me.butAddId_tipoUsuario = New System.Windows.Forms.Button()
        Me.lblId_tipoUsuario = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbotipoUsuario
        '
        Me.cbotipoUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbotipoUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbotipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbotipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbotipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbotipoUsuario.Location = New System.Drawing.Point(101, 14)
        Me.cbotipoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbotipoUsuario.Name = "cbotipoUsuario"
        Me.cbotipoUsuario.Size = New System.Drawing.Size(181, 23)
        Me.cbotipoUsuario.TabIndex = 1
        '
        'butVerId_tipoUsuario
        '
        Me.butVerId_tipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_tipoUsuario.FlatAppearance.BorderSize = 0
        Me.butVerId_tipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_tipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_tipoUsuario.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_tipoUsuario.Location = New System.Drawing.Point(286, 14)
        Me.butVerId_tipoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_tipoUsuario.Name = "butVerId_tipoUsuario"
        Me.butVerId_tipoUsuario.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_tipoUsuario.TabIndex = 4
        Me.butVerId_tipoUsuario.TabStop = False
        '
        'butAddId_tipoUsuario
        '
        Me.butAddId_tipoUsuario.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_tipoUsuario.FlatAppearance.BorderSize = 0
        Me.butAddId_tipoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_tipoUsuario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_tipoUsuario.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_tipoUsuario.Location = New System.Drawing.Point(308, 14)
        Me.butAddId_tipoUsuario.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_tipoUsuario.Name = "butAddId_tipoUsuario"
        Me.butAddId_tipoUsuario.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_tipoUsuario.TabIndex = 5
        Me.butAddId_tipoUsuario.TabStop = False
        '
        'lblId_tipoUsuario
        '
        Me.lblId_tipoUsuario.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_tipoUsuario.Location = New System.Drawing.Point(20, 12)
        Me.lblId_tipoUsuario.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_tipoUsuario.Name = "lblId_tipoUsuario"
        Me.lblId_tipoUsuario.Size = New System.Drawing.Size(77, 30)
        Me.lblId_tipoUsuario.TabIndex = 3
        Me.lblId_tipoUsuario.Text = "Tipo de usuario"
        Me.lblId_tipoUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_tipoUsuario, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cbotipoUsuario, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_tipoUsuario, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_tipoUsuario, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(10, 48)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(374, 60)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntNoticias_TiposUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(394, 182)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(378, 136)
        Me.Name = "frmEntNoticias_TiposUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Noticias_TiposUsuarios"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbotipoUsuario As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_tipoUsuario As System.Windows.Forms.Button
    Private WithEvents butAddId_tipoUsuario As System.Windows.Forms.Button
    Private WithEvents lblId_tipoUsuario As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
