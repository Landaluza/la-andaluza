<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposFormatosLineas_TiposFormatos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposFormatosLineas_TiposFormatos))
        Me.cboTipoFormatoLinea = New System.Windows.Forms.ComboBox()
        Me.cboTipoFormato = New System.Windows.Forms.ComboBox()
        Me.txtVelocidad = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblTipoFormatoLineaID = New System.Windows.Forms.Label()
        Me.lblTipoFormatoID = New System.Windows.Forms.Label()
        Me.lblVelocidad = New System.Windows.Forms.Label()

        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPersonalRecomendado = New BasesParaCompatibilidad.CuadroDeTexto()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboTipoFormatoLinea
        '
        Me.cboTipoFormatoLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoFormatoLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoFormatoLinea.Enabled = False
        Me.cboTipoFormatoLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoFormatoLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFormatoLinea.Location = New System.Drawing.Point(128, 37)
        Me.cboTipoFormatoLinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoFormatoLinea.Name = "cboTipoFormatoLinea"
        Me.cboTipoFormatoLinea.Size = New System.Drawing.Size(376, 23)
        Me.cboTipoFormatoLinea.TabIndex = 0
        '
        'cboTipoFormato
        '
        Me.cboTipoFormato.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoFormato.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoFormato.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoFormato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoFormato.Location = New System.Drawing.Point(128, 67)
        Me.cboTipoFormato.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboTipoFormato.Name = "cboTipoFormato"
        Me.cboTipoFormato.Size = New System.Drawing.Size(376, 23)
        Me.cboTipoFormato.TabIndex = 1
        '
        'txtVelocidad
        '
        Me.txtVelocidad.BackColor = System.Drawing.SystemColors.Window
        Me.txtVelocidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtVelocidad.EsUnicoCampo = ""
        Me.txtVelocidad.EsUnicoCampoID = ""
        Me.txtVelocidad.EsUnicoID = 0
        Me.txtVelocidad.EsUnicoTabla = ""
        Me.txtVelocidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtVelocidad.Location = New System.Drawing.Point(363, 98)
        Me.txtVelocidad.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtVelocidad.MaxLength = 9
        Me.txtVelocidad.Minimo = 0
        Me.txtVelocidad.Modificado = False
        Me.txtVelocidad.Name = "txtVelocidad"
        Me.txtVelocidad.Numerico_EsNumerico = False
        Me.txtVelocidad.Numerico_NumeroDoublees = 0
        Me.txtVelocidad.Numerico_SeparadorMiles = False
        Me.txtVelocidad.Obligatorio = False
        Me.txtVelocidad.ParametroID = 0
        Me.txtVelocidad.Size = New System.Drawing.Size(140, 21)
        Me.txtVelocidad.TabIndex = 2
        Me.txtVelocidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtVelocidad.ValorMaximo = 0.0R
        Me.txtVelocidad.ValorMinimo = 0.0R
        '
        'lblTipoFormatoLineaID
        '
        Me.lblTipoFormatoLineaID.Enabled = False
        Me.lblTipoFormatoLineaID.Location = New System.Drawing.Point(27, 34)
        Me.lblTipoFormatoLineaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoFormatoLineaID.Name = "lblTipoFormatoLineaID"
        Me.lblTipoFormatoLineaID.Size = New System.Drawing.Size(96, 30)
        Me.lblTipoFormatoLineaID.TabIndex = 0
        Me.lblTipoFormatoLineaID.Text = "Formato linea"
        Me.lblTipoFormatoLineaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoFormatoID
        '
        Me.lblTipoFormatoID.Location = New System.Drawing.Point(27, 64)
        Me.lblTipoFormatoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTipoFormatoID.Name = "lblTipoFormatoID"
        Me.lblTipoFormatoID.Size = New System.Drawing.Size(96, 30)
        Me.lblTipoFormatoID.TabIndex = 3
        Me.lblTipoFormatoID.Text = "Formato envasado"
        Me.lblTipoFormatoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblVelocidad
        '
        Me.lblVelocidad.Location = New System.Drawing.Point(27, 94)
        Me.lblVelocidad.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblVelocidad.Name = "lblVelocidad"
        Me.lblVelocidad.Size = New System.Drawing.Size(96, 28)
        Me.lblVelocidad.TabIndex = 6
        Me.lblVelocidad.Text = "Velocidad"
        Me.lblVelocidad.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(27, 125)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(228, 28)
        Me.Label1.TabIndex = 1000000002
        Me.Label1.Text = "Personal recomendado para su fabricación"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPersonalRecomendado
        '
        Me.txtPersonalRecomendado.BackColor = System.Drawing.SystemColors.Window
        Me.txtPersonalRecomendado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPersonalRecomendado.EsUnicoCampo = ""
        Me.txtPersonalRecomendado.EsUnicoCampoID = ""
        Me.txtPersonalRecomendado.EsUnicoID = 0
        Me.txtPersonalRecomendado.EsUnicoTabla = ""
        Me.txtPersonalRecomendado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPersonalRecomendado.Location = New System.Drawing.Point(363, 128)
        Me.txtPersonalRecomendado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtPersonalRecomendado.MaxLength = 9
        Me.txtPersonalRecomendado.Minimo = 0
        Me.txtPersonalRecomendado.Modificado = False
        Me.txtPersonalRecomendado.Name = "txtPersonalRecomendado"
        Me.txtPersonalRecomendado.Numerico_EsNumerico = False
        Me.txtPersonalRecomendado.Numerico_NumeroDoublees = 0
        Me.txtPersonalRecomendado.Numerico_SeparadorMiles = False
        Me.txtPersonalRecomendado.Obligatorio = False
        Me.txtPersonalRecomendado.ParametroID = 0
        Me.txtPersonalRecomendado.Size = New System.Drawing.Size(140, 21)
        Me.txtPersonalRecomendado.TabIndex = 1000000001
        Me.txtPersonalRecomendado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPersonalRecomendado.ValorMaximo = 0.0R
        Me.txtPersonalRecomendado.ValorMinimo = 0.0R
        '
        'frmEntTiposFormatosLineas_TiposFormatos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(532, 174)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblTipoFormatoLineaID)
        Me.Controls.Add(Me.cboTipoFormatoLinea)
        Me.Controls.Add(Me.cboTipoFormato)
        Me.Controls.Add(Me.lblTipoFormatoID)
        Me.Controls.Add(Me.lblVelocidad)
        Me.Controls.Add(Me.txtPersonalRecomendado)
        Me.Controls.Add(Me.txtVelocidad)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTiposFormatosLineas_TiposFormatos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposFormatosLineas_TiposFormatos"
        Me.Controls.SetChildIndex(Me.txtVelocidad, 0)
        Me.Controls.SetChildIndex(Me.txtPersonalRecomendado, 0)
        Me.Controls.SetChildIndex(Me.lblVelocidad, 0)
        Me.Controls.SetChildIndex(Me.lblTipoFormatoID, 0)
        Me.Controls.SetChildIndex(Me.cboTipoFormato, 0)
        Me.Controls.SetChildIndex(Me.cboTipoFormatoLinea, 0)
        Me.Controls.SetChildIndex(Me.lblTipoFormatoLineaID, 0)
        Me.Controls.SetChildIndex(Me.Label1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboTipoFormatoLinea As System.Windows.Forms.ComboBox
    Private WithEvents cboTipoFormato As System.Windows.Forms.ComboBox
    Private WithEvents txtVelocidad As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblTipoFormatoLineaID As System.Windows.Forms.Label
    Private WithEvents lblTipoFormatoID As System.Windows.Forms.Label
    Private WithEvents lblVelocidad As System.Windows.Forms.Label

    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents txtPersonalRecomendado As BasesParaCompatibilidad.CuadroDeTexto
End Class
