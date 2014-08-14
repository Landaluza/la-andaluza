<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosTipos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosTipos))
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.butVerResponsableID = New System.Windows.Forms.Button()
        Me.butAddResponsableID = New System.Windows.Forms.Button()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtUtilizacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodificacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblResponsableID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblUtilizacion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCodificacion = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpDocumentos = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboResponsable
        '
        Me.cboResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.Location = New System.Drawing.Point(175, 10)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(478, 26)
        Me.cboResponsable.TabIndex = 0
        '
        'butVerResponsableID
        '
        Me.butVerResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerResponsableID.FlatAppearance.BorderSize = 0
        Me.butVerResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerResponsableID.Location = New System.Drawing.Point(659, 10)
        Me.butVerResponsableID.Name = "butVerResponsableID"
        Me.butVerResponsableID.Size = New System.Drawing.Size(24, 26)
        Me.butVerResponsableID.TabIndex = 1
        Me.butVerResponsableID.TabStop = False
        '
        'butAddResponsableID
        '
        Me.butAddResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddResponsableID.FlatAppearance.BorderSize = 0
        Me.butAddResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddResponsableID.Location = New System.Drawing.Point(689, 10)
        Me.butAddResponsableID.Name = "butAddResponsableID"
        Me.butAddResponsableID.Size = New System.Drawing.Size(24, 26)
        Me.butAddResponsableID.TabIndex = 2
        Me.butAddResponsableID.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(175, 47)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(478, 24)
        Me.txtDescripcion.TabIndex = 1
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
        Me.txtUtilizacion.Location = New System.Drawing.Point(175, 82)
        Me.txtUtilizacion.MaxLength = 500
        Me.txtUtilizacion.Minimo = 0
        Me.txtUtilizacion.Modificado = False
        Me.txtUtilizacion.Name = "txtUtilizacion"
        Me.txtUtilizacion.Numerico_EsNumerico = False
        Me.txtUtilizacion.Numerico_NumeroDoublees = 0
        Me.txtUtilizacion.Numerico_SeparadorMiles = False
        Me.txtUtilizacion.Obligatorio = False
        Me.txtUtilizacion.ParametroID = 0
        Me.txtUtilizacion.Size = New System.Drawing.Size(736, 24)
        Me.txtUtilizacion.TabIndex = 2
        Me.txtUtilizacion.ValorMaximo = 0.0!
        Me.txtUtilizacion.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(175, 116)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(736, 24)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'txtCodificacion
        '
        Me.txtCodificacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodificacion.EsUnicoCampo = ""
        Me.txtCodificacion.EsUnicoCampoID = ""
        Me.txtCodificacion.EsUnicoID = 0
        Me.txtCodificacion.EsUnicoTabla = ""
        Me.txtCodificacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodificacion.Location = New System.Drawing.Point(1085, 12)
        Me.txtCodificacion.MaxLength = 22
        Me.txtCodificacion.Minimo = 0
        Me.txtCodificacion.Modificado = False
        Me.txtCodificacion.Name = "txtCodificacion"
        Me.txtCodificacion.Numerico_EsNumerico = False
        Me.txtCodificacion.Numerico_NumeroDoublees = 0
        Me.txtCodificacion.Numerico_SeparadorMiles = False
        Me.txtCodificacion.Obligatorio = False
        Me.txtCodificacion.ParametroID = 0
        Me.txtCodificacion.Size = New System.Drawing.Size(155, 24)
        Me.txtCodificacion.TabIndex = 4
        Me.txtCodificacion.ValorMaximo = 0.0!
        Me.txtCodificacion.ValorMinimo = 0.0!
        '
        'lblResponsableID
        '
        Me.lblResponsableID.Location = New System.Drawing.Point(41, 6)
        Me.lblResponsableID.Name = "lblResponsableID"
        Me.lblResponsableID.Size = New System.Drawing.Size(100, 37)
        Me.lblResponsableID.TabIndex = 0
        Me.lblResponsableID.Text = "Responsable"
        Me.lblResponsableID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(41, 43)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(100, 35)
        Me.lblDescripcion.TabIndex = 3
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilizacion
        '
        Me.lblUtilizacion.Location = New System.Drawing.Point(41, 78)
        Me.lblUtilizacion.Name = "lblUtilizacion"
        Me.lblUtilizacion.Size = New System.Drawing.Size(100, 34)
        Me.lblUtilizacion.TabIndex = 4
        Me.lblUtilizacion.Text = "Utilización"
        Me.lblUtilizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(41, 112)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(108, 35)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodificacion
        '
        Me.lblCodificacion.Location = New System.Drawing.Point(951, 8)
        Me.lblCodificacion.Name = "lblCodificacion"
        Me.lblCodificacion.Size = New System.Drawing.Size(100, 35)
        Me.lblCodificacion.TabIndex = 6
        Me.lblCodificacion.Text = "Codificación"
        Me.lblCodificacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 186)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1253, 454)
        Me.Panel1.TabIndex = 1000000001
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpDocumentos)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1253, 454)
        Me.TabControl1.TabIndex = 0
        '
        'tpDocumentos
        '
        Me.tpDocumentos.Location = New System.Drawing.Point(4, 25)
        Me.tpDocumentos.Name = "tpDocumentos"
        Me.tpDocumentos.Padding = New System.Windows.Forms.Padding(3)
        Me.tpDocumentos.Size = New System.Drawing.Size(1245, 425)
        Me.tpDocumentos.TabIndex = 0
        Me.tpDocumentos.Text = "Documentos"
        Me.tpDocumentos.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtObservaciones)
        Me.Panel2.Controls.Add(Me.lblObservaciones)
        Me.Panel2.Controls.Add(Me.lblResponsableID)
        Me.Panel2.Controls.Add(Me.lblUtilizacion)
        Me.Panel2.Controls.Add(Me.cboResponsable)
        Me.Panel2.Controls.Add(Me.lblCodificacion)
        Me.Panel2.Controls.Add(Me.txtDescripcion)
        Me.Panel2.Controls.Add(Me.butVerResponsableID)
        Me.Panel2.Controls.Add(Me.txtCodificacion)
        Me.Panel2.Controls.Add(Me.lblDescripcion)
        Me.Panel2.Controls.Add(Me.butAddResponsableID)
        Me.Panel2.Controls.Add(Me.txtUtilizacion)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1253, 161)
        Me.Panel2.TabIndex = 1000000002
        '
        'frmEntArticulosTipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1253, 640)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(532, 250)
        Me.Name = "frmEntArticulosTipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ArticulosTipos"
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboResponsable As System.Windows.Forms.ComboBox
    Private WithEvents butVerResponsableID As System.Windows.Forms.Button
    Private WithEvents butAddResponsableID As System.Windows.Forms.Button
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtUtilizacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCodificacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblResponsableID As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblUtilizacion As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents lblCodificacion As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpDocumentos As System.Windows.Forms.TabPage
    Private WithEvents Panel2 As System.Windows.Forms.Panel
End Class
