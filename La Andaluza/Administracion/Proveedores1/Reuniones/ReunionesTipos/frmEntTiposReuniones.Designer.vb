<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposReuniones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposReuniones))
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnombre.EsUnicoCampo = ""
        Me.txtnombre.EsUnicoCampoID = ""
        Me.txtnombre.EsUnicoID = 0
        Me.txtnombre.EsUnicoTabla = ""
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(74, 18)
        Me.txtnombre.MaxLength = 500
        Me.txtnombre.Minimo = 0
        Me.txtnombre.Modificado = False
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Numerico_EsNumerico = False
        Me.txtnombre.Numerico_NumeroDoublees = 0
        Me.txtnombre.Numerico_SeparadorMiles = False
        Me.txtnombre.Obligatorio = False
        Me.txtnombre.ParametroID = 0
        Me.txtnombre.Size = New System.Drawing.Size(278, 21)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.ValorMaximo = 0.0R
        Me.txtnombre.ValorMinimo = 0.0R
        '
        'lblnombre
        '
        Me.lblnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblnombre.Location = New System.Drawing.Point(23, 15)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(45, 27)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "Nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98.0!))
        Me.tlpMiddle.Controls.Add(Me.lblnombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtnombre, 2, 0)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 2
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(375, 82)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntTiposReuniones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(375, 107)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTiposReuniones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposReuniones"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblnombre As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
