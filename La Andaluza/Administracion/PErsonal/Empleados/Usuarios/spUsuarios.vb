Imports BasesParaCompatibilidad.ComboBoxExtension


Public Class spUsuarios
    Inherits BasesParaCompatibilidad.StoredProcedure

    Public Sub New()
        MyBase.New("[dbo].[UsuariosSelect]", _
                        "[dbo].[UsuariosInsert]", _
                        "[dbo].[UsuariosUpdate]", _
                        "[dbo].[UsuariosDelete]", _
                        "[dbo].[UsuariosSelectDgv]", _
                        "[dbo].[UsuariosSelectDgvBy]")
    End Sub

    Public Overloads Function Select_Record(ByVal UsuarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Usuarios
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("UsuarioID")
        dbo.searchKey.value = UsuarioID
        MyBase.Select_Record(dbo, dtb)
        Return dbo
    End Function

    Public Overrides Function Delete(ByVal UsuarioID As Int32, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("UsuarioID")
        dbo.searchKey.value = UsuarioID
        Return MyBase.DeleteProcedure(dbo, dtb)
    End Function

    Public Sub cargar_Usuarios(ByRef cbo As ComboBox, ByRef dtb As BasesParaCompatibilidad.DataBase)
        cbo.mam_DataSource("UsuariosCbo", False, dtb)
    End Sub

    Public Function CambiarContraseña(ByVal usuarioid As Integer, ByVal oldPass As String, ByVal newPass As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        dtb.Conectar()
        Dim updateCommand As System.Data.SqlClient.SqlCommand = dtb.Comando("[dbo].[UsuariosupdateCriptedPassword]")
        'Dim connection As System.Data.SqlClient.SqlConnection  = Me.dtb.Conexion
        'Dim updateProcedure As String = "[dbo].[UsuariosupdateCriptedPassword]"
        'Dim updateCommand As  System.Data.SqlClient.SqlCommand = dtb.comando(updateProcedure)
        updateCommand.CommandType = CommandType.StoredProcedure
        updateCommand.Parameters.AddWithValue("@UsuarioId", usuarioid)
        updateCommand.Parameters.AddWithValue("@criptedPass", newPass)
        updateCommand.Parameters.AddWithValue("@actualPass", oldPass)

        Try
            updateCommand.ExecuteNonQuery()

            Return True
        Catch ex As System.Data.SqlClient.SqlException
            Return False
        Finally
            dtb.Desconectar()
        End Try
    End Function

    Public Function select_record_by_usuario(ByVal usuario As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As DBO_Usuarios
        Dim dbo As New DBO_Usuarios
        dbo.searchKey = dbo.item("Usuario")
        dbo.searchKey.value = usuario
        MyBase.Select_proc(dbo, "UsuariosSelectByUsuario", dtb)
        Return dbo
    End Function

    Public Function autentificar(ByVal login As String, ByVal pass As String, ByRef dtb As BasesParaCompatibilidad.DataBase) As Boolean
        Dim dbo As DBO_Usuarios
        Dim dt As DataTable
        Dim spTiposUsuarios As New spTiposUsuarios

        Try
            dtb.PrepararConsulta("UsuariosValidar @login, @pass")
            dtb.AñadirParametroConsulta("@login", login)
            dtb.AñadirParametroConsulta("@pass", pass)
            dt = dtb.Consultar

            If dt.Rows(0).Item(0) > 0 Then
                dbo = select_record_by_usuario(login, dtb)

                BasesParaCompatibilidad.Config.User = dbo.ID
                Config.UserType = dbo.TipoUsuarioID
                Envasado.Config.UserType = dbo.TipoUsuarioID

                Config.dataFillNotificaction = False
                dtb.PrepararConsulta("select id from empleados where id_usuario= @id")
                dtb.AñadirParametroConsulta("@id", BasesParaCompatibilidad.Config.User)
                Config.Worker = dtb.Consultar().Rows(0).Item(0)

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function
End Class
