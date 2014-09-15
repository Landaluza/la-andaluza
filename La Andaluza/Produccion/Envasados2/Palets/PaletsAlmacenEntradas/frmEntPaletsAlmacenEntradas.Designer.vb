<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsAlmacenEntradas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsAlmacenEntradas))
        Me.txtPaletAlmacenEntradaID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtSSCC = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtArticulo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtComentariosCarga = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.lblPaletAlmacenEntradaID = New System.Windows.Forms.Label()
        Me.lblSSCC = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblArticulo = New System.Windows.Forms.Label()
        Me.lblCajas = New System.Windows.Forms.Label()
        Me.lblComentariosCarga = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'txtPaletAlmacenEntradaID
        '
        Me.txtPaletAlmacenEntradaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPaletAlmacenEntradaID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPaletAlmacenEntradaID.EsUnicoCampo = ""
        Me.txtPaletAlmacenEntradaID.EsUnicoCampoID = ""
        Me.txtPaletAlmacenEntradaID.EsUnicoID = 0
        Me.txtPaletAlmacenEntradaID.EsUnicoTabla = ""
        Me.txtPaletAlmacenEntradaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPaletAlmacenEntradaID.Location = New System.Drawing.Point(140, 2)
        Me.txtPaletAlmacenEntradaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPaletAlmacenEntradaID.MaxLength = 9
        Me.txtPaletAlmacenEntradaID.Minimo = 0
        Me.txtPaletAlmacenEntradaID.Modificado = False
        Me.txtPaletAlmacenEntradaID.Name = "txtPaletAlmacenEntradaID"
        Me.txtPaletAlmacenEntradaID.Numerico_EsNumerico = False
        Me.txtPaletAlmacenEntradaID.Numerico_NumeroDoublees = 0
        Me.txtPaletAlmacenEntradaID.Numerico_SeparadorMiles = False
        Me.txtPaletAlmacenEntradaID.Obligatorio = True
        Me.txtPaletAlmacenEntradaID.ParametroID = 0
        Me.txtPaletAlmacenEntradaID.Size = New System.Drawing.Size(51, 21)
        Me.txtPaletAlmacenEntradaID.TabIndex = 0
        Me.txtPaletAlmacenEntradaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPaletAlmacenEntradaID.ValorMaximo = 0.0R
        Me.txtPaletAlmacenEntradaID.ValorMinimo = 0.0R
        Me.txtPaletAlmacenEntradaID.Visible = False
        '
        'txtSSCC
        '
        Me.txtSSCC.BackColor = System.Drawing.SystemColors.Window
        Me.txtSSCC.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSSCC.EsUnicoCampo = ""
        Me.txtSSCC.EsUnicoCampoID = ""
        Me.txtSSCC.EsUnicoID = 0
        Me.txtSSCC.EsUnicoTabla = ""
        Me.txtSSCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSSCC.Location = New System.Drawing.Point(140, 27)
        Me.txtSSCC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtSSCC.MaxLength = 50
        Me.txtSSCC.Minimo = 0
        Me.txtSSCC.Modificado = False
        Me.txtSSCC.Name = "txtSSCC"
        Me.txtSSCC.Numerico_EsNumerico = False
        Me.txtSSCC.Numerico_NumeroDoublees = 0
        Me.txtSSCC.Numerico_SeparadorMiles = False
        Me.txtSSCC.Obligatorio = False
        Me.txtSSCC.ParametroID = 0
        Me.txtSSCC.Size = New System.Drawing.Size(181, 21)
        Me.txtSSCC.TabIndex = 1
        Me.txtSSCC.ValorMaximo = 0.0R
        Me.txtSSCC.ValorMinimo = 0.0R
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(140, 52)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 2
        '
        'txtArticulo
        '
        Me.txtArticulo.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtArticulo.EsUnicoCampo = ""
        Me.txtArticulo.EsUnicoCampoID = ""
        Me.txtArticulo.EsUnicoID = 0
        Me.txtArticulo.EsUnicoTabla = ""
        Me.txtArticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticulo.Location = New System.Drawing.Point(140, 77)
        Me.txtArticulo.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtArticulo.MaxLength = 150
        Me.txtArticulo.Minimo = 0
        Me.txtArticulo.Modificado = False
        Me.txtArticulo.Name = "txtArticulo"
        Me.txtArticulo.Numerico_EsNumerico = False
        Me.txtArticulo.Numerico_NumeroDoublees = 0
        Me.txtArticulo.Numerico_SeparadorMiles = False
        Me.txtArticulo.Obligatorio = False
        Me.txtArticulo.ParametroID = 0
        Me.txtArticulo.Size = New System.Drawing.Size(181, 21)
        Me.txtArticulo.TabIndex = 3
        Me.txtArticulo.ValorMaximo = 0.0R
        Me.txtArticulo.ValorMinimo = 0.0R
        '
        'txtCajas
        '
        Me.txtCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCajas.EsUnicoCampo = ""
        Me.txtCajas.EsUnicoCampoID = ""
        Me.txtCajas.EsUnicoID = 0
        Me.txtCajas.EsUnicoTabla = ""
        Me.txtCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajas.Location = New System.Drawing.Point(140, 102)
        Me.txtCajas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtCajas.MaxLength = 9
        Me.txtCajas.Minimo = 0
        Me.txtCajas.Modificado = False
        Me.txtCajas.Name = "txtCajas"
        Me.txtCajas.Numerico_EsNumerico = False
        Me.txtCajas.Numerico_NumeroDoublees = 0
        Me.txtCajas.Numerico_SeparadorMiles = False
        Me.txtCajas.Obligatorio = False
        Me.txtCajas.ParametroID = 0
        Me.txtCajas.Size = New System.Drawing.Size(51, 21)
        Me.txtCajas.TabIndex = 4
        Me.txtCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajas.ValorMaximo = 0.0R
        Me.txtCajas.ValorMinimo = 0.0R
        '
        'txtComentariosCarga
        '
        Me.txtComentariosCarga.BackColor = System.Drawing.SystemColors.Window
        Me.txtComentariosCarga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtComentariosCarga.EsUnicoCampo = ""
        Me.txtComentariosCarga.EsUnicoCampoID = ""
        Me.txtComentariosCarga.EsUnicoID = 0
        Me.txtComentariosCarga.EsUnicoTabla = ""
        Me.txtComentariosCarga.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtComentariosCarga.Location = New System.Drawing.Point(140, 127)
        Me.txtComentariosCarga.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtComentariosCarga.MaxLength = 300
        Me.txtComentariosCarga.Minimo = 0
        Me.txtComentariosCarga.Modificado = False
        Me.txtComentariosCarga.Name = "txtComentariosCarga"
        Me.txtComentariosCarga.Numerico_EsNumerico = False
        Me.txtComentariosCarga.Numerico_NumeroDoublees = 0
        Me.txtComentariosCarga.Numerico_SeparadorMiles = False
        Me.txtComentariosCarga.Obligatorio = False
        Me.txtComentariosCarga.ParametroID = 0
        Me.txtComentariosCarga.Size = New System.Drawing.Size(181, 21)
        Me.txtComentariosCarga.TabIndex = 5
        Me.txtComentariosCarga.ValorMaximo = 0.0R
        Me.txtComentariosCarga.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(140, 152)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 300
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(253, 21)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(140, 177)
        Me.chbVigente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(14, 20)
        Me.chbVigente.TabIndex = 7
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'lblPaletAlmacenEntradaID
        '
        Me.lblPaletAlmacenEntradaID.Location = New System.Drawing.Point(20, 0)
        Me.lblPaletAlmacenEntradaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblPaletAlmacenEntradaID.Name = "lblPaletAlmacenEntradaID"
        Me.lblPaletAlmacenEntradaID.Size = New System.Drawing.Size(116, 20)
        Me.lblPaletAlmacenEntradaID.TabIndex = 0
        Me.lblPaletAlmacenEntradaID.Text = "PaletAlmacenEntradaID"
        Me.lblPaletAlmacenEntradaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPaletAlmacenEntradaID.Visible = False
        '
        'lblSSCC
        '
        Me.lblSSCC.Location = New System.Drawing.Point(20, 25)
        Me.lblSSCC.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSSCC.Name = "lblSSCC"
        Me.lblSSCC.Size = New System.Drawing.Size(116, 20)
        Me.lblSSCC.TabIndex = 1
        Me.lblSSCC.Text = "SSCC"
        Me.lblSSCC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(20, 50)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(116, 20)
        Me.lblFecha.TabIndex = 2
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblArticulo
        '
        Me.lblArticulo.Location = New System.Drawing.Point(20, 75)
        Me.lblArticulo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblArticulo.Name = "lblArticulo"
        Me.lblArticulo.Size = New System.Drawing.Size(116, 20)
        Me.lblArticulo.TabIndex = 3
        Me.lblArticulo.Text = "Articulo"
        Me.lblArticulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCajas
        '
        Me.lblCajas.Location = New System.Drawing.Point(20, 100)
        Me.lblCajas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCajas.Name = "lblCajas"
        Me.lblCajas.Size = New System.Drawing.Size(116, 20)
        Me.lblCajas.TabIndex = 4
        Me.lblCajas.Text = "Cajas"
        Me.lblCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblComentariosCarga
        '
        Me.lblComentariosCarga.Location = New System.Drawing.Point(20, 125)
        Me.lblComentariosCarga.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblComentariosCarga.Name = "lblComentariosCarga"
        Me.lblComentariosCarga.Size = New System.Drawing.Size(116, 20)
        Me.lblComentariosCarga.TabIndex = 5
        Me.lblComentariosCarga.Text = "ComentariosCarga"
        Me.lblComentariosCarga.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 150)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(116, 20)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Location = New System.Drawing.Point(20, 175)
        Me.lblVigente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(116, 20)
        Me.lblVigente.TabIndex = 7
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.tlpMiddle.Controls.Add(Me.lblPaletAlmacenEntradaID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtPaletAlmacenEntradaID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblSSCC, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtSSCC, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblArticulo, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtArticulo, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblCajas, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtCajas, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblComentariosCarga, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtComentariosCarga, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblVigente, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.chbVigente, 2, 7)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 37)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 9
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(440, 202)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntPaletsAlmacenEntradas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(435, 255)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPaletsAlmacenEntradas"
        Me.Text = "PaletsAlmacenEntradas"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents lblSSCC As System.Windows.Forms.Label

    Private WithEvents txtPaletAlmacenEntradaID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSSCC As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtArticulo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtComentariosCarga As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbVigente As System.Windows.Forms.CheckBox
    Private WithEvents lblPaletAlmacenEntradaID As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblArticulo As System.Windows.Forms.Label
    Private WithEvents lblCajas As System.Windows.Forms.Label
    Private WithEvents lblComentariosCarga As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblVigente As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
