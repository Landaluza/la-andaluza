Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCostesAnuales_Empleados
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboCostesAnuales_Empleados As DBO_CostesAnuales_Empleados

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCostesAnuales_Empleados, MaestroID)
        InitializeComponent()

        dboCostesAnuales_Empleados = New DBO_CostesAnuales_Empleados


        MyBase.newRegForm = New frmEntCostesAnuales_Empleados(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboCostesAnuales_Empleados = New DBO_CostesAnuales_Empleados
        If m_MaestroID <> 0 Then dboCostesAnuales_Empleados.Id_empleado = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboCostesAnuales_Empleados)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCostesAnuales_Empleados = CType(sp, spCostesAnuales_Empleados).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboCostesAnuales_Empleados Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboCostesAnuales_Empleados)
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
                .FormatoColumna("FechaInicio", BasesParaCompatibilidad.TiposColumna.FechaCorta, True)
                .FormatoColumna("Normal", BasesParaCompatibilidad.TiposColumna.Double2, True)
                .FormatoColumna("Extra", BasesParaCompatibilidad.TiposColumna.Double2, True)
                .FormatoColumna("Festivo", BasesParaCompatibilidad.TiposColumna.Double2, True)
                .FormatoColumna("Turno", BasesParaCompatibilidad.TiposColumna.Double2, True)
                .FormatoColumna("Nocturnidad", BasesParaCompatibilidad.TiposColumna.Double2, True)

            End With
        End If



    End Sub

End Class
