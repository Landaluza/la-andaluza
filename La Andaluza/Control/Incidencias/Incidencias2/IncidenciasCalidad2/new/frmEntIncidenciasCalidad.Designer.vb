<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntIncidenciasCalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntIncidenciasCalidad))
        Me.txtLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRutaDocumento = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRutaDocumento = New System.Windows.Forms.Button()
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedorID = New System.Windows.Forms.Button()
        Me.butAddProveedorID = New System.Windows.Forms.Button()
        Me.cboTipoMaterial = New System.Windows.Forms.ComboBox()
        Me.butVerTipoMaterialID = New System.Windows.Forms.Button()
        Me.butAddTipoMaterialID = New System.Windows.Forms.Button()
        Me.lblLote = New System.Windows.Forms.Label()
        Me.lblRutaDocumento = New System.Windows.Forms.Label()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblTipoMaterialID = New System.Windows.Forms.Label()

        Me.panContenido = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.panContenido.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtLote
        '
        Me.txtLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtLote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLote.EsUnicoCampo = ""
        Me.txtLote.EsUnicoCampoID = ""
        Me.txtLote.EsUnicoID = 0
        Me.txtLote.EsUnicoTabla = ""
        Me.txtLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLote.Location = New System.Drawing.Point(6, 16)
        Me.txtLote.MaxLength = 20
        Me.txtLote.Minimo = 0
        Me.txtLote.Modificado = False
        Me.txtLote.Name = "txtLote"
        Me.txtLote.Numerico_EsNumerico = False
        Me.txtLote.Numerico_NumeroDoublees = 0
        Me.txtLote.Numerico_SeparadorMiles = False
        Me.txtLote.Obligatorio = False
        Me.txtLote.ParametroID = 0
        Me.txtLote.Size = New System.Drawing.Size(280, 21)
        Me.txtLote.TabIndex = 1
        Me.txtLote.ValorMaximo = 0.0R
        Me.txtLote.ValorMinimo = 0.0R
        '
        'txtRutaDocumento
        '
        Me.txtRutaDocumento.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaDocumento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutaDocumento.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaDocumento.Enabled = False
        Me.txtRutaDocumento.EsUnicoCampo = ""
        Me.txtRutaDocumento.EsUnicoCampoID = ""
        Me.txtRutaDocumento.EsUnicoID = 0
        Me.txtRutaDocumento.EsUnicoTabla = ""
        Me.txtRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaDocumento.Location = New System.Drawing.Point(6, 58)
        Me.txtRutaDocumento.MaxLength = 250
        Me.txtRutaDocumento.Minimo = 0
        Me.txtRutaDocumento.Modificado = False
        Me.txtRutaDocumento.Name = "txtRutaDocumento"
        Me.txtRutaDocumento.Numerico_EsNumerico = False
        Me.txtRutaDocumento.Numerico_NumeroDoublees = 0
        Me.txtRutaDocumento.Numerico_SeparadorMiles = False
        Me.txtRutaDocumento.Obligatorio = False
        Me.txtRutaDocumento.ParametroID = 0
        Me.txtRutaDocumento.Size = New System.Drawing.Size(280, 21)
        Me.txtRutaDocumento.TabIndex = 3
        Me.txtRutaDocumento.ValorMaximo = 0.0R
        Me.txtRutaDocumento.ValorMinimo = 0.0R
        '
        'butRutaDocumento
        '
        Me.butRutaDocumento.FlatAppearance.BorderSize = 0
        Me.butRutaDocumento.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaDocumento.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaDocumento.Location = New System.Drawing.Point(288, 58)
        Me.butRutaDocumento.Name = "butRutaDocumento"
        Me.butRutaDocumento.Size = New System.Drawing.Size(20, 20)
        Me.butRutaDocumento.TabIndex = 4
        Me.butRutaDocumento.TabStop = False
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(6, 144)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(254, 23)
        Me.cboProveedor.TabIndex = 10
        '
        'butVerProveedorID
        '
        Me.butVerProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProveedorID.FlatAppearance.BorderSize = 0
        Me.butVerProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedorID.Location = New System.Drawing.Point(261, 147)
        Me.butVerProveedorID.Name = "butVerProveedorID"
        Me.butVerProveedorID.Size = New System.Drawing.Size(20, 20)
        Me.butVerProveedorID.TabIndex = 11
        Me.butVerProveedorID.TabStop = False
        '
        'butAddProveedorID
        '
        Me.butAddProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProveedorID.FlatAppearance.BorderSize = 0
        Me.butAddProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedorID.Location = New System.Drawing.Point(285, 147)
        Me.butAddProveedorID.Name = "butAddProveedorID"
        Me.butAddProveedorID.Size = New System.Drawing.Size(20, 20)
        Me.butAddProveedorID.TabIndex = 12
        Me.butAddProveedorID.TabStop = False
        '
        'cboTipoMaterial
        '
        Me.cboTipoMaterial.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoMaterial.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoMaterial.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoMaterial.Location = New System.Drawing.Point(6, 98)
        Me.cboTipoMaterial.Name = "cboTipoMaterial"
        Me.cboTipoMaterial.Size = New System.Drawing.Size(254, 23)
        Me.cboTipoMaterial.TabIndex = 6
        '
        'butVerTipoMaterialID
        '
        Me.butVerTipoMaterialID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoMaterialID.FlatAppearance.BorderSize = 0
        Me.butVerTipoMaterialID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTipoMaterialID.Location = New System.Drawing.Point(261, 98)
        Me.butVerTipoMaterialID.Name = "butVerTipoMaterialID"
        Me.butVerTipoMaterialID.Size = New System.Drawing.Size(20, 20)
        Me.butVerTipoMaterialID.TabIndex = 7
        Me.butVerTipoMaterialID.TabStop = False
        '
        'butAddTipoMaterialID
        '
        Me.butAddTipoMaterialID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoMaterialID.FlatAppearance.BorderSize = 0
        Me.butAddTipoMaterialID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoMaterialID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoMaterialID.Location = New System.Drawing.Point(284, 98)
        Me.butAddTipoMaterialID.Name = "butAddTipoMaterialID"
        Me.butAddTipoMaterialID.Size = New System.Drawing.Size(20, 20)
        Me.butAddTipoMaterialID.TabIndex = 8
        Me.butAddTipoMaterialID.TabStop = False
        '
        'lblLote
        '
        Me.lblLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLote.Location = New System.Drawing.Point(4, 0)
        Me.lblLote.Name = "lblLote"
        Me.lblLote.Size = New System.Drawing.Size(93, 13)
        Me.lblLote.TabIndex = 0
        Me.lblLote.Text = "Lote"
        Me.lblLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaDocumento
        '
        Me.lblRutaDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRutaDocumento.Location = New System.Drawing.Point(4, 41)
        Me.lblRutaDocumento.Name = "lblRutaDocumento"
        Me.lblRutaDocumento.Size = New System.Drawing.Size(93, 13)
        Me.lblRutaDocumento.TabIndex = 2
        Me.lblRutaDocumento.Text = "Ruta documento"
        Me.lblRutaDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblProveedorID.Location = New System.Drawing.Point(4, 128)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(93, 13)
        Me.lblProveedorID.TabIndex = 9
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoMaterialID
        '
        Me.lblTipoMaterialID.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoMaterialID.Location = New System.Drawing.Point(4, 83)
        Me.lblTipoMaterialID.Name = "lblTipoMaterialID"
        Me.lblTipoMaterialID.Size = New System.Drawing.Size(93, 13)
        Me.lblTipoMaterialID.TabIndex = 5
        Me.lblTipoMaterialID.Text = "Tipo material"
        Me.lblTipoMaterialID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'panContenido
        '
        Me.panContenido.Controls.Add(Me.cboTipoMaterial)
        Me.panContenido.Controls.Add(Me.lblLote)
        Me.panContenido.Controls.Add(Me.butVerTipoMaterialID)
        Me.panContenido.Controls.Add(Me.txtLote)
        Me.panContenido.Controls.Add(Me.lblRutaDocumento)
        Me.panContenido.Controls.Add(Me.butAddProveedorID)
        Me.panContenido.Controls.Add(Me.lblTipoMaterialID)
        Me.panContenido.Controls.Add(Me.txtRutaDocumento)
        Me.panContenido.Controls.Add(Me.butAddTipoMaterialID)
        Me.panContenido.Controls.Add(Me.butVerProveedorID)
        Me.panContenido.Controls.Add(Me.butRutaDocumento)
        Me.panContenido.Controls.Add(Me.cboProveedor)
        Me.panContenido.Controls.Add(Me.lblProveedorID)
        Me.panContenido.Location = New System.Drawing.Point(0, 28)
        Me.panContenido.Name = "panContenido"
        Me.panContenido.Size = New System.Drawing.Size(312, 186)
        Me.panContenido.TabIndex = 0
        '
        'frmEntIncidenciasCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(414, 230)
        Me.Controls.Add(Me.panContenido)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntIncidenciasCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "IncidenciasCalidad"
        Me.Controls.SetChildIndex(Me.panContenido, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.panContenido.ResumeLayout(False)
        Me.panContenido.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtLote As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRutaDocumento As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRutaDocumento As System.Windows.Forms.Button
    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerProveedorID As System.Windows.Forms.Button
    Private WithEvents butAddProveedorID As System.Windows.Forms.Button
    Private WithEvents cboTipoMaterial As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents butAddTipoMaterialID As System.Windows.Forms.Button
    Private WithEvents lblLote As System.Windows.Forms.Label
    Private WithEvents lblRutaDocumento As System.Windows.Forms.Label
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblTipoMaterialID As System.Windows.Forms.Label

    Private WithEvents panContenido As System.Windows.Forms.Panel
End Class
