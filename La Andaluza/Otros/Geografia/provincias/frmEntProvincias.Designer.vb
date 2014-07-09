<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProvincias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProvincias))
        Me.cboId_pais = New System.Windows.Forms.ComboBox()
        Me.butVerId_pais = New System.Windows.Forms.Button()
        Me.butAddId_pais = New System.Windows.Forms.Button()
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblId_pais = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboId_pais
        '
        Me.cboId_pais.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboId_pais.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboId_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboId_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboId_pais.Location = New System.Drawing.Point(106, 50)
        Me.cboId_pais.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboId_pais.Name = "cboId_pais"
        Me.cboId_pais.Size = New System.Drawing.Size(181, 23)
        Me.cboId_pais.TabIndex = 0
        '
        'butVerId_pais
        '
        Me.butVerId_pais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_pais.FlatAppearance.BorderSize = 0
        Me.butVerId_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_pais.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_pais.Location = New System.Drawing.Point(290, 50)
        Me.butVerId_pais.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_pais.Name = "butVerId_pais"
        Me.butVerId_pais.Size = New System.Drawing.Size(18, 19)
        Me.butVerId_pais.TabIndex = 1
        Me.butVerId_pais.TabStop = False
        '
        'butAddId_pais
        '
        Me.butAddId_pais.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_pais.FlatAppearance.BorderSize = 0
        Me.butAddId_pais.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_pais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_pais.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_pais.Location = New System.Drawing.Point(313, 50)
        Me.butAddId_pais.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_pais.Name = "butAddId_pais"
        Me.butAddId_pais.Size = New System.Drawing.Size(18, 19)
        Me.butAddId_pais.TabIndex = 2
        Me.butAddId_pais.TabStop = False
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
        Me.txtNombre.Location = New System.Drawing.Point(106, 80)
        Me.txtNombre.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtNombre.MaxLength = 500
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(181, 21)
        Me.txtNombre.TabIndex = 1
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'lblId_pais
        '
        Me.lblId_pais.Location = New System.Drawing.Point(51, 47)
        Me.lblId_pais.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_pais.Name = "lblId_pais"
        Me.lblId_pais.Size = New System.Drawing.Size(50, 30)
        Me.lblId_pais.TabIndex = 0
        Me.lblId_pais.Text = "Pais"
        Me.lblId_pais.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(53, 77)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(48, 28)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntProvincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(358, 141)
        Me.Controls.Add(Me.cboId_pais)
        Me.Controls.Add(Me.butAddId_pais)
        Me.Controls.Add(Me.lblId_pais)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.butVerId_pais)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(342, 134)
        Me.Name = "frmEntProvincias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Provincias"
        Me.Controls.SetChildIndex(Me.butVerId_pais, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.lblId_pais, 0)
        Me.Controls.SetChildIndex(Me.butAddId_pais, 0)
        Me.Controls.SetChildIndex(Me.cboId_pais, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboId_pais As System.Windows.Forms.ComboBox
   Private WithEvents butVerId_pais As System.Windows.Forms.Button
   Private WithEvents butAddId_pais As System.Windows.Forms.Button
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblId_pais As System.Windows.Forms.Label
   Private WithEvents lblNombre As System.Windows.Forms.Label

End Class
