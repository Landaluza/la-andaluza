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
        dtb.AņadirParametroConsulta("@id", AnaliticaID)
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
        dtb.AņadirParametroConsulta("@id", LoteID)

        Return dtb.Consultar
    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        Return dtb.ConsultaAlteraciones("update Analiticas set " & _
                                                           "LoteID = " & Convert.ToString(LoteID) & "," & _
                                                           "AnalistaID = " & Convert.ToString(AnalistaID) & "," & _
                                                           "CatadorID = " & Convert.ToString(CatadorID) & _
                                                           "  where AnaliticaID = " & Convert.ToString(AnaliticaID))



    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        If Not dtb.ConsultaAlteraciones("insert into Analiticas values('" & Nombre & "'," & Convert.ToString(LoteID) & _
                                  "," & Convert.ToString(AnalistaID) & _
                                  "," & Convert.ToString(CatadorID) & _
                                  ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")") Then
            Return 0
        End If

        dtb.PrepararConsulta("select max(AnaliticaID) from Analiticas where AnaliticaID>0")
        Return dtb.Consultar().Rows(0).Item(0)


    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
     
            dtb.PrepararConsulta("delete from Analiticas where AnaliticaID = @id")
            dtb.AņadirParametroConsulta("@id", AnaliticaID)
            Return dtb.Consultar(True)
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("Analiticas", "AnaliticaID = " & AnaliticaID) = 0 Then
            '    MessageBox.Show("no se puede eliminar este Analitica, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            '    Return False
            'End If
            'Return True
       
    End Function
#End Region
End Class