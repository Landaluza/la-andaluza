Public Class spVentas

    Function grabar_venta(ByVal mes As Integer, ByVal agno As Integer, ByVal qs As Integer, ByVal descripcion As String, ByVal cantidad As Integer) As Boolean
        Dim clsExcelToSQL As New ExcelToSQLClass
        clsExcelToSQL.Año = agno
        clsExcelToSQL.Mes = mes
        clsExcelToSQL.Año_IsDBNull = False
        clsExcelToSQL.Mes_IsDBNull = False

        clsExcelToSQL.Descripcion = descripcion
        clsExcelToSQL.Cajas = cantidad
        clsExcelToSQL.Cajas_IsDBNull = False
        clsExcelToSQL.CodigoQS = qs
        clsExcelToSQL.CodigoQS_IsDBNull = False
        clsExcelToSQL.Observaciones_IsDBNull = True

        Dim excelImport As New ExcelToSQLDataClass
        Return excelImport.Add(clsExcelToSQL)
    End Function

End Class
