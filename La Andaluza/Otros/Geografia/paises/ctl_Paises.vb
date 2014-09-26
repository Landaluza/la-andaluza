Public Class ctl_Paises
    Private sp_paises As spPaises

    Public ReadOnly Property spPaises As spPaises
        Get
            Return sp_paises
        End Get
    End Property

    Public Sub New()
        Me.sp_paises = New spPaises
    End Sub

    Public Sub Añadir_pais_para_combo(ByRef combo As ComboBox)
        Dim frm As New frmEntPaises
        BasesParaCompatibilidad.Pantalla.mostrarDialogo(frm)

        Me.sp_paises.cargar_ComboBox(combo)
    End Sub
End Class
