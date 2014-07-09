Public Class clsRecipientesSalidas

#Region "Atributos"
    Private RecipienteSalidaID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property _RecipienteSalidaID() As Integer
        Get
            Return RecipienteSalidaID
        End Get

        Set(ByVal value As Integer)
            RecipienteSalidaID = value
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

        Return BasesParaCompatibilidad.BD.ConsultaVer("RecipientesSalidas.RecipienteSalidaID,RecipientesSalidas.Descripcion", "RecipientesSalidas")
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("RecipientesSalidas", _
                       "Descripcion='" & Descripcion & "'", _
                       "RecipienteSalidaID=" & Convert.ToString(RecipienteSalidaID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "'" & Descripcion & "'", _
                       "RecipientesSalidas")
            RecipienteSalidaID = BasesParaCompatibilidad.BD.ConsultaVer("max(RecipienteSalidaID)", "RecipientesSalidas").Rows(0).Item(0)
            Return RecipienteSalidaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("RecipientesSalidas", "RecipienteSalidaID = " & Convert.ToString(RecipienteSalidaID)) = 0 Then
                MessageBox.Show("no se puede eliminar RecipienteSalida, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
