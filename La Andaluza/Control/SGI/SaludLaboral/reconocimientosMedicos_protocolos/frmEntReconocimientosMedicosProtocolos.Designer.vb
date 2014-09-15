<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntReconocimientosMedicosProtocolos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntReconocimientosMedicosProtocolos))
        Me.cboReconocimientoMedico = New System.Windows.Forms.ComboBox()
        Me.butVerReconocimientoMedicoID = New System.Windows.Forms.Button()
        Me.butAddReconocimientoMedicoID = New System.Windows.Forms.Button()
        Me.cboProtocoloMedico = New System.Windows.Forms.ComboBox()
        Me.butVerProtocoloMedicoID = New System.Windows.Forms.Button()
        Me.butAddProtocoloMedicoID = New System.Windows.Forms.Button()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblReconocimientoMedicoID = New System.Windows.Forms.Label()
        Me.lblProtocoloMedicoID = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboReconocimientoMedico
        '
        Me.cboReconocimientoMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboReconocimientoMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboReconocimientoMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboReconocimientoMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboReconocimientoMedico.Location = New System.Drawing.Point(148, 40)
        Me.cboReconocimientoMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboReconocimientoMedico.Name = "cboReconocimientoMedico"
        Me.cboReconocimientoMedico.Size = New System.Drawing.Size(400, 23)
        Me.cboReconocimientoMedico.TabIndex = 0
        '
        'butVerReconocimientoMedicoID
        '
        Me.butVerReconocimientoMedicoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerReconocimientoMedicoID.FlatAppearance.BorderSize = 0
        Me.butVerReconocimientoMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerReconocimientoMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerReconocimientoMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerReconocimientoMedicoID.Location = New System.Drawing.Point(552, 40)
        Me.butVerReconocimientoMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerReconocimientoMedicoID.Name = "butVerReconocimientoMedicoID"
        Me.butVerReconocimientoMedicoID.Size = New System.Drawing.Size(18, 22)
        Me.butVerReconocimientoMedicoID.TabIndex = 1
        Me.butVerReconocimientoMedicoID.TabStop = False
        '
        'butAddReconocimientoMedicoID
        '
        Me.butAddReconocimientoMedicoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddReconocimientoMedicoID.FlatAppearance.BorderSize = 0
        Me.butAddReconocimientoMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddReconocimientoMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddReconocimientoMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddReconocimientoMedicoID.Location = New System.Drawing.Point(574, 40)
        Me.butAddReconocimientoMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddReconocimientoMedicoID.Name = "butAddReconocimientoMedicoID"
        Me.butAddReconocimientoMedicoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddReconocimientoMedicoID.TabIndex = 2
        Me.butAddReconocimientoMedicoID.TabStop = False
        '
        'cboProtocoloMedico
        '
        Me.cboProtocoloMedico.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboProtocoloMedico.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboProtocoloMedico.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboProtocoloMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboProtocoloMedico.Location = New System.Drawing.Point(148, 70)
        Me.cboProtocoloMedico.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboProtocoloMedico.Name = "cboProtocoloMedico"
        Me.cboProtocoloMedico.Size = New System.Drawing.Size(400, 23)
        Me.cboProtocoloMedico.TabIndex = 1
        '
        'butVerProtocoloMedicoID
        '
        Me.butVerProtocoloMedicoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerProtocoloMedicoID.FlatAppearance.BorderSize = 0
        Me.butVerProtocoloMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerProtocoloMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerProtocoloMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerProtocoloMedicoID.Location = New System.Drawing.Point(552, 69)
        Me.butVerProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerProtocoloMedicoID.Name = "butVerProtocoloMedicoID"
        Me.butVerProtocoloMedicoID.Size = New System.Drawing.Size(18, 21)
        Me.butVerProtocoloMedicoID.TabIndex = 4
        Me.butVerProtocoloMedicoID.TabStop = False
        '
        'butAddProtocoloMedicoID
        '
        Me.butAddProtocoloMedicoID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddProtocoloMedicoID.FlatAppearance.BorderSize = 0
        Me.butAddProtocoloMedicoID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddProtocoloMedicoID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddProtocoloMedicoID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddProtocoloMedicoID.Location = New System.Drawing.Point(574, 70)
        Me.butAddProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddProtocoloMedicoID.Name = "butAddProtocoloMedicoID"
        Me.butAddProtocoloMedicoID.Size = New System.Drawing.Size(18, 21)
        Me.butAddProtocoloMedicoID.TabIndex = 5
        Me.butAddProtocoloMedicoID.TabStop = False
        '
        'txtObservaciones
        '
        Me.txtObservaciones.BackColor = System.Drawing.SystemColors.Window
        Me.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtObservaciones.EsUnicoCampo = ""
        Me.txtObservaciones.EsUnicoCampoID = ""
        Me.txtObservaciones.EsUnicoID = 0
        Me.txtObservaciones.EsUnicoTabla = ""
        Me.txtObservaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtObservaciones.Location = New System.Drawing.Point(148, 100)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 4000
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(400, 58)
        Me.txtObservaciones.TabIndex = 2
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblReconocimientoMedicoID
        '
        Me.lblReconocimientoMedicoID.Location = New System.Drawing.Point(43, 37)
        Me.lblReconocimientoMedicoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReconocimientoMedicoID.Name = "lblReconocimientoMedicoID"
        Me.lblReconocimientoMedicoID.Size = New System.Drawing.Size(101, 30)
        Me.lblReconocimientoMedicoID.TabIndex = 0
        Me.lblReconocimientoMedicoID.Text = "Reconocimiento"
        Me.lblReconocimientoMedicoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblProtocoloMedicoID
        '
        Me.lblProtocoloMedicoID.Location = New System.Drawing.Point(43, 67)
        Me.lblProtocoloMedicoID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblProtocoloMedicoID.Name = "lblProtocoloMedicoID"
        Me.lblProtocoloMedicoID.Size = New System.Drawing.Size(101, 30)
        Me.lblProtocoloMedicoID.TabIndex = 3
        Me.lblProtocoloMedicoID.Text = "Protocolo"
        Me.lblProtocoloMedicoID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(43, 98)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(101, 28)
        Me.lblObservaciones.TabIndex = 6
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntReconocimientosMedicosProtocolos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(698, 190)
        Me.Controls.Add(Me.lblReconocimientoMedicoID)
        Me.Controls.Add(Me.cboReconocimientoMedico)
        Me.Controls.Add(Me.butVerReconocimientoMedicoID)
        Me.Controls.Add(Me.butAddReconocimientoMedicoID)
        Me.Controls.Add(Me.lblProtocoloMedicoID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.cboProtocoloMedico)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.butVerProtocoloMedicoID)
        Me.Controls.Add(Me.butAddProtocoloMedicoID)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntReconocimientosMedicosProtocolos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "ReconocimientosMedicosProtocolos"
        Me.Controls.SetChildIndex(Me.butAddProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.butVerProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.cboProtocoloMedico, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblProtocoloMedicoID, 0)
        Me.Controls.SetChildIndex(Me.butAddReconocimientoMedicoID, 0)
        Me.Controls.SetChildIndex(Me.butVerReconocimientoMedicoID, 0)
        Me.Controls.SetChildIndex(Me.cboReconocimientoMedico, 0)
        Me.Controls.SetChildIndex(Me.lblReconocimientoMedicoID, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboReconocimientoMedico As System.Windows.Forms.ComboBox
   Private WithEvents butVerReconocimientoMedicoID As System.Windows.Forms.Button
   Private WithEvents butAddReconocimientoMedicoID As System.Windows.Forms.Button
   Private WithEvents cboProtocoloMedico As System.Windows.Forms.ComboBox
   Private WithEvents butVerProtocoloMedicoID As System.Windows.Forms.Button
   Private WithEvents butAddProtocoloMedicoID As System.Windows.Forms.Button
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblReconocimientoMedicoID As System.Windows.Forms.Label
   Private WithEvents lblProtocoloMedicoID As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label

End Class
