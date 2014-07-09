Public Class clsDepositos

#Region "Atributos"
    Private DepositoID As Integer
    Private Codigo As Integer
    Private FechaCreacion As Date
    Private Capacidad As Integer
    Private DoctoUbicacionFisica As String
    Private TonelID As String
    Private TransicubaID As String
    Private BotaID As String
    Private BotaPiernaID As String
    Private MaterialConstruccionID As String
    Private Listado As Boolean
    Private dtb As new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
#End Region

#Region "Propiedades"
    Public Property _DepositoID() As Integer
        Get
            Return DepositoID
        End Get

        Set(ByVal value As Integer)
            DepositoID = value
        End Set
    End Property

    Public Property _Codigo() As Integer
        Get
            Return Codigo
        End Get

        Set(ByVal value As Integer)
            Codigo = value
        End Set
    End Property

    Public Property _FechaCreacion() As DateTime
        Get
            Return FechaCreacion
        End Get

        Set(ByVal value As DateTime)
            FechaCreacion = value
        End Set
    End Property

    Public Property _Capacidad() As Double
        Get
            Return Capacidad
        End Get

        Set(ByVal value As Double)
            Capacidad = value
        End Set
    End Property

    Public Property _DoctoUbicacionFisica() As String
        Get
            Return DoctoUbicacionFisica
        End Get

        Set(ByVal value As String)
            DoctoUbicacionFisica = value
        End Set
    End Property

    Public Property _TonelID() As Integer
        Get
            If TonelID = "null" Then
                Return 0
            Else
                Return TonelID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TonelID = "null"
            Else
                TonelID = value
            End If
        End Set
    End Property

    Public Property _TransicubaID() As Integer
        Get
            If TransicubaID = "null" Then
                Return 0
            Else
                Return TransicubaID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TransicubaID = "null"
            Else
                TransicubaID = value
            End If
        End Set
    End Property

    Public Property _BotaID() As Integer
        Get
            If BotaID = "null" Then
                Return 0
            Else
                Return BotaID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                BotaID = "null"
            Else
                BotaID = value
            End If
        End Set
    End Property


    Public Property _BotaPiernaID() As Integer
        Get
            If BotaPiernaID = "null" Then
                Return 0
            Else
                Return BotaPiernaID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                BotaPiernaID = "null"
            Else
                BotaPiernaID = value
            End If
        End Set
    End Property

    Public Property _MaterialConstruccionID() As Integer
        Get
            If MaterialConstruccionID = "null" Then
                Return 0
            Else
                Return MaterialConstruccionID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                MaterialConstruccionID = "null"
            Else
                MaterialConstruccionID = value
            End If
        End Set
    End Property

    Public Property _Listado() As Boolean
        Get
            Return Listado
        End Get

        Set(ByVal value As Boolean)
            Listado = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function devolverDepositosFinales() As DataTable
        Return dtb.Consultar("devolverDepositosFinales", True)
    End Function

    Public Function devolverDepositosVacios() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Depositos.DepositoID, Depositos.Codigo, Lotes.CantidadRestante", "Lotes RIGHT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID", "(Depositos.BotaID Is NULL AND Lotes.CantidadRestante Is NULL) ORDER BY Depositos.Codigo")
    End Function

    Public Function devolverDepositosPartidas() As DataTable
        Return dtb.Consultar("devolverDepositosPartidas", True)
    End Function

    Public Function devolverDepositosLotes() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Depositos.Codigo,  Depositos.Capacidad, Depositos.Listado,Lotes.TipoLoteID, Lotes.CodigoLote, Lotes.CantidadRestante,CASE WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID) ELSE Lotes.Descripcion END AS Descripcion,Lotes.TipoProductoID,dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Acidez') as Acidez,dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Alcohol') as Alcohol, dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Densidad') as Densidad, dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Sulfuroso') as Sulfuroso", "Lotes RIGHT OUTER JOIN  Depositos ON Lotes.DepositoID = Depositos.DepositoID", "(Depositos.BotaID Is NULL and Depositos.Listado = 'TRUE') ORDER BY Depositos.Codigo")
    End Function

    Public Function devolverDepositosporCodigo() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("DepositoId,Codigo", "Depositos", "botaID is null ORDER BY Depositos.Codigo")
    End Function

    Public Sub Cargar()
        Try
            Dim tabla As New DataTable
            tabla = BasesParaCompatibilidad.BD.ConsultaVer("Depositos.FechaCreacion, Depositos.Capacidad,Depositos.DoctoUbicacionFisica,TonelID,TransicubaID, BotaID, BotaPiernaID", "Depositos", "DepositoID=" & DepositoID)

            If Convert.IsDBNull(tabla.Rows(0).Item(0)) Then
                FechaCreacion = datetime.now
            Else
                FechaCreacion = tabla.Rows(0).Item(0)
            End If

            Capacidad = tabla.Rows(0).Item(1)
            If Convert.IsDBNull(tabla.Rows(0).Item(2)) Then
                DoctoUbicacionFisica = ""
            Else
                DoctoUbicacionFisica = tabla.Rows(0).Item(2)
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(3)) Then
                _TonelID = 0
            Else
                TonelID = tabla.Rows(0).Item(3)
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(4)) Then
                _TransicubaID = 0
            Else
                TransicubaID = tabla.Rows(0).Item(4)
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(5)) Then
                _BotaID = 0
            Else
                BotaID = tabla.Rows(0).Item(5)
            End If
            If Convert.IsDBNull(tabla.Rows(0).Item(6)) Then
                _BotaPiernaID = 0
            Else
                BotaPiernaID = tabla.Rows(0).Item(6)
            End If
        Catch ex As Exception
            Capacidad = 0
            DoctoUbicacionFisica = ""
            _TonelID = 0
            _TransicubaID = 0
            _BotaID = 0
            _BotaPiernaID = 0
        End Try
    End Sub

    Public Function Limpiar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Depositos", _
                                 "TonelID=" & Convert.ToString(TonelID) & "," & _
                                 "TransicubaID=" & Convert.ToString(TransicubaID) & "," & _
                                 "BotaPiernaID=" & Convert.ToString(BotaPiernaID) & "," & _
                                 "BotaID=" & Convert.ToString(BotaID) & "", _
                                 "DepositoID=" & Convert.ToString(DepositoID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Depositos.DepositoID,Depositos.Codigo,Depositos.FechaCreacion,Depositos.Capacidad,Depositos.DoctoUbicacionFisica,Depositos.TonelID,Depositos.TransicubaID,Depositos.BotaID,Depositos.BotaPiernaID,MaterialConstruccion.descripcion, Listado", "Depositos left join MaterialConstruccion on Depositos.MaterialConstruccionID = MaterialConstruccion.MaterialConstruccionID", "Depositos.depositoID > 0 ORDER BY Depositos.Codigo")
    End Function

    Public Function devolverTransicubasActivas() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Depositos.TransicubaID,Depositos.Codigo", _
                              "Depositos INNER JOIN Transicubas ON Depositos.TransicubaID = Transicubas.TransicubaID", _
                              "(Transicubas.Estado = 'True')  and Depositos.DepositoID not in (SELECT DISTINCT Depositos.DepositoID FROM Depositos INNER JOIN Transicubas ON Depositos.TransicubaID = Transicubas.TransicubaID INNER JOIN Lotes ON Depositos.DepositoID = Lotes.DepositoID WHERE (Transicubas.Estado = 'True')) order by Depositos.Codigo")
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Depositos", _
                                 "Codigo=" & Convert.ToString(Codigo) & "," & _
                                 "FechaCreacion='" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaCreacion) & "'," & _
                                 "Capacidad='" & Capacidad & "'," & _
                                 "DoctoUbicacionFisica='" & DoctoUbicacionFisica & "'," & _
                                 "MaterialConstruccionID=" & Convert.ToString(MaterialConstruccionID) & "," & _
                                 "Listado='" & Convert.ToString(Listado) & "'," & _
                                 "TonelID=" & Convert.ToString(TonelID) & "," & _
                                 "TransicubaID=" & Convert.ToString(TransicubaID) & "," & _
                                 "BotaPiernaID=" & Convert.ToString(BotaPiernaID) & "," & _
                                 "BotaID=" & Convert.ToString(BotaID) & "", _
                                 "DepositoID=" & Convert.ToString(DepositoID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            Dim calendar As New BasesParaCompatibilidad.Calendar
            BasesParaCompatibilidad.BD.ConsultaInsertar( _
                              "" & Convert.ToString(Codigo) & "," & _
                              "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaCreacion) & "'," & _
                              "'" & Convert.ToString(Capacidad) & "'," & _
                              "'" & DoctoUbicacionFisica & "'," & _
                              "" & Convert.ToString(TonelID) & "," & _
                              "" & Convert.ToString(TransicubaID) & "," & _
                              "" & Convert.ToString(BotaID) & "," & Convert.ToString(BotaPiernaID) & "," & MaterialConstruccionID & ",'" & Listado & "'", _
                              "Depositos")

            DepositoID = BasesParaCompatibilidad.BD.ConsultaVer("max(DepositoID)", "Depositos").Rows(0).Item(0)
            Return DepositoID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("Depositos", "DepositoID = " & Convert.ToString(DepositoID)) = 0 Then
                MessageBox.Show("no se puede eliminar Deposito, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
