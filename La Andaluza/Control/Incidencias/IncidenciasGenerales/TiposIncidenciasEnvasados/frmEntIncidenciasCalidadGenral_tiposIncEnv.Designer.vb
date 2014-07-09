<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntIncidenciasCalidadGenral_tiposIncEnv
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.butAddId_tipo = New System.Windows.Forms.Button()
        Me.butVerId_tipo = New System.Windows.Forms.Button()
        Me.lblId_tipo = New System.Windows.Forms.Label()
        Me.cboTipo = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butAddId_tipo
        '
        Me.butAddId_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_tipo.FlatAppearance.BorderSize = 0
        Me.butAddId_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_tipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_tipo.Location = New System.Drawing.Point(656, 43)
        Me.butAddId_tipo.Name = "butAddId_tipo"
        Me.butAddId_tipo.Size = New System.Drawing.Size(24, 26)
        Me.butAddId_tipo.TabIndex = 15
        Me.butAddId_tipo.TabStop = False
        '
        'butVerId_tipo
        '
        Me.butVerId_tipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_tipo.FlatAppearance.BorderSize = 0
        Me.butVerId_tipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_tipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_tipo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_tipo.Location = New System.Drawing.Point(626, 43)
        Me.butVerId_tipo.Name = "butVerId_tipo"
        Me.butVerId_tipo.Size = New System.Drawing.Size(24, 26)
        Me.butVerId_tipo.TabIndex = 14
        Me.butVerId_tipo.TabStop = False
        '
        'lblId_tipo
        '
        Me.lblId_tipo.Location = New System.Drawing.Point(47, 40)
        Me.lblId_tipo.Name = "lblId_tipo"
        Me.lblId_tipo.Size = New System.Drawing.Size(89, 37)
        Me.lblId_tipo.TabIndex = 12
        Me.lblId_tipo.Text = "Tipo"
        Me.lblId_tipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboTipo
        '
        Me.cboTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipo.Location = New System.Drawing.Point(142, 43)
        Me.cboTipo.Name = "cboTipo"
        Me.cboTipo.Size = New System.Drawing.Size(478, 26)
        Me.cboTipo.TabIndex = 13
        '
        'frmEntIncidenciasCalidadGenral_tiposIncEnv
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(741, 125)
        Me.Controls.Add(Me.butAddId_tipo)
        Me.Controls.Add(Me.butVerId_tipo)
        Me.Controls.Add(Me.lblId_tipo)
        Me.Controls.Add(Me.cboTipo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmEntIncidenciasCalidadGenral_tiposIncEnv"
        Me.Text = "frmEntIncidenciasCalidadGenral_tiposIncEnv"
        Me.Controls.SetChildIndex(Me.cboTipo, 0)
        Me.Controls.SetChildIndex(Me.lblId_tipo, 0)
        Me.Controls.SetChildIndex(Me.butVerId_tipo, 0)
        Me.Controls.SetChildIndex(Me.butAddId_tipo, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents butAddId_tipo As System.Windows.Forms.Button
   Private WithEvents butVerId_tipo As System.Windows.Forms.Button
   Private WithEvents lblId_tipo As System.Windows.Forms.Label
   Private WithEvents cboTipo As System.Windows.Forms.ComboBox
End Class
