<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposGravedadesIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposGravedadesIncidencias))
        Me.txtdescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtValores = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblValores = New System.Windows.Forms.Label()

        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.EsUnicoCampo = ""
        Me.txtdescripcion.EsUnicoCampoID = ""
        Me.txtdescripcion.EsUnicoID = 0
        Me.txtdescripcion.EsUnicoTabla = ""
        Me.txtdescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.Location = New System.Drawing.Point(130, 44)
        Me.txtdescripcion.MaxLength = 50
        Me.txtdescripcion.Minimo = 0
        Me.txtdescripcion.Modificado = False
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Numerico_EsNumerico = False
        Me.txtdescripcion.Numerico_NumeroDoublees = 0
        Me.txtdescripcion.Numerico_SeparadorMiles = False
        Me.txtdescripcion.Obligatorio = False
        Me.txtdescripcion.ParametroID = 0
        Me.txtdescripcion.Size = New System.Drawing.Size(200, 21)
        Me.txtdescripcion.TabIndex = 0
        Me.txtdescripcion.ValorMaximo = 0.0R
        Me.txtdescripcion.ValorMinimo = 0.0R
        '
        'txtValores
        '
        Me.txtValores.BackColor = System.Drawing.SystemColors.Window
        Me.txtValores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValores.EsUnicoCampo = ""
        Me.txtValores.EsUnicoCampoID = ""
        Me.txtValores.EsUnicoID = 0
        Me.txtValores.EsUnicoTabla = ""
        Me.txtValores.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValores.Location = New System.Drawing.Point(130, 74)
        Me.txtValores.MaxLength = 9
        Me.txtValores.Minimo = 0
        Me.txtValores.Modificado = False
        Me.txtValores.Name = "txtValores"
        Me.txtValores.Numerico_EsNumerico = False
        Me.txtValores.Numerico_NumeroDoublees = 0
        Me.txtValores.Numerico_SeparadorMiles = False
        Me.txtValores.Obligatorio = False
        Me.txtValores.ParametroID = 0
        Me.txtValores.Size = New System.Drawing.Size(200, 21)
        Me.txtValores.TabIndex = 1
        Me.txtValores.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValores.ValorMaximo = 0.0R
        Me.txtValores.ValorMinimo = 0.0R
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Location = New System.Drawing.Point(56, 41)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(69, 30)
        Me.lbldescripcion.TabIndex = 0
        Me.lbldescripcion.Text = "Descripción"
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValores
        '
        Me.lblValores.Location = New System.Drawing.Point(56, 71)
        Me.lblValores.Name = "lblValores"
        Me.lblValores.Size = New System.Drawing.Size(69, 30)
        Me.lblValores.TabIndex = 1
        Me.lblValores.Text = "Valor"
        Me.lblValores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntTiposGravedadesIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(393, 128)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.lblValores)
        Me.Controls.Add(Me.txtValores)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(402, 135)
        Me.Name = "frmEntTiposGravedadesIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposGravedadesIncidencias"
        Me.Controls.SetChildIndex(Me.txtValores, 0)
        Me.Controls.SetChildIndex(Me.lblValores, 0)
        Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
        Me.Controls.SetChildIndex(Me.lbldescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtdescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtValores As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lbldescripcion As System.Windows.Forms.Label
    Private WithEvents lblValores As System.Windows.Forms.Label
End Class
