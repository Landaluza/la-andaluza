<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPoblaciones
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPoblaciones))
        Me.cboId_provincia = New System.Windows.Forms.ComboBox()
        Me.butVerId_provincia = New System.Windows.Forms.Button()
        Me.butAddId_provincia = New System.Windows.Forms.Button()
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblId_provincia = New System.Windows.Forms.Label()
        Me.lblNombre = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboId_provincia
        '
        Me.cboId_provincia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboId_provincia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboId_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboId_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboId_provincia.Location = New System.Drawing.Point(100, 50)
        Me.cboId_provincia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboId_provincia.Name = "cboId_provincia"
        Me.cboId_provincia.Size = New System.Drawing.Size(181, 23)
        Me.cboId_provincia.TabIndex = 0
        '
        'butVerId_provincia
        '
        Me.butVerId_provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_provincia.FlatAppearance.BorderSize = 0
        Me.butVerId_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_provincia.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_provincia.Location = New System.Drawing.Point(285, 50)
        Me.butVerId_provincia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_provincia.Name = "butVerId_provincia"
        Me.butVerId_provincia.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_provincia.TabIndex = 1
        Me.butVerId_provincia.TabStop = False
        '
        'butAddId_provincia
        '
        Me.butAddId_provincia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_provincia.FlatAppearance.BorderSize = 0
        Me.butAddId_provincia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_provincia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_provincia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_provincia.Location = New System.Drawing.Point(308, 50)
        Me.butAddId_provincia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_provincia.Name = "butAddId_provincia"
        Me.butAddId_provincia.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_provincia.TabIndex = 2
        Me.butAddId_provincia.TabStop = False
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
        Me.txtNombre.Location = New System.Drawing.Point(100, 80)
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
        'lblId_provincia
        '
        Me.lblId_provincia.Location = New System.Drawing.Point(30, 47)
        Me.lblId_provincia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_provincia.Name = "lblId_provincia"
        Me.lblId_provincia.Size = New System.Drawing.Size(66, 30)
        Me.lblId_provincia.TabIndex = 0
        Me.lblId_provincia.Text = "Provincia"
        Me.lblId_provincia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(30, 77)
        Me.lblNombre.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(66, 28)
        Me.lblNombre.TabIndex = 3
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntPoblaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(359, 121)
        Me.Controls.Add(Me.lblId_provincia)
        Me.Controls.Add(Me.cboId_provincia)
        Me.Controls.Add(Me.butVerId_provincia)
        Me.Controls.Add(Me.butAddId_provincia)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblNombre)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(368, 134)
        Me.Name = "frmEntPoblaciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Poblaciones"
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.butAddId_provincia, 0)
        Me.Controls.SetChildIndex(Me.butVerId_provincia, 0)
        Me.Controls.SetChildIndex(Me.cboId_provincia, 0)
        Me.Controls.SetChildIndex(Me.lblId_provincia, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboId_provincia As System.Windows.Forms.ComboBox
   Private WithEvents butVerId_provincia As System.Windows.Forms.Button
   Private WithEvents butAddId_provincia As System.Windows.Forms.Button
    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblId_provincia As System.Windows.Forms.Label
   Private WithEvents lblNombre As System.Windows.Forms.Label

End Class
