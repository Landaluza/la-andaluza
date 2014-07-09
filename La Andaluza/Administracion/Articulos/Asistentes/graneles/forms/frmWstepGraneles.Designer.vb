<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepGraneles
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim EnologicoLabel As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Me.lblGranelTipoID = New System.Windows.Forms.Label()
        Me.cboGranelTipoID = New System.Windows.Forms.ComboBox()
        Me.PanContenidos = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbCreartipoProducto = New System.Windows.Forms.CheckBox()
        Me.panNuevoTipoProducto = New System.Windows.Forms.Panel()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.chEnologico = New System.Windows.Forms.CheckBox()
        Me.pantipoProducto = New System.Windows.Forms.Panel()
        Me.butaddTProducto = New System.Windows.Forms.Button()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbCertificados = New System.Windows.Forms.GroupBox()
        Me.txtCantidaDefecto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbreviatura = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cbMedidas = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        EnologicoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.PanContenidos.SuspendLayout()
        Me.panNuevoTipoProducto.SuspendLayout()
        Me.pantipoProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnologicoLabel
        '
        EnologicoLabel.AutoSize = True
        EnologicoLabel.Location = New System.Drawing.Point(49, 74)
        EnologicoLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        EnologicoLabel.Name = "EnologicoLabel"
        EnologicoLabel.Size = New System.Drawing.Size(74, 17)
        EnologicoLabel.TabIndex = 1000000008
        EnologicoLabel.Text = "Enologico:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(49, 101)
        Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(83, 17)
        Label2.TabIndex = 1000000011
        Label2.Text = "Se Mide en:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(106, 46)
        Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(57, 17)
        Label3.TabIndex = 1000000013
        Label3.Text = "Unidad:"
        '
        'lblGranelTipoID
        '
        Me.lblGranelTipoID.Location = New System.Drawing.Point(105, 29)
        Me.lblGranelTipoID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblGranelTipoID.Name = "lblGranelTipoID"
        Me.lblGranelTipoID.Size = New System.Drawing.Size(96, 26)
        Me.lblGranelTipoID.TabIndex = 0
        Me.lblGranelTipoID.Text = "Tipo granel"
        Me.lblGranelTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGranelTipoID
        '
        Me.cboGranelTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGranelTipoID.Location = New System.Drawing.Point(209, 29)
        Me.cboGranelTipoID.Margin = New System.Windows.Forms.Padding(4)
        Me.cboGranelTipoID.Name = "cboGranelTipoID"
        Me.cboGranelTipoID.Size = New System.Drawing.Size(332, 26)
        Me.cboGranelTipoID.TabIndex = 1
        '
        'PanContenidos
        '
        Me.PanContenidos.AutoSize = True
        Me.PanContenidos.Controls.Add(Me.Panel2)
        Me.PanContenidos.Controls.Add(Me.Panel3)
        Me.PanContenidos.Controls.Add(Me.Panel1)
        Me.PanContenidos.Location = New System.Drawing.Point(16, 15)
        Me.PanContenidos.Margin = New System.Windows.Forms.Padding(4)
        Me.PanContenidos.Name = "PanContenidos"
        Me.PanContenidos.Size = New System.Drawing.Size(663, 557)
        Me.PanContenidos.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(293, 16)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(115, 17)
        Me.Label5.TabIndex = 1000000015
        Me.Label5.Text = "Cantidad defecto"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(106, 16)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 1000000013
        Me.Label4.Text = "Densidad"
        '
        'cbCreartipoProducto
        '
        Me.cbCreartipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbCreartipoProducto.AutoSize = True
        Me.cbCreartipoProducto.Location = New System.Drawing.Point(108, 9)
        Me.cbCreartipoProducto.Name = "cbCreartipoProducto"
        Me.cbCreartipoProducto.Size = New System.Drawing.Size(136, 21)
        Me.cbCreartipoProducto.TabIndex = 7
        Me.cbCreartipoProducto.Text = "Crear uno nuevo"
        Me.cbCreartipoProducto.UseVisualStyleBackColor = True
        '
        'panNuevoTipoProducto
        '
        Me.panNuevoTipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.panNuevoTipoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panNuevoTipoProducto.Controls.Add(Me.lblDescripcion)
        Me.panNuevoTipoProducto.Controls.Add(Me.txtDescripcion)
        Me.panNuevoTipoProducto.Controls.Add(Me.txtAbreviatura)
        Me.panNuevoTipoProducto.Controls.Add(EnologicoLabel)
        Me.panNuevoTipoProducto.Controls.Add(Me.lblAbreviatura)
        Me.panNuevoTipoProducto.Controls.Add(Me.chEnologico)
        Me.panNuevoTipoProducto.Controls.Add(Label2)
        Me.panNuevoTipoProducto.Controls.Add(Me.cbMedidas)
        Me.panNuevoTipoProducto.Enabled = False
        Me.panNuevoTipoProducto.Location = New System.Drawing.Point(108, 33)
        Me.panNuevoTipoProducto.Name = "panNuevoTipoProducto"
        Me.panNuevoTipoProducto.Size = New System.Drawing.Size(433, 134)
        Me.panNuevoTipoProducto.TabIndex = 6
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(49, 16)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(82, 17)
        Me.lblDescripcion.TabIndex = 1000000006
        Me.lblDescripcion.Text = "Descripcion"
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.AutoSize = True
        Me.lblAbreviatura.Location = New System.Drawing.Point(49, 46)
        Me.lblAbreviatura.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(81, 17)
        Me.lblAbreviatura.TabIndex = 1000000007
        Me.lblAbreviatura.Text = "Abreviatura"
        '
        'chEnologico
        '
        Me.chEnologico.Location = New System.Drawing.Point(134, 72)
        Me.chEnologico.Margin = New System.Windows.Forms.Padding(4)
        Me.chEnologico.Name = "chEnologico"
        Me.chEnologico.Size = New System.Drawing.Size(57, 17)
        Me.chEnologico.TabIndex = 1000000009
        '
        'pantipoProducto
        '
        Me.pantipoProducto.Controls.Add(Me.butaddTProducto)
        Me.pantipoProducto.Controls.Add(Me.cboTipoProducto)
        Me.pantipoProducto.Controls.Add(Me.Label1)
        Me.pantipoProducto.Location = New System.Drawing.Point(108, 74)
        Me.pantipoProducto.Name = "pantipoProducto"
        Me.pantipoProducto.Size = New System.Drawing.Size(459, 57)
        Me.pantipoProducto.TabIndex = 5
        '
        'butaddTProducto
        '
        Me.butaddTProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butaddTProducto.FlatAppearance.BorderSize = 0
        Me.butaddTProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butaddTProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butaddTProducto.Location = New System.Drawing.Point(440, 4)
        Me.butaddTProducto.Name = "butaddTProducto"
        Me.butaddTProducto.Size = New System.Drawing.Size(19, 28)
        Me.butaddTProducto.TabIndex = 5
        Me.butaddTProducto.UseVisualStyleBackColor = True
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.Location = New System.Drawing.Point(101, 4)
        Me.cboTipoProducto.Margin = New System.Windows.Forms.Padding(4)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(332, 26)
        Me.cboTipoProducto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-3, 6)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 26)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbCertificados
        '
        Me.gbCertificados.AutoSize = True
        Me.gbCertificados.BackColor = System.Drawing.SystemColors.Control
        Me.gbCertificados.Location = New System.Drawing.Point(108, 59)
        Me.gbCertificados.Margin = New System.Windows.Forms.Padding(4)
        Me.gbCertificados.Name = "gbCertificados"
        Me.gbCertificados.Padding = New System.Windows.Forms.Padding(4)
        Me.gbCertificados.Size = New System.Drawing.Size(433, 159)
        Me.gbCertificados.TabIndex = 2
        Me.gbCertificados.TabStop = False
        Me.gbCertificados.Text = "Certificados requeridos"
        '
        'txtCantidaDefecto
        '
        Me.txtCantidaDefecto.EsUnicoCampo = "Descripcion"
        Me.txtCantidaDefecto.EsUnicoCampoID = "TipoProductoID"
        Me.txtCantidaDefecto.EsUnicoID = 0
        Me.txtCantidaDefecto.EsUnicoTabla = "TiposProductos"
        Me.txtCantidaDefecto.Location = New System.Drawing.Point(416, 13)
        Me.txtCantidaDefecto.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCantidaDefecto.MaxLength = 50
        Me.txtCantidaDefecto.Minimo = 0
        Me.txtCantidaDefecto.Modificado = False
        Me.txtCantidaDefecto.Name = "txtCantidaDefecto"
        Me.txtCantidaDefecto.Numerico_EsNumerico = True
        Me.txtCantidaDefecto.Numerico_NumeroDoublees = 4
        Me.txtCantidaDefecto.Numerico_SeparadorMiles = False
        Me.txtCantidaDefecto.Obligatorio = True
        Me.txtCantidaDefecto.ParametroID = 0
        Me.txtCantidaDefecto.Size = New System.Drawing.Size(125, 22)
        Me.txtCantidaDefecto.TabIndex = 1000000014
        Me.txtCantidaDefecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidaDefecto.ValorMaximo = 0.0!
        Me.txtCantidaDefecto.ValorMinimo = 0.0!
        '
        'txtDensidad
        '
        Me.txtDensidad.EsUnicoCampo = "Descripcion"
        Me.txtDensidad.EsUnicoCampoID = "TipoProductoID"
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = "TiposProductos"
        Me.txtDensidad.Location = New System.Drawing.Point(209, 13)
        Me.txtDensidad.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDensidad.MaxLength = 50
        Me.txtDensidad.Minimo = 0
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 2
        Me.txtDensidad.Numerico_SeparadorMiles = False
        Me.txtDensidad.Obligatorio = True
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(76, 22)
        Me.txtDensidad.TabIndex = 1000000012
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0.0!
        Me.txtDensidad.ValorMinimo = 0.0!
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Litros", "Kilos"})
        Me.cboUnidad.Location = New System.Drawing.Point(209, 43)
        Me.cboUnidad.Margin = New System.Windows.Forms.Padding(4)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(332, 24)
        Me.cboUnidad.TabIndex = 1000000012
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EsUnicoCampo = "Descripcion"
        Me.txtDescripcion.EsUnicoCampoID = "TipoProductoID"
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = "TiposProductos"
        Me.txtDescripcion.Location = New System.Drawing.Point(134, 12)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(243, 22)
        Me.txtDescripcion.TabIndex = 1000000004
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.EsUnicoCampo = "Abreviatura"
        Me.txtAbreviatura.EsUnicoCampoID = "TipoProductoID"
        Me.txtAbreviatura.EsUnicoID = 0
        Me.txtAbreviatura.EsUnicoTabla = "TiposProductos"
        Me.txtAbreviatura.Location = New System.Drawing.Point(134, 42)
        Me.txtAbreviatura.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAbreviatura.MaxLength = 3
        Me.txtAbreviatura.Minimo = 3
        Me.txtAbreviatura.Modificado = False
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Numerico_EsNumerico = False
        Me.txtAbreviatura.Numerico_NumeroDoublees = 0
        Me.txtAbreviatura.Numerico_SeparadorMiles = False
        Me.txtAbreviatura.Obligatorio = True
        Me.txtAbreviatura.ParametroID = 0
        Me.txtAbreviatura.Size = New System.Drawing.Size(55, 22)
        Me.txtAbreviatura.TabIndex = 1000000005
        Me.txtAbreviatura.ValorMaximo = 0.0!
        Me.txtAbreviatura.ValorMinimo = 0.0!
        '
        'cbMedidas
        '
        Me.cbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidas.FormattingEnabled = True
        Me.cbMedidas.Location = New System.Drawing.Point(134, 97)
        Me.cbMedidas.Margin = New System.Windows.Forms.Padding(4)
        Me.cbMedidas.Name = "cbMedidas"
        Me.cbMedidas.Size = New System.Drawing.Size(243, 24)
        Me.cbMedidas.TabIndex = 1000000010
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbCertificados)
        Me.Panel1.Controls.Add(Me.lblGranelTipoID)
        Me.Panel1.Controls.Add(Me.cboGranelTipoID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(663, 221)
        Me.Panel1.TabIndex = 1000000016
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.pantipoProducto)
        Me.Panel2.Controls.Add(Me.cboUnidad)
        Me.Panel2.Controls.Add(Me.Label5)
        Me.Panel2.Controls.Add(Me.txtDensidad)
        Me.Panel2.Controls.Add(Me.txtCantidaDefecto)
        Me.Panel2.Controls.Add(Label3)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 221)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(663, 166)
        Me.Panel2.TabIndex = 1000000017
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.panNuevoTipoProducto)
        Me.Panel3.Controls.Add(Me.cbCreartipoProducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 387)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(663, 170)
        Me.Panel3.TabIndex = 1000000018
        '
        'frmWstepGraneles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 584)
        Me.Controls.Add(Me.PanContenidos)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmWstepGraneles"
        Me.Text = "frmWstepGraneles"
        Me.PanContenidos.ResumeLayout(False)
        Me.panNuevoTipoProducto.ResumeLayout(False)
        Me.panNuevoTipoProducto.PerformLayout()
        Me.pantipoProducto.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents lblGranelTipoID As System.Windows.Forms.Label
   Private WithEvents cboGranelTipoID As System.Windows.Forms.ComboBox
   Private WithEvents PanContenidos As System.Windows.Forms.Panel
   Private WithEvents gbCertificados As System.Windows.Forms.GroupBox
   Private WithEvents cbCreartipoProducto As System.Windows.Forms.CheckBox
   Private WithEvents panNuevoTipoProducto As System.Windows.Forms.Panel
   Private WithEvents pantipoProducto As System.Windows.Forms.Panel
   Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAbreviatura As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblAbreviatura As System.Windows.Forms.Label
    Private WithEvents chEnologico As System.Windows.Forms.CheckBox
    Private WithEvents cbMedidas As System.Windows.Forms.ComboBox
    Private WithEvents butaddTProducto As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtDensidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboUnidad As System.Windows.Forms.ComboBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtCantidaDefecto As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents Panel3 As System.Windows.Forms.Panel
   Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
