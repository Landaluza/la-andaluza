<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosTiposDocumentos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosTiposDocumentos))
        Me.txtArticuloTipoDocumentoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloTipoID = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtFuente = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloTipoDocumentoID = New System.Windows.Forms.Label()
        Me.lblArticuloTipoID = New System.Windows.Forms.Label()
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
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtArticuloTipoDocumentoID
        '
        Me.txtArticuloTipoDocumentoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloTipoDocumentoID.EsUnicoCampo = ""
        Me.txtArticuloTipoDocumentoID.EsUnicoCampoID = ""
        Me.txtArticuloTipoDocumentoID.EsUnicoID = 0
        Me.txtArticuloTipoDocumentoID.EsUnicoTabla = ""
        Me.txtArticuloTipoDocumentoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloTipoDocumentoID.Location = New System.Drawing.Point(201, 4)
        Me.txtArticuloTipoDocumentoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArticuloTipoDocumentoID.MaxLength = 9
        Me.txtArticuloTipoDocumentoID.Minimo = 0
        Me.txtArticuloTipoDocumentoID.Modificado = False
        Me.txtArticuloTipoDocumentoID.Name = "txtArticuloTipoDocumentoID"
        Me.txtArticuloTipoDocumentoID.Numerico_EsNumerico = False
        Me.txtArticuloTipoDocumentoID.Numerico_NumeroDoublees = 0
        Me.txtArticuloTipoDocumentoID.Numerico_SeparadorMiles = False
        Me.txtArticuloTipoDocumentoID.Obligatorio = True
        Me.txtArticuloTipoDocumentoID.ParametroID = 0
        Me.txtArticuloTipoDocumentoID.Size = New System.Drawing.Size(73, 24)
        Me.txtArticuloTipoDocumentoID.TabIndex = 0
        Me.txtArticuloTipoDocumentoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloTipoDocumentoID.ValorMaximo = 0.0!
        Me.txtArticuloTipoDocumentoID.ValorMinimo = 0.0!
        Me.txtArticuloTipoDocumentoID.Visible = False
        '
        'cboArticuloTipoID
        '
        Me.cboArticuloTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloTipoID.Location = New System.Drawing.Point(201, 36)
        Me.cboArticuloTipoID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloTipoID.Name = "cboArticuloTipoID"
        Me.cboArticuloTipoID.Size = New System.Drawing.Size(265, 26)
        Me.cboArticuloTipoID.TabIndex = 1
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(201, 70)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 250
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(973, 24)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(201, 102)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(125, 24)
        Me.dtpFecha.TabIndex = 3
        '
        'txtFuente
        '
        Me.txtFuente.BackColor = System.Drawing.SystemColors.Window
        Me.txtFuente.EsUnicoCampo = ""
        Me.txtFuente.EsUnicoCampoID = ""
        Me.txtFuente.EsUnicoID = 0
        Me.txtFuente.EsUnicoTabla = ""
        Me.txtFuente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFuente.Location = New System.Drawing.Point(201, 134)
        Me.txtFuente.Margin = New System.Windows.Forms.Padding(4)
        Me.txtFuente.MaxLength = 100
        Me.txtFuente.Minimo = 0
        Me.txtFuente.Modificado = False
        Me.txtFuente.Name = "txtFuente"
        Me.txtFuente.Numerico_EsNumerico = False
        Me.txtFuente.Numerico_NumeroDoublees = 0
        Me.txtFuente.Numerico_SeparadorMiles = False
        Me.txtFuente.Obligatorio = False
        Me.txtFuente.ParametroID = 0
        Me.txtFuente.Size = New System.Drawing.Size(307, 24)
        Me.txtFuente.TabIndex = 4
        Me.txtFuente.ValorMaximo = 0.0!
        Me.txtFuente.ValorMinimo = 0.0!
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRuta.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(201, 166)
        Me.txtRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRuta.MaxLength = 250
        Me.txtRuta.Minimo = 0
        Me.txtRuta.Modificado = False
        Me.txtRuta.Name = "txtRuta"
        Me.txtRuta.Numerico_EsNumerico = False
        Me.txtRuta.Numerico_NumeroDoublees = 0
        Me.txtRuta.Numerico_SeparadorMiles = False
        Me.txtRuta.Obligatorio = False
        Me.txtRuta.ParametroID = 0
        Me.txtRuta.Size = New System.Drawing.Size(973, 24)
        Me.txtRuta.TabIndex = 5
        Me.txtRuta.ValorMaximo = 0.0!
        Me.txtRuta.ValorMinimo = 0.0!
        '
        'butRuta
        '
        Me.butRuta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRuta.FlatAppearance.BorderSize = 0
        Me.butRuta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRuta.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRuta.Location = New System.Drawing.Point(1182, 166)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(27, 25)
        Me.butRuta.TabIndex = 6
        Me.butRuta.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(201, 199)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(973, 24)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblArticuloTipoDocumentoID
        '
        Me.lblArticuloTipoDocumentoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloTipoDocumentoID.Location = New System.Drawing.Point(14, 0)
        Me.lblArticuloTipoDocumentoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloTipoDocumentoID.Name = "lblArticuloTipoDocumentoID"
        Me.lblArticuloTipoDocumentoID.Size = New System.Drawing.Size(179, 26)
        Me.lblArticuloTipoDocumentoID.TabIndex = 0
        Me.lblArticuloTipoDocumentoID.Text = "ArticuloTipoDocumentoID"
        Me.lblArticuloTipoDocumentoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloTipoDocumentoID.Visible = False
        '
        'lblArticuloTipoID
        '
        Me.lblArticuloTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloTipoID.Location = New System.Drawing.Point(14, 32)
        Me.lblArticuloTipoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloTipoID.Name = "lblArticuloTipoID"
        Me.lblArticuloTipoID.Size = New System.Drawing.Size(179, 26)
        Me.lblArticuloTipoID.TabIndex = 1
        Me.lblArticuloTipoID.Text = "ArticuloTipo"
        Me.lblArticuloTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(14, 66)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(179, 26)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFecha.Location = New System.Drawing.Point(14, 98)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(179, 26)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFuente
        '
        Me.lblFuente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFuente.Location = New System.Drawing.Point(14, 130)
        Me.lblFuente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFuente.Name = "lblFuente"
        Me.lblFuente.Size = New System.Drawing.Size(179, 26)
        Me.lblFuente.TabIndex = 4
        Me.lblFuente.Text = "Fuente"
        Me.lblFuente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(14, 162)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(179, 26)
        Me.lblRuta.TabIndex = 5
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(14, 195)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(179, 26)
        Me.lblObservaciones.TabIndex = 8
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 6
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.081081!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.91892!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.tlpMiddle.Controls.Add(Me.lblArticuloTipoDocumentoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtArticuloTipoDocumentoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloTipoID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloTipoID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFuente, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtFuente, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 8
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1267, 235)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntArticulosTiposDocumentos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1267, 304)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(510, 327)
        Me.Name = "frmEntArticulosTiposDocumentos"
        Me.Text = "ArticulosTiposDocumentos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtArticuloTipoDocumentoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloTipoID As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtFuente As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloTipoDocumentoID As System.Windows.Forms.Label
    Private WithEvents lblArticuloTipoID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblFuente As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
