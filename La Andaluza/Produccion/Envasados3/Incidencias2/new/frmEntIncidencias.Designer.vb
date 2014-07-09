<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntIncidencias))
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoIncidencia = New System.Windows.Forms.ComboBox()
        Me.butVerTipoIncidenciaID = New System.Windows.Forms.Button()
        Me.butAddTipoIncidenciaID = New System.Windows.Forms.Button()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pancontenido = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lDato3 = New System.Windows.Forms.Label()
        Me.lDato2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTipoIncidenciaID = New System.Windows.Forms.Label()
        Me.cboMaquina = New System.Windows.Forms.ComboBox()
        Me.lblMaquina = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.dtpnumMinutos = New System.Windows.Forms.NumericUpDown()
        Me.lblMinutos = New System.Windows.Forms.Label()
        Me.lblClaseIncidencia = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpEmpleados = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pancontenido.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dtpnumMinutos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtpHoraInicio
        '
        Me.dtpHoraInicio.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraInicio.CustomFormat = "HH:mm"
        Me.dtpHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraInicio.Location = New System.Drawing.Point(8, 63)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(77, 29)
        Me.dtpHoraInicio.TabIndex = 2
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH:mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(177, 63)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(76, 29)
        Me.dtpHoraFin.TabIndex = 6
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
        Me.txtObservaciones.Location = New System.Drawing.Point(10, 226)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(330, 56)
        Me.txtObservaciones.TabIndex = 8
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'cboTipoIncidencia
        '
        Me.cboTipoIncidencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoIncidencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboTipoIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoIncidencia.Location = New System.Drawing.Point(8, 106)
        Me.cboTipoIncidencia.Name = "cboTipoIncidencia"
        Me.cboTipoIncidencia.Size = New System.Drawing.Size(331, 23)
        Me.cboTipoIncidencia.TabIndex = 3
        '
        'butVerTipoIncidenciaID
        '
        Me.butVerTipoIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butVerTipoIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.search_3
        Me.butVerTipoIncidenciaID.Location = New System.Drawing.Point(186, 76)
        Me.butVerTipoIncidenciaID.Name = "butVerTipoIncidenciaID"
        Me.butVerTipoIncidenciaID.Size = New System.Drawing.Size(22, 18)
        Me.butVerTipoIncidenciaID.TabIndex = 4
        Me.butVerTipoIncidenciaID.TabStop = False
        '
        'butAddTipoIncidenciaID
        '
        Me.butAddTipoIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butAddTipoIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoIncidenciaID.Location = New System.Drawing.Point(210, 77)
        Me.butAddTipoIncidenciaID.Name = "butAddTipoIncidenciaID"
        Me.butAddTipoIncidenciaID.Size = New System.Drawing.Size(16, 15)
        Me.butAddTipoIncidenciaID.TabIndex = 5
        Me.butAddTipoIncidenciaID.TabStop = False
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraInicio.Location = New System.Drawing.Point(19, 38)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(46, 22)
        Me.lblHoraInicio.TabIndex = 1
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFin.Location = New System.Drawing.Point(191, 38)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(41, 22)
        Me.lblHoraFin.TabIndex = 5
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(109, 197)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(110, 26)
        Me.lblObservaciones.TabIndex = 7
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pancontenido)
        Me.SplitContainer1.Size = New System.Drawing.Size(710, 398)
        Me.SplitContainer1.SplitterDistance = 352
        Me.SplitContainer1.TabIndex = 0
        '
        'pancontenido
        '
        Me.pancontenido.Controls.Add(Me.Panel3)
        Me.pancontenido.Controls.Add(Me.Panel2)
        Me.pancontenido.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pancontenido.Location = New System.Drawing.Point(0, 0)
        Me.pancontenido.Name = "pancontenido"
        Me.pancontenido.Size = New System.Drawing.Size(352, 398)
        Me.pancontenido.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.lDato3)
        Me.Panel3.Controls.Add(Me.lDato2)
        Me.Panel3.Controls.Add(Me.Label3)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.lblTipoIncidenciaID)
        Me.Panel3.Controls.Add(Me.cboMaquina)
        Me.Panel3.Controls.Add(Me.lblObservaciones)
        Me.Panel3.Controls.Add(Me.butVerTipoIncidenciaID)
        Me.Panel3.Controls.Add(Me.cboTipoIncidencia)
        Me.Panel3.Controls.Add(Me.txtObservaciones)
        Me.Panel3.Controls.Add(Me.lblMaquina)
        Me.Panel3.Controls.Add(Me.butAddTipoIncidenciaID)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 96)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(352, 302)
        Me.Panel3.TabIndex = 1
        '
        'lDato3
        '
        Me.lDato3.AutoSize = True
        Me.lDato3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDato3.Location = New System.Drawing.Point(106, 168)
        Me.lDato3.Name = "lDato3"
        Me.lDato3.Size = New System.Drawing.Size(51, 20)
        Me.lDato3.TabIndex = 16
        Me.lDato3.Text = "valor3"
        Me.lDato3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lDato2
        '
        Me.lDato2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lDato2.Location = New System.Drawing.Point(10, 171)
        Me.lDato2.Name = "lDato2"
        Me.lDato2.Size = New System.Drawing.Size(57, 22)
        Me.lDato2.TabIndex = 15
        Me.lDato2.Text = "valor3"
        Me.lDato2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(106, 149)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 22)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Dato3"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 149)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 22)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Dato2"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoIncidenciaID
        '
        Me.lblTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIncidenciaID.Location = New System.Drawing.Point(142, 72)
        Me.lblTipoIncidenciaID.Name = "lblTipoIncidenciaID"
        Me.lblTipoIncidenciaID.Size = New System.Drawing.Size(46, 22)
        Me.lblTipoIncidenciaID.TabIndex = 2
        Me.lblTipoIncidenciaID.Text = "Tipo"
        Me.lblTipoIncidenciaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaquina.Location = New System.Drawing.Point(8, 40)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(331, 23)
        Me.cboMaquina.TabIndex = 1
        '
        'lblMaquina
        '
        Me.lblMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaquina.Location = New System.Drawing.Point(129, 10)
        Me.lblMaquina.Name = "lblMaquina"
        Me.lblMaquina.Size = New System.Drawing.Size(97, 30)
        Me.lblMaquina.TabIndex = 0
        Me.lblMaquina.Text = "Maquina"
        Me.lblMaquina.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.dtpHoraInicio)
        Me.Panel2.Controls.Add(Me.dtpnumMinutos)
        Me.Panel2.Controls.Add(Me.lblHoraFin)
        Me.Panel2.Controls.Add(Me.lblHoraInicio)
        Me.Panel2.Controls.Add(Me.dtpHoraFin)
        Me.Panel2.Controls.Add(Me.lblMinutos)
        Me.Panel2.Controls.Add(Me.lblClaseIncidencia)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 96)
        Me.Panel2.TabIndex = 0
        '
        'dtpnumMinutos
        '
        Me.dtpnumMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpnumMinutos.Location = New System.Drawing.Point(104, 63)
        Me.dtpnumMinutos.Name = "dtpnumMinutos"
        Me.dtpnumMinutos.Size = New System.Drawing.Size(51, 29)
        Me.dtpnumMinutos.TabIndex = 4
        '
        'lblMinutos
        '
        Me.lblMinutos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMinutos.Location = New System.Drawing.Point(100, 38)
        Me.lblMinutos.Name = "lblMinutos"
        Me.lblMinutos.Size = New System.Drawing.Size(67, 22)
        Me.lblMinutos.TabIndex = 3
        Me.lblMinutos.Text = "Minutos"
        Me.lblMinutos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClaseIncidencia
        '
        Me.lblClaseIncidencia.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblClaseIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblClaseIncidencia.Location = New System.Drawing.Point(0, 0)
        Me.lblClaseIncidencia.Name = "lblClaseIncidencia"
        Me.lblClaseIncidencia.Size = New System.Drawing.Size(352, 27)
        Me.lblClaseIncidencia.TabIndex = 0
        Me.lblClaseIncidencia.Text = "Clase incidencia"
        Me.lblClaseIncidencia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer2.Size = New System.Drawing.Size(710, 512)
        Me.SplitContainer2.SplitterDistance = 398
        Me.SplitContainer2.SplitterWidth = 3
        Me.SplitContainer2.TabIndex = 1000000004
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpEmpleados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(710, 111)
        Me.TabControl1.TabIndex = 0
        '
        'tpEmpleados
        '
        Me.tpEmpleados.Location = New System.Drawing.Point(4, 22)
        Me.tpEmpleados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEmpleados.Name = "tpEmpleados"
        Me.tpEmpleados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpEmpleados.Size = New System.Drawing.Size(702, 85)
        Me.tpEmpleados.TabIndex = 0
        Me.tpEmpleados.Text = "Personal extra requerido por la incidencia"
        Me.tpEmpleados.UseVisualStyleBackColor = True
        '
        'frmEntIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(710, 537)
        Me.ControlBox = True
        Me.Controls.Add(Me.SplitContainer2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(470, 222)
        Me.Name = "frmEntIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incidencias"
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pancontenido.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.dtpnumMinutos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents dtpHoraInicio As System.Windows.Forms.DateTimePicker
    Private WithEvents dtpHoraFin As System.Windows.Forms.DateTimePicker
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboTipoIncidencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerTipoIncidenciaID As System.Windows.Forms.Button
    Private WithEvents butAddTipoIncidenciaID As System.Windows.Forms.Button
    Private WithEvents lblHoraInicio As System.Windows.Forms.Label
    Private WithEvents lblHoraFin As System.Windows.Forms.Label
    Private WithEvents lblObservaciones As System.Windows.Forms.Label

    Private WithEvents lblMaquina As System.Windows.Forms.Label
    Private WithEvents cboMaquina As System.Windows.Forms.ComboBox
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents pancontenido As System.Windows.Forms.Panel
    Private WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpEmpleados As System.Windows.Forms.TabPage
    Private WithEvents lblMinutos As System.Windows.Forms.Label
    Private WithEvents lblClaseIncidencia As System.Windows.Forms.Label
    Private WithEvents dtpnumMinutos As System.Windows.Forms.NumericUpDown
    Private WithEvents Panel3 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents lblTipoIncidenciaID As System.Windows.Forms.Label
    Private WithEvents lDato3 As System.Windows.Forms.Label
    Private WithEvents lDato2 As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
End Class
