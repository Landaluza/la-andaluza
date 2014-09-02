

Public Class spPartesEnvasados_CausasPartesEnvasado
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[PartesEnvasados_CausasPartesEnvasadoSelect]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasadoInsert]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasadoUpdate]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasadoDelete]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasadoSelectDgv]",  _
                     "[dbo].[PartesEnvasados_CausasPartesEnvasadoSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_PartesEnvasados_CausasPartesEnvasado
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado
       dbo.searchKey = dbo.item("Id")
       dbo.searchKey.value = Id
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Public Function DeleteByParte(ByVal Id_empleadoFormatoEnvasado As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)

        Return dtb.ConsultaAlteraciones("delete from PartesEnvasados_CausasPartesEnvasado where id_ParteEnvasado=" & Id_empleadoFormatoEnvasado)
    End Function

    Public Function seleccionarUltimoRegistro(Optional ByVal cnn as System.Data.SqlClient.SqlConnection = Nothing, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Integer
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, cnn, trans)
        Return dtb.Consultar("select max(id) from PartesEnvasados_CausasPartesEnvasado", False).Rows(0).Item(0)
    End Function

    Function isNoConforme(ByVal parteId As Integer) As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("select count(*) from PartesEnvasados_CausasPartesEnvasado where id_parteEnvasado = @id")
        dtb.AñadirParametroConsulta("@id", parteId)

        If dtb.Consultar().Rows(0).Item(0) > 0 Then
            Return True
        Else : Return False
        End If
    End Function

End Class
