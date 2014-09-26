Public Class Ctl_Provincias
    Private sp_provincias As spProvincias

    Public ReadOnly Property spProvincias As spProvincias
        Get
            Return sp_provincias
        End Get
    End Property


    Public Sub New()
        Me.sp_provincias = New spProvincias
    End Sub

    Public Sub Añadir_provincias_para_combo(ByRef comboProvincias As ComboBox, ByVal id_pais As Integer)
        Dim dboProvincia As New DBO_Provincias
        dboProvincia.Id_pais = id_pais

        Dim frm As New frmEntProvincias(BasesParaCompatibilidad.DetailedSimpleForm.VISION, New spProvincias, dboProvincia)
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)
        Try
            Me.sp_provincias.cargar_ComboBox(comboProvincias, id_pais)
        Catch ex As Exception
        End Try
    End Sub
End Class
