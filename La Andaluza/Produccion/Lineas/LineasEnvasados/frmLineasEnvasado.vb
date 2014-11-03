Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmLineasEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform



    Private dboLineasEnvasado As DBO_LineasEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spLineasEnvasado, MaestroID)
        InitializeComponent()

        dboLineasEnvasado = New DBO_LineasEnvasado


        MyBase.newRegForm = New frmEntLineasEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboLineasEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboLineasEnvasado = CType(sp, spLineasEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboLineasEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboLineasEnvasado)
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
                .FormatoColumna("VelocidadMaxima", BasesParaCompatibilidad.TiposColumna.Miles, 100)

            End With
        End If

    End Sub

End Class
