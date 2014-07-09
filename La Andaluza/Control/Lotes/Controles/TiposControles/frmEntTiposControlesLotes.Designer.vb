<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposControlesLotes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposControlesLotes))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.txtRutaControles = New System.Windows.Forms.TextBox()
        Me.butRutaControles = New System.Windows.Forms.Button()
        Me.cboprocedimiento = New System.Windows.Forms.ComboBox()
        Me.butVerId_procedimiento = New System.Windows.Forms.Button()
        Me.butAddId_procedimiento = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblRutaControles = New System.Windows.Forms.Label()
        Me.lblId_procedimiento = New System.Windows.Forms.Label()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(112, 14)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 21)
        Me.txtDescripcion.TabIndex = 0
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 42)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(253, 21)
        Me.txtObservaciones.TabIndex = 1
        '
        'txtRutaControles
        '
        Me.txtRutaControles.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaControles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtRutaControles, 4)
        Me.txtRutaControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRutaControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaControles.Location = New System.Drawing.Point(112, 70)
        Me.txtRutaControles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaControles.MaxLength = 250
        Me.txtRutaControles.Name = "txtRutaControles"
        Me.txtRutaControles.Size = New System.Drawing.Size(253, 21)
        Me.txtRutaControles.TabIndex = 2
        '
        'butRutaControles
        '
        Me.butRutaControles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRutaControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butRutaControles.FlatAppearance.BorderSize = 0
        Me.butRutaControles.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaControles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaControles.Image = CType(resources.GetObject("butRutaControles.Image"), System.Drawing.Image)
        Me.butRutaControles.Location = New System.Drawing.Point(369, 70)
        Me.butRutaControles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaControles.Name = "butRutaControles"
        Me.butRutaControles.Size = New System.Drawing.Size(18, 24)
        Me.butRutaControles.TabIndex = 3
        Me.butRutaControles.TabStop = False
        '
        'cboprocedimiento
        '
        Me.cboprocedimiento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboprocedimiento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboprocedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboprocedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboprocedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboprocedimiento.Location = New System.Drawing.Point(112, 98)
        Me.cboprocedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboprocedimiento.Name = "cboprocedimiento"
        Me.cboprocedimiento.Size = New System.Drawing.Size(181, 23)
        Me.cboprocedimiento.TabIndex = 3
        '
        'butVerId_procedimiento
        '
        Me.butVerId_procedimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_procedimiento.FlatAppearance.BorderSize = 0
        Me.butVerId_procedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_procedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_procedimiento.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_procedimiento.Location = New System.Drawing.Point(297, 98)
        Me.butVerId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_procedimiento.Name = "butVerId_procedimiento"
        Me.butVerId_procedimiento.Size = New System.Drawing.Size(18, 26)
        Me.butVerId_procedimiento.TabIndex = 5
        Me.butVerId_procedimiento.TabStop = False
        '
        'butAddId_procedimiento
        '
        Me.butAddId_procedimiento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_procedimiento.FlatAppearance.BorderSize = 0
        Me.butAddId_procedimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_procedimiento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_procedimiento.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_procedimiento.Location = New System.Drawing.Point(319, 98)
        Me.butAddId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_procedimiento.Name = "butAddId_procedimiento"
        Me.butAddId_procedimiento.Size = New System.Drawing.Size(18, 26)
        Me.butAddId_procedimiento.TabIndex = 6
        Me.butAddId_procedimiento.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(88, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 40)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(88, 28)
        Me.lblObservaciones.TabIndex = 1
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaControles
        '
        Me.lblRutaControles.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRutaControles.Location = New System.Drawing.Point(20, 68)
        Me.lblRutaControles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaControles.Name = "lblRutaControles"
        Me.lblRutaControles.Size = New System.Drawing.Size(88, 28)
        Me.lblRutaControles.TabIndex = 2
        Me.lblRutaControles.Text = "Ruta"
        Me.lblRutaControles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_procedimiento
        '
        Me.lblId_procedimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_procedimiento.Location = New System.Drawing.Point(20, 96)
        Me.lblId_procedimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_procedimiento.Name = "lblId_procedimiento"
        Me.lblId_procedimiento.Size = New System.Drawing.Size(88, 30)
        Me.lblId_procedimiento.TabIndex = 4
        Me.lblId_procedimiento.Text = "Procedimiento"
        Me.lblId_procedimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblRutaControles, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtRutaControles, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.butRutaControles, 6, 2)
        Me.tlpMiddle.Controls.Add(Me.lblId_procedimiento, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboprocedimiento, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerId_procedimiento, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddId_procedimiento, 4, 3)
        Me.tlpMiddle.Location = New System.Drawing.Point(40, 63)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(412, 144)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntTiposControlesLotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(549, 253)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(416, 184)
        Me.Name = "frmEntTiposControlesLotes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposControlesLotes"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents txtRutaControles As System.Windows.Forms.TextBox
    Private WithEvents butRutaControles As System.Windows.Forms.Button
    Private WithEvents cboprocedimiento As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_procedimiento As System.Windows.Forms.Button
    Private WithEvents butAddId_procedimiento As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblRutaControles As System.Windows.Forms.Label
    Private WithEvents lblId_procedimiento As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
