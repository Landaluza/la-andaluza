Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmLugaresEntregas
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboLugaresEntregas As DBO_LugaresEntregas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spLugaresEntregas, MaestroID)
        InitializeComponent()

        dboLugaresEntregas = New DBO_LugaresEntregas


        MyBase.newRegForm = CType(New frmEntLugaresEntregas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboLugaresEntregas, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboLugaresEntregas = CType(sp, spLugaresEntregas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboLugaresEntregas Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboLugaresEntregas, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
