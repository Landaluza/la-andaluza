Public Class clsTiposProveedores

#Region "Atributos"
    Private TipoProveedorID As Integer
    Private Descripcion As String
#End Region

#Region "Propiedades"
    Public Property _TipoProveedorID() As Integer
        Get
            Return TipoProveedorID
        End Get

        Set(ByVal value As Integer)
            TipoProveedorID = value
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

#End Region

#Region "Metodos"

    Public Function devolver() As DataTable
        Return BasesParaCompatibilidad.BD.ConsultaVer("*", "TiposProveedores")
    End Function


    Public Function Modificar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaModificar("TiposProveedores", "Descripcion = '" & Descripcion & "'", _
                                                                   "TipoProveedorID = " & Convert.ToString(TipoProveedorID))
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Insertar() As Integer
        Try
            BasesParaCompatibilidad.BD.ConsultaInsertar("'" & Descripcion & "'", "TiposProveedores")
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Public Function Eliminar() As Integer
        Try
            If BasesParaCompatibilidad.BD.ConsultaEliminar("TiposProveedores", "TipoProveedorID = " & TipoProveedorID) = 0 Then
                MessageBox.Show("no se puede eliminar este tipo de proveedor, se encuentra en uso", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If
            Return 1
        Catch ex As Exception
            Return 0
        End Try
    End Function

#End Region

End Class
