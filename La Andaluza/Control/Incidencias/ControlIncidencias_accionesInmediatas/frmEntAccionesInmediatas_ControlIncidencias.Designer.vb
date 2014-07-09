<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAccionesInmediatas_ControlIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAccionesInmediatas_ControlIncidencias))
        Me.cboAccionesInmediatas = New System.Windows.Forms.ComboBox()
        Me.butVerId_AccionesInmediatas = New System.Windows.Forms.Button()
        Me.butAddId_AccionesInmediatas = New System.Windows.Forms.Button()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboid_empleado = New System.Windows.Forms.ComboBox()
        Me.butVerid_empleado = New System.Windows.Forms.Button()
        Me.butAddid_empleado = New System.Windows.Forms.Button()
        Me.lblId_AccionesInmediatas = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblid_empleado = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboAccionesInmediatas
        '
        Me.cboAccionesInmediatas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboAccionesInmediatas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboAccionesInmediatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboAccionesInmediatas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboAccionesInmediatas.Location = New System.Drawing.Point(140, 46)
        Me.cboAccionesInmediatas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboAccionesInmediatas.Name = "cboAccionesInmediatas"
        Me.cboAccionesInmediatas.Size = New System.Drawing.Size(351, 23)
        Me.cboAccionesInmediatas.TabIndex = 1
        '
        'butVerId_AccionesInmediatas
        '
        Me.butVerId_AccionesInmediatas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_AccionesInmediatas.FlatAppearance.BorderSize = 0
        Me.butVerId_AccionesInmediatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_AccionesInmediatas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_AccionesInmediatas.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_AccionesInmediatas.Location = New System.Drawing.Point(495, 47)
        Me.butVerId_AccionesInmediatas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_AccionesInmediatas.Name = "butVerId_AccionesInmediatas"
        Me.butVerId_AccionesInmediatas.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_AccionesInmediatas.TabIndex = 4
        Me.butVerId_AccionesInmediatas.TabStop = False
        '
        'butAddId_AccionesInmediatas
        '
        Me.butAddId_AccionesInmediatas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_AccionesInmediatas.FlatAppearance.BorderSize = 0
        Me.butAddId_AccionesInmediatas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_AccionesInmediatas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_AccionesInmediatas.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_AccionesInmediatas.Location = New System.Drawing.Point(518, 47)
        Me.butAddId_AccionesInmediatas.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_AccionesInmediatas.Name = "butAddId_AccionesInmediatas"
        Me.butAddId_AccionesInmediatas.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_AccionesInmediatas.TabIndex = 5
        Me.butAddId_AccionesInmediatas.TabStop = False
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(140, 76)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 3000
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(351, 50)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboid_empleado
        '
        Me.cboid_empleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_empleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_empleado.Location = New System.Drawing.Point(140, 131)
        Me.cboid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboid_empleado.Name = "cboid_empleado"
        Me.cboid_empleado.Size = New System.Drawing.Size(351, 23)
        Me.cboid_empleado.TabIndex = 3
        '
        'butVerid_empleado
        '
        Me.butVerid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_empleado.FlatAppearance.BorderSize = 0
        Me.butVerid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerid_empleado.Location = New System.Drawing.Point(495, 132)
        Me.butVerid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerid_empleado.Name = "butVerid_empleado"
        Me.butVerid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerid_empleado.TabIndex = 8
        Me.butVerid_empleado.TabStop = False
        '
        'butAddid_empleado
        '
        Me.butAddid_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_empleado.FlatAppearance.BorderSize = 0
        Me.butAddid_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_empleado.Location = New System.Drawing.Point(518, 132)
        Me.butAddid_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddid_empleado.Name = "butAddid_empleado"
        Me.butAddid_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddid_empleado.TabIndex = 9
        Me.butAddid_empleado.TabStop = False
        '
        'lblId_AccionesInmediatas
        '
        Me.lblId_AccionesInmediatas.Location = New System.Drawing.Point(22, 44)
        Me.lblId_AccionesInmediatas.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_AccionesInmediatas.Name = "lblId_AccionesInmediatas"
        Me.lblId_AccionesInmediatas.Size = New System.Drawing.Size(114, 30)
        Me.lblId_AccionesInmediatas.TabIndex = 3
        Me.lblId_AccionesInmediatas.Text = "Acción inmediatas"
        Me.lblId_AccionesInmediatas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(22, 74)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(114, 28)
        Me.lblDescripcion.TabIndex = 6
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblid_empleado
        '
        Me.lblid_empleado.Location = New System.Drawing.Point(22, 128)
        Me.lblid_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblid_empleado.Name = "lblid_empleado"
        Me.lblid_empleado.Size = New System.Drawing.Size(114, 30)
        Me.lblid_empleado.TabIndex = 7
        Me.lblid_empleado.Text = "Responsable"
        Me.lblid_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAccionesInmediatas_ControlIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(561, 176)
        Me.Controls.Add(Me.cboAccionesInmediatas)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.lblId_AccionesInmediatas)
        Me.Controls.Add(Me.butAddId_AccionesInmediatas)
        Me.Controls.Add(Me.cboid_empleado)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.butAddid_empleado)
        Me.Controls.Add(Me.butVerId_AccionesInmediatas)
        Me.Controls.Add(Me.butVerid_empleado)
        Me.Controls.Add(Me.lblid_empleado)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(415, 188)
        Me.Name = "frmEntAccionesInmediatas_ControlIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AccionesInmediatas_ControlIncidencias"
        Me.Controls.SetChildIndex(Me.lblid_empleado, 0)
        Me.Controls.SetChildIndex(Me.butVerid_empleado, 0)
        Me.Controls.SetChildIndex(Me.butVerId_AccionesInmediatas, 0)
        Me.Controls.SetChildIndex(Me.butAddid_empleado, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboid_empleado, 0)
        Me.Controls.SetChildIndex(Me.butAddId_AccionesInmediatas, 0)
        Me.Controls.SetChildIndex(Me.lblId_AccionesInmediatas, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.cboAccionesInmediatas, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents cboAccionesInmediatas As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_AccionesInmediatas As System.Windows.Forms.Button
    Private WithEvents butAddId_AccionesInmediatas As System.Windows.Forms.Button
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboid_empleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_empleado As System.Windows.Forms.Button
    Private WithEvents butAddid_empleado As System.Windows.Forms.Button
    Private WithEvents lblId_AccionesInmediatas As System.Windows.Forms.Label
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblid_empleado As System.Windows.Forms.Label
End Class
