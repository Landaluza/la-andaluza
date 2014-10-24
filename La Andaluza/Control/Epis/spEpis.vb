

Public Class spEpis
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("[dbo].[EpisSelect]", "[dbo].[EpisInsert]", "[dbo].[EpisUpdate]", _
                   "[dbo].[EpisDelete]", "EpisSelectDgv", "")
    End Sub
    Public Function Select_Record(ByVal EpiID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Epis
        dtb.Conectar()
        Dim DBO_Epis As New DBO_Epis

        Dim selectProcedure As String = "[dbo].[EpisSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@EpiID", EpiID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_Epis.EpiID = If(reader("EpiID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EpiID")))
                DBO_Epis.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_Epis.Marca = If(reader("Marca") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Marca")))
                DBO_Epis.Marca_IsDBNull = If(reader("Marca") Is Convert.DBNull, True, False)
                DBO_Epis.Modelo = If(reader("Modelo") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Modelo")))
                DBO_Epis.Modelo_IsDBNull = If(reader("Modelo") Is Convert.DBNull, True, False)
                DBO_Epis.EpiTipoID = If(reader("EpiTipoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EpiTipoID")))
                DBO_Epis.EpiTipoID_IsDBNull = If(reader("EpiTipoID") Is Convert.DBNull, True, False)
                DBO_Epis.RiesgoQuimico = If(reader("RiesgoQuimico") Is Convert.DBNull, False, Convert.ToBoolean(reader("RiesgoQuimico")))
                DBO_Epis.RiesgoMecanico = If(reader("RiesgoMecanico") Is Convert.DBNull, False, Convert.ToBoolean(reader("RiesgoMecanico")))
                DBO_Epis.RiesgoMicrobiologico = If(reader("RiesgoMicrobiologico") Is Convert.DBNull, False, Convert.ToBoolean(reader("RiesgoMicrobiologico")))
                DBO_Epis.RiesgoFrio = If(reader("RiesgoFrio") Is Convert.DBNull, False, Convert.ToBoolean(reader("RiesgoFrio")))
                DBO_Epis.RiesgoTermico = If(reader("RiesgoTermico") Is Convert.DBNull, False, Convert.ToBoolean(reader("RiesgoTermico")))
                DBO_Epis.Usos = If(reader("Usos") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Usos")))
                DBO_Epis.Usos_IsDBNull = If(reader("Usos") Is Convert.DBNull, True, False)
                DBO_Epis.Advertencias = If(reader("Advertencias") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Advertencias")))
                DBO_Epis.Advertencias_IsDBNull = If(reader("Advertencias") Is Convert.DBNull, True, False)
                DBO_Epis.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_Epis.Observaciones_IsDBNull = If(reader("Observaciones") Is Convert.DBNull, True, False)
                DBO_Epis.aMecanico = If(reader("aMecanico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("aMecanico")))
                DBO_Epis.aMecanico_IsDBNull = If(reader("aMecanico") Is Convert.DBNull, True, False)
                DBO_Epis.bMecanico = If(reader("bMecanico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("bMecanico")))
                DBO_Epis.bMecanico_IsDBNull = If(reader("bMecanico") Is Convert.DBNull, True, False)
                DBO_Epis.cMecanico = If(reader("cMecanico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("cMecanico")))
                DBO_Epis.cMecanico_IsDBNull = If(reader("cMecanico") Is Convert.DBNull, True, False)
                DBO_Epis.dMecanico = If(reader("dMecanico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("dMecanico")))
                DBO_Epis.dMecanico_IsDBNull = If(reader("dMecanico") Is Convert.DBNull, True, False)
                DBO_Epis.aQuimico = If(reader("aQuimico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("aQuimico")))
                DBO_Epis.aQuimico_IsDBNull = If(reader("aQuimico") Is Convert.DBNull, True, False)
                DBO_Epis.aMicrobiologico = If(reader("aMicrobiologico") Is Convert.DBNull, String.Empty, Convert.ToString(reader("aMicrobiologico")))
                DBO_Epis.aMicrobiologico_IsDBNull = If(reader("aMicrobiologico") Is Convert.DBNull, True, False)
                DBO_Epis.aFrio = If(reader("aFrio") Is Convert.DBNull, String.Empty, Convert.ToString(reader("aFrio")))
                DBO_Epis.aFrio_IsDBNull = If(reader("aFrio") Is Convert.DBNull, True, False)
                DBO_Epis.bFrio = If(reader("bFrio") Is Convert.DBNull, String.Empty, Convert.ToString(reader("bFrio")))
                DBO_Epis.bFrio_IsDBNull = If(reader("bFrio") Is Convert.DBNull, True, False)
                DBO_Epis.cFrio = If(reader("cFrio") Is Convert.DBNull, String.Empty, Convert.ToString(reader("cFrio")))
                DBO_Epis.cFrio_IsDBNull = If(reader("cFrio") Is Convert.DBNull, True, False)
                DBO_Epis.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Epis.FechaModificacion_IsDBNull = If(reader("FechaModificacion") Is Convert.DBNull, True, False)
                DBO_Epis.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_Epis.UsuarioModificacion_IsDBNull = If(reader("UsuarioModificacion") Is Convert.DBNull, True, False)
            Else
                DBO_Epis = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try
        Return DBO_Epis
    End Function

    Public Function InsertEpis(ByVal dbo_Epis As DBO_Epis, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[EpisInsert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_Epis.Descripcion)
        insertCommand.Parameters.AddWithValue("@Marca", If(dbo_Epis.Marca_IsDBNull = True, Convert.DBNull, dbo_Epis.Marca))
        insertCommand.Parameters.AddWithValue("@Modelo", If(dbo_Epis.Modelo_IsDBNull = True, Convert.DBNull, dbo_Epis.Modelo))
        insertCommand.Parameters.AddWithValue("@EpiTipoID", If(dbo_Epis.EpiTipoID_IsDBNull = True, Convert.DBNull, dbo_Epis.EpiTipoID))
        insertCommand.Parameters.AddWithValue("@RiesgoQuimico", dbo_Epis.RiesgoQuimico)
        insertCommand.Parameters.AddWithValue("@RiesgoMecanico", dbo_Epis.RiesgoMecanico)
        insertCommand.Parameters.AddWithValue("@RiesgoMicrobiologico", dbo_Epis.RiesgoMicrobiologico)
        insertCommand.Parameters.AddWithValue("@RiesgoFrio", dbo_Epis.RiesgoFrio)
        insertCommand.Parameters.AddWithValue("@RiesgoTermico", dbo_Epis.RiesgoTermico)
        insertCommand.Parameters.AddWithValue("@Usos", If(dbo_Epis.Usos_IsDBNull = True, Convert.DBNull, dbo_Epis.Usos))
        insertCommand.Parameters.AddWithValue("@Advertencias", If(dbo_Epis.Advertencias_IsDBNull = True, Convert.DBNull, dbo_Epis.Advertencias))
        insertCommand.Parameters.AddWithValue("@Observaciones", If(dbo_Epis.Observaciones_IsDBNull = True, Convert.DBNull, dbo_Epis.Observaciones))
        insertCommand.Parameters.AddWithValue("@aMecanico", If(dbo_Epis.aMecanico_IsDBNull = True, Convert.DBNull, dbo_Epis.aMecanico))
        insertCommand.Parameters.AddWithValue("@bMecanico", If(dbo_Epis.bMecanico_IsDBNull = True, Convert.DBNull, dbo_Epis.bMecanico))
        insertCommand.Parameters.AddWithValue("@cMecanico", If(dbo_Epis.cMecanico_IsDBNull = True, Convert.DBNull, dbo_Epis.cMecanico))
        insertCommand.Parameters.AddWithValue("@dMecanico", If(dbo_Epis.dMecanico_IsDBNull = True, Convert.DBNull, dbo_Epis.dMecanico))
        insertCommand.Parameters.AddWithValue("@aQuimico", If(dbo_Epis.aQuimico_IsDBNull = True, Convert.DBNull, dbo_Epis.aQuimico))
        insertCommand.Parameters.AddWithValue("@aMicrobiologico", If(dbo_Epis.aMicrobiologico_IsDBNull = True, Convert.DBNull, dbo_Epis.aMicrobiologico))
        insertCommand.Parameters.AddWithValue("@aFrio", If(dbo_Epis.aFrio_IsDBNull = True, Convert.DBNull, dbo_Epis.aFrio))
        insertCommand.Parameters.AddWithValue("@bFrio", If(dbo_Epis.bFrio_IsDBNull = True, Convert.DBNull, dbo_Epis.bFrio))
        insertCommand.Parameters.AddWithValue("@cFrio", If(dbo_Epis.cFrio_IsDBNull = True, Convert.DBNull, dbo_Epis.cFrio))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", If(dbo_Epis.FechaModificacion_IsDBNull = True, Convert.DBNull, dbo_Epis.FechaModificacion))
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", If(dbo_Epis.UsuarioModificacion_IsDBNull = True, Convert.DBNull, dbo_Epis.UsuarioModificacion))
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

    Public Function UpdateEpis(ByVal oldDBO_Epis As DBO_Epis, ByVal newDBO_Epis As DBO_Epis, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[EpisUpdate]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_Epis.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewMarca", If(newDBO_Epis.Marca_IsDBNull = True, Convert.DBNull, newDBO_Epis.Marca))
        updateCommand.Parameters.AddWithValue("@NewModelo", If(newDBO_Epis.Modelo_IsDBNull = True, Convert.DBNull, newDBO_Epis.Modelo))
        updateCommand.Parameters.AddWithValue("@NewEpiTipoID", If(newDBO_Epis.EpiTipoID_IsDBNull = True, Convert.DBNull, newDBO_Epis.EpiTipoID))
        updateCommand.Parameters.AddWithValue("@NewRiesgoQuimico", newDBO_Epis.RiesgoQuimico)
        updateCommand.Parameters.AddWithValue("@NewRiesgoMecanico", newDBO_Epis.RiesgoMecanico)
        updateCommand.Parameters.AddWithValue("@NewRiesgoMicrobiologico", newDBO_Epis.RiesgoMicrobiologico)
        updateCommand.Parameters.AddWithValue("@NewRiesgoFrio", newDBO_Epis.RiesgoFrio)
        updateCommand.Parameters.AddWithValue("@NewRiesgoTermico", newDBO_Epis.RiesgoTermico)
        updateCommand.Parameters.AddWithValue("@NewUsos", If(newDBO_Epis.Usos_IsDBNull = True, Convert.DBNull, newDBO_Epis.Usos))
        updateCommand.Parameters.AddWithValue("@NewAdvertencias", If(newDBO_Epis.Advertencias_IsDBNull = True, Convert.DBNull, newDBO_Epis.Advertencias))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", If(newDBO_Epis.Observaciones_IsDBNull = True, Convert.DBNull, newDBO_Epis.Observaciones))
        updateCommand.Parameters.AddWithValue("@NewaMecanico", If(newDBO_Epis.aMecanico_IsDBNull = True, Convert.DBNull, newDBO_Epis.aMecanico))
        updateCommand.Parameters.AddWithValue("@NewbMecanico", If(newDBO_Epis.bMecanico_IsDBNull = True, Convert.DBNull, newDBO_Epis.bMecanico))
        updateCommand.Parameters.AddWithValue("@NewcMecanico", If(newDBO_Epis.cMecanico_IsDBNull = True, Convert.DBNull, newDBO_Epis.cMecanico))
        updateCommand.Parameters.AddWithValue("@NewdMecanico", If(newDBO_Epis.dMecanico_IsDBNull = True, Convert.DBNull, newDBO_Epis.dMecanico))
        updateCommand.Parameters.AddWithValue("@NewaQuimico", If(newDBO_Epis.aQuimico_IsDBNull = True, Convert.DBNull, newDBO_Epis.aQuimico))
        updateCommand.Parameters.AddWithValue("@NewaMicrobiologico", If(newDBO_Epis.aMicrobiologico_IsDBNull = True, Convert.DBNull, newDBO_Epis.aMicrobiologico))
        updateCommand.Parameters.AddWithValue("@NewaFrio", If(newDBO_Epis.aFrio_IsDBNull = True, Convert.DBNull, newDBO_Epis.aFrio))
        updateCommand.Parameters.AddWithValue("@NewbFrio", If(newDBO_Epis.bFrio_IsDBNull = True, Convert.DBNull, newDBO_Epis.bFrio))
        updateCommand.Parameters.AddWithValue("@NewcFrio", If(newDBO_Epis.cFrio_IsDBNull = True, Convert.DBNull, newDBO_Epis.cFrio))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", If(newDBO_Epis.FechaModificacion_IsDBNull = True, Convert.DBNull, newDBO_Epis.FechaModificacion))
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", If(newDBO_Epis.UsuarioModificacion_IsDBNull = True, Convert.DBNull, newDBO_Epis.UsuarioModificacion))
        updateCommand.Parameters.AddWithValue("@OldEpiID", oldDBO_Epis.EpiID)
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
            MessageBox.Show("Error en UpdateEpis" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function DeleteEpis(ByVal EpiID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[EpisDelete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldEpiID", EpiID)
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
            Throw
        Finally
            dtb.Desconectar()
        End Try
    End Function

End Class
