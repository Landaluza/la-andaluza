<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsMovimientosTipos
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
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbEntrePalets = New System.Windows.Forms.CheckBox()
        Me.txtUtilizacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbEncajadoMonodosis = New System.Windows.Forms.CheckBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblEntrePalets = New System.Windows.Forms.Label()
        Me.lblUtilizacion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblEncajadoMonodosis = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(185, 18)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(240, 24)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'chbEntrePalets
        '
        Me.chbEntrePalets.BackColor = System.Drawing.SystemColors.Control
        Me.chbEntrePalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbEntrePalets.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEntrePalets.Location = New System.Drawing.Point(185, 53)
        Me.chbEntrePalets.Name = "chbEntrePalets"
        Me.chbEntrePalets.Size = New System.Drawing.Size(240, 25)
        Me.chbEntrePalets.TabIndex = 1
        Me.chbEntrePalets.UseVisualStyleBackColor = False
        '
        'txtUtilizacion
        '
        Me.txtUtilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtUtilizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtUtilizacion.EsUnicoCampo = ""
        Me.txtUtilizacion.EsUnicoCampoID = ""
        Me.txtUtilizacion.EsUnicoID = 0
        Me.txtUtilizacion.EsUnicoTabla = ""
        Me.txtUtilizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizacion.Location = New System.Drawing.Point(185, 84)
        Me.txtUtilizacion.MaxLength = 500
        Me.txtUtilizacion.Minimo = 0
        Me.txtUtilizacion.Modificado = False
        Me.txtUtilizacion.Name = "txtUtilizacion"
        Me.txtUtilizacion.Numerico_EsNumerico = False
        Me.txtUtilizacion.Numerico_NumeroDoublees = 0
        Me.txtUtilizacion.Numerico_SeparadorMiles = False
        Me.txtUtilizacion.Obligatorio = False
        Me.txtUtilizacion.ParametroID = 0
        Me.txtUtilizacion.Size = New System.Drawing.Size(240, 24)
        Me.txtUtilizacion.TabIndex = 2
        Me.txtUtilizacion.ValorMaximo = 0.0!
        Me.txtUtilizacion.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(185, 119)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(336, 24)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'chbEncajadoMonodosis
        '
        Me.chbEncajadoMonodosis.BackColor = System.Drawing.SystemColors.Control
        Me.chbEncajadoMonodosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chbEncajadoMonodosis.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEncajadoMonodosis.Location = New System.Drawing.Point(185, 153)
        Me.chbEncajadoMonodosis.Name = "chbEncajadoMonodosis"
        Me.chbEncajadoMonodosis.Size = New System.Drawing.Size(240, 25)
        Me.chbEncajadoMonodosis.TabIndex = 4
        Me.chbEncajadoMonodosis.UseVisualStyleBackColor = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblDescripcion.Location = New System.Drawing.Point(27, 15)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(152, 35)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEntrePalets
        '
        Me.lblEntrePalets.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEntrePalets.Location = New System.Drawing.Point(27, 50)
        Me.lblEntrePalets.Name = "lblEntrePalets"
        Me.lblEntrePalets.Size = New System.Drawing.Size(152, 31)
        Me.lblEntrePalets.TabIndex = 1
        Me.lblEntrePalets.Text = "EntrePalets"
        Me.lblEntrePalets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilizacion
        '
        Me.lblUtilizacion.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblUtilizacion.Location = New System.Drawing.Point(27, 81)
        Me.lblUtilizacion.Name = "lblUtilizacion"
        Me.lblUtilizacion.Size = New System.Drawing.Size(152, 35)
        Me.lblUtilizacion.TabIndex = 2
        Me.lblUtilizacion.Text = "Utilizacion"
        Me.lblUtilizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblObservaciones.Location = New System.Drawing.Point(27, 116)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(152, 34)
        Me.lblObservaciones.TabIndex = 3
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEncajadoMonodosis
        '
        Me.lblEncajadoMonodosis.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblEncajadoMonodosis.Location = New System.Drawing.Point(27, 150)
        Me.lblEncajadoMonodosis.Name = "lblEncajadoMonodosis"
        Me.lblEncajadoMonodosis.Size = New System.Drawing.Size(152, 31)
        Me.lblEncajadoMonodosis.TabIndex = 4
        Me.lblEncajadoMonodosis.Text = "Encajado monodosis"
        Me.lblEncajadoMonodosis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 56.0!))
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblEntrePalets, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.chbEntrePalets, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblUtilizacion, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtUtilizacion, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblEncajadoMonodosis, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.chbEncajadoMonodosis, 2, 4)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 6
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(577, 195)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntPaletsMovimientosTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(577, 220)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPaletsMovimientosTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PaletsMovimientosTipos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbEntrePalets As System.Windows.Forms.CheckBox
    Private WithEvents txtUtilizacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbEncajadoMonodosis As System.Windows.Forms.CheckBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblEntrePalets As System.Windows.Forms.Label
    Private WithEvents lblUtilizacion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblEncajadoMonodosis As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
