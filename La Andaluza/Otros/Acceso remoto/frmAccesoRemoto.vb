Public Class frmAccesoRemoto
    Private sesion As RemoteSession
    Public Sub New(ByVal sesion As RemoteSession)

        InitializeComponent()

        Me.sesion = sesion
    End Sub

    Public WriteOnly Property Session As RemoteSession
        Set(value As RemoteSession)
            desconectar()
            Me.sesion = value
        End Set
    End Property
    Private Sub conectar()
        If rdp.Connected.ToString() = "0" Then
            Try
                Me.Text = sesion.name
                rdp.Server = sesion.Server                
                rdp.Domain = sesion.Domain
                rdp.UserName = sesion.User

                If sesion.Port <> "" Then
                    Dim adv As MSTSCLib.IMsRdpClientAdvancedSettings2 = DirectCast(rdp.AdvancedSettings, MSTSCLib.IMsRdpClientAdvancedSettings2)
                    adv.RDPPort = sesion.Port
                End If

                Dim secured As MSTSCLib.IMsTscNonScriptable = DirectCast(rdp.GetOcx(), MSTSCLib.IMsTscNonScriptable)

                secured.ClearTextPassword = sesion.Password                
                rdp.Connect()
            Catch ex As Exception
                MessageBox.Show(ex.Message, Me.Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Private Sub desconectar()
        If Not rdp Is Nothing Then
            If rdp.Connected.ToString() = "1" Then
                rdp.Disconnect()
            End If
        End If
    End Sub

    Private Sub frmAccesoRemoto_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        conectar()
    End Sub

    Private Sub frmAccesoRemoto_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        desconectar()
    End Sub
End Class