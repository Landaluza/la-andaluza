Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDDDPlanes
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboDDDPlanes As DBO_DDDPlanes

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDDDPlanes, MaestroID)
        InitializeComponent()

        dboDDDPlanes = New DBO_DDDPlanes


        MyBase.newRegForm = New frmEntDDDPlanes(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDDDPlanes)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboDDDPlanes = CType(sp, spDDDPlanes).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDDDPlanes Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDDDPlanes)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()

        If Not dataSource Is Nothing Then
            GeneralBindingSource.DataSource = dataSource
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
