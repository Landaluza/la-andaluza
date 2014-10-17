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

    Public Overloads Function Select_Record(ByVal ProveedorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_Proveedores
        Dim dbo As New DBO_Proveedores
        dbo.searchKey = dbo.item("ProveedorID")
        dbo.searchKey.value = ProveedorID
        MyBase.Select_Record(dbo, trans)


        dbo.proveedorCero = spProveedoresCero.Select_Record(ProveedorID, trans)

        Return dbo
    End Function

    Public Overloads Function Select_RecordByArticulo() As DataTable
        Return dtb.Consultar(spArtFilter, True)
    End Function

    Public Overrides Function Delete(ByVal ProveedorID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
        Dim dbo As New DBO_Proveedores
        dbo.searchKey = dbo.item("ProveedorID")
        dbo.searchKey.value = ProveedorID
        Return MyBase.DeleteProcedure(dbo, trans)
    End Function

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox)
        cbo.mam_DataSource("ProveedoresSelectCbo", False)
    End Sub

    Sub MarcarInactivo(ByVal proveedorID As Integer)
        BasesParaCompatibilidad.BD.realizarConsultaAlteraciones("update proveedores set activo = 0 where proveedorID=" & proveedorID)
    End Sub

    Sub cargar_Proveedores(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("ProveedoresCbo", False)
    End Sub

    Sub cargar_Proveedores_Por_Tipo_Material(ByRef cbo As ComboBox, ByVal TipoMaterialId As Integer)
        cbo.mam_DataSource("ProveedoresCboByTipoMaterial " & TipoMaterialId, False)
    End Sub

    Public Sub cargar_Proveedores_Por_Tipo(ByRef cbo As ComboBox, ByVal tipo As Integer)
        cbo.mam_DataSource("Proveedores1CboPorTipo " & tipo, False)
    End Sub

    Public Sub cargar_Proveedores_Analiticas(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 6)
    End Sub

    Public Sub cargar_Proveedores_Enologicos(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 5)
    End Sub

    Public Sub cargar_Proveedores_Compras(ByRef cbo As ComboBox)
        Me.cargar_Proveedores_Por_Tipo(cbo, 3)
    End Sub

    Public Function devolverProveedoresAnaliticas() As DataTable
        Return Deprecated.ConsultaVer("Proveedores.ProveedorID, Proveedores.Nombre", "TipoProv_Proveedor INNER JOIN Proveedores ON TipoProv_Proveedor.ProveedorID = Proveedores.ProveedorID INNER JOIN TiposProveedores ON TipoProv_Proveedor.TipoProveedorID = TiposProveedores.TipoProveedorID", "TiposProveedores.Descripcion = 'Analiticas'")

    End Function



    Public Function devolverProveedores() As DataTable
        dtb.PrepararConsulta("select * from proveedores")
        Return dtb.Consultar

    End Function

End Class
