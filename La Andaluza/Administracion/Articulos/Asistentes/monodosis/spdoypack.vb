﻿

Class spdoypack
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("doypackSelectById", "[dbo].[doypackInsert]", "[dbo].[doypackUpdate]", _
            "[dbo].[doypackDelete]", String.Empty, String.Empty)
    End Sub
    Public Function FormatoPorArticulo(ByVal p1 As Integer) As Integer
        dtb.PrepararConsulta("select id_tipoFormato from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar
        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function crear_formato(ByVal nombre As String) As Integer
        Dim s As String = "INSERT INTO [dbo].[TiposFormatos] (codigoqs, [Descripcion], separadores, cajaspalet, tipocajaid) " & _
        " VALUES (1, @nom , 1, 1, 1)"
        dtb.PrepararConsulta(s)
        dtb.AñadirParametroConsulta("@nom", nombre)

        If dtb.Consultar(True) Then
            Return dtb.Consultar("select max(tipoformatoid) from tiposformatos", True).Rows(0).Item(0)
        Else
            Return 0
        End If
    End Function
    Public Function MarcaPorArticulo(ByVal p1 As Integer) As Integer
        dtb.PrepararConsulta("select id_marca from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function CajaPorArticulo(ByVal p1 As Integer) As Integer
        dtb.PrepararConsulta("select id_tipoCaja from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function ProductoPorArticulo(ByVal p1 As Integer) As Integer
        dtb.PrepararConsulta("select id_TipoProducto from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function PaletNCPorArticulo(ByVal p1 As Integer) As Integer
        dtb.PrepararConsulta("select id_PaletProducidoNoConforme from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar

        Return If(IsDBNull(dt.Rows(0).Item(0)), Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function EanPorArticulo(ByVal p1 As Integer) As String
        dtb.PrepararConsulta("select ean13 from doypack where id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", p1)
        Dim dt As DataTable = dtb.Consultar

        If dt Is Nothing Then Return String.Empty
        If dt.Rows(0) Is Nothing Then Return String.Empty
        If Convert.IsDBNull(dt.Rows(0).Item(0)) Then Return String.Empty

        Return dt.Rows(0).Item(0).ToString
        'Return If(dt.Rows(0).Item(0) Is Convert.DBNull, Nothing, dt.Rows(0).Item(0))
    End Function

    Public Function UltimoArticuloInsertado() As Integer
        Return dtb.Consultar("select max(articuloID) from articulos1", False).Rows(0).Item(0)
    End Function

    'Public Function selectRecord(ByVal p1 As Integer) As Collection
    '    Dim doys As New Collection
    '    Dim Dbo_DoyPack As Dbo_DoyPack
    '    Dim selectProcedure As String = "[dbo].[doypackSelect]"

    '    Try
    '        Dim dt As DataTable = DataTableFill(selectProcedure & " " & p1)
    '        For Each row As DataRow In dt.Rows
    '            Dbo_DoyPack = New Dbo_DoyPack
    '            Dbo_DoyPack.ArticuloPrimarioID = p1
    '            Dbo_DoyPack.ID = row.Item(0)
    '            Dbo_DoyPack.Cantidad = row.Item(1)
    '            Dbo_DoyPack.MonodosisID = row.Item(2)
    '            Dbo_DoyPack.TipoFormatoID = row.Item(3)
    '            Dbo_DoyPack.MarcaId = row.Item(4)
    '            Dbo_DoyPack.Palet_NO_Conforme_ID = row.Item(5)
    '            doys.Add(Dbo_DoyPack)
    '        Next
    '    Catch ex As Exception
    '        doys = New Collection
    '    End Try

    '    Return doys
    'End Function

    Public Function selectRecordById(ByVal p1 As Integer) As Dbo_DoyPack

        Dim Dbo_DoyPack As New Dbo_DoyPack
        'Dim selectProcedure As String = "exec doypackSelectById"
        dtb.PrepararConsulta("doypackSelectById @p1")
        Try
            dtb.AñadirParametroConsulta("@p1", p1)
            Dim dt As DataTable = dtb.Consultar
            'Dim dt As DataTable = dtb.Consultar(selectProcedure & " " & p1, False)
            Dbo_DoyPack.ArticuloPrimarioID = dt.Rows(0).Item(0)
            Dbo_DoyPack.ID = p1
            Dbo_DoyPack.Cantidad = dt.Rows(0).Item(1)
            Dbo_DoyPack.MonodosisID = dt.Rows(0).Item(2)
            Dbo_DoyPack.TipoFormatoID = dt.Rows(0).Item(3)
            Dbo_DoyPack.MarcaId = dt.Rows(0).Item(4)
            Dbo_DoyPack.Palet_NO_Conforme_ID = dt.Rows(0).Item(5)
            Dbo_DoyPack.ProductoId = dt.Rows(0).Item(6)
            Dbo_DoyPack.CajaId = dt.Rows(0).Item(7)
            Dbo_DoyPack.Ean13 = dt.Rows(0).Item(8)
        Catch ex As Exception
            Dbo_DoyPack = Nothing
        End Try

        Return Dbo_DoyPack
    End Function

    Public Function selectRecordBy(ByVal p1 As Integer, ByVal p2 As Integer) As Dbo_DoyPack

        Dim Dbo_DoyPack As New Dbo_DoyPack
        Dim selectProcedure As String = "[dbo].[doypackSelectBy]"

        Try
            Dim dt As DataTable = dtb.Consultar(selectProcedure & " " & p1 & ", " & p2, True)
            For Each row As DataRow In dt.Rows
                Dbo_DoyPack = New Dbo_DoyPack
                Dbo_DoyPack.ArticuloPrimarioID = p1
                Dbo_DoyPack.ID = row.Item(0)
                Dbo_DoyPack.Cantidad = row.Item(1)
                Dbo_DoyPack.MonodosisID = p2
                Dbo_DoyPack.TipoFormatoID = row.Item(3)
                Dbo_DoyPack.MarcaId = dt.Rows(0).Item(4)
                Dbo_DoyPack.Palet_NO_Conforme_ID = dt.Rows(0).Item(5)
                Dbo_DoyPack.ProductoId = dt.Rows(0).Item(6)
                Dbo_DoyPack.CajaId = dt.Rows(0).Item(7)
                Dbo_DoyPack.Ean13 = dt.Rows(0).Item(8)
            Next
        Catch ex As Exception
            Dbo_DoyPack = Nothing
        End Try

        Return Dbo_DoyPack
    End Function


    Public Function selectRecords(ByVal id As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        ', id_marca, id_paletproducidoNoConforme
        dtb.PrepararConsulta("select doypack.id,articulos1.descripcionLa, doypack.cantidad, id_monodosis from monodosis, articulos1, doypack where monodosis.id_articuloPrimario = articulos1.articuloid and monodosis.id_articuloPrimario = doypack.id_monodosis and doypack.id_articuloPrimario = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Consultar
    End Function

    Public Function actualizarFormatoPorArticulo(ByVal p1 As Integer, ByVal formato As Integer, ByVal id_marca As Integer, ByVal id_caja As Integer, id_NC As Integer, id_producto As Integer, ean As String) As Boolean

        Return Deprecated.realizarConsultaAlteraciones("update doypack set id_tipoFormato = " & formato & ", id_marca=" & id_marca & ", id_tipocaja =" & id_caja & ", id_tipoproducto=" & id_producto & ", id_paletProducidoNoConforme=" & If(id_NC = 0, "null", Convert.ToString(id_NC)) & ",ean13= " & If(ean = "0" Or ean = String.Empty, "null", "'" & ean & "'") & " where id_articuloPrimario = " & p1)
    End Function

    Public Function esDoypack(ByVal p1 As Integer, Optional dtb as BasesParaCompatibilidad.Database = Nothing) As Boolean
        Dim dt As DataTable

        If dtb Is Nothing Then
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        End If

        dtb.PrepararConsulta("Select count(*) from doypack where id_articuloPrimario =  @id")
        dtb.AñadirParametroConsulta("@id", p1)
        dt = dtb.Consultar()

        If dt.Rows(0).Item(0) = 0 Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Function modify(ByVal dbo As Dbo_DoyPack) As Boolean
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try
            Dim updateProcedure As String = "[dbo].[doypackUpdate]"
            Dim updateCommand As New System.Data.SqlClient.SqlCommand(updateProcedure, connection)
            updateCommand.CommandType = CommandType.StoredProcedure
            If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then updateCommand.Transaction = BasesParaCompatibilidad.BD.transaction
            updateCommand.Parameters.AddWithValue("@id_articuloPrimario", dbo.ArticuloPrimarioID)
            updateCommand.Parameters.AddWithValue("@id_tipoFormato", dbo.TipoFormatoID)
            updateCommand.Parameters.AddWithValue("@id_monodosis", dbo.MonodosisID)
            updateCommand.Parameters.AddWithValue("@cantidad", dbo.Cantidad)
            updateCommand.Parameters.AddWithValue("@id_marca", dbo.MarcaId)
            updateCommand.Parameters.AddWithValue("@id_Palet", If(dbo.Palet_NO_Conforme_ID = 0, Convert.DBNull, dbo.Palet_NO_Conforme_ID))
            updateCommand.Parameters.AddWithValue("@id_Producto", dbo.ProductoId)
            updateCommand.Parameters.AddWithValue("@id_Caja", dbo.CajaId)
            updateCommand.Parameters.AddWithValue("@ean", If(dbo.Ean13 = 0, Convert.DBNull, dbo.Ean13))
            updateCommand.Parameters.AddWithValue("@id", dbo.ID)

            updateCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then
                connection.Close()
                BasesParaCompatibilidad.BD.Cerrar()
            End If
        End Try
    End Function

    Public Function add(ByVal dbo As Dbo_DoyPack) As Boolean
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try
            Dim insertProcedure As String = "[dbo].[doypackInsert]"
            Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
            insertCommand.CommandType = CommandType.StoredProcedure
            If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then insertCommand.Transaction = BasesParaCompatibilidad.BD.transaction
            insertCommand.Parameters.AddWithValue("@id_articuloPrimario", dbo.ArticuloPrimarioID)
            insertCommand.Parameters.AddWithValue("@id_tipoFormato", dbo.TipoFormatoID)
            insertCommand.Parameters.AddWithValue("@id_monodosis", dbo.MonodosisID)
            insertCommand.Parameters.AddWithValue("@cantidad", dbo.Cantidad)
            insertCommand.Parameters.AddWithValue("@id_marca", dbo.MarcaId)
            insertCommand.Parameters.AddWithValue("@id_Palet", If(dbo.Palet_NO_Conforme_ID = 0, Convert.DBNull, dbo.Palet_NO_Conforme_ID))
            insertCommand.Parameters.AddWithValue("@id_Producto", dbo.ProductoId)
            insertCommand.Parameters.AddWithValue("@id_Caja", dbo.CajaId)
            insertCommand.Parameters.AddWithValue("@ean", If(dbo.Ean13 = 0, Convert.DBNull, dbo.Ean13))

            insertCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then
                connection.Close()
                BasesParaCompatibilidad.BD.Cerrar()
            End If
        End Try
    End Function

    Public Function delete(ByVal p1 As Integer) As Boolean
        If BasesParaCompatibilidad.BD.transaction Is Nothing Then BasesParaCompatibilidad.BD.Conectar()

        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Try
            Dim deleteProcedure As String = "[dbo].[doypackDelete]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            deleteCommand.CommandType = CommandType.StoredProcedure
            If Not BasesParaCompatibilidad.BD.transaction Is Nothing Then deleteCommand.Transaction = BasesParaCompatibilidad.BD.transaction
            deleteCommand.Parameters.AddWithValue("@id", p1)

            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            If BasesParaCompatibilidad.BD.transaction Is Nothing Then
                connection.Close()
                BasesParaCompatibilidad.BD.Cerrar()
            End If
        End Try
    End Function

    Public Function deleteBy(ByVal p1 As Integer, ByVal p2 As Integer, ByRef dtb As BasesParaCompatibilidad.Database) As Boolean
        Try
            Dim deleteProcedure As String = "[dbo].[doypackDeleteBy]"
            Dim deleteCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[doypackDeleteBy]")
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Transaction = dtb.Transaccion
            deleteCommand.Parameters.AddWithValue("@articulo", p1)
            deleteCommand.Parameters.AddWithValue("@monodosis", p2)

            deleteCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        End Try
    End Function

    Public Function InsertarCompuestoPor(p1 As Integer, p2 As Integer, p3 As Double) As Boolean
        Dim dtb As New BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server, BasesParaCompatibilidad.BD.Cnx, BasesParaCompatibilidad.BD.transaction)
        Dim retorno As Boolean = True
        Dim spArticulos1 As New spArticulos1

        Try
            Dim m_aux As DBO_Articulos1 = spArticulos1.Select_Record(p1, dtb.Transaccion)

            dtb.PrepararConsulta("insert into articulos1_articulos1_compuestoPor(id_articulo, id_articuloCompuestoPor, cantidad) values( @p1, @p2, @p3)")
            dtb.AñadirParametroConsulta("@p1", p1)
            dtb.AñadirParametroConsulta("@p2", p2)
            dtb.AñadirParametroConsulta("@p3", p3)
            retorno = retorno And dtb.Consultar(True)

            Return retorno
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

    Public Function seleccionar_composicion_vigente(ByVal Id_articulo As Integer, Optional ByRef dtb as BasesParaCompatibilidad.Database = Nothing) As Integer
        If dtb Is Nothing Then
            dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        End If

        dtb.PrepararConsulta("select id from ComposicionesArticulos where FechaFinVigencia is null and id_articulo = @id")
        dtb.AñadirParametroConsulta("@id", Id_articulo)
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

End Class
