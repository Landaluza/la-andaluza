<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosClientesNecesidades
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
        Me.cboCliente = New System.Windows.Forms.ComboBox()
        Me.butVerClienteID = New System.Windows.Forms.Button()
        Me.butAddClienteID = New System.Windows.Forms.Button()
        Me.txtRuta = New System.Windows.Forms.TextBox()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New System.Windows.Forms.TextBox()
        Me.lblClienteID = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboCliente
        '
        Me.cboCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCliente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCliente.Location = New System.Drawing.Point(207, 18)
        Me.cboCliente.Name = "cboCliente"
        Me.cboCliente.Size = New System.Drawing.Size(240, 26)
        Me.cboCliente.TabIndex = 0
        '
        'butVerClienteID
        '
        Me.butVerClienteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerClienteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerClienteID.FlatAppearance.BorderSize = 0
        Me.butVerClienteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerClienteID.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerClienteID.Location = New System.Drawing.Point(453, 18)
        Me.butVerClienteID.Name = "butVerClienteID"
        Me.butVerClienteID.Size = New System.Drawing.Size(24, 31)
        Me.butVerClienteID.TabIndex = 1
        Me.butVerClienteID.TabStop = False
        '
        'butAddClienteID
        '
        Me.butAddClienteID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddClienteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddClienteID.FlatAppearance.BorderSize = 0
        Me.butAddClienteID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddClienteID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddClienteID.Location = New System.Drawing.Point(483, 18)
        Me.butAddClienteID.Name = "butAddClienteID"
        Me.butAddClienteID.Size = New System.Drawing.Size(24, 31)
        Me.butAddClienteID.TabIndex = 2
        Me.butAddClienteID.TabStop = False
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtRuta, 4)
        Me.txtRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(207, 55)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Size = New System.Drawing.Size(336, 24)
        Me.txtRuta.TabIndex = 1
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(549, 55)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(24, 29)
        Me.butRuta.TabIndex = 4
        Me.butRuta.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(207, 90)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 24)
        Me.txtObservaciones.TabIndex = 2
        '
        'lblClienteID
        '
        Me.lblClienteID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblClienteID.Location = New System.Drawing.Point(27, 15)
        Me.lblClienteID.Name = "lblClienteID"
        Me.lblClienteID.Size = New System.Drawing.Size(174, 37)
        Me.lblClienteID.TabIndex = 0
        Me.lblClienteID.Text = "Cliente"
        Me.lblClienteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblRuta.Location = New System.Drawing.Point(27, 52)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(174, 35)
        Me.lblRuta.TabIndex = 3
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 87)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(174, 34)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.tlpMiddle.Controls.Add(Me.lblClienteID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboCliente, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerClienteID, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddClienteID, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 6, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(12, 46)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(605, 147)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntPedidosClientesNecesidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(624, 228)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPedidosClientesNecesidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PedidosClientesNecesidades"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboCliente As System.Windows.Forms.ComboBox
    Private WithEvents butVerClienteID As System.Windows.Forms.Button
    Private WithEvents butAddClienteID As System.Windows.Forms.Button
    Private WithEvents txtRuta As System.Windows.Forms.TextBox
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As System.Windows.Forms.TextBox
    Private WithEvents lblClienteID As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
