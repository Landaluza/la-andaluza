<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad))
        Me.cboIncidencia = New System.Windows.Forms.ComboBox()
        Me.butVerId_Incidencia = New System.Windows.Forms.Button()
        Me.butAddId_Incidencia = New System.Windows.Forms.Button()
        Me.lblId_Incidencia = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboIncidencia
        '
        Me.cboIncidencia.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboIncidencia.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboIncidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboIncidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboIncidencia.Location = New System.Drawing.Point(87, 50)
        Me.cboIncidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboIncidencia.Name = "cboIncidencia"
        Me.cboIncidencia.Size = New System.Drawing.Size(315, 23)
        Me.cboIncidencia.TabIndex = 0
        '
        'butVerId_Incidencia
        '
        Me.butVerId_Incidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerId_Incidencia.FlatAppearance.BorderSize = 0
        Me.butVerId_Incidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerId_Incidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerId_Incidencia.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerId_Incidencia.Location = New System.Drawing.Point(406, 50)
        Me.butVerId_Incidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerId_Incidencia.Name = "butVerId_Incidencia"
        Me.butVerId_Incidencia.Size = New System.Drawing.Size(18, 21)
        Me.butVerId_Incidencia.TabIndex = 1
        Me.butVerId_Incidencia.TabStop = False
        '
        'butAddId_Incidencia
        '
        Me.butAddId_Incidencia.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddId_Incidencia.FlatAppearance.BorderSize = 0
        Me.butAddId_Incidencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddId_Incidencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddId_Incidencia.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddId_Incidencia.Location = New System.Drawing.Point(428, 50)
        Me.butAddId_Incidencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddId_Incidencia.Name = "butAddId_Incidencia"
        Me.butAddId_Incidencia.Size = New System.Drawing.Size(18, 21)
        Me.butAddId_Incidencia.TabIndex = 2
        Me.butAddId_Incidencia.TabStop = False
        '
        'lblId_Incidencia
        '
        Me.lblId_Incidencia.Location = New System.Drawing.Point(20, 46)
        Me.lblId_Incidencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblId_Incidencia.Name = "lblId_Incidencia"
        Me.lblId_Incidencia.Size = New System.Drawing.Size(62, 30)
        Me.lblId_Incidencia.TabIndex = 0
        Me.lblId_Incidencia.Text = "Incidencia"
        Me.lblId_Incidencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(490, 108)
        Me.Controls.Add(Me.lblId_Incidencia)
        Me.Controls.Add(Me.cboIncidencia)
        Me.Controls.Add(Me.butVerId_Incidencia)
        Me.Controls.Add(Me.butAddId_Incidencia)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad"
        Me.Controls.SetChildIndex(Me.butAddId_Incidencia, 0)
        Me.Controls.SetChildIndex(Me.butVerId_Incidencia, 0)
        Me.Controls.SetChildIndex(Me.cboIncidencia, 0)
        Me.Controls.SetChildIndex(Me.lblId_Incidencia, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents cboIncidencia As System.Windows.Forms.ComboBox
    Private WithEvents butVerId_Incidencia As System.Windows.Forms.Button
    Private WithEvents butAddId_Incidencia As System.Windows.Forms.Button
    Private WithEvents lblId_Incidencia As System.Windows.Forms.Label

End Class
