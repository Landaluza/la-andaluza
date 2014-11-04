Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposLotes
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposLotesSelect]",  _
                     "[dbo].[TiposLotesInsert]",  _
                     "[dbo].[TiposLotesUpdate]",  _
                     "[dbo].[TiposLotesDelete]",  _
                     "[dbo].[TiposLotesSelectDgv]",  _
                     "[dbo].[TiposLotesSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoLoteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposLotes
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("TipoLoteID")
        dbo.searchKey.value = TipoLoteID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoLoteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("TipoLoteID")
        dbo.searchKey.value = TipoLoteID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_TiposLotes(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal opcion As String = "")
        If opcion = String.Empty Then
            cbo.mam_DataSource("TiposLotesCbo", False, dtb)
        Else
            cbo.mam_DataSource("TiposLotesCbo", True, dtb, opcion)
        End If
    End Sub

    Public Function devolver_TiposLotes(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("TiposLotesCbo")
        Return dtb.Consultar()
    End Function

    Public Function DevolverPorDescripcion(ByVal Descripcion As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposLotes
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("Descripcion")
        dbo.searchKey.value = Descripcion
        'MyBase.Select_Record(dbo,dtb)
        MyBase.Select_proc(dbo, "TiposLotesByDescripcion", dtb)
        Return dbo
    End Function

End Class
