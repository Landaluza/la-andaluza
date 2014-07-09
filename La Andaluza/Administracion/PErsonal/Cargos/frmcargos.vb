Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmcargos
    Inherits BasesParaCompatibilidad.gridsimpleform


    Private dbocargos As DBO_cargos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spcargos, MaestroID)
        InitializeComponent()

        dbocargos = New DBO_cargos


        MyBase.newRegForm = New frmEntcargos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub




    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dbocargos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dbocargos = CType(sp, spcargos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value)
        If Not dbocargos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dbocargos)
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
                .FormatoColumna("nombre", BasesParaCompatibilidad.TiposColumna.Izquierda, True)
                .FormatoColumna("observaciones", BasesParaCompatibilidad.TiposColumna.Izquierda, True)

            End With
        End If



    End Sub

End Class
