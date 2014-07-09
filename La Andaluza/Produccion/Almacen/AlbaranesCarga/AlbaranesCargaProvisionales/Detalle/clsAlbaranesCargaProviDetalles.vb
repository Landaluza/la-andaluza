Public Class clsAlbaranesCargaProviDetalles


#Region "Atributos"
    Private AlbaranCargaProviDetalleID As Integer
    Private AlbaranCargaProviMaestroID As Integer
    Private SCC As Integer
    Private CodigoQS As Integer
    Private AticuloDescripcion As String
    Private Cajas As Integer
    Private UnidadMedidaID As Integer
    Private Lote As String
    Private TipoPaletID As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
    Private LoteAlternativo As String

#End Region

#Region "Propiedades"
    Public Property _AlbaranCargaProviDetalleID() As Integer
        Get
            Return AlbaranCargaProviDetalleID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProviDetalleID = value
        End Set
    End Property


    Public Property _AlbaranCargaProviMaestroID() As Integer
        Get
            Return AlbaranCargaProviMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaProviMaestroID = value
        End Set
    End Property

    Public Property _SCC() As Integer
        Get
            Return SCC
        End Get

        Set(ByVal value As Integer)
            SCC = value
        End Set
    End Property

    Public Property _CodigoQS() As Integer
        Get
            Return CodigoQS
        End Get

        Set(ByVal value As Integer)
            CodigoQS = value
        End Set
    End Property

    Public Property _AticuloDescripcion() As String
        Get
            Return AticuloDescripcion
        End Get

        Set(ByVal value As String)
            AticuloDescripcion = value
        End Set
    End Property

    Public Property _Cajas() As Integer
        Get
            Return Cajas
        End Get

        Set(ByVal value As Integer)
            Cajas = value
        End Set
    End Property

    Public Property _UnidadMedidaID() As Integer
        Get
            Return UnidadMedidaID
        End Get

        Set(ByVal value As Integer)
            UnidadMedidaID = value
        End Set
    End Property

    Public Property _Lote() As String
        Get
            Return Lote
        End Get

        Set(ByVal value As String)
            Lote = value
        End Set
    End Property

    Public Property _TipoPaletID() As Integer
        Get
            Return TipoPaletID
        End Get

        Set(ByVal value As Integer)
            TipoPaletID = value
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

    Public Property _LoteAlternativo() As String
        Get
            Return LoteAlternativo
        End Get

        Set(ByVal value As String)
            LoteAlternativo = value
        End Set
    End Property

#End Region

#Region "Metodos"

    Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("AlbaranesCargaProviDetalles.AlbaranCargaProviDetalleID,AlbaranesCargaProviDetalles.AlbaranCargaProviMaestroID,AlbaranesCargaProviDetalles.SCC,AlbaranesCargaProviDetalles.CodigoQS,AlbaranesCargaProviDetalles.AticuloDescripcion,AlbaranesCargaProviDetalles.Cajas,AlbaranesCargaProviDetalles.UnidadMedidaID,AlbaranesCargaProviDetalles.Lote,AlbaranesCargaProviDetalles.TipoPaletID,AlbaranesCargaProviDetalles.Observaciones,AlbaranesCargaProviDetalles.Reserva1,AlbaranesCargaProviDetalles.Reserva2,AlbaranesCargaProviDetalles.Reserva3", "AlbaranesCargaProviDetalles")
    End Function

    Public Function SelectPaletsByAlbaranPro(ByVal AlbaranID As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaProcedAlmacenado("SelectPaletsByAlbaranPro", Convert.ToString(AlbaranID))
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("AlbaranesCargaProviDetalles", _
                       "AlbaranCargaProviMaestroID=" & Convert.ToString(AlbaranCargaProviMaestroID) & "," & _
                       "SCC=" & Convert.ToString(SCC) & "," & _
                       "CodigoQS=" & Convert.ToString(CodigoQS) & "," & _
                       "AticuloDescripcion='" & AticuloDescripcion & "'," & _
                       "Cajas=" & Convert.ToString(Cajas) & "," & _
                       "UnidadMedidaID=" & Convert.ToString(UnidadMedidaID) & "," & _
                       "Lote='" & Lote & "'," & _
                       "TipoPaletID=" & Convert.ToString(TipoPaletID) & "," & _
                       "Observaciones='" & Observaciones & "'," & _
                       "Reserva1='" & Reserva1 & "'," & _
                       "Reserva2='" & Reserva2 & "'," & _
                       "LoteAlternativo='" & LoteAlternativo & "'," & _
                       "Reserva3='" & Reserva3 & "'",
                       "AlbaranCargaProviDetalleID=" & Convert.ToString(AlbaranCargaProviDetalleID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaInsertarConcampos( _
                "([AlbaranCargaProviMaestroID],[SCC] ,[CodigoQS] ,[AticuloDescripcion] ,[Cajas] ,[UnidadMedidaID] ,[Lote],[TipoPaletID] ,[Observaciones] ,[Reserva1] ,[Reserva2] ,[Reserva3], LoteAlternativo, FechaModificacion, UsuarioModificacion)", _
                       "" & Convert.ToString(AlbaranCargaProviMaestroID) & "," & _
                       "" & Convert.ToString(SCC) & "," & _
                       "" & Convert.ToString(CodigoQS) & "," & _
                       "'" & AticuloDescripcion & "'," & _
                       "" & Convert.ToString(Cajas) & "," & _
                       "" & Convert.ToString(UnidadMedidaID) & "," & _
                       "'" & Lote & "'," & _
                       "" & Convert.ToString(TipoPaletID) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'," & _
                       "'" & LoteAlternativo & "'", _
                       "AlbaranesCargaProviDetalles") = 1 Then

                AlbaranCargaProviDetalleID = (BasesParaCompatibilidad.BD.ConsultaVer("max(AlbaranCargaProviDetalleID)", "AlbaranesCargaProviDetalles").Rows(0).Item(0))
                Return AlbaranCargaProviDetalleID
            Else
                Return 0
            End If
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If (BasesParaCompatibilidad.BD.ConsultaEliminar("AlbaranesCargaProviDetalles", "AlbaranCargaProviDetalleID = " & Convert.ToString(AlbaranCargaProviDetalleID)) = 0) Then
                MessageBox.Show("no se puede eliminar AlbaranCargaProviDetalle, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
