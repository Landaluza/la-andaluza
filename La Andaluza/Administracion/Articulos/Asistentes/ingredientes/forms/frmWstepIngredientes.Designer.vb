<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepIngredientes
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
        Dim Label5 As System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btnAddTProducto = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboUnidad = New System.Windows.Forms.ComboBox()
        Me.cbCreartipoProducto = New System.Windows.Forms.CheckBox()
        Me.panNuevoTipoProducto = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CuadroDeTexto1 = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAbreviatura = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblAbreviatura = New System.Windows.Forms.Label()
        Me.chEnologico = New System.Windows.Forms.CheckBox()
        Me.cbMedidas = New System.Windows.Forms.ComboBox()
        Me.pantipoProducto = New System.Windows.Forms.Panel()
        Me.cboTipoProducto = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnañadirEstado = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboEstado = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblIngredienteTipoID = New System.Windows.Forms.Label()
        Me.btnAddTipo = New System.Windows.Forms.Button()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboIngredienteTipoID = New System.Windows.Forms.ComboBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpCertificados = New System.Windows.Forms.TabPage()
        Me.gbCertificados = New System.Windows.Forms.GroupBox()
        Me.tbpCondiciones = New System.Windows.Forms.TabPage()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbpResiduos = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        EnologicoLabel = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.panNuevoTipoProducto.SuspendLayout()
        Me.pantipoProducto.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tbpCertificados.SuspendLayout()
        Me.tbpCondiciones.SuspendLayout()
        Me.tbpResiduos.SuspendLayout()
        Me.SuspendLayout()
        '
        'EnologicoLabel
        '
        EnologicoLabel.AutoSize = True
        EnologicoLabel.Location = New System.Drawing.Point(89, 65)
        EnologicoLabel.Name = "EnologicoLabel"
        EnologicoLabel.Size = New System.Drawing.Size(57, 13)
        EnologicoLabel.TabIndex = 1000000008
        EnologicoLabel.Text = "Enologico:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(89, 87)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(64, 13)
        Label2.TabIndex = 1000000011
        Label2.Text = "Se Mide en:"
        '
        'Label5
        '
        Label5.AutoSize = True
        Label5.Location = New System.Drawing.Point(23, 225)
        Label5.Name = "Label5"
        Label5.Size = New System.Drawing.Size(44, 13)
        Label5.TabIndex = 1000000017
        Label5.Text = "Unidad:"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.SplitContainer1)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(901, 470)
        Me.Panel1.TabIndex = 1000000021
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddTProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDensidad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboUnidad)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cbCreartipoProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.panNuevoTipoProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pantipoProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnañadirEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label14)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboEstado)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblDescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtDescripcion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblIngredienteTipoID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btnAddTipo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lblObservaciones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txtObservaciones)
        Me.SplitContainer1.Panel1.Controls.Add(Me.cboIngredienteTipoID)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(901, 470)
        Me.SplitContainer1.SplitterDistance = 495
        Me.SplitContainer1.TabIndex = 0
        '
        'btnAddTProducto
        '
        Me.btnAddTProducto.FlatAppearance.BorderSize = 0
        Me.btnAddTProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTProducto.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnAddTProducto.Location = New System.Drawing.Point(457, 254)
        Me.btnAddTProducto.Name = "btnAddTProducto"
        Me.btnAddTProducto.Size = New System.Drawing.Size(20, 23)
        Me.btnAddTProducto.TabIndex = 1000000018
        Me.btnAddTProducto.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 1000000016
        Me.Label4.Text = "Densidad"
        '
        'txtDensidad
        '
        Me.txtDensidad.EsUnicoCampo = "Descripcion"
        Me.txtDensidad.EsUnicoCampoID = "TipoProductoID"
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = "TiposProductos"
        Me.txtDensidad.Location = New System.Drawing.Point(114, 198)
        Me.txtDensidad.MaxLength = 50
        Me.txtDensidad.Minimo = 0
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 2
        Me.txtDensidad.Numerico_SeparadorMiles = False
        Me.txtDensidad.Obligatorio = True
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(94, 20)
        Me.txtDensidad.TabIndex = 1000000014
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0R
        Me.txtDensidad.ValorMinimo = 0R
        '
        'cboUnidad
        '
        Me.cboUnidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboUnidad.FormattingEnabled = True
        Me.cboUnidad.Items.AddRange(New Object() {"Litros", "Kilos"})
        Me.cboUnidad.Location = New System.Drawing.Point(114, 223)
        Me.cboUnidad.Name = "cboUnidad"
        Me.cboUnidad.Size = New System.Drawing.Size(250, 21)
        Me.cboUnidad.TabIndex = 1000000015
        '
        'cbCreartipoProducto
        '
        Me.cbCreartipoProducto.AutoSize = True
        Me.cbCreartipoProducto.Location = New System.Drawing.Point(26, 301)
        Me.cbCreartipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cbCreartipoProducto.Name = "cbCreartipoProducto"
        Me.cbCreartipoProducto.Size = New System.Drawing.Size(105, 17)
        Me.cbCreartipoProducto.TabIndex = 12
        Me.cbCreartipoProducto.Text = "Crear uno nuevo"
        Me.cbCreartipoProducto.UseVisualStyleBackColor = True
        '
        'panNuevoTipoProducto
        '
        Me.panNuevoTipoProducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panNuevoTipoProducto.Controls.Add(Me.Label1)
        Me.panNuevoTipoProducto.Controls.Add(Me.CuadroDeTexto1)
        Me.panNuevoTipoProducto.Controls.Add(Me.txtAbreviatura)
        Me.panNuevoTipoProducto.Controls.Add(EnologicoLabel)
        Me.panNuevoTipoProducto.Controls.Add(Me.lblAbreviatura)
        Me.panNuevoTipoProducto.Controls.Add(Me.chEnologico)
        Me.panNuevoTipoProducto.Controls.Add(Label2)
        Me.panNuevoTipoProducto.Controls.Add(Me.cbMedidas)
        Me.panNuevoTipoProducto.Enabled = False
        Me.panNuevoTipoProducto.Location = New System.Drawing.Point(26, 323)
        Me.panNuevoTipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.panNuevoTipoProducto.Name = "panNuevoTipoProducto"
        Me.panNuevoTipoProducto.Size = New System.Drawing.Size(432, 121)
        Me.panNuevoTipoProducto.TabIndex = 11
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 13)
        Me.Label1.TabIndex = 1000000006
        Me.Label1.Text = "Descripcion"
        '
        'CuadroDeTexto1
        '
        Me.CuadroDeTexto1.EsUnicoCampo = "Descripcion"
        Me.CuadroDeTexto1.EsUnicoCampoID = "TipoProductoID"
        Me.CuadroDeTexto1.EsUnicoID = 0
        Me.CuadroDeTexto1.EsUnicoTabla = "TiposProductos"
        Me.CuadroDeTexto1.Location = New System.Drawing.Point(153, 15)
        Me.CuadroDeTexto1.MaxLength = 50
        Me.CuadroDeTexto1.Minimo = 0
        Me.CuadroDeTexto1.Modificado = False
        Me.CuadroDeTexto1.Name = "CuadroDeTexto1"
        Me.CuadroDeTexto1.Numerico_EsNumerico = False
        Me.CuadroDeTexto1.Numerico_NumeroDoublees = 0
        Me.CuadroDeTexto1.Numerico_SeparadorMiles = False
        Me.CuadroDeTexto1.Obligatorio = True
        Me.CuadroDeTexto1.ParametroID = 0
        Me.CuadroDeTexto1.Size = New System.Drawing.Size(183, 20)
        Me.CuadroDeTexto1.TabIndex = 1000000004
        Me.CuadroDeTexto1.ValorMaximo = 0R
        Me.CuadroDeTexto1.ValorMinimo = 0R
        '
        'txtAbreviatura
        '
        Me.txtAbreviatura.EsUnicoCampo = "Abreviatura"
        Me.txtAbreviatura.EsUnicoCampoID = "TipoProductoID"
        Me.txtAbreviatura.EsUnicoID = 0
        Me.txtAbreviatura.EsUnicoTabla = "TiposProductos"
        Me.txtAbreviatura.Location = New System.Drawing.Point(153, 39)
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
        Me.lblAbreviatura.Location = New System.Drawing.Point(89, 42)
        Me.lblAbreviatura.Name = "lblAbreviatura"
        Me.lblAbreviatura.Size = New System.Drawing.Size(61, 13)
        Me.lblAbreviatura.TabIndex = 1000000007
        Me.lblAbreviatura.Text = "Abreviatura"
        '
        'chEnologico
        '
        Me.chEnologico.Location = New System.Drawing.Point(153, 63)
        Me.chEnologico.Name = "chEnologico"
        Me.chEnologico.Size = New System.Drawing.Size(43, 14)
        Me.chEnologico.TabIndex = 1000000009
        '
        'cbMedidas
        '
        Me.cbMedidas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMedidas.FormattingEnabled = True
        Me.cbMedidas.Location = New System.Drawing.Point(153, 84)
        Me.cbMedidas.Name = "cbMedidas"
        Me.cbMedidas.Size = New System.Drawing.Size(183, 21)
        Me.cbMedidas.TabIndex = 1000000010
        '
        'pantipoProducto
        '
        Me.pantipoProducto.Controls.Add(Me.cboTipoProducto)
        Me.pantipoProducto.Controls.Add(Me.Label3)
        Me.pantipoProducto.Location = New System.Drawing.Point(26, 250)
        Me.pantipoProducto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.pantipoProducto.Name = "pantipoProducto"
        Me.pantipoProducto.Size = New System.Drawing.Size(431, 33)
        Me.pantipoProducto.TabIndex = 10
        '
        'cboTipoProducto
        '
        Me.cboTipoProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoProducto.Location = New System.Drawing.Point(88, 5)
        Me.cboTipoProducto.Name = "cboTipoProducto"
        Me.cboTipoProducto.Size = New System.Drawing.Size(344, 23)
        Me.cboTipoProducto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-2, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 21)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo producto"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnañadirEstado
        '
        Me.btnañadirEstado.Enabled = False
        Me.btnañadirEstado.FlatAppearance.BorderSize = 0
        Me.btnañadirEstado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnañadirEstado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnañadirEstado.Location = New System.Drawing.Point(438, 21)
        Me.btnañadirEstado.Name = "btnañadirEstado"
        Me.btnañadirEstado.Size = New System.Drawing.Size(20, 23)
        Me.btnañadirEstado.TabIndex = 9
        Me.btnañadirEstado.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.BackColor = System.Drawing.SystemColors.Control
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(23, 21)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(76, 21)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Estado"
        Me.Label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboEstado
        '
        Me.cboEstado.BackColor = System.Drawing.SystemColors.Window
        Me.cboEstado.Enabled = False
        Me.cboEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEstado.Location = New System.Drawing.Point(114, 20)
        Me.cboEstado.Name = "cboEstado"
        Me.cboEstado.Size = New System.Drawing.Size(318, 23)
        Me.cboEstado.TabIndex = 1
        Me.cboEstado.Text = "Liquido, solido, polvo"
        '
        'lblDescripcion
        '
        Me.lblDescripcion.BackColor = System.Drawing.SystemColors.Control
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 76)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(76, 21)
        Me.lblDescripcion.TabIndex = 5
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(114, 76)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(344, 55)
        Me.txtDescripcion.TabIndex = 6
        Me.txtDescripcion.ValorMaximo = 0R
        Me.txtDescripcion.ValorMinimo = 0R
        '
        'lblIngredienteTipoID
        '
        Me.lblIngredienteTipoID.Location = New System.Drawing.Point(23, 49)
        Me.lblIngredienteTipoID.Name = "lblIngredienteTipoID"
        Me.lblIngredienteTipoID.Size = New System.Drawing.Size(87, 21)
        Me.lblIngredienteTipoID.TabIndex = 2
        Me.lblIngredienteTipoID.Text = "Tipo"
        Me.lblIngredienteTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnAddTipo
        '
        Me.btnAddTipo.FlatAppearance.BorderSize = 0
        Me.btnAddTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddTipo.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.btnAddTipo.Location = New System.Drawing.Point(438, 49)
        Me.btnAddTipo.Name = "btnAddTipo"
        Me.btnAddTipo.Size = New System.Drawing.Size(20, 23)
        Me.btnAddTipo.TabIndex = 4
        Me.btnAddTipo.UseVisualStyleBackColor = True
        '
        'lblObservaciones
        '
        Me.lblObservaciones.BackColor = System.Drawing.SystemColors.Control
        Me.lblObservaciones.Location = New System.Drawing.Point(23, 137)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(87, 21)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(114, 137)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(344, 55)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.ValorMaximo = 0R
        Me.txtObservaciones.ValorMinimo = 0R
        '
        'cboIngredienteTipoID
        '
        Me.cboIngredienteTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIngredienteTipoID.Location = New System.Drawing.Point(114, 49)
        Me.cboIngredienteTipoID.Name = "cboIngredienteTipoID"
        Me.cboIngredienteTipoID.Size = New System.Drawing.Size(318, 23)
        Me.cboIngredienteTipoID.TabIndex = 3
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.TabControl1.Controls.Add(Me.tbpCertificados)
        Me.TabControl1.Controls.Add(Me.tbpCondiciones)
        Me.TabControl1.Controls.Add(Me.tbpResiduos)
        Me.TabControl1.Location = New System.Drawing.Point(22, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(374, 453)
        Me.TabControl1.TabIndex = 0
        '
        'tbpCertificados
        '
        Me.tbpCertificados.Controls.Add(Me.gbCertificados)
        Me.tbpCertificados.Location = New System.Drawing.Point(4, 22)
        Me.tbpCertificados.Name = "tbpCertificados"
        Me.tbpCertificados.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpCertificados.Size = New System.Drawing.Size(366, 427)
        Me.tbpCertificados.TabIndex = 0
        Me.tbpCertificados.Text = "Certificados"
        Me.tbpCertificados.UseVisualStyleBackColor = True
        '
        'gbCertificados
        '
        Me.gbCertificados.AutoSize = True
        Me.gbCertificados.BackColor = System.Drawing.SystemColors.Control
        Me.gbCertificados.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbCertificados.Location = New System.Drawing.Point(3, 3)
        Me.gbCertificados.Name = "gbCertificados"
        Me.gbCertificados.Size = New System.Drawing.Size(360, 421)
        Me.gbCertificados.TabIndex = 3
        Me.gbCertificados.TabStop = False
        Me.gbCertificados.Text = "Certificados requeridos"
        '
        'tbpCondiciones
        '
        Me.tbpCondiciones.Controls.Add(Me.Label11)
        Me.tbpCondiciones.Location = New System.Drawing.Point(4, 22)
        Me.tbpCondiciones.Name = "tbpCondiciones"
        Me.tbpCondiciones.Padding = New System.Windows.Forms.Padding(3, 3, 3, 3)
        Me.tbpCondiciones.Size = New System.Drawing.Size(678, 427)
        Me.tbpCondiciones.TabIndex = 1
        Me.tbpCondiciones.Text = "Condiciones almacenamiento"
        Me.tbpCondiciones.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label11.Location = New System.Drawing.Point(6, 18)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(143, 21)
        Me.Label11.TabIndex = 1000000007
        Me.Label11.Text = "Condiciones almacen"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tbpResiduos
        '
        Me.tbpResiduos.Controls.Add(Me.Label10)
        Me.tbpResiduos.Location = New System.Drawing.Point(4, 22)
        Me.tbpResiduos.Name = "tbpResiduos"
        Me.tbpResiduos.Size = New System.Drawing.Size(678, 427)
        Me.tbpResiduos.TabIndex = 2
        Me.tbpResiduos.Text = "Gestion residuos"
        Me.tbpResiduos.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label10.Location = New System.Drawing.Point(28, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 21)
        Me.Label10.TabIndex = 1000000006
        Me.Label10.Text = "Gestion envases vacios"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmWstepIngredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(949, 532)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frmWstepIngredientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmWstepIngredientes"
        Me.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.panNuevoTipoProducto.ResumeLayout(False)
        Me.panNuevoTipoProducto.PerformLayout()
        Me.pantipoProducto.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.tbpCertificados.ResumeLayout(False)
        Me.tbpCertificados.PerformLayout()
        Me.tbpCondiciones.ResumeLayout(False)
        Me.tbpResiduos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboEstado As System.Windows.Forms.ComboBox
    Private WithEvents Label14 As System.Windows.Forms.Label
    Private WithEvents btnAddTipo As System.Windows.Forms.Button
    Private WithEvents cboIngredienteTipoID As System.Windows.Forms.ComboBox
    Private WithEvents lblIngredienteTipoID As System.Windows.Forms.Label
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tbpCondiciones As System.Windows.Forms.TabPage
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents tbpResiduos As System.Windows.Forms.TabPage
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents btnañadirEstado As System.Windows.Forms.Button
    Private WithEvents tbpCertificados As System.Windows.Forms.TabPage
    Private WithEvents gbCertificados As System.Windows.Forms.GroupBox
    Private WithEvents cbCreartipoProducto As System.Windows.Forms.CheckBox
    Private WithEvents panNuevoTipoProducto As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents CuadroDeTexto1 As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAbreviatura As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblAbreviatura As System.Windows.Forms.Label
    Private WithEvents chEnologico As System.Windows.Forms.CheckBox
    Private WithEvents cbMedidas As System.Windows.Forms.ComboBox
    Private WithEvents pantipoProducto As System.Windows.Forms.Panel
    Private WithEvents cboTipoProducto As System.Windows.Forms.ComboBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents btnAddTProducto As System.Windows.Forms.Button
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtDensidad As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents cboUnidad As System.Windows.Forms.ComboBox
End Class
