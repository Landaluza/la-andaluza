Public Class ctlProveedores
    Dim clsTipoProv As New clsTiposProveedores
    Dim clsProv As New clsProveedores
    Dim clsPro_Tip As New clsProv_TipProv


    Public Function devolverProveedoresAnaliticas() As DataTable
        Return clsProv.devolverProveedoresAnaliticas()
    End Function

  

    Public Function devolverProveedores() As DataTable
        Return clsProv.devolver()
    End Function

End Class
