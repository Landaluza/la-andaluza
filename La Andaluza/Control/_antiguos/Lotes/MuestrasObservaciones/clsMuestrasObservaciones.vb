Public Class clsMuestrasObservaciones
#Region "Atributos"
    Private AnaliticaID As Integer
    Private ObservacionID As Integer
    Private Descripcion As String
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

    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _ObservacionID() As Integer
        Get
            Return ObservacionID
        End Get

        Set(ByVal value As Integer)
            ObservacionID = value
        End Set
    End Property
#End Region

#Region "Propiedades"


    Public Function existe(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select Count(*) from MuestrasObservaciones where AnaliticaID = @ana and ObservacionID = @obs")
        dtb.AņadirParametroConsulta("@ana", AnaliticaID)
        dtb.AņadirParametroConsulta("@obs", ObservacionID)
        Return dtb.Consultar().Rows(0).Item(0) > 0
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Return dtb.ConsultaAlteraciones("Insert into MuestrasObservaciones values(" & Convert.ToString(AnaliticaID) & "," & Convert.ToString(ObservacionID) & ",'" & Descripcion & "'" & _
                                         ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")")

    End Function


    Public Function cargar(ByRef dtb As BasesParaCompatibilidad.DataBase) As String
        dtb.PrepararConsulta("select Descripcion from MuestrasObservaciones where AnaliticaID = @an and ObservacionID = @ob")
        dtb.AņadirParametroConsulta("@an", AnaliticaID)
        dtb.AņadirParametroConsulta("@ob", ObservacionID)
        Try
            Return dtb.Consultar().Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("update MuestrasObservaciones set " & _
                                                       "Descripcion = '" & Descripcion & "'" & _
                                                       " where AnaliticaID = " & Convert.ToString(AnaliticaID) & _
                                                       " and ObservacionID = " & Convert.ToString(ObservacionID))
    End Function


    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID= @id and ObservacionID= @obs")
        dtb.AņadirParametroConsulta("@id", AnaliticaID)
        dtb.AņadirParametroConsulta("@obs", ObservacionID)
        Return dtb.Execute

    End Function

    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID = @id")
        dtb.AņadirParametroConsulta("@id", AnaliticaID)
        Return dtb.Execute

        'If BasesParaCompatibilidad.BD.ConsultaEliminar("MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


        'Return True

    End Function

#End Region
End Class
