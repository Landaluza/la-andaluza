﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepArticuloSecundario
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
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtPeso = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtParticulares = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtGenericas = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCajasPalet = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtSeparadores = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboCajaID = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblPeso = New System.Windows.Forms.Label()
        Me.lblParticulares = New System.Windows.Forms.Label()
        Me.lblGenericas = New System.Windows.Forms.Label()
        Me.lblCajasPalet = New System.Windows.Forms.Label()
        Me.lblSeparadores = New System.Windows.Forms.Label()
        Me.lblCajaID = New System.Windows.Forms.Label()
        Me.panContenidos = New System.Windows.Forms.Panel()
        Me.cboProducto = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.btnPrimario = New System.Windows.Forms.Button()
        Me.lPrimario = New System.Windows.Forms.Label()
        Me.txtDescripcionPrimario = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.panContenidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(101, 212)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(541, 92)
        Me.txtObservaciones.TabIndex = 24
        Me.txtObservaciones.ValorMaximo = 0R
        Me.txtObservaciones.ValorMinimo = 0R
        '
        'txtPeso
        '
        Me.txtPeso.BackColor = System.Drawing.SystemColors.Window
        Me.txtPeso.EsUnicoCampo = ""
        Me.txtPeso.EsUnicoCampoID = ""
        Me.txtPeso.EsUnicoID = 0
        Me.txtPeso.EsUnicoTabla = ""
        Me.txtPeso.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPeso.Location = New System.Drawing.Point(595, 75)
        Me.txtPeso.Minimo = 0
        Me.txtPeso.Modificado = False
        Me.txtPeso.Name = "txtPeso"
        Me.txtPeso.Numerico_EsNumerico = True
        Me.txtPeso.Numerico_NumeroDoublees = 2
        Me.txtPeso.Numerico_SeparadorMiles = False
        Me.txtPeso.Obligatorio = False
        Me.txtPeso.ParametroID = 0
        Me.txtPeso.Size = New System.Drawing.Size(47, 21)
        Me.txtPeso.TabIndex = 9
        Me.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPeso.ValorMaximo = 0R
        Me.txtPeso.ValorMinimo = 0R
        '
        'txtParticulares
        '
        Me.txtParticulares.BackColor = System.Drawing.SystemColors.Window
        Me.txtParticulares.EsUnicoCampo = ""
        Me.txtParticulares.EsUnicoCampoID = ""
        Me.txtParticulares.EsUnicoID = 0
        Me.txtParticulares.EsUnicoTabla = ""
        Me.txtParticulares.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtParticulares.Location = New System.Drawing.Point(101, 185)
        Me.txtParticulares.MaxLength = 4000
        Me.txtParticulares.Minimo = 0
        Me.txtParticulares.Modificado = False
        Me.txtParticulares.Name = "txtParticulares"
        Me.txtParticulares.Numerico_EsNumerico = False
        Me.txtParticulares.Numerico_NumeroDoublees = 0
        Me.txtParticulares.Numerico_SeparadorMiles = False
        Me.txtParticulares.Obligatorio = False
        Me.txtParticulares.ParametroID = 0
        Me.txtParticulares.Size = New System.Drawing.Size(541, 21)
        Me.txtParticulares.TabIndex = 13
        Me.txtParticulares.ValorMaximo = 0R
        Me.txtParticulares.ValorMinimo = 0R
        '
        'txtGenericas
        '
        Me.txtGenericas.BackColor = System.Drawing.SystemColors.Window
        Me.txtGenericas.EsUnicoCampo = ""
        Me.txtGenericas.EsUnicoCampoID = ""
        Me.txtGenericas.EsUnicoID = 0
        Me.txtGenericas.EsUnicoTabla = ""
        Me.txtGenericas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGenericas.Location = New System.Drawing.Point(101, 105)
        Me.txtGenericas.MaxLength = 4000
        Me.txtGenericas.Minimo = 0
        Me.txtGenericas.Modificado = False
        Me.txtGenericas.Multiline = True
        Me.txtGenericas.Name = "txtGenericas"
        Me.txtGenericas.Numerico_EsNumerico = False
        Me.txtGenericas.Numerico_NumeroDoublees = 0
        Me.txtGenericas.Numerico_SeparadorMiles = False
        Me.txtGenericas.Obligatorio = False
        Me.txtGenericas.ParametroID = 0
        Me.txtGenericas.Size = New System.Drawing.Size(541, 74)
        Me.txtGenericas.TabIndex = 11
        Me.txtGenericas.ValorMaximo = 0R
        Me.txtGenericas.ValorMinimo = 0R
        '
        'txtCajasPalet
        '
        Me.txtCajasPalet.BackColor = System.Drawing.SystemColors.Window
        Me.txtCajasPalet.EsUnicoCampo = ""
        Me.txtCajasPalet.EsUnicoCampoID = ""
        Me.txtCajasPalet.EsUnicoID = 0
        Me.txtCajasPalet.EsUnicoTabla = ""
        Me.txtCajasPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCajasPalet.Location = New System.Drawing.Point(595, 48)
        Me.txtCajasPalet.MaxLength = 9
        Me.txtCajasPalet.Minimo = 0
        Me.txtCajasPalet.Modificado = False
        Me.txtCajasPalet.Name = "txtCajasPalet"
        Me.txtCajasPalet.Numerico_EsNumerico = False
        Me.txtCajasPalet.Numerico_NumeroDoublees = 0
        Me.txtCajasPalet.Numerico_SeparadorMiles = False
        Me.txtCajasPalet.Obligatorio = False
        Me.txtCajasPalet.ParametroID = 0
        Me.txtCajasPalet.Size = New System.Drawing.Size(47, 21)
        Me.txtCajasPalet.TabIndex = 7
        Me.txtCajasPalet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCajasPalet.ValorMaximo = 0R
        Me.txtCajasPalet.ValorMinimo = 0R
        '
        'txtSeparadores
        '
        Me.txtSeparadores.BackColor = System.Drawing.SystemColors.Window
        Me.txtSeparadores.EsUnicoCampo = ""
        Me.txtSeparadores.EsUnicoCampoID = ""
        Me.txtSeparadores.EsUnicoID = 0
        Me.txtSeparadores.EsUnicoTabla = ""
        Me.txtSeparadores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSeparadores.Location = New System.Drawing.Point(595, 21)
        Me.txtSeparadores.MaxLength = 9
        Me.txtSeparadores.Minimo = 0
        Me.txtSeparadores.Modificado = False
        Me.txtSeparadores.Name = "txtSeparadores"
        Me.txtSeparadores.Numerico_EsNumerico = False
        Me.txtSeparadores.Numerico_NumeroDoublees = 0
        Me.txtSeparadores.Numerico_SeparadorMiles = False
        Me.txtSeparadores.Obligatorio = False
        Me.txtSeparadores.ParametroID = 0
        Me.txtSeparadores.Size = New System.Drawing.Size(47, 21)
        Me.txtSeparadores.TabIndex = 3
        Me.txtSeparadores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSeparadores.ValorMaximo = 0R
        Me.txtSeparadores.ValorMinimo = 0R
        '
        'cboCajaID
        '
        Me.cboCajaID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCajaID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCajaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCajaID.Location = New System.Drawing.Point(101, 22)
        Me.cboCajaID.Name = "cboCajaID"
        Me.cboCajaID.Size = New System.Drawing.Size(401, 23)
        Me.cboCajaID.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(4, 213)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 21)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Observaciones"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPeso
        '
        Me.lblPeso.Location = New System.Drawing.Point(522, 76)
        Me.lblPeso.Name = "lblPeso"
        Me.lblPeso.Size = New System.Drawing.Size(53, 21)
        Me.lblPeso.TabIndex = 8
        Me.lblPeso.Text = "Peso"
        Me.lblPeso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblParticulares
        '
        Me.lblParticulares.Location = New System.Drawing.Point(4, 185)
        Me.lblParticulares.Name = "lblParticulares"
        Me.lblParticulares.Size = New System.Drawing.Size(79, 21)
        Me.lblParticulares.TabIndex = 12
        Me.lblParticulares.Text = "Particulares"
        Me.lblParticulares.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblGenericas
        '
        Me.lblGenericas.Location = New System.Drawing.Point(4, 105)
        Me.lblGenericas.Name = "lblGenericas"
        Me.lblGenericas.Size = New System.Drawing.Size(79, 21)
        Me.lblGenericas.TabIndex = 10
        Me.lblGenericas.Text = "Genericas"
        Me.lblGenericas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCajasPalet
        '
        Me.lblCajasPalet.Location = New System.Drawing.Point(522, 49)
        Me.lblCajasPalet.Name = "lblCajasPalet"
        Me.lblCajasPalet.Size = New System.Drawing.Size(63, 21)
        Me.lblCajasPalet.TabIndex = 6
        Me.lblCajasPalet.Text = "Cajas palet"
        Me.lblCajasPalet.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSeparadores
        '
        Me.lblSeparadores.Location = New System.Drawing.Point(522, 24)
        Me.lblSeparadores.Name = "lblSeparadores"
        Me.lblSeparadores.Size = New System.Drawing.Size(67, 21)
        Me.lblSeparadores.TabIndex = 2
        Me.lblSeparadores.Text = "Separadores"
        Me.lblSeparadores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCajaID
        '
        Me.lblCajaID.Enabled = False
        Me.lblCajaID.Location = New System.Drawing.Point(4, 21)
        Me.lblCajaID.Name = "lblCajaID"
        Me.lblCajaID.Size = New System.Drawing.Size(79, 21)
        Me.lblCajaID.TabIndex = 0
        Me.lblCajaID.Text = "Caja"
        Me.lblCajaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panContenidos
        '
        Me.panContenidos.Controls.Add(Me.cboProducto)
        Me.panContenidos.Controls.Add(Me.Label8)
        Me.panContenidos.Controls.Add(Me.btnPrimario)
        Me.panContenidos.Controls.Add(Me.lPrimario)
        Me.panContenidos.Controls.Add(Me.txtDescripcionPrimario)
        Me.panContenidos.Controls.Add(Me.lblCajaID)
        Me.panContenidos.Controls.Add(Me.lblSeparadores)
        Me.panContenidos.Controls.Add(Me.lblCajasPalet)
        Me.panContenidos.Controls.Add(Me.lblGenericas)
        Me.panContenidos.Controls.Add(Me.lblParticulares)
        Me.panContenidos.Controls.Add(Me.lblPeso)
        Me.panContenidos.Controls.Add(Me.Label1)
        Me.panContenidos.Controls.Add(Me.cboCajaID)
        Me.panContenidos.Controls.Add(Me.txtSeparadores)
        Me.panContenidos.Controls.Add(Me.txtCajasPalet)
        Me.panContenidos.Controls.Add(Me.txtGenericas)
        Me.panContenidos.Controls.Add(Me.txtParticulares)
        Me.panContenidos.Controls.Add(Me.txtPeso)
        Me.panContenidos.Controls.Add(Me.txtObservaciones)
        Me.panContenidos.Location = New System.Drawing.Point(12, 13)
        Me.panContenidos.Name = "panContenidos"
        Me.panContenidos.Size = New System.Drawing.Size(656, 353)
        Me.panContenidos.TabIndex = 0
        '
        'cboProducto
        '
        Me.cboProducto.FormattingEnabled = True
        Me.cboProducto.Location = New System.Drawing.Point(101, 50)
        Me.cboProducto.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cboProducto.Name = "cboProducto"
        Me.cboProducto.Size = New System.Drawing.Size(401, 21)
        Me.cboProducto.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(4, 43)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 26)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Producto"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnPrimario
        '
        Me.btnPrimario.FlatAppearance.BorderSize = 0
        Me.btnPrimario.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPrimario.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.btnPrimario.Location = New System.Drawing.Point(616, 308)
        Me.btnPrimario.Name = "btnPrimario"
        Me.btnPrimario.Size = New System.Drawing.Size(26, 30)
        Me.btnPrimario.TabIndex = 27
        Me.btnPrimario.UseVisualStyleBackColor = True
        '
        'lPrimario
        '
        Me.lPrimario.Location = New System.Drawing.Point(4, 312)
        Me.lPrimario.Name = "lPrimario"
        Me.lPrimario.Size = New System.Drawing.Size(91, 21)
        Me.lPrimario.TabIndex = 25
        Me.lPrimario.Text = "Articulo primario"
        Me.lPrimario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtDescripcionPrimario
        '
        Me.txtDescripcionPrimario.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionPrimario.Enabled = False
        Me.txtDescripcionPrimario.EsUnicoCampo = ""
        Me.txtDescripcionPrimario.EsUnicoCampoID = ""
        Me.txtDescripcionPrimario.EsUnicoID = 0
        Me.txtDescripcionPrimario.EsUnicoTabla = ""
        Me.txtDescripcionPrimario.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionPrimario.Location = New System.Drawing.Point(101, 312)
        Me.txtDescripcionPrimario.MaxLength = 4000
        Me.txtDescripcionPrimario.Minimo = 0
        Me.txtDescripcionPrimario.Modificado = False
        Me.txtDescripcionPrimario.Name = "txtDescripcionPrimario"
        Me.txtDescripcionPrimario.Numerico_EsNumerico = False
        Me.txtDescripcionPrimario.Numerico_NumeroDoublees = 0
        Me.txtDescripcionPrimario.Numerico_SeparadorMiles = False
        Me.txtDescripcionPrimario.Obligatorio = False
        Me.txtDescripcionPrimario.ParametroID = 0
        Me.txtDescripcionPrimario.Size = New System.Drawing.Size(509, 21)
        Me.txtDescripcionPrimario.TabIndex = 26
        Me.txtDescripcionPrimario.ValorMaximo = 0R
        Me.txtDescripcionPrimario.ValorMinimo = 0R
        '
        'frmWstepArticuloSecundario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 384)
        Me.Controls.Add(Me.panContenidos)
        Me.Name = "frmWstepArticuloSecundario"
        Me.Text = "frmWstepArticuloSecundario"
        Me.panContenidos.ResumeLayout(False)
        Me.panContenidos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtPeso As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtParticulares As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtGenericas As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCajasPalet As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtSeparadores As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents lblPeso As System.Windows.Forms.Label
    Private WithEvents lblParticulares As System.Windows.Forms.Label
    Private WithEvents lblGenericas As System.Windows.Forms.Label
    Private WithEvents lblCajasPalet As System.Windows.Forms.Label
    Private WithEvents lblSeparadores As System.Windows.Forms.Label
    Private WithEvents lblCajaID As System.Windows.Forms.Label
    Private WithEvents panContenidos As System.Windows.Forms.Panel
    Private WithEvents lPrimario As System.Windows.Forms.Label
    Private WithEvents txtDescripcionPrimario As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents btnPrimario As System.Windows.Forms.Button
    Public WithEvents cboCajaID As System.Windows.Forms.ComboBox
    Private WithEvents Label8 As System.Windows.Forms.Label
    Public WithEvents cboProducto As System.Windows.Forms.ComboBox
End Class
