﻿Public Class spBusquedaAdministracion
    Private dtb as BasesParaCompatibilidad.Database
    Private query As String

    Public Sub New()
        Me.dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    End Sub

    Public Function recuperarDatos(ByVal filtro As String, Optional ByVal camiones As Boolean = True, Optional ByVal conductores As Boolean = True) As DataTable
        query = "select x.tipo, x.nombre, x.id, x.otros from ("

        If conductores Then
            query = query & "Select 1 tipo, Nombre+' '+Apellido1+' '+Apellido2 nombre, conductorid id, observaciones Otros from Conductores where Nombre+' '+Apellido1+' '+Apellido2 like '%" & filtro & "%'"

            If camiones Then query = query & " union "
        End If
        If camiones Then query = query & "select 2 tipo, MatriculaCabeza nombre, camionid id, '' Otros from camiones where MatriculaCabeza like '%" & filtro & "%' "

        query = query & ") as x order by x.nombre"

        Return dtb.Consultar(query, _
                             False)

        'Return dtb.Consultar("select x.tipo, x.nombre, x.id from " & _
        '                     "(Select 1 tipo, Nombre+' '+Apellido1+' '+Apellido2 nombre, conductorid id from conductores where Nombre+' '+Apellido1+' '+Apellido2 like '%" & filtro & "%'" & _
        '                     "union " & _
        '                     "select 2 tipo, MatriculaCabeza nombre, camionid id from camiones where MatriculaCabeza like '%" & filtro & "%' " & _
        '                     ") as x order by x.nombre", _
        '                     False)
    End Function

End Class
