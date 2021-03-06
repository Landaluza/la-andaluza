Public Class clsAnaliticasValores
#Region "Atributos"
    Private AnaliticaID As Integer
    Private ParametroID As Integer
    Private Valor As Double
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

    Public Property _Valor() As Double
        Get
            Return Valor
        End Get

        Set(ByVal value As Double)
            Valor = value
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


#Region "Metodos"

    Public Function existe(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select Count(*) from AnaliticasValores where AnaliticaID = @ana and ParametroID = @par")
        dtb.AņadirParametroConsulta("@ana", AnaliticaID)
        dtb.AņadirParametroConsulta("@par", ParametroID)
        Return dtb.Consultar().Rows(0).Item(0) > 0
    End Function

    Public Function cargar(ByRef dtb As BasesParaCompatibilidad.DataBase) As String
        dtb.PrepararConsulta("select Valor from AnaliticasValores where AnaliticaID = @id and ParametroID = @par")
        dtb.AņadirParametroConsulta("@id", AnaliticaID)
        dtb.AņadirParametroConsulta("@par", ParametroID)
        Try
            Return dtb.Consultar().Rows(0).Item(0)
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("insert into AnaliticasValores values( @ana , @par , @val , @fecha , @user )")
        dtb.AņadirParametroConsulta("@ana", AnaliticaID)
        dtb.AņadirParametroConsulta("@par", ParametroID)
        dtb.AņadirParametroConsulta("@val", Valor)
        dtb.AņadirParametroConsulta("@fecha", BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay))
        dtb.AņadirParametroConsulta("@user", BasesParaCompatibilidad.Config.User)

        Return dtb.Execute

    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update AnaliticasValores set Valor = @val where AnaliticaID = @ana and ParametroID = @par")
        dtb.AņadirParametroConsulta("@val", Valor) 'Convert.ToString(Valor).Replace(",", ".")
        dtb.AņadirParametroConsulta("@ana", AnaliticaID)
        dtb.AņadirParametroConsulta("@par", ParametroID)
        Return dtb.Execute

    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

            dtb.PrepararConsulta("delete from AnaliticasValores where AnaliticaID = @ana and ParametroID = @par")
            dtb.AņadirParametroConsulta("@ana", AnaliticaID)
            dtb.AņadirParametroConsulta("@par", ParametroID)

        Return dtb.Execute

        'BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasValores", "AnaliticaID = " & Convert.ToString(AnaliticaID) & " and ParametroID = " & Convert.ToString(ParametroID))
        'Return 1
    End Function

    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from AnaliticasValores where AnaliticaID = @id")
        dtb.AņadirParametroConsulta("@id", AnaliticaID)
        Return dtb.Execute
        'If BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasValores", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False
        'Return True

    End Function
#End Region
End Class
