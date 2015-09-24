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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.pantipoProducto = New System.Windows.Forms.Panel()
        Me.butaddTProducto = New System.Windows.Forms.Button()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidaDefecto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.panNuevoTipoProducto = New System.Windows.Forms.Panel()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbreviatura = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.chEnologico = New System.Windows.Forms.CheckBox()
        Me.cbMedidas = New System.Windows.Forms.ComboBox()
        Me.cbCreartipoProducto = New System.Windows.Forms.CheckBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.gbCertificados = New System.Windows.Forms.GroupBox()
        EnologicoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        Me.PanContenidos.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.pantipoProducto.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.panNuevoTipoProducto.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnologicoLabel
        '
        EnologicoLabel.AutoSize = True
        EnologicoLabel.Location = New System.Drawing.Point(37, 60)
        EnologicoLabel.Name = "EnologicoLabel"
        EnologicoLabel.Size = New System.Drawing.Size(57, 13)
        EnologicoLabel.TabIndex = 1000000008
        EnologicoLabel.Text = "Enologico:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(37, 82)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 13)
        Label2.TabIndex = 1000000011
        Label2.Text = "Se Mide en:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(8, 33)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(44, 13)
        Label3.TabIndex = 1000000013
        Label3.Text = "Unidad:"
        '
        'lblGranelTipoID
        '
        Me.lblGranelTipoID.Location = New System.Drawing.Point(7, 22)
        Me.lblGranelTipoID.Name = "lblGranelTipoID"
        Me.lblGranelTipoID.Size = New System.Drawing.Size(66, 21)
        Me.lblGranelTipoID.TabIndex = 0
        Me.lblGranelTipoID.Text = "Tipo granel"
        Me.lblGranelTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboGranelTipoID
        '
        Me.cboGranelTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboGranelTipoID.Location = New System.Drawing.Point(79, 22)
        Me.cboGranelTipoID.Name = "cboGranelTipoID"
        Me.cboGranelTipoID.Size = New System.Drawing.Size(250, 23)
        Me.cboGranelTipoID.TabIndex = 1
        '
        'PanContenidos
        '
        Me.PanContenidos.AutoSize = True
        Me.PanContenidos.Controls.Add(Me.Panel2)
        Me.PanContenidos.Controls.Add(Me.Panel3)
        Me.PanContenidos.Controls.Add(Me.Panel1)
        Me.PanContenidos.Location = New System.Drawing.Point(12, 12)
        Me.PanContenidos.Name = "PanContenidos"
        Me.PanContenidos.Size = New System.Drawing.Size(393, 453)
        Me.PanContenidos.TabIndex = 0
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
        Me.Panel2.Location = New System.Drawing.Point(0, 180)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(390, 135)
        Me.Panel2.TabIndex = 1000000017
        '
        'pantipoProducto
        '
        Me.pantipoProducto.Controls.Add(Me.butaddTProducto)
        Me.pantipoProducto.Controls.Add(Me.cboTipoProducto)
        Me.pantipoProducto.Controls.Add(Me.Label1)
        Me.pantipoProducto.Location = New System.Drawing.Point(9, 56)
        Me.pantipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pantipoProducto.Name = "pantipoProducto"
        Me.pantipoProducto.Size = New System.Drawing.Size(356, 46)
        Me.pantipoProducto.TabIndex = 5
        '
        'butaddTProducto
        '
        Me.butaddTProducto.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butaddTProducto.FlatAppearance.BorderSize = 0
        Me.butaddTProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butaddTProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butaddTProducto.Location = New System.Drawing.Point(330, 3)
        Me.butaddTProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butaddTProducto.Name = "butaddTProducto"
        Me.butaddTProducto.Size = New System.Drawing.Size(24, 23)
        Me.butaddTProducto.TabIndex = 5
        Me.butaddTProducto.UseVisualStyleBackColor = True
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.Location = New System.Drawing.Point(76, 3)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(250, 23)
        Me.cboTipoProducto.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(-2, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Tipo producto"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Litros", "Kilos"})
        Me.cboUnidad.Location = New System.Drawing.Point(85, 31)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(250, 21)
        Me.cboUnidad.TabIndex = 1000000012
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(148, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(88, 13)
        Me.Label5.TabIndex = 1000000015
        Me.Label5.Text = "Cantidad defecto"
        '
        'txtDensidad
        '
        Me.txtDensidad.EsUnicoCampo = "Descripcion"
        Me.txtDensidad.EsUnicoCampoID = "TipoProductoID"
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = "TiposProductos"
        Me.txtDensidad.Location = New System.Drawing.Point(85, 7)
        Me.txtDensidad.MaxLength = 50
        Me.txtDensidad.Minimo = 0
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 2
        Me.txtDensidad.Numerico_SeparadorMiles = False
        Me.txtDensidad.Obligatorio = True
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(58, 20)
        Me.txtDensidad.TabIndex = 1000000012
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0R
        Me.txtDensidad.ValorMinimo = 0R
        '
        'txtCantidaDefecto
        '
        Me.txtCantidaDefecto.EsUnicoCampo = "Descripcion"
        Me.txtCantidaDefecto.EsUnicoCampoID = "TipoProductoID"
        Me.txtCantidaDefecto.EsUnicoID = 0
        Me.txtCantidaDefecto.EsUnicoTabla = "TiposProductos"
        Me.txtCantidaDefecto.Location = New System.Drawing.Point(240, 7)
        Me.txtCantidaDefecto.MaxLength = 50
        Me.txtCantidaDefecto.Minimo = 0
        Me.txtCantidaDefecto.Modificado = False
        Me.txtCantidaDefecto.Name = "txtCantidaDefecto"
        Me.txtCantidaDefecto.Numerico_EsNumerico = True
        Me.txtCantidaDefecto.Numerico_NumeroDoublees = 4
        Me.txtCantidaDefecto.Numerico_SeparadorMiles = False
        Me.txtCantidaDefecto.Obligatorio = True
        Me.txtCantidaDefecto.ParametroID = 0
        Me.txtCantidaDefecto.Size = New System.Drawing.Size(95, 20)
        Me.txtCantidaDefecto.TabIndex = 1000000014
        Me.txtCantidaDefecto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidaDefecto.ValorMaximo = 0R
        Me.txtCantidaDefecto.ValorMinimo = 0R
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1000000013
        Me.Label4.Text = "Densidad"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.panNuevoTipoProducto)
        Me.Panel3.Controls.Add(Me.cbCreartipoProducto)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 315)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(393, 138)
        Me.Panel3.TabIndex = 1000000018
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
        Me.panNuevoTipoProducto.Location = New System.Drawing.Point(10, 27)
        Me.panNuevoTipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panNuevoTipoProducto.Name = "panNuevoTipoProducto"
        Me.panNuevoTipoProducto.Size = New System.Drawing.Size(325, 109)
        Me.panNuevoTipoProducto.TabIndex = 6
        '
        'lblDescripcion
        '
        Me.lblDescripcion.AutoSize = True
        Me.lblDescripcion.Location = New System.Drawing.Point(37, 13)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lblDescripcion.TabIndex = 1000000006
        Me.lblDescripcion.Text = "Descripcion"
        '
        'txtDescripcion
        '
        Me.txtDescripcion.EsUnicoCampo = "Descripcion"
        Me.txtDescripcion.EsUnicoCampoID = "TipoProductoID"
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = "TiposProductos"
        Me.txtDescripcion.Location = New System.Drawing.Point(107, 10)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(183, 20)
        Me.txtDescripcion.TabIndex = 1000000004
        Me.txtDescripcion.ValorMaximo = 0R
        Me.txtDescripcion.ValorMinimo = 0R
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.EsUnicoCampo = "Abreviatura"
        Me.txtAbreviatura.EsUnicoCampoID = "TipoProductoID"
        Me.txtAbreviatura.EsUnicoID = 0
        Me.txtAbreviatura.EsUnicoTabla = "TiposProductos"
        Me.txtAbreviatura.Location = New System.Drawing.Point(107, 36)
        Me.txtAbreviatura.MaxLength = 3
        Me.txtAbreviatura.Minimo = 3
        Me.txtAbreviatura.Modificado = False
        Me.txtAbreviatura.Name = "txtAbreviatura"
        Me.txtAbreviatura.Numerico_EsNumerico = False
        Me.txtAbreviatura.Numerico_NumeroDoublees = 0
        Me.txtAbreviatura.Numerico_SeparadorMiles = False
        Me.txtAbreviatura.Obligatorio = True
        Me.txtAbreviatura.ParametroID = 0
        Me.txtAbreviatura.Size = New System.Drawing.Size(42, 20)
        Me.txtAbreviatura.TabIndex = 1000000005
        Me.txtAbreviatura.ValorMaximo = 0R
        Me.txtAbreviatura.ValorMinimo = 0R
        '
        'lblAbreviatura
        '
        Me.lblAbreviatura.AutoSize = True
        Me.lblAbreviatura.Location = New System.Drawing.Point(37, 37)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(61, 13)
        Me.lblAbreviatura.TabIndex = 1000000007
        Me.lblAbreviatura.Text = "Abreviatura"
        '
        'chEnologico
        '
        Me.chEnologico.Location = New System.Drawing.Point(107, 58)
        Me.chEnologico.Name = "chEnologico"
        Me.chEnologico.Size = New System.Drawing.Size(43, 14)
        Me.chEnologico.TabIndex = 1000000009
        '
        'cbMedidas
        '
        Me.cbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidas.FormattingEnabled = True
        Me.cbMedidas.Location = New System.Drawing.Point(107, 78)
        Me.cbMedidas.Name = "cbMedidas"
        Me.cbMedidas.Size = New System.Drawing.Size(183, 21)
        Me.cbMedidas.TabIndex = 1000000010
        '
        'cbCreartipoProducto
        '
        Me.cbCreartipoProducto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cbCreartipoProducto.AutoSize = True
        Me.cbCreartipoProducto.Location = New System.Drawing.Point(10, 8)
        Me.cbCreartipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCreartipoProducto.Name = "cbCreartipoProducto"
        Me.cbCreartipoProducto.Size = New System.Drawing.Size(105, 17)
        Me.cbCreartipoProducto.TabIndex = 7
        Me.cbCreartipoProducto.Text = "Crear uno nuevo"
        Me.cbCreartipoProducto.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.gbCertificados)
        Me.Panel1.Controls.Add(Me.lblGranelTipoID)
        Me.Panel1.Controls.Add(Me.cboGranelTipoID)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 180)
        Me.Panel1.TabIndex = 1000000016
        '
        'gbCertificados
        '
        Me.gbCertificados.AutoSize = True
        Me.gbCertificados.BackColor = System.Drawing.SystemColors.Control
        Me.gbCertificados.Location = New System.Drawing.Point(3, 46)
        Me.gbCertificados.Name = "gbCertificados"
        Me.gbCertificados.Size = New System.Drawing.Size(325, 129)
        Me.gbCertificados.TabIndex = 2
        Me.gbCertificados.TabStop = False
        Me.gbCertificados.Text = "Certificados requeridos"
        '
        'frmWstepGraneles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(421, 474)
        Me.Controls.Add(Me.PanContenidos)
        Me.Name = "frmWstepGraneles"
        Me.Text = "frmWstepGraneles"
        Me.PanContenidos.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.pantipoProducto.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.panNuevoTipoProducto.ResumeLayout(False)
        Me.panNuevoTipoProducto.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
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
