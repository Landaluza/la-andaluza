Namespace Deprecated

Public Module BD
        Private linea As String




        'Public Function ConsultaInsertar(ByVal Datos As String, ByVal tabla As String) As Integer
        '    linea = "insert into " + tabla + " values " + "( " + Datos + ",'" + BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")"
        '    Return BasesParaCompatibilidad.BD.realizarConsultaAlteraciones(linea)
        'End Function

        'Public Function ConsultaInsertarConcampos(ByVal campos As String, ByVal Datos As String, ByVal tabla As String) As Integer
        '    linea = "insert into " + tabla + campos + " values " + "( " + Datos + ",'" + BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")"
        '    Return BasesParaCompatibilidad.BD.realizarConsultaAlteraciones(linea)
        'End Function

        'Public Function ConsultaInsertarSinDatosUsuario(ByVal Datos As String, ByVal tabla As String) As Integer
        '    Linea = "insert into " + tabla + " values " + "( " + Datos + ")"
        '    Return BasesParaCompatibilidad.BD.realizarConsultaAlteraciones(linea)
        'End Function

        'Public Function ConsultaModificar(ByVal tabla As String, ByVal valor1 As String, ByVal restriccion As String) As Integer
        '    linea = "UPDATE  " + tabla + " SET " + valor1 + ", FechaModificacion='" + BasesParaCompatibilidad.Calendar.ArmarFecha(Today + " " + TimeOfDay) + "',UsuarioModificacion=" & BasesParaCompatibilidad.Config.User.ToString + " WHERE " + restriccion
        '    Return BasesParaCompatibilidad.BD.realizarConsultaAlteraciones(linea)
        'End Function



        'Public Function ConsultaVer(ByVal datos As String, ByVal tabla As String, ByVal restriccion As String, ByVal orderBy As String) As DataTable
        '    If restriccion.Length = 0 Then
        '        Linea = "select " + datos + " from " + tabla + " order by " + orderBy
        '    Else
        '        Linea = "select " + datos + " from " + tabla + " where " + restriccion + " order by " + orderBy
        '    End If
        '    Return BasesParaCompatibilidad.BD.RealizarConsulta(linea)
        'End Function

        Public Function ConsultaVer(ByVal datos As String, ByVal tabla As String, ByVal restriccion As String) As DataTable
            Linea = "select " + datos + " from " + tabla + " where " + restriccion
            Return BasesParaCompatibilidad.BD.RealizarConsulta(linea)
        End Function

        'Public Function ConsultaVer(ByVal top100 As Boolean, ByVal datos As String, ByVal tabla As String, ByVal restriccion As String) As DataTable
        '    If top100 Then
        '        Linea = "select top 100 " + datos + " from " + tabla + " where " + restriccion
        '    Else
        '        Linea = "select " + datos + " from " + tabla + " where " + restriccion
        '    End If
        '    Return BasesParaCompatibilidad.BD.RealizarConsulta(linea)
        'End Function

        'Public Function ConsultaVer(ByVal datos As String, ByVal tabla As String) As DataTable
        '    Linea = "select " + datos + If(tabla <> "", " from " + tabla, "")
        '    Return BasesParaCompatibilidad.BD.RealizarConsulta(linea)
        'End Function

        'Public Function ConsultaProcedAlmacenado(ByVal NombreProcedimiento As String, ByVal datos As String) As DataTable
        '    Try
        '        Linea = NombreProcedimiento + " " + datos
        '        Return BasesParaCompatibilidad.BD.RealizarConsulta(linea)
        '    Catch ex As Exception
        '        MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '        Return Nothing
        '    End Try
        'End Function




    End Module
End Namespace
