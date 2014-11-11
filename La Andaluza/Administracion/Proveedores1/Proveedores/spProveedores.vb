Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spProveedores
Inherits BasesParaCompatibilidad.StoredProcedure
    Private spProveedoresCero As spProveedoresCero
    Private spArtFilter As String
    Private m_InactivesProcedure As String

    Public ReadOnly Property DataGridViewStoredProcedure2 As String
        Get
            Return m_InactivesProcedure
        End Get
    End Property

    Public Sub New(Optional ByVal maestroId As Integer = Nothing)
        MyBase.New("[dbo].[ProveedoresSelect]", "[dbo].[ProveedoresInsert]", "[dbo].[ProveedoresUpdate]", "[dbo].[ProveedoresDelete]", "[dbo].[Proveedores1SelectDgv]", "ProveedoresSelectDgvBy")
        spProveedoresCero = New spProveedoresCero
        Me.m_InactivesProcedure = "Proveedores1SelectDgvInactivos"
        spArtFilter = "SELECT [dbo].[Proveedores].[ProveedorID] ,[dbo].[Proveedores].[Nombre] ,[dbo].[Proveedores].[QS]  FROM  [dbo].[Proveedores] where proveedorID in (select proveedorId from proveedores_articulos where articuloID = " & maestroId & ")"
    End Sub

    Public Overloads Function Select_Record(ByVal ProveedorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Proveedores
        Dim dbo As New DBO_Proveedores
        dbo.searchKey = dbo.item("ProveedorID")
        dbo.searchKey.value = ProveedorID
        MyBase.Select_Record(dbo, dtb)


        dbo.proveedorCero = spProveedoresCero.Select_Record(ProveedorID, dtb)

        Return dbo
    End Function

    Public Overloads Function Select_RecordByArticulo(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta(spArtFilter)
        Return dtb.Consultar()
    End Function

    Public Overrides Function Delete(ByVal ProveedorID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Proveedores
        dbo.searchKey = dbo.item("ProveedorID")
        dbo.searchKey.value = ProveedorID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ProveedoresSelectCbo", False, dtb)
    End Sub

    Function MarcarInactivo(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal proveedorID As Integer) As Boolean
        dtb.PrepararConsulta("update proveedores set activo = 0 where proveedorID= @id")
        dtb.AñadirParametroConsulta("@id", proveedorID)
        Return dtb.Execute
    End Function

    Sub cargar_Proveedores(ByRef comboBox As ComboBox, ByRef dtb As BasesParaCompatibilidad.database)
        comboBox.mam_DataSource("ProveedoresCbo", False, dtb)
    End Sub

    Sub cargar_Proveedores_Por_Tipo_Material(ByRef cbo As ComboBox, ByVal TipoMaterialId As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("ProveedoresCboByTipoMaterial " & TipoMaterialId, False, dtb)
    End Sub

    Public Sub cargar_Proveedores_Por_Tipo(ByRef cbo As ComboBox, ByVal tipo As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("Proveedores1CboPorTipo " & tipo, False, dtb)
    End Sub

    Public Sub cargar_Proveedores_Analiticas(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.cargar_Proveedores_Por_Tipo(cbo, 6, dtb)
    End Sub

    Public Sub cargar_Proveedores_Enologicos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.cargar_Proveedores_Por_Tipo(cbo, 5, dtb)
    End Sub

    Public Sub cargar_Proveedores_Compras(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Me.cargar_Proveedores_Por_Tipo(cbo, 3, dtb)
    End Sub

    Public Function devolverProveedoresAnaliticas(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select Proveedores.ProveedorID, Proveedores.Nombre from TipoProv_Proveedor INNER JOIN Proveedores ON TipoProv_Proveedor.ProveedorID = Proveedores.ProveedorID INNER JOIN TiposProveedores ON TipoProv_Proveedor.TipoProveedorID = TiposProveedores.TipoProveedorID where TiposProveedores.Descripcion = 'Analiticas'")
        Return dtb.Consultar()
    End Function



    Public Function devolverProveedores(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select * from proveedores")
        Return dtb.Consultar

    End Function

End Class
