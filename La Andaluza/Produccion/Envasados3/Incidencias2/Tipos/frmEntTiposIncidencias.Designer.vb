<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposIncidencias))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboClaseIncidencia = New System.Windows.Forms.ComboBox()
        Me.butVerClaseIncidenciaID = New System.Windows.Forms.Button()
        Me.butAddClaseIncidenciaID = New System.Windows.Forms.Button()
        Me.cboCategoriaIncidencia = New System.Windows.Forms.ComboBox()
        Me.butVerCategoriaIncidenciaID = New System.Windows.Forms.Button()
        Me.butAddCategoriaIncidenciaID = New System.Windows.Forms.Button()
        Me.txtDuracion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboIncidenciaCalidadGeneral = New System.Windows.Forms.ComboBox()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblClaseIncidenciaID = New System.Windows.Forms.Label()
        Me.lblCategoriaIncidenciaID = New System.Windows.Forms.Label()
        Me.lblDuracion = New System.Windows.Forms.Label()
        Me.lblId_IncidenciaCalidadGeneral = New System.Windows.Forms.Label()

        Me.btnLimpiarIncidencia = New System.Windows.Forms.Button()
        Me.btnLimpiarMaquina = New System.Windows.Forms.Button()
        Me.lblMaquinaID = New System.Windows.Forms.Label()
        Me.cboMaquina = New System.Windows.Forms.ComboBox()
        Me.butVerMaquinaID = New System.Windows.Forms.Button()
        Me.butAddMaquinaID = New System.Windows.Forms.Button()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(170, 42)
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
        Me.txtDescripcion.Size = New System.Drawing.Size(403, 21)
        Me.txtDescripcion.TabIndex = 1
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboClaseIncidencia
        '
        Me.cboClaseIncidencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboClaseIncidencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboClaseIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboClaseIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboClaseIncidencia.Location = New System.Drawing.Point(170, 101)
        Me.cboClaseIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboClaseIncidencia.Name = "cboClaseIncidencia"
        Me.cboClaseIncidencia.Size = New System.Drawing.Size(403, 23)
        Me.cboClaseIncidencia.TabIndex = 7
        '
        'butVerClaseIncidenciaID
        '
        Me.butVerClaseIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerClaseIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butVerClaseIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerClaseIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerClaseIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerClaseIncidenciaID.Location = New System.Drawing.Point(577, 100)
        Me.butVerClaseIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerClaseIncidenciaID.Name = "butVerClaseIncidenciaID"
        Me.butVerClaseIncidenciaID.Size = New System.Drawing.Size(18, 22)
        Me.butVerClaseIncidenciaID.TabIndex = 8
        Me.butVerClaseIncidenciaID.TabStop = False
        '
        'butAddClaseIncidenciaID
        '
        Me.butAddClaseIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddClaseIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butAddClaseIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddClaseIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddClaseIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddClaseIncidenciaID.Location = New System.Drawing.Point(599, 100)
        Me.butAddClaseIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddClaseIncidenciaID.Name = "butAddClaseIncidenciaID"
        Me.butAddClaseIncidenciaID.Size = New System.Drawing.Size(18, 22)
        Me.butAddClaseIncidenciaID.TabIndex = 9
        Me.butAddClaseIncidenciaID.TabStop = False
        '
        'cboCategoriaIncidencia
        '
        Me.cboCategoriaIncidencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboCategoriaIncidencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboCategoriaIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboCategoriaIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboCategoriaIncidencia.Location = New System.Drawing.Point(170, 71)
        Me.cboCategoriaIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboCategoriaIncidencia.Name = "cboCategoriaIncidencia"
        Me.cboCategoriaIncidencia.Size = New System.Drawing.Size(403, 23)
        Me.cboCategoriaIncidencia.TabIndex = 3
        '
        'butVerCategoriaIncidenciaID
        '
        Me.butVerCategoriaIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerCategoriaIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butVerCategoriaIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerCategoriaIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerCategoriaIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerCategoriaIncidenciaID.Location = New System.Drawing.Point(577, 70)
        Me.butVerCategoriaIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerCategoriaIncidenciaID.Name = "butVerCategoriaIncidenciaID"
        Me.butVerCategoriaIncidenciaID.Size = New System.Drawing.Size(18, 22)
        Me.butVerCategoriaIncidenciaID.TabIndex = 4
        Me.butVerCategoriaIncidenciaID.TabStop = False
        '
        'butAddCategoriaIncidenciaID
        '
        Me.butAddCategoriaIncidenciaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddCategoriaIncidenciaID.FlatAppearance.BorderSize = 0
        Me.butAddCategoriaIncidenciaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddCategoriaIncidenciaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddCategoriaIncidenciaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddCategoriaIncidenciaID.Location = New System.Drawing.Point(599, 70)
        Me.butAddCategoriaIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddCategoriaIncidenciaID.Name = "butAddCategoriaIncidenciaID"
        Me.butAddCategoriaIncidenciaID.Size = New System.Drawing.Size(18, 22)
        Me.butAddCategoriaIncidenciaID.TabIndex = 5
        Me.butAddCategoriaIncidenciaID.TabStop = False
        '
        'txtDuracion
        '
        Me.txtDuracion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDuracion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDuracion.EsUnicoCampo = ""
        Me.txtDuracion.EsUnicoCampoID = ""
        Me.txtDuracion.EsUnicoID = 0
        Me.txtDuracion.EsUnicoTabla = ""
        Me.txtDuracion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDuracion.Location = New System.Drawing.Point(170, 161)
        Me.txtDuracion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDuracion.MaxLength = 9
        Me.txtDuracion.Minimo = 0
        Me.txtDuracion.Modificado = False
        Me.txtDuracion.Name = "txtDuracion"
        Me.txtDuracion.Numerico_EsNumerico = False
        Me.txtDuracion.Numerico_NumeroDoublees = 0
        Me.txtDuracion.Numerico_SeparadorMiles = False
        Me.txtDuracion.Obligatorio = False
        Me.txtDuracion.ParametroID = 0
        Me.txtDuracion.Size = New System.Drawing.Size(111, 21)
        Me.txtDuracion.TabIndex = 16
        Me.txtDuracion.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDuracion.ValorMaximo = 0.0R
        Me.txtDuracion.ValorMinimo = 0.0R
        '
        'cboIncidenciaCalidadGeneral
        '
        Me.cboIncidenciaCalidadGeneral.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboIncidenciaCalidadGeneral.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIncidenciaCalidadGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIncidenciaCalidadGeneral.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIncidenciaCalidadGeneral.Location = New System.Drawing.Point(170, 188)
        Me.cboIncidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboIncidenciaCalidadGeneral.Name = "cboIncidenciaCalidadGeneral"
        Me.cboIncidenciaCalidadGeneral.Size = New System.Drawing.Size(403, 23)
        Me.cboIncidenciaCalidadGeneral.TabIndex = 18
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(23, 40)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(142, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblClaseIncidenciaID
        '
        Me.lblClaseIncidenciaID.Location = New System.Drawing.Point(23, 98)
        Me.lblClaseIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblClaseIncidenciaID.Name = "lblClaseIncidenciaID"
        Me.lblClaseIncidenciaID.Size = New System.Drawing.Size(142, 30)
        Me.lblClaseIncidenciaID.TabIndex = 6
        Me.lblClaseIncidenciaID.Text = "Clase"
        Me.lblClaseIncidenciaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCategoriaIncidenciaID
        '
        Me.lblCategoriaIncidenciaID.Location = New System.Drawing.Point(23, 68)
        Me.lblCategoriaIncidenciaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCategoriaIncidenciaID.Name = "lblCategoriaIncidenciaID"
        Me.lblCategoriaIncidenciaID.Size = New System.Drawing.Size(142, 30)
        Me.lblCategoriaIncidenciaID.TabIndex = 2
        Me.lblCategoriaIncidenciaID.Text = "Categoría"
        Me.lblCategoriaIncidenciaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDuracion
        '
        Me.lblDuracion.Location = New System.Drawing.Point(23, 158)
        Me.lblDuracion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDuracion.Name = "lblDuracion"
        Me.lblDuracion.Size = New System.Drawing.Size(142, 28)
        Me.lblDuracion.TabIndex = 15
        Me.lblDuracion.Text = "Duración"
        Me.lblDuracion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_IncidenciaCalidadGeneral
        '
        Me.lblId_IncidenciaCalidadGeneral.Location = New System.Drawing.Point(23, 186)
        Me.lblId_IncidenciaCalidadGeneral.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_IncidenciaCalidadGeneral.Name = "lblId_IncidenciaCalidadGeneral"
        Me.lblId_IncidenciaCalidadGeneral.Size = New System.Drawing.Size(142, 30)
        Me.lblId_IncidenciaCalidadGeneral.TabIndex = 17
        Me.lblId_IncidenciaCalidadGeneral.Text = "Incidencia calidad"
        Me.lblId_IncidenciaCalidadGeneral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'btnLimpiarIncidencia
        '
        Me.btnLimpiarIncidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarIncidencia.FlatAppearance.BorderSize = 0
        Me.btnLimpiarIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarIncidencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnLimpiarIncidencia.Location = New System.Drawing.Point(577, 189)
        Me.btnLimpiarIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiarIncidencia.Name = "btnLimpiarIncidencia"
        Me.btnLimpiarIncidencia.Size = New System.Drawing.Size(18, 21)
        Me.btnLimpiarIncidencia.TabIndex = 19
        Me.btnLimpiarIncidencia.TabStop = False
        '
        'btnLimpiarMaquina
        '
        Me.btnLimpiarMaquina.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiarMaquina.FlatAppearance.BorderSize = 0
        Me.btnLimpiarMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiarMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLimpiarMaquina.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnLimpiarMaquina.Location = New System.Drawing.Point(555, 132)
        Me.btnLimpiarMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiarMaquina.Name = "btnLimpiarMaquina"
        Me.btnLimpiarMaquina.Size = New System.Drawing.Size(18, 21)
        Me.btnLimpiarMaquina.TabIndex = 12
        Me.btnLimpiarMaquina.TabStop = False
        '
        'lblMaquinaID
        '
        Me.lblMaquinaID.Location = New System.Drawing.Point(23, 129)
        Me.lblMaquinaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaquinaID.Name = "lblMaquinaID"
        Me.lblMaquinaID.Size = New System.Drawing.Size(142, 30)
        Me.lblMaquinaID.TabIndex = 10
        Me.lblMaquinaID.Text = "Máquina"
        Me.lblMaquinaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaquina.Location = New System.Drawing.Point(170, 132)
        Me.cboMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(384, 23)
        Me.cboMaquina.TabIndex = 11
        '
        'butVerMaquinaID
        '
        Me.butVerMaquinaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerMaquinaID.FlatAppearance.BorderSize = 0
        Me.butVerMaquinaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerMaquinaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerMaquinaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerMaquinaID.Location = New System.Drawing.Point(577, 132)
        Me.butVerMaquinaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerMaquinaID.Name = "butVerMaquinaID"
        Me.butVerMaquinaID.Size = New System.Drawing.Size(18, 21)
        Me.butVerMaquinaID.TabIndex = 13
        Me.butVerMaquinaID.TabStop = False
        '
        'butAddMaquinaID
        '
        Me.butAddMaquinaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddMaquinaID.FlatAppearance.BorderSize = 0
        Me.butAddMaquinaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMaquinaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMaquinaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMaquinaID.Location = New System.Drawing.Point(599, 132)
        Me.butAddMaquinaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddMaquinaID.Name = "butAddMaquinaID"
        Me.butAddMaquinaID.Size = New System.Drawing.Size(18, 21)
        Me.butAddMaquinaID.TabIndex = 14
        Me.butAddMaquinaID.TabStop = False
        '
        'frmEntTiposIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(680, 240)
        Me.Controls.Add(Me.btnLimpiarMaquina)
        Me.Controls.Add(Me.lblMaquinaID)
        Me.Controls.Add(Me.cboMaquina)
        Me.Controls.Add(Me.butVerMaquinaID)
        Me.Controls.Add(Me.butAddMaquinaID)
        Me.Controls.Add(Me.btnLimpiarIncidencia)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblCategoriaIncidenciaID)
        Me.Controls.Add(Me.cboCategoriaIncidencia)
        Me.Controls.Add(Me.cboClaseIncidencia)
        Me.Controls.Add(Me.cboIncidenciaCalidadGeneral)
        Me.Controls.Add(Me.lblId_IncidenciaCalidadGeneral)
        Me.Controls.Add(Me.lblClaseIncidenciaID)
        Me.Controls.Add(Me.txtDuracion)
        Me.Controls.Add(Me.lblDuracion)
        Me.Controls.Add(Me.butAddClaseIncidenciaID)
        Me.Controls.Add(Me.butVerCategoriaIncidenciaID)
        Me.Controls.Add(Me.butVerClaseIncidenciaID)
        Me.Controls.Add(Me.butAddCategoriaIncidenciaID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(444, 240)
        Me.Name = "frmEntTiposIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposIncidencias"
        Me.Controls.SetChildIndex(Me.butAddCategoriaIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.butVerClaseIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.butVerCategoriaIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.butAddClaseIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.lblDuracion, 0)
        Me.Controls.SetChildIndex(Me.txtDuracion, 0)
        Me.Controls.SetChildIndex(Me.lblClaseIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.lblId_IncidenciaCalidadGeneral, 0)
        Me.Controls.SetChildIndex(Me.cboIncidenciaCalidadGeneral, 0)
        Me.Controls.SetChildIndex(Me.cboClaseIncidencia, 0)
        Me.Controls.SetChildIndex(Me.cboCategoriaIncidencia, 0)
        Me.Controls.SetChildIndex(Me.lblCategoriaIncidenciaID, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiarIncidencia, 0)
        Me.Controls.SetChildIndex(Me.butAddMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.butVerMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.cboMaquina, 0)
        Me.Controls.SetChildIndex(Me.lblMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.btnLimpiarMaquina, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboClaseIncidencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerClaseIncidenciaID As System.Windows.Forms.Button
    Private WithEvents butAddClaseIncidenciaID As System.Windows.Forms.Button
    Private WithEvents cboCategoriaIncidencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerCategoriaIncidenciaID As System.Windows.Forms.Button
    Private WithEvents butAddCategoriaIncidenciaID As System.Windows.Forms.Button
    Private WithEvents txtDuracion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboIncidenciaCalidadGeneral As System.Windows.Forms.ComboBox
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblClaseIncidenciaID As System.Windows.Forms.Label
    Private WithEvents lblCategoriaIncidenciaID As System.Windows.Forms.Label
    Private WithEvents lblDuracion As System.Windows.Forms.Label
    Private WithEvents lblId_IncidenciaCalidadGeneral As System.Windows.Forms.Label

    Private WithEvents btnLimpiarIncidencia As System.Windows.Forms.Button
    Private WithEvents btnLimpiarMaquina As System.Windows.Forms.Button
    Private WithEvents lblMaquinaID As System.Windows.Forms.Label
    Private WithEvents cboMaquina As System.Windows.Forms.ComboBox
    Private WithEvents butVerMaquinaID As System.Windows.Forms.Button
    Private WithEvents butAddMaquinaID As System.Windows.Forms.Button
End Class
