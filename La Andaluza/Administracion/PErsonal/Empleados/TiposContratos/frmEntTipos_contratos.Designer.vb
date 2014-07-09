<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTipos_contratos
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
        Me.txtnombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtobservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.lblobservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtnombre.EsUnicoCampo = ""
        Me.txtnombre.EsUnicoCampoID = ""
        Me.txtnombre.EsUnicoID = 0
        Me.txtnombre.EsUnicoTabla = ""
        Me.txtnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(133, 18)
        Me.txtnombre.MaxLength = 300
        Me.txtnombre.Minimo = 0
        Me.txtnombre.Modificado = False
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Numerico_EsNumerico = False
        Me.txtnombre.Numerico_NumeroDoublees = 0
        Me.txtnombre.Numerico_SeparadorMiles = False
        Me.txtnombre.Obligatorio = False
        Me.txtnombre.ParametroID = 0
        Me.txtnombre.Size = New System.Drawing.Size(240, 24)
        Me.txtnombre.TabIndex = 0
        Me.txtnombre.ValorMaximo = 0.0!
        Me.txtnombre.ValorMinimo = 0.0!
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtobservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtobservaciones.EsUnicoCampo = ""
        Me.txtobservaciones.EsUnicoCampoID = ""
        Me.txtobservaciones.EsUnicoID = 0
        Me.txtobservaciones.EsUnicoTabla = ""
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(133, 53)
        Me.txtobservaciones.MaxLength = 1000
        Me.txtobservaciones.Minimo = 0
        Me.txtobservaciones.Modificado = False
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Numerico_EsNumerico = False
        Me.txtobservaciones.Numerico_NumeroDoublees = 0
        Me.txtobservaciones.Numerico_SeparadorMiles = False
        Me.txtobservaciones.Obligatorio = False
        Me.txtobservaciones.ParametroID = 0
        Me.txtobservaciones.Size = New System.Drawing.Size(240, 24)
        Me.txtobservaciones.TabIndex = 1
        Me.txtobservaciones.ValorMaximo = 0.0!
        Me.txtobservaciones.ValorMinimo = 0.0!
        '
        'lblnombre
        '
        Me.lblnombre.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblnombre.Location = New System.Drawing.Point(27, 15)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(100, 35)
        Me.lblnombre.TabIndex = 0
        Me.lblnombre.Text = "nombre"
        Me.lblnombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblobservaciones
        '
        Me.lblobservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblobservaciones.Location = New System.Drawing.Point(27, 50)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(100, 35)
        Me.lblobservaciones.TabIndex = 1
        Me.lblobservaciones.Text = "observaciones"
        Me.lblobservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118.0!))
        Me.tlpMiddle.Controls.Add(Me.lblnombre, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtnombre, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblobservaciones, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtobservaciones, 2, 1)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(491, 109)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntTipos_contratos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(491, 134)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(497, 155)
        Me.Name = "frmEntTipos_contratos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Tipos_contratos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtnombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtobservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblnombre As System.Windows.Forms.Label
    Private WithEvents lblobservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
