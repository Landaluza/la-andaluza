Imports System.Deployment.Application

Public Class Updater
    Private aplazar As Integer

    Public Sub New()
        aplazar = 0
    End Sub
    Public Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing

        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                MessageBox.Show("No se puede descargar la nueva version de la aplicación. " + ControlChars.Lf & ControlChars.Lf & "Comprueba la conexión de internet o vuelve a intentarlo más tarde. Error: " + dde.Message)
                Return
            Catch ioe As InvalidOperationException
                MessageBox.Show("No se puede actualizar la aplicación. Error de configuracion en las actualizaciones. Error: " & ioe.Message)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Dim dr As DialogResult = MessageBox.Show("Hay una actualización disponible, estas actualizaciones pueden corregir fallos del sistema o en la seguridad. Actualizar ahora?", "Actualización disponible", MessageBoxButtons.OKCancel)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    If aplazar = 0 Then
                        Dim dr As DialogResult = MessageBox.Show("Se ha detectado una actualizacion obligatoria, desea actualizar ahora?" & Environment.NewLine & "(Si pulsa Cancelar se pospondra la actualización 5 minutos)", "Actualización obligatoria disponible", MessageBoxButtons.YesNo)
                        If (Not System.Windows.Forms.DialogResult.No = dr) Then
                            doUpdate = False
                            aplazar = 1
                        End If
                    Else
                        ' Display a message that the app MUST reboot. Display the minimum required version.
                        aplazar = 0
                        MessageBox.Show("Se ha detectado una actualización obligatoria " & _
                            "a la versión " & info.MinimumRequiredVersion.ToString() & _
                            ". Se instalará la actualización y luego se reiniciará la aplicacion automaticamente.", _
                            "Actualización disponible", MessageBoxButtons.OK, _
                            MessageBoxIcon.Information)

                    End If
                    
                End If

                If (doUpdate) Then
                    Try
                        AD.Update()
                        MessageBox.Show("Se ha instalado una actualización, la aplicación se reiniciara ahora.")
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        MessageBox.Show("No se pudo instalar la ultima version de la aplicacion. " & ControlChars.Lf & ControlChars.Lf & "Por favor comprueba tu conexion de red o vuelve a intentarlo mas tarde.")
                        Return
                    End Try
                End If
            End If
        End If
    End Sub
End Class
