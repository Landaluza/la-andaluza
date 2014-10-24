Imports BasesParaCompatibilidad.ComboBoxExtension 

Public Class spTiposDepositos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposDepositosSelect]",  _
                     "[dbo].[TiposDepositosInsert]",  _
                     "[dbo].[TiposDepositosUpdate]",  _
                     "[dbo].[TiposDepositosDelete]",  _
                     "[dbo].[TiposDepositosSelectDgv]",  _
                     "[dbo].[TiposDepositosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposDepositos
        Dim dbo As New DBO_TiposDepositos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposDepositos
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.Databussines), dtb)
    End Function

    Public Sub cargar_TiposDepositos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposDepositosCbo", False, dtb)
    End Sub

End Class
