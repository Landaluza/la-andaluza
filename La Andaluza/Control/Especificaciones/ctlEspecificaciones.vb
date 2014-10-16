Public Class ctlEspecificaciones

    Private clsEsp As clsEspecificaciones
    Private clsValEsp As clsValoresespecificaciones
    Private dtb As BasesParaCompatibilidad.DataBase

    Public Sub New()
        clsEsp = New clsEspecificaciones
        clsValEsp = New clsValoresespecificaciones
        dtb = New BasesParaCompatibilidad.DataBase(BasesParaCompatibilidad.Config.Server)
    End Sub
    Public Sub setEspecificacionID(ByVal EspecificacionID As Integer)
        clsEsp._EspecificacionID = EspecificacionID
    End Sub


    Sub mostrarTodosValoresEspecificaciones(ByRef dtsValEsp As dtsEspecificaciones.ValoresEspecificacionesDataTable)
        Dim tabla As New DataTable

        clsValEsp._EspecificacionID = clsEsp._EspecificacionID
        tabla = clsValEsp.devolver(dtb)

        Dim i As Integer
        Dim regPar As dtsEspecificaciones.ValoresEspecificacionesRow

        dtsValEsp.Clear()

        While i < tabla.Rows.Count
            regPar = dtsValEsp.NewValoresEspecificacionesRow

            regPar.ParametroID = tabla.Rows(i).Item(0)
            regPar.Nombre = tabla.Rows(i).Item(1)
            regPar.UnidadMedida = tabla.Rows(i).Item(6)
            If Convert.IsDBNull(tabla.Rows(i).Item(7)) Then
                regPar.MetodosAnalisisID = ""
            Else
                regPar.MetodosAnalisisID = tabla.Rows(i).Item(7)
            End If
            Try
                regPar.Obligatoriedad = If(Convert.IsDBNull(tabla.Rows(i).Item(2)), Nothing, tabla.Rows(i).Item(2))
                regPar.Minimo = If(Convert.IsDBNull(tabla.Rows(i).Item(3)), Nothing, tabla.Rows(i).Item(3))
                regPar.Maximo = If(Convert.IsDBNull(tabla.Rows(i).Item(4)), Nothing, tabla.Rows(i).Item(4))
                regPar.Periodicidad = If(Convert.IsDBNull(tabla.Rows(i).Item(5)), False, tabla.Rows(i).Item(5))
                regPar.DesviacionMaxima = If(Convert.IsDBNull(tabla.Rows(i).Item(8)), Nothing, tabla.Rows(i).Item(8))
                regPar.DesviacionMinima = If(Convert.IsDBNull(tabla.Rows(i).Item(9)), Nothing, tabla.Rows(i).Item(9))
                regPar.MaximoLegislacion = If(Convert.IsDBNull(tabla.Rows(i).Item(10)), Nothing, tabla.Rows(i).Item(10))
                regPar.MinimoLegislacion = If(Convert.IsDBNull(tabla.Rows(i).Item(11)), Nothing, tabla.Rows(i).Item(11))
            Catch ex As Exception
                'regPar.Minimo = 0
                'regPar.Maximo = 0
                'regPar.Periodicidad = 0
                'regPar.Obligatoriedad = False
                'regPar.DesviacionMaxima = 0
                'regPar.DesviacionMinima = 0
            End Try

            dtsValEsp.AddValoresEspecificacionesRow(regPar)
            regPar = Nothing
            i = i + 1
        End While
    End Sub


    Public Sub mostrarTodasEspecificaciones(ByRef dtsEsp As dtsEspecificaciones.EspecificacionesDataTable)

        Dim tabla As New DataTable
        tabla = clsEsp.devolver()

        Dim i As Integer
        Dim regPar As dtsEspecificaciones.EspecificacionesRow

        dtsEsp.Clear()

        While i < tabla.Rows.Count
            regPar = dtsEsp.NewEspecificacionesRow
            regPar.EspecificacionID = tabla.Rows(i).Item(0)
            regPar.Descripcion = tabla.Rows(i).Item(1)
            If Convert.IsDBNull(tabla.Rows(i).Item(2)) Then
                regPar.CodigoQS = 0
            Else
                regPar.CodigoQS = tabla.Rows(i).Item(2)
            End If

            regPar.FechaRevisado = tabla.Rows(i).Item(3)
            regPar.TipoLote = tabla.Rows(i).Item(4)
            If Convert.IsDBNull(tabla.Rows(i).Item(5)) Then
                regPar.TipoProducto = ""
            Else
                regPar.TipoProducto = tabla.Rows(i).Item(5)
            End If
            If Convert.IsDBNull(tabla.Rows(i).Item(6)) Then
                regPar.LegislacionID = 0
            Else
                regPar.LegislacionID = tabla.Rows(i).Item(6)
            End If
            dtsEsp.AddEspecificacionesRow(regPar)
            regPar = Nothing
            i = i + 1
        End While

    End Sub
    Public Sub setLegislacion(ByVal value As Integer)
        Me.clsValEsp._LegislacionID = value
        Me.clsEsp._LegislacionID = value
    End Sub

    Public Function getLegislacion() As Integer
        Return Me.clsEsp._LegislacionID
    End Function

    Public Function devolverEspecificaciones() As DataTable
        Return clsEsp.devolver()
    End Function

    Public Function devolverEspecificacionesPorLote(ByVal TipoLoteId As Integer, ByVal TipoProductoID As Integer) As DataTable
        clsEsp._TipoLoteID = TipoLoteId
        clsEsp._TipoProductoID = TipoProductoID
        Return clsEsp.devolverPorLote()
    End Function

    Public Function devolverEspecificacionesTodas() As DataTable
        Return clsEsp.devolverTodo()
    End Function

    Public Function GuardarEspecificacion(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal Descripcion As String, ByVal qs As String, ByVal fecha As Date, ByVal lote As Integer, ByVal formato As Integer, ByVal LegislacionID As Integer) As Boolean
        clsEsp._Descripcion = Descripcion
        clsEsp._CodigoQS = qs
        clsEsp._FechaRevisado = fecha
        clsEsp._TipoLoteID = lote
        clsEsp._TipoProductoID = formato
        clsEsp._LegislacionID = LegislacionID

        If clsEsp._EspecificacionID > 0 Then
            Return clsEsp.Modificar(dtb)
        Else
            Return clsEsp.Insertar(dtb)
        End If
    End Function

    Public Function EliminarEspecificacion(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        clsValEsp._EspecificacionID = clsEsp._EspecificacionID
        If clsValEsp.EliminarPorEspecificacion(dtb) Then

            Return clsEsp.Eliminar(dtb)
        End If
        Return False
    End Function

    Public Function guardarValoresEspecificaciones(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal ParametroId As Integer, ByVal obligatoriedad As Boolean, ByVal minimo As Double, ByVal maximo As Double, ByVal periodicidad As Double, ByVal MetodoAnalisisID As Integer, ByVal desviacionMax As Double, ByVal desviacionMin As Double) As Boolean
        clsValEsp._EspecificacionID = clsEsp._EspecificacionID
        clsValEsp._ParametroID = ParametroId
        clsValEsp._Obligatoriedad = obligatoriedad
        clsValEsp._Minimo = minimo
        clsValEsp._Maximo = maximo
        clsValEsp._Periodicidad = periodicidad
        clsValEsp._MetodoAnalisisID = MetodoAnalisisID
        clsValEsp._DesviacionMaxima = desviacionMax
        clsValEsp._DesviacionMinima = desviacionMin

        If clsValEsp.existe() Then
            If (obligatoriedad = True Or minimo > 0 Or maximo > 0 Or periodicidad > 0 Or MetodoAnalisisID > 0 Or desviacionMax > 0 Or desviacionMin > 0) Then
                Return clsValEsp.Modificar(dtb)
            Else
                Return clsValEsp.Eliminar(dtb)
            End If
        Else
            If (obligatoriedad = True Or minimo > 0 Or maximo > 0 Or periodicidad > 0 Or MetodoAnalisisID > 0 Or desviacionMax > 0 Or desviacionMin > 0) Then
                Return clsValEsp.Insertar(dtb)
            Else
                Return False
            End If
        End If
    End Function

End Class
