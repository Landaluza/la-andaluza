Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmMedidasProductos
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboMedidasProductos As DBO_MedidasProductos

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spMedidasProductos, MaestroID)
        InitializeComponent()

        dboMedidasProductos = New DBO_MedidasProductos


        MyBase.newRegForm = New frmEntMedidasProductos(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp)
    End Sub

    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(Me.dboMedidasProductos)
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        Dim dtb As New BasesParaCompatibilidad.DataBase
        dboMedidasProductos = CType(sp, spMedidasProductos).Select_Record(dgvGeneral.CurrentRow.Cells("Id").Value, dtb)
        If Not dboMedidasProductos Is Nothing Then
            newRegForm.SetDataBussinesObject(Me.dboMedidasProductos)
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
