<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntListaParametros
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntListaParametros))
        Me.txtNombre = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboUnidadMedida = New System.Windows.Forms.ComboBox()
        Me.butVerUnidadMedidaID = New System.Windows.Forms.Button()
        Me.butAddUnidadMedidaID = New System.Windows.Forms.Button()
        Me.cboid_parametroTipo = New System.Windows.Forms.ComboBox()
        Me.butVerid_parametroTipo = New System.Windows.Forms.Button()
        Me.butAddid_parametroTipo = New System.Windows.Forms.Button()
        Me.lblNombre = New System.Windows.Forms.Label()
        Me.lblUnidadMedidaID = New System.Windows.Forms.Label()
        Me.lblid_parametroTipo = New System.Windows.Forms.Label()

        Me.cbEnvasado = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.txtNombre.Location = New System.Drawing.Point(134, 46)
        Me.txtNombre.MaxLength = 50
        Me.txtNombre.Minimo = 0
        Me.txtNombre.Modificado = False
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Numerico_EsNumerico = False
        Me.txtNombre.Numerico_NumeroDoublees = 0
        Me.txtNombre.Numerico_SeparadorMiles = False
        Me.txtNombre.Obligatorio = False
        Me.txtNombre.ParametroID = 0
        Me.txtNombre.Size = New System.Drawing.Size(200, 21)
        Me.txtNombre.TabIndex = 0
        Me.txtNombre.ValorMaximo = 0.0R
        Me.txtNombre.ValorMinimo = 0.0R
        '
        'cboUnidadMedida
        '
        Me.cboUnidadMedida.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboUnidadMedida.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboUnidadMedida.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboUnidadMedida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboUnidadMedida.Location = New System.Drawing.Point(134, 73)
        Me.cboUnidadMedida.Name = "cboUnidadMedida"
        Me.cboUnidadMedida.Size = New System.Drawing.Size(200, 23)
        Me.cboUnidadMedida.TabIndex = 1
        '
        'butVerUnidadMedidaID
        '
        Me.butVerUnidadMedidaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerUnidadMedidaID.FlatAppearance.BorderSize = 0
        Me.butVerUnidadMedidaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerUnidadMedidaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerUnidadMedidaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerUnidadMedidaID.Location = New System.Drawing.Point(340, 73)
        Me.butVerUnidadMedidaID.Name = "butVerUnidadMedidaID"
        Me.butVerUnidadMedidaID.Size = New System.Drawing.Size(20, 20)
        Me.butVerUnidadMedidaID.TabIndex = 2
        Me.butVerUnidadMedidaID.TabStop = False
        '
        'butAddUnidadMedidaID
        '
        Me.butAddUnidadMedidaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddUnidadMedidaID.FlatAppearance.BorderSize = 0
        Me.butAddUnidadMedidaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddUnidadMedidaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddUnidadMedidaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddUnidadMedidaID.Location = New System.Drawing.Point(366, 73)
        Me.butAddUnidadMedidaID.Name = "butAddUnidadMedidaID"
        Me.butAddUnidadMedidaID.Size = New System.Drawing.Size(20, 20)
        Me.butAddUnidadMedidaID.TabIndex = 3
        Me.butAddUnidadMedidaID.TabStop = False
        '
        'cboid_parametroTipo
        '
        Me.cboid_parametroTipo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_parametroTipo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_parametroTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_parametroTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_parametroTipo.Location = New System.Drawing.Point(134, 102)
        Me.cboid_parametroTipo.Name = "cboid_parametroTipo"
        Me.cboid_parametroTipo.Size = New System.Drawing.Size(200, 23)
        Me.cboid_parametroTipo.TabIndex = 2
        '
        'butVerid_parametroTipo
        '
        Me.butVerid_parametroTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_parametroTipo.FlatAppearance.BorderSize = 0
        Me.butVerid_parametroTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_parametroTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_parametroTipo.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_parametroTipo.Location = New System.Drawing.Point(340, 102)
        Me.butVerid_parametroTipo.Name = "butVerid_parametroTipo"
        Me.butVerid_parametroTipo.Size = New System.Drawing.Size(20, 20)
        Me.butVerid_parametroTipo.TabIndex = 5
        Me.butVerid_parametroTipo.TabStop = False
        '
        'butAddid_parametroTipo
        '
        Me.butAddid_parametroTipo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_parametroTipo.FlatAppearance.BorderSize = 0
        Me.butAddid_parametroTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_parametroTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_parametroTipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_parametroTipo.Location = New System.Drawing.Point(366, 102)
        Me.butAddid_parametroTipo.Name = "butAddid_parametroTipo"
        Me.butAddid_parametroTipo.Size = New System.Drawing.Size(20, 20)
        Me.butAddid_parametroTipo.TabIndex = 6
        Me.butAddid_parametroTipo.TabStop = False
        '
        'lblNombre
        '
        Me.lblNombre.Location = New System.Drawing.Point(30, 43)
        Me.lblNombre.Name = "lblNombre"
        Me.lblNombre.Size = New System.Drawing.Size(98, 21)
        Me.lblNombre.TabIndex = 0
        Me.lblNombre.Text = "Nombre"
        Me.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUnidadMedidaID
        '
        Me.lblUnidadMedidaID.Location = New System.Drawing.Point(30, 70)
        Me.lblUnidadMedidaID.Name = "lblUnidadMedidaID"
        Me.lblUnidadMedidaID.Size = New System.Drawing.Size(98, 21)
        Me.lblUnidadMedidaID.TabIndex = 1
        Me.lblUnidadMedidaID.Text = "UnidadMedida"
        Me.lblUnidadMedidaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_parametroTipo
        '
        Me.lblid_parametroTipo.Location = New System.Drawing.Point(30, 99)
        Me.lblid_parametroTipo.Name = "lblid_parametroTipo"
        Me.lblid_parametroTipo.Size = New System.Drawing.Size(98, 21)
        Me.lblid_parametroTipo.TabIndex = 4
        Me.lblid_parametroTipo.Text = "Tipo"
        Me.lblid_parametroTipo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'cbEnvasado
        '
        Me.cbEnvasado.AutoSize = True
        Me.cbEnvasado.Location = New System.Drawing.Point(33, 137)
        Me.cbEnvasado.Name = "cbEnvasado"
        Me.cbEnvasado.Size = New System.Drawing.Size(285, 17)
        Me.cbEnvasado.TabIndex = 1000000001
        Me.cbEnvasado.Text = "El parametro se utilizara en las analiticas de envasados"
        Me.cbEnvasado.UseVisualStyleBackColor = True
        '
        'frmEntListaParametros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(422, 166)
        Me.Controls.Add(Me.cbEnvasado)
        Me.Controls.Add(Me.lblNombre)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.lblUnidadMedidaID)
        Me.Controls.Add(Me.cboUnidadMedida)
        Me.Controls.Add(Me.butVerUnidadMedidaID)
        Me.Controls.Add(Me.butAddid_parametroTipo)
        Me.Controls.Add(Me.butAddUnidadMedidaID)
        Me.Controls.Add(Me.butVerid_parametroTipo)
        Me.Controls.Add(Me.lblid_parametroTipo)
        Me.Controls.Add(Me.cboid_parametroTipo)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntListaParametros"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ListaParametros"
        Me.Controls.SetChildIndex(Me.cboid_parametroTipo, 0)
        Me.Controls.SetChildIndex(Me.lblid_parametroTipo, 0)
        Me.Controls.SetChildIndex(Me.butVerid_parametroTipo, 0)
        Me.Controls.SetChildIndex(Me.butAddUnidadMedidaID, 0)
        Me.Controls.SetChildIndex(Me.butAddid_parametroTipo, 0)
        Me.Controls.SetChildIndex(Me.butVerUnidadMedidaID, 0)
        Me.Controls.SetChildIndex(Me.cboUnidadMedida, 0)
        Me.Controls.SetChildIndex(Me.lblUnidadMedidaID, 0)
        Me.Controls.SetChildIndex(Me.txtNombre, 0)
        Me.Controls.SetChildIndex(Me.lblNombre, 0)
        Me.Controls.SetChildIndex(Me.cbEnvasado, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtNombre As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboUnidadMedida As System.Windows.Forms.ComboBox
   Private WithEvents butVerUnidadMedidaID As System.Windows.Forms.Button
   Private WithEvents butAddUnidadMedidaID As System.Windows.Forms.Button
   Private WithEvents cboid_parametroTipo As System.Windows.Forms.ComboBox
   Private WithEvents butVerid_parametroTipo As System.Windows.Forms.Button
   Private WithEvents butAddid_parametroTipo As System.Windows.Forms.Button
   Private WithEvents lblNombre As System.Windows.Forms.Label
   Private WithEvents lblUnidadMedidaID As System.Windows.Forms.Label
   Private WithEvents lblid_parametroTipo As System.Windows.Forms.Label

   Private WithEvents cbEnvasado As System.Windows.Forms.CheckBox
End Class
