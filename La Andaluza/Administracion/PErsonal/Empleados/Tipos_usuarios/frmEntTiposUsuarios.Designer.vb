<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _ 
Partial Class frmEntTiposUsuarios
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
        Me.txtDescripcion = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.txtpermisos = New BasesParaCompatibilidad.CuadroDeTexto()
        Me.lblDescripcion = New System.Windows.Forms.Label()
        Me.lblpermisos = New System.Windows.Forms.Label()
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtDescripcion
        '
        Me.txtDescripcion.BackColor = System.Drawing.SystemColors.Window
        Me.txtDescripcion.EsUnicoCampo = ""
        Me.txtDescripcion.EsUnicoCampoID = ""
        Me.txtDescripcion.EsUnicoID = 0
        Me.txtDescripcion.EsUnicoTabla = ""
        Me.txtDescripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescripcion.Location = New System.Drawing.Point(132, 49)
        Me.txtDescripcion.MaxLength = 50
        Me.txtDescripcion.Minimo = 0
        Me.txtDescripcion.Modificado = False
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Numerico_EsNumerico = False
        Me.txtDescripcion.Numerico_NumeroDoublees = 0
        Me.txtDescripcion.Numerico_SeparadorMiles = False
        Me.txtDescripcion.Obligatorio = False
        Me.txtDescripcion.ParametroID = 0
        Me.txtDescripcion.Size = New System.Drawing.Size(383, 24)
        Me.txtDescripcion.TabIndex = 0
        Me.txtDescripcion.ValorMaximo = 0.0!
        Me.txtDescripcion.ValorMinimo = 0.0!
        '
        'txtpermisos
        '
        Me.txtpermisos.BackColor = System.Drawing.SystemColors.Window
        Me.txtpermisos.EsUnicoCampo = ""
        Me.txtpermisos.EsUnicoCampoID = ""
        Me.txtpermisos.EsUnicoID = 0
        Me.txtpermisos.EsUnicoTabla = ""
        Me.txtpermisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpermisos.Location = New System.Drawing.Point(132, 84)
        Me.txtpermisos.MaxLength = 9
        Me.txtpermisos.Minimo = 0
        Me.txtpermisos.Modificado = False
        Me.txtpermisos.Name = "txtpermisos"
        Me.txtpermisos.Numerico_EsNumerico = False
        Me.txtpermisos.Numerico_NumeroDoublees = 0
        Me.txtpermisos.Numerico_SeparadorMiles = False
        Me.txtpermisos.Obligatorio = False
        Me.txtpermisos.ParametroID = 0
        Me.txtpermisos.Size = New System.Drawing.Size(61, 24)
        Me.txtpermisos.TabIndex = 1
        Me.txtpermisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtpermisos.ValorMaximo = 0.0!
        Me.txtpermisos.ValorMinimo = 0.0!
        '
        'lblDescripcion
        '
        Me.lblDescripcion.Location = New System.Drawing.Point(32, 46)
        Me.lblDescripcion.Name = "lblDescripcion"
        Me.lblDescripcion.Size = New System.Drawing.Size(94, 35)
        Me.lblDescripcion.TabIndex = 0
        Me.lblDescripcion.Text = "Descripción"
        Me.lblDescripcion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblpermisos
        '
        Me.lblpermisos.Location = New System.Drawing.Point(32, 81)
        Me.lblpermisos.Name = "lblpermisos"
        Me.lblpermisos.Size = New System.Drawing.Size(94, 35)
        Me.lblpermisos.TabIndex = 1
        Me.lblpermisos.Text = "Permisos"
        Me.lblpermisos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        '
        'frmEntTiposUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.ClientSize = New System.Drawing.Size(547, 153)
        Me.Controls.Add(Me.lblDescripcion)
        Me.Controls.Add(Me.txtDescripcion)
        Me.Controls.Add(Me.lblpermisos)
        Me.Controls.Add(Me.txtpermisos)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.MinimumSize = New System.Drawing.Size(491, 155)
        Me.Name = "frmEntTiposUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "TiposUsuarios"
        Me.Controls.SetChildIndex(Me.txtpermisos, 0)
        Me.Controls.SetChildIndex(Me.lblpermisos, 0)
        Me.Controls.SetChildIndex(Me.txtDescripcion, 0)
        Me.Controls.SetChildIndex(Me.lblDescripcion, 0)
        CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtDescripcion As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents txtpermisos As BasesParaCompatibilidad.CuadroDeTexto
    Private WithEvents lblDescripcion As System.Windows.Forms.Label
    Private WithEvents lblpermisos As System.Windows.Forms.Label
End Class
