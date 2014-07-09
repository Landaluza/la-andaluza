Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCausasPartesEnvasado
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboCausasPartesEnvasado As DBO_CausasPartesEnvasado

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCausasPartesEnvasado, MaestroID)
        InitializeComponent()

        dboCausasPartesEnvasado = New DBO_CausasPartesEnvasado


        MyBase.newRegForm = New frmEntCausasPartesEnvasado(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboCausasPartesEnvasado)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCausasPartesEnvasado = CType(sp, spCausasPartesEnvasado).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboCausasPartesEnvasado Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboCausasPartesEnvasado)
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
