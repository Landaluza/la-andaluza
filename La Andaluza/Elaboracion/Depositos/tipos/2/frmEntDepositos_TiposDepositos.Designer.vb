<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntDepositos_TiposDepositos
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
        Me.cboDeposito = New System.Windows.Forms.ComboBox()
        Me.butVerId_Deposito = New System.Windows.Forms.Button()
        Me.butAddId_Deposito = New System.Windows.Forms.Button()
        Me.cboTipoDeposito = New System.Windows.Forms.ComboBox()
        Me.butVerId_TipoDeposito = New System.Windows.Forms.Button()
        Me.butAddId_TipoDeposito = New System.Windows.Forms.Button()
        Me.lblId_Deposito = New System.Windows.Forms.Label
        Me.lblId_TipoDeposito = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboDeposito
        '
        Me.cboDeposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDeposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDeposito.Name = "cboDeposito
        Me.cboDeposito.TabIndex = 0
        Me.cboDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboDeposito.Size = New System.Drawing.Size(200,21)
        '
        'butVerId_Deposito
        '
        Me.butVerId_Deposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_Deposito.FlatAppearance.BorderSize = 0
        Me.butVerId_Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_Deposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_Deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_Deposito.Name = "butVerId_Deposito
        Me.butVerId_Deposito.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_Deposito.TabStop = False
        Me.butVerId_Deposito.Size = New System.Drawing.Size(20, 20)
        'butAddId_Deposito
        '
        Me.butAddId_Deposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_Deposito.FlatAppearance.BorderSize = 0
        Me.butAddId_Deposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_Deposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_Deposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_Deposito.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddId_Deposito.Name = "butAddId_Deposito
        Me.butAddId_Deposito.TabStop = False
        Me.butAddId_Deposito.Size = New System.Drawing.Size(20, 20)
        '
        '
        'cboTipoDeposito
        '
        Me.cboTipoDeposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoDeposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDeposito.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboTipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDeposito.Name = "cboTipoDeposito
        Me.cboTipoDeposito.TabIndex = 1
        Me.cboTipoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoDeposito.Size = New System.Drawing.Size(200,21)
        '
        'butVerId_TipoDeposito
        '
        Me.butVerId_TipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_TipoDeposito.FlatAppearance.BorderSize = 0
        Me.butVerId_TipoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TipoDeposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_TipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TipoDeposito.Name = "butVerId_TipoDeposito
        Me.butVerId_TipoDeposito.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_TipoDeposito.TabStop = False
        Me.butVerId_TipoDeposito.Size = New System.Drawing.Size(20, 20)
        'butAddId_TipoDeposito
        '
        Me.butAddId_TipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoDeposito.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoDeposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoDeposito.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddId_TipoDeposito.Name = "butAddId_TipoDeposito
        Me.butAddId_TipoDeposito.TabStop = False
        Me.butAddId_TipoDeposito.Size = New System.Drawing.Size(20, 20)
        '
        '
        'lblId_Deposito
        '
        Me.lblId_Deposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_Deposito.Name = "lblId_Deposito
        Me.lblId_Deposito.Text = "Deposito
        Me.lblId_Deposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblId_Deposito.Size = New System.Drawing.Size(91,21)
        Me.lblId_Deposito.Location = New System.Drawing.Point(20,40)
        '
        'lblId_TipoDeposito
        '
        Me.lblId_TipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoDeposito.Name = "lblId_TipoDeposito
        Me.lblId_TipoDeposito.Text = "Tipodeposito
        Me.lblId_TipoDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblId_TipoDeposito.Size = New System.Drawing.Size(91,21)
        Me.lblId_TipoDeposito.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_Deposito, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboDeposito, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerId_Deposito, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddId_Deposito, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoDeposito, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboTipoDeposito, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerId_TipoDeposito, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoDeposito, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(421, 58)
        '
        '
        'frmEntDepositos_TiposDepositos
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(421, 138)
        Me.MinimumSize = New System.Drawing.Size(421, 138)
        Me.Name = "frmEntDepositos_TiposDepositos
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Depositos_TiposDepositos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(421,348)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents cboDeposito As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_Deposito As System.Windows.Forms.Button
    Private WithEvents butAddId_Deposito As System.Windows.Forms.Button
    Private WithEvents cboTipoDeposito As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TipoDeposito As System.Windows.Forms.Button
    Private WithEvents butAddId_TipoDeposito As System.Windows.Forms.Button
    Private WithEvents lblId_Deposito As System.Windows.Forms.Label
    Private WithEvents lblId_TipoDeposito As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
