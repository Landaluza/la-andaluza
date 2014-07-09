<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntRecipientesSalidas
    Inherits BasesParaCompatibilidad.FrmAheredarEntOld

    'Form invalida a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DescripcionLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntRecipientesSalidas))
        Me.DtsRecipientesSalidas = New La_Andaluza.dtsRecipientesSalidas()
        Me.DescripcionCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        DescripcionLabel = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsRecipientesSalidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "RecipientesSalidas"
        Me.GeneralBindingSource.DataSource = Me.DtsRecipientesSalidas
        '
        'DescripcionLabel
        '
        DescripcionLabel.AutoSize = True
        DescripcionLabel.Location = New System.Drawing.Point(32, 70)
        DescripcionLabel.Name = "DescripcionLabel"
        DescripcionLabel.Size = New System.Drawing.Size(66, 13)
        DescripcionLabel.TabIndex = 1000000000
        DescripcionLabel.Text = "Descripcion:"
        '
        'DtsRecipientesSalidas
        '
        Me.DtsRecipientesSalidas.DataSetName = "dtsRecipientesSalidas"
        Me.DtsRecipientesSalidas.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DescripcionCuadroDeTexto
        '
        Me.DescripcionCuadroDeTexto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DescripcionCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Descripcion", True))
        Me.DescripcionCuadroDeTexto.EsUnicoCampo = ""
        Me.DescripcionCuadroDeTexto.EsUnicoCampoID = ""
        Me.DescripcionCuadroDeTexto.EsUnicoID = 0
        Me.DescripcionCuadroDeTexto.EsUnicoTabla = ""
        Me.DescripcionCuadroDeTexto.Location = New System.Drawing.Point(104, 67)
        Me.DescripcionCuadroDeTexto.MaxLength = 50
        Me.DescripcionCuadroDeTexto.Minimo = 0
        Me.DescripcionCuadroDeTexto.Modificado = False
        Me.DescripcionCuadroDeTexto.Name = "DescripcionCuadroDeTexto"
        Me.DescripcionCuadroDeTexto.Numerico_EsNumerico = False
        Me.DescripcionCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.DescripcionCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.DescripcionCuadroDeTexto.Obligatorio = False
        Me.DescripcionCuadroDeTexto.ParametroID = 0
        Me.DescripcionCuadroDeTexto.Size = New System.Drawing.Size(273, 20)
        Me.DescripcionCuadroDeTexto.TabIndex = 1
        Me.DescripcionCuadroDeTexto.ValorMaximo = 0.0R
        Me.DescripcionCuadroDeTexto.ValorMinimo = 0.0R
        '
        'frmEntRecipientesSalidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(442, 145)
        Me.Controls.Add(DescripcionLabel)
        Me.Controls.Add(Me.DescripcionCuadroDeTexto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEntRecipientesSalidas"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.DescripcionCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(DescripcionLabel, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsRecipientesSalidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsRecipientesSalidas As La_Andaluza.dtsRecipientesSalidas
    Private WithEvents DescripcionCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto

End Class
