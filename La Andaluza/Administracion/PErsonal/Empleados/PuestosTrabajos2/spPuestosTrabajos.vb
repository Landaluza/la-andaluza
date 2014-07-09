Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spPuestosTrabajos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[PuestosTrabajosSelect]", _
                      "[dbo].[PuestosTrabajosInsert]", _
                      "[dbo].[PuestosTrabajosUpdate]", _
                      "[dbo].[PuestosTrabajosDelete]", _
                      "[dbo].[PuestosTrabajosSelectDgv]", _
                      "[dbo].[PuestosTrabajosSelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal PuestoTrabajoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_PuestosTrabajos
       Dim dbo As New DBO_PuestosTrabajos
       dbo.searchKey = dbo.item("PuestoTrabajoID")
       dbo.searchKey.value = PuestoTrabajoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PuestoTrabajoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_PuestosTrabajos
       dbo.searchKey = dbo.item("PuestoTrabajoID")
       dbo.searchKey.value = PuestoTrabajoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

   Public Sub cargar_PuestosTrabajos(ByRef cbo As ComboBox)
       cbo.mam_DataSource("PuestosTrabajosCbo", False)
   End Sub

End Class
