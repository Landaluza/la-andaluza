<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPartesEnvasados_CausasPartesEnvasado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPartesEnvasados_CausasPartesEnvasado))
        Me.cboCausaParteEnvasado = New System.Windows.Forms.ComboBox()
        Me.butVerId_CausaParteEnvasado = New System.Windows.Forms.Button()
        Me.butAddId_CausaParteEnvasado = New System.Windows.Forms.Button()
        Me.lblId_CausaParteEnvasado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboCausaParteEnvasado
        '
        Me.cboCausaParteEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCausaParteEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCausaParteEnvasado.Location = New System.Drawing.Point(90, 98)
        Me.cboCausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCausaParteEnvasado.Name = "cboCausaParteEnvasado"
        Me.cboCausaParteEnvasado.Size = New System.Drawing.Size(390, 23)
        Me.cboCausaParteEnvasado.TabIndex = 1
        '
        'butVerId_CausaParteEnvasado
        '
        Me.butVerId_CausaParteEnvasado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_CausaParteEnvasado.FlatAppearance.BorderSize = 0
        Me.butVerId_CausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_CausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_CausaParteEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_CausaParteEnvasado.Location = New System.Drawing.Point(484, 98)
        Me.butVerId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_CausaParteEnvasado.Name = "butVerId_CausaParteEnvasado"
        Me.butVerId_CausaParteEnvasado.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_CausaParteEnvasado.TabIndex = 4
        Me.butVerId_CausaParteEnvasado.TabStop = False
        '
        'butAddId_CausaParteEnvasado
        '
        Me.butAddId_CausaParteEnvasado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_CausaParteEnvasado.FlatAppearance.BorderSize = 0
        Me.butAddId_CausaParteEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_CausaParteEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_CausaParteEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_CausaParteEnvasado.Location = New System.Drawing.Point(506, 98)
        Me.butAddId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_CausaParteEnvasado.Name = "butAddId_CausaParteEnvasado"
        Me.butAddId_CausaParteEnvasado.Size = New System.Drawing.Size(18, 19)
        Me.butAddId_CausaParteEnvasado.TabIndex = 5
        Me.butAddId_CausaParteEnvasado.TabStop = False
        '
        'lblId_CausaParteEnvasado
        '
        Me.lblId_CausaParteEnvasado.Location = New System.Drawing.Point(40, 95)
        Me.lblId_CausaParteEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_CausaParteEnvasado.Name = "lblId_CausaParteEnvasado"
        Me.lblId_CausaParteEnvasado.Size = New System.Drawing.Size(45, 30)
        Me.lblId_CausaParteEnvasado.TabIndex = 3
        Me.lblId_CausaParteEnvasado.Text = "Causa"
        Me.lblId_CausaParteEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntPartesEnvasados_CausasPartesEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(579, 182)
        Me.Controls.Add(Me.cboCausaParteEnvasado)
        Me.Controls.Add(Me.lblId_CausaParteEnvasado)
        Me.Controls.Add(Me.butAddId_CausaParteEnvasado)
        Me.Controls.Add(Me.butVerId_CausaParteEnvasado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPartesEnvasados_CausasPartesEnvasado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PartesEnvasados_CausasPartesEnvasado"
        Me.Controls.SetChildIndex(Me.butVerId_CausaParteEnvasado, 0)
        Me.Controls.SetChildIndex(Me.butAddId_CausaParteEnvasado, 0)
        Me.Controls.SetChildIndex(Me.lblId_CausaParteEnvasado, 0)
        Me.Controls.SetChildIndex(Me.cboCausaParteEnvasado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboCausaParteEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_CausaParteEnvasado As System.Windows.Forms.Button
    Private WithEvents butAddId_CausaParteEnvasado As System.Windows.Forms.Button
    Private WithEvents lblId_CausaParteEnvasado As System.Windows.Forms.Label

End Class
