Public Class ctlDepositos

    Dim clsDep As New clsDepositos

    Public Function GetDepositoID() As Integer
        Return clsDep._DepositoID
    End Function

    Public Sub SetDepositoID(ByVal ID As Integer)
        clsDep._DepositoID = ID
    End Sub

    Public Function devolverDepositosporCodigo() As DataTable
        Return clsDep.devolverDepositosporCodigo()
    End Function

    Public Function devolverDepositos1() As DataTable
        Return clsDep.Devolver()
    End Function

    Public Function devolverDepositosFinales() As DataTable
        Return clsDep.devolverDepositosFinales()
    End Function

    Public Function devolverDepositosVacios() As DataTable
        Return clsDep.devolverDepositosVacios()
    End Function
    
    Public Function devolverDepositosPartidas() As DataTable
        Return clsDep.devolverDepositosPartidas()
    End Function

    Public Sub CargarDepositos()
        clsDep.Cargar()
    End Sub

    Public Function devolverCapacidadDeposito() As Integer
        Return clsDep._Capacidad
    End Function

    Public Sub DevolverDatosDepositos(ByRef capacidad As String, ByRef DoctoUbicacionFisica As String)
        capacidad = clsDep._Capacidad
        DoctoUbicacionFisica = clsDep._DoctoUbicacionFisica
        clsTon._TonelID = clsDep._TonelID
        clsTra._TransicubaID = clsDep._TransicubaID
        clsBot._BotaID = clsDep._BotaID
        clsBotPie._BotaPiernaID = clsDep._BotaPiernaID
    End Sub

    Public Sub LimpiarDeposito()
        If clsDep._DepositoID > 0 Then
            clsDep._TonelID = 0
            clsDep._TransicubaID = 0
            clsDep._BotaID = 0
            clsDep._BotaPiernaID = 0
            clsDep.Limpiar()
        End If
    End Sub

    Public Function devolverDepositosLotes() As DataTable
        Return clsDep.devolverDepositosLotes()
    End Function

    Public Sub mostrarTodosDepositos(ByRef dts As dtsDepositos.DepositosDataTable)
        Dim reg As dtsDepositos.DepositosRow
        Dim i As Integer
        Dim tabla As New DataTable

        tabla = clsDep.Devolver()
        dts.Clear()

        While i < tabla.Rows.Count
            reg = dts.NewDepositosRow
            reg.DepositoID = tabla.Rows(i).Item(0)
            reg.Tipo = "" 'Para evitar que si no se introduce tipo se asigne a NULL

            reg.Codigo = tabla.Rows(i).Item(1)

            If Convert.IsDBNull(tabla.Rows(i).Item(2)) Then
                reg.FechaCreacion = datetime.now
            Else
                reg.FechaCreacion = tabla.Rows(i).Item(2)
            End If
            reg.Capacidad = tabla.Rows(i).Item(3)

            If (Convert.IsDBNull(tabla.Rows(i).Item(4))) Then
                reg.DoctoUbicacionFisica = ""
            Else
                reg.DoctoUbicacionFisica = tabla.Rows(i).Item(4)
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(5)) Then
                reg.TonelID = ""
            Else
                reg.TonelID = tabla.Rows(i).Item(5)
                reg.Tipo = "Deposito"
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(6)) Then
                reg.TransicubaID = ""
            Else
                reg.TransicubaID = tabla.Rows(i).Item(6)
                reg.Tipo = "Transicuba"
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(7)) Then
                reg.BotaID = ""
            Else
                reg.BotaID = tabla.Rows(i).Item(7)
                reg.Tipo = "Bota"
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(8)) Then
                reg.BotaPiernaID = ""
            Else
                reg.BotaPiernaID = tabla.Rows(i).Item(8)
                reg.Tipo = "Pierna botas"
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(9)) Then
                reg.MaterialConstruccionID = ""
            Else
                reg.MaterialConstruccionID = tabla.Rows(i).Item(9)
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(10)) Then
                reg.Listado = False
            Else
                reg.Listado = tabla.Rows(i).Item(10)
            End If
            dts.AddDepositosRow(reg)

            i = i + 1
        End While
    End Sub

    Public Sub GuardarDeposito(ByVal Codigo As Integer, ByVal FechaCreacion As Date, ByVal Capacidad As String, _
               ByVal DoctoUbicacionFisica As String, ByVal materialConstruccion As Integer, ByVal listado As Boolean)
        clsDep._Codigo = Codigo
        clsDep._Capacidad = Capacidad
        clsDep._FechaCreacion = FechaCreacion
        clsDep._DoctoUbicacionFisica = DoctoUbicacionFisica

        clsDep._TonelID = clsTon._TonelID
        clsDep._TransicubaID = clsTra._TransicubaID
        clsDep._BotaID = clsBot._BotaID
        clsDep._BotaPiernaID = clsBotPie._BotaPiernaID

        clsDep._MaterialConstruccionID = materialConstruccion
        clsDep._Listado = listado
        If clsDep._DepositoID = 0 Then
            clsDep.Insertar()
        Else
            clsDep.Modificar()
        End If
    End Sub

    Public Sub EliminarDeposito()
        clsDep.Cargar()

        If clsDep._BotaID > 0 Then
            clsBot._BotaID = clsDep._BotaID
            LimpiarDeposito()
            EliminarBota()
        ElseIf clsDep._TonelID > 0 Then
            clsTon._TonelID = clsDep._TonelID
            LimpiarDeposito()
            EliminarTonel()
        ElseIf clsDep._BotaPiernaID > 0 Then
            clsBotPie._BotaPiernaID = clsDep._BotaPiernaID
            LimpiarDeposito()
            EliminarBotaPierna()
        ElseIf clsDep._TransicubaID > 0 Then
            clsTra._TransicubaID = clsDep._TransicubaID
            LimpiarDeposito()
            EliminarTransicuba()
        End If
        clsDep.Eliminar()
    End Sub

    '--------------------------------BOTAS---------------------------------------------
    Dim clsBot As New clsBotas

    Public Function GetBotaID() As Integer
        Return clsBot._BotaID
    End Function

    Public Sub SetBotaID(ByVal ID As Integer)
        clsBot._BotaID = ID
    End Sub

    Public Function devolverBotas() As DataTable
        Return clsBot.Devolver()
    End Function

    Public Sub CargarBota()
        clsBot.Cargar()
    End Sub

    Public Sub DevolverDatosBota(ByRef BotaTaponID As Integer, ByRef PosicionID As Integer)
        BotaTaponID = clsBot._BotaTaponID
        PosicionID = clsBot._PosicionID
    End Sub

    Public Sub GuardarBota( _
               ByVal BotaTaponID As Integer, _
               ByVal PosicionID As Integer)
        clsBot._BotaTaponID = BotaTaponID
        clsBot._PosicionID = PosicionID
        If clsBot._BotaID = 0 Then
            clsBot.Insertar()
        Else
            clsBot.Modificar()
        End If
    End Sub

    Public Sub EliminarBota()
        clsBot.Eliminar()
    End Sub

    '-------------------------------- TONELES ---------------------------------------------
    Dim clsTon As New clsToneles

    Public Function GetTonelID() As Integer
        Return clsTon._TonelID
    End Function

    Public Sub SetTonelID(ByVal ID As Integer)
        clsTon._TonelID = ID
    End Sub

    Public Function devolverToneles() As DataTable
        Return clsTon.Devolver()
    End Function

    Public Sub CargarTonel()
        clsTon.Cargar()
    End Sub

    Public Sub DevolverDatosTonel(ByRef Descripcion As String, ByRef contHab As String)
        Descripcion = clsTon._Descripcion
        contHab = clsTon._ContenidoHabitual
    End Sub

    Public Sub GuardarTonel( _
               ByVal Descripcion As String, ByVal ContenidoHabitual As String)
        clsTon._Descripcion = Descripcion
        clsTon._ContenidoHabitual = ContenidoHabitual
        If clsTon._TonelID = 0 Then
            clsTon.Insertar()
        Else
            clsTon.Modificar()
        End If
    End Sub

    Public Sub EliminarTonel()
        clsTon.Eliminar()
    End Sub

    '-------------------------------- PIERNAS ---------------------------------------------
    Dim clsBotPie As New clsBotasPiernas

    Public Function GetBotasPiernaID() As Integer
        Return clsBotPie._BotaPiernaID
    End Function

    Public Sub SetBotasPiernaID(ByVal ID As Integer)
        clsBotPie._BotaPiernaID = ID
    End Sub

    Public Function devolverBotasPiernas() As DataTable
        Return clsBotPie.Devolver()
    End Function

    Public Sub CargarBotaPierna()
        clsBotPie.Cargar()
    End Sub

    Public Sub DevolverDatosBotaPierna(ByRef Descripcion As String, ByRef contHab As String)
        Descripcion = clsBotPie._Descripcion
        contHab = clsBotPie._ContenidoHabitual
    End Sub

    Public Sub GuardarBotaPierna(ByVal Descripcion As String, ByVal ContenidoHabitual As String)
        clsBotPie._Descripcion = Descripcion
        clsBotPie._ContenidoHabitual = ContenidoHabitual
        If clsBotPie._BotaPiernaID = 0 Then
            clsBotPie.Insertar()
        Else
            clsBotPie.Modificar()
        End If
    End Sub

    Public Sub EliminarBotaPierna()
        clsBotPie.Eliminar()
    End Sub

    '-------------------------------- TRANSICUBAS ---------------------------------------------
    Dim clsTra As New clsTransicubas

    Public Function GetTransicubaID() As Integer
        Return clsTra._TransicubaID
    End Function

    Public Sub SetTransicubaID(ByVal ID As Integer)
        clsTra._TransicubaID = ID
    End Sub

    Public Function devolverTransicubas() As DataTable
        Return clsTra.Devolver()
    End Function

    Public Function devolverTransicubasActivas() As DataTable
        Return clsDep.devolverTransicubasActivas()
    End Function

    Public Sub CargarTransicuba()
        clsTra.Cargar()
    End Sub

    Public Function darDeBajaTransicuba() As Integer
        Return clsTra.darDeBajaTransicuba()
    End Function

    Public Sub DevolverDatosTransicuba(ByRef Descripcion As String, ByRef estado As Boolean)
        Descripcion = clsTra._Descripcion
        clsTra._Estado = estado
    End Sub

    Public Sub GuardarTransicuba( _
               ByVal Descripcion As String, _
               ByVal Estado As Boolean)

        clsTra._Descripcion = Descripcion
        clsTra._Estado = Estado

        If clsTra._TransicubaID = 0 Then
            clsTra.Insertar()
        Else
            clsTra.Modificar()
        End If
    End Sub

    Public Sub EliminarTransicuba()
        clsTra.Eliminar()
    End Sub
End Class
