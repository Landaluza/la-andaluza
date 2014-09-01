Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spEspecificacionLegal
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[legislacionProductosSelect]", "[dbo].[legislacionProductosInsert]", "[dbo].[legislacionProductosUpdate]", "[dbo].[legislacionProductosDelete]", "[dbo].[legislacionProductosSelectDgv]", "[dbo].[legislacionProductosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_EspecificacionLegal
        Dim dbo As New DBO_EspecificacionLegal
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), trans)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim dbo As New DBO_EspecificacionLegal
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), trans)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
        cbo.mam_DataSource("legislacionProductosCbo", False)
    End Sub

    Public Sub cargarParametros(ByVal dataGridView As DataGridView, Optional ByVal Legislacion As Integer = 0)
        Dim row As DataRow
        Dim dt As DataTable
        Dim reg As dtsEspecificaciones.ValoresEspecificacionesRow
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dts As New dtsEspecificaciones.ValoresEspecificacionesDataTable

        dtb.PrepararConsulta("LegislacionProductosSelectParametros @id")
        dtb.AñadirParametroConsulta("@id", Legislacion)
        dt = dtb.Consultar()
        reg = dts.NewValoresEspecificacionesRow
        reg.Table.Columns.Remove("Periodicidad")
        reg.Table.Columns.Remove("UnidadMedida")
        reg.Table.Columns.Remove("MetodosAnalisisID")
        reg.Table.Columns.Remove("DesviacionMaxima")
        reg.Table.Columns.Remove("DesviacionMinima")
        reg.Table.Columns.Remove("MaximoLegislacion")
        reg.Table.Columns.Remove("MinimoLegislacion")
        reg.Table.Columns.Remove("Obligatoriedad")
        

        For Each row In dt.Rows
            reg = dts.NewValoresEspecificacionesRow            
            

            reg.Maximo = If(row.Item("maximo") Is Convert.DBNull, 0.0, CSng(row.Item("maximo")))
            reg.Minimo = If(row.Item("minimo") Is Convert.DBNull, 0.0, CSng(row.Item("minimo")))
            reg.ParametroID = row.Item("parametroid")
            reg.Nombre = row.Item("nombre")

            dts.AddValoresEspecificacionesRow(reg)
        Next

        dataGridView.DataSource = dts
    End Sub

    Public Function GuardarParametros(ByVal dgv As DataGridView, Optional ByVal IdLegislacion As Integer = Nothing, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        Dim row As DataGridViewRow
        Dim dbo As New DBO_ParametroEspecificacionLegal
        If IdLegislacion = Nothing Then
            dbo.IdLegislacion = BasesParaCompatibilidad.BD.ConsultaVer("max(Id)", "legislacionProductos").Rows(0).Item(0)
        Else
            dbo.IdLegislacion = IdLegislacion
        End If

        For Each row In dgv.Rows
            If Not Convert.IsDBNull(row.Cells("maximo").Value) Or Not Convert.IsDBNull(row.Cells("minimo").Value) Then
                'If Not Convert.IsDBNull(row.Cells("maximo").Value) Then If row.Cells("maximo").Value <> Nothing Then dbo.Maximo = row.Cells("maximo").Value
                'If Not Convert.IsDBNull(row.Cells("minimo").Value) Then If row.Cells("minimo").Value <> Nothing Then dbo.Minimo = row.Cells("minimo").Value
                If Not Convert.IsDBNull(row.Cells("parametroid").Value) Then dbo.IdParametro = row.Cells("parametroid").Value

                If Not guardarParametro(dbo.IdLegislacion, dbo.IdParametro, row.Cells("maximo").Value.ToString.Replace(",", "."), row.Cells("minimo").Value.ToString.Replace(",", "."), trans) Then
                    BasesParaCompatibilidad.BD.CancelarTransaccion()
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Public Function borrarParametros(ByVal legislacion As Integer, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx

        Try
            Dim deleteProcedure As String = "[dbo].[LegislacionProductos_parametrosDelete]"
            Dim deleteCommand As New System.Data.SqlClient.SqlCommand(deleteProcedure, connection)
            If Not trans Is Nothing Then deleteCommand.Transaction = trans
            deleteCommand.CommandType = CommandType.StoredProcedure
            deleteCommand.Parameters.AddWithValue("@legislacionID", legislacion)
            deleteCommand.ExecuteNonQuery()

            Return True
        Catch ex As Exception
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function

    Protected Function guardarParametro(ByVal legilacion As Integer, ByVal parametro As Integer, ByVal maximo As String, ByVal minimo As String, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
        If trans Is Nothing Then BasesParaCompatibilidad.BD.Conectar()
        Dim connection As System.Data.SqlClient.SqlConnection = BasesParaCompatibilidad.BD.Cnx
        Dim insertProcedure As String = "[dbo].[LegislacionProductos_parametrosInsert]"
        Dim insertCommand As New System.Data.SqlClient.SqlCommand(insertProcedure, connection)
        insertCommand.CommandType = CommandType.StoredProcedure
        If Not trans Is Nothing Then insertCommand.Transaction = trans

        insertCommand.Parameters.AddWithValue("@Id_legislacion", legilacion)
        insertCommand.Parameters.AddWithValue("@Id_parametro", parametro)
        insertCommand.Parameters.AddWithValue("@Maximo", maximo)

        insertCommand.Parameters.AddWithValue("@Minimo", minimo)


        insertCommand.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        insertCommand.Parameters.AddWithValue("@FechaModificacion", DateTime.Now)

        Try
            insertCommand.ExecuteNonQuery()
            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            If trans Is Nothing Then connection.Close()
        End Try
    End Function
End Class
