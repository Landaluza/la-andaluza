Public Class spIncidenciasEmpleados

    Public Function Eliminar(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
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

    Function cargar_grilla(ByVal maestro As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("[PartesEnvasados_CausasPartesEnvasado_IncidenciasCalidadSelectDgvByIncidencia] " & maestro, False)
    End Function

    Public Function Guardar(ByVal id_incidencias As Integer, ByVal DBO_empleados_formatosEnvasados As DBO_empleados_formatosEnvasados, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim check As Boolean
        'modificacion, realizar las operaciones en tiempo real
        If dtb.Transaccion Is Nothing Then
            dtb.Conectar()
            dtb.EmpezarTransaccion()

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

            spempleados_formatosEnvasados.Grabar(DBO_empleados_formatosEnvasados, dtb)

            DBO_PartesEnvasados_CausasPartesEnvasado.Id_ParteEnvasado = spempleados_formatosEnvasados.seleccionarUltimoRegistro(dtb)
            DBO_PartesEnvasados_CausasPartesEnvasado.Id_CausaParteEnvasado = 2 'incidencia

            spPartesEnvasados_CausasPartesEnvasado.Grabar(DBO_PartesEnvasados_CausasPartesEnvasado, dtb)

            dbo.Id_ParteEnvasado_causaParteEnvasado = spPartesEnvasados_CausasPartesEnvasado.seleccionarUltimoRegistro(dtb)
            dbo.Id_Incidencia = id_incidencias

            sp.Grabar(dbo, dtb)

            If check Then dtb.TerminarTransaccion()
            Return True
        Catch ex As Exception
            If check Then dtb.CancelarTransaccion()
            Throw
            Return False
        End Try
    End Function
End Class
