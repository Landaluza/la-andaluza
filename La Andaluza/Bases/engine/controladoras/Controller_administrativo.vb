Public Class Controller_administrativo
    Inherits Controller


    Public Overrides Sub cargar_extras()

        'Control.CheckForIllegalCrossThreadCalls = False

        Me.form = New frmBusquedaAdministracion

        'AddHandler frm.MouseLeave, AddressOf GUImain.ToolStripLabel1_Click
    End Sub
End Class
