<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCausasPartesEnvasado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCausasPartesEnvasado))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_CausaParteTipo = New System.Windows.Forms.ComboBox()
        Me.butVerid_CausaParteTipo = New System.Windows.Forms.Button()
        Me.butAddid_CausaParteTipo = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblid_CausaParteTipo = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(106, 39)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(338, 21)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboid_CausaParteTipo
        '
        Me.cboid_CausaParteTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_CausaParteTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_CausaParteTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_CausaParteTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_CausaParteTipo.Location = New System.Drawing.Point(106, 68)
        Me.cboid_CausaParteTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.cboid_CausaParteTipo.Name = "cboid_CausaParteTipo"
        Me.cboid_CausaParteTipo.Size = New System.Drawing.Size(338, 23)
        Me.cboid_CausaParteTipo.TabIndex = 1
        '
        'butVerid_CausaParteTipo
        '
        Me.butVerid_CausaParteTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_CausaParteTipo.FlatAppearance.BorderSize = 0
        Me.butVerid_CausaParteTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_CausaParteTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_CausaParteTipo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_CausaParteTipo.Location = New System.Drawing.Point(448, 69)
        Me.butVerid_CausaParteTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.butVerid_CausaParteTipo.Name = "butVerid_CausaParteTipo"
        Me.butVerid_CausaParteTipo.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_CausaParteTipo.TabIndex = 2
        Me.butVerid_CausaParteTipo.TabStop = False
        '
        'butAddid_CausaParteTipo
        '
        Me.butAddid_CausaParteTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_CausaParteTipo.FlatAppearance.BorderSize = 0
        Me.butAddid_CausaParteTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_CausaParteTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_CausaParteTipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_CausaParteTipo.Location = New System.Drawing.Point(470, 69)
        Me.butAddid_CausaParteTipo.Margin = New System.Windows.Forms.Padding(2)
        Me.butAddid_CausaParteTipo.Name = "butAddid_CausaParteTipo"
        Me.butAddid_CausaParteTipo.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_CausaParteTipo.TabIndex = 3
        Me.butAddid_CausaParteTipo.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(35, 37)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(67, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_CausaParteTipo
        '
        Me.lblid_CausaParteTipo.Location = New System.Drawing.Point(35, 65)
        Me.lblid_CausaParteTipo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_CausaParteTipo.Name = "lblid_CausaParteTipo"
        Me.lblid_CausaParteTipo.Size = New System.Drawing.Size(67, 30)
        Me.lblid_CausaParteTipo.TabIndex = 1
        Me.lblid_CausaParteTipo.Text = "Tipo"
        Me.lblid_CausaParteTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntCausasPartesEnvasado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(517, 110)
        Me.Controls.Add(Me.cboid_CausaParteTipo)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.butAddid_CausaParteTipo)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.butVerid_CausaParteTipo)
        Me.Controls.Add(Me.lblid_CausaParteTipo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(392, 132)
        Me.Name = "frmEntCausasPartesEnvasado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CausasPartesEnvasado"
        Me.Controls.SetChildIndex(Me.lblid_CausaParteTipo, 0)
        Me.Controls.SetChildIndex(Me.butVerid_CausaParteTipo, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.butAddid_CausaParteTipo, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboid_CausaParteTipo, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboid_CausaParteTipo As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_CausaParteTipo As System.Windows.Forms.Button
    Private WithEvents butAddid_CausaParteTipo As System.Windows.Forms.Button
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblid_CausaParteTipo As System.Windows.Forms.Label

End Class
