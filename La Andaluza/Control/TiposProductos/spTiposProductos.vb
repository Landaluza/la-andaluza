Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spTiposProductos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[TiposProductosSelect]",  _
                     "[dbo].[TiposProductosInsert]",  _
                     "[dbo].[TiposProductosUpdate]",  _
                     "[dbo].[TiposProductosDelete]",  _
                     "[dbo].[TiposProductosSelectDgv]",  _
                     "[dbo].[TiposProductosSelectDgvBy]")
   End Sub

    Public Overloads Function Select_Record(ByVal TipoProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_TiposProductos
        Dim dbo As New DBO_TiposProductos
        dbo.searchKey = dbo.item("TipoProductoID")
        dbo.searchKey.value = TipoProductoID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal TipoProductoID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_TiposProductos
        dbo.searchKey = dbo.item("TipoProductoID")
        dbo.searchKey.value = TipoProductoID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_ComboBox_Enologicos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal primeraCelda As String = "")
        If primeraCelda = String.Empty Then
            cbo.mam_DataSource("[TiposProductosSelectCboEnologicos]", False, dtb)
        Else
            cbo.mam_DataSource("[TiposProductosSelectCboEnologicos]", True, dtb, primeraCelda)
        End If
    End Sub

    Public Sub cargar_ComboBox(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal primeracelda As String = "")
        If primeracelda = String.Empty Then
            cbo.mam_DataSource("TiposProductosSelectCbo", False, dtb)
        Else
            cbo.mam_DataSource("TiposProductosSelectCbo", False, dtb, primeracelda)
        End If
    End Sub

    Public Sub cargar_ComboBox_datos_completos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("[dbo].[TiposProductosSelectDgv]", False, dtb)
    End Sub

    Public Function devolver_TiposProductos_Cbo(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("TiposProductosSelectCbo")
        Return dtb.Consultar()
    End Function

    Public Function devolver_TiposProductos_No_enologicos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("TiposProductosSelectCboNoEnologicos")
        Return dtb.Consultar()
    End Function

    Public Function devolver_TiposProductos_Enologicos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("TiposProductosSelectCboEnologicos")
        Return dtb.Consultar()
    End Function

    Public Function devolver_TiposProductos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("[dbo].[TiposProductosSelectDgv]")
        Return dtb.Consultar()
    End Function

    Public Sub cargar_ComboBox_No_enologicos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal primeraCelda As String = "")
        If primeraCelda = String.Empty Then
            cbo.mam_DataSource("[TiposProductosSelectCboNoEnologicos]", False, dtb)
        Else
            cbo.mam_DataSource("[TiposProductosSelectCboNoEnologicos]", True, dtb, primeraCelda)
        End If
    End Sub

    Public Sub cargar_ComboBox_para_envasado(ByRef cbo As ComboBox, ByVal formatoLinea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposProductosCboFormatosEnvasados " & formatoLinea, False, dtb)
    End Sub

    Public Sub cargar_ComboBox_para_envasado_por_Linea(ByRef cbo As ComboBox, ByVal Linea As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("TiposProductosCboFormatosEnvasadosAll " & Linea, False, dtb)
    End Sub

    Sub cargar_MedidasProductos(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("MedidasProductosSelectCbo", False, dtb)
    End Sub

End Class
