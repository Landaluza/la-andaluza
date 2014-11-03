Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmUnidadesMedidas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboUnidadesMedidas As DBO_UnidadesMedidas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spUnidadesMedidas, MaestroID)
        InitializeComponent()

        dboUnidadesMedidas = New DBO_UnidadesMedidas


        MyBase.newRegForm = New frmEntUnidadesMedidas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboUnidadesMedidas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboUnidadesMedidas = CType(sp, spUnidadesMedidas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboUnidadesMedidas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboUnidadesMedidas)
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
                .FormatoColumna("Abreviatura", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If
    End Sub

End Class
