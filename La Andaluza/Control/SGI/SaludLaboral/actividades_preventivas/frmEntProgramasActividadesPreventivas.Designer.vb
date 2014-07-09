<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProgramasActividadesPreventivas
    Inherits BasesParaCompatibilidad.DetailedSimpleForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProgramasActividadesPreventivas))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpFechaFinal = New System.Windows.Forms.DateTimePicker()
        Me.txtAutor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbVigente = New System.Windows.Forms.CheckBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblFechaInicio = New System.Windows.Forms.Label()
        Me.lblFechaFinal = New System.Windows.Forms.Label()
        Me.lblAutor = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblVigente = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(108, 14)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(342, 21)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'dtpFechaInicio
        '
        Me.dtpFechaInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaInicio.Location = New System.Drawing.Point(108, 42)
        Me.dtpFechaInicio.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaInicio.Name = "dtpFechaInicio"
        Me.dtpFechaInicio.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaInicio.TabIndex = 1
        '
        'dtpFechaFinal
        '
        Me.dtpFechaFinal.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFechaFinal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFechaFinal.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaFinal.Location = New System.Drawing.Point(108, 70)
        Me.dtpFechaFinal.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFechaFinal.Name = "dtpFechaFinal"
        Me.dtpFechaFinal.Size = New System.Drawing.Size(86, 21)
        Me.dtpFechaFinal.TabIndex = 2
        '
        'txtAutor
        '
        Me.txtAutor.BackColor = System.Drawing.SystemColors.Window
        Me.txtAutor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtAutor.EsUnicoCampo = ""
        Me.txtAutor.EsUnicoCampoID = ""
        Me.txtAutor.EsUnicoID = 0
        Me.txtAutor.EsUnicoTabla = ""
        Me.txtAutor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAutor.Location = New System.Drawing.Point(108, 98)
        Me.txtAutor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAutor.MaxLength = 500
        Me.txtAutor.Minimo = 0
        Me.txtAutor.Modificado = False
        Me.txtAutor.Name = "txtAutor"
        Me.txtAutor.Numerico_EsNumerico = False
        Me.txtAutor.Numerico_NumeroDoublees = 0
        Me.txtAutor.Numerico_SeparadorMiles = False
        Me.txtAutor.Obligatorio = False
        Me.txtAutor.ParametroID = 0
        Me.txtAutor.Size = New System.Drawing.Size(342, 21)
        Me.txtAutor.TabIndex = 3
        Me.txtAutor.ValorMaximo = 0.0R
        Me.txtAutor.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 126)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(342, 21)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'chbVigente
        '
        Me.chbVigente.BackColor = System.Drawing.SystemColors.Control
        Me.chbVigente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbVigente.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbVigente.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbVigente.Location = New System.Drawing.Point(108, 154)
        Me.chbVigente.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbVigente.Name = "chbVigente"
        Me.chbVigente.Size = New System.Drawing.Size(342, 22)
        Me.chbVigente.TabIndex = 5
        Me.chbVigente.UseVisualStyleBackColor = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(20, 12)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaInicio
        '
        Me.lblFechaInicio.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaInicio.Location = New System.Drawing.Point(20, 40)
        Me.lblFechaInicio.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaInicio.Name = "lblFechaInicio"
        Me.lblFechaInicio.Size = New System.Drawing.Size(84, 28)
        Me.lblFechaInicio.TabIndex = 1
        Me.lblFechaInicio.Text = "Inicio"
        Me.lblFechaInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFechaFinal
        '
        Me.lblFechaFinal.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFechaFinal.Location = New System.Drawing.Point(20, 68)
        Me.lblFechaFinal.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFechaFinal.Name = "lblFechaFinal"
        Me.lblFechaFinal.Size = New System.Drawing.Size(84, 28)
        Me.lblFechaFinal.TabIndex = 2
        Me.lblFechaFinal.Text = "Fin"
        Me.lblFechaFinal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAutor
        '
        Me.lblAutor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblAutor.Location = New System.Drawing.Point(20, 96)
        Me.lblAutor.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAutor.Name = "lblAutor"
        Me.lblAutor.Size = New System.Drawing.Size(84, 28)
        Me.lblAutor.TabIndex = 3
        Me.lblAutor.Text = "Autor"
        Me.lblAutor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(20, 124)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 28)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVigente
        '
        Me.lblVigente.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblVigente.Location = New System.Drawing.Point(20, 152)
        Me.lblVigente.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVigente.Name = "lblVigente"
        Me.lblVigente.Size = New System.Drawing.Size(84, 26)
        Me.lblVigente.TabIndex = 5
        Me.lblVigente.Text = "Vigente"
        Me.lblVigente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFechaInicio, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaInicio, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFechaFinal, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpFechaFinal, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblAutor, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtAutor, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblVigente, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.chbVigente, 2, 5)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 12, 0, 0)
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(476, 181)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntProgramasActividadesPreventivas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(476, 206)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(485, 233)
        Me.Name = "frmEntProgramasActividadesPreventivas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProgramasActividadesPreventivas"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFechaInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpFechaFinal As System.Windows.Forms.DateTimePicker
    Private WithEvents txtAutor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents chbVigente As System.Windows.Forms.CheckBox
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblFechaInicio As System.Windows.Forms.Label
   Private WithEvents lblFechaFinal As System.Windows.Forms.Label
   Private WithEvents lblAutor As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblVigente As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
