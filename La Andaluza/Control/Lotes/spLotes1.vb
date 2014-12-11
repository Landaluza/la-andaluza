

Class spLotes1
    inherits BasesParaCompatibilidad.sp
    Public Sub New()
        MyBase.New("[dbo].[Lotes1Select]", "[dbo].[Lotes1Insert]", "[dbo].[Lotes1Update]", _
                   "[dbo].[Lotes1Delete]", "OrdenesEnvasados2SelectDgv", String.Empty)
    End Sub
    Public Function Select_Record(ByVal LoteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Lotes1
        dtb.Conectar()
        Dim DBO_Lotes1 As New DBO_Lotes1

        Dim selectProcedure As String = "[dbo].[Lotes1Select]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@LoteID", LoteID)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
            If reader.Read Then

                DBO_Lotes1.LoteID = If(reader("LoteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteID")))
                DBO_Lotes1.Referencia = If(reader("Referencia") Is Convert.DBNull, 0, Convert.ToInt32(reader("Referencia")))
                DBO_Lotes1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_Lotes1.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_Lotes1.CantidadRestante = System.Convert.ToDouble(If(reader("CantidadRestante") Is Convert.DBNull, 0, reader("CantidadRestante")))
                DBO_Lotes1.Observacion = If(reader("Observacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observacion")))
                DBO_Lotes1.LoteProveedor = If(reader("LoteProveedor") Is Convert.DBNull, String.Empty, Convert.ToString(reader("LoteProveedor")))
                DBO_Lotes1.Botellas = If(reader("Botellas") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Botellas")))
                DBO_Lotes1.CantidadID = If(reader("CantidadID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CantidadID")))
                DBO_Lotes1.MedidaID = If(reader("MedidaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MedidaID")))
                DBO_Lotes1.EspecificacionID = If(reader("EspecificacionID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EspecificacionID")))
                DBO_Lotes1.TipoLoteID = If(reader("TipoLoteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoLoteID")))
                DBO_Lotes1.TipoProductoID = If(reader("TipoProductoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoProductoID")))
                DBO_Lotes1.CorredorID = If(reader("CorredorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CorredorID")))
                DBO_Lotes1.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_Lotes1.LoteConjuntoCompraID = If(reader("LoteConjuntoCompraID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteConjuntoCompraID")))
                DBO_Lotes1.CodigoLote = If(reader("CodigoLote") Is Convert.DBNull, String.Empty, Convert.ToString(reader("CodigoLote")))
                DBO_Lotes1.DepositoID = If(reader("DepositoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("DepositoID")))
                DBO_Lotes1.DepositoPrevioID = If(reader("DepositoPrevioID") Is Convert.DBNull, 0, Convert.ToInt32(reader("DepositoPrevioID")))
                DBO_Lotes1.Revisar = If(reader("Revisar") Is Convert.DBNull, False, Convert.ToBoolean(reader("Revisar")))
                DBO_Lotes1.RecipienteSalidaID = If(reader("RecipienteSalidaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("RecipienteSalidaID")))
                DBO_Lotes1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Lotes1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_Lotes1.Identificador = If(reader("Identificador") Is Convert.DBNull, "", Convert.ToString(reader("Identificador")))
                If Convert.IsDBNull(reader("Caducidad")) Then
                    DBO_Lotes1.Caducidad = Nothing
                Else
                    DBO_Lotes1.Caducidad = CType(reader("Caducidad"), Date)
                End If


            Else
                DBO_Lotes1 = Nothing
            End If

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try

        Return DBO_Lotes1
    End Function

    Public Function Select_Record(ByVal codigoLote As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Lotes1
        dtb.Conectar()
        Dim DBO_Lotes1 As New DBO_Lotes1

        Dim selectProcedure As String = "[dbo].[Lotes1SelectPorCodigoLote]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        selectCommand.CommandType = CommandType.StoredProcedure

        selectCommand.Parameters.AddWithValue("@codigoLote", codigoLote)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.Read Then

                DBO_Lotes1.LoteID = If(reader("LoteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteID")))
                DBO_Lotes1.Referencia = If(reader("Referencia") Is Convert.DBNull, 0, Convert.ToInt32(reader("Referencia")))
                DBO_Lotes1.Descripcion = If(reader("Descripcion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Descripcion")))
                DBO_Lotes1.Fecha = If(reader("Fecha") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("Fecha")))
                DBO_Lotes1.CantidadRestante = System.Convert.ToDouble(If(reader("CantidadRestante") Is Convert.DBNull, 0, reader("CantidadRestante")))
                DBO_Lotes1.Observacion = If(reader("Observacion") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Observacion")))
                DBO_Lotes1.LoteProveedor = If(reader("LoteProveedor") Is Convert.DBNull, String.Empty, Convert.ToString(reader("LoteProveedor")))
                DBO_Lotes1.Botellas = If(reader("Botellas") Is Convert.DBNull, String.Empty, Convert.ToString(reader("Botellas")))
                DBO_Lotes1.CantidadID = If(reader("CantidadID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CantidadID")))
                DBO_Lotes1.MedidaID = If(reader("MedidaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("MedidaID")))
                DBO_Lotes1.EspecificacionID = If(reader("EspecificacionID") Is Convert.DBNull, 0, Convert.ToInt32(reader("EspecificacionID")))
                DBO_Lotes1.TipoLoteID = If(reader("TipoLoteID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoLoteID")))
                DBO_Lotes1.TipoProductoID = If(reader("TipoProductoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoProductoID")))
                DBO_Lotes1.CorredorID = If(reader("CorredorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("CorredorID")))
                DBO_Lotes1.ProveedorID = If(reader("ProveedorID") Is Convert.DBNull, 0, Convert.ToInt32(reader("ProveedorID")))
                DBO_Lotes1.LoteConjuntoCompraID = If(reader("LoteConjuntoCompraID") Is Convert.DBNull, 0, Convert.ToInt32(reader("LoteConjuntoCompraID")))
                DBO_Lotes1.CodigoLote = If(reader("CodigoLote") Is Convert.DBNull, String.Empty, Convert.ToString(reader("CodigoLote")))
                DBO_Lotes1.DepositoID = If(reader("DepositoID") Is Convert.DBNull, 0, Convert.ToInt32(reader("DepositoID")))
                DBO_Lotes1.DepositoPrevioID = If(reader("DepositoPrevioID") Is Convert.DBNull, 0, Convert.ToInt32(reader("DepositoPrevioID")))
                DBO_Lotes1.Revisar = If(reader("Revisar") Is Convert.DBNull, False, Convert.ToBoolean(reader("Revisar")))
                DBO_Lotes1.RecipienteSalidaID = If(reader("RecipienteSalidaID") Is Convert.DBNull, 0, Convert.ToInt32(reader("RecipienteSalidaID")))
                DBO_Lotes1.FechaModificacion = If(reader("FechaModificacion") Is Convert.DBNull, System.DateTime.Now.Date, CDate(reader("FechaModificacion")))
                DBO_Lotes1.UsuarioModificacion = If(reader("UsuarioModificacion") Is Convert.DBNull, 0, Convert.ToInt32(reader("UsuarioModificacion")))
                DBO_Lotes1.Identificador = If(reader("Identificador") Is Convert.DBNull, "", Convert.ToString(reader("Identificador")))
                If Convert.IsDBNull(reader("Caducidad")) Then
                    DBO_Lotes1.Caducidad = Nothing
                Else
                    DBO_Lotes1.Caducidad = CType(reader("Caducidad"), Date)
                End If

            Else
                DBO_Lotes1 = Nothing
            End If

            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            Throw
        Finally
            dtb.Desconectar()
        End Try

        Return DBO_Lotes1
    End Function

    Public Function Lotes1Insert(ByVal dbo_Lotes1 As DBO_Lotes1, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim insertProcedure As String = "[dbo].[Lotes1Insert]"
        Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
        insertCommand.CommandType = CommandType.StoredProcedure


        insertCommand.Parameters.AddWithValue("@Referencia", If(dbo_Lotes1.Referencia.HasValue, dbo_Lotes1.Referencia, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Descripcion", If(String.IsNullOrEmpty(dbo_Lotes1.Descripcion), Convert.DBNull, dbo_Lotes1.Descripcion))
        insertCommand.Parameters.AddWithValue("@Fecha", If(dbo_Lotes1.Fecha.HasValue, dbo_Lotes1.Fecha, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CantidadRestante", dbo_Lotes1.CantidadRestante)
        insertCommand.Parameters.AddWithValue("@Observacion", If(String.IsNullOrEmpty(dbo_Lotes1.Observacion), Convert.DBNull, dbo_Lotes1.Observacion))
        insertCommand.Parameters.AddWithValue("@LoteProveedor", If(String.IsNullOrEmpty(dbo_Lotes1.LoteProveedor), Convert.DBNull, dbo_Lotes1.LoteProveedor))
        insertCommand.Parameters.AddWithValue("@Botellas", If(String.IsNullOrEmpty(dbo_Lotes1.Botellas), Convert.DBNull, dbo_Lotes1.Botellas))
        insertCommand.Parameters.AddWithValue("@CantidadID", If(dbo_Lotes1.CantidadID.HasValue, dbo_Lotes1.CantidadID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@MedidaID", If(dbo_Lotes1.MedidaID.HasValue, dbo_Lotes1.MedidaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@EspecificacionID", If(dbo_Lotes1.EspecificacionID.HasValue, dbo_Lotes1.EspecificacionID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@TipoLoteID", If(dbo_Lotes1.TipoLoteID.HasValue, dbo_Lotes1.TipoLoteID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@TipoProductoID", If(dbo_Lotes1.TipoProductoID.HasValue, dbo_Lotes1.TipoProductoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CorredorID", If(dbo_Lotes1.CorredorID.HasValue, dbo_Lotes1.CorredorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@ProveedorID", If(dbo_Lotes1.ProveedorID.HasValue, dbo_Lotes1.ProveedorID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@LoteConjuntoCompraID", If(dbo_Lotes1.LoteConjuntoCompraID.HasValue, dbo_Lotes1.LoteConjuntoCompraID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@CodigoLote", dbo_Lotes1.CodigoLote)
        insertCommand.Parameters.AddWithValue("@DepositoID", If(dbo_Lotes1.DepositoID.HasValue, dbo_Lotes1.DepositoID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@DepositoPrevioID", If(dbo_Lotes1.DepositoPrevioID.HasValue, dbo_Lotes1.DepositoPrevioID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@Revisar", If(dbo_Lotes1.Revisar.HasValue, dbo_Lotes1.Revisar, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@RecipienteSalidaID", If(dbo_Lotes1.RecipienteSalidaID.HasValue, dbo_Lotes1.RecipienteSalidaID, Convert.DBNull))
        insertCommand.Parameters.AddWithValue("@FechaModificacion", dbo_Lotes1.FechaModificacion)
        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", dbo_Lotes1.UsuarioModificacion)
        insertCommand.Parameters.AddWithValue("@Identificador", dbo_Lotes1.Identificador)
        insertCommand.Parameters.AddWithValue("@Caducidad", If(dbo_Lotes1.Caducidad.Value = Nothing, Convert.DBNull, dbo_Lotes1.Caducidad))

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

    Public Function Lotes1Update(ByVal newDBO_Lotes1 As DBO_Lotes1, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[Lotes1Update]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure

        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewReferencia", If(newDBO_Lotes1.Referencia.HasValue, newDBO_Lotes1.Referencia, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDescripcion", If(String.IsNullOrEmpty(newDBO_Lotes1.Descripcion), Convert.DBNull, newDBO_Lotes1.Descripcion))
        updateCommand.Parameters.AddWithValue("@NewFecha", If(newDBO_Lotes1.Fecha.HasValue, newDBO_Lotes1.Fecha, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCantidadRestante", newDBO_Lotes1.CantidadRestante)
        updateCommand.Parameters.AddWithValue("@NewObservacion", If(String.IsNullOrEmpty(newDBO_Lotes1.Observacion), Convert.DBNull, newDBO_Lotes1.Observacion))
        updateCommand.Parameters.AddWithValue("@NewLoteProveedor", If(String.IsNullOrEmpty(newDBO_Lotes1.LoteProveedor), Convert.DBNull, newDBO_Lotes1.LoteProveedor))
        updateCommand.Parameters.AddWithValue("@NewBotellas", If(String.IsNullOrEmpty(newDBO_Lotes1.Botellas), Convert.DBNull, newDBO_Lotes1.Botellas))
        updateCommand.Parameters.AddWithValue("@NewCantidadID", If(newDBO_Lotes1.CantidadID.HasValue, newDBO_Lotes1.CantidadID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewMedidaID", If(newDBO_Lotes1.MedidaID.HasValue, newDBO_Lotes1.MedidaID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewEspecificacionID", If(newDBO_Lotes1.EspecificacionID.HasValue, newDBO_Lotes1.EspecificacionID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewTipoLoteID", If(newDBO_Lotes1.TipoLoteID.HasValue, newDBO_Lotes1.TipoLoteID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewTipoProductoID", If(newDBO_Lotes1.TipoProductoID.HasValue, newDBO_Lotes1.TipoProductoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCorredorID", If(newDBO_Lotes1.CorredorID.HasValue, newDBO_Lotes1.CorredorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewProveedorID", If(newDBO_Lotes1.ProveedorID.HasValue, newDBO_Lotes1.ProveedorID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewLoteConjuntoCompraID", If(newDBO_Lotes1.LoteConjuntoCompraID.HasValue, newDBO_Lotes1.LoteConjuntoCompraID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewCodigoLote", newDBO_Lotes1.CodigoLote)
        updateCommand.Parameters.AddWithValue("@NewDepositoID", If(newDBO_Lotes1.DepositoID.HasValue, newDBO_Lotes1.DepositoID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewDepositoPrevioID", If(newDBO_Lotes1.DepositoPrevioID.HasValue, newDBO_Lotes1.DepositoPrevioID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewRevisar", If(newDBO_Lotes1.Revisar.HasValue, newDBO_Lotes1.Revisar, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewRecipienteSalidaID", If(newDBO_Lotes1.RecipienteSalidaID.HasValue, newDBO_Lotes1.RecipienteSalidaID, Convert.DBNull))
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", newDBO_Lotes1.FechaModificacion)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", newDBO_Lotes1.UsuarioModificacion)
        updateCommand.Parameters.AddWithValue("@OldLoteID", newDBO_Lotes1.LoteID)
        updateCommand.Parameters.AddWithValue("@Identificador", newDBO_Lotes1.Identificador)
        updateCommand.Parameters.AddWithValue("@Caducidad", If(newDBO_Lotes1.Caducidad.Value = Nothing, Convert.DBNull, newDBO_Lotes1.Caducidad))
        '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en UpdateLotes1" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function


    Public Function Lotes1UpdateCantidadRestante(ByVal NewLoteID As Integer, ByVal NewCantidadRestante As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim updateProcedure As String = "[dbo].[Lotes1UpdateCantidadRestante]"
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure

        '<Tag=[Three][Start]> -- please do not remove this line
        updateCommand.Parameters.AddWithValue("@NewCantidadRestante", NewCantidadRestante)
        updateCommand.Parameters.AddWithValue("@NewFechaModificacion", System.DateTime.Now)
        updateCommand.Parameters.AddWithValue("@NewUsuarioModificacion", BasesParaCompatibilidad.Config.User)
        updateCommand.Parameters.AddWithValue("@OldLoteID", NewLoteID)
        '<Tag=[Three][End]> -- please do not remove this line
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
            MessageBox.Show("Error en Lotes1UpdateCantidadRestante" & Environment.NewLine & Environment.NewLine & ex.Message, Convert.ToString(ex.GetType))
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function


    Public Function Lotes1Delete(ByVal LoteID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()

        Dim deleteProcedure As String = "[dbo].[Lotes1Delete]"
        Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.comando(deleteProcedure)
        deleteCommand.CommandType = CommandType.StoredProcedure
        '<Tag=[Four][Start]> -- please do not remove this line
        deleteCommand.Parameters.AddWithValue("@OldLoteID", LoteID)
        '<Tag=[Four][End]> -- please do not remove this line
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

    Public Function GrabarLotes1(ByVal dbo_Lotes1 As DBO_Lotes1, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dbo_Lotes1.FechaModificacion = System.DateTime.Now.date
        dbo_Lotes1.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        If dbo_Lotes1.LoteID = 0 Then
            Return Lotes1Insert(dbo_Lotes1, dtb)
        Else
            Return Lotes1Update(dbo_Lotes1, dtb)
        End If
    End Function

    Public Function CountLotesTerminadosPorTipoProducto(ByVal m_Producto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("LotesByTipoProducto @pro, @otro")
        dtb.AñadirParametroConsulta("@pro", m_Producto)
        dtb.AñadirParametroConsulta("@otro", 0)
        Return dtb.Consultar().Rows.Count
    End Function

    Public Function DgvFillLotesTodosPorTipoProducto(ByVal m_Producto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As System.Data.DataTable
        dtb.PrepararConsulta("LotesAllByTipoProducto @pro")
        dtb.AñadirParametroConsulta("@pro", m_Producto)
        Return dtb.Consultar()
    End Function

    Public Function DgvFillLotesTerminadosPorTipoProducto(ByVal m_Producto As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As System.Data.DataTable
        dtb.PrepararConsulta("LotesByTipoProducto @pro, @otro")
        dtb.AñadirParametroConsulta("@pro", m_Producto)
        dtb.AñadirParametroConsulta("@otro", 0)
        Return dtb.Consultar
    End Function

    Public Function DgvFillLotesTerminadosPorTipoProductoYLote(ByVal m_Producto As Integer, ByVal LoteId As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As System.Data.DataTable
        dtb.PrepararConsulta("LotesByTipoProducto @pro, @lote")
        dtb.AñadirParametroConsulta("@pro", m_Producto)
        dtb.AñadirParametroConsulta("@lote", LoteId)
        Return dtb.Consultar()
    End Function

    Public Function calcularDensidad(ByVal m_LoteID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Double
        dtb.PrepararConsulta("LotesSelectDensidadByLoteID @id")
        dtb.AñadirParametroConsulta("@id", m_LoteID)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Function devolverproximocodigoLote(ByVal codigoSinLetra As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As String
        Dim codigo As String
        Dim letra As Char
        Dim letraAsc As Integer
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[LotesSelectUltimoCodigo]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)

        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@codigoLote", codigoSinLetra)

        Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
        If reader.Read Then
            codigo = (If(reader("codigoLote") Is Convert.DBNull, codigoSinLetra, reader("codigoLote"))).ToString
        Else
            codigo = codigoSinLetra + "0"
        End If

        reader.Close()
        dtb.Desconectar()

        letra = codigo.Substring(14, 1)
        letraAsc = Asc(letra) + 1

        If letraAsc = 58 Then
            letraAsc = 64
        ElseIf letraAsc = 90 Then
            letraAsc = 97
        End If

        letra = ChrW(letraAsc)
        codigo = codigo.Substring(0, 14) + letra

        Return codigo
    End Function

    Public Function GuardarLoteDiferencias(ByVal m_dbo As DBO_Lotes1, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim retorno As Boolean = True
        Dim loteProcedencia As Integer = m_dbo.LoteID
        Dim deposito As Integer
        Dim spCompuestoPor As New spCompuestoPor
        Dim spMovimientos1 As New spMovimientos1
        'Dim codigoLote As String = m_dbo.CodigoLote
        Dim cantidad As String = m_dbo.CantidadRestante
        Dim m_compuestoPor As New DBO_CompuestoPor
        Dim m_movimiento As New DBO_Movimientos1
        Dim m_lote As DBO_Lotes1 = Me.Select_Record(m_dbo.LoteID, dtb)


        m_dbo.CodigoLote = GenerarCodigoDiferencias(m_dbo.Fecha, m_dbo.CodigoLote.Substring(8, 3))

        If existeLote(dtb, m_dbo.CodigoLote) Then
            'seleccionar registro lote
            'update cantidad = cantidad+nuevacantidad
            dtb.PrepararConsulta("select LoteID, cantidadRestante from Lotes where codigoLote= @cod")
            dtb.AñadirParametroConsulta("@cod", m_dbo.CodigoLote)
            Dim tabla As DataTable = dtb.Consultar
            Dim cantidadOriginal As Integer = tabla.Rows(0).Item(1)
            m_dbo.LoteID = tabla.Rows(0).Item(0)

            Me.Lotes1UpdateCantidadRestante(m_dbo.LoteID, cantidadOriginal + Convert.ToInt32(cantidad), dtb)

        Else
            'insertar lote
            'insertar compuesto por            
            m_dbo.CantidadRestante = cantidad
            m_dbo.TipoLoteID = 42
            m_dbo.TipoProductoID = m_lote.TipoProductoID
            m_dbo.LoteID = Nothing
            m_dbo.UsuarioModificacion = BasesParaCompatibilidad.Config.User
            m_dbo.FechaModificacion = Today.Date

            retorno = retorno And Me.Lotes1Insert(m_dbo, dtb)
            'm_dbo = spLotes1.Select_Record(codigoLote,dtb)
            dtb.PrepararConsulta("select max(LoteID) from Lotes")
            m_dbo.LoteID = dtb.Consultar().Rows(0).Item(0)




        End If

        deposito = m_lote.DepositoID
        m_movimiento.Cantidad = cantidad
        m_movimiento.ProcesoID = 11
        m_movimiento.Fecha = Today
        m_movimiento.SaleDepositoID = deposito
        m_movimiento.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_movimiento.FechaModificacion = Today.Date

        retorno = retorno And spMovimientos1.Movimientos1Insert(m_movimiento, dtb)

        m_compuestoPor.Cantidad = cantidad
        m_compuestoPor.LotePartida = loteProcedencia
        m_compuestoPor.LoteFinal = m_dbo.LoteID
        dtb.PrepararConsulta("select max(MovimientoID) from Movimientos")
        m_compuestoPor.MovimientoID = dtb.Consultar().Rows(0).Item(0)
        m_compuestoPor.UsuarioModificacion = BasesParaCompatibilidad.Config.User
        m_compuestoPor.FechaModificacion = Today.Date
        retorno = retorno And spCompuestoPor.CompuestoPorInsert(m_compuestoPor, dtb)

        Me.Lotes1UpdateCantidadRestante(loteProcedencia, 0, dtb)
        Return retorno
    End Function


    Public Function existeLote(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal lote As String) As Boolean
        dtb.PrepararConsulta("select count(*) from Lotes where codigoLote= @cod")
        dtb.AñadirParametroConsulta("@cod", lote)
        Dim tabla As DataTable = dtb.Consultar
        Return If(tabla.Rows(0).Item(0) > 0, True, False)
        'dtb.Conectar 
        'Dim cuenta As Integer
        'Dim connection As System.Data.SqlClient.SqlConnection  = BasesParaCompatibilidad.BD.Cnx
        'Dim selectProcedure As String = "[dbo].[Lotes1SelectCountByCodigoLote]"
        'Dim selectCommand As  System.Data.SqlClient.SqlCommand= dtb.comando(selectProcedure)
        'selectCommand.CommandType = CommandType.StoredProcedure
        '
        'selectCommand.Parameters.AddWithValue("@codigoLote", lote)


        'Dim reader As System.Data.SqlClient.SqlDataReader  = selectCommand.ExecuteReader(CommandBehavior.SingleRow)
        'If reader.Read Then
        '    cuenta = if(reader("cuenta") Is Convert.DBNull, 0, reader("cuenta")))
        'Else
        '    Throw New Exception("No se pudo leer los datos")
        'End If

        'reader.Close()
        'dtb.Desconectar 

        'Return if(cuenta > 0, True, False)
    End Function

    Public Function GenerarCodigoDiferencias(ByVal m_fecha As Date, ByVal m_Articulo As String) As String
        Dim dia, mes As String
        'If m_fecha.Day < 10 Then
        '    dia = "0" & m_fecha.Day
        'Else
        '    dia = m_fecha.Day
        'End If
        dia = "01"
        If m_fecha.Month < 10 Then
            mes = "0" & m_fecha.Month
        Else
            mes = m_fecha.Month
        End If

        Return m_fecha.Year & mes & dia & m_Articulo & "Dif" & "1"
    End Function

    Public Function ActualizarCantidad(ByVal loteId As Integer, ByVal p2 As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update lotes set cantidadrestante = @can where loteID = @id")
        dtb.AñadirParametroConsulta("@can", p2)
        dtb.AñadirParametroConsulta("@id", loteId)
        Return dtb.Execute
    End Function

    Public Function comprobar(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal dbo As DBO_Lotes1) As Boolean
        Dim dbo_actual As DBO_Lotes1 = Me.Select_Record(dbo.LoteID, dtb)


        If dbo_actual.LoteID <> dbo.LoteID Then Return False
        If dbo_actual.Referencia <> dbo.Referencia Then Return False
        If dbo_actual.Descripcion <> dbo.Descripcion Then Return False
        If dbo_actual.Fecha <> dbo.Fecha Then Return False
        If dbo_actual.CantidadRestante <> dbo.CantidadRestante Then Return False
        If dbo_actual.Observacion <> dbo.Observacion Then Return False
        If dbo_actual.LoteProveedor <> dbo.LoteProveedor Then Return False
        If dbo_actual.Botellas <> dbo.Botellas Then Return False
        If dbo_actual.CantidadID <> dbo.CantidadID Then Return False
        If dbo_actual.MedidaID <> dbo.MedidaID Then Return False
        If dbo_actual.EspecificacionID <> dbo.EspecificacionID Then Return False
        If dbo_actual.TipoLoteID <> dbo.TipoLoteID Then Return False
        If dbo_actual.TipoProductoID <> dbo.TipoProductoID Then Return False
        If dbo_actual.CorredorID <> dbo.CorredorID Then Return False
        If dbo_actual.ProveedorID <> dbo.ProveedorID Then Return False
        If dbo_actual.LoteConjuntoCompraID <> dbo.LoteConjuntoCompraID Then Return False
        If dbo_actual.CodigoLote <> dbo.CodigoLote Then Return False
        If dbo_actual.DepositoID <> dbo.DepositoID Then Return False
        If dbo_actual.DepositoPrevioID <> dbo.DepositoPrevioID Then Return False
        If dbo_actual.Revisar <> dbo.Revisar Then Return False
        If dbo_actual.RecipienteSalidaID <> dbo.RecipienteSalidaID Then Return False
        If dbo_actual.Identificador <> dbo.Identificador Then Return False
        If dbo_actual.Caducidad <> dbo.Caducidad Then Return False


        Return True

    End Function
End Class
