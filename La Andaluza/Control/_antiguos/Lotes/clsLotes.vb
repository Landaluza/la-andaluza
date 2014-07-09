Public Class clsLotes

#Region "Atributos"
    Private LoteID As Integer
    Private Referencia As Integer
    Private Descripcion As String
    Private Fecha As Date
    Private CantidadRestante As Double
    Private Observacion As String

    Private Botellas As String
    Private CantidadID As String
    Private MedidaID As String

    Private LoteProveedor As String

    Private EspecificacionID As String
    Private TipoLoteID As String
    Private TipoLote As String

    Private TipoProductoID As String

    Private CorredorID As String
    Private ProveedorID As String
    Private LoteConjuntoCompraID As String

    Private CodigoLote As String
    Private DepositoID As String
    Private RecipienteSalidaID As String

#End Region

#Region "Propiedades"
    Public Property _LoteID() As Integer
        Get
            Return LoteID
        End Get

        Set(ByVal value As Integer)
            LoteID = value
        End Set
    End Property

    Public Property _Referencia() As Integer
        Get
            Return Referencia
        End Get

        Set(ByVal value As Integer)
            Referencia = value
        End Set
    End Property

    Public Property _CodigoLote() As String
        Get
            Return CodigoLote
        End Get

        Set(ByVal value As String)
            CodigoLote = value
        End Set
    End Property

    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _Fecha() As Date
        Get
            Return Fecha
        End Get

        Set(ByVal value As Date)
            Fecha = value
        End Set
    End Property

    Public Property _CantidadRestante() As Double
        Get
            Return CantidadRestante
        End Get

        Set(ByVal value As Double)
            CantidadRestante = value
        End Set
    End Property


    Public Property _LoteProveedor() As String
        Get
            Return LoteProveedor
        End Get

        Set(ByVal value As String)
            LoteProveedor = value
        End Set
    End Property


    Public Property _TipoLoteID() As Integer
        Get
            If TipoLoteID = "null" Then
                Return 0
            Else
                Return If(TipoLoteID <> String.Empty, Convert.ToInt32(TipoLoteID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TipoLoteID = "null"
            Else
                TipoLoteID = value.ToString
            End If
        End Set
    End Property

    Public Property _RecipienteSalidaID() As Integer
        Get
            If RecipienteSalidaID = "null" Then
                Return 0
            Else
                Return If(RecipienteSalidaID <> String.Empty, Convert.ToInt32(RecipienteSalidaID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                RecipienteSalidaID = "null"
            Else
                RecipienteSalidaID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _TipoProductoID() As Integer
        Get
            If TipoProductoID = "null" Then
                Return 0
            Else
                Return If(TipoProductoID <> String.Empty, Convert.ToInt32(TipoProductoID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TipoProductoID = "null"
            Else
                TipoProductoID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _CorredorID() As Integer
        Get
            If CorredorID = "null" Then
                Return 0
            Else
                Return If(CorredorID <> String.Empty, Convert.ToInt32(CorredorID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                CorredorID = "null"
            Else
                CorredorID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _EspecificacionID() As Integer
        Get
            If EspecificacionID = "null" Then
                Return 0
            Else
                Return If(EspecificacionID <> String.Empty, Convert.ToInt32(EspecificacionID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                EspecificacionID = "null"
            Else
                EspecificacionID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _Observacion() As String
        Get
            Return Observacion
        End Get

        Set(ByVal value As String)
            Observacion = value
        End Set
    End Property

    Public Property _Botellas() As String
        Get
            If Botellas = "null" Then
                Return "0"
            Else
                Return Botellas
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                Botellas = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    Botellas = "null"
                Else
                    Botellas = value
                End If
            End If
        End Set
    End Property

    Public Property _CantidadID() As String
        Get
            If CantidadID = "null" Then
                Return "0"
            Else
                Return CantidadID
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                CantidadID = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    CantidadID = "null"
                Else
                    CantidadID = value
                End If

            End If
        End Set
    End Property

    Public Property _MedidaID() As String
        Get
            If MedidaID = "null" Then
                Return "0"
            Else

                Return MedidaID
            End If
        End Get

        Set(ByVal value As String)
            If value = "" Then
                MedidaID = "null"
            Else
                If Convert.ToInt32(value) = 0 Then
                    CantidadID = "null"
                Else
                    MedidaID = value

                End If
            End If
        End Set
    End Property

    Public Property _ProveedorID() As Integer
        Get
            If ProveedorID = "null" Then
                Return 0
            Else
                Return If(ProveedorID <> String.Empty, Convert.ToInt32(ProveedorID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                ProveedorID = "null"
            Else
                ProveedorID = Convert.ToString(value)
            End If
        End Set
    End Property

    Public Property _LoteConjuntoCompraID() As Integer
        Get
            If LoteConjuntoCompraID = "null" Then
                Return 0
            Else
                Return If(LoteConjuntoCompraID <> String.Empty, Convert.ToInt32(LoteConjuntoCompraID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                LoteConjuntoCompraID = "null"
            Else
                LoteConjuntoCompraID = Convert.ToString(value)
            End If
        End Set
    End Property



    Public Property _DepositoID() As Integer
        Get
            If DepositoID = "null" Then
                Return 0
            Else
                Return If(DepositoID <> String.Empty, Convert.ToInt32(DepositoID), 0)
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                DepositoID = "null"
            Else
                DepositoID = Convert.ToString(value)
            End If
        End Set
    End Property


#End Region

#Region "Metodos"

    Public Sub New()
        _Descripcion = ""
        _Referencia = 0
        _Fecha = Today
        _CantidadRestante = 0
        _Observacion = ""
        _Botellas = 0
        _CantidadID = 0
        _MedidaID = 0
        _LoteProveedor = ""
        _EspecificacionID = 0
        _TipoLoteID = 0
        _TipoProductoID = 0
        _CorredorID = 0
        _ProveedorID = 0
        _LoteConjuntoCompraID = 0        
        _CodigoLote = ""
        _DepositoID = 0
        _RecipienteSalidaID = 0
    End Sub

    Public Sub Limpiar()
        _Descripcion = ""
        _Referencia = 0
        _Fecha = Today
        _CantidadRestante = 0
        _Observacion = ""
        _Botellas = 0
        _CantidadID = 0
        _MedidaID = 0
        _LoteProveedor = ""
        _EspecificacionID = 0
        _TipoLoteID = 0
        _TipoProductoID = 0
        _CorredorID = 0
        _ProveedorID = 0
        _LoteConjuntoCompraID = 0        
        _CodigoLote = ""
        _DepositoID = 0
        _RecipienteSalidaID = 0
    End Sub

    Public Sub cargarParaMovimientoPorDeposito()
        Dim tabla As DataTable = BasesParaCompatibilidad.BD.ConsultaVer("LoteID, Descripcion, CantidadRestante, TipoProductoId, CodigoLote, observacion", _
                                   "Lotes", _
                                   "Lotes.DepositoID =" & Convert.ToString(DepositoID))

        Try
            LoteID = Convert.ToInt32(tabla.Rows(0).Item("LoteID"))
            If IsDBNull(tabla.Rows(0).Item(1)) Then
                Descripcion = ""
            Else
                Descripcion = CStr(tabla.Rows(0).Item(1))
            End If
            If IsDBNull(tabla.Rows(0).Item(2)) Then
                CantidadRestante = 0
            Else
                CantidadRestante = tabla.Rows(0).Item(2)
            End If

            If IsDBNull(tabla.Rows(0).Item(3)) Then
                TipoProductoID = "NULL"
            Else
                TipoProductoID = CStr(tabla.Rows(0).Item(3))
            End If
            CodigoLote = CStr(tabla.Rows(0).Item(4))
            If IsDBNull(tabla.Rows(0).Item(5)) Then
                Observacion = ""
            Else
                Observacion = CStr(tabla.Rows(0).Item(5))
            End If

        Catch ex As Exception
            LoteID = 0
            Descripcion = ""
            CantidadRestante = 0
            _TipoProductoID = 0
            CodigoLote = ""
            Observacion = ""
        End Try

    End Sub

    Public Function LoteEsEnologico() As Boolean
        Try
            Return BasesParaCompatibilidad.BD.ConsultaVer("TiposProductos.Enologico", _
                                  "Lotes inner join tiposproductos", _
                                  "LoteID = " & Convert.ToString(LoteID)).Rows(0).Item(0)

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Sub devolverReferencia()
        Try
            Referencia = Convert.ToInt32(BasesParaCompatibilidad.BD.ConsultaVer("max(referencia)", "Lotes").Rows(0).Item(0))
            Referencia = Referencia + 1
        Catch ex As Exception
            Referencia = 1
        End Try
    End Sub

    Public Function devolverTipoLote() As String
        Try
            Return Convert.ToString(BasesParaCompatibilidad.BD.ConsultaVer("TiposLotes.Descripcion", _
                                   "Lotes LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID", _
                                   "Lotes.DepositoID =" & Convert.ToString(DepositoID)).Rows(0).Item(0))
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Public Function guardarLoteCompra() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaInsertar(Referencia & ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                "'" & Convert.ToString(CantidadRestante) & "'," & _
                                "" & Convert.ToString(TipoLoteID) & "," & _
                                "" & Convert.ToString(TipoProductoID) & "," & _
                                Convert.ToString(ProveedorID) & "," & _
                                "'" & CodigoLote & "','" & Descripcion & "','" & Observacion & "'", _
                                "Lotes(Referencia,Fecha,CantidadRestante,TipoLoteID,TipoProductoID,ProveedorID,CodigoLote,descripcion,observacion,FechaModificacion,UsuarioModificacion)") = 0 Then
                LoteID = 0
                Return LoteID
            End If

            LoteID = Convert.ToInt32(BasesParaCompatibilidad.BD.ConsultaVer("max(LoteID)", "Lotes").Rows(0).Item(0))
            Return LoteID
        Catch ex As Exception
            Return (0)
        End Try
    End Function

    Public Function devolverTodosEnologicos(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, _
                                  "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , Lotes.Observacion, " & _
                                  "Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, " & _
                                  "TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, " & _
                                  "Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, " & _
                                  "Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID ", _
                                  "TiposProductos.Enologico = 'True'" & " order by Lotes.Fecha desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                              "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID ", _
                                              "TiposProductos.Enologico = 'True'" & " and lotes.loteid = " & id & "order by Lotes.Fecha desc")
        End If
    End Function

    Public Function devolverTodosEnologicos2(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, _
                                  "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                  " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "TiposProductos.Enologico = 'True'" & " order by Lotes.Fecha desc, referencia desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                             " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                              "TiposProductos.Enologico = 'True'" & " and lotes.loteid = " & id & "order by Lotes.Fecha desc, referencia desc")
        End If
    End Function

    Public Function devolverTodosNoEnologicos2(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                  " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "TiposProductos.Enologico = 'False'" & " order by Lotes.Fecha desc, referencia desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                 " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "TiposProductos.Enologico = 'False' and lotes.loteid = " & id & " order by Lotes.Fecha desc, referencia desc")
        End If
    End Function

    Public Function devolverPorTipoLoteID2(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                  " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " order by Lotes.Fecha desc, referencia desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                 " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " and lotes.loteid = " & id & "order by Lotes.Fecha desc, referencia desc")
        End If
    End Function

    Public Function devolverPorTipoProductoID2(Optional ByVal top100 As Boolean = False, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                  " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " order by lotes.fecha desc, referencia desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                 " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and lotes.loteid = " & id & " order by lotes.fecha desc, referencia desc")
        End If
    End Function

    Public Function devolverPorTipoProductoIDyTipoLoteID2(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                 " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " order by Lotes.Fecha desc, referencia desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia", _
                                 " Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  ", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " and lotes.loteid = " & id & " order by Lotes.Fecha desc, referencia desc")
        End If
    End Function

    Public Function devolverTodosNoEnologicos(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante, Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID ", _
                                  "TiposProductos.Enologico = 'False'" & " order by Lotes.Fecha desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha,  case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID ", _
                                  "TiposProductos.Enologico = 'False' and lotes.loteid = " & id & " order by Lotes.Fecha desc")
        End If
    End Function

    Public Function devolverPorTipoLoteID(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " order by Lotes.Fecha desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " and lotes.loteid = " & id & "order by Lotes.Fecha desc")
        End If
    End Function

    Public Function devolverPorTipoProductoID(ByVal TipoProductoID As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, Lotes.CodigoLote", _
                              "Lotes", _
                              "Lotes.CantidadRestante >0 AND Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID))
    End Function

    Public Function devolverPorTipoProductoID(Optional ByVal top100 As Boolean = False, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " order by lotes.fecha desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha,case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and lotes.loteid = " & id & " order by lotes.fecha desc")
        End If
    End Function

    Public Function devolverPorTipoProductoIDyTipoLoteID(ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        If id = Nothing Then
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " order by Lotes.Fecha desc")
        Else
            Return BasesParaCompatibilidad.BD.ConsultaVer(top100, "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID", _
                                  "Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID", _
                                  "Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " and lotes.loteid = " & id & " order by Lotes.Fecha desc")
        End If
    End Function

    Public Sub devolverDatosLotePorLoteID()
        Dim strSELECT As String
        Dim strFROM As String
        Dim strWHERE As String

        strSELECT = "TiposProductos.TipoProductoID AS TipoProductoDescripcion," & _
                    "TiposLotes.TipoLoteID AS TipoLoteDescripcion," & _
                    "TiposProductos.MedidaID AS MedidaDescripcion," & _
                    "case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante, " & _
                    "Lotes.Descripcion," & _
                    "Lotes.Observacion"

        strFROM = "Lotes LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID " & _
                  "LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID "

        strWHERE = "Lotes.LoteID = " & LoteID.ToString
        Dim tabla As DataTable = BasesParaCompatibilidad.BD.ConsultaVer(strSELECT, strFROM, strWHERE)

        Try
            If IsDBNull(tabla.Rows(0).Item("TipoProductoDescripcion")) Then
                _TipoProductoID = 0
            Else
                TipoProductoID = CStr(tabla.Rows(0).Item("TipoProductoDescripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("TipoLoteDescripcion")) Then
                _TipoLoteID = 0
            Else
                TipoLoteID = CStr(tabla.Rows(0).Item("TipoLoteDescripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("MedidaDescripcion")) Then
                _MedidaID = 0
            Else
                _MedidaID = CStr(tabla.Rows(0).Item("MedidaDescripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("CantidadRestante")) Then
                CantidadRestante = 0
            Else
                CantidadRestante = tabla.Rows(0).Item("CantidadRestante")
            End If

            If IsDBNull(tabla.Rows(0).Item("Descripcion")) Then
                Descripcion = ""
            Else
                Descripcion = CStr(tabla.Rows(0).Item("Descripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("Observacion")) Then
                Observacion = ""
            Else
                Observacion = CStr(tabla.Rows(0).Item("Observacion"))
            End If
        Catch ex As Exception
            Descripcion = ""
            CantidadRestante = 0
            _TipoProductoID = 0
            _TipoLoteID = 0
            _MedidaID = 0
            CodigoLote = ""
            Observacion = ""
        End Try
    End Sub

    Public Sub devolverDatosLotePorDepositoID()
        Dim strSELECT As String
        Dim strFROM As String
        Dim strWHERE As String

        strSELECT = "LoteID," & _
                    "TiposProductos.TipoProductoID AS TipoProductoDescripcion," & _
                    "TiposLotes.TipoLoteID AS TipoLoteDescripcion," & _
                    "CodigoLote," & _
                    "case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante, " & _
                    "Lotes.Descripcion," & _
                    "Lotes.Observacion"

        strFROM = "Lotes LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID " & _
                  "LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID "

        strWHERE = "Lotes.DepositoID = " & DepositoID.ToString
        Dim tabla As DataTable = BasesParaCompatibilidad.BD.ConsultaVer(strSELECT, strFROM, strWHERE)

        Try
            _LoteID = Convert.ToInt32(tabla.Rows(0).Item("LoteID"))

            If IsDBNull(tabla.Rows(0).Item("TipoProductoDescripcion")) Then
                _TipoProductoID = 0
            Else
                TipoProductoID = CStr(tabla.Rows(0).Item("TipoProductoDescripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("TipoLoteDescripcion")) Then
                _TipoLoteID = 0
            Else
                TipoLoteID = CStr(tabla.Rows(0).Item("TipoLoteDescripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("CodigoLote")) Then
                CodigoLote = ""
            Else
                CodigoLote = CStr(tabla.Rows(0).Item("CodigoLote"))
            End If

            If IsDBNull(tabla.Rows(0).Item("CantidadRestante")) Then
                CantidadRestante = 0
            Else
                CantidadRestante = tabla.Rows(0).Item("CantidadRestante")
            End If

            If IsDBNull(tabla.Rows(0).Item("Descripcion")) Then
                Descripcion = ""
            Else
                Descripcion = CStr(tabla.Rows(0).Item("Descripcion"))
            End If

            If IsDBNull(tabla.Rows(0).Item("Observacion")) Then
                Observacion = ""
            Else
                Observacion = CStr(tabla.Rows(0).Item("Observacion"))
            End If
        Catch ex As Exception
            Descripcion = ""
            CantidadRestante = 0
            _TipoProductoID = 0
            _TipoLoteID = 0
            _MedidaID = 0
            CodigoLote = ""
            Observacion = ""
        End Try
    End Sub

    Public Function ModificarLoteEnologico() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Lotes", _
                                 "Descripcion = '" & Descripcion & "'," & _
                                 "Fecha = '" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                 "Observacion = '" & Observacion & "'," & _
                                 "LoteProveedor = '" & LoteProveedor & "'," & _
                                 "Botellas = " & Convert.ToString(Botellas) & "," & _
                                 "CantidadID = " & Convert.ToString(CantidadID) & "," & _
                                 "MedidaID = " & Convert.ToString(MedidaID) & "," & _
                                 "TipoLoteID = " & Convert.ToString(TipoLoteID) & "," & _
                                 "TipoProductoID = " & Convert.ToString(TipoProductoID) & "," & _
                                 "CorredorID = " & CorredorID & "," & _
                                 "EspecificacionID = " & EspecificacionID & "," & _
                                 "ProveedorID = " & ProveedorID & "," & _
                                 "CodigoLote = '" & CodigoLote & "'," & _
                                 "LoteConjuntoCompraID = " & LoteConjuntoCompraID & ", DepositoID=" & DepositoID, _
                                 "LoteID = " & Convert.ToString(LoteID))
            '"CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'," & _
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Lotes", _
                                 "Descripcion = '" & Descripcion & "'," & _
                                 "Fecha = '" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                 "Observacion = '" & Observacion & "'," & _
                                 "LoteProveedor = '" & LoteProveedor & "'," & _
                                 "Botellas = " & Convert.ToString(Botellas) & "," & _
                                 "CantidadID = " & Convert.ToString(CantidadID) & "," & _
                                 "Referencia = " & Convert.ToString(Referencia) & "," & _
                                 "MedidaID = " & If(MedidaID Is Nothing, "null", Convert.ToString(MedidaID)) & "," & _
                                 "TipoLoteID = " & Convert.ToString(TipoLoteID) & "," & _
                                 "TipoProductoID = " & Convert.ToString(TipoProductoID) & "," & _
                                 "CorredorID = " & CorredorID & "," & _
                                 "EspecificacionID = " & EspecificacionID & "," & _
                                 "ProveedorID = " & ProveedorID & "," & _
                                 "CodigoLote = '" & CodigoLote & "'," & _
                                 "RecipienteSalidaID = " & RecipienteSalidaID & "," & _
                                 "LoteConjuntoCompraID = " & LoteConjuntoCompraID, _
                                 "LoteID = " & Convert.ToString(LoteID))
            '", CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'", _
            Return True
        Catch ex As Exception
            messagebox.show("n" & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Sub ModificarCantidadRestante_Deposito()
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Lotes", _
                                 "DepositoID = " & DepositoID & "," & _
                                 "CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'", _
                                 "LoteID = " & Convert.ToString(LoteID))

        Catch ex As Exception
            messagebox.show("Error en ModificarCantidadRestante_y_Deposito", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ModificarDesdeMovimiento()
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Lotes", _
                                 "DepositoID = " & DepositoID & "," & _
                                 "CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'," & _
                                 "Descripcion = '" & Descripcion & "'," & _
                                 "Observacion = '" & Observacion & "'", _
                                 "LoteID = " & Convert.ToString(LoteID))

        Catch ex As Exception
            messagebox.show("Error en ModificarDesdeMovimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub ModificarDesdeMovimientoMAM()
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("Lotes", _
                                 "CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'," & _
                                 "Descripcion = '" & Descripcion & "'," & _
                                 "Observacion = '" & Observacion & "'", _
                                 "LoteID = " & Convert.ToString(LoteID))


        Catch ex As Exception
            messagebox.show("Error en ModificarDesdeMovimiento", "", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function Insertar() As Integer
        Try
            If Botellas <> "null" Then
                BasesParaCompatibilidad.BD.ConsultaInsertar(Referencia & ",'" & Descripcion & "'," & _
                                    "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                    "'" & Convert.ToString(CantidadRestante) & "'," & _
                                    "'" & Observacion & "'," & _
                                    "'" & LoteProveedor & "'," & _
                                    "'" & Convert.ToString(Botellas) & "'," & _
                                    "" & Convert.ToString(CantidadID) & "," & _
                                    "" & Convert.ToString(MedidaID) & "," & _
                                    "" & Convert.ToString(EspecificacionID) & "," & _
                                    "" & Convert.ToString(TipoLoteID) & "," & _
                                    "" & Convert.ToString(TipoProductoID) & "," & _
                                    Convert.ToString(CorredorID) & "," & _
                                    Convert.ToString(ProveedorID) & "," & _
                                    Convert.ToString(LoteConjuntoCompraID) & "," & _
                                    "'" & CodigoLote & "'," & DepositoID & "," & DepositoID & ",'False'," & RecipienteSalidaID, _
                                    "Lotes")
            Else
                BasesParaCompatibilidad.BD.ConsultaInsertar(Referencia & ",'" & Descripcion & "'," & _
                                    "'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Fecha) & "'," & _
                                    "'" & Convert.ToString(CantidadRestante) & "'," & _
                                    "'" & Observacion & "'," & _
                                    "'" & LoteProveedor & "'," & _
                                    "" & Convert.ToString(Botellas) & "," & _
                                    "" & Convert.ToString(CantidadID) & "," & _
                                    "" & Convert.ToString(MedidaID) & "," & _
                                    "" & Convert.ToString(EspecificacionID) & "," & _
                                    "" & Convert.ToString(TipoLoteID) & "," & _
                                    "" & Convert.ToString(TipoProductoID) & "," & _
                                    Convert.ToString(CorredorID) & "," & _
                                    Convert.ToString(ProveedorID) & "," & _
                                    Convert.ToString(LoteConjuntoCompraID) & "," & _
                                    "'" & CodigoLote & "'," & DepositoID & "," & DepositoID & ",'False'," & RecipienteSalidaID, _
                                    "Lotes")
            End If
            LoteID = BasesParaCompatibilidad.BD.ConsultaVer("max(LoteID)", "Lotes").Rows(0).Item(0)
            Return LoteID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Boolean
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("Lotes", "LoteID = " & LoteID) = 0 Then
                MessageBox.Show("No se puede eliminar este Lote, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Return False
            End If
            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function devolverLotesEnologicosParaMovimientoPorProceso(ByVal Proceso As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, Lotes.CodigoLote", _
                              "Lotes LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID inner join usosProductos on TiposProductos.TipoProductoID = usosproductos.TipoProductoID", _
                              "(usosProductos.ProcesoID = " & Proceso & " and CantidadRestante > 0)")
    End Function

    Public Function devolverLotesEnologicosPorTipoMovimientoProcesoyTipoProducto(ByVal TipoMovimiento As Integer, ByVal TipoProducto As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, Lotes.CodigoLote", _
                              "Lotes LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID inner join usosProductos on TiposProductos.TipoProductoID = usosproductos.TipoProductoID", _
                              "(Lotes.ProcesoID = " & TipoMovimiento & " and Lotes.TipoProductoID = " & TipoProducto & "  and CantidadRestante > 0)")
    End Function

    Public Sub validarLoteDiferencia()
        Try
            Dim tabla As DataTable = BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, cantidadRestante, descripcion", "Lotes", "codigoLote = '" & CodigoLote & "'")
            LoteID = Convert.ToInt32(tabla.Rows(0).Item(0))
            CantidadRestante = tabla.Rows(0).Item(1)
            Descripcion = CStr(tabla.Rows(0).Item(2))
        Catch ex As Exception
            LoteID = 0
            CantidadRestante = 0
            Descripcion = ""
        End Try
    End Sub

    Public Sub DevolverEnologicosParaMovimientosPorLoteID()
        Dim tabla As DataTable = BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, Lotes.CantidadRestante,TipoProductoID, Lotes.CodigoLote", "Lotes", "LoteID =" & Convert.ToString(LoteID))
        Try
            LoteID = Convert.ToInt32(tabla.Rows(0).Item(0))
            CantidadRestante = tabla.Rows(0).Item(1)
            TipoProductoID = CStr(tabla.Rows(0).Item(2))
            CodigoLote = CStr(tabla.Rows(0).Item(0))
        Catch ex As Exception
            LoteID = 0
            CantidadRestante = 0
            TipoProductoID = 0
            CodigoLote = ""
        End Try
    End Sub

    Public Function DevolverLotesComponentes() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("LotePartida.LoteID, LotePartida.CodigoLote, CompuestoPor.Cantidad, Movimientos.Observaciones", _
                              "Lotes AS LotePartida INNER JOIN CompuestoPor ON LotePartida.LoteID = CompuestoPor.LotePartida INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID", _
                              "CompuestoPor.LoteFinal = " & Convert.ToString(LoteID))
    End Function

    Public Function DevolverLotesQueCompone() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Lotes.LoteID, Lotes.CodigoLote, CompuestoPor.Cantidad, Movimientos.Observaciones", _
                              "CompuestoPor INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID INNER JOIN Lotes ON CompuestoPor.LoteFinal = Lotes.LoteID", _
                              "CompuestoPor.LotePartida=" & Convert.ToString(LoteID))
    End Function

    Public Function DevolverLotesTrazabilidad(ByVal Lote As Integer) As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Lotes.CodigoLote AS ComponeA, Lotes_Partida.LoteID, Lotes_Partida.CodigoLote, Movimientos.Fecha, Procesos.Descripcion AS Proceso, CompuestoPor.Cantidad, Proveedores.Nombre", _
                              "Lotes INNER JOIN CompuestoPor ON Lotes.LoteID = CompuestoPor.LoteFinal LEFT JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID LEFT JOIN Lotes AS Lotes_Partida ON CompuestoPor.LotePartida = Lotes_Partida.LoteID LEFT JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID LEFT JOIN Proveedores ON Lotes_Partida.ProveedorID = Proveedores.ProveedorID", _
                              "Lotes.LoteID =" & Lote)
    End Function

    Public Function DevolverMuestrasAnaliticas() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("Analiticas.AnaliticaID, Lotes.Referencia", _
                              "Lotes inner JOIN Analiticas ON Lotes.LoteID = Analiticas.LoteID", _
                              "Analiticas.Nombre= 'La Andaluza'  and referencia is not null and referencia <> 0 order by Lotes.Referencia")
    End Function

    '-----------------------------------ENOLOGICOS---------------------------------------------------
    Public Function DevolverEnologicos() As DataTable
        Dim strSELECT As String
        Dim strFROM As String
        Dim strWHERE As String

        strSELECT = "Lotes.LoteID," & _
                    "Lotes.Descripcion," & _
                    "Lotes.Fecha," & _
                    "Lotes.CantidadRestante, " & _
                    "Lotes.TipoProductoID, " & _
                    "TiposLotes.Descripcion As TiposLote," & _
                    "TiposProductos.Descripcion As TiposProductos," & _
                    "Proveedores.Nombre, " & _
                    "Lotes.CodigoLote, " & _
                    "LoteProveedor"

        strFROM = "Lotes LEFT OUTER JOIN TiposLotes " & _
                  "ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN " & _
                  "TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN " & _
                  "Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID"

        strWHERE = "(TiposProductos.Enologico = 'True') AND (TiposLotes.Abreviatura = 'Eco')"

        Return BasesParaCompatibilidad.BD.ConsultaVer(strSELECT, strFROM, strWHERE)
    End Function

    Public Function CantidadDeMaceraciones() As Integer
        Return BasesParaCompatibilidad.BD.ConsultaVer("count(*)", _
                              "Lotes INNER JOIN CompuestoPor ON Lotes.LoteID = CompuestoPor.LoteFinal INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID INNER JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID", _
                              "Procesos.TipoMovimiento = 'M' and  Lotes.LoteId =" & Convert.ToString(LoteID)).Rows(0).Item(0)
    End Function
#End Region
End Class
