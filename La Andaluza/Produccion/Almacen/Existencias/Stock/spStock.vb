

Public Class spStock

    Public Sub SelectStock0(ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[Stock0]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try

            selectCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
    End Sub

    Public Function SelectStock1(ByVal StartDate As Date, ByVal EndDate As Date, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[Stock1]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.Parameters.AddWithValue("@StartDate", StartDate)
        selectCommand.Parameters.AddWithValue("@EndDate", EndDate)
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

    Public Function SelectStock2(ByVal StartDate As Date, ByVal EndDate As Date, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[Stock2]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.Parameters.AddWithValue("@StartDate", StartDate)
        selectCommand.Parameters.AddWithValue("@EndDate", EndDate)
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

    Public Function SelectStock3(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[Stock3]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        Try

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
            Return dt
        Catch ex As System.Data.SqlClient.SqlException
            Return Nothing
        Finally
            dtb.Desconectar()
        End Try

    End Function

    Public Sub SelectStock4(ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[Stock4]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try

            selectCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try
    End Sub
End Class
