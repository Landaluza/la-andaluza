Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAlmacenPalets
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub

  


    Public Function selectEntradasPorFecha(ByVal d As DateTime, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.Conectar()

        Dim selectProcedure As String = "[dbo].[PaletsAlmacenEntradasSelectByFecha]"
        Dim selectCommand As System.Data.SqlClient.SqlCommand = dtb.comando(selectProcedure)
        Dim dt As New DataTable
        selectCommand.CommandType = CommandType.StoredProcedure
        selectCommand.Parameters.AddWithValue("@fecha", d.Date)

        Try

            Dim reader As System.Data.SqlClient.SqlDataReader = selectCommand.ExecuteReader()
            If reader.HasRows Then
                dt.Load(reader)
            End If
            reader.Close()
        Catch ex As System.Data.SqlClient.SqlException
        Finally
            dtb.Desconectar()
        End Try

        Return dt
    End Function

    Public Sub cargarComboBoxQsAlbaranCargaMaestroProvisional(ByRef combo As Windows.Forms.ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        combo.mam_DataSource("AlbaranCargaMaestroProSelectCboQs", False, dtb)
    End Sub

    Public Function cargasSinServir(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("select isnull(count(ordenesCarga.OrdenCargaID),0) from OrdenesCarga where servido = 'false' and id_AlbaranCargaProMaestro is null group by ordenesCarga.OrdenCargaID")
            Return dtb.Consultar().Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Sub cargarComboBoxSccPorAlbaranDetalleProvisional(ByRef combo As Windows.Forms.ComboBox, ByVal albaranCargaDetalleProvisional As String, ByRef dtb As BasesParaCompatibilidad.DataBase)
        combo.mam_DataSource("PaletsProducidosSelectCboSccByAlbaranDetalleProID " & albaranCargaDetalleProvisional, False, dtb)
    End Sub
End Class
