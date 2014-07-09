Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Runtime.InteropServices

''' <summary>
''' EventArgs class for Progress
''' </summary>
Public Class ProgressEventArgs
    Inherits EventArgs
    Private ReadOnly _progress As Integer = 0

    Public Sub New(ByVal progress As Integer)
        _progress = progress
    End Sub

    'Properties.
    Public ReadOnly Property Progress() As Integer
        Get
            Return _progress
        End Get
    End Property
End Class

Public Class cFileCopy
    Public Event Progress As ProgressEventHandler

    'http://www.pinvoke.net/default.aspx/kernel32.CopyFileEx
    <DllImport("kernel32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function CopyFileEx(ByVal lpExistingFileName As String, ByVal lpNewFileName As String, ByVal lpProgressRoutine As CopyProgressRoutine, ByVal lpData As IntPtr, ByRef pbCancel As Int32, ByVal dwCopyFlags As CopyFileFlags) As <MarshalAs(UnmanagedType.Bool)> Boolean
    End Function

    Private Delegate Function CopyProgressRoutine(ByVal TotalFileSize As Long, ByVal TotalBytesTransferred As Long, ByVal StreamSize As Long, ByVal StreamBytesTransferred As Long, ByVal dwStreamNumber As UInteger, ByVal dwCallbackReason As CopyProgressCallbackReason, _
     ByVal hSourceFile As IntPtr, ByVal hDestinationFile As IntPtr, ByVal lpData As IntPtr) As CopyProgressResult

    Private pbCancel As Integer

    Private Enum CopyProgressResult As UInteger
        PROGRESS_CONTINUE = 0
        PROGRESS_CANCEL = 1
        PROGRESS_STOP = 2
        PROGRESS_QUIET = 3
    End Enum

    Private Enum CopyProgressCallbackReason As UInteger
        CALLBACK_CHUNK_FINISHED = &H0
        CALLBACK_STREAM_SWITCH = &H1
    End Enum

    <Flags()> _
    Private Enum CopyFileFlags As UInteger
        COPY_FILE_FAIL_IF_EXISTS = &H1
        COPY_FILE_RESTARTABLE = &H2
        COPY_FILE_OPEN_SOURCE_FOR_WRITE = &H4
        COPY_FILE_ALLOW_DECRYPTED_DESTINATION = &H8
    End Enum

    Public Sub XCopy(ByVal oldFile As String, ByVal newFile As String)
        CopyFileEx(oldFile, newFile, New CopyProgressRoutine(AddressOf Me.CopyProgressHandler), IntPtr.Zero, pbCancel, CopyFileFlags.COPY_FILE_RESTARTABLE)
    End Sub

    Private Function CopyProgressHandler(ByVal total As Long, ByVal transferred As Long, ByVal streamSize As Long, ByVal StreamByteTrans As Long, ByVal dwStreamNumber As UInteger, ByVal reason As CopyProgressCallbackReason, _
     ByVal hSourceFile As IntPtr, ByVal hDestinationFile As IntPtr, ByVal lpData As IntPtr) As CopyProgressResult
        'calculate progress
        Dim iProgress As Integer
        iProgress = Convert.ToInt32(Math.Truncate((CSng(transferred) / CSng(total)) * 100))
        RaiseEvent Progress(Me, New ProgressEventArgs(iProgress))
        Return CopyProgressResult.PROGRESS_CONTINUE
    End Function


End Class
