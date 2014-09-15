<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosIngredientesTipos
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
        Me.txtIngredienteTipoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblIngredienteTipoID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.panContenidos = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.panContenidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtIngredienteTipoID
        '
        Me.txtIngredienteTipoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtIngredienteTipoID.EsUnicoCampo = ""
        Me.txtIngredienteTipoID.EsUnicoCampoID = ""
        Me.txtIngredienteTipoID.EsUnicoID = 0
        Me.txtIngredienteTipoID.EsUnicoTabla = ""
        Me.txtIngredienteTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIngredienteTipoID.Location = New System.Drawing.Point(137, 3)
        Me.txtIngredienteTipoID.MaxLength = 9
        Me.txtIngredienteTipoID.Minimo = 0
        Me.txtIngredienteTipoID.Modificado = False
        Me.txtIngredienteTipoID.Name = "txtIngredienteTipoID"
        Me.txtIngredienteTipoID.Numerico_EsNumerico = False
        Me.txtIngredienteTipoID.Numerico_NumeroDoublees = 0
        Me.txtIngredienteTipoID.Numerico_SeparadorMiles = False
        Me.txtIngredienteTipoID.Obligatorio = True
        Me.txtIngredienteTipoID.ParametroID = 0
        Me.txtIngredienteTipoID.Size = New System.Drawing.Size(56, 21)
        Me.txtIngredienteTipoID.TabIndex = 0
        Me.txtIngredienteTipoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtIngredienteTipoID.ValorMaximo = 0.0!
        Me.txtIngredienteTipoID.ValorMinimo = 0.0!
        Me.txtIngredienteTipoID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(137, 30)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(550, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(137, 57)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(550, 21)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblIngredienteTipoID
        '
        Me.lblIngredienteTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblIngredienteTipoID.Location = New System.Drawing.Point(33, 0)
        Me.lblIngredienteTipoID.Name = "lblIngredienteTipoID"
        Me.lblIngredienteTipoID.Size = New System.Drawing.Size(98, 21)
        Me.lblIngredienteTipoID.TabIndex = 0
        Me.lblIngredienteTipoID.Text = "IngredienteTipoID"
        Me.lblIngredienteTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblIngredienteTipoID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(33, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(98, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(33, 54)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(98, 21)
        Me.lblObservaciones.TabIndex = 2
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
        Me.tlpMiddle.Controls.Add(Me.lblIngredienteTipoID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtIngredienteTipoID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 2)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 0)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(691, 113)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'panContenidos
        '
        Me.panContenidos.Controls.Add(Me.tlpMiddle)
        Me.panContenidos.Location = New System.Drawing.Point(12, 57)
        Me.panContenidos.Name = "panContenidos"
        Me.panContenidos.Size = New System.Drawing.Size(691, 113)
        Me.panContenidos.TabIndex = 1000000002
        '
        'frmEntArticulosIngredientesTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(715, 198)
        Me.Controls.Add(Me.panContenidos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulosIngredientesTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ArticulosIngredientesTipos"
        Me.Controls.SetChildIndex(Me.panContenidos, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.panContenidos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtIngredienteTipoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblIngredienteTipoID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents panContenidos As System.Windows.Forms.Panel
End Class
