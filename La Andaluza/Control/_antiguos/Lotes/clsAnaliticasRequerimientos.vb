Public Class clsAnaliticasRequerimientos
#Region "Atributos"
    Private AnaliticaID As Integer
    Private ParametroID As Integer
#End Region

#Region "Propiedades"
    Public Property _AnaliticaID() As Integer
        Get
            Return AnaliticaID
        End Get

        Set(ByVal value As Integer)
            AnaliticaID = value
        End Set
    End Property

    Public Property _ParametroID() As Integer
        Get
            Return ParametroID
        End Get

        Set(ByVal value As Integer)
            ParametroID = value
        End Set
    End Property

#End Region


#Region "Propiedades"


    Public Function existe() As Boolean

        Return Convert.ToBoolean(BasesParaCompatibilidad.BD.ConsultaVer("Count(*)", "AnaliticasRequerimientos", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ParametroID = " & Convert.ToString(ParametroID)).Rows(0).Item(0) > 0)

    End Function


    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar(Convert.ToString(AnaliticaID) & "," & Convert.ToString(ParametroID), "AnaliticasRequerimientos")
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)

        Try
            dtb.PrepararConsulta("delete from AnaliticasRequerimientos where AnaliticaID = @ana and ParametroID = @par")
            dtb.AñadirParametroConsulta("@ana", AnaliticaID)
            dtb.AñadirParametroConsulta("@par", ParametroID)

            If dtb.Consultar(True) Then
                Return 1
            Else
                Return 0
            End If
            'BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasRequerimientos", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ParametroID = " & Convert.ToString(ParametroID))


            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function EliminarPorAnalitica() As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Try
            dtb.PrepararConsulta("delete from AnaliticasRequerimientos where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasRequerimientos", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False


            'Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class
