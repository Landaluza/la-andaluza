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
        Return BasesParaCompatibilidad.BD.ConsultaVer("Count(*)", "MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ObservacionID = " & Convert.ToString(ObservacionID)).Rows(0).Item(0) > 0
    End Function

    Public Function Insertar() As Integer

        BasesParaCompatibilidad.BD.ConsultaInsertar(Convert.ToString(AnaliticaID) & "," & Convert.ToString(ObservacionID) & ",'" & Descripcion & "'", "MuestrasObservaciones")
        Try

            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function cargar() As String

        Try
            Return BasesParaCompatibilidad.BD.ConsultaVer("Descripcion", "MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ObservacionID = " & Convert.ToString(ObservacionID)).Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function


    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("MuestrasObservaciones", _
                                                           "Descripcion = '" & Descripcion & "'", _
                                                           "AnaliticaID = " & Convert.ToString(AnaliticaID) & _
                                                           " and ObservacionID = " & Convert.ToString(ObservacionID))


            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function


    Public Function Eliminar() As Integer
        Dim bdt As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Try
            bdt.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID= @id and ObservacionID= @obs")
            bdt.AñadirParametroConsulta("@id", AnaliticaID)
            bdt.AñadirParametroConsulta("@obs", ObservacionID)
            If bdt.Consultar(True) Then
                'BasesParaCompatibilidad.BD.ConsultaEliminar("MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ObservacionID = " & Convert.ToString(ObservacionID))


                Return 1
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function EliminarPorAnalitica() As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        

        Try
            dtb.PrepararConsulta("delete from MuestrasObservaciones where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)

            'If BasesParaCompatibilidad.BD.ConsultaEliminar("MuestrasObservaciones", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


            'Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region
End Class
