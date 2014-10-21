Namespace Deprecated

Public Module BD
        Private linea As String




        Public Function ConsultaVer(ByVal datos As String, ByVal tabla As String, ByVal restriccion As String) As DataTable
            Linea = "select " + datos + " from " + tabla + " where " + restriccion
            Return Deprecated.RealizarConsulta(linea)
        End Function

    
#Region "Consultas Alejandro"

        Public Function RealizarConsulta(ByVal Cadena As String) As DataTable
            Dim dtsTabla As New DataTable
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
            Try
                dtsTabla = EjecutarRealizarConsulta(Cadena)
                Return dtsTabla
            Catch ex As Exception
                Return Nothing
            Finally
                If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
            End Try
        End Function



        Public Function EjecutarRealizarConsulta(ByVal strRealizarConsulta As String) As DataTable
            Dim dtsTemp As New DataSet
            Dim cmd As System.Data.SqlClient.SqlCommand = Nothing

            Try
                cmd = New System.Data.SqlClient.SqlCommand(strRealizarConsulta, BasesParaCompatibilidad.BD.Cnx)
                If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction
                cmd.CommandTimeout = 300
                Dim Ad As New System.Data.SqlClient.SqlDataAdapter(cmd)
                Ad.Fill(dtsTemp, "NuevaTabla")
                cmd.Dispose()
            Catch ex As Exception
                cmd.Dispose()
                MessageBox.Show("problema en BD.EjecutarRealizarConsulta Ad.Fill" & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

            Return dtsTemp.Tables(0)
        End Function

        'Public Function realizarConsultaAlteraciones(ByVal strrealizarConsulta As String) As Integer
        '    Dim exito As Integer
        '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        '    Dim cmd As System.Data.SqlClient.SqlCommand
        '    cmd = New System.Data.SqlClient.SqlCommand(strrealizarConsulta, BasesParaCompatibilidad.BD.Cnx)
        '    If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then cmd.Transaction = BasesParaCompatibilidad.BD.transaction
        '    Try
        '        cmd.ExecuteNonQuery()
        '        exito = 1
        '    Catch ex As Exception
        '        MessageBox.Show("Ha ocurrido un error. Detalles:" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        exito = 0
        '    End Try
        '    cmd.Dispose()
        '    If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Cerrar()
        '    Return exito
        'End Function





#End Region


    End Module
End Namespace
