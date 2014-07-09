Public Class Controler_control
    Inherits Controller


    Public Overrides Sub cargar_extras()

        'Control.CheckForIllegalCrossThreadCalls = False

        Me.form = New frmResumenDepositos

        'AddHandler frm.MouseLeave, AddressOf GUImain.ToolStripLabel1_Click
    End Sub


End Class
