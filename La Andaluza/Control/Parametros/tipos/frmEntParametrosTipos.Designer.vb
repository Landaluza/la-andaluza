<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntParametrosTipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntParametrosTipos))
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.EsUnicoCampo = ""
        Me.txtnombre.EsUnicoCampoID = ""
        Me.txtnombre.EsUnicoID = 0
        Me.txtnombre.EsUnicoTabla = ""
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(115, 40)
        Me.txtnombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtnombre.MaxLength = 300
        Me.txtnombre.Minimo = 0
        Me.txtnombre.Modificado = False
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Numerico_EsNumerico = False
        Me.txtnombre.Numerico_NumeroDoublees = 0
        Me.txtnombre.Numerico_SeparadorMiles = False
        Me.txtnombre.Obligatorio = False
        Me.txtnombre.ParametroID = 0
        Me.txtnombre.Size = New System.Drawing.Size(181, 21)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.ValorMaximo = 0.0R
        Me.txtnombre.ValorMinimo = 0.0R
        '
        'lblnombre
        '
        Me.lblnombre.Location = New System.Drawing.Point(58, 37)
        Me.lblnombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(52, 28)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntParametrosTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(365, 89)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.txtnombre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntParametrosTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ParametrosTipos"
        Me.Controls.SetChildIndex(Me.txtnombre, 0)
        Me.Controls.SetChildIndex(Me.lblnombre, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblnombre As System.Windows.Forms.Label

End Class
