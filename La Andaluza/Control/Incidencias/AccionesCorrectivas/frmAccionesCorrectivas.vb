Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAccionesCorrectivas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAccionesCorrectivas As DBO_AccionesCorrectivas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAccionesCorrectivas, MaestroID)
        InitializeComponent()

        dboAccionesCorrectivas = New DBO_AccionesCorrectivas


        MyBase.newRegForm = New frmEntAccionesCorrectivas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAccionesCorrectivas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAccionesCorrectivas = CType(sp, spAccionesCorrectivas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboAccionesCorrectivas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAccionesCorrectivas)
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
                .FormatoColumna("Descripcion", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("Observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
