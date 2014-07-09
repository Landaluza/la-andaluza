

Public Class spInformeSalidasAlmacen

    Public Function listar_palets_por_producto_entre_fechas(ByVal producto As Integer, ByVal inicio As Date, ByVal fin As Date) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.Conectar()

        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("selectInformeSalidasAlmacen ")
        selectCommand.CommandType = CommandType.StoredProcedure

        'Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)

        Try
            selectCommand.Parameters.AddWithValue("@producto", producto)
            selectCommand.Parameters.AddWithValue("@inicio", inicio)
            selectCommand.Parameters.AddWithValue("@fin", fin)

            Dim dtsTemp As New DataSet
            Dim Ad As New System.Data.SqlClient.SqlDataAdapter(selectCommand)
            Ad.Fill(dtsTemp, "NuevaTabla")

            Return dtsTemp.Tables(0)
        Catch ex As Exception
            Return Nothing
        Finally

        End Try
    End Function
End Class
