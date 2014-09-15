<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEnvasadosProductosArticulos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntEnvasadosProductosArticulos))
        Me.txtEnvasadoProductoArticuloID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtFormatoEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butVerLoteTerminadoID = New System.Windows.Forms.Button()
        Me.txtCantidadAsignada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblEnvasadoProductoArticuloID = New System.Windows.Forms.Label()
        Me.lblFormatoEnvasadoID = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidadResta = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCantidadLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCantidadRestante = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLitrosLote = New System.Windows.Forms.Label()
        Me.txtCantidadAsiganadaPrevia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLitrosEnvasados = New System.Windows.Forms.Label()
        Me.txtCantidadEnvasada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDensidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblLitros = New System.Windows.Forms.Label()
        Me.gpbMermas = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCantidadEnvasadaAnterior = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCantidadMermas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCantidadPreparada = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtPorcentajeMermas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtCantidadEnvasadaTotal = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCantidadRestaLote = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.cbMermaPositiva = New System.Windows.Forms.CheckBox()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.cbMerma = New System.Windows.Forms.CheckBox()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.dgvLotes = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel17 = New System.Windows.Forms.Panel()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.Panel9 = New System.Windows.Forms.Panel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.gpbMermas.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel10.SuspendLayout()
        Me.Panel15.SuspendLayout()
        Me.Panel14.SuspendLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel17.SuspendLayout()
        Me.Panel7.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'txtEnvasadoProductoArticuloID
        '
        Me.txtEnvasadoProductoArticuloID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoProductoArticuloID.EsUnicoCampo = ""
        Me.txtEnvasadoProductoArticuloID.EsUnicoCampoID = ""
        Me.txtEnvasadoProductoArticuloID.EsUnicoID = 0
        Me.txtEnvasadoProductoArticuloID.EsUnicoTabla = ""
        Me.txtEnvasadoProductoArticuloID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvasadoProductoArticuloID.Location = New System.Drawing.Point(186, 3)
        Me.txtEnvasadoProductoArticuloID.MaxLength = 9
        Me.txtEnvasadoProductoArticuloID.Minimo = 0
        Me.txtEnvasadoProductoArticuloID.Modificado = False
        Me.txtEnvasadoProductoArticuloID.Name = "txtEnvasadoProductoArticuloID"
        Me.txtEnvasadoProductoArticuloID.Numerico_EsNumerico = False
        Me.txtEnvasadoProductoArticuloID.Numerico_NumeroDoublees = 0
        Me.txtEnvasadoProductoArticuloID.Numerico_SeparadorMiles = False
        Me.txtEnvasadoProductoArticuloID.Obligatorio = True
        Me.txtEnvasadoProductoArticuloID.ParametroID = 0
        Me.txtEnvasadoProductoArticuloID.Size = New System.Drawing.Size(56, 21)
        Me.txtEnvasadoProductoArticuloID.TabIndex = 1
        Me.txtEnvasadoProductoArticuloID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEnvasadoProductoArticuloID.ValorMaximo = 0.0R
        Me.txtEnvasadoProductoArticuloID.ValorMinimo = 0.0R
        Me.txtEnvasadoProductoArticuloID.Visible = False
        '
        'txtFormatoEnvasadoID
        '
        Me.txtFormatoEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtFormatoEnvasadoID.EsUnicoCampo = ""
        Me.txtFormatoEnvasadoID.EsUnicoCampoID = ""
        Me.txtFormatoEnvasadoID.EsUnicoID = 0
        Me.txtFormatoEnvasadoID.EsUnicoTabla = ""
        Me.txtFormatoEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFormatoEnvasadoID.Location = New System.Drawing.Point(351, 3)
        Me.txtFormatoEnvasadoID.MaxLength = 9
        Me.txtFormatoEnvasadoID.Minimo = 0
        Me.txtFormatoEnvasadoID.Modificado = False
        Me.txtFormatoEnvasadoID.Name = "txtFormatoEnvasadoID"
        Me.txtFormatoEnvasadoID.Numerico_EsNumerico = False
        Me.txtFormatoEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtFormatoEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtFormatoEnvasadoID.Obligatorio = False
        Me.txtFormatoEnvasadoID.ParametroID = 0
        Me.txtFormatoEnvasadoID.Size = New System.Drawing.Size(68, 21)
        Me.txtFormatoEnvasadoID.TabIndex = 3
        Me.txtFormatoEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtFormatoEnvasadoID.ValorMaximo = 0.0R
        Me.txtFormatoEnvasadoID.ValorMinimo = 0.0R
        Me.txtFormatoEnvasadoID.Visible = False
        '
        'butVerLoteTerminadoID
        '
        Me.butVerLoteTerminadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerLoteTerminadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerLoteTerminadoID.Location = New System.Drawing.Point(669, 5)
        Me.butVerLoteTerminadoID.Name = "butVerLoteTerminadoID"
        Me.butVerLoteTerminadoID.Size = New System.Drawing.Size(20, 20)
        Me.butVerLoteTerminadoID.TabIndex = 8
        Me.butVerLoteTerminadoID.TabStop = False
        '
        'txtCantidadAsignada
        '
        Me.txtCantidadAsignada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadAsignada.EsUnicoCampo = ""
        Me.txtCantidadAsignada.EsUnicoCampoID = ""
        Me.txtCantidadAsignada.EsUnicoID = 0
        Me.txtCantidadAsignada.EsUnicoTabla = ""
        Me.txtCantidadAsignada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAsignada.Location = New System.Drawing.Point(229, 56)
        Me.txtCantidadAsignada.MaxLength = 9
        Me.txtCantidadAsignada.Minimo = 0
        Me.txtCantidadAsignada.Modificado = False
        Me.txtCantidadAsignada.Name = "txtCantidadAsignada"
        Me.txtCantidadAsignada.Numerico_EsNumerico = True
        Me.txtCantidadAsignada.Numerico_NumeroDoublees = 0
        Me.txtCantidadAsignada.Numerico_SeparadorMiles = True
        Me.txtCantidadAsignada.Obligatorio = False
        Me.txtCantidadAsignada.ParametroID = 0
        Me.txtCantidadAsignada.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadAsignada.TabIndex = 11
        Me.txtCantidadAsignada.TabStop = False
        Me.txtCantidadAsignada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadAsignada.ValorMaximo = 0.0R
        Me.txtCantidadAsignada.ValorMinimo = 0.0R
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(84, 15)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(844, 21)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblEnvasadoProductoArticuloID
        '
        Me.lblEnvasadoProductoArticuloID.Location = New System.Drawing.Point(23, 0)
        Me.lblEnvasadoProductoArticuloID.Name = "lblEnvasadoProductoArticuloID"
        Me.lblEnvasadoProductoArticuloID.Size = New System.Drawing.Size(157, 21)
        Me.lblEnvasadoProductoArticuloID.TabIndex = 0
        Me.lblEnvasadoProductoArticuloID.Text = "EnvasadoProductoArticuloID"
        Me.lblEnvasadoProductoArticuloID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblEnvasadoProductoArticuloID.Visible = False
        '
        'lblFormatoEnvasadoID
        '
        Me.lblFormatoEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.lblFormatoEnvasadoID.Location = New System.Drawing.Point(248, 3)
        Me.lblFormatoEnvasadoID.Name = "lblFormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.Size = New System.Drawing.Size(97, 21)
        Me.lblFormatoEnvasadoID.TabIndex = 2
        Me.lblFormatoEnvasadoID.Text = "FormatoEnvasadoID"
        Me.lblFormatoEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFormatoEnvasadoID.Visible = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblObservaciones.Location = New System.Drawing.Point(0, 15)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 25)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 424.0!))
        Me.tlpMiddle.Controls.Add(Me.lblEnvasadoProductoArticuloID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtEnvasadoProductoArticuloID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.txtFormatoEnvasadoID, 5, 0)
        Me.tlpMiddle.Controls.Add(Me.lblFormatoEnvasadoID, 4, 0)
        Me.tlpMiddle.Location = New System.Drawing.Point(18, 6)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 5
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.Size = New System.Drawing.Size(844, 66)
        Me.tlpMiddle.TabIndex = 1
        Me.tlpMiddle.Visible = False
        '
        'tlpTop
        '




        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(0, 82)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 21)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Cantidad restante por asignar"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadResta
        '
        Me.txtCantidadResta.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadResta.Enabled = False
        Me.txtCantidadResta.EsUnicoCampo = ""
        Me.txtCantidadResta.EsUnicoCampoID = ""
        Me.txtCantidadResta.EsUnicoID = 0
        Me.txtCantidadResta.EsUnicoTabla = ""
        Me.txtCantidadResta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadResta.Location = New System.Drawing.Point(229, 84)
        Me.txtCantidadResta.MaxLength = 500
        Me.txtCantidadResta.Minimo = 0
        Me.txtCantidadResta.Modificado = False
        Me.txtCantidadResta.Name = "txtCantidadResta"
        Me.txtCantidadResta.Numerico_EsNumerico = True
        Me.txtCantidadResta.Numerico_NumeroDoublees = 0
        Me.txtCantidadResta.Numerico_SeparadorMiles = True
        Me.txtCantidadResta.Obligatorio = False
        Me.txtCantidadResta.ParametroID = 0
        Me.txtCantidadResta.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadResta.TabIndex = 13
        Me.txtCantidadResta.TabStop = False
        Me.txtCantidadResta.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadResta.ValorMaximo = 0.0R
        Me.txtCantidadResta.ValorMinimo = 0.0R
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(0, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(181, 21)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cantidad que asignamos del lote"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(0, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 21)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Cantidad del lote"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadLote
        '
        Me.txtCantidadLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadLote.Enabled = False
        Me.txtCantidadLote.EsUnicoCampo = ""
        Me.txtCantidadLote.EsUnicoCampoID = ""
        Me.txtCantidadLote.EsUnicoID = 0
        Me.txtCantidadLote.EsUnicoTabla = ""
        Me.txtCantidadLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadLote.Location = New System.Drawing.Point(229, 27)
        Me.txtCantidadLote.MaxLength = 500
        Me.txtCantidadLote.Minimo = 0
        Me.txtCantidadLote.Modificado = False
        Me.txtCantidadLote.Name = "txtCantidadLote"
        Me.txtCantidadLote.Numerico_EsNumerico = True
        Me.txtCantidadLote.Numerico_NumeroDoublees = 0
        Me.txtCantidadLote.Numerico_SeparadorMiles = True
        Me.txtCantidadLote.Obligatorio = False
        Me.txtCantidadLote.ParametroID = 0
        Me.txtCantidadLote.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadLote.TabIndex = 9
        Me.txtCantidadLote.TabStop = False
        Me.txtCantidadLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadLote.ValorMaximo = 0.0R
        Me.txtCantidadLote.ValorMinimo = 0.0R
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(0, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 21)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Cantidad restante"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadRestante
        '
        Me.txtCantidadRestante.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadRestante.Enabled = False
        Me.txtCantidadRestante.EsUnicoCampo = ""
        Me.txtCantidadRestante.EsUnicoCampoID = ""
        Me.txtCantidadRestante.EsUnicoID = 0
        Me.txtCantidadRestante.EsUnicoTabla = ""
        Me.txtCantidadRestante.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRestante.Location = New System.Drawing.Point(229, 80)
        Me.txtCantidadRestante.MaxLength = 500
        Me.txtCantidadRestante.Minimo = 0
        Me.txtCantidadRestante.Modificado = False
        Me.txtCantidadRestante.Name = "txtCantidadRestante"
        Me.txtCantidadRestante.Numerico_EsNumerico = True
        Me.txtCantidadRestante.Numerico_NumeroDoublees = 0
        Me.txtCantidadRestante.Numerico_SeparadorMiles = True
        Me.txtCantidadRestante.Obligatorio = False
        Me.txtCantidadRestante.ParametroID = 0
        Me.txtCantidadRestante.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadRestante.TabIndex = 5
        Me.txtCantidadRestante.TabStop = False
        Me.txtCantidadRestante.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadRestante.ValorMaximo = 0.0R
        Me.txtCantidadRestante.ValorMinimo = 0.0R
        '
        'lblLitrosLote
        '
        Me.lblLitrosLote.Location = New System.Drawing.Point(0, 54)
        Me.lblLitrosLote.Name = "lblLitrosLote"
        Me.lblLitrosLote.Size = New System.Drawing.Size(163, 21)
        Me.lblLitrosLote.TabIndex = 2
        Me.lblLitrosLote.Text = "Cantidad asignada hasta ahora"
        Me.lblLitrosLote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadAsiganadaPrevia
        '
        Me.txtCantidadAsiganadaPrevia.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadAsiganadaPrevia.Enabled = False
        Me.txtCantidadAsiganadaPrevia.EsUnicoCampo = ""
        Me.txtCantidadAsiganadaPrevia.EsUnicoCampoID = ""
        Me.txtCantidadAsiganadaPrevia.EsUnicoID = 0
        Me.txtCantidadAsiganadaPrevia.EsUnicoTabla = ""
        Me.txtCantidadAsiganadaPrevia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadAsiganadaPrevia.Location = New System.Drawing.Point(229, 54)
        Me.txtCantidadAsiganadaPrevia.MaxLength = 500
        Me.txtCantidadAsiganadaPrevia.Minimo = 0
        Me.txtCantidadAsiganadaPrevia.Modificado = False
        Me.txtCantidadAsiganadaPrevia.Name = "txtCantidadAsiganadaPrevia"
        Me.txtCantidadAsiganadaPrevia.Numerico_EsNumerico = True
        Me.txtCantidadAsiganadaPrevia.Numerico_NumeroDoublees = 0
        Me.txtCantidadAsiganadaPrevia.Numerico_SeparadorMiles = True
        Me.txtCantidadAsiganadaPrevia.Obligatorio = False
        Me.txtCantidadAsiganadaPrevia.ParametroID = 0
        Me.txtCantidadAsiganadaPrevia.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadAsiganadaPrevia.TabIndex = 3
        Me.txtCantidadAsiganadaPrevia.TabStop = False
        Me.txtCantidadAsiganadaPrevia.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadAsiganadaPrevia.ValorMaximo = 0.0R
        Me.txtCantidadAsiganadaPrevia.ValorMinimo = 0.0R
        '
        'lblLitrosEnvasados
        '
        Me.lblLitrosEnvasados.Location = New System.Drawing.Point(0, 30)
        Me.lblLitrosEnvasados.Name = "lblLitrosEnvasados"
        Me.lblLitrosEnvasados.Size = New System.Drawing.Size(104, 21)
        Me.lblLitrosEnvasados.TabIndex = 0
        Me.lblLitrosEnvasados.Text = "Cantidad envasada"
        Me.lblLitrosEnvasados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadEnvasada
        '
        Me.txtCantidadEnvasada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadEnvasada.Enabled = False
        Me.txtCantidadEnvasada.EsUnicoCampo = ""
        Me.txtCantidadEnvasada.EsUnicoCampoID = ""
        Me.txtCantidadEnvasada.EsUnicoID = 0
        Me.txtCantidadEnvasada.EsUnicoTabla = ""
        Me.txtCantidadEnvasada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEnvasada.Location = New System.Drawing.Point(229, 30)
        Me.txtCantidadEnvasada.MaxLength = 500
        Me.txtCantidadEnvasada.Minimo = 0
        Me.txtCantidadEnvasada.Modificado = False
        Me.txtCantidadEnvasada.Name = "txtCantidadEnvasada"
        Me.txtCantidadEnvasada.Numerico_EsNumerico = True
        Me.txtCantidadEnvasada.Numerico_NumeroDoublees = 0
        Me.txtCantidadEnvasada.Numerico_SeparadorMiles = True
        Me.txtCantidadEnvasada.Obligatorio = False
        Me.txtCantidadEnvasada.ParametroID = 0
        Me.txtCantidadEnvasada.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadEnvasada.TabIndex = 1
        Me.txtCantidadEnvasada.TabStop = False
        Me.txtCantidadEnvasada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadEnvasada.ValorMaximo = 0.0R
        Me.txtCantidadEnvasada.ValorMinimo = 0.0R
        '
        'txtDensidad
        '
        Me.txtDensidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtDensidad.Enabled = False
        Me.txtDensidad.EsUnicoCampo = ""
        Me.txtDensidad.EsUnicoCampoID = ""
        Me.txtDensidad.EsUnicoID = 0
        Me.txtDensidad.EsUnicoTabla = ""
        Me.txtDensidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDensidad.Location = New System.Drawing.Point(440, 26)
        Me.txtDensidad.MaxLength = 500
        Me.txtDensidad.Minimo = 0
        Me.txtDensidad.Modificado = False
        Me.txtDensidad.Name = "txtDensidad"
        Me.txtDensidad.Numerico_EsNumerico = True
        Me.txtDensidad.Numerico_NumeroDoublees = 4
        Me.txtDensidad.Numerico_SeparadorMiles = False
        Me.txtDensidad.Obligatorio = False
        Me.txtDensidad.ParametroID = 0
        Me.txtDensidad.Size = New System.Drawing.Size(42, 21)
        Me.txtDensidad.TabIndex = 7
        Me.txtDensidad.TabStop = False
        Me.txtDensidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDensidad.ValorMaximo = 0.0R
        Me.txtDensidad.ValorMinimo = 0.0R
        Me.txtDensidad.Visible = False
        '
        'lblLitros
        '
        Me.lblLitros.Location = New System.Drawing.Point(337, 27)
        Me.lblLitros.Name = "lblLitros"
        Me.lblLitros.Size = New System.Drawing.Size(119, 21)
        Me.lblLitros.TabIndex = 6
        Me.lblLitros.Text = "litros con densidad = "
        Me.lblLitros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblLitros.Visible = False
        '
        'gpbMermas
        '
        Me.gpbMermas.Controls.Add(Me.Label11)
        Me.gpbMermas.Controls.Add(Me.Label10)
        Me.gpbMermas.Controls.Add(Me.txtCantidadEnvasadaAnterior)
        Me.gpbMermas.Controls.Add(Me.Label9)
        Me.gpbMermas.Controls.Add(Me.txtCantidadMermas)
        Me.gpbMermas.Controls.Add(Me.txtCantidadPreparada)
        Me.gpbMermas.Controls.Add(Me.Label6)
        Me.gpbMermas.Controls.Add(Me.txtPorcentajeMermas)
        Me.gpbMermas.Controls.Add(Me.Label8)
        Me.gpbMermas.Controls.Add(Me.Label5)
        Me.gpbMermas.Controls.Add(Me.txtCantidadEnvasadaTotal)
        Me.gpbMermas.Dock = System.Windows.Forms.DockStyle.Right
        Me.gpbMermas.Location = New System.Drawing.Point(552, 190)
        Me.gpbMermas.Name = "gpbMermas"
        Me.gpbMermas.Size = New System.Drawing.Size(376, 178)
        Me.gpbMermas.TabIndex = 7
        Me.gpbMermas.TabStop = False
        Me.gpbMermas.Text = "Mermas"
        Me.gpbMermas.Visible = False
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(68, 98)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(95, 9)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "(incluido este movimiento)"
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label10.Location = New System.Drawing.Point(68, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 21)
        Me.Label10.TabIndex = 4
        Me.Label10.Text = "Cantidad envasada"
        Me.Label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadEnvasadaAnterior
        '
        Me.txtCantidadEnvasadaAnterior.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadEnvasadaAnterior.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadEnvasadaAnterior.EsUnicoCampo = ""
        Me.txtCantidadEnvasadaAnterior.EsUnicoCampoID = ""
        Me.txtCantidadEnvasadaAnterior.EsUnicoID = 0
        Me.txtCantidadEnvasadaAnterior.EsUnicoTabla = ""
        Me.txtCantidadEnvasadaAnterior.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEnvasadaAnterior.Location = New System.Drawing.Point(251, 53)
        Me.txtCantidadEnvasadaAnterior.MaxLength = 500
        Me.txtCantidadEnvasadaAnterior.Minimo = 0
        Me.txtCantidadEnvasadaAnterior.Modificado = False
        Me.txtCantidadEnvasadaAnterior.Name = "txtCantidadEnvasadaAnterior"
        Me.txtCantidadEnvasadaAnterior.Numerico_EsNumerico = True
        Me.txtCantidadEnvasadaAnterior.Numerico_NumeroDoublees = 0
        Me.txtCantidadEnvasadaAnterior.Numerico_SeparadorMiles = True
        Me.txtCantidadEnvasadaAnterior.Obligatorio = False
        Me.txtCantidadEnvasadaAnterior.ParametroID = 0
        Me.txtCantidadEnvasadaAnterior.Size = New System.Drawing.Size(68, 21)
        Me.txtCantidadEnvasadaAnterior.TabIndex = 3
        Me.txtCantidadEnvasadaAnterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadEnvasadaAnterior.ValorMaximo = 0.0R
        Me.txtCantidadEnvasadaAnterior.ValorMinimo = 0.0R
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label9.Location = New System.Drawing.Point(68, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 21)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "Cantidad mermas"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadMermas
        '
        Me.txtCantidadMermas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadMermas.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadMermas.EsUnicoCampo = ""
        Me.txtCantidadMermas.EsUnicoCampoID = ""
        Me.txtCantidadMermas.EsUnicoID = 0
        Me.txtCantidadMermas.EsUnicoTabla = ""
        Me.txtCantidadMermas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadMermas.Location = New System.Drawing.Point(251, 115)
        Me.txtCantidadMermas.MaxLength = 500
        Me.txtCantidadMermas.Minimo = 0
        Me.txtCantidadMermas.Modificado = False
        Me.txtCantidadMermas.Name = "txtCantidadMermas"
        Me.txtCantidadMermas.Numerico_EsNumerico = True
        Me.txtCantidadMermas.Numerico_NumeroDoublees = 0
        Me.txtCantidadMermas.Numerico_SeparadorMiles = True
        Me.txtCantidadMermas.Obligatorio = False
        Me.txtCantidadMermas.ParametroID = 0
        Me.txtCantidadMermas.Size = New System.Drawing.Size(68, 21)
        Me.txtCantidadMermas.TabIndex = 7
        Me.txtCantidadMermas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadMermas.ValorMaximo = 0.0R
        Me.txtCantidadMermas.ValorMinimo = 0.0R
        '
        'txtCantidadPreparada
        '
        Me.txtCantidadPreparada.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadPreparada.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadPreparada.EsUnicoCampo = ""
        Me.txtCantidadPreparada.EsUnicoCampoID = ""
        Me.txtCantidadPreparada.EsUnicoID = 0
        Me.txtCantidadPreparada.EsUnicoTabla = ""
        Me.txtCantidadPreparada.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadPreparada.Location = New System.Drawing.Point(251, 29)
        Me.txtCantidadPreparada.MaxLength = 500
        Me.txtCantidadPreparada.Minimo = 0
        Me.txtCantidadPreparada.Modificado = False
        Me.txtCantidadPreparada.Name = "txtCantidadPreparada"
        Me.txtCantidadPreparada.Numerico_EsNumerico = True
        Me.txtCantidadPreparada.Numerico_NumeroDoublees = 0
        Me.txtCantidadPreparada.Numerico_SeparadorMiles = True
        Me.txtCantidadPreparada.Obligatorio = False
        Me.txtCantidadPreparada.ParametroID = 0
        Me.txtCantidadPreparada.Size = New System.Drawing.Size(68, 21)
        Me.txtCantidadPreparada.TabIndex = 1
        Me.txtCantidadPreparada.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadPreparada.ValorMaximo = 0.0R
        Me.txtCantidadPreparada.ValorMinimo = 0.0R
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label6.Location = New System.Drawing.Point(68, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 21)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Cantidad preparada"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPorcentajeMermas
        '
        Me.txtPorcentajeMermas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtPorcentajeMermas.BackColor = System.Drawing.SystemColors.Window
        Me.txtPorcentajeMermas.EsUnicoCampo = ""
        Me.txtPorcentajeMermas.EsUnicoCampoID = ""
        Me.txtPorcentajeMermas.EsUnicoID = 0
        Me.txtPorcentajeMermas.EsUnicoTabla = ""
        Me.txtPorcentajeMermas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPorcentajeMermas.Location = New System.Drawing.Point(251, 142)
        Me.txtPorcentajeMermas.MaxLength = 500
        Me.txtPorcentajeMermas.Minimo = 0
        Me.txtPorcentajeMermas.Modificado = False
        Me.txtPorcentajeMermas.Name = "txtPorcentajeMermas"
        Me.txtPorcentajeMermas.Numerico_EsNumerico = True
        Me.txtPorcentajeMermas.Numerico_NumeroDoublees = 2
        Me.txtPorcentajeMermas.Numerico_SeparadorMiles = False
        Me.txtPorcentajeMermas.Obligatorio = False
        Me.txtPorcentajeMermas.ParametroID = 0
        Me.txtPorcentajeMermas.Size = New System.Drawing.Size(68, 21)
        Me.txtPorcentajeMermas.TabIndex = 9
        Me.txtPorcentajeMermas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPorcentajeMermas.ValorMaximo = 0.0R
        Me.txtPorcentajeMermas.ValorMinimo = 0.0R
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.Location = New System.Drawing.Point(68, 53)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 21)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Cantidad envasada anteriormente"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.Location = New System.Drawing.Point(219, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(26, 21)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "% "
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadEnvasadaTotal
        '
        Me.txtCantidadEnvasadaTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCantidadEnvasadaTotal.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadEnvasadaTotal.EsUnicoCampo = ""
        Me.txtCantidadEnvasadaTotal.EsUnicoCampoID = ""
        Me.txtCantidadEnvasadaTotal.EsUnicoID = 0
        Me.txtCantidadEnvasadaTotal.EsUnicoTabla = ""
        Me.txtCantidadEnvasadaTotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadEnvasadaTotal.Location = New System.Drawing.Point(251, 80)
        Me.txtCantidadEnvasadaTotal.MaxLength = 500
        Me.txtCantidadEnvasadaTotal.Minimo = 0
        Me.txtCantidadEnvasadaTotal.Modificado = False
        Me.txtCantidadEnvasadaTotal.Name = "txtCantidadEnvasadaTotal"
        Me.txtCantidadEnvasadaTotal.Numerico_EsNumerico = True
        Me.txtCantidadEnvasadaTotal.Numerico_NumeroDoublees = 0
        Me.txtCantidadEnvasadaTotal.Numerico_SeparadorMiles = True
        Me.txtCantidadEnvasadaTotal.Obligatorio = False
        Me.txtCantidadEnvasadaTotal.ParametroID = 0
        Me.txtCantidadEnvasadaTotal.Size = New System.Drawing.Size(68, 21)
        Me.txtCantidadEnvasadaTotal.TabIndex = 5
        Me.txtCantidadEnvasadaTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadEnvasadaTotal.ValorMaximo = 0.0R
        Me.txtCantidadEnvasadaTotal.ValorMinimo = 0.0R
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(0, 107)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 21)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Cantidad restante del lote"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCantidadRestaLote
        '
        Me.txtCantidadRestaLote.BackColor = System.Drawing.SystemColors.Window
        Me.txtCantidadRestaLote.Enabled = False
        Me.txtCantidadRestaLote.EsUnicoCampo = ""
        Me.txtCantidadRestaLote.EsUnicoCampoID = ""
        Me.txtCantidadRestaLote.EsUnicoID = 0
        Me.txtCantidadRestaLote.EsUnicoTabla = ""
        Me.txtCantidadRestaLote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCantidadRestaLote.Location = New System.Drawing.Point(229, 109)
        Me.txtCantidadRestaLote.MaxLength = 500
        Me.txtCantidadRestaLote.Minimo = 0
        Me.txtCantidadRestaLote.Modificado = False
        Me.txtCantidadRestaLote.Name = "txtCantidadRestaLote"
        Me.txtCantidadRestaLote.Numerico_EsNumerico = True
        Me.txtCantidadRestaLote.Numerico_NumeroDoublees = 0
        Me.txtCantidadRestaLote.Numerico_SeparadorMiles = True
        Me.txtCantidadRestaLote.Obligatorio = False
        Me.txtCantidadRestaLote.ParametroID = 0
        Me.txtCantidadRestaLote.Size = New System.Drawing.Size(94, 21)
        Me.txtCantidadRestaLote.TabIndex = 15
        Me.txtCantidadRestaLote.TabStop = False
        Me.txtCantidadRestaLote.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCantidadRestaLote.ValorMaximo = 0.0R
        Me.txtCantidadRestaLote.ValorMinimo = 0.0R
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel10)
        Me.Panel1.Controls.Add(Me.txtCantidadEnvasada)
        Me.Panel1.Controls.Add(Me.lblLitrosEnvasados)
        Me.Panel1.Controls.Add(Me.txtCantidadAsiganadaPrevia)
        Me.Panel1.Controls.Add(Me.lblLitrosLote)
        Me.Panel1.Controls.Add(Me.txtCantidadRestante)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.Panel18)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 50)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(928, 140)
        Me.Panel1.TabIndex = 4
        '
        'Panel10
        '
        Me.Panel10.Controls.Add(Me.Panel16)
        Me.Panel10.Controls.Add(Me.Panel15)
        Me.Panel10.Controls.Add(Me.Panel14)
        Me.Panel10.Controls.Add(Me.Panel12)
        Me.Panel10.Controls.Add(Me.Panel13)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel10.Location = New System.Drawing.Point(626, 0)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(238, 140)
        Me.Panel10.TabIndex = 9
        '
        'Panel16
        '
        Me.Panel16.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel16.Location = New System.Drawing.Point(0, 68)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(238, 12)
        Me.Panel16.TabIndex = 11
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.cbMermaPositiva)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel15.Location = New System.Drawing.Point(0, 16)
        Me.Panel15.Name = "Panel15"
        Me.Panel15.Size = New System.Drawing.Size(238, 52)
        Me.Panel15.TabIndex = 10
        '
        'cbMermaPositiva
        '
        Me.cbMermaPositiva.AutoSize = True
        Me.cbMermaPositiva.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMermaPositiva.Location = New System.Drawing.Point(0, 0)
        Me.cbMermaPositiva.Name = "cbMermaPositiva"
        Me.cbMermaPositiva.Size = New System.Drawing.Size(238, 52)
        Me.cbMermaPositiva.TabIndex = 1
        Me.cbMermaPositiva.Text = "Se envasa + de lo que tenia el lote. Merma Positiva"
        Me.cbMermaPositiva.UseVisualStyleBackColor = True
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.cbMerma)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel14.Location = New System.Drawing.Point(0, 80)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(238, 47)
        Me.Panel14.TabIndex = 9
        '
        'cbMerma
        '
        Me.cbMerma.AutoSize = True
        Me.cbMerma.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cbMerma.Location = New System.Drawing.Point(0, 0)
        Me.cbMerma.Name = "cbMerma"
        Me.cbMerma.Size = New System.Drawing.Size(238, 47)
        Me.cbMerma.TabIndex = 0
        Me.cbMerma.Text = "En realidad el lote se queda a 0. Hay que calcular mermas."
        Me.cbMerma.UseVisualStyleBackColor = True
        '
        'Panel12
        '
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel12.Location = New System.Drawing.Point(0, 0)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(238, 16)
        Me.Panel12.TabIndex = 7
        '
        'Panel13
        '
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel13.Location = New System.Drawing.Point(0, 127)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(238, 13)
        Me.Panel13.TabIndex = 8
        '
        'Panel18
        '
        Me.Panel18.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel18.Location = New System.Drawing.Point(864, 0)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(64, 140)
        Me.Panel18.TabIndex = 10
        '
        'dgvLotes
        '
        Me.dgvLotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLotes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvLotes.Location = New System.Drawing.Point(22, 21)
        Me.dgvLotes.MultiSelect = False
        Me.dgvLotes.Name = "dgvLotes"
        Me.dgvLotes.RowTemplate.Height = 24
        Me.dgvLotes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLotes.Size = New System.Drawing.Size(928, 266)
        Me.dgvLotes.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dgvLotes)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Controls.Add(Me.Panel5)
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 25)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(974, 682)
        Me.Panel2.TabIndex = 9
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.gpbMermas)
        Me.Panel3.Controls.Add(Me.Panel17)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.Panel7)
        Me.Panel3.Controls.Add(Me.Panel11)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(22, 287)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(928, 395)
        Me.Panel3.TabIndex = 10
        '
        'Panel17
        '
        Me.Panel17.Controls.Add(Me.Label2)
        Me.Panel17.Controls.Add(Me.txtDensidad)
        Me.Panel17.Controls.Add(Me.Label7)
        Me.Panel17.Controls.Add(Me.Label3)
        Me.Panel17.Controls.Add(Me.txtCantidadLote)
        Me.Panel17.Controls.Add(Me.txtCantidadResta)
        Me.Panel17.Controls.Add(Me.Label4)
        Me.Panel17.Controls.Add(Me.txtCantidadRestaLote)
        Me.Panel17.Controls.Add(Me.txtCantidadAsignada)
        Me.Panel17.Controls.Add(Me.lblLitros)
        Me.Panel17.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel17.Location = New System.Drawing.Point(0, 190)
        Me.Panel17.Name = "Panel17"
        Me.Panel17.Size = New System.Drawing.Size(504, 178)
        Me.Panel17.TabIndex = 11
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.txtObservaciones)
        Me.Panel7.Controls.Add(Me.lblObservaciones)
        Me.Panel7.Controls.Add(Me.Panel8)
        Me.Panel7.Controls.Add(Me.Panel9)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel7.Location = New System.Drawing.Point(0, 0)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(928, 50)
        Me.Panel7.TabIndex = 8
        '
        'Panel8
        '
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel8.Location = New System.Drawing.Point(0, 0)
        Me.Panel8.Name = "Panel8"
        Me.Panel8.Size = New System.Drawing.Size(928, 15)
        Me.Panel8.TabIndex = 4
        '
        'Panel9
        '
        Me.Panel9.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel9.Location = New System.Drawing.Point(0, 40)
        Me.Panel9.Name = "Panel9"
        Me.Panel9.Size = New System.Drawing.Size(928, 10)
        Me.Panel9.TabIndex = 5
        '
        'Panel11
        '
        Me.Panel11.Controls.Add(Me.tlpMiddle)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel11.Location = New System.Drawing.Point(0, 368)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(928, 27)
        Me.Panel11.TabIndex = 10
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(22, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(928, 21)
        Me.Panel6.TabIndex = 11
        '
        'Panel5
        '
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel5.Location = New System.Drawing.Point(0, 0)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(22, 682)
        Me.Panel5.TabIndex = 11
        '
        'Panel4
        '
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Right
        Me.Panel4.Location = New System.Drawing.Point(950, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(24, 682)
        Me.Panel4.TabIndex = 11
        '
        'frmEntEnvasadosProductosArticulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(974, 707)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.butVerLoteTerminadoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntEnvasadosProductosArticulos"
        Me.Text = "EnvasadosProductosArticulos"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.butVerLoteTerminadoID, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.gpbMermas.ResumeLayout(False)
        Me.gpbMermas.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel10.ResumeLayout(False)
        Me.Panel15.ResumeLayout(False)
        Me.Panel15.PerformLayout()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        CType(Me.dgvLotes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel17.ResumeLayout(False)
        Me.Panel17.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel11.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents butVerLoteTerminadoID As System.Windows.Forms.Button

   Private WithEvents Panel2 As System.Windows.Forms.Panel
   Private WithEvents Panel10 As System.Windows.Forms.Panel
   Private WithEvents Panel15 As System.Windows.Forms.Panel
   Private WithEvents Panel14 As System.Windows.Forms.Panel
   Private WithEvents Panel7 As System.Windows.Forms.Panel
   Private WithEvents Panel18 As System.Windows.Forms.Panel
    Private WithEvents txtEnvasadoProductoArticuloID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtFormatoEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCantidadAsignada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblEnvasadoProductoArticuloID As System.Windows.Forms.Label
    Private WithEvents lblFormatoEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtCantidadResta As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents txtCantidadLote As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtCantidadRestante As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLitrosLote As System.Windows.Forms.Label
    Private WithEvents txtCantidadAsiganadaPrevia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLitrosEnvasados As System.Windows.Forms.Label
    Private WithEvents txtCantidadEnvasada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDensidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblLitros As System.Windows.Forms.Label
    Private WithEvents gpbMermas As System.Windows.Forms.GroupBox
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents txtPorcentajeMermas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents txtCantidadMermas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label9 As System.Windows.Forms.Label
    Private WithEvents txtCantidadPreparada As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label8 As System.Windows.Forms.Label
    Private WithEvents txtCantidadEnvasadaTotal As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label7 As System.Windows.Forms.Label
    Private WithEvents txtCantidadRestaLote As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label10 As System.Windows.Forms.Label
    Private WithEvents txtCantidadEnvasadaAnterior As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents dgvLotes As System.Windows.Forms.DataGridView
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents Panel16 As System.Windows.Forms.Panel
    Private WithEvents Panel12 As System.Windows.Forms.Panel
    Private WithEvents Panel13 As System.Windows.Forms.Panel
    Private WithEvents Panel8 As System.Windows.Forms.Panel
    Private WithEvents Panel9 As System.Windows.Forms.Panel
    Private WithEvents Panel11 As System.Windows.Forms.Panel
    Private WithEvents cbMermaPositiva As System.Windows.Forms.CheckBox
    Private WithEvents cbMerma As System.Windows.Forms.CheckBox
    Private WithEvents Label11 As System.Windows.Forms.Label
    Private WithEvents Panel17 As System.Windows.Forms.Panel
End Class
