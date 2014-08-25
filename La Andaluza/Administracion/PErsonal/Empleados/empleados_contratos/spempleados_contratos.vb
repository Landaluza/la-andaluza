

Public Class spempleados_contratos
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[empleados_contratosSelect]", _
                        "[dbo].[empleados_contratosInsert]", _
                        "[dbo].[empleados_contratosUpdate]", _
                        "[dbo].[empleados_contratosDelete]", _
                        "[dbo].[empleados_contratosSelectDgv]", _
                        "[dbo].[empleados_contratosSelectDgvByid_empleado]")
    End Sub

    Public Overloads Function Select_Record(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_empleados_contratos
        Dim dbo As New DBO_empleados_contratos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        MyBase.Select_Record(dbo, trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_empleados_contratos
        dbo.searchKey = dbo.item("id")
        dbo.searchKey.value = id
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Function select_fecha_final(ByVal id_empleado As Integer) As String
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        dtb.PrepararConsulta("select max(fecha_final) from empleados_contratos where id_empleado = @id")
        dtb.AñadirParametroConsulta("@id", id_empleado)
        Dim row As Object = dtb.Consultar().Rows(0).Item(0)
        'Dim row As Object = dtb.Consultar("select max(fecha_final) from empleados_contratos where id_empleado = " & id_empleado, False).Rows(0).Item(0)
        Return if(IsDBNull(row), "-", row)
    End Function

    Function select_ultimo_contrato(personalId As Integer) As DBO_empleados_contratos
        Dim dbo As New DBO_empleados_contratos
        dbo.searchKey = dbo.item("id_empleado")
        dbo.searchKey.value = personalId
        MyBase.Select_proc(dbo, "[empleados_contratosSelectUltimo]")
        Return dbo
    End Function

End Class
