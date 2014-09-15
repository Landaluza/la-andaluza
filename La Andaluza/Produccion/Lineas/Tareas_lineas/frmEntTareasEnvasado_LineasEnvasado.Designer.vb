<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTareasEnvasado_LineasEnvasado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTareasEnvasado_LineasEnvasado))
        Me.cboTareaEnvasado = New System.Windows.Forms.ComboBox()
        Me.butVerId_TareaEnvasado = New System.Windows.Forms.Button()
        Me.butAddId_TareaEnvasado = New System.Windows.Forms.Button()
        Me.cboLineaEnvasado = New System.Windows.Forms.ComboBox()
        Me.lblId_TareaEnvasado = New System.Windows.Forms.Label()
        Me.lblId_LineaEnvasado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTareaEnvasado
        '
        Me.cboTareaEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTareaEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTareaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTareaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTareaEnvasado.Location = New System.Drawing.Point(118, 36)
        Me.cboTareaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTareaEnvasado.Name = "cboTareaEnvasado"
        Me.cboTareaEnvasado.Size = New System.Drawing.Size(447, 23)
        Me.cboTareaEnvasado.TabIndex = 0
        '
        'butVerId_TareaEnvasado
        '
        Me.butVerId_TareaEnvasado.FlatAppearance.BorderSize = 0
        Me.butVerId_TareaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_TareaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_TareaEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_TareaEnvasado.Location = New System.Drawing.Point(568, 33)
        Me.butVerId_TareaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_TareaEnvasado.Name = "butVerId_TareaEnvasado"
        Me.butVerId_TareaEnvasado.Size = New System.Drawing.Size(18, 25)
        Me.butVerId_TareaEnvasado.TabIndex = 1
        Me.butVerId_TareaEnvasado.TabStop = False
        '
        'butAddId_TareaEnvasado
        '
        Me.butAddId_TareaEnvasado.FlatAppearance.BorderSize = 0
        Me.butAddId_TareaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_TareaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_TareaEnvasado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_TareaEnvasado.Location = New System.Drawing.Point(591, 33)
        Me.butAddId_TareaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_TareaEnvasado.Name = "butAddId_TareaEnvasado"
        Me.butAddId_TareaEnvasado.Size = New System.Drawing.Size(18, 24)
        Me.butAddId_TareaEnvasado.TabIndex = 2
        Me.butAddId_TareaEnvasado.TabStop = False
        '
        'cboLineaEnvasado
        '
        Me.cboLineaEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLineaEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLineaEnvasado.Enabled = False
        Me.cboLineaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLineaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineaEnvasado.Location = New System.Drawing.Point(118, 66)
        Me.cboLineaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboLineaEnvasado.Name = "cboLineaEnvasado"
        Me.cboLineaEnvasado.Size = New System.Drawing.Size(447, 23)
        Me.cboLineaEnvasado.TabIndex = 1
        '
        'lblId_TareaEnvasado
        '
        Me.lblId_TareaEnvasado.Location = New System.Drawing.Point(22, 33)
        Me.lblId_TareaEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_TareaEnvasado.Name = "lblId_TareaEnvasado"
        Me.lblId_TareaEnvasado.Size = New System.Drawing.Size(92, 30)
        Me.lblId_TareaEnvasado.TabIndex = 0
        Me.lblId_TareaEnvasado.Text = "Tarea"
        Me.lblId_TareaEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_LineaEnvasado
        '
        Me.lblId_LineaEnvasado.Enabled = False
        Me.lblId_LineaEnvasado.Location = New System.Drawing.Point(22, 63)
        Me.lblId_LineaEnvasado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_LineaEnvasado.Name = "lblId_LineaEnvasado"
        Me.lblId_LineaEnvasado.Size = New System.Drawing.Size(92, 30)
        Me.lblId_LineaEnvasado.TabIndex = 3
        Me.lblId_LineaEnvasado.Text = "Linea"
        Me.lblId_LineaEnvasado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntTareasEnvasado_LineasEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(630, 106)
        Me.Controls.Add(Me.lblId_TareaEnvasado)
        Me.Controls.Add(Me.cboTareaEnvasado)
        Me.Controls.Add(Me.butVerId_TareaEnvasado)
        Me.Controls.Add(Me.butAddId_TareaEnvasado)
        Me.Controls.Add(Me.cboLineaEnvasado)
        Me.Controls.Add(Me.lblId_LineaEnvasado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTareasEnvasado_LineasEnvasado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TareasEnvasado_LineasEnvasado"
        Me.Controls.SetChildIndex(Me.lblId_LineaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.cboLineaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.butAddId_TareaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.butVerId_TareaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.cboTareaEnvasado, 0)
        Me.Controls.SetChildIndex(Me.lblId_TareaEnvasado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboTareaEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_TareaEnvasado As System.Windows.Forms.Button
    Private WithEvents butAddId_TareaEnvasado As System.Windows.Forms.Button
    Private WithEvents cboLineaEnvasado As System.Windows.Forms.ComboBox
    Private WithEvents lblId_TareaEnvasado As System.Windows.Forms.Label
    Private WithEvents lblId_LineaEnvasado As System.Windows.Forms.Label

End Class
