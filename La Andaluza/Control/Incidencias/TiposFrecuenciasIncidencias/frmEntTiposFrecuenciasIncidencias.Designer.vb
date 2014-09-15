<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposFrecuenciasIncidencias
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmEntTiposFrecuenciasIncidencias))
        Me.txtdescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtValor = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lbldescripcion = New System.Windows.Forms.Label()
        Me.lblValor = New System.Windows.Forms.Label()

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
        Me.txtdescripcion.Location = New System.Drawing.Point(130, 46)
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
        'txtValor
        '
        Me.txtValor.BackColor = System.Drawing.SystemColors.Window
        Me.txtValor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtValor.EsUnicoCampo = ""
        Me.txtValor.EsUnicoCampoID = ""
        Me.txtValor.EsUnicoID = 0
        Me.txtValor.EsUnicoTabla = ""
        Me.txtValor.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValor.Location = New System.Drawing.Point(130, 76)
        Me.txtValor.MaxLength = 9
        Me.txtValor.Minimo = 0
        Me.txtValor.Modificado = False
        Me.txtValor.Name = "txtValor"
        Me.txtValor.Numerico_EsNumerico = False
        Me.txtValor.Numerico_NumeroDoublees = 0
        Me.txtValor.Numerico_SeparadorMiles = False
        Me.txtValor.Obligatorio = False
        Me.txtValor.ParametroID = 0
        Me.txtValor.Size = New System.Drawing.Size(200, 21)
        Me.txtValor.TabIndex = 1
        Me.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtValor.ValorMaximo = 0.0R
        Me.txtValor.ValorMinimo = 0.0R
        '
        'lbldescripcion
        '
        Me.lbldescripcion.Location = New System.Drawing.Point(56, 42)
        Me.lbldescripcion.Name = "lbldescripcion"
        Me.lbldescripcion.Size = New System.Drawing.Size(69, 30)
        Me.lbldescripcion.TabIndex = 0
        Me.lbldescripcion.Text = "Descripción"
        Me.lbldescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblValor
        '
        Me.lblValor.Location = New System.Drawing.Point(56, 72)
        Me.lblValor.Name = "lblValor"
        Me.lblValor.Size = New System.Drawing.Size(69, 30)
        Me.lblValor.TabIndex = 1
        Me.lblValor.Text = "Valor"
        Me.lblValor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tlpTop
        '




        '
        'frmEntTiposFrecuenciasIncidencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.ClientSize = New System.Drawing.Size(393, 144)
        Me.Controls.Add(Me.lbldescripcion)
        Me.Controls.Add(Me.txtdescripcion)
        Me.Controls.Add(Me.lblValor)
        Me.Controls.Add(Me.txtValor)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimumSize = New System.Drawing.Size(0, 0)
        Me.Name = "frmEntTiposFrecuenciasIncidencias"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposFrecuenciasIncidencias"
        Me.Controls.SetChildIndex(Me.txtValor, 0)
        Me.Controls.SetChildIndex(Me.lblValor, 0)
        Me.Controls.SetChildIndex(Me.txtdescripcion, 0)
        Me.Controls.SetChildIndex(Me.lbldescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub


    Private WithEvents txtdescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtValor As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lbldescripcion As System.Windows.Forms.Label
    Private WithEvents lblValor As System.Windows.Forms.Label
End Class
