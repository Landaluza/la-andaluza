<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntPaletsProducidos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntPaletsProducidos))
        Me.chbTerminado = New System.Windows.Forms.CheckBox()
        Me.chbMultilote = New System.Windows.Forms.CheckBox()
        Me.lblTerminado = New System.Windows.Forms.Label()
        Me.lblMultilote = New System.Windows.Forms.Label()

        Me.lblObs = New System.Windows.Forms.Label()
        Me.txtScc = New System.Windows.Forms.Label()
        Me.lblSSCC = New System.Windows.Forms.Label()
        Me.txtObservacionesPalets = New System.Windows.Forms.TextBox()
        Me.btnLimpiar = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chbalamcen = New System.Windows.Forms.CheckBox()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'chbTerminado
        '
        Me.chbTerminado.BackColor = System.Drawing.SystemColors.Control
        Me.chbTerminado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbTerminado.Location = New System.Drawing.Point(73, 82)
        Me.chbTerminado.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbTerminado.Name = "chbTerminado"
        Me.chbTerminado.Size = New System.Drawing.Size(20, 21)
        Me.chbTerminado.TabIndex = 3
        Me.chbTerminado.UseVisualStyleBackColor = False
        '
        'chbMultilote
        '
        Me.chbMultilote.BackColor = System.Drawing.SystemColors.Control
        Me.chbMultilote.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbMultilote.Location = New System.Drawing.Point(156, 83)
        Me.chbMultilote.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chbMultilote.Name = "chbMultilote"
        Me.chbMultilote.Size = New System.Drawing.Size(21, 20)
        Me.chbMultilote.TabIndex = 6
        Me.chbMultilote.UseVisualStyleBackColor = False
        '
        'lblTerminado
        '
        Me.lblTerminado.Location = New System.Drawing.Point(10, 80)
        Me.lblTerminado.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTerminado.Name = "lblTerminado"
        Me.lblTerminado.Size = New System.Drawing.Size(58, 26)
        Me.lblTerminado.TabIndex = 5
        Me.lblTerminado.Text = "Terminado"
        Me.lblTerminado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMultilote
        '
        Me.lblMultilote.Location = New System.Drawing.Point(104, 80)
        Me.lblMultilote.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblMultilote.Name = "lblMultilote"
        Me.lblMultilote.Size = New System.Drawing.Size(48, 25)
        Me.lblMultilote.TabIndex = 10
        Me.lblMultilote.Text = "Multilote"
        Me.lblMultilote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'lblObs
        '
        Me.lblObs.AutoSize = True
        Me.lblObs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblObs.Location = New System.Drawing.Point(261, 15)
        Me.lblObs.Name = "lblObs"
        Me.lblObs.Size = New System.Drawing.Size(88, 15)
        Me.lblObs.TabIndex = 1000000002
        Me.lblObs.Text = "Observaciones"
        Me.lblObs.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtScc
        '
        Me.txtScc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtScc.Font = New System.Drawing.Font("Microsoft Sans Serif", 30.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtScc.ForeColor = System.Drawing.Color.Blue
        Me.txtScc.Location = New System.Drawing.Point(12, 32)
        Me.txtScc.Name = "txtScc"
        Me.txtScc.Size = New System.Drawing.Size(232, 40)
        Me.txtScc.TabIndex = 1000000003
        '
        'lblSSCC
        '
        Me.lblSSCC.AutoSize = True
        Me.lblSSCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSSCC.Location = New System.Drawing.Point(12, 9)
        Me.lblSSCC.Name = "lblSSCC"
        Me.lblSSCC.Size = New System.Drawing.Size(60, 24)
        Me.lblSSCC.TabIndex = 1000000001
        Me.lblSSCC.Text = "SSCC"
        Me.lblSSCC.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'txtObservacionesPalets
        '
        Me.txtObservacionesPalets.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtObservacionesPalets.Location = New System.Drawing.Point(263, 33)
        Me.txtObservacionesPalets.Multiline = True
        Me.txtObservacionesPalets.Name = "txtObservacionesPalets"
        Me.txtObservacionesPalets.Size = New System.Drawing.Size(437, 69)
        Me.txtObservacionesPalets.TabIndex = 1000000004
        '
        'btnLimpiar
        '
        Me.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnLimpiar.FlatAppearance.BorderSize = 0
        Me.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLimpiar.Image = Global.La_Andaluza.My.Resources.Resources.edit_clear_2
        Me.btnLimpiar.Location = New System.Drawing.Point(347, 14)
        Me.btnLimpiar.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(22, 19)
        Me.btnLimpiar.TabIndex = 1000000005
        Me.btnLimpiar.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.chbalamcen)
        Me.Panel1.Controls.Add(Me.txtObservacionesPalets)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.chbTerminado)
        Me.Panel1.Controls.Add(Me.lblObs)
        Me.Panel1.Controls.Add(Me.lblTerminado)
        Me.Panel1.Controls.Add(Me.txtScc)
        Me.Panel1.Controls.Add(Me.lblMultilote)
        Me.Panel1.Controls.Add(Me.lblSSCC)
        Me.Panel1.Controls.Add(Me.chbMultilote)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 25)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(709, 107)
        Me.Panel1.TabIndex = 1000000006
        '
        'Panel2
        '
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(709, 329)
        Me.Panel2.TabIndex = 1000000007
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(187, 78)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 25)
        Me.Label1.TabIndex = 1000000007
        Me.Label1.Text = "Almacen"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chbalamcen
        '
        Me.chbalamcen.BackColor = System.Drawing.SystemColors.Control
        Me.chbalamcen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chbalamcen.Location = New System.Drawing.Point(239, 81)
        Me.chbalamcen.Margin = New System.Windows.Forms.Padding(2)
        Me.chbalamcen.Name = "chbalamcen"
        Me.chbalamcen.Size = New System.Drawing.Size(21, 20)
        Me.chbalamcen.TabIndex = 1000000006
        Me.chbalamcen.UseVisualStyleBackColor = False
        '
        'frmEntPaletsProducidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(709, 461)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(408, 262)
        Me.Name = "frmEntPaletsProducidos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = " "
        Me.Controls.SetChildIndex(Me.Panel1, 0)
        Me.Controls.SetChildIndex(Me.Panel2, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents chbTerminado As System.Windows.Forms.CheckBox
    Private WithEvents chbMultilote As System.Windows.Forms.CheckBox
    Private WithEvents lblTerminado As System.Windows.Forms.Label
    Private WithEvents lblMultilote As System.Windows.Forms.Label

    Private WithEvents lblObs As System.Windows.Forms.Label
    Private WithEvents txtScc As System.Windows.Forms.Label
    Private WithEvents lblSSCC As System.Windows.Forms.Label
    Private WithEvents txtObservacionesPalets As System.windows.Forms.TextBox
    Private WithEvents btnLimpiar As System.Windows.Forms.Button
    Private WithEvents Panel1 As System.Windows.Forms.Panel
    Private WithEvents Panel2 As System.Windows.Forms.Panel
    Private WithEvents Label1 As System.Windows.Forms.Label
    Private WithEvents chbalamcen As System.Windows.Forms.CheckBox
End Class
