Public Class clsAnaliticas

#Region "Atributos"
    Private AnaliticaID As Integer
    Private Nombre As String
    Private LoteID As Integer
    Private AnalistaID As String
    Private CatadorID As String

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

    Public Property _Nombre() As String
        Get
            Return Nombre
        End Get

        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property _LoteID() As Integer
        Get
            Return LoteID
        End Get

        Set(ByVal value As Integer)
            LoteID = value
        End Set
    End Property

    Public Property _AnalistaID() As Integer
        Get
            If AnalistaID = "null" Then
                Return 0
            Else
                Return (AnalistaID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                AnalistaID = "null"
            Else
                AnalistaID = value.ToString
            End If
        End Set
    End Property

    Public Property _CatadorID() As Integer
        Get
            If CatadorID = "null" Then
                Return 0
            Else
                Return Convert.ToInt32(CatadorID)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                CatadorID = "null"
            Else
                CatadorID = value.ToString
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select AnalistaID,CatadorID from Analiticas where AnaliticaID = @id")
        dtb.AñadirParametroConsulta("@id", AnaliticaID)
        Try
            Dim tab As DataTable = dtb.Consultar
            If IsDBNull(tab.Rows(0).Item(0)) Then
                _AnalistaID = 0
            Else
                _AnalistaID = tab.Rows(0).Item(0)
            End If
            If IsDBNull(tab.Rows(0).Item(1)) Then
                _CatadorID = 0
            Else
                _CatadorID = tab.Rows(0).Item(1)
            End If
        Catch ex As Exception
            _AnalistaID = 0
            _CatadorID = 0
        End Try
    End Sub


    Public Function DevolverPorMuestra(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable

        dtb.PrepararConsulta("select AnaliticaID, Nombre from Analiticas where LoteID = @id")
        dtb.AñadirParametroConsulta("@id", LoteID)

        Return dtb.Consultar
    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update Analiticas set " & _
                                                           "LoteID = @id," & _
                                                           "AnalistaID = @ana," & _
                                                           "CatadorID = @cat" & _
                                                           "  where AnaliticaID = @an2")
        dtb.AñadirParametroConsulta("@id", LoteID)
        dtb.AñadirParametroConsulta("@ana", AnalistaID)
        dtb.AñadirParametroConsulta("@cat", CatadorID)
        dtb.AñadirParametroConsulta("@an2", AnaliticaID)

        Return dtb.Execute



    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("insert into Analiticas([Nombre],[LoteID],[AnalistaID],[CatadorID],[FechaModificacion],[UsuarioModificacion]) " & _
                                        "values(@nom, @lot, @ana, @cat, @fec, @usr)")
        dtb.AñadirParametroConsulta("@nom", Nombre)
        dtb.AñadirParametroConsulta("@lot", LoteID)
        dtb.AñadirParametroConsulta("@ana", AnalistaID)
        dtb.AñadirParametroConsulta("@cat", CatadorID)
        dtb.AñadirParametroConsulta("@fec", Now.Date)
        dtb.AñadirParametroConsulta("@usr", BasesParaCompatibilidad.Config.User)

        If Not dtb.Execute Then
            Return 0
        End If

        dtb.PrepararConsulta("select max(AnaliticaID) from Analiticas where AnaliticaID>0")
        Return dtb.Consultar().Rows(0).Item(0)
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
     
            dtb.PrepararConsulta("delete from Analiticas where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
        Return dtb.Execute
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("Analiticas", "AnaliticaID = " & AnaliticaID) = 0 Then
            '    MessageBox.Show("no se puede eliminar este Analitica, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            'Return True
       
    End Function
#End Region
End Class