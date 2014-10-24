

Public Class spInformePedidos

    Public Function SelectInformePedidos(ByVal ConNulos As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()


        'selectProcedure = "[dbo].[InformePedidosDaniel]"

        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[InformePedidosMAM2]")
        Dim dt As New DataTable
        selectCommand.Parameters.AddWithValue("@ConCeros", ConNulos)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
        Return dt
    End Function

 

    Public Function SelectInformePedidos_AlbaranesCarga(ByRef dtb As BasesParaCompatibilidad.Database) As DataTable
        dtb.Conectar()
        Return dtb.Consultar("[dbo].[InformePedidos_SelectAlbaranesCargaMaestro]", True)
    End Function

    Public Sub InsertInformePedidos_TablaTemporal(ByVal AlbaranCargaMaestroID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[InformePedidos_InsertTempAlbaranesCargaMaestro]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.Parameters.AddWithValue("@AlbaranCargaMaestroID", AlbaranCargaMaestroID)
        insertCommand.CommandType = CommandType.StoredProcedure

        Try
            insertCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Sub


    Public Sub InsertInformePedidos_TablaTemporal(ByRef dtb As BasesParaCompatibilidad.Database, ByVal AlbaranCargaMaestroID As Integer)
        dtb.Conectar()
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[InformePedidos_InsertTempAlbaranesCargaMaestro]")
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@AlbaranCargaMaestroID", AlbaranCargaMaestroID)

        Try
            insertCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Conectar()
        End Try
    End Sub

    Public Function SelectInformePedidos_ClienteEnFecha(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()

        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[InformePedidos_ClienteFecha]")
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        Try

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
        Return dt
    End Function

End Class
