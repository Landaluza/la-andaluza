<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosClientesDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosClientesDocumentos))
        Me.txtPedidoClienteDocumentoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidoClienteMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPedidoClienteDocumentoID = New System.Windows.Forms.Label()
        Me.lblPedidoClienteMaestroID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtPedidoClienteDocumentoID
        '
        Me.txtPedidoClienteDocumentoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoClienteDocumentoID.EsUnicoCampo = ""
        Me.txtPedidoClienteDocumentoID.EsUnicoCampoID = ""
        Me.txtPedidoClienteDocumentoID.EsUnicoID = 0
        Me.txtPedidoClienteDocumentoID.EsUnicoTabla = ""
        Me.txtPedidoClienteDocumentoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoClienteDocumentoID.Location = New System.Drawing.Point(192, 3)
        Me.txtPedidoClienteDocumentoID.MaxLength = 9
        Me.txtPedidoClienteDocumentoID.Minimo = 0
        Me.txtPedidoClienteDocumentoID.Modificado = False
        Me.txtPedidoClienteDocumentoID.Name = "txtPedidoClienteDocumentoID"
        Me.txtPedidoClienteDocumentoID.Numerico_EsNumerico = False
        Me.txtPedidoClienteDocumentoID.Numerico_NumeroDoublees = 0
        Me.txtPedidoClienteDocumentoID.Numerico_SeparadorMiles = False
        Me.txtPedidoClienteDocumentoID.Obligatorio = True
        Me.txtPedidoClienteDocumentoID.ParametroID = 0
        Me.txtPedidoClienteDocumentoID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoClienteDocumentoID.TabIndex = 0
        Me.txtPedidoClienteDocumentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoClienteDocumentoID.ValorMaximo = 0.0R
        Me.txtPedidoClienteDocumentoID.ValorMinimo = 0.0R
        Me.txtPedidoClienteDocumentoID.Visible = False
        '
        'txtPedidoClienteMaestroID
        '
        Me.txtPedidoClienteMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoClienteMaestroID.EsUnicoCampo = ""
        Me.txtPedidoClienteMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoClienteMaestroID.EsUnicoID = 0
        Me.txtPedidoClienteMaestroID.EsUnicoTabla = ""
        Me.txtPedidoClienteMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoClienteMaestroID.Location = New System.Drawing.Point(192, 30)
        Me.txtPedidoClienteMaestroID.MaxLength = 9
        Me.txtPedidoClienteMaestroID.Minimo = 0
        Me.txtPedidoClienteMaestroID.Modificado = False
        Me.txtPedidoClienteMaestroID.Name = "txtPedidoClienteMaestroID"
        Me.txtPedidoClienteMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoClienteMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoClienteMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoClienteMaestroID.Obligatorio = False
        Me.txtPedidoClienteMaestroID.ParametroID = 0
        Me.txtPedidoClienteMaestroID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoClienteMaestroID.TabIndex = 1
        Me.txtPedidoClienteMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoClienteMaestroID.ValorMaximo = 0.0R
        Me.txtPedidoClienteMaestroID.ValorMinimo = 0.0R
        Me.txtPedidoClienteMaestroID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Cursor = System.Windows.Forms.Cursors.No
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(192, 84)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(651, 21)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(192, 111)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(651, 21)
        Me.txtRuta.TabIndex = 3
        Me.txtRuta.ValorMaximo = 0.0R
        Me.txtRuta.ValorMinimo = 0.0R
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(849, 111)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(20, 20)
        Me.butRuta.TabIndex = 4
        Me.butRuta.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(192, 57)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 4
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(192, 138)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(651, 21)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblPedidoClienteDocumentoID
        '
        Me.lblPedidoClienteDocumentoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoClienteDocumentoID.Location = New System.Drawing.Point(39, 0)
        Me.lblPedidoClienteDocumentoID.Name = "lblPedidoClienteDocumentoID"
        Me.lblPedidoClienteDocumentoID.Size = New System.Drawing.Size(147, 21)
        Me.lblPedidoClienteDocumentoID.TabIndex = 0
        Me.lblPedidoClienteDocumentoID.Text = "PedidoClienteDocumentoID"
        Me.lblPedidoClienteDocumentoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoClienteDocumentoID.Visible = False
        '
        'lblPedidoClienteMaestroID
        '
        Me.lblPedidoClienteMaestroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoClienteMaestroID.Location = New System.Drawing.Point(39, 27)
        Me.lblPedidoClienteMaestroID.Name = "lblPedidoClienteMaestroID"
        Me.lblPedidoClienteMaestroID.Size = New System.Drawing.Size(147, 21)
        Me.lblPedidoClienteMaestroID.TabIndex = 1
        Me.lblPedidoClienteMaestroID.Text = "PedidoClienteMaestroID"
        Me.lblPedidoClienteMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoClienteMaestroID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblDescripcion.Location = New System.Drawing.Point(39, 84)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(147, 21)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblRuta.Location = New System.Drawing.Point(39, 111)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(147, 21)
        Me.lblRuta.TabIndex = 3
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblFecha.Location = New System.Drawing.Point(39, 57)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(147, 21)
        Me.lblFecha.TabIndex = 6
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblObservaciones.Location = New System.Drawing.Point(39, 138)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(147, 21)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblPedidoClienteDocumentoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoClienteDocumentoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoClienteMaestroID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoClienteMaestroID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(873, 162)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntPedidosClientesDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(873, 212)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(399, 244)
        Me.Name = "frmEntPedidosClientesDocumentos"
        Me.Text = "PedidosClientesDocumentos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtPedidoClienteDocumentoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidoClienteMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPedidoClienteDocumentoID As System.Windows.Forms.Label
    Private WithEvents lblPedidoClienteMaestroID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
