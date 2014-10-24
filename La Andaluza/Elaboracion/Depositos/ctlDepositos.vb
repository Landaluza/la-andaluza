Imports BasesParaCompatibilidad.ComboBoxExtension
Public Class ctlDepositos

    Dim clsDep As New clsDepositos



    Public Sub SetDepositoID(ByVal ID As Integer)
        clsDep._DepositoID = ID
    End Sub

    Public Function devolverDepositosporCodigo(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return clsDep.devolverDepositosporCodigo(dtb)
    End Function

    Public Sub devolverDepositosporCodigo(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef cbo As ComboBox)
        cbo.mam_DataSource(clsDep.devolverDepositosporCodigo(dtb), False)
    End Sub

    Public Sub CargarDepositos(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsDep.Cargar(dtb)
    End Sub

    Public Sub DevolverDatosDepositos(ByRef capacidad As String, ByRef DoctoUbicacionFisica As String)
        capacidad = clsDep._Capacidad
        DoctoUbicacionFisica = clsDep._DoctoUbicacionFisica
        clsTon._TonelID = clsDep._TonelID
        clsTra._TransicubaID = clsDep._TransicubaID
        clsBot._BotaID = clsDep._BotaID
        clsBotPie._BotaPiernaID = clsDep._BotaPiernaID
    End Sub

    Public Sub LimpiarDeposito(ByRef dtb As BasesParaCompatibilidad.DataBase)
        If clsDep._DepositoID > 0 Then
            clsDep._TonelID = 0
            clsDep._TransicubaID = 0
            clsDep._BotaID = 0
            clsDep._BotaPiernaID = 0
            clsDep.Limpiar(dtb)
        End If
    End Sub

    Public Function devolverDepositosLotes(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return clsDep.devolverDepositosLotes(dtb)
    End Function

    Public Sub mostrarTodosDepositos(ByRef dtb As BasesParaCompatibilidad.DataBase, ByRef dts As dtsDepositos.DepositosDataTable)
        Dim reg As dtsDepositos.DepositosRow
        Dim i As Integer
        Dim tabla As New DataTable

        tabla = clsDep.Devolver(dtb)
        dts.Clear()

        While i < tabla.Rows.Count
            reg = dts.NewDepositosRow
            reg.DepositoID = tabla.Rows(i).Item(0)
            reg.Tipo = "" 'Para evitar que si no se introduce tipo se asigne a NULL

            reg.Codigo = tabla.Rows(i).Item(1)

            If Convert.IsDBNull(tabla.Rows(i).Item(2)) Then
                reg.FechaCreacion = DateTime.Now
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

    Public Sub GuardarDeposito(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal Codigo As String, ByVal FechaCreacion As Date, ByVal Capacidad As String, _
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
            clsDep.Insertar(dtb)
        Else
            clsDep.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarDeposito(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsDep.Cargar(dtb)

        If clsDep._BotaID > 0 Then
            clsBot._BotaID = clsDep._BotaID
            LimpiarDeposito(dtb)
            EliminarBota(dtb)
        ElseIf clsDep._TonelID > 0 Then
            clsTon._TonelID = clsDep._TonelID
            LimpiarDeposito(dtb)
            EliminarTonel(dtb)
        ElseIf clsDep._BotaPiernaID > 0 Then
            clsBotPie._BotaPiernaID = clsDep._BotaPiernaID
            LimpiarDeposito(dtb)
            EliminarBotaPierna(dtb)
        ElseIf clsDep._TransicubaID > 0 Then
            clsTra._TransicubaID = clsDep._TransicubaID
            LimpiarDeposito(dtb)
            EliminarTransicuba(dtb)
        End If
        clsDep.Eliminar(dtb)
    End Sub

    '--------------------------------BOTAS---------------------------------------------
    Dim clsBot As New clsBotas

    Public Function GetBotaID() As Integer
        Return clsBot._BotaID
    End Function

    Public Sub CargarBota(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsBot.Cargar(dtb)
    End Sub

    Public Sub DevolverDatosBota(ByRef BotaTaponID As Integer, ByRef PosicionID As Integer)
        BotaTaponID = clsBot._BotaTaponID
        PosicionID = clsBot._PosicionID
    End Sub

    Public Sub GuardarBota(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal BotaTaponID As Integer, _
               ByVal PosicionID As Integer)
        clsBot._BotaTaponID = BotaTaponID
        clsBot._PosicionID = PosicionID
        If clsBot._BotaID = 0 Then
            clsBot.Insertar(dtb)
        Else
            clsBot.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarBota(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsBot.Eliminar(dtb)
    End Sub

    '-------------------------------- TONELES ---------------------------------------------
    Dim clsTon As New clsToneles

    Public Function GetTonelID() As Integer
        Return clsTon._TonelID
    End Function

    Public Sub CargarTonel(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsTon.Cargar(dtb)
    End Sub

    Public Sub DevolverDatosTonel(ByRef Descripcion As String, ByRef contHab As String)
        Descripcion = clsTon._Descripcion
        contHab = clsTon._ContenidoHabitual
    End Sub

    Public Sub GuardarTonel(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal Descripcion As String, ByVal ContenidoHabitual As String)
        clsTon._Descripcion = Descripcion
        clsTon._ContenidoHabitual = ContenidoHabitual
        If clsTon._TonelID = 0 Then
            clsTon.Insertar(dtb)
        Else
            clsTon.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarTonel(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsTon.Eliminar(dtb)
    End Sub

    '-------------------------------- PIERNAS ---------------------------------------------
    Dim clsBotPie As New clsBotasPiernas

    Public Function GetBotasPiernaID() As Integer
        Return clsBotPie._BotaPiernaID
    End Function

    Public Sub CargarBotaPierna(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsBotPie.Cargar(dtb)
    End Sub

    Public Sub DevolverDatosBotaPierna(ByRef Descripcion As String, ByRef contHab As String)
        Descripcion = clsBotPie._Descripcion
        contHab = clsBotPie._ContenidoHabitual
    End Sub

    Public Sub GuardarBotaPierna(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal Descripcion As String, ByVal ContenidoHabitual As String)
        clsBotPie._Descripcion = Descripcion
        clsBotPie._ContenidoHabitual = ContenidoHabitual
        If clsBotPie._BotaPiernaID = 0 Then
            clsBotPie.Insertar(dtb)
        Else
            clsBotPie.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarBotaPierna(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsBotPie.Eliminar(dtb)
    End Sub

    '-------------------------------- TRANSICUBAS ---------------------------------------------
    Dim clsTra As New clsTransicubas

    Public Function GetTransicubaID() As Integer
        Return clsTra._TransicubaID
    End Function


    Public Sub CargarTransicuba(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsTra.Cargar(dtb)
    End Sub


    Public Sub DevolverDatosTransicuba(ByRef Descripcion As String, ByRef estado As Boolean)
        Descripcion = clsTra._Descripcion
        clsTra._Estado = estado
    End Sub

    Public Sub GuardarTransicuba(ByRef dtb As BasesParaCompatibilidad.DataBase, _
               ByVal Descripcion As String, _
               ByVal Estado As Boolean)

        clsTra._Descripcion = Descripcion
        clsTra._Estado = Estado

        If clsTra._TransicubaID = 0 Then
            clsTra.Insertar(dtb)
        Else
            clsTra.Modificar(dtb)
        End If
    End Sub

    Public Sub EliminarTransicuba(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsTra.Eliminar(dtb)
    End Sub
End Class
