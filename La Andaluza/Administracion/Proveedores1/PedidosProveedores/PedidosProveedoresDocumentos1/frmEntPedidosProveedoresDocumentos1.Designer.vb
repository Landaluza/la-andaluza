<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPedidosProveedoresDocumentos1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPedidosProveedoresDocumentos1))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPedidoProveedorMaestroID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblPedidoProveedorMaestroID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.lblPedidoProveedorDocumentoID = New System.Windows.Forms.Label()
        Me.txtPedidoProveedorDocumentoID = New BasesParaCompatibilidad.CuadroDeTexto()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(172, 30)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(751, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRuta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(172, 57)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(751, 21)
        Me.txtRuta.TabIndex = 2
        Me.txtRuta.ValorMaximo = 0.0R
        Me.txtRuta.ValorMinimo = 0.0R
        '
        'butRuta
        '
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(929, 57)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(24, 20)
        Me.butRuta.TabIndex = 3
        Me.butRuta.TabStop = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(172, 84)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 3
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
        Me.txtObservaciones.Location = New System.Drawing.Point(172, 111)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(751, 21)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtPedidoProveedorMaestroID
        '
        Me.txtPedidoProveedorMaestroID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorMaestroID.EsUnicoCampo = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorMaestroID.EsUnicoID = 0
        Me.txtPedidoProveedorMaestroID.EsUnicoTabla = ""
        Me.txtPedidoProveedorMaestroID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorMaestroID.Location = New System.Drawing.Point(172, 138)
        Me.txtPedidoProveedorMaestroID.MaxLength = 9
        Me.txtPedidoProveedorMaestroID.Minimo = 0
        Me.txtPedidoProveedorMaestroID.Modificado = False
        Me.txtPedidoProveedorMaestroID.Name = "txtPedidoProveedorMaestroID"
        Me.txtPedidoProveedorMaestroID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorMaestroID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorMaestroID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorMaestroID.Obligatorio = True
        Me.txtPedidoProveedorMaestroID.ParametroID = 0
        Me.txtPedidoProveedorMaestroID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoProveedorMaestroID.TabIndex = 5
        Me.txtPedidoProveedorMaestroID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorMaestroID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorMaestroID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorMaestroID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(3, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(163, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(3, 54)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(163, 21)
        Me.lblRuta.TabIndex = 2
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(3, 81)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(163, 21)
        Me.lblFecha.TabIndex = 5
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(3, 108)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(163, 21)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPedidoProveedorMaestroID
        '
        Me.lblPedidoProveedorMaestroID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoProveedorMaestroID.Location = New System.Drawing.Point(3, 135)
        Me.lblPedidoProveedorMaestroID.Name = "lblPedidoProveedorMaestroID"
        Me.lblPedidoProveedorMaestroID.Size = New System.Drawing.Size(163, 21)
        Me.lblPedidoProveedorMaestroID.TabIndex = 7
        Me.lblPedidoProveedorMaestroID.Text = "PedidoProveedorMaestroID"
        Me.lblPedidoProveedorMaestroID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorMaestroID.Visible = False
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorDocumentoID, 0, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorDocumentoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 0, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 0, 2)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 0, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 0, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.lblPedidoProveedorMaestroID, 0, 5)
        Me.tlpMiddle.Controls.Add(Me.txtPedidoProveedorMaestroID, 1, 5)
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
        Me.tlpMiddle.Size = New System.Drawing.Size(956, 162)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'lblPedidoProveedorDocumentoID
        '
        Me.lblPedidoProveedorDocumentoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPedidoProveedorDocumentoID.Location = New System.Drawing.Point(3, 0)
        Me.lblPedidoProveedorDocumentoID.Name = "lblPedidoProveedorDocumentoID"
        Me.lblPedidoProveedorDocumentoID.Size = New System.Drawing.Size(163, 21)
        Me.lblPedidoProveedorDocumentoID.TabIndex = 0
        Me.lblPedidoProveedorDocumentoID.Text = "PedidoProveedorDocumentoID"
        Me.lblPedidoProveedorDocumentoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPedidoProveedorDocumentoID.Visible = False
        '
        'txtPedidoProveedorDocumentoID
        '
        Me.txtPedidoProveedorDocumentoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPedidoProveedorDocumentoID.EsUnicoCampo = ""
        Me.txtPedidoProveedorDocumentoID.EsUnicoCampoID = ""
        Me.txtPedidoProveedorDocumentoID.EsUnicoID = 0
        Me.txtPedidoProveedorDocumentoID.EsUnicoTabla = ""
        Me.txtPedidoProveedorDocumentoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPedidoProveedorDocumentoID.Location = New System.Drawing.Point(172, 3)
        Me.txtPedidoProveedorDocumentoID.MaxLength = 9
        Me.txtPedidoProveedorDocumentoID.Minimo = 0
        Me.txtPedidoProveedorDocumentoID.Modificado = False
        Me.txtPedidoProveedorDocumentoID.Name = "txtPedidoProveedorDocumentoID"
        Me.txtPedidoProveedorDocumentoID.Numerico_EsNumerico = False
        Me.txtPedidoProveedorDocumentoID.Numerico_NumeroDoublees = 0
        Me.txtPedidoProveedorDocumentoID.Numerico_SeparadorMiles = False
        Me.txtPedidoProveedorDocumentoID.Obligatorio = True
        Me.txtPedidoProveedorDocumentoID.ParametroID = 0
        Me.txtPedidoProveedorDocumentoID.Size = New System.Drawing.Size(56, 21)
        Me.txtPedidoProveedorDocumentoID.TabIndex = 0
        Me.txtPedidoProveedorDocumentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPedidoProveedorDocumentoID.ValorMaximo = 0.0R
        Me.txtPedidoProveedorDocumentoID.ValorMinimo = 0.0R
        Me.txtPedidoProveedorDocumentoID.Visible = False
        '
        'frmEntPedidosProveedoresDocumentos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(965, 212)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(416, 244)
        Me.Name = "frmEntPedidosProveedoresDocumentos1"
        Me.Text = "PedidosProveedoresDocumentos1"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPedidoProveedorMaestroID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblPedidoProveedorMaestroID As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblPedidoProveedorDocumentoID As System.Windows.Forms.Label
    Private WithEvents txtPedidoProveedorDocumentoID As BasesParaCompatibilidad.CuadroDeTexto
End Class
