

Class spArticulosFichasCondiciones3
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[ArticulosFichasCondiciones3Select]", "[dbo].[ArticulosFichasCondiciones3Insert]", "[dbo].[ArticulosFichasCondiciones3Update]", _
                   "[dbo].[ArticulosFichasCondiciones3Delete]", "ArticulosFichasCondiciones3SelectDgv", "ArticulosFichasCondiciones3SelectDgvByArticuloFichaCondicionID")
    End Sub

    Public Function Select_Record(ByVal ArticuloFichaCondicionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_ArticulosFichasCondiciones3
        dtb.Conectar()
        Dim DBO_ArticulosFichasCondiciones3 As New DBO_ArticulosFichasCondiciones3

        Dim selectProcedure As String = "[dbo].[ArticulosFichasCondiciones3Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@ArticuloFichaCondicionID", ArticuloFichaCondicionID)
        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then
                DBO_ArticulosFichasCondiciones3.ArticuloFichaCondicionID = If(reader("ArticuloFichaCondicionID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloFichaCondicionID")))
                DBO_ArticulosFichasCondiciones3.ArticuloID = If(reader("ArticuloID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloID")))
                DBO_ArticulosFichasCondiciones3.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_ArticulosFichasCondiciones3.FormaPagoID = If(reader("FormaPagoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("FormaPagoID")))
                DBO_ArticulosFichasCondiciones3.PlazoPagoID = If(reader("PlazoPagoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("PlazoPagoID")))
                DBO_ArticulosFichasCondiciones3.UnidadID = If(reader("UnidadID") Is Convert.DBNull, 0, Convert.ToInt32(reader("UnidadID")))
                DBO_ArticulosFichasCondiciones3.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_ArticulosFichasCondiciones3.EurosUnidad = If(reader("EurosUnidad") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("EurosUnidad")))
                DBO_ArticulosFichasCondiciones3.CantidadMinima = If(reader("CantidadMinima") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("CantidadMinima")))
                DBO_ArticulosFichasCondiciones3.PrecioAnterior = If(reader("PrecioAnterior") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("PrecioAnterior")))
                DBO_ArticulosFichasCondiciones3.Incremento = If(reader("Incremento") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("Incremento")))
                DBO_ArticulosFichasCondiciones3.Ruta = If(reader("Ruta") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Ruta")))
                DBO_ArticulosFichasCondiciones3.FechaInicio = If(reader("FechaInicio") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaInicio")))
                DBO_ArticulosFichasCondiciones3.FechaFinal = If(reader("FechaFinal") Is Convert.DBNull, System.DateTime.Now, CDate(reader("FechaFinal")))
                DBO_ArticulosFichasCondiciones3.Vigente = If(reader("Vigente") Is Convert.DBNull, False, Convert.ToBoolean(reader("Vigente")))
                DBO_ArticulosFichasCondiciones3.CosteTransporte = If(reader("CosteTransporte") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("CosteTransporte")))
                DBO_ArticulosFichasCondiciones3.CosteEmbalaje = If(reader("CosteEmbalaje") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("CosteEmbalaje")))
                DBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje = If(reader("CosteDevolucionEmbalaje") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("CosteDevolucionEmbalaje")))
                DBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje = If(reader("AbonoDevolucionEmbalaje") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("AbonoDevolucionEmbalaje")))
                DBO_ArticulosFichasCondiciones3.CosteMolde = If(reader("CosteMolde") Is Convert.DBNull, 0, System.Convert.ToDouble(reader("CosteMolde")))
                DBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad = System.Convert.ToDouble(If(reader("CosteAmortizacionMoldeUnidad") Is Convert.DBNull, 0, reader("CosteAmortizacionMoldeUnidad")))
                DBO_ArticulosFichasCondiciones3.Observaciones = If(reader("Observaciones") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observaciones")))
                DBO_ArticulosFichasCondiciones3.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_ArticulosFichasCondiciones3.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
            Else
                DBO_ArticulosFichasCondiciones3 = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException

        Finally
            dtb.Desconectar()
        End Try
        Return DBO_ArticulosFichasCondiciones3
    End Function

    Public Function ArticulosFichasCondiciones3Insert(ByVal dbo_ArticulosFichasCondiciones3 As DBO_ArticulosFichasCondiciones3, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[ArticulosFichasCondiciones3Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure
        insertCommand.Parameters.AddWithValue("@ArticuloID", If(dbo_ArticulosFichasCondiciones3.ArticuloID.HasValue, dbo_ArticulosFichasCondiciones3.ArticuloID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ProveedorID", If(dbo_ArticulosFichasCondiciones3.ProveedorID.HasValue, dbo_ArticulosFichasCondiciones3.ProveedorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FormaPagoID", If(dbo_ArticulosFichasCondiciones3.FormaPagoID.HasValue, dbo_ArticulosFichasCondiciones3.FormaPagoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@PlazoPagoID", If(dbo_ArticulosFichasCondiciones3.PlazoPagoID.HasValue, dbo_ArticulosFichasCondiciones3.PlazoPagoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@UnidadID", If(dbo_ArticulosFichasCondiciones3.UnidadID.HasValue, dbo_ArticulosFichasCondiciones3.UnidadID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", dbo_ArticulosFichasCondiciones3.Descripcion)
        insertCommand.Parameters.AddWithValue("@EurosUnidad", dbo_ArticulosFichasCondiciones3.EurosUnidad)
        insertCommand.Parameters.AddWithValue("@CantidadMinima", If(dbo_ArticulosFichasCondiciones3.CantidadMinima.HasValue, dbo_ArticulosFichasCondiciones3.CantidadMinima, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@PrecioAnterior", If(dbo_ArticulosFichasCondiciones3.PrecioAnterior.HasValue, dbo_ArticulosFichasCondiciones3.PrecioAnterior, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Incremento", If(dbo_ArticulosFichasCondiciones3.Incremento.HasValue, dbo_ArticulosFichasCondiciones3.Incremento, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Ruta", dbo_ArticulosFichasCondiciones3.Ruta)
        insertCommand.Parameters.AddWithValue("@FechaInicio", If(dbo_ArticulosFichasCondiciones3.FechaInicio.HasValue, dbo_ArticulosFichasCondiciones3.FechaInicio, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaFinal", If(dbo_ArticulosFichasCondiciones3.FechaFinal.HasValue, dbo_ArticulosFichasCondiciones3.FechaFinal, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Vigente", dbo_ArticulosFichasCondiciones3.Vigente)
        insertCommand.Parameters.AddWithValue("@CosteTransporte", If(dbo_ArticulosFichasCondiciones3.CosteTransporte.HasValue, dbo_ArticulosFichasCondiciones3.CosteTransporte, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CosteEmbalaje", If(dbo_ArticulosFichasCondiciones3.CosteEmbalaje.HasValue, dbo_ArticulosFichasCondiciones3.CosteEmbalaje, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CosteDevolucionEmbalaje", If(dbo_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje.HasValue, dbo_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@AbonoDevolucionEmbalaje", If(dbo_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje.HasValue, dbo_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CosteMolde", If(dbo_ArticulosFichasCondiciones3.CosteMolde.HasValue, dbo_ArticulosFichasCondiciones3.CosteMolde, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CosteAmortizacionMoldeUnidad", If(dbo_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad.HasValue, dbo_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Observaciones", dbo_ArticulosFichasCondiciones3.Observaciones)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_ArticulosFichasCondiciones3.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_ArticulosFichasCondiciones3.UsuarioModificacion)
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
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ArticulosFichasCondiciones3Update(ByVal newDBO_ArticulosFichasCondiciones3 As DBO_ArticulosFichasCondiciones3, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[ArticulosFichasCondiciones3Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@NewArticuloID", If(newDBO_ArticulosFichasCondiciones3.ArticuloID.HasValue, newDBO_ArticulosFichasCondiciones3.ArticuloID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewProveedorID", If(newDBO_ArticulosFichasCondiciones3.ProveedorID.HasValue, newDBO_ArticulosFichasCondiciones3.ProveedorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFormaPagoID", If(newDBO_ArticulosFichasCondiciones3.FormaPagoID.HasValue, newDBO_ArticulosFichasCondiciones3.FormaPagoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewPlazoPagoID", If(newDBO_ArticulosFichasCondiciones3.PlazoPagoID.HasValue, newDBO_ArticulosFichasCondiciones3.PlazoPagoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewUnidadID", If(newDBO_ArticulosFichasCondiciones3.UnidadID.HasValue, newDBO_ArticulosFichasCondiciones3.UnidadID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", newDBO_ArticulosFichasCondiciones3.Descripcion)
        updateCommand.Parameters.AddWithValue("@NewEurosUnidad", newDBO_ArticulosFichasCondiciones3.EurosUnidad)
        updateCommand.Parameters.AddWithValue("@NewCantidadMinima", If(newDBO_ArticulosFichasCondiciones3.CantidadMinima.HasValue, newDBO_ArticulosFichasCondiciones3.CantidadMinima, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewPrecioAnterior", If(newDBO_ArticulosFichasCondiciones3.PrecioAnterior.HasValue, newDBO_ArticulosFichasCondiciones3.PrecioAnterior, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewIncremento", If(newDBO_ArticulosFichasCondiciones3.Incremento.HasValue, newDBO_ArticulosFichasCondiciones3.Incremento, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewRuta", newDBO_ArticulosFichasCondiciones3.Ruta)
        updateCommand.Parameters.AddWithValue("@NewFechaInicio", If(newDBO_ArticulosFichasCondiciones3.FechaInicio.HasValue, newDBO_ArticulosFichasCondiciones3.FechaInicio, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaFinal", If(newDBO_ArticulosFichasCondiciones3.FechaFinal.HasValue, newDBO_ArticulosFichasCondiciones3.FechaFinal, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewVigente", newDBO_ArticulosFichasCondiciones3.Vigente)
        updateCommand.Parameters.AddWithValue("@NewCosteTransporte", If(newDBO_ArticulosFichasCondiciones3.CosteTransporte.HasValue, newDBO_ArticulosFichasCondiciones3.CosteTransporte, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCosteEmbalaje", If(newDBO_ArticulosFichasCondiciones3.CosteEmbalaje.HasValue, newDBO_ArticulosFichasCondiciones3.CosteEmbalaje, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCosteDevolucionEmbalaje", If(newDBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje.HasValue, newDBO_ArticulosFichasCondiciones3.CosteDevolucionEmbalaje, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewAbonoDevolucionEmbalaje", If(newDBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje.HasValue, newDBO_ArticulosFichasCondiciones3.AbonoDevolucionEmbalaje, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCosteMolde", If(newDBO_ArticulosFichasCondiciones3.CosteMolde.HasValue, newDBO_ArticulosFichasCondiciones3.CosteMolde, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCosteAmortizacionMoldeUnidad", If(newDBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad.HasValue, newDBO_ArticulosFichasCondiciones3.CosteAmortizacionMoldeUnidad, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewObservaciones", newDBO_ArticulosFichasCondiciones3.Observaciones)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_ArticulosFichasCondiciones3.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_ArticulosFichasCondiciones3.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldArticuloFichaCondicionID", newDBO_ArticulosFichasCondiciones3.ArticuloFichaCondicionID)
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
            MessageBox.Show("Error en UpdateArticulosFichasCondiciones3" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function ArticulosFichasCondiciones3Delete(ByVal ArticuloFichaCondicionID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[ArticulosFichasCondiciones3Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        deleteCommand.Parameters.AddWithValue("@OldArticuloFichaCondicionID", ArticuloFichaCondicionID)
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

    Public Sub GrabarArticulosFichasCondiciones3(ByVal dbo_ArticulosFichasCondiciones3 As DBO_ArticulosFichasCondiciones3, ByRef dtb As BasesParaCompatibilidad.DataBase)
        If dbo_ArticulosFichasCondiciones3.ArticuloFichaCondicionID = 0 Then
            ArticulosFichasCondiciones3Insert(dbo_ArticulosFichasCondiciones3, dtb)
        Else
            ArticulosFichasCondiciones3Update(dbo_ArticulosFichasCondiciones3, dtb)
        End If
    End Sub

End Class
