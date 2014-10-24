Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spMedidasProductos
Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[MedidasProductosSelect]", _
                        "[dbo].[MedidasProductosInsert]", _
                        "[dbo].[MedidasProductosUpdate]", _
                        "[dbo].[MedidasProductosDelete]", _
                        "[dbo].[MedidasProductosSelectDgv]", _
                        "[dbo].[MedidasProductosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal MedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MedidasProductos
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MedidaID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_MedidasProductos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MedidasProductosCbo", False, dtb)
    End Sub

    Public Function devolver_MedidasProductos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("MedidasProductosCbo", True)
    End Function
End Class
