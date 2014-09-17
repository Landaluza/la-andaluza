<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntTiposDEpositoPorDEposito
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposDEpositoPorDEposito))
        Me.cboTipoDeposito = New System.Windows.Forms.ComboBox()
        Me.butAddId_TipoDeposito = New System.Windows.Forms.Button()
        Me.lblId_TipoDeposito = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboTipoDeposito
        '
        Me.cboTipoDeposito.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoDeposito.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboTipoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoDeposito.Location = New System.Drawing.Point(120, 18)
        Me.cboTipoDeposito.Name = "cboTipoDeposito"
        Me.cboTipoDeposito.Size = New System.Drawing.Size(200, 23)
        Me.cboTipoDeposito.TabIndex = 1
        '
        'butAddId_TipoDeposito
        '
        Me.butAddId_TipoDeposito.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_TipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_TipoDeposito.FlatAppearance.BorderSize = 0
        Me.butAddId_TipoDeposito.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TipoDeposito.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TipoDeposito.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TipoDeposito.Location = New System.Drawing.Point(326, 18)
        Me.butAddId_TipoDeposito.Name = "butAddId_TipoDeposito"
        Me.butAddId_TipoDeposito.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_TipoDeposito.TabIndex = 5
        Me.butAddId_TipoDeposito.TabStop = False
        '
        'lblId_TipoDeposito
        '
        Me.lblId_TipoDeposito.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_TipoDeposito.Location = New System.Drawing.Point(23, 15)
        Me.lblId_TipoDeposito.Name = "lblId_TipoDeposito"
        Me.lblId_TipoDeposito.Size = New System.Drawing.Size(91, 29)
        Me.lblId_TipoDeposito.TabIndex = 3
        Me.lblId_TipoDeposito.Text = "Tipodeposito"
        Me.lblId_TipoDeposito.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_TipoDeposito, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboTipoDeposito, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddId_TipoDeposito, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(421, 64)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntTiposDEpositoPorDEposito
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(405, 105)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(421, 138)
        Me.Name = "frmEntTiposDEpositoPorDEposito"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Depositos_TiposDepositos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboTipoDeposito As System.Windows.Forms.ComboBox
    Private WithEvents butAddId_TipoDeposito As System.Windows.Forms.Button
    Private WithEvents lblId_TipoDeposito As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
