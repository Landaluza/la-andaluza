Namespace Proveedores
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class frmAvisosPedidos
        Inherits BasesParaCompatibilidad.gridsimpleform

        'Form invalida a Dispose para limpiar la lista de componentes.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Requerido por el Dise�ador de Windows Forms
        Private components As System.ComponentModel.IContainer

        'NOTA: el Dise�ador de Windows Forms necesita el siguiente procedimiento
        'Se puede modificar usando el Dise�ador de Windows Forms.  
        'No lo modifique con el editor de c�digo.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'frmAvisosPedidos
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(835, 461)
            Me.DoubleBuffered = True
            Me.MinimumSize = New System.Drawing.Size(400, 400)
            Me.Name = "frmAvisosPedidos"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "Avisos de pedidos"
            CType(Me.GeneralBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub

    End Class
End Namespace