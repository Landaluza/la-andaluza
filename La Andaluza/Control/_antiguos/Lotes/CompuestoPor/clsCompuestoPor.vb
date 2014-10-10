Public Class clsCompuestoPor

#Region "Atributos"
    Private LoteFinal As Integer
    Private LotePartida As Integer
    Private MovimientoID As String
    Private Cantidad As Double
#End Region

#Region "Propiedades"
    Public Property _LoteFinal() As Integer
        Get
            Return LoteFinal
        End Get

        Set(ByVal value As Integer)
            LoteFinal = value
        End Set
    End Property

    Public Property _LotePartida() As Integer
        Get
            Return LotePartida
        End Get

        Set(ByVal value As Integer)
            LotePartida = value
        End Set
    End Property

    Public Property _Cantidad() As Double
        Get
            Return Cantidad
        End Get

        Set(ByVal value As Double)
            Cantidad = value
        End Set
    End Property

    Public Property _MovimientoID() As Integer
        Get
            If MovimientoID = "null" Then
                Return 0
            Else
                Return MovimientoID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                MovimientoID = "null"
            Else
                MovimientoID = value
            End If
        End Set
    End Property

#End Region

#Region "Metodos"
    Public Function DevolverPorMovimiento() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("LoteFinal,LotePartida,Cantidad", "CompuestoPor", "MovimientoID=" & Convert.ToString(MovimientoID))
    End Function


    Public Function Insertar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaInsertar("" & Convert.ToString(LoteFinal) & "," & _
                                "" & Convert.ToString(LotePartida) & "," & _
                                "" & Convert.ToString(MovimientoID) & "," & _
                                "'" & Convert.ToString(Cantidad).Replace(",", ".") & "'", _
                                "CompuestoPor") = 0 Then
                LoteFinal = 0
                Return 0
            End If

            LoteFinal = BasesParaCompatibilidad.BD.ConsultaVer("max(LoteFinal)", "CompuestoPor").Rows(0).Item(0)
            Return LoteFinal
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function RevertirMovimiento() As Boolean
        Dim dt As DataTable
        Try
            dt = BasesParaCompatibilidad.BD.ConsultaProcedAlmacenado("RevertirMovimiento", Convert.ToString(LotePartida) & "," & "'" & Convert.ToString(Cantidad).Replace(",", ".") & "'")
            If dt Is Nothing Then Return False
            If dt.Rows.Count = 0 Then Return False
            If dt.Rows(0).Item(0) Is Convert.DBNull Then Return False

            If Convert.ToBoolean(dt.Rows(0).Item(0)) <> True Then Return False

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function


#End Region
End Class
