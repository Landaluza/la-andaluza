Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class spClientes2

    Public Sub cargar_Clientes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ClientesCbo", False, dtb)
    End Sub
End Class
