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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntCostesPorConcepto))
        Me.cboConceptosGastosIncidencias = New System.Windows.Forms.ComboBox()
        Me.butVerId_ConceptosGastosIncidencias = New System.Windows.Forms.Button()
        Me.butAddId_ConceptosGastosIncidencias = New System.Windows.Forms.Button()
        Me.txtCoste = New System.Windows.Forms.TextBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.lblId_ConceptosGastosIncidencias = New System.Windows.Forms.Label()
        Me.lblCoste = New System.Windows.Forms.Label()
        Me.lblFecha = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboConceptosGastosIncidencias
        '
        Me.cboConceptosGastosIncidencias.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboConceptosGastosIncidencias.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboConceptosGastosIncidencias.Location = New System.Drawing.Point(206, 18)
        Me.cboConceptosGastosIncidencias.Name = "cboConceptosGastosIncidencias"
        Me.cboConceptosGastosIncidencias.Size = New System.Drawing.Size(200, 23)
        Me.cboConceptosGastosIncidencias.TabIndex = 0
        '
        'butVerId_ConceptosGastosIncidencias
        '
        Me.butVerId_ConceptosGastosIncidencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerId_ConceptosGastosIncidencias.FlatAppearance.BorderSize = 0
        Me.butVerId_ConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_ConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_ConceptosGastosIncidencias.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerId_ConceptosGastosIncidencias.Location = New System.Drawing.Point(412, 18)
        Me.butVerId_ConceptosGastosIncidencias.Name = "butVerId_ConceptosGastosIncidencias"
        Me.butVerId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(20, 23)
        Me.butVerId_ConceptosGastosIncidencias.TabIndex = 1
        Me.butVerId_ConceptosGastosIncidencias.TabStop = False
        '
        'butAddId_ConceptosGastosIncidencias
        '
        Me.butAddId_ConceptosGastosIncidencias.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddId_ConceptosGastosIncidencias.FlatAppearance.BorderSize = 0
        Me.butAddId_ConceptosGastosIncidencias.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_ConceptosGastosIncidencias.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_ConceptosGastosIncidencias.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_ConceptosGastosIncidencias.Location = New System.Drawing.Point(438, 18)
        Me.butAddId_ConceptosGastosIncidencias.Name = "butAddId_ConceptosGastosIncidencias"
        Me.butAddId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(20, 23)
        Me.butAddId_ConceptosGastosIncidencias.TabIndex = 2
        Me.butAddId_ConceptosGastosIncidencias.TabStop = False
        '
        'txtCoste
        '
        Me.txtCoste.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCoste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtCoste.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCoste.Location = New System.Drawing.Point(206, 47)
        Me.txtCoste.Name = "txtCoste"
        Me.txtCoste.Size = New System.Drawing.Size(200, 21)
        Me.txtCoste.TabIndex = 1
        '
        'dtpFecha
        '
        Me.dtpFecha.BackColor = System.Drawing.SystemColors.Window
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(206, 74)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(95, 21)
        Me.dtpFecha.TabIndex = 2
        '
        'lblId_ConceptosGastosIncidencias
        '
        Me.lblId_ConceptosGastosIncidencias.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblId_ConceptosGastosIncidencias.Location = New System.Drawing.Point(23, 15)
        Me.lblId_ConceptosGastosIncidencias.Name = "lblId_ConceptosGastosIncidencias"
        Me.lblId_ConceptosGastosIncidencias.Size = New System.Drawing.Size(177, 29)
        Me.lblId_ConceptosGastosIncidencias.TabIndex = 0
        Me.lblId_ConceptosGastosIncidencias.Text = "Concepto"
        Me.lblId_ConceptosGastosIncidencias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCoste
        '
        Me.lblCoste.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblCoste.Location = New System.Drawing.Point(23, 44)
        Me.lblCoste.Name = "lblCoste"
        Me.lblCoste.Size = New System.Drawing.Size(177, 27)
        Me.lblCoste.TabIndex = 3
        Me.lblCoste.Text = "Coste"
        Me.lblCoste.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFecha
        '
        Me.lblFecha.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblFecha.Location = New System.Drawing.Point(23, 71)
        Me.lblFecha.Name = "lblFecha"
        Me.lblFecha.Size = New System.Drawing.Size(177, 27)
        Me.lblFecha.TabIndex = 4
        Me.lblFecha.Text = "Fecha"
        Me.lblFecha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.AutoSize = True
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46.0!))
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
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 4
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(507, 118)
        Me.tlpMiddle.TabIndex = 8
        '
        'frmEntCostesPorConcepto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(491, 155)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntCostesPorConcepto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "CostesPorConcepto"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.tlpMiddle.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

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
