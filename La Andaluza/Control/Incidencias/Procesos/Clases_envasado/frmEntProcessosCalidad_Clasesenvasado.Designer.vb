<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntProcessosCalidad_Clasesenvasado
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
        Me.butAddId_clase = New System.Windows.Forms.Button()
        Me.butVerId_clase = New System.Windows.Forms.Button()
        Me.lblId_clase = New System.Windows.Forms.Label()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'butAddId_clase
        '
        Me.butAddId_clase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_clase.FlatAppearance.BorderSize = 0
        Me.butAddId_clase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_clase.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_clase.Location = New System.Drawing.Point(632, 35)
        Me.butAddId_clase.Name = "butAddId_clase"
        Me.butAddId_clase.Size = New System.Drawing.Size(24, 26)
        Me.butAddId_clase.TabIndex = 11
        Me.butAddId_clase.TabStop = False
        '
        'butVerId_clase
        '
        Me.butVerId_clase.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_clase.FlatAppearance.BorderSize = 0
        Me.butVerId_clase.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_clase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_clase.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_clase.Location = New System.Drawing.Point(602, 35)
        Me.butVerId_clase.Name = "butVerId_clase"
        Me.butVerId_clase.Size = New System.Drawing.Size(24, 26)
        Me.butVerId_clase.TabIndex = 10
        Me.butVerId_clase.TabStop = False
        '
        'lblId_clase
        '
        Me.lblId_clase.Location = New System.Drawing.Point(23, 32)
        Me.lblId_clase.Name = "lblId_clase"
        Me.lblId_clase.Size = New System.Drawing.Size(89, 37)
        Me.lblId_clase.TabIndex = 8
        Me.lblId_clase.Text = "Clase"
        Me.lblId_clase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboClase
        '
        Me.cboClase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboClase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClase.Location = New System.Drawing.Point(118, 35)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(478, 26)
        Me.cboClase.TabIndex = 9
        '
        'frmEntProcessosCalidad_Clasesenvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(696, 100)
        Me.Controls.Add(Me.butAddId_clase)
        Me.Controls.Add(Me.butVerId_clase)
        Me.Controls.Add(Me.lblId_clase)
        Me.Controls.Add(Me.cboClase)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmEntProcessosCalidad_Clasesenvasado"
        Me.Text = "frmEntProcessosCalidad_Clasesenvasado"
        Me.Controls.SetChildIndex(Me.cboClase, 0)
        Me.Controls.SetChildIndex(Me.lblId_clase, 0)
        Me.Controls.SetChildIndex(Me.butVerId_clase, 0)
        Me.Controls.SetChildIndex(Me.butAddId_clase, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents butAddId_clase As System.Windows.Forms.Button
    Private WithEvents butVerId_clase As System.Windows.Forms.Button
    Private WithEvents lblId_clase As System.Windows.Forms.Label
    Private WithEvents cboClase As System.Windows.Forms.ComboBox
End Class
