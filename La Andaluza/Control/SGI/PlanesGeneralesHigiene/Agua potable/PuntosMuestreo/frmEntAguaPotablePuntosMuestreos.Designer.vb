<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntAguaPotablePuntosMuestreos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntAguaPotablePuntosMuestreos))
        Me.cboResponsable = New System.Windows.Forms.ComboBox()
        Me.butVerResponsableID = New System.Windows.Forms.Button()
        Me.butAddResponsableID = New System.Windows.Forms.Button()
        Me.txtReferencia = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtObservaciones = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblResponsableID = New System.Windows.Forms.Label()
        Me.lblReferencia = New System.Windows.Forms.Label()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblObservaciones = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cboResponsable
        '
        Me.cboResponsable.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cboResponsable.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cboResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cboResponsable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboResponsable.Location = New System.Drawing.Point(118, 47)
        Me.cboResponsable.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cboResponsable.Name = "cboResponsable"
        Me.cboResponsable.Size = New System.Drawing.Size(325, 23)
        Me.cboResponsable.TabIndex = 0
        '
        'butVerResponsableID
        '
        Me.butVerResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butVerResponsableID.FlatAppearance.BorderSize = 0
        Me.butVerResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butVerResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butVerResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.view_16
        Me.butVerResponsableID.Location = New System.Drawing.Point(447, 48)
        Me.butVerResponsableID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butVerResponsableID.Name = "butVerResponsableID"
        Me.butVerResponsableID.Size = New System.Drawing.Size(18, 19)
        Me.butVerResponsableID.TabIndex = 1
        Me.butVerResponsableID.TabStop = False
        '
        'butAddResponsableID
        '
        Me.butAddResponsableID.Cursor = System.Windows.Forms.Cursors.Hand
        Me.butAddResponsableID.FlatAppearance.BorderSize = 0
        Me.butAddResponsableID.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.butAddResponsableID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.butAddResponsableID.Image = Global.La_Andaluza.My.Resources.Resources.edit_add_2
        Me.butAddResponsableID.Location = New System.Drawing.Point(470, 48)
        Me.butAddResponsableID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.butAddResponsableID.Name = "butAddResponsableID"
        Me.butAddResponsableID.Size = New System.Drawing.Size(18, 19)
        Me.butAddResponsableID.TabIndex = 2
        Me.butAddResponsableID.TabStop = False
        '
        'txtReferencia
        '
        Me.txtReferencia.BackColor = System.Drawing.SystemColors.Window
        Me.txtReferencia.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtReferencia.EsUnicoCampo = ""
        Me.txtReferencia.EsUnicoCampoID = ""
        Me.txtReferencia.EsUnicoID = 0
        Me.txtReferencia.EsUnicoTabla = ""
        Me.txtReferencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReferencia.Location = New System.Drawing.Point(118, 78)
        Me.txtReferencia.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtReferencia.MaxLength = 4000
        Me.txtReferencia.Minimo = 0
        Me.txtReferencia.Modificado = False
        Me.txtReferencia.Name = "txtReferencia"
        Me.txtReferencia.Numerico_EsNumerico = False
        Me.txtReferencia.Numerico_NumeroDoublees = 0
        Me.txtReferencia.Numerico_SeparadorMiles = False
        Me.txtReferencia.Obligatorio = False
        Me.txtReferencia.ParametroID = 0
        Me.txtReferencia.Size = New System.Drawing.Size(325, 14)
        Me.txtReferencia.TabIndex = 1
        Me.txtReferencia.ValorMaximo = 0.0R
        Me.txtReferencia.ValorMinimo = 0.0R
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(118, 106)
        Me.txtDescripcion.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(325, 14)
        Me.txtDescripcion.TabIndex = 2
        Me.txtDescripcion.ValorMaximo = 0.0R
        Me.txtDescripcion.ValorMinimo = 0.0R
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
        Me.txtObservaciones.Location = New System.Drawing.Point(118, 133)
        Me.txtObservaciones.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtObservaciones.MaxLength = 500
        Me.txtObservaciones.Minimo = 0
        Me.txtObservaciones.Modificado = False
        Me.txtObservaciones.Multiline = True
        Me.txtObservaciones.Name = "txtObservaciones"
        Me.txtObservaciones.Numerico_EsNumerico = False
        Me.txtObservaciones.Numerico_NumeroDoublees = 0
        Me.txtObservaciones.Numerico_SeparadorMiles = False
        Me.txtObservaciones.Obligatorio = False
        Me.txtObservaciones.ParametroID = 0
        Me.txtObservaciones.Size = New System.Drawing.Size(325, 41)
        Me.txtObservaciones.TabIndex = 3
        Me.txtObservaciones.ValorMaximo = 0.0R
        Me.txtObservaciones.ValorMinimo = 0.0R
        '
        'lblResponsableID
        '
        Me.lblResponsableID.Location = New System.Drawing.Point(28, 45)
        Me.lblResponsableID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblResponsableID.Name = "lblResponsableID"
        Me.lblResponsableID.Size = New System.Drawing.Size(86, 30)
        Me.lblResponsableID.TabIndex = 0
        Me.lblResponsableID.Text = "Responsable"
        Me.lblResponsableID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblReferencia
        '
        Me.lblReferencia.Location = New System.Drawing.Point(28, 75)
        Me.lblReferencia.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblReferencia.Name = "lblReferencia"
        Me.lblReferencia.Size = New System.Drawing.Size(86, 28)
        Me.lblReferencia.TabIndex = 3
        Me.lblReferencia.Text = "Referencia"
        Me.lblReferencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(28, 103)
        Me.lblDescripcion.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(86, 28)
        Me.lblDescripcion.TabIndex = 4
        Me.lblDescripcion.Text = "Descripcion"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObservaciones
        '
        Me.lblObservaciones.Location = New System.Drawing.Point(28, 131)
        Me.lblObservaciones.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblObservaciones.Name = "lblObservaciones"
        Me.lblObservaciones.Size = New System.Drawing.Size(86, 28)
        Me.lblObservaciones.TabIndex = 5
        Me.lblObservaciones.Text = "Observaciones"
        Me.lblObservaciones.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntAguaPotablePuntosMuestreos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(513, 193)
        Me.Controls.Add(Me.txtReferencia)
        Me.Controls.Add(Me.lblResponsableID)
        Me.Controls.Add(Me.cboResponsable)
        Me.Controls.Add(Me.butVerResponsableID)
        Me.Controls.Add(Me.butAddResponsableID)
        Me.Controls.Add(Me.txtObservaciones)
        Me.Controls.Add(Me.lblReferencia)
        Me.Controls.Add(Me.lblObservaciones)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(413, 184)
        Me.Name = "frmEntAguaPotablePuntosMuestreos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "AguaPotablePuntosMuestreos"
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblObservaciones, 0)
        Me.Controls.SetChildIndex(Me.lblReferencia, 0)
        Me.Controls.SetChildIndex(Me.txtObservaciones, 0)
        Me.Controls.SetChildIndex(Me.butAddResponsableID, 0)
        Me.Controls.SetChildIndex(Me.butVerResponsableID, 0)
        Me.Controls.SetChildIndex(Me.cboResponsable, 0)
        Me.Controls.SetChildIndex(Me.lblResponsableID, 0)
        Me.Controls.SetChildIndex(Me.txtReferencia, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

   Private WithEvents cboResponsable As System.Windows.Forms.ComboBox
   Private WithEvents butVerResponsableID As System.Windows.Forms.Button
   Private WithEvents butAddResponsableID As System.Windows.Forms.Button
    Private WithEvents txtReferencia As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtObservaciones As BasesParaCompatibilidad.CuadroDeTexto
   Private WithEvents lblResponsableID As System.Windows.Forms.Label
   Private WithEvents lblReferencia As System.Windows.Forms.Label
   Private WithEvents lblDescripcion As System.Windows.Forms.Label
   Private WithEvents lblObservaciones As System.Windows.Forms.Label

End Class
