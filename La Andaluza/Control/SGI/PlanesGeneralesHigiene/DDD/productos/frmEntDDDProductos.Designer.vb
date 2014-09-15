<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntDDDProductos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntDDDProductos))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtRutaFicha = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.butRutaFicha = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblRutaFicha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

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
        Me.txtDescripcion.Location = New System.Drawing.Point(102, 34)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(244, 21)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'txtRutaFicha
        '
        Me.txtRutaFicha.BackColor = System.Drawing.SystemColors.Window
        Me.txtRutaFicha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRutaFicha.Cursor = System.Windows.Forms.Cursors.No
        Me.txtRutaFicha.Enabled = False
        Me.txtRutaFicha.EsUnicoCampo = ""
        Me.txtRutaFicha.EsUnicoCampoID = ""
        Me.txtRutaFicha.EsUnicoID = 0
        Me.txtRutaFicha.EsUnicoTabla = ""
        Me.txtRutaFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRutaFicha.Location = New System.Drawing.Point(102, 63)
        Me.txtRutaFicha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtRutaFicha.MaxLength = 250
        Me.txtRutaFicha.Minimo = 0
        Me.txtRutaFicha.Modificado = False
        Me.txtRutaFicha.Name = "txtRutaFicha"
        Me.txtRutaFicha.Numerico_EsNumerico = False
        Me.txtRutaFicha.Numerico_NumeroDoublees = 0
        Me.txtRutaFicha.Numerico_SeparadorMiles = False
        Me.txtRutaFicha.Obligatorio = False
        Me.txtRutaFicha.ParametroID = 0
        Me.txtRutaFicha.Size = New System.Drawing.Size(244, 21)
        Me.txtRutaFicha.TabIndex = 1
        Me.txtRutaFicha.ValorMaximo = 0.0R
        Me.txtRutaFicha.ValorMinimo = 0.0R
        '
        'butRutaFicha
        '
        Me.butRutaFicha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butRutaFicha.FlatAppearance.BorderSize = 0
        Me.butRutaFicha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butRutaFicha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butRutaFicha.Image = Global.La_Andaluza.My.Resources.Resources.folder_magnify
        Me.butRutaFicha.Location = New System.Drawing.Point(350, 63)
        Me.butRutaFicha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butRutaFicha.Name = "butRutaFicha"
        Me.butRutaFicha.Size = New System.Drawing.Size(18, 20)
        Me.butRutaFicha.TabIndex = 2
        Me.butRutaFicha.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(102, 91)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(244, 21)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(14, 32)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(75, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRutaFicha
        '
        Me.lblRutaFicha.Location = New System.Drawing.Point(14, 60)
        Me.lblRutaFicha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblRutaFicha.Name = "lblRutaFicha"
        Me.lblRutaFicha.Size = New System.Drawing.Size(75, 28)
        Me.lblRutaFicha.TabIndex = 1
        Me.lblRutaFicha.Text = "Ruta ficha"
        Me.lblRutaFicha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(14, 89)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(84, 28)
        Me.lblObservaciones.TabIndex = 3
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntDDDProductos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(394, 130)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblRutaFicha)
        Me.Controls.Add(Me.txtRutaFicha)
        Me.Controls.Add(Me.butRutaFicha)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntDDDProductos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "DDDProductos"
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butRutaFicha, 0)
        Me.Controls.SetChildIndex(Me.txtRutaFicha, 0)
        Me.Controls.SetChildIndex(Me.lblRutaFicha, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtRutaFicha As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents butRutaFicha As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblRutaFicha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
End Class
