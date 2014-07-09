Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMaquinas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboMaquinas As DBO_Maquinas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMaquinas, MaestroID)
        InitializeComponent()

        dboMaquinas = New DBO_Maquinas


        MyBase.newRegForm = New frmEntMaquinas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboMaquinas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboMaquinas = CType(sp, spMaquinas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboMaquinas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboMaquinas)
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

            End With
        End If



    End Sub

End Class
