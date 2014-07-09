<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntelaboraciones_fases
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
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.cboid_articuloGranel = New System.Windows.Forms.ComboBox()
        Me.chbanalizar = New System.Windows.Forms.CheckBox()
        Me.lblid_articuloGranel = New System.Windows.Forms.Label()
        Me.lblfase = New System.Windows.Forms.Label()
        Me.lblanalizar = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbSobreTerminado = New System.Windows.Forms.CheckBox()
        Me.txtfase = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsGuardar = New System.Windows.Forms.ToolStripButton()
        Me.tssalir = New System.Windows.Forms.ToolStripButton()
        Me.tlpMiddle.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboid_articuloGranel
        '
        Me.cboid_articuloGranel.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_articuloGranel.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_articuloGranel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_articuloGranel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_articuloGranel.Location = New System.Drawing.Point(149, 18)
        Me.cboid_articuloGranel.Name = "cboid_articuloGranel"
        Me.cboid_articuloGranel.Size = New System.Drawing.Size(240, 26)
        Me.cboid_articuloGranel.TabIndex = 0
        '
        'chbanalizar
        '
        Me.chbanalizar.BackColor = System.Drawing.SystemColors.Control
        Me.chbanalizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbanalizar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbanalizar.Location = New System.Drawing.Point(149, 90)
        Me.chbanalizar.Name = "chbanalizar"
        Me.chbanalizar.Size = New System.Drawing.Size(240, 25)
        Me.chbanalizar.TabIndex = 2
        Me.chbanalizar.UseVisualStyleBackColor = False
        '
        'lblid_articuloGranel
        '
        Me.lblid_articuloGranel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_articuloGranel.Location = New System.Drawing.Point(27, 15)
        Me.lblid_articuloGranel.Name = "lblid_articuloGranel"
        Me.lblid_articuloGranel.Size = New System.Drawing.Size(116, 37)
        Me.lblid_articuloGranel.TabIndex = 0
        Me.lblid_articuloGranel.Text = "ArticuloGranel"
        Me.lblid_articuloGranel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblfase
        '
        Me.lblfase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblfase.Location = New System.Drawing.Point(27, 52)
        Me.lblfase.Name = "lblfase"
        Me.lblfase.Size = New System.Drawing.Size(116, 35)
        Me.lblfase.TabIndex = 3
        Me.lblfase.Text = "Fase"
        Me.lblfase.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblanalizar
        '
        Me.lblanalizar.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblanalizar.Location = New System.Drawing.Point(27, 87)
        Me.lblanalizar.Name = "lblanalizar"
        Me.lblanalizar.Size = New System.Drawing.Size(116, 31)
        Me.lblanalizar.TabIndex = 4
        Me.lblanalizar.Text = "Analizar"
        Me.lblanalizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102.0!))
        Me.tlpMiddle.Controls.Add(Me.Label1, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.cbSobreTerminado, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblid_articuloGranel, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboid_articuloGranel, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblfase, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtfase, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblanalizar, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.chbanalizar, 2, 2)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(494, 172)
        Me.tlpMiddle.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Label1.Location = New System.Drawing.Point(27, 118)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 54)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Añadir en terminado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cbSobreTerminado
        '
        Me.cbSobreTerminado.BackColor = System.Drawing.SystemColors.Control
        Me.cbSobreTerminado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbSobreTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbSobreTerminado.Location = New System.Drawing.Point(149, 121)
        Me.cbSobreTerminado.Name = "cbSobreTerminado"
        Me.cbSobreTerminado.Size = New System.Drawing.Size(240, 48)
        Me.cbSobreTerminado.TabIndex = 5
        Me.cbSobreTerminado.UseVisualStyleBackColor = False
        '
        'txtfase
        '
        Me.txtfase.BackColor = System.Drawing.SystemColors.Window
        Me.txtfase.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtfase.EsUnicoCampo = ""
        Me.txtfase.EsUnicoCampoID = ""
        Me.txtfase.EsUnicoID = 0
        Me.txtfase.EsUnicoTabla = ""
        Me.txtfase.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfase.Location = New System.Drawing.Point(149, 55)
        Me.txtfase.MaxLength = 9
        Me.txtfase.Minimo = 0
        Me.txtfase.Modificado = False
        Me.txtfase.Name = "txtfase"
        Me.txtfase.Numerico_EsNumerico = False
        Me.txtfase.Numerico_NumeroDoublees = 0
        Me.txtfase.Numerico_SeparadorMiles = False
        Me.txtfase.Obligatorio = False
        Me.txtfase.ParametroID = 0
        Me.txtfase.Size = New System.Drawing.Size(240, 24)
        Me.txtfase.TabIndex = 1
        Me.txtfase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtfase.ValorMaximo = 0.0!
        Me.txtfase.ValorMinimo = 0.0!
        '
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsGuardar, Me.tssalir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(494, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsGuardar
        '
        Me.tsGuardar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsGuardar.Image = Global.La_Andaluza.My.Resources.Resources.document_save_5_16
        Me.tsGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsGuardar.Name = "tsGuardar"
        Me.tsGuardar.Size = New System.Drawing.Size(23, 22)
        Me.tsGuardar.Text = "Guardar"
        '
        'tssalir
        '
        Me.tssalir.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tssalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tssalir.Image = Global.La_Andaluza.My.Resources.Resources.application_xit_3
        Me.tssalir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tssalir.Name = "tssalir"
        Me.tssalir.Size = New System.Drawing.Size(23, 22)
        Me.tssalir.Text = "Salir"
        '
        'frmEntelaboraciones_fases
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 15)
        Me.ClientSize = New System.Drawing.Size(494, 197)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MinimumSize = New System.Drawing.Size(512, 188)
        Me.Name = "frmEntelaboraciones_fases"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "elaboraciones_fases"
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboid_articuloGranel As System.Windows.Forms.ComboBox
    Private WithEvents txtfase As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents chbanalizar As System.Windows.Forms.CheckBox
   Private WithEvents lblid_articuloGranel As System.Windows.Forms.Label
   Private WithEvents lblfase As System.Windows.Forms.Label
   Private WithEvents lblanalizar As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
   Private WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
   Private WithEvents tsGuardar As System.Windows.Forms.ToolStripButton
   Private WithEvents tssalir As System.Windows.Forms.ToolStripButton
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents cbSobreTerminado As System.Windows.Forms.CheckBox
End Class
