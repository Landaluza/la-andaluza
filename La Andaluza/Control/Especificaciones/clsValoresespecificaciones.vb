Public Class clsValoresespecificaciones

#Region "Atributos"
    Private ParametroID As Integer
    Private EspecificacionID As Integer
    Private LegislacionID As Integer
    Private Nombre As String
    Private Obligatoriedad As Boolean
    Private Minimo As Double
    Private Maximo As Double
    Private Periodicidad As Double
    Private UnidadMedida As String
    Private MetodoAnalisisID As String
    Private Desviacion_maximo As Double
    Private Desviacion_minimo As Double
#End Region

#Region "Propiedades"
    Public Property _ParametroID() As Integer
        Get
            Return ParametroID
        End Get

        Set(ByVal value As Integer)
            ParametroID = value
        End Set
    End Property

    Public Property _LegislacionID() As Integer
        Get
            Return LegislacionID
        End Get

        Set(ByVal value As Integer)
            LegislacionID = value
        End Set
    End Property

    Public Property _EspecificacionID() As Integer
        Get
            Return EspecificacionID
        End Get

        Set(ByVal value As Integer)
            EspecificacionID = value
        End Set
    End Property

    Public Property _DesviacionMaxima() As Double
        Get
            Return Desviacion_maximo
        End Get

        Set(ByVal value As Double)
            Desviacion_maximo = value
        End Set
    End Property

    Public Property _DesviacionMinima() As Double
        Get
            Return Desviacion_minimo
        End Get

        Set(ByVal value As Double)
            Desviacion_minimo = value
        End Set
    End Property

    Public Property _Obligatoriedad() As Boolean
        Get
            Return Obligatoriedad
        End Get

        Set(ByVal value As Boolean)
            Obligatoriedad = value
        End Set
    End Property

    Public Property _Minimo() As Double
        Get
            Return Minimo
        End Get

        Set(ByVal value As Double)
            Minimo = value
        End Set
    End Property

    Public Property _Maximo() As Double
        Get
            Return Maximo
        End Get

        Set(ByVal value As Double)
            Maximo = value
        End Set
    End Property

    Public Property _Periodicidad() As Double
        Get
            Return Periodicidad
        End Get

        Set(ByVal value As Double)
            Periodicidad = value
        End Set
    End Property

    Public Property _UnidadMedida() As String
        Get
            Return UnidadMedida
        End Get

        Set(ByVal value As String)
            UnidadMedida = value
        End Set
    End Property


    Public Property _MetodoAnalisisID() As Integer
        Get
            If MetodoAnalisisID = "null" Then
                Return 0
            Else
                Return MetodoAnalisisID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                MetodoAnalisisID = "null"
            Else
                MetodoAnalisisID = value
            End If
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Function devolver(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable

        dtb.PrepararConsulta(" select ListaParametros.ParametroID, " & _
                                "ListaParametros.Nombre, " & _
                                "C1.Obligatoriedad, " & _
                                "isnull(C1.Minimo, legislacionProductos_listaParametros.minimo) as minimo, " & _
                                "isnull(C1.Maximo, legislacionProductos_listaParametros.maximo) as Maximo, " & _
                                "C1.Periodicidad, " & _
                                "UnidadesMedidas.Descripcion, " & _
                                "MetodosAnalisis.Descripcion AS MetodosAnalisis, " & _
                                "C1.desviacionMaximo, " & _
                                "C1.desviacionminimo, " & _
                                "legislacionProductos_listaParametros.maximo as maximoLegislacion, " & _
                                "legislacionProductos_listaParametros.minimo as minimoLegislacion " & _
                                " from	MetodosAnalisis RIGHT JOIN (SELECT " & _
                                                                    "ValoresEspecificaciones.ParametroID AS ParametroIDen, " & _
                                                                    "ValoresEspecificaciones.Obligatoriedad, " & _
                                                                    "ValoresEspecificaciones.Minimo, " & _
                                                                    "ValoresEspecificaciones.Maximo, " & _
                                                                    "ValoresEspecificaciones.Periodicidad, " & _
                                                                    "ValoresEspecificaciones.MetodoAnalisisID, " & _
                                                                    "ValoresEspecificaciones.desviacionMaximo, " & _
                                                                    "ValoresEspecificaciones.desviacionMinimo " & _
                                                                "FROM " & _
                                                                     "Especificaciones INNER JOIN ValoresEspecificaciones " & _
                                                                     "ON Especificaciones.EspecificacionID = ValoresEspecificaciones.EspecificacionID " & _
                                                                     "INNER JOIN ListaParametros AS ListaParametros_1 " & _
                                                                     "ON ValoresEspecificaciones.ParametroID = ListaParametros_1.ParametroID  " & _
                                                                "WHERE " & _
                                                                 "(Especificaciones.EspecificacionID = " & EspecificacionID.ToString & ") " & _
                                                                ") AS c1 " & _
                                 "ON MetodosAnalisis.MetodoAnalisisID = c1.MetodoAnalisisID " & _
                                 "RIGHT OUTER JOIN ListaParametros INNER JOIN UnidadesMedidas " & _
                                 "ON ListaParametros.UnidadMedidaID = UnidadesMedidas.UnidadMedidaID " & _
                                 "ON c1.ParametroIDen = ListaParametros.ParametroID " & _
                                 "left join legislacionProductos_listaParametros " & _
                                 "on ListaParametros.parametroId = legislacionProductos_listaParametros.Id_parametro " & _
                                 "Where (id_legislacion =  " & LegislacionID.ToString & "or id_legislacion is null)")
        '"MetodosAnalisis RIGHT JOIN (SELECT     ValoresEspecificaciones.ParametroID AS ParametroIDen, ValoresEspecificaciones.Obligatoriedad, ValoresEspecificaciones.Minimo, ValoresEspecificaciones.Maximo, ValoresEspecificaciones.Periodicidad, ValoresEspecificaciones.MetodoAnalisisID,ValoresEspecificaciones.desviacionMaximo, ValoresEspecificaciones.desviacionMinimo  FROM Especificaciones INNER JOIN ValoresEspecificaciones ON Especificaciones.EspecificacionID = ValoresEspecificaciones.EspecificacionID INNER JOIN ListaParametros AS ListaParametros_1 ON ValoresEspecificaciones.ParametroID = ListaParametros_1.ParametroID  WHERE (Especificaciones.EspecificacionID = " & EspecificacionID.ToString & ")) AS c1 ON MetodosAnalisis.MetodoAnalisisID = c1.MetodoAnalisisID RIGHT OUTER JOIN ListaParametros INNER JOIN UnidadesMedidas ON ListaParametros.UnidadMedidaID = UnidadesMedidas.UnidadMedidaID ON c1.ParametroIDen = ListaParametros.ParametroID")

        Return dtb.Consultar
    End Function

    Public Function devolverPorEspecificacion(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable

        dtb.PrepararConsulta("select ListaParametros.ParametroID, ListaParametros.Nombre, t1.Minimo, t1.Maximo, t1.Obligatoriedad from ListaParametros left join (SELECT ValoresEspecificaciones.ParametroID, ValoresEspecificaciones.Obligatoriedad, ValoresEspecificaciones.Minimo, ValoresEspecificaciones.Maximo, ValoresEspecificaciones.MetodoAnalisisID FROM ListaParametros INNER JOIN ValoresEspecificaciones ON ListaParametros.ParametroID = ValoresEspecificaciones.ParametroID INNER JOIN Especificaciones ON ValoresEspecificaciones.EspecificacionID = Especificaciones.EspecificacionID WHERE (Especificaciones.EspecificacionID = " & EspecificacionID.ToString & ")) As t1 on ListaParametros.ParametroID = t1.ParametroID")
        Return dtb.Consultar

    End Function

    Public Function existe(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("select Count(*) from ValoresEspecificaciones where ParametroID = @par and EspecificacionID = @es")
        dtb.AñadirParametroConsulta("@par", ParametroID)
        dtb.AñadirParametroConsulta("@es", EspecificacionID)
        Return CInt(dtb.Consultar().Rows(0).Item(0)) > 0
    End Function


    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update ValoresEspecificaciones set " & _
                                 "Obligatoriedad = '" & Obligatoriedad.ToString & _
                                 "', Minimo = " & Minimo.ToString.Replace(","c, "."c) & _
                                 ", Maximo = " & Maximo.ToString.Replace(","c, "."c) & _
                                 ",Periodicidad = " & Convert.ToString(Periodicidad) & _
                                 ",desviacionMaximo = " & Desviacion_maximo.ToString.Replace(","c, "."c) & _
                                 ",desviacionMinimo = " & Desviacion_minimo.ToString.Replace(","c, "."c) & _
                                 ",MetodoAnalisisID=" & MetodoAnalisisID.ToString & _
                                 " where ParametroID = " & ParametroID.ToString & " and EspecificacionID = " & EspecificacionID.ToString)
        Return dtb.Execute

        'Try
        '    Deprecated.ConsultaModificar("ValoresEspecificaciones", _
        '                         "Obligatoriedad = '" & Obligatoriedad.ToString & _
        '                         "', Minimo = " & Minimo.ToString.Replace(","c, "."c) & _
        '                         ", Maximo = " & Maximo.ToString.Replace(","c, "."c) & _
        '                         ",Periodicidad = " & Convert.ToString(Periodicidad) & _
        '                         ",desviacionMaximo = " & Desviacion_maximo.ToString.Replace(","c, "."c) & _
        '                         ",desviacionMinimo = " & Desviacion_minimo.ToString.Replace(","c, "."c) & _
        '                         ",MetodoAnalisisID=" & MetodoAnalisisID.ToString, _
        '                         "ParametroID = " & ParametroID.ToString & " and EspecificacionID = " & EspecificacionID.ToString)


        '    Return 1
        'Catch ex As Exception
        '    MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return 0
        'End Try
    End Function

    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("insert into ValoresEspecificaciones(ParametroID, EspecificacionID, Obligatoriedad, Minimo, Maximo, Periodicidad, MetodoAnalisisID, desviacionMaximo, desviacionMinimo) values(" & _
                                         ParametroID.ToString & "," & EspecificacionID.ToString & ",'" & Obligatoriedad.ToString & "'," & _
                                         Minimo.ToString.Replace(","c, "."c) & "," & Maximo.ToString.Replace(","c, "."c) & "," & _
                                         Convert.ToString(Periodicidad) & "," & MetodoAnalisisID.ToString & "," & _
                                         Desviacion_maximo.ToString.Replace(","c, "."c) & "," & Desviacion_minimo.ToString.Replace(","c, "."c) & ")")

        Return dtb.Execute
        'Try
        '    Deprecated.ConsultaInsertarConcampos("(ParametroID, EspecificacionID, Obligatoriedad, Minimo, Maximo, Periodicidad, MetodoAnalisisID, desviacionMaximo, desviacionMinimo, FechaModificacion, UsuarioModificacion)", _
        '                                 ParametroID.ToString & "," & EspecificacionID.ToString & ",'" & Obligatoriedad.ToString & "'," & _
        '                                 Minimo.ToString.Replace(","c, "."c) & "," & Maximo.ToString.Replace(","c, "."c) & "," & _
        '                                 Convert.ToString(Periodicidad) & "," & MetodoAnalisisID.ToString & "," & _
        '                                 Desviacion_maximo.ToString.Replace(","c, "."c) & "," & Desviacion_minimo.ToString.Replace(","c, "."c), _
        '                                 "ValoresEspecificaciones")


        '    Return 1
        'Catch ex As Exception
        '    MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return 0
        'End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("delete from ValoresEspecificaciones where ParametroID= @par and EspecificacionID= @esp")
        dtb.AñadirParametroConsulta("@par", ParametroID)
        dtb.AñadirParametroConsulta("@esp", EspecificacionID)
        Return dtb.Execute
        'Try
        '    BasesParaCompatibilidad.BD.ConsultaEliminar("ValoresEspecificaciones", "ParametroID = " & ParametroID.ToString & " and EspecificacionID = " & EspecificacionID.ToString)
        '    Return 1
        'Catch ex As Exception
        '    MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return 0
        'End Try
    End Function

    Public Function EliminarPorEspecificacion(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from ValoresEspecificaciones where EspecificacionID= @id")
        dtb.AñadirParametroConsulta("@id", EspecificacionID)
        Return dtb.Execute
        'Try
        '    BasesParaCompatibilidad.BD.ConsultaEliminar("ValoresEspecificaciones", "EspecificacionID = " & EspecificacionID.ToString)
        '    Return 1
        'Catch ex As Exception
        '    MessageBox.Show(ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Return 0
        'End Try
    End Function

#End Region
End Class
