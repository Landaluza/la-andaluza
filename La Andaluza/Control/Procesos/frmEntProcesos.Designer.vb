<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProcesos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProcesos))
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.cboTipoLote = New System.Windows.Forms.ComboBox()
        Me.butVerTipoLoteID = New System.Windows.Forms.Button()
        Me.butAddTipoLoteID = New System.Windows.Forms.Button()
        Me.chbConMuestra = New System.Windows.Forms.CheckBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblTipoProductoParaLote = New System.Windows.Forms.Label()
        Me.lblTipoMovimiento = New System.Windows.Forms.Label()
        Me.lblTipoLoteID = New System.Windows.Forms.Label()
        Me.lblConMuestra = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.txtTipoProductoParaLote = New System.Windows.Forms.ComboBox()
        Me.txtTipoMovimiento = New System.Windows.Forms.ComboBox()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(132, 14)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 14)
        Me.txtDescripcion.TabIndex = 0
        '
        'cboTipoLote
        '
        Me.cboTipoLote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoLote.Location = New System.Drawing.Point(132, 98)
        Me.cboTipoLote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoLote.Name = "cboTipoLote"
        Me.cboTipoLote.Size = New System.Drawing.Size(181, 23)
        Me.cboTipoLote.TabIndex = 3
        '
        'butVerTipoLoteID
        '
        Me.butVerTipoLoteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerTipoLoteID.FlatAppearance.BorderSize = 0
        Me.butVerTipoLoteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoLoteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoLoteID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerTipoLoteID.Location = New System.Drawing.Point(317, 98)
        Me.butVerTipoLoteID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerTipoLoteID.Name = "butVerTipoLoteID"
        Me.butVerTipoLoteID.Size = New System.Drawing.Size(18, 26)
        Me.butVerTipoLoteID.TabIndex = 4
        Me.butVerTipoLoteID.TabStop = False
        '
        'butAddTipoLoteID
        '
        Me.butAddTipoLoteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddTipoLoteID.FlatAppearance.BorderSize = 0
        Me.butAddTipoLoteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoLoteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoLoteID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoLoteID.Location = New System.Drawing.Point(339, 98)
        Me.butAddTipoLoteID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddTipoLoteID.Name = "butAddTipoLoteID"
        Me.butAddTipoLoteID.Size = New System.Drawing.Size(18, 26)
        Me.butAddTipoLoteID.TabIndex = 5
        Me.butAddTipoLoteID.TabStop = False
        '
        'chbConMuestra
        '
        Me.chbConMuestra.BackColor = System.Drawing.SystemColors.Control
        Me.chbConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbConMuestra.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbConMuestra.Location = New System.Drawing.Point(132, 128)
        Me.chbConMuestra.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbConMuestra.Name = "chbConMuestra"
        Me.chbConMuestra.Size = New System.Drawing.Size(181, 21)
        Me.chbConMuestra.TabIndex = 4
        Me.chbConMuestra.UseVisualStyleBackColor = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(108, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoProductoParaLote
        '
        Me.lblTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoProductoParaLote.Location = New System.Drawing.Point(20, 40)
        Me.lblTipoProductoParaLote.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoProductoParaLote.Name = "lblTipoProductoParaLote"
        Me.lblTipoProductoParaLote.Size = New System.Drawing.Size(108, 28)
        Me.lblTipoProductoParaLote.TabIndex = 1
        Me.lblTipoProductoParaLote.Text = "Tipo producto"
        Me.lblTipoProductoParaLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoMovimiento
        '
        Me.lblTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoMovimiento.Location = New System.Drawing.Point(20, 68)
        Me.lblTipoMovimiento.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoMovimiento.Name = "lblTipoMovimiento"
        Me.lblTipoMovimiento.Size = New System.Drawing.Size(108, 28)
        Me.lblTipoMovimiento.TabIndex = 2
        Me.lblTipoMovimiento.Text = "Tipo movimiento"
        Me.lblTipoMovimiento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoLoteID
        '
        Me.lblTipoLoteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblTipoLoteID.Location = New System.Drawing.Point(20, 96)
        Me.lblTipoLoteID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoLoteID.Name = "lblTipoLoteID"
        Me.lblTipoLoteID.Size = New System.Drawing.Size(108, 30)
        Me.lblTipoLoteID.TabIndex = 3
        Me.lblTipoLoteID.Text = "Tipo lote"
        Me.lblTipoLoteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblConMuestra
        '
        Me.lblConMuestra.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblConMuestra.Location = New System.Drawing.Point(20, 126)
        Me.lblConMuestra.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblConMuestra.Name = "lblConMuestra"
        Me.lblConMuestra.Size = New System.Drawing.Size(108, 25)
        Me.lblConMuestra.TabIndex = 6
        Me.lblConMuestra.Text = "ConMuestra"
        Me.lblConMuestra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblTipoProductoParaLote, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.lblTipoMovimiento, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.lblTipoLoteID, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cboTipoLote, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.butVerTipoLoteID, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.butAddTipoLoteID, 4, 3)
        Me.tlpMiddle.Controls.Add(Me.lblConMuestra, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbConMuestra, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtTipoProductoParaLote, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.txtTipoMovimiento, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 24)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(405, 128)
        Me.tlpMiddle.TabIndex = 8
        '
        'txtTipoProductoParaLote
        '
        Me.txtTipoProductoParaLote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtTipoProductoParaLote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoProductoParaLote.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoProductoParaLote.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTipoProductoParaLote.FormattingEnabled = True
        Me.txtTipoProductoParaLote.Items.AddRange(New Object() {"D", "H", "I"})
        Me.txtTipoProductoParaLote.Location = New System.Drawing.Point(132, 42)
        Me.txtTipoProductoParaLote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTipoProductoParaLote.Name = "txtTipoProductoParaLote"
        Me.txtTipoProductoParaLote.Size = New System.Drawing.Size(181, 21)
        Me.txtTipoProductoParaLote.TabIndex = 7
        '
        'txtTipoMovimiento
        '
        Me.txtTipoMovimiento.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTipoMovimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtTipoMovimiento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.txtTipoMovimiento.FormattingEnabled = True
        Me.txtTipoMovimiento.Items.AddRange(New Object() {"A", "D", "E", "F", "M", "S", "T"})
        Me.txtTipoMovimiento.Location = New System.Drawing.Point(132, 70)
        Me.txtTipoMovimiento.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtTipoMovimiento.Name = "txtTipoMovimiento"
        Me.txtTipoMovimiento.Size = New System.Drawing.Size(181, 21)
        Me.txtTipoMovimiento.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(400, 182)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(409, 210)
        Me.Name = "frmEntProcesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Procesos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents cboTipoLote As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoLoteID As System.Windows.Forms.Button
    Private WithEvents butAddTipoLoteID As System.Windows.Forms.Button
    Private WithEvents chbConMuestra As System.Windows.Forms.CheckBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblTipoProductoParaLote As System.Windows.Forms.Label
    Private WithEvents lblTipoMovimiento As System.Windows.Forms.Label
    Private WithEvents lblTipoLoteID As System.Windows.Forms.Label
    Private WithEvents lblConMuestra As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

    Private WithEvents txtTipoProductoParaLote As System.Windows.Forms.ComboBox
    Private WithEvents txtTipoMovimiento As System.Windows.Forms.ComboBox
End Class
