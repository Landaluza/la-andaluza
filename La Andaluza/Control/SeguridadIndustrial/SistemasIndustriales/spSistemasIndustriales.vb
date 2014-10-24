

Public Class spSistemasIndustriales
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[SistemasIndustrialesSelect]", "[dbo].[SistemasIndustrialesInsert]", "[dbo].[SistemasIndustrialesUpdate]", "[dbo].[SistemasIndustrialesDelete]", "SistemasIndustrialesSelectDgv", "")
    End Sub
    Public Function Select_Record(ByVal SistemaIndustrialID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_SistemasIndustriales
        dtb.Conectar()
        Dim DBO_SistemasIndustriales As New DBO_SistemasIndustriales

        Dim selectProcedure As String = "[dbo].[SistemasIndustrialesSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@SistemaIndustrialID", SistemaIndustrialID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_SistemasIndustriales.SistemaIndustrialID = If(reader("SistemaIndustrialID") Is Convert.DBNull, 0, Convert.ToInt32(reader("SistemaIndustrialID")))
                DBO_SistemasIndustriales.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_SistemasIndustriales.FechaInstalacion = If(reader("FechaInstalacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaInstalacion")))
                DBO_SistemasIndustriales.FechaInstalacion_IsDBNull = If(reader("FechaInstalacion") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.FechaRegistroIndustria = If(reader("FechaRegistroIndustria") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaRegistroIndustria")))
                DBO_SistemasIndustriales.FechaRegistroIndustria_IsDBNull = If(reader("FechaRegistroIndustria") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.ReferenciaExpedienteIndustria = If(reader("ReferenciaExpedienteIndustria") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ReferenciaExpedienteIndustria")))
                DBO_SistemasIndustriales.ReferenciaExpedienteIndustria_IsDBNull = If(reader("ReferenciaExpedienteIndustria") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.ReferenciaRegistroIndustria = If(reader("ReferenciaRegistroIndustria") Is Convert.DBNull, String.Empty, Convert.ToString(reader("ReferenciaRegistroIndustria")))
                DBO_SistemasIndustriales.ReferenciaRegistroIndustria_IsDBNull = If(reader("ReferenciaRegistroIndustria") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.FechaPresentacionIndustria = If(reader("FechaPresentacionIndustria") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaPresentacionIndustria")))
                DBO_SistemasIndustriales.FechaPresentacionIndustria_IsDBNull = If(reader("FechaPresentacionIndustria") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.AutorProyecto = If(reader("AutorProyecto") Is Convert.DBNull, String.Empty, Convert.ToString(reader("AutorProyecto")))
                DBO_SistemasIndustriales.AutorProyecto_IsDBNull = If(reader("AutorProyecto") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_SistemasIndustriales.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_SistemasIndustriales.FechaModificacion_IsDBNull = If(reader("FechaModificacion") Is Convert.DBNull, True, False)
                DBO_SistemasIndustriales.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_SistemasIndustriales.UsuarioModificacion_IsDBNull = If(reader("UsuarioModificacion") Is Convert.DBNull, True, False)
            Else
                DBO_SistemasIndustriales = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_SistemasIndustriales
    End Function

    Public Function InsertSistemasIndustriales(ByVal dbo_SistemasIndustriales As DBO_SistemasIndustriales, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[SistemasIndustrialesInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_SistemasIndustriales.Descripcion)
        insertCommand.Parameters.AddWithValue("@FechaInstalacion", If(dbo_SistemasIndustriales.FechaInstalacion_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.FechaInstalacion))
        insertCommand.Parameters.AddWithValue("@FechaRegistroIndustria", If(dbo_SistemasIndustriales.FechaRegistroIndustria_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.FechaRegistroIndustria))
        insertCommand.Parameters.AddWithValue("@ReferenciaExpedienteIndustria", If(dbo_SistemasIndustriales.ReferenciaExpedienteIndustria_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.ReferenciaExpedienteIndustria))
        insertCommand.Parameters.AddWithValue("@ReferenciaRegistroIndustria", If(dbo_SistemasIndustriales.ReferenciaRegistroIndustria_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.ReferenciaRegistroIndustria))
        insertCommand.Parameters.AddWithValue("@FechaPresentacionIndustria", If(dbo_SistemasIndustriales.FechaPresentacionIndustria_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.FechaPresentacionIndustria))
        insertCommand.Parameters.AddWithValue("@AutorProyecto", If(dbo_SistemasIndustriales.AutorProyecto_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.AutorProyecto))
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_SistemasIndustriales.Observaciones_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.Observaciones))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", If(dbo_SistemasIndustriales.FechaModificacion_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.FechaModificacion))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", If(dbo_SistemasIndustriales.UsuarioModificacion_IsDBNull = True, Convert.DBNull, dbo_SistemasIndustriales.UsuarioModificacion))
        insertCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        insertCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            insertCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(insertCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function UpdateSistemasIndustriales(ByVal oldDBO_SistemasIndustriales As DBO_SistemasIndustriales, ByVal newDBO_SistemasIndustriales As DBO_SistemasIndustriales, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[SistemasIndustrialesUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_SistemasIndustriales.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewFechaInstalacion", If(newDBO_SistemasIndustriales.FechaInstalacion_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.FechaInstalacion))
        updateCommand.Parameters.AddWithValue("@NewFechaRegistroIndustria", If(newDBO_SistemasIndustriales.FechaRegistroIndustria_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.FechaRegistroIndustria))
        updateCommand.Parameters.AddWithValue("@NewReferenciaExpedienteIndustria", If(newDBO_SistemasIndustriales.ReferenciaExpedienteIndustria_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.ReferenciaExpedienteIndustria))
        updateCommand.Parameters.AddWithValue("@NewReferenciaRegistroIndustria", If(newDBO_SistemasIndustriales.ReferenciaRegistroIndustria_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.ReferenciaRegistroIndustria))
        updateCommand.Parameters.AddWithValue("@NewFechaPresentacionIndustria", If(newDBO_SistemasIndustriales.FechaPresentacionIndustria_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.FechaPresentacionIndustria))
        updateCommand.Parameters.AddWithValue("@NewAutorProyecto", If(newDBO_SistemasIndustriales.AutorProyecto_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.AutorProyecto))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDBO_SistemasIndustriales.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", If(newDBO_SistemasIndustriales.FechaModificacion_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.FechaModificacion))
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", If(newDBO_SistemasIndustriales.UsuarioModificacion_IsDBNull = True, Convert.DBNull, newDBO_SistemasIndustriales.UsuarioModificacion))
        updateCommand.Parameters.AddWithValue("@OldSistemaIndustrialID", oldDBO_SistemasIndustriales.SistemaIndustrialID)
        updateCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        updateCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            updateCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(updateCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Error en UpdateSistemasIndustriales" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeleteSistemasIndustriales(ByVal SistemaIndustrialID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[SistemasIndustrialesDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldSistemaIndustrialID", SistemaIndustrialID)
        deleteCommand.Parameters.Add("@ReturnValue", System.Data.SqlDbType.Int)
        deleteCommand.Parameters("@ReturnValue").Direction = ParameterDirection.Output
        Try

            deleteCommand.ExecuteNonQuery()
            Dim count As Integer = System.Convert.ToInt32(deleteCommand.Parameters("@ReturnValue").Value)
            If count > 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

End Class
