

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
    Public Function spCargaNecesidadesJRMaestro(ByVal Action As Integer, _
                                           ByVal ValorMaestroID As Integer, _
                                           ByVal ValorFecha As Date, _
                                           ByVal ValorHora As Date, _
                                           ByVal ValorObservaciones As String, _
                                           ByVal ValorFechaModificacion As Date, _
                                           ByVal ValorUsuarioModificacion As Integer, _
                                           ByVal ValorServido As Boolean, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Try

            'Dim cmd As System.Data.SqlClient.SqlCommand

            If Action = _Insert Then
                dtb.PrepararConsulta("InsertCargaNecesidadesJRMaestro @Fecha , @Hora , @Observaciones , @FechaModificacion , @UsuarioModificacion , @Servido")
            ElseIf Action = _Update Then
                dtb.PrepararConsulta("UpdateCargaNecesidadesJRMaestro @MaestroID , @Fecha , @Hora , @Observaciones , @FechaModificacion , @UsuarioModificacion , @Servido")
                dtb.AñadirParametroConsulta("@MaestroID", ValorMaestroID)
            Else : Action = _Delete
                dtb.PrepararConsulta("DeleteCargaNecesidadesJRMaestro @MaestroID")
                dtb.AñadirParametroConsulta("@MaestroID", ValorMaestroID)
            End If

            If Action = _Insert Or Action = _Update Then
                dtb.AñadirParametroConsulta("@Fecha", ValorFecha)
                dtb.AñadirParametroConsulta("@Hora", ValorHora)
                dtb.AñadirParametroConsulta("@Observaciones", ValorObservaciones)
                dtb.AñadirParametroConsulta("@FechaModificacion", ValorFechaModificacion)
                dtb.AñadirParametroConsulta("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
                dtb.AñadirParametroConsulta("@Servido", ValorServido)
            End If

            'cmd.ExecuteNonQuery()
            Return dtb.Consultar(True)

        Catch ex As Exception
            MessageBox.Show("Error en BD.spCargaNecesidadesJRMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function spDeleteCargaNecesidadesJRMaestro(ByVal ValorMaestroID As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Try
            dtb.PrepararConsulta("DeleteCargaNecesidadesJRMaestro @MaestroID")

            dtb.AñadirParametroConsulta("@MaestroID", ValorMaestroID)
            Return dtb.Consultar(True)
        Catch ex As Exception
            MessageBox.Show("Error en BD.spDeleteCargaNecesidadesJRMaestro" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function spMaxCargaNecesidadesMaestro(ByRef dtb As BasesParaCompatibilidad.DataBase) As Integer
        Dim MaxID As Integer = 0
        dtb.Conectar()
        Try
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

    Public Function spCargaNecesidadesJRDetalle(ByVal Action As Integer, _
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
                                           ByVal ValorUsuarioModificacion As Integer, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean


        dtb.Conectar()
        Try
            'Dim cmd As System.Data.SqlClient.SqlCommand

            If Action = _Insert Then
                dtb.PrepararConsulta("InsertCargaNecesidadesJRDetalle @CargaNecesidadesJRMaestroID , @ArticuloID , @Carga , @Stock , @Observaciones , @Reserva1 , @Reserva2 , @Reserva3 , @FechaModificacion , @UsuarioModificacion")
            ElseIf Action = _Update Then
                dtb.PrepararConsulta("UpdateCargaNecesidadesJRDetalle  @CargaNecesidadesJRDetalleID, @CargaNecesidadesJRMaestroID , @ArticuloID , @Carga , @Stock , @Observaciones , @Reserva1 , @Reserva2 , @Reserva3 , @FechaModificacion , @UsuarioModificacion")
                dtb.AñadirParametroConsulta("@CargaNecesidadesJRDetalleID", ValorCargaNecesidadesJRDetalleID)
            Else : Action = _Delete
                dtb.PrepararConsulta("DeleteCargaNecesidadesJRDetalle @DetalleID")
                dtb.AñadirParametroConsulta("@DetalleID", ValorCargaNecesidadesJRDetalleID)
            End If

            If Action = _Insert Or Action = _Update Then
                dtb.AñadirParametroConsulta("@CargaNecesidadesJRMaestroID", ValorCargaNecesidadesJRMaestroID)
                dtb.AñadirParametroConsulta("@ArticuloID", ValorArticuloID)
                dtb.AñadirParametroConsulta("@Carga ", ValorCarga)
                dtb.AñadirParametroConsulta("@Stock", ValorStock)
                dtb.AñadirParametroConsulta("@Observaciones", ValorObservaciones)
                dtb.AñadirParametroConsulta("@Reserva1", ValorReserva1)
                dtb.AñadirParametroConsulta("@Reserva2", ValorReserva2)
                dtb.AñadirParametroConsulta("@Reserva3", ValorReserva3)
                dtb.AñadirParametroConsulta("@FechaModificacion", ValorFechaModificacion)
                dtb.AñadirParametroConsulta("@UsuarioModificacion", BasesParaCompatibilidad.Config.User)
            End If

            Return dtb.Consultar(True)
        Catch ex As Exception
            MessageBox.Show("Error en BD.spCargaNecesidadesJRDetalle" & Environment.NewLine & Environment.NewLine & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        Finally
            dtb.Desconectar()
        End Try

    End Function

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
