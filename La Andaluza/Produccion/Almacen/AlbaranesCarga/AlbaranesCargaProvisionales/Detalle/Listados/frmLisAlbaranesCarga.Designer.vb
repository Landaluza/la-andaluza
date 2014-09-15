<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLisAlbaranesCarga
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.lblBotellas = New System.Windows.Forms.Label()
        Me.lblTotalCajas = New System.Windows.Forms.Label()
        Me.txtTotalLitros = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalBotellas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtTotalCajas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.btnExcel = New System.Windows.Forms.Button()
        Me.btnImprimir = New System.Windows.Forms.Button()
        Me.dtpDesde = New System.Windows.Forms.DateTimePicker()
        Me.btnPorDias = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvEnvasados = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dtpHasta = New System.Windows.Forms.DateTimePicker()
        Me.cboReferencia = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cboLugaresEntrega = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cboClientes = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnDesglose = New System.Windows.Forms.Button()
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(215, 31)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(77, 16)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "TOTALES"
        '
        'lblLitros
        '
        Me.lblLitros.AutoSize = True
        Me.lblLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLitros.Location = New System.Drawing.Point(468, 12)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(38, 13)
        Me.lblLitros.TabIndex = 39
        Me.lblLitros.Text = "Litros"
        '
        'lblBotellas
        '
        Me.lblBotellas.AutoSize = True
        Me.lblBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBotellas.Location = New System.Drawing.Point(387, 12)
        Me.lblBotellas.Name = "lblBotellas"
        Me.lblBotellas.Size = New System.Drawing.Size(52, 13)
        Me.lblBotellas.TabIndex = 38
        Me.lblBotellas.Text = "Botellas"
        '
        'lblTotalCajas
        '
        Me.lblTotalCajas.AutoSize = True
        Me.lblTotalCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCajas.Location = New System.Drawing.Point(314, 12)
        Me.lblTotalCajas.Name = "lblTotalCajas"
        Me.lblTotalCajas.Size = New System.Drawing.Size(38, 13)
        Me.lblTotalCajas.TabIndex = 37
        Me.lblTotalCajas.Text = "Cajas"
        '
        'txtTotalLitros
        '
        Me.txtTotalLitros.EsUnicoCampo = ""
        Me.txtTotalLitros.EsUnicoCampoID = ""
        Me.txtTotalLitros.EsUnicoID = 0
        Me.txtTotalLitros.EsUnicoTabla = ""
        Me.txtTotalLitros.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalLitros.Location = New System.Drawing.Point(448, 28)
        Me.txtTotalLitros.MaxLength = 30
        Me.txtTotalLitros.Minimo = 0
        Me.txtTotalLitros.Modificado = False
        Me.txtTotalLitros.Name = "txtTotalLitros"
        Me.txtTotalLitros.Numerico_EsNumerico = True
        Me.txtTotalLitros.Numerico_NumeroDoublees = 0
        Me.txtTotalLitros.Numerico_SeparadorMiles = True
        Me.txtTotalLitros.Obligatorio = False
        Me.txtTotalLitros.ParametroID = 0
        Me.txtTotalLitros.Size = New System.Drawing.Size(69, 22)
        Me.txtTotalLitros.TabIndex = 36
        Me.txtTotalLitros.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalLitros.ValorMaximo = 0.0R
        Me.txtTotalLitros.ValorMinimo = 0.0R
        '
        'txtTotalBotellas
        '
        Me.txtTotalBotellas.EsUnicoCampo = ""
        Me.txtTotalBotellas.EsUnicoCampoID = ""
        Me.txtTotalBotellas.EsUnicoID = 0
        Me.txtTotalBotellas.EsUnicoTabla = ""
        Me.txtTotalBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalBotellas.Location = New System.Drawing.Point(373, 28)
        Me.txtTotalBotellas.MaxLength = 30
        Me.txtTotalBotellas.Minimo = 0
        Me.txtTotalBotellas.Modificado = False
        Me.txtTotalBotellas.Name = "txtTotalBotellas"
        Me.txtTotalBotellas.Numerico_EsNumerico = True
        Me.txtTotalBotellas.Numerico_NumeroDoublees = 0
        Me.txtTotalBotellas.Numerico_SeparadorMiles = True
        Me.txtTotalBotellas.Obligatorio = False
        Me.txtTotalBotellas.ParametroID = 0
        Me.txtTotalBotellas.Size = New System.Drawing.Size(69, 22)
        Me.txtTotalBotellas.TabIndex = 35
        Me.txtTotalBotellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalBotellas.ValorMaximo = 0.0R
        Me.txtTotalBotellas.ValorMinimo = 0.0R
        '
        'txtTotalCajas
        '
        Me.txtTotalCajas.EsUnicoCampo = ""
        Me.txtTotalCajas.EsUnicoCampoID = ""
        Me.txtTotalCajas.EsUnicoID = 0
        Me.txtTotalCajas.EsUnicoTabla = ""
        Me.txtTotalCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTotalCajas.Location = New System.Drawing.Point(298, 28)
        Me.txtTotalCajas.MaxLength = 30
        Me.txtTotalCajas.Minimo = 0
        Me.txtTotalCajas.Modificado = False
        Me.txtTotalCajas.Name = "txtTotalCajas"
        Me.txtTotalCajas.Numerico_EsNumerico = True
        Me.txtTotalCajas.Numerico_NumeroDoublees = 0
        Me.txtTotalCajas.Numerico_SeparadorMiles = True
        Me.txtTotalCajas.Obligatorio = False
        Me.txtTotalCajas.ParametroID = 0
        Me.txtTotalCajas.Size = New System.Drawing.Size(69, 22)
        Me.txtTotalCajas.TabIndex = 34
        Me.txtTotalCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalCajas.ValorMaximo = 0.0R
        Me.txtTotalCajas.ValorMinimo = 0.0R
        '
        'btnExcel
        '
        Me.btnExcel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnExcel.FlatAppearance.BorderSize = 0
        Me.btnExcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExcel.Image = Global.La_Andaluza.My.Resources.Resources.page_excel_16
        Me.btnExcel.Location = New System.Drawing.Point(417, 15)
        Me.btnExcel.Name = "btnExcel"
        Me.btnExcel.Size = New System.Drawing.Size(24, 20)
        Me.btnExcel.TabIndex = 33
        Me.btnExcel.UseVisualStyleBackColor = True
        '
        'btnImprimir
        '
        Me.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnImprimir.FlatAppearance.BorderSize = 0
        Me.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnImprimir.Image = Global.La_Andaluza.My.Resources.Resources.document_print_16
        Me.btnImprimir.Location = New System.Drawing.Point(387, 15)
        Me.btnImprimir.Name = "btnImprimir"
        Me.btnImprimir.Size = New System.Drawing.Size(24, 20)
        Me.btnImprimir.TabIndex = 32
        Me.btnImprimir.UseVisualStyleBackColor = True
        '
        'dtpDesde
        '
        Me.dtpDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDesde.Location = New System.Drawing.Point(58, 40)
        Me.dtpDesde.Name = "dtpDesde"
        Me.dtpDesde.Size = New System.Drawing.Size(87, 20)
        Me.dtpDesde.TabIndex = 23
        Me.dtpDesde.Value = New Date(2010, 1, 1, 0, 0, 0, 0)
        '
        'btnPorDias
        '
        Me.btnPorDias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPorDias.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnPorDias.Location = New System.Drawing.Point(14, 64)
        Me.btnPorDias.Name = "btnPorDias"
        Me.btnPorDias.Size = New System.Drawing.Size(135, 23)
        Me.btnPorDias.TabIndex = 29
        Me.btnPorDias.Text = "Por dias"
        Me.btnPorDias.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnPorDias.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(156, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Hasta:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Referencia"
        '
        'dgvEnvasados
        '
        Me.dgvEnvasados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEnvasados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvEnvasados.Location = New System.Drawing.Point(0, 94)
        Me.dgvEnvasados.Name = "dgvEnvasados"
        Me.dgvEnvasados.RowTemplate.Height = 16
        Me.dgvEnvasados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEnvasados.Size = New System.Drawing.Size(916, 671)
        Me.dgvEnvasados.TabIndex = 25
        Me.dgvEnvasados.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "Desde:"
        '
        'dtpHasta
        '
        Me.dtpHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpHasta.Location = New System.Drawing.Point(200, 40)
        Me.dtpHasta.Name = "dtpHasta"
        Me.dtpHasta.Size = New System.Drawing.Size(87, 20)
        Me.dtpHasta.TabIndex = 24
        '
        'cboReferencia
        '
        Me.cboReferencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReferencia.FormattingEnabled = True
        Me.cboReferencia.Location = New System.Drawing.Point(76, 15)
        Me.cboReferencia.Name = "cboReferencia"
        Me.cboReferencia.Size = New System.Drawing.Size(305, 21)
        Me.cboReferencia.TabIndex = 22
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtTotalCajas)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.txtTotalBotellas)
        Me.Panel1.Controls.Add(Me.lblLitros)
        Me.Panel1.Controls.Add(Me.txtTotalLitros)
        Me.Panel1.Controls.Add(Me.lblBotellas)
        Me.Panel1.Controls.Add(Me.lblTotalCajas)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 765)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(916, 59)
        Me.Panel1.TabIndex = 42
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.cboLugaresEntrega)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.cboClientes)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.btnDesglose)
        Me.Panel2.Controls.Add(Me.cboReferencia)
        Me.Panel2.Controls.Add(Me.dtpHasta)
        Me.Panel2.Controls.Add(Me.btnExcel)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.btnImprimir)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.dtpDesde)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.btnPorDias)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(916, 94)
        Me.Panel2.TabIndex = 43
        '
        'cboLugaresEntrega
        '
        Me.cboLugaresEntrega.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLugaresEntrega.FormattingEnabled = True
        Me.cboLugaresEntrega.Location = New System.Drawing.Point(598, 36)
        Me.cboLugaresEntrega.Name = "cboLugaresEntrega"
        Me.cboLugaresEntrega.Size = New System.Drawing.Size(291, 21)
        Me.cboLugaresEntrega.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(519, 39)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 38
        Me.Label5.Text = "Lugar entrega"
        '
        'cboClientes
        '
        Me.cboClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClientes.FormattingEnabled = True
        Me.cboClientes.Location = New System.Drawing.Point(598, 10)
        Me.cboClientes.Name = "cboClientes"
        Me.cboClientes.Size = New System.Drawing.Size(291, 21)
        Me.cboClientes.TabIndex = 35
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(519, 13)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "Cliente"
        '
        'btnDesglose
        '
        Me.btnDesglose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDesglose.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.btnDesglose.Location = New System.Drawing.Point(249, 64)
        Me.btnDesglose.Name = "btnDesglose"
        Me.btnDesglose.Size = New System.Drawing.Size(130, 23)
        Me.btnDesglose.TabIndex = 34
        Me.btnDesglose.Text = "Por días desglosado"
        Me.btnDesglose.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.btnDesglose.UseVisualStyleBackColor = True
        '
        'frmLisAlbaranesCarga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 824)
        Me.Controls.Add(Me.dgvEnvasados)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmLisAlbaranesCarga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmLisAlbaranesCarga"
        CType(Me.dgvEnvasados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents lblLitros As System.Windows.Forms.Label
    Private WithEvents lblBotellas As System.Windows.Forms.Label
    Private WithEvents lblTotalCajas As System.Windows.Forms.Label
    Private WithEvents txtTotalLitros As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTotalBotellas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtTotalCajas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents btnExcel As System.Windows.Forms.Button
    Private WithEvents btnImprimir As System.Windows.Forms.Button
    Private WithEvents dtpDesde As System.Windows.Forms.DateTimePicker
    Private WithEvents btnPorDias As System.Windows.Forms.Button
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents dgvEnvasados As System.Windows.Forms.DataGridView
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents dtpHasta As System.Windows.Forms.DateTimePicker
    Private WithEvents cboReferencia As System.Windows.Forms.ComboBox
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents btnDesglose As System.Windows.Forms.Button
    Private WithEvents cboLugaresEntrega As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents cboClientes As System.Windows.Forms.ComboBox
    Private WithEvents Label4 As System.Windows.Forms.Label
End Class
