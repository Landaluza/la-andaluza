Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmUsuarios
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboUsuarios As DBO_Usuarios

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spUsuarios, MaestroID)
        InitializeComponent()

        dboUsuarios = New DBO_Usuarios


        MyBase.newRegForm = New frmEntUsuarios(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboUsuarios)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboUsuarios = CType(sp, spUsuarios).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboUsuarios Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboUsuarios)
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
                .FormatoColumna("Usuario", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("email", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
