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

   Public Overloads Function Select_Record(ByVal ProtocoloMedicoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_ProtocolosMedicos
       Dim dbo As New DBO_ProtocolosMedicos
       dbo.searchKey = dbo.item("ProtocoloMedicoID")
       dbo.searchKey.value = ProtocoloMedicoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ProtocoloMedicoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_ProtocolosMedicos
       dbo.searchKey = dbo.item("ProtocoloMedicoID")
       dbo.searchKey.value = ProtocoloMedicoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_ProtocolosMedicos(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("[ProtocolosMedicosSelectCbo]", False)
    End Sub

End Class
