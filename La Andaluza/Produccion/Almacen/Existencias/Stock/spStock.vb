

Public Class spStock

    Public Sub SelectStock0()
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock0]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            
            selectCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function SelectStock1(ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock1]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.Parameters.AddWithValue("@StartDate", StartDate)
        selectCommand.Parameters.AddWithValue("@EndDate", EndDate)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            
            Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try
        Return dt
    End Function

    Public Function SelectStock2(ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.Parameters.AddWithValue("@StartDate", StartDate)
        selectCommand.Parameters.AddWithValue("@EndDate", EndDate)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            
            Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try
        Return dt
    End Function

    Public Function SelectStock3() As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock3]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            
            Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
            Return dt
        Catch ex As System.Data.SqlClient.SqlException
            Return Nothing
        Finally
            connection.Close()
        End Try

    End Function

    Public Sub SelectStock4()
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock4]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            
            selectCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try
    End Sub
End Class
