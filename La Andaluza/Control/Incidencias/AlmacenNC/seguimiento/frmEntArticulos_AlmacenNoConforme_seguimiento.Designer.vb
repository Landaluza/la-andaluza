<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulos_AlmacenNoConforme_seguimiento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulos_AlmacenNoConforme_seguimiento))
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtobservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblobservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(105, 37)
        Me.dtpFecha.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(86, 21)
        Me.dtpFecha.TabIndex = 1
        '
        'txtobservaciones
        '
        Me.txtobservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtobservaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtobservaciones.EsUnicoCampo = ""
        Me.txtobservaciones.EsUnicoCampoID = ""
        Me.txtobservaciones.EsUnicoID = 0
        Me.txtobservaciones.EsUnicoTabla = ""
        Me.txtobservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtobservaciones.Location = New System.Drawing.Point(105, 66)
        Me.txtobservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtobservaciones.MaxLength = 3000
        Me.txtobservaciones.Minimo = 0
        Me.txtobservaciones.Modificado = False
        Me.txtobservaciones.Multiline = True
        Me.txtobservaciones.Name = "txtobservaciones"
        Me.txtobservaciones.Numerico_EsNumerico = False
        Me.txtobservaciones.Numerico_NumeroDoublees = 0
        Me.txtobservaciones.Numerico_SeparadorMiles = False
        Me.txtobservaciones.Obligatorio = False
        Me.txtobservaciones.ParametroID = 0
        Me.txtobservaciones.Size = New System.Drawing.Size(377, 75)
        Me.txtobservaciones.TabIndex = 2
        Me.txtobservaciones.ValorMaximo = 0.0R
        Me.txtobservaciones.ValorMinimo = 0.0R
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(16, 34)
        Me.lblFecha.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(84, 28)
        Me.lblFecha.TabIndex = 3
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblobservaciones
        '
        Me.lblobservaciones.Location = New System.Drawing.Point(16, 63)
        Me.lblobservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblobservaciones.Name = "lblobservaciones"
        Me.lblobservaciones.Size = New System.Drawing.Size(84, 28)
        Me.lblobservaciones.TabIndex = 4
        Me.lblobservaciones.Text = "Observaciones"
        Me.lblobservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntArticulos_AlmacenNoConforme_seguimiento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(499, 168)
        Me.Controls.Add(Me.lblobservaciones)
        Me.Controls.Add(Me.lblFecha)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.txtobservaciones)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(464, 159)
        Me.Name = "frmEntArticulos_AlmacenNoConforme_seguimiento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Articulos_AlmacenNoConforme_seguimiento"
        Me.Controls.SetChildIndex(Me.txtobservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.lblobservaciones, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtobservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblobservaciones As System.Windows.Forms.Label

End Class
