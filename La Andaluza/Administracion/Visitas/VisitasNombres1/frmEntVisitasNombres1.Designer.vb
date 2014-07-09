<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntVisitasNombres1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntVisitasNombres1))
        Me.txtVisitaNombreID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboEmpresaID = New System.Windows.Forms.ComboBox()
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDNI = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboVisitaTipoID = New System.Windows.Forms.ComboBox()
        Me.butVerVisitaTipoID = New System.Windows.Forms.Button()
        Me.butAddVisitaTipoID = New System.Windows.Forms.Button()
        Me.lblVisitaNombreID = New System.Windows.Forms.Label()
        Me.lblEmpresaID = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblDNI = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblVisitaTipoID = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        '
        'txtVisitaNombreID
        '
        Me.txtVisitaNombreID.BackColor = System.Drawing.SystemColors.Window
        Me.txtVisitaNombreID.EsUnicoCampo = ""
        Me.txtVisitaNombreID.EsUnicoCampoID = ""
        Me.txtVisitaNombreID.EsUnicoID = 0
        Me.txtVisitaNombreID.EsUnicoTabla = ""
        Me.txtVisitaNombreID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVisitaNombreID.Location = New System.Drawing.Point(115, 3)
        Me.txtVisitaNombreID.MaxLength = 9
        Me.txtVisitaNombreID.Minimo = 0
        Me.txtVisitaNombreID.Modificado = False
        Me.txtVisitaNombreID.Name = "txtVisitaNombreID"
        Me.txtVisitaNombreID.Numerico_EsNumerico = False
        Me.txtVisitaNombreID.Numerico_NumeroDoublees = 0
        Me.txtVisitaNombreID.Numerico_SeparadorMiles = False
        Me.txtVisitaNombreID.Obligatorio = True
        Me.txtVisitaNombreID.ParametroID = 0
        Me.txtVisitaNombreID.Size = New System.Drawing.Size(56, 21)
        Me.txtVisitaNombreID.TabIndex = 0
        Me.txtVisitaNombreID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVisitaNombreID.ValorMaximo = 0.0R
        Me.txtVisitaNombreID.ValorMinimo = 0.0R
        Me.txtVisitaNombreID.Visible = False
        '
        'cboEmpresaID
        '
        Me.cboEmpresaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboEmpresaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.tlpMiddle.SetColumnSpan(Me.cboEmpresaID, 4)
        Me.cboEmpresaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboEmpresaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEmpresaID.Location = New System.Drawing.Point(115, 59)
        Me.cboEmpresaID.Name = "cboEmpresaID"
        Me.cboEmpresaID.Size = New System.Drawing.Size(523, 23)
        Me.cboEmpresaID.TabIndex = 1
        Me.cboEmpresaID.Visible = False
        '
        'txtNombre
        '
        Me.txtNombre.BackColor = System.Drawing.SystemColors.Window
        Me.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNombre.EsUnicoCampo = ""
        Me.txtNombre.EsUnicoCampoID = ""
        Me.txtNombre.EsUnicoID = 0
        Me.txtNombre.EsUnicoTabla = ""
        Me.txtNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.Location = New System.Drawing.Point(115, 88)
        Me.txtNombre.MaxLength = 160
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(200, 21)
        Me.txtNombre.TabIndex = 2
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'txtDNI
        '
        Me.txtDNI.BackColor = System.Drawing.SystemColors.Window
        Me.txtDNI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDNI.EsUnicoCampo = ""
        Me.txtDNI.EsUnicoCampoID = ""
        Me.txtDNI.EsUnicoID = 0
        Me.txtDNI.EsUnicoTabla = ""
        Me.txtDNI.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDNI.Location = New System.Drawing.Point(115, 115)
        Me.txtDNI.MaxLength = 32
        Me.txtDNI.Minimo = 0
        Me.txtDNI.Modificado = False
        Me.txtDNI.Name = "txtDNI"
        Me.txtDNI.Numerico_EsNumerico = False
        Me.txtDNI.Numerico_NumeroDoublees = 0
        Me.txtDNI.Numerico_SeparadorMiles = False
        Me.txtDNI.Obligatorio = False
        Me.txtDNI.ParametroID = 0
        Me.txtDNI.Size = New System.Drawing.Size(200, 21)
        Me.txtDNI.TabIndex = 3
        Me.txtDNI.ValorMaximo = 0.0R
        Me.txtDNI.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tlpMiddle.SetColumnSpan(Me.txtObservaciones, 4)
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(115, 142)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(523, 21)
        Me.txtObservaciones.TabIndex = 4
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'cboVisitaTipoID
        '
        Me.cboVisitaTipoID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVisitaTipoID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVisitaTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVisitaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVisitaTipoID.Location = New System.Drawing.Point(115, 30)
        Me.cboVisitaTipoID.Name = "cboVisitaTipoID"
        Me.cboVisitaTipoID.Size = New System.Drawing.Size(200, 23)
        Me.cboVisitaTipoID.TabIndex = 5
        '
        'butVerVisitaTipoID
        '
        Me.butVerVisitaTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerVisitaTipoID.FlatAppearance.BorderSize = 0
        Me.butVerVisitaTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVisitaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVisitaTipoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVisitaTipoID.Location = New System.Drawing.Point(321, 30)
        Me.butVerVisitaTipoID.Name = "butVerVisitaTipoID"
        Me.butVerVisitaTipoID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVisitaTipoID.TabIndex = 6
        Me.butVerVisitaTipoID.TabStop = False
        '
        'butAddVisitaTipoID
        '
        Me.butAddVisitaTipoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddVisitaTipoID.FlatAppearance.BorderSize = 0
        Me.butAddVisitaTipoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddVisitaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddVisitaTipoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddVisitaTipoID.Location = New System.Drawing.Point(347, 30)
        Me.butAddVisitaTipoID.Name = "butAddVisitaTipoID"
        Me.butAddVisitaTipoID.Size = New System.Drawing.Size(20, 20)
        Me.butAddVisitaTipoID.TabIndex = 7
        Me.butAddVisitaTipoID.TabStop = False
        '
        'lblVisitaNombreID
        '
        Me.lblVisitaNombreID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblVisitaNombreID.Location = New System.Drawing.Point(22, 0)
        Me.lblVisitaNombreID.Name = "lblVisitaNombreID"
        Me.lblVisitaNombreID.Size = New System.Drawing.Size(87, 21)
        Me.lblVisitaNombreID.TabIndex = 0
        Me.lblVisitaNombreID.Text = "VisitaNombreID"
        Me.lblVisitaNombreID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblVisitaNombreID.Visible = False
        '
        'lblEmpresaID
        '
        Me.lblEmpresaID.Location = New System.Drawing.Point(22, 56)
        Me.lblEmpresaID.Name = "lblEmpresaID"
        Me.lblEmpresaID.Size = New System.Drawing.Size(87, 21)
        Me.lblEmpresaID.TabIndex = 1
        Me.lblEmpresaID.Text = "Empresa"
        Me.lblEmpresaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEmpresaID.Visible = False
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(22, 85)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(87, 21)
        Me.lblNombre.TabIndex = 2
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDNI
        '
        Me.lblDNI.Location = New System.Drawing.Point(22, 112)
        Me.lblDNI.Name = "lblDNI"
        Me.lblDNI.Size = New System.Drawing.Size(87, 21)
        Me.lblDNI.TabIndex = 3
        Me.lblDNI.Text = "DNI"
        Me.lblDNI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(22, 139)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(87, 20)
        Me.lblObservaciones.TabIndex = 4
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVisitaTipoID
        '
        Me.lblVisitaTipoID.Location = New System.Drawing.Point(22, 27)
        Me.lblVisitaTipoID.Name = "lblVisitaTipoID"
        Me.lblVisitaTipoID.Size = New System.Drawing.Size(87, 21)
        Me.lblVisitaTipoID.TabIndex = 5
        Me.lblVisitaTipoID.Text = "Tipo"
        Me.lblVisitaTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 19.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpMiddle.Controls.Add(Me.lblVisitaNombreID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtVisitaNombreID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.cboEmpresaID, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblEmpresaID, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.txtDNI, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.txtNombre, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblDNI, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.lblNombre, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.cboVisitaTipoID, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerVisitaTipoID, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddVisitaTipoID, 4, 1)
        Me.tlpMiddle.Controls.Add(Me.lblVisitaTipoID, 1, 1)
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
        Me.tlpMiddle.Size = New System.Drawing.Size(666, 166)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'tlpTop
        '




        '
        'frmEntVisitasNombres1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(678, 216)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(449, 248)
        Me.Name = "frmEntVisitasNombres1"
        Me.Text = "VisitasNombres1"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtVisitaNombreID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboEmpresaID As System.Windows.Forms.ComboBox
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDNI As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboVisitaTipoID As System.Windows.Forms.ComboBox
   Private WithEvents butVerVisitaTipoID As System.Windows.Forms.Button
   Private WithEvents butAddVisitaTipoID As System.Windows.Forms.Button
   Private WithEvents lblVisitaNombreID As System.Windows.Forms.Label
   Private WithEvents lblEmpresaID As System.Windows.Forms.Label
   Private WithEvents lblNombre As System.Windows.Forms.Label
   Private WithEvents lblDNI As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblVisitaTipoID As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
