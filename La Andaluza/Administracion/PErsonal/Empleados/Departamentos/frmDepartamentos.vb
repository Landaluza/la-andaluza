Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmDepartamentos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboDepartamentos As DBO_Departamentos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spDepartamentos, MaestroID)
        InitializeComponent()

        dboDepartamentos = New DBO_Departamentos


        MyBase.newRegForm = New frmEntDepartamentos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub


    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboDepartamentos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboDepartamentos = CType(sp, spDepartamentos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboDepartamentos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboDepartamentos)
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
