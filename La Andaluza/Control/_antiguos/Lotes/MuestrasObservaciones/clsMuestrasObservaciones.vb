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


    Public Function existe() As Boolean
        Return Deprecated.ConsultaVer("Count(*)", "MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ObservacionID = " & Convert.ToString(ObservacionID)).Rows(0).Item(0) > 0
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Return dtb.ConsultaAlteraciones("Insert into MuestrasObservaciones values(" & Convert.ToString(AnaliticaID) & "," & Convert.ToString(ObservacionID) & ",'" & Descripcion & "'" & _
                                         ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")")

    End Function


    Public Function cargar() As String

        Try
            Return Deprecated.ConsultaVer("Descripcion", "MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ObservacionID = " & Convert.ToString(ObservacionID)).Rows(0).Item(0)
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
        dtb.AñadirParametroConsulta("@id", AnaliticaID)
        dtb.AñadirParametroConsulta("@obs", ObservacionID)
        Return dtb.Consultar(True)

    End Function

    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
    
            dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)

            'If BasesParaCompatibilidad.BD.ConsultaEliminar("MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


            'Return True

    End Function

#End Region
End Class
