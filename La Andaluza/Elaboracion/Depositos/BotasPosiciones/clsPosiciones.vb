Public Class clsPosiciones


#Region "Atributos"
    Private PosicionID As Integer
    Private Descripcion As String
    Private AlturaID As String
#End Region

#Region "Propiedades"
    Public Property _PosicionID() As Integer
        Get
            Return PosicionID
        End Get

        Set(ByVal value As Integer)
            PosicionID = value
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

    Public Property _AlturaID() As Integer
        Get
            If AlturaID = "null" Then
                Return 0
            Else
                Return AlturaID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                AlturaID = "null"
            Else
                AlturaID = value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function DevolverPorAlturas() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("PosicionID,Descripcion", "Posiciones", "AlturaID=" & AlturaID & " order by Descripcion")
    End Function

    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Posiciones.PosicionID,Posiciones.Descripcion,Alturas.Descripcion As Alturas", "Posiciones LEFT JOIN Alturas On Posiciones.AlturaID = Alturas.AlturaID")

    End Function

    Public Function Cargar() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Naves.NaveID, Piernas.PiernaID, Alturas.AlturaID", "Posiciones INNER JOIN Alturas ON Posiciones.AlturaID = Alturas.AlturaID INNER JOIN Piernas INNER JOIN  Naves ON Piernas.NaveID = Naves.NaveID ON Alturas.PiernaID = Piernas.PiernaID", "Posiciones.PosicionID = " & Convert.ToString(PosicionID))

    End Function


    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Posiciones", _
                             "Descripcion='" & Descripcion & "'," & _
                             "AlturaID=" & Convert.ToString(AlturaID) & "", _
                             "PosicionID=" & Convert.ToString(PosicionID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "'" & Descripcion & "'," & _
                              "" & Convert.ToString(AlturaID) & "", _
                              "Posiciones")
            PosicionID = BasesParaCompatibilidad.BD.ConsultaVer("max(PosicionID)", "Posiciones").Rows(0).Item(0)
            Return PosicionID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("Posiciones", "PosicionID = " & Convert.ToString(PosicionID)) = 0) Then
                MessageBox.Show("no se puede eliminar Posicion, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
