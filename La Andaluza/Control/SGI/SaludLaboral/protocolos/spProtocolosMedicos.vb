Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProtocolosMedicos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[ProtocolosMedicosSelect]",  _
                     "[dbo].[ProtocolosMedicosInsert]",  _
                     "[dbo].[ProtocolosMedicosUpdate]",  _
                     "[dbo].[ProtocolosMedicosDelete]",  _
                     "[dbo].[ProtocolosMedicosSelectDgv]",  _
                     "[dbo].[ProtocolosMedicosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal ProtocoloMedicoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ProtocolosMedicos
        Dim dbo As New DBO_ProtocolosMedicos
        dbo.searchKey = dbo.item("ProtocoloMedicoID")
        dbo.searchKey.value = ProtocoloMedicoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal ProtocoloMedicoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_ProtocolosMedicos
        dbo.searchKey = dbo.item("ProtocoloMedicoID")
        dbo.searchKey.value = ProtocoloMedicoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Sub cargar_ProtocolosMedicos(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        comboBox.mam_DataSource("[ProtocolosMedicosSelectCbo]", False, dtb)
    End Sub

End Class
