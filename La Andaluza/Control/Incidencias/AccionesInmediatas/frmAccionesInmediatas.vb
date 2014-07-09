Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAccionesInmediatas
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dboAccionesInmediatas As DBO_AccionesInmediatas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAccionesInmediatas, MaestroID)
        InitializeComponent()

        dboAccionesInmediatas = New DBO_AccionesInmediatas


        MyBase.newRegForm = New frmEntAccionesInmediatas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboAccionesInmediatas)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAccionesInmediatas = CType(sp, spAccionesInmediatas).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dboAccionesInmediatas Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboAccionesInmediatas)
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
