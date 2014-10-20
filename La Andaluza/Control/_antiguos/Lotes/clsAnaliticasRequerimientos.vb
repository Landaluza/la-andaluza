Public Class clsAnaliticasRequerimientos
#Region "Atributos"
    Private AnaliticaID As Integer
    Private ParametroID As Integer
#End Region

#Region "Propiedades"
    Public Property _AnaliticaID() As Integer
        Get
            Return AnaliticaID
        End Get

        Set(ByVal value As Integer)
            AnaliticaID = value
        End Set
    End Property

    Public Property _ParametroID() As Integer
        Get
            Return ParametroID
        End Get

        Set(ByVal value As Integer)
            ParametroID = value
        End Set
    End Property

#End Region


#Region "Propiedades"


    Public Function existe(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select Count(*) from AnaliticasRequerimientos where AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ParametroID = " & Convert.ToString(ParametroID))

        Return Convert.ToBoolean(dtb.Consultar().Rows(0).Item(0) > 0)
    End Function


    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("insert into AnaliticasRequerimientos values(" & Convert.ToString(AnaliticaID) & "," & Convert.ToString(ParametroID) & _
                                        ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")")

    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from AnaliticasRequerimientos where AnaliticaID = @ana and ParametroID = @par")
        dtb.AñadirParametroConsulta("@ana", AnaliticaID)
        dtb.AñadirParametroConsulta("@par", ParametroID)

        Return dtb.Consultar(True)

        'BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasRequerimientos", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ParametroID = " & Convert.ToString(ParametroID))

    End Function

    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
      
            dtb.PrepararConsulta("delete from AnaliticasRequerimientos where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasRequerimientos", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


            'Return True
    End Function
#End Region
End Class
