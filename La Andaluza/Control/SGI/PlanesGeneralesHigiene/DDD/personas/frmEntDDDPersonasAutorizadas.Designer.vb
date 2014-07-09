<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntDDDPersonasAutorizadas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDDDPersonasAutorizadas))
        Me.cboProveedor = New System.Windows.Forms.ComboBox()
        Me.butVerProveedorID = New System.Windows.Forms.Button()
        Me.butAddProveedorID = New System.Windows.Forms.Button()
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRutaCarnetManipulador = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRutaCarnetManipulador = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblProveedorID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblRutaCarnetManipulador = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboProveedor
        '
        Me.cboProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProveedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProveedor.Location = New System.Drawing.Point(146, 40)
        Me.cboProveedor.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProveedor.Name = "cboProveedor"
        Me.cboProveedor.Size = New System.Drawing.Size(375, 23)
        Me.cboProveedor.TabIndex = 0
        '
        'butVerProveedorID
        '
        Me.butVerProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProveedorID.FlatAppearance.BorderSize = 0
        Me.butVerProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProveedorID.Location = New System.Drawing.Point(525, 40)
        Me.butVerProveedorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProveedorID.Name = "butVerProveedorID"
        Me.butVerProveedorID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProveedorID.TabIndex = 1
        Me.butVerProveedorID.TabStop = False
        '
        'butAddProveedorID
        '
        Me.butAddProveedorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProveedorID.FlatAppearance.BorderSize = 0
        Me.butAddProveedorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProveedorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProveedorID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProveedorID.Location = New System.Drawing.Point(548, 40)
        Me.butAddProveedorID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProveedorID.Name = "butAddProveedorID"
        Me.butAddProveedorID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProveedorID.TabIndex = 2
        Me.butAddProveedorID.TabStop = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtNombre.EsUnicoCampo = ""
        Me.txtNombre.EsUnicoCampoID = ""
        Me.txtNombre.EsUnicoID = 0
        Me.txtNombre.EsUnicoTabla = ""
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(146, 70)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.MaxLength = 160
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(398, 14)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'txtRutaCarnetManipulador
        '
        Me.txtRutaCarnetManipulador.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaCarnetManipulador.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtRutaCarnetManipulador.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaCarnetManipulador.EsUnicoCampo = ""
        Me.txtRutaCarnetManipulador.EsUnicoCampoID = ""
        Me.txtRutaCarnetManipulador.EsUnicoID = 0
        Me.txtRutaCarnetManipulador.EsUnicoTabla = ""
        Me.txtRutaCarnetManipulador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaCarnetManipulador.Location = New System.Drawing.Point(146, 98)
        Me.txtRutaCarnetManipulador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaCarnetManipulador.MaxLength = 250
        Me.txtRutaCarnetManipulador.Minimo = 0
        Me.txtRutaCarnetManipulador.Modificado = False
        Me.txtRutaCarnetManipulador.Name = "txtRutaCarnetManipulador"
        Me.txtRutaCarnetManipulador.Numerico_EsNumerico = False
        Me.txtRutaCarnetManipulador.Numerico_NumeroDoublees = 0
        Me.txtRutaCarnetManipulador.Numerico_SeparadorMiles = False
        Me.txtRutaCarnetManipulador.Obligatorio = False
        Me.txtRutaCarnetManipulador.ParametroID = 0
        Me.txtRutaCarnetManipulador.Size = New System.Drawing.Size(398, 14)
        Me.txtRutaCarnetManipulador.TabIndex = 2
        Me.txtRutaCarnetManipulador.ValorMaximo = 0.0R
        Me.txtRutaCarnetManipulador.ValorMinimo = 0.0R
        '
        'butRutaCarnetManipulador
        '
        Me.butRutaCarnetManipulador.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRutaCarnetManipulador.FlatAppearance.BorderSize = 0
        Me.butRutaCarnetManipulador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaCarnetManipulador.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaCarnetManipulador.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaCarnetManipulador.Location = New System.Drawing.Point(548, 94)
        Me.butRutaCarnetManipulador.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaCarnetManipulador.Name = "butRutaCarnetManipulador"
        Me.butRutaCarnetManipulador.Size = New System.Drawing.Size(18, 23)
        Me.butRutaCarnetManipulador.TabIndex = 5
        Me.butRutaCarnetManipulador.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(146, 126)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(398, 14)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblProveedorID
        '
        Me.lblProveedorID.Location = New System.Drawing.Point(16, 36)
        Me.lblProveedorID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProveedorID.Name = "lblProveedorID"
        Me.lblProveedorID.Size = New System.Drawing.Size(117, 30)
        Me.lblProveedorID.TabIndex = 0
        Me.lblProveedorID.Text = "Proveedor"
        Me.lblProveedorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(16, 66)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(117, 28)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaCarnetManipulador
        '
        Me.lblRutaCarnetManipulador.Location = New System.Drawing.Point(16, 94)
        Me.lblRutaCarnetManipulador.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaCarnetManipulador.Name = "lblRutaCarnetManipulador"
        Me.lblRutaCarnetManipulador.Size = New System.Drawing.Size(123, 28)
        Me.lblRutaCarnetManipulador.TabIndex = 4
        Me.lblRutaCarnetManipulador.Text = "RutaCarnetManipulador"
        Me.lblRutaCarnetManipulador.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(16, 122)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(117, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntDDDPersonasAutorizadas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(574, 157)
        Me.Controls.Add(Me.lblProveedorID)
        Me.Controls.Add(Me.cboProveedor)
        Me.Controls.Add(Me.butVerProveedorID)
        Me.Controls.Add(Me.butAddProveedorID)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblRutaCarnetManipulador)
        Me.Controls.Add(Me.butRutaCarnetManipulador)
        Me.Controls.Add(Me.txtRutaCarnetManipulador)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(444, 184)
        Me.Name = "frmEntDDDPersonasAutorizadas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DDDPersonasAutorizadas"
        Me.Controls.SetChildIndex(Me.txtRutaCarnetManipulador, 0)
        Me.Controls.SetChildIndex(Me.butRutaCarnetManipulador, 0)
        Me.Controls.SetChildIndex(Me.lblRutaCarnetManipulador, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.butAddProveedorID, 0)
        Me.Controls.SetChildIndex(Me.butVerProveedorID, 0)
        Me.Controls.SetChildIndex(Me.cboProveedor, 0)
        Me.Controls.SetChildIndex(Me.lblProveedorID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboProveedor As System.Windows.Forms.ComboBox
    Private WithEvents butVerProveedorID As System.Windows.Forms.Button
    Private WithEvents butAddProveedorID As System.Windows.Forms.Button
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRutaCarnetManipulador As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRutaCarnetManipulador As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblProveedorID As System.Windows.Forms.Label
    Private WithEvents lblNombre As System.Windows.Forms.Label
    Private WithEvents lblRutaCarnetManipulador As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
