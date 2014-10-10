Public Class clsAlturas

#Region "Atributos"
    Private AlturaID As Integer
    Private Descripcion As String
    Private PiernaID As String
#End Region

#Region "Propiedades"
    Public Property _AlturaID() As Integer
        Get
            Return AlturaID
        End Get

        Set(ByVal value As Integer)
            AlturaID = value
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

    Public Property _PiernaID() As Integer
        Get
            If PiernaID = "null" Then
                Return 0
            Else
                Return PiernaID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                PiernaID = "null"
            Else
                PiernaID = value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function DevolverPorPiernas() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("AlturaID,Descripcion", "Alturas", "PiernaID=" & PiernaID & " order by descripcion")
    End Function

    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Alturas.AlturaID,Alturas.Descripcion,Piernas.Descripcion As Piernas", "Alturas LEFT JOIN Piernas On Alturas.PiernaID = Piernas.PiernaID")

    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Alturas", _
                               "Descripcion='" & Descripcion & "'," & _
                               "PiernaID=" & Convert.ToString(PiernaID) & "", _
                               "AlturaID=" & Convert.ToString(AlturaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "'" & Descripcion & "'," & _
                              "" & Convert.ToString(PiernaID) & "", _
                              "Alturas")
            AlturaID = BasesParaCompatibilidad.BD.ConsultaVer("max(AlturaID)", "Alturas").Rows(0).Item(0)
            Return AlturaID
        Catch ex As Exception
            Return 0
        End Try
    End Function



#End Region
End Class
