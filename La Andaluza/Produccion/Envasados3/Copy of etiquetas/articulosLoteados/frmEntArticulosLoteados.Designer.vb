<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntArticulosLoteados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntArticulosLoteados))
        Me.cboid_tipoLoteado = New System.Windows.Forms.ComboBox()
        Me.butVerid_tipoLoteado = New System.Windows.Forms.Button()
        Me.butAddid_tipoLoteado = New System.Windows.Forms.Button()
        Me.lblid_tipoLoteado = New System.Windows.Forms.Label()
        Me.tlpMiddle = New System.Windows.Forms.TableLayoutPanel()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tlpMiddle.SuspendLayout()
        Me.SuspendLayout()
        '
        'cboid_tipoLoteado
        '
        Me.cboid_tipoLoteado.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboid_tipoLoteado.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboid_tipoLoteado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.cboid_tipoLoteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboid_tipoLoteado.Location = New System.Drawing.Point(169, 18)
        Me.cboid_tipoLoteado.Name = "cboid_tipoLoteado"
        Me.cboid_tipoLoteado.Size = New System.Drawing.Size(200, 23)
        Me.cboid_tipoLoteado.TabIndex = 1
        '
        'butVerid_tipoLoteado
        '
        Me.butVerid_tipoLoteado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerid_tipoLoteado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butVerid_tipoLoteado.FlatAppearance.BorderSize = 0
        Me.butVerid_tipoLoteado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerid_tipoLoteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerid_tipoLoteado.Image = Global.La_Andaluza.My.Resources.Resources.agenda
        Me.butVerid_tipoLoteado.Location = New System.Drawing.Point(375, 18)
        Me.butVerid_tipoLoteado.Name = "butVerid_tipoLoteado"
        Me.butVerid_tipoLoteado.Size = New System.Drawing.Size(20, 23)
        Me.butVerid_tipoLoteado.TabIndex = 4
        Me.butVerid_tipoLoteado.TabStop = False
        '
        'butAddid_tipoLoteado
        '
        Me.butAddid_tipoLoteado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddid_tipoLoteado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.butAddid_tipoLoteado.FlatAppearance.BorderSize = 0
        Me.butAddid_tipoLoteado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddid_tipoLoteado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddid_tipoLoteado.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddid_tipoLoteado.Location = New System.Drawing.Point(401, 18)
        Me.butAddid_tipoLoteado.Name = "butAddid_tipoLoteado"
        Me.butAddid_tipoLoteado.Size = New System.Drawing.Size(20, 23)
        Me.butAddid_tipoLoteado.TabIndex = 5
        Me.butAddid_tipoLoteado.TabStop = False
        '
        'lblid_tipoLoteado
        '
        Me.lblid_tipoLoteado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblid_tipoLoteado.Location = New System.Drawing.Point(21, 15)
        Me.lblid_tipoLoteado.Name = "lblid_tipoLoteado"
        Me.lblid_tipoLoteado.Size = New System.Drawing.Size(142, 29)
        Me.lblid_tipoLoteado.TabIndex = 3
        Me.lblid_tipoLoteado.Text = "Loteado"
        Me.lblid_tipoLoteado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpMiddle
        '
        Me.tlpMiddle.ColumnCount = 8
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 18.0!))
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.tlpMiddle.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 48.0!))
        Me.tlpMiddle.Controls.Add(Me.lblid_tipoLoteado, 1, 1)
        Me.tlpMiddle.Controls.Add(Me.cboid_tipoLoteado, 2, 1)
        Me.tlpMiddle.Controls.Add(Me.butVerid_tipoLoteado, 3, 1)
        Me.tlpMiddle.Controls.Add(Me.butAddid_tipoLoteado, 4, 1)
        Me.tlpMiddle.Location = New System.Drawing.Point(0, 25)
        Me.tlpMiddle.Name = "tlpMiddle"
        Me.tlpMiddle.Padding = New System.Windows.Forms.Padding(0, 15, 0, 0)
        Me.tlpMiddle.RowCount = 3
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.tlpMiddle.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.tlpMiddle.Size = New System.Drawing.Size(472, 60)
        Me.tlpMiddle.TabIndex = 8
        '
        'tlpTop
        '




        '
        'frmEntArticulosLoteados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(472, 119)
        Me.Controls.Add(Me.tlpMiddle)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntArticulosLoteados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ArticulosLoteados"
        Me.Controls.SetChildIndex(Me.tlpMiddle, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tlpMiddle.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboid_tipoLoteado As System.Windows.Forms.ComboBox
    Private WithEvents butVerid_tipoLoteado As System.Windows.Forms.Button
    Private WithEvents butAddid_tipoLoteado As System.Windows.Forms.Button
    Private WithEvents lblid_tipoLoteado As System.Windows.Forms.Label
    Private WithEvents tlpMiddle As System.Windows.Forms.TableLayoutPanel

End Class
