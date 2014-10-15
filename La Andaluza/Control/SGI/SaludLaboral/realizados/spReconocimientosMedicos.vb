Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spReconocimientosMedicos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ReconocimientosMedicosSelect]",  _
                     "[dbo].[ReconocimientosMedicosInsert]",  _
                     "[dbo].[ReconocimientosMedicosUpdate]",  _
                     "[dbo].[ReconocimientosMedicosDelete]",  _
                     "[dbo].[ReconocimientosMedicosSelectDgv]",  _
                     "[dbo].[ReconocimientosMedicosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal ReconocimientoMedicoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ReconocimientosMedicos
       Dim dbo As New DBO_ReconocimientosMedicos
       dbo.searchKey = dbo.item("ReconocimientoMedicoID")
       dbo.searchKey.value = ReconocimientoMedicoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ReconocimientoMedicoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ReconocimientosMedicos
       dbo.searchKey = dbo.item("ReconocimientoMedicoID")
       dbo.searchKey.value = ReconocimientoMedicoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_ReconocimientosMedicos(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource(dtb.Consultar("[ReconocimientosMedicosSelectCbo]", True), False)
    End Sub

End Class
