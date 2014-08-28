<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccesoRemoto
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAccesoRemoto))
        Me.rdp = New AxMSTSCLib.AxMsTscAxNotSafeForScripting()
        CType(Me.rdp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rdp
        '
        Me.rdp.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rdp.Enabled = True
        Me.rdp.Location = New System.Drawing.Point(0, 0)
        Me.rdp.Name = "rdp"
        Me.rdp.OcxState = CType(resources.GetObject("rdp.OcxState"), System.Windows.Forms.AxHost.State)
        Me.rdp.Size = New System.Drawing.Size(1001, 595)
        Me.rdp.TabIndex = 0
        '
        'frmAccesoRemoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 595)
        Me.Controls.Add(Me.rdp)
        Me.Name = "frmAccesoRemoto"
        Me.Text = "frmAccesoRemoto"
        CType(Me.rdp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Private WithEvents rdp As AxMSTSCLib.AxMsTscAxNotSafeForScripting
End Class
