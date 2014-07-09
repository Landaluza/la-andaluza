Public Class clsAlbaranCargaProMaestro

#Region "Atributos"
    Private AlbaranCargaProMaestroID As Integer
    Private Numero As Integer
    Private Fecha As DateTime
    Private ResponsableCargaID As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
    Private CodigoPedidoMaestro As Integer
    Private OrdenCarga As Integer
#End Region

#Region "Propiedades"
    Public Property _AlbaranCargaProMaestroID() As Integer
        Get
            Return AlbaranCargaProMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProMaestroID = value
        End Set
    End Property

    Public Property _CodigoPedidoMaestro() As Integer
        Get
            Return CodigoPedidoMaestro
        End Get

        Set(ByVal value As Integer)
            CodigoPedidoMaestro = value
        End Set
    End Property

    Public Property _OrdenCarga() As Integer
        Get
            Return OrdenCarga
        End Get

        Set(ByVal value As Integer)
            OrdenCarga = value
        End Set
    End Property

    Public Property _Numero() As Integer
        Get
            Return Numero
        End Get

        Set(ByVal value As Integer)
            Numero = value
        End Set
    End Property

    Public Property _Fecha() As DateTime
        Get
            Return Fecha
        End Get

        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property

    Public Property _ResponsableCargaID() As Integer
        Get
            Return ResponsableCargaID
        End Get

        Set(ByVal value As Integer)
            ResponsableCargaID = value
        End Set
    End Property

    Public Property _Observaciones() As String
        Get
            Return Observaciones
        End Get

        Set(ByVal value As String)
            Observaciones = value
        End Set
    End Property

    Public Property _Reserva1() As String
        Get
            Return Reserva1
        End Get

        Set(ByVal value As String)
            Reserva1 = value
        End Set
    End Property

    Public Property _Reserva2() As String
        Get
            Return Reserva2
        End Get

        Set(ByVal value As String)
            Reserva2 = value
        End Set
    End Property

    Public Property _Reserva3() As String
        Get
            Return Reserva3
        End Get

        Set(ByVal value As String)
            Reserva3 = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("AlbaranCargaProMaestro.AlbaranCargaProMaestroID,AlbaranCargaProMaestro.Numero,AlbaranCargaProMaestro.Fecha,AlbaranCargaProMaestro.ResponsableCargaID,AlbaranCargaProMaestro.Observaciones,AlbaranCargaProMaestro.Reserva1,AlbaranCargaProMaestro.Reserva2,AlbaranCargaProMaestro.Reserva3", "AlbaranCargaProMaestro")
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("AlbaranCargaProMaestro", _
                       "Numero=" & Convert.ToString(Numero) & "," & _
                       "Fecha='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "ResponsableCargaID=" & Convert.ToString(ResponsableCargaID) & "," & _
                       "Observaciones='" & Observaciones & "'," & _
                       "Reserva1='" & Reserva1 & "'," & _
                       "Reserva2='" & Reserva2 & "'," & _
                       "Reserva3='" & Reserva3 & "'", _
                       "AlbaranCargaProMaestroID=" & Convert.ToString(AlbaranCargaProMaestroID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "" & Convert.ToString(Numero) & "," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "" & Convert.ToString(ResponsableCargaID) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'", _
                       "AlbaranCargaProMaestro")
            AlbaranCargaProMaestroID = BasesParaCompatibilidad.BD.ConsultaVer("max(AlbaranCargaProMaestroID)", "AlbaranCargaProMaestro").Rows(0).Item(0)
            Return AlbaranCargaProMaestroID
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function Insertar(ByVal par As Boolean) As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertarConcampos( _
                        "([Numero] ,[Fecha],[ResponsableCargaID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3] ,[FechaModificacion] ,[UsuarioModificacion] )", _
                       "" & Convert.ToString(Numero) & "," & _
                       "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                       "" & Convert.ToString(ResponsableCargaID) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'", _
                       "AlbaranCargaProMaestro")
            AlbaranCargaProMaestroID = BasesParaCompatibilidad.BD.ConsultaVer("max(AlbaranCargaProMaestroID)", "AlbaranCargaProMaestro").Rows(0).Item(0)

            If CodigoPedidoMaestro <> Nothing Then
                BasesParaCompatibilidad.BD.ConsultaModificar("PedidosClientesMaestros", _
                          "id_albaranCargaProMaestro= " & Convert.ToString(AlbaranCargaProMaestroID) & "", _
                          "PedidoClienteMaestroID=" & Convert.ToString(CodigoPedidoMaestro))
            Else
                BasesParaCompatibilidad.BD.ConsultaModificar("OrdenesCarga", _
                       "id_albaranCargaProMaestro=" & Convert.ToString(AlbaranCargaProMaestroID) & "", _
                       "OrdenCargaID=" & Convert.ToString(OrdenCarga))
            End If

            Return AlbaranCargaProMaestroID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("AlbaranCargaProMaestro", "AlbaranCargaProMaestroID = " & Convert.ToString(AlbaranCargaProMaestroID)) = 0 Then
                MessageBox.Show("no se puede eliminar AlbaranCargaProMaestro, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class

