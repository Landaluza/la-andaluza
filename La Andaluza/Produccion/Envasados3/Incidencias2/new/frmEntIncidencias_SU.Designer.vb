<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEntIncidencias_SU
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
        Me.dtpHoraInicio = New System.Windows.Forms.DateTimePicker()
        Me.dtpHoraFin = New System.Windows.Forms.DateTimePicker()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboTipoIncidencia = New System.Windows.Forms.ComboBox()
        Me.butVerTipoIncidenciaID = New System.Windows.Forms.Button()
        Me.butAddTipoIncidenciaID = New System.Windows.Forms.Button()
        Me.lblHoraInicio = New System.Windows.Forms.Label()
        Me.lblHoraFin = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()
        Me.lblTipoIncidenciaID = New System.Windows.Forms.Label()

        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboClase = New System.Windows.Forms.ComboBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.pancontenido = New System.Windows.Forms.Panel()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblMaquinas = New System.Windows.Forms.Label()
        Me.cboMaquina = New System.Windows.Forms.ComboBox()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpEmpleados = New System.Windows.Forms.TabPage()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.pancontenido.SuspendLayout()
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
        Me.dtpHoraInicio.Location = New System.Drawing.Point(7, 250)
        Me.dtpHoraInicio.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHoraInicio.Name = "dtpHoraInicio"
        Me.dtpHoraInicio.ShowUpDown = True
        Me.dtpHoraInicio.Size = New System.Drawing.Size(101, 34)
        Me.dtpHoraInicio.TabIndex = 10
        '
        'dtpHoraFin
        '
        Me.dtpHoraFin.BackColor = System.Drawing.SystemColors.Window
        Me.dtpHoraFin.CustomFormat = "HH.mm"
        Me.dtpHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpHoraFin.Location = New System.Drawing.Point(172, 250)
        Me.dtpHoraFin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtpHoraFin.Name = "dtpHoraFin"
        Me.dtpHoraFin.ShowUpDown = True
        Me.dtpHoraFin.Size = New System.Drawing.Size(100, 34)
        Me.dtpHoraFin.TabIndex = 12
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(4, 331)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
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
        Me.txtObservaciones.Size = New System.Drawing.Size(444, 75)
        Me.txtObservaciones.TabIndex = 14
        Me.txtObservaciones.ValorMaximo = 0.0!
        Me.txtObservaciones.ValorMinimo = 0.0!
        '
        'cboTipoIncidencia
        '
        Me.cboTipoIncidencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboTipoIncidencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboTipoIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboTipoIncidencia.Location = New System.Drawing.Point(7, 187)
        Me.cboTipoIncidencia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboTipoIncidencia.Name = "cboTipoIncidencia"
        Me.cboTipoIncidencia.Size = New System.Drawing.Size(440, 26)
        Me.cboTipoIncidencia.TabIndex = 8
        '
        'butVerTipoIncidenciaID
        '
        Me.butVerTipoIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerTipoIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butVerTipoIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerTipoIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerTipoIncidenciaID.Location = New System.Drawing.Point(111, 164)
        Me.butVerTipoIncidenciaID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butVerTipoIncidenciaID.Name = "butVerTipoIncidenciaID"
        Me.butVerTipoIncidenciaID.Size = New System.Drawing.Size(21, 18)
        Me.butVerTipoIncidenciaID.TabIndex = 6
        Me.butVerTipoIncidenciaID.TabStop = False
        '
        'butAddTipoIncidenciaID
        '
        Me.butAddTipoIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddTipoIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butAddTipoIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddTipoIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddTipoIncidenciaID.Location = New System.Drawing.Point(141, 165)
        Me.butAddTipoIncidenciaID.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.butAddTipoIncidenciaID.Name = "butAddTipoIncidenciaID"
        Me.butAddTipoIncidenciaID.Size = New System.Drawing.Size(21, 18)
        Me.butAddTipoIncidenciaID.TabIndex = 7
        Me.butAddTipoIncidenciaID.TabStop = False
        '
        'lblHoraInicio
        '
        Me.lblHoraInicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraInicio.Location = New System.Drawing.Point(20, 219)
        Me.lblHoraInicio.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraInicio.Name = "lblHoraInicio"
        Me.lblHoraInicio.Size = New System.Drawing.Size(61, 27)
        Me.lblHoraInicio.TabIndex = 9
        Me.lblHoraInicio.Text = "Inicio"
        Me.lblHoraInicio.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblHoraFin
        '
        Me.lblHoraFin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHoraFin.Location = New System.Drawing.Point(193, 219)
        Me.lblHoraFin.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHoraFin.Name = "lblHoraFin"
        Me.lblHoraFin.Size = New System.Drawing.Size(55, 27)
        Me.lblHoraFin.TabIndex = 11
        Me.lblHoraFin.Text = "Fin"
        Me.lblHoraFin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObservaciones.Location = New System.Drawing.Point(4, 295)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(159, 32)
        Me.lblObservaciones.TabIndex = 13
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTipoIncidenciaID
        '
        Me.lblTipoIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoIncidenciaID.Location = New System.Drawing.Point(4, 153)
        Me.lblTipoIncidenciaID.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTipoIncidenciaID.Name = "lblTipoIncidenciaID"
        Me.lblTipoIncidenciaID.Size = New System.Drawing.Size(77, 31)
        Me.lblTipoIncidenciaID.TabIndex = 5
        Me.lblTipoIncidenciaID.Text = "Tipo"
        Me.lblTipoIncidenciaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(4, 5)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Categoría"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboClase
        '
        Me.cboClase.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboClase.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClase.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClase.Location = New System.Drawing.Point(7, 31)
        Me.cboClase.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboClase.Name = "cboClase"
        Me.cboClase.Size = New System.Drawing.Size(332, 37)
        Me.cboClase.TabIndex = 2
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.pancontenido)
        Me.SplitContainer1.Size = New System.Drawing.Size(1029, 428)
        Me.SplitContainer1.SplitterDistance = 486
        Me.SplitContainer1.SplitterWidth = 5
        Me.SplitContainer1.TabIndex = 0
        '
        'pancontenido
        '
        Me.pancontenido.Controls.Add(Me.btnHelp)
        Me.pancontenido.Controls.Add(Me.dtpHoraFin)
        Me.pancontenido.Controls.Add(Me.lblMaquinas)
        Me.pancontenido.Controls.Add(Me.lblHoraFin)
        Me.pancontenido.Controls.Add(Me.cboMaquina)
        Me.pancontenido.Controls.Add(Me.dtpHoraInicio)
        Me.pancontenido.Controls.Add(Me.lblHoraInicio)
        Me.pancontenido.Controls.Add(Me.butVerTipoIncidenciaID)
        Me.pancontenido.Controls.Add(Me.Label1)
        Me.pancontenido.Controls.Add(Me.cboTipoIncidencia)
        Me.pancontenido.Controls.Add(Me.cboClase)
        Me.pancontenido.Controls.Add(Me.lblTipoIncidenciaID)
        Me.pancontenido.Controls.Add(Me.butAddTipoIncidenciaID)
        Me.pancontenido.Controls.Add(Me.txtObservaciones)
        Me.pancontenido.Controls.Add(Me.lblObservaciones)
        Me.pancontenido.Location = New System.Drawing.Point(17, 4)
        Me.pancontenido.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pancontenido.Name = "pancontenido"
        Me.pancontenido.Size = New System.Drawing.Size(451, 411)
        Me.pancontenido.TabIndex = 0
        '
        'btnHelp
        '
        Me.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnHelp.FlatAppearance.BorderSize = 0
        Me.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHelp.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHelp.Image = Global.La_Andaluza.My.Resources.Resources.system_help_3
        Me.btnHelp.Location = New System.Drawing.Point(141, 9)
        Me.btnHelp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(21, 18)
        Me.btnHelp.TabIndex = 1
        Me.btnHelp.TabStop = False
        '
        'lblMaquinas
        '
        Me.lblMaquinas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMaquinas.Location = New System.Drawing.Point(3, 74)
        Me.lblMaquinas.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaquinas.Name = "lblMaquinas"
        Me.lblMaquinas.Size = New System.Drawing.Size(129, 37)
        Me.lblMaquinas.TabIndex = 3
        Me.lblMaquinas.Text = "Maquina"
        Me.lblMaquinas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaquina.Enabled = False
        Me.cboMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaquina.Location = New System.Drawing.Point(8, 114)
        Me.cboMaquina.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(440, 26)
        Me.cboMaquina.TabIndex = 4
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1029, 565)
        Me.SplitContainer2.SplitterDistance = 428
        Me.SplitContainer2.TabIndex = 1000000004
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpEmpleados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1029, 133)
        Me.TabControl1.TabIndex = 0
        '
        'tpEmpleados
        '
        Me.tpEmpleados.Location = New System.Drawing.Point(4, 25)
        Me.tpEmpleados.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpEmpleados.Name = "tpEmpleados"
        Me.tpEmpleados.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.tpEmpleados.Size = New System.Drawing.Size(1021, 104)
        Me.tpEmpleados.TabIndex = 0
        Me.tpEmpleados.Text = "Personal extra requerido por la incidencia"
        Me.tpEmpleados.UseVisualStyleBackColor = True
        '
        'frmEntIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(1029, 590)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MinimumSize = New System.Drawing.Size(622, 264)
        Me.Name = "frmEntIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Incidencias"
        Me.Controls.SetChildIndex(Me.SplitContainer2, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.pancontenido.ResumeLayout(False)
        Me.pancontenido.PerformLayout()
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
    Private WithEvents lblTipoIncidenciaID As System.Windows.Forms.Label

    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents cboClase As System.Windows.Forms.ComboBox
    Private WithEvents lblMaquinas As System.Windows.Forms.Label
    Private WithEvents cboMaquina As System.Windows.Forms.ComboBox
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents pancontenido As System.Windows.Forms.Panel
    Private WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpEmpleados As System.Windows.Forms.TabPage
    Private WithEvents btnHelp As System.Windows.Forms.Button
End Class
