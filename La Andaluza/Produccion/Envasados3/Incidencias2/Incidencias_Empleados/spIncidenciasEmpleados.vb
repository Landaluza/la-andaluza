Public Class spIncidenciasEmpleados

    Public Function Eliminar(ByVal id As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        dtb.EmpezarTransaccion()

        Try

            If dtb.ConsultaAlteraciones("Incidencias_EmpleadosDelete " & id) Then
                dtb.TerminarTransaccion()
                Return True
            Else
                dtb.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

    Function cargar_grilla(ByVal maestro As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadSelectDgvByIncidencia] " & maestro, False)
    End Function

    Public Function Guardar(ByVal id_incidencias As Integer, ByVal DBO_empleados_formatosEnvasados As DBO_empleados_formatosEnvasados, Optional ByVal transaction As SqlClient.SqlTransaction = Nothing) As Boolean
        Dim check As Boolean
        'modificacion, realizar las operaciones en tiempo real
        If transaction Is Nothing Then
            BasesParaCompatibilidad.BD.Conectar()
            BasesParaCompatibilidad.BD.EmpezarTransaccion()
            transaction = BasesParaCompatibilidad.BD.transaction
            check = True
        Else
            check = False
        End If

        Try
            Dim sp As New spPartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad
            Dim spempleados_formatosEnvasados As New spempleados_formatosEnvasados
            Dim spPartesEnvasados_CausasPartesEnvasado As New spPartesEnvasados_CausasPartesEnvasado
            Dim DBO_PartesEnvasados_CausasPartesEnvasado As New DBO_PartesEnvasados_CausasPartesEnvasado
            Dim dbo As New DBO_PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidad

            spempleados_formatosEnvasados.Grabar(DBO_empleados_formatosEnvasados, transaction)

            DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = spempleados_formatosEnvasados.seleccionarUltimoRegistro(BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
            DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = 2 'incidencia

            spPartesEnvasados_CausasPartesEnvasado.Grabar(DBO_PartesEnvasados_CausasPartesEnvasado, transaction)

            dbo.Id_ParteEnvasado_causaParteEnvasado = spPartesEnvasados_CausasPartesEnvasado.seleccionarUltimoRegistro(BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
            dbo.Id_Incidencia = id_incidencias

            sp.Grabar(dbo, transaction)

            If check Then BasesParaCompatibilidad.BD.TerminarTransaccion()
            Return True
        Catch ex As Exception
            If check Then BasesParaCompatibilidad.BD.CancelarTransaccion()
            Throw
            Return False
        End Try
    End Function
End Class
