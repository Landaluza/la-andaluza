Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spClientes2

    Public Sub cargar_Clientes(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ClientesCbo", False)
    End Sub
End Class
