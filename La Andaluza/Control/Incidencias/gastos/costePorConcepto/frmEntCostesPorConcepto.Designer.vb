<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntCostesPorConcepto
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
        Me.cboConceptosGastosIncidencias = New System.Windows.Forms.ComboBox()
        Me.butVerId_ConceptosGastosIncidencias = New System.Windows.Forms.Button()
        Me.butAddId_ConceptosGastosIncidencias = New System.Windows.Forms.Button()
        Me.txtCoste = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblId_ConceptosGastosIncidencias = New System.Windows.Forms.Label
        Me.lblCoste = New System.Windows.Forms.Label
        Me.lblFecha = New System.Windows.Forms.Label
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel
        Me.tlpMiddle.SuspendLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboConceptosGastosIncidencias
        '
        Me.cboConceptosGastosIncidencias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboConceptosGastosIncidencias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConceptosGastosIncidencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown
        Me.cboConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptosGastosIncidencias.Name = "cboConceptosGastosIncidencias
        Me.cboConceptosGastosIncidencias.TabIndex = 0
        Me.cboConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboConceptosGastosIncidencias.Size = New System.Drawing.Size(200,21)
        '
        'butVerId_ConceptosGastosIncidencias
        '
        Me.butVerId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_ConceptosGastosIncidencias.FlatAppearance.BorderSize = 0
        Me.butVerId_ConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_ConceptosGastosIncidencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_ConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_ConceptosGastosIncidencias.Name = "butVerId_ConceptosGastosIncidencias
        Me.butVerId_ConceptosGastosIncidencias.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_ConceptosGastosIncidencias.TabStop = False
        Me.butVerId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(20, 20)
        'butAddId_ConceptosGastosIncidencias
        '
        Me.butAddId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_ConceptosGastosIncidencias.FlatAppearance.BorderSize = 0
        Me.butAddId_ConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_ConceptosGastosIncidencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_ConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_ConceptosGastosIncidencias.Image = Global.La_Andaluza.My.Resources.edit_add_2
        Me.butAddId_ConceptosGastosIncidencias.Name = "butAddId_ConceptosGastosIncidencias
        Me.butAddId_ConceptosGastosIncidencias.TabStop = False
        Me.butAddId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(20, 20)
        '
        '
        'txtCoste
        '
        Me.txtCoste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoste.Name = "txtCoste
        Me.txtCoste.TabIndex = 1
        Me.txtCoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        'dtpFecha
        '
        Me.dtpFecha.Dock = System.Windows.Forms.DockStyle.None
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Name = "dtpFecha
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Size = New System.Drawing.Size(95,21)
        '
        'lblId_ConceptosGastosIncidencias
        '
        Me.lblId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_ConceptosGastosIncidencias.Name = "lblId_ConceptosGastosIncidencias
        Me.lblId_ConceptosGastosIncidencias.Text = "Conceptosgastosincencias
        Me.lblId_ConceptosGastosIncidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(177,21)
        Me.lblId_ConceptosGastosIncidencias.Location = New System.Drawing.Point(20,40)
        '
        'lblCoste
        '
        Me.lblCoste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCoste.Name = "lblCoste
        Me.lblCoste.Text = "Coste
        Me.lblCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblCoste.Size = New System.Drawing.Size(177,21)
        Me.lblCoste.Location = New System.Drawing.Point(20,40)
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Name = "lblFecha
        Me.lblFecha.Text = "Fecha
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lblFecha.Size = New System.Drawing.Size(177,21)
        Me.lblFecha.Location = New System.Drawing.Point(20,40)
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Controls.Add(Me.lblId_ConceptosGastosIncidencias, 1, 0)
        Me.tlpMiddle.Controls.Add(Me.cboConceptosGastosIncidencias, 2, 0)
        Me.tlpMiddle.Controls.Add(Me.butVerId_ConceptosGastosIncidencias, 3, 0)
        Me.tlpMiddle.Controls.Add(Me.butAddId_ConceptosGastosIncidencias, 4, 0)
        Me.tlpMiddle.Controls.Add(Me.lblCoste, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.txtCoste, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.lblFecha, 1, 2)
        Me.tlpMiddle.Controls.Add(Me.dtpFecha, 2, 2)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle)
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(507, 56)
        '
        '
        'frmEntCostesPorConcepto
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.Controls.Add(Me.tlpMiddle)
        Me.ClientSize = New System.Drawing.Size(507, 136)
        Me.MinimumSize = New System.Drawing.Size(507, 136)
        Me.Name = "frmEntCostesPorConcepto
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CostesPorConcepto"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.Dock = System.Windows.Forms.DockStyle.None
        Me.tlpMiddle.Autosize = True
        Me.Size = new Size(507,392)
        Me.tlpMiddle.PerformLayout()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

       End Sub

    Private WithEvents cboConceptosGastosIncidencias As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_ConceptosGastosIncidencias As System.Windows.Forms.Button
    Private WithEvents butAddId_ConceptosGastosIncidencias As System.Windows.Forms.Button
    Private WithEvents txtCoste As System.Windows.Forms.TextBox
    Private WithEvents dtpFecha As System.Windows.Forms.DateTimePicker
    Private WithEvents lblId_ConceptosGastosIncidencias As System.Windows.Forms.Label
    Private WithEvents lblCoste As System.Windows.Forms.Label
    Private WithEvents lblFecha As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel
End Class
