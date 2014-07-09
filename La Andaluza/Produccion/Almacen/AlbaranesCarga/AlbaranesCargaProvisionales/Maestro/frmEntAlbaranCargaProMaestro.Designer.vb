<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntAlbaranCargaProMaestro
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
        Dim AlbaranCargaProMaestroIDLabel As System.Windows.Forms.Label
        Dim NumeroLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim ResponsableCargaIDLabel As System.Windows.Forms.Label
        Dim ObservacionesLabel As System.Windows.Forms.Label
        Dim Reserva1Label As System.Windows.Forms.Label
        Dim Reserva2Label As System.Windows.Forms.Label
        Dim Reserva3Label As System.Windows.Forms.Label
        Me.DtsAlbaranCargaProMaestro = New La_Andaluza.dtsAlbaranCargaProMaestro()
        Me.AlbaranCargaProMaestroIDTextBox = New System.Windows.Forms.TextBox()
        Me.NumeroCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ResponsableCargaIDCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.ObservacionesCuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva1CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva2CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.Reserva3CuadroDeTexto = New BasesParaCompatibilidad.CuadroDeTexto()
        AlbaranCargaProMaestroIDLabel = New System.Windows.Forms.Label()
        NumeroLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        ResponsableCargaIDLabel = New System.Windows.Forms.Label()
        ObservacionesLabel = New System.Windows.Forms.Label()
        Reserva1Label = New System.Windows.Forms.Label()
        Reserva2Label = New System.Windows.Forms.Label()
        Reserva3Label = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DtsAlbaranCargaProMaestro, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GeneralBindingSource
        '
        Me.GeneralBindingSource.DataMember = "AlbaranCargaProMaestro"
        Me.GeneralBindingSource.DataSource = Me.DtsAlbaranCargaProMaestro
        '
        'AlbaranCargaProMaestroIDLabel
        '
        AlbaranCargaProMaestroIDLabel.AutoSize = True
        AlbaranCargaProMaestroIDLabel.Location = New System.Drawing.Point(22, 43)
        AlbaranCargaProMaestroIDLabel.Name = "AlbaranCargaProMaestroIDLabel"
        AlbaranCargaProMaestroIDLabel.Size = New System.Drawing.Size(151, 13)
        AlbaranCargaProMaestroIDLabel.TabIndex = 1000000000
        AlbaranCargaProMaestroIDLabel.Text = "Albaran Carga Pro Maestro ID:"
        AlbaranCargaProMaestroIDLabel.Visible = False
        '
        'NumeroLabel
        '
        NumeroLabel.AutoSize = True
        NumeroLabel.Location = New System.Drawing.Point(22, 69)
        NumeroLabel.Name = "NumeroLabel"
        NumeroLabel.Size = New System.Drawing.Size(47, 13)
        NumeroLabel.TabIndex = 1000000002
        NumeroLabel.Text = "Numero:"
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(22, 96)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(40, 13)
        FechaLabel.TabIndex = 1000000004
        FechaLabel.Text = "Fecha:"
        '
        'ResponsableCargaIDLabel
        '
        ResponsableCargaIDLabel.AutoSize = True
        ResponsableCargaIDLabel.Location = New System.Drawing.Point(22, 121)
        ResponsableCargaIDLabel.Name = "ResponsableCargaIDLabel"
        ResponsableCargaIDLabel.Size = New System.Drawing.Size(117, 13)
        ResponsableCargaIDLabel.TabIndex = 1000000006
        ResponsableCargaIDLabel.Text = "Responsable Carga ID:"
        '
        'ObservacionesLabel
        '
        ObservacionesLabel.AutoSize = True
        ObservacionesLabel.Location = New System.Drawing.Point(22, 147)
        ObservacionesLabel.Name = "ObservacionesLabel"
        ObservacionesLabel.Size = New System.Drawing.Size(81, 13)
        ObservacionesLabel.TabIndex = 1000000008
        ObservacionesLabel.Text = "Observaciones:"
        '
        'Reserva1Label
        '
        Reserva1Label.AutoSize = True
        Reserva1Label.Location = New System.Drawing.Point(22, 173)
        Reserva1Label.Name = "Reserva1Label"
        Reserva1Label.Size = New System.Drawing.Size(89, 13)
        Reserva1Label.TabIndex = 1000000010
        Reserva1Label.Text = "Numero definitivo"
        '
        'Reserva2Label
        '
        Reserva2Label.AutoSize = True
        Reserva2Label.Location = New System.Drawing.Point(22, 199)
        Reserva2Label.Name = "Reserva2Label"
        Reserva2Label.Size = New System.Drawing.Size(56, 13)
        Reserva2Label.TabIndex = 1000000012
        Reserva2Label.Text = "Reserva2:"
        Reserva2Label.Visible = False
        '
        'Reserva3Label
        '
        Reserva3Label.AutoSize = True
        Reserva3Label.Location = New System.Drawing.Point(22, 225)
        Reserva3Label.Name = "Reserva3Label"
        Reserva3Label.Size = New System.Drawing.Size(56, 13)
        Reserva3Label.TabIndex = 1000000014
        Reserva3Label.Text = "Reserva3:"
        Reserva3Label.Visible = False
        '
        'DtsAlbaranCargaProMaestro
        '
        Me.DtsAlbaranCargaProMaestro.DataSetName = "dtsAlbaranCargaProMaestro"
        Me.DtsAlbaranCargaProMaestro.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AlbaranCargaProMaestroIDTextBox
        '
        Me.AlbaranCargaProMaestroIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "AlbaranCargaProMaestroID", True))
        Me.AlbaranCargaProMaestroIDTextBox.Location = New System.Drawing.Point(179, 40)
        Me.AlbaranCargaProMaestroIDTextBox.Name = "AlbaranCargaProMaestroIDTextBox"
        Me.AlbaranCargaProMaestroIDTextBox.Size = New System.Drawing.Size(54, 20)
        Me.AlbaranCargaProMaestroIDTextBox.TabIndex = 1000000001
        Me.AlbaranCargaProMaestroIDTextBox.Visible = False
        '
        'NumeroCuadroDeTexto
        '
        Me.NumeroCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Numero", True))
        Me.NumeroCuadroDeTexto.Enabled = False
        Me.NumeroCuadroDeTexto.EsUnicoCampo = ""
        Me.NumeroCuadroDeTexto.EsUnicoCampoID = ""
        Me.NumeroCuadroDeTexto.EsUnicoID = 0
        Me.NumeroCuadroDeTexto.EsUnicoTabla = ""
        Me.NumeroCuadroDeTexto.Location = New System.Drawing.Point(179, 66)
        Me.NumeroCuadroDeTexto.Minimo = 0
        Me.NumeroCuadroDeTexto.Modificado = False
        Me.NumeroCuadroDeTexto.Name = "NumeroCuadroDeTexto"
        Me.NumeroCuadroDeTexto.Numerico_EsNumerico = False
        Me.NumeroCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.NumeroCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.NumeroCuadroDeTexto.Obligatorio = False
        Me.NumeroCuadroDeTexto.ParametroID = 0
        Me.NumeroCuadroDeTexto.Size = New System.Drawing.Size(54, 20)
        Me.NumeroCuadroDeTexto.TabIndex = 1000000003
        Me.NumeroCuadroDeTexto.ValorMaximo = 0.0!
        Me.NumeroCuadroDeTexto.ValorMinimo = 0.0!
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.GeneralBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(179, 92)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(87, 20)
        Me.FechaDateTimePicker.TabIndex = 1000000005
        '
        'ResponsableCargaIDCuadroDeTexto
        '
        Me.ResponsableCargaIDCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "ResponsableCargaID", True))
        Me.ResponsableCargaIDCuadroDeTexto.EsUnicoCampo = ""
        Me.ResponsableCargaIDCuadroDeTexto.EsUnicoCampoID = ""
        Me.ResponsableCargaIDCuadroDeTexto.EsUnicoID = 0
        Me.ResponsableCargaIDCuadroDeTexto.EsUnicoTabla = ""
        Me.ResponsableCargaIDCuadroDeTexto.Location = New System.Drawing.Point(179, 118)
        Me.ResponsableCargaIDCuadroDeTexto.Minimo = 0
        Me.ResponsableCargaIDCuadroDeTexto.Modificado = False
        Me.ResponsableCargaIDCuadroDeTexto.Name = "ResponsableCargaIDCuadroDeTexto"
        Me.ResponsableCargaIDCuadroDeTexto.Numerico_EsNumerico = False
        Me.ResponsableCargaIDCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ResponsableCargaIDCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ResponsableCargaIDCuadroDeTexto.Obligatorio = False
        Me.ResponsableCargaIDCuadroDeTexto.ParametroID = 0
        Me.ResponsableCargaIDCuadroDeTexto.Size = New System.Drawing.Size(200, 20)
        Me.ResponsableCargaIDCuadroDeTexto.TabIndex = 1000000007
        Me.ResponsableCargaIDCuadroDeTexto.ValorMaximo = 0.0!
        Me.ResponsableCargaIDCuadroDeTexto.ValorMinimo = 0.0!
        '
        'ObservacionesCuadroDeTexto
        '
        Me.ObservacionesCuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Observaciones", True))
        Me.ObservacionesCuadroDeTexto.EsUnicoCampo = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoCampoID = ""
        Me.ObservacionesCuadroDeTexto.EsUnicoID = 0
        Me.ObservacionesCuadroDeTexto.EsUnicoTabla = ""
        Me.ObservacionesCuadroDeTexto.Location = New System.Drawing.Point(179, 144)
        Me.ObservacionesCuadroDeTexto.Minimo = 0
        Me.ObservacionesCuadroDeTexto.Modificado = False
        Me.ObservacionesCuadroDeTexto.Name = "ObservacionesCuadroDeTexto"
        Me.ObservacionesCuadroDeTexto.Numerico_EsNumerico = False
        Me.ObservacionesCuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.ObservacionesCuadroDeTexto.Numerico_SeparadorMiles = False
        Me.ObservacionesCuadroDeTexto.Obligatorio = False
        Me.ObservacionesCuadroDeTexto.ParametroID = 0
        Me.ObservacionesCuadroDeTexto.Size = New System.Drawing.Size(418, 20)
        Me.ObservacionesCuadroDeTexto.TabIndex = 1000000009
        Me.ObservacionesCuadroDeTexto.ValorMaximo = 0.0!
        Me.ObservacionesCuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva1CuadroDeTexto
        '
        Me.Reserva1CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva1", True))
        Me.Reserva1CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva1CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva1CuadroDeTexto.EsUnicoID = 0
        Me.Reserva1CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva1CuadroDeTexto.Location = New System.Drawing.Point(179, 170)
        Me.Reserva1CuadroDeTexto.Minimo = 0
        Me.Reserva1CuadroDeTexto.Modificado = False
        Me.Reserva1CuadroDeTexto.Name = "Reserva1CuadroDeTexto"
        Me.Reserva1CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva1CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva1CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva1CuadroDeTexto.Obligatorio = False
        Me.Reserva1CuadroDeTexto.ParametroID = 0
        Me.Reserva1CuadroDeTexto.Size = New System.Drawing.Size(54, 20)
        Me.Reserva1CuadroDeTexto.TabIndex = 1000000011
        Me.Reserva1CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva1CuadroDeTexto.ValorMinimo = 0.0!
        '
        'Reserva2CuadroDeTexto
        '
        Me.Reserva2CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva2", True))
        Me.Reserva2CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva2CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva2CuadroDeTexto.EsUnicoID = 0
        Me.Reserva2CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva2CuadroDeTexto.Location = New System.Drawing.Point(179, 196)
        Me.Reserva2CuadroDeTexto.Minimo = 0
        Me.Reserva2CuadroDeTexto.Modificado = False
        Me.Reserva2CuadroDeTexto.Name = "Reserva2CuadroDeTexto"
        Me.Reserva2CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva2CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva2CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva2CuadroDeTexto.Obligatorio = False
        Me.Reserva2CuadroDeTexto.ParametroID = 0
        Me.Reserva2CuadroDeTexto.Size = New System.Drawing.Size(200, 20)
        Me.Reserva2CuadroDeTexto.TabIndex = 1000000013
        Me.Reserva2CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva2CuadroDeTexto.ValorMinimo = 0.0!
        Me.Reserva2CuadroDeTexto.Visible = False
        '
        'Reserva3CuadroDeTexto
        '
        Me.Reserva3CuadroDeTexto.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.GeneralBindingSource, "Reserva3", True))
        Me.Reserva3CuadroDeTexto.EsUnicoCampo = ""
        Me.Reserva3CuadroDeTexto.EsUnicoCampoID = ""
        Me.Reserva3CuadroDeTexto.EsUnicoID = 0
        Me.Reserva3CuadroDeTexto.EsUnicoTabla = ""
        Me.Reserva3CuadroDeTexto.Location = New System.Drawing.Point(179, 222)
        Me.Reserva3CuadroDeTexto.Minimo = 0
        Me.Reserva3CuadroDeTexto.Modificado = False
        Me.Reserva3CuadroDeTexto.Name = "Reserva3CuadroDeTexto"
        Me.Reserva3CuadroDeTexto.Numerico_EsNumerico = False
        Me.Reserva3CuadroDeTexto.Numerico_NumeroDoublees = 0
        Me.Reserva3CuadroDeTexto.Numerico_SeparadorMiles = False
        Me.Reserva3CuadroDeTexto.Obligatorio = False
        Me.Reserva3CuadroDeTexto.ParametroID = 0
        Me.Reserva3CuadroDeTexto.Size = New System.Drawing.Size(200, 20)
        Me.Reserva3CuadroDeTexto.TabIndex = 1000000015
        Me.Reserva3CuadroDeTexto.ValorMaximo = 0.0!
        Me.Reserva3CuadroDeTexto.ValorMinimo = 0.0!
        Me.Reserva3CuadroDeTexto.Visible = False
        '
        'frmEntAlbaranCargaProMaestro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(606, 261)
        Me.Controls.Add(AlbaranCargaProMaestroIDLabel)
        Me.Controls.Add(Me.AlbaranCargaProMaestroIDTextBox)
        Me.Controls.Add(NumeroLabel)
        Me.Controls.Add(Me.NumeroCuadroDeTexto)
        Me.Controls.Add(FechaLabel)
        Me.Controls.Add(Me.FechaDateTimePicker)
        Me.Controls.Add(ResponsableCargaIDLabel)
        Me.Controls.Add(Me.ResponsableCargaIDCuadroDeTexto)
        Me.Controls.Add(ObservacionesLabel)
        Me.Controls.Add(Me.ObservacionesCuadroDeTexto)
        Me.Controls.Add(Reserva1Label)
        Me.Controls.Add(Me.Reserva1CuadroDeTexto)
        Me.Controls.Add(Reserva2Label)
        Me.Controls.Add(Me.Reserva2CuadroDeTexto)
        Me.Controls.Add(Reserva3Label)
        Me.Controls.Add(Me.Reserva3CuadroDeTexto)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Name = "frmEntAlbaranCargaProMaestro"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.Reserva3CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva3Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva2CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva2Label, 0)
        Me.Controls.SetChildIndex(Me.Reserva1CuadroDeTexto, 0)
        Me.Controls.SetChildIndex(Reserva1Label, 0)
        Me.Controls.SetChildIndex(Me.ObservacionesCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ObservacionesLabel, 0)
        Me.Controls.SetChildIndex(Me.ResponsableCargaIDCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(ResponsableCargaIDLabel, 0)
        Me.Controls.SetChildIndex(Me.FechaDateTimePicker, 0)
        Me.Controls.SetChildIndex(FechaLabel, 0)
        Me.Controls.SetChildIndex(Me.NumeroCuadroDeTexto, 0)
        Me.Controls.SetChildIndex(NumeroLabel, 0)
        Me.Controls.SetChildIndex(Me.AlbaranCargaProMaestroIDTextBox, 0)
        Me.Controls.SetChildIndex(AlbaranCargaProMaestroIDLabel, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DtsAlbaranCargaProMaestro, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents DtsAlbaranCargaProMaestro As La_Andaluza.dtsAlbaranCargaProMaestro
   Private WithEvents AlbaranCargaProMaestroIDTextBox As System.Windows.Forms.TextBox
    Private WithEvents NumeroCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Private WithEvents ResponsableCargaIDCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents ObservacionesCuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva1CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva2CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents Reserva3CuadroDeTexto As BasesParaCompatibilidad.CuadroDeTexto

End Class
