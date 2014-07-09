Imports BasesParaCompatibilidad.DataGridViewExtension
Public Class frmAlturas
    Inherits BasesParaCompatibilidad.gridsimpleform

    Private dboAlturas As DBO_Alturas

    Public Sub New(Optional ByVal MaestroID As Integer = 0)
        MyBase.New(New spAlturas, MaestroID)
        InitializeComponent()

        dboAlturas = New DBO_Alturas


        MyBase.newRegForm = CType(New frmEntAlturas(BasesParaCompatibilidad.gridsimpleform.ACCION_INSERTAR, sp), BasesParaCompatibilidad.DetailedSimpleForm)
    End Sub



    Private Sub Insert_Before() Handles MyBase.BeforeInsert
        newRegForm.SetDataBussinesObject(CType(Me.dboAlturas, BasesParaCompatibilidad.DataBussines))
    End Sub

    Private Sub modify_Before() Handles MyBase.BeforeModify
        dboAlturas = CType(sp, spAlturas).Select_Record(CType(dgvGeneral.CurrentRow.Cells("Id").Value, Integer))
        If Not dboAlturas Is Nothing Then
            newRegForm.SetDataBussinesObject(CType(Me.dboAlturas, BasesParaCompatibilidad.DataBussines))
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
