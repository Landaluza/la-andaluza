Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spMotivosCeseServicio
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[MotivosCeseServicioSelect]", _
                      "[dbo].[MotivosCeseServicioInsert]", _
                      "[dbo].[MotivosCeseServicioUpdate]", _
                      "[dbo].[MotivosCeseServicioDelete]", _
                      "[dbo].[MotivosCeseServicioSelectDgv]", _
                      "[dbo].[MotivosCeseServicioSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal MotivoCeseServicioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_MotivosCeseServicio
        Dim dbo As New DBO_MotivosCeseServicio
        dbo.searchKey = dbo.item("MotivoCeseServicioID")
        dbo.searchKey.value = MotivoCeseServicioID
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal MotivoCeseServicioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_MotivosCeseServicio
        dbo.searchKey = dbo.item("MotivoCeseServicioID")
        dbo.searchKey.value = MotivoCeseServicioID
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_MotivosCeseServicio(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MotivosCeseServicioCbo", False, dtb)
    End Sub

End Class
