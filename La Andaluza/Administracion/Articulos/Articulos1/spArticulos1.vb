Imports BasesParaCompatibilidad.ComboBoxExtension

Public Class spArticulos1
    Inherits BasesParaCompatibilidad.StoredProcedure


    Public ReadOnly Property DatagridViewProcedureForSelectInactivos As String
        Get
            Return "[Articulos1SelectDgv2_inactivos]"
        End Get
    End Property
    Public Sub New()
        MyBase.New("[dbo].[Articulos1Select]", _
                      "[dbo].[Articulos1Insert]", _
                      "[dbo].[Articulos1Update]", _
                      "[dbo].[Articulos1Delete]", _
                      "[dbo].[Articulos1SelectDgv2]", _
                      "[dbo].[Articulos1SelectDgvBy]")
    End Sub

   Public Overloads Function Select_Record(ByVal ArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As DBO_Articulos1
       Dim dbo As New DBO_Articulos1
       dbo.searchKey = dbo.item("ArticuloID")
       dbo.searchKey.value = ArticuloID
       MyBase.Select_Record(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal ArticuloID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction = Nothing) As Boolean
       Dim dbo As New DBO_Articulos1
       dbo.searchKey = dbo.item("ArticuloID")
       dbo.searchKey.value = ArticuloID
       return MyBase.DeleteProcedure(ctype(dbo, BasesParaCompatibilidad.databussines), trans)
   End Function

    Public Sub cargar_Articulos(ByRef cbo As ComboBox)
        cbo.mam_DataSource("Articulos1Cbo", False)
    End Sub

    Public Sub cargar_Articulos_Por_Tipo(ByRef cbo As ComboBox, ByVal tipo As Integer)
        cbo.mam_DataSource("Articulos1CboByTipo " & tipo, False)
    End Sub

    'Public Function Articulos1SelecMax(ByRef mytrans As System.Data.SqlClient.SqlTransaction) As Integer
    '    Dim MaxID As Integer = 0

    '    Dim cmd As New System.Data.SqlClient.SqlCommand
    '    cmd.CommandType = CommandType.StoredProcedure
    '    cmd.Connection = BasesParaCompatibilidad.BD.Cnx
    '    cmd.CommandText = "Articulos1SelectMax"
    '    cmd.Transaction = mytrans
    '    MaxID = (cmd.ExecuteScalar())

    '    Return MaxID

    'End Function

    Public Function certificadosByArticuloId(ByVal articuloID As Integer) As DataTable
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Return dtb.Consultar("exec Articulos_certificadosSelect " & articuloID, False)
    End Function

    Public Function comprobarCambioTipo(ByVal id As Integer) As Boolean
        Dim dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
        Dim dt As DataTable = dtb.Consultar("select count(*) from (select articuloid from articulosEnvasesterciarios union select articuloid from ArticulosEnvasesSecundarios union select articuloid from ArticulosGraneles union select articuloid from ArticulosIngredientes union select articuloid from ArticulosIngredientesIDI union select articuloid from ArticulosMateriasPrimas union select id_articulo as articulid from ArticulosPrimarios) as x where x.articuloid = " & id, False)

        Try
            If Convert.ToInt32(dt.Rows(0).Item(0)) = 0 Then
                Return True
            End If
        Catch ex As Exception
        End Try        

        Return False
    End Function
End Class
