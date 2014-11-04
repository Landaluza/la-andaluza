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

    Public Overloads Function Select_Record(ByVal ReconocimientoMedicoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ReconocimientosMedicos
        Dim dbo As New DBO_ReconocimientosMedicos
        dbo.searchKey = dbo.item("ReconocimientoMedicoID")
        dbo.searchKey.value = ReconocimientoMedicoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ReconocimientoMedicoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ReconocimientosMedicos
        dbo.searchKey = dbo.item("ReconocimientoMedicoID")
        dbo.searchKey.value = ReconocimientoMedicoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_ReconocimientosMedicos(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("[ReconocimientosMedicosSelectCbo]")
        comboBox.mam_DataSource(dtb.Consultar(), False)
    End Sub

End Class
