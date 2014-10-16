Public Class clsTransicubas

#Region "Atributos"
    Private TransicubaID As Integer
    Private Descripcion As String
    Private Estado As Boolean
#End Region

#Region "Propiedades"
    Public Property _TransicubaID() As Integer
        Get
            Return TransicubaID
        End Get

        Set(ByVal value As Integer)
            TransicubaID = value
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

    Public Property _Estado() As Boolean
        Get
            Return Estado
        End Get

        Set(ByVal value As Boolean)
            Estado = value
        End Set
    End Property

#End Region

#Region "Metodos"
  

    Public Sub Cargar()
        Try
            Dim tabla As New DataTable
            tabla = BasesParaCompatibilidad.BD.ConsultaVer("Transicubas.Descripcion,Transicubas.Estado", "Transicubas", "TransicubaID=" & Convert.ToString(TransicubaID))

            If Convert.IsDBNull(tabla.Rows(0).Item(0)) Then
                Descripcion = ""
            Else
                Descripcion = tabla.Rows(0).Item(0)
            End If
            Estado = tabla.Rows(0).Item(1)
        Catch ex As Exception
            Descripcion = ""
            Estado = False
        End Try
    End Sub


    Public Function darDeBajaTransicuba() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaModificar("Transicubas", _
                       "Estado='False'", _
                       "TransicubaID=" & Convert.ToString(TransicubaID)) = 0 Then
                Return 0
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function
    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Transicubas", _
                       "Descripcion='" & Descripcion & "'," & _
                       "Estado='" & Estado & "'", _
                       "TransicubaID=" & Convert.ToString(TransicubaID))


            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "'" & Descripcion & "'," & _
                       "'" & Estado & "'", _
                       "Transicubas")



            TransicubaID = BasesParaCompatibilidad.BD.ConsultaVer("max(TransicubaID)", "Transicubas").Rows(0).Item(0)
            Return TransicubaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        Try
            dtb.PrepararConsulta("delete from Transicubas where TransicubaID = @id")
            dtb.AñadirParametroConsulta("@id", TransicubaID)
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Transicuba, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If
            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("Transicubas", "TransicubaID = " & Convert.ToString(TransicubaID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar Transicuba, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'TransicubaID = 0
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
