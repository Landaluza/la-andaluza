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

   Public Overloads Function Select_Record(ByVal TipoLoteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposLotes
       Dim dbo As New DBO_TiposLotes
       dbo.searchKey = dbo.item("TipoLoteID")
       dbo.searchKey.value = TipoLoteID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal TipoLoteID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_TiposLotes
       dbo.searchKey = dbo.item("TipoLoteID")
       dbo.searchKey.value = TipoLoteID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Sub cargar_TiposLotes(ByRef cbo As ComboBox, Optional ByVal opcion As String = "")
        If opcion = String.Empty Then
            cbo.mam_DataSource("TiposLotesCbo", False)
        Else
            cbo.mam_DataSource("TiposLotesCbo", True, new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server), opcion)
        End If
    End Sub

    Public Function devolver_TiposLotes() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("TiposLotesCbo", False)
    End Function

    Public Function DevolverPorDescripcion(ByVal Descripcion As String, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_TiposLotes
        Dim dbo As New DBO_TiposLotes
        dbo.searchKey = dbo.item("Descripcion")
        dbo.searchKey.value = Descripcion
        'MyBase.Select_Record(dbo, trans)
        MyBase.Select_proc(dbo, "TiposLotesByDescripcion", trans)
        Return dbo
    End Function

End Class
