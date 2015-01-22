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
        dtb.AñadirParametroConsulta("@ana", AnaliticaID)
        dtb.AñadirParametroConsulta("@obs", ObservacionID)
        Return dtb.Consultar().Rows(0).Item(0) > 0
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("Insert into MuestrasObservaciones values( @ana , @obs , @desc , @fecha , @user )")
        dtb.AñadirParametroConsulta("@ana", AnaliticaID)
        dtb.AñadirParametroConsulta("@obs", ObservacionID)
        dtb.AñadirParametroConsulta("@desc", Descripcion)
        dtb.AñadirParametroConsulta("@fecha", BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay))
        dtb.AñadirParametroConsulta("@user", BasesParaCompatibilidad.Config.User)

        Return dtb.Execute

    End Function


    Public Function cargar(ByRef dtb As BasesParaCompatibilidad.DataBase) As String
        dtb.PrepararConsulta("select Descripcion from MuestrasObservaciones where AnaliticaID = @an and ObservacionID = @ob")
        dtb.AñadirParametroConsulta("@an", AnaliticaID)
        dtb.AñadirParametroConsulta("@ob", ObservacionID)
        Try
            Return dtb.Consultar().Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update MuestrasObservaciones set " & _
                                                       "Descripcion = @des " & _
                                                       " where AnaliticaID = @ana" & _
                                                       " and ObservacionID = @obs")
        dtb.AñadirParametroConsulta("@des", Descripcion)
        dtb.AñadirParametroConsulta("@ana", AnaliticaID)
        dtb.AñadirParametroConsulta("@obs", ObservacionID)

        Return dtb.Execute
    End Function


    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID= @id and ObservacionID= @obs")
        dtb.AñadirParametroConsulta("@id", AnaliticaID)
        dtb.AñadirParametroConsulta("@obs", ObservacionID)
        Return dtb.Execute

    End Function

    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID = @id")
        dtb.AñadirParametroConsulta("@id", AnaliticaID)
        Return dtb.Execute

        'If BasesParaCompatibilidad.BD.ConsultaEliminar("MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


        'Return True

    End Function

#End Region
End Class
