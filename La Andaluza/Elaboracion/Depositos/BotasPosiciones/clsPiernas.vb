Public Class clsPiernas

#Region "Atributos"
    Private PiernaID As Integer
    Private Descripcion As String
    Private NaveID As String
#End Region

#Region "Propiedades"
    Public Property _PiernaID() As Integer
        Get
            Return PiernaID
        End Get

        Set(ByVal value As Integer)
            PiernaID = value
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

    Public Property _NaveID() As Integer
        Get
            If NaveID = "null" Then
                Return 0
            Else
                Return NaveID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                NaveID = "null"
            Else
                NaveID = value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function DevolverPorNaves() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("PiernaID,Descripcion", "Piernas", "NaveID = " & NaveID & " order by descripcion ")

    End Function

    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Piernas.PiernaID,Piernas.Descripcion,Naves.Descripcion As Naves", "Piernas LEFT JOIN Naves On Piernas.NaveID = Naves.NaveID")

    End Function

    Public Function Modificar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Piernas", _
                              "Descripcion='" & Descripcion & "'," & _
                              "NaveID=" & Convert.ToString(NaveID) & "", _
                              "PiernaID=" & Convert.ToString(PiernaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                             "'" & Descripcion & "'," & _
                             "" & Convert.ToString(NaveID) & "", _
                             "Piernas")
            PiernaID = BasesParaCompatibilidad.BD.ConsultaVer("max(PiernaID)", "Piernas").Rows(0).Item(0)
            Return PiernaID
        Catch ex As Exception
            Return 0
        End Try
    End Function


#End Region
End Class
