Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmProcedimientos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboProcedimientos As DBO_Procedimientos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spProcedimientos, MaestroID)
        InitializeComponent()

        dboProcedimientos = New DBO_Procedimientos


        MyBase.newRegForm = CType(New frmEntProcedimientos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboProcedimientos = New DBO_Procedimientos
        newRegForm.SetDataBussinesObject(CType(Me.dboProcedimientos, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboProcedimientos = CType(sp, spProcedimientos).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer), dtb)
        If Not dboProcedimientos Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboProcedimientos, BasesParaCompatibilidad.DataBussines))
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
                .FormatoColumna("Ruta", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("N_version", BasesParaCompatibilidad.TiposColumna.Miles, 50)
                .FormatoColumna("Codigo", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If

    End Sub

End Class
