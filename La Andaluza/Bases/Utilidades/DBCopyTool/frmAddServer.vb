Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms

Public Class frmAddServer
    Private _sServername As String

    Public Sub New()
        InitializeComponent()
    End Sub

    Public ReadOnly Property Servername() As String
        Get
            Return _sServername
        End Get
    End Property

    Private Sub btnCancel_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnCancel.Click
        DialogResult = DialogResult.Cancel
    End Sub

    Private Sub btnAddServer_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAddServer.Click
        If txtServername.Text = "" Then
            MessageBox.Show("Please specify a servername/Ip...", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
        Else
            _sServername = txtServername.Text
            DialogResult = DialogResult.OK
        End If
    End Sub

End Class