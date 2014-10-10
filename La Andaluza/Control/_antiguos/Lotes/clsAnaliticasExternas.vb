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
    Public Function Devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("*", "AnaliticasExternas")

    End Function

    Public Sub cargar()
        Try
            Dim tab As DataTable = BasesParaCompatibilidad.BD.ConsultaVer("*", "AnaliticasExternas", "AnaliticaID = " & Convert.ToString(AnaliticaID))
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

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("AnaliticasExternas", _
            "RutaAnalisis='" & RutaAnalisis & "'," & _
            "Fecha='" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
            "ProveedorID='" & Convert.ToString(ProveedorID) & "'," & _
            "AnaliticaID='" & Convert.ToString(AnaliticaID) & "'", _
            "AnaliticaExternaID=" & Convert.ToString(AnaliticaExternaID))


            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar("'" & RutaAnalisis & "'," & _
            "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
            If(ProveedorID = Nothing, "null", "'" & Convert.ToString(ProveedorID) & "'") & "," & _
            "'" & Convert.ToString(AnaliticaID) & "'", _
            "AnaliticasExternas")
            AnaliticaExternaID = BasesParaCompatibilidad.BD.ConsultaVer("max(AnaliticaExternaID)", "AnaliticasExternas").Rows(0).Item(0)
            Return AnaliticaExternaID
        Catch ex As Exception
            Return 0
        End Try
    End Function


    Public Function EliminarPorAnalitica() As Boolean
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("AnaliticasExternas", "AnaliticaID = " & Convert.ToString(AnaliticaID)) = 0 Then Return False

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

#End Region
End Class
