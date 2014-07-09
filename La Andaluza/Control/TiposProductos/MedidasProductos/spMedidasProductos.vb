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

    Public Overloads Function Select_Record(ByVal MedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_MedidasProductos
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MedidaID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_MedidasProductos
        dbo.searchKey = dbo.item("MedidaID")
        dbo.searchKey.value = MedidaID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Sub cargar_MedidasProductos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("MedidasProductosCbo", False)
    End Sub

    Public Function devolver_MedidasProductos() As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("MedidasProductosCbo", True)
    End Function
End Class
