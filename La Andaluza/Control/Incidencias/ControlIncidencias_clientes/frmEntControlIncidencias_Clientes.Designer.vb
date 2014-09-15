<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntControlIncidencias_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlIncidencias_Clientes))
        Me.cbocliente = New System.Windows.Forms.ComboBox()
        Me.butVerId_cliente = New System.Windows.Forms.Button()
        Me.butAddId_cliente = New System.Windows.Forms.Button()
        Me.lblId_cliente = New System.Windows.Forms.Label()

        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbocliente
        '
        Me.cbocliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbocliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbocliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbocliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbocliente.Location = New System.Drawing.Point(66, 28)
        Me.cbocliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbocliente.Name = "cbocliente"
        Me.cbocliente.Size = New System.Drawing.Size(306, 23)
        Me.cbocliente.TabIndex = 1
        '
        'butVerId_cliente
        '
        Me.butVerId_cliente.FlatAppearance.BorderSize = 0
        Me.butVerId_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_cliente.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_cliente.Location = New System.Drawing.Point(376, 28)
        Me.butVerId_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_cliente.Name = "butVerId_cliente"
        Me.butVerId_cliente.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_cliente.TabIndex = 4
        Me.butVerId_cliente.TabStop = False
        '
        'butAddId_cliente
        '
        Me.butAddId_cliente.FlatAppearance.BorderSize = 0
        Me.butAddId_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_cliente.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_cliente.Location = New System.Drawing.Point(398, 28)
        Me.butAddId_cliente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_cliente.Name = "butAddId_cliente"
        Me.butAddId_cliente.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_cliente.TabIndex = 5
        Me.butAddId_cliente.TabStop = False
        '
        'lblId_cliente
        '
        Me.lblId_cliente.Location = New System.Drawing.Point(18, 26)
        Me.lblId_cliente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_cliente.Name = "lblId_cliente"
        Me.lblId_cliente.Size = New System.Drawing.Size(44, 30)
        Me.lblId_cliente.TabIndex = 3
        Me.lblId_cliente.Text = "Cliente"
        Me.lblId_cliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cbocliente)
        Me.Panel1.Controls.Add(Me.lblId_cliente)
        Me.Panel1.Controls.Add(Me.butAddId_cliente)
        Me.Panel1.Controls.Add(Me.butVerId_cliente)
        Me.Panel1.Location = New System.Drawing.Point(27, 23)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(433, 81)
        Me.Panel1.TabIndex = 1000000001
        '
        'frmEntControlIncidencias_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(483, 124)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlIncidencias_Clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ControlIncidencias_Clientes"
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cbocliente As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_cliente As System.Windows.Forms.Button
    Private WithEvents butAddId_cliente As System.Windows.Forms.Button
    Private WithEvents lblId_cliente As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
