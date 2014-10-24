Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProgramasActividadesPreventivas
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboProgramasActividadesPreventivas As DBO_ProgramasActividadesPreventivas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProgramasActividadesPreventivas, MaestroID)
        InitializeComponent()

        dboProgramasActividadesPreventivas = New DBO_ProgramasActividadesPreventivas


        MyBase.newRegForm = New frmEntProgramasActividadesPreventivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboProgramasActividadesPreventivas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboProgramasActividadesPreventivas = CType(sp, spProgramasActividadesPreventivas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboProgramasActividadesPreventivas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboProgramasActividadesPreventivas)
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
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("FechaFinal", BasesParaCompatibilidad.TiposColumna.FechaCorta, 90)
                .FormatoColumna("Autor", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
