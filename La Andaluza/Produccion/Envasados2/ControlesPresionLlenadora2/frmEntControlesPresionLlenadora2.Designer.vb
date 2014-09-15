<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntControlesPresionLlenadora2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntControlesPresionLlenadora2))

        Me.lblVerificadorID = New System.Windows.Forms.Label()
        Me.cboVerificadorID = New System.Windows.Forms.ComboBox()
        Me.butVerVerificadorID = New System.Windows.Forms.Button()
        Me.lblHora = New System.Windows.Forms.Label()
        Me.dtpHora = New System.Windows.Forms.DateTimePicker()
        Me.lblPresion = New System.Windows.Forms.Label()
        Me.txtPresion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblCorrecto = New System.Windows.Forms.Label()
        Me.chbCorrecto = New System.Windows.Forms.CheckBox()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        '
        'tlpTop
        '




        '
        'lblVerificadorID
        '
        Me.lblVerificadorID.Location = New System.Drawing.Point(13, 43)
        Me.lblVerificadorID.Name = "lblVerificadorID"
        Me.lblVerificadorID.Size = New System.Drawing.Size(81, 21)
        Me.lblVerificadorID.TabIndex = 1
        Me.lblVerificadorID.Text = "Verificador"
        Me.lblVerificadorID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboVerificadorID
        '
        Me.cboVerificadorID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboVerificadorID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboVerificadorID.Location = New System.Drawing.Point(100, 42)
        Me.cboVerificadorID.Name = "cboVerificadorID"
        Me.cboVerificadorID.Size = New System.Drawing.Size(257, 23)
        Me.cboVerificadorID.TabIndex = 2
        '
        'butVerVerificadorID
        '
        Me.butVerVerificadorID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerVerificadorID.FlatAppearance.BorderSize = 0
        Me.butVerVerificadorID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerVerificadorID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerVerificadorID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerVerificadorID.Location = New System.Drawing.Point(363, 44)
        Me.butVerVerificadorID.Name = "butVerVerificadorID"
        Me.butVerVerificadorID.Size = New System.Drawing.Size(20, 20)
        Me.butVerVerificadorID.TabIndex = 3
        Me.butVerVerificadorID.TabStop = False
        '
        'lblHora
        '
        Me.lblHora.Location = New System.Drawing.Point(16, 71)
        Me.lblHora.Name = "lblHora"
        Me.lblHora.Size = New System.Drawing.Size(78, 21)
        Me.lblHora.TabIndex = 4
        Me.lblHora.Text = "Hora"
        Me.lblHora.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpHora
        '
        Me.dtpHora.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHora.CustomFormat = "HH:mm"
        Me.dtpHora.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHora.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHora.Location = New System.Drawing.Point(100, 71)
        Me.dtpHora.Name = "dtpHora"
        Me.dtpHora.ShowUpDown = True
        Me.dtpHora.Size = New System.Drawing.Size(56, 21)
        Me.dtpHora.TabIndex = 5
        '
        'lblPresion
        '
        Me.lblPresion.Location = New System.Drawing.Point(177, 71)
        Me.lblPresion.Name = "lblPresion"
        Me.lblPresion.Size = New System.Drawing.Size(49, 21)
        Me.lblPresion.TabIndex = 6
        Me.lblPresion.Text = "Presion"
        Me.lblPresion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPresion
        '
        Me.txtPresion.BackColor = System.Drawing.SystemColors.Window
        Me.txtPresion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPresion.EsUnicoCampo = ""
        Me.txtPresion.EsUnicoCampoID = ""
        Me.txtPresion.EsUnicoID = 0
        Me.txtPresion.EsUnicoTabla = ""
        Me.txtPresion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPresion.Location = New System.Drawing.Point(232, 71)
        Me.txtPresion.Minimo = 0
        Me.txtPresion.Modificado = False
        Me.txtPresion.Name = "txtPresion"
        Me.txtPresion.Numerico_EsNumerico = True
        Me.txtPresion.Numerico_NumeroDoublees = 2
        Me.txtPresion.Numerico_SeparadorMiles = False
        Me.txtPresion.Obligatorio = False
        Me.txtPresion.ParametroID = 0
        Me.txtPresion.Size = New System.Drawing.Size(45, 21)
        Me.txtPresion.TabIndex = 7
        Me.txtPresion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtPresion.ValorMaximo = 0.0R
        Me.txtPresion.ValorMinimo = 0.0R
        '
        'lblCorrecto
        '
        Me.lblCorrecto.Location = New System.Drawing.Point(304, 71)
        Me.lblCorrecto.Name = "lblCorrecto"
        Me.lblCorrecto.Size = New System.Drawing.Size(53, 21)
        Me.lblCorrecto.TabIndex = 8
        Me.lblCorrecto.Text = "Correcto"
        Me.lblCorrecto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbCorrecto
        '
        Me.chbCorrecto.BackColor = System.Drawing.SystemColors.Control
        Me.chbCorrecto.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chbCorrecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbCorrecto.Location = New System.Drawing.Point(367, 71)
        Me.chbCorrecto.Name = "chbCorrecto"
        Me.chbCorrecto.Size = New System.Drawing.Size(16, 21)
        Me.chbCorrecto.TabIndex = 9
        Me.chbCorrecto.UseVisualStyleBackColor = False
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(13, 98)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(81, 21)
        Me.lblObservaciones.TabIndex = 11
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
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
        Me.txtObservaciones.Location = New System.Drawing.Point(100, 98)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(283, 80)
        Me.txtObservaciones.TabIndex = 12
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'txtEnvasadoID
        '
        Me.txtEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.txtEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtEnvasadoID.EsUnicoCampo = ""
        Me.txtEnvasadoID.EsUnicoCampoID = ""
        Me.txtEnvasadoID.EsUnicoID = 0
        Me.txtEnvasadoID.EsUnicoTabla = ""
        Me.txtEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEnvasadoID.Location = New System.Drawing.Point(-154, 86)
        Me.txtEnvasadoID.MaxLength = 9
        Me.txtEnvasadoID.Minimo = 0
        Me.txtEnvasadoID.Modificado = False
        Me.txtEnvasadoID.Name = "txtEnvasadoID"
        Me.txtEnvasadoID.Numerico_EsNumerico = False
        Me.txtEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtEnvasadoID.Obligatorio = True
        Me.txtEnvasadoID.ParametroID = 0
        Me.txtEnvasadoID.Size = New System.Drawing.Size(56, 21)
        Me.txtEnvasadoID.TabIndex = 1000000004
        Me.txtEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtEnvasadoID.ValorMaximo = 0.0R
        Me.txtEnvasadoID.ValorMinimo = 0.0R
        Me.txtEnvasadoID.Visible = False
        '
        'frmEntControlesPresionLlenadora2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(408, 192)
        Me.Controls.Add(Me.lblVerificadorID)
        Me.Controls.Add(Me.cboVerificadorID)
        Me.Controls.Add(Me.butVerVerificadorID)
        Me.Controls.Add(Me.lblHora)
        Me.Controls.Add(Me.dtpHora)
        Me.Controls.Add(Me.lblPresion)
        Me.Controls.Add(Me.txtPresion)
        Me.Controls.Add(Me.lblCorrecto)
        Me.Controls.Add(Me.chbCorrecto)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.txtEnvasadoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntControlesPresionLlenadora2"
        Me.Text = "ControlesPresionLlenadora1"
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.txtEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.chbCorrecto, 0)
        Me.Controls.SetChildIndex(Me.lblCorrecto, 0)
        Me.Controls.SetChildIndex(Me.txtPresion, 0)
        Me.Controls.SetChildIndex(Me.lblPresion, 0)
        Me.Controls.SetChildIndex(Me.dtpHora, 0)
        Me.Controls.SetChildIndex(Me.lblHora, 0)
        Me.Controls.SetChildIndex(Me.butVerVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.cboVerificadorID, 0)
        Me.Controls.SetChildIndex(Me.lblVerificadorID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblVerificadorID As System.Windows.Forms.Label
    Private WithEvents cboVerificadorID As System.Windows.Forms.ComboBox
    Private WithEvents butVerVerificadorID As System.Windows.Forms.Button
    Private WithEvents lblHora As System.Windows.Forms.Label
    Private WithEvents dtpHora As System.Windows.Forms.DateTimePicker
    Private WithEvents lblPresion As System.Windows.Forms.Label
    Private WithEvents txtPresion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblCorrecto As System.Windows.Forms.Label
    Private WithEvents chbCorrecto As System.Windows.Forms.CheckBox
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
End Class
