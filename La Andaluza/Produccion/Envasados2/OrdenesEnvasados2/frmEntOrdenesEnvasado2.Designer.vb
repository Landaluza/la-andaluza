<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntOrdenesEnvasado2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntOrdenesEnvasado2))
        Me.txtOrdenEnvasadoID = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblOrdenEnvasadoID = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tbpLinea1 = New System.Windows.Forms.TabPage()
        Me.tbpLinea2 = New System.Windows.Forms.TabPage()
        Me.tbpLinea3 = New System.Windows.Forms.TabPage()
        Me.tbpLinea4 = New System.Windows.Forms.TabPage()
        Me.tbpLinea5 = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtTodoCorrecto
        '
        Me.txtTodoCorrecto.Margin = New System.Windows.Forms.Padding(2)
        '
        'txtOrdenEnvasadoID
        '
        Me.txtOrdenEnvasadoID.BackColor = System.Drawing.SystemColors.Window
        Me.txtOrdenEnvasadoID.EsUnicoCampo = ""
        Me.txtOrdenEnvasadoID.EsUnicoCampoID = ""
        Me.txtOrdenEnvasadoID.EsUnicoID = 0
        Me.txtOrdenEnvasadoID.EsUnicoTabla = ""
        Me.txtOrdenEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOrdenEnvasadoID.Location = New System.Drawing.Point(896, 12)
        Me.txtOrdenEnvasadoID.MaxLength = 9
        Me.txtOrdenEnvasadoID.Minimo = 0
        Me.txtOrdenEnvasadoID.Modificado = False
        Me.txtOrdenEnvasadoID.Name = "txtOrdenEnvasadoID"
        Me.txtOrdenEnvasadoID.Numerico_EsNumerico = False
        Me.txtOrdenEnvasadoID.Numerico_NumeroDoublees = 0
        Me.txtOrdenEnvasadoID.Numerico_SeparadorMiles = False
        Me.txtOrdenEnvasadoID.Obligatorio = False
        Me.txtOrdenEnvasadoID.ParametroID = 0
        Me.txtOrdenEnvasadoID.Size = New System.Drawing.Size(48, 21)
        Me.txtOrdenEnvasadoID.TabIndex = 0
        Me.txtOrdenEnvasadoID.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtOrdenEnvasadoID.ValorMaximo = 0.0R
        Me.txtOrdenEnvasadoID.ValorMinimo = 0.0R
        Me.txtOrdenEnvasadoID.Visible = False
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(112, 37)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(111, 21)
        Me.dtpFecha.TabIndex = 1
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
        Me.txtObservaciones.Location = New System.Drawing.Point(112, 60)
        Me.txtObservaciones.MaxLength = 250
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = True
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(546, 21)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblOrdenEnvasadoID
        '
        Me.lblOrdenEnvasadoID.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.lblOrdenEnvasadoID.Location = New System.Drawing.Point(1043, 45)
        Me.lblOrdenEnvasadoID.Name = "lblOrdenEnvasadoID"
        Me.lblOrdenEnvasadoID.Size = New System.Drawing.Size(97, 21)
        Me.lblOrdenEnvasadoID.TabIndex = 0
        Me.lblOrdenEnvasadoID.Text = "OrdenEnvasadoID"
        Me.lblOrdenEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblOrdenEnvasadoID.Visible = False
        '
        'lblFecha
        '
        Me.lblFecha.Location = New System.Drawing.Point(14, 40)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(45, 21)
        Me.lblFecha.TabIndex = 1
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(14, 61)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(83, 21)
        Me.lblObservaciones.TabIndex = 2
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tbpLinea1)
        Me.TabControl1.Controls.Add(Me.tbpLinea2)
        Me.TabControl1.Controls.Add(Me.tbpLinea3)
        Me.TabControl1.Controls.Add(Me.tbpLinea4)
        Me.TabControl1.Controls.Add(Me.tbpLinea5)
        Me.TabControl1.Location = New System.Drawing.Point(12, 96)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1517, 811)
        Me.TabControl1.TabIndex = 1000000074
        '
        'tbpLinea1
        '
        Me.tbpLinea1.Location = New System.Drawing.Point(4, 22)
        Me.tbpLinea1.Name = "tbpLinea1"
        Me.tbpLinea1.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLinea1.Size = New System.Drawing.Size(1509, 785)
        Me.tbpLinea1.TabIndex = 0
        Me.tbpLinea1.Text = "Linea1"
        Me.tbpLinea1.UseVisualStyleBackColor = True
        '
        'tbpLinea2
        '
        Me.tbpLinea2.Location = New System.Drawing.Point(4, 22)
        Me.tbpLinea2.Name = "tbpLinea2"
        Me.tbpLinea2.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLinea2.Size = New System.Drawing.Size(1509, 785)
        Me.tbpLinea2.TabIndex = 1
        Me.tbpLinea2.Text = "Linea2"
        Me.tbpLinea2.UseVisualStyleBackColor = True
        '
        'tbpLinea3
        '
        Me.tbpLinea3.Location = New System.Drawing.Point(4, 22)
        Me.tbpLinea3.Name = "tbpLinea3"
        Me.tbpLinea3.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLinea3.Size = New System.Drawing.Size(1509, 785)
        Me.tbpLinea3.TabIndex = 2
        Me.tbpLinea3.Text = "Linea3"
        Me.tbpLinea3.UseVisualStyleBackColor = True
        '
        'tbpLinea4
        '
        Me.tbpLinea4.Location = New System.Drawing.Point(4, 22)
        Me.tbpLinea4.Name = "tbpLinea4"
        Me.tbpLinea4.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLinea4.Size = New System.Drawing.Size(1509, 785)
        Me.tbpLinea4.TabIndex = 3
        Me.tbpLinea4.Text = "Linea4"
        Me.tbpLinea4.UseVisualStyleBackColor = True
        '
        'tbpLinea5
        '
        Me.tbpLinea5.Location = New System.Drawing.Point(4, 22)
        Me.tbpLinea5.Name = "tbpLinea5"
        Me.tbpLinea5.Padding = New System.Windows.Forms.Padding(3)
        Me.tbpLinea5.Size = New System.Drawing.Size(1509, 785)
        Me.tbpLinea5.TabIndex = 4
        Me.tbpLinea5.Text = "Linea5"
        Me.tbpLinea5.UseVisualStyleBackColor = True
        '
        'frmEntOrdenesEnvasado2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(1529, 909)
        Me.Controls.Add(Me.txtOrdenEnvasadoID)
        Me.Controls.Add(Me.lblOrdenEnvasadoID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.lblFecha)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MinimumSize = New System.Drawing.Size(350, 163)
        Me.Name = "frmEntOrdenesEnvasado2"
        Me.Text = "OrdenesEnvasado"
        Me.Controls.SetChildIndex(Me.lblFecha, 0)
        Me.Controls.SetChildIndex(Me.txtTodoCorrecto, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.dtpFecha, 0)
        Me.Controls.SetChildIndex(Me.TabControl1, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblOrdenEnvasadoID, 0)
        Me.Controls.SetChildIndex(Me.txtOrdenEnvasadoID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtOrdenEnvasadoID As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblOrdenEnvasadoID As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tbpLinea1 As System.Windows.Forms.TabPage
    Private WithEvents tbpLinea2 As System.Windows.Forms.TabPage
    Private WithEvents tbpLinea3 As System.Windows.Forms.TabPage
    Private WithEvents tbpLinea4 As System.Windows.Forms.TabPage
    Private WithEvents tbpLinea5 As System.Windows.Forms.TabPage
End Class
