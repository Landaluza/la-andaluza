<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProveedoresTipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProveedoresTipos))
        Me.txtProveedorTipoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblProveedorTipoID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtProveedorTipoID
        '
        Me.txtProveedorTipoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtProveedorTipoID.EsUnicoCampo = ""
        Me.txtProveedorTipoID.EsUnicoCampoID = ""
        Me.txtProveedorTipoID.EsUnicoID = 0
        Me.txtProveedorTipoID.EsUnicoTabla = ""
        Me.txtProveedorTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProveedorTipoID.Location = New System.Drawing.Point(130, 3)
        Me.txtProveedorTipoID.MaxLength = 9
        Me.txtProveedorTipoID.Minimo = 0
        Me.txtProveedorTipoID.Modificado = False
        Me.txtProveedorTipoID.Name = "txtProveedorTipoID"
        Me.txtProveedorTipoID.Numerico_EsNumerico = False
        Me.txtProveedorTipoID.Numerico_NumeroDoublees = 0
        Me.txtProveedorTipoID.Numerico_SeparadorMiles = False
        Me.txtProveedorTipoID.Obligatorio = True
        Me.txtProveedorTipoID.ParametroID = 0
        Me.txtProveedorTipoID.Size = New System.Drawing.Size(56, 21)
        Me.txtProveedorTipoID.TabIndex = 0
        Me.txtProveedorTipoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtProveedorTipoID.ValorMaximo = 0.0R
        Me.txtProveedorTipoID.ValorMinimo = 0.0R
        Me.txtProveedorTipoID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 30)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(491, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(130, 57)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(491, 21)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblProveedorTipoID
        '
        Me.lblProveedorTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblProveedorTipoID.Location = New System.Drawing.Point(33, 0)
        Me.lblProveedorTipoID.Name = "lblProveedorTipoID"
        Me.lblProveedorTipoID.Size = New System.Drawing.Size(91, 21)
        Me.lblProveedorTipoID.TabIndex = 0
        Me.lblProveedorTipoID.Text = "ProveedorTipoID"
        Me.lblProveedorTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblProveedorTipoID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(33, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(91, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(33, 54)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(91, 21)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 5
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.Controls.Add(Me.lblProveedorTipoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtProveedorTipoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(684, 81)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntProveedoresTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(684, 135)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntProveedoresTipos"
        Me.Text = "ProveedoresTipos"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtProveedorTipoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblProveedorTipoID As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
