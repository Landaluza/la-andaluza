Public Class ctlBotasPosiciones
    '-------------------------------- NAVES -------------------------------------------
    'Dim clsNav As New spNaves
    Private dboNaves As New DBO_Naves
    Private dboPiernas As New DBO_Piernas
    Private clsAlt As New spAlturas
    Private dboAltura As New DBO_Alturas

    Public Function GetNaveID() As Integer
        Return dboNaves.ID
    End Function

    Public Sub SetNaveID(ByVal ID As Integer)
        dboNaves.ID = ID
    End Sub

    'Public Function devolverNaves() As DataTable
    '    Return clsNav.Devolver()
    'End Function


    'Public Sub GuardarNave( _
    '           ByVal Descripcion As String)
    '    clsNav._Descripcion = Descripcion
    '    If clsNav._NaveID = 0 Then
    '        clsNav.Insertar()
    '    Else
    '        clsNav.Modificar()
    '    End If
    'End Sub

    'Public Sub EliminarNave()
    '    clsNav.Eliminar()
    'End Sub

    '-------------------------------- PIERNAS -------------------------------------------

    'Dim clsPie As New clsPiernas

    Public Function GetPiernaID() As Integer
        Return dboPiernas.ID
    End Function

    Public Sub SetPiernaID(ByVal ID As Integer)
        dboPiernas.ID = ID
    End Sub

    'Public Function devolverPiernas() As DataTable
    '    Return clsPie.Devolver()
    'End Function

    'Public Function devolverPiernasPorNaves(nave As Integer) As DataTable
    '    clsPie._NaveID = nave 'clsNav._NaveID
    '    Return clsPie.DevolverPorNaves()
    'End Function


    'Public Sub GuardarPierna(ByVal Descripcion As String, _
    '           ByVal NaveID As Integer)
    '    clsPie._Descripcion = Descripcion
    '    clsPie._NaveID = NaveID
    '    If clsPie._PiernaID = 0 Then
    '        clsPie.Insertar()
    '    Else
    '        clsPie.Modificar()
    '    End If
    'End Sub

    'Public Sub EliminarPierna()
    '    clsPie.Eliminar()
    'End Sub

    '-------------------------------- Alturas -------------------------------------------

    Public Function GetAlturaID() As Integer
        Return dboAltura.ID
    End Function

    Public Sub SetAlturaID(ByVal ID As Integer)
        dboAltura.ID = ID
    End Sub

    'Public Function devolverAlturas() As DataTable
    '    Return clsAlt.Devolver()
    'End Function


    Public Sub GuardarAltura( _
                ByVal Descripcion As String, _
                ByVal PiernaID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dboAltura.Descripcion = Descripcion
        dboAltura.PiernaID = PiernaID

        clsAlt.Grabar(dboAltura, dtb)

    End Sub

    Public Sub EliminarAltura(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsAlt.Delete(dboAltura.ID, dtb)
    End Sub

    Public Function devolverAlturasPorPiernas(ByVal pierna As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dboAltura.PiernaID = pierna 'clsPie._PiernaID
        dtb.PrepararConsulta("select AlturaID,Descripcion from Alturas where PiernaID= @pierna order by descripcion")
        dtb.AñadirParametroConsulta("@pierna", pierna)
        Return dtb.Consultar
    End Function

    '-------------------------------- POSICIONES -------------------------------------------

    Dim clsPos As New spPosiciones
    Dim dboPosiciones As New DBO_Posiciones


    Public Function GetPosicionID() As Integer
        Return dboPosiciones.ID
    End Function

    Public Sub SetPosicionID(ByVal ID As Integer)
        dboPosiciones.ID = ID
    End Sub

    Public Function devolverPosiciones(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Return dtb.Consultar("select Posiciones.PosicionID,Posiciones.Descripcion,Alturas.Descripcion As Alturas from Posiciones LEFT JOIN Alturas On Posiciones.AlturaID = Alturas.AlturaID", False)
    End Function


    Public Sub GuardarPosicion( _
                ByVal Descripcion As String, _
                ByVal AlturaID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dboPosiciones.Descripcion = Descripcion
        dboPosiciones.AlturaID = AlturaID

        clsPos.Grabar(dboPosiciones, dtb)
    End Sub

    Public Sub EliminarPosicion(ByRef dtb As BasesParaCompatibilidad.DataBase)
        clsPos.Delete(dboPosiciones.ID, dtb)
    End Sub

    Public Function devolverPosicionesPorAlturas(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dboPosiciones.AlturaID = dboAltura.ID
        dtb.PrepararConsulta("select PosicionID,Descripcion from Posiciones where AlturaID= @alt order by Descripcion")
        dtb.AñadirParametroConsulta("@alt", dboPosiciones.AlturaID)
        Return dtb.Consultar
    End Function
End Class
