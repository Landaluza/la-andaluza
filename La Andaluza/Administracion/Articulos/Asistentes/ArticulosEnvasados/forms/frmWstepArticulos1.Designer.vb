﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepArticulos1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWstepArticulos1))
        Me.chbTienePedidos = New System.Windows.Forms.CheckBox()
        Me.lblCodigoQS = New System.Windows.Forms.Label()
        Me.lblUtilizacion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblCodigoTARIC = New System.Windows.Forms.Label()
        Me.lblCodigoLA = New System.Windows.Forms.Label()
        Me.panContenidos = New System.Windows.Forms.Panel()
        Me.lAvisos = New System.Windows.Forms.Label()
        Me.btnEvolucion = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtEvolucion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.chbActivo = New System.Windows.Forms.CheckBox()
        Me.btnInformacion = New System.Windows.Forms.Button()
        Me.lInfoGeneral = New System.Windows.Forms.Label()
        Me.txtInfoGeneral = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lDescripcion = New System.Windows.Forms.Label()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodigoLA = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodigoQS = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtUtilizacion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtCodigoTARIC = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.panContenidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbTienePedidos
        '
        Me.chbTienePedidos.AutoSize = True
        Me.chbTienePedidos.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbTienePedidos.Location = New System.Drawing.Point(234, 71)
        Me.chbTienePedidos.Name = "chbTienePedidos"
        Me.chbTienePedidos.Size = New System.Drawing.Size(112, 17)
        Me.chbTienePedidos.TabIndex = 6
        Me.chbTienePedidos.Text = "Se hacen pedidos"
        Me.chbTienePedidos.UseVisualStyleBackColor = True
        '
        'lblCodigoQS
        '
        Me.lblCodigoQS.Location = New System.Drawing.Point(5, 61)
        Me.lblCodigoQS.Name = "lblCodigoQS"
        Me.lblCodigoQS.Size = New System.Drawing.Size(65, 21)
        Me.lblCodigoQS.TabIndex = 4
        Me.lblCodigoQS.Text = "Codigo QS"
        Me.lblCodigoQS.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblUtilizacion
        '
        Me.lblUtilizacion.Location = New System.Drawing.Point(5, 133)
        Me.lblUtilizacion.Name = "lblUtilizacion"
        Me.lblUtilizacion.Size = New System.Drawing.Size(97, 21)
        Me.lblUtilizacion.TabIndex = 7
        Me.lblUtilizacion.Text = "Utilizacion"
        Me.lblUtilizacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(5, 160)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(97, 21)
        Me.lblObservaciones.TabIndex = 15
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoTARIC
        '
        Me.lblCodigoTARIC.Location = New System.Drawing.Point(5, 96)
        Me.lblCodigoTARIC.Name = "lblCodigoTARIC"
        Me.lblCodigoTARIC.Size = New System.Drawing.Size(75, 21)
        Me.lblCodigoTARIC.TabIndex = 9
        Me.lblCodigoTARIC.Text = "Codigo TARIC"
        Me.lblCodigoTARIC.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCodigoLA
        '
        Me.lblCodigoLA.Location = New System.Drawing.Point(5, 40)
        Me.lblCodigoLA.Name = "lblCodigoLA"
        Me.lblCodigoLA.Size = New System.Drawing.Size(97, 21)
        Me.lblCodigoLA.TabIndex = 2
        Me.lblCodigoLA.Text = "CodigoLA"
        Me.lblCodigoLA.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'panContenidos
        '
        Me.panContenidos.Controls.Add(Me.lAvisos)
        Me.panContenidos.Controls.Add(Me.btnEvolucion)
        Me.panContenidos.Controls.Add(Me.Label1)
        Me.panContenidos.Controls.Add(Me.txtEvolucion)
        Me.panContenidos.Controls.Add(Me.chbActivo)
        Me.panContenidos.Controls.Add(Me.btnInformacion)
        Me.panContenidos.Controls.Add(Me.lInfoGeneral)
        Me.panContenidos.Controls.Add(Me.txtInfoGeneral)
        Me.panContenidos.Controls.Add(Me.lDescripcion)
        Me.panContenidos.Controls.Add(Me.txtDescripcion)
        Me.panContenidos.Controls.Add(Me.txtObservaciones)
        Me.panContenidos.Controls.Add(Me.chbTienePedidos)
        Me.panContenidos.Controls.Add(Me.txtCodigoLA)
        Me.panContenidos.Controls.Add(Me.txtCodigoQS)
        Me.panContenidos.Controls.Add(Me.lblCodigoQS)
        Me.panContenidos.Controls.Add(Me.lblUtilizacion)
        Me.panContenidos.Controls.Add(Me.txtUtilizacion)
        Me.panContenidos.Controls.Add(Me.lblObservaciones)
        Me.panContenidos.Controls.Add(Me.txtCodigoTARIC)
        Me.panContenidos.Controls.Add(Me.lblCodigoLA)
        Me.panContenidos.Controls.Add(Me.lblCodigoTARIC)
        Me.panContenidos.Location = New System.Drawing.Point(10, 1)
        Me.panContenidos.Name = "panContenidos"
        Me.panContenidos.Size = New System.Drawing.Size(593, 357)
        Me.panContenidos.TabIndex = 0
        '
        'lAvisos
        '
        Me.lAvisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Strikeout), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lAvisos.Image = Global.La_Andaluza.My.Resources.Resources.winmerge
        Me.lAvisos.Location = New System.Drawing.Point(484, 38)
        Me.lAvisos.Name = "lAvisos"
        Me.lAvisos.Size = New System.Drawing.Size(95, 89)
        Me.lAvisos.TabIndex = 47
        Me.lAvisos.Text = "Avisos pendientes"
        Me.lAvisos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lAvisos.Visible = False
        '
        'btnEvolucion
        '
        Me.btnEvolucion.FlatAppearance.BorderSize = 0
        Me.btnEvolucion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEvolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEvolucion.Image = CType(resources.GetObject("btnEvolucion.Image"), System.Drawing.Image)
        Me.btnEvolucion.Location = New System.Drawing.Point(559, 288)
        Me.btnEvolucion.Name = "btnEvolucion"
        Me.btnEvolucion.Size = New System.Drawing.Size(20, 21)
        Me.btnEvolucion.TabIndex = 46
        Me.btnEvolucion.TabStop = False
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(5, 289)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 32)
        Me.Label1.TabIndex = 45
        Me.Label1.Text = "Evolucion de precios"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEvolucion
        '
        Me.txtEvolucion.BackColor = System.Drawing.SystemColors.Window
        Me.txtEvolucion.Enabled = False
        Me.txtEvolucion.EsUnicoCampo = ""
        Me.txtEvolucion.EsUnicoCampoID = ""
        Me.txtEvolucion.EsUnicoID = 0
        Me.txtEvolucion.EsUnicoTabla = ""
        Me.txtEvolucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEvolucion.Location = New System.Drawing.Point(108, 288)
        Me.txtEvolucion.MaxLength = 500
        Me.txtEvolucion.Minimo = 0
        Me.txtEvolucion.Modificado = False
        Me.txtEvolucion.Multiline = True
        Me.txtEvolucion.Name = "txtEvolucion"
        Me.txtEvolucion.Numerico_EsNumerico = False
        Me.txtEvolucion.Numerico_NumeroDoublees = 0
        Me.txtEvolucion.Numerico_SeparadorMiles = False
        Me.txtEvolucion.Obligatorio = False
        Me.txtEvolucion.ParametroID = 0
        Me.txtEvolucion.Size = New System.Drawing.Size(443, 39)
        Me.txtEvolucion.TabIndex = 44
        Me.txtEvolucion.ValorMaximo = 0R
        Me.txtEvolucion.ValorMinimo = 0R
        '
        'chbActivo
        '
        Me.chbActivo.AutoSize = True
        Me.chbActivo.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chbActivo.Checked = True
        Me.chbActivo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chbActivo.Location = New System.Drawing.Point(234, 40)
        Me.chbActivo.Name = "chbActivo"
        Me.chbActivo.Size = New System.Drawing.Size(56, 17)
        Me.chbActivo.TabIndex = 43
        Me.chbActivo.Text = "Activo"
        Me.chbActivo.UseVisualStyleBackColor = True
        '
        'btnInformacion
        '
        Me.btnInformacion.FlatAppearance.BorderSize = 0
        Me.btnInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInformacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnInformacion.Image = CType(resources.GetObject("btnInformacion.Image"), System.Drawing.Image)
        Me.btnInformacion.Location = New System.Drawing.Point(559, 243)
        Me.btnInformacion.Name = "btnInformacion"
        Me.btnInformacion.Size = New System.Drawing.Size(20, 21)
        Me.btnInformacion.TabIndex = 42
        Me.btnInformacion.TabStop = False
        '
        'lInfoGeneral
        '
        Me.lInfoGeneral.Location = New System.Drawing.Point(5, 244)
        Me.lInfoGeneral.Name = "lInfoGeneral"
        Me.lInfoGeneral.Size = New System.Drawing.Size(97, 21)
        Me.lInfoGeneral.TabIndex = 18
        Me.lInfoGeneral.Text = "Información"
        Me.lInfoGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtInfoGeneral
        '
        Me.txtInfoGeneral.BackColor = System.Drawing.SystemColors.Window
        Me.txtInfoGeneral.Enabled = False
        Me.txtInfoGeneral.EsUnicoCampo = ""
        Me.txtInfoGeneral.EsUnicoCampoID = ""
        Me.txtInfoGeneral.EsUnicoID = 0
        Me.txtInfoGeneral.EsUnicoTabla = ""
        Me.txtInfoGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInfoGeneral.Location = New System.Drawing.Point(108, 243)
        Me.txtInfoGeneral.MaxLength = 500
        Me.txtInfoGeneral.Minimo = 0
        Me.txtInfoGeneral.Modificado = False
        Me.txtInfoGeneral.Multiline = True
        Me.txtInfoGeneral.Name = "txtInfoGeneral"
        Me.txtInfoGeneral.Numerico_EsNumerico = False
        Me.txtInfoGeneral.Numerico_NumeroDoublees = 0
        Me.txtInfoGeneral.Numerico_SeparadorMiles = False
        Me.txtInfoGeneral.Obligatorio = False
        Me.txtInfoGeneral.ParametroID = 0
        Me.txtInfoGeneral.Size = New System.Drawing.Size(443, 39)
        Me.txtInfoGeneral.TabIndex = 17
        Me.txtInfoGeneral.ValorMaximo = 0R
        Me.txtInfoGeneral.ValorMinimo = 0R
        '
        'lDescripcion
        '
        Me.lDescripcion.AutoSize = True
        Me.lDescripcion.Location = New System.Drawing.Point(5, 16)
        Me.lDescripcion.Name = "lDescripcion"
        Me.lDescripcion.Size = New System.Drawing.Size(63, 13)
        Me.lDescripcion.TabIndex = 0
        Me.lDescripcion.Text = "Descripción"
        Me.lDescripcion.Visible = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(108, 13)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(471, 20)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.Visible = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(108, 159)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(471, 75)
        Me.txtObservaciones.TabIndex = 16
        Me.txtObservaciones.ValorMaximo = 0R
        Me.txtObservaciones.ValorMinimo = 0R
        '
        'txtCodigoLA
        '
        Me.txtCodigoLA.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoLA.EsUnicoCampo = ""
        Me.txtCodigoLA.EsUnicoCampoID = ""
        Me.txtCodigoLA.EsUnicoID = 0
        Me.txtCodigoLA.EsUnicoTabla = ""
        Me.txtCodigoLA.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoLA.Location = New System.Drawing.Point(108, 39)
        Me.txtCodigoLA.MaxLength = 9
        Me.txtCodigoLA.Minimo = 0
        Me.txtCodigoLA.Modificado = False
        Me.txtCodigoLA.Name = "txtCodigoLA"
        Me.txtCodigoLA.Numerico_EsNumerico = False
        Me.txtCodigoLA.Numerico_NumeroDoublees = 0
        Me.txtCodigoLA.Numerico_SeparadorMiles = False
        Me.txtCodigoLA.Obligatorio = True
        Me.txtCodigoLA.ParametroID = 0
        Me.txtCodigoLA.Size = New System.Drawing.Size(109, 21)
        Me.txtCodigoLA.TabIndex = 3
        Me.txtCodigoLA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigoLA.ValorMaximo = 0R
        Me.txtCodigoLA.ValorMinimo = 0R
        '
        'txtCodigoQS
        '
        Me.txtCodigoQS.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoQS.EsUnicoCampo = ""
        Me.txtCodigoQS.EsUnicoCampoID = ""
        Me.txtCodigoQS.EsUnicoID = 0
        Me.txtCodigoQS.EsUnicoTabla = ""
        Me.txtCodigoQS.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoQS.Location = New System.Drawing.Point(108, 67)
        Me.txtCodigoQS.MaxLength = 9
        Me.txtCodigoQS.Minimo = 0
        Me.txtCodigoQS.Modificado = False
        Me.txtCodigoQS.Name = "txtCodigoQS"
        Me.txtCodigoQS.Numerico_EsNumerico = False
        Me.txtCodigoQS.Numerico_NumeroDoublees = 0
        Me.txtCodigoQS.Numerico_SeparadorMiles = False
        Me.txtCodigoQS.Obligatorio = False
        Me.txtCodigoQS.ParametroID = 0
        Me.txtCodigoQS.Size = New System.Drawing.Size(109, 21)
        Me.txtCodigoQS.TabIndex = 5
        Me.txtCodigoQS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCodigoQS.ValorMaximo = 0R
        Me.txtCodigoQS.ValorMinimo = 0R
        '
        'txtUtilizacion
        '
        Me.txtUtilizacion.BackColor = System.Drawing.SystemColors.Window
        Me.txtUtilizacion.EsUnicoCampo = ""
        Me.txtUtilizacion.EsUnicoCampoID = ""
        Me.txtUtilizacion.EsUnicoID = 0
        Me.txtUtilizacion.EsUnicoTabla = ""
        Me.txtUtilizacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUtilizacion.Location = New System.Drawing.Point(108, 132)
        Me.txtUtilizacion.MaxLength = 500
        Me.txtUtilizacion.Minimo = 0
        Me.txtUtilizacion.Modificado = False
        Me.txtUtilizacion.Name = "txtUtilizacion"
        Me.txtUtilizacion.Numerico_EsNumerico = False
        Me.txtUtilizacion.Numerico_NumeroDoublees = 0
        Me.txtUtilizacion.Numerico_SeparadorMiles = False
        Me.txtUtilizacion.Obligatorio = False
        Me.txtUtilizacion.ParametroID = 0
        Me.txtUtilizacion.Size = New System.Drawing.Size(471, 21)
        Me.txtUtilizacion.TabIndex = 8
        Me.txtUtilizacion.ValorMaximo = 0R
        Me.txtUtilizacion.ValorMinimo = 0R
        '
        'txtCodigoTARIC
        '
        Me.txtCodigoTARIC.BackColor = System.Drawing.SystemColors.Window
        Me.txtCodigoTARIC.EsUnicoCampo = ""
        Me.txtCodigoTARIC.EsUnicoCampoID = ""
        Me.txtCodigoTARIC.EsUnicoID = 0
        Me.txtCodigoTARIC.EsUnicoTabla = ""
        Me.txtCodigoTARIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigoTARIC.Location = New System.Drawing.Point(108, 94)
        Me.txtCodigoTARIC.MaxLength = 4000
        Me.txtCodigoTARIC.Minimo = 0
        Me.txtCodigoTARIC.Modificado = False
        Me.txtCodigoTARIC.Name = "txtCodigoTARIC"
        Me.txtCodigoTARIC.Numerico_EsNumerico = False
        Me.txtCodigoTARIC.Numerico_NumeroDoublees = 0
        Me.txtCodigoTARIC.Numerico_SeparadorMiles = False
        Me.txtCodigoTARIC.Obligatorio = False
        Me.txtCodigoTARIC.ParametroID = 0
        Me.txtCodigoTARIC.Size = New System.Drawing.Size(182, 21)
        Me.txtCodigoTARIC.TabIndex = 10
        Me.txtCodigoTARIC.ValorMaximo = 0R
        Me.txtCodigoTARIC.ValorMinimo = 0R
        '
        'frmWstepArticulos1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 370)
        Me.Controls.Add(Me.panContenidos)
        Me.Name = "frmWstepArticulos1"
        Me.Text = "frmWstepArticulos1"
        Me.panContenidos.ResumeLayout(False)
        Me.panContenidos.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents chbTienePedidos As System.Windows.Forms.CheckBox
    Private WithEvents txtCodigoQS As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCodigoQS As System.Windows.Forms.Label
    Private WithEvents lblUtilizacion As System.Windows.Forms.Label
    Private WithEvents txtUtilizacion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents txtCodigoTARIC As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCodigoTARIC As System.Windows.Forms.Label
    Private WithEvents lblCodigoLA As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtCodigoLA As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lDescripcion As System.Windows.Forms.Label
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
    Private WithEvents lInfoGeneral As System.Windows.Forms.Label
    Private WithEvents txtInfoGeneral As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents btnInformacion As System.Windows.Forms.Button
    Private WithEvents chbActivo As System.Windows.Forms.CheckBox
    Private WithEvents panContenidos As System.Windows.Forms.Panel
    Private WithEvents btnEvolucion As System.Windows.Forms.Button
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtEvolucion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lAvisos As System.Windows.Forms.Label
End Class
