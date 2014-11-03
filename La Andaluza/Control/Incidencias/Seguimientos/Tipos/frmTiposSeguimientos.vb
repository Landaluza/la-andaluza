Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmTiposSeguimientos
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboTiposSeguimientos As DBO_TiposSeguimientos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spTiposSeguimientos, MaestroID)
        InitializeComponent()

        dboTiposSeguimientos = New DBO_TiposSeguimientos


        MyBase.newRegForm = New frmEntTiposSeguimientos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboTiposSeguimientos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboTiposSeguimientos = CType(sp, spTiposSeguimientos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboTiposSeguimientos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboTiposSeguimientos)
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
