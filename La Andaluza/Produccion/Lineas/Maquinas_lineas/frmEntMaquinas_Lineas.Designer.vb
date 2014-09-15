<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntMaquinas_Lineas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntMaquinas_Lineas))
        Me.cboMaquina = New System.Windows.Forms.ComboBox()
        Me.butVerMaquinaID = New System.Windows.Forms.Button()
        Me.butAddMaquinaID = New System.Windows.Forms.Button()
        Me.cboLinea = New System.Windows.Forms.ComboBox()
        Me.lblMaquinaID = New System.Windows.Forms.Label()
        Me.lblLineaID = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboMaquina
        '
        Me.cboMaquina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboMaquina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboMaquina.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboMaquina.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMaquina.Location = New System.Drawing.Point(89, 41)
        Me.cboMaquina.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboMaquina.Name = "cboMaquina"
        Me.cboMaquina.Size = New System.Drawing.Size(258, 23)
        Me.cboMaquina.TabIndex = 0
        '
        'butVerMaquinaID
        '
        Me.butVerMaquinaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerMaquinaID.FlatAppearance.BorderSize = 0
        Me.butVerMaquinaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerMaquinaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerMaquinaID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerMaquinaID.Location = New System.Drawing.Point(351, 40)
        Me.butVerMaquinaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerMaquinaID.Name = "butVerMaquinaID"
        Me.butVerMaquinaID.Size = New System.Drawing.Size(18, 21)
        Me.butVerMaquinaID.TabIndex = 1
        Me.butVerMaquinaID.TabStop = False
        '
        'butAddMaquinaID
        '
        Me.butAddMaquinaID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddMaquinaID.FlatAppearance.BorderSize = 0
        Me.butAddMaquinaID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddMaquinaID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddMaquinaID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddMaquinaID.Location = New System.Drawing.Point(374, 40)
        Me.butAddMaquinaID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddMaquinaID.Name = "butAddMaquinaID"
        Me.butAddMaquinaID.Size = New System.Drawing.Size(18, 21)
        Me.butAddMaquinaID.TabIndex = 2
        Me.butAddMaquinaID.TabStop = False
        '
        'cboLinea
        '
        Me.cboLinea.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboLinea.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboLinea.Enabled = False
        Me.cboLinea.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboLinea.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboLinea.Location = New System.Drawing.Point(89, 71)
        Me.cboLinea.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboLinea.Name = "cboLinea"
        Me.cboLinea.Size = New System.Drawing.Size(258, 23)
        Me.cboLinea.TabIndex = 1
        '
        'lblMaquinaID
        '
        Me.lblMaquinaID.Location = New System.Drawing.Point(32, 38)
        Me.lblMaquinaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMaquinaID.Name = "lblMaquinaID"
        Me.lblMaquinaID.Size = New System.Drawing.Size(52, 30)
        Me.lblMaquinaID.TabIndex = 0
        Me.lblMaquinaID.Text = "Maquina"
        Me.lblMaquinaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLineaID
        '
        Me.lblLineaID.Enabled = False
        Me.lblLineaID.Location = New System.Drawing.Point(32, 68)
        Me.lblLineaID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLineaID.Name = "lblLineaID"
        Me.lblLineaID.Size = New System.Drawing.Size(52, 30)
        Me.lblLineaID.TabIndex = 3
        Me.lblLineaID.Text = "Linea"
        Me.lblLineaID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntMaquinas_Lineas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(430, 132)
        Me.Controls.Add(Me.cboMaquina)
        Me.Controls.Add(Me.lblLineaID)
        Me.Controls.Add(Me.lblMaquinaID)
        Me.Controls.Add(Me.cboLinea)
        Me.Controls.Add(Me.butVerMaquinaID)
        Me.Controls.Add(Me.butAddMaquinaID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntMaquinas_Lineas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Maquinas_Lineas"
        Me.Controls.SetChildIndex(Me.butAddMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.butVerMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.cboLinea, 0)
        Me.Controls.SetChildIndex(Me.lblMaquinaID, 0)
        Me.Controls.SetChildIndex(Me.lblLineaID, 0)
        Me.Controls.SetChildIndex(Me.cboMaquina, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboMaquina As System.Windows.Forms.ComboBox
    Private WithEvents butVerMaquinaID As System.Windows.Forms.Button
    Private WithEvents butAddMaquinaID As System.Windows.Forms.Button
    Private WithEvents cboLinea As System.Windows.Forms.ComboBox
    Private WithEvents lblMaquinaID As System.Windows.Forms.Label
    Private WithEvents lblLineaID As System.Windows.Forms.Label

End Class
