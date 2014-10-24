Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmtiposEnvases
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dbotiposEnvases As DBO_tiposEnvases

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New sptiposEnvases, MaestroID)
        InitializeComponent()
        dbotiposEnvases = New DBO_tiposEnvases


        MyBase.newRegForm = CType(New frmEnttiposEnvases(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dbotiposEnvases, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dbotiposEnvases = CType(sp, sptiposEnvases).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dbotiposEnvases Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dbotiposEnvases, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
