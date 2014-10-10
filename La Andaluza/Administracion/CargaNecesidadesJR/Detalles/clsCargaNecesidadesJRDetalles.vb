Public Class clsCargaNecesidadesJRDetalles

#Region "Atributos"
    Private CargaNecesidadesJRDetalleID As Integer
    Private CargaNecesidadesJRMaestroID As Integer
    Private ArticuloID As Integer
    Private Carga As Integer
    Private Stock As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
#End Region

#Region "Propiedades"
    Public Property _CargaNecesidadesJRDetalleID() As Integer
        Get
            Return CargaNecesidadesJRDetalleID
        End Get

        Set(ByVal value As Integer)
            CargaNecesidadesJRDetalleID = value
        End Set
    End Property

    Public Property _CargaNecesidadesJRMaestroID() As Integer
        Get
            Return CargaNecesidadesJRMaestroID
        End Get

        Set(ByVal value As Integer)
            CargaNecesidadesJRMaestroID = value
        End Set
    End Property

    Public Property _ArticuloID() As Integer
        Get
            Return ArticuloID
        End Get

        Set(ByVal value As Integer)
            ArticuloID = value
        End Set
    End Property

    Public Property _Carga() As Integer
        Get
            Return Carga
        End Get

        Set(ByVal value As Integer)
            Carga = value
        End Set
    End Property

    Public Property _Stock() As Integer
        Get
            Return Stock
        End Get

        Set(ByVal value As Integer)
            Stock = value
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

        Return BasesParaCompatibilidad.BD.ConsultaVer("CargaNecesidadesJRDetalles.CargaNecesidadesJRDetalleID,CargaNecesidadesJRDetalles.CargaNecesidadesJRMaestroID,CargaNecesidadesJRDetalles.ArticuloID,CargaNecesidadesJRDetalles.Carga,CargaNecesidadesJRDetalles.Stock,CargaNecesidadesJRDetalles.Observaciones,CargaNecesidadesJRDetalles.Reserva1,CargaNecesidadesJRDetalles.Reserva2,CargaNecesidadesJRDetalles.Reserva3", "CargaNecesidadesJRDetalles")
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("CargaNecesidadesJRDetalles", _
                       "CargaNecesidadesJRMaestroID=" & Convert.ToString(CargaNecesidadesJRMaestroID) & "," & _
                       "ArticuloID=" & Convert.ToString(ArticuloID) & "," & _
                       "Carga=" & Convert.ToString(Carga) & "," & _
                       "Stock=" & Convert.ToString(Stock) & "," & _
                       "Observaciones='" & Observaciones & "'," & _
                       "Reserva1='" & Reserva1 & "'," & _
                       "Reserva2='" & Reserva2 & "'," & _
                       "Reserva3='" & Reserva3 & "'", _
                       "CargaNecesidadesJRDetalleID=" & Convert.ToString(CargaNecesidadesJRDetalleID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                       "" & Convert.ToString(CargaNecesidadesJRMaestroID) & "," & _
                       "" & Convert.ToString(ArticuloID) & "," & _
                       "" & Convert.ToString(Carga) & "," & _
                       "" & Convert.ToString(Stock) & "," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "'", _
                       "CargaNecesidadesJRDetalles")
            CargaNecesidadesJRDetalleID = BasesParaCompatibilidad.BD.ConsultaVer("max(CargaNecesidadesJRDetalleID)", "CargaNecesidadesJRDetalles").Rows(0).Item(0)
            Return CargaNecesidadesJRDetalleID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
       

        Try
            dtb.PrepararConsulta("Delete from CargaNecesidadesJRDetalles where CargaNecesidadesJRDetalleID = @id")
            dtb.AñadirParametroConsulta("@id", CargaNecesidadesJRDetalleID)

            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar CargaNecesidadesJRDetalle, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If

        Catch ex As Exception
            Return 0
        End Try
        'Try
        '    If BasesParaCompatibilidad.BD.ConsultaEliminar("CargaNecesidadesJRDetalles", "CargaNecesidadesJRDetalleID = " & Convert.ToString(CargaNecesidadesJRDetalleID)) = 0 Then
        '        MessageBox.Show("no se puede eliminar CargaNecesidadesJRDetalle, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    End If
        '    Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

#End Region
End Class
