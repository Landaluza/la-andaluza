

Public Class spStock2

    Public Function SelectStock2_1() As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2_1]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
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

    Public Sub SelectStock2_2()
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2_2]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
        selectCommand.CommandType = CommandType.StoredProcedure
        Try
            selectCommand.ExecuteNonQuery()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            connection.Close()
        End Try
    End Sub

    Public Function SelectStock2_3(ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2_3]"
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

    Public Function SelectStock2_4(ByVal StartDate As Date, ByVal EndDate As Date) As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2_4]"
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

    Public Function SelectStock2_5() As DataTable
        BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        Dim selectProcedure As String = "[dbo].[Stock2_5]"
        Dim selectCommand As New System.Data.SqlClient.SqlCommand(selectProcedure, connection)
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
End Class
