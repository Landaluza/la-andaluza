<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntEpis
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
        Me.txtEpiID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtMarca = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtModelo = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEpiTipoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRiesgoQuimico = New System.Windows.Forms.CheckBox()
        Me.txtRiesgoMecanico = New System.Windows.Forms.CheckBox()
        Me.txtRiesgoMicrobiologico = New System.Windows.Forms.CheckBox()
        Me.txtRiesgoFrio = New System.Windows.Forms.CheckBox()
        Me.txtRiesgoTermico = New System.Windows.Forms.CheckBox()
        Me.txtUsos = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtAdvertencias = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtaMecanico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtbMecanico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtcMecanico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtdMecanico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtaQuimico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtaMicrobiologico = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtaFrio = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtbFrio = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtcFrio = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblEpiID = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblMarca = New System.Windows.Forms.Label()
        Me.lblModelo = New System.Windows.Forms.Label()
        Me.lblEpiTipoID = New System.Windows.Forms.Label()
        Me.lblRiesgoQuimico = New System.Windows.Forms.Label()
        Me.lblRiesgoMecanico = New System.Windows.Forms.Label()
        Me.lblRiesgoMicrobiologico = New System.Windows.Forms.Label()
        Me.lblRiesgoFrio = New System.Windows.Forms.Label()
        Me.lblRiesgoTermico = New System.Windows.Forms.Label()
        Me.lblUsos = New System.Windows.Forms.Label()
        Me.lblAdvertencias = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblaMecanico = New System.Windows.Forms.Label()
        Me.lblbMecanico = New System.Windows.Forms.Label()
        Me.lblcMecanico = New System.Windows.Forms.Label()
        Me.lbldMecanico = New System.Windows.Forms.Label()
        Me.lblaQuimico = New System.Windows.Forms.Label()
        Me.lblaMicrobiologico = New System.Windows.Forms.Label()
        Me.lblaFrio = New System.Windows.Forms.Label()
        Me.lblbFrio = New System.Windows.Forms.Label()
        Me.lblcFrio = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        Me.cboEpisTipos = New System.Windows.Forms.ComboBox()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtEpiID
        '
        Me.txtEpiID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEpiID.EsUnicoCampo = ""
        Me.txtEpiID.EsUnicoCampoID = ""
        Me.txtEpiID.EsUnicoID = 0
        Me.txtEpiID.EsUnicoTabla = ""
        Me.txtEpiID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpiID.Location = New System.Drawing.Point(157, 3)
        Me.txtEpiID.MaxLength = 9
        Me.txtEpiID.Minimo = 0
        Me.txtEpiID.Modificado = False
        Me.txtEpiID.Name = "txtEpiID"
        Me.txtEpiID.Numerico_EsNumerico = False
        Me.txtEpiID.Numerico_NumeroDoublees = 0
        Me.txtEpiID.Numerico_SeparadorMiles = False
        Me.txtEpiID.Obligatorio = False
        Me.txtEpiID.ParametroID = 0
        Me.txtEpiID.Size = New System.Drawing.Size(56, 21)
        Me.txtEpiID.TabIndex = 0
        Me.txtEpiID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEpiID.ValorMaximo = 0.0!
        Me.txtEpiID.ValorMinimo = 0.0!
        Me.txtEpiID.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(157, 30)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = True
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtMarca
        '
        Me.txtMarca.BackColor = System.Drawing.SystemColors.Window
        Me.txtMarca.EsUnicoCampo = ""
        Me.txtMarca.EsUnicoCampoID = ""
        Me.txtMarca.EsUnicoID = 0
        Me.txtMarca.EsUnicoTabla = ""
        Me.txtMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtMarca.Location = New System.Drawing.Point(157, 57)
        Me.txtMarca.MaxLength = 200
        Me.txtMarca.Minimo = 0
        Me.txtMarca.Modificado = False
        Me.txtMarca.Name = "txtMarca"
        Me.txtMarca.Numerico_EsNumerico = False
        Me.txtMarca.Numerico_NumeroDoublees = 0
        Me.txtMarca.Numerico_SeparadorMiles = False
        Me.txtMarca.Obligatorio = False
        Me.txtMarca.ParametroID = 0
        Me.txtMarca.Size = New System.Drawing.Size(200, 21)
        Me.txtMarca.TabIndex = 2
        Me.txtMarca.ValorMaximo = 0.0!
        Me.txtMarca.ValorMinimo = 0.0!
        '
        'txtModelo
        '
        Me.txtModelo.BackColor = System.Drawing.SystemColors.Window
        Me.txtModelo.EsUnicoCampo = ""
        Me.txtModelo.EsUnicoCampoID = ""
        Me.txtModelo.EsUnicoID = 0
        Me.txtModelo.EsUnicoTabla = ""
        Me.txtModelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtModelo.Location = New System.Drawing.Point(157, 84)
        Me.txtModelo.MaxLength = 200
        Me.txtModelo.Minimo = 0
        Me.txtModelo.Modificado = False
        Me.txtModelo.Name = "txtModelo"
        Me.txtModelo.Numerico_EsNumerico = False
        Me.txtModelo.Numerico_NumeroDoublees = 0
        Me.txtModelo.Numerico_SeparadorMiles = False
        Me.txtModelo.Obligatorio = False
        Me.txtModelo.ParametroID = 0
        Me.txtModelo.Size = New System.Drawing.Size(200, 21)
        Me.txtModelo.TabIndex = 3
        Me.txtModelo.ValorMaximo = 0.0!
        Me.txtModelo.ValorMinimo = 0.0!
        '
        'txtEpiTipoID
        '
        Me.txtEpiTipoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEpiTipoID.EsUnicoCampo = ""
        Me.txtEpiTipoID.EsUnicoCampoID = ""
        Me.txtEpiTipoID.EsUnicoID = 0
        Me.txtEpiTipoID.EsUnicoTabla = ""
        Me.txtEpiTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEpiTipoID.Location = New System.Drawing.Point(443, 111)
        Me.txtEpiTipoID.MaxLength = 9
        Me.txtEpiTipoID.Minimo = 0
        Me.txtEpiTipoID.Modificado = False
        Me.txtEpiTipoID.Name = "txtEpiTipoID"
        Me.txtEpiTipoID.Numerico_EsNumerico = False
        Me.txtEpiTipoID.Numerico_NumeroDoublees = 0
        Me.txtEpiTipoID.Numerico_SeparadorMiles = False
        Me.txtEpiTipoID.Obligatorio = True
        Me.txtEpiTipoID.ParametroID = 0
        Me.txtEpiTipoID.Size = New System.Drawing.Size(56, 21)
        Me.txtEpiTipoID.TabIndex = 4
        Me.txtEpiTipoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEpiTipoID.ValorMaximo = 0.0!
        Me.txtEpiTipoID.ValorMinimo = 0.0!
        Me.txtEpiTipoID.Visible = False
        '
        'txtRiesgoQuimico
        '
        Me.txtRiesgoQuimico.BackColor = System.Drawing.SystemColors.Control
        Me.txtRiesgoQuimico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgoQuimico.Location = New System.Drawing.Point(157, 138)
        Me.txtRiesgoQuimico.Name = "txtRiesgoQuimico"
        Me.txtRiesgoQuimico.Size = New System.Drawing.Size(16, 21)
        Me.txtRiesgoQuimico.TabIndex = 5
        Me.txtRiesgoQuimico.UseVisualStyleBackColor = False
        '
        'txtRiesgoMecanico
        '
        Me.txtRiesgoMecanico.BackColor = System.Drawing.SystemColors.Control
        Me.txtRiesgoMecanico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgoMecanico.Location = New System.Drawing.Point(157, 165)
        Me.txtRiesgoMecanico.Name = "txtRiesgoMecanico"
        Me.txtRiesgoMecanico.Size = New System.Drawing.Size(16, 21)
        Me.txtRiesgoMecanico.TabIndex = 6
        Me.txtRiesgoMecanico.UseVisualStyleBackColor = False
        '
        'txtRiesgoMicrobiologico
        '
        Me.txtRiesgoMicrobiologico.BackColor = System.Drawing.SystemColors.Control
        Me.txtRiesgoMicrobiologico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgoMicrobiologico.Location = New System.Drawing.Point(157, 192)
        Me.txtRiesgoMicrobiologico.Name = "txtRiesgoMicrobiologico"
        Me.txtRiesgoMicrobiologico.Size = New System.Drawing.Size(16, 21)
        Me.txtRiesgoMicrobiologico.TabIndex = 7
        Me.txtRiesgoMicrobiologico.UseVisualStyleBackColor = False
        '
        'txtRiesgoFrio
        '
        Me.txtRiesgoFrio.BackColor = System.Drawing.SystemColors.Control
        Me.txtRiesgoFrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgoFrio.Location = New System.Drawing.Point(157, 219)
        Me.txtRiesgoFrio.Name = "txtRiesgoFrio"
        Me.txtRiesgoFrio.Size = New System.Drawing.Size(16, 21)
        Me.txtRiesgoFrio.TabIndex = 8
        Me.txtRiesgoFrio.UseVisualStyleBackColor = False
        '
        'txtRiesgoTermico
        '
        Me.txtRiesgoTermico.BackColor = System.Drawing.SystemColors.Control
        Me.txtRiesgoTermico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRiesgoTermico.Location = New System.Drawing.Point(157, 246)
        Me.txtRiesgoTermico.Name = "txtRiesgoTermico"
        Me.txtRiesgoTermico.Size = New System.Drawing.Size(16, 21)
        Me.txtRiesgoTermico.TabIndex = 9
        Me.txtRiesgoTermico.UseVisualStyleBackColor = False
        '
        'txtUsos
        '
        Me.txtUsos.BackColor = System.Drawing.SystemColors.Window
        Me.txtUsos.EsUnicoCampo = ""
        Me.txtUsos.EsUnicoCampoID = ""
        Me.txtUsos.EsUnicoID = 0
        Me.txtUsos.EsUnicoTabla = ""
        Me.txtUsos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUsos.Location = New System.Drawing.Point(157, 273)
        Me.txtUsos.MaxLength = 4000
        Me.txtUsos.Minimo = 0
        Me.txtUsos.Modificado = False
        Me.txtUsos.Name = "txtUsos"
        Me.txtUsos.Numerico_EsNumerico = False
        Me.txtUsos.Numerico_NumeroDoublees = 0
        Me.txtUsos.Numerico_SeparadorMiles = False
        Me.txtUsos.Obligatorio = False
        Me.txtUsos.ParametroID = 0
        Me.txtUsos.Size = New System.Drawing.Size(200, 21)
        Me.txtUsos.TabIndex = 10
        Me.txtUsos.ValorMaximo = 0.0!
        Me.txtUsos.ValorMinimo = 0.0!
        '
        'txtAdvertencias
        '
        Me.txtAdvertencias.BackColor = System.Drawing.SystemColors.Window
        Me.txtAdvertencias.EsUnicoCampo = ""
        Me.txtAdvertencias.EsUnicoCampoID = ""
        Me.txtAdvertencias.EsUnicoID = 0
        Me.txtAdvertencias.EsUnicoTabla = ""
        Me.txtAdvertencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAdvertencias.Location = New System.Drawing.Point(157, 300)
        Me.txtAdvertencias.MaxLength = 4000
        Me.txtAdvertencias.Minimo = 0
        Me.txtAdvertencias.Modificado = False
        Me.txtAdvertencias.Name = "txtAdvertencias"
        Me.txtAdvertencias.Numerico_EsNumerico = False
        Me.txtAdvertencias.Numerico_NumeroDoublees = 0
        Me.txtAdvertencias.Numerico_SeparadorMiles = False
        Me.txtAdvertencias.Obligatorio = False
        Me.txtAdvertencias.ParametroID = 0
        Me.txtAdvertencias.Size = New System.Drawing.Size(200, 21)
        Me.txtAdvertencias.TabIndex = 11
        Me.txtAdvertencias.ValorMaximo = 0.0!
        Me.txtAdvertencias.ValorMinimo = 0.0!
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(157, 327)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(200, 21)
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'txtaMecanico
        '
        Me.txtaMecanico.BackColor = System.Drawing.SystemColors.Window
        Me.txtaMecanico.EsUnicoCampo = ""
        Me.txtaMecanico.EsUnicoCampoID = ""
        Me.txtaMecanico.EsUnicoID = 0
        Me.txtaMecanico.EsUnicoTabla = ""
        Me.txtaMecanico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaMecanico.Location = New System.Drawing.Point(157, 354)
        Me.txtaMecanico.MaxLength = 2
        Me.txtaMecanico.Minimo = 0
        Me.txtaMecanico.Modificado = False
        Me.txtaMecanico.Name = "txtaMecanico"
        Me.txtaMecanico.Numerico_EsNumerico = False
        Me.txtaMecanico.Numerico_NumeroDoublees = 0
        Me.txtaMecanico.Numerico_SeparadorMiles = False
        Me.txtaMecanico.Obligatorio = False
        Me.txtaMecanico.ParametroID = 0
        Me.txtaMecanico.Size = New System.Drawing.Size(200, 21)
        Me.txtaMecanico.TabIndex = 13
        Me.txtaMecanico.ValorMaximo = 0.0!
        Me.txtaMecanico.ValorMinimo = 0.0!
        '
        'txtbMecanico
        '
        Me.txtbMecanico.BackColor = System.Drawing.SystemColors.Window
        Me.txtbMecanico.EsUnicoCampo = ""
        Me.txtbMecanico.EsUnicoCampoID = ""
        Me.txtbMecanico.EsUnicoID = 0
        Me.txtbMecanico.EsUnicoTabla = ""
        Me.txtbMecanico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbMecanico.Location = New System.Drawing.Point(157, 381)
        Me.txtbMecanico.MaxLength = 2
        Me.txtbMecanico.Minimo = 0
        Me.txtbMecanico.Modificado = False
        Me.txtbMecanico.Name = "txtbMecanico"
        Me.txtbMecanico.Numerico_EsNumerico = False
        Me.txtbMecanico.Numerico_NumeroDoublees = 0
        Me.txtbMecanico.Numerico_SeparadorMiles = False
        Me.txtbMecanico.Obligatorio = False
        Me.txtbMecanico.ParametroID = 0
        Me.txtbMecanico.Size = New System.Drawing.Size(200, 21)
        Me.txtbMecanico.TabIndex = 14
        Me.txtbMecanico.ValorMaximo = 0.0!
        Me.txtbMecanico.ValorMinimo = 0.0!
        '
        'txtcMecanico
        '
        Me.txtcMecanico.BackColor = System.Drawing.SystemColors.Window
        Me.txtcMecanico.EsUnicoCampo = ""
        Me.txtcMecanico.EsUnicoCampoID = ""
        Me.txtcMecanico.EsUnicoID = 0
        Me.txtcMecanico.EsUnicoTabla = ""
        Me.txtcMecanico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcMecanico.Location = New System.Drawing.Point(157, 408)
        Me.txtcMecanico.MaxLength = 2
        Me.txtcMecanico.Minimo = 0
        Me.txtcMecanico.Modificado = False
        Me.txtcMecanico.Name = "txtcMecanico"
        Me.txtcMecanico.Numerico_EsNumerico = False
        Me.txtcMecanico.Numerico_NumeroDoublees = 0
        Me.txtcMecanico.Numerico_SeparadorMiles = False
        Me.txtcMecanico.Obligatorio = False
        Me.txtcMecanico.ParametroID = 0
        Me.txtcMecanico.Size = New System.Drawing.Size(200, 21)
        Me.txtcMecanico.TabIndex = 15
        Me.txtcMecanico.ValorMaximo = 0.0!
        Me.txtcMecanico.ValorMinimo = 0.0!
        '
        'txtdMecanico
        '
        Me.txtdMecanico.BackColor = System.Drawing.SystemColors.Window
        Me.txtdMecanico.EsUnicoCampo = ""
        Me.txtdMecanico.EsUnicoCampoID = ""
        Me.txtdMecanico.EsUnicoID = 0
        Me.txtdMecanico.EsUnicoTabla = ""
        Me.txtdMecanico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdMecanico.Location = New System.Drawing.Point(157, 435)
        Me.txtdMecanico.MaxLength = 2
        Me.txtdMecanico.Minimo = 0
        Me.txtdMecanico.Modificado = False
        Me.txtdMecanico.Name = "txtdMecanico"
        Me.txtdMecanico.Numerico_EsNumerico = False
        Me.txtdMecanico.Numerico_NumeroDoublees = 0
        Me.txtdMecanico.Numerico_SeparadorMiles = False
        Me.txtdMecanico.Obligatorio = False
        Me.txtdMecanico.ParametroID = 0
        Me.txtdMecanico.Size = New System.Drawing.Size(200, 21)
        Me.txtdMecanico.TabIndex = 16
        Me.txtdMecanico.ValorMaximo = 0.0!
        Me.txtdMecanico.ValorMinimo = 0.0!
        '
        'txtaQuimico
        '
        Me.txtaQuimico.BackColor = System.Drawing.SystemColors.Window
        Me.txtaQuimico.EsUnicoCampo = ""
        Me.txtaQuimico.EsUnicoCampoID = ""
        Me.txtaQuimico.EsUnicoID = 0
        Me.txtaQuimico.EsUnicoTabla = ""
        Me.txtaQuimico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaQuimico.Location = New System.Drawing.Point(157, 462)
        Me.txtaQuimico.MaxLength = 2
        Me.txtaQuimico.Minimo = 0
        Me.txtaQuimico.Modificado = False
        Me.txtaQuimico.Name = "txtaQuimico"
        Me.txtaQuimico.Numerico_EsNumerico = False
        Me.txtaQuimico.Numerico_NumeroDoublees = 0
        Me.txtaQuimico.Numerico_SeparadorMiles = False
        Me.txtaQuimico.Obligatorio = False
        Me.txtaQuimico.ParametroID = 0
        Me.txtaQuimico.Size = New System.Drawing.Size(200, 21)
        Me.txtaQuimico.TabIndex = 17
        Me.txtaQuimico.ValorMaximo = 0.0!
        Me.txtaQuimico.ValorMinimo = 0.0!
        '
        'txtaMicrobiologico
        '
        Me.txtaMicrobiologico.BackColor = System.Drawing.SystemColors.Window
        Me.txtaMicrobiologico.EsUnicoCampo = ""
        Me.txtaMicrobiologico.EsUnicoCampoID = ""
        Me.txtaMicrobiologico.EsUnicoID = 0
        Me.txtaMicrobiologico.EsUnicoTabla = ""
        Me.txtaMicrobiologico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaMicrobiologico.Location = New System.Drawing.Point(157, 489)
        Me.txtaMicrobiologico.MaxLength = 2
        Me.txtaMicrobiologico.Minimo = 0
        Me.txtaMicrobiologico.Modificado = False
        Me.txtaMicrobiologico.Name = "txtaMicrobiologico"
        Me.txtaMicrobiologico.Numerico_EsNumerico = False
        Me.txtaMicrobiologico.Numerico_NumeroDoublees = 0
        Me.txtaMicrobiologico.Numerico_SeparadorMiles = False
        Me.txtaMicrobiologico.Obligatorio = False
        Me.txtaMicrobiologico.ParametroID = 0
        Me.txtaMicrobiologico.Size = New System.Drawing.Size(200, 21)
        Me.txtaMicrobiologico.TabIndex = 18
        Me.txtaMicrobiologico.ValorMaximo = 0.0!
        Me.txtaMicrobiologico.ValorMinimo = 0.0!
        '
        'txtaFrio
        '
        Me.txtaFrio.BackColor = System.Drawing.SystemColors.Window
        Me.txtaFrio.EsUnicoCampo = ""
        Me.txtaFrio.EsUnicoCampoID = ""
        Me.txtaFrio.EsUnicoID = 0
        Me.txtaFrio.EsUnicoTabla = ""
        Me.txtaFrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaFrio.Location = New System.Drawing.Point(157, 516)
        Me.txtaFrio.MaxLength = 2
        Me.txtaFrio.Minimo = 0
        Me.txtaFrio.Modificado = False
        Me.txtaFrio.Name = "txtaFrio"
        Me.txtaFrio.Numerico_EsNumerico = False
        Me.txtaFrio.Numerico_NumeroDoublees = 0
        Me.txtaFrio.Numerico_SeparadorMiles = False
        Me.txtaFrio.Obligatorio = False
        Me.txtaFrio.ParametroID = 0
        Me.txtaFrio.Size = New System.Drawing.Size(200, 21)
        Me.txtaFrio.TabIndex = 19
        Me.txtaFrio.ValorMaximo = 0.0!
        Me.txtaFrio.ValorMinimo = 0.0!
        '
        'txtbFrio
        '
        Me.txtbFrio.BackColor = System.Drawing.SystemColors.Window
        Me.txtbFrio.EsUnicoCampo = ""
        Me.txtbFrio.EsUnicoCampoID = ""
        Me.txtbFrio.EsUnicoID = 0
        Me.txtbFrio.EsUnicoTabla = ""
        Me.txtbFrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbFrio.Location = New System.Drawing.Point(157, 543)
        Me.txtbFrio.MaxLength = 2
        Me.txtbFrio.Minimo = 0
        Me.txtbFrio.Modificado = False
        Me.txtbFrio.Name = "txtbFrio"
        Me.txtbFrio.Numerico_EsNumerico = False
        Me.txtbFrio.Numerico_NumeroDoublees = 0
        Me.txtbFrio.Numerico_SeparadorMiles = False
        Me.txtbFrio.Obligatorio = False
        Me.txtbFrio.ParametroID = 0
        Me.txtbFrio.Size = New System.Drawing.Size(200, 21)
        Me.txtbFrio.TabIndex = 20
        Me.txtbFrio.ValorMaximo = 0.0!
        Me.txtbFrio.ValorMinimo = 0.0!
        '
        'txtcFrio
        '
        Me.txtcFrio.BackColor = System.Drawing.SystemColors.Window
        Me.txtcFrio.EsUnicoCampo = ""
        Me.txtcFrio.EsUnicoCampoID = ""
        Me.txtcFrio.EsUnicoID = 0
        Me.txtcFrio.EsUnicoTabla = ""
        Me.txtcFrio.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcFrio.Location = New System.Drawing.Point(157, 570)
        Me.txtcFrio.MaxLength = 2
        Me.txtcFrio.Minimo = 0
        Me.txtcFrio.Modificado = False
        Me.txtcFrio.Name = "txtcFrio"
        Me.txtcFrio.Numerico_EsNumerico = False
        Me.txtcFrio.Numerico_NumeroDoublees = 0
        Me.txtcFrio.Numerico_SeparadorMiles = False
        Me.txtcFrio.Obligatorio = False
        Me.txtcFrio.ParametroID = 0
        Me.txtcFrio.Size = New System.Drawing.Size(200, 21)
        Me.txtcFrio.TabIndex = 21
        Me.txtcFrio.ValorMaximo = 0.0!
        Me.txtcFrio.ValorMinimo = 0.0!
        '
        'lblEpiID
        '
        Me.lblEpiID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEpiID.Location = New System.Drawing.Point(28, 0)
        Me.lblEpiID.Name = "lblEpiID"
        Me.lblEpiID.Size = New System.Drawing.Size(123, 21)
        Me.lblEpiID.TabIndex = 0
        Me.lblEpiID.Text = "EpiID"
        Me.lblEpiID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblDescripcion.Location = New System.Drawing.Point(28, 27)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(123, 21)
        Me.lblDescripcion.TabIndex = 1
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMarca
        '
        Me.lblMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblMarca.Location = New System.Drawing.Point(28, 54)
        Me.lblMarca.Name = "lblMarca"
        Me.lblMarca.Size = New System.Drawing.Size(123, 21)
        Me.lblMarca.TabIndex = 2
        Me.lblMarca.Text = "Marca"
        Me.lblMarca.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblModelo
        '
        Me.lblModelo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblModelo.Location = New System.Drawing.Point(28, 81)
        Me.lblModelo.Name = "lblModelo"
        Me.lblModelo.Size = New System.Drawing.Size(123, 21)
        Me.lblModelo.TabIndex = 3
        Me.lblModelo.Text = "Modelo"
        Me.lblModelo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEpiTipoID
        '
        Me.lblEpiTipoID.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblEpiTipoID.Location = New System.Drawing.Point(28, 108)
        Me.lblEpiTipoID.Name = "lblEpiTipoID"
        Me.lblEpiTipoID.Size = New System.Drawing.Size(123, 21)
        Me.lblEpiTipoID.TabIndex = 4
        Me.lblEpiTipoID.Text = "EpiTipoID"
        Me.lblEpiTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRiesgoQuimico
        '
        Me.lblRiesgoQuimico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRiesgoQuimico.Location = New System.Drawing.Point(28, 135)
        Me.lblRiesgoQuimico.Name = "lblRiesgoQuimico"
        Me.lblRiesgoQuimico.Size = New System.Drawing.Size(123, 21)
        Me.lblRiesgoQuimico.TabIndex = 5
        Me.lblRiesgoQuimico.Text = "RiesgoQuimico"
        Me.lblRiesgoQuimico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRiesgoMecanico
        '
        Me.lblRiesgoMecanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRiesgoMecanico.Location = New System.Drawing.Point(28, 162)
        Me.lblRiesgoMecanico.Name = "lblRiesgoMecanico"
        Me.lblRiesgoMecanico.Size = New System.Drawing.Size(123, 21)
        Me.lblRiesgoMecanico.TabIndex = 6
        Me.lblRiesgoMecanico.Text = "RiesgoMecanico"
        Me.lblRiesgoMecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRiesgoMicrobiologico
        '
        Me.lblRiesgoMicrobiologico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRiesgoMicrobiologico.Location = New System.Drawing.Point(28, 189)
        Me.lblRiesgoMicrobiologico.Name = "lblRiesgoMicrobiologico"
        Me.lblRiesgoMicrobiologico.Size = New System.Drawing.Size(123, 21)
        Me.lblRiesgoMicrobiologico.TabIndex = 7
        Me.lblRiesgoMicrobiologico.Text = "RiesgoMicrobiologico"
        Me.lblRiesgoMicrobiologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRiesgoFrio
        '
        Me.lblRiesgoFrio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRiesgoFrio.Location = New System.Drawing.Point(28, 216)
        Me.lblRiesgoFrio.Name = "lblRiesgoFrio"
        Me.lblRiesgoFrio.Size = New System.Drawing.Size(123, 21)
        Me.lblRiesgoFrio.TabIndex = 8
        Me.lblRiesgoFrio.Text = "RiesgoFrio"
        Me.lblRiesgoFrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRiesgoTermico
        '
        Me.lblRiesgoTermico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblRiesgoTermico.Location = New System.Drawing.Point(28, 243)
        Me.lblRiesgoTermico.Name = "lblRiesgoTermico"
        Me.lblRiesgoTermico.Size = New System.Drawing.Size(123, 21)
        Me.lblRiesgoTermico.TabIndex = 9
        Me.lblRiesgoTermico.Text = "RiesgoTermico"
        Me.lblRiesgoTermico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUsos
        '
        Me.lblUsos.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblUsos.Location = New System.Drawing.Point(28, 270)
        Me.lblUsos.Name = "lblUsos"
        Me.lblUsos.Size = New System.Drawing.Size(123, 21)
        Me.lblUsos.TabIndex = 10
        Me.lblUsos.Text = "Usos"
        Me.lblUsos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAdvertencias
        '
        Me.lblAdvertencias.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblAdvertencias.Location = New System.Drawing.Point(28, 297)
        Me.lblAdvertencias.Name = "lblAdvertencias"
        Me.lblAdvertencias.Size = New System.Drawing.Size(123, 21)
        Me.lblAdvertencias.TabIndex = 11
        Me.lblAdvertencias.Text = "Advertencias"
        Me.lblAdvertencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblObservaciones.Location = New System.Drawing.Point(28, 324)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(123, 21)
        Me.lblObservaciones.TabIndex = 12
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblaMecanico
        '
        Me.lblaMecanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblaMecanico.Location = New System.Drawing.Point(28, 351)
        Me.lblaMecanico.Name = "lblaMecanico"
        Me.lblaMecanico.Size = New System.Drawing.Size(123, 21)
        Me.lblaMecanico.TabIndex = 13
        Me.lblaMecanico.Text = "aMecanico"
        Me.lblaMecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbMecanico
        '
        Me.lblbMecanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblbMecanico.Location = New System.Drawing.Point(28, 378)
        Me.lblbMecanico.Name = "lblbMecanico"
        Me.lblbMecanico.Size = New System.Drawing.Size(123, 21)
        Me.lblbMecanico.TabIndex = 14
        Me.lblbMecanico.Text = "bMecanico"
        Me.lblbMecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcMecanico
        '
        Me.lblcMecanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblcMecanico.Location = New System.Drawing.Point(28, 405)
        Me.lblcMecanico.Name = "lblcMecanico"
        Me.lblcMecanico.Size = New System.Drawing.Size(123, 21)
        Me.lblcMecanico.TabIndex = 15
        Me.lblcMecanico.Text = "cMecanico"
        Me.lblcMecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbldMecanico
        '
        Me.lbldMecanico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbldMecanico.Location = New System.Drawing.Point(28, 432)
        Me.lbldMecanico.Name = "lbldMecanico"
        Me.lbldMecanico.Size = New System.Drawing.Size(123, 21)
        Me.lbldMecanico.TabIndex = 16
        Me.lbldMecanico.Text = "dMecanico"
        Me.lbldMecanico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblaQuimico
        '
        Me.lblaQuimico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblaQuimico.Location = New System.Drawing.Point(28, 459)
        Me.lblaQuimico.Name = "lblaQuimico"
        Me.lblaQuimico.Size = New System.Drawing.Size(123, 21)
        Me.lblaQuimico.TabIndex = 17
        Me.lblaQuimico.Text = "aQuimico"
        Me.lblaQuimico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblaMicrobiologico
        '
        Me.lblaMicrobiologico.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblaMicrobiologico.Location = New System.Drawing.Point(28, 486)
        Me.lblaMicrobiologico.Name = "lblaMicrobiologico"
        Me.lblaMicrobiologico.Size = New System.Drawing.Size(123, 21)
        Me.lblaMicrobiologico.TabIndex = 18
        Me.lblaMicrobiologico.Text = "aMicrobiologico"
        Me.lblaMicrobiologico.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblaFrio
        '
        Me.lblaFrio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblaFrio.Location = New System.Drawing.Point(28, 513)
        Me.lblaFrio.Name = "lblaFrio"
        Me.lblaFrio.Size = New System.Drawing.Size(123, 21)
        Me.lblaFrio.TabIndex = 19
        Me.lblaFrio.Text = "aFrio"
        Me.lblaFrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblbFrio
        '
        Me.lblbFrio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblbFrio.Location = New System.Drawing.Point(28, 540)
        Me.lblbFrio.Name = "lblbFrio"
        Me.lblbFrio.Size = New System.Drawing.Size(123, 21)
        Me.lblbFrio.TabIndex = 20
        Me.lblbFrio.Text = "bFrio"
        Me.lblbFrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblcFrio
        '
        Me.lblcFrio.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblcFrio.Location = New System.Drawing.Point(28, 567)
        Me.lblcFrio.Name = "lblcFrio"
        Me.lblcFrio.Size = New System.Drawing.Size(123, 21)
        Me.lblcFrio.TabIndex = 21
        Me.lblcFrio.Text = "cFrio"
        Me.lblcFrio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tlpMiddle.ColumnCount = 4
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 56.84755!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.24289!))
        Me.tlpMiddle.Controls.Add(Me.lblEpiID, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.txtEpiID, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.lblDescripcion, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtDescripcion, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblMarca, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.txtMarca, 2, 2)
        Me.tlpMiddle.Controls.Add(Me.lblModelo, 1, 3)
        Me.tlpMiddle.Controls.Add(Me.txtModelo, 2, 3)
        Me.tlpMiddle.Controls.Add(Me.lblEpiTipoID, 1, 4)
        Me.tlpMiddle.Controls.Add(Me.lblRiesgoQuimico, 1, 5)
        Me.tlpMiddle.Controls.Add(Me.txtRiesgoQuimico, 2, 5)
        Me.tlpMiddle.Controls.Add(Me.lblRiesgoMecanico, 1, 6)
        Me.tlpMiddle.Controls.Add(Me.txtRiesgoMecanico, 2, 6)
        Me.tlpMiddle.Controls.Add(Me.lblRiesgoMicrobiologico, 1, 7)
        Me.tlpMiddle.Controls.Add(Me.txtRiesgoMicrobiologico, 2, 7)
        Me.tlpMiddle.Controls.Add(Me.lblRiesgoFrio, 1, 8)
        Me.tlpMiddle.Controls.Add(Me.txtRiesgoFrio, 2, 8)
        Me.tlpMiddle.Controls.Add(Me.lblRiesgoTermico, 1, 9)
        Me.tlpMiddle.Controls.Add(Me.txtRiesgoTermico, 2, 9)
        Me.tlpMiddle.Controls.Add(Me.lblUsos, 1, 10)
        Me.tlpMiddle.Controls.Add(Me.txtUsos, 2, 10)
        Me.tlpMiddle.Controls.Add(Me.lblAdvertencias, 1, 11)
        Me.tlpMiddle.Controls.Add(Me.txtAdvertencias, 2, 11)
        Me.tlpMiddle.Controls.Add(Me.lblObservaciones, 1, 12)
        Me.tlpMiddle.Controls.Add(Me.txtObservaciones, 2, 12)
        Me.tlpMiddle.Controls.Add(Me.lblaMecanico, 1, 13)
        Me.tlpMiddle.Controls.Add(Me.txtaMecanico, 2, 13)
        Me.tlpMiddle.Controls.Add(Me.lblbMecanico, 1, 14)
        Me.tlpMiddle.Controls.Add(Me.txtbMecanico, 2, 14)
        Me.tlpMiddle.Controls.Add(Me.lblcMecanico, 1, 15)
        Me.tlpMiddle.Controls.Add(Me.txtcMecanico, 2, 15)
        Me.tlpMiddle.Controls.Add(Me.lbldMecanico, 1, 16)
        Me.tlpMiddle.Controls.Add(Me.txtdMecanico, 2, 16)
        Me.tlpMiddle.Controls.Add(Me.lblaQuimico, 1, 17)
        Me.tlpMiddle.Controls.Add(Me.txtaQuimico, 2, 17)
        Me.tlpMiddle.Controls.Add(Me.lblaMicrobiologico, 1, 18)
        Me.tlpMiddle.Controls.Add(Me.txtaMicrobiologico, 2, 18)
        Me.tlpMiddle.Controls.Add(Me.lblaFrio, 1, 19)
        Me.tlpMiddle.Controls.Add(Me.txtaFrio, 2, 19)
        Me.tlpMiddle.Controls.Add(Me.lblbFrio, 1, 20)
        Me.tlpMiddle.Controls.Add(Me.txtbFrio, 2, 20)
        Me.tlpMiddle.Controls.Add(Me.lblcFrio, 1, 21)
        Me.tlpMiddle.Controls.Add(Me.txtcFrio, 2, 21)
        Me.tlpMiddle.Controls.Add(Me.cboEpisTipos, 2, 4)
        Me.tlpMiddle.Controls.Add(Me.txtEpiTipoID, 3, 4)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 40)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 23
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(634, 594)
        Me.tlpMiddle.TabIndex = 1000000001
        '
        'cboEpisTipos
        '
        Me.cboEpisTipos.FormattingEnabled = True
        Me.cboEpisTipos.Location = New System.Drawing.Point(157, 111)
        Me.cboEpisTipos.Name = "cboEpisTipos"
        Me.cboEpisTipos.Size = New System.Drawing.Size(280, 21)
        Me.cboEpisTipos.TabIndex = 22
        '
        'tlpTop
        '




        '
        'frmEntEpis
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(646, 674)
        Me.Controls.Add(Me.tlpMiddle)
        Me.MinimumSize = New System.Drawing.Size(373, 674)
        Me.Name = "frmEntEpis"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Epis"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtEpiID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtMarca As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtModelo As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtEpiTipoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRiesgoQuimico As System.Windows.Forms.CheckBox
    Private WithEvents txtRiesgoMecanico As System.Windows.Forms.CheckBox
    Private WithEvents txtRiesgoMicrobiologico As System.Windows.Forms.CheckBox
    Private WithEvents txtRiesgoFrio As System.Windows.Forms.CheckBox
    Private WithEvents txtRiesgoTermico As System.Windows.Forms.CheckBox
    Private WithEvents txtUsos As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtAdvertencias As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtaMecanico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtbMecanico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtcMecanico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtdMecanico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtaQuimico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtaMicrobiologico As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtaFrio As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtbFrio As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtcFrio As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblEpiID As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblMarca As System.Windows.Forms.Label
   Private WithEvents lblModelo As System.Windows.Forms.Label
   Private WithEvents lblEpiTipoID As System.Windows.Forms.Label
   Private WithEvents lblRiesgoQuimico As System.Windows.Forms.Label
   Private WithEvents lblRiesgoMecanico As System.Windows.Forms.Label
   Private WithEvents lblRiesgoMicrobiologico As System.Windows.Forms.Label
   Private WithEvents lblRiesgoFrio As System.Windows.Forms.Label
   Private WithEvents lblRiesgoTermico As System.Windows.Forms.Label
   Private WithEvents lblUsos As System.Windows.Forms.Label
   Private WithEvents lblAdvertencias As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label
   Private WithEvents lblaMecanico As System.Windows.Forms.Label
   Private WithEvents lblbMecanico As System.Windows.Forms.Label
   Private WithEvents lblcMecanico As System.Windows.Forms.Label
   Private WithEvents lbldMecanico As System.Windows.Forms.Label
   Private WithEvents lblaQuimico As System.Windows.Forms.Label
   Private WithEvents lblaMicrobiologico As System.Windows.Forms.Label
   Private WithEvents lblaFrio As System.Windows.Forms.Label
   Private WithEvents lblbFrio As System.Windows.Forms.Label
   Private WithEvents lblcFrio As System.Windows.Forms.Label
   Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

   Private WithEvents cboEpisTipos As System.Windows.Forms.ComboBox
End Class
