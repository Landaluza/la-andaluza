Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmCausas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboCausas As DBO_Causas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spCausas, MaestroID)
        InitializeComponent()

        dboCausas = New DBO_Causas


        MyBase.newRegForm = New frmEntCausas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboCausas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboCausas = CType(sp, spCausas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboCausas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboCausas)
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
