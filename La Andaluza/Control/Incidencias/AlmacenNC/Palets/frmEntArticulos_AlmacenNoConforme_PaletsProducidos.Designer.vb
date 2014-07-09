<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulos_AlmacenNoConforme_PaletsProducidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulos_AlmacenNoConforme_PaletsProducidos))
        Me.cbopaletProduccido = New System.Windows.Forms.ComboBox()
        Me.lblId_paletProduccido = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbopaletProduccido
        '
        Me.cbopaletProduccido.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbopaletProduccido.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbopaletProduccido.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbopaletProduccido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbopaletProduccido.Location = New System.Drawing.Point(115, 57)
        Me.cbopaletProduccido.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbopaletProduccido.Name = "cbopaletProduccido"
        Me.cbopaletProduccido.Size = New System.Drawing.Size(280, 23)
        Me.cbopaletProduccido.TabIndex = 0
        '
        'lblId_paletProduccido
        '
        Me.lblId_paletProduccido.Location = New System.Drawing.Point(46, 54)
        Me.lblId_paletProduccido.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_paletProduccido.Name = "lblId_paletProduccido"
        Me.lblId_paletProduccido.Size = New System.Drawing.Size(64, 30)
        Me.lblId_paletProduccido.TabIndex = 0
        Me.lblId_paletProduccido.Text = "Palet"
        Me.lblId_paletProduccido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntArticulos_AlmacenNoConforme_PaletsProducidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(455, 129)
        Me.Controls.Add(Me.lblId_paletProduccido)
        Me.Controls.Add(Me.cbopaletProduccido)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(464, 136)
        Me.Name = "frmEntArticulos_AlmacenNoConforme_PaletsProducidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos_AlmacenNoConforme_PaletsProducidos"
        Me.Controls.SetChildIndex(Me.cbopaletProduccido, 0)
        Me.Controls.SetChildIndex(Me.lblId_paletProduccido, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cbopaletProduccido As System.Windows.Forms.ComboBox
    Private WithEvents lblId_paletProduccido As System.Windows.Forms.Label

End Class
