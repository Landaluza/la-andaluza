<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPuestosTrabajos
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
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboDepartamento = New System.Windows.Forms.ComboBox()
        Me.butVerId_Departamento = New System.Windows.Forms.Button()
        Me.butAddId_Departamento = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblId_Departamento = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(148, 60)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(300, 24)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'cboDepartamento
        '
        Me.cboDepartamento.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboDepartamento.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboDepartamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDepartamento.Location = New System.Drawing.Point(148, 95)
        Me.cboDepartamento.Name = "cboDepartamento"
        Me.cboDepartamento.Size = New System.Drawing.Size(240, 26)
        Me.cboDepartamento.TabIndex = 1
        '
        'butVerId_Departamento
        '
        Me.butVerId_Departamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_Departamento.FlatAppearance.BorderSize = 0
        Me.butVerId_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_Departamento.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_Departamento.Location = New System.Drawing.Point(394, 95)
        Me.butVerId_Departamento.Name = "butVerId_Departamento"
        Me.butVerId_Departamento.Size = New System.Drawing.Size(24, 26)
        Me.butVerId_Departamento.TabIndex = 2
        Me.butVerId_Departamento.TabStop = False
        '
        'butAddId_Departamento
        '
        Me.butAddId_Departamento.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_Departamento.FlatAppearance.BorderSize = 0
        Me.butAddId_Departamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_Departamento.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_Departamento.Location = New System.Drawing.Point(424, 95)
        Me.butAddId_Departamento.Name = "butAddId_Departamento"
        Me.butAddId_Departamento.Size = New System.Drawing.Size(24, 26)
        Me.butAddId_Departamento.TabIndex = 3
        Me.butAddId_Departamento.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(28, 57)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(114, 35)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_Departamento
        '
        Me.lblId_Departamento.Location = New System.Drawing.Point(28, 92)
        Me.lblId_Departamento.Name = "lblId_Departamento"
        Me.lblId_Departamento.Size = New System.Drawing.Size(114, 37)
        Me.lblId_Departamento.TabIndex = 1
        Me.lblId_Departamento.Text = "Departamento"
        Me.lblId_Departamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'frmEntPuestosTrabajos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(504, 154)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.butVerId_Departamento)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.butAddId_Departamento)
        Me.Controls.Add(Me.cboDepartamento)
        Me.Controls.Add(Me.lblId_Departamento)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPuestosTrabajos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PuestosTrabajos"
        Me.Controls.SetChildIndex(Me.lblId_Departamento, 0)
        Me.Controls.SetChildIndex(Me.cboDepartamento, 0)
        Me.Controls.SetChildIndex(Me.butAddId_Departamento, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.butVerId_Departamento, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboDepartamento As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_Departamento As System.Windows.Forms.Button
    Private WithEvents butAddId_Departamento As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblId_Departamento As System.Windows.Forms.Label
End Class
