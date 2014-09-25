Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmEmpleados_LineasEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboEmpleados_LineasEnvasado As DBO_Empleados_LineasEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spEmpleados_LineasEnvasado, MaestroID)
        InitializeComponent()

        dboEmpleados_LineasEnvasado = New DBO_Empleados_LineasEnvasado


        MyBase.newRegForm = New frmEntEmpleados_LineasEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        dboEmpleados_LineasEnvasado = New DBO_Empleados_LineasEnvasado
        If m_MaestroID <> 0 Then dboEmpleados_LineasEnvasado.Id_LineaEnvasado = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboEmpleados_LineasEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboEmpleados_LineasEnvasado = CType(sp, spEmpleados_LineasEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboEmpleados_LineasEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboEmpleados_LineasEnvasado)
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
                .Columns("Linea").Visible = False
                .FormatoColumna("Empleado", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
