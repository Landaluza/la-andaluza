Public Class clsAlbaranesCargaDetalles


#Region "Atributos"
    Private AlbaranCargaDetalleID As Integer
    Private AlbaranCargaMaestroID As Integer
    Private Scc As Integer
    Private CodigoQS As Integer
    Private AticuloDescripcion As String
    Private Cajas As Integer
    Private UnidadMedida As String
    Private Lote As String
    Private TipoPalet As String
    Private Observaciones As String
    Private Reserva1 As String
    Private Reserva2 As String
    Private Reserva3 As String
#End Region

#Region "Propiedades"
    Public Property _AlbaranCargaDetalleID() As Integer
        Get
            Return AlbaranCargaDetalleID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaDetalleID = value
        End Set
    End Property

    Public Property _AlbaranCargaMaestroID() As Integer
        Get
            Return AlbaranCargaMaestroID
        End Get

        Set(ByVal value As Integer)
            AlbaranCargaMaestroID = value
        End Set
    End Property

    Public Property _Scc() As Integer
        Get
            Return Scc
        End Get

        Set(ByVal value As Integer)
            Scc = value
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

    Public Property _UnidadMedida() As String
        Get
            Return UnidadMedida
        End Get

        Set(ByVal value As String)
            UnidadMedida = value
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

    Public Property _TipoPalet() As String
        Get
            Return TipoPalet
        End Get

        Set(ByVal value As String)
            TipoPalet = value
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
        dtb.PrepararConsulta("select AlbaranesCargaDetalles.AlbaranCargaDetalleID,AlbaranesCargaDetalles.AlbaranCargaMaestroID,AlbaranesCargaDetalles.Scc,AlbaranesCargaDetalles.CodigoQS,AlbaranesCargaDetalles.AticuloDescripcion,AlbaranesCargaDetalles.Cajas,AlbaranesCargaDetalles.UnidadMedida,AlbaranesCargaDetalles.Lote,AlbaranesCargaDetalles.TipoPalet,AlbaranesCargaDetalles.Observaciones,AlbaranesCargaDetalles.Reserva1,AlbaranesCargaDetalles.Reserva2,AlbaranesCargaDetalles.Reserva3 from AlbaranesCargaDetalles")
        Return dtb.Consultar()
    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.ConsultaAlteraciones("update AlbaranesCargaDetalles set " & _
                       "AlbaranCargaMaestroID=" & Convert.ToString(AlbaranCargaMaestroID) & "," & _
                       "Scc=" & Convert.ToString(Scc) & "," & _
                       "CodigoQS=" & Convert.ToString(CodigoQS) & "," & _
                       "AticuloDescripcion='" & AticuloDescripcion & "'," & _
                       "Cajas=" & Convert.ToString(Cajas) & "," & _
                       "UnidadMedida='" & UnidadMedida & "'," & _
                       "Lote='" & Lote & "'," & _
                       "TipoPalet='" & TipoPalet & "'," & _
                       "Observaciones='" & Observaciones & "'," & _
                       "Reserva1='" & Reserva1 & "'," & _
                       "Reserva2='" & Reserva2 & "'," & _
                       "Reserva3='" & Reserva3 & "'" & _
                       " where AlbaranCargaDetalleID=" & Convert.ToString(AlbaranCargaDetalleID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.ConsultaAlteraciones("insert into AlbaranesCargaDetalles values(" & _
                       "" & Convert.ToString(AlbaranCargaMaestroID) & "," & _
                       "" & Convert.ToString(Scc) & "," & _
                       "" & Convert.ToString(CodigoQS) & "," & _
                       "'" & AticuloDescripcion & "'," & _
                       "" & Convert.ToString(Cajas) & "," & _
                       "'" & UnidadMedida & "'," & _
                       "'" & Lote & "'," & _
                       "'" & TipoPalet & "'," & _
                       "'" & Observaciones & "'," & _
                       "'" & Reserva1 & "'," & _
                       "'" & Reserva2 & "'," & _
                       "'" & Reserva3 & "','" & _
                       BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")")


            dtb.PrepararConsulta("select max(AlbaranCargaDetalleID) from AlbaranesCargaDetalles")
            AlbaranCargaDetalleID = dtb.Consultar().Rows(0).Item(0)
            Return AlbaranCargaDetalleID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        'Dim dtb As BasesParaCompatibilidad.DataBase 
        Try
            dtb.PrepararConsulta("delete from AlbaranesCargaDetalles where AlbaranCargaDetalleID = @id")
            dtb.AñadirParametroConsulta("@id", AlbaranCargaDetalleID)
            Return dtb.Execute
            'If (BasesParaCompatibilidad.BD.ConsultaEliminar("AlbaranesCargaDetalles", "AlbaranCargaDetalleID = " & Convert.ToString(AlbaranCargaDetalleID)) = 0) Then
            '    MessageBox.Show("no se puede eliminar AlbaranCargaDetalle, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'End If
            'Return 1
        Catch ex As Exception
            MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'Return 0
            Return False
        End Try
    End Function

#End Region
End Class
