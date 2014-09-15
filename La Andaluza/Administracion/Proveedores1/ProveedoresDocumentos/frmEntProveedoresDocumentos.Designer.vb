<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProveedoresDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProveedoresDocumentos))
        Me.txtProveedorDocumentoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboProveedorID = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFuente = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblProveedorDocumentoID = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblFuente = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
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
        'txtProveedorDocumentoID
        '
        Me.txtProveedorDocumentoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedorDocumentoID.EsUnicoCampo = ""
        Me.txtProveedorDocumentoID.EsUnicoCampoID = ""
        Me.txtProveedorDocumentoID.EsUnicoID = 0
        Me.txtProveedorDocumentoID.EsUnicoTabla = ""
        Me.txtProveedorDocumentoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorDocumentoID.Location = New System.Drawing.Point(158, 3)
        Me.txtProveedorDocumentoID.MaxLength = 9
        Me.txtProveedorDocumentoID.Minimo = 0
        Me.txtProveedorDocumentoID.Modificado = False
        Me.txtProveedorDocumentoID.Name = "txtProveedorDocumentoID"
        Me.txtProveedorDocumentoID.Numerico_EsNumerico = False
        Me.txtProveedorDocumentoID.Numerico_NumeroDoublees = 0
        Me.txtProveedorDocumentoID.Numerico_SeparadorMiles = False
        Me.txtProveedorDocumentoID.Obligatorio = True
        Me.txtProveedorDocumentoID.ParametroID = 0
        Me.txtProveedorDocumentoID.Size = New System.Drawing.Size(56, 21)
        Me.txtProveedorDocumentoID.TabIndex = 0
        Me.txtProveedorDocumentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtProveedorDocumentoID.ValorMaximo = 0.0R
        Me.txtProveedorDocumentoID.ValorMinimo = 0.0R
        Me.txtProveedorDocumentoID.Visible = False
        '
        'cboProveedorID
        '
        Me.cboProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedorID.Location = New System.Drawing.Point(158, 30)
        Me.cboProveedorID.Name = "cboProveedorID"
        Me.cboProveedorID.Size = New System.Drawing.Size(395, 23)
        Me.cboProveedorID.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(158, 59)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(395, 14)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(158, 86)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 3
        '
        'txtFuente
        '
        Me.txtFuente.BackColor = System.Drawing.SystemColors.Window
        Me.txtFuente.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtFuente.EsUnicoCampo = ""
        Me.txtFuente.EsUnicoCampoID = ""
        Me.txtFuente.EsUnicoID = 0
        Me.txtFuente.EsUnicoTabla = ""
        Me.txtFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuente.Location = New System.Drawing.Point(158, 113)
        Me.txtFuente.MaxLength = 4000
        Me.txtFuente.Minimo = 0
        Me.txtFuente.Modificado = False
        Me.txtFuente.Name = "txtFuente"
        Me.txtFuente.Numerico_EsNumerico = False
        Me.txtFuente.Numerico_NumeroDoublees = 0
        Me.txtFuente.Numerico_SeparadorMiles = False
        Me.txtFuente.Obligatorio = False
        Me.txtFuente.ParametroID = 0
        Me.txtFuente.Size = New System.Drawing.Size(200, 14)
        Me.txtFuente.TabIndex = 4
        Me.txtFuente.ValorMaximo = 0.0R
        Me.txtFuente.ValorMinimo = 0.0R
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(158, 140)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(395, 14)
        Me.txtRuta.TabIndex = 5
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
        Me.butRuta.Location = New System.Drawing.Point(559, 140)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(27, 20)
        Me.butRuta.TabIndex = 6
        Me.butRuta.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(158, 167)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(395, 57)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblProveedorDocumentoID
        '
        Me.lblProveedorDocumentoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProveedorDocumentoID.Location = New System.Drawing.Point(25, 0)
        Me.lblProveedorDocumentoID.Name = "lblProveedorDocumentoID"
        Me.lblProveedorDocumentoID.Size = New System.Drawing.Size(127, 21)
        Me.lblProveedorDocumentoID.TabIndex = 0
        Me.lblProveedorDocumentoID.Text = "ProveedorDocumentoID"
        Me.lblProveedorDocumentoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProveedorDocumentoID.Visible = False
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProveedorID.Location = New System.Drawing.Point(25, 27)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(127, 21)
        Me.lblProveedorID.TabIndex = 1
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(25, 56)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(127, 21)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(25, 83)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(127, 21)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFuente
        '
        Me.lblFuente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFuente.Location = New System.Drawing.Point(25, 110)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(127, 21)
        Me.lblFuente.TabIndex = 4
        Me.lblFuente.Text = "Fuente"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(25, 137)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(127, 21)
        Me.lblRuta.TabIndex = 5
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(25, 164)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(127, 21)
        Me.lblObservaciones.TabIndex = 8
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
        Me.tlpMiddle.Controls.Add(Me.lblProveedorDocumentoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtProveedorDocumentoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblProveedorID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboProveedorID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFuente, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtFuente, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(10, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(590, 234)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        '
        'frmEntProveedoresDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(615, 323)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntProveedoresDocumentos"
        Me.Text = "ProveedoresDocumentos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtProveedorDocumentoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboProveedorID As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblProveedorDocumentoID As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblFuente As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents txtFuente As BasesParaCompatibilidad.CuadroDeTexto
End Class
