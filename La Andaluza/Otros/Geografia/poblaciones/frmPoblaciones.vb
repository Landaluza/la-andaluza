Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmPoblaciones
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboPoblaciones As DBO_Poblaciones

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spPoblaciones, MaestroID)
        InitializeComponent()

        dboPoblaciones = New DBO_Poblaciones


        MyBase.newRegForm = New frmEntPoblaciones(ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        If m_MaestroID <> 0 Then dboPoblaciones.Id_provincia = m_MaestroID
        newRegForm.SetDataBussinesObject(Me.dboPoblaciones)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboPoblaciones = CType(sp, spPoblaciones).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboPoblaciones Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboPoblaciones)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
    End Sub

    Protected Overrides Sub BindDataSource()
        GeneralBindingSource.DataSource = dataSource ' DataTableFill(Me.sp.DataGridViewStoredProcedure)

        If Not GeneralBindingSource.DataSource Is Nothing Then
            With dgvGeneral
                .DataSource = GeneralBindingSource
                .Columns("Id").Visible = False
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
