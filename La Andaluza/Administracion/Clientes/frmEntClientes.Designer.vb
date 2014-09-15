<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntClientes
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

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
        Me.txtClienteID = New BasesParaCompatibilidad.CuadroDeTexto
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto
        Me.txtCodigoQS = New BasesParaCompatibilidad.CuadroDeTexto
        Me.lblClienteID = New System.Windows.Forms.Label
        Me.lblNombre = New System.Windows.Forms.Label
        Me.lblCodigoQS = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtClienteID
        '
        Me.txtClienteID.BackColor = System.Drawing.SystemColors.Window
        Me.txtClienteID.EsUnicoCampo = ""
        Me.txtClienteID.EsUnicoCampoID = ""
        Me.txtClienteID.EsUnicoID = 0
        Me.txtClienteID.EsUnicoTabla = ""
        Me.txtClienteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtClienteID.Location = New System.Drawing.Point(83, 3)
        Me.txtClienteID.MaxLength = 9
        Me.txtClienteID.Minimo = 0
        Me.txtClienteID.Modificado = False
        Me.txtClienteID.Name = "txtClienteID"
        Me.txtClienteID.Numerico_EsNumerico = False
        Me.txtClienteID.Numerico_NumeroDoublees = 0
        Me.txtClienteID.Numerico_SeparadorMiles = False
        Me.txtClienteID.Obligatorio = False
        Me.txtClienteID.ParametroID = 0
        Me.txtClienteID.Size = New System.Drawing.Size(101, 21)
        Me.txtClienteID.TabIndex = 0
        Me.txtClienteID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtClienteID.ValorMaximo = 0.0!
        Me.txtClienteID.ValorMinimo = 0.0!
        Me.txtClienteID.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.EsUnicoCampo = ""
        Me.txtNombre.EsUnicoCampoID = ""
        Me.txtNombre.EsUnicoID = 0
        Me.txtNombre.EsUnicoTabla = ""
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(83, 57)
        Me.txtNombre.MaxLength = 300
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(326, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.ValorMaximo = 0.0!
        Me.txtNombre.ValorMinimo = 0.0!
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.EsUnicoCampo = ""
        Me.txtCodigoQS.EsUnicoCampoID = ""
        Me.txtCodigoQS.EsUnicoID = 0
        Me.txtCodigoQS.EsUnicoTabla = ""
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(83, 30)
        Me.txtCodigoQS.MaxLength = 10
        Me.txtCodigoQS.Minimo = 0
        Me.txtCodigoQS.Modificado = False
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Numerico_EsNumerico = False
        Me.txtCodigoQS.Numerico_NumeroDoublees = 0
        Me.txtCodigoQS.Numerico_SeparadorMiles = False
        Me.txtCodigoQS.Obligatorio = False
        Me.txtCodigoQS.ParametroID = 0
        Me.txtCodigoQS.Size = New System.Drawing.Size(101, 21)
        Me.txtCodigoQS.TabIndex = 0
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigoQS.ValorMaximo = 0.0!
        Me.txtCodigoQS.ValorMinimo = 0.0!
        '
        'lblClienteID
        '
        Me.lblClienteID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblClienteID.Location = New System.Drawing.Point(22, 0)
        Me.lblClienteID.Name = "lblClienteID"
        Me.lblClienteID.Size = New System.Drawing.Size(55, 21)
        Me.lblClienteID.TabIndex = 0
        Me.lblClienteID.Text = "ClienteID"
        Me.lblClienteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblClienteID.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblNombre.Location = New System.Drawing.Point(22, 57)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(55, 21)
        Me.lblNombre.TabIndex = 1
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblCodigoQS.Location = New System.Drawing.Point(22, 30)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(55, 21)
        Me.lblCodigoQS.TabIndex = 2
        Me.lblCodigoQS.Text = "CodigoQS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle)
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.Controls.Add(Me.lblClienteID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtClienteID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCodigoQS, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtCodigoQS, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(447, 81)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(447, 161)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Clientes"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtClienteID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCodigoQS As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblClienteID As System.Windows.Forms.Label
   Private WithEvents lblNombre As System.Windows.Forms.Label
   Private WithEvents lblCodigoQS As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
