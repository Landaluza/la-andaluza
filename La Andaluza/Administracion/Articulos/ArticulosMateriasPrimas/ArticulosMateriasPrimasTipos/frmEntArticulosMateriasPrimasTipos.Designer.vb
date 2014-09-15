<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosMateriasPrimasTipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosMateriasPrimasTipos))
        Me.txtMateriaPrimaTipoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbLiquido = New System.Windows.Forms.CheckBox()
        Me.chbCertificadoOGM = New System.Windows.Forms.CheckBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblMateriaPrimaTipoID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblLiquido = New System.Windows.Forms.Label()
        Me.lblCertificadoOGM = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.panContenido = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.panContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        '
        'txtMateriaPrimaTipoID
        '
        Me.txtMateriaPrimaTipoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtMateriaPrimaTipoID.EsUnicoCampo = ""
        Me.txtMateriaPrimaTipoID.EsUnicoCampoID = ""
        Me.txtMateriaPrimaTipoID.EsUnicoID = 0
        Me.txtMateriaPrimaTipoID.EsUnicoTabla = ""
        Me.txtMateriaPrimaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMateriaPrimaTipoID.Location = New System.Drawing.Point(208, 4)
        Me.txtMateriaPrimaTipoID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMateriaPrimaTipoID.MaxLength = 9
        Me.txtMateriaPrimaTipoID.Minimo = 0
        Me.txtMateriaPrimaTipoID.Modificado = False
        Me.txtMateriaPrimaTipoID.Name = "txtMateriaPrimaTipoID"
        Me.txtMateriaPrimaTipoID.Numerico_EsNumerico = False
        Me.txtMateriaPrimaTipoID.Numerico_NumeroDoublees = 0
        Me.txtMateriaPrimaTipoID.Numerico_SeparadorMiles = False
        Me.txtMateriaPrimaTipoID.Obligatorio = True
        Me.txtMateriaPrimaTipoID.ParametroID = 0
        Me.txtMateriaPrimaTipoID.Size = New System.Drawing.Size(73, 24)
        Me.txtMateriaPrimaTipoID.TabIndex = 0
        Me.txtMateriaPrimaTipoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMateriaPrimaTipoID.ValorMaximo = 0.0!
        Me.txtMateriaPrimaTipoID.ValorMinimo = 0.0!
        Me.txtMateriaPrimaTipoID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(208, 36)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(469, 24)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'chbLiquido
        '
        Me.chbLiquido.BackColor = System.Drawing.SystemColors.Control
        Me.chbLiquido.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbLiquido.Location = New System.Drawing.Point(208, 68)
        Me.chbLiquido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbLiquido.Name = "chbLiquido"
        Me.chbLiquido.Size = New System.Drawing.Size(21, 26)
        Me.chbLiquido.TabIndex = 2
        Me.chbLiquido.UseVisualStyleBackColor = False
        '
        'chbCertificadoOGM
        '
        Me.chbCertificadoOGM.BackColor = System.Drawing.SystemColors.Control
        Me.chbCertificadoOGM.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCertificadoOGM.Location = New System.Drawing.Point(208, 102)
        Me.chbCertificadoOGM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chbCertificadoOGM.Name = "chbCertificadoOGM"
        Me.chbCertificadoOGM.Size = New System.Drawing.Size(21, 26)
        Me.chbCertificadoOGM.TabIndex = 3
        Me.chbCertificadoOGM.UseVisualStyleBackColor = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(208, 136)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(901, 24)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblMateriaPrimaTipoID
        '
        Me.lblMateriaPrimaTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMateriaPrimaTipoID.Location = New System.Drawing.Point(56, 0)
        Me.lblMateriaPrimaTipoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMateriaPrimaTipoID.Name = "lblMateriaPrimaTipoID"
        Me.lblMateriaPrimaTipoID.Size = New System.Drawing.Size(144, 26)
        Me.lblMateriaPrimaTipoID.TabIndex = 0
        Me.lblMateriaPrimaTipoID.Text = "MateriaPrimaTipoID"
        Me.lblMateriaPrimaTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblMateriaPrimaTipoID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(56, 32)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(144, 26)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLiquido
        '
        Me.lblLiquido.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblLiquido.Location = New System.Drawing.Point(56, 64)
        Me.lblLiquido.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblLiquido.Name = "lblLiquido"
        Me.lblLiquido.Size = New System.Drawing.Size(144, 26)
        Me.lblLiquido.TabIndex = 2
        Me.lblLiquido.Text = "Liquido"
        Me.lblLiquido.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCertificadoOGM
        '
        Me.lblCertificadoOGM.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblCertificadoOGM.Location = New System.Drawing.Point(56, 98)
        Me.lblCertificadoOGM.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblCertificadoOGM.Name = "lblCertificadoOGM"
        Me.lblCertificadoOGM.Size = New System.Drawing.Size(144, 26)
        Me.lblCertificadoOGM.TabIndex = 3
        Me.lblCertificadoOGM.Text = "CertificadoOGM"
        Me.lblCertificadoOGM.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(56, 132)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(144, 26)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblMateriaPrimaTipoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtMateriaPrimaTipoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblLiquido, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.chbLiquido, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblCertificadoOGM, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.chbCertificadoOGM, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 4)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 0)
        Me.tlpMiddle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(1145, 219)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        '
        'panContenido
        '
        Me.panContenido.Controls.Add(Me.tlpMiddle)
        Me.panContenido.Location = New System.Drawing.Point(0, 66)
        Me.panContenido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.panContenido.Name = "panContenido"
        Me.panContenido.Size = New System.Drawing.Size(1145, 219)
        Me.panContenido.TabIndex = 1000000002
        '
        'frmEntArticulosMateriasPrimasTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1145, 327)
        Me.Controls.Add(Me.panContenido)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulosMateriasPrimasTipos"
        Me.Text = "ArticulosMateriasPrimasTipos"
        Me.Controls.SetChildIndex(Me.panContenido, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.panContenido.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents panContenido As System.Windows.Forms.Panel
    Private WithEvents txtMateriaPrimaTipoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbLiquido As System.Windows.Forms.CheckBox
    Private WithEvents chbCertificadoOGM As System.Windows.Forms.CheckBox
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblMateriaPrimaTipoID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblLiquido As System.Windows.Forms.Label
    Private WithEvents lblCertificadoOGM As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
