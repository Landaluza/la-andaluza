

Class spMonodosis
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("[dbo].[monodosisSelect]", "[dbo].[MonodosisInsert]", "[dbo].[MonodosisUpdate]", _
                   String.Empty, String.Empty, String.Empty)
    End Sub

    Public Function guardarMonodosis(ByVal dbo_Monodosis As DBO_Monodosis, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Dim insertProcedure As String = "[dbo].[MonodosisInsert]"

        Try
            Dim insertCommand As System.Data.SqlClient.SqlCommand = dtb.comando(insertProcedure)
            insertCommand.CommandType = CommandType.StoredProcedure


            insertCommand.Parameters.AddWithValue("@ArticuloID", dbo_Monodosis.ArticuloId)
            insertCommand.Parameters.AddWithValue("@tipoFormatoID", If(dbo_Monodosis.TipoFormatoId = 0, Convert.DBNull, dbo_Monodosis.TipoFormatoId))
            insertCommand.Parameters.AddWithValue("@id_marca", dbo_Monodosis.MarcaId)
            insertCommand.Parameters.AddWithValue("@id_Palet", If(dbo_Monodosis.Palet_NO_Conforme_ID = 0, Convert.DBNull, dbo_Monodosis.Palet_NO_Conforme_ID))
            insertCommand.Parameters.AddWithValue("@id_Producto", dbo_Monodosis.ProductoId)
            insertCommand.Parameters.AddWithValue("@id_Caja", dbo_Monodosis.CajaId)
            insertCommand.Parameters.AddWithValue("@cantidad", dbo_Monodosis.CantidadPorMatricula)
            insertCommand.Parameters.AddWithValue("@ean", If(dbo_Monodosis.Ean13 = "0" Or dbo_Monodosis.Ean13 = String.Empty, Convert.DBNull, dbo_Monodosis.Ean13))

            insertCommand.ExecuteNonQuery()

            Return True

        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function updateMonodosis(ByVal dbo_Monodosis As DBO_Monodosis, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.Conectar()
        Dim insertProcedure As String = "[dbo].[MonodosisUpdate]"

        Try
            Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando(insertProcedure)
            updateCommand.CommandType = CommandType.StoredProcedure


            updateCommand.Parameters.AddWithValue("@ArticuloID", dbo_Monodosis.ArticuloId)
            updateCommand.Parameters.AddWithValue("@tipoFormatoID", dbo_Monodosis.TipoFormatoId)
            updateCommand.Parameters.AddWithValue("@id_marca", dbo_Monodosis.MarcaId)
            updateCommand.Parameters.AddWithValue("@id_Palet", If(dbo_Monodosis.Palet_NO_Conforme_ID = 0, Convert.DBNull, dbo_Monodosis.Palet_NO_Conforme_ID))
            updateCommand.Parameters.AddWithValue("@id_Producto", dbo_Monodosis.ProductoId)
            updateCommand.Parameters.AddWithValue("@id_Caja", dbo_Monodosis.CajaId)
            updateCommand.Parameters.AddWithValue("@cantidad", dbo_Monodosis.CantidadPorMatricula)
            updateCommand.Parameters.AddWithValue("@ean", If(dbo_Monodosis.Ean13 = "0" Or dbo_Monodosis.Ean13 = String.Empty, Convert.DBNull, dbo_Monodosis.Ean13))

            updateCommand.ExecuteNonQuery()

            Return True

        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function

    Function selectRecord(p1 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Monodosis
        dtb.Conectar()
        Dim DBO_monodosis As New DBO_Monodosis

        Dim selectProcedure As String = "[dbo].[monodosisSelect]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)

        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@articuloID", p1)

        Try
            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader(CommandBehavior.SingleRow)

            If reader.Read Then
                DBO_monodosis.ArticuloId = If(reader("ArticuloId") Is Convert.DBNull, 0, Convert.ToInt32(reader("ArticuloId")))
                DBO_monodosis.TipoFormatoId = If(reader("TipoFormatoId") Is Convert.DBNull, 0, Convert.ToInt32(reader("TipoFormatoId")))
                DBO_monodosis.MarcaId = If(reader("id_marca") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_marca")))
                DBO_monodosis.Palet_NO_Conforme_ID = If(reader("id_PaletProducidoNoConforme") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_PaletProducidoNoConforme")))
                DBO_monodosis.ProductoId = If(reader("id_Producto") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_Producto")))
                DBO_monodosis.CajaId = If(reader("id_Caja") Is Convert.DBNull, 0, Convert.ToInt32(reader("id_Caja")))
                DBO_monodosis.Ean13 = If(reader("ean") Is Convert.DBNull, "0", Convert.ToString(reader("ean")))
                DBO_monodosis.CantidadPorMatricula = If(reader("cantidad") Is Convert.DBNull, "0", Convert.ToString(reader("cantidad")))
            Else
                DBO_monodosis = Nothing
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
            DBO_monodosis = Nothing
        Finally
            dtb.Desconectar()
        End Try

        Return DBO_monodosis
    End Function

    Function limpiarDatos(ByRef dtb As BasesParaCompatibilidad.DataBase, id As Integer) As Boolean
        Try
            dtb.PrepararConsulta("delete from monodosis where id_articuloprimario= @id")
            dtb.AñadirParametroConsulta("@id", id)

            If Not dtb.Execute Then
                Return False
            End If

            dtb.PrepararConsulta("delete from doypack where id_articuloprimario= @id")
            dtb.AñadirParametroConsulta("@id", id)
            Return dtb.Execute
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function selectDgv(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable

        dtb.PrepararConsulta("MonodosisSelectDetallado")
        Return dtb.Consultar
    End Function

    Function esMonodosis(ByVal p1 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dt As DataTable

        dtb.PrepararConsulta("Select count(*) from monodosis where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        dt = dtb.Consultar

        If dt.Rows(0).Item(0) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

End Class
