Public Class frmPersonalEnvasadoOcupado
    Private envasado As Integer
    Private dtb As BasesParaCompatibilidad.DataBase
    Public Sub New(ByVal envasado As Integer)

        ' This call is required by the designer.
        InitializeComponent()
        dtb = New BasesParaCompatibilidad.DataBase
        Me.envasado = envasado

    End Sub
    Private Sub cargar()
        Dim dtOcupados As DataTable
        Dim spEmlpeados As New spEmpleados
        DgvOcupados.Rows.Clear()

        dtOcupados = spEmlpeados.devolver_Empleados_Envasados_ocupados(envasado, dtb)

        For Each row As DataRow In dtOcupados.Rows
            DgvOcupados.Rows.Add(New String() {row(1), row(0), row(2), row(3), row(4)})
        Next
    End Sub

    Private Sub frmPersonalEnvasadoOcupado_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        cargar()
    End Sub

    Private Sub btnRefresh_Click(sender As System.Object, e As System.EventArgs) Handles btnRefresh.Click
        cargar()
    End Sub
End Class