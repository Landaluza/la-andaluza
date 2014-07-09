Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spReconocimientosMedicosTipos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosTiposSelect]",  _
                     "[dbo].[ReconocimientosMedicosTiposInsert]",  _
                     "[dbo].[ReconocimientosMedicosTiposUpdate]",  _
                     "[dbo].[ReconocimientosMedicosTiposDelete]",  _
                     "[dbo].[ReconocimientosMedicosTiposSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosTiposSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ReconocimientoMedicoTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ReconocimientosMedicosTipos
       Dim dbo As New DBO_ReconocimientosMedicosTipos
       dbo.searchKey = dbo.item("ReconocimientoMedicoTipoID")
       dbo.searchKey.value = ReconocimientoMedicoTipoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ReconocimientoMedicoTipoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ReconocimientosMedicosTipos
       dbo.searchKey = dbo.item("ReconocimientoMedicoTipoID")
       dbo.searchKey.value = ReconocimientoMedicoTipoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_ReconocimientosMedicosTipos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("ReconocimientosMedicosTiposCbo", False)
   End Sub

End Class
