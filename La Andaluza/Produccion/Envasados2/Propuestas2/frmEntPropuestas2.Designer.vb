<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPropuestas2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPropuestas2))

        Me.lblPropuestaID = New System.Windows.Forms.Label()
        Me.txtPropuestaID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.cboFormatoEnvasadoID = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblPropuestaTipoMejoraID = New System.Windows.Forms.Label()
        Me.cboPropuestaTipoMejoraID = New System.Windows.Forms.ComboBox()
        Me.lblPropuestaUrgenciaID = New System.Windows.Forms.Label()
        Me.cboPropuestaUrgenciaID = New System.Windows.Forms.ComboBox()
        Me.lblPersonalID = New System.Windows.Forms.Label()
        Me.cboPersonalID = New System.Windows.Forms.ComboBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'tlpTop
        '




        '
        'lblPropuestaID
        '
        Me.lblPropuestaID.Location = New System.Drawing.Point(15, 335)
        Me.lblPropuestaID.Name = "lblPropuestaID"
        Me.lblPropuestaID.Size = New System.Drawing.Size(128, 21)
        Me.lblPropuestaID.TabIndex = 1000000003
        Me.lblPropuestaID.Text = "PropuestaID"
        Me.lblPropuestaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblPropuestaID.Visible = False
        '
        'txtPropuestaID
        '
        Me.txtPropuestaID.BackColor = System.Drawing.SystemColors.Window
        Me.txtPropuestaID.Enabled = False
        Me.txtPropuestaID.EsUnicoCampo = ""
        Me.txtPropuestaID.EsUnicoCampoID = ""
        Me.txtPropuestaID.EsUnicoID = 0
        Me.txtPropuestaID.EsUnicoTabla = ""
        Me.txtPropuestaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPropuestaID.Location = New System.Drawing.Point(162, 335)
        Me.txtPropuestaID.MaxLength = 9
        Me.txtPropuestaID.Minimo = 0
        Me.txtPropuestaID.Modificado = False
        Me.txtPropuestaID.Name = "txtPropuestaID"
        Me.txtPropuestaID.Numerico_EsNumerico = False
        Me.txtPropuestaID.Numerico_NumeroDoublees = 0
        Me.txtPropuestaID.Numerico_SeparadorMiles = False
        Me.txtPropuestaID.Obligatorio = True
        Me.txtPropuestaID.ParametroID = 0
        Me.txtPropuestaID.Size = New System.Drawing.Size(56, 21)
        Me.txtPropuestaID.TabIndex = 1000000002
        Me.txtPropuestaID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPropuestaID.ValorMaximo = 0.0R
        Me.txtPropuestaID.ValorMinimo = 0.0R
        Me.txtPropuestaID.Visible = False
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(15, 307)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(128, 21)
        Me.lblFormatoEnvasadoID.TabIndex = 1000000005
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasado"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Visible = False
        '
        'cboFormatoEnvasadoID
        '
        Me.cboFormatoEnvasadoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboFormatoEnvasadoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboFormatoEnvasadoID.Enabled = False
        Me.cboFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboFormatoEnvasadoID.Location = New System.Drawing.Point(162, 306)
        Me.cboFormatoEnvasadoID.Name = "cboFormatoEnvasadoID"
        Me.cboFormatoEnvasadoID.Size = New System.Drawing.Size(150, 23)
        Me.cboFormatoEnvasadoID.TabIndex = 1000000004
        Me.cboFormatoEnvasadoID.Visible = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(15, 42)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(89, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(128, 42)
        Me.txtDescripcion.MaxLength = 500
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(302, 82)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'lblPropuestaTipoMejoraID
        '
        Me.lblPropuestaTipoMejoraID.Location = New System.Drawing.Point(18, 132)
        Me.lblPropuestaTipoMejoraID.Name = "lblPropuestaTipoMejoraID"
        Me.lblPropuestaTipoMejoraID.Size = New System.Drawing.Size(86, 21)
        Me.lblPropuestaTipoMejoraID.TabIndex = 3
        Me.lblPropuestaTipoMejoraID.Text = "Tipo Mejora"
        Me.lblPropuestaTipoMejoraID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPropuestaTipoMejoraID
        '
        Me.cboPropuestaTipoMejoraID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPropuestaTipoMejoraID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPropuestaTipoMejoraID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPropuestaTipoMejoraID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPropuestaTipoMejoraID.Location = New System.Drawing.Point(128, 130)
        Me.cboPropuestaTipoMejoraID.Name = "cboPropuestaTipoMejoraID"
        Me.cboPropuestaTipoMejoraID.Size = New System.Drawing.Size(302, 23)
        Me.cboPropuestaTipoMejoraID.TabIndex = 4
        '
        'lblPropuestaUrgenciaID
        '
        Me.lblPropuestaUrgenciaID.Location = New System.Drawing.Point(18, 161)
        Me.lblPropuestaUrgenciaID.Name = "lblPropuestaUrgenciaID"
        Me.lblPropuestaUrgenciaID.Size = New System.Drawing.Size(86, 21)
        Me.lblPropuestaUrgenciaID.TabIndex = 5
        Me.lblPropuestaUrgenciaID.Text = "Urgencia"
        Me.lblPropuestaUrgenciaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPropuestaUrgenciaID
        '
        Me.cboPropuestaUrgenciaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPropuestaUrgenciaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPropuestaUrgenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPropuestaUrgenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPropuestaUrgenciaID.Location = New System.Drawing.Point(128, 159)
        Me.cboPropuestaUrgenciaID.Name = "cboPropuestaUrgenciaID"
        Me.cboPropuestaUrgenciaID.Size = New System.Drawing.Size(302, 23)
        Me.cboPropuestaUrgenciaID.TabIndex = 6
        '
        'lblPersonalID
        '
        Me.lblPersonalID.Location = New System.Drawing.Point(18, 190)
        Me.lblPersonalID.Name = "lblPersonalID"
        Me.lblPersonalID.Size = New System.Drawing.Size(86, 21)
        Me.lblPersonalID.TabIndex = 7
        Me.lblPersonalID.Text = "Personal"
        Me.lblPersonalID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboPersonalID
        '
        Me.cboPersonalID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboPersonalID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboPersonalID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboPersonalID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboPersonalID.Location = New System.Drawing.Point(128, 188)
        Me.cboPersonalID.Name = "cboPersonalID"
        Me.cboPersonalID.Size = New System.Drawing.Size(302, 23)
        Me.cboPersonalID.TabIndex = 8
        '
        'frmEntPropuestas2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(476, 241)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblPropuestaTipoMejoraID)
        Me.Controls.Add(Me.cboPropuestaTipoMejoraID)
        Me.Controls.Add(Me.lblPropuestaUrgenciaID)
        Me.Controls.Add(Me.cboPropuestaUrgenciaID)
        Me.Controls.Add(Me.lblPersonalID)
        Me.Controls.Add(Me.cboPersonalID)
        Me.Controls.Add(Me.lblFormatoEnvasadoID)
        Me.Controls.Add(Me.cboFormatoEnvasadoID)
        Me.Controls.Add(Me.lblPropuestaID)
        Me.Controls.Add(Me.txtPropuestaID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPropuestas2"
        Me.Text = "Propuestas2"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.txtPropuestaID, 0)
        Me.Controls.SetChildIndex(Me.lblPropuestaID, 0)
        Me.Controls.SetChildIndex(Me.cboFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.lblFormatoEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.cboPersonalID, 0)
        Me.Controls.SetChildIndex(Me.lblPersonalID, 0)
        Me.Controls.SetChildIndex(Me.cboPropuestaUrgenciaID, 0)
        Me.Controls.SetChildIndex(Me.lblPropuestaUrgenciaID, 0)
        Me.Controls.SetChildIndex(Me.cboPropuestaTipoMejoraID, 0)
        Me.Controls.SetChildIndex(Me.lblPropuestaTipoMejoraID, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents lblPropuestaID As System.Windows.Forms.Label
    Private WithEvents txtPropuestaID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents cboFormatoEnvasadoID As System.Windows.Forms.ComboBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblPropuestaTipoMejoraID As System.Windows.Forms.Label
    Private WithEvents cboPropuestaTipoMejoraID As System.Windows.Forms.ComboBox
    Private WithEvents lblPropuestaUrgenciaID As System.Windows.Forms.Label
    Private WithEvents cboPropuestaUrgenciaID As System.Windows.Forms.ComboBox
    Private WithEvents lblPersonalID As System.Windows.Forms.Label
    Private WithEvents cboPersonalID As System.Windows.Forms.ComboBox
End Class
