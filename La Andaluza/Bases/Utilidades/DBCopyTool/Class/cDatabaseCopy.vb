Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.IO

Public Delegate Sub StepsEventHandler(ByVal sender As Object, ByVal e As StepsEventArgs)

Public Class StepsEventArgs
    Inherits EventArgs
    Private ReadOnly _step As Steps = 0

    Public Sub New(ByVal [step] As Steps)
        _step = [step]
    End Sub

    'Properties.
    Public ReadOnly Property [Step]() As Steps
        Get
            Return _step
        End Get
    End Property
End Class

Public Enum Steps As UInteger
    IDLE = 0
    BACKUP = 1
    COPY = 2
    RESTORE = 3
    [ERROR] = 4
End Enum

Class cDatabaseCopy
    Public Event Progress As ProgressEventHandler
    Public Event StepChanged As StepsEventHandler

    Private Sub OperationProgress(ByVal sender As Object, ByVal e As ProgressEventArgs)
        RaiseEvent Progress(Me, New ProgressEventArgs(e.Progress))
    End Sub

    Public Sub CopyDatabase(ByVal sSourceBackupDir As String, ByVal sSourceDatabase As String, ByVal sDestDatabase As String, ByVal sDestDir As String, ByVal sDestBackupDir As String, ByVal sDestLogDir As String, _
     ByVal sSourceServer As String, ByVal sDestServer As String, ByVal sSourceServerUsername As String, ByVal sSourceServerPassword As String, ByVal bSourceServerUseIntegratedSecurity As Boolean, ByVal sDestServerUsername As String, _
     ByVal sDestServerPassword As String, ByVal bDestServerUseIntegratedSecurity As Boolean)
        'create paths            
        Dim sDatabaseBackupFile As String = sSourceBackupDir & sSourceDatabase & "_CopyTool.bak"
        Dim sDatabaseRestoreFile As String = sDestBackupDir & sSourceDatabase & "_CopyTool.bak"

        Dim sUncSourceFile As String = cHelper.MakeUncPath(sDatabaseBackupFile, sSourceServer)
        Dim sUncDestFile As String = cHelper.MakeUncPath(sDatabaseRestoreFile, sDestServer)

        'delete old backup if exists
        cHelper.DeleteFileIfExists(sUncSourceFile)

        'backp the database            
        RaiseEvent StepChanged(Me, New StepsEventArgs(Steps.BACKUP))
        Dim dbBackup As New cDatabaseHelper(sSourceServer, bSourceServerUseIntegratedSecurity, sSourceServerUsername, sSourceServerPassword, sSourceDatabase)

        'dbBackup.Progress += New ProgressEventHandler(AddressOf OperationProgress)
        dbBackup.BackupDatabase(sDatabaseBackupFile)

        'delete old backup if exists
        RaiseEvent StepChanged(Me, New StepsEventArgs(Steps.COPY))
        'cHelper.DeleteFileIfExists(sUncDestFile);

        'copy File
        Dim c As New cFileCopy()
        'c.Progress += New ProgressEventHandler(AddressOf OperationProgress)
        c.XCopy(sUncSourceFile, sUncDestFile)

        'restore the database
        RaiseEvent StepChanged(Me, New StepsEventArgs(Steps.RESTORE))
        Dim dbRestore As New cDatabaseHelper(sDestServer, bDestServerUseIntegratedSecurity, sDestServerUsername, sDestServerPassword, "master")
        'dbRestore.Progress += New ProgressEventHandler(AddressOf OperationProgress)
        dbRestore.RestoreDatabase(sDestDatabase, sDatabaseRestoreFile, sDestDir, sDestLogDir)

        'cleanup

        Try
            IO.File.Delete(sUncSourceFile)
            IO.File.Delete(sUncDestFile)
        Catch ex As Exception
            Throw New Exception("Couldn't delete file. " & sUncDestFile & " " & ex.Message)
        End Try

        RaiseEvent StepChanged(Me, New StepsEventArgs(Steps.IDLE))
    End Sub
End Class
