<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepEtiquetas
    Inherits System.Windows.Forms.Form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PanContenidos = New System.Windows.Forms.Panel()
        Me.cboEtiquetaTipo = New System.Windows.Forms.ComboBox()
        Me.lblGranelTipoID = New System.Windows.Forms.Label()
        Me.PanContenidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanContenidos
        '
        Me.PanContenidos.AutoSize = True
        Me.PanContenidos.Controls.Add(Me.cboEtiquetaTipo)
        Me.PanContenidos.Controls.Add(Me.lblGranelTipoID)
        Me.PanContenidos.Location = New System.Drawing.Point(46, 69)
        Me.PanContenidos.Name = "PanContenidos"
        Me.PanContenidos.Size = New System.Drawing.Size(497, 62)
        Me.PanContenidos.TabIndex = 2
        '
        'cboEtiquetaTipo
        '
        Me.cboEtiquetaTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboEtiquetaTipo.Location = New System.Drawing.Point(188, 15)
        Me.cboEtiquetaTipo.Name = "cboEtiquetaTipo"
        Me.cboEtiquetaTipo.Size = New System.Drawing.Size(250, 23)
        Me.cboEtiquetaTipo.TabIndex = 1
        '
        'lblGranelTipoID
        '
        Me.lblGranelTipoID.Location = New System.Drawing.Point(61, 11)
        Me.lblGranelTipoID.Name = "lblGranelTipoID"
        Me.lblGranelTipoID.Size = New System.Drawing.Size(121, 31)
        Me.lblGranelTipoID.TabIndex = 0
        Me.lblGranelTipoID.Text = "Tipo de etiqueta"
        Me.lblGranelTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmWstepEtiquetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(615, 382)
        Me.Controls.Add(Me.PanContenidos)
        Me.Name = "frmWstepEtiquetas"
        Me.Text = "frmWstepEtiquetas"
        Me.PanContenidos.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
   Private WithEvents PanContenidos As System.Windows.Forms.Panel
   Private WithEvents cboEtiquetaTipo As System.Windows.Forms.ComboBox
   Private WithEvents lblGranelTipoID As System.Windows.Forms.Label
End Class
