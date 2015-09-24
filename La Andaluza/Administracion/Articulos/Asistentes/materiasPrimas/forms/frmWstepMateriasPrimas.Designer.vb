<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWstepMateriasPrimas
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
        Me.gbCertificados = New System.Windows.Forms.GroupBox()
        Me.cboMateriaPrimaTipoID = New System.Windows.Forms.ComboBox()
        Me.lblGranelTipoID = New System.Windows.Forms.Label()
        Me.PanContenidos.SuspendLayout()
        Me.SuspendLayout()
        '
        'PanContenidos
        '
        Me.PanContenidos.AutoSize = True
        Me.PanContenidos.Controls.Add(Me.gbCertificados)
        Me.PanContenidos.Controls.Add(Me.cboMateriaPrimaTipoID)
        Me.PanContenidos.Controls.Add(Me.lblGranelTipoID)
        Me.PanContenidos.Location = New System.Drawing.Point(12, 43)
        Me.PanContenidos.Name = "PanContenidos"
        Me.PanContenidos.Size = New System.Drawing.Size(407, 255)
        Me.PanContenidos.TabIndex = 1
        '
        'gbCertificados
        '
        Me.gbCertificados.AutoSize = True
        Me.gbCertificados.BackColor = System.Drawing.SystemColors.Control
        Me.gbCertificados.Location = New System.Drawing.Point(3, 76)
        Me.gbCertificados.Name = "gbCertificados"
        Me.gbCertificados.Size = New System.Drawing.Size(374, 139)
        Me.gbCertificados.TabIndex = 2
        Me.gbCertificados.TabStop = False
        Me.gbCertificados.Text = "Certificados requeridos"
        '
        'cboMateriaPrimaTipoID
        '
        Me.cboMateriaPrimaTipoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMateriaPrimaTipoID.Location = New System.Drawing.Point(127, 13)
        Me.cboMateriaPrimaTipoID.Name = "cboMateriaPrimaTipoID"
        Me.cboMateriaPrimaTipoID.Size = New System.Drawing.Size(250, 23)
        Me.cboMateriaPrimaTipoID.TabIndex = 1
        '
        'lblGranelTipoID
        '
        Me.lblGranelTipoID.Location = New System.Drawing.Point(0, 9)
        Me.lblGranelTipoID.Name = "lblGranelTipoID"
        Me.lblGranelTipoID.Size = New System.Drawing.Size(121, 31)
        Me.lblGranelTipoID.TabIndex = 0
        Me.lblGranelTipoID.Text = "Tipo de materia prima"
        Me.lblGranelTipoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frmWstepMateriasPrimas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(439, 334)
        Me.Controls.Add(Me.PanContenidos)
        Me.Name = "frmWstepMateriasPrimas"
        Me.Text = "frmWstepMateriasPrimas"
        Me.PanContenidos.ResumeLayout(False)
        Me.PanContenidos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents PanContenidos As System.Windows.Forms.Panel
   Private WithEvents gbCertificados As System.Windows.Forms.GroupBox
   Private WithEvents cboMateriaPrimaTipoID As System.Windows.Forms.ComboBox
   Private WithEvents lblGranelTipoID As System.Windows.Forms.Label
End Class
