

Public Class spCargasNecesidades
    inherits BasesParaCompatibilidad.sp

    Public Sub New()
        MyBase.New("", "", "", "", "", "")
    End Sub

    Private _Seleccion As Integer = 0
    Private _Insert As Integer = 1
    Private _Update As Integer = 2
    Private _Delete As Integer = 3


    Public ReadOnly Property Seleccion As Integer
        Get
            Return Me._Seleccion
        End Get
    End Property
    Public ReadOnly Property insert As Integer
        Get
            Return Me._Insert
        End Get
    End Property
    Public ReadOnly Property Update As Integer
        Get
            Return Me._Update
        End Get
    End Property
    Public ReadOnly Property Delete As Integer
        Get
            Return Me._Delete
        End Get
    End Property

#Region "spCargaNecesidades"
    Public Sub spCargaNecesidadesJRMaestro(ByVal Action As Integer, _
                                           ByVal ValorMaestroID As Integer, _
                                           ByVal ValorFecha As Date, _
                                           ByVal ValorHora As Date, _
                                           ByVal ValorObservaciones As String, _
                                           ByVal ValorFechaModificacion As Date, _
                                           ByVal ValorUsuarioModificacion As Integer, _
                                           ByVal ValorServido As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            dtb.Conectar()
            Dim cmd As System.Data.SqlClient.SqlCommand

            If Action = _Insert Then
                cmd = dtb.comando("InsertCargaNecesidadesJRMaestro")
            ElseIf Action = _Update Then
                cmd = dtb.comando("UpdateCargaNecesidadesJRMaestro")
                cmd.Parameters.AddWithValue("@MaestroID", ValorMaestroID)
            Else : Action = _Delete
                cmd = dtb.Comando("DeleteCargaNecesidadesJRMaestro")
                cmd.Parameters.AddWithValue("@MaestroID", ValorMaestroID)
            End If

            If Action = _Insert Or Action = _Update Then
                cmd.Parameters.AddWithValue("@Fecha", ValorFecha)
                cmd.Parameters.AddWithValue("@Hora", ValorHora)
                cmd.Parameters.AddWithValue("@Observaciones", ValorObservaciones)
                cmd.Parameters.AddWithValue("@FechaModificacion", ValorFechaModificacion)
                cmd.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
                cmd.Parameters.AddWithValue("@Servido", ValorServido)
            End If

            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Error en BD.spCargaNecesidadesJRMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try
    End Sub

    Public Sub spDeleteCargaNecesidadesJRMaestro(ByVal ValorMaestroID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        Try
            dtb.Conectar()
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteCargaNecesidadesJRMaestro")
            cmd.Parameters.AddWithValue("@MaestroID", ValorMaestroID)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en BD.spDeleteCargaNecesidadesJRMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try
    End Sub

    Public Function spMaxCargaNecesidadesMaestro(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Dim MaxID As Integer = 0
        Try
            dtb.Conectar()
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("MaxCargaNecesidadesMaestro")
            MaxID = (cmd.ExecuteScalar())

            Return MaxID
        Catch ex As Exception
            MessageBox.Show("Error en BD.spMaxCargaNecesidadesMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            'messagebox.show(String.Format("Error en BD.spMaxCargaNecesidadesMaestro Mensaje: {0}", ex.Message))
            'Leandro dice: el string.Format para armar los mensajes es mejor que el & para unir el string
            Return MaxID
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Sub spCargaNecesidadesJRDetalle(ByVal Action As Integer, _
                                           ByVal ValorCargaNecesidadesJRDetalleID As Integer, _
                                           ByVal ValorCargaNecesidadesJRMaestroID As Integer, _
                                           ByVal ValorArticuloID As Integer, _
                                           ByVal ValorCarga As Integer, _
                                           ByVal ValorStock As Integer, _
                                           ByVal ValorObservaciones As String, _
                                           ByVal ValorReserva1 As String, _
                                           ByVal ValorReserva2 As String, _
                                           ByVal ValorReserva3 As String, _
                                           ByVal ValorFechaModificacion As Date, _
                                           ByVal ValorUsuarioModificacion As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)


        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand

            If Action = _Insert Then
                cmd = dtb.Comando("InsertCargaNecesidadesJRDetalle")
            ElseIf Action = _Update Then
                cmd = dtb.Comando("UpdateCargaNecesidadesJRDetalle")
                cmd.Parameters.AddWithValue("@CargaNecesidadesJRDetalleID", ValorCargaNecesidadesJRDetalleID)
            Else : Action = _Delete
                cmd = dtb.Comando("DeleteCargaNecesidadesJRDetalle")
                cmd.Parameters.AddWithValue("@DetalleID", ValorCargaNecesidadesJRDetalleID)
            End If

            If Action = _Insert Or Action = _Update Then
                cmd.Parameters.AddWithValue("@CargaNecesidadesJRMaestroID", ValorCargaNecesidadesJRMaestroID)
                cmd.Parameters.AddWithValue("@ArticuloID", ValorArticuloID)
                cmd.Parameters.AddWithValue("@Carga ", ValorCarga)
                cmd.Parameters.AddWithValue("@Stock", ValorStock)
                cmd.Parameters.AddWithValue("@Observaciones", ValorObservaciones)
                cmd.Parameters.AddWithValue("@Reserva1", ValorReserva1)
                cmd.Parameters.AddWithValue("@Reserva2", ValorReserva2)
                cmd.Parameters.AddWithValue("@Reserva3", ValorReserva3)
                cmd.Parameters.AddWithValue("@FechaModificacion", ValorFechaModificacion)
                cmd.Parameters.AddWithValue("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
            End If

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en BD.spCargaNecesidadesJRDetalle" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        dtb.Desconectar()
    End Sub

    Public Sub spDeleteCargaNecesidadesJRDetalle(ByVal ValorCargaNecesidadesJRDetalleID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase)
        dtb.Conectar()
        Try
            Dim cmd As System.Data.SqlClient.SqlCommand = dtb.Comando("DeleteCargaNecesidadesJRDetalle")
            cmd.Parameters.AddWithValue("@DetalleID", ValorCargaNecesidadesJRDetalleID)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MessageBox.Show("Error en BD.spDeleteCargaNecesidadesJRDetalle" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            dtb.Desconectar()
        End Try

    End Sub
#End Region
End Class
