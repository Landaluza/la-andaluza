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
    Public Sub cargar()
        Try
            Dim tab As DataTable = BasesParaCompatibilidad.BD.ConsultaVer("AnalistaID,CatadorID", "Analiticas", "AnaliticaID = " & Convert.ToString(AnaliticaID))
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

    Function verAnalitica() As Integer
        Try
            AnaliticaID = BasesParaCompatibilidad.BD.ConsultaVer("AnaliticaID", "Analiticas", "Nombre = '" & Nombre & "'").Rows(0).Item(0)
            Return AnaliticaID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("*", "Analiticas", "AnaliticaID > 0")
    End Function

    Public Function DevolverPorMuestra() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("AnaliticaID, Nombre", "Analiticas", "LoteID = " & Convert.ToString(LoteID))
    End Function

    Public Function Modificar() As Integer

        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Analiticas", _
                                                           "LoteID = " & Convert.ToString(LoteID) & "," & _
                                                           "AnalistaID = " & Convert.ToString(AnalistaID) & "," & _
                                                           "CatadorID = " & Convert.ToString(CatadorID), _
                                                           "AnaliticaID = " & Convert.ToString(AnaliticaID))


            Return 1
        Catch ex As Exception
            Return 0
        End Try

    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar("'" & Nombre & "'," & Convert.ToString(LoteID) & "," & Convert.ToString(AnalistaID) & "," & Convert.ToString(CatadorID), "Analiticas")
            Return BasesParaCompatibilidad.BD.ConsultaVer("max(AnaliticaID)", "Analiticas", "AnaliticaID>0").Rows(0).Item(0)

        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Boolean
        Dim dtb As New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
        Try
            dtb.PrepararConsulta("delete from Analiticas where AnaliticaID = @id")
            dtb.AñadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("Analiticas", "AnaliticaID = " & AnaliticaID) = 0 Then
            '    MessageBox.Show("no se puede eliminar este Analitica, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            'Return True
        Catch ex As Exception
            Return False
        End Try
    End Function
#End Region
End Class