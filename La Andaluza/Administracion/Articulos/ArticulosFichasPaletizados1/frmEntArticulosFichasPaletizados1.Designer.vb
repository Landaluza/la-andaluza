<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosFichasPaletizados1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosFichasPaletizados1))
        Me.txtArticuloFichaPaletizadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRuta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRuta = New System.Windows.Forms.Button()
        Me.dtpFechaVigente = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaObsoleta = New System.Windows.Forms.DateTimePicker()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblArticuloFichaPaletizadoID = New System.Windows.Forms.Label()
        Me.lblRuta = New System.Windows.Forms.Label()
        Me.lblFechaVigente = New System.Windows.Forms.Label()
        Me.lblFechaObsoleta = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.lblArticuloID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloID = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5)
        '
        'txtArticuloFichaPaletizadoID
        '
        Me.txtArticuloFichaPaletizadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtArticuloFichaPaletizadoID.EsUnicoCampo = ""
        Me.txtArticuloFichaPaletizadoID.EsUnicoCampoID = ""
        Me.txtArticuloFichaPaletizadoID.EsUnicoID = 0
        Me.txtArticuloFichaPaletizadoID.EsUnicoTabla = ""
        Me.txtArticuloFichaPaletizadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtArticuloFichaPaletizadoID.Location = New System.Drawing.Point(359, 294)
        Me.txtArticuloFichaPaletizadoID.Margin = New System.Windows.Forms.Padding(4)
        Me.txtArticuloFichaPaletizadoID.MaxLength = 9
        Me.txtArticuloFichaPaletizadoID.Minimo = 0
        Me.txtArticuloFichaPaletizadoID.Modificado = False
        Me.txtArticuloFichaPaletizadoID.Name = "txtArticuloFichaPaletizadoID"
        Me.txtArticuloFichaPaletizadoID.Numerico_EsNumerico = False
        Me.txtArticuloFichaPaletizadoID.Numerico_NumeroDoublees = 0
        Me.txtArticuloFichaPaletizadoID.Numerico_SeparadorMiles = False
        Me.txtArticuloFichaPaletizadoID.Obligatorio = True
        Me.txtArticuloFichaPaletizadoID.ParametroID = 0
        Me.txtArticuloFichaPaletizadoID.Size = New System.Drawing.Size(79, 24)
        Me.txtArticuloFichaPaletizadoID.TabIndex = 0
        Me.txtArticuloFichaPaletizadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtArticuloFichaPaletizadoID.ValorMaximo = 0.0!
        Me.txtArticuloFichaPaletizadoID.ValorMinimo = 0.0!
        Me.txtArticuloFichaPaletizadoID.Visible = False
        '
        'txtRuta
        '
        Me.txtRuta.BackColor = System.Drawing.SystemColors.Window
        Me.txtRuta.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRuta.Enabled = False
        Me.txtRuta.EsUnicoCampo = ""
        Me.txtRuta.EsUnicoCampoID = ""
        Me.txtRuta.EsUnicoID = 0
        Me.txtRuta.EsUnicoTabla = ""
        Me.txtRuta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRuta.Location = New System.Drawing.Point(210, 70)
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
        Me.txtRuta.Size = New System.Drawing.Size(964, 24)
        Me.txtRuta.TabIndex = 3
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
        Me.butRuta.Location = New System.Drawing.Point(1199, 70)
        Me.butRuta.Margin = New System.Windows.Forms.Padding(4)
        Me.butRuta.Name = "butRuta"
        Me.butRuta.Size = New System.Drawing.Size(27, 25)
        Me.butRuta.TabIndex = 4
        Me.butRuta.TabStop = False
        '
        'dtpFechaVigente
        '
        Me.dtpFechaVigente.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaVigente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaVigente.Location = New System.Drawing.Point(210, 103)
        Me.dtpFechaVigente.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaVigente.Name = "dtpFechaVigente"
        Me.dtpFechaVigente.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaVigente.TabIndex = 4
        '
        'dtpFechaObsoleta
        '
        Me.dtpFechaObsoleta.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaObsoleta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaObsoleta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaObsoleta.Location = New System.Drawing.Point(210, 135)
        Me.dtpFechaObsoleta.Margin = New System.Windows.Forms.Padding(4)
        Me.dtpFechaObsoleta.Name = "dtpFechaObsoleta"
        Me.dtpFechaObsoleta.Size = New System.Drawing.Size(125, 24)
        Me.dtpFechaObsoleta.TabIndex = 5
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(210, 167)
        Me.chbVigente.Margin = New System.Windows.Forms.Padding(4)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(21, 26)
        Me.chbVigente.TabIndex = 6
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(210, 201)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(964, 24)
        Me.txtObservaciones.TabIndex = 7
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblArticuloFichaPaletizadoID
        '
        Me.lblArticuloFichaPaletizadoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblArticuloFichaPaletizadoID.Location = New System.Drawing.Point(163, 295)
        Me.lblArticuloFichaPaletizadoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloFichaPaletizadoID.Name = "lblArticuloFichaPaletizadoID"
        Me.lblArticuloFichaPaletizadoID.Size = New System.Drawing.Size(188, 26)
        Me.lblArticuloFichaPaletizadoID.TabIndex = 0
        Me.lblArticuloFichaPaletizadoID.Text = "ArticuloFichaPaletizadoID"
        Me.lblArticuloFichaPaletizadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloFichaPaletizadoID.Visible = False
        '
        'lblRuta
        '
        Me.lblRuta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRuta.Location = New System.Drawing.Point(14, 66)
        Me.lblRuta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRuta.Name = "lblRuta"
        Me.lblRuta.Size = New System.Drawing.Size(188, 26)
        Me.lblRuta.TabIndex = 3
        Me.lblRuta.Text = "Ruta"
        Me.lblRuta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaVigente
        '
        Me.lblFechaVigente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaVigente.Location = New System.Drawing.Point(14, 99)
        Me.lblFechaVigente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaVigente.Name = "lblFechaVigente"
        Me.lblFechaVigente.Size = New System.Drawing.Size(188, 26)
        Me.lblFechaVigente.TabIndex = 6
        Me.lblFechaVigente.Text = "FechaVigente"
        Me.lblFechaVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaObsoleta
        '
        Me.lblFechaObsoleta.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblFechaObsoleta.Location = New System.Drawing.Point(14, 131)
        Me.lblFechaObsoleta.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFechaObsoleta.Name = "lblFechaObsoleta"
        Me.lblFechaObsoleta.Size = New System.Drawing.Size(188, 26)
        Me.lblFechaObsoleta.TabIndex = 7
        Me.lblFechaObsoleta.Text = "FechaObsoleta"
        Me.lblFechaObsoleta.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVigente.Location = New System.Drawing.Point(14, 163)
        Me.lblVigente.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(188, 26)
        Me.lblVigente.TabIndex = 8
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(14, 197)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(188, 26)
        Me.lblObservaciones.TabIndex = 9
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 1.051248!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 98.94875!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblArticuloID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblRuta, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.butRuta, 3, 3)
        Me.tlpMiddle.Controls.Add(Me.lblFechaVigente, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaVigente, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblFechaObsoleta, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaObsoleta, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblVigente, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.chbVigente, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.txtRuta, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloID, 2, 1)
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
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.Size = New System.Drawing.Size(1231, 242)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'lblArticuloID
        '
        Me.lblArticuloID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloID.Location = New System.Drawing.Point(14, 0)
        Me.lblArticuloID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblArticuloID.Name = "lblArticuloID"
        Me.lblArticuloID.Size = New System.Drawing.Size(188, 26)
        Me.lblArticuloID.TabIndex = 1
        Me.lblArticuloID.Text = "ArticuloID"
        Me.lblArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(14, 34)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(188, 26)
        Me.lblDescripcion.TabIndex = 2
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(210, 38)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 0
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(964, 24)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'cboArticuloID
        '
        Me.cboArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloID.Location = New System.Drawing.Point(210, 4)
        Me.cboArticuloID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboArticuloID.Name = "cboArticuloID"
        Me.cboArticuloID.Size = New System.Drawing.Size(516, 26)
        Me.cboArticuloID.TabIndex = 1
        '
        'frmEntArticulosFichasPaletizados1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1231, 330)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Controls.Add(Me.lblArticuloFichaPaletizadoID)
        Me.Controls.Add(Me.txtArticuloFichaPaletizadoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MinimumSize = New System.Drawing.Size(519, 360)
        Me.Name = "frmEntArticulosFichasPaletizados1"
        Me.Text = "ArticulosFichasPaletizados1"
        Me.Controls.SetChildIndex(Me.txtArticuloFichaPaletizadoID, 0)
        Me.Controls.SetChildIndex(Me.lblArticuloFichaPaletizadoID, 0)
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtArticuloFichaPaletizadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRuta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRuta As System.Windows.Forms.Button
    Private WithEvents dtpFechaVigente As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaObsoleta As System.Windows.Forms.DateTimePicker
    Private WithEvents chbVigente As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblArticuloFichaPaletizadoID As System.Windows.Forms.Label
    Private WithEvents lblRuta As System.Windows.Forms.Label
    Private WithEvents lblFechaVigente As System.Windows.Forms.Label
    Private WithEvents lblFechaObsoleta As System.Windows.Forms.Label
    Private WithEvents lblVigente As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents lblArticuloID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboArticuloID As System.Windows.Forms.ComboBox
End Class
