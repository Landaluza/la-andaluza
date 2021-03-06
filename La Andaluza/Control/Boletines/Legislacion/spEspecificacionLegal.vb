Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spEspecificacionLegal
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[legislacionProductosSelect]", "[dbo].[legislacionProductosInsert]", "[dbo].[legislacionProductosUpdate]", "[dbo].[legislacionProductosDelete]", "[dbo].[legislacionProductosSelectDgv]", "[dbo].[legislacionProductosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_EspecificacionLegal
        Dim dbo As New DBO_EspecificacionLegal
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        MyBase.Select_Record(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal Id As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_EspecificacionLegal
        dbo.searchKey = dbo.item("Id")
        dbo.searchKey.value = Id
        Return MyBase.DeleteProcedure(CType(dbo, BasesParaCompatibilidad.databussines), dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("legislacionProductosCbo", False, dtb)
    End Sub

    Public Sub cargarParametros(ByVal dataGridView As DataGridView, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal Legislacion As Integer = 0)
        Dim row As DataRow
        Dim dt As DataTable
        Dim reg As dtsEspecificaciones.ValoresEspecificacionesRow
        Dim dts As New dtsEspecificaciones.ValoresEspecificacionesDataTable

        dtb.PrepararConsulta("LegislacionProductosSelectParametros @id")
        dtb.AņadirParametroConsulta("@id", Legislacion)
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

    Public Function GuardarParametros(ByVal dgv As DataGridView, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal IdLegislacion As Integer = Nothing) As Boolean
        Dim row As DataGridViewRow
        Dim dbo As New DBO_ParametroEspecificacionLegal
        If IdLegislacion = Nothing Then
            dtb.PrepararConsulta("select max(Id) from legislacionProductos")
            dbo.IdLegislacion = dtb.Consultar().Rows(0).Item(0)
        Else
            dbo.IdLegislacion = IdLegislacion
        End If

        For Each row In dgv.Rows
            If Not Convert.IsDBNull(row.Cells("maximo").Value) Or Not Convert.IsDBNull(row.Cells("minimo").Value) Then
                'If Not Convert.IsDBNull(row.Cells("maximo").Value) Then If row.Cells("maximo").Value <> Nothing Then dbo.Maximo = row.Cells("maximo").Value
                'If Not Convert.IsDBNull(row.Cells("minimo").Value) Then If row.Cells("minimo").Value <> Nothing Then dbo.Minimo = row.Cells("minimo").Value
                If Not Convert.IsDBNull(row.Cells("parametroid").Value) Then dbo.IdParametro = row.Cells("parametroid").Value

                If Not guardarParametro(dbo.IdLegislacion, dbo.IdParametro, row.Cells("maximo").Value.ToString.Replace(",", "."), row.Cells("minimo").Value.ToString.Replace(",", "."), dtb) Then
                    dtb.CancelarTransaccion()
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Public Function borrarParametros(ByVal legislacion As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Try
            dtb.PrepararConsulta("[dbo].[LegislacionProductos_parametrosDelete] @legislacionID")
            dtb.AņadirParametroConsulta("@legislacionID", legislacion)

            Return dtb.Execute
        Catch ex As Exception
            Return False
        End Try
    End Function

    Protected Function guardarParametro(ByVal legilacion As Integer, ByVal parametro As Integer, ByVal maximo As String, ByVal minimo As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("[dbo].[LegislacionProductos_parametrosInsert]")
        dtb.AņadirParametroConsulta("@Id_legislacion", legilacion)
        dtb.AņadirParametroConsulta("@Id_parametro", parametro)
        dtb.AņadirParametroConsulta("@Maximo", maximo)
        dtb.AņadirParametroConsulta("@Minimo", minimo)
        dtb.AņadirParametroConsulta("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
        dtb.AņadirParametroConsulta("@FechaModificacion", DateTime.Now)

        Try
            Return dtb.Execute
        Catch ex As System.Data.SqlClient.SqlException
            Return False

        End Try
    End Function
End Class
