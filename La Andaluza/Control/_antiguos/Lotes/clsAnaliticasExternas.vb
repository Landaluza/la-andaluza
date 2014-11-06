Public Class clsAnaliticasExternas

#Region "Atributos"
    Private AnaliticaExternaID As Integer
    Private RutaAnalisis As String
    Private Fecha As DateTime
    Private ProveedorID As Integer
    Private AnaliticaID As Integer
#End Region

#Region "Propiedades"
    Public Property _AnaliticaExternaID() As Integer
        Get
            Return AnaliticaExternaID
        End Get

        Set(ByVal value As Integer)
            AnaliticaExternaID = value
        End Set
    End Property

    Public Property _RutaAnalisis() As String
        Get
            Return RutaAnalisis
        End Get

        Set(ByVal value As String)
            RutaAnalisis = value
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

    Public Property _ProveedorID() As Integer
        Get
            Return ProveedorID
        End Get

        Set(ByVal value As Integer)
            ProveedorID = value
        End Set
    End Property

    Public Property _AnaliticaID() As Integer
        Get
            Return AnaliticaID
        End Get

        Set(ByVal value As Integer)
            AnaliticaID = value
        End Set
    End Property

#End Region

#Region "Metodos"
 

    Public Sub cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select * from AnaliticasExternas where AnaliticaID =  @id")
        dtb.AñadirParametroConsulta("@id", AnaliticaID)
        Try
            Dim tab As DataTable = dtb.Consultar
            AnaliticaExternaID = tab.Rows(0).Item(0)
            RutaAnalisis = tab.Rows(0).Item(1)
            Fecha = tab.Rows(0).Item(2)
            ProveedorID = tab.Rows(0).Item(3)
        Catch ex As Exception
            AnaliticaExternaID = 0
            RutaAnalisis = ""
            Fecha = Today
            ProveedorID = 0
        End Try
    End Sub

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update AnaliticasExternas set RutaAnalisis= @rut, Fecha= @fec, ProveedorID= @pro, AnaliticaID= @ana where AnaliticaExternaID= @id")

        dtb.AñadirParametroConsulta("@rut", RutaAnalisis)
        dtb.AñadirParametroConsulta("@fec", Fecha.Date)
        dtb.AñadirParametroConsulta("@pro", ProveedorID)
        dtb.AñadirParametroConsulta("@ana", AnaliticaID)
        dtb.AñadirParametroConsulta("@id", AnaliticaExternaID)
        Return dtb.Execute
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        If Not dtb.ConsultaAlteraciones("insert into AnaliticasExternas values('" & RutaAnalisis & "'," & _
                        "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                        If(ProveedorID = Nothing, "null", "'" & Convert.ToString(ProveedorID) & "'") & "," & _
                        "'" & Convert.ToString(AnaliticaID) & "'" & _
                        ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")") Then

            AnaliticaExternaID = 0
        Else
            dtb.PrepararConsulta("select max(AnaliticaExternaID) from AnaliticasExternas")
            AnaliticaExternaID = dtb.Consultar().Rows(0).Item(0)
        End If
        
        Return AnaliticaExternaID

    End Function


    Public Function EliminarPorAnalitica(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
       
            dtb.PrepararConsulta("delete from AnaliticasExternas where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
        Return dtb.Execute
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasExternas", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False

            'Return True
     
    End Function

#End Region
End Class
