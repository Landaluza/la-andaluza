<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCamposADD
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
        Me.txtID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboArticuloTipoID = New System.Windows.Forms.ComboBox()
        Me.cboSolicitanteID = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtUtilizacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblArticuloTipoID = New System.Windows.Forms.Label()
        Me.lblSolicitanteID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblUtilizacion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtID
        '
        Me.txtID.BackColor = System.Drawing.SystemColors.Window
        Me.txtID.EsUnicoCampo = ""
        Me.txtID.EsUnicoCampoID = ""
        Me.txtID.EsUnicoID = 0
        Me.txtID.EsUnicoTabla = ""
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(113, 3)
        Me.txtID.MaxLength = 9
        Me.txtID.Minimo = 0
        Me.txtID.Modificado = False
        Me.txtID.Name = "txtID"
        Me.txtID.Numerico_EsNumerico = False
        Me.txtID.Numerico_NumeroDoublees = 0
        Me.txtID.Numerico_SeparadorMiles = False
        Me.txtID.Obligatorio = True
        Me.txtID.ParametroID = 0
        Me.txtID.Size = New System.Drawing.Size(56, 21)
        Me.txtID.TabIndex = 0
        Me.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtID.ValorMaximo = 0.0!
        Me.txtID.ValorMinimo = 0.0!
        Me.txtID.Visible = False
        '
        'cboArticuloTipoID
        '
        Me.cboArticuloTipoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboArticuloTipoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboArticuloTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboArticuloTipoID.Location = New System.Drawing.Point(113, 30)
        Me.cboArticuloTipoID.Name = "cboArticuloTipoID"
        Me.cboArticuloTipoID.Size = New System.Drawing.Size(314, 23)
        Me.cboArticuloTipoID.TabIndex = 1
        Me.cboArticuloTipoID.Visible = False
        '
        'cboSolicitanteID
        '
        Me.cboSolicitanteID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboSolicitanteID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboSolicitanteID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSolicitanteID.Location = New System.Drawing.Point(113, 59)
        Me.cboSolicitanteID.Name = "cboSolicitanteID"
        Me.cboSolicitanteID.Size = New System.Drawing.Size(314, 23)
        Me.cboSolicitanteID.TabIndex = 2
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(113, 88)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(314, 21)
        Me.txtDescripcion.TabIndex = 3
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtUtilizacion
        '
        Me.txtUtilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtUtilizacion.EsUnicoCampo = ""
        Me.txtUtilizacion.EsUnicoCampoID = ""
        Me.txtUtilizacion.EsUnicoID = 0
        Me.txtUtilizacion.EsUnicoTabla = ""
        Me.txtUtilizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizacion.Location = New System.Drawing.Point(113, 115)
        Me.txtUtilizacion.MaxLength = 4000
        Me.txtUtilizacion.Minimo = 0
        Me.txtUtilizacion.Modificado = False
        Me.txtUtilizacion.Name = "txtUtilizacion"
        Me.txtUtilizacion.Numerico_EsNumerico = False
        Me.txtUtilizacion.Numerico_NumeroDoublees = 0
        Me.txtUtilizacion.Numerico_SeparadorMiles = False
        Me.txtUtilizacion.Obligatorio = False
        Me.txtUtilizacion.ParametroID = 0
        Me.txtUtilizacion.Size = New System.Drawing.Size(591, 21)
        Me.txtUtilizacion.TabIndex = 4
        Me.txtUtilizacion.ValorMaximo = 0.0!
        Me.txtUtilizacion.ValorMinimo = 0.0!
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
        Me.txtObservaciones.Location = New System.Drawing.Point(113, 142)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(591, 21)
        Me.txtObservaciones.TabIndex = 5
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'lblID
        '
        Me.lblID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblID.Location = New System.Drawing.Point(23, 0)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(84, 21)
        Me.lblID.TabIndex = 0
        Me.lblID.Text = "ID"
        Me.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblID.Visible = False
        '
        'lblArticuloTipoID
        '
        Me.lblArticuloTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblArticuloTipoID.Location = New System.Drawing.Point(23, 27)
        Me.lblArticuloTipoID.Name = "lblArticuloTipoID"
        Me.lblArticuloTipoID.Size = New System.Drawing.Size(84, 21)
        Me.lblArticuloTipoID.TabIndex = 1
        Me.lblArticuloTipoID.Text = "ArticuloTipoID"
        Me.lblArticuloTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblArticuloTipoID.Visible = False
        '
        'lblSolicitanteID
        '
        Me.lblSolicitanteID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblSolicitanteID.Location = New System.Drawing.Point(23, 56)
        Me.lblSolicitanteID.Name = "lblSolicitanteID"
        Me.lblSolicitanteID.Size = New System.Drawing.Size(84, 21)
        Me.lblSolicitanteID.TabIndex = 2
        Me.lblSolicitanteID.Text = "Solicitante"
        Me.lblSolicitanteID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 85)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(84, 21)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilizacion
        '
        Me.lblUtilizacion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUtilizacion.Location = New System.Drawing.Point(23, 112)
        Me.lblUtilizacion.Name = "lblUtilizacion"
        Me.lblUtilizacion.Size = New System.Drawing.Size(84, 21)
        Me.lblUtilizacion.TabIndex = 4
        Me.lblUtilizacion.Text = "Utilizacion"
        Me.lblUtilizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 139)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 21)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 47.0!))
        Me.tlpMiddle.Controls.Add(Me.lblID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblArticuloTipoID, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboArticuloTipoID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblSolicitanteID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.cboSolicitanteID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblUtilizacion, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.txtUtilizacion, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 5)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 7
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(718, 166)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'frmEntCamposADD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(726, 209)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(443, 246)
        Me.Name = "frmEntCamposADD"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CamposADD"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboArticuloTipoID As System.Windows.Forms.ComboBox
    Private WithEvents cboSolicitanteID As System.Windows.Forms.ComboBox
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtUtilizacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblID As System.Windows.Forms.Label
   Private WithEvents lblArticuloTipoID As System.Windows.Forms.Label
   Private WithEvents lblSolicitanteID As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblUtilizacion As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
