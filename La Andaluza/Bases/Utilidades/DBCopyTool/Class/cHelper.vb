Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Data.Sql
Imports System.Data
Imports System.Net
Imports System.IO

NotInheritable Class cHelper
    Private Sub New()
    End Sub

    Public Shared Function GetServersFromNetwork() As DataTable
        ' Retrieve the enumerator instance and then the data.
        Dim instance As SqlDataSourceEnumerator = SqlDataSourceEnumerator.Instance
        Dim dtInstances As DataTable = instance.GetDataSources()
        Return dtInstances

    End Function


    Public Shared Function CheckFilePathRegex(ByVal sFilepath As String) As Boolean
        'check if dirs are dirs
        Dim reFoldername As New Regex("^[A-Za-z]:\\(.)*(\\)*$")

        If Not reFoldername.IsMatch(sFilepath) OrElse Not sFilepath.EndsWith("\") Then
            Return False
        Else
            Return True
        End If
    End Function

    Public Shared Function MakeUncPath(ByVal sText As String, ByVal sServer As String) As String
        Dim sUncPath As String
        Dim driveLetter As Char
        driveLetter = sText.Substring(0, 1)(0)


        'Comentado por MAM para que no de error, ya que cre nombres de red
        'Tengo que volver a ejecutarlo, de lo contrario no se ejecuta la copia.
        sServer = sServer.Replace(sServer, getIpFromServer(sServer))
        sUncPath = sText.Replace(driveLetter & ":\", "\\" & sServer & "\" & driveLetter & "$\")

        'Añadido por MAM
        'Tengo que comentarlo de lo contrario no se ejecuta la copia.
        'sUncPath = sText


        Return sUncPath
    End Function

    Public Shared Sub DeleteFileIfExists(ByVal sUncFileName As String)
        'Check if file exists and delete..
        If IO.File.Exists(sUncFileName) Then
            IO.File.Delete(sUncFileName)
        End If
    End Sub


    Private Shared Function getIpFromServer(ByVal sServername As String) As String
        If sServername.Contains("\") Then
            sServername = sServername.Substring(0, sServername.IndexOf("\"))
            Dim ip As IPHostEntry = Dns.GetHostEntry(sServername)
            Dim IpA As IPAddress() = ip.AddressList

            Return IpA(0).ToString()
        Else
            'To get a host with a www address
            Dim ip As IPHostEntry = Dns.GetHostEntry(sServername)
            Dim IpA As IPAddress() = ip.AddressList
            Return IpA(0).ToString()
        End If
    End Function

End Class
