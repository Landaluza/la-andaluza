Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spAguaPotablePuntosMuestreos
Inherits BasesParaCompatibilidad.StoredProcedure

   Public Sub new()
       MyBase.New( "[dbo].[AguaPotablePuntosMuestreosSelect]",  _
                     "[dbo].[AguaPotablePuntosMuestreosInsert]",  _
                     "[dbo].[AguaPotablePuntosMuestreosUpdate]",  _
                     "[dbo].[AguaPotablePuntosMuestreosDelete]",  _
                     "[dbo].[AguaPotablePuntosMuestreosSelectDgv]",  _
                     "[dbo].[AguaPotablePuntosMuestreosSelectDgvBy]")
   End Sub

   Public Overloads Function Select_Record(ByVal PuntoMuestreoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As DBO_AguaPotablePuntosMuestreos
       Dim dbo As New DBO_AguaPotablePuntosMuestreos
       dbo.searchKey = dbo.item("PuntoMuestreoID")
       dbo.searchKey.value = PuntoMuestreoID
       MyBase.Select_Record(dbo, trans)
       Return dbo
   End Function

   Public Overrides Function Delete(ByVal PuntoMuestreoID As Int32, Optional ByRef trans As System.Data.SqlClient.SqlTransaction= Nothing) As Boolean
       Dim dbo As New DBO_AguaPotablePuntosMuestreos
       dbo.searchKey = dbo.item("PuntoMuestreoID")
       dbo.searchKey.value = PuntoMuestreoID
       return MyBase.DeleteProcedure(dbo,  trans)
   End Function

    Sub cargar_ComboBox(ByRef comboBox As ComboBox)
        comboBox.mam_DataSource("AguaPotableAnaliticasCloro_AguaPotablePuntosMuestreosCbo", False)
    End Sub

End Class
