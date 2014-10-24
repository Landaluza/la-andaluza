Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmArticulosMinMax
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboArticulosMinMax As DBO_ArticulosMinMax

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spArticulosMinMax, MaestroID)
        InitializeComponent()


        dboArticulosMinMax = New DBO_ArticulosMinMax

        MyBase.newRegForm = CType(New frmEntArticulosMinMax(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboArticulosMinMax, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboArticulosMinMax = CType(sp, spArticulosMinMax).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboArticulosMinMax Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboArticulosMinMax, BasesParaCompatibilidad.DataBussines))
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
                .FormatoColumna("DescripcionLA", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("MinimoJR", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("MaximoJR", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("MinimoLA", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("MaximoLA", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("MinimoProveedor", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("MaximoProveedor", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaFinal", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
