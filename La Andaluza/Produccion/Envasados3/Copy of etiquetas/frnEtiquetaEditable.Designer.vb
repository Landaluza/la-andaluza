<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frnEtiquetaEditable
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.lscc = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lCaducidad = New System.Windows.Forms.TextBox()
        Me.ltCaducidad = New System.Windows.Forms.Label()
        Me.lean13 = New System.Windows.Forms.TextBox()
        Me.panCabecera = New System.Windows.Forms.Panel()
        Me.txtCabecera = New System.Windows.Forms.TextBox()
        Me.lean14 = New System.Windows.Forms.TextBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.llote = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.labelean = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.lnCajas = New System.Windows.Forms.TextBox()
        Me.lPalet = New System.Windows.Forms.TextBox()
        Me.lnBotellas = New System.Windows.Forms.TextBox()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lCajasBotellas = New System.Windows.Forms.TextBox()
        Me.lProducto = New System.Windows.Forms.TextBox()
        Me.lMarca = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Panel6.SuspendLayout()
        Me.panCabecera.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.lscc)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 322)
        Me.Panel6.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(548, 53)
        Me.Panel6.TabIndex = 3
        '
        'lscc
        '
        Me.lscc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lscc.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lscc.Location = New System.Drawing.Point(111, 8)
        Me.lscc.Margin = New System.Windows.Forms.Padding(2)
        Me.lscc.MaxLength = 8
        Me.lscc.Name = "lscc"
        Me.lscc.Size = New System.Drawing.Size(424, 32)
        Me.lscc.TabIndex = 0
        Me.lscc.Text = "xxxxx"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 10)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "SSCC:"
        '
        'lCaducidad
        '
        Me.lCaducidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCaducidad.Location = New System.Drawing.Point(387, 111)
        Me.lCaducidad.Margin = New System.Windows.Forms.Padding(2)
        Me.lCaducidad.MaxLength = 20
        Me.lCaducidad.Name = "lCaducidad"
        Me.lCaducidad.Size = New System.Drawing.Size(147, 32)
        Me.lCaducidad.TabIndex = 3
        '
        'ltCaducidad
        '
        Me.ltCaducidad.BackColor = System.Drawing.Color.White
        Me.ltCaducidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ltCaducidad.Location = New System.Drawing.Point(8, 113)
        Me.ltCaducidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ltCaducidad.Name = "ltCaducidad"
        Me.ltCaducidad.Size = New System.Drawing.Size(375, 31)
        Me.ltCaducidad.TabIndex = 12
        Me.ltCaducidad.Text = "Fecha de consumo preferente(aammdd):"
        '
        'lean13
        '
        Me.lean13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lean13.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lean13.Location = New System.Drawing.Point(111, 5)
        Me.lean13.Margin = New System.Windows.Forms.Padding(2)
        Me.lean13.MaxLength = 13
        Me.lean13.Name = "lean13"
        Me.lean13.Size = New System.Drawing.Size(422, 32)
        Me.lean13.TabIndex = 0
        Me.lean13.Text = "8481034912123"
        '
        'panCabecera
        '
        Me.panCabecera.Controls.Add(Me.txtCabecera)
        Me.panCabecera.Dock = System.Windows.Forms.DockStyle.Top
        Me.panCabecera.Location = New System.Drawing.Point(0, 0)
        Me.panCabecera.Margin = New System.Windows.Forms.Padding(2)
        Me.panCabecera.Name = "panCabecera"
        Me.panCabecera.Size = New System.Drawing.Size(548, 20)
        Me.panCabecera.TabIndex = 3
        '
        'txtCabecera
        '
        Me.txtCabecera.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtCabecera.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCabecera.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCabecera.Location = New System.Drawing.Point(0, 0)
        Me.txtCabecera.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCabecera.MaxLength = 1000
        Me.txtCabecera.Multiline = True
        Me.txtCabecera.Name = "txtCabecera"
        Me.txtCabecera.Size = New System.Drawing.Size(548, 20)
        Me.txtCabecera.TabIndex = 0
        Me.txtCabecera.Text = "Datos no recuperados"
        Me.txtCabecera.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lean14
        '
        Me.lean14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lean14.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lean14.Location = New System.Drawing.Point(112, 41)
        Me.lean14.Margin = New System.Windows.Forms.Padding(2)
        Me.lean14.MaxLength = 14
        Me.lean14.Name = "lean14"
        Me.lean14.Size = New System.Drawing.Size(422, 32)
        Me.lean14.TabIndex = 1
        Me.lean14.Text = "1848103400785"
        '
        'btnAceptar
        '
        Me.btnAceptar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAceptar.FlatAppearance.BorderSize = 0
        Me.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAceptar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_ok_3
        Me.btnAceptar.Location = New System.Drawing.Point(383, 383)
        Me.btnAceptar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(154, 57)
        Me.btnAceptar.TabIndex = 1
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancelar.FlatAppearance.BorderSize = 0
        Me.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCancelar.Image = Global.La_Andaluza.My.Resources.Resources.dialog_cancel_3
        Me.btnCancelar.Location = New System.Drawing.Point(20, 383)
        Me.btnCancelar.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(153, 57)
        Me.btnCancelar.TabIndex = 0
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AutoSize = True
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnCancelar)
        Me.Panel1.Controls.Add(Me.btnAceptar)
        Me.Panel1.Controls.Add(Me.Panel6)
        Me.Panel1.Controls.Add(Me.Panel5)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.panCabecera)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(548, 451)
        Me.Panel1.TabIndex = 3
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.White
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.lCaducidad)
        Me.Panel5.Controls.Add(Me.ltCaducidad)
        Me.Panel5.Controls.Add(Me.lean13)
        Me.Panel5.Controls.Add(Me.lean14)
        Me.Panel5.Controls.Add(Me.llote)
        Me.Panel5.Controls.Add(Me.Label3)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Controls.Add(Me.labelean)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(0, 170)
        Me.Panel5.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(548, 152)
        Me.Panel5.TabIndex = 2
        '
        'llote
        '
        Me.llote.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.llote.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.llote.Location = New System.Drawing.Point(112, 77)
        Me.llote.Margin = New System.Windows.Forms.Padding(2)
        Me.llote.MaxLength = 20
        Me.llote.Name = "llote"
        Me.llote.Size = New System.Drawing.Size(422, 32)
        Me.llote.TabIndex = 2
        Me.llote.Text = "xxxxx"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 77)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 26)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LOTE:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 41)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GTIN-14:"
        '
        'labelean
        '
        Me.labelean.AutoSize = True
        Me.labelean.BackColor = System.Drawing.Color.White
        Me.labelean.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelean.Location = New System.Drawing.Point(8, 7)
        Me.labelean.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.labelean.Name = "labelean"
        Me.labelean.Size = New System.Drawing.Size(100, 26)
        Me.labelean.TabIndex = 0
        Me.labelean.Text = "GTIN-13:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Panel4)
        Me.Panel2.Controls.Add(Me.Panel3)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 20)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(548, 150)
        Me.Panel2.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.lnCajas)
        Me.Panel4.Controls.Add(Me.lPalet)
        Me.Panel4.Controls.Add(Me.lnBotellas)
        Me.Panel4.Controls.Add(Me.Panel10)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(304, 0)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(244, 150)
        Me.Panel4.TabIndex = 1
        '
        'lnCajas
        '
        Me.lnCajas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lnCajas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lnCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnCajas.Location = New System.Drawing.Point(5, 63)
        Me.lnCajas.Margin = New System.Windows.Forms.Padding(2)
        Me.lnCajas.MaxLength = 1000
        Me.lnCajas.Multiline = True
        Me.lnCajas.Name = "lnCajas"
        Me.lnCajas.Size = New System.Drawing.Size(237, 52)
        Me.lnCajas.TabIndex = 1
        Me.lnCajas.Text = "XXX CAJAS POR PALET"
        '
        'lPalet
        '
        Me.lPalet.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lPalet.Dock = System.Windows.Forms.DockStyle.Top
        Me.lPalet.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lPalet.Location = New System.Drawing.Point(5, 0)
        Me.lPalet.Margin = New System.Windows.Forms.Padding(2)
        Me.lPalet.MaxLength = 1000
        Me.lPalet.Multiline = True
        Me.lPalet.Name = "lPalet"
        Me.lPalet.Size = New System.Drawing.Size(237, 63)
        Me.lPalet.TabIndex = 0
        Me.lPalet.Text = "PALET: CHEP XX x XXX bbb bb bb  cc"
        '
        'lnBotellas
        '
        Me.lnBotellas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lnBotellas.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.lnBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnBotellas.Location = New System.Drawing.Point(5, 115)
        Me.lnBotellas.Margin = New System.Windows.Forms.Padding(2)
        Me.lnBotellas.MaxLength = 1000
        Me.lnBotellas.Multiline = True
        Me.lnBotellas.Name = "lnBotellas"
        Me.lnBotellas.Size = New System.Drawing.Size(237, 33)
        Me.lnBotellas.TabIndex = 2
        Me.lnBotellas.Text = "xxxx BOTELLAS"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.White
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel10.Location = New System.Drawing.Point(0, 0)
        Me.Panel10.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(5, 148)
        Me.Panel10.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lCajasBotellas)
        Me.Panel3.Controls.Add(Me.lProducto)
        Me.Panel3.Controls.Add(Me.lMarca)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(304, 150)
        Me.Panel3.TabIndex = 0
        '
        'lCajasBotellas
        '
        Me.lCajasBotellas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lCajasBotellas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lCajasBotellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lCajasBotellas.Location = New System.Drawing.Point(0, 115)
        Me.lCajasBotellas.Margin = New System.Windows.Forms.Padding(2)
        Me.lCajasBotellas.MaxLength = 1000
        Me.lCajasBotellas.Multiline = True
        Me.lCajasBotellas.Name = "lCajasBotellas"
        Me.lCajasBotellas.Size = New System.Drawing.Size(302, 33)
        Me.lCajasBotellas.TabIndex = 2
        Me.lCajasBotellas.Text = "xx BOTELLAS DE xxx ml"
        Me.lCajasBotellas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lProducto
        '
        Me.lProducto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lProducto.Dock = System.Windows.Forms.DockStyle.Top
        Me.lProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lProducto.Location = New System.Drawing.Point(0, 31)
        Me.lProducto.Margin = New System.Windows.Forms.Padding(2)
        Me.lProducto.MaxLength = 1000
        Me.lProducto.Multiline = True
        Me.lProducto.Name = "lProducto"
        Me.lProducto.Size = New System.Drawing.Size(302, 84)
        Me.lProducto.TabIndex = 1
        Me.lProducto.Text = "sustituir los datos de ejemplo por los reales"
        Me.lProducto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lMarca
        '
        Me.lMarca.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lMarca.Dock = System.Windows.Forms.DockStyle.Top
        Me.lMarca.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lMarca.Location = New System.Drawing.Point(0, 0)
        Me.lMarca.Margin = New System.Windows.Forms.Padding(2)
        Me.lMarca.MaxLength = 1000
        Me.lMarca.Multiline = True
        Me.lMarca.Name = "lMarca"
        Me.lMarca.Size = New System.Drawing.Size(302, 31)
        Me.lMarca.TabIndex = 0
        Me.lMarca.Text = "Datos no recuperados"
        Me.lMarca.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Timer1
        '
        Me.Timer1.Interval = 5000
        '
        'frnEtiquetaEditable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancelar
        Me.ClientSize = New System.Drawing.Size(548, 451)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "frnEtiquetaEditable"
        Me.Text = "frnEtiquetaEditable"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.panCabecera.ResumeLayout(False)
        Me.panCabecera.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents Panel6 As System.Windows.Forms.Panel
    Private WithEvents lscc As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents lCaducidad As System.Windows.Forms.TextBox
    Private WithEvents ltCaducidad As System.Windows.Forms.Label
    Private WithEvents lean13 As System.Windows.Forms.TextBox
    Private WithEvents panCabecera As System.Windows.Forms.Panel
    Private WithEvents txtCabecera As System.Windows.Forms.TextBox
    Private WithEvents lean14 As System.Windows.Forms.TextBox
    Private WithEvents btnAceptar As System.Windows.Forms.Button
    Private WithEvents btnCancelar As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel5 As System.Windows.Forms.Panel
    Private WithEvents llote As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents labelean As System.Windows.Forms.Label
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Panel4 As System.Windows.Forms.Panel
    Private WithEvents lnCajas As System.Windows.Forms.TextBox
    Private WithEvents lPalet As System.Windows.Forms.TextBox
    Private WithEvents lnBotellas As System.Windows.Forms.TextBox
    Private WithEvents Panel10 As System.Windows.Forms.Panel
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents lCajasBotellas As System.Windows.Forms.TextBox
    Private WithEvents lProducto As System.Windows.Forms.TextBox
    Private WithEvents lMarca As System.Windows.Forms.TextBox
    Private WithEvents Timer1 As System.Windows.Forms.Timer
End Class
