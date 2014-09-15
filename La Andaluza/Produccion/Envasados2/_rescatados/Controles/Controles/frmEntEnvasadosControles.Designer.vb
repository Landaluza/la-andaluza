<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEnvasadosControles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEnvasadosControles))
        Me.txtEnvasadoControlID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboResponsableID = New System.Windows.Forms.ComboBox()
        Me.txtFormatoEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.chbLoteadoEnvase = New System.Windows.Forms.CheckBox()
        Me.chbLoteadoCaja = New System.Windows.Forms.CheckBox()
        Me.chbEtiquetaPalet = New System.Windows.Forms.CheckBox()
        Me.chbMosaico = New System.Windows.Forms.CheckBox()
        Me.chbPaletizado = New System.Windows.Forms.CheckBox()
        Me.chbTodoCorrecto = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblEnvasadoControlID = New System.Windows.Forms.Label()
        Me.lblResponsableID = New System.Windows.Forms.Label()
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.lblLoteadoEnvase = New System.Windows.Forms.Label()
        Me.lblLoteadoCaja = New System.Windows.Forms.Label()
        Me.lblEtiquetaPalet = New System.Windows.Forms.Label()
        Me.lblMosaico = New System.Windows.Forms.Label()
        Me.lblPaletizado = New System.Windows.Forms.Label()
        Me.lblTodoCorrecto = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        Me.panDatos = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'txtEnvasadoControlID
        '
        Me.txtEnvasadoControlID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoControlID.EsUnicoCampo = ""
        Me.txtEnvasadoControlID.EsUnicoCampoID = ""
        Me.txtEnvasadoControlID.EsUnicoID = 0
        Me.txtEnvasadoControlID.EsUnicoTabla = ""
        Me.txtEnvasadoControlID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvasadoControlID.Location = New System.Drawing.Point(178, 4)
        Me.txtEnvasadoControlID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtEnvasadoControlID.MaxLength = 9
        Me.txtEnvasadoControlID.Minimo = 0
        Me.txtEnvasadoControlID.Modificado = False
        Me.txtEnvasadoControlID.Name = "txtEnvasadoControlID"
        Me.txtEnvasadoControlID.Numerico_EsNumerico = False
        Me.txtEnvasadoControlID.Numerico_NumeroDoublees = 0
        Me.txtEnvasadoControlID.Numerico_SeparadorMiles = False
        Me.txtEnvasadoControlID.Obligatorio = True
        Me.txtEnvasadoControlID.ParametroID = 0
        Me.txtEnvasadoControlID.Size = New System.Drawing.Size(73, 24)
        Me.txtEnvasadoControlID.TabIndex = 0
        Me.txtEnvasadoControlID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEnvasadoControlID.ValorMaximo = 0.0!
        Me.txtEnvasadoControlID.ValorMinimo = 0.0!
        Me.txtEnvasadoControlID.Visible = False
        '
        'cboResponsableID
        '
        Me.cboResponsableID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboResponsableID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsableID.Location = New System.Drawing.Point(178, 36)
        Me.cboResponsableID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboResponsableID.Name = "cboResponsableID"
        Me.cboResponsableID.Size = New System.Drawing.Size(433, 26)
        Me.cboResponsableID.TabIndex = 1
        '
        'txtFormatoEnvasadoID
        '
        Me.txtFormatoEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtFormatoEnvasadoID.EsUnicoCampo = ""
        Me.txtFormatoEnvasadoID.EsUnicoCampoID = ""
        Me.txtFormatoEnvasadoID.EsUnicoID = 0
        Me.txtFormatoEnvasadoID.EsUnicoTabla = ""
        Me.txtFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormatoEnvasadoID.Location = New System.Drawing.Point(178, 70)
        Me.txtFormatoEnvasadoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtFormatoEnvasadoID.MaxLength = 9
        Me.txtFormatoEnvasadoID.Minimo = 0
        Me.txtFormatoEnvasadoID.Modificado = False
        Me.txtFormatoEnvasadoID.Name = "txtFormatoEnvasadoID"
        Me.txtFormatoEnvasadoID.Numerico_EsNumerico = False
        Me.txtFormatoEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtFormatoEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtFormatoEnvasadoID.Obligatorio = False
        Me.txtFormatoEnvasadoID.ParametroID = 0
        Me.txtFormatoEnvasadoID.Size = New System.Drawing.Size(73, 24)
        Me.txtFormatoEnvasadoID.TabIndex = 2
        Me.txtFormatoEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFormatoEnvasadoID.ValorMaximo = 0.0!
        Me.txtFormatoEnvasadoID.ValorMinimo = 0.0!
        Me.txtFormatoEnvasadoID.Visible = False
        '
        'dtpHora
        '
        Me.dtpHora.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(178, 102)
        Me.dtpHora.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(73, 24)
        Me.dtpHora.TabIndex = 3
        '
        'chbLoteadoEnvase
        '
        Me.chbLoteadoEnvase.BackColor = System.Drawing.SystemColors.Control
        Me.chbLoteadoEnvase.Checked = True
        Me.chbLoteadoEnvase.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbLoteadoEnvase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLoteadoEnvase.Location = New System.Drawing.Point(178, 134)
        Me.chbLoteadoEnvase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbLoteadoEnvase.Name = "chbLoteadoEnvase"
        Me.chbLoteadoEnvase.Size = New System.Drawing.Size(21, 26)
        Me.chbLoteadoEnvase.TabIndex = 4
        Me.chbLoteadoEnvase.UseVisualStyleBackColor = False
        '
        'chbLoteadoCaja
        '
        Me.chbLoteadoCaja.BackColor = System.Drawing.SystemColors.Control
        Me.chbLoteadoCaja.Checked = True
        Me.chbLoteadoCaja.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbLoteadoCaja.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLoteadoCaja.Location = New System.Drawing.Point(178, 168)
        Me.chbLoteadoCaja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbLoteadoCaja.Name = "chbLoteadoCaja"
        Me.chbLoteadoCaja.Size = New System.Drawing.Size(21, 26)
        Me.chbLoteadoCaja.TabIndex = 5
        Me.chbLoteadoCaja.UseVisualStyleBackColor = False
        '
        'chbEtiquetaPalet
        '
        Me.chbEtiquetaPalet.BackColor = System.Drawing.SystemColors.Control
        Me.chbEtiquetaPalet.Checked = True
        Me.chbEtiquetaPalet.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbEtiquetaPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEtiquetaPalet.Location = New System.Drawing.Point(178, 202)
        Me.chbEtiquetaPalet.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbEtiquetaPalet.Name = "chbEtiquetaPalet"
        Me.chbEtiquetaPalet.Size = New System.Drawing.Size(21, 26)
        Me.chbEtiquetaPalet.TabIndex = 6
        Me.chbEtiquetaPalet.UseVisualStyleBackColor = False
        '
        'chbMosaico
        '
        Me.chbMosaico.BackColor = System.Drawing.SystemColors.Control
        Me.chbMosaico.Checked = True
        Me.chbMosaico.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbMosaico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMosaico.Location = New System.Drawing.Point(178, 236)
        Me.chbMosaico.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbMosaico.Name = "chbMosaico"
        Me.chbMosaico.Size = New System.Drawing.Size(21, 26)
        Me.chbMosaico.TabIndex = 7
        Me.chbMosaico.UseVisualStyleBackColor = False
        '
        'chbPaletizado
        '
        Me.chbPaletizado.BackColor = System.Drawing.SystemColors.Control
        Me.chbPaletizado.Checked = True
        Me.chbPaletizado.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbPaletizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbPaletizado.Location = New System.Drawing.Point(178, 270)
        Me.chbPaletizado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbPaletizado.Name = "chbPaletizado"
        Me.chbPaletizado.Size = New System.Drawing.Size(21, 26)
        Me.chbPaletizado.TabIndex = 8
        Me.chbPaletizado.UseVisualStyleBackColor = False
        '
        'chbTodoCorrecto
        '
        Me.chbTodoCorrecto.BackColor = System.Drawing.SystemColors.Control
        Me.chbTodoCorrecto.Checked = True
        Me.chbTodoCorrecto.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbTodoCorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTodoCorrecto.Location = New System.Drawing.Point(178, 304)
        Me.chbTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbTodoCorrecto.Name = "chbTodoCorrecto"
        Me.chbTodoCorrecto.Size = New System.Drawing.Size(21, 26)
        Me.chbTodoCorrecto.TabIndex = 9
        Me.chbTodoCorrecto.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(178, 338)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(433, 24)
        Me.txtObservaciones.TabIndex = 10
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblEnvasadoControlID
        '
        Me.lblEnvasadoControlID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEnvasadoControlID.Location = New System.Drawing.Point(25, 0)
        Me.lblEnvasadoControlID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEnvasadoControlID.Name = "lblEnvasadoControlID"
        Me.lblEnvasadoControlID.Size = New System.Drawing.Size(145, 26)
        Me.lblEnvasadoControlID.TabIndex = 0
        Me.lblEnvasadoControlID.Text = "EnvasadoControlID"
        Me.lblEnvasadoControlID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEnvasadoControlID.Visible = False
        '
        'lblResponsableID
        '
        Me.lblResponsableID.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblResponsableID.Location = New System.Drawing.Point(25, 32)
        Me.lblResponsableID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblResponsableID.Name = "lblResponsableID"
        Me.lblResponsableID.Size = New System.Drawing.Size(145, 34)
        Me.lblResponsableID.TabIndex = 1
        Me.lblResponsableID.Text = "Verificador"
        Me.lblResponsableID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(25, 66)
        Me.lblFormatoEnvasadoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(145, 26)
        Me.lblFormatoEnvasadoID.TabIndex = 4
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Visible = False
        '
        'lblHora
        '
        Me.lblHora.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHora.Location = New System.Drawing.Point(25, 98)
        Me.lblHora.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(145, 26)
        Me.lblHora.TabIndex = 5
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLoteadoEnvase
        '
        Me.lblLoteadoEnvase.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLoteadoEnvase.Location = New System.Drawing.Point(25, 130)
        Me.lblLoteadoEnvase.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoteadoEnvase.Name = "lblLoteadoEnvase"
        Me.lblLoteadoEnvase.Size = New System.Drawing.Size(145, 26)
        Me.lblLoteadoEnvase.TabIndex = 6
        Me.lblLoteadoEnvase.Text = "Loteado envase"
        Me.lblLoteadoEnvase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLoteadoCaja
        '
        Me.lblLoteadoCaja.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLoteadoCaja.Location = New System.Drawing.Point(25, 164)
        Me.lblLoteadoCaja.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLoteadoCaja.Name = "lblLoteadoCaja"
        Me.lblLoteadoCaja.Size = New System.Drawing.Size(145, 26)
        Me.lblLoteadoCaja.TabIndex = 7
        Me.lblLoteadoCaja.Text = "Loteado caja"
        Me.lblLoteadoCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEtiquetaPalet
        '
        Me.lblEtiquetaPalet.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEtiquetaPalet.Location = New System.Drawing.Point(25, 198)
        Me.lblEtiquetaPalet.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblEtiquetaPalet.Name = "lblEtiquetaPalet"
        Me.lblEtiquetaPalet.Size = New System.Drawing.Size(145, 26)
        Me.lblEtiquetaPalet.TabIndex = 8
        Me.lblEtiquetaPalet.Text = "Etiqueta palet"
        Me.lblEtiquetaPalet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMosaico
        '
        Me.lblMosaico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMosaico.Location = New System.Drawing.Point(25, 232)
        Me.lblMosaico.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMosaico.Name = "lblMosaico"
        Me.lblMosaico.Size = New System.Drawing.Size(145, 26)
        Me.lblMosaico.TabIndex = 9
        Me.lblMosaico.Text = "Mosaico"
        Me.lblMosaico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPaletizado
        '
        Me.lblPaletizado.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblPaletizado.Location = New System.Drawing.Point(25, 266)
        Me.lblPaletizado.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblPaletizado.Name = "lblPaletizado"
        Me.lblPaletizado.Size = New System.Drawing.Size(145, 26)
        Me.lblPaletizado.TabIndex = 10
        Me.lblPaletizado.Text = "Paletizado"
        Me.lblPaletizado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTodoCorrecto
        '
        Me.lblTodoCorrecto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTodoCorrecto.Location = New System.Drawing.Point(25, 300)
        Me.lblTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTodoCorrecto.Name = "lblTodoCorrecto"
        Me.lblTodoCorrecto.Size = New System.Drawing.Size(145, 26)
        Me.lblTodoCorrecto.TabIndex = 11
        Me.lblTodoCorrecto.Text = "Todo correcto"
        Me.lblTodoCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(25, 334)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(145, 26)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 21.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
        Me.tlpMiddle.Controls.Add(Me.lblEnvasadoControlID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtEnvasadoControlID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFormatoEnvasadoID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtFormatoEnvasadoID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblHora, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.dtpHora, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblLoteadoEnvase, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbLoteadoEnvase, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblLoteadoCaja, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.chbLoteadoCaja, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblEtiquetaPalet, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.chbEtiquetaPalet, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblMosaico, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.chbMosaico, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblPaletizado, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.chbPaletizado, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lblTodoCorrecto, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.chbTodoCorrecto, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.lblResponsableID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboResponsableID, 2, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 49)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 12
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(645, 368)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'panDatos
        '
        Me.panDatos.Location = New System.Drawing.Point(653, 49)
        Me.panDatos.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panDatos.Name = "panDatos"
        Me.panDatos.Size = New System.Drawing.Size(980, 658)
        Me.panDatos.TabIndex = 1000000002
        '
        'frmEntEnvasadosControles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1649, 726)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.panDatos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntEnvasadosControles"
        Me.Text = "EnvasadosControles"
        Me.Controls.SetChildIndex(Me.panDatos, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtEnvasadoControlID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboResponsableID As System.Windows.Forms.ComboBox
    Private WithEvents txtFormatoEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Private WithEvents chbLoteadoEnvase As System.Windows.Forms.CheckBox
    Private WithEvents chbLoteadoCaja As System.Windows.Forms.CheckBox
    Private WithEvents chbEtiquetaPalet As System.Windows.Forms.CheckBox
    Private WithEvents chbMosaico As System.Windows.Forms.CheckBox
    Private WithEvents chbPaletizado As System.Windows.Forms.CheckBox
    Private WithEvents chbTodoCorrecto As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblEnvasadoControlID As System.Windows.Forms.Label
   Private WithEvents lblResponsableID As System.Windows.Forms.Label
   Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
   Private WithEvents lblHora As System.Windows.Forms.Label
   Private WithEvents lblLoteadoEnvase As System.Windows.Forms.Label
   Private WithEvents lblLoteadoCaja As System.Windows.Forms.Label
   Private WithEvents lblEtiquetaPalet As System.Windows.Forms.Label
   Private WithEvents lblMosaico As System.Windows.Forms.Label
   Private WithEvents lblPaletizado As System.Windows.Forms.Label
   Private WithEvents lblTodoCorrecto As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

   Private WithEvents panDatos As System.Windows.Forms.Panel
End Class
