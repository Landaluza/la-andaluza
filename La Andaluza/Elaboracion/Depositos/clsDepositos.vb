Public Class clsDepositos

#Region "Atributos"
    Private DepositoID As Integer
    Private Codigo As String
    Private FechaCreacion As Date
    Private Capacidad As Integer
    Private DoctoUbicacionFisica As String
    Private TonelID As String
    Private TransicubaID As String
    Private BotaID As String
    Private BotaPiernaID As String
    Private MaterialConstruccionID As String
    Private Listado As Boolean
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

    Public Property _Codigo() As String
        Get
            Return Codigo
        End Get

        Set(ByVal value As String)
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

    Public Function devolverDepositosLotes(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select Depositos.Codigo,  Depositos.Capacidad, Depositos.Listado,Lotes.TipoLoteID, Lotes.CodigoLote, Lotes.CantidadRestante,CASE WHEN CodigoLote is NULL THEN dbo.DepositoLavado(Depositos.DepositoID) ELSE Lotes.Descripcion END AS Descripcion,Lotes.TipoProductoID,dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Acidez') as Acidez,dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Alcohol') as Alcohol, dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Densidad') as Densidad, dbo.DevolerValorParametroDeLote(Lotes.LoteID, 'Sulfuroso') as Sulfuroso from Lotes RIGHT OUTER JOIN  Depositos ON Lotes.DepositoID = Depositos.DepositoID where (Depositos.BotaID Is NULL and Depositos.Listado = 'TRUE') ORDER BY Depositos.Codigo")
        Return dtb.Consultar()
    End Function

    Public Function devolverDepositosporCodigo(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select DepositoId,Codigo from Depositos where botaID is null ORDER BY Depositos.Codigo")
        Return dtb.Consultar()
    End Function

    Public Sub Cargar(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            Dim tabla As New DataTable
            dtb.PrepararConsulta("select Depositos.FechaCreacion, Depositos.Capacidad,Depositos.DoctoUbicacionFisica,TonelID,TransicubaID, BotaID, BotaPiernaID from Depositos where DepositoID= @dep")
            dtb.AñadirParametroConsulta("@dep", DepositoID)
            tabla = dtb.Consultar()

            If Convert.IsDBNull(tabla.Rows(0).Item(0)) Then
                FechaCreacion = DateTime.Now
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

    Public Function Limpiar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.ConsultaAlteraciones("update Depositos set " & _
                                 "TonelID=" & Convert.ToString(TonelID) & "," & _
                                 "TransicubaID=" & Convert.ToString(TransicubaID) & "," & _
                                 "BotaPiernaID=" & Convert.ToString(BotaPiernaID) & "," & _
                                 "BotaID=" & Convert.ToString(BotaID) & "" & _
                                 " where DepositoID=" & Convert.ToString(DepositoID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Devolver(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select Depositos.DepositoID,Depositos.Codigo,Depositos.FechaCreacion,Depositos.Capacidad,Depositos.DoctoUbicacionFisica,Depositos.TonelID,Depositos.TransicubaID,Depositos.BotaID,Depositos.BotaPiernaID,MaterialConstruccion.descripcion, Listado from Depositos left join MaterialConstruccion on Depositos.MaterialConstruccionID = MaterialConstruccion.MaterialConstruccionID where Depositos.depositoID > 0 ORDER BY Depositos.Codigo")
        Return dtb.Consultar()
    End Function



    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.ConsultaAlteraciones(" update Depositos set " & _
                                 "Codigo='" & Codigo & "'," & _
                                 "FechaCreacion='" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaCreacion) & "'," & _
                                 "Capacidad='" & Capacidad & "'," & _
                                 "DoctoUbicacionFisica='" & DoctoUbicacionFisica & "'," & _
                                 "MaterialConstruccionID=" & Convert.ToString(MaterialConstruccionID) & "," & _
                                 "Listado='" & Convert.ToString(Listado) & "'," & _
                                 "TonelID=" & Convert.ToString(TonelID) & "," & _
                                 "TransicubaID=" & Convert.ToString(TransicubaID) & "," & _
                                 "BotaPiernaID=" & Convert.ToString(BotaPiernaID) & "," & _
                                 "BotaID=" & Convert.ToString(BotaID) & "" & _
                                 " where DepositoID=" & Convert.ToString(DepositoID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            Dim calendar As New BasesParaCompatibilidad.Calendar
            dtb.ConsultaAlteraciones("insert into depositos values(" & _
                              "'" & Codigo & "'," & _
                              "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaCreacion) & "'," & _
                              "'" & Convert.ToString(Capacidad) & "'," & _
                              "'" & DoctoUbicacionFisica & "'," & _
                              "" & Convert.ToString(TonelID) & "," & _
                              "" & Convert.ToString(TransicubaID) & "," & _
                              "" & Convert.ToString(BotaID) & "," & Convert.ToString(BotaPiernaID) & "," & MaterialConstruccionID & ",'" & Listado & "','" & _
                              BasesParaCompatibilidad.Calendar.ArmarFecha((Today + " " + TimeOfDay)) + "'," + BasesParaCompatibilidad.Config.User.ToString + ")")

            dtb.PrepararConsulta("select max(DepositoID) from Depositos")
            DepositoID = dtb.Consultar().Rows(0).Item(0)
            Return DepositoID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            dtb.PrepararConsulta("delete from Depositos where DepositoID = @id")
            dtb.AñadirParametroConsulta("@id", DepositoID)
            If dtb.Consultar(True) Then
                Return 1
            Else
                MessageBox.Show("no se puede eliminar Deposito, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return 0
            End If
            'If BasesParaCompatibilidad.BD.ConsultaEliminar("Depositos", "DepositoID = " & Convert.ToString(DepositoID)) = 0 Then
            '    MessageBox.Show("no se puede eliminar Deposito, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            'End If
            'Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region
End Class
