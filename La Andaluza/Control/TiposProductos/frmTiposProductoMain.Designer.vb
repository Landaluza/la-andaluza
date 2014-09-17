<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTiposProductoMain
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tab = New System.Windows.Forms.TabControl()
        Me.tpProductos = New System.Windows.Forms.TabPage()
        Me.tpFamilia = New System.Windows.Forms.TabPage()
        Me.tpMedidas = New System.Windows.Forms.TabPage()
        Me.tpClases = New System.Windows.Forms.TabPage()
        Me.tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'tab
        '
        Me.tab.Appearance = System.Windows.Forms.TabAppearance.FlatButtons
        Me.tab.Controls.Add(Me.tpProductos)
        Me.tab.Controls.Add(Me.tpFamilia)
        Me.tab.Controls.Add(Me.tpMedidas)
        Me.tab.Controls.Add(Me.tpClases)
        Me.tab.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab.Location = New System.Drawing.Point(0, 0)
        Me.tab.Name = "tab"
        Me.tab.SelectedIndex = 0
        Me.tab.Size = New System.Drawing.Size(755, 443)
        Me.tab.TabIndex = 0
        '
        'tpProductos
        '
        Me.tpProductos.Location = New System.Drawing.Point(4, 25)
        Me.tpProductos.Name = "tpProductos"
        Me.tpProductos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpProductos.Size = New System.Drawing.Size(747, 414)
        Me.tpProductos.TabIndex = 0
        Me.tpProductos.Text = "Productos"
        Me.tpProductos.UseVisualStyleBackColor = True
        '
        'tpFamilia
        '
        Me.tpFamilia.Location = New System.Drawing.Point(4, 25)
        Me.tpFamilia.Name = "tpFamilia"
        Me.tpFamilia.Padding = New System.Windows.Forms.Padding(3)
        Me.tpFamilia.Size = New System.Drawing.Size(747, 414)
        Me.tpFamilia.TabIndex = 1
        Me.tpFamilia.Text = "Familias"
        Me.tpFamilia.UseVisualStyleBackColor = True
        '
        'tpMedidas
        '
        Me.tpMedidas.Location = New System.Drawing.Point(4, 25)
        Me.tpMedidas.Name = "tpMedidas"
        Me.tpMedidas.Padding = New System.Windows.Forms.Padding(3)
        Me.tpMedidas.Size = New System.Drawing.Size(747, 414)
        Me.tpMedidas.TabIndex = 2
        Me.tpMedidas.Text = "Medidas"
        Me.tpMedidas.UseVisualStyleBackColor = True
        '
        'tpClases
        '
        Me.tpClases.Location = New System.Drawing.Point(4, 25)
        Me.tpClases.Name = "tpClases"
        Me.tpClases.Padding = New System.Windows.Forms.Padding(3)
        Me.tpClases.Size = New System.Drawing.Size(747, 414)
        Me.tpClases.TabIndex = 3
        Me.tpClases.Text = "Clases"
        Me.tpClases.UseVisualStyleBackColor = True
        '
        'frmTiposProductoMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(755, 443)
        Me.Controls.Add(Me.tab)
        Me.Name = "frmTiposProductoMain"
        Me.Text = "Productos"
        Me.tab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents tab As System.Windows.Forms.TabControl
    Private WithEvents tpProductos As System.Windows.Forms.TabPage
    Private WithEvents tpFamilia As System.Windows.Forms.TabPage
    Private WithEvents tpMedidas As System.Windows.Forms.TabPage
    Private WithEvents tpClases As System.Windows.Forms.TabPage
End Class
