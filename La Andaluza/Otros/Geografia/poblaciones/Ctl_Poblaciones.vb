Public Class Ctl_Poblaciones

    Private sp_poblaciones As spPoblaciones

    Public ReadOnly Property spPoblaciones As spPoblaciones
        Get
            Return sp_poblaciones
        End Get
    End Property

    Public Sub New()
        Me.sp_poblaciones = New spPoblaciones
    End Sub

    Public Sub Añadir_poblacion_para_combo(ByRef combo As ComboBox, ByVal id_provincia As Integer)
        Dim dboPoblacion As New DBO_Poblaciones
        dboPoblacion.Id_provincia = id_provincia

        Dim frm As New frmEntPoblaciones(BasesParaCompatibilidad.DetailedSimpleForm.VISION, New spPoblaciones, dboPoblacion)
        frm.ShowDialog()

        Try
            sp_poblaciones.cargar_ComboBox(combo, id_provincia)
        Catch ex As Exception
        End Try
    End Sub
End Class
