Public Class clsObservaciones
#Region "Atributos"
    Private ObservacionID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property _ObservacionID() As Integer
        Get
            Return ObservacionID
        End Get

        Set(ByVal value As Integer)
            ObservacionID = value
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

#End Region

#Region "Metodos"

    Function verObservacion() As Integer
        Try
            ObservacionID = BasesParaCompatibilidad.BD.ConsultaVer("ObservacionID", "ListaObservaciones", "Descripcion = '" & Descripcion & "'").Rows(0).Item(0)
            Return ObservacionID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("*", "ListaObservaciones", "ObservacionID > 0")

    End Function

    Public Function Modificar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("ListaObservaciones", _
                                                           "Descripcion = '" & Descripcion & "'", _
                                                           "ObservacionID = " & Convert.ToString(ObservacionID))


            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function Insertar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar("'" & Descripcion & "'", "ListaObservaciones")


            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function


#End Region
End Class
