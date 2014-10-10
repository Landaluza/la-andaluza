Public Class clsEspecificaciones


#Region "Atributos"
    Private EspecificacionID As Integer
    Private LegislacionID As Integer
    Private Descripcion As String
    Private CodigoQS As String
    Private FechaRevisado As DateTime
    Private TipoLoteID As Integer
    Private TipoProductoID As String
#End Region

#Region "Propiedades"
    Public Property _EspecificacionID() As Integer
        Get
            Return EspecificacionID
        End Get

        Set(ByVal value As Integer)
            EspecificacionID = value
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

    Public Property _Descripcion() As String
        Get
            Return Descripcion
        End Get

        Set(ByVal value As String)
            Descripcion = value
        End Set
    End Property

    Public Property _CodigoQS() As String
        Get
            Return CodigoQS
        End Get
        Set(ByVal value As String)
            CodigoQS = value
        End Set
    End Property

    Public Property _FechaRevisado() As DateTime
        Get
            Return FechaRevisado
        End Get

        Set(ByVal value As DateTime)
            FechaRevisado = value
        End Set
    End Property

    Public Property _TipoProductoID() As Integer
        Get
            If TipoProductoID = "null" Then
                Return 0
            Else
                Return TipoProductoID
            End If
        End Get

        Set(ByVal value As Integer)
            If value = 0 Then
                TipoProductoID = "null"
            Else
                TipoProductoID = value
            End If
        End Set
    End Property

    Public Property _TipoLoteID() As Integer
        Get
            Return TipoLoteID
        End Get

        Set(ByVal value As Integer)
            TipoLoteID = value
        End Set
    End Property
#End Region

#Region "Metodos"
    Public Sub New()
        EspecificacionID = 0
    End Sub

    Function devolverIDtipoProducto() As Integer
        Try
            Return BasesParaCompatibilidad.BD.ConsultaVer("TipoProductoID", "Especificaciones", "EspecificacionID = " & EspecificacionID.ToString).Rows(0).Item(0)
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function devolver() As DataTable

        Return BasesParaCompatibilidad.BD.ConsultaVer("Especificaciones.EspecificacionID, Especificaciones.Descripcion, Especificaciones.CodigoQS, Especificaciones.FechaRevisado, TiposLotes.Descripcion, TiposProductos.Descripcion AS FormatoGranel, Especificaciones.LegislacionID", _
        "Especificaciones INNER JOIN TiposLotes ON Especificaciones.TipoLoteID = TiposLotes.TipoLoteID LEFT OUTER JOIN TiposProductos ON Especificaciones.TipoProductoID = TiposProductos.TipoProductoID", _
        "(Especificaciones.EspecificacionID > 0)")

    End Function

    Public Function devolverPorLote() As DataTable


        Return BasesParaCompatibilidad.BD.ConsultaVer("Especificaciones.EspecificacionID, Especificaciones.Descripcion", _
        "Especificaciones", _
        "Especificaciones.TipoLoteID = " & TipoLoteID.ToString & " and Especificaciones.TipoProductoID =" & TipoProductoID.ToString)

    End Function


    Public Function devolverTodo() As DataTable


        Return BasesParaCompatibilidad.BD.ConsultaVer("Especificaciones.EspecificacionID, Especificaciones.Descripcion", _
        "Especificaciones", _
        "EspecificacionID > 0 order by Descripcion")

    End Function

    Public Function Modificar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("update Especificaciones set " & _
                             "CodigoQS = '" & CodigoQS.ToString & _
                                                            "',Descripcion= '" & Descripcion & _
                                                            "', FechaRevisado = '" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaRevisado) & _
                                                            "', TipoLoteID = " & TipoLoteID.ToString & _
                                                            ",TipoProductoID = " & TipoProductoID.ToString & _
                                                            ",LegislacionID = " & LegislacionID.ToString & _
                                                            " where EspecificacionID = " & EspecificacionID.ToString)
        Return dtb.Consultar(True)
        'Try
        '    BasesParaCompatibilidad.BD.ConsultaModificar("Especificaciones", _
        '                                                    "CodigoQS = '" & CodigoQS.ToString & _
        '                                                    "',Descripcion= '" & Descripcion & _
        '                                                    "', FechaRevisado = '" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaRevisado) & _
        '                                                    "', TipoLoteID = " & TipoLoteID.ToString & _
        '                                                    ",TipoProductoID = " & TipoProductoID.ToString & _
        '                                                    ",LegislacionID = " & LegislacionID.ToString, _
        '                                                    "EspecificacionID = " & EspecificacionID.ToString)


        '    Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function



    Public Function Insertar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.PrepararConsulta("insert into Especificaciones '" & Descripcion & _
                                                           "','" & CodigoQS.ToString & _
                                                           "','" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaRevisado) & _
                                                           "'," & TipoLoteID.ToString & _
                                                           "," & TipoProductoID.ToString & _
                                                           ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(DateTime.Now) & _
                                                           "'," & BasesParaCompatibilidad.Config.User & _
                                                           ", " & LegislacionID)
        Return dtb.Consultar(True)

        'Try
        '    BasesParaCompatibilidad.BD.ConsultaInsertarSinDatosUsuario("'" & Descripcion & _
        '                                                   "','" & CodigoQS.ToString & _
        '                                                   "','" & BasesParaCompatibilidad.Calendar.ArmarFecha(FechaRevisado) & _
        '                                                   "'," & TipoLoteID.ToString & _
        '                                                   "," & TipoProductoID.ToString & _
        '                                                   ",'" & BasesParaCompatibilidad.Calendar.ArmarFecha(DateTime.Now) & _
        '                                                   "'," & BasesParaCompatibilidad.Config.User & _
        '                                                   ", " & LegislacionID, _
        '                                                   "Especificaciones")


        '    EspecificacionID = BasesParaCompatibilidad.BD.ConsultaVer("max(EspecificacionID)", "Especificaciones").Rows(0).Item(0)
        '    Return EspecificacionID
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

    Public Function Eliminar(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        dtb.PrepararConsulta("delete from Especificaciones where EspecificacionID= @id")
        dtb.AñadirParametroConsulta("@id", EspecificacionID)

        Return dtb.Consultar(True)
        'Try


        'If (BasesParaCompatibilidad.BD.ConsultaEliminar("Especificaciones", "EspecificacionID = " & EspecificacionID.ToString) = 0) Then
        '    MessageBox.Show("no se puede eliminar esa especificacion, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        'End If
        'Return 1
        'Catch ex As Exception
        '    Return 0
        'End Try
    End Function

#End Region
End Class
