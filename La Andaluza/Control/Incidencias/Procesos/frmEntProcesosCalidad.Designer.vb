<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntProcesosCalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntProcesosCalidad))
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.cboempleado = New System.Windows.Forms.ComboBox()
        Me.butVerId_empleado = New System.Windows.Forms.Button()
        Me.butAddId_empleado = New System.Windows.Forms.Button()
        Me.txtDescripcionIngles = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblId_empleado = New System.Windows.Forms.Label()
        Me.lblDescripcionIngles = New System.Windows.Forms.Label()

        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpClasesEnvasado = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
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
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 12)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 500
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Multiline = True
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(379, 90)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
        '
        'cboempleado
        '
        Me.cboempleado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboempleado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboempleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboempleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboempleado.Location = New System.Drawing.Point(130, 228)
        Me.cboempleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboempleado.Name = "cboempleado"
        Me.cboempleado.Size = New System.Drawing.Size(334, 23)
        Me.cboempleado.TabIndex = 1
        '
        'butVerId_empleado
        '
        Me.butVerId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_empleado.FlatAppearance.BorderSize = 0
        Me.butVerId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_empleado.Location = New System.Drawing.Point(467, 228)
        Me.butVerId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_empleado.Name = "butVerId_empleado"
        Me.butVerId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_empleado.TabIndex = 2
        Me.butVerId_empleado.TabStop = False
        '
        'butAddId_empleado
        '
        Me.butAddId_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_empleado.FlatAppearance.BorderSize = 0
        Me.butAddId_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_empleado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_empleado.Location = New System.Drawing.Point(490, 228)
        Me.butAddId_empleado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_empleado.Name = "butAddId_empleado"
        Me.butAddId_empleado.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_empleado.TabIndex = 3
        Me.butAddId_empleado.TabStop = False
        '
        'txtDescripcionIngles
        '
        Me.txtDescripcionIngles.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcionIngles.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcionIngles.EsUnicoCampo = ""
        Me.txtDescripcionIngles.EsUnicoCampoID = ""
        Me.txtDescripcionIngles.EsUnicoID = 0
        Me.txtDescripcionIngles.EsUnicoTabla = ""
        Me.txtDescripcionIngles.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcionIngles.Location = New System.Drawing.Point(130, 119)
        Me.txtDescripcionIngles.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcionIngles.MaxLength = 250
        Me.txtDescripcionIngles.Minimo = 0
        Me.txtDescripcionIngles.Modificado = False
        Me.txtDescripcionIngles.Multiline = True
        Me.txtDescripcionIngles.Name = "txtDescripcionIngles"
        Me.txtDescripcionIngles.Numerico_EsNumerico = False
        Me.txtDescripcionIngles.Numerico_NumeroDoublees = 0
        Me.txtDescripcionIngles.Numerico_SeparadorMiles = False
        Me.txtDescripcionIngles.Obligatorio = False
        Me.txtDescripcionIngles.ParametroID = 0
        Me.txtDescripcionIngles.Size = New System.Drawing.Size(379, 84)
        Me.txtDescripcionIngles.TabIndex = 2
        Me.txtDescripcionIngles.ValorMaximo = 0.0R
        Me.txtDescripcionIngles.ValorMinimo = 0.0R
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(33, 10)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(92, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblId_empleado
        '
        Me.lblId_empleado.Location = New System.Drawing.Point(33, 226)
        Me.lblId_empleado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_empleado.Name = "lblId_empleado"
        Me.lblId_empleado.Size = New System.Drawing.Size(92, 30)
        Me.lblId_empleado.TabIndex = 1
        Me.lblId_empleado.Text = "Empleado"
        Me.lblId_empleado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcionIngles
        '
        Me.lblDescripcionIngles.Location = New System.Drawing.Point(33, 116)
        Me.lblDescripcionIngles.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcionIngles.Name = "lblDescripcionIngles"
        Me.lblDescripcionIngles.Size = New System.Drawing.Size(92, 28)
        Me.lblDescripcionIngles.TabIndex = 4
        Me.lblDescripcionIngles.Text = "Inglés"
        Me.lblDescripcionIngles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 25)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(782, 604)
        Me.SplitContainer1.SplitterDistance = 274
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1000000001
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpClasesEnvasado)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(782, 327)
        Me.TabControl1.TabIndex = 0
        '
        'tpClasesEnvasado
        '
        Me.tpClasesEnvasado.Location = New System.Drawing.Point(4, 22)
        Me.tpClasesEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpClasesEnvasado.Name = "tpClasesEnvasado"
        Me.tpClasesEnvasado.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpClasesEnvasado.Size = New System.Drawing.Size(774, 301)
        Me.tpClasesEnvasado.TabIndex = 1
        Me.tpClasesEnvasado.Text = "Clases incidencias envasado"
        Me.tpClasesEnvasado.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.lblDescripcionIngles)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.butAddId_empleado)
        Me.Panel1.Controls.Add(Me.txtDescripcionIngles)
        Me.Panel1.Controls.Add(Me.butVerId_empleado)
        Me.Panel1.Controls.Add(Me.lblId_empleado)
        Me.Panel1.Controls.Add(Me.cboempleado)
        Me.Panel1.Location = New System.Drawing.Point(70, 20)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(542, 263)
        Me.Panel1.TabIndex = 1000000002
        '
        'frmEntProcesosCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(782, 629)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(394, 159)
        Me.Name = "frmEntProcesosCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ProcesosCalidad"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


   Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents cboempleado As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_empleado As System.Windows.Forms.Button
    Private WithEvents butAddId_empleado As System.Windows.Forms.Button
    Private WithEvents txtDescripcionIngles As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblId_empleado As System.Windows.Forms.Label
    Private WithEvents lblDescripcionIngles As System.Windows.Forms.Label
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents tpClasesEnvasado As System.Windows.Forms.TabPage
    Private WithEvents Panel1 As System.Windows.Forms.Panel
End Class
