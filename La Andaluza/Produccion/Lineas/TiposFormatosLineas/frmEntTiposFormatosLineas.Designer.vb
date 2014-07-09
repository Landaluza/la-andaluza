<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposFormatosLineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposFormatosLineas))
        Me.cboLineaEnvasado = New System.Windows.Forms.ComboBox()
        Me.butVerLineaEnvasadoID = New System.Windows.Forms.Button()
        Me.butAddLineaEnvasadoID = New System.Windows.Forms.Button()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblLineaEnvasadoID = New System.Windows.Forms.Label()

        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tpFormatosEnvasados = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtDescripcion = New System.Windows.Forms.TextBox()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboLineaEnvasado
        '
        Me.cboLineaEnvasado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLineaEnvasado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLineaEnvasado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLineaEnvasado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLineaEnvasado.Location = New System.Drawing.Point(133, 41)
        Me.cboLineaEnvasado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboLineaEnvasado.Name = "cboLineaEnvasado"
        Me.cboLineaEnvasado.Size = New System.Drawing.Size(181, 23)
        Me.cboLineaEnvasado.TabIndex = 1
        '
        'butVerLineaEnvasadoID
        '
        Me.butVerLineaEnvasadoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerLineaEnvasadoID.FlatAppearance.BorderSize = 0
        Me.butVerLineaEnvasadoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerLineaEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerLineaEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerLineaEnvasadoID.Location = New System.Drawing.Point(317, 41)
        Me.butVerLineaEnvasadoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerLineaEnvasadoID.Name = "butVerLineaEnvasadoID"
        Me.butVerLineaEnvasadoID.Size = New System.Drawing.Size(18, 19)
        Me.butVerLineaEnvasadoID.TabIndex = 2
        Me.butVerLineaEnvasadoID.TabStop = False
        '
        'butAddLineaEnvasadoID
        '
        Me.butAddLineaEnvasadoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddLineaEnvasadoID.FlatAppearance.BorderSize = 0
        Me.butAddLineaEnvasadoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddLineaEnvasadoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddLineaEnvasadoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddLineaEnvasadoID.Location = New System.Drawing.Point(340, 41)
        Me.butAddLineaEnvasadoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddLineaEnvasadoID.Name = "butAddLineaEnvasadoID"
        Me.butAddLineaEnvasadoID.Size = New System.Drawing.Size(18, 19)
        Me.butAddLineaEnvasadoID.TabIndex = 3
        Me.butAddLineaEnvasadoID.TabStop = False
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(32, 11)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(96, 28)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLineaEnvasadoID
        '
        Me.lblLineaEnvasadoID.Location = New System.Drawing.Point(32, 39)
        Me.lblLineaEnvasadoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineaEnvasadoID.Name = "lblLineaEnvasadoID"
        Me.lblLineaEnvasadoID.Size = New System.Drawing.Size(96, 30)
        Me.lblLineaEnvasadoID.TabIndex = 1
        Me.lblLineaEnvasadoID.Text = "Linea"
        Me.lblLineaEnvasadoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tpFormatosEnvasados)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(609, 382)
        Me.TabControl1.TabIndex = 1000000001
        '
        'tpFormatosEnvasados
        '
        Me.tpFormatosEnvasados.Location = New System.Drawing.Point(4, 22)
        Me.tpFormatosEnvasados.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpFormatosEnvasados.Name = "tpFormatosEnvasados"
        Me.tpFormatosEnvasados.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpFormatosEnvasados.Size = New System.Drawing.Size(601, 356)
        Me.tpFormatosEnvasados.TabIndex = 0
        Me.tpFormatosEnvasados.Text = "Formatos envasados"
        Me.tpFormatosEnvasados.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.cboLineaEnvasado)
        Me.Panel1.Controls.Add(Me.butAddLineaEnvasadoID)
        Me.Panel1.Controls.Add(Me.butVerLineaEnvasadoID)
        Me.Panel1.Controls.Add(Me.lblDescripcion)
        Me.Panel1.Controls.Add(Me.lblLineaEnvasadoID)
        Me.Panel1.Location = New System.Drawing.Point(104, 2)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 81)
        Me.Panel1.TabIndex = 1000000002
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDescripcion.Location = New System.Drawing.Point(133, 16)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(181, 20)
        Me.txtDescripcion.TabIndex = 4
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
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Size = New System.Drawing.Size(609, 454)
        Me.SplitContainer1.SplitterDistance = 69
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 1000000004
        '
        'frmEntTiposFormatosLineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(609, 479)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(396, 133)
        Me.Name = "frmEntTiposFormatosLineas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposFormatosLineas"
        Me.Controls.SetChildIndex(Me.SplitContainer1, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboLineaEnvasado As System.Windows.Forms.ComboBox
   Private WithEvents butVerLineaEnvasadoID As System.Windows.Forms.Button
   Private WithEvents butAddLineaEnvasadoID As System.Windows.Forms.Button
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblLineaEnvasadoID As System.Windows.Forms.Label

    Private WithEvents tpFormatosEnvasados As System.Windows.Forms.TabPage
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Private WithEvents TabControl1 As System.Windows.Forms.TabControl
    Private WithEvents txtDescripcion As System.Windows.Forms.TextBox
End Class
