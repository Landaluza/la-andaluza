Public Class spArticulosGranelesCompuestoPor
    'añadir en la
    'alter table articulosIngredientes_articulos1Compuestopor add subcantidad Double(14,6)
    Public Sub New()

    End Sub

    Public Sub select_record(ByRef p1 As DBO_articulosGranelesCompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.PrepararConsulta("select subcantidad, orden from articulosIngredientes_articulos1Compuestopor where id_articuloIngrediente = @componente and id_articulo = @articulo and id_elaboracion_fase = @fase")
        dtb.AñadirParametroConsulta("@componente", p1.ArticuloComponente)
        dtb.AñadirParametroConsulta("@articulo", p1.ArticuloPrincipal)
        dtb.AñadirParametroConsulta("@fase", p1.Fase)
        Dim dt As DataTable = dtb.Consultar

        p1.Cantidad = dt.Rows(0).Item(0)
        p1.Orden = dt.Rows(0).Item(1)
        p1.Old_Cantidad = dt.Rows(0).Item(0)
        p1.Old_Orden = dt.Rows(0).Item(1)
    End Sub

    Public Function DataTableFill(ByVal id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select " & _
                                "articulos1.articuloid, descripcionLa, costeUnitario, cantidad*costeunitario subtotal, orden, fase, subcantidad as cantidad, elaboraciones_fases.id id_fase " & _
                            "from articulos1_articulos1_compuestoPor, articulos1, elaboraciones_fases, articulosIngredientes_articulos1Compuestopor " & _
                            "where articulosIngredientes_articulos1Compuestopor.id_elaboracion_fase = elaboraciones_fases.id " & _
                            "and articulosIngredientes_articulos1Compuestopor.id_articulo = articulos1_articulos1_compuestoPor.id_articulo  " & _
                            "and articulosIngredientes_articulos1Compuestopor.id_articuloIngrediente = articulos1_articulos1_compuestoPor.id_articuloCompuestoPor  " & _
                            "and articulosIngredientes_articulos1Compuestopor.id_articuloIngrediente = articulos1.articuloid  " & _
                            "and articulosIngredientes_articulos1Compuestopor.id_articulo = @id order by descripcionLa, fase, orden")
        dtb.AñadirParametroConsulta("@id", id)

        Return dtb.Consultar
    End Function

    Function Eliminar(p1 As DBO_articulosGranelesCompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.EmpezarTransaccion()
        Dim retorno As Boolean = True
        Try
            dtb.PrepararConsulta("delete from articulosIngredientes_articulos1Compuestopor where id_articuloIngrediente = @ing and id_articulo = @art and id_elaboracion_fase = @fas")
            dtb.AñadirParametroConsulta("@ing", p1.ArticuloComponente)
            dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
            dtb.AñadirParametroConsulta("@fas", p1.Fase)
            retorno = retorno And dtb.Execute

            dtb.PrepararConsulta("select count(*) from articulosIngredientes_articulos1Compuestopor where id_articuloIngrediente = @ing and id_articulo = @art")
            dtb.AñadirParametroConsulta("@ing", p1.ArticuloComponente)
            dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
            Dim dt As DataTable = dtb.Consultar()

            If dt.Rows(0).Item(0) > 1 Then
                dtb.PrepararConsulta("update articulos1_articulos1_compuestoPor set cantidad=cantidad - @can where id_articulo= @art and id_articuloCompuestoPor= @com")
                dtb.AñadirParametroConsulta("@can", Convert.ToString(p1.Old_Cantidad).Replace(",", "."))
                dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
                dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente & String.Empty)
                retorno = retorno And dtb.Execute
            Else
                dtb.PrepararConsulta("delete from articulos1_articulos1_compuestoPor where id_articulo= @art and id_articuloCompuestoPor= @com")
                dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
                dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente & String.Empty)
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

    Function CargarCombo(id As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select articulos1.articuloId, descripcionLA, isnull(id_unidadMedida,0) from articulos1, articulosIngredientes " & _
                                "where articuloTpoId = 6 and id_tipoProducto is not null " & _
                                "and articulos1.articuloid = articulosIngredientes.articuloId order by descripcionLA")
        Return dtb.Consultar

    End Function

    Function Insertar(p1 As DBO_articulosGranelesCompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.EmpezarTransaccion()
        Dim retorno As Boolean = True
        Try
            ''compbrobacion para insertar solo una vez en compuesto por
            dtb.PrepararConsulta("select count(*) from articulos1_articulos1_compuestoPor where id_articulo= @artp and id_articuloCompuestoPor= @art")
            dtb.AñadirParametroConsulta("@art", p1.ArticuloComponente)
            dtb.AñadirParametroConsulta("@artp", p1.ArticuloPrincipal)
            Dim dt As DataTable = dtb.Consultar()
            If dt.Rows(0).Item(0) = 0 Then
                dtb.PrepararConsulta("insert into articulos1_articulos1_compuestoPor(id_articulo, id_articuloCompuestoPor, cantidad) values( @art , @com , @can )")
                dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
                dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente)
                dtb.AñadirParametroConsulta("@can", Replace(p1.Cantidad, ",", "."))
                retorno = retorno And dtb.Execute
            Else
                dtb.PrepararConsulta("update articulos1_articulos1_compuestoPor set cantidad=cantidad + @can where id_articulo= @art and id_articuloCompuestoPor= @com")
                dtb.AñadirParametroConsulta("@can", Convert.ToString(p1.Cantidad).Replace(",", "."))
                dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
                dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente & String.Empty)
                retorno = retorno And dtb.Execute
            End If

            dtb.PrepararConsulta("insert into articulosIngredientes_articulos1Compuestopor(id_articuloIngrediente , id_articulo , id_elaboracion_fase,	orden, subcantidad) " & _
                                 "values( @com , @art , @fas , @ord , @can)")
            dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente)
            dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
            dtb.AñadirParametroConsulta("@fas", p1.Fase)
            dtb.AñadirParametroConsulta("@ord", p1.Orden)
            dtb.AñadirParametroConsulta("@can", Convert.ToString(p1.Cantidad).Replace(",", "."))
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

    Function Actualizar(p1 As DBO_articulosGranelesCompuestoPor, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.EmpezarTransaccion()
        Dim retorno As Boolean = True
        Try
            dtb.PrepararConsulta("update articulos1_articulos1_compuestoPor set cantidad=cantidad- @can + @can2  where id_articulo= @art and id_articuloCompuestoPor= @com")
            dtb.AñadirParametroConsulta("@can", Convert.ToString(p1.Old_Cantidad).Replace(",", "."))
            dtb.AñadirParametroConsulta("@can2", Convert.ToString(p1.Cantidad).Replace(",", "."))
            dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
            dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente)
            retorno = retorno And dtb.Execute

            dtb.PrepararConsulta("update articulosIngredientes_articulos1Compuestopor set orden = @ord, subcantidad= @can where id_articuloIngrediente = @com and id_articulo = @art and id_elaboracion_fase = @fas")
            dtb.AñadirParametroConsulta("@ord", p1.Orden)
            dtb.AñadirParametroConsulta("@can", Convert.ToString(p1.Cantidad).Replace(",", "."))
            dtb.AñadirParametroConsulta("@com", p1.ArticuloComponente)
            dtb.AñadirParametroConsulta("@art", p1.ArticuloPrincipal)
            dtb.AñadirParametroConsulta("@fas", p1.Fase)

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
