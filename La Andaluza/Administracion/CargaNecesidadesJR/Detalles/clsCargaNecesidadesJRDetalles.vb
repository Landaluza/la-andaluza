Public Class clsCargaNecesidadesJRDetalles

    Private CargaNecesidadesJRDetalleID As Integer
    Private CargaNecesidadesJRMaestroID As Integer
    Private ArticuloID As Integer
    Private Carga As Integer
    Private Stock As Integer
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String


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

    Public Function Devolver(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select CargaNecesidadesJRDetalles.CargaNecesidadesJRDetalleID,CargaNecesidadesJRDetalles.CargaNecesidadesJRMaestroID,CargaNecesidadesJRDetalles.ArticuloID,CargaNecesidadesJRDetalles.Carga,CargaNecesidadesJRDetalles.Stock,CargaNecesidadesJRDetalles.Observaciones,CargaNecesidadesJRDetalles.Reserva1,CargaNecesidadesJRDetalles.Reserva2,CargaNecesidadesJRDetalles.Reserva3 from CargaNecesidadesJRDetalles")
        Return dtb.Consultar
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
