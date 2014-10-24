Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAccionesPreventivas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAccionesPreventivas As DBO_AccionesPreventivas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAccionesPreventivas, MaestroID)
        InitializeComponent()

        dboAccionesPreventivas = New DBO_AccionesPreventivas


        MyBase.newRegForm = New frmEntAccionesPreventivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAccionesPreventivas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAccionesPreventivas = CType(sp, spAccionesPreventivas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAccionesPreventivas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAccionesPreventivas)
        Else
            MyBase.EventHandeld = True
            MessageBox.Show("No se pudo recuperar los datos", "Atenci�n", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
