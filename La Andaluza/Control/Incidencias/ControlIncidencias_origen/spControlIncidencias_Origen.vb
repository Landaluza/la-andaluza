Public Class spControlIncidencias_Origen
    Private m_DataGridViewStoredProcedure As String

    Public ReadOnly Property DataGridViewStoredProcedure As String
        Get
            Return Me.m_DataGridViewStoredProcedure
        End Get
    End Property

    Public Sub New(ByVal maestroID As Integer)
        m_DataGridViewStoredProcedure= "ControlIncidencias_OrigenSelectDgvBy " & maestroID
    End Sub
End Class
