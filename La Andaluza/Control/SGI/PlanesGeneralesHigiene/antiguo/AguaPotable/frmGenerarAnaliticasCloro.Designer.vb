<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerarAnaliticasCloro
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
        Me.cboAnalista = New System.Windows.Forms.ComboBox()
        Me.cboVerificador = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.butGenerar = New System.Windows.Forms.Button()
        Me.butCancelar = New System.Windows.Forms.Button()
        Me.gpbPuntosMuestreo = New System.Windows.Forms.GroupBox()
        Me.chkCloro = New System.Windows.Forms.CheckBox()
        Me.chkOrganoleptico = New System.Windows.Forms.CheckBox()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gpbPuntosMuestreo.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboAnalista
        '
        Me.cboAnalista.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAnalista.FormattingEnabled = True
        Me.cboAnalista.Location = New System.Drawing.Point(114, 83)
        Me.cboAnalista.Name = "cboAnalista"
        Me.cboAnalista.Size = New System.Drawing.Size(384, 21)
        Me.cboAnalista.TabIndex = 1
        '
        'cboVerificador
        '
        Me.cboVerificador.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboVerificador.FormattingEnabled = True
        Me.cboVerificador.Location = New System.Drawing.Point(114, 110)
        Me.cboVerificador.Name = "cboVerificador"
        Me.cboVerificador.Size = New System.Drawing.Size(384, 21)
        Me.cboVerificador.TabIndex = 4
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(114, 57)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(107, 20)
        Me.dtpFecha.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(55, 63)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Fecha"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(55, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Verificador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(55, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(44, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Analista"
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv.Location = New System.Drawing.Point(3, 16)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(924, 387)
        Me.dgv.TabIndex = 6
        '
        'butGenerar
        '
        Me.butGenerar.Location = New System.Drawing.Point(788, 569)
        Me.butGenerar.Name = "butGenerar"
        Me.butGenerar.Size = New System.Drawing.Size(85, 42)
        Me.butGenerar.TabIndex = 7
        Me.butGenerar.Text = "Generar"
        Me.butGenerar.UseVisualStyleBackColor = True
        '
        'butCancelar
        '
        Me.butCancelar.Location = New System.Drawing.Point(897, 569)
        Me.butCancelar.Name = "butCancelar"
        Me.butCancelar.Size = New System.Drawing.Size(85, 42)
        Me.butCancelar.TabIndex = 8
        Me.butCancelar.Text = "Cancelar"
        Me.butCancelar.UseVisualStyleBackColor = True
        '
        'gpbPuntosMuestreo
        '
        Me.gpbPuntosMuestreo.Controls.Add(Me.dgv)
        Me.gpbPuntosMuestreo.Location = New System.Drawing.Point(58, 157)
        Me.gpbPuntosMuestreo.Name = "gpbPuntosMuestreo"
        Me.gpbPuntosMuestreo.Size = New System.Drawing.Size(930, 406)
        Me.gpbPuntosMuestreo.TabIndex = 5
        Me.gpbPuntosMuestreo.TabStop = False
        Me.gpbPuntosMuestreo.Text = "Puntos de muestreo"
        '
        'chkCloro
        '
        Me.chkCloro.AutoSize = True
        Me.chkCloro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkCloro.Location = New System.Drawing.Point(545, 87)
        Me.chkCloro.Name = "chkCloro"
        Me.chkCloro.Size = New System.Drawing.Size(47, 17)
        Me.chkCloro.TabIndex = 2
        Me.chkCloro.Text = "Cloro"
        Me.chkCloro.UseVisualStyleBackColor = True
        '
        'chkOrganoleptico
        '
        Me.chkOrganoleptico.AutoSize = True
        Me.chkOrganoleptico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.chkOrganoleptico.Location = New System.Drawing.Point(612, 87)
        Me.chkOrganoleptico.Name = "chkOrganoleptico"
        Me.chkOrganoleptico.Size = New System.Drawing.Size(89, 17)
        Me.chkOrganoleptico.TabIndex = 3
        Me.chkOrganoleptico.Text = "Organoleptico"
        Me.chkOrganoleptico.UseVisualStyleBackColor = True
        '
        'frmGenerarAnaliticasCloro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1013, 618)
        Me.ControlBox = False
        Me.Controls.Add(Me.chkOrganoleptico)
        Me.Controls.Add(Me.chkCloro)
        Me.Controls.Add(Me.gpbPuntosMuestreo)
        Me.Controls.Add(Me.butCancelar)
        Me.Controls.Add(Me.butGenerar)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.cboVerificador)
        Me.Controls.Add(Me.cboAnalista)
        Me.MaximumSize = New System.Drawing.Size(1029, 656)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmGenerarAnaliticasCloro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "frmGenerarAnaliticasCloro"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gpbPuntosMuestreo.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents cboAnalista As System.Windows.Forms.ComboBox
   Private WithEvents cboVerificador As System.Windows.Forms.ComboBox
   Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
   Private WithEvents Label1 As System.Windows.Forms.Label
   Private WithEvents Label2 As System.Windows.Forms.Label
   Private WithEvents Label3 As System.Windows.Forms.Label
   Private WithEvents dgv As System.Windows.Forms.DataGridView
   Private WithEvents butGenerar As System.Windows.Forms.Button
   Private WithEvents butCancelar As System.Windows.Forms.Button
   Private WithEvents gpbPuntosMuestreo As System.Windows.Forms.GroupBox
   Private WithEvents chkCloro As System.Windows.Forms.CheckBox
   Private WithEvents chkOrganoleptico As System.Windows.Forms.CheckBox
End Class
