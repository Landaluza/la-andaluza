<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposProductos))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbreviatura = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbEnologico = New System.Windows.Forms.CheckBox()
        Me.cboMedida = New System.Windows.Forms.ComboBox()
        Me.butVerMedidaID = New System.Windows.Forms.Button()
        Me.butAddMedidaID = New System.Windows.Forms.Button()
        Me.cboid_palet_no_conforme = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.lblEnologico = New System.Windows.Forms.Label()
        Me.lblMedidaID = New System.Windows.Forms.Label()
        Me.lblid_palet_no_conforme = New System.Windows.Forms.Label()

        Me.chbNC = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(151, 35)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 14)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.BackColor = System.Drawing.SystemColors.Window
        Me.txtAbreviatura.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAbreviatura.EsUnicoCampo = ""
        Me.txtAbreviatura.EsUnicoCampoID = ""
        Me.txtAbreviatura.EsUnicoID = 0
        Me.txtAbreviatura.EsUnicoTabla = ""
        Me.txtAbreviatura.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAbreviatura.Location = New System.Drawing.Point(151, 63)
        Me.txtAbreviatura.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtAbreviatura.MaxLength = 3
        Me.txtAbreviatura.Minimo = 0
        Me.txtAbreviatura.Modificado = False
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Numerico_EsNumerico = False
        Me.txtAbreviatura.Numerico_NumeroDoublees = 0
        Me.txtAbreviatura.Numerico_SeparadorMiles = False
        Me.txtAbreviatura.Obligatorio = False
        Me.txtAbreviatura.ParametroID = 0
        Me.txtAbreviatura.Size = New System.Drawing.Size(181, 14)
        Me.txtAbreviatura.TabIndex = 1
        Me.txtAbreviatura.ValorMaximo = 0.0R
        Me.txtAbreviatura.ValorMinimo = 0.0R
        '
        'chbEnologico
        '
        Me.chbEnologico.BackColor = System.Drawing.SystemColors.Control
        Me.chbEnologico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbEnologico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbEnologico.Location = New System.Drawing.Point(151, 92)
        Me.chbEnologico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbEnologico.Name = "chbEnologico"
        Me.chbEnologico.Size = New System.Drawing.Size(180, 20)
        Me.chbEnologico.TabIndex = 2
        Me.chbEnologico.UseVisualStyleBackColor = False
        '
        'cboMedida
        '
        Me.cboMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMedida.Location = New System.Drawing.Point(151, 117)
        Me.cboMedida.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMedida.Name = "cboMedida"
        Me.cboMedida.Size = New System.Drawing.Size(181, 23)
        Me.cboMedida.TabIndex = 3
        '
        'butVerMedidaID
        '
        Me.butVerMedidaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerMedidaID.FlatAppearance.BorderSize = 0
        Me.butVerMedidaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerMedidaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerMedidaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerMedidaID.Location = New System.Drawing.Point(335, 117)
        Me.butVerMedidaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerMedidaID.Name = "butVerMedidaID"
        Me.butVerMedidaID.Size = New System.Drawing.Size(18, 21)
        Me.butVerMedidaID.TabIndex = 4
        Me.butVerMedidaID.TabStop = False
        '
        'butAddMedidaID
        '
        Me.butAddMedidaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddMedidaID.FlatAppearance.BorderSize = 0
        Me.butAddMedidaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMedidaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMedidaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMedidaID.Location = New System.Drawing.Point(358, 117)
        Me.butAddMedidaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddMedidaID.Name = "butAddMedidaID"
        Me.butAddMedidaID.Size = New System.Drawing.Size(18, 21)
        Me.butAddMedidaID.TabIndex = 5
        Me.butAddMedidaID.TabStop = False
        '
        'cboid_palet_no_conforme
        '
        Me.cboid_palet_no_conforme.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_palet_no_conforme.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_palet_no_conforme.Enabled = False
        Me.cboid_palet_no_conforme.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_palet_no_conforme.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_palet_no_conforme.Location = New System.Drawing.Point(151, 147)
        Me.cboid_palet_no_conforme.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_palet_no_conforme.Name = "cboid_palet_no_conforme"
        Me.cboid_palet_no_conforme.Size = New System.Drawing.Size(181, 23)
        Me.cboid_palet_no_conforme.TabIndex = 4
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(28, 32)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(114, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.Location = New System.Drawing.Point(28, 61)
        Me.lblAbreviatura.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(114, 28)
        Me.lblAbreviatura.TabIndex = 1
        Me.lblAbreviatura.Text = "Abreviatura"
        Me.lblAbreviatura.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEnologico
        '
        Me.lblEnologico.Location = New System.Drawing.Point(28, 89)
        Me.lblEnologico.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEnologico.Name = "lblEnologico"
        Me.lblEnologico.Size = New System.Drawing.Size(114, 25)
        Me.lblEnologico.TabIndex = 2
        Me.lblEnologico.Text = "Enologico"
        Me.lblEnologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMedidaID
        '
        Me.lblMedidaID.Location = New System.Drawing.Point(28, 115)
        Me.lblMedidaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMedidaID.Name = "lblMedidaID"
        Me.lblMedidaID.Size = New System.Drawing.Size(114, 30)
        Me.lblMedidaID.TabIndex = 3
        Me.lblMedidaID.Text = "Medida"
        Me.lblMedidaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_palet_no_conforme
        '
        Me.lblid_palet_no_conforme.Location = New System.Drawing.Point(28, 145)
        Me.lblid_palet_no_conforme.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_palet_no_conforme.Name = "lblid_palet_no_conforme"
        Me.lblid_palet_no_conforme.Size = New System.Drawing.Size(100, 30)
        Me.lblid_palet_no_conforme.TabIndex = 6
        Me.lblid_palet_no_conforme.Text = "Palet no conforme"
        Me.lblid_palet_no_conforme.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'chbNC
        '
        Me.chbNC.BackColor = System.Drawing.SystemColors.Control
        Me.chbNC.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbNC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbNC.Location = New System.Drawing.Point(134, 148)
        Me.chbNC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbNC.Name = "chbNC"
        Me.chbNC.Size = New System.Drawing.Size(13, 20)
        Me.chbNC.TabIndex = 9
        Me.chbNC.UseVisualStyleBackColor = False
        '
        'frmEntTiposProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(406, 199)
        Me.Controls.Add(Me.chbNC)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblAbreviatura)
        Me.Controls.Add(Me.cboMedida)
        Me.Controls.Add(Me.txtAbreviatura)
        Me.Controls.Add(Me.lblEnologico)
        Me.Controls.Add(Me.chbEnologico)
        Me.Controls.Add(Me.cboid_palet_no_conforme)
        Me.Controls.Add(Me.lblMedidaID)
        Me.Controls.Add(Me.lblid_palet_no_conforme)
        Me.Controls.Add(Me.butAddMedidaID)
        Me.Controls.Add(Me.butVerMedidaID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(415, 212)
        Me.Name = "frmEntTiposProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposProductos"
        Me.Controls.SetChildIndex(Me.butVerMedidaID, 0)
        Me.Controls.SetChildIndex(Me.butAddMedidaID, 0)
        Me.Controls.SetChildIndex(Me.lblid_palet_no_conforme, 0)
        Me.Controls.SetChildIndex(Me.lblMedidaID, 0)
        Me.Controls.SetChildIndex(Me.cboid_palet_no_conforme, 0)
        Me.Controls.SetChildIndex(Me.chbEnologico, 0)
        Me.Controls.SetChildIndex(Me.lblEnologico, 0)
        Me.Controls.SetChildIndex(Me.txtAbreviatura, 0)
        Me.Controls.SetChildIndex(Me.cboMedida, 0)
        Me.Controls.SetChildIndex(Me.lblAbreviatura, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.chbNC, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAbreviatura As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents chbEnologico As System.Windows.Forms.CheckBox
    Private WithEvents cboMedida As System.Windows.Forms.ComboBox
    Private WithEvents butVerMedidaID As System.Windows.Forms.Button
    Private WithEvents butAddMedidaID As System.Windows.Forms.Button
    Private WithEvents cboid_palet_no_conforme As System.Windows.Forms.ComboBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblAbreviatura As System.Windows.Forms.Label
    Private WithEvents lblEnologico As System.Windows.Forms.Label
    Private WithEvents lblMedidaID As System.Windows.Forms.Label
    Private WithEvents lblid_palet_no_conforme As System.Windows.Forms.Label

    Private WithEvents chbNC As System.Windows.Forms.CheckBox
End Class
