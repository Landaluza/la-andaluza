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

    Public Overloads Function Select_Record(ByVal PuestoTrabajoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_PuestosTrabajos
        Dim dbo As New DBO_PuestosTrabajos
        dbo.searchKey = dbo.item("PuestoTrabajoID")
        dbo.searchKey.value = PuestoTrabajoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal PuestoTrabajoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_PuestosTrabajos
        dbo.searchKey = dbo.item("PuestoTrabajoID")
        dbo.searchKey.value = PuestoTrabajoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_PuestosTrabajos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("PuestosTrabajosCbo", False, dtb)
    End Sub

End Class
