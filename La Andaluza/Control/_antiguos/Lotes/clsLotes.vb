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


    Public Sub devolverReferencia(ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            dtb.PrepararConsulta("select max(referencia) from Lotes")
            Referencia = Convert.ToInt32(dtb.Consultar().Rows(0).Item(0))
            Referencia = Referencia + 1
        Catch ex As Exception
            Referencia = 1
        End Try
    End Sub



    Public Function devolverTodosEnologicos(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If

        If id = Nothing Then
            dtb.PrepararConsulta(query & "" & _
                                  "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , Lotes.Observacion, " & _
                                  "Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, " & _
                                  "TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, " & _
                                  "Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, " & _
                                  "Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  "from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where TiposProductos.Enologico = 'True'" & " order by Lotes.Fecha desc")
        Else
            dtb.PrepararConsulta(query & "" & _
                                 "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                              " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                              " where TiposProductos.Enologico = 'True'" & " and lotes.loteid = " & id & "order by Lotes.Fecha desc")
        End If

        Return dtb.Consultar()
    End Function

    Public Function devolverTodosEnologicos2(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "" & _
                                  "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                  "from  Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where TiposProductos.Enologico = 'True' order by Lotes.Fecha desc, referencia desc")

        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                             " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                              " where TiposProductos.Enologico = 'True'" & " and lotes.loteid = " & id & " order by Lotes.Fecha desc, referencia desc")
        End If

        Return dtb.Consultar
    End Function

    Public Function devolverTodosNoEnologicos2(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where TiposProductos.Enologico = 'False'  order by Lotes.Fecha desc, referencia desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                 " from  Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where TiposProductos.Enologico = 'False' and lotes.loteid = " & id & " order by Lotes.Fecha desc, referencia desc")
        End If

        Return dtb.Consultar()
    End Function

    Public Function devolverPorTipoLoteID2(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " order by Lotes.Fecha desc, referencia desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                 " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " and lotes.loteid = " & id & "order by Lotes.Fecha desc, referencia desc")
        End If

        Return dtb.Consultar()
    End Function

    Public Function devolverPorTipoProductoID2(ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal top100 As Boolean = False, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " order by lotes.fecha desc, referencia desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                 " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and lotes.loteid = " & id & " order by lotes.fecha desc, referencia desc")
        End If
        Return dtb.Consultar
    End Function

    Public Function devolverPorTipoProductoIDyTipoLoteID2(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                 " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " order by Lotes.Fecha desc, referencia desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, isnull(Lotes.Descripcion, '') Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante , isnull( Lotes.Observacion, '') Observacion, isnull(Lotes.CantidadID, 0) CantidadID, Lotes.CodigoLote, isnull(Depositos.Codigo,'-')  DepositoID, isnull(lotes.referencia, 0) referencia " & _
                                 " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID  " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " and lotes.loteid = " & id & " order by Lotes.Fecha desc, referencia desc")
        End If
        Return dtb.Consultar()
    End Function

    Public Function devolverTodosNoEnologicos(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante, Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion, Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where TiposProductos.Enologico = 'False'  order by Lotes.Fecha desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha,  case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where TiposProductos.Enologico = 'False' and lotes.loteid = " & id & " order by Lotes.Fecha desc")
        End If

        Return dtb.Consultar
    End Function

    Public Function devolverPorTipoLoteID(ByRef dtb As BasesParaCompatibilidad.DataBase, top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " order by Lotes.Fecha desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoLoteID = " & Convert.ToString(TipoLoteID) & " and lotes.loteid = " & id & "order by Lotes.Fecha desc")
        End If

        Return dtb.Consultar
    End Function


    Public Function devolverPorTipoProductoID(ByRef dtb As BasesParaCompatibilidad.DataBase, Optional ByVal top100 As Boolean = False, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " order by lotes.fecha desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha,case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and lotes.loteid = " & id & " order by lotes.fecha desc")
        End If

        Return dtb.Consultar()
    End Function

    Public Function devolverPorTipoProductoIDyTipoLoteID(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal top100 As Boolean, Optional ByVal id As Integer = Nothing) As DataTable
        Dim query As String
        If top100 Then
            query = "select top 100 "
        Else
            query = "select "
        End If
        If id = Nothing Then
            dtb.PrepararConsulta(query & " Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " order by Lotes.Fecha desc")
        Else
            dtb.PrepararConsulta(query & "Lotes.LoteID, Lotes.Descripcion, Lotes.Fecha, case when (select isnull(max(merma),0) from envasadosProductosArticulos epa where epa.loteterminadoID = Lotes.LoteID) > 0 then 0 else Lotes.CantidadRestante end as CantidadRestante,  Lotes.Observacion, Lotes.LoteProveedor, Lotes.Botellas, Lotes.CantidadID, Lotes.MedidaID, Corredores.Nombre AS Corredor, TiposLotes.Descripcion AS TipoLote, TiposProductos.Descripcion AS TipoProducto, Proveedores.Nombre AS Proveedor, Lotes.LoteConjuntoCompraID, Especificaciones.Descripcion AS Especificacion,  Lotes.CodigoLote, Depositos.Codigo, lotes.referencia, DepPrev.Codigo,Lotes.RecipienteSalidaID " & _
                                  " from Lotes LEFT OUTER JOIN Depositos ON Lotes.DepositoID = Depositos.DepositoID LEFT OUTER JOIN Depositos as DepPrev ON Lotes.DepositoPrevioID = DepPrev.DepositoID LEFT OUTER JOIN TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN Especificaciones ON TiposProductos.TipoProductoID = Especificaciones.TipoProductoID AND Lotes.EspecificacionID = Especificaciones.EspecificacionID LEFT OUTER JOIN TiposLotes ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN Corredores ON Lotes.CorredorID = Corredores.CorredorID LEFT OUTER JOIN Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID " & _
                                  " where Lotes.TipoProductoID = " & Convert.ToString(TipoProductoID) & " and Lotes.TipoLoteID = " & TipoLoteID.ToString & " and lotes.loteid = " & id & " order by Lotes.Fecha desc")
        End If

        Return dtb.consultar
    End Function



    Public Function ModificarLoteEnologico(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("update Lotes set " & _
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
                                 "LoteConjuntoCompraID = " & LoteConjuntoCompraID & ", DepositoID=" & DepositoID & _
                                 " where LoteID = " & Convert.ToString(LoteID))
        '"CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'," & _

    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Return dtb.ConsultaAlteraciones("update Lotes set " & _
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
                                 "LoteConjuntoCompraID = " & LoteConjuntoCompraID & _
                                 " where LoteID = " & Convert.ToString(LoteID))


        '", CantidadRestante = '" & Convert.ToString(CantidadRestante) & "'", _


    End Function




    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Try
            If Botellas <> "null" Then      

                If Not dtb.ConsultaAlteraciones("insert into lotes values(" & Referencia & ",'" & Descripcion & "'," & _
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
                                    "'" & CodigoLote & "'," & DepositoID & "," & DepositoID & ",'False'," & RecipienteSalidaID & _
                                    ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")") Then

                    Throw New Exception("No se pudo insertar el lote")
                End If
            Else

                If Not dtb.ConsultaAlteraciones("insert into lotes values(" & Referencia & ",'" & Descripcion & "'," & _
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
                                    "'" & CodigoLote & "'," & DepositoID & "," & DepositoID & ",'False'," & RecipienteSalidaID & _
                                    ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(Today & " " & TimeOfDay) & "'," & BasesParaCompatibilidad.Config.User.ToString & ")") Then

                    Throw New Exception("No se pudo insertar el lote")
                End If
            End If

            dtb.PrepararConsulta("select max(LoteID) from Lotes")
            LoteID = dtb.Consultar().Rows(0).Item(0)
            Return LoteID
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean

        dtb.PrepararConsulta("delete from Lotes where LoteID = @id")
        dtb.AñadirParametroConsulta("@id", LoteID)
        Return dtb.Consultar(True)
        'If BasesParaCompatibilidad.BD.ConsultaEliminar("Lotes", "LoteID = " & LoteID) = 0 Then
        '    MessageBox.Show("No se puede eliminar este Lote, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        '    Return False
        'End If
        'Return True

    End Function



    Public Function DevolverLotesComponentes(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select LotePartida.LoteID, LotePartida.CodigoLote, CompuestoPor.Cantidad, Movimientos.Observaciones " & _
                              " from Lotes AS LotePartida INNER JOIN CompuestoPor ON LotePartida.LoteID = CompuestoPor.LotePartida INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID " & _
                              " where CompuestoPor.LoteFinal = @lot")

        dtb.AñadirParametroConsulta("@lot", LoteID)
        Return dtb.Consultar
    End Function

    Public Function DevolverLotesQueCompone(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select Lotes.LoteID, Lotes.CodigoLote, CompuestoPor.Cantidad, Movimientos.Observaciones " & _
                              " from CompuestoPor INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID INNER JOIN Lotes ON CompuestoPor.LoteFinal = Lotes.LoteID" & _
                              " where CompuestoPor.LotePartida= @lot")

        dtb.AñadirParametroConsulta("@lot", LoteID)
        Return dtb.Consultar
    End Function

    Public Function DevolverLotesTrazabilidad(ByRef dtb As BasesParaCompatibilidad.DataBase, ByVal Lote As Integer) As DataTable
        dtb.PrepararConsulta("select Lotes.CodigoLote AS ComponeA, Lotes_Partida.LoteID, Lotes_Partida.CodigoLote, Movimientos.Fecha, Procesos.Descripcion AS Proceso, CompuestoPor.Cantidad, Proveedores.Nombre " & _
                              " from Lotes INNER JOIN CompuestoPor ON Lotes.LoteID = CompuestoPor.LoteFinal LEFT JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID LEFT JOIN Lotes AS Lotes_Partida ON CompuestoPor.LotePartida = Lotes_Partida.LoteID LEFT JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID LEFT JOIN Proveedores ON Lotes_Partida.ProveedorID = Proveedores.ProveedorID " & _
                              " where Lotes.LoteID = @lot")
        dtb.AñadirParametroConsulta("@lot", Lote)
        Return dtb.Consultar
    End Function

    Public Function DevolverMuestrasAnaliticas(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        dtb.PrepararConsulta("select Analiticas.AnaliticaID, convert(varchar, Lotes.Referencia) + ' - ' + isnull(codigolote, '') " & _
                              "from Lotes inner JOIN Analiticas ON Lotes.LoteID = Analiticas.LoteID" & _
                              " where Analiticas.Nombre= 'La Andaluza'  and referencia is not null and referencia <> 0 order by Lotes.Referencia")

        Return dtb.Consultar
    End Function

    '-----------------------------------ENOLOGICOS---------------------------------------------------
    Public Function DevolverEnologicos(ByRef dtb As BasesParaCompatibilidad.DataBase) As DataTable
        Dim strSELECT As String
        Dim strFROM As String
        Dim strWHERE As String

        strSELECT = "select Lotes.LoteID," & _
                    "Lotes.Descripcion," & _
                    "Lotes.Fecha," & _
                    "Lotes.CantidadRestante, " & _
                    "Lotes.TipoProductoID, " & _
                    "TiposLotes.Descripcion As TiposLote," & _
                    "TiposProductos.Descripcion As TiposProductos," & _
                    "Proveedores.Nombre, " & _
                    "Lotes.CodigoLote, " & _
                    "LoteProveedor"

        strFROM = " from Lotes LEFT OUTER JOIN TiposLotes " & _
                  "ON Lotes.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN " & _
                  "TiposProductos ON Lotes.TipoProductoID = TiposProductos.TipoProductoID LEFT OUTER JOIN " & _
                  "Proveedores ON Lotes.ProveedorID = Proveedores.ProveedorID"

        strWHERE = " where (TiposProductos.Enologico = 'True') AND (TiposLotes.Abreviatura = 'Eco')"

        dtb.PrepararConsulta(strSELECT & strFROM & strWHERE)
        Return dtb.Consultar
    End Function

    Public Function CantidadDeMaceraciones(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta(" select count(*) " & _
                              " from Lotes INNER JOIN CompuestoPor ON Lotes.LoteID = CompuestoPor.LoteFinal INNER JOIN Movimientos ON CompuestoPor.MovimientoID = Movimientos.MovimientoID INNER JOIN Procesos ON Movimientos.ProcesoID = Procesos.ProcesoID inner join tiposmovimientos on tipomovimientoid = tiposmovimientos.id " & _
                              " where tiposmovimientos.abreviatura = 'M' and  Lotes.LoteId = @lot")
        dtb.AñadirParametroConsulta("@lot", LoteID)

        Return dtb.Consultar().Rows(0).Item(0)
    End Function
#End Region
End Class
