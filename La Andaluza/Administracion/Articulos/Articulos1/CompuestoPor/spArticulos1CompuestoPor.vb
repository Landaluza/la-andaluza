Public Class spArticulos1CompuestoPor

    Public Sub New()

    End Sub

    Public Function DataTableFill(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select articuloid, descripcionLa, cantidad, costeUnitario, cantidad*costeunitario subtotal from articulos1_articulos1_compuestoPor, articulos1 where id_articuloCompuestopor = articuloid and id_articulo = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Consultar
    End Function

    Public Function Eliminar(ByVal id As Integer, ByVal id2 As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.EmpezarTransaccion()
        Dim spArticulos1 As New spArticulos1
        Dim spdoypack As New spdoypack
        Try
            Dim retorno As Boolean = True
            Dim m_art_aux As DBO_Articulos1 = spArticulos1.Select_Record(id, dtb)

            If m_art_aux.ArticuloTpoID = 10 Then
                m_art_aux = spArticulos1.Select_Record(id2, dtb)
                If m_art_aux.ArticuloTpoID = 9 Then
                    dtb.PrepararConsulta("update articulosenvasesterciarios set id_articuloenvasesecundario=null where articuloID= @id")
                    dtb.AñadirParametroConsulta("@id", id)
                    retorno = retorno And dtb.Execute
                End If

            ElseIf m_art_aux.ArticuloTpoID = 9 Then
                dtb.PrepararConsulta("update articulosenvasessecundarios set id_articuloPrimario=null where articuloID= @id")
                dtb.AñadirParametroConsulta("@id", id)
                retorno = retorno And dtb.Execute

            ElseIf spdoypack.esDoypack(m_art_aux.ID, dtb) Then
                retorno = retorno And spdoypack.deleteBy(id, id2, dtb)
            End If

            dtb.PrepararConsulta("delete from articulos1_articulos1_compuestoPor where id_articulo= @id and id_articuloCompuestopor = @com")
            dtb.AñadirParametroConsulta("@id", id)
            dtb.AñadirParametroConsulta("@com", id2)
            retorno = retorno And dtb.Execute

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

    Public Function CargarCombo(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Dim spArticulos1 As New spArticulos1
        Dim spArticulosEnvasesTerciarios1 As New spArticulosEnvasesTerciarios
        Dim m_aux As DBO_Articulos1 = spArticulos1.Select_Record(id, dtb)
        If m_aux.ArticuloTpoID = 10 Then 'ArticuloTerciario
            Dim m_ter_aux As DBO_ArticulosEnvasesTerciarios = spArticulosEnvasesTerciarios1.Select_RecordByArticuloID(id, dtb)
            If Not IsDBNull(m_ter_aux.id_ArticuloEnvaseSecundario) Then
                If m_ter_aux.id_ArticuloEnvaseSecundario <> 0 Then
                    dtb.PrepararConsulta("select articuloId, descripcionLA from articulos1 where articulos1.articuloID not in(select isnull(articulosenvasessecundarios.articuloID,0) from articulosenvasessecundarios)")
                    Return dtb.Consultar
                End If
            Else
                dtb.PrepararConsulta("select articuloId, descripcionLA from articulos1 where articulos1.articuloID not in(select isnull(articulosenvasessecundarios.articuloID,0) from articulosenvasessecundarios)")
                Return dtb.Consultar()
            End If
        Else
            If m_aux.ArticuloTpoID = 4 Then 'Graneles
                dtb.PrepararConsulta("select articuloId, descripcionLA from articulos1 where articuloTpoId = 6")
                Return dtb.Consultar
            End If
        End If
        dtb.PrepararConsulta("select articuloId, descripcionLA from articulos1")
        Return dtb.Consultar
    End Function

    Public Function CargarCombo1(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select ArticuloID, DescripcionLA from Articulos1 WHERE Articulos1.ArticuloTpoID = @id")
        dtb.AñadirParametroConsulta("@id", id)
        Return dtb.Consultar
    End Function

    'si es secundario sobre terciario actualizar el terciario
    Public Function Insertar(p1 As Integer, p2 As Integer, p3 As Double, ByRef dtb As BasesParaCompatibilidad.DataBase, Optional formato As Integer = Nothing) As Boolean
        dtb.EmpezarTransaccion()
        Dim retorno As Boolean = True
        Dim spArticulos1 As New spArticulos1
        Try
            Dim m_aux As DBO_Articulos1 = spArticulos1.Select_Record(p1, dtb)
            If m_aux.ArticuloTpoID = 10 Then
                m_aux = spArticulos1.Select_Record(p2, dtb)
                If m_aux.ArticuloTpoID = 9 Then
                    Dim spArticulosEnvasesSecundarios As New spArticulosEnvasesSecundarios
                    Dim m_sec_aux As DBO_ArticulosEnvasesSecundarios = spArticulosEnvasesSecundarios.Select_RecordByArticuloID(p2, dtb)
                    dtb.PrepararConsulta("update articulosenvasesterciarios set id_articuloenvasesecundario = @sec where articuloid = @art")
                    dtb.AñadirParametroConsulta("@sec", m_sec_aux.ID)
                    dtb.AñadirParametroConsulta("@art", p1)
                    retorno = retorno And dtb.Execute
                End If
            End If

            dtb.PrepararConsulta("insert into articulos1_articulos1_compuestoPor(id_articulo, id_articuloCompuestoPor, cantidad) values( @art, @com, @can )")
            dtb.AñadirParametroConsulta("@art", p1)
            dtb.AñadirParametroConsulta("@com", p2)
            dtb.AñadirParametroConsulta("@can", Convert.ToString(p3).Replace(",", "."))
            retorno = retorno And dtb.Execute

            If formato <> Nothing Then
                dtb.PrepararConsulta("insert into doypack(id_articuloPrimario, id_monodosis, id_tipoformato,cantidad) values( @art, @mon, @for, @can )")
                dtb.AñadirParametroConsulta("@art", p1)
                dtb.AñadirParametroConsulta("@mon", p2)
                dtb.AñadirParametroConsulta("@for", formato)
                dtb.AñadirParametroConsulta("@can", Convert.ToString(p3).Replace(",", "."))
                retorno = retorno And dtb.Execute
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

    Public Function Actualizar(p1 As Integer, p2 As Integer, p3 As Double, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim retorno As Boolean = True
        dtb.EmpezarTransaccion()

        Try
            dtb.PrepararConsulta("update articulos1_articulos1_compuestoPor set cantidad= @cantidad where id_articulo= @art and id_articuloCompuestoPor= @id")
            dtb.AñadirParametroConsulta("@cantidad", Convert.ToString(p3).Replace(",", "."))
            dtb.AñadirParametroConsulta("@art", p1)
            dtb.AñadirParametroConsulta("@id", p2)
            retorno = retorno And dtb.Execute

            dtb.PrepararConsulta("update doypack set cantidad = @can where id_articuloPrimario = @art and id_monodosis = @id")
            dtb.AñadirParametroConsulta("@can", Convert.ToString(p3).Replace(",", "."))
            dtb.AñadirParametroConsulta("@art", p1)
            dtb.AñadirParametroConsulta("@id", p2)
            retorno = retorno And dtb.Execute

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
