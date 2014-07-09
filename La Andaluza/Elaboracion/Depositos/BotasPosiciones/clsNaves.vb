Public Class clsNaves

#Region "Atributos"
    Private NaveID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property _NaveID() As Integer
        Get
            Return NaveID
        End Get

        Set(ByVal value As Integer)
            NaveID = value
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
    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Naves.NaveID,Naves.Descripcion", "Naves")

    End Function

    Public Function Modificar() As Integer


        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Naves", _
                              "Descripcion='" & Descripcion & "'", _
                              "NaveID=" & Convert.ToString(NaveID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer


        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "'" & Descripcion & "'", _
                              "Naves")
            NaveID = BasesParaCompatibilidad.BD.ConsultaVer("max(NaveID)", "Naves").Rows(0).Item(0)
            Return NaveID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("Naves", "NaveID = " & Convert.ToString(NaveID)) = 0) Then
                MessageBox.Show("no se puede eliminar Nave, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
