<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntPaletsContenidos2
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsContenidos2))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblCantidadCajas = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidadCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCompletando = New System.Windows.Forms.Label()
        Me.txtPartePaletContenido = New BasesParaCompatibilidad.CuadroDeTexto()

        Me.txtPaletContenidoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblScc = New System.Windows.Forms.Label()
        Me.cbScc = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboMonodosis = New System.Windows.Forms.ComboBox()
        Me.btnMonodosis = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.lnoconforme = New System.Windows.Forms.Label()
        Me.PanDoyPack = New System.Windows.Forms.Panel()
        Me.lDoypack = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(119, 43)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(83, 21)
        Me.dtpHoraInicio.TabIndex = 1
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(119, 70)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(83, 21)
        Me.dtpHoraFin.TabIndex = 2
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Location = New System.Drawing.Point(12, 43)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(90, 21)
        Me.lblHoraInicio.TabIndex = 1
        Me.lblHoraInicio.Text = "HoraInicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Location = New System.Drawing.Point(12, 70)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(90, 21)
        Me.lblHoraFin.TabIndex = 2
        Me.lblHoraFin.Text = "HoraFin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCantidadCajas
        '
        Me.lblCantidadCajas.Location = New System.Drawing.Point(299, 43)
        Me.lblCantidadCajas.Name = "lblCantidadCajas"
        Me.lblCantidadCajas.Size = New System.Drawing.Size(94, 21)
        Me.lblCantidadCajas.TabIndex = 3
        Me.lblCantidadCajas.Text = "CantidadCajas"
        Me.lblCantidadCajas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(119, 97)
        Me.txtObservaciones.MaxLength = 400
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(528, 52)
        Me.txtObservaciones.TabIndex = 6
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtCantidadCajas
        '
        Me.txtCantidadCajas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadCajas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCantidadCajas.EsUnicoCampo = ""
        Me.txtCantidadCajas.EsUnicoCampoID = ""
        Me.txtCantidadCajas.EsUnicoID = 0
        Me.txtCantidadCajas.EsUnicoTabla = ""
        Me.txtCantidadCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadCajas.Location = New System.Drawing.Point(399, 43)
        Me.txtCantidadCajas.MaxLength = 9
        Me.txtCantidadCajas.Minimo = 0
        Me.txtCantidadCajas.Modificado = False
        Me.txtCantidadCajas.Name = "txtCantidadCajas"
        Me.txtCantidadCajas.Numerico_EsNumerico = False
        Me.txtCantidadCajas.Numerico_NumeroDoublees = 0
        Me.txtCantidadCajas.Numerico_SeparadorMiles = False
        Me.txtCantidadCajas.Obligatorio = False
        Me.txtCantidadCajas.ParametroID = 0
        Me.txtCantidadCajas.Size = New System.Drawing.Size(66, 21)
        Me.txtCantidadCajas.TabIndex = 3
        Me.txtCantidadCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadCajas.ValorMaximo = 0.0R
        Me.txtCantidadCajas.ValorMinimo = 0.0R
        '
        'lblCompletando
        '
        Me.lblCompletando.AutoSize = True
        Me.lblCompletando.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCompletando.ForeColor = System.Drawing.Color.Red
        Me.lblCompletando.Location = New System.Drawing.Point(12, 166)
        Me.lblCompletando.Name = "lblCompletando"
        Me.lblCompletando.Size = New System.Drawing.Size(90, 15)
        Me.lblCompletando.TabIndex = 22
        Me.lblCompletando.Text = "Completando..."
        Me.lblCompletando.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCompletando.Visible = False
        '
        'txtPartePaletContenido
        '
        Me.txtPartePaletContenido.EsUnicoCampo = ""
        Me.txtPartePaletContenido.EsUnicoCampoID = ""
        Me.txtPartePaletContenido.EsUnicoID = 0
        Me.txtPartePaletContenido.EsUnicoTabla = ""
        Me.txtPartePaletContenido.Location = New System.Drawing.Point(357, 300)
        Me.txtPartePaletContenido.Minimo = 0
        Me.txtPartePaletContenido.Modificado = False
        Me.txtPartePaletContenido.Name = "txtPartePaletContenido"
        Me.txtPartePaletContenido.Numerico_EsNumerico = False
        Me.txtPartePaletContenido.Numerico_NumeroDoublees = 0
        Me.txtPartePaletContenido.Numerico_SeparadorMiles = False
        Me.txtPartePaletContenido.Obligatorio = False
        Me.txtPartePaletContenido.ParametroID = 0
        Me.txtPartePaletContenido.Size = New System.Drawing.Size(66, 20)
        Me.txtPartePaletContenido.TabIndex = 21
        Me.txtPartePaletContenido.TabStop = False
        Me.txtPartePaletContenido.ValorMaximo = 0.0R
        Me.txtPartePaletContenido.ValorMinimo = 0.0R
        Me.txtPartePaletContenido.Visible = False
        '
        'tlpTop
        '




        '
        'txtPaletContenidoID
        '
        Me.txtPaletContenidoID.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtPaletContenidoID.Enabled = False
        Me.txtPaletContenidoID.EsUnicoCampo = ""
        Me.txtPaletContenidoID.EsUnicoCampoID = ""
        Me.txtPaletContenidoID.EsUnicoID = 0
        Me.txtPaletContenidoID.EsUnicoTabla = ""
        Me.txtPaletContenidoID.Location = New System.Drawing.Point(140, 300)
        Me.txtPaletContenidoID.Minimo = 0
        Me.txtPaletContenidoID.Modificado = False
        Me.txtPaletContenidoID.Name = "txtPaletContenidoID"
        Me.txtPaletContenidoID.Numerico_EsNumerico = False
        Me.txtPaletContenidoID.Numerico_NumeroDoublees = 0
        Me.txtPaletContenidoID.Numerico_SeparadorMiles = False
        Me.txtPaletContenidoID.Obligatorio = False
        Me.txtPaletContenidoID.ParametroID = 0
        Me.txtPaletContenidoID.Size = New System.Drawing.Size(66, 20)
        Me.txtPaletContenidoID.TabIndex = 18
        Me.txtPaletContenidoID.TabStop = False
        Me.txtPaletContenidoID.ValorMaximo = 0.0R
        Me.txtPaletContenidoID.ValorMinimo = 0.0R
        Me.txtPaletContenidoID.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(181, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1000000002
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(247, 302)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(104, 13)
        Me.Label3.TabIndex = 1000000003
        Me.Label3.Text = "ParteContenidoPalet"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(30, 303)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 13)
        Me.Label4.TabIndex = 1000000004
        Me.Label4.Text = "ContenidoPaletID"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Visible = False
        '
        'lblScc
        '
        Me.lblScc.AutoSize = True
        Me.lblScc.Location = New System.Drawing.Point(12, 23)
        Me.lblScc.Name = "lblScc"
        Me.lblScc.Size = New System.Drawing.Size(28, 13)
        Me.lblScc.TabIndex = 1000000007
        Me.lblScc.Text = "SCC"
        Me.lblScc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblScc.Visible = False
        '
        'cbScc
        '
        Me.cbScc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbScc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbScc.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cbScc.FormattingEnabled = True
        Me.cbScc.Location = New System.Drawing.Point(119, 17)
        Me.cbScc.Name = "cbScc"
        Me.cbScc.Size = New System.Drawing.Size(83, 21)
        Me.cbScc.TabIndex = 1000000008
        Me.cbScc.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(299, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 1000000009
        Me.Label1.Text = "SCC Monodosis"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Visible = False
        '
        'cboMonodosis
        '
        Me.cboMonodosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMonodosis.FormattingEnabled = True
        Me.cboMonodosis.Location = New System.Drawing.Point(399, 70)
        Me.cboMonodosis.Name = "cboMonodosis"
        Me.cboMonodosis.Size = New System.Drawing.Size(118, 21)
        Me.cboMonodosis.TabIndex = 4
        Me.cboMonodosis.Visible = False
        '
        'btnMonodosis
        '
        Me.btnMonodosis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMonodosis.FlatAppearance.BorderSize = 0
        Me.btnMonodosis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMonodosis.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.btnMonodosis.Location = New System.Drawing.Point(516, 70)
        Me.btnMonodosis.Name = "btnMonodosis"
        Me.btnMonodosis.Size = New System.Drawing.Size(23, 21)
        Me.btnMonodosis.TabIndex = 11
        Me.btnMonodosis.UseVisualStyleBackColor = True
        Me.btnMonodosis.Visible = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(12, 91)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(90, 21)
        Me.lblObservaciones.TabIndex = 1000000010
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lnoconforme)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbScc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnMonodosis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPartePaletContenido)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCantidadCajas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblCompletando)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtPaletContenidoID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtCantidadCajas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtObservaciones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHoraInicio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboMonodosis)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblObservaciones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpHoraInicio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.dtpHoraFin)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblScc)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblHoraFin)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PanDoyPack)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lDoypack)
        Me.SplitContainer1.Panel2Collapsed = True
        Me.SplitContainer1.Size = New System.Drawing.Size(663, 214)
        Me.SplitContainer1.SplitterDistance = 859
        Me.SplitContainer1.TabIndex = 0
        '
        'lnoconforme
        '
        Me.lnoconforme.AutoSize = True
        Me.lnoconforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnoconforme.ForeColor = System.Drawing.Color.Red
        Me.lnoconforme.Location = New System.Drawing.Point(539, 74)
        Me.lnoconforme.Name = "lnoconforme"
        Me.lnoconforme.Size = New System.Drawing.Size(116, 16)
        Me.lnoconforme.TabIndex = 5
        Me.lnoconforme.Text = "Palet no conforme"
        Me.lnoconforme.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lnoconforme.Visible = False
        '
        'PanDoyPack
        '
        Me.PanDoyPack.AutoScroll = True
        Me.PanDoyPack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanDoyPack.Location = New System.Drawing.Point(0, 13)
        Me.PanDoyPack.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.PanDoyPack.Name = "PanDoyPack"
        Me.PanDoyPack.Size = New System.Drawing.Size(72, 68)
        Me.PanDoyPack.TabIndex = 1
        '
        'lDoypack
        '
        Me.lDoypack.AutoSize = True
        Me.lDoypack.Dock = System.Windows.Forms.DockStyle.Top
        Me.lDoypack.Location = New System.Drawing.Point(0, 0)
        Me.lDoypack.Name = "lDoypack"
        Me.lDoypack.Size = New System.Drawing.Size(50, 13)
        Me.lDoypack.TabIndex = 0
        Me.lDoypack.Text = "Doypack"
        '
        'frmEntPaletsContenidos2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.BackColor = System.Drawing.Color.LightGray
        Me.ClientSize = New System.Drawing.Size(663, 239)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPaletsContenidos2"
        Me.Text = "ContenidosPalets2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents ToolTip1 As System.Windows.Forms.ToolTip
   Private WithEvents lDoypack As System.Windows.Forms.Label
   Private WithEvents PanDoyPack As System.Windows.Forms.Panel
    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblCompletando As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents lblScc As System.Windows.Forms.Label
    Private WithEvents cbScc As System.Windows.Forms.ComboBox
    Private WithEvents lblCantidadCajas As System.Windows.Forms.Label
    Private WithEvents txtCantidadCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboMonodosis As System.Windows.Forms.ComboBox
    Private WithEvents btnMonodosis As System.Windows.Forms.Button
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents lnoconforme As System.Windows.Forms.Label
    Private WithEvents txtPartePaletContenido As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPaletContenidoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
