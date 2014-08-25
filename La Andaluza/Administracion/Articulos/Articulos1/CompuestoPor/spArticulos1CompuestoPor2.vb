Public Class spArticulos1CompuestoPor2
    Private dtb as BasesParaCompatibilidad.Database

    Public Sub New()
        dtb = new BasesParaCompatibilidad.Database(BasesParaCompatibilidad.Config.Server)
    End Sub

    Public Function DataTableFill(ByVal id As Integer) As DataTable
        dtb.PrepararConsulta("select 	articuloid, descripcionLa, cantidad, subtotal from 	ComposicionesArticulos, ComposicionesArticulosDetalles, articulos1 where ComposicionesArticulosDetalles.id_articulo = articuloid and ComposicionesArticulos.id_articulo = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Consultar

        'Return dtb.Consultar("select 	articuloid, descripcionLa, cantidad, subtotal from 	ComposicionesArticulos, ComposicionesArticulosDetalles, articulos1 where ComposicionesArticulosDetalles.id_articulo = articuloid and ComposicionesArticulos.id_articulo = " & id, False)
    End Function

    Public Function Eliminar(ByVal id As Integer, ByVal id2 As Integer) As Boolean
        dtb.EmpezarTransaccion()
        Dim spArticulos1 As New spArticulos1
        Dim spdoypack As New spdoypack

        Try
            Dim retorno As Boolean = True
            Dim m_art_aux As DBO_Articulos1 = spArticulos1.Select_Record(id, dtb.Transaccion)

            If m_art_aux.ArticuloTpoID = 10 Then
                m_art_aux = spArticulos1.Select_Record(id2, dtb.Transaccion)
                If m_art_aux.ArticuloTpoID = 9 Then
                    retorno = retorno And dtb.ConsultaAlteraciones("update articulosenvasesterciarios set id_articuloenvasesecundario=null where articuloID=" & id)
                End If
            ElseIf m_art_aux.ArticuloTpoID = 9 Then
                retorno = retorno And dtb.ConsultaAlteraciones("update articulosenvasessecundarios set id_articuloPrimario=null where articuloID=" & id)
            ElseIf spdoypack.esDoypack(m_art_aux.ID, dtb) Then
                retorno = retorno And spdoypack.deleteBy(id, id2, dtb)
            End If

            retorno = retorno And dtb.ConsultaAlteraciones("delete from ComposicionesArticulosDetalles where id_composicionArticulo=(select id from composicionesArticulos where id_articulo=" & id & ") ")

            retorno = retorno And dtb.ConsultaAlteraciones("delete from ComposicionesArticulos where id_articulo=" & id & String.Empty)

            If retorno Then
                dtb.TerminarTransaccion()
                Return True
            Else
                dtb.CancelarTransaccion()
                Return False
            End If
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

    Public Function CargarCombo(ByVal id As Integer) As DataTable
        Dim spArticulos1 As New spArticulos1
        Dim spArticulosEnvasesTerciarios1 As New spArticulosEnvasesTerciarios
        Dim m_aux As DBO_Articulos1 = spArticulos1.Select_Record(id, dtb.Transaccion)
        If m_aux.ArticuloTpoID = 10 Then 'ArticuloTerciario
            Dim m_ter_aux As DBO_ArticulosEnvasesTerciarios = spArticulosEnvasesTerciarios1.Select_RecordByArticuloID(id, dtb.Transaccion)
            If Not IsDBNull(m_ter_aux.id_ArticuloEnvaseSecundario) Then
                If m_ter_aux.id_ArticuloEnvaseSecundario <> 0 Then
                    Return dtb.Consultar("select articuloId, descripcionLA from articulos1 where articulos1.articuloID not in(select isnull(articulosenvasessecundarios.articuloID,0) from articulosenvasessecundarios)", False)
                End If
            Else
                Return dtb.Consultar("select articuloId, descripcionLA from articulos1 where articulos1.articuloID not in(select isnull(articulosenvasessecundarios.articuloID,0) from articulosenvasessecundarios)", False)
            End If
        Else
            If m_aux.ArticuloTpoID = 4 Then 'Graneles
                Return dtb.Consultar("select articuloId, descripcionLA from articulos1 where articuloTpoId = 6", False)
            End If
        End If

        Return dtb.Consultar("select articuloId, descripcionLA from articulos1", False)
    End Function

    Public Function CargarCombo1(ByVal id As Integer) As DataTable
        dtb.PrepararConsulta("select ArticuloID, DescripcionLA from Articulos1 WHERE Articulos1.ArticuloTpoID = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Consultar()

        ' Return dtb.Consultar("select ArticuloID, DescripcionLA from Articulos1 WHERE Articulos1.ArticuloTpoID =" & id, False)
    End Function

    'si es secundario sobre terciario actualizar el terciario
    Public Function Insertar(p1 As Integer, p2 As Integer, p3 As Double, Optional formato As Integer = Nothing) As Boolean
        dtb.EmpezarTransaccion()
        Dim spArticulos1 As New spArticulos1
        Dim retorno As Boolean = True
        Try
            Dim m_aux As DBO_Articulos1 = spArticulos1.Select_Record(p1, dtb.Transaccion)
            If m_aux.ArticuloTpoID = 10 Then
                m_aux = spArticulos1.Select_Record(p2, dtb.Transaccion)
                If m_aux.ArticuloTpoID = 9 Then
                    Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                    Dim m_sec_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(p2, dtb.Transaccion)
                    retorno = retorno And dtb.ConsultaAlteraciones("update articulosenvasesterciarios set id_articuloenvasesecundario =" & m_sec_aux.ID & " where articuloid =" & p1)
                End If
            End If

            retorno = retorno And dtb.ConsultaAlteraciones("insert into articulos1_articulos1_compuestoPor(id_articulo, id_articuloCompuestoPor, cantidad) values(" & p1 & " ," & p2 & " ," & Convert.ToString(p3).Replace(",", ".") & ")")

            If formato <> Nothing Then
                retorno = retorno And dtb.ConsultaAlteraciones("insert into doypack(id_articuloPrimario, id_monodosis, id_tipoformato,cantidad) values(" & p1 & " ," & p2 & " ," & formato & " ," & Convert.ToString(p3).Replace(",", ".") & ")")
            End If

            If retorno Then
                dtb.TerminarTransaccion()
            Else
                dtb.CancelarTransaccion()
            End If

            Return retorno
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

    Public Function Actualizar(p1 As Integer, p2 As Integer, p3 As Double) As Boolean
        Dim retorno As Boolean = True
        dtb.EmpezarTransaccion()

        Try
            retorno = retorno And dtb.ConsultaAlteraciones("update articulos1_articulos1_compuestoPor set cantidad=" & Convert.ToString(p3).Replace(",", ".") & " where id_articulo=" & p1 & " and id_articuloCompuestoPor=" & p2)
            retorno = retorno And dtb.ConsultaAlteraciones("update doypack set cantidad = " & Convert.ToString(p3).Replace(",", ".") & " where id_articuloPrimario = " & p1 & " and id_monodosis = " & p2)

            If retorno Then
                dtb.TerminarTransaccion()
            Else
                dtb.CancelarTransaccion()
            End If

            Return retorno
        Catch ex As Exception
            dtb.CancelarTransaccion()
            Return False
        End Try
    End Function

End Class
